// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics
{
    /// <summary>A collection of all function pointers to all OpenGL entry points.</summary>
    public static unsafe partial class GLXPointers
    {
        internal static delegate* unmanaged<ulong*, ulong, void*, void, byte> _glXAssociateDMPbufferSGIX_fnptr = &glXAssociateDMPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXAssociateDMPbufferSGIX_Lazy(ulong* dpy, ulong pbuffer, void* parameters, void dmbuffer)
        {
            _glXAssociateDMPbufferSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, void*, void, byte>)GLLoader.BindingsContext.GetProcAddress("glXAssociateDMPbufferSGIX");
            return _glXAssociateDMPbufferSGIX_fnptr(dpy, pbuffer, parameters, dmbuffer);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, ulong, int> _glXBindChannelToWindowSGIX_fnptr = &glXBindChannelToWindowSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindChannelToWindowSGIX_Lazy(ulong* display, int screen, int channel, ulong window)
        {
            _glXBindChannelToWindowSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, ulong, int>)GLLoader.BindingsContext.GetProcAddress("glXBindChannelToWindowSGIX");
            return _glXBindChannelToWindowSGIX_fnptr(display, screen, channel, window);
        }
        
        internal static delegate* unmanaged<ulong*, int, int> _glXBindHyperpipeSGIX_fnptr = &glXBindHyperpipeSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindHyperpipeSGIX_Lazy(ulong* dpy, int hpId)
        {
            _glXBindHyperpipeSGIX_fnptr = (delegate* unmanaged<ulong*, int, int>)GLLoader.BindingsContext.GetProcAddress("glXBindHyperpipeSGIX");
            return _glXBindHyperpipeSGIX_fnptr(dpy, hpId);
        }
        
        internal static delegate* unmanaged<ulong*, uint, uint, byte> _glXBindSwapBarrierNV_fnptr = &glXBindSwapBarrierNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXBindSwapBarrierNV_Lazy(ulong* dpy, uint group, uint barrier)
        {
            _glXBindSwapBarrierNV_fnptr = (delegate* unmanaged<ulong*, uint, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glXBindSwapBarrierNV");
            return _glXBindSwapBarrierNV_fnptr(dpy, group, barrier);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, void> _glXBindSwapBarrierSGIX_fnptr = &glXBindSwapBarrierSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXBindSwapBarrierSGIX_Lazy(ulong* dpy, ulong drawable, int barrier)
        {
            _glXBindSwapBarrierSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, int, void>)GLLoader.BindingsContext.GetProcAddress("glXBindSwapBarrierSGIX");
            _glXBindSwapBarrierSGIX_fnptr(dpy, drawable, barrier);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, int*, void> _glXBindTexImageEXT_fnptr = &glXBindTexImageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXBindTexImageEXT_Lazy(ulong* dpy, ulong drawable, int buffer, int* attrib_list)
        {
            _glXBindTexImageEXT_fnptr = (delegate* unmanaged<ulong*, ulong, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glXBindTexImageEXT");
            _glXBindTexImageEXT_fnptr(dpy, drawable, buffer, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, uint, ulong, int> _glXBindVideoCaptureDeviceNV_fnptr = &glXBindVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindVideoCaptureDeviceNV_Lazy(ulong* dpy, uint video_capture_slot, ulong device)
        {
            _glXBindVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<ulong*, uint, ulong, int>)GLLoader.BindingsContext.GetProcAddress("glXBindVideoCaptureDeviceNV");
            return _glXBindVideoCaptureDeviceNV_fnptr(dpy, video_capture_slot, device);
        }
        
        internal static delegate* unmanaged<ulong*, uint, uint, int*, int> _glXBindVideoDeviceNV_fnptr = &glXBindVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindVideoDeviceNV_Lazy(ulong* dpy, uint video_slot, uint video_device, int* attrib_list)
        {
            _glXBindVideoDeviceNV_fnptr = (delegate* unmanaged<ulong*, uint, uint, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXBindVideoDeviceNV");
            return _glXBindVideoDeviceNV_fnptr(dpy, video_slot, video_device, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, uint, ulong, int, int> _glXBindVideoImageNV_fnptr = &glXBindVideoImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindVideoImageNV_Lazy(ulong* dpy, uint VideoDevice, ulong pbuf, int iVideoBuffer)
        {
            _glXBindVideoImageNV_fnptr = (delegate* unmanaged<ulong*, uint, ulong, int, int>)GLLoader.BindingsContext.GetProcAddress("glXBindVideoImageNV");
            return _glXBindVideoImageNV_fnptr(dpy, VideoDevice, pbuf, iVideoBuffer);
        }
        
        internal static delegate* unmanaged<__GLXContextRec*, int, int, int, int, int, int, int, int, uint, uint, void> _glXBlitContextFramebufferAMD_fnptr = &glXBlitContextFramebufferAMD_Lazy;
        [UnmanagedCallersOnly]
        private static void glXBlitContextFramebufferAMD_Lazy(__GLXContextRec* dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
        {
            _glXBlitContextFramebufferAMD_fnptr = (delegate* unmanaged<__GLXContextRec*, int, int, int, int, int, int, int, int, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("glXBlitContextFramebufferAMD");
            _glXBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int, int, int, int, int> _glXChannelRectSGIX_fnptr = &glXChannelRectSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXChannelRectSGIX_Lazy(ulong* display, int screen, int channel, int x, int y, int w, int h)
        {
            _glXChannelRectSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, int, int, int, int, int>)GLLoader.BindingsContext.GetProcAddress("glXChannelRectSGIX");
            return _glXChannelRectSGIX_fnptr(display, screen, channel, x, y, w, h);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, uint, int> _glXChannelRectSyncSGIX_fnptr = &glXChannelRectSyncSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXChannelRectSyncSGIX_Lazy(ulong* display, int screen, int channel, uint synctype)
        {
            _glXChannelRectSyncSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, uint, int>)GLLoader.BindingsContext.GetProcAddress("glXChannelRectSyncSGIX");
            return _glXChannelRectSyncSGIX_fnptr(display, screen, channel, synctype);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, int*, __GLXFBConfigRec**> _glXChooseFBConfig_fnptr = &glXChooseFBConfig_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXFBConfigRec** glXChooseFBConfig_Lazy(ulong* dpy, int screen, int* attrib_list, int* nelements)
        {
            _glXChooseFBConfig_fnptr = (delegate* unmanaged<ulong*, int, int*, int*, __GLXFBConfigRec**>)GLLoader.BindingsContext.GetProcAddress("glXChooseFBConfig");
            return _glXChooseFBConfig_fnptr(dpy, screen, attrib_list, nelements);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, int*, __GLXFBConfigRec**> _glXChooseFBConfigSGIX_fnptr = &glXChooseFBConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXFBConfigRec** glXChooseFBConfigSGIX_Lazy(ulong* dpy, int screen, int* attrib_list, int* nelements)
        {
            _glXChooseFBConfigSGIX_fnptr = (delegate* unmanaged<ulong*, int, int*, int*, __GLXFBConfigRec**>)GLLoader.BindingsContext.GetProcAddress("glXChooseFBConfigSGIX");
            return _glXChooseFBConfigSGIX_fnptr(dpy, screen, attrib_list, nelements);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, ulong*> _glXChooseVisual_fnptr = &glXChooseVisual_Lazy;
        [UnmanagedCallersOnly]
        private static ulong* glXChooseVisual_Lazy(ulong* dpy, int screen, int* attribList)
        {
            _glXChooseVisual_fnptr = (delegate* unmanaged<ulong*, int, int*, ulong*>)GLLoader.BindingsContext.GetProcAddress("glXChooseVisual");
            return _glXChooseVisual_fnptr(dpy, screen, attribList);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, __GLXContextRec*, uint, uint, IntPtr, IntPtr, nint, void> _glXCopyBufferSubDataNV_fnptr = &glXCopyBufferSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopyBufferSubDataNV_Lazy(ulong* dpy, __GLXContextRec* readCtx, __GLXContextRec* writeCtx, uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            _glXCopyBufferSubDataNV_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, __GLXContextRec*, uint, uint, IntPtr, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glXCopyBufferSubDataNV");
            _glXCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, __GLXContextRec*, uint, uint, IntPtr, IntPtr, nint, void> _glXNamedCopyBufferSubDataNV_fnptr = &glXNamedCopyBufferSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXNamedCopyBufferSubDataNV_Lazy(ulong* dpy, __GLXContextRec* readCtx, __GLXContextRec* writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            _glXNamedCopyBufferSubDataNV_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, __GLXContextRec*, uint, uint, IntPtr, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glXNamedCopyBufferSubDataNV");
            _glXNamedCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, __GLXContextRec*, ulong, void> _glXCopyContext_fnptr = &glXCopyContext_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopyContext_Lazy(ulong* dpy, __GLXContextRec* src, __GLXContextRec* dst, ulong mask)
        {
            _glXCopyContext_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, __GLXContextRec*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXCopyContext");
            _glXCopyContext_fnptr(dpy, src, dst, mask);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, uint, uint, int, int, int, int, __GLXContextRec*, uint, uint, int, int, int, int, int, int, int, void> _glXCopyImageSubDataNV_fnptr = &glXCopyImageSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopyImageSubDataNV_Lazy(ulong* dpy, __GLXContextRec* srcCtx, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, __GLXContextRec* dstCtx, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
        {
            _glXCopyImageSubDataNV_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, uint, uint, int, int, int, int, __GLXContextRec*, uint, uint, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glXCopyImageSubDataNV");
            _glXCopyImageSubDataNV_fnptr(dpy, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, int, int, int, void> _glXCopySubBufferMESA_fnptr = &glXCopySubBufferMESA_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopySubBufferMESA_Lazy(ulong* dpy, ulong drawable, int x, int y, int width, int height)
        {
            _glXCopySubBufferMESA_fnptr = (delegate* unmanaged<ulong*, ulong, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glXCopySubBufferMESA");
            _glXCopySubBufferMESA_fnptr(dpy, drawable, x, y, width, height);
        }
        
        internal static delegate* unmanaged<uint, __GLXContextRec*, __GLXContextRec*> _glXCreateAssociatedContextAMD_fnptr = &glXCreateAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXCreateAssociatedContextAMD_Lazy(uint id, __GLXContextRec* share_list)
        {
            _glXCreateAssociatedContextAMD_fnptr = (delegate* unmanaged<uint, __GLXContextRec*, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXCreateAssociatedContextAMD");
            return _glXCreateAssociatedContextAMD_fnptr(id, share_list);
        }
        
        internal static delegate* unmanaged<uint, __GLXContextRec*, int*, __GLXContextRec*> _glXCreateAssociatedContextAttribsAMD_fnptr = &glXCreateAssociatedContextAttribsAMD_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXCreateAssociatedContextAttribsAMD_Lazy(uint id, __GLXContextRec* share_context, int* attribList)
        {
            _glXCreateAssociatedContextAttribsAMD_fnptr = (delegate* unmanaged<uint, __GLXContextRec*, int*, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXCreateAssociatedContextAttribsAMD");
            return _glXCreateAssociatedContextAttribsAMD_fnptr(id, share_context, attribList);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, __GLXContextRec*, byte, int*, __GLXContextRec*> _glXCreateContextAttribsARB_fnptr = &glXCreateContextAttribsARB_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXCreateContextAttribsARB_Lazy(ulong* dpy, __GLXFBConfigRec* config, __GLXContextRec* share_context, byte direct, int* attrib_list)
        {
            _glXCreateContextAttribsARB_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, __GLXContextRec*, byte, int*, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXCreateContextAttribsARB");
            return _glXCreateContextAttribsARB_fnptr(dpy, config, share_context, direct, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, ulong*, __GLXContextRec*, byte, __GLXContextRec*> _glXCreateContext_fnptr = &glXCreateContext_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXCreateContext_Lazy(ulong* dpy, ulong* vis, __GLXContextRec* shareList, byte direct)
        {
            _glXCreateContext_fnptr = (delegate* unmanaged<ulong*, ulong*, __GLXContextRec*, byte, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXCreateContext");
            return _glXCreateContext_fnptr(dpy, vis, shareList, direct);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, __GLXContextRec*, byte, __GLXContextRec*> _glXCreateContextWithConfigSGIX_fnptr = &glXCreateContextWithConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXCreateContextWithConfigSGIX_Lazy(ulong* dpy, __GLXFBConfigRec* config, int render_type, __GLXContextRec* share_list, byte direct)
        {
            _glXCreateContextWithConfigSGIX_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, __GLXContextRec*, byte, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXCreateContextWithConfigSGIX");
            return _glXCreateContextWithConfigSGIX_fnptr(dpy, config, render_type, share_list, direct);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, uint, uint, int*, ulong> _glXCreateGLXPbufferSGIX_fnptr = &glXCreateGLXPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreateGLXPbufferSGIX_Lazy(ulong* dpy, __GLXFBConfigRec* config, uint width, uint height, int* attrib_list)
        {
            _glXCreateGLXPbufferSGIX_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, uint, uint, int*, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreateGLXPbufferSGIX");
            return _glXCreateGLXPbufferSGIX_fnptr(dpy, config, width, height, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, ulong*, ulong, ulong> _glXCreateGLXPixmap_fnptr = &glXCreateGLXPixmap_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreateGLXPixmap_Lazy(ulong* dpy, ulong* visual, ulong pixmap)
        {
            _glXCreateGLXPixmap_fnptr = (delegate* unmanaged<ulong*, ulong*, ulong, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmap");
            return _glXCreateGLXPixmap_fnptr(dpy, visual, pixmap);
        }
        
        internal static delegate* unmanaged<ulong*, ulong*, ulong, ulong, ulong> _glXCreateGLXPixmapMESA_fnptr = &glXCreateGLXPixmapMESA_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreateGLXPixmapMESA_Lazy(ulong* dpy, ulong* visual, ulong pixmap, ulong cmap)
        {
            _glXCreateGLXPixmapMESA_fnptr = (delegate* unmanaged<ulong*, ulong*, ulong, ulong, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmapMESA");
            return _glXCreateGLXPixmapMESA_fnptr(dpy, visual, pixmap, cmap);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong, ulong> _glXCreateGLXPixmapWithConfigSGIX_fnptr = &glXCreateGLXPixmapWithConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreateGLXPixmapWithConfigSGIX_Lazy(ulong* dpy, __GLXFBConfigRec* config, ulong pixmap)
        {
            _glXCreateGLXPixmapWithConfigSGIX_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmapWithConfigSGIX");
            return _glXCreateGLXPixmapWithConfigSGIX_fnptr(dpy, config, pixmap);
        }
        
        internal static delegate* unmanaged<ulong*, int, void, void, int, void, ulong> _glXCreateGLXVideoSourceSGIX_fnptr = &glXCreateGLXVideoSourceSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreateGLXVideoSourceSGIX_Lazy(ulong* display, int screen, void server, void path, int nodeClass, void drainNode)
        {
            _glXCreateGLXVideoSourceSGIX_fnptr = (delegate* unmanaged<ulong*, int, void, void, int, void, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreateGLXVideoSourceSGIX");
            return _glXCreateGLXVideoSourceSGIX_fnptr(display, screen, server, path, nodeClass, drainNode);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, __GLXContextRec*, byte, __GLXContextRec*> _glXCreateNewContext_fnptr = &glXCreateNewContext_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXCreateNewContext_Lazy(ulong* dpy, __GLXFBConfigRec* config, int render_type, __GLXContextRec* share_list, byte direct)
        {
            _glXCreateNewContext_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, __GLXContextRec*, byte, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXCreateNewContext");
            return _glXCreateNewContext_fnptr(dpy, config, render_type, share_list, direct);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, int*, ulong> _glXCreatePbuffer_fnptr = &glXCreatePbuffer_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreatePbuffer_Lazy(ulong* dpy, __GLXFBConfigRec* config, int* attrib_list)
        {
            _glXCreatePbuffer_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, int*, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreatePbuffer");
            return _glXCreatePbuffer_fnptr(dpy, config, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong, int*, ulong> _glXCreatePixmap_fnptr = &glXCreatePixmap_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreatePixmap_Lazy(ulong* dpy, __GLXFBConfigRec* config, ulong pixmap, int* attrib_list)
        {
            _glXCreatePixmap_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong, int*, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreatePixmap");
            return _glXCreatePixmap_fnptr(dpy, config, pixmap, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong, int*, ulong> _glXCreateWindow_fnptr = &glXCreateWindow_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXCreateWindow_Lazy(ulong* dpy, __GLXFBConfigRec* config, ulong win, int* attrib_list)
        {
            _glXCreateWindow_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong, int*, ulong>)GLLoader.BindingsContext.GetProcAddress("glXCreateWindow");
            return _glXCreateWindow_fnptr(dpy, config, win, attrib_list);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, float, void> _glXCushionSGI_fnptr = &glXCushionSGI_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCushionSGI_Lazy(ulong* dpy, ulong window, float cushion)
        {
            _glXCushionSGI_fnptr = (delegate* unmanaged<ulong*, ulong, float, void>)GLLoader.BindingsContext.GetProcAddress("glXCushionSGI");
            _glXCushionSGI_fnptr(dpy, window, cushion);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, float, byte> _glXDelayBeforeSwapNV_fnptr = &glXDelayBeforeSwapNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXDelayBeforeSwapNV_Lazy(ulong* dpy, ulong drawable, float seconds)
        {
            _glXDelayBeforeSwapNV_fnptr = (delegate* unmanaged<ulong*, ulong, float, byte>)GLLoader.BindingsContext.GetProcAddress("glXDelayBeforeSwapNV");
            return _glXDelayBeforeSwapNV_fnptr(dpy, drawable, seconds);
        }
        
        internal static delegate* unmanaged<__GLXContextRec*, byte> _glXDeleteAssociatedContextAMD_fnptr = &glXDeleteAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXDeleteAssociatedContextAMD_Lazy(__GLXContextRec* ctx)
        {
            _glXDeleteAssociatedContextAMD_fnptr = (delegate* unmanaged<__GLXContextRec*, byte>)GLLoader.BindingsContext.GetProcAddress("glXDeleteAssociatedContextAMD");
            return _glXDeleteAssociatedContextAMD_fnptr(ctx);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, void> _glXDestroyContext_fnptr = &glXDestroyContext_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyContext_Lazy(ulong* dpy, __GLXContextRec* ctx)
        {
            _glXDestroyContext_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyContext");
            _glXDestroyContext_fnptr(dpy, ctx);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXDestroyGLXPbufferSGIX_fnptr = &glXDestroyGLXPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyGLXPbufferSGIX_Lazy(ulong* dpy, ulong pbuf)
        {
            _glXDestroyGLXPbufferSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyGLXPbufferSGIX");
            _glXDestroyGLXPbufferSGIX_fnptr(dpy, pbuf);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXDestroyGLXPixmap_fnptr = &glXDestroyGLXPixmap_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyGLXPixmap_Lazy(ulong* dpy, ulong pixmap)
        {
            _glXDestroyGLXPixmap_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyGLXPixmap");
            _glXDestroyGLXPixmap_fnptr(dpy, pixmap);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXDestroyGLXVideoSourceSGIX_fnptr = &glXDestroyGLXVideoSourceSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyGLXVideoSourceSGIX_Lazy(ulong* dpy, ulong glxvideosource)
        {
            _glXDestroyGLXVideoSourceSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyGLXVideoSourceSGIX");
            _glXDestroyGLXVideoSourceSGIX_fnptr(dpy, glxvideosource);
        }
        
        internal static delegate* unmanaged<ulong*, int, int> _glXDestroyHyperpipeConfigSGIX_fnptr = &glXDestroyHyperpipeConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXDestroyHyperpipeConfigSGIX_Lazy(ulong* dpy, int hpId)
        {
            _glXDestroyHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<ulong*, int, int>)GLLoader.BindingsContext.GetProcAddress("glXDestroyHyperpipeConfigSGIX");
            return _glXDestroyHyperpipeConfigSGIX_fnptr(dpy, hpId);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXDestroyPbuffer_fnptr = &glXDestroyPbuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyPbuffer_Lazy(ulong* dpy, ulong pbuf)
        {
            _glXDestroyPbuffer_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyPbuffer");
            _glXDestroyPbuffer_fnptr(dpy, pbuf);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXDestroyPixmap_fnptr = &glXDestroyPixmap_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyPixmap_Lazy(ulong* dpy, ulong pixmap)
        {
            _glXDestroyPixmap_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyPixmap");
            _glXDestroyPixmap_fnptr(dpy, pixmap);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXDestroyWindow_fnptr = &glXDestroyWindow_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyWindow_Lazy(ulong* dpy, ulong win)
        {
            _glXDestroyWindow_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXDestroyWindow");
            _glXDestroyWindow_fnptr(dpy, win);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, ulong*> _glXEnumerateVideoCaptureDevicesNV_fnptr = &glXEnumerateVideoCaptureDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static ulong* glXEnumerateVideoCaptureDevicesNV_Lazy(ulong* dpy, int screen, int* nelements)
        {
            _glXEnumerateVideoCaptureDevicesNV_fnptr = (delegate* unmanaged<ulong*, int, int*, ulong*>)GLLoader.BindingsContext.GetProcAddress("glXEnumerateVideoCaptureDevicesNV");
            return _glXEnumerateVideoCaptureDevicesNV_fnptr(dpy, screen, nelements);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, uint*> _glXEnumerateVideoDevicesNV_fnptr = &glXEnumerateVideoDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static uint* glXEnumerateVideoDevicesNV_Lazy(ulong* dpy, int screen, int* nelements)
        {
            _glXEnumerateVideoDevicesNV_fnptr = (delegate* unmanaged<ulong*, int, int*, uint*>)GLLoader.BindingsContext.GetProcAddress("glXEnumerateVideoDevicesNV");
            return _glXEnumerateVideoDevicesNV_fnptr(dpy, screen, nelements);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, void> _glXFreeContextEXT_fnptr = &glXFreeContextEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXFreeContextEXT_Lazy(ulong* dpy, __GLXContextRec* context)
        {
            _glXFreeContextEXT_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, void>)GLLoader.BindingsContext.GetProcAddress("glXFreeContextEXT");
            _glXFreeContextEXT_fnptr(dpy, context);
        }
        
        internal static delegate* unmanaged<void*, uint> _glXGetAGPOffsetMESA_fnptr = &glXGetAGPOffsetMESA_Lazy;
        [UnmanagedCallersOnly]
        private static uint glXGetAGPOffsetMESA_Lazy(void* pointer)
        {
            _glXGetAGPOffsetMESA_fnptr = (delegate* unmanaged<void*, uint>)GLLoader.BindingsContext.GetProcAddress("glXGetAGPOffsetMESA");
            return _glXGetAGPOffsetMESA_fnptr(pointer);
        }
        
        internal static delegate* unmanaged<ulong*, int, byte*> _glXGetClientString_fnptr = &glXGetClientString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXGetClientString_Lazy(ulong* dpy, int name)
        {
            _glXGetClientString_fnptr = (delegate* unmanaged<ulong*, int, byte*>)GLLoader.BindingsContext.GetProcAddress("glXGetClientString");
            return _glXGetClientString_fnptr(dpy, name);
        }
        
        internal static delegate* unmanaged<ulong*, ulong*, int, int*, int> _glXGetConfig_fnptr = &glXGetConfig_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetConfig_Lazy(ulong* dpy, ulong* visual, int attrib, int* value)
        {
            _glXGetConfig_fnptr = (delegate* unmanaged<ulong*, ulong*, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetConfig");
            return _glXGetConfig_fnptr(dpy, visual, attrib, value);
        }
        
        internal static delegate* unmanaged<__GLXContextRec*, uint> _glXGetContextGPUIDAMD_fnptr = &glXGetContextGPUIDAMD_Lazy;
        [UnmanagedCallersOnly]
        private static uint glXGetContextGPUIDAMD_Lazy(__GLXContextRec* ctx)
        {
            _glXGetContextGPUIDAMD_fnptr = (delegate* unmanaged<__GLXContextRec*, uint>)GLLoader.BindingsContext.GetProcAddress("glXGetContextGPUIDAMD");
            return _glXGetContextGPUIDAMD_fnptr(ctx);
        }
        
        internal static delegate* unmanaged<__GLXContextRec*, ulong> _glXGetContextIDEXT_fnptr = &glXGetContextIDEXT_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXGetContextIDEXT_Lazy(__GLXContextRec* context)
        {
            _glXGetContextIDEXT_fnptr = (delegate* unmanaged<__GLXContextRec*, ulong>)GLLoader.BindingsContext.GetProcAddress("glXGetContextIDEXT");
            return _glXGetContextIDEXT_fnptr(context);
        }
        
        internal static delegate* unmanaged<__GLXContextRec*> _glXGetCurrentAssociatedContextAMD_fnptr = &glXGetCurrentAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXGetCurrentAssociatedContextAMD_Lazy()
        {
            _glXGetCurrentAssociatedContextAMD_fnptr = (delegate* unmanaged<__GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentAssociatedContextAMD");
            return _glXGetCurrentAssociatedContextAMD_fnptr();
        }
        
        internal static delegate* unmanaged<__GLXContextRec*> _glXGetCurrentContext_fnptr = &glXGetCurrentContext_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXGetCurrentContext_Lazy()
        {
            _glXGetCurrentContext_fnptr = (delegate* unmanaged<__GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentContext");
            return _glXGetCurrentContext_fnptr();
        }
        
        internal static delegate* unmanaged<ulong*> _glXGetCurrentDisplayEXT_fnptr = &glXGetCurrentDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static ulong* glXGetCurrentDisplayEXT_Lazy()
        {
            _glXGetCurrentDisplayEXT_fnptr = (delegate* unmanaged<ulong*>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentDisplayEXT");
            return _glXGetCurrentDisplayEXT_fnptr();
        }
        
        internal static delegate* unmanaged<ulong*> _glXGetCurrentDisplay_fnptr = &glXGetCurrentDisplay_Lazy;
        [UnmanagedCallersOnly]
        private static ulong* glXGetCurrentDisplay_Lazy()
        {
            _glXGetCurrentDisplay_fnptr = (delegate* unmanaged<ulong*>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentDisplay");
            return _glXGetCurrentDisplay_fnptr();
        }
        
        internal static delegate* unmanaged<ulong> _glXGetCurrentDrawable_fnptr = &glXGetCurrentDrawable_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXGetCurrentDrawable_Lazy()
        {
            _glXGetCurrentDrawable_fnptr = (delegate* unmanaged<ulong>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentDrawable");
            return _glXGetCurrentDrawable_fnptr();
        }
        
        internal static delegate* unmanaged<ulong> _glXGetCurrentReadDrawableSGI_fnptr = &glXGetCurrentReadDrawableSGI_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXGetCurrentReadDrawableSGI_Lazy()
        {
            _glXGetCurrentReadDrawableSGI_fnptr = (delegate* unmanaged<ulong>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentReadDrawableSGI");
            return _glXGetCurrentReadDrawableSGI_fnptr();
        }
        
        internal static delegate* unmanaged<ulong> _glXGetCurrentReadDrawable_fnptr = &glXGetCurrentReadDrawable_Lazy;
        [UnmanagedCallersOnly]
        private static ulong glXGetCurrentReadDrawable_Lazy()
        {
            _glXGetCurrentReadDrawable_fnptr = (delegate* unmanaged<ulong>)GLLoader.BindingsContext.GetProcAddress("glXGetCurrentReadDrawable");
            return _glXGetCurrentReadDrawable_fnptr();
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, int*, int> _glXGetFBConfigAttrib_fnptr = &glXGetFBConfigAttrib_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetFBConfigAttrib_Lazy(ulong* dpy, __GLXFBConfigRec* config, int attribute, int* value)
        {
            _glXGetFBConfigAttrib_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetFBConfigAttrib");
            return _glXGetFBConfigAttrib_fnptr(dpy, config, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, int*, int> _glXGetFBConfigAttribSGIX_fnptr = &glXGetFBConfigAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetFBConfigAttribSGIX_Lazy(ulong* dpy, __GLXFBConfigRec* config, int attribute, int* value)
        {
            _glXGetFBConfigAttribSGIX_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetFBConfigAttribSGIX");
            return _glXGetFBConfigAttribSGIX_fnptr(dpy, config, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, ulong*, __GLXFBConfigRec*> _glXGetFBConfigFromVisualSGIX_fnptr = &glXGetFBConfigFromVisualSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXFBConfigRec* glXGetFBConfigFromVisualSGIX_Lazy(ulong* dpy, ulong* vis)
        {
            _glXGetFBConfigFromVisualSGIX_fnptr = (delegate* unmanaged<ulong*, ulong*, __GLXFBConfigRec*>)GLLoader.BindingsContext.GetProcAddress("glXGetFBConfigFromVisualSGIX");
            return _glXGetFBConfigFromVisualSGIX_fnptr(dpy, vis);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, __GLXFBConfigRec**> _glXGetFBConfigs_fnptr = &glXGetFBConfigs_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXFBConfigRec** glXGetFBConfigs_Lazy(ulong* dpy, int screen, int* nelements)
        {
            _glXGetFBConfigs_fnptr = (delegate* unmanaged<ulong*, int, int*, __GLXFBConfigRec**>)GLLoader.BindingsContext.GetProcAddress("glXGetFBConfigs");
            return _glXGetFBConfigs_fnptr(dpy, screen, nelements);
        }
        
        internal static delegate* unmanaged<uint, uint*, uint> _glXGetGPUIDsAMD_fnptr = &glXGetGPUIDsAMD_Lazy;
        [UnmanagedCallersOnly]
        private static uint glXGetGPUIDsAMD_Lazy(uint maxCount, uint* ids)
        {
            _glXGetGPUIDsAMD_fnptr = (delegate* unmanaged<uint, uint*, uint>)GLLoader.BindingsContext.GetProcAddress("glXGetGPUIDsAMD");
            return _glXGetGPUIDsAMD_fnptr(maxCount, ids);
        }
        
        internal static delegate* unmanaged<uint, int, uint, uint, void*, int> _glXGetGPUInfoAMD_fnptr = &glXGetGPUInfoAMD_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetGPUInfoAMD_Lazy(uint id, int property, uint dataType, uint size, void* data)
        {
            _glXGetGPUInfoAMD_fnptr = (delegate* unmanaged<uint, int, uint, uint, void*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetGPUInfoAMD");
            return _glXGetGPUInfoAMD_fnptr(id, property, dataType, size, data);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int*, int*, byte> _glXGetMscRateOML_fnptr = &glXGetMscRateOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXGetMscRateOML_Lazy(ulong* dpy, ulong drawable, int* numerator, int* denominator)
        {
            _glXGetMscRateOML_fnptr = (delegate* unmanaged<ulong*, ulong, int*, int*, byte>)GLLoader.BindingsContext.GetProcAddress("glXGetMscRateOML");
            return _glXGetMscRateOML_fnptr(dpy, drawable, numerator, denominator);
        }
        
        internal static delegate* unmanaged<byte*, IntPtr> _glXGetProcAddressARB_fnptr = &glXGetProcAddressARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetProcAddressARB_Lazy(byte* procName)
        {
            _glXGetProcAddressARB_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("glXGetProcAddressARB");
            return _glXGetProcAddressARB_fnptr(procName);
        }
        
        internal static delegate* unmanaged<byte*, IntPtr> _glXGetProcAddress_fnptr = &glXGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetProcAddress_Lazy(byte* procName)
        {
            _glXGetProcAddress_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("glXGetProcAddress");
            return _glXGetProcAddress_fnptr(procName);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong*, void> _glXGetSelectedEvent_fnptr = &glXGetSelectedEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void glXGetSelectedEvent_Lazy(ulong* dpy, ulong draw, ulong* event_mask)
        {
            _glXGetSelectedEvent_fnptr = (delegate* unmanaged<ulong*, ulong, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glXGetSelectedEvent");
            _glXGetSelectedEvent_fnptr(dpy, draw, event_mask);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong*, void> _glXGetSelectedEventSGIX_fnptr = &glXGetSelectedEventSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXGetSelectedEventSGIX_Lazy(ulong* dpy, ulong drawable, ulong* mask)
        {
            _glXGetSelectedEventSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, ulong*, void>)GLLoader.BindingsContext.GetProcAddress("glXGetSelectedEventSGIX");
            _glXGetSelectedEventSGIX_fnptr(dpy, drawable, mask);
        }
        
        internal static delegate* unmanaged<int> _glXGetSwapIntervalMESA_fnptr = &glXGetSwapIntervalMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetSwapIntervalMESA_Lazy()
        {
            _glXGetSwapIntervalMESA_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("glXGetSwapIntervalMESA");
            return _glXGetSwapIntervalMESA_fnptr();
        }
        
        internal static delegate* unmanaged<ulong*, ulong, long*, long*, long*, byte> _glXGetSyncValuesOML_fnptr = &glXGetSyncValuesOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXGetSyncValuesOML_Lazy(ulong* dpy, ulong drawable, long* ust, long* msc, long* sbc)
        {
            _glXGetSyncValuesOML_fnptr = (delegate* unmanaged<ulong*, ulong, long*, long*, long*, byte>)GLLoader.BindingsContext.GetProcAddress("glXGetSyncValuesOML");
            return _glXGetSyncValuesOML_fnptr(dpy, drawable, ust, msc, sbc);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong, ulong*, int> _glXGetTransparentIndexSUN_fnptr = &glXGetTransparentIndexSUN_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetTransparentIndexSUN_Lazy(ulong* dpy, ulong overlay, ulong underlay, ulong* pTransparentIndex)
        {
            _glXGetTransparentIndexSUN_fnptr = (delegate* unmanaged<ulong*, ulong, ulong, ulong*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetTransparentIndexSUN");
            return _glXGetTransparentIndexSUN_fnptr(dpy, overlay, underlay, pTransparentIndex);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, uint*, int> _glXGetVideoDeviceNV_fnptr = &glXGetVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetVideoDeviceNV_Lazy(ulong* dpy, int screen, int numVideoDevices, uint* pVideoDevice)
        {
            _glXGetVideoDeviceNV_fnptr = (delegate* unmanaged<ulong*, int, int, uint*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetVideoDeviceNV");
            return _glXGetVideoDeviceNV_fnptr(dpy, screen, numVideoDevices, pVideoDevice);
        }
        
        internal static delegate* unmanaged<ulong*, int, uint, ulong*, ulong*, int> _glXGetVideoInfoNV_fnptr = &glXGetVideoInfoNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetVideoInfoNV_Lazy(ulong* dpy, int screen, uint VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo)
        {
            _glXGetVideoInfoNV_fnptr = (delegate* unmanaged<ulong*, int, uint, ulong*, ulong*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetVideoInfoNV");
            return _glXGetVideoInfoNV_fnptr(dpy, screen, VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
        }
        
        internal static delegate* unmanaged<uint*, int> _glXGetVideoSyncSGI_fnptr = &glXGetVideoSyncSGI_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetVideoSyncSGI_Lazy(uint* count)
        {
            _glXGetVideoSyncSGI_fnptr = (delegate* unmanaged<uint*, int>)GLLoader.BindingsContext.GetProcAddress("glXGetVideoSyncSGI");
            return _glXGetVideoSyncSGI_fnptr(count);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong*> _glXGetVisualFromFBConfig_fnptr = &glXGetVisualFromFBConfig_Lazy;
        [UnmanagedCallersOnly]
        private static ulong* glXGetVisualFromFBConfig_Lazy(ulong* dpy, __GLXFBConfigRec* config)
        {
            _glXGetVisualFromFBConfig_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong*>)GLLoader.BindingsContext.GetProcAddress("glXGetVisualFromFBConfig");
            return _glXGetVisualFromFBConfig_fnptr(dpy, config);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong*> _glXGetVisualFromFBConfigSGIX_fnptr = &glXGetVisualFromFBConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static ulong* glXGetVisualFromFBConfigSGIX_Lazy(ulong* dpy, __GLXFBConfigRec* config)
        {
            _glXGetVisualFromFBConfigSGIX_fnptr = (delegate* unmanaged<ulong*, __GLXFBConfigRec*, ulong*>)GLLoader.BindingsContext.GetProcAddress("glXGetVisualFromFBConfigSGIX");
            return _glXGetVisualFromFBConfigSGIX_fnptr(dpy, config);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int, void*, int> _glXHyperpipeAttribSGIX_fnptr = &glXHyperpipeAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXHyperpipeAttribSGIX_Lazy(ulong* dpy, int timeSlice, int attrib, int size, void* attribList)
        {
            _glXHyperpipeAttribSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, int, void*, int>)GLLoader.BindingsContext.GetProcAddress("glXHyperpipeAttribSGIX");
            return _glXHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, GLXHyperpipeConfigSGIX*, int*, int> _glXHyperpipeConfigSGIX_fnptr = &glXHyperpipeConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXHyperpipeConfigSGIX_Lazy(ulong* dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId)
        {
            _glXHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, GLXHyperpipeConfigSGIX*, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXHyperpipeConfigSGIX");
            return _glXHyperpipeConfigSGIX_fnptr(dpy, networkId, npipes, cfg, hpId);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, __GLXContextRec*> _glXImportContextEXT_fnptr = &glXImportContextEXT_Lazy;
        [UnmanagedCallersOnly]
        private static __GLXContextRec* glXImportContextEXT_Lazy(ulong* dpy, ulong contextID)
        {
            _glXImportContextEXT_fnptr = (delegate* unmanaged<ulong*, ulong, __GLXContextRec*>)GLLoader.BindingsContext.GetProcAddress("glXImportContextEXT");
            return _glXImportContextEXT_fnptr(dpy, contextID);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, byte> _glXIsDirect_fnptr = &glXIsDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXIsDirect_Lazy(ulong* dpy, __GLXContextRec* ctx)
        {
            _glXIsDirect_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, byte>)GLLoader.BindingsContext.GetProcAddress("glXIsDirect");
            return _glXIsDirect_fnptr(dpy, ctx);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, uint, byte> _glXJoinSwapGroupNV_fnptr = &glXJoinSwapGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXJoinSwapGroupNV_Lazy(ulong* dpy, ulong drawable, uint group)
        {
            _glXJoinSwapGroupNV_fnptr = (delegate* unmanaged<ulong*, ulong, uint, byte>)GLLoader.BindingsContext.GetProcAddress("glXJoinSwapGroupNV");
            return _glXJoinSwapGroupNV_fnptr(dpy, drawable, group);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong, void> _glXJoinSwapGroupSGIX_fnptr = &glXJoinSwapGroupSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXJoinSwapGroupSGIX_Lazy(ulong* dpy, ulong drawable, ulong member)
        {
            _glXJoinSwapGroupSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXJoinSwapGroupSGIX");
            _glXJoinSwapGroupSGIX_fnptr(dpy, drawable, member);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXLockVideoCaptureDeviceNV_fnptr = &glXLockVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXLockVideoCaptureDeviceNV_Lazy(ulong* dpy, ulong device)
        {
            _glXLockVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXLockVideoCaptureDeviceNV");
            _glXLockVideoCaptureDeviceNV_fnptr(dpy, device);
        }
        
        internal static delegate* unmanaged<__GLXContextRec*, byte> _glXMakeAssociatedContextCurrentAMD_fnptr = &glXMakeAssociatedContextCurrentAMD_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeAssociatedContextCurrentAMD_Lazy(__GLXContextRec* ctx)
        {
            _glXMakeAssociatedContextCurrentAMD_fnptr = (delegate* unmanaged<__GLXContextRec*, byte>)GLLoader.BindingsContext.GetProcAddress("glXMakeAssociatedContextCurrentAMD");
            return _glXMakeAssociatedContextCurrentAMD_fnptr(ctx);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong, __GLXContextRec*, byte> _glXMakeContextCurrent_fnptr = &glXMakeContextCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeContextCurrent_Lazy(ulong* dpy, ulong draw, ulong read, __GLXContextRec* ctx)
        {
            _glXMakeContextCurrent_fnptr = (delegate* unmanaged<ulong*, ulong, ulong, __GLXContextRec*, byte>)GLLoader.BindingsContext.GetProcAddress("glXMakeContextCurrent");
            return _glXMakeContextCurrent_fnptr(dpy, draw, read, ctx);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, __GLXContextRec*, byte> _glXMakeCurrent_fnptr = &glXMakeCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeCurrent_Lazy(ulong* dpy, ulong drawable, __GLXContextRec* ctx)
        {
            _glXMakeCurrent_fnptr = (delegate* unmanaged<ulong*, ulong, __GLXContextRec*, byte>)GLLoader.BindingsContext.GetProcAddress("glXMakeCurrent");
            return _glXMakeCurrent_fnptr(dpy, drawable, ctx);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong, __GLXContextRec*, byte> _glXMakeCurrentReadSGI_fnptr = &glXMakeCurrentReadSGI_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeCurrentReadSGI_Lazy(ulong* dpy, ulong draw, ulong read, __GLXContextRec* ctx)
        {
            _glXMakeCurrentReadSGI_fnptr = (delegate* unmanaged<ulong*, ulong, ulong, __GLXContextRec*, byte>)GLLoader.BindingsContext.GetProcAddress("glXMakeCurrentReadSGI");
            return _glXMakeCurrentReadSGI_fnptr(dpy, draw, read, ctx);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int*, int*, int*, int*, int> _glXQueryChannelDeltasSGIX_fnptr = &glXQueryChannelDeltasSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryChannelDeltasSGIX_Lazy(ulong* display, int screen, int channel, int* x, int* y, int* w, int* h)
        {
            _glXQueryChannelDeltasSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, int*, int*, int*, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryChannelDeltasSGIX");
            return _glXQueryChannelDeltasSGIX_fnptr(display, screen, channel, x, y, w, h);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int*, int*, int*, int*, int> _glXQueryChannelRectSGIX_fnptr = &glXQueryChannelRectSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryChannelRectSGIX_Lazy(ulong* display, int screen, int channel, int* dx, int* dy, int* dw, int* dh)
        {
            _glXQueryChannelRectSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, int*, int*, int*, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryChannelRectSGIX");
            return _glXQueryChannelRectSGIX_fnptr(display, screen, channel, dx, dy, dw, dh);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, int, int*, int> _glXQueryContext_fnptr = &glXQueryContext_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryContext_Lazy(ulong* dpy, __GLXContextRec* ctx, int attribute, int* value)
        {
            _glXQueryContext_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryContext");
            return _glXQueryContext_fnptr(dpy, ctx, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, __GLXContextRec*, int, int*, int> _glXQueryContextInfoEXT_fnptr = &glXQueryContextInfoEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryContextInfoEXT_Lazy(ulong* dpy, __GLXContextRec* context, int attribute, int* value)
        {
            _glXQueryContextInfoEXT_fnptr = (delegate* unmanaged<ulong*, __GLXContextRec*, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryContextInfoEXT");
            return _glXQueryContextInfoEXT_fnptr(dpy, context, attribute, value);
        }
        
        internal static delegate* unmanaged<int, uint*, byte> _glXQueryCurrentRendererIntegerMESA_fnptr = &glXQueryCurrentRendererIntegerMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryCurrentRendererIntegerMESA_Lazy(int attribute, uint* value)
        {
            _glXQueryCurrentRendererIntegerMESA_fnptr = (delegate* unmanaged<int, uint*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryCurrentRendererIntegerMESA");
            return _glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value);
        }
        
        internal static delegate* unmanaged<int, byte*> _glXQueryCurrentRendererStringMESA_fnptr = &glXQueryCurrentRendererStringMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryCurrentRendererStringMESA_Lazy(int attribute)
        {
            _glXQueryCurrentRendererStringMESA_fnptr = (delegate* unmanaged<int, byte*>)GLLoader.BindingsContext.GetProcAddress("glXQueryCurrentRendererStringMESA");
            return _glXQueryCurrentRendererStringMESA_fnptr(attribute);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, uint*, void> _glXQueryDrawable_fnptr = &glXQueryDrawable_Lazy;
        [UnmanagedCallersOnly]
        private static void glXQueryDrawable_Lazy(ulong* dpy, ulong draw, int attribute, uint* value)
        {
            _glXQueryDrawable_fnptr = (delegate* unmanaged<ulong*, ulong, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glXQueryDrawable");
            _glXQueryDrawable_fnptr(dpy, draw, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, int*, int*, byte> _glXQueryExtension_fnptr = &glXQueryExtension_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryExtension_Lazy(ulong* dpy, int* errorb, int* @event)
        {
            _glXQueryExtension_fnptr = (delegate* unmanaged<ulong*, int*, int*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryExtension");
            return _glXQueryExtension_fnptr(dpy, errorb, @event);
        }
        
        internal static delegate* unmanaged<ulong*, int, byte*> _glXQueryExtensionsString_fnptr = &glXQueryExtensionsString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryExtensionsString_Lazy(ulong* dpy, int screen)
        {
            _glXQueryExtensionsString_fnptr = (delegate* unmanaged<ulong*, int, byte*>)GLLoader.BindingsContext.GetProcAddress("glXQueryExtensionsString");
            return _glXQueryExtensionsString_fnptr(dpy, screen);
        }
        
        internal static delegate* unmanaged<ulong*, int, uint*, byte> _glXQueryFrameCountNV_fnptr = &glXQueryFrameCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryFrameCountNV_Lazy(ulong* dpy, int screen, uint* count)
        {
            _glXQueryFrameCountNV_fnptr = (delegate* unmanaged<ulong*, int, uint*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryFrameCountNV");
            return _glXQueryFrameCountNV_fnptr(dpy, screen, count);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, uint*, void> _glXQueryGLXPbufferSGIX_fnptr = &glXQueryGLXPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXQueryGLXPbufferSGIX_Lazy(ulong* dpy, ulong pbuf, int attribute, uint* value)
        {
            _glXQueryGLXPbufferSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glXQueryGLXPbufferSGIX");
            _glXQueryGLXPbufferSGIX_fnptr(dpy, pbuf, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int, void*, int> _glXQueryHyperpipeAttribSGIX_fnptr = &glXQueryHyperpipeAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryHyperpipeAttribSGIX_Lazy(ulong* dpy, int timeSlice, int attrib, int size, void* returnAttribList)
        {
            _glXQueryHyperpipeAttribSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, int, void*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeAttribSGIX");
            return _glXQueryHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, returnAttribList);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int, void*, void*, int> _glXQueryHyperpipeBestAttribSGIX_fnptr = &glXQueryHyperpipeBestAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryHyperpipeBestAttribSGIX_Lazy(ulong* dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList)
        {
            _glXQueryHyperpipeBestAttribSGIX_fnptr = (delegate* unmanaged<ulong*, int, int, int, void*, void*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeBestAttribSGIX");
            return _glXQueryHyperpipeBestAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList, returnAttribList);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, GLXHyperpipeConfigSGIX*> _glXQueryHyperpipeConfigSGIX_fnptr = &glXQueryHyperpipeConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static GLXHyperpipeConfigSGIX* glXQueryHyperpipeConfigSGIX_Lazy(ulong* dpy, int hpId, int* npipes)
        {
            _glXQueryHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<ulong*, int, int*, GLXHyperpipeConfigSGIX*>)GLLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeConfigSGIX");
            return _glXQueryHyperpipeConfigSGIX_fnptr(dpy, hpId, npipes);
        }
        
        internal static delegate* unmanaged<ulong*, int*, GLXHyperpipeNetworkSGIX*> _glXQueryHyperpipeNetworkSGIX_fnptr = &glXQueryHyperpipeNetworkSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static GLXHyperpipeNetworkSGIX* glXQueryHyperpipeNetworkSGIX_Lazy(ulong* dpy, int* npipes)
        {
            _glXQueryHyperpipeNetworkSGIX_fnptr = (delegate* unmanaged<ulong*, int*, GLXHyperpipeNetworkSGIX*>)GLLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeNetworkSGIX");
            return _glXQueryHyperpipeNetworkSGIX_fnptr(dpy, npipes);
        }
        
        internal static delegate* unmanaged<ulong*, int, int*, byte> _glXQueryMaxSwapBarriersSGIX_fnptr = &glXQueryMaxSwapBarriersSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryMaxSwapBarriersSGIX_Lazy(ulong* dpy, int screen, int* max)
        {
            _glXQueryMaxSwapBarriersSGIX_fnptr = (delegate* unmanaged<ulong*, int, int*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryMaxSwapBarriersSGIX");
            return _glXQueryMaxSwapBarriersSGIX_fnptr(dpy, screen, max);
        }
        
        internal static delegate* unmanaged<ulong*, int, uint*, uint*, byte> _glXQueryMaxSwapGroupsNV_fnptr = &glXQueryMaxSwapGroupsNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryMaxSwapGroupsNV_Lazy(ulong* dpy, int screen, uint* maxGroups, uint* maxBarriers)
        {
            _glXQueryMaxSwapGroupsNV_fnptr = (delegate* unmanaged<ulong*, int, uint*, uint*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryMaxSwapGroupsNV");
            return _glXQueryMaxSwapGroupsNV_fnptr(dpy, screen, maxGroups, maxBarriers);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int, uint*, byte> _glXQueryRendererIntegerMESA_fnptr = &glXQueryRendererIntegerMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryRendererIntegerMESA_Lazy(ulong* dpy, int screen, int renderer, int attribute, uint* value)
        {
            _glXQueryRendererIntegerMESA_fnptr = (delegate* unmanaged<ulong*, int, int, int, uint*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryRendererIntegerMESA");
            return _glXQueryRendererIntegerMESA_fnptr(dpy, screen, renderer, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, int, byte*> _glXQueryRendererStringMESA_fnptr = &glXQueryRendererStringMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryRendererStringMESA_Lazy(ulong* dpy, int screen, int renderer, int attribute)
        {
            _glXQueryRendererStringMESA_fnptr = (delegate* unmanaged<ulong*, int, int, int, byte*>)GLLoader.BindingsContext.GetProcAddress("glXQueryRendererStringMESA");
            return _glXQueryRendererStringMESA_fnptr(dpy, screen, renderer, attribute);
        }
        
        internal static delegate* unmanaged<ulong*, int, int, byte*> _glXQueryServerString_fnptr = &glXQueryServerString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryServerString_Lazy(ulong* dpy, int screen, int name)
        {
            _glXQueryServerString_fnptr = (delegate* unmanaged<ulong*, int, int, byte*>)GLLoader.BindingsContext.GetProcAddress("glXQueryServerString");
            return _glXQueryServerString_fnptr(dpy, screen, name);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, uint*, uint*, byte> _glXQuerySwapGroupNV_fnptr = &glXQuerySwapGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQuerySwapGroupNV_Lazy(ulong* dpy, ulong drawable, uint* group, uint* barrier)
        {
            _glXQuerySwapGroupNV_fnptr = (delegate* unmanaged<ulong*, ulong, uint*, uint*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQuerySwapGroupNV");
            return _glXQuerySwapGroupNV_fnptr(dpy, drawable, group, barrier);
        }
        
        internal static delegate* unmanaged<ulong*, int*, int*, byte> _glXQueryVersion_fnptr = &glXQueryVersion_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryVersion_Lazy(ulong* dpy, int* maj, int* min)
        {
            _glXQueryVersion_fnptr = (delegate* unmanaged<ulong*, int*, int*, byte>)GLLoader.BindingsContext.GetProcAddress("glXQueryVersion");
            return _glXQueryVersion_fnptr(dpy, maj, min);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, int*, int> _glXQueryVideoCaptureDeviceNV_fnptr = &glXQueryVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryVideoCaptureDeviceNV_Lazy(ulong* dpy, ulong device, int attribute, int* value)
        {
            _glXQueryVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<ulong*, ulong, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("glXQueryVideoCaptureDeviceNV");
            return _glXQueryVideoCaptureDeviceNV_fnptr(dpy, device, attribute, value);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, byte> _glXReleaseBuffersMESA_fnptr = &glXReleaseBuffersMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXReleaseBuffersMESA_Lazy(ulong* dpy, ulong drawable)
        {
            _glXReleaseBuffersMESA_fnptr = (delegate* unmanaged<ulong*, ulong, byte>)GLLoader.BindingsContext.GetProcAddress("glXReleaseBuffersMESA");
            return _glXReleaseBuffersMESA_fnptr(dpy, drawable);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, void> _glXReleaseTexImageEXT_fnptr = &glXReleaseTexImageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXReleaseTexImageEXT_Lazy(ulong* dpy, ulong drawable, int buffer)
        {
            _glXReleaseTexImageEXT_fnptr = (delegate* unmanaged<ulong*, ulong, int, void>)GLLoader.BindingsContext.GetProcAddress("glXReleaseTexImageEXT");
            _glXReleaseTexImageEXT_fnptr(dpy, drawable, buffer);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXReleaseVideoCaptureDeviceNV_fnptr = &glXReleaseVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXReleaseVideoCaptureDeviceNV_Lazy(ulong* dpy, ulong device)
        {
            _glXReleaseVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXReleaseVideoCaptureDeviceNV");
            _glXReleaseVideoCaptureDeviceNV_fnptr(dpy, device);
        }
        
        internal static delegate* unmanaged<ulong*, int, uint, int> _glXReleaseVideoDeviceNV_fnptr = &glXReleaseVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXReleaseVideoDeviceNV_Lazy(ulong* dpy, int screen, uint VideoDevice)
        {
            _glXReleaseVideoDeviceNV_fnptr = (delegate* unmanaged<ulong*, int, uint, int>)GLLoader.BindingsContext.GetProcAddress("glXReleaseVideoDeviceNV");
            return _glXReleaseVideoDeviceNV_fnptr(dpy, screen, VideoDevice);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int> _glXReleaseVideoImageNV_fnptr = &glXReleaseVideoImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXReleaseVideoImageNV_Lazy(ulong* dpy, ulong pbuf)
        {
            _glXReleaseVideoImageNV_fnptr = (delegate* unmanaged<ulong*, ulong, int>)GLLoader.BindingsContext.GetProcAddress("glXReleaseVideoImageNV");
            return _glXReleaseVideoImageNV_fnptr(dpy, pbuf);
        }
        
        internal static delegate* unmanaged<ulong*, int, byte> _glXResetFrameCountNV_fnptr = &glXResetFrameCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXResetFrameCountNV_Lazy(ulong* dpy, int screen)
        {
            _glXResetFrameCountNV_fnptr = (delegate* unmanaged<ulong*, int, byte>)GLLoader.BindingsContext.GetProcAddress("glXResetFrameCountNV");
            return _glXResetFrameCountNV_fnptr(dpy, screen);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong, void> _glXSelectEvent_fnptr = &glXSelectEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSelectEvent_Lazy(ulong* dpy, ulong draw, ulong event_mask)
        {
            _glXSelectEvent_fnptr = (delegate* unmanaged<ulong*, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXSelectEvent");
            _glXSelectEvent_fnptr(dpy, draw, event_mask);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, ulong, void> _glXSelectEventSGIX_fnptr = &glXSelectEventSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSelectEventSGIX_Lazy(ulong* dpy, ulong drawable, ulong mask)
        {
            _glXSelectEventSGIX_fnptr = (delegate* unmanaged<ulong*, ulong, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXSelectEventSGIX");
            _glXSelectEventSGIX_fnptr(dpy, drawable, mask);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, ulong*, byte, int> _glXSendPbufferToVideoNV_fnptr = &glXSendPbufferToVideoNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXSendPbufferToVideoNV_Lazy(ulong* dpy, ulong pbuf, int iBufferType, ulong* pulCounterPbuffer, byte bBlock)
        {
            _glXSendPbufferToVideoNV_fnptr = (delegate* unmanaged<ulong*, ulong, int, ulong*, byte, int>)GLLoader.BindingsContext.GetProcAddress("glXSendPbufferToVideoNV");
            return _glXSendPbufferToVideoNV_fnptr(dpy, pbuf, iBufferType, pulCounterPbuffer, bBlock);
        }
        
        internal static delegate* unmanaged<int, byte> _glXSet3DfxModeMESA_fnptr = &glXSet3DfxModeMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXSet3DfxModeMESA_Lazy(int mode)
        {
            _glXSet3DfxModeMESA_fnptr = (delegate* unmanaged<int, byte>)GLLoader.BindingsContext.GetProcAddress("glXSet3DfxModeMESA");
            return _glXSet3DfxModeMESA_fnptr(mode);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, void> _glXSwapBuffers_fnptr = &glXSwapBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSwapBuffers_Lazy(ulong* dpy, ulong drawable)
        {
            _glXSwapBuffers_fnptr = (delegate* unmanaged<ulong*, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glXSwapBuffers");
            _glXSwapBuffers_fnptr(dpy, drawable);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, long, long, long, long> _glXSwapBuffersMscOML_fnptr = &glXSwapBuffersMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static long glXSwapBuffersMscOML_Lazy(ulong* dpy, ulong drawable, long target_msc, long divisor, long remainder)
        {
            _glXSwapBuffersMscOML_fnptr = (delegate* unmanaged<ulong*, ulong, long, long, long, long>)GLLoader.BindingsContext.GetProcAddress("glXSwapBuffersMscOML");
            return _glXSwapBuffersMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder);
        }
        
        internal static delegate* unmanaged<uint, int> _glXSwapIntervalMESA_fnptr = &glXSwapIntervalMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int glXSwapIntervalMESA_Lazy(uint interval)
        {
            _glXSwapIntervalMESA_fnptr = (delegate* unmanaged<uint, int>)GLLoader.BindingsContext.GetProcAddress("glXSwapIntervalMESA");
            return _glXSwapIntervalMESA_fnptr(interval);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, int, void> _glXSwapIntervalEXT_fnptr = &glXSwapIntervalEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSwapIntervalEXT_Lazy(ulong* dpy, ulong drawable, int interval)
        {
            _glXSwapIntervalEXT_fnptr = (delegate* unmanaged<ulong*, ulong, int, void>)GLLoader.BindingsContext.GetProcAddress("glXSwapIntervalEXT");
            _glXSwapIntervalEXT_fnptr(dpy, drawable, interval);
        }
        
        internal static delegate* unmanaged<int, int> _glXSwapIntervalSGI_fnptr = &glXSwapIntervalSGI_Lazy;
        [UnmanagedCallersOnly]
        private static int glXSwapIntervalSGI_Lazy(int interval)
        {
            _glXSwapIntervalSGI_fnptr = (delegate* unmanaged<int, int>)GLLoader.BindingsContext.GetProcAddress("glXSwapIntervalSGI");
            return _glXSwapIntervalSGI_fnptr(interval);
        }
        
        internal static delegate* unmanaged<ulong, int, int, int, void> _glXUseXFont_fnptr = &glXUseXFont_Lazy;
        [UnmanagedCallersOnly]
        private static void glXUseXFont_Lazy(ulong font, int first, int count, int list)
        {
            _glXUseXFont_fnptr = (delegate* unmanaged<ulong, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glXUseXFont");
            _glXUseXFont_fnptr(font, first, count, list);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, long, long, long, long*, long*, long*, byte> _glXWaitForMscOML_fnptr = &glXWaitForMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXWaitForMscOML_Lazy(ulong* dpy, ulong drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc)
        {
            _glXWaitForMscOML_fnptr = (delegate* unmanaged<ulong*, ulong, long, long, long, long*, long*, long*, byte>)GLLoader.BindingsContext.GetProcAddress("glXWaitForMscOML");
            return _glXWaitForMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder, ust, msc, sbc);
        }
        
        internal static delegate* unmanaged<ulong*, ulong, long, long*, long*, long*, byte> _glXWaitForSbcOML_fnptr = &glXWaitForSbcOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXWaitForSbcOML_Lazy(ulong* dpy, ulong drawable, long target_sbc, long* ust, long* msc, long* sbc)
        {
            _glXWaitForSbcOML_fnptr = (delegate* unmanaged<ulong*, ulong, long, long*, long*, long*, byte>)GLLoader.BindingsContext.GetProcAddress("glXWaitForSbcOML");
            return _glXWaitForSbcOML_fnptr(dpy, drawable, target_sbc, ust, msc, sbc);
        }
        
        internal static delegate* unmanaged<void> _glXWaitGL_fnptr = &glXWaitGL_Lazy;
        [UnmanagedCallersOnly]
        private static void glXWaitGL_Lazy()
        {
            _glXWaitGL_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glXWaitGL");
            _glXWaitGL_fnptr();
        }
        
        internal static delegate* unmanaged<int, int, uint*, int> _glXWaitVideoSyncSGI_fnptr = &glXWaitVideoSyncSGI_Lazy;
        [UnmanagedCallersOnly]
        private static int glXWaitVideoSyncSGI_Lazy(int divisor, int remainder, uint* count)
        {
            _glXWaitVideoSyncSGI_fnptr = (delegate* unmanaged<int, int, uint*, int>)GLLoader.BindingsContext.GetProcAddress("glXWaitVideoSyncSGI");
            return _glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
        }
        
        internal static delegate* unmanaged<void> _glXWaitX_fnptr = &glXWaitX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXWaitX_Lazy()
        {
            _glXWaitX_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glXWaitX");
            _glXWaitX_fnptr();
        }
        
    }
}
