using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics
{
    interface IVKBindingsContext
    {

    }

    internal static unsafe class VKLoader
    {
        public static IntPtr VulkanHandle;

        public static IntPtr Instance;

        public static void Init()
        {
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

            Vulkan.VkPointers._vkGetInstanceProcAddr_fnptr = (delegate* unmanaged<IntPtr, byte*, IntPtr>)vkGetInstanceProcAddrFnptr;
        }

        public static void SetInstance(IntPtr instance)
        {
            Instance = instance;
        }

        public static IntPtr GetInstanceProcAddress(string name)
        {
            //Vulkan.VkPointers._GetInstanceProcAddr_fnptr =
            IntPtr data = Marshal.StringToCoTaskMemAnsi(name);
            IntPtr fnptr = Vulkan.Vk.GetInstanceProcAddr(Instance, (byte*)data);
            Marshal.FreeCoTaskMem(data);

            if (fnptr == 0)
            {
                NativeLibrary.TryGetExport(VulkanHandle, name, out fnptr);
            }

            return fnptr;
        }
    }
}
