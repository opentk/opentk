using OpenTK.Graphics.Wgl;
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
