using OpenTK.Platform;
using OpenTK.Graphics.Vulkan;
using System;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VulkanTestProject
{
    internal class Program
    {
        static WindowHandle Window;

        static VkInstance VulkanInstance;
        static VkPhysicalDevice PhysicalDevice;
        static VkDevice Device;
        static DeviceDispatchTable DeviceFunctions;
        static VkSurfaceKHR Surface;

        static VkQueue GraphicsQueue;
        static VkQueue PresentQueue;
        static VkRenderPass RenderPass;
        static VkCommandPool CommandPool;
        static VkCommandBuffer CommandBuffer;

        static VkPipelineLayout PipelineLayout;
        static VkPipeline Pipeline;

        static bool FramebufferHasNewSize = false;
        static VkExtent2D SwapchainExtents;
        static VkSurfaceFormatKHR SwapchainFormat;
        static VkSwapchainKHR Swapchain;
        static VkImageView[] SwapchainImageViews;
        static VkFramebuffer[] SwapchainFramebuffers;

        static VkSemaphore ImageAvailableSemaphore;
        static VkSemaphore RenderFinishedSemaphore;
        static VkFence InFlightFence;

        static unsafe void Main(string[] args)
        {
            VKLoader.Init();

            ToolkitOptions options = new ToolkitOptions() { ApplicationName = "PAL2 Vulkan test app", Logger = new ConsoleLogger(), FeatureFlags = ToolkitFlags.EnableVulkan };
            Toolkit.Init(options);

            EventQueue.EventRaised += EventQueue_EventRaised;

            // FIXME: How do we create a window for OpenGL vs Vulkan?
            Window = Toolkit.Window.Create(new VulkanGraphicsApiHints());

            Toolkit.Window.SetClientSize(Window, (800, 600));
            Toolkit.Window.SetTitle(Window, options.ApplicationName);
            Toolkit.Window.SetBorderStyle(Window, WindowBorderStyle.ResizableBorder);
            Toolkit.Window.SetMode(Window, WindowMode.Normal);

            HashSet<string> supportedExtensions = new HashSet<string>();
            {
                uint extensionCount = 0;
                Vk.EnumerateInstanceExtensionProperties(null, &extensionCount, null);
                VkExtensionProperties* extensionPropertiesPtr = (VkExtensionProperties*)NativeMemory.Alloc(extensionCount, (uint)sizeof(VkExtensionProperties));
                Vk.EnumerateInstanceExtensionProperties(null, &extensionCount, extensionPropertiesPtr);

                Span<VkExtensionProperties> extensionProperties = new Span<VkExtensionProperties>(extensionPropertiesPtr, (int)extensionCount);
                for (int i = 0; i < extensionProperties.Length; i++)
                {
                    ReadOnlySpan<byte> extName = extensionProperties[i].extensionName;
                    extName = extName.Slice(0, extName.IndexOf((byte)0));
                    supportedExtensions.Add(Encoding.UTF8.GetString(extName));
                }
                NativeMemory.Free(extensionPropertiesPtr);
            }
            
            VkApplicationInfo applicationInfo;
            applicationInfo.sType = VkStructureType.StructureTypeApplicationInfo;
            applicationInfo.pNext = null;
            applicationInfo.pApplicationName = (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference("OpenTK Vulkan test app"u8));
            applicationInfo.applicationVersion = 1;
            applicationInfo.pEngineName = null;
            applicationInfo.engineVersion = 0;
            applicationInfo.apiVersion = Vk.MAKE_API_VERSION(0, 1, 3, 0);

            ReadOnlySpan<string> requiredExtensions = Toolkit.Vulkan.GetRequiredInstanceExtensions();

            List<string> extensions = new List<string>();
            if (OperatingSystem.IsMacOS())
            {
                // FIXME: For some reason VK_KHR_portability_subset doesn't work
                // even though the validation layer complains that we don't set it.
                // Not sure what that is about...
                // - Noggin_bops 2024-10-07 
                //extensions.Add("VK_KHR_portability_subset");
                extensions.Add("VK_KHR_portability_enumeration");
            }

            if (supportedExtensions.Contains("VK_EXT_debug_utils"))
            {
                extensions.Add("VK_EXT_debug_utils");
            }

            // FIXME: We could check that the required extensions actually are present,
            // this way we could provide better error messages.
            extensions.AddRange(requiredExtensions);

            HashSet<string> supportedLayers = new HashSet<string>();
            {
                uint layerCount = 0;
                Vk.EnumerateInstanceLayerProperties(&layerCount, null);
                VkLayerProperties* layersPtr = (VkLayerProperties*)NativeMemory.Alloc(layerCount, (uint)sizeof(VkLayerProperties));
                Vk.EnumerateInstanceLayerProperties(&layerCount, layersPtr);
                ReadOnlySpan<VkLayerProperties> layers = new ReadOnlySpan<VkLayerProperties>(layersPtr, (int)layerCount);
                for (int i = 0; i < layers.Length; i++)
                {
                    ReadOnlySpan<byte> layerName = layers[i].layerName;
                    layerName = layerName.Slice(0, layerName.IndexOf((byte)0));
                    supportedLayers.Add(Encoding.UTF8.GetString(layerName));
                }
            }

            string[] validationLayers;
            if (supportedLayers.Contains("VK_LAYER_KHRONOS_validation"))
            {
                validationLayers = ["VK_LAYER_KHRONOS_validation"];
            }
            else
            {
                validationLayers = [];
            }

            byte** extensionsPtr = (byte**)MarshalTk.StringArrayToCoTaskMemAnsi(CollectionsMarshal.AsSpan(extensions));
            byte** validationLayersPtr = (byte**)MarshalTk.StringArrayToCoTaskMemAnsi(validationLayers);

            VkInstanceCreateInfo instanceCreateInfo;
            instanceCreateInfo.sType = VkStructureType.StructureTypeInstanceCreateInfo;
            instanceCreateInfo.pNext = null;
            instanceCreateInfo.flags = 0;
            if (OperatingSystem.IsMacOS())
            {
                instanceCreateInfo.flags = VkInstanceCreateFlagBits.InstanceCreateEnumeratePortabilityBitKhr;
            }
            instanceCreateInfo.pApplicationInfo = &applicationInfo;
            instanceCreateInfo.enabledLayerCount = (uint)validationLayers.Length;
            instanceCreateInfo.ppEnabledLayerNames = validationLayersPtr;
            instanceCreateInfo.enabledExtensionCount = (uint)extensions.Count;
            instanceCreateInfo.ppEnabledExtensionNames = extensionsPtr;

            VkInstance instance;
            VkResult result = Vk.CreateInstance(&instanceCreateInfo, null, &instance);
            if (result != VkResult.Success)
            {
                throw new Exception($"Was not able to create vk instance: {result}");
            }
            VulkanInstance = instance;

            MarshalTk.FreeStringArrayCoTaskMem((IntPtr)extensionsPtr, extensions.Count);
            MarshalTk.FreeStringArrayCoTaskMem((IntPtr)validationLayersPtr, validationLayers.Length);

            VKLoader.SetInstance(instance);

            result = Toolkit.Vulkan.CreateWindowSurface(instance, Window, null, out Surface);
            if (result != VkResult.Success)
            {
                throw new Exception("Failed to create vulkan window surface!");
            }

            uint deviceCount = default;
            result = Vk.EnumeratePhysicalDevices(VulkanInstance, &deviceCount, null);
            if (result != VkResult.Success)
            {
                throw new Exception($"Was not able to enumerate physical devices count: {result}");
            }
            Span<VkPhysicalDevice> physicalDevices = new VkPhysicalDevice[deviceCount];
            result = Vk.EnumeratePhysicalDevices(VulkanInstance, &deviceCount, (VkPhysicalDevice*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(physicalDevices)));
            if (result != VkResult.Success)
            {
                throw new Exception($"Was not able to enumerate physical devices: {result}");
            }

            PriorityQueue<VkPhysicalDevice, int> scoreboard = new PriorityQueue<VkPhysicalDevice, int>();
            for (int i = 0; i < physicalDevices.Length; i++)
            {
                // Negate the score to make higher scores higher priority.
                scoreboard.Enqueue(physicalDevices[i], -ScorePhysicalDevice(physicalDevices[i]));

                static int ScorePhysicalDevice(VkPhysicalDevice device)
                {
                    int score = 0;

                    VkPhysicalDeviceProperties properties;
                    Vk.GetPhysicalDeviceProperties(device, &properties);

                    VkPhysicalDeviceFeatures features;
                    Vk.GetPhysicalDeviceFeatures(device, &features);

                    if (properties.deviceType == VkPhysicalDeviceType.PhysicalDeviceTypeDiscreteGpu)
                    {
                        score += 1000;
                    }

                    // We need to have swapchain capabilities.
                    uint deviceExtensionCount = 0;
                    Vk.EnumerateDeviceExtensionProperties(device, null, &deviceExtensionCount, null);
                    VkExtensionProperties* deviceExtensionsPtr = (VkExtensionProperties*)NativeMemory.Alloc(deviceExtensionCount, (uint)sizeof(VkExtensionProperties));
                    Vk.EnumerateDeviceExtensionProperties(device, null, &deviceExtensionCount, deviceExtensionsPtr);
                    ReadOnlySpan<VkExtensionProperties> deviceExtensions = new ReadOnlySpan<VkExtensionProperties>(deviceExtensionsPtr, (int)deviceExtensionCount);

                    bool hasKHRSwapchain = false;
                    for (int i = 0; i < deviceExtensions.Length; i++)
                    {
                        ReadOnlySpan<byte> extName = deviceExtensions[i].extensionName;
                        extName = extName.Slice(0, extName.IndexOf((byte)0));
                        if (extName.SequenceEqual("VK_KHR_swapchain"u8))
                        {
                            hasKHRSwapchain = true;
                        }
                    }
                    NativeMemory.Free(deviceExtensionsPtr);

                    bool hasGraphicsQueue = TryFindQueueFamily(device, out _);
                    bool hasPresentationQueue = TryFindPresentationQueueFamily(device, out _);

                    // We need KHR_swapchain, a graphics and a presentation queue.
                    if (hasKHRSwapchain == false || hasGraphicsQueue == false || hasPresentationQueue == false)
                    {
                        score = 0;
                    }

                    if (hasKHRSwapchain)
                    {
                        VkSurfaceCapabilitiesKHR surfaceCaps;
                        Vk.GetPhysicalDeviceSurfaceCapabilitiesKHR(device, Surface, &surfaceCaps);

                        uint formatCount = 0;
                        Vk.GetPhysicalDeviceSurfaceFormatsKHR(device, Surface, &formatCount, null);
                        VkSurfaceFormatKHR* formatsPtr = (VkSurfaceFormatKHR*)NativeMemory.Alloc(formatCount, (uint)sizeof(VkSurfaceFormatKHR));
                        Vk.GetPhysicalDeviceSurfaceFormatsKHR(device, Surface, &formatCount, formatsPtr);
                        ReadOnlySpan<VkSurfaceFormatKHR> formats = new ReadOnlySpan<VkSurfaceFormatKHR>(formatsPtr, (int)formatCount);

                        uint presentModeCount = 0;
                        Vk.GetPhysicalDeviceSurfacePresentModesKHR(device, Surface, &presentModeCount, null);
                        VkPresentModeKHR* presentModesPtr = (VkPresentModeKHR*)NativeMemory.Alloc(presentModeCount, (uint)sizeof(VkPresentModeKHR));
                        Vk.GetPhysicalDeviceSurfacePresentModesKHR(device, Surface, &presentModeCount, presentModesPtr);
                        ReadOnlySpan<VkPresentModeKHR> presentModes = new ReadOnlySpan<VkPresentModeKHR>(presentModesPtr, (int)presentModeCount);

                        if (formats.Length == 0 || presentModes.Length == 0)
                        {
                            score = 0;
                        }
                    }

                    return score;
                }
            }

            if (scoreboard.TryDequeue(out PhysicalDevice, out int deviceScore) == false && deviceScore != 0)
            {
                throw new Exception("Couldn't find suitable physical device.");
            }

            uint deviceExtensionCount = 0;
            result = Vk.EnumerateDeviceExtensionProperties(PhysicalDevice, null, &deviceExtensionCount, null);
            Span<VkExtensionProperties> deviceExtensions = new VkExtensionProperties[deviceExtensionCount];
            result = Vk.EnumerateDeviceExtensionProperties(PhysicalDevice, null, &deviceExtensionCount, (VkExtensionProperties*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(deviceExtensions)));


            HashSet<string> deviceExtensionsSet = new HashSet<string>();
            bool foundSwapchain = false;
            for (int i = 0; i < deviceExtensions.Length; i++)
            {
                ReadOnlySpan<byte> name = deviceExtensions[i].extensionName;
                name = name.Slice(0, name.IndexOf((byte)0));

                deviceExtensionsSet.Add(Encoding.UTF8.GetString(name));

                if (name.SequenceEqual("VK_KHR_swapchain"u8))
                {
                    foundSwapchain = true;
                }
            }

            if (foundSwapchain == false)
            {
                throw new Exception("Couldn't find VK_KHR_swapchain extension!");
            }

            if (TryFindQueueFamily(PhysicalDevice, out int graphicsQueueFamily) == false)
            {
                throw new Exception("Could not find graphics queue family.");
            }
            if (TryFindPresentationQueueFamily(PhysicalDevice, out int presentationQueueFamily) == false)
            {
                throw new Exception("Could not find presentation queue family.");
            }

            VkDeviceQueueCreateInfo* queueCreateInfos = stackalloc VkDeviceQueueCreateInfo[2];
            
            float priority = 1.0f;
            queueCreateInfos[0].sType = VkStructureType.StructureTypeDeviceQueueCreateInfo;
            queueCreateInfos[0].pNext = null;
            queueCreateInfos[0].flags = 0;
            queueCreateInfos[0].queueFamilyIndex = (uint)graphicsQueueFamily;
            queueCreateInfos[0].queueCount = 1;
            queueCreateInfos[0].pQueuePriorities = &priority;

            queueCreateInfos[1].sType = VkStructureType.StructureTypeDeviceQueueCreateInfo;
            queueCreateInfos[1].pNext = null;
            queueCreateInfos[1].flags = 0;
            queueCreateInfos[1].queueFamilyIndex = (uint)presentationQueueFamily;
            queueCreateInfos[1].queueCount = 1;
            queueCreateInfos[1].pQueuePriorities = &priority;

            VkPhysicalDeviceFeatures deviceFeatures = default;

            List<string> enabledDeviceExtensions = ["VK_KHR_swapchain"];
            if (OperatingSystem.IsMacOS())
            {
                enabledDeviceExtensions.Add("VK_KHR_portability_subset");
            }
            byte** enabledExtensionsPtr = (byte**)MarshalTk.StringArrayToCoTaskMemAnsi(CollectionsMarshal.AsSpan(enabledDeviceExtensions));

            VkDeviceCreateInfo deviceCreateInfo;
            deviceCreateInfo.sType = VkStructureType.StructureTypeDeviceCreateInfo;
            deviceCreateInfo.pNext = null;
            deviceCreateInfo.flags = 0;
            deviceCreateInfo.queueCreateInfoCount = graphicsQueueFamily == presentationQueueFamily ? 1u : 2u;
            deviceCreateInfo.pQueueCreateInfos = queueCreateInfos;
            deviceCreateInfo.enabledLayerCount = (uint)validationLayers.Length;
            deviceCreateInfo.ppEnabledLayerNames = validationLayersPtr;
            deviceCreateInfo.enabledExtensionCount = (uint)enabledDeviceExtensions.Count;
            deviceCreateInfo.ppEnabledExtensionNames = enabledExtensionsPtr;
            deviceCreateInfo.pEnabledFeatures = &deviceFeatures;

            VkDevice device;
            result = Vk.CreateDevice(PhysicalDevice, &deviceCreateInfo, null, &device);
            Device = device;
            if (result != VkResult.Success)
            {
                throw new Exception($"Was not able to create logical device: {result}");
            }

            DeviceFunctions = new DeviceDispatchTable(device);

            VkQueue graphicsQueue;
            DeviceFunctions.GetDeviceQueue(Device, (uint)graphicsQueueFamily, 0, &graphicsQueue);
            GraphicsQueue = graphicsQueue;

            VkQueue presentQueue;
            DeviceFunctions.GetDeviceQueue(Device, (uint)presentationQueueFamily, 0, &presentQueue);
            PresentQueue = presentQueue;

            CreateSwapchain();

            uint swapchainImageCount;
            result = DeviceFunctions.GetSwapchainImagesKHR(Device, Swapchain, &swapchainImageCount, null);

            Span<VkImage> swapchainImages = new VkImage[swapchainImageCount];
            result = DeviceFunctions.GetSwapchainImagesKHR(Device, Swapchain, &swapchainImageCount, (VkImage*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(swapchainImages)));

            VkAttachmentReference colorAttachmentRef;
            colorAttachmentRef.attachment = 0;
            colorAttachmentRef.layout = VkImageLayout.ImageLayoutColorAttachmentOptimal;

            VkSubpassDescription subpass;
            subpass.flags = 0;
            subpass.pipelineBindPoint = VkPipelineBindPoint.PipelineBindPointGraphics;
            subpass.inputAttachmentCount = 0;
            subpass.pInputAttachments = null;
            subpass.colorAttachmentCount = 1;
            subpass.pColorAttachments = &colorAttachmentRef;
            subpass.pResolveAttachments = null;
            subpass.pDepthStencilAttachment = null;
            subpass.preserveAttachmentCount = 0;
            subpass.pPreserveAttachments = null;

            VkAttachmentDescription colorAttachment;
            colorAttachment.flags = 0;
            colorAttachment.format = SwapchainFormat.format;
            colorAttachment.samples = VkSampleCountFlagBits.SampleCount1Bit;
            colorAttachment.loadOp = VkAttachmentLoadOp.AttachmentLoadOpClear;
            colorAttachment.storeOp = VkAttachmentStoreOp.AttachmentStoreOpStore;
            colorAttachment.stencilLoadOp = VkAttachmentLoadOp.AttachmentLoadOpClear;
            colorAttachment.stencilStoreOp = VkAttachmentStoreOp.AttachmentStoreOpStore;
            colorAttachment.initialLayout = VkImageLayout.ImageLayoutUndefined;
            colorAttachment.finalLayout = VkImageLayout.ImageLayoutPresentSrcKhr;

            VkRenderPassCreateInfo renderPassCreateInfo;
            renderPassCreateInfo.sType = VkStructureType.StructureTypeRenderPassCreateInfo;
            renderPassCreateInfo.pNext = null;
            renderPassCreateInfo.flags = 0;
            renderPassCreateInfo.attachmentCount = 1;
            renderPassCreateInfo.pAttachments = &colorAttachment;
            renderPassCreateInfo.subpassCount = 1;
            renderPassCreateInfo.pSubpasses = &subpass;
            renderPassCreateInfo.dependencyCount = 0;
            renderPassCreateInfo.pDependencies = null;

            VkRenderPass renderPass;
            result = DeviceFunctions.CreateRenderPass(Device, &renderPassCreateInfo, null, &renderPass);
            RenderPass = renderPass;

            // Create the graphics pipeline
            {
                VkShaderModule vertexModule;
                {
                    byte[] vert = File.ReadAllBytes("./Assets/triangle.vert.spv");
                    fixed (byte* vertPtr = vert)
                    {
                        VkShaderModuleCreateInfo shaderModuleCreateInfo = new VkShaderModuleCreateInfo();
                        shaderModuleCreateInfo.codeSize = (uint)vert.Length;
                        shaderModuleCreateInfo.pCode = (uint*)vertPtr;
                        result = DeviceFunctions.CreateShaderModule(Device, &shaderModuleCreateInfo, null, &vertexModule);
                    }
                }

                VkShaderModule fragmentModule;
                {
                    byte[] frag = File.ReadAllBytes("./Assets/triangle.frag.spv");
                    fixed (byte* vertPtr = frag)
                    {
                        VkShaderModuleCreateInfo shaderModuleCreateInfo = new VkShaderModuleCreateInfo();
                        shaderModuleCreateInfo.codeSize = (uint)frag.Length;
                        shaderModuleCreateInfo.pCode = (uint*)vertPtr;
                        result = DeviceFunctions.CreateShaderModule(Device, &shaderModuleCreateInfo, null, &fragmentModule);
                    }
                }

                byte* name = (byte*)NativeMemory.AllocZeroed((uint)"main"u8.Length);
                "main"u8.CopyTo(new Span<byte>(name, "main"u8.Length));

                VkPipelineShaderStageCreateInfo vertShaderStageInfo = new VkPipelineShaderStageCreateInfo();
                vertShaderStageInfo.stage = VkShaderStageFlagBits.ShaderStageVertexBit;
                vertShaderStageInfo.module = vertexModule;
                vertShaderStageInfo.pName = name;

                VkPipelineShaderStageCreateInfo fragShaderStageInfo = new VkPipelineShaderStageCreateInfo();
                fragShaderStageInfo.stage = VkShaderStageFlagBits.ShaderStageFragmentBit;
                fragShaderStageInfo.module = fragmentModule;
                fragShaderStageInfo.pName = name;

                VkPipelineShaderStageCreateInfo* shaderStages = stackalloc VkPipelineShaderStageCreateInfo[2];
                shaderStages[0] = vertShaderStageInfo;
                shaderStages[1] = fragShaderStageInfo;

                VkDynamicState* dynamicStates = (VkDynamicState*)NativeMemory.Alloc(2, sizeof(VkDynamicState));
                dynamicStates[0] = VkDynamicState.DynamicStateViewport;
                dynamicStates[1] = VkDynamicState.DynamicStateScissor;

                VkPipelineDynamicStateCreateInfo dynamicStateInfo = new VkPipelineDynamicStateCreateInfo();
                dynamicStateInfo.dynamicStateCount = 2;
                dynamicStateInfo.pDynamicStates = dynamicStates;

                VkPipelineVertexInputStateCreateInfo vertexInputInfo = new VkPipelineVertexInputStateCreateInfo();
                vertexInputInfo.vertexBindingDescriptionCount = 0;
                vertexInputInfo.pVertexBindingDescriptions = null;
                vertexInputInfo.vertexAttributeDescriptionCount = 0;
                vertexInputInfo.pVertexAttributeDescriptions = null;

                VkPipelineInputAssemblyStateCreateInfo inputAssemblyInfo = new VkPipelineInputAssemblyStateCreateInfo();
                inputAssemblyInfo.topology = VkPrimitiveTopology.PrimitiveTopologyTriangleList;
                inputAssemblyInfo.primitiveRestartEnable = 0;

                VkViewport viewport = new VkViewport();
                viewport.x = 0;
                viewport.y = 0;
                viewport.width = SwapchainExtents.width;
                viewport.height = SwapchainExtents.height;
                viewport.minDepth = 0.0f;
                viewport.maxDepth = 1.0f;

                VkRect2D scissor = new VkRect2D();
                scissor.offset = new VkOffset2D(0, 0);
                scissor.extent = SwapchainExtents;

                VkPipelineViewportStateCreateInfo viewportState = new VkPipelineViewportStateCreateInfo();
                viewportState.viewportCount = 1;
                viewportState.scissorCount = 1;

                VkPipelineRasterizationStateCreateInfo rasterizerStateInfo = new VkPipelineRasterizationStateCreateInfo();
                rasterizerStateInfo.depthClampEnable = 0;
                rasterizerStateInfo.rasterizerDiscardEnable = 0;
                rasterizerStateInfo.polygonMode = VkPolygonMode.PolygonModeFill;
                rasterizerStateInfo.cullMode = VkCullModeFlagBits.CullModeBackBit;
                rasterizerStateInfo.frontFace = VkFrontFace.FrontFaceClockwise;
                rasterizerStateInfo.depthBiasEnable = 0;
                rasterizerStateInfo.depthBiasConstantFactor = 0.0f;
                rasterizerStateInfo.depthBiasClamp = 0.0f;
                rasterizerStateInfo.depthBiasSlopeFactor = 0.0f;
                rasterizerStateInfo.lineWidth = 1.0f;

                VkPipelineMultisampleStateCreateInfo multisampleStateInfo = new VkPipelineMultisampleStateCreateInfo();
                multisampleStateInfo.rasterizationSamples = VkSampleCountFlagBits.SampleCount1Bit;
                multisampleStateInfo.sampleShadingEnable = 0;
                multisampleStateInfo.minSampleShading = 1.0f;
                multisampleStateInfo.pSampleMask = null;
                multisampleStateInfo.alphaToCoverageEnable = 0;
                multisampleStateInfo.alphaToOneEnable = 0;

                VkPipelineColorBlendAttachmentState colorBlendAttachmentState = new VkPipelineColorBlendAttachmentState();
                colorBlendAttachmentState.colorWriteMask = VkColorComponentFlagBits.ColorComponentRBit | VkColorComponentFlagBits.ColorComponentGBit | VkColorComponentFlagBits.ColorComponentBBit | VkColorComponentFlagBits.ColorComponentABit;
                colorBlendAttachmentState.blendEnable = 0;
                colorBlendAttachmentState.srcColorBlendFactor = VkBlendFactor.BlendFactorOne;
                colorBlendAttachmentState.dstColorBlendFactor = VkBlendFactor.BlendFactorZero;
                colorBlendAttachmentState.colorBlendOp = VkBlendOp.BlendOpAdd;
                colorBlendAttachmentState.srcAlphaBlendFactor = VkBlendFactor.BlendFactorOne;
                colorBlendAttachmentState.dstColorBlendFactor = VkBlendFactor.BlendFactorZero;
                colorBlendAttachmentState.alphaBlendOp = VkBlendOp.BlendOpAdd;

                VkPipelineColorBlendStateCreateInfo colorBlendStateInfo = new VkPipelineColorBlendStateCreateInfo();
                colorBlendStateInfo.logicOpEnable = 0;
                colorBlendStateInfo.logicOp = VkLogicOp.LogicOpCopy;
                colorBlendStateInfo.attachmentCount = 1;
                colorBlendStateInfo.pAttachments = &colorBlendAttachmentState;
                colorBlendStateInfo.blendConstants[0] = 0.0f;
                colorBlendStateInfo.blendConstants[1] = 0.0f;
                colorBlendStateInfo.blendConstants[2] = 0.0f;
                colorBlendStateInfo.blendConstants[3] = 0.0f;

                VkPipelineLayoutCreateInfo pipelineLayoutInfo = new VkPipelineLayoutCreateInfo();
                pipelineLayoutInfo.setLayoutCount = 0;
                pipelineLayoutInfo.pSetLayouts = null;
                pipelineLayoutInfo.pushConstantRangeCount = 0;
                pipelineLayoutInfo.pPushConstantRanges = null;

                VkPipelineLayout layout;
                result = DeviceFunctions.CreatePipelineLayout(Device, &pipelineLayoutInfo, null, &layout);
                if (result != VkResult.Success)
                {
                    throw new Exception($"Could not create pipeline layout: {result}");
                }
                PipelineLayout = layout;

                VkGraphicsPipelineCreateInfo pipelineInfo = new VkGraphicsPipelineCreateInfo();
                pipelineInfo.stageCount = 2;
                pipelineInfo.pStages = shaderStages;
                pipelineInfo.pVertexInputState = &vertexInputInfo;
                pipelineInfo.pInputAssemblyState = &inputAssemblyInfo;
                pipelineInfo.pViewportState = &viewportState;
                pipelineInfo.pRasterizationState = &rasterizerStateInfo;
                pipelineInfo.pMultisampleState = &multisampleStateInfo;
                pipelineInfo.pDepthStencilState = null;
                pipelineInfo.pColorBlendState = &colorBlendStateInfo;
                pipelineInfo.pDynamicState = &dynamicStateInfo;
                pipelineInfo.layout = PipelineLayout;
                pipelineInfo.renderPass = RenderPass;
                pipelineInfo.subpass = 0;

                VkPipeline pipeline;
                result = DeviceFunctions.CreateGraphicsPipelines(Device, VkPipelineCache.Zero, 1, &pipelineInfo, null, &pipeline);
                if (result != VkResult.Success)
                {
                    throw new Exception($"Failed to create graphics pipeline: {result}");
                }
                Pipeline = pipeline;

                NativeMemory.Free(name);
                DeviceFunctions.DestroyShaderModule(Device, vertexModule, null);
                DeviceFunctions.DestroyShaderModule(Device, fragmentModule, null);
            }

            SwapchainImageViews = new VkImageView[swapchainImages.Length];
            SwapchainFramebuffers = new VkFramebuffer[swapchainImages.Length];
            for (int i = 0; i < swapchainImages.Length; i++)
            {
                VkImageViewCreateInfo imgViewCreate;
                imgViewCreate.sType = VkStructureType.StructureTypeImageViewCreateInfo;
                imgViewCreate.pNext = null;
                imgViewCreate.flags = 0;
                imgViewCreate.image = swapchainImages[i];
                imgViewCreate.viewType = VkImageViewType.ImageViewType2D;
                imgViewCreate.format = SwapchainFormat.format;
                imgViewCreate.components.r = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.components.g = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.components.b = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.components.a = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.subresourceRange.aspectMask = VkImageAspectFlagBits.ImageAspectColorBit;
                imgViewCreate.subresourceRange.baseMipLevel = 0;
                imgViewCreate.subresourceRange.levelCount = 1;
                imgViewCreate.subresourceRange.baseArrayLayer = 0;
                imgViewCreate.subresourceRange.layerCount = 1;

                VkImageView imgView;
                result = DeviceFunctions.CreateImageView(Device, &imgViewCreate, null, &imgView);
                SwapchainImageViews[i] = imgView;

                VkFramebufferCreateInfo fbCreate;
                fbCreate.sType = VkStructureType.StructureTypeFramebufferCreateInfo;
                fbCreate.pNext = null;
                fbCreate.flags = 0;
                fbCreate.renderPass = renderPass;
                fbCreate.attachmentCount = 1;
                fbCreate.pAttachments = &imgView;
                fbCreate.width = SwapchainExtents.width;
                fbCreate.height = SwapchainExtents.height;
                fbCreate.layers = 1;

                VkFramebuffer framebuffer;
                result = DeviceFunctions.CreateFramebuffer(Device, &fbCreate, null, &framebuffer);
                SwapchainFramebuffers[i] = framebuffer;
            }

            VkCommandPoolCreateInfo commandPoolCreate;
            commandPoolCreate.sType = VkStructureType.StructureTypeCommandPoolCreateInfo;
            commandPoolCreate.pNext = null;
            commandPoolCreate.flags = VkCommandPoolCreateFlagBits.CommandPoolCreateResetCommandBufferBit;
            commandPoolCreate.queueFamilyIndex = (uint)graphicsQueueFamily;

            VkCommandPool commandPool;
            result = DeviceFunctions.CreateCommandPool(Device, &commandPoolCreate, null, &commandPool);
            CommandPool = commandPool;

            VkCommandBufferAllocateInfo cmdBufferAlloc;
            cmdBufferAlloc.sType = VkStructureType.StructureTypeCommandBufferAllocateInfo;
            cmdBufferAlloc.pNext = null;
            cmdBufferAlloc.commandPool = commandPool;
            cmdBufferAlloc.level = VkCommandBufferLevel.CommandBufferLevelPrimary;
            cmdBufferAlloc.commandBufferCount = 1;

            VkCommandBuffer commandBuffer;
            result = DeviceFunctions.AllocateCommandBuffers(Device, &cmdBufferAlloc, &commandBuffer);
            CommandBuffer = commandBuffer;

            {
                VkSemaphoreCreateInfo semaphoreCreate;
                semaphoreCreate.sType = VkStructureType.StructureTypeSemaphoreCreateInfo;
                semaphoreCreate.pNext = null;
                semaphoreCreate.flags = 0;

                VkSemaphore imageAvail;
                result = DeviceFunctions.CreateSemaphore(Device, &semaphoreCreate, null, &imageAvail);
                ImageAvailableSemaphore = imageAvail;

                VkSemaphore renderFinished;
                result = DeviceFunctions.CreateSemaphore(Device, &semaphoreCreate, null, &renderFinished);
                RenderFinishedSemaphore = renderFinished;

                VkFenceCreateInfo fenceCreate;
                fenceCreate.sType = VkStructureType.StructureTypeFenceCreateInfo;
                fenceCreate.pNext = null;
                fenceCreate.flags = VkFenceCreateFlagBits.FenceCreateSignaledBit;

                VkFence inFlight;
                result = DeviceFunctions.CreateFence(Device, &fenceCreate, null, &inFlight);
                InFlightFence = inFlight;
            }

            static bool TryFindQueueFamily(VkPhysicalDevice physicalDevice, out int queueFamily)
            {
                uint propertyCount = 0;
                Vk.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, &propertyCount, null);

                Span<VkQueueFamilyProperties> familyProperties = stackalloc VkQueueFamilyProperties[(int)propertyCount];
                fixed (VkQueueFamilyProperties* ptr = familyProperties)
                    Vk.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, &propertyCount, ptr);

                for (int i = 0; i < propertyCount; i++)
                {
                    if ((familyProperties[i].queueFlags & VkQueueFlagBits.QueueGraphicsBit) != 0)
                    {
                        queueFamily = i;
                        return true;
                    }
                }

                queueFamily = default;
                return false;
            }

            static bool TryFindPresentationQueueFamily(VkPhysicalDevice physicalDevice, out int queueFamily)
            {
                uint propertyCount = 0;
                Vk.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, &propertyCount, null);
                Span<VkQueueFamilyProperties> familyProperties = stackalloc VkQueueFamilyProperties[(int)propertyCount];
                fixed (VkQueueFamilyProperties* ptr = familyProperties)
                    Vk.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, &propertyCount, ptr);

                for (int i = 0; i < propertyCount; i++)
                {
                    if (Toolkit.Vulkan.GetPhysicalDevicePresentationSupport(VulkanInstance, physicalDevice, (uint)i))
                    {
                        queueFamily = i;
                        return true;
                    }
                }

                queueFamily = default;
                return false;
            }

            Stopwatch watch = Stopwatch.StartNew();
            while (true)
            {
                Toolkit.Window.ProcessEvents(false);
                if (Toolkit.Window.IsWindowDestroyed(Window))
                    break;

                float deltaTime = (float)watch.Elapsed.TotalSeconds;
                watch.Restart();
                OnUpdateFrame(deltaTime);
            }

            DeviceFunctions.DeviceWaitIdle(Device);

            CleanupSwapchain();

            DeviceFunctions.DestroyCommandPool(Device, CommandPool, null);

            DeviceFunctions.DestroyPipeline(Device, Pipeline, null);
            DeviceFunctions.DestroyPipelineLayout(Device, PipelineLayout, null);
            DeviceFunctions.DestroyRenderPass(Device, RenderPass, null);

            DeviceFunctions.DestroySemaphore(Device, ImageAvailableSemaphore, null);
            DeviceFunctions.DestroySemaphore(Device, RenderFinishedSemaphore, null);
            DeviceFunctions.DestroyFence(Device, InFlightFence, null);

            Vk.DestroySurfaceKHR(VulkanInstance, Surface, null);
            Vk.DestroyDevice(Device, null);
            Vk.DestroyInstance(VulkanInstance, null);
        }

        private static void EventQueue_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            if (args is CloseEventArgs close)
            {
                Toolkit.Window.Destroy(close.Window);
            }
            else if (args is WindowFramebufferResizeEventArgs fbResize)
            {
                FramebufferHasNewSize = true;
            }
        }

        const float CycleTime = 8.0f;
        static float Time = 0;

        protected unsafe static void OnUpdateFrame(float deltaTime)
        {
            Time += deltaTime;
            if (Time > CycleTime) Time = 0;

            VkResult result;

            fixed (VkFence* inFlightFencePtr = &InFlightFence)
            {
                result = DeviceFunctions.WaitForFences(Device, 1, inFlightFencePtr, 1, ulong.MaxValue);
            }

            uint imageIndex;
            result = DeviceFunctions.AcquireNextImageKHR(Device, Swapchain, ulong.MaxValue, ImageAvailableSemaphore, VkFence.Zero, &imageIndex);
            if (result == VkResult.ErrorOutOfDateKhr )
            {
                RecreateSwapchain();
                return;
            }

            // Only do this if we are submitting work!
            fixed (VkFence* inFlightFencePtr = &InFlightFence)
            {
                result = DeviceFunctions.ResetFences(Device, 1, inFlightFencePtr);
            }

            result = DeviceFunctions.ResetCommandBuffer(CommandBuffer, 0);
            RecordCommandBuffer(CommandBuffer, RenderPass, SwapchainFramebuffers[imageIndex], SwapchainExtents, Time);

            fixed (VkSemaphore* imageAvailableSemaphorePtr = &ImageAvailableSemaphore)
            fixed (VkSemaphore* renderFinishedSemaphorePtr = &RenderFinishedSemaphore)
            fixed (VkCommandBuffer* commandBufferPtr = &CommandBuffer)
            fixed (VkSwapchainKHR* swapchainPtr = &Swapchain)
            {
                VkSubmitInfo submitInfo;
                submitInfo.sType = VkStructureType.StructureTypeSubmitInfo;
                submitInfo.pNext = null;
                submitInfo.waitSemaphoreCount = 1;
                submitInfo.pWaitSemaphores = imageAvailableSemaphorePtr;
                VkPipelineStageFlagBits stage = VkPipelineStageFlagBits.PipelineStageColorAttachmentOutputBit;
                submitInfo.pWaitDstStageMask = &stage;
                submitInfo.commandBufferCount = 1;
                submitInfo.pCommandBuffers = commandBufferPtr;
                submitInfo.signalSemaphoreCount = 1;
                submitInfo.pSignalSemaphores = renderFinishedSemaphorePtr;

                result = DeviceFunctions.QueueSubmit(GraphicsQueue, 1, &submitInfo, InFlightFence);

                VkPresentInfoKHR presentInfo;
                presentInfo.sType = VkStructureType.StructureTypePresentInfoKhr;
                presentInfo.pNext = null;
                presentInfo.waitSemaphoreCount = 1;
                presentInfo.pWaitSemaphores = renderFinishedSemaphorePtr;
                presentInfo.swapchainCount = 1;
                presentInfo.pSwapchains = swapchainPtr;
                presentInfo.pImageIndices = &imageIndex;
                presentInfo.pResults = null;

                result = DeviceFunctions.QueuePresentKHR(PresentQueue, &presentInfo);
                if (result == VkResult.ErrorOutOfDateKhr || result == VkResult.SuboptimalKhr || FramebufferHasNewSize)
                {
                    FramebufferHasNewSize = false;
                    RecreateSwapchain();
                }
            }
        }

        static unsafe void RecordCommandBuffer(VkCommandBuffer commandBuffer, VkRenderPass renderPass, VkFramebuffer framebuffer, VkExtent2D imageExtent, float time)
        {
            VkCommandBufferBeginInfo beginInfo;
            beginInfo.sType = VkStructureType.StructureTypeCommandBufferBeginInfo;
            beginInfo.pNext = null;
            beginInfo.flags = 0;
            beginInfo.pInheritanceInfo = null;

            VkResult result = DeviceFunctions.BeginCommandBuffer(commandBuffer, &beginInfo);

            VkRenderPassBeginInfo renderPassInfo;
            renderPassInfo.sType = VkStructureType.StructureTypeRenderPassBeginInfo;
            renderPassInfo.pNext = null;
            renderPassInfo.renderPass = renderPass;
            renderPassInfo.framebuffer = framebuffer;
            renderPassInfo.renderArea.offset = new VkOffset2D() { x = 0, y = 0 };
            renderPassInfo.renderArea.extent = imageExtent;
            renderPassInfo.clearValueCount = 1;

            Color4<Rgba> color = new Color4<Hsva>(time / CycleTime, 1, 1, 1).ToRgba();
            color = new Color4<Rgba>(0.05f, 0.05f, 0.05f, 1.0f);

            VkClearValue clearValue = default;
            clearValue.color.float32[0] = color.X;
            clearValue.color.float32[1] = color.Y;
            clearValue.color.float32[2] = color.Z;
            clearValue.color.float32[3] = color.W;
            renderPassInfo.pClearValues = &clearValue;

            DeviceFunctions.CmdBeginRenderPass(commandBuffer, &renderPassInfo, VkSubpassContents.SubpassContentsInline);

            DeviceFunctions.CmdBindPipeline(commandBuffer, VkPipelineBindPoint.PipelineBindPointGraphics, Pipeline);

            VkViewport viewport = new VkViewport(0.0f, 0.0f, SwapchainExtents.width, SwapchainExtents.height, 0.0f, 1.0f);
            DeviceFunctions.CmdSetViewport(commandBuffer, 0, 1, &viewport);

            VkRect2D scissor = new VkRect2D(new VkOffset2D(0, 0), SwapchainExtents);
            DeviceFunctions.CmdSetScissor(commandBuffer, 0, 1, &scissor);

            DeviceFunctions.CmdDraw(commandBuffer, 3, 1, 0, 0);

            DeviceFunctions.CmdEndRenderPass(commandBuffer);

            result = DeviceFunctions.EndCommandBuffer(commandBuffer);
        }

        static unsafe void CreateSwapchain()
        {
            VkResult result;

            VkSurfaceCapabilitiesKHR surfaceCaps;
            result = Vk.GetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice, Surface, &surfaceCaps);

            uint surfaceFormatCount;
            result = Vk.GetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice, Surface, &surfaceFormatCount, null);
            Span<VkSurfaceFormatKHR> surfaceFormats = stackalloc VkSurfaceFormatKHR[(int)surfaceFormatCount];
            result = Vk.GetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice, Surface, &surfaceFormatCount, (VkSurfaceFormatKHR*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(surfaceFormats)));

            VkSurfaceFormatKHR choosenFormat = default;
            bool foundFormat = false;
            for (int i = 0; i < surfaceFormats.Length; i++)
            {
                if (surfaceFormats[i].format == VkFormat.FormatR8g8b8a8Srgb || surfaceFormats[i].format == VkFormat.FormatB8g8r8a8Srgb)
                {
                    choosenFormat = surfaceFormats[i];
                    foundFormat = true;
                    break;
                }
            }
            if (foundFormat == false)
            {
                choosenFormat = surfaceFormats[0];
            }

            uint presentModeCount = 0;
            result = Vk.GetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice, Surface, &presentModeCount, null);
            Span<VkPresentModeKHR> presentModes = stackalloc VkPresentModeKHR[(int)presentModeCount];
            result = Vk.GetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice, Surface, &presentModeCount, (VkPresentModeKHR*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(presentModes)));

            VkSwapchainCreateInfoKHR swapchainCreate;
            swapchainCreate.sType = VkStructureType.StructureTypeSwapchainCreateInfoKhr;
            swapchainCreate.pNext = null;
            swapchainCreate.flags = 0;
            swapchainCreate.surface = Surface;
            swapchainCreate.minImageCount = surfaceCaps.minImageCount;
            swapchainCreate.imageFormat = choosenFormat.format;
            swapchainCreate.imageColorSpace = choosenFormat.colorSpace;
            swapchainCreate.imageExtent = surfaceCaps.currentExtent;
            swapchainCreate.imageArrayLayers = 1;
            swapchainCreate.imageUsage = VkImageUsageFlagBits.ImageUsageColorAttachmentBit;
            swapchainCreate.imageSharingMode = VkSharingMode.SharingModeExclusive;
            swapchainCreate.queueFamilyIndexCount = 0;
            swapchainCreate.pQueueFamilyIndices = null;
            swapchainCreate.preTransform = surfaceCaps.currentTransform;
            swapchainCreate.compositeAlpha = VkCompositeAlphaFlagBitsKHR.CompositeAlphaOpaqueBitKhr;
            // FIXME: Get from the possible present modes..
            swapchainCreate.presentMode = VkPresentModeKHR.PresentModeFifoKhr;
            swapchainCreate.clipped = 1;
            swapchainCreate.oldSwapchain = VkSwapchainKHR.Zero;

            VkSwapchainKHR swapchain;
            result = DeviceFunctions.CreateSwapchainKHR(Device, &swapchainCreate, null, &swapchain);
            Swapchain = swapchain;

            SwapchainExtents = swapchainCreate.imageExtent;

            SwapchainFormat = choosenFormat;
        }

        static unsafe void CleanupSwapchain()
        {
            DeviceFunctions.DeviceWaitIdle(Device);

            for (int i = 0; i < SwapchainFramebuffers.Length; i++)
            {
                DeviceFunctions.DestroyFramebuffer(Device, SwapchainFramebuffers[i], null);
            }

            for (int i = 0; i < SwapchainImageViews.Length; i++)
            {
                DeviceFunctions.DestroyImageView(Device, SwapchainImageViews[i], null);
            }

            DeviceFunctions.DestroySwapchainKHR(Device, Swapchain, null);
        }

        static unsafe void RecreateSwapchain()
        {
            CleanupSwapchain();

            CreateSwapchain();

            VkResult result;

            uint swapchainImageCount;
            result = DeviceFunctions.GetSwapchainImagesKHR(Device, Swapchain, &swapchainImageCount, null);

            Span<VkImage> swapchainImages = new VkImage[swapchainImageCount];
            result = DeviceFunctions.GetSwapchainImagesKHR(Device, Swapchain, &swapchainImageCount, (VkImage*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(swapchainImages)));


            SwapchainImageViews = new VkImageView[swapchainImages.Length];
            SwapchainFramebuffers = new VkFramebuffer[swapchainImages.Length];
            for (int i = 0; i < swapchainImages.Length; i++)
            {
                VkImageViewCreateInfo imgViewCreate;
                imgViewCreate.sType = VkStructureType.StructureTypeImageViewCreateInfo;
                imgViewCreate.pNext = null;
                imgViewCreate.flags = 0;
                imgViewCreate.image = swapchainImages[i];
                imgViewCreate.viewType = VkImageViewType.ImageViewType2D;
                imgViewCreate.format = SwapchainFormat.format;
                imgViewCreate.components.r = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.components.g = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.components.b = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.components.a = VkComponentSwizzle.ComponentSwizzleIdentity;
                imgViewCreate.subresourceRange.aspectMask = VkImageAspectFlagBits.ImageAspectColorBit;
                imgViewCreate.subresourceRange.baseMipLevel = 0;
                imgViewCreate.subresourceRange.levelCount = 1;
                imgViewCreate.subresourceRange.baseArrayLayer = 0;
                imgViewCreate.subresourceRange.layerCount = 1;

                VkImageView imgView;
                result = DeviceFunctions.CreateImageView(Device, &imgViewCreate, null, &imgView);
                SwapchainImageViews[i] = imgView;

                VkFramebufferCreateInfo fbCreate;
                fbCreate.sType = VkStructureType.StructureTypeFramebufferCreateInfo;
                fbCreate.pNext = null;
                fbCreate.flags = 0;
                fbCreate.renderPass = RenderPass;
                fbCreate.attachmentCount = 1;
                fbCreate.pAttachments = &imgView;
                fbCreate.width = SwapchainExtents.width;
                fbCreate.height = SwapchainExtents.height;
                fbCreate.layers = 1;

                VkFramebuffer framebuffer;
                result = DeviceFunctions.CreateFramebuffer(Device, &fbCreate, null, &framebuffer);
                SwapchainFramebuffers[i] = framebuffer;
            }
        }
    }
}
