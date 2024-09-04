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

namespace VulkanTestProject
{
    internal class Program
    {
        static WindowHandle Window;

        static VkInstance VulkanInstance;
        static VkPhysicalDevice PhysicalDevice;
        static VkDevice Device;
        static VkSurfaceKHR Surface;

        static VkQueue GraphicsQueue;
        static VkRenderPass RenderPass;
        static VkCommandPool CommandPool;
        static VkCommandBuffer CommandBuffer;

        static VkExtent2D SwapchainExtents;
        static VkSwapchainKHR Swapchain;
        static VkImageView[] SwapchainImageViews;
        static VkFramebuffer[] SwapchainFramebuffers;

        static VkSemaphore ImageAvailableSemaphore;
        static VkSemaphore RenderFinishedSemaphore;
        static VkFence InFlightFence;

        static unsafe void Main(string[] args)
        {
            ToolkitOptions options = new ToolkitOptions() { ApplicationName = "PAL2 Vulkan test app", Logger = new ConsoleLogger() };
            Toolkit.Init(options);

            EventQueue.EventRaised += EventQueue_EventRaised;

            // FIXME: How do we create a window for OpenGL vs Vulkan?
            Window = Toolkit.Window.Create(null);

            Toolkit.Window.SetClientSize(Window, (800, 600));
            Toolkit.Window.SetTitle(Window, options.ApplicationName);
            Toolkit.Window.SetBorderStyle(Window, WindowBorderStyle.ResizableBorder);
            Toolkit.Window.SetMode(Window, WindowMode.Normal);

            VKLoader.Init();

            VkApplicationInfo applicationInfo;
            applicationInfo.sType = VkStructureType.StructureTypeApplicationInfo;
            applicationInfo.pNext = null;
            applicationInfo.pApplicationName = (byte*)Unsafe.AsPointer(ref MemoryMarshal.GetReference("OpenTK Vulkan test app"u8));
            applicationInfo.applicationVersion = 1;
            applicationInfo.pEngineName = null;
            applicationInfo.engineVersion = 0;
            applicationInfo.apiVersion = Vk.MAKE_API_VERSION(0, 1, 3, 0);

            ReadOnlySpan<string> requiredExtensions = Toolkit.Vulkan.GetRequiredInstanceExtensions();

            string[] extensions = new string[requiredExtensions.Length + 1];
            extensions[0] = "VK_EXT_debug_utils";
            requiredExtensions.CopyTo(extensions.AsSpan()[1..]);

            string[] validationLayers = [ "VK_LAYER_KHRONOS_validation" ];

            byte** extensionsPtr = MarshalTk.MarshalStringArrayToAnsiStringArrayPtr(extensions, out uint extensionsCount);
            byte** validationLayersPtr = MarshalTk.MarshalStringArrayToAnsiStringArrayPtr(validationLayers, out uint validationLayerCount);

            VkInstanceCreateInfo instanceCreateInfo;
            instanceCreateInfo.sType = VkStructureType.StructureTypeInstanceCreateInfo;
            instanceCreateInfo.pNext = null;
            instanceCreateInfo.flags = 0;
            instanceCreateInfo.pApplicationInfo = &applicationInfo;
            instanceCreateInfo.enabledLayerCount = validationLayerCount;
            instanceCreateInfo.ppEnabledLayerNames = validationLayersPtr;
            instanceCreateInfo.enabledExtensionCount = extensionsCount;
            instanceCreateInfo.ppEnabledExtensionNames = extensionsPtr;

            VkInstance instance;
            VkResult result = Vk.CreateInstance(&instanceCreateInfo, null, &instance);
            if (result != VkResult.Success)
            {
                throw new Exception($"Was not able to create vk instance: {result}");
            }
            VulkanInstance = instance;

            MarshalTk.FreeAnsiStringArrayPtr(extensionsPtr, extensionsCount);
            MarshalTk.FreeAnsiStringArrayPtr(validationLayersPtr, validationLayerCount);

            VKLoader.SetInstance(instance);

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

            PhysicalDevice = physicalDevices[0];

            uint deviceExtensionCount = 0;
            result = Vk.EnumerateDeviceExtensionProperties(PhysicalDevice, null, &deviceExtensionCount, null);

            Span<VkExtensionProperties> deviceExtensions = new VkExtensionProperties[deviceExtensionCount];
            result = Vk.EnumerateDeviceExtensionProperties(PhysicalDevice, null, &deviceExtensionCount, (VkExtensionProperties*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(deviceExtensions)));

            bool foundSwapchain = false;
            for (int i = 0; i < deviceExtensions.Length; i++)
            {
                ReadOnlySpan<byte> name = deviceExtensions[i].extensionName;
                name = name.Slice(0, name.IndexOf((byte)0));

                if (name.SequenceEqual("VK_KHR_swapchain"u8))
                {
                    foundSwapchain = true;
                }
            }

            if (foundSwapchain == false)
            {
                throw new Exception("Couldn't find VK_KHR_swapchain extension!");
            }

            int queueFamily = FindQueueFamily(PhysicalDevice);

            VkDeviceQueueCreateInfo queueCreateInfo;
            queueCreateInfo.sType = VkStructureType.StructureTypeDeviceQueueCreateInfo;
            queueCreateInfo.pNext = null;
            queueCreateInfo.flags = 0;
            queueCreateInfo.queueFamilyIndex = (uint)queueFamily;
            queueCreateInfo.queueCount = 1;
            float priority = 1.0f;
            queueCreateInfo.pQueuePriorities = &priority;

            VkPhysicalDeviceFeatures deviceFeatures = default;

            VkDeviceCreateInfo deviceCreateInfo;
            deviceCreateInfo.sType = VkStructureType.StructureTypeDeviceCreateInfo;
            deviceCreateInfo.pNext = null;
            deviceCreateInfo.flags = 0;
            deviceCreateInfo.queueCreateInfoCount = 1;
            deviceCreateInfo.pQueueCreateInfos = &queueCreateInfo;
            deviceCreateInfo.enabledLayerCount = 0;
            deviceCreateInfo.ppEnabledLayerNames = null;
            deviceCreateInfo.enabledExtensionCount = 1;
            ReadOnlySpan<byte> extensionNames = "VK_KHR_swapchain"u8;
            fixed (byte* extptr = extensionNames)
            {
                deviceCreateInfo.ppEnabledExtensionNames = &extptr;
                deviceCreateInfo.pEnabledFeatures = &deviceFeatures;

                VkDevice device;
                result = Vk.CreateDevice(PhysicalDevice, &deviceCreateInfo, null, &device);
                Device = device;
            }
            if (result != VkResult.Success)
            {
                throw new Exception($"Was not able to create logical device: {result}");
            }


            VkQueue graphicsQueue;
            Vk.GetDeviceQueue(Device, (uint)queueFamily, 0, &graphicsQueue);
            GraphicsQueue = graphicsQueue;

            result = Toolkit.Vulkan.CreateWindowSurface(instance, Window, null, out Surface);

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
                if (surfaceFormats[i].format == VkFormat.FormatR8g8b8a8Srgb)
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
            result = Vk.CreateSwapchainKHR(Device, &swapchainCreate, null, &swapchain);
            Swapchain = swapchain;

            SwapchainExtents = swapchainCreate.imageExtent;

            uint swapchainImageCount;
            result = Vk.GetSwapchainImagesKHR(Device, swapchain, &swapchainImageCount, null);

            Span<VkImage> swapchainImages = new VkImage[swapchainImageCount];
            result = Vk.GetSwapchainImagesKHR(Device, swapchain, &swapchainImageCount, (VkImage*)Unsafe.AsPointer(ref MemoryMarshal.GetReference(swapchainImages)));

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
            colorAttachment.format = choosenFormat.format;
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
            result = Vk.CreateRenderPass(Device, &renderPassCreateInfo, null, &renderPass);
            RenderPass = renderPass;

            SwapchainImageViews = new VkImageView[swapchainImages.Length];
            SwapchainFramebuffers = new VkFramebuffer[swapchainImages.Length];
            for (int i = 0; i < swapchainImages.Length; i++)
            {
                VkImageViewCreateInfo imgViewCreate;
                imgViewCreate.sType = VkStructureType.StructureTypeImageViewCreateInfo;
                imgViewCreate.pNext = null;
                imgViewCreate.flags = 0;
                imgViewCreate.image = swapchainImages[i];
                imgViewCreate.viewType = VkImageViewType.ImageViewType2d;
                imgViewCreate.format = VkFormat.FormatR8g8b8a8Srgb;
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
                result = Vk.CreateImageView(Device, &imgViewCreate, null, &imgView);
                SwapchainImageViews[i] = imgView;

                VkFramebufferCreateInfo fbCreate;
                fbCreate.sType = VkStructureType.StructureTypeFramebufferCreateInfo;
                fbCreate.pNext = null;
                fbCreate.flags = 0;
                fbCreate.renderPass = renderPass;
                fbCreate.attachmentCount = 1;
                fbCreate.pAttachments = &imgView;
                fbCreate.width = swapchainCreate.imageExtent.width;
                fbCreate.height = swapchainCreate.imageExtent.height;
                fbCreate.layers = 1;

                VkFramebuffer framebuffer;
                result = Vk.CreateFramebuffer(Device, &fbCreate, null, &framebuffer);
                SwapchainFramebuffers[i] = framebuffer;
            }

            VkCommandPoolCreateInfo commandPoolCreate;
            commandPoolCreate.sType = VkStructureType.StructureTypeCommandPoolCreateInfo;
            commandPoolCreate.pNext = null;
            commandPoolCreate.flags = VkCommandPoolCreateFlagBits.CommandPoolCreateResetCommandBufferBit;
            commandPoolCreate.queueFamilyIndex = (uint)queueFamily;

            VkCommandPool commandPool;
            result = Vk.CreateCommandPool(Device, &commandPoolCreate, null, &commandPool);
            CommandPool = commandPool;

            VkCommandBufferAllocateInfo cmdBufferAlloc;
            cmdBufferAlloc.sType = VkStructureType.StructureTypeCommandBufferAllocateInfo;
            cmdBufferAlloc.pNext = null;
            cmdBufferAlloc.commandPool = commandPool;
            cmdBufferAlloc.level = VkCommandBufferLevel.CommandBufferLevelPrimary;
            cmdBufferAlloc.commandBufferCount = 1;

            VkCommandBuffer commandBuffer;
            result = Vk.AllocateCommandBuffers(Device, &cmdBufferAlloc, &commandBuffer);
            CommandBuffer = commandBuffer;

            {
                VkSemaphoreCreateInfo semaphoreCreate;
                semaphoreCreate.sType = VkStructureType.StructureTypeSemaphoreCreateInfo;
                semaphoreCreate.pNext = null;
                semaphoreCreate.flags = 0;

                VkSemaphore imageAvail;
                result = Vk.CreateSemaphore(Device, &semaphoreCreate, null, &imageAvail);
                ImageAvailableSemaphore = imageAvail;

                VkSemaphore renderFinished;
                result = Vk.CreateSemaphore(Device, &semaphoreCreate, null, &renderFinished);
                RenderFinishedSemaphore = renderFinished;

                VkFenceCreateInfo fenceCreate;
                fenceCreate.sType = VkStructureType.StructureTypeFenceCreateInfo;
                fenceCreate.pNext = null;
                fenceCreate.flags = VkFenceCreateFlagBits.FenceCreateSignaledBit;

                VkFence inFlight;
                result = Vk.CreateFence(Device, &fenceCreate, null, &inFlight);
                InFlightFence = inFlight;
            }

            static int FindQueueFamily(VkPhysicalDevice physicalDevice)
            {
                uint propertyCount = 0;
                Vk.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, &propertyCount, null);

                Span<VkQueueFamilyProperties> familyProperties = stackalloc VkQueueFamilyProperties[(int)propertyCount];
                fixed (VkQueueFamilyProperties* ptr = familyProperties)
                    Vk.GetPhysicalDeviceQueueFamilyProperties(physicalDevice, &propertyCount, ptr);

                for (int i = 0; i < propertyCount; i++)
                {
                    if ((familyProperties[i].queueFlags & VkQueueFlagBits.QueueGraphicsBit) != 0)
                        return i;
                }

                throw new Exception("Found no suitable queue family.");
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

            Vk.DeviceWaitIdle(Device);

            for (int i = 0; i < SwapchainImageViews.Length; i++)
            {
                Vk.DestroyFramebuffer(Device, SwapchainFramebuffers[i], null);
                Vk.DestroyImageView(Device, SwapchainImageViews[i], null);
            }
            Vk.DestroySwapchainKHR(Device, Swapchain, null);

            Vk.DestroyCommandPool(Device, CommandPool, null);

            Vk.DestroyRenderPass(Device, RenderPass, null);

            Vk.DestroySemaphore(Device, ImageAvailableSemaphore, null);
            Vk.DestroySemaphore(Device, RenderFinishedSemaphore, null);
            Vk.DestroyFence(Device, InFlightFence, null);

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
                result = Vk.WaitForFences(Device, 1, inFlightFencePtr, 1, ulong.MaxValue);
                Vk.ResetFences(Device, 1, inFlightFencePtr);
            }

            uint imageIndex;
            result = Vk.AcquireNextImageKHR(Device, Swapchain, ulong.MaxValue, ImageAvailableSemaphore, VkFence.Zero, &imageIndex);

            result = Vk.ResetCommandBuffer(CommandBuffer, 0);
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

                Vk.QueueSubmit(GraphicsQueue, 1, &submitInfo, InFlightFence);

                VkPresentInfoKHR presentInfo;
                presentInfo.sType = VkStructureType.StructureTypePresentInfoKhr;
                presentInfo.pNext = null;
                presentInfo.waitSemaphoreCount = 1;
                presentInfo.pWaitSemaphores = renderFinishedSemaphorePtr;
                presentInfo.swapchainCount = 1;
                presentInfo.pSwapchains = swapchainPtr;
                presentInfo.pImageIndices = &imageIndex;
                presentInfo.pResults = null;

                result = Vk.QueuePresentKHR(GraphicsQueue, &presentInfo);
            }
        }

        static unsafe void RecordCommandBuffer(VkCommandBuffer commandBuffer, VkRenderPass renderPass, VkFramebuffer framebuffer, VkExtent2D imageExtent, float time)
        {
            VkCommandBufferBeginInfo beginInfo;
            beginInfo.sType = VkStructureType.StructureTypeCommandBufferBeginInfo;
            beginInfo.pNext = null;
            beginInfo.flags = 0;
            beginInfo.pInheritanceInfo = null;

            VkResult result = Vk.BeginCommandBuffer(commandBuffer, &beginInfo);

            VkRenderPassBeginInfo renderPassInfo;
            renderPassInfo.sType = VkStructureType.StructureTypeRenderPassBeginInfo;
            renderPassInfo.pNext = null;
            renderPassInfo.renderPass = renderPass;
            renderPassInfo.framebuffer = framebuffer;
            renderPassInfo.renderArea.offset = new VkOffset2D() { x = 0, y = 0 };
            renderPassInfo.renderArea.extent = imageExtent;
            renderPassInfo.clearValueCount = 1;

            Color4<Rgba> color = new Color4<Hsva>(time / CycleTime, 1, 1, 1).ToRgba();

            VkClearValue clearValue = default;
            clearValue.color.float32[0] = color.X;
            clearValue.color.float32[1] = color.Y;
            clearValue.color.float32[2] = color.Z;
            clearValue.color.float32[3] = color.W;
            renderPassInfo.pClearValues = &clearValue;

            Vk.CmdBeginRenderPass(commandBuffer, &renderPassInfo, VkSubpassContents.SubpassContentsInline);

            Vk.CmdEndRenderPass(commandBuffer);

            result = Vk.EndCommandBuffer(commandBuffer);
        }

    }
}
