using System;
using OpenTK.Core.Utility;
using OpenTK.Graphics;
using OpenTK.Graphics.Vulkan;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.LibXcb;

namespace OpenTK.Platform.Native.X11
{
    public class X11VulkanComponent : IVulkanComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11VulkanComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Vulkan;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            // FIXME: We want some way to avoid calling this if we are not going to be using vulkan...
            // Maybe we make the initialization of the vulkan component separate?
            // Or we could make it a toolkit setting...
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
                else if (name.SequenceEqual("VK_KHR_xcb_surface"u8))
                    KHR_xcb_surface = true;
                else if (name.SequenceEqual("VK_KHR_xlib_surface"u8))
                    KHR_xlib_surface = true;
            }
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        internal bool KHR_surface;
        internal bool KHR_xcb_surface;
        internal bool KHR_xlib_surface;

        internal static readonly string[] XCBRequiredExtensions = ["VK_KHR_surface", "VK_KHR_xcb_surface"];
        internal static readonly string[] XLibRequiredExtensions = ["VK_KHR_surface", "VK_KHR_xlib_surface"];

        /// <inheritdoc/>
        public ReadOnlySpan<string> GetRequiredInstanceExtensions()
        {
            if (KHR_surface == false)
            {
                Logger?.LogWarning("VK_KHR_surface is not supported. Won't be able to create vulkan windows.");
                return [];
            }

            if (KHR_xcb_surface)
            {
                return XCBRequiredExtensions;
            }
            else if (KHR_xlib_surface)
            {
                return XLibRequiredExtensions;
            }
            else
            {
                Logger?.LogWarning("Missing both VK_KHR_xcb_surface and VK_KHR_xlib_surface. Won't be able to create vulkan windows.");
                return [];
            }
        }

        /// <inheritdoc/>
        public unsafe bool GetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint queueFamily)
        {
            XVisualId visualId = XVisualIDFromVisual(XDefaultVisual(X11.Display, X11.DefaultScreen));

            if (KHR_xcb_surface)
            {
                xcb_connection_t* connection = XGetXCBConnection(X11.Display);
                if (connection == null)
                {
                    Logger?.LogError($"Failed to get xcb connection. Can't query presentation support.");
                    return false;
                }

                return Vk.GetPhysicalDeviceXcbPresentationSupportKHR(device, queueFamily, (nint)connection, (uint)visualId.Id) != 0;
            }
            else if (KHR_xlib_surface)
            {
                return Vk.GetPhysicalDeviceXlibPresentationSupportKHR(device, queueFamily, X11.Display.Value, (nuint)visualId.Id) != 0;
            }
            else
            {
                Logger?.LogError("Missing both VK_KHR_xcb_surface and VK_KHR_xlib_surface. Can't query presentation support.");
                return false;
            }
        }

        /// <inheritdoc/>
        public unsafe VkResult CreateWindowSurface(VkInstance instance, WindowHandle window, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface)
        {
            XWindowHandle xwindow = window.As<XWindowHandle>(this);

            if (KHR_xcb_surface)
            {
                VkXcbSurfaceCreateInfoKHR xsci = new VkXcbSurfaceCreateInfoKHR();
                xsci.connection = (nint)XGetXCBConnection(X11.Display);
                if (xsci.connection == 0)
                {
                    Logger?.LogError($"Failed to get xcb connection. Can't create window surface.");
                    surface = VkSurfaceKHR.Zero;
                    return VkResult.ErrorExtensionNotPresent;
                }
                // FIXME: xcb_window_t is uint while xlib uses nuint for windows?
                xsci.window = (uint)xwindow.Window.Id;

                fixed (VkSurfaceKHR* surfacePtr = &surface)
                {
                    VkResult result = Vk.CreateXcbSurfaceKHR(instance, &xsci, allocator, surfacePtr);
                    if (result != VkResult.Success)
                    {
                        Logger?.LogError($"Could not create vulkan surface using vkCreateXcbSurfaceKHR: {result}");
                        return result;
                    }
                }

                return VkResult.Success;
            }
            else if (KHR_xlib_surface)
            {
                VkXlibSurfaceCreateInfoKHR xsci = new VkXlibSurfaceCreateInfoKHR();
                xsci.dpy = X11.Display.Value;
                // FIXME: XID type should be nuint
                xsci.window = (nuint)xwindow.Window.Id;

                fixed (VkSurfaceKHR* surfacePtr = &surface)
                {
                    VkResult result = Vk.CreateXlibSurfaceKHR(instance, &xsci, allocator, surfacePtr);
                    if (result != VkResult.Success)
                    {
                        Logger?.LogError($"Could not create vulkan surface using vkCreateXlibSurfaceKHR: {result}");
                        return result;
                    }
                }

                return VkResult.Success;
            }
            else
            {
                Logger?.LogError("Missing both VK_KHR_xcb_surface and VK_KHR_xlib_surface. Can't create window surface.");
                surface = VkSurfaceKHR.Zero;
                return VkResult.ErrorExtensionNotPresent;
            }
        }
    }
}

