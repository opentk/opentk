namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    partial class Wgl
    {

        internal static class Delegates
        {
            static Delegates()
            {
                Wgl.ReloadFunctions();
            }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateContext(IntPtr hDc);
            internal static CreateContext glCreateContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DeleteContext(IntPtr oldContext);
            internal static DeleteContext glDeleteContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentContext();
            internal static GetCurrentContext glGetCurrentContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            internal static MakeCurrent glMakeCurrent = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
            internal static CopyContext glCopyContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ChoosePixelFormat(IntPtr hDc, OpenTK.Platform.Windows.API.PixelFormatDescriptor pPfd);
            internal static ChoosePixelFormat glChoosePixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd);
            internal static DescribePixelFormat glDescribePixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentDC();
            internal static GetCurrentDC glGetCurrentDC = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetDefaultProcAddress(String lpszProc);
            internal static GetDefaultProcAddress glGetDefaultProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetProcAddress(String lpszProc);
            internal static GetProcAddress glGetProcAddress = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetPixelFormat(IntPtr hdc);
            internal static GetPixelFormat glGetPixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SetPixelFormat(IntPtr hdc, int ipfd, OpenTK.Platform.Windows.API.PixelFormatDescriptor ppfd);
            internal static SetPixelFormat glSetPixelFormat = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapBuffers(IntPtr hdc);
            internal static SwapBuffers glSwapBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
            internal static ShareLists glShareLists = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateLayerContext(IntPtr hDc, int level);
            internal static CreateLayerContext glCreateLayerContext = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, OpenTK.Platform.Windows.API.LayerPlaneDescriptor plpd);
            internal static DescribeLayerPlane glDescribeLayerPlane = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr);
            internal static SetLayerPaletteEntries glSetLayerPaletteEntries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32 pcr);
            internal static GetLayerPaletteEntries glGetLayerPaletteEntries = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize);
            internal static RealizeLayerPalette glRealizeLayerPalette = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
            internal static SwapLayerBuffers glSwapLayerBuffers = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsA glUseFontBitmapsA = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsW glUseFontBitmapsW = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);
            internal static CreateBufferRegionARB glCreateBufferRegionARB = (CreateBufferRegionARB)Wgl.GetDelegateForExtensionMethod("glCreateBufferRegionARB", typeof(CreateBufferRegionARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteBufferRegionARB(IntPtr hRegion);
            internal static DeleteBufferRegionARB glDeleteBufferRegionARB = (DeleteBufferRegionARB)Wgl.GetDelegateForExtensionMethod("glDeleteBufferRegionARB", typeof(DeleteBufferRegionARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
            internal static SaveBufferRegionARB glSaveBufferRegionARB = (SaveBufferRegionARB)Wgl.GetDelegateForExtensionMethod("glSaveBufferRegionARB", typeof(SaveBufferRegionARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
            internal static RestoreBufferRegionARB glRestoreBufferRegionARB = (RestoreBufferRegionARB)Wgl.GetDelegateForExtensionMethod("glRestoreBufferRegionARB", typeof(RestoreBufferRegionARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringARB(IntPtr hdc);
            internal static GetExtensionsStringARB glGetExtensionsStringARB = (GetExtensionsStringARB)Wgl.GetDelegateForExtensionMethod("glGetExtensionsStringARB", typeof(GetExtensionsStringARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivARB glGetPixelFormatAttribivARB = (GetPixelFormatAttribivARB)Wgl.GetDelegateForExtensionMethod("glGetPixelFormatAttribivARB", typeof(GetPixelFormatAttribivARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvARB glGetPixelFormatAttribfvARB = (GetPixelFormatAttribfvARB)Wgl.GetDelegateForExtensionMethod("glGetPixelFormatAttribfvARB", typeof(GetPixelFormatAttribfvARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats);
            internal unsafe static ChoosePixelFormatARB glChoosePixelFormatARB = (ChoosePixelFormatARB)Wgl.GetDelegateForExtensionMethod("glChoosePixelFormatARB", typeof(ChoosePixelFormatARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentARB glMakeContextCurrentARB = (MakeContextCurrentARB)Wgl.GetDelegateForExtensionMethod("glMakeContextCurrentARB", typeof(MakeContextCurrentARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCARB();
            internal static GetCurrentReadDCARB glGetCurrentReadDCARB = (GetCurrentReadDCARB)Wgl.GetDelegateForExtensionMethod("glGetCurrentReadDCARB", typeof(GetCurrentReadDCARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferARB glCreatePbufferARB = (CreatePbufferARB)Wgl.GetDelegateForExtensionMethod("glCreatePbufferARB", typeof(CreatePbufferARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCARB(IntPtr hPbuffer);
            internal static GetPbufferDCARB glGetPbufferDCARB = (GetPbufferDCARB)Wgl.GetDelegateForExtensionMethod("glGetPbufferDCARB", typeof(GetPbufferDCARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCARB glReleasePbufferDCARB = (ReleasePbufferDCARB)Wgl.GetDelegateForExtensionMethod("glReleasePbufferDCARB", typeof(ReleasePbufferDCARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferARB(IntPtr hPbuffer);
            internal static DestroyPbufferARB glDestroyPbufferARB = (DestroyPbufferARB)Wgl.GetDelegateForExtensionMethod("glDestroyPbufferARB", typeof(DestroyPbufferARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int piValue);
            internal static QueryPbufferARB glQueryPbufferARB = (QueryPbufferARB)Wgl.GetDelegateForExtensionMethod("glQueryPbufferARB", typeof(QueryPbufferARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static BindTexImageARB glBindTexImageARB = (BindTexImageARB)Wgl.GetDelegateForExtensionMethod("glBindTexImageARB", typeof(BindTexImageARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static ReleaseTexImageARB glReleaseTexImageARB = (ReleaseTexImageARB)Wgl.GetDelegateForExtensionMethod("glReleaseTexImageARB", typeof(ReleaseTexImageARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
            internal unsafe static SetPbufferAttribARB glSetPbufferAttribARB = (SetPbufferAttribARB)Wgl.GetDelegateForExtensionMethod("glSetPbufferAttribARB", typeof(SetPbufferAttribARB));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean CreateDisplayColorTableEXT(UInt16 id);
            internal static CreateDisplayColorTableEXT glCreateDisplayColorTableEXT = (CreateDisplayColorTableEXT)Wgl.GetDelegateForExtensionMethod("glCreateDisplayColorTableEXT", typeof(CreateDisplayColorTableEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean LoadDisplayColorTableEXT(UInt16* table, UInt32 length);
            internal unsafe static LoadDisplayColorTableEXT glLoadDisplayColorTableEXT = (LoadDisplayColorTableEXT)Wgl.GetDelegateForExtensionMethod("glLoadDisplayColorTableEXT", typeof(LoadDisplayColorTableEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BindDisplayColorTableEXT(UInt16 id);
            internal static BindDisplayColorTableEXT glBindDisplayColorTableEXT = (BindDisplayColorTableEXT)Wgl.GetDelegateForExtensionMethod("glBindDisplayColorTableEXT", typeof(BindDisplayColorTableEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DestroyDisplayColorTableEXT(UInt16 id);
            internal static DestroyDisplayColorTableEXT glDestroyDisplayColorTableEXT = (DestroyDisplayColorTableEXT)Wgl.GetDelegateForExtensionMethod("glDestroyDisplayColorTableEXT", typeof(DestroyDisplayColorTableEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetExtensionsStringEXT();
            internal static GetExtensionsStringEXT glGetExtensionsStringEXT = (GetExtensionsStringEXT)Wgl.GetDelegateForExtensionMethod("glGetExtensionsStringEXT", typeof(GetExtensionsStringEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentEXT glMakeContextCurrentEXT = (MakeContextCurrentEXT)Wgl.GetDelegateForExtensionMethod("glMakeContextCurrentEXT", typeof(MakeContextCurrentEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetCurrentReadDCEXT();
            internal static GetCurrentReadDCEXT glGetCurrentReadDCEXT = (GetCurrentReadDCEXT)Wgl.GetDelegateForExtensionMethod("glGetCurrentReadDCEXT", typeof(GetCurrentReadDCEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal unsafe static CreatePbufferEXT glCreatePbufferEXT = (CreatePbufferEXT)Wgl.GetDelegateForExtensionMethod("glCreatePbufferEXT", typeof(CreatePbufferEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetPbufferDCEXT(IntPtr hPbuffer);
            internal static GetPbufferDCEXT glGetPbufferDCEXT = (GetPbufferDCEXT)Wgl.GetDelegateForExtensionMethod("glGetPbufferDCEXT", typeof(GetPbufferDCEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCEXT glReleasePbufferDCEXT = (ReleasePbufferDCEXT)Wgl.GetDelegateForExtensionMethod("glReleasePbufferDCEXT", typeof(ReleasePbufferDCEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DestroyPbufferEXT(IntPtr hPbuffer);
            internal static DestroyPbufferEXT glDestroyPbufferEXT = (DestroyPbufferEXT)Wgl.GetDelegateForExtensionMethod("glDestroyPbufferEXT", typeof(DestroyPbufferEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] int piValue);
            internal static QueryPbufferEXT glQueryPbufferEXT = (QueryPbufferEXT)Wgl.GetDelegateForExtensionMethod("glQueryPbufferEXT", typeof(QueryPbufferEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues);
            internal unsafe static GetPixelFormatAttribivEXT glGetPixelFormatAttribivEXT = (GetPixelFormatAttribivEXT)Wgl.GetDelegateForExtensionMethod("glGetPixelFormatAttribivEXT", typeof(GetPixelFormatAttribivEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues);
            internal unsafe static GetPixelFormatAttribfvEXT glGetPixelFormatAttribfvEXT = (GetPixelFormatAttribfvEXT)Wgl.GetDelegateForExtensionMethod("glGetPixelFormatAttribfvEXT", typeof(GetPixelFormatAttribfvEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32 nNumFormats);
            internal unsafe static ChoosePixelFormatEXT glChoosePixelFormatEXT = (ChoosePixelFormatEXT)Wgl.GetDelegateForExtensionMethod("glChoosePixelFormatEXT", typeof(ChoosePixelFormatEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean SwapIntervalEXT(int interval);
            internal static SwapIntervalEXT glSwapIntervalEXT = (SwapIntervalEXT)Wgl.GetDelegateForExtensionMethod("glSwapIntervalEXT", typeof(SwapIntervalEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetSwapIntervalEXT();
            internal static GetSwapIntervalEXT glGetSwapIntervalEXT = (GetSwapIntervalEXT)Wgl.GetDelegateForExtensionMethod("glGetSwapIntervalEXT", typeof(GetSwapIntervalEXT));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr AllocateMemoryNV(Int32 size, Single readfreq, Single writefreq, Single priority);
            internal static AllocateMemoryNV glAllocateMemoryNV = (AllocateMemoryNV)Wgl.GetDelegateForExtensionMethod("glAllocateMemoryNV", typeof(AllocateMemoryNV));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FreeMemoryNV([Out] void* pointer);
            internal unsafe static FreeMemoryNV glFreeMemoryNV = (FreeMemoryNV)Wgl.GetDelegateForExtensionMethod("glFreeMemoryNV", typeof(FreeMemoryNV));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetSyncValuesOML(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static GetSyncValuesOML glGetSyncValuesOML = (GetSyncValuesOML)Wgl.GetDelegateForExtensionMethod("glGetSyncValuesOML", typeof(GetSyncValuesOML));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetMscRateOML(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator);
            internal unsafe static GetMscRateOML glGetMscRateOML = (GetMscRateOML)Wgl.GetDelegateForExtensionMethod("glGetMscRateOML", typeof(GetMscRateOML));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapBuffersMscOML glSwapBuffersMscOML = (SwapBuffersMscOML)Wgl.GetDelegateForExtensionMethod("glSwapBuffersMscOML", typeof(SwapBuffersMscOML));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapLayerBuffersMscOML glSwapLayerBuffersMscOML = (SwapLayerBuffersMscOML)Wgl.GetDelegateForExtensionMethod("glSwapLayerBuffersMscOML", typeof(SwapLayerBuffersMscOML));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForMscOML glWaitForMscOML = (WaitForMscOML)Wgl.GetDelegateForExtensionMethod("glWaitForMscOML", typeof(WaitForMscOML));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean WaitForSbcOML(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal unsafe static WaitForSbcOML glWaitForSbcOML = (WaitForSbcOML)Wgl.GetDelegateForExtensionMethod("glWaitForSbcOML", typeof(WaitForSbcOML));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetDigitalVideoParametersI3D glGetDigitalVideoParametersI3D = (GetDigitalVideoParametersI3D)Wgl.GetDelegateForExtensionMethod("glGetDigitalVideoParametersI3D", typeof(GetDigitalVideoParametersI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetDigitalVideoParametersI3D glSetDigitalVideoParametersI3D = (SetDigitalVideoParametersI3D)Wgl.GetDelegateForExtensionMethod("glSetDigitalVideoParametersI3D", typeof(SetDigitalVideoParametersI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal unsafe static GetGammaTableParametersI3D glGetGammaTableParametersI3D = (GetGammaTableParametersI3D)Wgl.GetDelegateForExtensionMethod("glGetGammaTableParametersI3D", typeof(GetGammaTableParametersI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal unsafe static SetGammaTableParametersI3D glSetGammaTableParametersI3D = (SetGammaTableParametersI3D)Wgl.GetDelegateForExtensionMethod("glSetGammaTableParametersI3D", typeof(SetGammaTableParametersI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue);
            internal unsafe static GetGammaTableI3D glGetGammaTableI3D = (GetGammaTableI3D)Wgl.GetDelegateForExtensionMethod("glGetGammaTableI3D", typeof(GetGammaTableI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean SetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
            internal unsafe static SetGammaTableI3D glSetGammaTableI3D = (SetGammaTableI3D)Wgl.GetDelegateForExtensionMethod("glSetGammaTableI3D", typeof(SetGammaTableI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableGenlockI3D(IntPtr hDC);
            internal static EnableGenlockI3D glEnableGenlockI3D = (EnableGenlockI3D)Wgl.GetDelegateForExtensionMethod("glEnableGenlockI3D", typeof(EnableGenlockI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableGenlockI3D(IntPtr hDC);
            internal static DisableGenlockI3D glDisableGenlockI3D = (DisableGenlockI3D)Wgl.GetDelegateForExtensionMethod("glDisableGenlockI3D", typeof(DisableGenlockI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsEnabledGenlockI3D(IntPtr hDC, [Out] Boolean pFlag);
            internal static IsEnabledGenlockI3D glIsEnabledGenlockI3D = (IsEnabledGenlockI3D)Wgl.GetDelegateForExtensionMethod("glIsEnabledGenlockI3D", typeof(IsEnabledGenlockI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceI3D(IntPtr hDC, UInt32 uSource);
            internal static GenlockSourceI3D glGenlockSourceI3D = (GenlockSourceI3D)Wgl.GetDelegateForExtensionMethod("glGenlockSourceI3D", typeof(GenlockSourceI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSourceI3D(IntPtr hDC, [Out] UInt32 uSource);
            internal static GetGenlockSourceI3D glGetGenlockSourceI3D = (GetGenlockSourceI3D)Wgl.GetDelegateForExtensionMethod("glGetGenlockSourceI3D", typeof(GetGenlockSourceI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);
            internal static GenlockSourceEdgeI3D glGenlockSourceEdgeI3D = (GenlockSourceEdgeI3D)Wgl.GetDelegateForExtensionMethod("glGenlockSourceEdgeI3D", typeof(GenlockSourceEdgeI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] UInt32 uEdge);
            internal static GetGenlockSourceEdgeI3D glGetGenlockSourceEdgeI3D = (GetGenlockSourceEdgeI3D)Wgl.GetDelegateForExtensionMethod("glGetGenlockSourceEdgeI3D", typeof(GetGenlockSourceEdgeI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);
            internal static GenlockSampleRateI3D glGenlockSampleRateI3D = (GenlockSampleRateI3D)Wgl.GetDelegateForExtensionMethod("glGenlockSampleRateI3D", typeof(GenlockSampleRateI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSampleRateI3D(IntPtr hDC, [Out] UInt32 uRate);
            internal static GetGenlockSampleRateI3D glGetGenlockSampleRateI3D = (GetGenlockSampleRateI3D)Wgl.GetDelegateForExtensionMethod("glGetGenlockSampleRateI3D", typeof(GetGenlockSampleRateI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);
            internal static GenlockSourceDelayI3D glGenlockSourceDelayI3D = (GenlockSourceDelayI3D)Wgl.GetDelegateForExtensionMethod("glGenlockSourceDelayI3D", typeof(GenlockSourceDelayI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetGenlockSourceDelayI3D(IntPtr hDC, [Out] UInt32 uDelay);
            internal static GetGenlockSourceDelayI3D glGetGenlockSourceDelayI3D = (GetGenlockSourceDelayI3D)Wgl.GetDelegateForExtensionMethod("glGetGenlockSourceDelayI3D", typeof(GetGenlockSourceDelayI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] UInt32 uMaxLineDelay, [Out] UInt32 uMaxPixelDelay);
            internal static QueryGenlockMaxSourceDelayI3D glQueryGenlockMaxSourceDelayI3D = (QueryGenlockMaxSourceDelayI3D)Wgl.GetDelegateForExtensionMethod("glQueryGenlockMaxSourceDelayI3D", typeof(QueryGenlockMaxSourceDelayI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);
            internal static CreateImageBufferI3D glCreateImageBufferI3D = (CreateImageBufferI3D)Wgl.GetDelegateForExtensionMethod("glCreateImageBufferI3D", typeof(CreateImageBufferI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean DestroyImageBufferI3D(IntPtr hDC, void* pAddress);
            internal unsafe static DestroyImageBufferI3D glDestroyImageBufferI3D = (DestroyImageBufferI3D)Wgl.GetDelegateForExtensionMethod("glDestroyImageBufferI3D", typeof(DestroyImageBufferI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, void* pAddress, Int32* pSize, UInt32 count);
            internal unsafe static AssociateImageBufferEventsI3D glAssociateImageBufferEventsI3D = (AssociateImageBufferEventsI3D)Wgl.GetDelegateForExtensionMethod("glAssociateImageBufferEventsI3D", typeof(AssociateImageBufferEventsI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean ReleaseImageBufferEventsI3D(IntPtr hDC, void* pAddress, UInt32 count);
            internal unsafe static ReleaseImageBufferEventsI3D glReleaseImageBufferEventsI3D = (ReleaseImageBufferEventsI3D)Wgl.GetDelegateForExtensionMethod("glReleaseImageBufferEventsI3D", typeof(ReleaseImageBufferEventsI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EnableFrameLockI3D();
            internal static EnableFrameLockI3D glEnableFrameLockI3D = (EnableFrameLockI3D)Wgl.GetDelegateForExtensionMethod("glEnableFrameLockI3D", typeof(EnableFrameLockI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean DisableFrameLockI3D();
            internal static DisableFrameLockI3D glDisableFrameLockI3D = (DisableFrameLockI3D)Wgl.GetDelegateForExtensionMethod("glDisableFrameLockI3D", typeof(DisableFrameLockI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean IsEnabledFrameLockI3D([Out] Boolean pFlag);
            internal static IsEnabledFrameLockI3D glIsEnabledFrameLockI3D = (IsEnabledFrameLockI3D)Wgl.GetDelegateForExtensionMethod("glIsEnabledFrameLockI3D", typeof(IsEnabledFrameLockI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryFrameLockMasterI3D([Out] Boolean pFlag);
            internal static QueryFrameLockMasterI3D glQueryFrameLockMasterI3D = (QueryFrameLockMasterI3D)Wgl.GetDelegateForExtensionMethod("glQueryFrameLockMasterI3D", typeof(QueryFrameLockMasterI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean GetFrameUsageI3D([Out] float pUsage);
            internal static GetFrameUsageI3D glGetFrameUsageI3D = (GetFrameUsageI3D)Wgl.GetDelegateForExtensionMethod("glGetFrameUsageI3D", typeof(GetFrameUsageI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean BeginFrameTrackingI3D();
            internal static BeginFrameTrackingI3D glBeginFrameTrackingI3D = (BeginFrameTrackingI3D)Wgl.GetDelegateForExtensionMethod("glBeginFrameTrackingI3D", typeof(BeginFrameTrackingI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean EndFrameTrackingI3D();
            internal static EndFrameTrackingI3D glEndFrameTrackingI3D = (EndFrameTrackingI3D)Wgl.GetDelegateForExtensionMethod("glEndFrameTrackingI3D", typeof(EndFrameTrackingI3D));
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Boolean QueryFrameTrackingI3D([Out] Int32 pFrameCount, [Out] Int32 pMissedFrames, [Out] float pLastMissedUsage);
            internal static QueryFrameTrackingI3D glQueryFrameTrackingI3D = (QueryFrameTrackingI3D)Wgl.GetDelegateForExtensionMethod("glQueryFrameTrackingI3D", typeof(QueryFrameTrackingI3D));
        }
    }
}
