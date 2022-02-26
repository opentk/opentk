using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
#pragma warning disable SA1516 // Elements should be separated by blank line
#pragma warning disable SA1401 // Fields should be private
    internal static class Wgl
    {
        [DllImport("opengl32.dll", EntryPoint = "wglCreateContext", SetLastError = true)]
        internal static extern IntPtr CreateContext(IntPtr hdc);

        [DllImport("opengl32.dll", EntryPoint = "wglDeleteContext", SetLastError = true)]
        internal static extern bool DeleteContext(IntPtr hglrc);

        [DllImport("opengl32.dll", EntryPoint = "wglMakeCurrent", SetLastError = true)]
        internal static extern bool MakeCurrent(IntPtr hdc, IntPtr hglrc);

        [DllImport("opengl32.dll", EntryPoint = "wglGetCurrentContext", SetLastError = true)]
        internal static extern IntPtr GetCurrentContext();

        [DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress", SetLastError = true)]
        internal static extern unsafe void* GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procName);

        internal static unsafe void* GetAnyProcAddress(string procName)
        {
            void* p = GetProcAddress(procName);
            if (p == (void*)0 ||
              (p == (void*)0x1) || (p == (void*)0x2) || (p == (void*)0x3) ||
              (p == (void*)-1))
            {
                // FIXME: Make this only load this once?
                IntPtr module = Win32.LoadLibrary("opengl32.dll");
                p = (void*)Win32.GetProcAddress(module, procName);
            }

            return p;
        }

        internal static unsafe delegate* unmanaged<IntPtr, byte*> _GetExtensionsStringARB__fnptr = &GetExtensionsStringARB__Lazy;
        public static unsafe byte* GetExtensionsStringARB_(IntPtr hdc) => _GetExtensionsStringARB__fnptr(hdc);
        [UnmanagedCallersOnly]
        private static unsafe byte* GetExtensionsStringARB__Lazy(IntPtr hdc)
        {
            _GetExtensionsStringARB__fnptr = (delegate* unmanaged<IntPtr, byte*>)GetProcAddress("wglGetExtensionsStringARB");
            return _GetExtensionsStringARB__fnptr(hdc);
        }
        public static unsafe string? GetExtensionsStringARB(IntPtr hdc)
        {
            byte* returnValue;
            string? returnValue_str;
            returnValue = GetExtensionsStringARB_(hdc);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
    }
#pragma warning restore SA1401 // Fields should be private
#pragma warning restore SA1516 // Elements should be separated by blank line
}
