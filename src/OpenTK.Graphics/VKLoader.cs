using OpenTK.Graphics.Vulkan;
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Used to load the Vulkan bindings.
    /// </summary>
    public static unsafe class VKLoader
    {
        internal static IntPtr VulkanHandle;

        internal static VkInstance Instance;

        /// <summary>
        /// Loads the vulkan native libraries and initializes the vulkan loader.
        /// </summary>
        /// <exception cref="PlatformNotSupportedException">We don't know the path to the vulkan binaries on this platform.</exception>
        /// <exception cref="EntryPointNotFoundException">Couldn't load <c>vkGetInstanceProcAddr</c> from the loaded vulkan library.</exception>
        public static void Init()
        {
            if (VulkanHandle != IntPtr.Zero)
            {
                return;
            }

            if (OperatingSystem.IsWindows())
            {
                VulkanHandle = NativeLibrary.Load("vulkan-1.dll");
            }
            else if (OperatingSystem.IsLinux())
            {
                VulkanHandle = NativeLibrary.Load("libvulkan.so.1");
            }
            else if (OperatingSystem.IsFreeBSD())
            {
                VulkanHandle = NativeLibrary.Load("libvulkan.so");
            }
            else if (OperatingSystem.IsMacOS())
            {
                VulkanHandle = NativeLibrary.Load("libvulkan.1.dylib");
            }
            else
            {
                throw new PlatformNotSupportedException();
            }

            if (NativeLibrary.TryGetExport(VulkanHandle, "vkGetInstanceProcAddr", out IntPtr vkGetInstanceProcAddrFnptr) == false)
            {
                throw new EntryPointNotFoundException("Could not load vkGetInstanceProcAddr.");
            }

            VkPointers._vkGetInstanceProcAddr_fnptr = (delegate* unmanaged<VkInstance, byte*, delegate* unmanaged[Cdecl]<void>>)vkGetInstanceProcAddrFnptr;
        }

        /// <summary>
        /// Set the <see cref="VkInstance"/> to use to load functions when calling functions directly on <see cref="Vk"/>.
        /// </summary>
        /// <param name="instance">The <see cref="VkInstance"/> to use to load functions.</param>
        /// <seealso cref="InstanceDispatchTable"/>
        /// <seealso cref="DeviceDispatchTable"/>
        public static void SetInstance(VkInstance instance)
        {
            Instance = instance;
        }

        /// <summary>
        /// Gets a function pointer to an instance function using the <see cref="VkInstance"/> set in <see cref="SetInstance(VkInstance)"/> to load the function.
        /// </summary>
        /// <param name="name">The name of the instance function to load.</param>
        /// <returns>The loaded function pointer, or null.</returns>
        public static IntPtr GetInstanceProcAddress(string name)
        {
            return GetInstanceProcAddress(Instance, name);
        }

        /// <summary>
        /// Gets a function pointer to an instance function using the <see cref="VkInstance"/> provided in <paramref name="instance"/> to load the function.
        /// </summary>
        /// <param name="instance">The instance to use when loading function pointers.</param>
        /// <param name="name">The name of the function to load.</param>
        /// <returns>The loaded function pointer, or null.</returns>
        public static IntPtr GetInstanceProcAddress(VkInstance instance, string name)
        {
            //Vulkan.VkPointers._GetInstanceProcAddr_fnptr =
            IntPtr data = Marshal.StringToCoTaskMemAnsi(name);
            IntPtr fnptr = (IntPtr)Vk.GetInstanceProcAddr(instance, (byte*)data);
            Marshal.FreeCoTaskMem(data);

            if (fnptr == 0)
            {
                NativeLibrary.TryGetExport(VulkanHandle, name, out fnptr);
            }

            return fnptr;
        }

        /// <summary>
        /// Calls <see cref="Vk.GetDeviceProcAddr(VkDevice, byte*)"/>.
        /// </summary>
        /// <param name="device">The device load a function pointer from.</param>
        /// <param name="name">The name of the function to load.</param>
        /// <returns>The function pointer, or null.</returns>
        public static IntPtr GetDeviceProcAddr(VkDevice device, string name)
        {
            IntPtr data = Marshal.StringToCoTaskMemAnsi(name);
            IntPtr fnptr = (IntPtr)Vk.GetDeviceProcAddr(device, (byte*)data);
            Marshal.FreeCoTaskMem(data);

            return fnptr;
        }
    }
}
