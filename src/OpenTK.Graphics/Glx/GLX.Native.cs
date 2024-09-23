// This file is auto generated, do not edit. Generated: 2024-09-23 23:09:51 GMT+02:00
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Wgl;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class Glx
    {
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXChooseFBConfig</c>]</b><br/>  </summary>
        public static GLXFBConfig* ChooseFBConfig(DisplayPtr dpy, int screen, int* attrib_list, int* nelements) => (GLXFBConfig*) GlxPointers._glXChooseFBConfig_fnptr((IntPtr)dpy, screen, attrib_list, nelements);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXChooseVisual</c>]</b><br/>  </summary>
        public static XVisualInfoPtr ChooseVisual(DisplayPtr dpy, int screen, int* attribList) => (XVisualInfoPtr) GlxPointers._glXChooseVisual_fnptr((IntPtr)dpy, screen, attribList);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXCopyContext</c>]</b><br/>  </summary>
        public static void CopyContext(DisplayPtr dpy, GLXContext src, GLXContext dst, ulong mask) => GlxPointers._glXCopyContext_fnptr((IntPtr)dpy, (IntPtr)src, (IntPtr)dst, mask);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXCreateContext</c>]</b><br/>  </summary>
        public static GLXContext CreateContext(DisplayPtr dpy, XVisualInfoPtr vis, GLXContext shareList, bool direct) => (GLXContext) GlxPointers._glXCreateContext_fnptr((IntPtr)dpy, (IntPtr)vis, (IntPtr)shareList, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXCreateGLXPixmap</c>]</b><br/>  </summary>
        public static GLXPixmap CreateGLXPixmap(DisplayPtr dpy, XVisualInfoPtr visual, Pixmap pixmap) => (GLXPixmap) GlxPointers._glXCreateGLXPixmap_fnptr((IntPtr)dpy, (IntPtr)visual, (nuint)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreateNewContext</c>]</b><br/>  </summary>
        public static GLXContext CreateNewContext(DisplayPtr dpy, GLXFBConfig config, int render_type, GLXContext share_list, bool direct) => (GLXContext) GlxPointers._glXCreateNewContext_fnptr((IntPtr)dpy, (IntPtr)config, render_type, (IntPtr)share_list, (byte)(direct ? 1 : 0));
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreatePbuffer</c>]</b><br/>  </summary>
        public static GLXPbuffer CreatePbuffer(DisplayPtr dpy, GLXFBConfig config, int* attrib_list) => (GLXPbuffer) GlxPointers._glXCreatePbuffer_fnptr((IntPtr)dpy, (IntPtr)config, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreatePixmap</c>]</b><br/>  </summary>
        public static GLXPixmap CreatePixmap(DisplayPtr dpy, GLXFBConfig config, Pixmap pixmap, int* attrib_list) => (GLXPixmap) GlxPointers._glXCreatePixmap_fnptr((IntPtr)dpy, (IntPtr)config, (nuint)pixmap, attrib_list);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXCreateWindow</c>]</b><br/>  </summary>
        public static GLXWindow CreateWindow(DisplayPtr dpy, GLXFBConfig config, Window win, int* attrib_list) => (GLXWindow) GlxPointers._glXCreateWindow_fnptr((IntPtr)dpy, (IntPtr)config, (nuint)win, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXDestroyContext</c>]</b><br/>  </summary>
        public static void DestroyContext(DisplayPtr dpy, GLXContext ctx) => GlxPointers._glXDestroyContext_fnptr((IntPtr)dpy, (IntPtr)ctx);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXDestroyGLXPixmap</c>]</b><br/>  </summary>
        public static void DestroyGLXPixmap(DisplayPtr dpy, GLXPixmap pixmap) => GlxPointers._glXDestroyGLXPixmap_fnptr((IntPtr)dpy, (nuint)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXDestroyPbuffer</c>]</b><br/>  </summary>
        public static void DestroyPbuffer(DisplayPtr dpy, GLXPbuffer pbuf) => GlxPointers._glXDestroyPbuffer_fnptr((IntPtr)dpy, (nuint)pbuf);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXDestroyPixmap</c>]</b><br/>  </summary>
        public static void DestroyPixmap(DisplayPtr dpy, GLXPixmap pixmap) => GlxPointers._glXDestroyPixmap_fnptr((IntPtr)dpy, (nuint)pixmap);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXDestroyWindow</c>]</b><br/>  </summary>
        public static void DestroyWindow(DisplayPtr dpy, GLXWindow win) => GlxPointers._glXDestroyWindow_fnptr((IntPtr)dpy, (nuint)win);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>glXGetClientString</c>]</b><br/>  </summary>
        public static byte* GetClientString_(DisplayPtr dpy, StringName name) => GlxPointers._glXGetClientString_fnptr((IntPtr)dpy, (int)name);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXGetConfig</c>]</b><br/>  </summary>
        public static int GetConfig(DisplayPtr dpy, XVisualInfoPtr visual, int attrib, int* value) => GlxPointers._glXGetConfig_fnptr((IntPtr)dpy, (IntPtr)visual, attrib, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXGetCurrentContext</c>]</b><br/>  </summary>
        public static GLXContext GetCurrentContext() => (GLXContext) GlxPointers._glXGetCurrentContext_fnptr();
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>glXGetCurrentDisplay</c>]</b><br/>  </summary>
        public static DisplayPtr GetCurrentDisplay() => (DisplayPtr) GlxPointers._glXGetCurrentDisplay_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXGetCurrentDrawable</c>]</b><br/>  </summary>
        public static GLXDrawable GetCurrentDrawable() => (GLXDrawable) GlxPointers._glXGetCurrentDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetCurrentReadDrawable</c>]</b><br/>  </summary>
        public static GLXDrawable GetCurrentReadDrawable() => (GLXDrawable) GlxPointers._glXGetCurrentReadDrawable_fnptr();
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetFBConfigAttrib</c>]</b><br/>  </summary>
        public static int GetFBConfigAttrib(DisplayPtr dpy, GLXFBConfig config, int attribute, int* value) => GlxPointers._glXGetFBConfigAttrib_fnptr((IntPtr)dpy, (IntPtr)config, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetFBConfigs</c>]</b><br/>  </summary>
        public static GLXFBConfig* GetFBConfigs(DisplayPtr dpy, int screen, int* nelements) => (GLXFBConfig*) GlxPointers._glXGetFBConfigs_fnptr((IntPtr)dpy, screen, nelements);
        
        /// <summary> <b>[requires: v1.4]</b> <b>[entry point: <c>glXGetProcAddress</c>]</b><br/>  </summary>
        public static IntPtr GetProcAddress(byte* procName) => GlxPointers._glXGetProcAddress_fnptr(procName);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetSelectedEvent</c>]</b><br/>  </summary>
        public static void GetSelectedEvent(DisplayPtr dpy, GLXDrawable draw, ulong* event_mask) => GlxPointers._glXGetSelectedEvent_fnptr((IntPtr)dpy, (nuint)draw, event_mask);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXGetVisualFromFBConfig</c>]</b><br/>  </summary>
        public static XVisualInfoPtr GetVisualFromFBConfig(DisplayPtr dpy, GLXFBConfig config) => (XVisualInfoPtr) GlxPointers._glXGetVisualFromFBConfig_fnptr((IntPtr)dpy, (IntPtr)config);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXIsDirect</c>]</b><br/>  </summary>
        public static bool IsDirect(DisplayPtr dpy, GLXContext ctx) => GlxPointers._glXIsDirect_fnptr((IntPtr)dpy, (IntPtr)ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXMakeContextCurrent</c>]</b><br/>  </summary>
        public static bool MakeContextCurrent(DisplayPtr dpy, GLXDrawable draw, GLXDrawable read, GLXContext ctx) => GlxPointers._glXMakeContextCurrent_fnptr((IntPtr)dpy, (nuint)draw, (nuint)read, (IntPtr)ctx) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXMakeCurrent</c>]</b><br/>  </summary>
        public static bool MakeCurrent(DisplayPtr dpy, GLXDrawable drawable, GLXContext ctx) => GlxPointers._glXMakeCurrent_fnptr((IntPtr)dpy, (nuint)drawable, (IntPtr)ctx) != 0;
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXQueryContext</c>]</b><br/>  </summary>
        public static int QueryContext(DisplayPtr dpy, GLXContext ctx, int attribute, int* value) => GlxPointers._glXQueryContext_fnptr((IntPtr)dpy, (IntPtr)ctx, attribute, value);
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXQueryDrawable</c>]</b><br/>  </summary>
        public static void QueryDrawable(DisplayPtr dpy, GLXDrawable draw, DrawableAttrib attribute, uint* value) => GlxPointers._glXQueryDrawable_fnptr((IntPtr)dpy, (nuint)draw, (int)attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXQueryExtension</c>]</b><br/>  </summary>
        public static bool QueryExtension(DisplayPtr dpy, int* errorb, int* @event) => GlxPointers._glXQueryExtension_fnptr((IntPtr)dpy, errorb, @event) != 0;
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>glXQueryExtensionsString</c>]</b><br/>  </summary>
        public static byte* QueryExtensionsString_(DisplayPtr dpy, int screen) => GlxPointers._glXQueryExtensionsString_fnptr((IntPtr)dpy, screen);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>glXQueryServerString</c>]</b><br/>  </summary>
        public static byte* QueryServerString_(DisplayPtr dpy, int screen, StringName name) => GlxPointers._glXQueryServerString_fnptr((IntPtr)dpy, screen, (int)name);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXQueryVersion</c>]</b><br/>  </summary>
        public static bool QueryVersion(DisplayPtr dpy, int* maj, int* min) => GlxPointers._glXQueryVersion_fnptr((IntPtr)dpy, maj, min) != 0;
        
        /// <summary> <b>[requires: v1.3]</b> <b>[entry point: <c>glXSelectEvent</c>]</b><br/>  </summary>
        public static void SelectEvent(DisplayPtr dpy, GLXDrawable draw, ulong event_mask) => GlxPointers._glXSelectEvent_fnptr((IntPtr)dpy, (nuint)draw, event_mask);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXSwapBuffers</c>]</b><br/>  </summary>
        public static void SwapBuffers(DisplayPtr dpy, GLXDrawable drawable) => GlxPointers._glXSwapBuffers_fnptr((IntPtr)dpy, (nuint)drawable);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXUseXFont</c>]</b><br/>  </summary>
        public static void UseXFont(Font font, int first, int count, int list) => GlxPointers._glXUseXFont_fnptr((nuint)font, first, count, list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXWaitGL</c>]</b><br/>  </summary>
        public static void WaitGL() => GlxPointers._glXWaitGL_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>glXWaitX</c>]</b><br/>  </summary>
        public static void WaitX() => GlxPointers._glXWaitX_fnptr();
        
        /// <summary>AMD extensions.</summary>
        public static unsafe partial class AMD
        {
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXBlitContextFramebufferAMD</c>]</b><br/>  </summary>
            public static void BlitContextFramebufferAMD(GLXContext dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, All filter) => GlxPointers._glXBlitContextFramebufferAMD_fnptr((IntPtr)dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, (uint)filter);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXCreateAssociatedContextAMD</c>]</b><br/>  </summary>
            public static GLXContext CreateAssociatedContextAMD(uint id, GLXContext share_list) => (GLXContext) GlxPointers._glXCreateAssociatedContextAMD_fnptr(id, (IntPtr)share_list);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXCreateAssociatedContextAttribsAMD</c>]</b><br/>  </summary>
            public static GLXContext CreateAssociatedContextAttribsAMD(uint id, GLXContext share_context, int* attribList) => (GLXContext) GlxPointers._glXCreateAssociatedContextAttribsAMD_fnptr(id, (IntPtr)share_context, attribList);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXDeleteAssociatedContextAMD</c>]</b><br/>  </summary>
            public static bool DeleteAssociatedContextAMD(GLXContext ctx) => GlxPointers._glXDeleteAssociatedContextAMD_fnptr((IntPtr)ctx) != 0;
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetContextGPUIDAMD</c>]</b><br/>  </summary>
            public static uint GetContextGPUIDAMD(GLXContext ctx) => GlxPointers._glXGetContextGPUIDAMD_fnptr((IntPtr)ctx);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetCurrentAssociatedContextAMD</c>]</b><br/>  </summary>
            public static GLXContext GetCurrentAssociatedContextAMD() => (GLXContext) GlxPointers._glXGetCurrentAssociatedContextAMD_fnptr();
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetGPUIDsAMD</c>]</b><br/>  </summary>
            public static uint GetGPUIDsAMD(uint maxCount, uint* ids) => GlxPointers._glXGetGPUIDsAMD_fnptr(maxCount, ids);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXGetGPUInfoAMD</c>]</b><br/>  </summary>
            public static int GetGPUInfoAMD(uint id, int property, All dataType, uint size, void* data) => GlxPointers._glXGetGPUInfoAMD_fnptr(id, property, (uint)dataType, size, data);
            
            /// <summary> <b>[requires: GLX_AMD_gpu_association]</b> <b>[entry point: <c>glXMakeAssociatedContextCurrentAMD</c>]</b><br/>  </summary>
            public static bool MakeAssociatedContextCurrentAMD(GLXContext ctx) => GlxPointers._glXMakeAssociatedContextCurrentAMD_fnptr((IntPtr)ctx) != 0;
            
        }
        /// <summary>ARB extensions.</summary>
        public static unsafe partial class ARB
        {
            /// <summary> <b>[requires: GLX_ARB_create_context]</b> <b>[entry point: <c>glXCreateContextAttribsARB</c>]</b><br/>  </summary>
            public static GLXContext CreateContextAttribsARB(DisplayPtr dpy, GLXFBConfig config, GLXContext share_context, bool direct, int* attrib_list) => (GLXContext) GlxPointers._glXCreateContextAttribsARB_fnptr((IntPtr)dpy, (IntPtr)config, (IntPtr)share_context, (byte)(direct ? 1 : 0), attrib_list);
            
            /// <summary> <b>[requires: GLX_ARB_get_proc_address]</b> <b>[entry point: <c>glXGetProcAddressARB</c>]</b><br/>  </summary>
            public static IntPtr GetProcAddressARB(byte* procName) => GlxPointers._glXGetProcAddressARB_fnptr(procName);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b> <b>[entry point: <c>glXBindTexImageEXT</c>]</b><br/>  </summary>
            public static void BindTexImageEXT(DisplayPtr dpy, GLXDrawable drawable, int buffer, int* attrib_list) => GlxPointers._glXBindTexImageEXT_fnptr((IntPtr)dpy, (nuint)drawable, buffer, attrib_list);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXFreeContextEXT</c>]</b><br/>  </summary>
            public static void FreeContextEXT(DisplayPtr dpy, GLXContext context) => GlxPointers._glXFreeContextEXT_fnptr((IntPtr)dpy, (IntPtr)context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXGetContextIDEXT</c>]</b><br/>  </summary>
            public static GLXContextID GetContextIDEXT(GLXContext context) => (GLXContextID) GlxPointers._glXGetContextIDEXT_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXGetCurrentDisplayEXT</c>]</b><br/>  </summary>
            public static DisplayPtr GetCurrentDisplayEXT() => (DisplayPtr) GlxPointers._glXGetCurrentDisplayEXT_fnptr();
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXImportContextEXT</c>]</b><br/>  </summary>
            public static GLXContext ImportContextEXT(DisplayPtr dpy, GLXContextID contextID) => (GLXContext) GlxPointers._glXImportContextEXT_fnptr((IntPtr)dpy, (nuint)contextID);
            
            /// <summary> <b>[requires: GLX_EXT_import_context]</b> <b>[entry point: <c>glXQueryContextInfoEXT</c>]</b><br/>  </summary>
            public static int QueryContextInfoEXT(DisplayPtr dpy, GLXContext context, int attribute, int* value) => GlxPointers._glXQueryContextInfoEXT_fnptr((IntPtr)dpy, (IntPtr)context, attribute, value);
            
            /// <summary> <b>[requires: GLX_EXT_texture_from_pixmap]</b> <b>[entry point: <c>glXReleaseTexImageEXT</c>]</b><br/>  </summary>
            public static void ReleaseTexImageEXT(DisplayPtr dpy, GLXDrawable drawable, int buffer) => GlxPointers._glXReleaseTexImageEXT_fnptr((IntPtr)dpy, (nuint)drawable, buffer);
            
            /// <summary> <b>[requires: GLX_EXT_swap_control]</b> <b>[entry point: <c>glXSwapIntervalEXT</c>]</b><br/>  </summary>
            public static void SwapIntervalEXT(DisplayPtr dpy, GLXDrawable drawable, int interval) => GlxPointers._glXSwapIntervalEXT_fnptr((IntPtr)dpy, (nuint)drawable, interval);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: GLX_MESA_copy_sub_buffer]</b> <b>[entry point: <c>glXCopySubBufferMESA</c>]</b><br/>  </summary>
            public static void CopySubBufferMESA(DisplayPtr dpy, GLXDrawable drawable, int x, int y, int width, int height) => GlxPointers._glXCopySubBufferMESA_fnptr((IntPtr)dpy, (nuint)drawable, x, y, width, height);
            
            /// <summary> <b>[requires: GLX_MESA_pixmap_colormap]</b> <b>[entry point: <c>glXCreateGLXPixmapMESA</c>]</b><br/>  </summary>
            public static GLXPixmap CreateGLXPixmapMESA(DisplayPtr dpy, XVisualInfoPtr visual, Pixmap pixmap, Colormap cmap) => (GLXPixmap) GlxPointers._glXCreateGLXPixmapMESA_fnptr((IntPtr)dpy, (IntPtr)visual, (nuint)pixmap, (nuint)cmap);
            
            /// <summary> <b>[requires: GLX_MESA_agp_offset]</b> <b>[entry point: <c>glXGetAGPOffsetMESA</c>]</b><br/>  </summary>
            public static uint GetAGPOffsetMESA(void* pointer) => GlxPointers._glXGetAGPOffsetMESA_fnptr(pointer);
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b> <b>[entry point: <c>glXGetSwapIntervalMESA</c>]</b><br/>  </summary>
            public static int GetSwapIntervalMESA() => GlxPointers._glXGetSwapIntervalMESA_fnptr();
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryCurrentRendererIntegerMESA</c>]</b><br/>  </summary>
            public static bool QueryCurrentRendererIntegerMESA(int attribute, uint* value) => GlxPointers._glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryCurrentRendererStringMESA</c>]</b><br/>  </summary>
            public static byte* QueryCurrentRendererStringMESA_(int attribute) => GlxPointers._glXQueryCurrentRendererStringMESA_fnptr(attribute);
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryRendererIntegerMESA</c>]</b><br/>  </summary>
            public static bool QueryRendererIntegerMESA(DisplayPtr dpy, int screen, int renderer, int attribute, uint* value) => GlxPointers._glXQueryRendererIntegerMESA_fnptr((IntPtr)dpy, screen, renderer, attribute, value) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_query_renderer]</b> <b>[entry point: <c>glXQueryRendererStringMESA</c>]</b><br/>  </summary>
            public static byte* QueryRendererStringMESA_(DisplayPtr dpy, int screen, int renderer, int attribute) => GlxPointers._glXQueryRendererStringMESA_fnptr((IntPtr)dpy, screen, renderer, attribute);
            
            /// <summary> <b>[requires: GLX_MESA_release_buffers]</b> <b>[entry point: <c>glXReleaseBuffersMESA</c>]</b><br/>  </summary>
            public static bool ReleaseBuffersMESA(DisplayPtr dpy, GLXDrawable drawable) => GlxPointers._glXReleaseBuffersMESA_fnptr((IntPtr)dpy, (nuint)drawable) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_set_3dfx_mode]</b> <b>[entry point: <c>glXSet3DfxModeMESA</c>]</b><br/>  </summary>
            public static bool Set3DfxModeMESA(int mode) => GlxPointers._glXSet3DfxModeMESA_fnptr(mode) != 0;
            
            /// <summary> <b>[requires: GLX_MESA_swap_control]</b> <b>[entry point: <c>glXSwapIntervalMESA</c>]</b><br/>  </summary>
            public static int SwapIntervalMESA(uint interval) => GlxPointers._glXSwapIntervalMESA_fnptr(interval);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXBindSwapBarrierNV</c>]</b><br/>  </summary>
            public static bool BindSwapBarrierNV(DisplayPtr dpy, uint group, uint barrier) => GlxPointers._glXBindSwapBarrierNV_fnptr((IntPtr)dpy, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXBindVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int BindVideoCaptureDeviceNV(DisplayPtr dpy, uint video_capture_slot, GLXVideoCaptureDeviceNV device) => GlxPointers._glXBindVideoCaptureDeviceNV_fnptr((IntPtr)dpy, video_capture_slot, (nuint)device);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b> <b>[entry point: <c>glXBindVideoDeviceNV</c>]</b><br/>  </summary>
            public static int BindVideoDeviceNV(DisplayPtr dpy, uint video_slot, uint video_device, int* attrib_list) => GlxPointers._glXBindVideoDeviceNV_fnptr((IntPtr)dpy, video_slot, video_device, attrib_list);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXBindVideoImageNV</c>]</b><br/>  </summary>
            public static int BindVideoImageNV(DisplayPtr dpy, GLXVideoDeviceNV VideoDevice, GLXPbuffer pbuf, int iVideoBuffer) => GlxPointers._glXBindVideoImageNV_fnptr((IntPtr)dpy, (uint)VideoDevice, (nuint)pbuf, iVideoBuffer);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b> <b>[entry point: <c>glXCopyBufferSubDataNV</c>]</b><br/>  </summary>
            public static void CopyBufferSubDataNV(DisplayPtr dpy, GLXContext readCtx, GLXContext writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size) => GlxPointers._glXCopyBufferSubDataNV_fnptr((IntPtr)dpy, (IntPtr)readCtx, (IntPtr)writeCtx, (uint)readTarget, (uint)writeTarget, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_copy_image]</b> <b>[entry point: <c>glXCopyImageSubDataNV</c>]</b><br/>  </summary>
            public static void CopyImageSubDataNV(DisplayPtr dpy, GLXContext srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, GLXContext dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) => GlxPointers._glXCopyImageSubDataNV_fnptr((IntPtr)dpy, (IntPtr)srcCtx, srcName, (uint)srcTarget, srcLevel, srcX, srcY, srcZ, (IntPtr)dstCtx, dstName, (uint)dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            
            /// <summary> <b>[requires: GLX_NV_delay_before_swap]</b> <b>[entry point: <c>glXDelayBeforeSwapNV</c>]</b><br/>  </summary>
            public static bool DelayBeforeSwapNV(DisplayPtr dpy, GLXDrawable drawable, float seconds) => GlxPointers._glXDelayBeforeSwapNV_fnptr((IntPtr)dpy, (nuint)drawable, seconds) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXEnumerateVideoCaptureDevicesNV</c>]</b><br/>  </summary>
            public static GLXVideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(DisplayPtr dpy, int screen, int* nelements) => (GLXVideoCaptureDeviceNV*) GlxPointers._glXEnumerateVideoCaptureDevicesNV_fnptr((IntPtr)dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_present_video]</b> <b>[entry point: <c>glXEnumerateVideoDevicesNV</c>]</b><br/>  </summary>
            public static uint* EnumerateVideoDevicesNV(DisplayPtr dpy, int screen, int* nelements) => GlxPointers._glXEnumerateVideoDevicesNV_fnptr((IntPtr)dpy, screen, nelements);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXGetVideoDeviceNV</c>]</b><br/>  </summary>
            public static int GetVideoDeviceNV(DisplayPtr dpy, int screen, int numVideoDevices, GLXVideoDeviceNV* pVideoDevice) => GlxPointers._glXGetVideoDeviceNV_fnptr((IntPtr)dpy, screen, numVideoDevices, (uint*)pVideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXGetVideoInfoNV</c>]</b><br/>  </summary>
            public static int GetVideoInfoNV(DisplayPtr dpy, int screen, GLXVideoDeviceNV VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo) => GlxPointers._glXGetVideoInfoNV_fnptr((IntPtr)dpy, screen, (uint)VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXJoinSwapGroupNV</c>]</b><br/>  </summary>
            public static bool JoinSwapGroupNV(DisplayPtr dpy, GLXDrawable drawable, uint group) => GlxPointers._glXJoinSwapGroupNV_fnptr((IntPtr)dpy, (nuint)drawable, group) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXLockVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static void LockVideoCaptureDeviceNV(DisplayPtr dpy, GLXVideoCaptureDeviceNV device) => GlxPointers._glXLockVideoCaptureDeviceNV_fnptr((IntPtr)dpy, (nuint)device);
            
            /// <summary> <b>[requires: GLX_NV_copy_buffer]</b> <b>[entry point: <c>glXNamedCopyBufferSubDataNV</c>]</b><br/>  </summary>
            public static void NamedCopyBufferSubDataNV(DisplayPtr dpy, GLXContext readCtx, GLXContext writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size) => GlxPointers._glXNamedCopyBufferSubDataNV_fnptr((IntPtr)dpy, (IntPtr)readCtx, (IntPtr)writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXQueryFrameCountNV</c>]</b><br/>  </summary>
            public static bool QueryFrameCountNV(DisplayPtr dpy, int screen, uint* count) => GlxPointers._glXQueryFrameCountNV_fnptr((IntPtr)dpy, screen, count) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXQueryMaxSwapGroupsNV</c>]</b><br/>  </summary>
            public static bool QueryMaxSwapGroupsNV(DisplayPtr dpy, int screen, uint* maxGroups, uint* maxBarriers) => GlxPointers._glXQueryMaxSwapGroupsNV_fnptr((IntPtr)dpy, screen, maxGroups, maxBarriers) != 0;
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXQuerySwapGroupNV</c>]</b><br/>  </summary>
            public static bool QuerySwapGroupNV(DisplayPtr dpy, GLXDrawable drawable, uint* group, uint* barrier) => GlxPointers._glXQuerySwapGroupNV_fnptr((IntPtr)dpy, (nuint)drawable, group, barrier) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXQueryVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static int QueryVideoCaptureDeviceNV(DisplayPtr dpy, GLXVideoCaptureDeviceNV device, int attribute, int* value) => GlxPointers._glXQueryVideoCaptureDeviceNV_fnptr((IntPtr)dpy, (nuint)device, attribute, value);
            
            /// <summary> <b>[requires: GLX_NV_video_capture]</b> <b>[entry point: <c>glXReleaseVideoCaptureDeviceNV</c>]</b><br/>  </summary>
            public static void ReleaseVideoCaptureDeviceNV(DisplayPtr dpy, GLXVideoCaptureDeviceNV device) => GlxPointers._glXReleaseVideoCaptureDeviceNV_fnptr((IntPtr)dpy, (nuint)device);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXReleaseVideoDeviceNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoDeviceNV(DisplayPtr dpy, int screen, GLXVideoDeviceNV VideoDevice) => GlxPointers._glXReleaseVideoDeviceNV_fnptr((IntPtr)dpy, screen, (uint)VideoDevice);
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXReleaseVideoImageNV</c>]</b><br/>  </summary>
            public static int ReleaseVideoImageNV(DisplayPtr dpy, GLXPbuffer pbuf) => GlxPointers._glXReleaseVideoImageNV_fnptr((IntPtr)dpy, (nuint)pbuf);
            
            /// <summary> <b>[requires: GLX_NV_swap_group]</b> <b>[entry point: <c>glXResetFrameCountNV</c>]</b><br/>  </summary>
            public static bool ResetFrameCountNV(DisplayPtr dpy, int screen) => GlxPointers._glXResetFrameCountNV_fnptr((IntPtr)dpy, screen) != 0;
            
            /// <summary> <b>[requires: GLX_NV_video_out]</b> <b>[entry point: <c>glXSendPbufferToVideoNV</c>]</b><br/>  </summary>
            public static int SendPbufferToVideoNV(DisplayPtr dpy, GLXPbuffer pbuf, int iBufferType, ulong* pulCounterPbuffer, bool bBlock) => GlxPointers._glXSendPbufferToVideoNV_fnptr((IntPtr)dpy, (nuint)pbuf, iBufferType, pulCounterPbuffer, (byte)(bBlock ? 1 : 0));
            
        }
        /// <summary>OML extensions.</summary>
        public static unsafe partial class OML
        {
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXGetMscRateOML</c>]</b><br/>  </summary>
            public static bool GetMscRateOML(DisplayPtr dpy, GLXDrawable drawable, int* numerator, int* denominator) => GlxPointers._glXGetMscRateOML_fnptr((IntPtr)dpy, (nuint)drawable, numerator, denominator) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXGetSyncValuesOML</c>]</b><br/>  </summary>
            public static bool GetSyncValuesOML(DisplayPtr dpy, GLXDrawable drawable, long* ust, long* msc, long* sbc) => GlxPointers._glXGetSyncValuesOML_fnptr((IntPtr)dpy, (nuint)drawable, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXSwapBuffersMscOML</c>]</b><br/>  </summary>
            public static long SwapBuffersMscOML(DisplayPtr dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder) => GlxPointers._glXSwapBuffersMscOML_fnptr((IntPtr)dpy, (nuint)drawable, target_msc, divisor, remainder);
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXWaitForMscOML</c>]</b><br/>  </summary>
            public static bool WaitForMscOML(DisplayPtr dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc) => GlxPointers._glXWaitForMscOML_fnptr((IntPtr)dpy, (nuint)drawable, target_msc, divisor, remainder, ust, msc, sbc) != 0;
            
            /// <summary> <b>[requires: GLX_OML_sync_control]</b> <b>[entry point: <c>glXWaitForSbcOML</c>]</b><br/>  </summary>
            public static bool WaitForSbcOML(DisplayPtr dpy, GLXDrawable drawable, long target_sbc, long* ust, long* msc, long* sbc) => GlxPointers._glXWaitForSbcOML_fnptr((IntPtr)dpy, (nuint)drawable, target_sbc, ust, msc, sbc) != 0;
            
        }
        /// <summary>SGI extensions.</summary>
        public static unsafe partial class SGI
        {
            /// <summary> <b>[requires: GLX_SGI_cushion]</b> <b>[entry point: <c>glXCushionSGI</c>]</b><br/>  </summary>
            public static void CushionSGI(DisplayPtr dpy, Window window, float cushion) => GlxPointers._glXCushionSGI_fnptr((IntPtr)dpy, (nuint)window, cushion);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b> <b>[entry point: <c>glXGetCurrentReadDrawableSGI</c>]</b><br/>  </summary>
            public static GLXDrawable GetCurrentReadDrawableSGI() => (GLXDrawable) GlxPointers._glXGetCurrentReadDrawableSGI_fnptr();
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b> <b>[entry point: <c>glXGetVideoSyncSGI</c>]</b><br/>  </summary>
            public static int GetVideoSyncSGI(uint* count) => GlxPointers._glXGetVideoSyncSGI_fnptr(count);
            
            /// <summary> <b>[requires: GLX_SGI_make_current_read]</b> <b>[entry point: <c>glXMakeCurrentReadSGI</c>]</b><br/>  </summary>
            public static bool MakeCurrentReadSGI(DisplayPtr dpy, GLXDrawable draw, GLXDrawable read, GLXContext ctx) => GlxPointers._glXMakeCurrentReadSGI_fnptr((IntPtr)dpy, (nuint)draw, (nuint)read, (IntPtr)ctx) != 0;
            
            /// <summary> <b>[requires: GLX_SGI_swap_control]</b> <b>[entry point: <c>glXSwapIntervalSGI</c>]</b><br/>  </summary>
            public static int SwapIntervalSGI(int interval) => GlxPointers._glXSwapIntervalSGI_fnptr(interval);
            
            /// <summary> <b>[requires: GLX_SGI_video_sync]</b> <b>[entry point: <c>glXWaitVideoSyncSGI</c>]</b><br/>  </summary>
            public static int WaitVideoSyncSGI(int divisor, int remainder, uint* count) => GlxPointers._glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
            
        }
        /// <summary>SGIX extensions.</summary>
        public static unsafe partial class SGIX
        {
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXBindChannelToWindowSGIX</c>]</b><br/>  </summary>
            public static int BindChannelToWindowSGIX(DisplayPtr display, int screen, int channel, Window window) => GlxPointers._glXBindChannelToWindowSGIX_fnptr((IntPtr)display, screen, channel, (nuint)window);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXBindHyperpipeSGIX</c>]</b><br/>  </summary>
            public static int BindHyperpipeSGIX(DisplayPtr dpy, int hpId) => GlxPointers._glXBindHyperpipeSGIX_fnptr((IntPtr)dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b> <b>[entry point: <c>glXBindSwapBarrierSGIX</c>]</b><br/>  </summary>
            public static void BindSwapBarrierSGIX(DisplayPtr dpy, GLXDrawable drawable, int barrier) => GlxPointers._glXBindSwapBarrierSGIX_fnptr((IntPtr)dpy, (nuint)drawable, barrier);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXChannelRectSGIX</c>]</b><br/>  </summary>
            public static int ChannelRectSGIX(DisplayPtr display, int screen, int channel, int x, int y, int w, int h) => GlxPointers._glXChannelRectSGIX_fnptr((IntPtr)display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXChannelRectSyncSGIX</c>]</b><br/>  </summary>
            public static int ChannelRectSyncSGIX(DisplayPtr display, int screen, int channel, All synctype) => GlxPointers._glXChannelRectSyncSGIX_fnptr((IntPtr)display, screen, channel, (uint)synctype);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXChooseFBConfigSGIX</c>]</b><br/>  </summary>
            public static GLXFBConfigSGIX* ChooseFBConfigSGIX(DisplayPtr dpy, int screen, int* attrib_list, int* nelements) => (GLXFBConfigSGIX*) GlxPointers._glXChooseFBConfigSGIX_fnptr((IntPtr)dpy, screen, attrib_list, nelements);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXCreateContextWithConfigSGIX</c>]</b><br/>  </summary>
            public static GLXContext CreateContextWithConfigSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, int render_type, GLXContext share_list, bool direct) => (GLXContext) GlxPointers._glXCreateContextWithConfigSGIX_fnptr((IntPtr)dpy, (IntPtr)config, render_type, (IntPtr)share_list, (byte)(direct ? 1 : 0));
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXCreateGLXPbufferSGIX</c>]</b><br/>  </summary>
            public static GLXPbufferSGIX CreateGLXPbufferSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, uint width, uint height, int* attrib_list) => (GLXPbufferSGIX) GlxPointers._glXCreateGLXPbufferSGIX_fnptr((IntPtr)dpy, (IntPtr)config, width, height, attrib_list);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXCreateGLXPixmapWithConfigSGIX</c>]</b><br/>  </summary>
            public static GLXPixmap CreateGLXPixmapWithConfigSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, Pixmap pixmap) => (GLXPixmap) GlxPointers._glXCreateGLXPixmapWithConfigSGIX_fnptr((IntPtr)dpy, (IntPtr)config, (nuint)pixmap);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXDestroyGLXPbufferSGIX</c>]</b><br/>  </summary>
            public static void DestroyGLXPbufferSGIX(DisplayPtr dpy, GLXPbufferSGIX pbuf) => GlxPointers._glXDestroyGLXPbufferSGIX_fnptr((IntPtr)dpy, (nuint)pbuf);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXDestroyHyperpipeConfigSGIX</c>]</b><br/>  </summary>
            public static int DestroyHyperpipeConfigSGIX(DisplayPtr dpy, int hpId) => GlxPointers._glXDestroyHyperpipeConfigSGIX_fnptr((IntPtr)dpy, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXGetFBConfigAttribSGIX</c>]</b><br/>  </summary>
            public static int GetFBConfigAttribSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, int attribute, int* value) => GlxPointers._glXGetFBConfigAttribSGIX_fnptr((IntPtr)dpy, (IntPtr)config, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXGetFBConfigFromVisualSGIX</c>]</b><br/>  </summary>
            public static GLXFBConfigSGIX GetFBConfigFromVisualSGIX(DisplayPtr dpy, XVisualInfoPtr vis) => (GLXFBConfigSGIX) GlxPointers._glXGetFBConfigFromVisualSGIX_fnptr((IntPtr)dpy, (IntPtr)vis);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXGetSelectedEventSGIX</c>]</b><br/>  </summary>
            public static void GetSelectedEventSGIX(DisplayPtr dpy, GLXDrawable drawable, ulong* mask) => GlxPointers._glXGetSelectedEventSGIX_fnptr((IntPtr)dpy, (nuint)drawable, mask);
            
            /// <summary> <b>[requires: GLX_SGIX_fbconfig]</b> <b>[entry point: <c>glXGetVisualFromFBConfigSGIX</c>]</b><br/>  </summary>
            public static XVisualInfoPtr GetVisualFromFBConfigSGIX(DisplayPtr dpy, GLXFBConfigSGIX config) => (XVisualInfoPtr) GlxPointers._glXGetVisualFromFBConfigSGIX_fnptr((IntPtr)dpy, (IntPtr)config);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXHyperpipeAttribSGIX</c>]</b><br/>  </summary>
            public static int HyperpipeAttribSGIX(DisplayPtr dpy, int timeSlice, int attrib, int size, void* attribList) => GlxPointers._glXHyperpipeAttribSGIX_fnptr((IntPtr)dpy, timeSlice, attrib, size, attribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXHyperpipeConfigSGIX</c>]</b><br/>  </summary>
            public static int HyperpipeConfigSGIX(DisplayPtr dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId) => GlxPointers._glXHyperpipeConfigSGIX_fnptr((IntPtr)dpy, networkId, npipes, cfg, hpId);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_group]</b> <b>[entry point: <c>glXJoinSwapGroupSGIX</c>]</b><br/>  </summary>
            public static void JoinSwapGroupSGIX(DisplayPtr dpy, GLXDrawable drawable, GLXDrawable member) => GlxPointers._glXJoinSwapGroupSGIX_fnptr((IntPtr)dpy, (nuint)drawable, (nuint)member);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXQueryChannelDeltasSGIX</c>]</b><br/>  </summary>
            public static int QueryChannelDeltasSGIX(DisplayPtr display, int screen, int channel, int* x, int* y, int* w, int* h) => GlxPointers._glXQueryChannelDeltasSGIX_fnptr((IntPtr)display, screen, channel, x, y, w, h);
            
            /// <summary> <b>[requires: GLX_SGIX_video_resize]</b> <b>[entry point: <c>glXQueryChannelRectSGIX</c>]</b><br/>  </summary>
            public static int QueryChannelRectSGIX(DisplayPtr display, int screen, int channel, int* dx, int* dy, int* dw, int* dh) => GlxPointers._glXQueryChannelRectSGIX_fnptr((IntPtr)display, screen, channel, dx, dy, dw, dh);
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXQueryGLXPbufferSGIX</c>]</b><br/>  </summary>
            public static void QueryGLXPbufferSGIX(DisplayPtr dpy, GLXPbufferSGIX pbuf, int attribute, uint* value) => GlxPointers._glXQueryGLXPbufferSGIX_fnptr((IntPtr)dpy, (nuint)pbuf, attribute, value);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeAttribSGIX</c>]</b><br/>  </summary>
            public static int QueryHyperpipeAttribSGIX(DisplayPtr dpy, int timeSlice, int attrib, int size, void* returnAttribList) => GlxPointers._glXQueryHyperpipeAttribSGIX_fnptr((IntPtr)dpy, timeSlice, attrib, size, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeBestAttribSGIX</c>]</b><br/>  </summary>
            public static int QueryHyperpipeBestAttribSGIX(DisplayPtr dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList) => GlxPointers._glXQueryHyperpipeBestAttribSGIX_fnptr((IntPtr)dpy, timeSlice, attrib, size, attribList, returnAttribList);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeConfigSGIX</c>]</b><br/>  </summary>
            public static GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(DisplayPtr dpy, int hpId, int* npipes) => GlxPointers._glXQueryHyperpipeConfigSGIX_fnptr((IntPtr)dpy, hpId, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_hyperpipe]</b> <b>[entry point: <c>glXQueryHyperpipeNetworkSGIX</c>]</b><br/>  </summary>
            public static GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(DisplayPtr dpy, int* npipes) => GlxPointers._glXQueryHyperpipeNetworkSGIX_fnptr((IntPtr)dpy, npipes);
            
            /// <summary> <b>[requires: GLX_SGIX_swap_barrier]</b> <b>[entry point: <c>glXQueryMaxSwapBarriersSGIX</c>]</b><br/>  </summary>
            public static bool QueryMaxSwapBarriersSGIX(DisplayPtr dpy, int screen, int* max) => GlxPointers._glXQueryMaxSwapBarriersSGIX_fnptr((IntPtr)dpy, screen, max) != 0;
            
            /// <summary> <b>[requires: GLX_SGIX_pbuffer]</b> <b>[entry point: <c>glXSelectEventSGIX</c>]</b><br/>  </summary>
            public static void SelectEventSGIX(DisplayPtr dpy, GLXDrawable drawable, ulong mask) => GlxPointers._glXSelectEventSGIX_fnptr((IntPtr)dpy, (nuint)drawable, mask);
            
        }
        /// <summary>SUN extensions.</summary>
        public static unsafe partial class SUN
        {
            /// <summary> <b>[requires: GLX_SUN_get_transparent_index]</b> <b>[entry point: <c>glXGetTransparentIndexSUN</c>]</b><br/>  </summary>
            public static int GetTransparentIndexSUN(DisplayPtr dpy, Window overlay, Window underlay, ulong* pTransparentIndex) => GlxPointers._glXGetTransparentIndexSUN_fnptr((IntPtr)dpy, (nuint)overlay, (nuint)underlay, pTransparentIndex);
            
        }
    }
}
