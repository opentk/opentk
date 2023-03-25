// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class GLX
    {
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static __GLXFBConfigRec** ChooseFBConfig(Display* dpy, int screen, int* attrib_list, int* nelements) => GLXPointers._glXChooseFBConfig_fnptr((ulong*)dpy, screen, attrib_list, nelements);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static XVisualInfo* ChooseVisual(Display* dpy, int screen, int* attribList) => (XVisualInfo*) GLXPointers._glXChooseVisual_fnptr((ulong*)dpy, screen, attribList);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void CopyContext(Display* dpy, __GLXContextRec* src, __GLXContextRec* dst, ulong mask) => GLXPointers._glXCopyContext_fnptr((ulong*)dpy, src, dst, mask);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static __GLXContextRec* CreateContext(Display* dpy, XVisualInfo* vis, __GLXContextRec* shareList, bool direct) => GLXPointers._glXCreateContext_fnptr((ulong*)dpy, (ulong*)vis, shareList, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static GLXPixmap CreateGLXPixmap(Display* dpy, XVisualInfo* visual, Pixmap pixmap) => (GLXPixmap) GLXPointers._glXCreateGLXPixmap_fnptr((ulong*)dpy, (ulong*)visual, (ulong)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static __GLXContextRec* CreateNewContext(Display* dpy, __GLXFBConfigRec* config, int render_type, __GLXContextRec* share_list, bool direct) => GLXPointers._glXCreateNewContext_fnptr((ulong*)dpy, config, render_type, share_list, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static GLXPbuffer CreatePbuffer(Display* dpy, __GLXFBConfigRec* config, int* attrib_list) => (GLXPbuffer) GLXPointers._glXCreatePbuffer_fnptr((ulong*)dpy, config, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static GLXPixmap CreatePixmap(Display* dpy, __GLXFBConfigRec* config, Pixmap pixmap, int* attrib_list) => (GLXPixmap) GLXPointers._glXCreatePixmap_fnptr((ulong*)dpy, config, (ulong)pixmap, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static GLXWindow CreateWindow(Display* dpy, __GLXFBConfigRec* config, Window win, int* attrib_list) => (GLXWindow) GLXPointers._glXCreateWindow_fnptr((ulong*)dpy, config, (ulong)win, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void DestroyContext(Display* dpy, __GLXContextRec* ctx) => GLXPointers._glXDestroyContext_fnptr((ulong*)dpy, ctx);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void DestroyGLXPixmap(Display* dpy, GLXPixmap pixmap) => GLXPointers._glXDestroyGLXPixmap_fnptr((ulong*)dpy, (ulong)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void DestroyPbuffer(Display* dpy, GLXPbuffer pbuf) => GLXPointers._glXDestroyPbuffer_fnptr((ulong*)dpy, (ulong)pbuf);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void DestroyPixmap(Display* dpy, GLXPixmap pixmap) => GLXPointers._glXDestroyPixmap_fnptr((ulong*)dpy, (ulong)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void DestroyWindow(Display* dpy, GLXWindow win) => GLXPointers._glXDestroyWindow_fnptr((ulong*)dpy, (ulong)win);
        
        /// <summary> <b>[requires: v1.1]</b>   </summary>
        public static byte* GetClientString(Display* dpy, int name) => GLXPointers._glXGetClientString_fnptr((ulong*)dpy, name);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static int GetConfig(Display* dpy, XVisualInfo* visual, int attrib, int* value) => GLXPointers._glXGetConfig_fnptr((ulong*)dpy, (ulong*)visual, attrib, value);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static __GLXContextRec* GetCurrentContext() => GLXPointers._glXGetCurrentContext_fnptr();
        
        /// <summary> <b>[requires: v1.2]</b>   </summary>
        public static Display* GetCurrentDisplay() => (Display*) GLXPointers._glXGetCurrentDisplay_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static GLXDrawable GetCurrentDrawable() => (GLXDrawable) GLXPointers._glXGetCurrentDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static GLXDrawable GetCurrentReadDrawable() => (GLXDrawable) GLXPointers._glXGetCurrentReadDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static int GetFBConfigAttrib(Display* dpy, __GLXFBConfigRec* config, int attribute, int* value) => GLXPointers._glXGetFBConfigAttrib_fnptr((ulong*)dpy, config, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static __GLXFBConfigRec** GetFBConfigs(Display* dpy, int screen, int* nelements) => GLXPointers._glXGetFBConfigs_fnptr((ulong*)dpy, screen, nelements);
        
        /// <summary> <b>[requires: v1.4]</b>   </summary>
        public static IntPtr GetProcAddress(byte* procName) => GLXPointers._glXGetProcAddress_fnptr(procName);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void GetSelectedEvent(Display* dpy, GLXDrawable draw, ulong* event_mask) => GLXPointers._glXGetSelectedEvent_fnptr((ulong*)dpy, (ulong)draw, event_mask);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static XVisualInfo* GetVisualFromFBConfig(Display* dpy, __GLXFBConfigRec* config) => (XVisualInfo*) GLXPointers._glXGetVisualFromFBConfig_fnptr((ulong*)dpy, config);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool IsDirect(Display* dpy, __GLXContextRec* ctx) => GLXPointers._glXIsDirect_fnptr((ulong*)dpy, ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static bool MakeContextCurrent(Display* dpy, GLXDrawable draw, GLXDrawable read, __GLXContextRec* ctx) => GLXPointers._glXMakeContextCurrent_fnptr((ulong*)dpy, (ulong)draw, (ulong)read, ctx) != 0;
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool MakeCurrent(Display* dpy, GLXDrawable drawable, __GLXContextRec* ctx) => GLXPointers._glXMakeCurrent_fnptr((ulong*)dpy, (ulong)drawable, ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static int QueryContext(Display* dpy, __GLXContextRec* ctx, int attribute, int* value) => GLXPointers._glXQueryContext_fnptr((ulong*)dpy, ctx, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void QueryDrawable(Display* dpy, GLXDrawable draw, int attribute, uint* value) => GLXPointers._glXQueryDrawable_fnptr((ulong*)dpy, (ulong)draw, attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool QueryExtension(Display* dpy, int* errorb, int* @event) => GLXPointers._glXQueryExtension_fnptr((ulong*)dpy, errorb, @event) != 0;
        
        /// <summary> <b>[requires: v1.1]</b>   </summary>
        public static byte* QueryExtensionsString(Display* dpy, int screen) => GLXPointers._glXQueryExtensionsString_fnptr((ulong*)dpy, screen);
        
        /// <summary> <b>[requires: v1.1]</b>   </summary>
        public static byte* QueryServerString(Display* dpy, int screen, int name) => GLXPointers._glXQueryServerString_fnptr((ulong*)dpy, screen, name);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static bool QueryVersion(Display* dpy, int* maj, int* min) => GLXPointers._glXQueryVersion_fnptr((ulong*)dpy, maj, min) != 0;
        
        /// <summary> <b>[requires: v1.3]</b>   </summary>
        public static void SelectEvent(Display* dpy, GLXDrawable draw, ulong event_mask) => GLXPointers._glXSelectEvent_fnptr((ulong*)dpy, (ulong)draw, event_mask);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void SwapBuffers(Display* dpy, GLXDrawable drawable) => GLXPointers._glXSwapBuffers_fnptr((ulong*)dpy, (ulong)drawable);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void UseXFont(Font font, int first, int count, int list) => GLXPointers._glXUseXFont_fnptr((ulong)font, first, count, list);
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void WaitGL() => GLXPointers._glXWaitGL_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b>   </summary>
        public static void WaitX() => GLXPointers._glXWaitX_fnptr();
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static void BlitContextFramebufferAMD(__GLXContextRec* dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, All filter) => GLXPointers._glXBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, (uint)filter);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static __GLXContextRec* CreateAssociatedContextAMD(uint id, __GLXContextRec* share_list) => GLXPointers._glXCreateAssociatedContextAMD_fnptr(id, share_list);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static __GLXContextRec* CreateAssociatedContextAttribsAMD(uint id, __GLXContextRec* share_context, int* attribList) => GLXPointers._glXCreateAssociatedContextAttribsAMD_fnptr(id, share_context, attribList);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static bool DeleteAssociatedContextAMD(__GLXContextRec* ctx) => GLXPointers._glXDeleteAssociatedContextAMD_fnptr(ctx) != 0;
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static uint GetContextGPUIDAMD(__GLXContextRec* ctx) => GLXPointers._glXGetContextGPUIDAMD_fnptr(ctx);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static __GLXContextRec* GetCurrentAssociatedContextAMD() => GLXPointers._glXGetCurrentAssociatedContextAMD_fnptr();
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static uint GetGPUIDsAMD(uint maxCount, uint* ids) => GLXPointers._glXGetGPUIDsAMD_fnptr(maxCount, ids);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static int GetGPUInfoAMD(uint id, int property, All dataType, uint size, void* data) => GLXPointers._glXGetGPUInfoAMD_fnptr(id, property, (uint)dataType, size, data);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b>   </summary>
            public static bool MakeAssociatedContextCurrentAMD(__GLXContextRec* ctx) => GLXPointers._glXMakeAssociatedContextCurrentAMD_fnptr(ctx) != 0;
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            /// <summary> <b>[requires: GLX_ARB_create_context]</b>   </summary>
            public static __GLXContextRec* CreateContextAttribsARB(Display* dpy, __GLXFBConfigRec* config, __GLXContextRec* share_context, bool direct, int* attrib_list) => GLXPointers._glXCreateContextAttribsARB_fnptr((ulong*)dpy, config, share_context, (byte)(direct ? 1 : 0), attrib_list);
            
            /// <summary> <b>[requires: GLX_ARB_get_proc_address]</b>   </summary>
            public static IntPtr GetProcAddressARB(byte* procName) => GLXPointers._glXGetProcAddressARB_fnptr(procName);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b>   </summary>
            public static void BindTexImageEXT(Display* dpy, GLXDrawable drawable, int buffer, int* attrib_list) => GLXPointers._glXBindTexImageEXT_fnptr((ulong*)dpy, (ulong)drawable, buffer, attrib_list);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static void FreeContextEXT(Display* dpy, __GLXContextRec* context) => GLXPointers._glXFreeContextEXT_fnptr((ulong*)dpy, context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static ContextID GetContextIDEXT(__GLXContextRec* context) => (ContextID) GLXPointers._glXGetContextIDEXT_fnptr(context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static Display* GetCurrentDisplayEXT() => (Display*) GLXPointers._glXGetCurrentDisplayEXT_fnptr();
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static __GLXContextRec* ImportContextEXT(Display* dpy, ContextID contextID) => GLXPointers._glXImportContextEXT_fnptr((ulong*)dpy, (ulong)contextID);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b>   </summary>
            public static int QueryContextInfoEXT(Display* dpy, __GLXContextRec* context, int attribute, int* value) => GLXPointers._glXQueryContextInfoEXT_fnptr((ulong*)dpy, context, attribute, value);
            
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b>   </summary>
            public static void ReleaseTexImageEXT(Display* dpy, GLXDrawable drawable, int buffer) => GLXPointers._glXReleaseTexImageEXT_fnptr((ulong*)dpy, (ulong)drawable, buffer);
            
            /// <summary> <b>[requires: GLX_EXT_swap_control]</b>   </summary>
            public static void SwapIntervalEXT(Display* dpy, GLXDrawable drawable, int interval) => GLXPointers._glXSwapIntervalEXT_fnptr((ulong*)dpy, (ulong)drawable, interval);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GLX_MESA_copy_sub_buffer]</b>   </summary>
            public static void CopySubBufferMESA(Display* dpy, GLXDrawable drawable, int x, int y, int width, int height) => GLXPointers._glXCopySubBufferMESA_fnptr((ulong*)dpy, (ulong)drawable, x, y, width, height);
            
            /// <summary> <b>[requires: GLX_MESA_pixmap_colormap]</b>   </summary>
            public static GLXPixmap CreateGLXPixmapMESA(Display* dpy, XVisualInfo* visual, Pixmap pixmap, Colormap cmap) => (GLXPixmap) GLXPointers._glXCreateGLXPixmapMESA_fnptr((ulong*)dpy, (ulong*)visual, (ulong)pixmap, (ulong)cmap);
            
            /// <summary> <b>[requires: GLX_MESA_agp_offset]</b>   </summary>
            public static uint GetAGPOffsetMESA(void* pointer) => GLXPointers._glXGetAGPOffsetMESA_fnptr(pointer);
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b>   </summary>
            public static int GetSwapIntervalMESA() => GLXPointers._glXGetSwapIntervalMESA_fnptr();
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static bool QueryCurrentRendererIntegerMESA(int attribute, uint* value) => GLXPointers._glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static byte* QueryCurrentRendererStringMESA_(int attribute) => GLXPointers._glXQueryCurrentRendererStringMESA_fnptr(attribute);
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static bool QueryRendererIntegerMESA(Display* dpy, int screen, int renderer, int attribute, uint* value) => GLXPointers._glXQueryRendererIntegerMESA_fnptr((ulong*)dpy, screen, renderer, attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b>   </summary>
            public static byte* QueryRendererStringMESA(Display* dpy, int screen, int renderer, int attribute) => GLXPointers._glXQueryRendererStringMESA_fnptr((ulong*)dpy, screen, renderer, attribute);
            
            /// <summary> <b>[requires: GLX_MESA_release_buffers]</b>   </summary>
            public static bool ReleaseBuffersMESA(Display* dpy, GLXDrawable drawable) => GLXPointers._glXReleaseBuffersMESA_fnptr((ulong*)dpy, (ulong)drawable) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_set_3dfx_mode]</b>   </summary>
            public static bool Set3DfxModeMESA(int mode) => GLXPointers._glXSet3DfxModeMESA_fnptr(mode) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b>   </summary>
            public static int SwapIntervalMESA(uint interval) => GLXPointers._glXSwapIntervalMESA_fnptr(interval);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool BindSwapBarrierNV(Display* dpy, uint group, uint barrier) => GLXPointers._glXBindSwapBarrierNV_fnptr((ulong*)dpy, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static int BindVideoCaptureDeviceNV(Display* dpy, uint video_capture_slot, VideoCaptureDeviceNV device) => GLXPointers._glXBindVideoCaptureDeviceNV_fnptr((ulong*)dpy, video_capture_slot, (ulong)device);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b>   </summary>
            public static int BindVideoDeviceNV(Display* dpy, uint video_slot, uint video_device, int* attrib_list) => GLXPointers._glXBindVideoDeviceNV_fnptr((ulong*)dpy, video_slot, video_device, attrib_list);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int BindVideoImageNV(Display* dpy, VideoDeviceNV VideoDevice, GLXPbuffer pbuf, int iVideoBuffer) => GLXPointers._glXBindVideoImageNV_fnptr((ulong*)dpy, (uint)VideoDevice, (ulong)pbuf, iVideoBuffer);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b>   </summary>
            public static void CopyBufferSubDataNV(Display* dpy, __GLXContextRec* readCtx, __GLXContextRec* writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLXPointers._glXCopyBufferSubDataNV_fnptr((ulong*)dpy, readCtx, writeCtx, (uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_copy_image]</b>   </summary>
            public static void CopyImageSubDataNV(Display* dpy, __GLXContextRec* srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, __GLXContextRec* dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => GLXPointers._glXCopyImageSubDataNV_fnptr((ulong*)dpy, srcCtx, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            /// <summary> <b>[requires: GLX_NV_delay_before_swap]</b>   </summary>
            public static bool DelayBeforeSwapNV(Display* dpy, GLXDrawable drawable, float seconds) => GLXPointers._glXDelayBeforeSwapNV_fnptr((ulong*)dpy, (ulong)drawable, seconds) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static VideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(Display* dpy, int screen, int* nelements) => (VideoCaptureDeviceNV*) GLXPointers._glXEnumerateVideoCaptureDevicesNV_fnptr((ulong*)dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b>   </summary>
            public static uint* EnumerateVideoDevicesNV(Display* dpy, int screen, int* nelements) => GLXPointers._glXEnumerateVideoDevicesNV_fnptr((ulong*)dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int GetVideoDeviceNV(Display* dpy, int screen, int numVideoDevices, VideoDeviceNV* pVideoDevice) => GLXPointers._glXGetVideoDeviceNV_fnptr((ulong*)dpy, screen, numVideoDevices, (uint*)pVideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int GetVideoInfoNV(Display* dpy, int screen, VideoDeviceNV VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo) => GLXPointers._glXGetVideoInfoNV_fnptr((ulong*)dpy, screen, (uint)VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool JoinSwapGroupNV(Display* dpy, GLXDrawable drawable, uint group) => GLXPointers._glXJoinSwapGroupNV_fnptr((ulong*)dpy, (ulong)drawable, group) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static void LockVideoCaptureDeviceNV(Display* dpy, VideoCaptureDeviceNV device) => GLXPointers._glXLockVideoCaptureDeviceNV_fnptr((ulong*)dpy, (ulong)device);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b>   </summary>
            public static void NamedCopyBufferSubDataNV(Display* dpy, __GLXContextRec* readCtx, __GLXContextRec* writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLXPointers._glXNamedCopyBufferSubDataNV_fnptr((ulong*)dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool QueryFrameCountNV(Display* dpy, int screen, uint* count) => GLXPointers._glXQueryFrameCountNV_fnptr((ulong*)dpy, screen, count) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool QueryMaxSwapGroupsNV(Display* dpy, int screen, uint* maxGroups, uint* maxBarriers) => GLXPointers._glXQueryMaxSwapGroupsNV_fnptr((ulong*)dpy, screen, maxGroups, maxBarriers) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool QuerySwapGroupNV(Display* dpy, GLXDrawable drawable, uint* group, uint* barrier) => GLXPointers._glXQuerySwapGroupNV_fnptr((ulong*)dpy, (ulong)drawable, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static int QueryVideoCaptureDeviceNV(Display* dpy, VideoCaptureDeviceNV device, int attribute, int* value) => GLXPointers._glXQueryVideoCaptureDeviceNV_fnptr((ulong*)dpy, (ulong)device, attribute, value);
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b>   </summary>
            public static void ReleaseVideoCaptureDeviceNV(Display* dpy, VideoCaptureDeviceNV device) => GLXPointers._glXReleaseVideoCaptureDeviceNV_fnptr((ulong*)dpy, (ulong)device);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int ReleaseVideoDeviceNV(Display* dpy, int screen, VideoDeviceNV VideoDevice) => GLXPointers._glXReleaseVideoDeviceNV_fnptr((ulong*)dpy, screen, (uint)VideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int ReleaseVideoImageNV(Display* dpy, GLXPbuffer pbuf) => GLXPointers._glXReleaseVideoImageNV_fnptr((ulong*)dpy, (ulong)pbuf);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b>   </summary>
            public static bool ResetFrameCountNV(Display* dpy, int screen) => GLXPointers._glXResetFrameCountNV_fnptr((ulong*)dpy, screen) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b>   </summary>
            public static int SendPbufferToVideoNV(Display* dpy, GLXPbuffer pbuf, int iBufferType, ulong* pulCounterPbuffer, bool bBlock) => GLXPointers._glXSendPbufferToVideoNV_fnptr((ulong*)dpy, (ulong)pbuf, iBufferType, pulCounterPbuffer, (byte)(bBlock ? 1 : 0));
            
        }
        /// <summary>OML extensions.</summary>
        public static unsafe partial class OML
        {
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool GetMscRateOML(Display* dpy, GLXDrawable drawable, int* numerator, int* denominator) => GLXPointers._glXGetMscRateOML_fnptr((ulong*)dpy, (ulong)drawable, numerator, denominator) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool GetSyncValuesOML(Display* dpy, GLXDrawable drawable, long* ust, long* msc, long* sbc) => GLXPointers._glXGetSyncValuesOML_fnptr((ulong*)dpy, (ulong)drawable, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static long SwapBuffersMscOML(Display* dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder) => GLXPointers._glXSwapBuffersMscOML_fnptr((ulong*)dpy, (ulong)drawable, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool WaitForMscOML(Display* dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc) => GLXPointers._glXWaitForMscOML_fnptr((ulong*)dpy, (ulong)drawable, target_msc, divisor, remainder, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b>   </summary>
            public static bool WaitForSbcOML(Display* dpy, GLXDrawable drawable, long target_sbc, long* ust, long* msc, long* sbc) => GLXPointers._glXWaitForSbcOML_fnptr((ulong*)dpy, (ulong)drawable, target_sbc, ust, msc, sbc) != 0;
            
        }
        /// <summary>SGI extensions.</summary>
        public static unsafe partial class SGI
        {
            /// <summary> <b>[requires: GLX_SGI_cushion]</b>   </summary>
            public static void CushionSGI(Display* dpy, Window window, float cushion) => GLXPointers._glXCushionSGI_fnptr((ulong*)dpy, (ulong)window, cushion);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b>   </summary>
            public static GLXDrawable GetCurrentReadDrawableSGI() => (GLXDrawable) GLXPointers._glXGetCurrentReadDrawableSGI_fnptr();
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b>   </summary>
            public static int GetVideoSyncSGI(uint* count) => GLXPointers._glXGetVideoSyncSGI_fnptr(count);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b>   </summary>
            public static bool MakeCurrentReadSGI(Display* dpy, GLXDrawable draw, GLXDrawable read, __GLXContextRec* ctx) => GLXPointers._glXMakeCurrentReadSGI_fnptr((ulong*)dpy, (ulong)draw, (ulong)read, ctx) != 0;
            
            /// <summary> <b>[requires: GLX_SGI_swap_control]</b>   </summary>
            public static int SwapIntervalSGI(int interval) => GLXPointers._glXSwapIntervalSGI_fnptr(interval);
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b>   </summary>
            public static int WaitVideoSyncSGI(int divisor, int remainder, uint* count) => GLXPointers._glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
            
        }
        /// <summary>SGIX extensions.</summary>
        public static unsafe partial class SGIX
        {
            /// <summary> <b>[requires: GLX_SGIX_dmbuffer]</b>   </summary>
            public static bool AssociateDMPbufferSGIX(Display* dpy, GLXPbufferSGIX pbuffer, void* parameters, void dmbuffer) => GLXPointers._glXAssociateDMPbufferSGIX_fnptr((ulong*)dpy, (ulong)pbuffer, parameters, dmbuffer) != 0;
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int BindChannelToWindowSGIX(Display* display, int screen, int channel, Window window) => GLXPointers._glXBindChannelToWindowSGIX_fnptr((ulong*)display, screen, channel, (ulong)window);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int BindHyperpipeSGIX(Display* dpy, int hpId) => GLXPointers._glXBindHyperpipeSGIX_fnptr((ulong*)dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b>   </summary>
            public static void BindSwapBarrierSGIX(Display* dpy, GLXDrawable drawable, int barrier) => GLXPointers._glXBindSwapBarrierSGIX_fnptr((ulong*)dpy, (ulong)drawable, barrier);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int ChannelRectSGIX(Display* display, int screen, int channel, int x, int y, int w, int h) => GLXPointers._glXChannelRectSGIX_fnptr((ulong*)display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int ChannelRectSyncSGIX(Display* display, int screen, int channel, All synctype) => GLXPointers._glXChannelRectSyncSGIX_fnptr((ulong*)display, screen, channel, (uint)synctype);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static __GLXFBConfigRec** ChooseFBConfigSGIX(Display* dpy, int screen, int* attrib_list, int* nelements) => GLXPointers._glXChooseFBConfigSGIX_fnptr((ulong*)dpy, screen, attrib_list, nelements);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static __GLXContextRec* CreateContextWithConfigSGIX(Display* dpy, __GLXFBConfigRec* config, int render_type, __GLXContextRec* share_list, bool direct) => GLXPointers._glXCreateContextWithConfigSGIX_fnptr((ulong*)dpy, config, render_type, share_list, (byte)(direct ? 1 : 0));
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static GLXPbufferSGIX CreateGLXPbufferSGIX(Display* dpy, __GLXFBConfigRec* config, uint width, uint height, int* attrib_list) => (GLXPbufferSGIX) GLXPointers._glXCreateGLXPbufferSGIX_fnptr((ulong*)dpy, config, width, height, attrib_list);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static GLXPixmap CreateGLXPixmapWithConfigSGIX(Display* dpy, __GLXFBConfigRec* config, Pixmap pixmap) => (GLXPixmap) GLXPointers._glXCreateGLXPixmapWithConfigSGIX_fnptr((ulong*)dpy, config, (ulong)pixmap);
            
            /// <summary> <b>[requires: GLX_SGIX_video_source]</b>   </summary>
            public static VideoSourceSGIX CreateGLXVideoSourceSGIX(Display* display, int screen, void server, void path, int nodeClass, void drainNode) => (VideoSourceSGIX) GLXPointers._glXCreateGLXVideoSourceSGIX_fnptr((ulong*)display, screen, server, path, nodeClass, drainNode);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void DestroyGLXPbufferSGIX(Display* dpy, GLXPbufferSGIX pbuf) => GLXPointers._glXDestroyGLXPbufferSGIX_fnptr((ulong*)dpy, (ulong)pbuf);
            
            /// <summary> <b>[requires: GLX_SGIX_video_source]</b>   </summary>
            public static void DestroyGLXVideoSourceSGIX(Display* dpy, VideoSourceSGIX glxvideosource) => GLXPointers._glXDestroyGLXVideoSourceSGIX_fnptr((ulong*)dpy, (ulong)glxvideosource);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int DestroyHyperpipeConfigSGIX(Display* dpy, int hpId) => GLXPointers._glXDestroyHyperpipeConfigSGIX_fnptr((ulong*)dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static int GetFBConfigAttribSGIX(Display* dpy, __GLXFBConfigRec* config, int attribute, int* value) => GLXPointers._glXGetFBConfigAttribSGIX_fnptr((ulong*)dpy, config, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static __GLXFBConfigRec* GetFBConfigFromVisualSGIX(Display* dpy, XVisualInfo* vis) => GLXPointers._glXGetFBConfigFromVisualSGIX_fnptr((ulong*)dpy, (ulong*)vis);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void GetSelectedEventSGIX(Display* dpy, GLXDrawable drawable, ulong* mask) => GLXPointers._glXGetSelectedEventSGIX_fnptr((ulong*)dpy, (ulong)drawable, mask);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b>   </summary>
            public static XVisualInfo* GetVisualFromFBConfigSGIX(Display* dpy, __GLXFBConfigRec* config) => (XVisualInfo*) GLXPointers._glXGetVisualFromFBConfigSGIX_fnptr((ulong*)dpy, config);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int HyperpipeAttribSGIX(Display* dpy, int timeSlice, int attrib, int size, void* attribList) => GLXPointers._glXHyperpipeAttribSGIX_fnptr((ulong*)dpy, timeSlice, attrib, size, attribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int HyperpipeConfigSGIX(Display* dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId) => GLXPointers._glXHyperpipeConfigSGIX_fnptr((ulong*)dpy, networkId, npipes, cfg, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_group]</b>   </summary>
            public static void JoinSwapGroupSGIX(Display* dpy, GLXDrawable drawable, GLXDrawable member) => GLXPointers._glXJoinSwapGroupSGIX_fnptr((ulong*)dpy, (ulong)drawable, (ulong)member);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int QueryChannelDeltasSGIX(Display* display, int screen, int channel, int* x, int* y, int* w, int* h) => GLXPointers._glXQueryChannelDeltasSGIX_fnptr((ulong*)display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b>   </summary>
            public static int QueryChannelRectSGIX(Display* display, int screen, int channel, int* dx, int* dy, int* dw, int* dh) => GLXPointers._glXQueryChannelRectSGIX_fnptr((ulong*)display, screen, channel, dx, dy, dw, dh);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void QueryGLXPbufferSGIX(Display* dpy, GLXPbufferSGIX pbuf, int attribute, uint* value) => GLXPointers._glXQueryGLXPbufferSGIX_fnptr((ulong*)dpy, (ulong)pbuf, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int QueryHyperpipeAttribSGIX(Display* dpy, int timeSlice, int attrib, int size, void* returnAttribList) => GLXPointers._glXQueryHyperpipeAttribSGIX_fnptr((ulong*)dpy, timeSlice, attrib, size, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static int QueryHyperpipeBestAttribSGIX(Display* dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList) => GLXPointers._glXQueryHyperpipeBestAttribSGIX_fnptr((ulong*)dpy, timeSlice, attrib, size, attribList, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(Display* dpy, int hpId, int* npipes) => GLXPointers._glXQueryHyperpipeConfigSGIX_fnptr((ulong*)dpy, hpId, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b>   </summary>
            public static GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(Display* dpy, int* npipes) => GLXPointers._glXQueryHyperpipeNetworkSGIX_fnptr((ulong*)dpy, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b>   </summary>
            public static bool QueryMaxSwapBarriersSGIX(Display* dpy, int screen, int* max) => GLXPointers._glXQueryMaxSwapBarriersSGIX_fnptr((ulong*)dpy, screen, max) != 0;
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b>   </summary>
            public static void SelectEventSGIX(Display* dpy, GLXDrawable drawable, ulong mask) => GLXPointers._glXSelectEventSGIX_fnptr((ulong*)dpy, (ulong)drawable, mask);
            
        }
        /// <summary>SUN extensions.</summary>
        public static unsafe partial class SUN
        {
            /// <summary> <b>[requires: GLX_SUN_get_transparent_index]</b>   </summary>
            public static Status GetTransparentIndexSUN(Display* dpy, Window overlay, Window underlay, ulong* pTransparentIndex) => (Status) GLXPointers._glXGetTransparentIndexSUN_fnptr((ulong*)dpy, (ulong)overlay, (ulong)underlay, pTransparentIndex);
            
        }
    }
}
