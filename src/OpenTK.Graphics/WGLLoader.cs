using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    public static class WGLLoader
    {
        public static class BindingsContext
        {
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
