using System;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.Vulkan;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    /// <summary>
    /// macOS vulkan component using VK_EXT_metal_surface or VK_MVK_macos_surface extensions to create 
    /// a vulkan surface using <see href="https://github.com/KhronosGroup/MoltenVK">MoltenVK</see> (part of the macOS Vulkan SDK).
    /// </summary>
    public class MacOSVulkanComponent : IVulkanComponent
    {
        internal static readonly SEL selLayer = sel_registerName("layer"u8);
        internal static readonly SEL selSetLayer = sel_registerName("setLayer:"u8);
        internal static readonly SEL selSetWantsLayer = sel_registerName("setWantsLayer:"u8);

        internal static readonly ObjCClass CAMetalLayerClass = objc_getClass("CAMetalLayer"u8);

        /// <inheritdoc/>
        public string Name => nameof(MacOSVulkanComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Vulkan;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            VKLoader.Init();

            VkPointers._vkEnumerateInstanceExtensionProperties_fnptr = 
                (delegate* unmanaged<byte*, uint*, VkExtensionProperties*, VkResult>)VKLoader.GetInstanceProcAddress(VkInstance.Zero, "vkEnumerateInstanceExtensionProperties");
            if (VkPointers._vkEnumerateInstanceExtensionProperties_fnptr == null)
            {
                Logger?.LogError("Could not load vkEnumerateInstanceExtensionProperties entry point.");
                return;
            }

            uint count;
            VkResult result = Vk.EnumerateInstanceExtensionProperties(null, &count, null);
            if (result != VkResult.Success)
            {
                Logger?.LogError($"Failed to get instance extension count: {result}");
                return;
            }

            VkExtensionProperties* properties = stackalloc VkExtensionProperties[(int)count];
            result = Vk.EnumerateInstanceExtensionProperties(null, &count, properties);
            if (result != VkResult.Success)
            {
                Logger?.LogError($"Failed to get instance extensions: {result}");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                ReadOnlySpan<byte> name = properties[i].extensionName;
                // FIXME: For some reason sometimes there is a stray non-zero byte
                // at the end of inline buffers. So TrimEnd fails.
                //name = name.TrimEnd([(byte)0]);
                name = name.Slice(0, name.IndexOf((byte)0));
                if (name.SequenceEqual("VK_KHR_surface"u8))
                    KHR_surface = true;
                else if (name.SequenceEqual("VK_EXT_metal_surface"u8))
                    EXT_metal_surface = true;
                else if (name.SequenceEqual("VK_MVK_macos_surface"u8))
                    MVK_macos_surface = true;
            }
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        internal bool KHR_surface;
        internal bool EXT_metal_surface;
        internal bool MVK_macos_surface;

        internal static readonly string[] MVKRequiredExtensions = [ "VK_KHR_surface", "VK_MVK_macos_surface" ];
        internal static readonly string[] MTLRequiredExtensions = [ "VK_KHR_surface", "VK_EXT_metal_surface" ];

        /// <inheritdoc/>
        public ReadOnlySpan<string> GetRequiredInstanceExtensions()
        {
            if (KHR_surface == false)
            {
                Logger?.LogWarning("VK_KHR_surface is not supported. Won't be able to create vulkan windows.");
                return [];
            }

            if (EXT_metal_surface)
            {
                return MTLRequiredExtensions;
            }
            else if (MVK_macos_surface)
            {
                return MVKRequiredExtensions;
            }
            else
            {
                Logger?.LogWarning("Missing both VK_EXT_metal_surface and VK_MVK_macos_surface. Won't be able to create vulkan windows.");
                return [];
            }
        }

        /// <inheritdoc/>
        public bool GetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint queueFamily)
        {
            return true;
        }

        /// <inheritdoc/>
        public unsafe VkResult CreateWindowSurface(VkInstance instance, WindowHandle window, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface)
        {
            NSWindowHandle nswindow = window.As<NSWindowHandle>(this);

            IntPtr mtlLayer = objc_msgSend_IntPtr((IntPtr)CAMetalLayerClass, selLayer);
            if (mtlLayer == 0)
            {
                Logger?.LogError("[CAMetalLayer layer] returned null. Can't create vulkan surface.");
                surface = VkSurfaceKHR.Zero;
                return VkResult.ErrorExtensionNotPresent;    
            }

            objc_msgSend(nswindow.View, selSetLayer, mtlLayer);
            // FIXME: BOOL
            objc_msgSend(nswindow.View, selSetWantsLayer, true);

            if (EXT_metal_surface)
            {
                VkMetalSurfaceCreateInfoEXT msci = new VkMetalSurfaceCreateInfoEXT();
                msci.pLayer = (IntPtr*)mtlLayer;

                VkResult result;
                fixed (VkSurfaceKHR* surfacePtr = &surface)
                {
                    result = Vk.CreateMetalSurfaceEXT(instance, &msci, allocator, surfacePtr);
                }

                if (result != VkResult.Success)
                {
                    Logger?.LogError($"vkCreateMetalSurfaceEXT failed with: {result}");
                }

                return result;
            }
            else if (MVK_macos_surface)
            {
                VkMacOSSurfaceCreateInfoMVK msci = new VkMacOSSurfaceCreateInfoMVK();
                msci.pView = (void*)mtlLayer;

                VkResult result;
                fixed (VkSurfaceKHR* surfacePtr = &surface)
                {
                    result = Vk.CreateMacOSSurfaceMVK(instance, &msci, allocator, surfacePtr);
                }

                if (result != VkResult.Success)
                {
                    Logger?.LogError($"vkCreateMacOSSurfaceMVK failed with: {result}");
                }

                return result;
            }
            else
            {
                Logger?.LogError("Missing both VK_EXT_metal_surface and VK_MVK_macos_surface. Can't create window surface.");
                surface = VkSurfaceKHR.Zero;
                return VkResult.ErrorExtensionNotPresent;
            }
        }
    }
}
