using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Used to load the WGL bindings.
    /// </summary>
    public static class WGLLoader
    {
        /// <summary>
        /// The bindings context for WGL.
        /// </summary>
        public static class BindingsContext
        {
            /// <summary>
            /// The wglGetProcAddress function returns the address of an OpenGL extension function for use with the current OpenGL rendering context.
            /// </summary>
            /// <param name="procName">Points to a null-terminated string that is the name of the extension function. The name of the extension function must be identical to a corresponding function implemented by OpenGL.</param>
            /// <returns>
            /// When the function succeeds, the return value is the address of the extension function.
            /// When no current rendering context exists or the function fails, the return value is NULL.
            /// To get extended error information, call GetLastError.
            /// </returns>
            public static IntPtr GetProcAddress(string procName)
            {
                if (NativeLibrary.TryGetExport(WGLHandle, procName, out IntPtr ret) == false)
                {
                    ret = wglGetProcAddress(procName);
                }
                return ret;
            }
        }

        private static readonly IntPtr WGLHandle = NativeLibrary.Load("opengl32.dll");

        [DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress", SetLastError = true)]
        internal static extern IntPtr wglGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procName);
    }
}
