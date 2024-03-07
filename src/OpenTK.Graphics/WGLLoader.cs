using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics
{
    public static class WGLLoader
    {
        public static class BindingsContext
        {
            // FIXME: Extend this to be able to use wglGetProcAddress?
            // Alternatively allow for user provided bindings contexts to be used...
            // - Noggin_bops 2024-03-06
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
