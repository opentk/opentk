using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    // FIXME: Actually implement this properly.
    /// <summary>
    /// Used to load the EGL bindings.
    /// </summary>
    public static class EGLLoader
    {
        /// <summary>
        /// The bindings context for EGL.
        /// </summary>
        public static class BindingsContext
        {
            /// <summary>
            /// Return a GL or an EGL extension function
            /// </summary>
            /// <param name="procName">Specifies the name of the function to return.</param>
            /// <returns>The function pointer if it exitst or null.</returns>
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
