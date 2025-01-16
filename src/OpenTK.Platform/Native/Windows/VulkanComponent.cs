using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.Vulkan;
using System;

namespace OpenTK.Platform.Native.Windows
{
    internal class VulkanComponent : IVulkanComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(VulkanComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Vulkan;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        internal static readonly string[] Win32RequiredExtensions = ["VK_KHR_surface", "VK_KHR_win32_surface"];

        /// <inheritdoc/>
        public ReadOnlySpan<string> GetRequiredInstanceExtensions()
        {
            return Win32RequiredExtensions;
        }

        /// <inheritdoc/>
        public unsafe bool GetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint queueFamily)
        {
            delegate* unmanaged<VkPhysicalDevice, uint, int> _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr =
                (delegate* unmanaged<VkPhysicalDevice, uint, int>)VKLoader.GetInstanceProcAddress(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR");
            if (_vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr == null)
            {
                throw new InvalidOperationException("Could not load vkGetPhysicalDeviceWin32PresentationSupportKHR entry point, the VK_KHR_win32_surface extension is probably missing.");
            }

            return _vkGetPhysicalDeviceWin32PresentationSupportKHR_fnptr(device, queueFamily) != 0;
        }

        /// <inheritdoc/>
        public unsafe VkResult CreateWindowSurface(VkInstance instance, WindowHandle window, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface)
        {
            HWND hwnd = window.As<HWND>(this);

            delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> _vkCreateWin32SurfaceKHR_fnptr =
                (delegate* unmanaged<VkInstance, VkWin32SurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)VKLoader.GetInstanceProcAddress(instance, "vkCreateWin32SurfaceKHR");
            if (_vkCreateWin32SurfaceKHR_fnptr == null)
            {
                throw new PalException(this, "Could not load vkCreateWin32SurfaceKHR entry point, the VK_KHR_win32_surface extension is probably missing.");
            }

            VkWin32SurfaceCreateInfoKHR surfaceCreateInfo;
            surfaceCreateInfo.sType = VkStructureType.StructureTypeWin32SurfaceCreateInfoKhr;
            surfaceCreateInfo.pNext = null;
            surfaceCreateInfo.flags = 0;
            surfaceCreateInfo.hinstance = WindowComponent.HInstance;
            surfaceCreateInfo.hwnd = hwnd.HWnd;

            VkResult result;
            fixed (VkSurfaceKHR* surfacePtr = &surface)
            {
                result = _vkCreateWin32SurfaceKHR_fnptr(instance, &surfaceCreateInfo, allocator, surfacePtr);
            }

            if (result != VkResult.Success)
            {
                Logger?.LogInfo($"Could not create win32 vulkan surface: {result}");
            }

            return result;
        }
    }
}
