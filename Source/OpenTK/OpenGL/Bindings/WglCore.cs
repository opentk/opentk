namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    partial class Wgl
    {

        internal static class Imports
        {
            static Imports() { }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glCreateContext", ExactSpelling = true)]
            internal extern static IntPtr CreateContext(IntPtr hDc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glDeleteContext", ExactSpelling = true)]
            internal extern static Boolean DeleteContext(IntPtr oldContext);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glGetCurrentContext", ExactSpelling = true)]
            internal extern static IntPtr GetCurrentContext();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glMakeCurrent", ExactSpelling = true)]
            internal extern static Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glCopyContext", ExactSpelling = true)]
            internal extern static Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glChoosePixelFormat", ExactSpelling = true)]
            internal extern static int ChoosePixelFormat(IntPtr hDc, OpenTK.Platform.Windows.API.PixelFormatDescriptor pPfd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glDescribePixelFormat", ExactSpelling = true)]
            internal extern static int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glGetCurrentDC", ExactSpelling = true)]
            internal extern static IntPtr GetCurrentDC();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glGetDefaultProcAddress", ExactSpelling = true)]
            internal extern static IntPtr GetDefaultProcAddress(String lpszProc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glGetProcAddress", ExactSpelling = true)]
            internal extern static IntPtr GetProcAddress(String lpszProc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glGetPixelFormat", ExactSpelling = true)]
            internal extern static int GetPixelFormat(IntPtr hdc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glSetPixelFormat", ExactSpelling = true)]
            internal extern static Boolean SetPixelFormat(IntPtr hdc, int ipfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glSwapBuffers", ExactSpelling = true)]
            internal extern static Boolean SwapBuffers(IntPtr hdc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glShareLists", ExactSpelling = true)]
            internal extern static Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glCreateLayerContext", ExactSpelling = true)]
            internal extern static IntPtr CreateLayerContext(IntPtr hDc, int level);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glDescribeLayerPlane", ExactSpelling = true)]
            internal extern static Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, OpenTK.Platform.Windows.API.LayerPlaneDescriptor plpd);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glSetLayerPaletteEntries", ExactSpelling = true)]
            internal extern static int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glGetLayerPaletteEntries", ExactSpelling = true)]
            internal extern static int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glRealizeLayerPalette", ExactSpelling = true)]
            internal extern static Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glSwapLayerBuffers", ExactSpelling = true)]
            internal extern static Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glUseFontBitmapsA", ExactSpelling = true)]
            internal extern static Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Wgl.Library, EntryPoint = "glUseFontBitmapsW", ExactSpelling = true)]
            internal extern static Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
        }
    }
}
