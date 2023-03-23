// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Wgl
{
    public static unsafe partial class WGL
    {
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor* pPfd) => WGLPointers._ChoosePixelFormat_fnptr(hDc, pPfd);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask) => WGLPointers._wglCopyContext_fnptr(hglrcSrc, hglrcDst, mask);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static IntPtr CreateContext(IntPtr hDc) => WGLPointers._wglCreateContext_fnptr(hDc);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static IntPtr CreateLayerContext(IntPtr hDc, int level) => WGLPointers._wglCreateLayerContext_fnptr(hDc, level);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int DeleteContext(IntPtr oldContext) => WGLPointers._wglDeleteContext_fnptr(oldContext);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, LayerPlaneDescriptor* plpd) => WGLPointers._wglDescribeLayerPlane_fnptr(hDc, pixelFormat, layerPlane, nBytes, plpd);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, PixelFormatDescriptor* ppfd) => WGLPointers._DescribePixelFormat_fnptr(hdc, ipfd, cjpfd, ppfd);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static IntPtr GetCurrentContext() => WGLPointers._wglGetCurrentContext_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static IntPtr GetCurrentDC() => WGLPointers._wglGetCurrentDC_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static uint GetEnhMetaFilePixelFormat(IntPtr hemf, uint cbBuffer, PixelFormatDescriptor* ppfd) => WGLPointers._GetEnhMetaFilePixelFormat_fnptr(hemf, cbBuffer, ppfd);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ColorRef* pcr) => WGLPointers._wglGetLayerPaletteEntries_fnptr(hdc, iLayerPlane, iStart, cEntries, (uint*)pcr);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int GetPixelFormat(IntPtr hdc) => WGLPointers._GetPixelFormat_fnptr(hdc);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static IntPtr GetProcAddress(char* lpszProc) => WGLPointers._wglGetProcAddress_fnptr(lpszProc);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int MakeCurrent(IntPtr hDc, IntPtr newContext) => WGLPointers._wglMakeCurrent_fnptr(hDc, newContext);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int RealizeLayerPalette(IntPtr hdc, int iLayerPlane, int bRealize) => WGLPointers._wglRealizeLayerPalette_fnptr(hdc, iLayerPlane, bRealize);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ColorRef* pcr) => WGLPointers._wglSetLayerPaletteEntries_fnptr(hdc, iLayerPlane, iStart, cEntries, (uint*)pcr);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd) => WGLPointers._SetPixelFormat_fnptr(hdc, ipfd, ppfd);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource) => WGLPointers._wglShareLists_fnptr(hrcSrvShare, hrcSrvSource);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int SwapBuffers(IntPtr hdc) => WGLPointers._SwapBuffers_fnptr(hdc);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int SwapLayerBuffers(IntPtr hdc, uint fuFlags) => WGLPointers._wglSwapLayerBuffers_fnptr(hdc, fuFlags);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int UseFontBitmaps(IntPtr hDC, uint first, uint count, uint listBase) => WGLPointers._wglUseFontBitmaps_fnptr(hDC, first, count, listBase);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int UseFontBitmapsA(IntPtr hDC, uint first, uint count, uint listBase) => WGLPointers._wglUseFontBitmapsA_fnptr(hDC, first, count, listBase);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int UseFontBitmapsW(IntPtr hDC, uint first, uint count, uint listBase) => WGLPointers._wglUseFontBitmapsW_fnptr(hDC, first, count, listBase);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int UseFontOutlines(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf) => WGLPointers._wglUseFontOutlines_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int UseFontOutlinesA(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf) => WGLPointers._wglUseFontOutlinesA_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int UseFontOutlinesW(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf) => WGLPointers._wglUseFontOutlinesW_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        
        /// <summary>_3DL extensions.</summary>
        public static unsafe partial class _3DL
        {
            /// <summary> <b>[requires: WGL_3DL_stereo_control]</b>   </summary>
            public static int SetStereoEmitterState3DL(IntPtr hDC, uint uState) => WGLPointers._wglSetStereoEmitterState3DL_fnptr(hDC, uState);
            
        }
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static void BlitContextFramebufferAMD(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, All filter) => WGLPointers._wglBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, (uint)filter);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static IntPtr CreateAssociatedContextAMD(uint id) => WGLPointers._wglCreateAssociatedContextAMD_fnptr(id);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static IntPtr CreateAssociatedContextAttribsAMD(uint id, IntPtr hShareContext, int* attribList) => WGLPointers._wglCreateAssociatedContextAttribsAMD_fnptr(id, hShareContext, attribList);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static int DeleteAssociatedContextAMD(IntPtr hglrc) => WGLPointers._wglDeleteAssociatedContextAMD_fnptr(hglrc);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static uint GetContextGPUIDAMD(IntPtr hglrc) => WGLPointers._wglGetContextGPUIDAMD_fnptr(hglrc);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static IntPtr GetCurrentAssociatedContextAMD() => WGLPointers._wglGetCurrentAssociatedContextAMD_fnptr();
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static uint GetGPUIDsAMD(uint maxCount, uint* ids) => WGLPointers._wglGetGPUIDsAMD_fnptr(maxCount, ids);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static int GetGPUInfoAMD(uint id, int property, All dataType, uint size, void* data) => WGLPointers._wglGetGPUInfoAMD_fnptr(id, property, (uint)dataType, size, data);
            
            /// <summary> <b>[requires: WGL_AMD_gpu_association]</b>   </summary>
            public static int MakeAssociatedContextCurrentAMD(IntPtr hglrc) => WGLPointers._wglMakeAssociatedContextCurrentAMD_fnptr(hglrc);
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            /// <summary> <b>[requires: WGL_ARB_render_texture]</b>   </summary>
            public static int BindTexImageARB(IntPtr hPbuffer, int iBuffer) => WGLPointers._wglBindTexImageARB_fnptr(hPbuffer, iBuffer);
            
            /// <summary> <b>[requires: WGL_ARB_pixel_format]</b>   </summary>
            public static int ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats) => WGLPointers._wglChoosePixelFormatARB_fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b>   </summary>
            public static IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, uint uType) => WGLPointers._wglCreateBufferRegionARB_fnptr(hDC, iLayerPlane, uType);
            
            /// <summary> <b>[requires: WGL_ARB_create_context]</b>   </summary>
            public static IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList) => WGLPointers._wglCreateContextAttribsARB_fnptr(hDC, hShareContext, attribList);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b>   </summary>
            public static IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList) => WGLPointers._wglCreatePbufferARB_fnptr(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b>   </summary>
            public static void DeleteBufferRegionARB(IntPtr hRegion) => WGLPointers._wglDeleteBufferRegionARB_fnptr(hRegion);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b>   </summary>
            public static int DestroyPbufferARB(IntPtr hPbuffer) => WGLPointers._wglDestroyPbufferARB_fnptr(hPbuffer);
            
            /// <summary> <b>[requires: WGL_ARB_make_current_read]</b>   </summary>
            public static IntPtr GetCurrentReadDCARB() => WGLPointers._wglGetCurrentReadDCARB_fnptr();
            
            /// <summary> <b>[requires: WGL_ARB_extensions_string]</b>   </summary>
            public static byte* GetExtensionsStringARB_(IntPtr hdc) => WGLPointers._wglGetExtensionsStringARB_fnptr(hdc);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b>   </summary>
            public static IntPtr GetPbufferDCARB(IntPtr hPbuffer) => WGLPointers._wglGetPbufferDCARB_fnptr(hPbuffer);
            
            /// <summary> <b>[requires: WGL_ARB_pixel_format]</b>   </summary>
            public static int GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues) => WGLPointers._wglGetPixelFormatAttribfvARB_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
            
            /// <summary> <b>[requires: WGL_ARB_pixel_format]</b>   </summary>
            public static int GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues) => WGLPointers._wglGetPixelFormatAttribivARB_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
            
            /// <summary> <b>[requires: WGL_ARB_make_current_read]</b>   </summary>
            public static int MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc) => WGLPointers._wglMakeContextCurrentARB_fnptr(hDrawDC, hReadDC, hglrc);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b>   </summary>
            public static int QueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue) => WGLPointers._wglQueryPbufferARB_fnptr(hPbuffer, iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_ARB_pbuffer]</b>   </summary>
            public static int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC) => WGLPointers._wglReleasePbufferDCARB_fnptr(hPbuffer, hDC);
            
            /// <summary> <b>[requires: WGL_ARB_render_texture]</b>   </summary>
            public static int ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer) => WGLPointers._wglReleaseTexImageARB_fnptr(hPbuffer, iBuffer);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b>   </summary>
            public static int RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc) => WGLPointers._wglRestoreBufferRegionARB_fnptr(hRegion, x, y, width, height, xSrc, ySrc);
            
            /// <summary> <b>[requires: WGL_ARB_buffer_region]</b>   </summary>
            public static int SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height) => WGLPointers._wglSaveBufferRegionARB_fnptr(hRegion, x, y, width, height);
            
            /// <summary> <b>[requires: WGL_ARB_render_texture]</b>   </summary>
            public static int SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList) => WGLPointers._wglSetPbufferAttribARB_fnptr(hPbuffer, piAttribList);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b>   </summary>
            public static bool BindDisplayColorTableEXT(ushort id) => WGLPointers._wglBindDisplayColorTableEXT_fnptr(id) != 0;
            
            /// <summary> <b>[requires: WGL_EXT_pixel_format]</b>   </summary>
            public static int ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats) => WGLPointers._wglChoosePixelFormatEXT_fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
            
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b>   </summary>
            public static bool CreateDisplayColorTableEXT(ushort id) => WGLPointers._wglCreateDisplayColorTableEXT_fnptr(id) != 0;
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b>   </summary>
            public static IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList) => WGLPointers._wglCreatePbufferEXT_fnptr(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
            
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b>   </summary>
            public static void DestroyDisplayColorTableEXT(ushort id) => WGLPointers._wglDestroyDisplayColorTableEXT_fnptr(id);
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b>   </summary>
            public static int DestroyPbufferEXT(IntPtr hPbuffer) => WGLPointers._wglDestroyPbufferEXT_fnptr(hPbuffer);
            
            /// <summary> <b>[requires: WGL_EXT_make_current_read]</b>   </summary>
            public static IntPtr GetCurrentReadDCEXT() => WGLPointers._wglGetCurrentReadDCEXT_fnptr();
            
            /// <summary> <b>[requires: WGL_EXT_extensions_string]</b>   </summary>
            public static byte* GetExtensionsStringEXT_() => WGLPointers._wglGetExtensionsStringEXT_fnptr();
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b>   </summary>
            public static IntPtr GetPbufferDCEXT(IntPtr hPbuffer) => WGLPointers._wglGetPbufferDCEXT_fnptr(hPbuffer);
            
            /// <summary> <b>[requires: WGL_EXT_pixel_format]</b>   </summary>
            public static int GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues) => WGLPointers._wglGetPixelFormatAttribfvEXT_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
            
            /// <summary> <b>[requires: WGL_EXT_pixel_format]</b>   </summary>
            public static int GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues) => WGLPointers._wglGetPixelFormatAttribivEXT_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
            
            /// <summary> <b>[requires: WGL_EXT_swap_control]</b>   </summary>
            public static int GetSwapIntervalEXT() => WGLPointers._wglGetSwapIntervalEXT_fnptr();
            
            /// <summary> <b>[requires: WGL_EXT_display_color_table]</b>   </summary>
            public static bool LoadDisplayColorTableEXT(ushort* table, uint length) => WGLPointers._wglLoadDisplayColorTableEXT_fnptr(table, length) != 0;
            
            /// <summary> <b>[requires: WGL_EXT_make_current_read]</b>   </summary>
            public static int MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc) => WGLPointers._wglMakeContextCurrentEXT_fnptr(hDrawDC, hReadDC, hglrc);
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b>   </summary>
            public static int QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int* piValue) => WGLPointers._wglQueryPbufferEXT_fnptr(hPbuffer, iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_EXT_pbuffer]</b>   </summary>
            public static int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC) => WGLPointers._wglReleasePbufferDCEXT_fnptr(hPbuffer, hDC);
            
            /// <summary> <b>[requires: WGL_EXT_swap_control]</b>   </summary>
            public static int SwapIntervalEXT(int interval) => WGLPointers._wglSwapIntervalEXT_fnptr(interval);
            
        }
        /// <summary>I3D extensions.</summary>
        public static unsafe partial class I3D
        {
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b>   </summary>
            public static int AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, uint* pSize, uint count) => WGLPointers._wglAssociateImageBufferEventsI3D_fnptr(hDC, pEvent, pAddress, pSize, count);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b>   </summary>
            public static int BeginFrameTrackingI3D() => WGLPointers._wglBeginFrameTrackingI3D_fnptr();
            
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b>   </summary>
            public static IntPtr CreateImageBufferI3D(IntPtr hDC, uint dwSize, uint uFlags) => WGLPointers._wglCreateImageBufferI3D_fnptr(hDC, dwSize, uFlags);
            
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b>   </summary>
            public static int DestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress) => WGLPointers._wglDestroyImageBufferI3D_fnptr(hDC, pAddress);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b>   </summary>
            public static int DisableFrameLockI3D() => WGLPointers._wglDisableFrameLockI3D_fnptr();
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int DisableGenlockI3D(IntPtr hDC) => WGLPointers._wglDisableGenlockI3D_fnptr(hDC);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b>   </summary>
            public static int EnableFrameLockI3D() => WGLPointers._wglEnableFrameLockI3D_fnptr();
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int EnableGenlockI3D(IntPtr hDC) => WGLPointers._wglEnableGenlockI3D_fnptr(hDC);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b>   </summary>
            public static int EndFrameTrackingI3D() => WGLPointers._wglEndFrameTrackingI3D_fnptr();
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GenlockSampleRateI3D(IntPtr hDC, uint uRate) => WGLPointers._wglGenlockSampleRateI3D_fnptr(hDC, uRate);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GenlockSourceDelayI3D(IntPtr hDC, uint uDelay) => WGLPointers._wglGenlockSourceDelayI3D_fnptr(hDC, uDelay);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GenlockSourceEdgeI3D(IntPtr hDC, uint uEdge) => WGLPointers._wglGenlockSourceEdgeI3D_fnptr(hDC, uEdge);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GenlockSourceI3D(IntPtr hDC, uint uSource) => WGLPointers._wglGenlockSourceI3D_fnptr(hDC, uSource);
            
            /// <summary> <b>[requires: WGL_I3D_digital_video_control]</b>   </summary>
            public static int GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue) => WGLPointers._wglGetDigitalVideoParametersI3D_fnptr(hDC, iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b>   </summary>
            public static int GetFrameUsageI3D(float* pUsage) => WGLPointers._wglGetFrameUsageI3D_fnptr(pUsage);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b>   </summary>
            public static int GetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue) => WGLPointers._wglGetGammaTableI3D_fnptr(hDC, iEntries, puRed, puGreen, puBlue);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b>   </summary>
            public static int GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue) => WGLPointers._wglGetGammaTableParametersI3D_fnptr(hDC, iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GetGenlockSampleRateI3D(IntPtr hDC, uint* uRate) => WGLPointers._wglGetGenlockSampleRateI3D_fnptr(hDC, uRate);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GetGenlockSourceDelayI3D(IntPtr hDC, uint* uDelay) => WGLPointers._wglGetGenlockSourceDelayI3D_fnptr(hDC, uDelay);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GetGenlockSourceEdgeI3D(IntPtr hDC, uint* uEdge) => WGLPointers._wglGetGenlockSourceEdgeI3D_fnptr(hDC, uEdge);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int GetGenlockSourceI3D(IntPtr hDC, uint* uSource) => WGLPointers._wglGetGenlockSourceI3D_fnptr(hDC, uSource);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b>   </summary>
            public static int IsEnabledFrameLockI3D(int* pFlag) => WGLPointers._wglIsEnabledFrameLockI3D_fnptr(pFlag);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int IsEnabledGenlockI3D(IntPtr hDC, int* pFlag) => WGLPointers._wglIsEnabledGenlockI3D_fnptr(hDC, pFlag);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_lock]</b>   </summary>
            public static int QueryFrameLockMasterI3D(int* pFlag) => WGLPointers._wglQueryFrameLockMasterI3D_fnptr(pFlag);
            
            /// <summary> <b>[requires: WGL_I3D_swap_frame_usage]</b>   </summary>
            public static int QueryFrameTrackingI3D(uint* pFrameCount, uint* pMissedFrames, float* pLastMissedUsage) => WGLPointers._wglQueryFrameTrackingI3D_fnptr(pFrameCount, pMissedFrames, pLastMissedUsage);
            
            /// <summary> <b>[requires: WGL_I3D_genlock]</b>   </summary>
            public static int QueryGenlockMaxSourceDelayI3D(IntPtr hDC, uint* uMaxLineDelay, uint* uMaxPixelDelay) => WGLPointers._wglQueryGenlockMaxSourceDelayI3D_fnptr(hDC, uMaxLineDelay, uMaxPixelDelay);
            
            /// <summary> <b>[requires: WGL_I3D_image_buffer]</b>   </summary>
            public static int ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, uint count) => WGLPointers._wglReleaseImageBufferEventsI3D_fnptr(hDC, pAddress, count);
            
            /// <summary> <b>[requires: WGL_I3D_digital_video_control]</b>   </summary>
            public static int SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue) => WGLPointers._wglSetDigitalVideoParametersI3D_fnptr(hDC, iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b>   </summary>
            public static int SetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue) => WGLPointers._wglSetGammaTableI3D_fnptr(hDC, iEntries, puRed, puGreen, puBlue);
            
            /// <summary> <b>[requires: WGL_I3D_gamma]</b>   </summary>
            public static int SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue) => WGLPointers._wglSetGammaTableParametersI3D_fnptr(hDC, iAttribute, piValue);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: WGL_NV_vertex_array_range]</b>   </summary>
            public static void* AllocateMemoryNV(int size, float readfreq, float writefreq, float priority) => WGLPointers._wglAllocateMemoryNV_fnptr(size, readfreq, writefreq, priority);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b>   </summary>
            public static int BindSwapBarrierNV(uint group, uint barrier) => WGLPointers._wglBindSwapBarrierNV_fnptr(group, barrier);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b>   </summary>
            public static int BindVideoCaptureDeviceNV(uint uVideoSlot, IntPtr hDevice) => WGLPointers._wglBindVideoCaptureDeviceNV_fnptr(uVideoSlot, hDevice);
            
            /// <summary> <b>[requires: WGL_NV_present_video]</b>   </summary>
            public static int BindVideoDeviceNV(IntPtr hDc, uint uVideoSlot, IntPtr hVideoDevice, int* piAttribList) => WGLPointers._wglBindVideoDeviceNV_fnptr(hDc, uVideoSlot, hVideoDevice, piAttribList);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b>   </summary>
            public static int BindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer) => WGLPointers._wglBindVideoImageNV_fnptr(hVideoDevice, hPbuffer, iVideoBuffer);
            
            /// <summary> <b>[requires: WGL_NV_copy_image]</b>   </summary>
            public static int CopyImageSubDataNV(IntPtr hSrcRC, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr hDstRC, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => WGLPointers._wglCopyImageSubDataNV_fnptr(hSrcRC, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, hDstRC, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b>   </summary>
            public static IntPtr CreateAffinityDCNV(IntPtr* phGpuList) => WGLPointers._wglCreateAffinityDCNV_fnptr(phGpuList);
            
            /// <summary> <b>[requires: WGL_NV_delay_before_swap]</b>   </summary>
            public static int DelayBeforeSwapNV(IntPtr hDC, float seconds) => WGLPointers._wglDelayBeforeSwapNV_fnptr(hDC, seconds);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b>   </summary>
            public static int DeleteDCNV(IntPtr hdc) => WGLPointers._wglDeleteDCNV_fnptr(hdc);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static int DXCloseDeviceNV(IntPtr hDevice) => WGLPointers._wglDXCloseDeviceNV_fnptr(hDevice);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static int DXLockObjectsNV(IntPtr hDevice, int count, IntPtr* hObjects) => WGLPointers._wglDXLockObjectsNV_fnptr(hDevice, count, hObjects);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static int DXObjectAccessNV(IntPtr hObject, All access) => WGLPointers._wglDXObjectAccessNV_fnptr(hObject, (uint)access);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static IntPtr DXOpenDeviceNV(void* dxDevice) => WGLPointers._wglDXOpenDeviceNV_fnptr(dxDevice);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static IntPtr DXRegisterObjectNV(IntPtr hDevice, void* dxObject, uint name, All type, All access) => WGLPointers._wglDXRegisterObjectNV_fnptr(hDevice, dxObject, name, (uint)type, (uint)access);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static int DXSetResourceShareHandleNV(void* dxObject, IntPtr shareHandle) => WGLPointers._wglDXSetResourceShareHandleNV_fnptr(dxObject, shareHandle);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static int DXUnlockObjectsNV(IntPtr hDevice, int count, IntPtr* hObjects) => WGLPointers._wglDXUnlockObjectsNV_fnptr(hDevice, count, hObjects);
            
            /// <summary> <b>[requires: WGL_NV_DX_interop]</b>   </summary>
            public static int DXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject) => WGLPointers._wglDXUnregisterObjectNV_fnptr(hDevice, hObject);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b>   </summary>
            public static uint EnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList) => WGLPointers._wglEnumerateVideoCaptureDevicesNV_fnptr(hDc, phDeviceList);
            
            /// <summary> <b>[requires: WGL_NV_present_video]</b>   </summary>
            public static int EnumerateVideoDevicesNV(IntPtr hDc, IntPtr* phDeviceList) => WGLPointers._wglEnumerateVideoDevicesNV_fnptr(hDc, phDeviceList);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b>   </summary>
            public static int EnumGpuDevicesNV(IntPtr hGpu, uint iDeviceIndex, _GPU_DEVICE* lpGpuDevice) => WGLPointers._wglEnumGpuDevicesNV_fnptr(hGpu, iDeviceIndex, lpGpuDevice);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b>   </summary>
            public static int EnumGpusFromAffinityDCNV(IntPtr hAffinityDC, uint iGpuIndex, IntPtr* hGpu) => WGLPointers._wglEnumGpusFromAffinityDCNV_fnptr(hAffinityDC, iGpuIndex, hGpu);
            
            /// <summary> <b>[requires: WGL_NV_gpu_affinity]</b>   </summary>
            public static int EnumGpusNV(uint iGpuIndex, IntPtr* phGpu) => WGLPointers._wglEnumGpusNV_fnptr(iGpuIndex, phGpu);
            
            /// <summary> <b>[requires: WGL_NV_vertex_array_range]</b>   </summary>
            public static void FreeMemoryNV(void* pointer) => WGLPointers._wglFreeMemoryNV_fnptr(pointer);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b>   </summary>
            public static int GetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice) => WGLPointers._wglGetVideoDeviceNV_fnptr(hDC, numDevices, hVideoDevice);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b>   </summary>
            public static int GetVideoInfoNV(IntPtr hpVideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo) => WGLPointers._wglGetVideoInfoNV_fnptr(hpVideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b>   </summary>
            public static int JoinSwapGroupNV(IntPtr hDC, uint group) => WGLPointers._wglJoinSwapGroupNV_fnptr(hDC, group);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b>   </summary>
            public static int LockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice) => WGLPointers._wglLockVideoCaptureDeviceNV_fnptr(hDc, hDevice);
            
            /// <summary> <b>[requires: WGL_NV_present_video]</b>   </summary>
            public static int QueryCurrentContextNV(int iAttribute, int* piValue) => WGLPointers._wglQueryCurrentContextNV_fnptr(iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b>   </summary>
            public static int QueryFrameCountNV(IntPtr hDC, uint* count) => WGLPointers._wglQueryFrameCountNV_fnptr(hDC, count);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b>   </summary>
            public static int QueryMaxSwapGroupsNV(IntPtr hDC, uint* maxGroups, uint* maxBarriers) => WGLPointers._wglQueryMaxSwapGroupsNV_fnptr(hDC, maxGroups, maxBarriers);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b>   </summary>
            public static int QuerySwapGroupNV(IntPtr hDC, uint* group, uint* barrier) => WGLPointers._wglQuerySwapGroupNV_fnptr(hDC, group, barrier);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b>   </summary>
            public static int QueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue) => WGLPointers._wglQueryVideoCaptureDeviceNV_fnptr(hDc, hDevice, iAttribute, piValue);
            
            /// <summary> <b>[requires: WGL_NV_video_capture]</b>   </summary>
            public static int ReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice) => WGLPointers._wglReleaseVideoCaptureDeviceNV_fnptr(hDc, hDevice);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b>   </summary>
            public static int ReleaseVideoDeviceNV(IntPtr hVideoDevice) => WGLPointers._wglReleaseVideoDeviceNV_fnptr(hVideoDevice);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b>   </summary>
            public static int ReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer) => WGLPointers._wglReleaseVideoImageNV_fnptr(hPbuffer, iVideoBuffer);
            
            /// <summary> <b>[requires: WGL_NV_swap_group]</b>   </summary>
            public static int ResetFrameCountNV(IntPtr hDC) => WGLPointers._wglResetFrameCountNV_fnptr(hDC);
            
            /// <summary> <b>[requires: WGL_NV_video_output]</b>   </summary>
            public static int SendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, ulong* pulCounterPbuffer, int bBlock) => WGLPointers._wglSendPbufferToVideoNV_fnptr(hPbuffer, iBufferType, pulCounterPbuffer, bBlock);
            
        }
        /// <summary>OML extensions.</summary>
        public static unsafe partial class OML
        {
            /// <summary> <b>[requires: WGL_OML_sync_control]</b>   </summary>
            public static int GetMscRateOML(IntPtr hdc, int* numerator, int* denominator) => WGLPointers._wglGetMscRateOML_fnptr(hdc, numerator, denominator);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b>   </summary>
            public static int GetSyncValuesOML(IntPtr hdc, long* ust, long* msc, long* sbc) => WGLPointers._wglGetSyncValuesOML_fnptr(hdc, ust, msc, sbc);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b>   </summary>
            public static long SwapBuffersMscOML(IntPtr hdc, long target_msc, long divisor, long remainder) => WGLPointers._wglSwapBuffersMscOML_fnptr(hdc, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b>   </summary>
            public static long SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder) => WGLPointers._wglSwapLayerBuffersMscOML_fnptr(hdc, fuPlanes, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b>   </summary>
            public static int WaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc) => WGLPointers._wglWaitForMscOML_fnptr(hdc, target_msc, divisor, remainder, ust, msc, sbc);
            
            /// <summary> <b>[requires: WGL_OML_sync_control]</b>   </summary>
            public static int WaitForSbcOML(IntPtr hdc, long target_sbc, long* ust, long* msc, long* sbc) => WGLPointers._wglWaitForSbcOML_fnptr(hdc, target_sbc, ust, msc, sbc);
            
        }
    }
}
