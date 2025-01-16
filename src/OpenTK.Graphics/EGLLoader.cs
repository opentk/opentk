using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    // FIXME: Actually implement this properly.
    public static class EGLLoader
    {
        public static class BindingsContext
        {
            public static unsafe IntPtr GetProcAddress(string procName)
            {
                byte* str = (byte*)Marshal.StringToCoTaskMemAnsi(procName);
                IntPtr ret = eglGetProcAddress(str);
                Marshal.FreeCoTaskMem((IntPtr)str);

                if (ret != IntPtr.Zero)
                {
                    return ret;
                }

                return 0;

                [DllImport("libEGL")]
                static extern IntPtr eglGetProcAddress(byte* proc);
            }
        }
    }
}
