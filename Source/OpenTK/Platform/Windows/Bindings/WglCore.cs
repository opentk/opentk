namespace OpenTK.Platform.Windows
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class Wgl
    {

        internal static partial class Imports
        {

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError=true)]
            internal extern static IntPtr CreateContext(IntPtr hDc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
            internal extern static Boolean DeleteContext(IntPtr oldContext);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true, SetLastError=true)]
            internal extern static IntPtr GetCurrentContext();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError=true)]
            internal extern static Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglCopyContext", ExactSpelling = true, SetLastError = true)]
            internal extern static unsafe int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor* pPfd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglDescribePixelFormat", ExactSpelling = true, SetLastError = true)]
            internal extern static unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, PixelFormatDescriptor* ppfd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true, SetLastError = true)]
            internal extern static IntPtr GetCurrentDC();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglGetDefaultProcAddress", ExactSpelling = true, SetLastError = true)]
            internal extern static IntPtr GetProcAddress(String lpszProc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglGetPixelFormat", ExactSpelling = true, SetLastError = true)]
            internal extern static int GetPixelFormat(IntPtr hdc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglSetPixelFormat", ExactSpelling = true, SetLastError = true)]
            internal extern static unsafe Boolean SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglSwapBuffers", ExactSpelling = true, SetLastError = true)]
            internal extern static Boolean SwapBuffers(IntPtr hdc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
            internal extern static Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
        }
    }
}
