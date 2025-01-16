using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
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

        // FIXME: By default let the OS decide, if that fails use vendor. Add other vendor GLX versions.
        static readonly string[] LibraryNames = new string[]
            {
                "libGLX.so",
                "libGLX.so.0",
                "libGLX_nvidia.so.1",
                "libGLX_nvidia.so.0",
                "libGLX_mesa.so.0",
            };

        // FIXME: Is it possible to make an API for users to provide additional search paths?
        private static IntPtr LoadGLX()
        {
            foreach (string name in LibraryNames)
            {
                if (NativeLibrary.TryLoad(name, out IntPtr handle))
                {
                    return handle;
                }
            }

            return 0;
        }

        private static readonly IntPtr GLXHandle;

        // Unfortunately we can't mark function pointers as nullable, but
        // if the function cannot be loaded it's null so we need to check before using.
        // - Noggin_bops 2024-03-07
        private static readonly unsafe delegate* unmanaged<byte*, IntPtr> glXGetProcAddress;
        private static readonly unsafe delegate* unmanaged<byte*, IntPtr> glXGetProcAddressARB;

        static unsafe GLXLoader()
        {
            GLXHandle = LoadGLX();
            if (GLXHandle == 0)
            {
                throw new DllNotFoundException($"Could not find libGLX (we searched these names '{string.Join(", ", LibraryNames)}'). Either glX is not installed or this is an OpenTK library searching bug.");
            }

            // Try load the function pointers, this could return null.
            NativeLibrary.TryGetExport(GLXHandle, "glXGetProcAddress", out IntPtr ptr);
            glXGetProcAddress = (delegate* unmanaged<byte*, IntPtr>)ptr;

            NativeLibrary.TryGetExport(GLXHandle, "glXGetProcAddressARB", out ptr);
            glXGetProcAddressARB = (delegate* unmanaged<byte*, IntPtr>)ptr;
        }
    }
}
