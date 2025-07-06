using OpenTK.Graphics.OpenXR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics
{
    public static unsafe class XRLoader
    {
        public static IntPtr OpenXRHandle;

        public static XrInstance Instance;

        public static void Init()
        {
            if (OpenXRHandle != IntPtr.Zero)
            {
                return;
            }

            if (OperatingSystem.IsWindows())
            {
                // FIXME: 
                //OpenXRHandle = NativeLibrary.Load("vulkan-1.dll");
            }
            else if (OperatingSystem.IsLinux())
            {
                // FIXME: 
                //OpenXRHandle = NativeLibrary.Load("libvulkan.so.1");
            }
            else if (OperatingSystem.IsFreeBSD())
            {
                // FIXME: 
                //OpenXRHandle = NativeLibrary.Load("libvulkan.so");
            }
            else if (OperatingSystem.IsMacOS())
            {
                // FIXME: 
                //OpenXRHandle = NativeLibrary.Load("libvulkan.1.dylib");
            }
            else
            {
                throw new PlatformNotSupportedException();
            }

            if (NativeLibrary.TryGetExport(OpenXRHandle, "xrGetInstanceProcAddr", out IntPtr xrGetInstanceProcAddrFnptr) == false)
            {
                throw new EntryPointNotFoundException("Could not load xrGetInstanceProcAddr.");
            }

            XrPointers._xrGetInstanceProcAddr_fnptr = (delegate* unmanaged<XrInstance, byte*, delegate* unmanaged[Cdecl]<void>*, XrResult>)xrGetInstanceProcAddrFnptr;
        }

        public static void SetInstance(XrInstance instance)
        {
            Instance = instance;
        }

        public static XrResult GetInstanceProcAddress(string name, out IntPtr fnptr)
        {
            return GetInstanceProcAddress(default, name, out fnptr);
        }

        public static XrResult GetInstanceProcAddress(XrInstance instance, string name, out IntPtr fnptr)
        {
            //Vulkan.VkPointers._GetInstanceProcAddr_fnptr =
            IntPtr data = Marshal.StringToCoTaskMemAnsi(name);
            delegate* unmanaged[Cdecl]<void> fnptr_t;
            XrResult result = Xr.GetInstanceProcAddr(instance, (byte*)data, &fnptr_t);
            fnptr = (IntPtr)fnptr_t;
            Marshal.FreeCoTaskMem(data);

            //if (fnptr == 0)
            //{
            //    NativeLibrary.TryGetExport(OpenXRHandle, name, out fnptr);
            //}

            return result;
        }
    }
}
