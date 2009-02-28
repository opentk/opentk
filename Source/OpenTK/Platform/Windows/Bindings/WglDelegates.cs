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
            internal delegate IntPtr CreateLayerContext(IntPtr hDc, int level);
            internal static CreateLayerContext wglCreateLayerContext;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, LayerPlaneDescriptor* plpd);
            internal unsafe static DescribeLayerPlane wglDescribeLayerPlane;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr);
            internal unsafe static SetLayerPaletteEntries wglSetLayerPaletteEntries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr);
            internal unsafe static GetLayerPaletteEntries wglGetLayerPaletteEntries;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize);
            internal static RealizeLayerPalette wglRealizeLayerPalette;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
            internal static SwapLayerBuffers wglSwapLayerBuffers;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsA wglUseFontBitmapsA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsW wglUseFontBitmapsW;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat* glyphMetrics);
            internal unsafe static UseFontOutlinesA wglUseFontOutlinesA;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat* glyphMetrics);
            internal unsafe static UseFontOutlinesW wglUseFontOutlinesW;
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
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr AllocateMemoryNV(Int32 size, Single readfreq, Single writefreq, Single priority);
            internal unsafe static AllocateMemoryNV wglAllocateMemoryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FreeMemoryNV([Out] IntPtr pointer);
            internal static FreeMemoryNV wglFreeMemoryNV;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetSyncValuesOML(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static GetSyncValuesOML wglGetSyncValuesOML;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetMscRateOML(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator);
            internal unsafe static GetMscRateOML wglGetMscRateOML;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapBuffersMscOML wglSwapBuffersMscOML;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapLayerBuffersMscOML wglSwapLayerBuffersMscOML;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForMscOML wglWaitForMscOML;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForSbcOML(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForSbcOML wglWaitForSbcOML;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetDigitalVideoParametersI3D wglGetDigitalVideoParametersI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetDigitalVideoParametersI3D wglSetDigitalVideoParametersI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetGammaTableParametersI3D wglGetGammaTableParametersI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetGammaTableParametersI3D wglSetGammaTableParametersI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue);
            internal unsafe static GetGammaTableI3D wglGetGammaTableI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
            internal unsafe static SetGammaTableI3D wglSetGammaTableI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableGenlockI3D(IntPtr hDC);
            internal static EnableGenlockI3D wglEnableGenlockI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableGenlockI3D(IntPtr hDC);
            internal static DisableGenlockI3D wglDisableGenlockI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean IsEnabledGenlockI3D(IntPtr hDC, [Out] Boolean* pFlag);
            internal unsafe static IsEnabledGenlockI3D wglIsEnabledGenlockI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceI3D(IntPtr hDC, UInt32 uSource);
            internal static GenlockSourceI3D wglGenlockSourceI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSourceI3D(IntPtr hDC, [Out] UInt32* uSource);
            internal unsafe static GetGenlockSourceI3D wglGetGenlockSourceI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);
            internal static GenlockSourceEdgeI3D wglGenlockSourceEdgeI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] UInt32* uEdge);
            internal unsafe static GetGenlockSourceEdgeI3D wglGetGenlockSourceEdgeI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);
            internal static GenlockSampleRateI3D wglGenlockSampleRateI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSampleRateI3D(IntPtr hDC, [Out] UInt32* uRate);
            internal unsafe static GetGenlockSampleRateI3D wglGetGenlockSampleRateI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);
            internal static GenlockSourceDelayI3D wglGenlockSourceDelayI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSourceDelayI3D(IntPtr hDC, [Out] UInt32* uDelay);
            internal unsafe static GetGenlockSourceDelayI3D wglGetGenlockSourceDelayI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] UInt32* uMaxLineDelay, [Out] UInt32* uMaxPixelDelay);
            internal unsafe static QueryGenlockMaxSourceDelayI3D wglQueryGenlockMaxSourceDelayI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);
            internal unsafe static CreateImageBufferI3D wglCreateImageBufferI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);
            internal static DestroyImageBufferI3D wglDestroyImageBufferI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr pAddress, Int32* pSize, UInt32 count);
            internal unsafe static AssociateImageBufferEventsI3D wglAssociateImageBufferEventsI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr pAddress, UInt32 count);
            internal static ReleaseImageBufferEventsI3D wglReleaseImageBufferEventsI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableFrameLockI3D();
            internal static EnableFrameLockI3D wglEnableFrameLockI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableFrameLockI3D();
            internal static DisableFrameLockI3D wglDisableFrameLockI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean IsEnabledFrameLockI3D([Out] Boolean* pFlag);
            internal unsafe static IsEnabledFrameLockI3D wglIsEnabledFrameLockI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryFrameLockMasterI3D([Out] Boolean* pFlag);
            internal unsafe static QueryFrameLockMasterI3D wglQueryFrameLockMasterI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetFrameUsageI3D([Out] float* pUsage);
            internal unsafe static GetFrameUsageI3D wglGetFrameUsageI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BeginFrameTrackingI3D();
            internal static BeginFrameTrackingI3D wglBeginFrameTrackingI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EndFrameTrackingI3D();
            internal static EndFrameTrackingI3D wglEndFrameTrackingI3D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryFrameTrackingI3D([Out] Int32* pFrameCount, [Out] Int32* pMissedFrames, [Out] float* pLastMissedUsage);
            internal unsafe static QueryFrameTrackingI3D wglQueryFrameTrackingI3D;
        }
    }
}
