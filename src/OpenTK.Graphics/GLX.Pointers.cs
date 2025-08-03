// This file is auto generated, do not edit. Generated: 2025-08-04 00:00:45 GMT+02:00
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    /// <summary>A collection of all function pointers to all OpenGL entry points.</summary>
    public static unsafe partial class GlxPointers
    {
        /// <summary><b>[entry point: <c>glXBindChannelToWindowSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, nuint, int> _glXBindChannelToWindowSGIX_fnptr = &glXBindChannelToWindowSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindChannelToWindowSGIX_Lazy(IntPtr display, int screen, int channel, nuint window)
        {
            _glXBindChannelToWindowSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, nuint, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindChannelToWindowSGIX");
            return _glXBindChannelToWindowSGIX_fnptr(display, screen, channel, window);
        }
        
        /// <summary><b>[entry point: <c>glXBindHyperpipeSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _glXBindHyperpipeSGIX_fnptr = &glXBindHyperpipeSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindHyperpipeSGIX_Lazy(IntPtr dpy, int hpId)
        {
            _glXBindHyperpipeSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindHyperpipeSGIX");
            return _glXBindHyperpipeSGIX_fnptr(dpy, hpId);
        }
        
        /// <summary><b>[entry point: <c>glXBindSwapBarrierNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, byte> _glXBindSwapBarrierNV_fnptr = &glXBindSwapBarrierNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXBindSwapBarrierNV_Lazy(IntPtr dpy, uint group, uint barrier)
        {
            _glXBindSwapBarrierNV_fnptr = (delegate* unmanaged<IntPtr, uint, uint, byte>)GLXLoader.BindingsContext.GetProcAddress("glXBindSwapBarrierNV");
            return _glXBindSwapBarrierNV_fnptr(dpy, group, barrier);
        }
        
        /// <summary><b>[entry point: <c>glXBindSwapBarrierSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, void> _glXBindSwapBarrierSGIX_fnptr = &glXBindSwapBarrierSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXBindSwapBarrierSGIX_Lazy(IntPtr dpy, nuint drawable, int barrier)
        {
            _glXBindSwapBarrierSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXBindSwapBarrierSGIX");
            _glXBindSwapBarrierSGIX_fnptr(dpy, drawable, barrier);
        }
        
        /// <summary><b>[entry point: <c>glXBindTexImageEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, int*, void> _glXBindTexImageEXT_fnptr = &glXBindTexImageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXBindTexImageEXT_Lazy(IntPtr dpy, nuint drawable, int buffer, int* attrib_list)
        {
            _glXBindTexImageEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, int, int*, void>)GLXLoader.BindingsContext.GetProcAddress("glXBindTexImageEXT");
            _glXBindTexImageEXT_fnptr(dpy, drawable, buffer, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXBindVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, int> _glXBindVideoCaptureDeviceNV_fnptr = &glXBindVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindVideoCaptureDeviceNV_Lazy(IntPtr dpy, uint video_capture_slot, nuint device)
        {
            _glXBindVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindVideoCaptureDeviceNV");
            return _glXBindVideoCaptureDeviceNV_fnptr(dpy, video_capture_slot, device);
        }
        
        /// <summary><b>[entry point: <c>glXBindVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, int*, int> _glXBindVideoDeviceNV_fnptr = &glXBindVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindVideoDeviceNV_Lazy(IntPtr dpy, uint video_slot, uint video_device, int* attrib_list)
        {
            _glXBindVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, uint, uint, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindVideoDeviceNV");
            return _glXBindVideoDeviceNV_fnptr(dpy, video_slot, video_device, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXBindVideoImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, int, int> _glXBindVideoImageNV_fnptr = &glXBindVideoImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXBindVideoImageNV_Lazy(IntPtr dpy, uint VideoDevice, nuint pbuf, int iVideoBuffer)
        {
            _glXBindVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindVideoImageNV");
            return _glXBindVideoImageNV_fnptr(dpy, VideoDevice, pbuf, iVideoBuffer);
        }
        
        /// <summary><b>[entry point: <c>glXBlitContextFramebufferAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void> _glXBlitContextFramebufferAMD_fnptr = &glXBlitContextFramebufferAMD_Lazy;
        [UnmanagedCallersOnly]
        private static void glXBlitContextFramebufferAMD_Lazy(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
        {
            _glXBlitContextFramebufferAMD_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void>)GLXLoader.BindingsContext.GetProcAddress("glXBlitContextFramebufferAMD");
            _glXBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        /// <summary><b>[entry point: <c>glXChannelRectSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int> _glXChannelRectSGIX_fnptr = &glXChannelRectSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXChannelRectSGIX_Lazy(IntPtr display, int screen, int channel, int x, int y, int w, int h)
        {
            _glXChannelRectSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXChannelRectSGIX");
            return _glXChannelRectSGIX_fnptr(display, screen, channel, x, y, w, h);
        }
        
        /// <summary><b>[entry point: <c>glXChannelRectSyncSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int> _glXChannelRectSyncSGIX_fnptr = &glXChannelRectSyncSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXChannelRectSyncSGIX_Lazy(IntPtr display, int screen, int channel, uint synctype)
        {
            _glXChannelRectSyncSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int>)GLXLoader.BindingsContext.GetProcAddress("glXChannelRectSyncSGIX");
            return _glXChannelRectSyncSGIX_fnptr(display, screen, channel, synctype);
        }
        
        /// <summary><b>[entry point: <c>glXChooseFBConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*> _glXChooseFBConfig_fnptr = &glXChooseFBConfig_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr* glXChooseFBConfig_Lazy(IntPtr dpy, int screen, int* attrib_list, int* nelements)
        {
            _glXChooseFBConfig_fnptr = (delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*>)GLXLoader.BindingsContext.GetProcAddress("glXChooseFBConfig");
            return _glXChooseFBConfig_fnptr(dpy, screen, attrib_list, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXChooseFBConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*> _glXChooseFBConfigSGIX_fnptr = &glXChooseFBConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr* glXChooseFBConfigSGIX_Lazy(IntPtr dpy, int screen, int* attrib_list, int* nelements)
        {
            _glXChooseFBConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*>)GLXLoader.BindingsContext.GetProcAddress("glXChooseFBConfigSGIX");
            return _glXChooseFBConfigSGIX_fnptr(dpy, screen, attrib_list, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXChooseVisual</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, IntPtr> _glXChooseVisual_fnptr = &glXChooseVisual_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXChooseVisual_Lazy(IntPtr dpy, int screen, int* attribList)
        {
            _glXChooseVisual_fnptr = (delegate* unmanaged<IntPtr, int, int*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXChooseVisual");
            return _glXChooseVisual_fnptr(dpy, screen, attribList);
        }
        
        /// <summary><b>[entry point: <c>glXCopyBufferSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void> _glXCopyBufferSubDataNV_fnptr = &glXCopyBufferSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopyBufferSubDataNV_Lazy(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            _glXCopyBufferSubDataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopyBufferSubDataNV");
            _glXCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
        }
        
        /// <summary><b>[entry point: <c>glXCopyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, ulong, void> _glXCopyContext_fnptr = &glXCopyContext_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopyContext_Lazy(IntPtr dpy, IntPtr src, IntPtr dst, ulong mask)
        {
            _glXCopyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, ulong, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopyContext");
            _glXCopyContext_fnptr(dpy, src, dst, mask);
        }
        
        /// <summary><b>[entry point: <c>glXCopyImageSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, void> _glXCopyImageSubDataNV_fnptr = &glXCopyImageSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopyImageSubDataNV_Lazy(IntPtr dpy, IntPtr srcCtx, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr dstCtx, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
        {
            _glXCopyImageSubDataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopyImageSubDataNV");
            _glXCopyImageSubDataNV_fnptr(dpy, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
        }
        
        /// <summary><b>[entry point: <c>glXCopySubBufferMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, int, int, int, void> _glXCopySubBufferMESA_fnptr = &glXCopySubBufferMESA_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCopySubBufferMESA_Lazy(IntPtr dpy, nuint drawable, int x, int y, int width, int height)
        {
            _glXCopySubBufferMESA_fnptr = (delegate* unmanaged<IntPtr, nuint, int, int, int, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopySubBufferMESA");
            _glXCopySubBufferMESA_fnptr(dpy, drawable, x, y, width, height);
        }
        
        /// <summary><b>[entry point: <c>glXCreateAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, IntPtr> _glXCreateAssociatedContextAMD_fnptr = &glXCreateAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXCreateAssociatedContextAMD_Lazy(uint id, IntPtr share_list)
        {
            _glXCreateAssociatedContextAMD_fnptr = (delegate* unmanaged<uint, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateAssociatedContextAMD");
            return _glXCreateAssociatedContextAMD_fnptr(id, share_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateAssociatedContextAttribsAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, int*, IntPtr> _glXCreateAssociatedContextAttribsAMD_fnptr = &glXCreateAssociatedContextAttribsAMD_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXCreateAssociatedContextAttribsAMD_Lazy(uint id, IntPtr share_context, int* attribList)
        {
            _glXCreateAssociatedContextAttribsAMD_fnptr = (delegate* unmanaged<uint, IntPtr, int*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateAssociatedContextAttribsAMD");
            return _glXCreateAssociatedContextAttribsAMD_fnptr(id, share_context, attribList);
        }
        
        /// <summary><b>[entry point: <c>glXCreateContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, IntPtr> _glXCreateContext_fnptr = &glXCreateContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXCreateContext_Lazy(IntPtr dpy, IntPtr vis, IntPtr shareList, byte direct)
        {
            _glXCreateContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateContext");
            return _glXCreateContext_fnptr(dpy, vis, shareList, direct);
        }
        
        /// <summary><b>[entry point: <c>glXCreateContextAttribsARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, int*, IntPtr> _glXCreateContextAttribsARB_fnptr = &glXCreateContextAttribsARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXCreateContextAttribsARB_Lazy(IntPtr dpy, IntPtr config, IntPtr share_context, byte direct, int* attrib_list)
        {
            _glXCreateContextAttribsARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, int*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateContextAttribsARB");
            return _glXCreateContextAttribsARB_fnptr(dpy, config, share_context, direct, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateContextWithConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr> _glXCreateContextWithConfigSGIX_fnptr = &glXCreateContextWithConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXCreateContextWithConfigSGIX_Lazy(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, byte direct)
        {
            _glXCreateContextWithConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateContextWithConfigSGIX");
            return _glXCreateContextWithConfigSGIX_fnptr(dpy, config, render_type, share_list, direct);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPbufferSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, uint, int*, nuint> _glXCreateGLXPbufferSGIX_fnptr = &glXCreateGLXPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreateGLXPbufferSGIX_Lazy(IntPtr dpy, IntPtr config, uint width, uint height, int* attrib_list)
        {
            _glXCreateGLXPbufferSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, uint, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPbufferSGIX");
            return _glXCreateGLXPbufferSGIX_fnptr(dpy, config, width, height, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, nuint> _glXCreateGLXPixmap_fnptr = &glXCreateGLXPixmap_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreateGLXPixmap_Lazy(IntPtr dpy, IntPtr visual, nuint pixmap)
        {
            _glXCreateGLXPixmap_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmap");
            return _glXCreateGLXPixmap_fnptr(dpy, visual, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPixmapMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, nuint, nuint> _glXCreateGLXPixmapMESA_fnptr = &glXCreateGLXPixmapMESA_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreateGLXPixmapMESA_Lazy(IntPtr dpy, IntPtr visual, nuint pixmap, nuint cmap)
        {
            _glXCreateGLXPixmapMESA_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, nuint, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmapMESA");
            return _glXCreateGLXPixmapMESA_fnptr(dpy, visual, pixmap, cmap);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPixmapWithConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, nuint> _glXCreateGLXPixmapWithConfigSGIX_fnptr = &glXCreateGLXPixmapWithConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreateGLXPixmapWithConfigSGIX_Lazy(IntPtr dpy, IntPtr config, nuint pixmap)
        {
            _glXCreateGLXPixmapWithConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmapWithConfigSGIX");
            return _glXCreateGLXPixmapWithConfigSGIX_fnptr(dpy, config, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXCreateNewContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr> _glXCreateNewContext_fnptr = &glXCreateNewContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXCreateNewContext_Lazy(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, byte direct)
        {
            _glXCreateNewContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateNewContext");
            return _glXCreateNewContext_fnptr(dpy, config, render_type, share_list, direct);
        }
        
        /// <summary><b>[entry point: <c>glXCreatePbuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, nuint> _glXCreatePbuffer_fnptr = &glXCreatePbuffer_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreatePbuffer_Lazy(IntPtr dpy, IntPtr config, int* attrib_list)
        {
            _glXCreatePbuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreatePbuffer");
            return _glXCreatePbuffer_fnptr(dpy, config, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreatePixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint> _glXCreatePixmap_fnptr = &glXCreatePixmap_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreatePixmap_Lazy(IntPtr dpy, IntPtr config, nuint pixmap, int* attrib_list)
        {
            _glXCreatePixmap_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreatePixmap");
            return _glXCreatePixmap_fnptr(dpy, config, pixmap, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateWindow</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint> _glXCreateWindow_fnptr = &glXCreateWindow_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXCreateWindow_Lazy(IntPtr dpy, IntPtr config, nuint win, int* attrib_list)
        {
            _glXCreateWindow_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateWindow");
            return _glXCreateWindow_fnptr(dpy, config, win, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCushionSGI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, float, void> _glXCushionSGI_fnptr = &glXCushionSGI_Lazy;
        [UnmanagedCallersOnly]
        private static void glXCushionSGI_Lazy(IntPtr dpy, nuint window, float cushion)
        {
            _glXCushionSGI_fnptr = (delegate* unmanaged<IntPtr, nuint, float, void>)GLXLoader.BindingsContext.GetProcAddress("glXCushionSGI");
            _glXCushionSGI_fnptr(dpy, window, cushion);
        }
        
        /// <summary><b>[entry point: <c>glXDelayBeforeSwapNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, float, byte> _glXDelayBeforeSwapNV_fnptr = &glXDelayBeforeSwapNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXDelayBeforeSwapNV_Lazy(IntPtr dpy, nuint drawable, float seconds)
        {
            _glXDelayBeforeSwapNV_fnptr = (delegate* unmanaged<IntPtr, nuint, float, byte>)GLXLoader.BindingsContext.GetProcAddress("glXDelayBeforeSwapNV");
            return _glXDelayBeforeSwapNV_fnptr(dpy, drawable, seconds);
        }
        
        /// <summary><b>[entry point: <c>glXDeleteAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _glXDeleteAssociatedContextAMD_fnptr = &glXDeleteAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXDeleteAssociatedContextAMD_Lazy(IntPtr ctx)
        {
            _glXDeleteAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXDeleteAssociatedContextAMD");
            return _glXDeleteAssociatedContextAMD_fnptr(ctx);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _glXDestroyContext_fnptr = &glXDestroyContext_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyContext_Lazy(IntPtr dpy, IntPtr ctx)
        {
            _glXDestroyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyContext");
            _glXDestroyContext_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyGLXPbufferSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyGLXPbufferSGIX_fnptr = &glXDestroyGLXPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyGLXPbufferSGIX_Lazy(IntPtr dpy, nuint pbuf)
        {
            _glXDestroyGLXPbufferSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyGLXPbufferSGIX");
            _glXDestroyGLXPbufferSGIX_fnptr(dpy, pbuf);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyGLXPixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyGLXPixmap_fnptr = &glXDestroyGLXPixmap_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyGLXPixmap_Lazy(IntPtr dpy, nuint pixmap)
        {
            _glXDestroyGLXPixmap_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyGLXPixmap");
            _glXDestroyGLXPixmap_fnptr(dpy, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyHyperpipeConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _glXDestroyHyperpipeConfigSGIX_fnptr = &glXDestroyHyperpipeConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXDestroyHyperpipeConfigSGIX_Lazy(IntPtr dpy, int hpId)
        {
            _glXDestroyHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyHyperpipeConfigSGIX");
            return _glXDestroyHyperpipeConfigSGIX_fnptr(dpy, hpId);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyPbuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyPbuffer_fnptr = &glXDestroyPbuffer_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyPbuffer_Lazy(IntPtr dpy, nuint pbuf)
        {
            _glXDestroyPbuffer_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyPbuffer");
            _glXDestroyPbuffer_fnptr(dpy, pbuf);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyPixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyPixmap_fnptr = &glXDestroyPixmap_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyPixmap_Lazy(IntPtr dpy, nuint pixmap)
        {
            _glXDestroyPixmap_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyPixmap");
            _glXDestroyPixmap_fnptr(dpy, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyWindow</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyWindow_fnptr = &glXDestroyWindow_Lazy;
        [UnmanagedCallersOnly]
        private static void glXDestroyWindow_Lazy(IntPtr dpy, nuint win)
        {
            _glXDestroyWindow_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyWindow");
            _glXDestroyWindow_fnptr(dpy, win);
        }
        
        /// <summary><b>[entry point: <c>glXEnumerateVideoCaptureDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, nuint*> _glXEnumerateVideoCaptureDevicesNV_fnptr = &glXEnumerateVideoCaptureDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static nuint* glXEnumerateVideoCaptureDevicesNV_Lazy(IntPtr dpy, int screen, int* nelements)
        {
            _glXEnumerateVideoCaptureDevicesNV_fnptr = (delegate* unmanaged<IntPtr, int, int*, nuint*>)GLXLoader.BindingsContext.GetProcAddress("glXEnumerateVideoCaptureDevicesNV");
            return _glXEnumerateVideoCaptureDevicesNV_fnptr(dpy, screen, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXEnumerateVideoDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, uint*> _glXEnumerateVideoDevicesNV_fnptr = &glXEnumerateVideoDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static uint* glXEnumerateVideoDevicesNV_Lazy(IntPtr dpy, int screen, int* nelements)
        {
            _glXEnumerateVideoDevicesNV_fnptr = (delegate* unmanaged<IntPtr, int, int*, uint*>)GLXLoader.BindingsContext.GetProcAddress("glXEnumerateVideoDevicesNV");
            return _glXEnumerateVideoDevicesNV_fnptr(dpy, screen, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXFreeContextEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _glXFreeContextEXT_fnptr = &glXFreeContextEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXFreeContextEXT_Lazy(IntPtr dpy, IntPtr context)
        {
            _glXFreeContextEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)GLXLoader.BindingsContext.GetProcAddress("glXFreeContextEXT");
            _glXFreeContextEXT_fnptr(dpy, context);
        }
        
        /// <summary><b>[entry point: <c>glXGetAGPOffsetMESA</c>]</b></summary>
        public static delegate* unmanaged<void*, uint> _glXGetAGPOffsetMESA_fnptr = &glXGetAGPOffsetMESA_Lazy;
        [UnmanagedCallersOnly]
        private static uint glXGetAGPOffsetMESA_Lazy(void* pointer)
        {
            _glXGetAGPOffsetMESA_fnptr = (delegate* unmanaged<void*, uint>)GLXLoader.BindingsContext.GetProcAddress("glXGetAGPOffsetMESA");
            return _glXGetAGPOffsetMESA_fnptr(pointer);
        }
        
        /// <summary><b>[entry point: <c>glXGetClientString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _glXGetClientString_fnptr = &glXGetClientString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXGetClientString_Lazy(IntPtr dpy, int name)
        {
            _glXGetClientString_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXGetClientString");
            return _glXGetClientString_fnptr(dpy, name);
        }
        
        /// <summary><b>[entry point: <c>glXGetConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXGetConfig_fnptr = &glXGetConfig_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetConfig_Lazy(IntPtr dpy, IntPtr visual, int attrib, int* value)
        {
            _glXGetConfig_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetConfig");
            return _glXGetConfig_fnptr(dpy, visual, attrib, value);
        }
        
        /// <summary><b>[entry point: <c>glXGetContextGPUIDAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint> _glXGetContextGPUIDAMD_fnptr = &glXGetContextGPUIDAMD_Lazy;
        [UnmanagedCallersOnly]
        private static uint glXGetContextGPUIDAMD_Lazy(IntPtr ctx)
        {
            _glXGetContextGPUIDAMD_fnptr = (delegate* unmanaged<IntPtr, uint>)GLXLoader.BindingsContext.GetProcAddress("glXGetContextGPUIDAMD");
            return _glXGetContextGPUIDAMD_fnptr(ctx);
        }
        
        /// <summary><b>[entry point: <c>glXGetContextIDEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint> _glXGetContextIDEXT_fnptr = &glXGetContextIDEXT_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXGetContextIDEXT_Lazy(IntPtr context)
        {
            _glXGetContextIDEXT_fnptr = (delegate* unmanaged<IntPtr, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetContextIDEXT");
            return _glXGetContextIDEXT_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentAssociatedContextAMD_fnptr = &glXGetCurrentAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetCurrentAssociatedContextAMD_Lazy()
        {
            _glXGetCurrentAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentAssociatedContextAMD");
            return _glXGetCurrentAssociatedContextAMD_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentContext_fnptr = &glXGetCurrentContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetCurrentContext_Lazy()
        {
            _glXGetCurrentContext_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentContext");
            return _glXGetCurrentContext_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentDisplay</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentDisplay_fnptr = &glXGetCurrentDisplay_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetCurrentDisplay_Lazy()
        {
            _glXGetCurrentDisplay_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentDisplay");
            return _glXGetCurrentDisplay_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentDisplayEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentDisplayEXT_fnptr = &glXGetCurrentDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetCurrentDisplayEXT_Lazy()
        {
            _glXGetCurrentDisplayEXT_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentDisplayEXT");
            return _glXGetCurrentDisplayEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentDrawable</c>]</b></summary>
        public static delegate* unmanaged<nuint> _glXGetCurrentDrawable_fnptr = &glXGetCurrentDrawable_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXGetCurrentDrawable_Lazy()
        {
            _glXGetCurrentDrawable_fnptr = (delegate* unmanaged<nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentDrawable");
            return _glXGetCurrentDrawable_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentReadDrawable</c>]</b></summary>
        public static delegate* unmanaged<nuint> _glXGetCurrentReadDrawable_fnptr = &glXGetCurrentReadDrawable_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXGetCurrentReadDrawable_Lazy()
        {
            _glXGetCurrentReadDrawable_fnptr = (delegate* unmanaged<nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentReadDrawable");
            return _glXGetCurrentReadDrawable_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentReadDrawableSGI</c>]</b></summary>
        public static delegate* unmanaged<nuint> _glXGetCurrentReadDrawableSGI_fnptr = &glXGetCurrentReadDrawableSGI_Lazy;
        [UnmanagedCallersOnly]
        private static nuint glXGetCurrentReadDrawableSGI_Lazy()
        {
            _glXGetCurrentReadDrawableSGI_fnptr = (delegate* unmanaged<nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentReadDrawableSGI");
            return _glXGetCurrentReadDrawableSGI_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigAttrib</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXGetFBConfigAttrib_fnptr = &glXGetFBConfigAttrib_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetFBConfigAttrib_Lazy(IntPtr dpy, IntPtr config, int attribute, int* value)
        {
            _glXGetFBConfigAttrib_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigAttrib");
            return _glXGetFBConfigAttrib_fnptr(dpy, config, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXGetFBConfigAttribSGIX_fnptr = &glXGetFBConfigAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetFBConfigAttribSGIX_Lazy(IntPtr dpy, IntPtr config, int attribute, int* value)
        {
            _glXGetFBConfigAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigAttribSGIX");
            return _glXGetFBConfigAttribSGIX_fnptr(dpy, config, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigFromVisualSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr> _glXGetFBConfigFromVisualSGIX_fnptr = &glXGetFBConfigFromVisualSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetFBConfigFromVisualSGIX_Lazy(IntPtr dpy, IntPtr vis)
        {
            _glXGetFBConfigFromVisualSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigFromVisualSGIX");
            return _glXGetFBConfigFromVisualSGIX_fnptr(dpy, vis);
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigs</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, IntPtr*> _glXGetFBConfigs_fnptr = &glXGetFBConfigs_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr* glXGetFBConfigs_Lazy(IntPtr dpy, int screen, int* nelements)
        {
            _glXGetFBConfigs_fnptr = (delegate* unmanaged<IntPtr, int, int*, IntPtr*>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigs");
            return _glXGetFBConfigs_fnptr(dpy, screen, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXGetGPUIDsAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, uint*, uint> _glXGetGPUIDsAMD_fnptr = &glXGetGPUIDsAMD_Lazy;
        [UnmanagedCallersOnly]
        private static uint glXGetGPUIDsAMD_Lazy(uint maxCount, uint* ids)
        {
            _glXGetGPUIDsAMD_fnptr = (delegate* unmanaged<uint, uint*, uint>)GLXLoader.BindingsContext.GetProcAddress("glXGetGPUIDsAMD");
            return _glXGetGPUIDsAMD_fnptr(maxCount, ids);
        }
        
        /// <summary><b>[entry point: <c>glXGetGPUInfoAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, int, uint, uint, void*, int> _glXGetGPUInfoAMD_fnptr = &glXGetGPUInfoAMD_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetGPUInfoAMD_Lazy(uint id, int property, uint dataType, uint size, void* data)
        {
            _glXGetGPUInfoAMD_fnptr = (delegate* unmanaged<uint, int, uint, uint, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetGPUInfoAMD");
            return _glXGetGPUInfoAMD_fnptr(id, property, dataType, size, data);
        }
        
        /// <summary><b>[entry point: <c>glXGetMscRateOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int*, int*, byte> _glXGetMscRateOML_fnptr = &glXGetMscRateOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXGetMscRateOML_Lazy(IntPtr dpy, nuint drawable, int* numerator, int* denominator)
        {
            _glXGetMscRateOML_fnptr = (delegate* unmanaged<IntPtr, nuint, int*, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXGetMscRateOML");
            return _glXGetMscRateOML_fnptr(dpy, drawable, numerator, denominator);
        }
        
        /// <summary><b>[entry point: <c>glXGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _glXGetProcAddress_fnptr = &glXGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetProcAddress_Lazy(byte* procName)
        {
            _glXGetProcAddress_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetProcAddress");
            return _glXGetProcAddress_fnptr(procName);
        }
        
        /// <summary><b>[entry point: <c>glXGetProcAddressARB</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _glXGetProcAddressARB_fnptr = &glXGetProcAddressARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetProcAddressARB_Lazy(byte* procName)
        {
            _glXGetProcAddressARB_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetProcAddressARB");
            return _glXGetProcAddressARB_fnptr(procName);
        }
        
        /// <summary><b>[entry point: <c>glXGetSelectedEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong*, void> _glXGetSelectedEvent_fnptr = &glXGetSelectedEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void glXGetSelectedEvent_Lazy(IntPtr dpy, nuint draw, ulong* event_mask)
        {
            _glXGetSelectedEvent_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong*, void>)GLXLoader.BindingsContext.GetProcAddress("glXGetSelectedEvent");
            _glXGetSelectedEvent_fnptr(dpy, draw, event_mask);
        }
        
        /// <summary><b>[entry point: <c>glXGetSelectedEventSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong*, void> _glXGetSelectedEventSGIX_fnptr = &glXGetSelectedEventSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXGetSelectedEventSGIX_Lazy(IntPtr dpy, nuint drawable, ulong* mask)
        {
            _glXGetSelectedEventSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong*, void>)GLXLoader.BindingsContext.GetProcAddress("glXGetSelectedEventSGIX");
            _glXGetSelectedEventSGIX_fnptr(dpy, drawable, mask);
        }
        
        /// <summary><b>[entry point: <c>glXGetSwapIntervalMESA</c>]</b></summary>
        public static delegate* unmanaged<int> _glXGetSwapIntervalMESA_fnptr = &glXGetSwapIntervalMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetSwapIntervalMESA_Lazy()
        {
            _glXGetSwapIntervalMESA_fnptr = (delegate* unmanaged<int>)GLXLoader.BindingsContext.GetProcAddress("glXGetSwapIntervalMESA");
            return _glXGetSwapIntervalMESA_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetSyncValuesOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long*, long*, long*, byte> _glXGetSyncValuesOML_fnptr = &glXGetSyncValuesOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXGetSyncValuesOML_Lazy(IntPtr dpy, nuint drawable, long* ust, long* msc, long* sbc)
        {
            _glXGetSyncValuesOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long*, long*, long*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXGetSyncValuesOML");
            return _glXGetSyncValuesOML_fnptr(dpy, drawable, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>glXGetTransparentIndexSUN</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, ulong*, int> _glXGetTransparentIndexSUN_fnptr = &glXGetTransparentIndexSUN_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetTransparentIndexSUN_Lazy(IntPtr dpy, nuint overlay, nuint underlay, ulong* pTransparentIndex)
        {
            _glXGetTransparentIndexSUN_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, ulong*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetTransparentIndexSUN");
            return _glXGetTransparentIndexSUN_fnptr(dpy, overlay, underlay, pTransparentIndex);
        }
        
        /// <summary><b>[entry point: <c>glXGetVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint*, int> _glXGetVideoDeviceNV_fnptr = &glXGetVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetVideoDeviceNV_Lazy(IntPtr dpy, int screen, int numVideoDevices, uint* pVideoDevice)
        {
            _glXGetVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int, int, uint*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetVideoDeviceNV");
            return _glXGetVideoDeviceNV_fnptr(dpy, screen, numVideoDevices, pVideoDevice);
        }
        
        /// <summary><b>[entry point: <c>glXGetVideoInfoNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, ulong*, ulong*, int> _glXGetVideoInfoNV_fnptr = &glXGetVideoInfoNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetVideoInfoNV_Lazy(IntPtr dpy, int screen, uint VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo)
        {
            _glXGetVideoInfoNV_fnptr = (delegate* unmanaged<IntPtr, int, uint, ulong*, ulong*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetVideoInfoNV");
            return _glXGetVideoInfoNV_fnptr(dpy, screen, VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
        }
        
        /// <summary><b>[entry point: <c>glXGetVideoSyncSGI</c>]</b></summary>
        public static delegate* unmanaged<uint*, int> _glXGetVideoSyncSGI_fnptr = &glXGetVideoSyncSGI_Lazy;
        [UnmanagedCallersOnly]
        private static int glXGetVideoSyncSGI_Lazy(uint* count)
        {
            _glXGetVideoSyncSGI_fnptr = (delegate* unmanaged<uint*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetVideoSyncSGI");
            return _glXGetVideoSyncSGI_fnptr(count);
        }
        
        /// <summary><b>[entry point: <c>glXGetVisualFromFBConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr> _glXGetVisualFromFBConfig_fnptr = &glXGetVisualFromFBConfig_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetVisualFromFBConfig_Lazy(IntPtr dpy, IntPtr config)
        {
            _glXGetVisualFromFBConfig_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetVisualFromFBConfig");
            return _glXGetVisualFromFBConfig_fnptr(dpy, config);
        }
        
        /// <summary><b>[entry point: <c>glXGetVisualFromFBConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr> _glXGetVisualFromFBConfigSGIX_fnptr = &glXGetVisualFromFBConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXGetVisualFromFBConfigSGIX_Lazy(IntPtr dpy, IntPtr config)
        {
            _glXGetVisualFromFBConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetVisualFromFBConfigSGIX");
            return _glXGetVisualFromFBConfigSGIX_fnptr(dpy, config);
        }
        
        /// <summary><b>[entry point: <c>glXHyperpipeAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void*, int> _glXHyperpipeAttribSGIX_fnptr = &glXHyperpipeAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXHyperpipeAttribSGIX_Lazy(IntPtr dpy, int timeSlice, int attrib, int size, void* attribList)
        {
            _glXHyperpipeAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXHyperpipeAttribSGIX");
            return _glXHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList);
        }
        
        /// <summary><b>[entry point: <c>glXHyperpipeConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, GLXHyperpipeConfigSGIX*, int*, int> _glXHyperpipeConfigSGIX_fnptr = &glXHyperpipeConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXHyperpipeConfigSGIX_Lazy(IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId)
        {
            _glXHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, GLXHyperpipeConfigSGIX*, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXHyperpipeConfigSGIX");
            return _glXHyperpipeConfigSGIX_fnptr(dpy, networkId, npipes, cfg, hpId);
        }
        
        /// <summary><b>[entry point: <c>glXImportContextEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, IntPtr> _glXImportContextEXT_fnptr = &glXImportContextEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr glXImportContextEXT_Lazy(IntPtr dpy, nuint contextID)
        {
            _glXImportContextEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXImportContextEXT");
            return _glXImportContextEXT_fnptr(dpy, contextID);
        }
        
        /// <summary><b>[entry point: <c>glXIsDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, byte> _glXIsDirect_fnptr = &glXIsDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXIsDirect_Lazy(IntPtr dpy, IntPtr ctx)
        {
            _glXIsDirect_fnptr = (delegate* unmanaged<IntPtr, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXIsDirect");
            return _glXIsDirect_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXJoinSwapGroupNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, uint, byte> _glXJoinSwapGroupNV_fnptr = &glXJoinSwapGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXJoinSwapGroupNV_Lazy(IntPtr dpy, nuint drawable, uint group)
        {
            _glXJoinSwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, nuint, uint, byte>)GLXLoader.BindingsContext.GetProcAddress("glXJoinSwapGroupNV");
            return _glXJoinSwapGroupNV_fnptr(dpy, drawable, group);
        }
        
        /// <summary><b>[entry point: <c>glXJoinSwapGroupSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, void> _glXJoinSwapGroupSGIX_fnptr = &glXJoinSwapGroupSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXJoinSwapGroupSGIX_Lazy(IntPtr dpy, nuint drawable, nuint member)
        {
            _glXJoinSwapGroupSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXJoinSwapGroupSGIX");
            _glXJoinSwapGroupSGIX_fnptr(dpy, drawable, member);
        }
        
        /// <summary><b>[entry point: <c>glXLockVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXLockVideoCaptureDeviceNV_fnptr = &glXLockVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXLockVideoCaptureDeviceNV_Lazy(IntPtr dpy, nuint device)
        {
            _glXLockVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXLockVideoCaptureDeviceNV");
            _glXLockVideoCaptureDeviceNV_fnptr(dpy, device);
        }
        
        /// <summary><b>[entry point: <c>glXMakeAssociatedContextCurrentAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _glXMakeAssociatedContextCurrentAMD_fnptr = &glXMakeAssociatedContextCurrentAMD_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeAssociatedContextCurrentAMD_Lazy(IntPtr ctx)
        {
            _glXMakeAssociatedContextCurrentAMD_fnptr = (delegate* unmanaged<IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeAssociatedContextCurrentAMD");
            return _glXMakeAssociatedContextCurrentAMD_fnptr(ctx);
        }
        
        /// <summary><b>[entry point: <c>glXMakeContextCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte> _glXMakeContextCurrent_fnptr = &glXMakeContextCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeContextCurrent_Lazy(IntPtr dpy, nuint draw, nuint read, IntPtr ctx)
        {
            _glXMakeContextCurrent_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeContextCurrent");
            return _glXMakeContextCurrent_fnptr(dpy, draw, read, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXMakeCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, IntPtr, byte> _glXMakeCurrent_fnptr = &glXMakeCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeCurrent_Lazy(IntPtr dpy, nuint drawable, IntPtr ctx)
        {
            _glXMakeCurrent_fnptr = (delegate* unmanaged<IntPtr, nuint, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeCurrent");
            return _glXMakeCurrent_fnptr(dpy, drawable, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXMakeCurrentReadSGI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte> _glXMakeCurrentReadSGI_fnptr = &glXMakeCurrentReadSGI_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXMakeCurrentReadSGI_Lazy(IntPtr dpy, nuint draw, nuint read, IntPtr ctx)
        {
            _glXMakeCurrentReadSGI_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeCurrentReadSGI");
            return _glXMakeCurrentReadSGI_fnptr(dpy, draw, read, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXNamedCopyBufferSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void> _glXNamedCopyBufferSubDataNV_fnptr = &glXNamedCopyBufferSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXNamedCopyBufferSubDataNV_Lazy(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            _glXNamedCopyBufferSubDataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void>)GLXLoader.BindingsContext.GetProcAddress("glXNamedCopyBufferSubDataNV");
            _glXNamedCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
        }
        
        /// <summary><b>[entry point: <c>glXQueryChannelDeltasSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int> _glXQueryChannelDeltasSGIX_fnptr = &glXQueryChannelDeltasSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryChannelDeltasSGIX_Lazy(IntPtr display, int screen, int channel, int* x, int* y, int* w, int* h)
        {
            _glXQueryChannelDeltasSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryChannelDeltasSGIX");
            return _glXQueryChannelDeltasSGIX_fnptr(display, screen, channel, x, y, w, h);
        }
        
        /// <summary><b>[entry point: <c>glXQueryChannelRectSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int> _glXQueryChannelRectSGIX_fnptr = &glXQueryChannelRectSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryChannelRectSGIX_Lazy(IntPtr display, int screen, int channel, int* dx, int* dy, int* dw, int* dh)
        {
            _glXQueryChannelRectSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryChannelRectSGIX");
            return _glXQueryChannelRectSGIX_fnptr(display, screen, channel, dx, dy, dw, dh);
        }
        
        /// <summary><b>[entry point: <c>glXQueryContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXQueryContext_fnptr = &glXQueryContext_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryContext_Lazy(IntPtr dpy, IntPtr ctx, int attribute, int* value)
        {
            _glXQueryContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryContext");
            return _glXQueryContext_fnptr(dpy, ctx, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryContextInfoEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXQueryContextInfoEXT_fnptr = &glXQueryContextInfoEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryContextInfoEXT_Lazy(IntPtr dpy, IntPtr context, int attribute, int* value)
        {
            _glXQueryContextInfoEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryContextInfoEXT");
            return _glXQueryContextInfoEXT_fnptr(dpy, context, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryCurrentRendererIntegerMESA</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, byte> _glXQueryCurrentRendererIntegerMESA_fnptr = &glXQueryCurrentRendererIntegerMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryCurrentRendererIntegerMESA_Lazy(int attribute, uint* value)
        {
            _glXQueryCurrentRendererIntegerMESA_fnptr = (delegate* unmanaged<int, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryCurrentRendererIntegerMESA");
            return _glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryCurrentRendererStringMESA</c>]</b></summary>
        public static delegate* unmanaged<int, byte*> _glXQueryCurrentRendererStringMESA_fnptr = &glXQueryCurrentRendererStringMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryCurrentRendererStringMESA_Lazy(int attribute)
        {
            _glXQueryCurrentRendererStringMESA_fnptr = (delegate* unmanaged<int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryCurrentRendererStringMESA");
            return _glXQueryCurrentRendererStringMESA_fnptr(attribute);
        }
        
        /// <summary><b>[entry point: <c>glXQueryDrawable</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, uint*, void> _glXQueryDrawable_fnptr = &glXQueryDrawable_Lazy;
        [UnmanagedCallersOnly]
        private static void glXQueryDrawable_Lazy(IntPtr dpy, nuint draw, int attribute, uint* value)
        {
            _glXQueryDrawable_fnptr = (delegate* unmanaged<IntPtr, nuint, int, uint*, void>)GLXLoader.BindingsContext.GetProcAddress("glXQueryDrawable");
            _glXQueryDrawable_fnptr(dpy, draw, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryExtension</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int*, byte> _glXQueryExtension_fnptr = &glXQueryExtension_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryExtension_Lazy(IntPtr dpy, int* errorb, int* @event)
        {
            _glXQueryExtension_fnptr = (delegate* unmanaged<IntPtr, int*, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryExtension");
            return _glXQueryExtension_fnptr(dpy, errorb, @event);
        }
        
        /// <summary><b>[entry point: <c>glXQueryExtensionsString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _glXQueryExtensionsString_fnptr = &glXQueryExtensionsString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryExtensionsString_Lazy(IntPtr dpy, int screen)
        {
            _glXQueryExtensionsString_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryExtensionsString");
            return _glXQueryExtensionsString_fnptr(dpy, screen);
        }
        
        /// <summary><b>[entry point: <c>glXQueryFrameCountNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint*, byte> _glXQueryFrameCountNV_fnptr = &glXQueryFrameCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryFrameCountNV_Lazy(IntPtr dpy, int screen, uint* count)
        {
            _glXQueryFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, int, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryFrameCountNV");
            return _glXQueryFrameCountNV_fnptr(dpy, screen, count);
        }
        
        /// <summary><b>[entry point: <c>glXQueryGLXPbufferSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, uint*, void> _glXQueryGLXPbufferSGIX_fnptr = &glXQueryGLXPbufferSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXQueryGLXPbufferSGIX_Lazy(IntPtr dpy, nuint pbuf, int attribute, uint* value)
        {
            _glXQueryGLXPbufferSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, int, uint*, void>)GLXLoader.BindingsContext.GetProcAddress("glXQueryGLXPbufferSGIX");
            _glXQueryGLXPbufferSGIX_fnptr(dpy, pbuf, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void*, int> _glXQueryHyperpipeAttribSGIX_fnptr = &glXQueryHyperpipeAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryHyperpipeAttribSGIX_Lazy(IntPtr dpy, int timeSlice, int attrib, int size, void* returnAttribList)
        {
            _glXQueryHyperpipeAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeAttribSGIX");
            return _glXQueryHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, returnAttribList);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeBestAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void*, void*, int> _glXQueryHyperpipeBestAttribSGIX_fnptr = &glXQueryHyperpipeBestAttribSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryHyperpipeBestAttribSGIX_Lazy(IntPtr dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList)
        {
            _glXQueryHyperpipeBestAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void*, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeBestAttribSGIX");
            return _glXQueryHyperpipeBestAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList, returnAttribList);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, GLXHyperpipeConfigSGIX*> _glXQueryHyperpipeConfigSGIX_fnptr = &glXQueryHyperpipeConfigSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static GLXHyperpipeConfigSGIX* glXQueryHyperpipeConfigSGIX_Lazy(IntPtr dpy, int hpId, int* npipes)
        {
            _glXQueryHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int*, GLXHyperpipeConfigSGIX*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeConfigSGIX");
            return _glXQueryHyperpipeConfigSGIX_fnptr(dpy, hpId, npipes);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeNetworkSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, GLXHyperpipeNetworkSGIX*> _glXQueryHyperpipeNetworkSGIX_fnptr = &glXQueryHyperpipeNetworkSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static GLXHyperpipeNetworkSGIX* glXQueryHyperpipeNetworkSGIX_Lazy(IntPtr dpy, int* npipes)
        {
            _glXQueryHyperpipeNetworkSGIX_fnptr = (delegate* unmanaged<IntPtr, int*, GLXHyperpipeNetworkSGIX*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeNetworkSGIX");
            return _glXQueryHyperpipeNetworkSGIX_fnptr(dpy, npipes);
        }
        
        /// <summary><b>[entry point: <c>glXQueryMaxSwapBarriersSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, byte> _glXQueryMaxSwapBarriersSGIX_fnptr = &glXQueryMaxSwapBarriersSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryMaxSwapBarriersSGIX_Lazy(IntPtr dpy, int screen, int* max)
        {
            _glXQueryMaxSwapBarriersSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryMaxSwapBarriersSGIX");
            return _glXQueryMaxSwapBarriersSGIX_fnptr(dpy, screen, max);
        }
        
        /// <summary><b>[entry point: <c>glXQueryMaxSwapGroupsNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint*, uint*, byte> _glXQueryMaxSwapGroupsNV_fnptr = &glXQueryMaxSwapGroupsNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryMaxSwapGroupsNV_Lazy(IntPtr dpy, int screen, uint* maxGroups, uint* maxBarriers)
        {
            _glXQueryMaxSwapGroupsNV_fnptr = (delegate* unmanaged<IntPtr, int, uint*, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryMaxSwapGroupsNV");
            return _glXQueryMaxSwapGroupsNV_fnptr(dpy, screen, maxGroups, maxBarriers);
        }
        
        /// <summary><b>[entry point: <c>glXQueryRendererIntegerMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, uint*, byte> _glXQueryRendererIntegerMESA_fnptr = &glXQueryRendererIntegerMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryRendererIntegerMESA_Lazy(IntPtr dpy, int screen, int renderer, int attribute, uint* value)
        {
            _glXQueryRendererIntegerMESA_fnptr = (delegate* unmanaged<IntPtr, int, int, int, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryRendererIntegerMESA");
            return _glXQueryRendererIntegerMESA_fnptr(dpy, screen, renderer, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryRendererStringMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, byte*> _glXQueryRendererStringMESA_fnptr = &glXQueryRendererStringMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryRendererStringMESA_Lazy(IntPtr dpy, int screen, int renderer, int attribute)
        {
            _glXQueryRendererStringMESA_fnptr = (delegate* unmanaged<IntPtr, int, int, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryRendererStringMESA");
            return _glXQueryRendererStringMESA_fnptr(dpy, screen, renderer, attribute);
        }
        
        /// <summary><b>[entry point: <c>glXQueryServerString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, byte*> _glXQueryServerString_fnptr = &glXQueryServerString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* glXQueryServerString_Lazy(IntPtr dpy, int screen, int name)
        {
            _glXQueryServerString_fnptr = (delegate* unmanaged<IntPtr, int, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryServerString");
            return _glXQueryServerString_fnptr(dpy, screen, name);
        }
        
        /// <summary><b>[entry point: <c>glXQuerySwapGroupNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, uint*, uint*, byte> _glXQuerySwapGroupNV_fnptr = &glXQuerySwapGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQuerySwapGroupNV_Lazy(IntPtr dpy, nuint drawable, uint* group, uint* barrier)
        {
            _glXQuerySwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, nuint, uint*, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQuerySwapGroupNV");
            return _glXQuerySwapGroupNV_fnptr(dpy, drawable, group, barrier);
        }
        
        /// <summary><b>[entry point: <c>glXQueryVersion</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int*, byte> _glXQueryVersion_fnptr = &glXQueryVersion_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXQueryVersion_Lazy(IntPtr dpy, int* maj, int* min)
        {
            _glXQueryVersion_fnptr = (delegate* unmanaged<IntPtr, int*, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryVersion");
            return _glXQueryVersion_fnptr(dpy, maj, min);
        }
        
        /// <summary><b>[entry point: <c>glXQueryVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, int*, int> _glXQueryVideoCaptureDeviceNV_fnptr = &glXQueryVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXQueryVideoCaptureDeviceNV_Lazy(IntPtr dpy, nuint device, int attribute, int* value)
        {
            _glXQueryVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, nuint, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryVideoCaptureDeviceNV");
            return _glXQueryVideoCaptureDeviceNV_fnptr(dpy, device, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseBuffersMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, byte> _glXReleaseBuffersMESA_fnptr = &glXReleaseBuffersMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXReleaseBuffersMESA_Lazy(IntPtr dpy, nuint drawable)
        {
            _glXReleaseBuffersMESA_fnptr = (delegate* unmanaged<IntPtr, nuint, byte>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseBuffersMESA");
            return _glXReleaseBuffersMESA_fnptr(dpy, drawable);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseTexImageEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, void> _glXReleaseTexImageEXT_fnptr = &glXReleaseTexImageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXReleaseTexImageEXT_Lazy(IntPtr dpy, nuint drawable, int buffer)
        {
            _glXReleaseTexImageEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseTexImageEXT");
            _glXReleaseTexImageEXT_fnptr(dpy, drawable, buffer);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXReleaseVideoCaptureDeviceNV_fnptr = &glXReleaseVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static void glXReleaseVideoCaptureDeviceNV_Lazy(IntPtr dpy, nuint device)
        {
            _glXReleaseVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseVideoCaptureDeviceNV");
            _glXReleaseVideoCaptureDeviceNV_fnptr(dpy, device);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, int> _glXReleaseVideoDeviceNV_fnptr = &glXReleaseVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXReleaseVideoDeviceNV_Lazy(IntPtr dpy, int screen, uint VideoDevice)
        {
            _glXReleaseVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int, uint, int>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseVideoDeviceNV");
            return _glXReleaseVideoDeviceNV_fnptr(dpy, screen, VideoDevice);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseVideoImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int> _glXReleaseVideoImageNV_fnptr = &glXReleaseVideoImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXReleaseVideoImageNV_Lazy(IntPtr dpy, nuint pbuf)
        {
            _glXReleaseVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, nuint, int>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseVideoImageNV");
            return _glXReleaseVideoImageNV_fnptr(dpy, pbuf);
        }
        
        /// <summary><b>[entry point: <c>glXResetFrameCountNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _glXResetFrameCountNV_fnptr = &glXResetFrameCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXResetFrameCountNV_Lazy(IntPtr dpy, int screen)
        {
            _glXResetFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, int, byte>)GLXLoader.BindingsContext.GetProcAddress("glXResetFrameCountNV");
            return _glXResetFrameCountNV_fnptr(dpy, screen);
        }
        
        /// <summary><b>[entry point: <c>glXSelectEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong, void> _glXSelectEvent_fnptr = &glXSelectEvent_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSelectEvent_Lazy(IntPtr dpy, nuint draw, ulong event_mask)
        {
            _glXSelectEvent_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong, void>)GLXLoader.BindingsContext.GetProcAddress("glXSelectEvent");
            _glXSelectEvent_fnptr(dpy, draw, event_mask);
        }
        
        /// <summary><b>[entry point: <c>glXSelectEventSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong, void> _glXSelectEventSGIX_fnptr = &glXSelectEventSGIX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSelectEventSGIX_Lazy(IntPtr dpy, nuint drawable, ulong mask)
        {
            _glXSelectEventSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong, void>)GLXLoader.BindingsContext.GetProcAddress("glXSelectEventSGIX");
            _glXSelectEventSGIX_fnptr(dpy, drawable, mask);
        }
        
        /// <summary><b>[entry point: <c>glXSendPbufferToVideoNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, ulong*, byte, int> _glXSendPbufferToVideoNV_fnptr = &glXSendPbufferToVideoNV_Lazy;
        [UnmanagedCallersOnly]
        private static int glXSendPbufferToVideoNV_Lazy(IntPtr dpy, nuint pbuf, int iBufferType, ulong* pulCounterPbuffer, byte bBlock)
        {
            _glXSendPbufferToVideoNV_fnptr = (delegate* unmanaged<IntPtr, nuint, int, ulong*, byte, int>)GLXLoader.BindingsContext.GetProcAddress("glXSendPbufferToVideoNV");
            return _glXSendPbufferToVideoNV_fnptr(dpy, pbuf, iBufferType, pulCounterPbuffer, bBlock);
        }
        
        /// <summary><b>[entry point: <c>glXSet3DfxModeMESA</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _glXSet3DfxModeMESA_fnptr = &glXSet3DfxModeMESA_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXSet3DfxModeMESA_Lazy(int mode)
        {
            _glXSet3DfxModeMESA_fnptr = (delegate* unmanaged<int, byte>)GLXLoader.BindingsContext.GetProcAddress("glXSet3DfxModeMESA");
            return _glXSet3DfxModeMESA_fnptr(mode);
        }
        
        /// <summary><b>[entry point: <c>glXSwapBuffers</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXSwapBuffers_fnptr = &glXSwapBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSwapBuffers_Lazy(IntPtr dpy, nuint drawable)
        {
            _glXSwapBuffers_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXSwapBuffers");
            _glXSwapBuffers_fnptr(dpy, drawable);
        }
        
        /// <summary><b>[entry point: <c>glXSwapBuffersMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long, long, long, long> _glXSwapBuffersMscOML_fnptr = &glXSwapBuffersMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static long glXSwapBuffersMscOML_Lazy(IntPtr dpy, nuint drawable, long target_msc, long divisor, long remainder)
        {
            _glXSwapBuffersMscOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long, long, long, long>)GLXLoader.BindingsContext.GetProcAddress("glXSwapBuffersMscOML");
            return _glXSwapBuffersMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder);
        }
        
        /// <summary><b>[entry point: <c>glXSwapIntervalEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, void> _glXSwapIntervalEXT_fnptr = &glXSwapIntervalEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void glXSwapIntervalEXT_Lazy(IntPtr dpy, nuint drawable, int interval)
        {
            _glXSwapIntervalEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXSwapIntervalEXT");
            _glXSwapIntervalEXT_fnptr(dpy, drawable, interval);
        }
        
        /// <summary><b>[entry point: <c>glXSwapIntervalMESA</c>]</b></summary>
        public static delegate* unmanaged<uint, int> _glXSwapIntervalMESA_fnptr = &glXSwapIntervalMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int glXSwapIntervalMESA_Lazy(uint interval)
        {
            _glXSwapIntervalMESA_fnptr = (delegate* unmanaged<uint, int>)GLXLoader.BindingsContext.GetProcAddress("glXSwapIntervalMESA");
            return _glXSwapIntervalMESA_fnptr(interval);
        }
        
        /// <summary><b>[entry point: <c>glXSwapIntervalSGI</c>]</b></summary>
        public static delegate* unmanaged<int, int> _glXSwapIntervalSGI_fnptr = &glXSwapIntervalSGI_Lazy;
        [UnmanagedCallersOnly]
        private static int glXSwapIntervalSGI_Lazy(int interval)
        {
            _glXSwapIntervalSGI_fnptr = (delegate* unmanaged<int, int>)GLXLoader.BindingsContext.GetProcAddress("glXSwapIntervalSGI");
            return _glXSwapIntervalSGI_fnptr(interval);
        }
        
        /// <summary><b>[entry point: <c>glXUseXFont</c>]</b></summary>
        public static delegate* unmanaged<nuint, int, int, int, void> _glXUseXFont_fnptr = &glXUseXFont_Lazy;
        [UnmanagedCallersOnly]
        private static void glXUseXFont_Lazy(nuint font, int first, int count, int list)
        {
            _glXUseXFont_fnptr = (delegate* unmanaged<nuint, int, int, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXUseXFont");
            _glXUseXFont_fnptr(font, first, count, list);
        }
        
        /// <summary><b>[entry point: <c>glXWaitForMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long, long, long, long*, long*, long*, byte> _glXWaitForMscOML_fnptr = &glXWaitForMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXWaitForMscOML_Lazy(IntPtr dpy, nuint drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc)
        {
            _glXWaitForMscOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long, long, long, long*, long*, long*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXWaitForMscOML");
            return _glXWaitForMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>glXWaitForSbcOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long, long*, long*, long*, byte> _glXWaitForSbcOML_fnptr = &glXWaitForSbcOML_Lazy;
        [UnmanagedCallersOnly]
        private static byte glXWaitForSbcOML_Lazy(IntPtr dpy, nuint drawable, long target_sbc, long* ust, long* msc, long* sbc)
        {
            _glXWaitForSbcOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long, long*, long*, long*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXWaitForSbcOML");
            return _glXWaitForSbcOML_fnptr(dpy, drawable, target_sbc, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>glXWaitGL</c>]</b></summary>
        public static delegate* unmanaged<void> _glXWaitGL_fnptr = &glXWaitGL_Lazy;
        [UnmanagedCallersOnly]
        private static void glXWaitGL_Lazy()
        {
            _glXWaitGL_fnptr = (delegate* unmanaged<void>)GLXLoader.BindingsContext.GetProcAddress("glXWaitGL");
            _glXWaitGL_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXWaitVideoSyncSGI</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint*, int> _glXWaitVideoSyncSGI_fnptr = &glXWaitVideoSyncSGI_Lazy;
        [UnmanagedCallersOnly]
        private static int glXWaitVideoSyncSGI_Lazy(int divisor, int remainder, uint* count)
        {
            _glXWaitVideoSyncSGI_fnptr = (delegate* unmanaged<int, int, uint*, int>)GLXLoader.BindingsContext.GetProcAddress("glXWaitVideoSyncSGI");
            return _glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
        }
        
        /// <summary><b>[entry point: <c>glXWaitX</c>]</b></summary>
        public static delegate* unmanaged<void> _glXWaitX_fnptr = &glXWaitX_Lazy;
        [UnmanagedCallersOnly]
        private static void glXWaitX_Lazy()
        {
            _glXWaitX_fnptr = (delegate* unmanaged<void>)GLXLoader.BindingsContext.GetProcAddress("glXWaitX");
            _glXWaitX_fnptr();
        }
        
    }
}
