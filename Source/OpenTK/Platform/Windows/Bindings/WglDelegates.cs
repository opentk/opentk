namespace OpenTK.Platform.Windows
{
    using System;
    using System.Runtime.InteropServices;

    partial class Wgl
    {

        internal static class Delegates
        {
            static Delegates()
            {
            }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateContext(IntPtr hDc);
            internal static CreateContext wglCreateContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DeleteContext(IntPtr oldContext);
            internal static DeleteContext wglDeleteContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentContext();
            internal static GetCurrentContext wglGetCurrentContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            internal static MakeCurrent wglMakeCurrent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
            internal static CopyContext wglCopyContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor* pPfd);
            internal unsafe static ChoosePixelFormat wglChoosePixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, PixelFormatDescriptor* ppfd);
            internal unsafe static DescribePixelFormat wglDescribePixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentDC();
            internal static GetCurrentDC wglGetCurrentDC = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetDefaultProcAddress(String lpszProc);
            internal static GetDefaultProcAddress wglGetDefaultProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetProcAddress(String lpszProc);
            internal static GetProcAddress wglGetProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetPixelFormat(IntPtr hdc);
            internal static GetPixelFormat wglGetPixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd);
            internal unsafe static SetPixelFormat wglSetPixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapBuffers(IntPtr hdc);
            internal static SwapBuffers wglSwapBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
            internal static ShareLists wglShareLists = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateLayerContext(IntPtr hDc, int level);
            internal static CreateLayerContext wglCreateLayerContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, LayerPlaneDescriptor* plpd);
            internal unsafe static DescribeLayerPlane wglDescribeLayerPlane = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr);
            internal unsafe static SetLayerPaletteEntries wglSetLayerPaletteEntries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr);
            internal unsafe static GetLayerPaletteEntries wglGetLayerPaletteEntries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize);
            internal static RealizeLayerPalette wglRealizeLayerPalette = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
            internal static SwapLayerBuffers wglSwapLayerBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsA wglUseFontBitmapsA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsW wglUseFontBitmapsW = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat* glyphMetrics);
            internal unsafe static UseFontOutlinesA wglUseFontOutlinesA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat* glyphMetrics);
            internal unsafe static UseFontOutlinesW wglUseFontOutlinesW = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);
            internal static CreateBufferRegionARB wglCreateBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteBufferRegionARB(IntPtr hRegion);
            internal static DeleteBufferRegionARB wglDeleteBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
            internal static SaveBufferRegionARB wglSaveBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
            internal static RestoreBufferRegionARB wglRestoreBufferRegionARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringARB(IntPtr hdc);
            internal static GetExtensionsStringARB wglGetExtensionsStringARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivARB wglGetPixelFormatAttribivARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvARB wglGetPixelFormatAttribfvARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal unsafe static ChoosePixelFormatARB wglChoosePixelFormatARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentARB wglMakeContextCurrentARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCARB();
            internal static GetCurrentReadDCARB wglGetCurrentReadDCARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferARB wglCreatePbufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCARB(IntPtr hPbuffer);
            internal static GetPbufferDCARB wglGetPbufferDCARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCARB wglReleasePbufferDCARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferARB(IntPtr hPbuffer);
            internal static DestroyPbufferARB wglDestroyPbufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal unsafe static QueryPbufferARB wglQueryPbufferARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static BindTexImageARB wglBindTexImageARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static ReleaseTexImageARB wglReleaseTexImageARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
            internal unsafe static SetPbufferAttribARB wglSetPbufferAttribARB = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CreateDisplayColorTableEXT(UInt16 id);
            internal static CreateDisplayColorTableEXT wglCreateDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean LoadDisplayColorTableEXT(UInt16* table, UInt32 length);
            internal unsafe static LoadDisplayColorTableEXT wglLoadDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindDisplayColorTableEXT(UInt16 id);
            internal static BindDisplayColorTableEXT wglBindDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyDisplayColorTableEXT(UInt16 id);
            internal static DestroyDisplayColorTableEXT wglDestroyDisplayColorTableEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringEXT();
            internal static GetExtensionsStringEXT wglGetExtensionsStringEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentEXT wglMakeContextCurrentEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCEXT();
            internal static GetCurrentReadDCEXT wglGetCurrentReadDCEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferEXT wglCreatePbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCEXT(IntPtr hPbuffer);
            internal static GetPbufferDCEXT wglGetPbufferDCEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCEXT wglReleasePbufferDCEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferEXT(IntPtr hPbuffer);
            internal static DestroyPbufferEXT wglDestroyPbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal unsafe static QueryPbufferEXT wglQueryPbufferEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivEXT wglGetPixelFormatAttribivEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvEXT wglGetPixelFormatAttribfvEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal unsafe static ChoosePixelFormatEXT wglChoosePixelFormatEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapIntervalEXT(int interval);
            internal static SwapIntervalEXT wglSwapIntervalEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetSwapIntervalEXT();
            internal static GetSwapIntervalEXT wglGetSwapIntervalEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr AllocateMemoryNV(Int32 size, Single readfreq, Single writefreq, Single priority);
            internal static AllocateMemoryNV wglAllocateMemoryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FreeMemoryNV([Out] void* pointer);
            internal unsafe static FreeMemoryNV wglFreeMemoryNV = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetSyncValuesOML(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static GetSyncValuesOML wglGetSyncValuesOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetMscRateOML(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator);
            internal unsafe static GetMscRateOML wglGetMscRateOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapBuffersMscOML wglSwapBuffersMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapLayerBuffersMscOML wglSwapLayerBuffersMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForMscOML wglWaitForMscOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForSbcOML(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForSbcOML wglWaitForSbcOML = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetDigitalVideoParametersI3D wglGetDigitalVideoParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetDigitalVideoParametersI3D wglSetDigitalVideoParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetGammaTableParametersI3D wglGetGammaTableParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetGammaTableParametersI3D wglSetGammaTableParametersI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue);
            internal unsafe static GetGammaTableI3D wglGetGammaTableI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
            internal unsafe static SetGammaTableI3D wglSetGammaTableI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableGenlockI3D(IntPtr hDC);
            internal static EnableGenlockI3D wglEnableGenlockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableGenlockI3D(IntPtr hDC);
            internal static DisableGenlockI3D wglDisableGenlockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean IsEnabledGenlockI3D(IntPtr hDC, [Out] Boolean* pFlag);
            internal unsafe static IsEnabledGenlockI3D wglIsEnabledGenlockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceI3D(IntPtr hDC, UInt32 uSource);
            internal static GenlockSourceI3D wglGenlockSourceI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSourceI3D(IntPtr hDC, [Out] UInt32* uSource);
            internal unsafe static GetGenlockSourceI3D wglGetGenlockSourceI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);
            internal static GenlockSourceEdgeI3D wglGenlockSourceEdgeI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] UInt32* uEdge);
            internal unsafe static GetGenlockSourceEdgeI3D wglGetGenlockSourceEdgeI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);
            internal static GenlockSampleRateI3D wglGenlockSampleRateI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSampleRateI3D(IntPtr hDC, [Out] UInt32* uRate);
            internal unsafe static GetGenlockSampleRateI3D wglGetGenlockSampleRateI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);
            internal static GenlockSourceDelayI3D wglGenlockSourceDelayI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGenlockSourceDelayI3D(IntPtr hDC, [Out] UInt32* uDelay);
            internal unsafe static GetGenlockSourceDelayI3D wglGetGenlockSourceDelayI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] UInt32* uMaxLineDelay, [Out] UInt32* uMaxPixelDelay);
            internal unsafe static QueryGenlockMaxSourceDelayI3D wglQueryGenlockMaxSourceDelayI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);
            internal static CreateImageBufferI3D wglCreateImageBufferI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean DestroyImageBufferI3D(IntPtr hDC, void* pAddress);
            internal unsafe static DestroyImageBufferI3D wglDestroyImageBufferI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, void* pAddress, Int32* pSize, UInt32 count);
            internal unsafe static AssociateImageBufferEventsI3D wglAssociateImageBufferEventsI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ReleaseImageBufferEventsI3D(IntPtr hDC, void* pAddress, UInt32 count);
            internal unsafe static ReleaseImageBufferEventsI3D wglReleaseImageBufferEventsI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableFrameLockI3D();
            internal static EnableFrameLockI3D wglEnableFrameLockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableFrameLockI3D();
            internal static DisableFrameLockI3D wglDisableFrameLockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean IsEnabledFrameLockI3D([Out] Boolean* pFlag);
            internal unsafe static IsEnabledFrameLockI3D wglIsEnabledFrameLockI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryFrameLockMasterI3D([Out] Boolean* pFlag);
            internal unsafe static QueryFrameLockMasterI3D wglQueryFrameLockMasterI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetFrameUsageI3D([Out] float* pUsage);
            internal unsafe static GetFrameUsageI3D wglGetFrameUsageI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BeginFrameTrackingI3D();
            internal static BeginFrameTrackingI3D wglBeginFrameTrackingI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EndFrameTrackingI3D();
            internal static EndFrameTrackingI3D wglEndFrameTrackingI3D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean QueryFrameTrackingI3D([Out] Int32* pFrameCount, [Out] Int32* pMissedFrames, [Out] float* pLastMissedUsage);
            internal unsafe static QueryFrameTrackingI3D wglQueryFrameTrackingI3D = null;
        }
    }
}
