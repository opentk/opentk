// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class GLX
    {
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXChooseFBConfig</c>]</b><br/>  </summary>
        public static GLXFBConfig* ChooseFBConfig(Display* dpy, int screen, int* attrib_list, int* nelements) => (GLXFBConfig*) GLXPointers._glXChooseFBConfig_fnptr(dpy, screen, attrib_list, nelements);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXChooseVisual</c>]</b><br/>  </summary>
        public static XVisualInfo* ChooseVisual(Display* dpy, int screen, int* attribList) => GLXPointers._glXChooseVisual_fnptr(dpy, screen, attribList);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXCopyContext</c>]</b><br/>  </summary>
        public static void CopyContext(Display* dpy, GLXContext src, GLXContext dst, ulong mask) => GLXPointers._glXCopyContext_fnptr(dpy, (IntPtr)src, (IntPtr)dst, mask);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXCreateContext</c>]</b><br/>  </summary>
        public static GLXContext CreateContext(Display* dpy, XVisualInfo* vis, GLXContext shareList, bool direct) => (GLXContext) GLXPointers._glXCreateContext_fnptr(dpy, vis, (IntPtr)shareList, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXCreateGLXPixmap</c>]</b><br/>  </summary>
        public static GLXPixmap CreateGLXPixmap(Display* dpy, XVisualInfo* visual, Pixmap pixmap) => (GLXPixmap) GLXPointers._glXCreateGLXPixmap_fnptr(dpy, visual, (nuint)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreateNewContext</c>]</b><br/>  </summary>
        public static GLXContext CreateNewContext(Display* dpy, GLXFBConfig config, int render_type, GLXContext share_list, bool direct) => (GLXContext) GLXPointers._glXCreateNewContext_fnptr(dpy, (IntPtr)config, render_type, (IntPtr)share_list, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreatePbuffer</c>]</b><br/>  </summary>
        public static GLXPbuffer CreatePbuffer(Display* dpy, GLXFBConfig config, int* attrib_list) => (GLXPbuffer) GLXPointers._glXCreatePbuffer_fnptr(dpy, (IntPtr)config, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreatePixmap</c>]</b><br/>  </summary>
        public static GLXPixmap CreatePixmap(Display* dpy, GLXFBConfig config, Pixmap pixmap, int* attrib_list) => (GLXPixmap) GLXPointers._glXCreatePixmap_fnptr(dpy, (IntPtr)config, (nuint)pixmap, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreateWindow</c>]</b><br/>  </summary>
        public static GLXWindow CreateWindow(Display* dpy, GLXFBConfig config, Window win, int* attrib_list) => (GLXWindow) GLXPointers._glXCreateWindow_fnptr(dpy, (IntPtr)config, (nuint)win, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXDestroyContext</c>]</b><br/>  </summary>
        public static void DestroyContext(Display* dpy, GLXContext ctx) => GLXPointers._glXDestroyContext_fnptr(dpy, (IntPtr)ctx);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXDestroyGLXPixmap</c>]</b><br/>  </summary>
        public static void DestroyGLXPixmap(Display* dpy, GLXPixmap pixmap) => GLXPointers._glXDestroyGLXPixmap_fnptr(dpy, (nuint)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXDestroyPbuffer</c>]</b><br/>  </summary>
        public static void DestroyPbuffer(Display* dpy, GLXPbuffer pbuf) => GLXPointers._glXDestroyPbuffer_fnptr(dpy, (nuint)pbuf);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXDestroyPixmap</c>]</b><br/>  </summary>
        public static void DestroyPixmap(Display* dpy, GLXPixmap pixmap) => GLXPointers._glXDestroyPixmap_fnptr(dpy, (nuint)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXDestroyWindow</c>]</b><br/>  </summary>
        public static void DestroyWindow(Display* dpy, GLXWindow win) => GLXPointers._glXDestroyWindow_fnptr(dpy, (nuint)win);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>glXGetClientString</c>]</b><br/>  </summary>
        public static byte* GetClientString(Display* dpy, int name) => GLXPointers._glXGetClientString_fnptr(dpy, name);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXGetConfig</c>]</b><br/>  </summary>
        public static int GetConfig(Display* dpy, XVisualInfo* visual, int attrib, int* value) => GLXPointers._glXGetConfig_fnptr(dpy, visual, attrib, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXGetCurrentContext</c>]</b><br/>  </summary>
        public static GLXContext GetCurrentContext() => (GLXContext) GLXPointers._glXGetCurrentContext_fnptr();
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>glXGetCurrentDisplay</c>]</b><br/>  </summary>
        public static Display* GetCurrentDisplay() => GLXPointers._glXGetCurrentDisplay_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXGetCurrentDrawable</c>]</b><br/>  </summary>
        public static GLXDrawable GetCurrentDrawable() => (GLXDrawable) GLXPointers._glXGetCurrentDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetCurrentReadDrawable</c>]</b><br/>  </summary>
        public static GLXDrawable GetCurrentReadDrawable() => (GLXDrawable) GLXPointers._glXGetCurrentReadDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetFBConfigAttrib</c>]</b><br/>  </summary>
        public static int GetFBConfigAttrib(Display* dpy, GLXFBConfig config, int attribute, int* value) => GLXPointers._glXGetFBConfigAttrib_fnptr(dpy, (IntPtr)config, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetFBConfigs</c>]</b><br/>  </summary>
        public static GLXFBConfig* GetFBConfigs(Display* dpy, int screen, int* nelements) => (GLXFBConfig*) GLXPointers._glXGetFBConfigs_fnptr(dpy, screen, nelements);
        
        /// <summary> <b>[requires: v1.4]</b> <b>[entry point: <c>glXGetProcAddress</c>]</b><br/>  </summary>
        public static IntPtr GetProcAddress(byte* procName) => GLXPointers._glXGetProcAddress_fnptr(procName);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetSelectedEvent</c>]</b><br/>  </summary>
        public static void GetSelectedEvent(Display* dpy, GLXDrawable draw, ulong* event_mask) => GLXPointers._glXGetSelectedEvent_fnptr(dpy, (nuint)draw, event_mask);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetVisualFromFBConfig</c>]</b><br/>  </summary>
        public static XVisualInfo* GetVisualFromFBConfig(Display* dpy, GLXFBConfig config) => GLXPointers._glXGetVisualFromFBConfig_fnptr(dpy, (IntPtr)config);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXIsDirect</c>]</b><br/>  </summary>
        public static bool IsDirect(Display* dpy, GLXContext ctx) => GLXPointers._glXIsDirect_fnptr(dpy, (IntPtr)ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXMakeContextCurrent</c>]</b><br/>  </summary>
        public static bool MakeContextCurrent(Display* dpy, GLXDrawable draw, GLXDrawable read, GLXContext ctx) => GLXPointers._glXMakeContextCurrent_fnptr(dpy, (nuint)draw, (nuint)read, (IntPtr)ctx) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXMakeCurrent</c>]</b><br/>  </summary>
        public static bool MakeCurrent(Display* dpy, GLXDrawable drawable, GLXContext ctx) => GLXPointers._glXMakeCurrent_fnptr(dpy, (nuint)drawable, (IntPtr)ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXQueryContext</c>]</b><br/>  </summary>
        public static int QueryContext(Display* dpy, GLXContext ctx, int attribute, int* value) => GLXPointers._glXQueryContext_fnptr(dpy, (IntPtr)ctx, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXQueryDrawable</c>]</b><br/>  </summary>
        public static void QueryDrawable(Display* dpy, GLXDrawable draw, int attribute, uint* value) => GLXPointers._glXQueryDrawable_fnptr(dpy, (nuint)draw, attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXQueryExtension</c>]</b><br/>  </summary>
        public static bool QueryExtension(Display* dpy, int* errorb, int* @event) => GLXPointers._glXQueryExtension_fnptr(dpy, errorb, @event) != 0;
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>glXQueryExtensionsString</c>]</b><br/>  </summary>
        public static byte* QueryExtensionsString(Display* dpy, int screen) => GLXPointers._glXQueryExtensionsString_fnptr(dpy, screen);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>glXQueryServerString</c>]</b><br/>  </summary>
        public static byte* QueryServerString(Display* dpy, int screen, int name) => GLXPointers._glXQueryServerString_fnptr(dpy, screen, name);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXQueryVersion</c>]</b><br/>  </summary>
        public static bool QueryVersion(Display* dpy, int* maj, int* min) => GLXPointers._glXQueryVersion_fnptr(dpy, maj, min) != 0;
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXSelectEvent</c>]</b><br/>  </summary>
        public static void SelectEvent(Display* dpy, GLXDrawable draw, ulong event_mask) => GLXPointers._glXSelectEvent_fnptr(dpy, (nuint)draw, event_mask);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXSwapBuffers</c>]</b><br/>  </summary>
        public static void SwapBuffers(Display* dpy, GLXDrawable drawable) => GLXPointers._glXSwapBuffers_fnptr(dpy, (nuint)drawable);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXUseXFont</c>]</b><br/>  </summary>
        public static void UseXFont(Font font, int first, int count, int list) => GLXPointers._glXUseXFont_fnptr((nuint)font, first, count, list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXWaitGL</c>]</b><br/>  </summary>
        public static void WaitGL() => GLXPointers._glXWaitGL_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXWaitX</c>]</b><br/>  </summary>
        public static void WaitX() => GLXPointers._glXWaitX_fnptr();
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXBlitContextFramebufferAMD</c>]</b><br/>  </summary>
            public static void BlitContextFramebufferAMD(GLXContext dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, All filter) => GLXPointers._glXBlitContextFramebufferAMD_fnptr((IntPtr)dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, (uint)filter);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXCreateAssociatedContextAMD</c>]</b><br/>  </summary>
            public static GLXContext CreateAssociatedContextAMD(uint id, GLXContext share_list) => (GLXContext) GLXPointers._glXCreateAssociatedContextAMD_fnptr(id, (IntPtr)share_list);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXCreateAssociatedContextAttribsAMD</c>]</b><br/>  </summary>
            public static GLXContext CreateAssociatedContextAttribsAMD(uint id, GLXContext share_context, int* attribList) => (GLXContext) GLXPointers._glXCreateAssociatedContextAttribsAMD_fnptr(id, (IntPtr)share_context, attribList);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXDeleteAssociatedContextAMD</c>]</b><br/>  </summary>
            public static bool DeleteAssociatedContextAMD(GLXContext ctx) => GLXPointers._glXDeleteAssociatedContextAMD_fnptr((IntPtr)ctx) != 0;
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetContextGPUIDAMD</c>]</b><br/>  </summary>
            public static uint GetContextGPUIDAMD(GLXContext ctx) => GLXPointers._glXGetContextGPUIDAMD_fnptr((IntPtr)ctx);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetCurrentAssociatedContextAMD</c>]</b><br/>  </summary>
            public static GLXContext GetCurrentAssociatedContextAMD() => (GLXContext) GLXPointers._glXGetCurrentAssociatedContextAMD_fnptr();
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetGPUIDsAMD</c>]</b><br/>  </summary>
            public static uint GetGPUIDsAMD(uint maxCount, uint* ids) => GLXPointers._glXGetGPUIDsAMD_fnptr(maxCount, ids);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetGPUInfoAMD</c>]</b><br/>  </summary>
            public static int GetGPUInfoAMD(uint id, int property, All dataType, uint size, void* data) => GLXPointers._glXGetGPUInfoAMD_fnptr(id, property, (uint)dataType, size, data);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXMakeAssociatedContextCurrentAMD</c>]</b><br/>  </summary>
            public static bool MakeAssociatedContextCurrentAMD(GLXContext ctx) => GLXPointers._glXMakeAssociatedContextCurrentAMD_fnptr((IntPtr)ctx) != 0;
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            /// <summary> <b>[requires: GLX_ARB_create_context]</b> <b>[entry point: <c>glXCreateContextAttribsARB</c>]</b><br/>  </summary>
            public static GLXContext CreateContextAttribsARB(Display* dpy, GLXFBConfig config, GLXContext share_context, bool direct, int* attrib_list) => (GLXContext) GLXPointers._glXCreateContextAttribsARB_fnptr(dpy, (IntPtr)config, (IntPtr)share_context, (byte)(direct ? 1 : 0), attrib_list);
            
            /// <summary> <b>[requires: GLX_ARB_get_proc_address]</b> <b>[entry point: <c>glXGetProcAddressARB</c>]</b><br/>  </summary>
            public static IntPtr GetProcAddressARB(byte* procName) => GLXPointers._glXGetProcAddressARB_fnptr(procName);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b> <b>[entry point: <c>glXBindTexImageEXT</c>]</b><br/>  </summary>
            public static void BindTexImageEXT(Display* dpy, GLXDrawable drawable, int buffer, int* attrib_list) => GLXPointers._glXBindTexImageEXT_fnptr(dpy, (nuint)drawable, buffer, attrib_list);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXFreeContextEXT</c>]</b><br/>  </summary>
            public static void FreeContextEXT(Display* dpy, GLXContext context) => GLXPointers._glXFreeContextEXT_fnptr(dpy, (IntPtr)context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXGetContextIDEXT</c>]</b><br/>  </summary>
            public static GLXContextID GetContextIDEXT(GLXContext context) => (GLXContextID) GLXPointers._glXGetContextIDEXT_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXGetCurrentDisplayEXT</c>]</b><br/>  </summary>
            public static Display* GetCurrentDisplayEXT() => GLXPointers._glXGetCurrentDisplayEXT_fnptr();
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXImportContextEXT</c>]</b><br/>  </summary>
            public static GLXContext ImportContextEXT(Display* dpy, GLXContextID contextID) => (GLXContext) GLXPointers._glXImportContextEXT_fnptr(dpy, (nuint)contextID);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXQueryContextInfoEXT</c>]</b><br/>  </summary>
            public static int QueryContextInfoEXT(Display* dpy, GLXContext context, int attribute, int* value) => GLXPointers._glXQueryContextInfoEXT_fnptr(dpy, (IntPtr)context, attribute, value);
            
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b> <b>[entry point: <c>glXReleaseTexImageEXT</c>]</b><br/>  </summary>
            public static void ReleaseTexImageEXT(Display* dpy, GLXDrawable drawable, int buffer) => GLXPointers._glXReleaseTexImageEXT_fnptr(dpy, (nuint)drawable, buffer);
            
            /// <summary> <b>[requires: GLX_EXT_swap_control]</b> <b>[entry point: <c>glXSwapIntervalEXT</c>]</b><br/>  </summary>
            public static void SwapIntervalEXT(Display* dpy, GLXDrawable drawable, int interval) => GLXPointers._glXSwapIntervalEXT_fnptr(dpy, (nuint)drawable, interval);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GLX_MESA_copy_sub_buffer]</b> <b>[entry point: <c>glXCopySubBufferMESA</c>]</b><br/>  </summary>
            public static void CopySubBufferMESA(Display* dpy, GLXDrawable drawable, int x, int y, int width, int height) => GLXPointers._glXCopySubBufferMESA_fnptr(dpy, (nuint)drawable, x, y, width, height);
            
            /// <summary> <b>[requires: GLX_MESA_pixmap_colormap]</b> <b>[entry point: <c>glXCreateGLXPixmapMESA</c>]</b><br/>  </summary>
            public static GLXPixmap CreateGLXPixmapMESA(Display* dpy, XVisualInfo* visual, Pixmap pixmap, Colormap cmap) => (GLXPixmap) GLXPointers._glXCreateGLXPixmapMESA_fnptr(dpy, visual, (nuint)pixmap, (nuint)cmap);
            
            /// <summary> <b>[requires: GLX_MESA_agp_offset]</b> <b>[entry point: <c>glXGetAGPOffsetMESA</c>]</b><br/>  </summary>
            public static uint GetAGPOffsetMESA(void* pointer) => GLXPointers._glXGetAGPOffsetMESA_fnptr(pointer);
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b> <b>[entry point: <c>glXGetSwapIntervalMESA</c>]</b><br/>  </summary>
            public static int GetSwapIntervalMESA() => GLXPointers._glXGetSwapIntervalMESA_fnptr();
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryCurrentRendererIntegerMESA</c>]</b><br/>  </summary>
            public static bool QueryCurrentRendererIntegerMESA(int attribute, uint* value) => GLXPointers._glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryCurrentRendererStringMESA</c>]</b><br/>  </summary>
            public static byte* QueryCurrentRendererStringMESA_(int attribute) => GLXPointers._glXQueryCurrentRendererStringMESA_fnptr(attribute);
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryRendererIntegerMESA</c>]</b><br/>  </summary>
            public static bool QueryRendererIntegerMESA(Display* dpy, int screen, int renderer, int attribute, uint* value) => GLXPointers._glXQueryRendererIntegerMESA_fnptr(dpy, screen, renderer, attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryRendererStringMESA</c>]</b><br/>  </summary>
            public static byte* QueryRendererStringMESA(Display* dpy, int screen, int renderer, int attribute) => GLXPointers._glXQueryRendererStringMESA_fnptr(dpy, screen, renderer, attribute);
            
            /// <summary> <b>[requires: GLX_MESA_release_buffers]</b> <b>[entry point: <c>glXReleaseBuffersMESA</c>]</b><br/>  </summary>
            public static bool ReleaseBuffersMESA(Display* dpy, GLXDrawable drawable) => GLXPointers._glXReleaseBuffersMESA_fnptr(dpy, (nuint)drawable) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_set_3dfx_mode]</b> <b>[entry point: <c>glXSet3DfxModeMESA</c>]</b><br/>  </summary>
            public static bool Set3DfxModeMESA(int mode) => GLXPointers._glXSet3DfxModeMESA_fnptr(mode) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b> <b>[entry point: <c>glXSwapIntervalMESA</c>]</b><br/>  </summary>
            public static int SwapIntervalMESA(uint interval) => GLXPointers._glXSwapIntervalMESA_fnptr(interval);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXBindSwapBarrierNV</c>]</b><br/>  </summary>
            public static bool BindSwapBarrierNV(Display* dpy, uint group, uint barrier) => GLXPointers._glXBindSwapBarrierNV_fnptr(dpy, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXBindVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int BindVideoCaptureDeviceNV(Display* dpy, uint video_capture_slot, GLXVideoCaptureDeviceNV device) => GLXPointers._glXBindVideoCaptureDeviceNV_fnptr(dpy, video_capture_slot, (nuint)device);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b> <b>[entry point: <c>glXBindVideoDeviceNV</c>]</b><br/>  </summary>
            public static int BindVideoDeviceNV(Display* dpy, uint video_slot, uint video_device, int* attrib_list) => GLXPointers._glXBindVideoDeviceNV_fnptr(dpy, video_slot, video_device, attrib_list);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXBindVideoImageNV</c>]</b><br/>  </summary>
            public static int BindVideoImageNV(Display* dpy, GLXVideoDeviceNV VideoDevice, GLXPbuffer pbuf, int iVideoBuffer) => GLXPointers._glXBindVideoImageNV_fnptr(dpy, (uint)VideoDevice, (nuint)pbuf, iVideoBuffer);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b> <b>[entry point: <c>glXCopyBufferSubDataNV</c>]</b><br/>  </summary>
            public static void CopyBufferSubDataNV(Display* dpy, GLXContext readCtx, GLXContext writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GLXPointers._glXCopyBufferSubDataNV_fnptr(dpy, (IntPtr)readCtx, (IntPtr)writeCtx, (uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_copy_image]</b> <b>[entry point: <c>glXCopyImageSubDataNV</c>]</b><br/>  </summary>
            public static void CopyImageSubDataNV(Display* dpy, GLXContext srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, GLXContext dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => GLXPointers._glXCopyImageSubDataNV_fnptr(dpy, (IntPtr)srcCtx, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, (IntPtr)dstCtx, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            /// <summary> <b>[requires: GLX_NV_delay_before_swap]</b> <b>[entry point: <c>glXDelayBeforeSwapNV</c>]</b><br/>  </summary>
            public static bool DelayBeforeSwapNV(Display* dpy, GLXDrawable drawable, float seconds) => GLXPointers._glXDelayBeforeSwapNV_fnptr(dpy, (nuint)drawable, seconds) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXEnumerateVideoCaptureDevicesNV</c>]</b><br/>  </summary>
            public static GLXVideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(Display* dpy, int screen, int* nelements) => (GLXVideoCaptureDeviceNV*) GLXPointers._glXEnumerateVideoCaptureDevicesNV_fnptr(dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b> <b>[entry point: <c>glXEnumerateVideoDevicesNV</c>]</b><br/>  </summary>
            public static uint* EnumerateVideoDevicesNV(Display* dpy, int screen, int* nelements) => GLXPointers._glXEnumerateVideoDevicesNV_fnptr(dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXGetVideoDeviceNV</c>]</b><br/>  </summary>
            public static int GetVideoDeviceNV(Display* dpy, int screen, int numVideoDevices, GLXVideoDeviceNV* pVideoDevice) => GLXPointers._glXGetVideoDeviceNV_fnptr(dpy, screen, numVideoDevices, (uint*)pVideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXGetVideoInfoNV</c>]</b><br/>  </summary>
            public static int GetVideoInfoNV(Display* dpy, int screen, GLXVideoDeviceNV VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo) => GLXPointers._glXGetVideoInfoNV_fnptr(dpy, screen, (uint)VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXJoinSwapGroupNV</c>]</b><br/>  </summary>
            public static bool JoinSwapGroupNV(Display* dpy, GLXDrawable drawable, uint group) => GLXPointers._glXJoinSwapGroupNV_fnptr(dpy, (nuint)drawable, group) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXLockVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static void LockVideoCaptureDeviceNV(Display* dpy, GLXVideoCaptureDeviceNV device) => GLXPointers._glXLockVideoCaptureDeviceNV_fnptr(dpy, (nuint)device);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b> <b>[entry point: <c>glXNamedCopyBufferSubDataNV</c>]</b><br/>  </summary>
            public static void NamedCopyBufferSubDataNV(Display* dpy, GLXContext readCtx, GLXContext writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GLXPointers._glXNamedCopyBufferSubDataNV_fnptr(dpy, (IntPtr)readCtx, (IntPtr)writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXQueryFrameCountNV</c>]</b><br/>  </summary>
            public static bool QueryFrameCountNV(Display* dpy, int screen, uint* count) => GLXPointers._glXQueryFrameCountNV_fnptr(dpy, screen, count) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXQueryMaxSwapGroupsNV</c>]</b><br/>  </summary>
            public static bool QueryMaxSwapGroupsNV(Display* dpy, int screen, uint* maxGroups, uint* maxBarriers) => GLXPointers._glXQueryMaxSwapGroupsNV_fnptr(dpy, screen, maxGroups, maxBarriers) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXQuerySwapGroupNV</c>]</b><br/>  </summary>
            public static bool QuerySwapGroupNV(Display* dpy, GLXDrawable drawable, uint* group, uint* barrier) => GLXPointers._glXQuerySwapGroupNV_fnptr(dpy, (nuint)drawable, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXQueryVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int QueryVideoCaptureDeviceNV(Display* dpy, GLXVideoCaptureDeviceNV device, int attribute, int* value) => GLXPointers._glXQueryVideoCaptureDeviceNV_fnptr(dpy, (nuint)device, attribute, value);
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXReleaseVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static void ReleaseVideoCaptureDeviceNV(Display* dpy, GLXVideoCaptureDeviceNV device) => GLXPointers._glXReleaseVideoCaptureDeviceNV_fnptr(dpy, (nuint)device);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXReleaseVideoDeviceNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoDeviceNV(Display* dpy, int screen, GLXVideoDeviceNV VideoDevice) => GLXPointers._glXReleaseVideoDeviceNV_fnptr(dpy, screen, (uint)VideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXReleaseVideoImageNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoImageNV(Display* dpy, GLXPbuffer pbuf) => GLXPointers._glXReleaseVideoImageNV_fnptr(dpy, (nuint)pbuf);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXResetFrameCountNV</c>]</b><br/>  </summary>
            public static bool ResetFrameCountNV(Display* dpy, int screen) => GLXPointers._glXResetFrameCountNV_fnptr(dpy, screen) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXSendPbufferToVideoNV</c>]</b><br/>  </summary>
            public static int SendPbufferToVideoNV(Display* dpy, GLXPbuffer pbuf, int iBufferType, ulong* pulCounterPbuffer, bool bBlock) => GLXPointers._glXSendPbufferToVideoNV_fnptr(dpy, (nuint)pbuf, iBufferType, pulCounterPbuffer, (byte)(bBlock ? 1 : 0));
            
        }
        /// <summary>OML extensions.</summary>
        public static unsafe partial class OML
        {
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXGetMscRateOML</c>]</b><br/>  </summary>
            public static bool GetMscRateOML(Display* dpy, GLXDrawable drawable, int* numerator, int* denominator) => GLXPointers._glXGetMscRateOML_fnptr(dpy, (nuint)drawable, numerator, denominator) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXGetSyncValuesOML</c>]</b><br/>  </summary>
            public static bool GetSyncValuesOML(Display* dpy, GLXDrawable drawable, long* ust, long* msc, long* sbc) => GLXPointers._glXGetSyncValuesOML_fnptr(dpy, (nuint)drawable, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXSwapBuffersMscOML</c>]</b><br/>  </summary>
            public static long SwapBuffersMscOML(Display* dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder) => GLXPointers._glXSwapBuffersMscOML_fnptr(dpy, (nuint)drawable, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXWaitForMscOML</c>]</b><br/>  </summary>
            public static bool WaitForMscOML(Display* dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc) => GLXPointers._glXWaitForMscOML_fnptr(dpy, (nuint)drawable, target_msc, divisor, remainder, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXWaitForSbcOML</c>]</b><br/>  </summary>
            public static bool WaitForSbcOML(Display* dpy, GLXDrawable drawable, long target_sbc, long* ust, long* msc, long* sbc) => GLXPointers._glXWaitForSbcOML_fnptr(dpy, (nuint)drawable, target_sbc, ust, msc, sbc) != 0;
            
        }
        /// <summary>SGI extensions.</summary>
        public static unsafe partial class SGI
        {
            /// <summary> <b>[requires: GLX_SGI_cushion]</b> <b>[entry point: <c>glXCushionSGI</c>]</b><br/>  </summary>
            public static void CushionSGI(Display* dpy, Window window, float cushion) => GLXPointers._glXCushionSGI_fnptr(dpy, (nuint)window, cushion);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b> <b>[entry point: <c>glXGetCurrentReadDrawableSGI</c>]</b><br/>  </summary>
            public static GLXDrawable GetCurrentReadDrawableSGI() => (GLXDrawable) GLXPointers._glXGetCurrentReadDrawableSGI_fnptr();
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b> <b>[entry point: <c>glXGetVideoSyncSGI</c>]</b><br/>  </summary>
            public static int GetVideoSyncSGI(uint* count) => GLXPointers._glXGetVideoSyncSGI_fnptr(count);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b> <b>[entry point: <c>glXMakeCurrentReadSGI</c>]</b><br/>  </summary>
            public static bool MakeCurrentReadSGI(Display* dpy, GLXDrawable draw, GLXDrawable read, GLXContext ctx) => GLXPointers._glXMakeCurrentReadSGI_fnptr(dpy, (nuint)draw, (nuint)read, (IntPtr)ctx) != 0;
            
            /// <summary> <b>[requires: GLX_SGI_swap_control]</b> <b>[entry point: <c>glXSwapIntervalSGI</c>]</b><br/>  </summary>
            public static int SwapIntervalSGI(int interval) => GLXPointers._glXSwapIntervalSGI_fnptr(interval);
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b> <b>[entry point: <c>glXWaitVideoSyncSGI</c>]</b><br/>  </summary>
            public static int WaitVideoSyncSGI(int divisor, int remainder, uint* count) => GLXPointers._glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
            
        }
        /// <summary>SGIX extensions.</summary>
        public static unsafe partial class SGIX
        {
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXBindChannelToWindowSGIX</c>]</b><br/>  </summary>
            public static int BindChannelToWindowSGIX(Display* display, int screen, int channel, Window window) => GLXPointers._glXBindChannelToWindowSGIX_fnptr(display, screen, channel, (nuint)window);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXBindHyperpipeSGIX</c>]</b><br/>  </summary>
            public static int BindHyperpipeSGIX(Display* dpy, int hpId) => GLXPointers._glXBindHyperpipeSGIX_fnptr(dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b> <b>[entry point: <c>glXBindSwapBarrierSGIX</c>]</b><br/>  </summary>
            public static void BindSwapBarrierSGIX(Display* dpy, GLXDrawable drawable, int barrier) => GLXPointers._glXBindSwapBarrierSGIX_fnptr(dpy, (nuint)drawable, barrier);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXChannelRectSGIX</c>]</b><br/>  </summary>
            public static int ChannelRectSGIX(Display* display, int screen, int channel, int x, int y, int w, int h) => GLXPointers._glXChannelRectSGIX_fnptr(display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXChannelRectSyncSGIX</c>]</b><br/>  </summary>
            public static int ChannelRectSyncSGIX(Display* display, int screen, int channel, All synctype) => GLXPointers._glXChannelRectSyncSGIX_fnptr(display, screen, channel, (uint)synctype);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXChooseFBConfigSGIX</c>]</b><br/>  </summary>
            public static GLXFBConfigSGIX* ChooseFBConfigSGIX(Display* dpy, int screen, int* attrib_list, int* nelements) => (GLXFBConfigSGIX*) GLXPointers._glXChooseFBConfigSGIX_fnptr(dpy, screen, attrib_list, nelements);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXCreateContextWithConfigSGIX</c>]</b><br/>  </summary>
            public static GLXContext CreateContextWithConfigSGIX(Display* dpy, GLXFBConfigSGIX config, int render_type, GLXContext share_list, bool direct) => (GLXContext) GLXPointers._glXCreateContextWithConfigSGIX_fnptr(dpy, (IntPtr)config, render_type, (IntPtr)share_list, (byte)(direct ? 1 : 0));
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXCreateGLXPbufferSGIX</c>]</b><br/>  </summary>
            public static GLXPbufferSGIX CreateGLXPbufferSGIX(Display* dpy, GLXFBConfigSGIX config, uint width, uint height, int* attrib_list) => (GLXPbufferSGIX) GLXPointers._glXCreateGLXPbufferSGIX_fnptr(dpy, (IntPtr)config, width, height, attrib_list);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXCreateGLXPixmapWithConfigSGIX</c>]</b><br/>  </summary>
            public static GLXPixmap CreateGLXPixmapWithConfigSGIX(Display* dpy, GLXFBConfigSGIX config, Pixmap pixmap) => (GLXPixmap) GLXPointers._glXCreateGLXPixmapWithConfigSGIX_fnptr(dpy, (IntPtr)config, (nuint)pixmap);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXDestroyGLXPbufferSGIX</c>]</b><br/>  </summary>
            public static void DestroyGLXPbufferSGIX(Display* dpy, GLXPbufferSGIX pbuf) => GLXPointers._glXDestroyGLXPbufferSGIX_fnptr(dpy, (nuint)pbuf);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXDestroyHyperpipeConfigSGIX</c>]</b><br/>  </summary>
            public static int DestroyHyperpipeConfigSGIX(Display* dpy, int hpId) => GLXPointers._glXDestroyHyperpipeConfigSGIX_fnptr(dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXGetFBConfigAttribSGIX</c>]</b><br/>  </summary>
            public static int GetFBConfigAttribSGIX(Display* dpy, GLXFBConfigSGIX config, int attribute, int* value) => GLXPointers._glXGetFBConfigAttribSGIX_fnptr(dpy, (IntPtr)config, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXGetFBConfigFromVisualSGIX</c>]</b><br/>  </summary>
            public static GLXFBConfigSGIX GetFBConfigFromVisualSGIX(Display* dpy, XVisualInfo* vis) => (GLXFBConfigSGIX) GLXPointers._glXGetFBConfigFromVisualSGIX_fnptr(dpy, vis);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXGetSelectedEventSGIX</c>]</b><br/>  </summary>
            public static void GetSelectedEventSGIX(Display* dpy, GLXDrawable drawable, ulong* mask) => GLXPointers._glXGetSelectedEventSGIX_fnptr(dpy, (nuint)drawable, mask);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXGetVisualFromFBConfigSGIX</c>]</b><br/>  </summary>
            public static XVisualInfo* GetVisualFromFBConfigSGIX(Display* dpy, GLXFBConfigSGIX config) => GLXPointers._glXGetVisualFromFBConfigSGIX_fnptr(dpy, (IntPtr)config);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXHyperpipeAttribSGIX</c>]</b><br/>  </summary>
            public static int HyperpipeAttribSGIX(Display* dpy, int timeSlice, int attrib, int size, void* attribList) => GLXPointers._glXHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXHyperpipeConfigSGIX</c>]</b><br/>  </summary>
            public static int HyperpipeConfigSGIX(Display* dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId) => GLXPointers._glXHyperpipeConfigSGIX_fnptr(dpy, networkId, npipes, cfg, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_group]</b> <b>[entry point: <c>glXJoinSwapGroupSGIX</c>]</b><br/>  </summary>
            public static void JoinSwapGroupSGIX(Display* dpy, GLXDrawable drawable, GLXDrawable member) => GLXPointers._glXJoinSwapGroupSGIX_fnptr(dpy, (nuint)drawable, (nuint)member);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXQueryChannelDeltasSGIX</c>]</b><br/>  </summary>
            public static int QueryChannelDeltasSGIX(Display* display, int screen, int channel, int* x, int* y, int* w, int* h) => GLXPointers._glXQueryChannelDeltasSGIX_fnptr(display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXQueryChannelRectSGIX</c>]</b><br/>  </summary>
            public static int QueryChannelRectSGIX(Display* display, int screen, int channel, int* dx, int* dy, int* dw, int* dh) => GLXPointers._glXQueryChannelRectSGIX_fnptr(display, screen, channel, dx, dy, dw, dh);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXQueryGLXPbufferSGIX</c>]</b><br/>  </summary>
            public static void QueryGLXPbufferSGIX(Display* dpy, GLXPbufferSGIX pbuf, int attribute, uint* value) => GLXPointers._glXQueryGLXPbufferSGIX_fnptr(dpy, (nuint)pbuf, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeAttribSGIX</c>]</b><br/>  </summary>
            public static int QueryHyperpipeAttribSGIX(Display* dpy, int timeSlice, int attrib, int size, void* returnAttribList) => GLXPointers._glXQueryHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeBestAttribSGIX</c>]</b><br/>  </summary>
            public static int QueryHyperpipeBestAttribSGIX(Display* dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList) => GLXPointers._glXQueryHyperpipeBestAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeConfigSGIX</c>]</b><br/>  </summary>
            public static GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(Display* dpy, int hpId, int* npipes) => GLXPointers._glXQueryHyperpipeConfigSGIX_fnptr(dpy, hpId, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeNetworkSGIX</c>]</b><br/>  </summary>
            public static GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(Display* dpy, int* npipes) => GLXPointers._glXQueryHyperpipeNetworkSGIX_fnptr(dpy, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b> <b>[entry point: <c>glXQueryMaxSwapBarriersSGIX</c>]</b><br/>  </summary>
            public static bool QueryMaxSwapBarriersSGIX(Display* dpy, int screen, int* max) => GLXPointers._glXQueryMaxSwapBarriersSGIX_fnptr(dpy, screen, max) != 0;
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXSelectEventSGIX</c>]</b><br/>  </summary>
            public static void SelectEventSGIX(Display* dpy, GLXDrawable drawable, ulong mask) => GLXPointers._glXSelectEventSGIX_fnptr(dpy, (nuint)drawable, mask);
            
        }
        /// <summary>SUN extensions.</summary>
        public static unsafe partial class SUN
        {
            /// <summary> <b>[requires: GLX_SUN_get_transparent_index]</b> <b>[entry point: <c>glXGetTransparentIndexSUN</c>]</b><br/>  </summary>
            public static int GetTransparentIndexSUN(Display* dpy, Window overlay, Window underlay, ulong* pTransparentIndex) => GLXPointers._glXGetTransparentIndexSUN_fnptr(dpy, (nuint)overlay, (nuint)underlay, pTransparentIndex);
            
        }
    }
}
