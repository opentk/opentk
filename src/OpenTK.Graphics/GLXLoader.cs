using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics
{
    // FIXME: Actually implement this properly.
    public static class GLXLoader
    {
        public static class BindingsContext
        {
            public static unsafe IntPtr GetProcAddress(string procName)
            {
                if (NativeLibrary.TryGetExport(GLXHandle, procName, out IntPtr ret))
                {
                    return ret;
                }

                if (glXGetProcAddress != null)
                {
                    byte* str = (byte*)Marshal.StringToCoTaskMemAnsi(procName);
                    ret = glXGetProcAddress(str);
                    Marshal.FreeCoTaskMem((IntPtr)str);

                    if (ret != IntPtr.Zero)
                    {
                        return ret;
                    }
                }

                if (glXGetProcAddressARB != null)
                {
                    byte* str = (byte*)Marshal.StringToCoTaskMemAnsi(procName);
                    ret = glXGetProcAddressARB(str);
                    Marshal.FreeCoTaskMem((IntPtr)str);

                    if (ret != IntPtr.Zero)
                    {
                        return ret;
                    }
                }

                return 0;
            }
        }

        // FIXME: More advanced .so resolution?
        private static readonly IntPtr GLXHandle = NativeLibrary.Load("libGL.so");

        // Unfortunately we can't mark function pointers as nullable, but
        // if the function cannot be loaded it's null so we need to check before using.
        // - Noggin_bops 2024-03-07
        private static readonly unsafe delegate* unmanaged<byte*, IntPtr> glXGetProcAddress;
        private static readonly unsafe delegate* unmanaged<byte*, IntPtr> glXGetProcAddressARB;

        // Try load the function pointers..
        static unsafe GLXLoader()
        {
            NativeLibrary.TryGetExport(GLXHandle, "glXGetProcAddress", out IntPtr ptr);
            glXGetProcAddress = (delegate* unmanaged<byte*, IntPtr>)ptr;

            NativeLibrary.TryGetExport(GLXHandle, "glXGetProcAddressARB", out ptr);
            glXGetProcAddressARB = (delegate* unmanaged<byte*, IntPtr>)ptr;
        }
    }
}
