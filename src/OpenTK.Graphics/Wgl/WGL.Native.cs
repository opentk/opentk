// This file is auto generated, do not edit. Generated: 2025-08-22 01:00:25 GMT+02:00
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Glx;
using OpenTK.Graphics.Egl;

namespace OpenTK.Graphics.Wgl
{
    public static unsafe partial class Wgl
    {
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>ChoosePixelFormat</c>]</b><br/>  </summary>
        public static int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor* pPfd) => WglPointers.ChoosePixelFormat_Lazy(hDc, pPfd);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglCopyContext</c>]</b><br/>  </summary>
        public static int CopyContext_(IntPtr hglrcSrc, IntPtr hglrcDst, AttribMask mask) => WglPointers.wglCopyContext_Lazy(hglrcSrc, hglrcDst, (uint)mask);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglCreateContext</c>]</b><br/>  </summary>
        public static IntPtr CreateContext(IntPtr hDc) => WglPointers.wglCreateContext_Lazy(hDc);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglCreateLayerContext</c>]</b><br/>  </summary>
        public static IntPtr CreateLayerContext(IntPtr hDc, int level) => WglPointers.wglCreateLayerContext_Lazy(hDc, level);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglDeleteContext</c>]</b><br/>  </summary>
        public static int DeleteContext_(IntPtr oldContext) => WglPointers.wglDeleteContext_Lazy(oldContext);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglDescribeLayerPlane</c>]</b><br/>  </summary>
        public static int DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, LayerPlaneDescriptor* plpd) => WglPointers.wglDescribeLayerPlane_Lazy(hDc, pixelFormat, layerPlane, nBytes, plpd);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>DescribePixelFormat</c>]</b><br/>  </summary>
        public static int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, PixelFormatDescriptor* ppfd) => WglPointers.DescribePixelFormat_Lazy(hdc, ipfd, cjpfd, ppfd);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglGetCurrentContext</c>]</b><br/>  </summary>
        public static IntPtr GetCurrentContext() => WglPointers.wglGetCurrentContext_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglGetCurrentDC</c>]</b><br/>  </summary>
        public static IntPtr GetCurrentDC() => WglPointers.wglGetCurrentDC_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>GetEnhMetaFilePixelFormat</c>]</b><br/>  </summary>
        public static uint GetEnhMetaFilePixelFormat(IntPtr hemf, uint cbBuffer, PixelFormatDescriptor* ppfd) => WglPointers.GetEnhMetaFilePixelFormat_Lazy(hemf, cbBuffer, ppfd);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglGetLayerPaletteEntries</c>]</b><br/>  </summary>
        public static int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ColorRef* pcr) => WglPointers.wglGetLayerPaletteEntries_Lazy(hdc, iLayerPlane, iStart, cEntries, (uint*)pcr);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>GetPixelFormat</c>]</b><br/>  </summary>
        public static int GetPixelFormat(IntPtr hdc) => WglPointers.GetPixelFormat_Lazy(hdc);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglGetProcAddress</c>]</b><br/>  </summary>
        public static IntPtr GetProcAddress(byte* lpszProc) => WglPointers.wglGetProcAddress_Lazy(lpszProc);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglMakeCurrent</c>]</b><br/>  </summary>
        public static int MakeCurrent_(IntPtr hDc, IntPtr newContext) => WglPointers.wglMakeCurrent_Lazy(hDc, newContext);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglRealizeLayerPalette</c>]</b><br/>  </summary>
        public static int RealizeLayerPalette_(IntPtr hdc, int iLayerPlane, int bRealize) => WglPointers.wglRealizeLayerPalette_Lazy(hdc, iLayerPlane, bRealize);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglSetLayerPaletteEntries</c>]</b><br/>  </summary>
        public static int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ColorRef* pcr) => WglPointers.wglSetLayerPaletteEntries_Lazy(hdc, iLayerPlane, iStart, cEntries, (uint*)pcr);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>SetPixelFormat</c>]</b><br/>  </summary>
        public static int SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd) => WglPointers.SetPixelFormat_Lazy(hdc, ipfd, ppfd);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglShareLists</c>]</b><br/>  </summary>
        public static int ShareLists_(IntPtr hrcSrvShare, IntPtr hrcSrvSource) => WglPointers.wglShareLists_Lazy(hrcSrvShare, hrcSrvSource);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>SwapBuffers</c>]</b><br/>  </summary>
        public static int SwapBuffers_(IntPtr hdc) => WglPointers.SwapBuffers_Lazy(hdc);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglSwapLayerBuffers</c>]</b><br/>  </summary>
        public static int SwapLayerBuffers_(IntPtr hdc, LayerPlaneMask fuFlags) => WglPointers.wglSwapLayerBuffers_Lazy(hdc, (uint)fuFlags);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglUseFontBitmaps</c>]</b><br/>  </summary>
        public static int UseFontBitmaps_(IntPtr hDC, uint first, uint count, uint listBase) => WglPointers.wglUseFontBitmaps_Lazy(hDC, first, count, listBase);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglUseFontBitmapsA</c>]</b><br/>  </summary>
        public static int UseFontBitmapsA_(IntPtr hDC, uint first, uint count, uint listBase) => WglPointers.wglUseFontBitmapsA_Lazy(hDC, first, count, listBase);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglUseFontBitmapsW</c>]</b><br/>  </summary>
        public static int UseFontBitmapsW_(IntPtr hDC, uint first, uint count, uint listBase) => WglPointers.wglUseFontBitmapsW_Lazy(hDC, first, count, listBase);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglUseFontOutlines</c>]</b><br/>  </summary>
        public static int UseFontOutlines_(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, FontFormat format, IntPtr lpgmf) => WglPointers.wglUseFontOutlines_Lazy(hDC, first, count, listBase, deviation, extrusion, (int)format, lpgmf);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglUseFontOutlinesA</c>]</b><br/>  </summary>
        public static int UseFontOutlinesA_(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, FontFormat format, IntPtr lpgmf) => WglPointers.wglUseFontOutlinesA_Lazy(hDC, first, count, listBase, deviation, extrusion, (int)format, lpgmf);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>wglUseFontOutlinesW</c>]</b><br/>  </summary>
        public static int UseFontOutlinesW_(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, FontFormat format, IntPtr lpgmf) => WglPointers.wglUseFontOutlinesW_Lazy(hDC, first, count, listBase, deviation, extrusion, (int)format, lpgmf);
        
        /// <summary>_3DL extensions.</summary>
        public static unsafe partial class _3DL
        {
            /// <summary> <b>[requires: WGL_3DL_stereo_control]</b> <b>[entry point: <c>wglSetStereoEmitterState3DL</c>]</b><br/>  </summary>
            public static int SetStereoEmitterState3DL_(IntPtr hDC, StereoEmitterState uState) => WglPointers.wglSetStereoEmitterState3DL_Lazy(hDC, (uint)uState);
            
        }
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglBlitContextFramebufferAMD</c>]</b><br/>  </summary>
            public static void BlitContextFramebufferAMD(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, All filter) => WglPointers.wglBlitContextFramebufferAMD_Lazy(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, (uint)filter);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglCreateAssociatedContextAMD</c>]</b><br/>  </summary>
            public static IntPtr CreateAssociatedContextAMD(uint id) => WglPointers.wglCreateAssociatedContextAMD_Lazy(id);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglCreateAssociatedContextAttribsAMD</c>]</b><br/>  </summary>
            public static IntPtr CreateAssociatedContextAttribsAMD(uint id, IntPtr hShareContext, int* attribList) => WglPointers.wglCreateAssociatedContextAttribsAMD_Lazy(id, hShareContext, attribList);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglDeleteAssociatedContextAMD</c>]</b><br/>  </summary>
            public static int DeleteAssociatedContextAMD_(IntPtr hglrc) => WglPointers.wglDeleteAssociatedContextAMD_Lazy(hglrc);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglGetContextGPUIDAMD</c>]</b><br/>  </summary>
            public static uint GetContextGPUIDAMD(IntPtr hglrc) => WglPointers.wglGetContextGPUIDAMD_Lazy(hglrc);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglGetCurrentAssociatedContextAMD</c>]</b><br/>  </summary>
            public static IntPtr GetCurrentAssociatedContextAMD() => WglPointers.wglGetCurrentAssociatedContextAMD_Lazy();
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglGetGPUIDsAMD</c>]</b><br/>  </summary>
            public static uint GetGPUIDsAMD(uint maxCount, uint* ids) => WglPointers.wglGetGPUIDsAMD_Lazy(maxCount, ids);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglGetGPUInfoAMD</c>]</b><br/>  </summary>
            public static int GetGPUInfoAMD(uint id, GPUPropertyAMD property, ScalarType dataType, uint size, void* data) => WglPointers.wglGetGPUInfoAMD_Lazy(id, (int)property, (uint)dataType, size, data);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b> <b>[entry point: <c>wglMakeAssociatedContextCurrentAMD</c>]</b><br/>  </summary>
            public static int MakeAssociatedContextCurrentAMD_(IntPtr hglrc) => WglPointers.wglMakeAssociatedContextCurrentAMD_Lazy(hglrc);
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            /// <summary> <b>[requires: WGL_ARB_render_texture]</b> <b>[entry point: <c>wglBindTexImageARB</c>]</b><br/>  </summary>
            public static int BindTexImageARB_(IntPtr hPbuffer, ColorBuffer iBuffer) => WglPointers.wglBindTexImageARB_Lazy(hPbuffer, (int)iBuffer);
            
            /// <summary> <b>[requires: WGL_ARB_pixel_format]</b> <b>[entry point: <c>wglChoosePixelFormatARB</c>]</b><br/>  </summary>
            public static int ChoosePixelFormatARB(IntPtr hdc, PixelFormatAttribute* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats) => WglPointers.wglChoosePixelFormatARB_Lazy(hdc, (int*)piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b> <b>[entry point: <c>wglCreateBufferRegionARB</c>]</b><br/>  </summary>
            public static IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, ColorBufferMask uType) => WglPointers.wglCreateBufferRegionARB_Lazy(hDC, iLayerPlane, (uint)uType);
            
            /// <summary> <b>[requires: WGL_ARB_create_context]</b> <b>[entry point: <c>wglCreateContextAttribsARB</c>]</b><br/>  </summary>
            public static IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, ContextAttribs* attribList) => WglPointers.wglCreateContextAttribsARB_Lazy(hDC, hShareContext, (int*)attribList);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b> <b>[entry point: <c>wglCreatePbufferARB</c>]</b><br/>  </summary>
            public static IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList) => WglPointers.wglCreatePbufferARB_Lazy(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b> <b>[entry point: <c>wglDeleteBufferRegionARB</c>]</b><br/>  </summary>
            public static void DeleteBufferRegionARB(IntPtr hRegion) => WglPointers.wglDeleteBufferRegionARB_Lazy(hRegion);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b> <b>[entry point: <c>wglDestroyPbufferARB</c>]</b><br/>  </summary>
            public static int DestroyPbufferARB_(IntPtr hPbuffer) => WglPointers.wglDestroyPbufferARB_Lazy(hPbuffer);
            
            /// <summary> <b>[requires: WGL_ARB_make_current_read]</b> <b>[entry point: <c>wglGetCurrentReadDCARB</c>]</b><br/>  </summary>
            public static IntPtr GetCurrentReadDCARB() => WglPointers.wglGetCurrentReadDCARB_Lazy();
            
            /// <summary> <b>[requires: WGL_ARB_extensions_string]</b> <b>[entry point: <c>wglGetExtensionsStringARB</c>]</b><br/>  </summary>
            public static byte* GetExtensionsStringARB_(IntPtr hdc) => WglPointers.wglGetExtensionsStringARB_Lazy(hdc);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b> <b>[entry point: <c>wglGetPbufferDCARB</c>]</b><br/>  </summary>
            public static IntPtr GetPbufferDCARB(IntPtr hPbuffer) => WglPointers.wglGetPbufferDCARB_Lazy(hPbuffer);
            
            /// <summary> <b>[requires: WGL_ARB_pixel_format]</b> <b>[entry point: <c>wglGetPixelFormatAttribfvARB</c>]</b><br/>  </summary>
            public static int GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, PixelFormatAttribute* piAttributes, float* pfValues) => WglPointers.wglGetPixelFormatAttribfvARB_Lazy(hdc, iPixelFormat, iLayerPlane, nAttributes, (int*)piAttributes, pfValues);
            
            /// <summary> <b>[requires: WGL_ARB_pixel_format]</b> <b>[entry point: <c>wglGetPixelFormatAttribivARB</c>]</b><br/>  </summary>
            public static int GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, PixelFormatAttribute* piAttributes, int* piValues) => WglPointers.wglGetPixelFormatAttribivARB_Lazy(hdc, iPixelFormat, iLayerPlane, nAttributes, (int*)piAttributes, piValues);
            
            /// <summary> <b>[requires: WGL_ARB_make_current_read]</b> <b>[entry point: <c>wglMakeContextCurrentARB</c>]</b><br/>  </summary>
            public static int MakeContextCurrentARB_(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc) => WglPointers.wglMakeContextCurrentARB_Lazy(hDrawDC, hReadDC, hglrc);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b> <b>[entry point: <c>wglQueryPbufferARB</c>]</b><br/>  </summary>
            public static int QueryPbufferARB(IntPtr hPbuffer, PBufferAttribute iAttribute, int* piValue) => WglPointers.wglQueryPbufferARB_Lazy(hPbuffer, (int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b> <b>[entry point: <c>wglReleasePbufferDCARB</c>]</b><br/>  </summary>
            public static int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC) => WglPointers.wglReleasePbufferDCARB_Lazy(hPbuffer, hDC);
            
            /// <summary> <b>[requires: WGL_ARB_render_texture]</b> <b>[entry point: <c>wglReleaseTexImageARB</c>]</b><br/>  </summary>
            public static int ReleaseTexImageARB_(IntPtr hPbuffer, ColorBuffer iBuffer) => WglPointers.wglReleaseTexImageARB_Lazy(hPbuffer, (int)iBuffer);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b> <b>[entry point: <c>wglRestoreBufferRegionARB</c>]</b><br/>  </summary>
            public static int RestoreBufferRegionARB_(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc) => WglPointers.wglRestoreBufferRegionARB_Lazy(hRegion, x, y, width, height, xSrc, ySrc);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b> <b>[entry point: <c>wglSaveBufferRegionARB</c>]</b><br/>  </summary>
            public static int SaveBufferRegionARB_(IntPtr hRegion, int x, int y, int width, int height) => WglPointers.wglSaveBufferRegionARB_Lazy(hRegion, x, y, width, height);
            
            /// <summary> <b>[requires: WGL_ARB_render_texture]</b> <b>[entry point: <c>wglSetPbufferAttribARB</c>]</b><br/>  </summary>
            public static int SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList) => WglPointers.wglSetPbufferAttribARB_Lazy(hPbuffer, piAttribList);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b> <b>[entry point: <c>wglBindDisplayColorTableEXT</c>]</b><br/>  </summary>
            public static bool BindDisplayColorTableEXT(ushort id) => WglPointers.wglBindDisplayColorTableEXT_Lazy(id) != 0;
            
            /// <summary> <b>[requires: WGL_EXT_pixel_format]</b> <b>[entry point: <c>wglChoosePixelFormatEXT</c>]</b><br/>  </summary>
            public static int ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats) => WglPointers.wglChoosePixelFormatEXT_Lazy(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
            
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b> <b>[entry point: <c>wglCreateDisplayColorTableEXT</c>]</b><br/>  </summary>
            public static bool CreateDisplayColorTableEXT(ushort id) => WglPointers.wglCreateDisplayColorTableEXT_Lazy(id) != 0;
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b> <b>[entry point: <c>wglCreatePbufferEXT</c>]</b><br/>  </summary>
            public static IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList) => WglPointers.wglCreatePbufferEXT_Lazy(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
            
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b> <b>[entry point: <c>wglDestroyDisplayColorTableEXT</c>]</b><br/>  </summary>
            public static void DestroyDisplayColorTableEXT(ushort id) => WglPointers.wglDestroyDisplayColorTableEXT_Lazy(id);
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b> <b>[entry point: <c>wglDestroyPbufferEXT</c>]</b><br/>  </summary>
            public static int DestroyPbufferEXT_(IntPtr hPbuffer) => WglPointers.wglDestroyPbufferEXT_Lazy(hPbuffer);
            
            /// <summary> <b>[requires: WGL_EXT_make_current_read]</b> <b>[entry point: <c>wglGetCurrentReadDCEXT</c>]</b><br/>  </summary>
            public static IntPtr GetCurrentReadDCEXT() => WglPointers.wglGetCurrentReadDCEXT_Lazy();
            
            /// <summary> <b>[requires: WGL_EXT_extensions_string]</b> <b>[entry point: <c>wglGetExtensionsStringEXT</c>]</b><br/>  </summary>
            public static byte* GetExtensionsStringEXT_() => WglPointers.wglGetExtensionsStringEXT_Lazy();
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b> <b>[entry point: <c>wglGetPbufferDCEXT</c>]</b><br/>  </summary>
            public static IntPtr GetPbufferDCEXT(IntPtr hPbuffer) => WglPointers.wglGetPbufferDCEXT_Lazy(hPbuffer);
            
            /// <summary> <b>[requires: WGL_EXT_pixel_format]</b> <b>[entry point: <c>wglGetPixelFormatAttribfvEXT</c>]</b><br/>  </summary>
            public static int GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, PixelFormatAttribute* piAttributes, float* pfValues) => WglPointers.wglGetPixelFormatAttribfvEXT_Lazy(hdc, iPixelFormat, iLayerPlane, nAttributes, (int*)piAttributes, pfValues);
            
            /// <summary> <b>[requires: WGL_EXT_pixel_format]</b> <b>[entry point: <c>wglGetPixelFormatAttribivEXT</c>]</b><br/>  </summary>
            public static int GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, PixelFormatAttribute* piAttributes, int* piValues) => WglPointers.wglGetPixelFormatAttribivEXT_Lazy(hdc, iPixelFormat, iLayerPlane, nAttributes, (int*)piAttributes, piValues);
            
            /// <summary> <b>[requires: WGL_EXT_swap_control]</b> <b>[entry point: <c>wglGetSwapIntervalEXT</c>]</b><br/>  </summary>
            public static int GetSwapIntervalEXT() => WglPointers.wglGetSwapIntervalEXT_Lazy();
            
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b> <b>[entry point: <c>wglLoadDisplayColorTableEXT</c>]</b><br/>  </summary>
            public static bool LoadDisplayColorTableEXT(ushort* table, uint length) => WglPointers.wglLoadDisplayColorTableEXT_Lazy(table, length) != 0;
            
            /// <summary> <b>[requires: WGL_EXT_make_current_read]</b> <b>[entry point: <c>wglMakeContextCurrentEXT</c>]</b><br/>  </summary>
            public static int MakeContextCurrentEXT_(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc) => WglPointers.wglMakeContextCurrentEXT_Lazy(hDrawDC, hReadDC, hglrc);
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b> <b>[entry point: <c>wglQueryPbufferEXT</c>]</b><br/>  </summary>
            public static int QueryPbufferEXT(IntPtr hPbuffer, PBufferAttribute iAttribute, int* piValue) => WglPointers.wglQueryPbufferEXT_Lazy(hPbuffer, (int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b> <b>[entry point: <c>wglReleasePbufferDCEXT</c>]</b><br/>  </summary>
            public static int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC) => WglPointers.wglReleasePbufferDCEXT_Lazy(hPbuffer, hDC);
            
            /// <summary> <b>[requires: WGL_EXT_swap_control]</b> <b>[entry point: <c>wglSwapIntervalEXT</c>]</b><br/>  </summary>
            public static int SwapIntervalEXT_(int interval) => WglPointers.wglSwapIntervalEXT_Lazy(interval);
            
        }
        /// <summary>I3D extensions.</summary>
        public static unsafe partial class I3D
        {
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b> <b>[entry point: <c>wglAssociateImageBufferEventsI3D</c>]</b><br/>  </summary>
            public static int AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, uint* pSize, uint count) => WglPointers.wglAssociateImageBufferEventsI3D_Lazy(hDC, pEvent, pAddress, pSize, count);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b> <b>[entry point: <c>wglBeginFrameTrackingI3D</c>]</b><br/>  </summary>
            public static int BeginFrameTrackingI3D_() => WglPointers.wglBeginFrameTrackingI3D_Lazy();
            
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b> <b>[entry point: <c>wglCreateImageBufferI3D</c>]</b><br/>  </summary>
            public static IntPtr CreateImageBufferI3D(IntPtr hDC, uint dwSize, ImageBufferMaskI3D uFlags) => WglPointers.wglCreateImageBufferI3D_Lazy(hDC, dwSize, (uint)uFlags);
            
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b> <b>[entry point: <c>wglDestroyImageBufferI3D</c>]</b><br/>  </summary>
            public static int DestroyImageBufferI3D_(IntPtr hDC, IntPtr pAddress) => WglPointers.wglDestroyImageBufferI3D_Lazy(hDC, pAddress);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b> <b>[entry point: <c>wglDisableFrameLockI3D</c>]</b><br/>  </summary>
            public static int DisableFrameLockI3D_() => WglPointers.wglDisableFrameLockI3D_Lazy();
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglDisableGenlockI3D</c>]</b><br/>  </summary>
            public static int DisableGenlockI3D_(IntPtr hDC) => WglPointers.wglDisableGenlockI3D_Lazy(hDC);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b> <b>[entry point: <c>wglEnableFrameLockI3D</c>]</b><br/>  </summary>
            public static int EnableFrameLockI3D_() => WglPointers.wglEnableFrameLockI3D_Lazy();
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglEnableGenlockI3D</c>]</b><br/>  </summary>
            public static int EnableGenlockI3D_(IntPtr hDC) => WglPointers.wglEnableGenlockI3D_Lazy(hDC);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b> <b>[entry point: <c>wglEndFrameTrackingI3D</c>]</b><br/>  </summary>
            public static int EndFrameTrackingI3D_() => WglPointers.wglEndFrameTrackingI3D_Lazy();
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGenlockSampleRateI3D</c>]</b><br/>  </summary>
            public static int GenlockSampleRateI3D_(IntPtr hDC, uint uRate) => WglPointers.wglGenlockSampleRateI3D_Lazy(hDC, uRate);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGenlockSourceDelayI3D</c>]</b><br/>  </summary>
            public static int GenlockSourceDelayI3D_(IntPtr hDC, uint uDelay) => WglPointers.wglGenlockSourceDelayI3D_Lazy(hDC, uDelay);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGenlockSourceEdgeI3D</c>]</b><br/>  </summary>
            public static int GenlockSourceEdgeI3D_(IntPtr hDC, uint uEdge) => WglPointers.wglGenlockSourceEdgeI3D_Lazy(hDC, uEdge);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGenlockSourceI3D</c>]</b><br/>  </summary>
            public static int GenlockSourceI3D_(IntPtr hDC, uint uSource) => WglPointers.wglGenlockSourceI3D_Lazy(hDC, uSource);
            
            /// <summary> <b>[requires: WGL_I3D_digital_video_control]</b> <b>[entry point: <c>wglGetDigitalVideoParametersI3D</c>]</b><br/>  </summary>
            public static int GetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, int* piValue) => WglPointers.wglGetDigitalVideoParametersI3D_Lazy(hDC, (int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b> <b>[entry point: <c>wglGetFrameUsageI3D</c>]</b><br/>  </summary>
            public static int GetFrameUsageI3D(float* pUsage) => WglPointers.wglGetFrameUsageI3D_Lazy(pUsage);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b> <b>[entry point: <c>wglGetGammaTableI3D</c>]</b><br/>  </summary>
            public static int GetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue) => WglPointers.wglGetGammaTableI3D_Lazy(hDC, iEntries, puRed, puGreen, puBlue);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b> <b>[entry point: <c>wglGetGammaTableParametersI3D</c>]</b><br/>  </summary>
            public static int GetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, int* piValue) => WglPointers.wglGetGammaTableParametersI3D_Lazy(hDC, (int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGetGenlockSampleRateI3D</c>]</b><br/>  </summary>
            public static int GetGenlockSampleRateI3D(IntPtr hDC, uint* uRate) => WglPointers.wglGetGenlockSampleRateI3D_Lazy(hDC, uRate);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGetGenlockSourceDelayI3D</c>]</b><br/>  </summary>
            public static int GetGenlockSourceDelayI3D(IntPtr hDC, uint* uDelay) => WglPointers.wglGetGenlockSourceDelayI3D_Lazy(hDC, uDelay);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGetGenlockSourceEdgeI3D</c>]</b><br/>  </summary>
            public static int GetGenlockSourceEdgeI3D(IntPtr hDC, uint* uEdge) => WglPointers.wglGetGenlockSourceEdgeI3D_Lazy(hDC, uEdge);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglGetGenlockSourceI3D</c>]</b><br/>  </summary>
            public static int GetGenlockSourceI3D(IntPtr hDC, uint* uSource) => WglPointers.wglGetGenlockSourceI3D_Lazy(hDC, uSource);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b> <b>[entry point: <c>wglIsEnabledFrameLockI3D</c>]</b><br/>  </summary>
            public static int IsEnabledFrameLockI3D(int* pFlag) => WglPointers.wglIsEnabledFrameLockI3D_Lazy(pFlag);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglIsEnabledGenlockI3D</c>]</b><br/>  </summary>
            public static int IsEnabledGenlockI3D(IntPtr hDC, int* pFlag) => WglPointers.wglIsEnabledGenlockI3D_Lazy(hDC, pFlag);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b> <b>[entry point: <c>wglQueryFrameLockMasterI3D</c>]</b><br/>  </summary>
            public static int QueryFrameLockMasterI3D(int* pFlag) => WglPointers.wglQueryFrameLockMasterI3D_Lazy(pFlag);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b> <b>[entry point: <c>wglQueryFrameTrackingI3D</c>]</b><br/>  </summary>
            public static int QueryFrameTrackingI3D(uint* pFrameCount, uint* pMissedFrames, float* pLastMissedUsage) => WglPointers.wglQueryFrameTrackingI3D_Lazy(pFrameCount, pMissedFrames, pLastMissedUsage);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b> <b>[entry point: <c>wglQueryGenlockMaxSourceDelayI3D</c>]</b><br/>  </summary>
            public static int QueryGenlockMaxSourceDelayI3D(IntPtr hDC, uint* uMaxLineDelay, uint* uMaxPixelDelay) => WglPointers.wglQueryGenlockMaxSourceDelayI3D_Lazy(hDC, uMaxLineDelay, uMaxPixelDelay);
            
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b> <b>[entry point: <c>wglReleaseImageBufferEventsI3D</c>]</b><br/>  </summary>
            public static int ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, uint count) => WglPointers.wglReleaseImageBufferEventsI3D_Lazy(hDC, pAddress, count);
            
            /// <summary> <b>[requires: WGL_I3D_digital_video_control]</b> <b>[entry point: <c>wglSetDigitalVideoParametersI3D</c>]</b><br/>  </summary>
            public static int SetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, int* piValue) => WglPointers.wglSetDigitalVideoParametersI3D_Lazy(hDC, (int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b> <b>[entry point: <c>wglSetGammaTableI3D</c>]</b><br/>  </summary>
            public static int SetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue) => WglPointers.wglSetGammaTableI3D_Lazy(hDC, iEntries, puRed, puGreen, puBlue);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b> <b>[entry point: <c>wglSetGammaTableParametersI3D</c>]</b><br/>  </summary>
            public static int SetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, int* piValue) => WglPointers.wglSetGammaTableParametersI3D_Lazy(hDC, (int)iAttribute, piValue);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: WGL_NV_vertex_array_range]</b> <b>[entry point: <c>wglAllocateMemoryNV</c>]</b><br/>  </summary>
            public static void* AllocateMemoryNV(int size, float readfreq, float writefreq, float priority) => WglPointers.wglAllocateMemoryNV_Lazy(size, readfreq, writefreq, priority);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b> <b>[entry point: <c>wglBindSwapBarrierNV</c>]</b><br/>  </summary>
            public static int BindSwapBarrierNV_(uint group, uint barrier) => WglPointers.wglBindSwapBarrierNV_Lazy(group, barrier);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b> <b>[entry point: <c>wglBindVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int BindVideoCaptureDeviceNV_(uint uVideoSlot, IntPtr hDevice) => WglPointers.wglBindVideoCaptureDeviceNV_Lazy(uVideoSlot, hDevice);
            
            /// <summary> <b>[requires: WGL_NV_present_video]</b> <b>[entry point: <c>wglBindVideoDeviceNV</c>]</b><br/>  </summary>
            public static int BindVideoDeviceNV(IntPtr hDc, uint uVideoSlot, IntPtr hVideoDevice, int* piAttribList) => WglPointers.wglBindVideoDeviceNV_Lazy(hDc, uVideoSlot, hVideoDevice, piAttribList);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b> <b>[entry point: <c>wglBindVideoImageNV</c>]</b><br/>  </summary>
            public static int BindVideoImageNV_(IntPtr hVideoDevice, IntPtr hPbuffer, VideoOutputBuffer iVideoBuffer) => WglPointers.wglBindVideoImageNV_Lazy(hVideoDevice, hPbuffer, (int)iVideoBuffer);
            
            /// <summary> <b>[requires: WGL_NV_copy_image]</b> <b>[entry point: <c>wglCopyImageSubDataNV</c>]</b><br/>  </summary>
            public static int CopyImageSubDataNV_(IntPtr hSrcRC, uint srcName, TextureTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr hDstRC, uint dstName, TextureTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => WglPointers.wglCopyImageSubDataNV_Lazy(hSrcRC, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, hDstRC, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b> <b>[entry point: <c>wglCreateAffinityDCNV</c>]</b><br/>  </summary>
            public static IntPtr CreateAffinityDCNV(IntPtr* phGpuList) => WglPointers.wglCreateAffinityDCNV_Lazy(phGpuList);
            
            /// <summary> <b>[requires: WGL_NV_delay_before_swap]</b> <b>[entry point: <c>wglDelayBeforeSwapNV</c>]</b><br/>  </summary>
            public static int DelayBeforeSwapNV_(IntPtr hDC, float seconds) => WglPointers.wglDelayBeforeSwapNV_Lazy(hDC, seconds);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b> <b>[entry point: <c>wglDeleteDCNV</c>]</b><br/>  </summary>
            public static int DeleteDCNV_(IntPtr hdc) => WglPointers.wglDeleteDCNV_Lazy(hdc);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXCloseDeviceNV</c>]</b><br/>  </summary>
            public static int DXCloseDeviceNV_(IntPtr hDevice) => WglPointers.wglDXCloseDeviceNV_Lazy(hDevice);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXLockObjectsNV</c>]</b><br/>  </summary>
            public static int DXLockObjectsNV(IntPtr hDevice, int count, IntPtr* hObjects) => WglPointers.wglDXLockObjectsNV_Lazy(hDevice, count, hObjects);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXObjectAccessNV</c>]</b><br/>  </summary>
            public static int DXObjectAccessNV_(IntPtr hObject, DXInteropMaskNV access) => WglPointers.wglDXObjectAccessNV_Lazy(hObject, (uint)access);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXOpenDeviceNV</c>]</b><br/>  </summary>
            public static IntPtr DXOpenDeviceNV(void* dxDevice) => WglPointers.wglDXOpenDeviceNV_Lazy(dxDevice);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXRegisterObjectNV</c>]</b><br/>  </summary>
            public static IntPtr DXRegisterObjectNV(IntPtr hDevice, void* dxObject, uint name, ObjectTypeDX type, DXInteropMaskNV access) => WglPointers.wglDXRegisterObjectNV_Lazy(hDevice, dxObject, name, (uint)type, (uint)access);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXSetResourceShareHandleNV</c>]</b><br/>  </summary>
            public static int DXSetResourceShareHandleNV(void* dxObject, IntPtr shareHandle) => WglPointers.wglDXSetResourceShareHandleNV_Lazy(dxObject, shareHandle);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXUnlockObjectsNV</c>]</b><br/>  </summary>
            public static int DXUnlockObjectsNV(IntPtr hDevice, int count, IntPtr* hObjects) => WglPointers.wglDXUnlockObjectsNV_Lazy(hDevice, count, hObjects);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b> <b>[entry point: <c>wglDXUnregisterObjectNV</c>]</b><br/>  </summary>
            public static int DXUnregisterObjectNV_(IntPtr hDevice, IntPtr hObject) => WglPointers.wglDXUnregisterObjectNV_Lazy(hDevice, hObject);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b> <b>[entry point: <c>wglEnumerateVideoCaptureDevicesNV</c>]</b><br/>  </summary>
            public static uint EnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList) => WglPointers.wglEnumerateVideoCaptureDevicesNV_Lazy(hDc, phDeviceList);
            
            /// <summary> <b>[requires: WGL_NV_present_video]</b> <b>[entry point: <c>wglEnumerateVideoDevicesNV</c>]</b><br/>  </summary>
            public static int EnumerateVideoDevicesNV(IntPtr hDc, IntPtr* phDeviceList) => WglPointers.wglEnumerateVideoDevicesNV_Lazy(hDc, phDeviceList);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b> <b>[entry point: <c>wglEnumGpuDevicesNV</c>]</b><br/>  </summary>
            public static int EnumGpuDevicesNV(IntPtr hGpu, uint iDeviceIndex, _GPU_DEVICE* lpGpuDevice) => WglPointers.wglEnumGpuDevicesNV_Lazy(hGpu, iDeviceIndex, lpGpuDevice);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b> <b>[entry point: <c>wglEnumGpusFromAffinityDCNV</c>]</b><br/>  </summary>
            public static int EnumGpusFromAffinityDCNV(IntPtr hAffinityDC, uint iGpuIndex, IntPtr* hGpu) => WglPointers.wglEnumGpusFromAffinityDCNV_Lazy(hAffinityDC, iGpuIndex, hGpu);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b> <b>[entry point: <c>wglEnumGpusNV</c>]</b><br/>  </summary>
            public static int EnumGpusNV(uint iGpuIndex, IntPtr* phGpu) => WglPointers.wglEnumGpusNV_Lazy(iGpuIndex, phGpu);
            
            /// <summary> <b>[requires: WGL_NV_vertex_array_range]</b> <b>[entry point: <c>wglFreeMemoryNV</c>]</b><br/>  </summary>
            public static void FreeMemoryNV(void* pointer) => WglPointers.wglFreeMemoryNV_Lazy(pointer);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b> <b>[entry point: <c>wglGetVideoDeviceNV</c>]</b><br/>  </summary>
            public static int GetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice) => WglPointers.wglGetVideoDeviceNV_Lazy(hDC, numDevices, hVideoDevice);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b> <b>[entry point: <c>wglGetVideoInfoNV</c>]</b><br/>  </summary>
            public static int GetVideoInfoNV(IntPtr hpVideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo) => WglPointers.wglGetVideoInfoNV_Lazy(hpVideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b> <b>[entry point: <c>wglJoinSwapGroupNV</c>]</b><br/>  </summary>
            public static int JoinSwapGroupNV_(IntPtr hDC, uint group) => WglPointers.wglJoinSwapGroupNV_Lazy(hDC, group);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b> <b>[entry point: <c>wglLockVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int LockVideoCaptureDeviceNV_(IntPtr hDc, IntPtr hDevice) => WglPointers.wglLockVideoCaptureDeviceNV_Lazy(hDc, hDevice);
            
            /// <summary> <b>[requires: WGL_NV_present_video]</b> <b>[entry point: <c>wglQueryCurrentContextNV</c>]</b><br/>  </summary>
            public static int QueryCurrentContextNV(ContextAttribute iAttribute, int* piValue) => WglPointers.wglQueryCurrentContextNV_Lazy((int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b> <b>[entry point: <c>wglQueryFrameCountNV</c>]</b><br/>  </summary>
            public static int QueryFrameCountNV(IntPtr hDC, uint* count) => WglPointers.wglQueryFrameCountNV_Lazy(hDC, count);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b> <b>[entry point: <c>wglQueryMaxSwapGroupsNV</c>]</b><br/>  </summary>
            public static int QueryMaxSwapGroupsNV(IntPtr hDC, uint* maxGroups, uint* maxBarriers) => WglPointers.wglQueryMaxSwapGroupsNV_Lazy(hDC, maxGroups, maxBarriers);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b> <b>[entry point: <c>wglQuerySwapGroupNV</c>]</b><br/>  </summary>
            public static int QuerySwapGroupNV(IntPtr hDC, uint* group, uint* barrier) => WglPointers.wglQuerySwapGroupNV_Lazy(hDC, group, barrier);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b> <b>[entry point: <c>wglQueryVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int QueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, VideoCaptureDeviceAttribute iAttribute, int* piValue) => WglPointers.wglQueryVideoCaptureDeviceNV_Lazy(hDc, hDevice, (int)iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b> <b>[entry point: <c>wglReleaseVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoCaptureDeviceNV_(IntPtr hDc, IntPtr hDevice) => WglPointers.wglReleaseVideoCaptureDeviceNV_Lazy(hDc, hDevice);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b> <b>[entry point: <c>wglReleaseVideoDeviceNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoDeviceNV_(IntPtr hVideoDevice) => WglPointers.wglReleaseVideoDeviceNV_Lazy(hVideoDevice);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b> <b>[entry point: <c>wglReleaseVideoImageNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoImageNV_(IntPtr hPbuffer, VideoOutputBuffer iVideoBuffer) => WglPointers.wglReleaseVideoImageNV_Lazy(hPbuffer, (int)iVideoBuffer);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b> <b>[entry point: <c>wglResetFrameCountNV</c>]</b><br/>  </summary>
            public static int ResetFrameCountNV_(IntPtr hDC) => WglPointers.wglResetFrameCountNV_Lazy(hDC);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b> <b>[entry point: <c>wglSendPbufferToVideoNV</c>]</b><br/>  </summary>
            public static int SendPbufferToVideoNV(IntPtr hPbuffer, VideoOutputBufferType iBufferType, ulong* pulCounterPbuffer, int bBlock) => WglPointers.wglSendPbufferToVideoNV_Lazy(hPbuffer, (int)iBufferType, pulCounterPbuffer, bBlock);
            
        }
        /// <summary>OML extensions.</summary>
        public static unsafe partial class OML
        {
            /// <summary> <b>[requires: WGL_OML_sync_control]</b> <b>[entry point: <c>wglGetMscRateOML</c>]</b><br/>  </summary>
            public static int GetMscRateOML(IntPtr hdc, int* numerator, int* denominator) => WglPointers.wglGetMscRateOML_Lazy(hdc, numerator, denominator);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b> <b>[entry point: <c>wglGetSyncValuesOML</c>]</b><br/>  </summary>
            public static int GetSyncValuesOML(IntPtr hdc, long* ust, long* msc, long* sbc) => WglPointers.wglGetSyncValuesOML_Lazy(hdc, ust, msc, sbc);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b> <b>[entry point: <c>wglSwapBuffersMscOML</c>]</b><br/>  </summary>
            public static long SwapBuffersMscOML(IntPtr hdc, long target_msc, long divisor, long remainder) => WglPointers.wglSwapBuffersMscOML_Lazy(hdc, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b> <b>[entry point: <c>wglSwapLayerBuffersMscOML</c>]</b><br/>  </summary>
            public static long SwapLayerBuffersMscOML(IntPtr hdc, LayerPlaneMask fuPlanes, long target_msc, long divisor, long remainder) => WglPointers.wglSwapLayerBuffersMscOML_Lazy(hdc, (int)fuPlanes, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b> <b>[entry point: <c>wglWaitForMscOML</c>]</b><br/>  </summary>
            public static int WaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc) => WglPointers.wglWaitForMscOML_Lazy(hdc, target_msc, divisor, remainder, ust, msc, sbc);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b> <b>[entry point: <c>wglWaitForSbcOML</c>]</b><br/>  </summary>
            public static int WaitForSbcOML(IntPtr hdc, long target_sbc, long* ust, long* msc, long* sbc) => WglPointers.wglWaitForSbcOML_Lazy(hdc, target_sbc, ust, msc, sbc);
            
        }
    }
}
