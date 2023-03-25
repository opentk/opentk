// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class GLX
    {
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void* ChooseFBConfig(void* dpy, int screen, int* attrib_list, int* nelements) => GLXPointers._glXChooseFBConfig_fnptr(dpy, screen, attrib_list, nelements);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void* ChooseVisual(void* dpy, int screen, int* attribList) => GLXPointers._glXChooseVisual_fnptr(dpy, screen, attribList);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void CopyContext(void* dpy, void src, void dst, ulong mask) => GLXPointers._glXCopyContext_fnptr(dpy, src, dst, mask);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void CreateContext(void* dpy, void* vis, void shareList, bool direct) => GLXPointers._glXCreateContext_fnptr(dpy, vis, shareList, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void CreateGLXPixmap(void* dpy, void* visual, void pixmap) => GLXPointers._glXCreateGLXPixmap_fnptr(dpy, visual, pixmap);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void CreateNewContext(void* dpy, void config, int render_type, void share_list, bool direct) => GLXPointers._glXCreateNewContext_fnptr(dpy, config, render_type, share_list, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void CreatePbuffer(void* dpy, void config, int* attrib_list) => GLXPointers._glXCreatePbuffer_fnptr(dpy, config, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void CreatePixmap(void* dpy, void config, void pixmap, int* attrib_list) => GLXPointers._glXCreatePixmap_fnptr(dpy, config, pixmap, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void CreateWindow(void* dpy, void config, void win, int* attrib_list) => GLXPointers._glXCreateWindow_fnptr(dpy, config, win, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void DestroyContext(void* dpy, void ctx) => GLXPointers._glXDestroyContext_fnptr(dpy, ctx);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void DestroyGLXPixmap(void* dpy, void pixmap) => GLXPointers._glXDestroyGLXPixmap_fnptr(dpy, pixmap);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void DestroyPbuffer(void* dpy, void pbuf) => GLXPointers._glXDestroyPbuffer_fnptr(dpy, pbuf);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void DestroyPixmap(void* dpy, void pixmap) => GLXPointers._glXDestroyPixmap_fnptr(dpy, pixmap);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void DestroyWindow(void* dpy, void win) => GLXPointers._glXDestroyWindow_fnptr(dpy, win);
        
        /// <summary> <b>[requires: v1.1]</b>   </summary>
        public static byte* GetClientString(void* dpy, int name) => GLXPointers._glXGetClientString_fnptr(dpy, name);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int GetConfig(void* dpy, void* visual, int attrib, int* value) => GLXPointers._glXGetConfig_fnptr(dpy, visual, attrib, value);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void GetCurrentContext() => GLXPointers._glXGetCurrentContext_fnptr();
        
        /// <summary> <b>[requires: v1.2]</b>   </summary>
        public static void* GetCurrentDisplay() => GLXPointers._glXGetCurrentDisplay_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void GetCurrentDrawable() => GLXPointers._glXGetCurrentDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void GetCurrentReadDrawable() => GLXPointers._glXGetCurrentReadDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static int GetFBConfigAttrib(void* dpy, void config, int attribute, int* value) => GLXPointers._glXGetFBConfigAttrib_fnptr(dpy, config, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void* GetFBConfigs(void* dpy, int screen, int* nelements) => GLXPointers._glXGetFBConfigs_fnptr(dpy, screen, nelements);
        
        /// <summary> <b>[requires: v1.4]</b>   </summary>
        public static void GetProcAddress(byte* procName) => GLXPointers._glXGetProcAddress_fnptr(procName);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void GetSelectedEvent(void* dpy, void draw, ulong* event_mask) => GLXPointers._glXGetSelectedEvent_fnptr(dpy, draw, event_mask);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void* GetVisualFromFBConfig(void* dpy, void config) => GLXPointers._glXGetVisualFromFBConfig_fnptr(dpy, config);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool IsDirect(void* dpy, void ctx) => GLXPointers._glXIsDirect_fnptr(dpy, ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static bool MakeContextCurrent(void* dpy, void draw, void read, void ctx) => GLXPointers._glXMakeContextCurrent_fnptr(dpy, draw, read, ctx) != 0;
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool MakeCurrent(void* dpy, void drawable, void ctx) => GLXPointers._glXMakeCurrent_fnptr(dpy, drawable, ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static int QueryContext(void* dpy, void ctx, int attribute, int* value) => GLXPointers._glXQueryContext_fnptr(dpy, ctx, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void QueryDrawable(void* dpy, void draw, int attribute, uint* value) => GLXPointers._glXQueryDrawable_fnptr(dpy, draw, attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool QueryExtension(void* dpy, int* errorb, int* @event) => GLXPointers._glXQueryExtension_fnptr(dpy, errorb, @event) != 0;
        
        /// <summary> <b>[requires: v1.1]</b>   </summary>
        public static byte* QueryExtensionsString(void* dpy, int screen) => GLXPointers._glXQueryExtensionsString_fnptr(dpy, screen);
        
        /// <summary> <b>[requires: v1.1]</b>   </summary>
        public static byte* QueryServerString(void* dpy, int screen, int name) => GLXPointers._glXQueryServerString_fnptr(dpy, screen, name);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool QueryVersion(void* dpy, int* maj, int* min) => GLXPointers._glXQueryVersion_fnptr(dpy, maj, min) != 0;
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void SelectEvent(void* dpy, void draw, ulong event_mask) => GLXPointers._glXSelectEvent_fnptr(dpy, draw, event_mask);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void SwapBuffers(void* dpy, void drawable) => GLXPointers._glXSwapBuffers_fnptr(dpy, drawable);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void UseXFont(void font, int first, int count, int list) => GLXPointers._glXUseXFont_fnptr(font, first, count, list);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void WaitGL() => GLXPointers._glXWaitGL_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void WaitX() => GLXPointers._glXWaitX_fnptr();
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static void BlitContextFramebufferAMD(void dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, All filter) => GLXPointers._glXBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, (uint)filter);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static void CreateAssociatedContextAMD(uint id, void share_list) => GLXPointers._glXCreateAssociatedContextAMD_fnptr(id, share_list);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static void CreateAssociatedContextAttribsAMD(uint id, void share_context, int* attribList) => GLXPointers._glXCreateAssociatedContextAttribsAMD_fnptr(id, share_context, attribList);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static bool DeleteAssociatedContextAMD(void ctx) => GLXPointers._glXDeleteAssociatedContextAMD_fnptr(ctx) != 0;
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static uint GetContextGPUIDAMD(void ctx) => GLXPointers._glXGetContextGPUIDAMD_fnptr(ctx);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static void GetCurrentAssociatedContextAMD() => GLXPointers._glXGetCurrentAssociatedContextAMD_fnptr();
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static uint GetGPUIDsAMD(uint maxCount, uint* ids) => GLXPointers._glXGetGPUIDsAMD_fnptr(maxCount, ids);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static int GetGPUInfoAMD(uint id, int property, All dataType, uint size, void* data) => GLXPointers._glXGetGPUInfoAMD_fnptr(id, property, (uint)dataType, size, data);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static bool MakeAssociatedContextCurrentAMD(void ctx) => GLXPointers._glXMakeAssociatedContextCurrentAMD_fnptr(ctx) != 0;
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            /// <summary> <b>[requires: GLX_ARB_create_context]</b>   </summary>
            public static void CreateContextAttribsARB(void* dpy, void config, void share_context, bool direct, int* attrib_list) => GLXPointers._glXCreateContextAttribsARB_fnptr(dpy, config, share_context, (byte)(direct ? 1 : 0), attrib_list);
            
            /// <summary> <b>[requires: GLX_ARB_get_proc_address]</b>   </summary>
            public static void GetProcAddressARB(byte* procName) => GLXPointers._glXGetProcAddressARB_fnptr(procName);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b>   </summary>
            public static void BindTexImageEXT(void* dpy, void drawable, int buffer, int* attrib_list) => GLXPointers._glXBindTexImageEXT_fnptr(dpy, drawable, buffer, attrib_list);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static void FreeContextEXT(void* dpy, void context) => GLXPointers._glXFreeContextEXT_fnptr(dpy, context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static void GetContextIDEXT(void context) => GLXPointers._glXGetContextIDEXT_fnptr(context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static void* GetCurrentDisplayEXT() => GLXPointers._glXGetCurrentDisplayEXT_fnptr();
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static void ImportContextEXT(void* dpy, void contextID) => GLXPointers._glXImportContextEXT_fnptr(dpy, contextID);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static int QueryContextInfoEXT(void* dpy, void context, int attribute, int* value) => GLXPointers._glXQueryContextInfoEXT_fnptr(dpy, context, attribute, value);
            
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b>   </summary>
            public static void ReleaseTexImageEXT(void* dpy, void drawable, int buffer) => GLXPointers._glXReleaseTexImageEXT_fnptr(dpy, drawable, buffer);
            
            /// <summary> <b>[requires: GLX_EXT_swap_control]</b>   </summary>
            public static void SwapIntervalEXT(void* dpy, void drawable, int interval) => GLXPointers._glXSwapIntervalEXT_fnptr(dpy, drawable, interval);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GLX_MESA_copy_sub_buffer]</b>   </summary>
            public static void CopySubBufferMESA(void* dpy, void drawable, int x, int y, int width, int height) => GLXPointers._glXCopySubBufferMESA_fnptr(dpy, drawable, x, y, width, height);
            
            /// <summary> <b>[requires: GLX_MESA_pixmap_colormap]</b>   </summary>
            public static void CreateGLXPixmapMESA(void* dpy, void* visual, void pixmap, GLXColormap cmap) => GLXPointers._glXCreateGLXPixmapMESA_fnptr(dpy, visual, pixmap, (ulong)cmap);
            
            /// <summary> <b>[requires: GLX_MESA_agp_offset]</b>   </summary>
            public static uint GetAGPOffsetMESA(void* pointer) => GLXPointers._glXGetAGPOffsetMESA_fnptr(pointer);
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b>   </summary>
            public static int GetSwapIntervalMESA() => GLXPointers._glXGetSwapIntervalMESA_fnptr();
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static bool QueryCurrentRendererIntegerMESA(int attribute, uint* value) => GLXPointers._glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static byte* QueryCurrentRendererStringMESA_(int attribute) => GLXPointers._glXQueryCurrentRendererStringMESA_fnptr(attribute);
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static bool QueryRendererIntegerMESA(void* dpy, int screen, int renderer, int attribute, uint* value) => GLXPointers._glXQueryRendererIntegerMESA_fnptr(dpy, screen, renderer, attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static byte* QueryRendererStringMESA(void* dpy, int screen, int renderer, int attribute) => GLXPointers._glXQueryRendererStringMESA_fnptr(dpy, screen, renderer, attribute);
            
            /// <summary> <b>[requires: GLX_MESA_release_buffers]</b>   </summary>
            public static bool ReleaseBuffersMESA(void* dpy, void drawable) => GLXPointers._glXReleaseBuffersMESA_fnptr(dpy, drawable) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_set_3dfx_mode]</b>   </summary>
            public static bool Set3DfxModeMESA(int mode) => GLXPointers._glXSet3DfxModeMESA_fnptr(mode) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b>   </summary>
            public static int SwapIntervalMESA(uint interval) => GLXPointers._glXSwapIntervalMESA_fnptr(interval);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool BindSwapBarrierNV(void* dpy, uint group, uint barrier) => GLXPointers._glXBindSwapBarrierNV_fnptr(dpy, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static int BindVideoCaptureDeviceNV(void* dpy, uint video_capture_slot, void device) => GLXPointers._glXBindVideoCaptureDeviceNV_fnptr(dpy, video_capture_slot, device);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b>   </summary>
            public static int BindVideoDeviceNV(void* dpy, uint video_slot, uint video_device, int* attrib_list) => GLXPointers._glXBindVideoDeviceNV_fnptr(dpy, video_slot, video_device, attrib_list);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int BindVideoImageNV(void* dpy, void VideoDevice, void pbuf, int iVideoBuffer) => GLXPointers._glXBindVideoImageNV_fnptr(dpy, VideoDevice, pbuf, iVideoBuffer);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b>   </summary>
            public static void CopyBufferSubDataNV(void* dpy, void readCtx, void writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLXPointers._glXCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, (uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_copy_image]</b>   </summary>
            public static void CopyImageSubDataNV(void* dpy, void srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, void dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => GLXPointers._glXCopyImageSubDataNV_fnptr(dpy, srcCtx, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            /// <summary> <b>[requires: GLX_NV_delay_before_swap]</b>   </summary>
            public static bool DelayBeforeSwapNV(void* dpy, void drawable, float seconds) => GLXPointers._glXDelayBeforeSwapNV_fnptr(dpy, drawable, seconds) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static void* EnumerateVideoCaptureDevicesNV(void* dpy, int screen, int* nelements) => GLXPointers._glXEnumerateVideoCaptureDevicesNV_fnptr(dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b>   </summary>
            public static uint* EnumerateVideoDevicesNV(void* dpy, int screen, int* nelements) => GLXPointers._glXEnumerateVideoDevicesNV_fnptr(dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int GetVideoDeviceNV(void* dpy, int screen, int numVideoDevices, void* pVideoDevice) => GLXPointers._glXGetVideoDeviceNV_fnptr(dpy, screen, numVideoDevices, pVideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int GetVideoInfoNV(void* dpy, int screen, void VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo) => GLXPointers._glXGetVideoInfoNV_fnptr(dpy, screen, VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool JoinSwapGroupNV(void* dpy, void drawable, uint group) => GLXPointers._glXJoinSwapGroupNV_fnptr(dpy, drawable, group) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static void LockVideoCaptureDeviceNV(void* dpy, void device) => GLXPointers._glXLockVideoCaptureDeviceNV_fnptr(dpy, device);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b>   </summary>
            public static void NamedCopyBufferSubDataNV(void* dpy, void readCtx, void writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLXPointers._glXNamedCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool QueryFrameCountNV(void* dpy, int screen, uint* count) => GLXPointers._glXQueryFrameCountNV_fnptr(dpy, screen, count) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool QueryMaxSwapGroupsNV(void* dpy, int screen, uint* maxGroups, uint* maxBarriers) => GLXPointers._glXQueryMaxSwapGroupsNV_fnptr(dpy, screen, maxGroups, maxBarriers) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool QuerySwapGroupNV(void* dpy, void drawable, uint* group, uint* barrier) => GLXPointers._glXQuerySwapGroupNV_fnptr(dpy, drawable, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static int QueryVideoCaptureDeviceNV(void* dpy, void device, int attribute, int* value) => GLXPointers._glXQueryVideoCaptureDeviceNV_fnptr(dpy, device, attribute, value);
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static void ReleaseVideoCaptureDeviceNV(void* dpy, void device) => GLXPointers._glXReleaseVideoCaptureDeviceNV_fnptr(dpy, device);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int ReleaseVideoDeviceNV(void* dpy, int screen, void VideoDevice) => GLXPointers._glXReleaseVideoDeviceNV_fnptr(dpy, screen, VideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int ReleaseVideoImageNV(void* dpy, void pbuf) => GLXPointers._glXReleaseVideoImageNV_fnptr(dpy, pbuf);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool ResetFrameCountNV(void* dpy, int screen) => GLXPointers._glXResetFrameCountNV_fnptr(dpy, screen) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int SendPbufferToVideoNV(void* dpy, void pbuf, int iBufferType, ulong* pulCounterPbuffer, bool bBlock) => GLXPointers._glXSendPbufferToVideoNV_fnptr(dpy, pbuf, iBufferType, pulCounterPbuffer, (byte)(bBlock ? 1 : 0));
            
        }
        /// <summary>OML extensions.</summary>
        public static unsafe partial class OML
        {
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool GetMscRateOML(void* dpy, void drawable, int* numerator, int* denominator) => GLXPointers._glXGetMscRateOML_fnptr(dpy, drawable, numerator, denominator) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool GetSyncValuesOML(void* dpy, void drawable, long* ust, long* msc, long* sbc) => GLXPointers._glXGetSyncValuesOML_fnptr(dpy, drawable, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static long SwapBuffersMscOML(void* dpy, void drawable, long target_msc, long divisor, long remainder) => GLXPointers._glXSwapBuffersMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool WaitForMscOML(void* dpy, void drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc) => GLXPointers._glXWaitForMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool WaitForSbcOML(void* dpy, void drawable, long target_sbc, long* ust, long* msc, long* sbc) => GLXPointers._glXWaitForSbcOML_fnptr(dpy, drawable, target_sbc, ust, msc, sbc) != 0;
            
        }
        /// <summary>SGI extensions.</summary>
        public static unsafe partial class SGI
        {
            /// <summary> <b>[requires: GLX_SGI_cushion]</b>   </summary>
            public static void CushionSGI(void* dpy, void window, float cushion) => GLXPointers._glXCushionSGI_fnptr(dpy, window, cushion);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b>   </summary>
            public static void GetCurrentReadDrawableSGI() => GLXPointers._glXGetCurrentReadDrawableSGI_fnptr();
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b>   </summary>
            public static int GetVideoSyncSGI(uint* count) => GLXPointers._glXGetVideoSyncSGI_fnptr(count);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b>   </summary>
            public static bool MakeCurrentReadSGI(void* dpy, void draw, void read, void ctx) => GLXPointers._glXMakeCurrentReadSGI_fnptr(dpy, draw, read, ctx) != 0;
            
            /// <summary> <b>[requires: GLX_SGI_swap_control]</b>   </summary>
            public static int SwapIntervalSGI(int interval) => GLXPointers._glXSwapIntervalSGI_fnptr(interval);
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b>   </summary>
            public static int WaitVideoSyncSGI(int divisor, int remainder, uint* count) => GLXPointers._glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
            
        }
        /// <summary>SGIX extensions.</summary>
        public static unsafe partial class SGIX
        {
            /// <summary> <b>[requires: GLX_SGIX_dmbuffer]</b>   </summary>
            public static bool AssociateDMPbufferSGIX(void* dpy, void pbuffer, void* parameters, void dmbuffer) => GLXPointers._glXAssociateDMPbufferSGIX_fnptr(dpy, pbuffer, parameters, dmbuffer) != 0;
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int BindChannelToWindowSGIX(void* display, int screen, int channel, void window) => GLXPointers._glXBindChannelToWindowSGIX_fnptr(display, screen, channel, window);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int BindHyperpipeSGIX(void* dpy, int hpId) => GLXPointers._glXBindHyperpipeSGIX_fnptr(dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b>   </summary>
            public static void BindSwapBarrierSGIX(void* dpy, void drawable, int barrier) => GLXPointers._glXBindSwapBarrierSGIX_fnptr(dpy, drawable, barrier);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int ChannelRectSGIX(void* display, int screen, int channel, int x, int y, int w, int h) => GLXPointers._glXChannelRectSGIX_fnptr(display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int ChannelRectSyncSGIX(void* display, int screen, int channel, All synctype) => GLXPointers._glXChannelRectSyncSGIX_fnptr(display, screen, channel, (uint)synctype);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static void* ChooseFBConfigSGIX(void* dpy, int screen, int* attrib_list, int* nelements) => GLXPointers._glXChooseFBConfigSGIX_fnptr(dpy, screen, attrib_list, nelements);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static void CreateContextWithConfigSGIX(void* dpy, void config, int render_type, void share_list, bool direct) => GLXPointers._glXCreateContextWithConfigSGIX_fnptr(dpy, config, render_type, share_list, (byte)(direct ? 1 : 0));
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void CreateGLXPbufferSGIX(void* dpy, void config, uint width, uint height, int* attrib_list) => GLXPointers._glXCreateGLXPbufferSGIX_fnptr(dpy, config, width, height, attrib_list);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static void CreateGLXPixmapWithConfigSGIX(void* dpy, void config, void pixmap) => GLXPointers._glXCreateGLXPixmapWithConfigSGIX_fnptr(dpy, config, pixmap);
            
            /// <summary> <b>[requires: GLX_SGIX_video_source]</b>   </summary>
            public static void CreateGLXVideoSourceSGIX(void* display, int screen, void server, void path, int nodeClass, void drainNode) => GLXPointers._glXCreateGLXVideoSourceSGIX_fnptr(display, screen, server, path, nodeClass, drainNode);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void DestroyGLXPbufferSGIX(void* dpy, void pbuf) => GLXPointers._glXDestroyGLXPbufferSGIX_fnptr(dpy, pbuf);
            
            /// <summary> <b>[requires: GLX_SGIX_video_source]</b>   </summary>
            public static void DestroyGLXVideoSourceSGIX(void* dpy, void glxvideosource) => GLXPointers._glXDestroyGLXVideoSourceSGIX_fnptr(dpy, glxvideosource);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int DestroyHyperpipeConfigSGIX(void* dpy, int hpId) => GLXPointers._glXDestroyHyperpipeConfigSGIX_fnptr(dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static int GetFBConfigAttribSGIX(void* dpy, void config, int attribute, int* value) => GLXPointers._glXGetFBConfigAttribSGIX_fnptr(dpy, config, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static void GetFBConfigFromVisualSGIX(void* dpy, void* vis) => GLXPointers._glXGetFBConfigFromVisualSGIX_fnptr(dpy, vis);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void GetSelectedEventSGIX(void* dpy, void drawable, ulong* mask) => GLXPointers._glXGetSelectedEventSGIX_fnptr(dpy, drawable, mask);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static void* GetVisualFromFBConfigSGIX(void* dpy, void config) => GLXPointers._glXGetVisualFromFBConfigSGIX_fnptr(dpy, config);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int HyperpipeAttribSGIX(void* dpy, int timeSlice, int attrib, int size, void* attribList) => GLXPointers._glXHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int HyperpipeConfigSGIX(void* dpy, int networkId, int npipes, void* cfg, int* hpId) => GLXPointers._glXHyperpipeConfigSGIX_fnptr(dpy, networkId, npipes, cfg, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_group]</b>   </summary>
            public static void JoinSwapGroupSGIX(void* dpy, void drawable, void member) => GLXPointers._glXJoinSwapGroupSGIX_fnptr(dpy, drawable, member);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int QueryChannelDeltasSGIX(void* display, int screen, int channel, int* x, int* y, int* w, int* h) => GLXPointers._glXQueryChannelDeltasSGIX_fnptr(display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int QueryChannelRectSGIX(void* display, int screen, int channel, int* dx, int* dy, int* dw, int* dh) => GLXPointers._glXQueryChannelRectSGIX_fnptr(display, screen, channel, dx, dy, dw, dh);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void QueryGLXPbufferSGIX(void* dpy, void pbuf, int attribute, uint* value) => GLXPointers._glXQueryGLXPbufferSGIX_fnptr(dpy, pbuf, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int QueryHyperpipeAttribSGIX(void* dpy, int timeSlice, int attrib, int size, void* returnAttribList) => GLXPointers._glXQueryHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int QueryHyperpipeBestAttribSGIX(void* dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList) => GLXPointers._glXQueryHyperpipeBestAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static void* QueryHyperpipeConfigSGIX(void* dpy, int hpId, int* npipes) => GLXPointers._glXQueryHyperpipeConfigSGIX_fnptr(dpy, hpId, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static void* QueryHyperpipeNetworkSGIX(void* dpy, int* npipes) => GLXPointers._glXQueryHyperpipeNetworkSGIX_fnptr(dpy, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b>   </summary>
            public static bool QueryMaxSwapBarriersSGIX(void* dpy, int screen, int* max) => GLXPointers._glXQueryMaxSwapBarriersSGIX_fnptr(dpy, screen, max) != 0;
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void SelectEventSGIX(void* dpy, void drawable, ulong mask) => GLXPointers._glXSelectEventSGIX_fnptr(dpy, drawable, mask);
            
        }
        /// <summary>SUN extensions.</summary>
        public static unsafe partial class SUN
        {
            /// <summary> <b>[requires: GLX_SUN_get_transparent_index]</b>   </summary>
            public static void GetTransparentIndexSUN(void* dpy, void overlay, void underlay, ulong* pTransparentIndex) => GLXPointers._glXGetTransparentIndexSUN_fnptr(dpy, overlay, underlay, pTransparentIndex);
            
        }
    }
}
