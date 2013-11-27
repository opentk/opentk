namespace OpenTK.Platform.Windows
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class Wgl
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateContext(IntPtr hDc);
            internal static CreateContext wglCreateContext;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DeleteContext(IntPtr oldContext);
            internal static DeleteContext wglDeleteContext;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentContext();
            internal static GetCurrentContext wglGetCurrentContext;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            internal static MakeCurrent wglMakeCurrent;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
            internal static CopyContext wglCopyContext;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor* pPfd);
            internal unsafe static ChoosePixelFormat wglChoosePixelFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, PixelFormatDescriptor* ppfd);
            internal unsafe static DescribePixelFormat wglDescribePixelFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentDC();
            internal static GetCurrentDC wglGetCurrentDC;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetDefaultProcAddress(String lpszProc);
            internal static GetDefaultProcAddress wglGetDefaultProcAddress;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetProcAddress(String lpszProc);
            internal static GetProcAddress wglGetProcAddress;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetPixelFormat(IntPtr hdc);
            internal static GetPixelFormat wglGetPixelFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd);
            internal unsafe static SetPixelFormat wglSetPixelFormat;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapBuffers(IntPtr hdc);
            internal static SwapBuffers wglSwapBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
            internal static ShareLists wglShareLists;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);
            internal unsafe static CreateContextAttribsARB wglCreateContextAttribsARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);
            internal static CreateBufferRegionARB wglCreateBufferRegionARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteBufferRegionARB(IntPtr hRegion);
            internal static DeleteBufferRegionARB wglDeleteBufferRegionARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
            internal static SaveBufferRegionARB wglSaveBufferRegionARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
            internal static RestoreBufferRegionARB wglRestoreBufferRegionARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringARB(IntPtr hdc);
            internal static GetExtensionsStringARB wglGetExtensionsStringARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivARB wglGetPixelFormatAttribivARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvARB wglGetPixelFormatAttribfvARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal unsafe static ChoosePixelFormatARB wglChoosePixelFormatARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentARB wglMakeContextCurrentARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCARB();
            internal static GetCurrentReadDCARB wglGetCurrentReadDCARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferARB wglCreatePbufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCARB(IntPtr hPbuffer);
            internal static GetPbufferDCARB wglGetPbufferDCARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCARB wglReleasePbufferDCARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferARB(IntPtr hPbuffer);
            internal static DestroyPbufferARB wglDestroyPbufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal unsafe static QueryPbufferARB wglQueryPbufferARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static BindTexImageARB wglBindTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static ReleaseTexImageARB wglReleaseTexImageARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
            internal unsafe static SetPbufferAttribARB wglSetPbufferAttribARB;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool CreateDisplayColorTableEXT(UInt16 id);
            internal static CreateDisplayColorTableEXT wglCreateDisplayColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool LoadDisplayColorTableEXT(UInt16* table, UInt32 length);
            internal unsafe static LoadDisplayColorTableEXT wglLoadDisplayColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool BindDisplayColorTableEXT(UInt16 id);
            internal static BindDisplayColorTableEXT wglBindDisplayColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyDisplayColorTableEXT(UInt16 id);
            internal static DestroyDisplayColorTableEXT wglDestroyDisplayColorTableEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringEXT();
            internal static GetExtensionsStringEXT wglGetExtensionsStringEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentEXT wglMakeContextCurrentEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCEXT();
            internal static GetCurrentReadDCEXT wglGetCurrentReadDCEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferEXT wglCreatePbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCEXT(IntPtr hPbuffer);
            internal static GetPbufferDCEXT wglGetPbufferDCEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCEXT wglReleasePbufferDCEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferEXT(IntPtr hPbuffer);
            internal static DestroyPbufferEXT wglDestroyPbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal unsafe static QueryPbufferEXT wglQueryPbufferEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivEXT wglGetPixelFormatAttribivEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvEXT wglGetPixelFormatAttribfvEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal unsafe static ChoosePixelFormatEXT wglChoosePixelFormatEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapIntervalEXT(int interval);
            internal static SwapIntervalEXT wglSwapIntervalEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetSwapIntervalEXT();
            internal static GetSwapIntervalEXT wglGetSwapIntervalEXT;
        }
    }
}
