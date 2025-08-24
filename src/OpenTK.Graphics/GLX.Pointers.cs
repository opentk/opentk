// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    /// <summary>A collection of all function pointers to all OpenGL entry points.</summary>
    public static unsafe partial class GlxPointers
    {
        /// <summary><b>[entry point: <c>glXBindChannelToWindowSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, nuint, int> _glXBindChannelToWindowSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXBindChannelToWindowSGIX_Lazy(IntPtr display, int screen, int channel, nuint window)
        {
            if (_glXBindChannelToWindowSGIX_fnptr == null)
                _glXBindChannelToWindowSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, nuint, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindChannelToWindowSGIX");
            return _glXBindChannelToWindowSGIX_fnptr(display, screen, channel, window);
        }
        
        /// <summary><b>[entry point: <c>glXBindHyperpipeSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _glXBindHyperpipeSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXBindHyperpipeSGIX_Lazy(IntPtr dpy, int hpId)
        {
            if (_glXBindHyperpipeSGIX_fnptr == null)
                _glXBindHyperpipeSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindHyperpipeSGIX");
            return _glXBindHyperpipeSGIX_fnptr(dpy, hpId);
        }
        
        /// <summary><b>[entry point: <c>glXBindSwapBarrierNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, byte> _glXBindSwapBarrierNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXBindSwapBarrierNV_Lazy(IntPtr dpy, uint group, uint barrier)
        {
            if (_glXBindSwapBarrierNV_fnptr == null)
                _glXBindSwapBarrierNV_fnptr = (delegate* unmanaged<IntPtr, uint, uint, byte>)GLXLoader.BindingsContext.GetProcAddress("glXBindSwapBarrierNV");
            return _glXBindSwapBarrierNV_fnptr(dpy, group, barrier);
        }
        
        /// <summary><b>[entry point: <c>glXBindSwapBarrierSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, void> _glXBindSwapBarrierSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXBindSwapBarrierSGIX_Lazy(IntPtr dpy, nuint drawable, int barrier)
        {
            if (_glXBindSwapBarrierSGIX_fnptr == null)
                _glXBindSwapBarrierSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXBindSwapBarrierSGIX");
            _glXBindSwapBarrierSGIX_fnptr(dpy, drawable, barrier);
        }
        
        /// <summary><b>[entry point: <c>glXBindTexImageEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, int*, void> _glXBindTexImageEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXBindTexImageEXT_Lazy(IntPtr dpy, nuint drawable, int buffer, int* attrib_list)
        {
            if (_glXBindTexImageEXT_fnptr == null)
                _glXBindTexImageEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, int, int*, void>)GLXLoader.BindingsContext.GetProcAddress("glXBindTexImageEXT");
            _glXBindTexImageEXT_fnptr(dpy, drawable, buffer, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXBindVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, int> _glXBindVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXBindVideoCaptureDeviceNV_Lazy(IntPtr dpy, uint video_capture_slot, nuint device)
        {
            if (_glXBindVideoCaptureDeviceNV_fnptr == null)
                _glXBindVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindVideoCaptureDeviceNV");
            return _glXBindVideoCaptureDeviceNV_fnptr(dpy, video_capture_slot, device);
        }
        
        /// <summary><b>[entry point: <c>glXBindVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, int*, int> _glXBindVideoDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXBindVideoDeviceNV_Lazy(IntPtr dpy, uint video_slot, uint video_device, int* attrib_list)
        {
            if (_glXBindVideoDeviceNV_fnptr == null)
                _glXBindVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, uint, uint, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindVideoDeviceNV");
            return _glXBindVideoDeviceNV_fnptr(dpy, video_slot, video_device, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXBindVideoImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, nuint, int, int> _glXBindVideoImageNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXBindVideoImageNV_Lazy(IntPtr dpy, uint VideoDevice, nuint pbuf, int iVideoBuffer)
        {
            if (_glXBindVideoImageNV_fnptr == null)
                _glXBindVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, uint, nuint, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXBindVideoImageNV");
            return _glXBindVideoImageNV_fnptr(dpy, VideoDevice, pbuf, iVideoBuffer);
        }
        
        /// <summary><b>[entry point: <c>glXBlitContextFramebufferAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void> _glXBlitContextFramebufferAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXBlitContextFramebufferAMD_Lazy(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
        {
            if (_glXBlitContextFramebufferAMD_fnptr == null)
                _glXBlitContextFramebufferAMD_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void>)GLXLoader.BindingsContext.GetProcAddress("glXBlitContextFramebufferAMD");
            _glXBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        /// <summary><b>[entry point: <c>glXChannelRectSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int> _glXChannelRectSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXChannelRectSGIX_Lazy(IntPtr display, int screen, int channel, int x, int y, int w, int h)
        {
            if (_glXChannelRectSGIX_fnptr == null)
                _glXChannelRectSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXChannelRectSGIX");
            return _glXChannelRectSGIX_fnptr(display, screen, channel, x, y, w, h);
        }
        
        /// <summary><b>[entry point: <c>glXChannelRectSyncSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int> _glXChannelRectSyncSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXChannelRectSyncSGIX_Lazy(IntPtr display, int screen, int channel, uint synctype)
        {
            if (_glXChannelRectSyncSGIX_fnptr == null)
                _glXChannelRectSyncSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int>)GLXLoader.BindingsContext.GetProcAddress("glXChannelRectSyncSGIX");
            return _glXChannelRectSyncSGIX_fnptr(display, screen, channel, synctype);
        }
        
        /// <summary><b>[entry point: <c>glXChooseFBConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*> _glXChooseFBConfig_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr* glXChooseFBConfig_Lazy(IntPtr dpy, int screen, int* attrib_list, int* nelements)
        {
            if (_glXChooseFBConfig_fnptr == null)
                _glXChooseFBConfig_fnptr = (delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*>)GLXLoader.BindingsContext.GetProcAddress("glXChooseFBConfig");
            return _glXChooseFBConfig_fnptr(dpy, screen, attrib_list, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXChooseFBConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*> _glXChooseFBConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr* glXChooseFBConfigSGIX_Lazy(IntPtr dpy, int screen, int* attrib_list, int* nelements)
        {
            if (_glXChooseFBConfigSGIX_fnptr == null)
                _glXChooseFBConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int*, int*, IntPtr*>)GLXLoader.BindingsContext.GetProcAddress("glXChooseFBConfigSGIX");
            return _glXChooseFBConfigSGIX_fnptr(dpy, screen, attrib_list, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXChooseVisual</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, IntPtr> _glXChooseVisual_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXChooseVisual_Lazy(IntPtr dpy, int screen, int* attribList)
        {
            if (_glXChooseVisual_fnptr == null)
                _glXChooseVisual_fnptr = (delegate* unmanaged<IntPtr, int, int*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXChooseVisual");
            return _glXChooseVisual_fnptr(dpy, screen, attribList);
        }
        
        /// <summary><b>[entry point: <c>glXCopyBufferSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void> _glXCopyBufferSubDataNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXCopyBufferSubDataNV_Lazy(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, uint readTarget, uint writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            if (_glXCopyBufferSubDataNV_fnptr == null)
                _glXCopyBufferSubDataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopyBufferSubDataNV");
            _glXCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
        }
        
        /// <summary><b>[entry point: <c>glXCopyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, ulong, void> _glXCopyContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXCopyContext_Lazy(IntPtr dpy, IntPtr src, IntPtr dst, ulong mask)
        {
            if (_glXCopyContext_fnptr == null)
                _glXCopyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, ulong, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopyContext");
            _glXCopyContext_fnptr(dpy, src, dst, mask);
        }
        
        /// <summary><b>[entry point: <c>glXCopyImageSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, void> _glXCopyImageSubDataNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXCopyImageSubDataNV_Lazy(IntPtr dpy, IntPtr srcCtx, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr dstCtx, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
        {
            if (_glXCopyImageSubDataNV_fnptr == null)
                _glXCopyImageSubDataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopyImageSubDataNV");
            _glXCopyImageSubDataNV_fnptr(dpy, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
        }
        
        /// <summary><b>[entry point: <c>glXCopySubBufferMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, int, int, int, void> _glXCopySubBufferMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXCopySubBufferMESA_Lazy(IntPtr dpy, nuint drawable, int x, int y, int width, int height)
        {
            if (_glXCopySubBufferMESA_fnptr == null)
                _glXCopySubBufferMESA_fnptr = (delegate* unmanaged<IntPtr, nuint, int, int, int, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXCopySubBufferMESA");
            _glXCopySubBufferMESA_fnptr(dpy, drawable, x, y, width, height);
        }
        
        /// <summary><b>[entry point: <c>glXCreateAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, IntPtr> _glXCreateAssociatedContextAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXCreateAssociatedContextAMD_Lazy(uint id, IntPtr share_list)
        {
            if (_glXCreateAssociatedContextAMD_fnptr == null)
                _glXCreateAssociatedContextAMD_fnptr = (delegate* unmanaged<uint, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateAssociatedContextAMD");
            return _glXCreateAssociatedContextAMD_fnptr(id, share_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateAssociatedContextAttribsAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, int*, IntPtr> _glXCreateAssociatedContextAttribsAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXCreateAssociatedContextAttribsAMD_Lazy(uint id, IntPtr share_context, int* attribList)
        {
            if (_glXCreateAssociatedContextAttribsAMD_fnptr == null)
                _glXCreateAssociatedContextAttribsAMD_fnptr = (delegate* unmanaged<uint, IntPtr, int*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateAssociatedContextAttribsAMD");
            return _glXCreateAssociatedContextAttribsAMD_fnptr(id, share_context, attribList);
        }
        
        /// <summary><b>[entry point: <c>glXCreateContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, IntPtr> _glXCreateContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXCreateContext_Lazy(IntPtr dpy, IntPtr vis, IntPtr shareList, byte direct)
        {
            if (_glXCreateContext_fnptr == null)
                _glXCreateContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateContext");
            return _glXCreateContext_fnptr(dpy, vis, shareList, direct);
        }
        
        /// <summary><b>[entry point: <c>glXCreateContextAttribsARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, int*, IntPtr> _glXCreateContextAttribsARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXCreateContextAttribsARB_Lazy(IntPtr dpy, IntPtr config, IntPtr share_context, byte direct, int* attrib_list)
        {
            if (_glXCreateContextAttribsARB_fnptr == null)
                _glXCreateContextAttribsARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, byte, int*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateContextAttribsARB");
            return _glXCreateContextAttribsARB_fnptr(dpy, config, share_context, direct, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateContextWithConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr> _glXCreateContextWithConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXCreateContextWithConfigSGIX_Lazy(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, byte direct)
        {
            if (_glXCreateContextWithConfigSGIX_fnptr == null)
                _glXCreateContextWithConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateContextWithConfigSGIX");
            return _glXCreateContextWithConfigSGIX_fnptr(dpy, config, render_type, share_list, direct);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPbufferSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, uint, int*, nuint> _glXCreateGLXPbufferSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreateGLXPbufferSGIX_Lazy(IntPtr dpy, IntPtr config, uint width, uint height, int* attrib_list)
        {
            if (_glXCreateGLXPbufferSGIX_fnptr == null)
                _glXCreateGLXPbufferSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, uint, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPbufferSGIX");
            return _glXCreateGLXPbufferSGIX_fnptr(dpy, config, width, height, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, nuint> _glXCreateGLXPixmap_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreateGLXPixmap_Lazy(IntPtr dpy, IntPtr visual, nuint pixmap)
        {
            if (_glXCreateGLXPixmap_fnptr == null)
                _glXCreateGLXPixmap_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmap");
            return _glXCreateGLXPixmap_fnptr(dpy, visual, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPixmapMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, nuint, nuint> _glXCreateGLXPixmapMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreateGLXPixmapMESA_Lazy(IntPtr dpy, IntPtr visual, nuint pixmap, nuint cmap)
        {
            if (_glXCreateGLXPixmapMESA_fnptr == null)
                _glXCreateGLXPixmapMESA_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, nuint, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmapMESA");
            return _glXCreateGLXPixmapMESA_fnptr(dpy, visual, pixmap, cmap);
        }
        
        /// <summary><b>[entry point: <c>glXCreateGLXPixmapWithConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, nuint> _glXCreateGLXPixmapWithConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreateGLXPixmapWithConfigSGIX_Lazy(IntPtr dpy, IntPtr config, nuint pixmap)
        {
            if (_glXCreateGLXPixmapWithConfigSGIX_fnptr == null)
                _glXCreateGLXPixmapWithConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateGLXPixmapWithConfigSGIX");
            return _glXCreateGLXPixmapWithConfigSGIX_fnptr(dpy, config, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXCreateNewContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr> _glXCreateNewContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXCreateNewContext_Lazy(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, byte direct)
        {
            if (_glXCreateNewContext_fnptr == null)
                _glXCreateNewContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, byte, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXCreateNewContext");
            return _glXCreateNewContext_fnptr(dpy, config, render_type, share_list, direct);
        }
        
        /// <summary><b>[entry point: <c>glXCreatePbuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, nuint> _glXCreatePbuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreatePbuffer_Lazy(IntPtr dpy, IntPtr config, int* attrib_list)
        {
            if (_glXCreatePbuffer_fnptr == null)
                _glXCreatePbuffer_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreatePbuffer");
            return _glXCreatePbuffer_fnptr(dpy, config, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreatePixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint> _glXCreatePixmap_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreatePixmap_Lazy(IntPtr dpy, IntPtr config, nuint pixmap, int* attrib_list)
        {
            if (_glXCreatePixmap_fnptr == null)
                _glXCreatePixmap_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreatePixmap");
            return _glXCreatePixmap_fnptr(dpy, config, pixmap, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCreateWindow</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint> _glXCreateWindow_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXCreateWindow_Lazy(IntPtr dpy, IntPtr config, nuint win, int* attrib_list)
        {
            if (_glXCreateWindow_fnptr == null)
                _glXCreateWindow_fnptr = (delegate* unmanaged<IntPtr, IntPtr, nuint, int*, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXCreateWindow");
            return _glXCreateWindow_fnptr(dpy, config, win, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>glXCushionSGI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, float, void> _glXCushionSGI_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXCushionSGI_Lazy(IntPtr dpy, nuint window, float cushion)
        {
            if (_glXCushionSGI_fnptr == null)
                _glXCushionSGI_fnptr = (delegate* unmanaged<IntPtr, nuint, float, void>)GLXLoader.BindingsContext.GetProcAddress("glXCushionSGI");
            _glXCushionSGI_fnptr(dpy, window, cushion);
        }
        
        /// <summary><b>[entry point: <c>glXDelayBeforeSwapNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, float, byte> _glXDelayBeforeSwapNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXDelayBeforeSwapNV_Lazy(IntPtr dpy, nuint drawable, float seconds)
        {
            if (_glXDelayBeforeSwapNV_fnptr == null)
                _glXDelayBeforeSwapNV_fnptr = (delegate* unmanaged<IntPtr, nuint, float, byte>)GLXLoader.BindingsContext.GetProcAddress("glXDelayBeforeSwapNV");
            return _glXDelayBeforeSwapNV_fnptr(dpy, drawable, seconds);
        }
        
        /// <summary><b>[entry point: <c>glXDeleteAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _glXDeleteAssociatedContextAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXDeleteAssociatedContextAMD_Lazy(IntPtr ctx)
        {
            if (_glXDeleteAssociatedContextAMD_fnptr == null)
                _glXDeleteAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXDeleteAssociatedContextAMD");
            return _glXDeleteAssociatedContextAMD_fnptr(ctx);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _glXDestroyContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXDestroyContext_Lazy(IntPtr dpy, IntPtr ctx)
        {
            if (_glXDestroyContext_fnptr == null)
                _glXDestroyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyContext");
            _glXDestroyContext_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyGLXPbufferSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyGLXPbufferSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXDestroyGLXPbufferSGIX_Lazy(IntPtr dpy, nuint pbuf)
        {
            if (_glXDestroyGLXPbufferSGIX_fnptr == null)
                _glXDestroyGLXPbufferSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyGLXPbufferSGIX");
            _glXDestroyGLXPbufferSGIX_fnptr(dpy, pbuf);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyGLXPixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyGLXPixmap_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXDestroyGLXPixmap_Lazy(IntPtr dpy, nuint pixmap)
        {
            if (_glXDestroyGLXPixmap_fnptr == null)
                _glXDestroyGLXPixmap_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyGLXPixmap");
            _glXDestroyGLXPixmap_fnptr(dpy, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyHyperpipeConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _glXDestroyHyperpipeConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXDestroyHyperpipeConfigSGIX_Lazy(IntPtr dpy, int hpId)
        {
            if (_glXDestroyHyperpipeConfigSGIX_fnptr == null)
                _glXDestroyHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyHyperpipeConfigSGIX");
            return _glXDestroyHyperpipeConfigSGIX_fnptr(dpy, hpId);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyPbuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyPbuffer_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXDestroyPbuffer_Lazy(IntPtr dpy, nuint pbuf)
        {
            if (_glXDestroyPbuffer_fnptr == null)
                _glXDestroyPbuffer_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyPbuffer");
            _glXDestroyPbuffer_fnptr(dpy, pbuf);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyPixmap</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyPixmap_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXDestroyPixmap_Lazy(IntPtr dpy, nuint pixmap)
        {
            if (_glXDestroyPixmap_fnptr == null)
                _glXDestroyPixmap_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyPixmap");
            _glXDestroyPixmap_fnptr(dpy, pixmap);
        }
        
        /// <summary><b>[entry point: <c>glXDestroyWindow</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXDestroyWindow_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXDestroyWindow_Lazy(IntPtr dpy, nuint win)
        {
            if (_glXDestroyWindow_fnptr == null)
                _glXDestroyWindow_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXDestroyWindow");
            _glXDestroyWindow_fnptr(dpy, win);
        }
        
        /// <summary><b>[entry point: <c>glXEnumerateVideoCaptureDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, nuint*> _glXEnumerateVideoCaptureDevicesNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint* glXEnumerateVideoCaptureDevicesNV_Lazy(IntPtr dpy, int screen, int* nelements)
        {
            if (_glXEnumerateVideoCaptureDevicesNV_fnptr == null)
                _glXEnumerateVideoCaptureDevicesNV_fnptr = (delegate* unmanaged<IntPtr, int, int*, nuint*>)GLXLoader.BindingsContext.GetProcAddress("glXEnumerateVideoCaptureDevicesNV");
            return _glXEnumerateVideoCaptureDevicesNV_fnptr(dpy, screen, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXEnumerateVideoDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, uint*> _glXEnumerateVideoDevicesNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint* glXEnumerateVideoDevicesNV_Lazy(IntPtr dpy, int screen, int* nelements)
        {
            if (_glXEnumerateVideoDevicesNV_fnptr == null)
                _glXEnumerateVideoDevicesNV_fnptr = (delegate* unmanaged<IntPtr, int, int*, uint*>)GLXLoader.BindingsContext.GetProcAddress("glXEnumerateVideoDevicesNV");
            return _glXEnumerateVideoDevicesNV_fnptr(dpy, screen, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXFreeContextEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _glXFreeContextEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXFreeContextEXT_Lazy(IntPtr dpy, IntPtr context)
        {
            if (_glXFreeContextEXT_fnptr == null)
                _glXFreeContextEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)GLXLoader.BindingsContext.GetProcAddress("glXFreeContextEXT");
            _glXFreeContextEXT_fnptr(dpy, context);
        }
        
        /// <summary><b>[entry point: <c>glXGetAGPOffsetMESA</c>]</b></summary>
        public static delegate* unmanaged<void*, uint> _glXGetAGPOffsetMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint glXGetAGPOffsetMESA_Lazy(void* pointer)
        {
            if (_glXGetAGPOffsetMESA_fnptr == null)
                _glXGetAGPOffsetMESA_fnptr = (delegate* unmanaged<void*, uint>)GLXLoader.BindingsContext.GetProcAddress("glXGetAGPOffsetMESA");
            return _glXGetAGPOffsetMESA_fnptr(pointer);
        }
        
        /// <summary><b>[entry point: <c>glXGetClientString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _glXGetClientString_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* glXGetClientString_Lazy(IntPtr dpy, int name)
        {
            if (_glXGetClientString_fnptr == null)
                _glXGetClientString_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXGetClientString");
            return _glXGetClientString_fnptr(dpy, name);
        }
        
        /// <summary><b>[entry point: <c>glXGetConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXGetConfig_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetConfig_Lazy(IntPtr dpy, IntPtr visual, int attrib, int* value)
        {
            if (_glXGetConfig_fnptr == null)
                _glXGetConfig_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetConfig");
            return _glXGetConfig_fnptr(dpy, visual, attrib, value);
        }
        
        /// <summary><b>[entry point: <c>glXGetContextGPUIDAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint> _glXGetContextGPUIDAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint glXGetContextGPUIDAMD_Lazy(IntPtr ctx)
        {
            if (_glXGetContextGPUIDAMD_fnptr == null)
                _glXGetContextGPUIDAMD_fnptr = (delegate* unmanaged<IntPtr, uint>)GLXLoader.BindingsContext.GetProcAddress("glXGetContextGPUIDAMD");
            return _glXGetContextGPUIDAMD_fnptr(ctx);
        }
        
        /// <summary><b>[entry point: <c>glXGetContextIDEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint> _glXGetContextIDEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXGetContextIDEXT_Lazy(IntPtr context)
        {
            if (_glXGetContextIDEXT_fnptr == null)
                _glXGetContextIDEXT_fnptr = (delegate* unmanaged<IntPtr, nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetContextIDEXT");
            return _glXGetContextIDEXT_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentAssociatedContextAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetCurrentAssociatedContextAMD_Lazy()
        {
            if (_glXGetCurrentAssociatedContextAMD_fnptr == null)
                _glXGetCurrentAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentAssociatedContextAMD");
            return _glXGetCurrentAssociatedContextAMD_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetCurrentContext_Lazy()
        {
            if (_glXGetCurrentContext_fnptr == null)
                _glXGetCurrentContext_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentContext");
            return _glXGetCurrentContext_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentDisplay</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentDisplay_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetCurrentDisplay_Lazy()
        {
            if (_glXGetCurrentDisplay_fnptr == null)
                _glXGetCurrentDisplay_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentDisplay");
            return _glXGetCurrentDisplay_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentDisplayEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _glXGetCurrentDisplayEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetCurrentDisplayEXT_Lazy()
        {
            if (_glXGetCurrentDisplayEXT_fnptr == null)
                _glXGetCurrentDisplayEXT_fnptr = (delegate* unmanaged<IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentDisplayEXT");
            return _glXGetCurrentDisplayEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentDrawable</c>]</b></summary>
        public static delegate* unmanaged<nuint> _glXGetCurrentDrawable_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXGetCurrentDrawable_Lazy()
        {
            if (_glXGetCurrentDrawable_fnptr == null)
                _glXGetCurrentDrawable_fnptr = (delegate* unmanaged<nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentDrawable");
            return _glXGetCurrentDrawable_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentReadDrawable</c>]</b></summary>
        public static delegate* unmanaged<nuint> _glXGetCurrentReadDrawable_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXGetCurrentReadDrawable_Lazy()
        {
            if (_glXGetCurrentReadDrawable_fnptr == null)
                _glXGetCurrentReadDrawable_fnptr = (delegate* unmanaged<nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentReadDrawable");
            return _glXGetCurrentReadDrawable_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetCurrentReadDrawableSGI</c>]</b></summary>
        public static delegate* unmanaged<nuint> _glXGetCurrentReadDrawableSGI_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static nuint glXGetCurrentReadDrawableSGI_Lazy()
        {
            if (_glXGetCurrentReadDrawableSGI_fnptr == null)
                _glXGetCurrentReadDrawableSGI_fnptr = (delegate* unmanaged<nuint>)GLXLoader.BindingsContext.GetProcAddress("glXGetCurrentReadDrawableSGI");
            return _glXGetCurrentReadDrawableSGI_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigAttrib</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXGetFBConfigAttrib_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetFBConfigAttrib_Lazy(IntPtr dpy, IntPtr config, int attribute, int* value)
        {
            if (_glXGetFBConfigAttrib_fnptr == null)
                _glXGetFBConfigAttrib_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigAttrib");
            return _glXGetFBConfigAttrib_fnptr(dpy, config, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXGetFBConfigAttribSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetFBConfigAttribSGIX_Lazy(IntPtr dpy, IntPtr config, int attribute, int* value)
        {
            if (_glXGetFBConfigAttribSGIX_fnptr == null)
                _glXGetFBConfigAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigAttribSGIX");
            return _glXGetFBConfigAttribSGIX_fnptr(dpy, config, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigFromVisualSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr> _glXGetFBConfigFromVisualSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetFBConfigFromVisualSGIX_Lazy(IntPtr dpy, IntPtr vis)
        {
            if (_glXGetFBConfigFromVisualSGIX_fnptr == null)
                _glXGetFBConfigFromVisualSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigFromVisualSGIX");
            return _glXGetFBConfigFromVisualSGIX_fnptr(dpy, vis);
        }
        
        /// <summary><b>[entry point: <c>glXGetFBConfigs</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, IntPtr*> _glXGetFBConfigs_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr* glXGetFBConfigs_Lazy(IntPtr dpy, int screen, int* nelements)
        {
            if (_glXGetFBConfigs_fnptr == null)
                _glXGetFBConfigs_fnptr = (delegate* unmanaged<IntPtr, int, int*, IntPtr*>)GLXLoader.BindingsContext.GetProcAddress("glXGetFBConfigs");
            return _glXGetFBConfigs_fnptr(dpy, screen, nelements);
        }
        
        /// <summary><b>[entry point: <c>glXGetGPUIDsAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, uint*, uint> _glXGetGPUIDsAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint glXGetGPUIDsAMD_Lazy(uint maxCount, uint* ids)
        {
            if (_glXGetGPUIDsAMD_fnptr == null)
                _glXGetGPUIDsAMD_fnptr = (delegate* unmanaged<uint, uint*, uint>)GLXLoader.BindingsContext.GetProcAddress("glXGetGPUIDsAMD");
            return _glXGetGPUIDsAMD_fnptr(maxCount, ids);
        }
        
        /// <summary><b>[entry point: <c>glXGetGPUInfoAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, int, uint, uint, void*, int> _glXGetGPUInfoAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetGPUInfoAMD_Lazy(uint id, int property, uint dataType, uint size, void* data)
        {
            if (_glXGetGPUInfoAMD_fnptr == null)
                _glXGetGPUInfoAMD_fnptr = (delegate* unmanaged<uint, int, uint, uint, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetGPUInfoAMD");
            return _glXGetGPUInfoAMD_fnptr(id, property, dataType, size, data);
        }
        
        /// <summary><b>[entry point: <c>glXGetMscRateOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int*, int*, byte> _glXGetMscRateOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXGetMscRateOML_Lazy(IntPtr dpy, nuint drawable, int* numerator, int* denominator)
        {
            if (_glXGetMscRateOML_fnptr == null)
                _glXGetMscRateOML_fnptr = (delegate* unmanaged<IntPtr, nuint, int*, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXGetMscRateOML");
            return _glXGetMscRateOML_fnptr(dpy, drawable, numerator, denominator);
        }
        
        /// <summary><b>[entry point: <c>glXGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _glXGetProcAddress_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetProcAddress_Lazy(byte* procName)
        {
            if (_glXGetProcAddress_fnptr == null)
                _glXGetProcAddress_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetProcAddress");
            return _glXGetProcAddress_fnptr(procName);
        }
        
        /// <summary><b>[entry point: <c>glXGetProcAddressARB</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _glXGetProcAddressARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetProcAddressARB_Lazy(byte* procName)
        {
            if (_glXGetProcAddressARB_fnptr == null)
                _glXGetProcAddressARB_fnptr = (delegate* unmanaged<byte*, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetProcAddressARB");
            return _glXGetProcAddressARB_fnptr(procName);
        }
        
        /// <summary><b>[entry point: <c>glXGetSelectedEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong*, void> _glXGetSelectedEvent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXGetSelectedEvent_Lazy(IntPtr dpy, nuint draw, ulong* event_mask)
        {
            if (_glXGetSelectedEvent_fnptr == null)
                _glXGetSelectedEvent_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong*, void>)GLXLoader.BindingsContext.GetProcAddress("glXGetSelectedEvent");
            _glXGetSelectedEvent_fnptr(dpy, draw, event_mask);
        }
        
        /// <summary><b>[entry point: <c>glXGetSelectedEventSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong*, void> _glXGetSelectedEventSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXGetSelectedEventSGIX_Lazy(IntPtr dpy, nuint drawable, ulong* mask)
        {
            if (_glXGetSelectedEventSGIX_fnptr == null)
                _glXGetSelectedEventSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong*, void>)GLXLoader.BindingsContext.GetProcAddress("glXGetSelectedEventSGIX");
            _glXGetSelectedEventSGIX_fnptr(dpy, drawable, mask);
        }
        
        /// <summary><b>[entry point: <c>glXGetSwapIntervalMESA</c>]</b></summary>
        public static delegate* unmanaged<int> _glXGetSwapIntervalMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetSwapIntervalMESA_Lazy()
        {
            if (_glXGetSwapIntervalMESA_fnptr == null)
                _glXGetSwapIntervalMESA_fnptr = (delegate* unmanaged<int>)GLXLoader.BindingsContext.GetProcAddress("glXGetSwapIntervalMESA");
            return _glXGetSwapIntervalMESA_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXGetSyncValuesOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long*, long*, long*, byte> _glXGetSyncValuesOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXGetSyncValuesOML_Lazy(IntPtr dpy, nuint drawable, long* ust, long* msc, long* sbc)
        {
            if (_glXGetSyncValuesOML_fnptr == null)
                _glXGetSyncValuesOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long*, long*, long*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXGetSyncValuesOML");
            return _glXGetSyncValuesOML_fnptr(dpy, drawable, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>glXGetTransparentIndexSUN</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, ulong*, int> _glXGetTransparentIndexSUN_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetTransparentIndexSUN_Lazy(IntPtr dpy, nuint overlay, nuint underlay, ulong* pTransparentIndex)
        {
            if (_glXGetTransparentIndexSUN_fnptr == null)
                _glXGetTransparentIndexSUN_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, ulong*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetTransparentIndexSUN");
            return _glXGetTransparentIndexSUN_fnptr(dpy, overlay, underlay, pTransparentIndex);
        }
        
        /// <summary><b>[entry point: <c>glXGetVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint*, int> _glXGetVideoDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetVideoDeviceNV_Lazy(IntPtr dpy, int screen, int numVideoDevices, uint* pVideoDevice)
        {
            if (_glXGetVideoDeviceNV_fnptr == null)
                _glXGetVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int, int, uint*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetVideoDeviceNV");
            return _glXGetVideoDeviceNV_fnptr(dpy, screen, numVideoDevices, pVideoDevice);
        }
        
        /// <summary><b>[entry point: <c>glXGetVideoInfoNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, ulong*, ulong*, int> _glXGetVideoInfoNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetVideoInfoNV_Lazy(IntPtr dpy, int screen, uint VideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo)
        {
            if (_glXGetVideoInfoNV_fnptr == null)
                _glXGetVideoInfoNV_fnptr = (delegate* unmanaged<IntPtr, int, uint, ulong*, ulong*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetVideoInfoNV");
            return _glXGetVideoInfoNV_fnptr(dpy, screen, VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
        }
        
        /// <summary><b>[entry point: <c>glXGetVideoSyncSGI</c>]</b></summary>
        public static delegate* unmanaged<uint*, int> _glXGetVideoSyncSGI_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXGetVideoSyncSGI_Lazy(uint* count)
        {
            if (_glXGetVideoSyncSGI_fnptr == null)
                _glXGetVideoSyncSGI_fnptr = (delegate* unmanaged<uint*, int>)GLXLoader.BindingsContext.GetProcAddress("glXGetVideoSyncSGI");
            return _glXGetVideoSyncSGI_fnptr(count);
        }
        
        /// <summary><b>[entry point: <c>glXGetVisualFromFBConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr> _glXGetVisualFromFBConfig_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetVisualFromFBConfig_Lazy(IntPtr dpy, IntPtr config)
        {
            if (_glXGetVisualFromFBConfig_fnptr == null)
                _glXGetVisualFromFBConfig_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetVisualFromFBConfig");
            return _glXGetVisualFromFBConfig_fnptr(dpy, config);
        }
        
        /// <summary><b>[entry point: <c>glXGetVisualFromFBConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr> _glXGetVisualFromFBConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXGetVisualFromFBConfigSGIX_Lazy(IntPtr dpy, IntPtr config)
        {
            if (_glXGetVisualFromFBConfigSGIX_fnptr == null)
                _glXGetVisualFromFBConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXGetVisualFromFBConfigSGIX");
            return _glXGetVisualFromFBConfigSGIX_fnptr(dpy, config);
        }
        
        /// <summary><b>[entry point: <c>glXHyperpipeAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void*, int> _glXHyperpipeAttribSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXHyperpipeAttribSGIX_Lazy(IntPtr dpy, int timeSlice, int attrib, int size, void* attribList)
        {
            if (_glXHyperpipeAttribSGIX_fnptr == null)
                _glXHyperpipeAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXHyperpipeAttribSGIX");
            return _glXHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList);
        }
        
        /// <summary><b>[entry point: <c>glXHyperpipeConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, GLXHyperpipeConfigSGIX*, int*, int> _glXHyperpipeConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXHyperpipeConfigSGIX_Lazy(IntPtr dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId)
        {
            if (_glXHyperpipeConfigSGIX_fnptr == null)
                _glXHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, GLXHyperpipeConfigSGIX*, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXHyperpipeConfigSGIX");
            return _glXHyperpipeConfigSGIX_fnptr(dpy, networkId, npipes, cfg, hpId);
        }
        
        /// <summary><b>[entry point: <c>glXImportContextEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, IntPtr> _glXImportContextEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr glXImportContextEXT_Lazy(IntPtr dpy, nuint contextID)
        {
            if (_glXImportContextEXT_fnptr == null)
                _glXImportContextEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, IntPtr>)GLXLoader.BindingsContext.GetProcAddress("glXImportContextEXT");
            return _glXImportContextEXT_fnptr(dpy, contextID);
        }
        
        /// <summary><b>[entry point: <c>glXIsDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, byte> _glXIsDirect_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXIsDirect_Lazy(IntPtr dpy, IntPtr ctx)
        {
            if (_glXIsDirect_fnptr == null)
                _glXIsDirect_fnptr = (delegate* unmanaged<IntPtr, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXIsDirect");
            return _glXIsDirect_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXJoinSwapGroupNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, uint, byte> _glXJoinSwapGroupNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXJoinSwapGroupNV_Lazy(IntPtr dpy, nuint drawable, uint group)
        {
            if (_glXJoinSwapGroupNV_fnptr == null)
                _glXJoinSwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, nuint, uint, byte>)GLXLoader.BindingsContext.GetProcAddress("glXJoinSwapGroupNV");
            return _glXJoinSwapGroupNV_fnptr(dpy, drawable, group);
        }
        
        /// <summary><b>[entry point: <c>glXJoinSwapGroupSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, void> _glXJoinSwapGroupSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXJoinSwapGroupSGIX_Lazy(IntPtr dpy, nuint drawable, nuint member)
        {
            if (_glXJoinSwapGroupSGIX_fnptr == null)
                _glXJoinSwapGroupSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXJoinSwapGroupSGIX");
            _glXJoinSwapGroupSGIX_fnptr(dpy, drawable, member);
        }
        
        /// <summary><b>[entry point: <c>glXLockVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXLockVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXLockVideoCaptureDeviceNV_Lazy(IntPtr dpy, nuint device)
        {
            if (_glXLockVideoCaptureDeviceNV_fnptr == null)
                _glXLockVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXLockVideoCaptureDeviceNV");
            _glXLockVideoCaptureDeviceNV_fnptr(dpy, device);
        }
        
        /// <summary><b>[entry point: <c>glXMakeAssociatedContextCurrentAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _glXMakeAssociatedContextCurrentAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXMakeAssociatedContextCurrentAMD_Lazy(IntPtr ctx)
        {
            if (_glXMakeAssociatedContextCurrentAMD_fnptr == null)
                _glXMakeAssociatedContextCurrentAMD_fnptr = (delegate* unmanaged<IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeAssociatedContextCurrentAMD");
            return _glXMakeAssociatedContextCurrentAMD_fnptr(ctx);
        }
        
        /// <summary><b>[entry point: <c>glXMakeContextCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte> _glXMakeContextCurrent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXMakeContextCurrent_Lazy(IntPtr dpy, nuint draw, nuint read, IntPtr ctx)
        {
            if (_glXMakeContextCurrent_fnptr == null)
                _glXMakeContextCurrent_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeContextCurrent");
            return _glXMakeContextCurrent_fnptr(dpy, draw, read, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXMakeCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, IntPtr, byte> _glXMakeCurrent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXMakeCurrent_Lazy(IntPtr dpy, nuint drawable, IntPtr ctx)
        {
            if (_glXMakeCurrent_fnptr == null)
                _glXMakeCurrent_fnptr = (delegate* unmanaged<IntPtr, nuint, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeCurrent");
            return _glXMakeCurrent_fnptr(dpy, drawable, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXMakeCurrentReadSGI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte> _glXMakeCurrentReadSGI_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXMakeCurrentReadSGI_Lazy(IntPtr dpy, nuint draw, nuint read, IntPtr ctx)
        {
            if (_glXMakeCurrentReadSGI_fnptr == null)
                _glXMakeCurrentReadSGI_fnptr = (delegate* unmanaged<IntPtr, nuint, nuint, IntPtr, byte>)GLXLoader.BindingsContext.GetProcAddress("glXMakeCurrentReadSGI");
            return _glXMakeCurrentReadSGI_fnptr(dpy, draw, read, ctx);
        }
        
        /// <summary><b>[entry point: <c>glXNamedCopyBufferSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void> _glXNamedCopyBufferSubDataNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXNamedCopyBufferSubDataNV_Lazy(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
        {
            if (_glXNamedCopyBufferSubDataNV_fnptr == null)
                _glXNamedCopyBufferSubDataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, uint, uint, IntPtr, IntPtr, nint, void>)GLXLoader.BindingsContext.GetProcAddress("glXNamedCopyBufferSubDataNV");
            _glXNamedCopyBufferSubDataNV_fnptr(dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
        }
        
        /// <summary><b>[entry point: <c>glXQueryChannelDeltasSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int> _glXQueryChannelDeltasSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryChannelDeltasSGIX_Lazy(IntPtr display, int screen, int channel, int* x, int* y, int* w, int* h)
        {
            if (_glXQueryChannelDeltasSGIX_fnptr == null)
                _glXQueryChannelDeltasSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryChannelDeltasSGIX");
            return _glXQueryChannelDeltasSGIX_fnptr(display, screen, channel, x, y, w, h);
        }
        
        /// <summary><b>[entry point: <c>glXQueryChannelRectSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int> _glXQueryChannelRectSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryChannelRectSGIX_Lazy(IntPtr display, int screen, int channel, int* dx, int* dy, int* dw, int* dh)
        {
            if (_glXQueryChannelRectSGIX_fnptr == null)
                _glXQueryChannelRectSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, int*, int*, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryChannelRectSGIX");
            return _glXQueryChannelRectSGIX_fnptr(display, screen, channel, dx, dy, dw, dh);
        }
        
        /// <summary><b>[entry point: <c>glXQueryContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXQueryContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryContext_Lazy(IntPtr dpy, IntPtr ctx, int attribute, int* value)
        {
            if (_glXQueryContext_fnptr == null)
                _glXQueryContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryContext");
            return _glXQueryContext_fnptr(dpy, ctx, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryContextInfoEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _glXQueryContextInfoEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryContextInfoEXT_Lazy(IntPtr dpy, IntPtr context, int attribute, int* value)
        {
            if (_glXQueryContextInfoEXT_fnptr == null)
                _glXQueryContextInfoEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryContextInfoEXT");
            return _glXQueryContextInfoEXT_fnptr(dpy, context, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryCurrentRendererIntegerMESA</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, byte> _glXQueryCurrentRendererIntegerMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryCurrentRendererIntegerMESA_Lazy(int attribute, uint* value)
        {
            if (_glXQueryCurrentRendererIntegerMESA_fnptr == null)
                _glXQueryCurrentRendererIntegerMESA_fnptr = (delegate* unmanaged<int, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryCurrentRendererIntegerMESA");
            return _glXQueryCurrentRendererIntegerMESA_fnptr(attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryCurrentRendererStringMESA</c>]</b></summary>
        public static delegate* unmanaged<int, byte*> _glXQueryCurrentRendererStringMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* glXQueryCurrentRendererStringMESA_Lazy(int attribute)
        {
            if (_glXQueryCurrentRendererStringMESA_fnptr == null)
                _glXQueryCurrentRendererStringMESA_fnptr = (delegate* unmanaged<int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryCurrentRendererStringMESA");
            return _glXQueryCurrentRendererStringMESA_fnptr(attribute);
        }
        
        /// <summary><b>[entry point: <c>glXQueryDrawable</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, uint*, void> _glXQueryDrawable_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXQueryDrawable_Lazy(IntPtr dpy, nuint draw, int attribute, uint* value)
        {
            if (_glXQueryDrawable_fnptr == null)
                _glXQueryDrawable_fnptr = (delegate* unmanaged<IntPtr, nuint, int, uint*, void>)GLXLoader.BindingsContext.GetProcAddress("glXQueryDrawable");
            _glXQueryDrawable_fnptr(dpy, draw, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryExtension</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int*, byte> _glXQueryExtension_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryExtension_Lazy(IntPtr dpy, int* errorb, int* @event)
        {
            if (_glXQueryExtension_fnptr == null)
                _glXQueryExtension_fnptr = (delegate* unmanaged<IntPtr, int*, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryExtension");
            return _glXQueryExtension_fnptr(dpy, errorb, @event);
        }
        
        /// <summary><b>[entry point: <c>glXQueryExtensionsString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _glXQueryExtensionsString_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* glXQueryExtensionsString_Lazy(IntPtr dpy, int screen)
        {
            if (_glXQueryExtensionsString_fnptr == null)
                _glXQueryExtensionsString_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryExtensionsString");
            return _glXQueryExtensionsString_fnptr(dpy, screen);
        }
        
        /// <summary><b>[entry point: <c>glXQueryFrameCountNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint*, byte> _glXQueryFrameCountNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryFrameCountNV_Lazy(IntPtr dpy, int screen, uint* count)
        {
            if (_glXQueryFrameCountNV_fnptr == null)
                _glXQueryFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, int, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryFrameCountNV");
            return _glXQueryFrameCountNV_fnptr(dpy, screen, count);
        }
        
        /// <summary><b>[entry point: <c>glXQueryGLXPbufferSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, uint*, void> _glXQueryGLXPbufferSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXQueryGLXPbufferSGIX_Lazy(IntPtr dpy, nuint pbuf, int attribute, uint* value)
        {
            if (_glXQueryGLXPbufferSGIX_fnptr == null)
                _glXQueryGLXPbufferSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, int, uint*, void>)GLXLoader.BindingsContext.GetProcAddress("glXQueryGLXPbufferSGIX");
            _glXQueryGLXPbufferSGIX_fnptr(dpy, pbuf, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void*, int> _glXQueryHyperpipeAttribSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryHyperpipeAttribSGIX_Lazy(IntPtr dpy, int timeSlice, int attrib, int size, void* returnAttribList)
        {
            if (_glXQueryHyperpipeAttribSGIX_fnptr == null)
                _glXQueryHyperpipeAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeAttribSGIX");
            return _glXQueryHyperpipeAttribSGIX_fnptr(dpy, timeSlice, attrib, size, returnAttribList);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeBestAttribSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void*, void*, int> _glXQueryHyperpipeBestAttribSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryHyperpipeBestAttribSGIX_Lazy(IntPtr dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList)
        {
            if (_glXQueryHyperpipeBestAttribSGIX_fnptr == null)
                _glXQueryHyperpipeBestAttribSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void*, void*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeBestAttribSGIX");
            return _glXQueryHyperpipeBestAttribSGIX_fnptr(dpy, timeSlice, attrib, size, attribList, returnAttribList);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeConfigSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, GLXHyperpipeConfigSGIX*> _glXQueryHyperpipeConfigSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static GLXHyperpipeConfigSGIX* glXQueryHyperpipeConfigSGIX_Lazy(IntPtr dpy, int hpId, int* npipes)
        {
            if (_glXQueryHyperpipeConfigSGIX_fnptr == null)
                _glXQueryHyperpipeConfigSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int*, GLXHyperpipeConfigSGIX*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeConfigSGIX");
            return _glXQueryHyperpipeConfigSGIX_fnptr(dpy, hpId, npipes);
        }
        
        /// <summary><b>[entry point: <c>glXQueryHyperpipeNetworkSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, GLXHyperpipeNetworkSGIX*> _glXQueryHyperpipeNetworkSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static GLXHyperpipeNetworkSGIX* glXQueryHyperpipeNetworkSGIX_Lazy(IntPtr dpy, int* npipes)
        {
            if (_glXQueryHyperpipeNetworkSGIX_fnptr == null)
                _glXQueryHyperpipeNetworkSGIX_fnptr = (delegate* unmanaged<IntPtr, int*, GLXHyperpipeNetworkSGIX*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryHyperpipeNetworkSGIX");
            return _glXQueryHyperpipeNetworkSGIX_fnptr(dpy, npipes);
        }
        
        /// <summary><b>[entry point: <c>glXQueryMaxSwapBarriersSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, byte> _glXQueryMaxSwapBarriersSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryMaxSwapBarriersSGIX_Lazy(IntPtr dpy, int screen, int* max)
        {
            if (_glXQueryMaxSwapBarriersSGIX_fnptr == null)
                _glXQueryMaxSwapBarriersSGIX_fnptr = (delegate* unmanaged<IntPtr, int, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryMaxSwapBarriersSGIX");
            return _glXQueryMaxSwapBarriersSGIX_fnptr(dpy, screen, max);
        }
        
        /// <summary><b>[entry point: <c>glXQueryMaxSwapGroupsNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint*, uint*, byte> _glXQueryMaxSwapGroupsNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryMaxSwapGroupsNV_Lazy(IntPtr dpy, int screen, uint* maxGroups, uint* maxBarriers)
        {
            if (_glXQueryMaxSwapGroupsNV_fnptr == null)
                _glXQueryMaxSwapGroupsNV_fnptr = (delegate* unmanaged<IntPtr, int, uint*, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryMaxSwapGroupsNV");
            return _glXQueryMaxSwapGroupsNV_fnptr(dpy, screen, maxGroups, maxBarriers);
        }
        
        /// <summary><b>[entry point: <c>glXQueryRendererIntegerMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, uint*, byte> _glXQueryRendererIntegerMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryRendererIntegerMESA_Lazy(IntPtr dpy, int screen, int renderer, int attribute, uint* value)
        {
            if (_glXQueryRendererIntegerMESA_fnptr == null)
                _glXQueryRendererIntegerMESA_fnptr = (delegate* unmanaged<IntPtr, int, int, int, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryRendererIntegerMESA");
            return _glXQueryRendererIntegerMESA_fnptr(dpy, screen, renderer, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXQueryRendererStringMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, byte*> _glXQueryRendererStringMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* glXQueryRendererStringMESA_Lazy(IntPtr dpy, int screen, int renderer, int attribute)
        {
            if (_glXQueryRendererStringMESA_fnptr == null)
                _glXQueryRendererStringMESA_fnptr = (delegate* unmanaged<IntPtr, int, int, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryRendererStringMESA");
            return _glXQueryRendererStringMESA_fnptr(dpy, screen, renderer, attribute);
        }
        
        /// <summary><b>[entry point: <c>glXQueryServerString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, byte*> _glXQueryServerString_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* glXQueryServerString_Lazy(IntPtr dpy, int screen, int name)
        {
            if (_glXQueryServerString_fnptr == null)
                _glXQueryServerString_fnptr = (delegate* unmanaged<IntPtr, int, int, byte*>)GLXLoader.BindingsContext.GetProcAddress("glXQueryServerString");
            return _glXQueryServerString_fnptr(dpy, screen, name);
        }
        
        /// <summary><b>[entry point: <c>glXQuerySwapGroupNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, uint*, uint*, byte> _glXQuerySwapGroupNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQuerySwapGroupNV_Lazy(IntPtr dpy, nuint drawable, uint* group, uint* barrier)
        {
            if (_glXQuerySwapGroupNV_fnptr == null)
                _glXQuerySwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, nuint, uint*, uint*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQuerySwapGroupNV");
            return _glXQuerySwapGroupNV_fnptr(dpy, drawable, group, barrier);
        }
        
        /// <summary><b>[entry point: <c>glXQueryVersion</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int*, byte> _glXQueryVersion_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXQueryVersion_Lazy(IntPtr dpy, int* maj, int* min)
        {
            if (_glXQueryVersion_fnptr == null)
                _glXQueryVersion_fnptr = (delegate* unmanaged<IntPtr, int*, int*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXQueryVersion");
            return _glXQueryVersion_fnptr(dpy, maj, min);
        }
        
        /// <summary><b>[entry point: <c>glXQueryVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, int*, int> _glXQueryVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXQueryVideoCaptureDeviceNV_Lazy(IntPtr dpy, nuint device, int attribute, int* value)
        {
            if (_glXQueryVideoCaptureDeviceNV_fnptr == null)
                _glXQueryVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, nuint, int, int*, int>)GLXLoader.BindingsContext.GetProcAddress("glXQueryVideoCaptureDeviceNV");
            return _glXQueryVideoCaptureDeviceNV_fnptr(dpy, device, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseBuffersMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, byte> _glXReleaseBuffersMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXReleaseBuffersMESA_Lazy(IntPtr dpy, nuint drawable)
        {
            if (_glXReleaseBuffersMESA_fnptr == null)
                _glXReleaseBuffersMESA_fnptr = (delegate* unmanaged<IntPtr, nuint, byte>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseBuffersMESA");
            return _glXReleaseBuffersMESA_fnptr(dpy, drawable);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseTexImageEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, void> _glXReleaseTexImageEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXReleaseTexImageEXT_Lazy(IntPtr dpy, nuint drawable, int buffer)
        {
            if (_glXReleaseTexImageEXT_fnptr == null)
                _glXReleaseTexImageEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseTexImageEXT");
            _glXReleaseTexImageEXT_fnptr(dpy, drawable, buffer);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXReleaseVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXReleaseVideoCaptureDeviceNV_Lazy(IntPtr dpy, nuint device)
        {
            if (_glXReleaseVideoCaptureDeviceNV_fnptr == null)
                _glXReleaseVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseVideoCaptureDeviceNV");
            _glXReleaseVideoCaptureDeviceNV_fnptr(dpy, device);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, int> _glXReleaseVideoDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXReleaseVideoDeviceNV_Lazy(IntPtr dpy, int screen, uint VideoDevice)
        {
            if (_glXReleaseVideoDeviceNV_fnptr == null)
                _glXReleaseVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int, uint, int>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseVideoDeviceNV");
            return _glXReleaseVideoDeviceNV_fnptr(dpy, screen, VideoDevice);
        }
        
        /// <summary><b>[entry point: <c>glXReleaseVideoImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int> _glXReleaseVideoImageNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXReleaseVideoImageNV_Lazy(IntPtr dpy, nuint pbuf)
        {
            if (_glXReleaseVideoImageNV_fnptr == null)
                _glXReleaseVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, nuint, int>)GLXLoader.BindingsContext.GetProcAddress("glXReleaseVideoImageNV");
            return _glXReleaseVideoImageNV_fnptr(dpy, pbuf);
        }
        
        /// <summary><b>[entry point: <c>glXResetFrameCountNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _glXResetFrameCountNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXResetFrameCountNV_Lazy(IntPtr dpy, int screen)
        {
            if (_glXResetFrameCountNV_fnptr == null)
                _glXResetFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, int, byte>)GLXLoader.BindingsContext.GetProcAddress("glXResetFrameCountNV");
            return _glXResetFrameCountNV_fnptr(dpy, screen);
        }
        
        /// <summary><b>[entry point: <c>glXSelectEvent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong, void> _glXSelectEvent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXSelectEvent_Lazy(IntPtr dpy, nuint draw, ulong event_mask)
        {
            if (_glXSelectEvent_fnptr == null)
                _glXSelectEvent_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong, void>)GLXLoader.BindingsContext.GetProcAddress("glXSelectEvent");
            _glXSelectEvent_fnptr(dpy, draw, event_mask);
        }
        
        /// <summary><b>[entry point: <c>glXSelectEventSGIX</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, ulong, void> _glXSelectEventSGIX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXSelectEventSGIX_Lazy(IntPtr dpy, nuint drawable, ulong mask)
        {
            if (_glXSelectEventSGIX_fnptr == null)
                _glXSelectEventSGIX_fnptr = (delegate* unmanaged<IntPtr, nuint, ulong, void>)GLXLoader.BindingsContext.GetProcAddress("glXSelectEventSGIX");
            _glXSelectEventSGIX_fnptr(dpy, drawable, mask);
        }
        
        /// <summary><b>[entry point: <c>glXSendPbufferToVideoNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, ulong*, byte, int> _glXSendPbufferToVideoNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXSendPbufferToVideoNV_Lazy(IntPtr dpy, nuint pbuf, int iBufferType, ulong* pulCounterPbuffer, byte bBlock)
        {
            if (_glXSendPbufferToVideoNV_fnptr == null)
                _glXSendPbufferToVideoNV_fnptr = (delegate* unmanaged<IntPtr, nuint, int, ulong*, byte, int>)GLXLoader.BindingsContext.GetProcAddress("glXSendPbufferToVideoNV");
            return _glXSendPbufferToVideoNV_fnptr(dpy, pbuf, iBufferType, pulCounterPbuffer, bBlock);
        }
        
        /// <summary><b>[entry point: <c>glXSet3DfxModeMESA</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _glXSet3DfxModeMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXSet3DfxModeMESA_Lazy(int mode)
        {
            if (_glXSet3DfxModeMESA_fnptr == null)
                _glXSet3DfxModeMESA_fnptr = (delegate* unmanaged<int, byte>)GLXLoader.BindingsContext.GetProcAddress("glXSet3DfxModeMESA");
            return _glXSet3DfxModeMESA_fnptr(mode);
        }
        
        /// <summary><b>[entry point: <c>glXSwapBuffers</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, void> _glXSwapBuffers_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXSwapBuffers_Lazy(IntPtr dpy, nuint drawable)
        {
            if (_glXSwapBuffers_fnptr == null)
                _glXSwapBuffers_fnptr = (delegate* unmanaged<IntPtr, nuint, void>)GLXLoader.BindingsContext.GetProcAddress("glXSwapBuffers");
            _glXSwapBuffers_fnptr(dpy, drawable);
        }
        
        /// <summary><b>[entry point: <c>glXSwapBuffersMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long, long, long, long> _glXSwapBuffersMscOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static long glXSwapBuffersMscOML_Lazy(IntPtr dpy, nuint drawable, long target_msc, long divisor, long remainder)
        {
            if (_glXSwapBuffersMscOML_fnptr == null)
                _glXSwapBuffersMscOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long, long, long, long>)GLXLoader.BindingsContext.GetProcAddress("glXSwapBuffersMscOML");
            return _glXSwapBuffersMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder);
        }
        
        /// <summary><b>[entry point: <c>glXSwapIntervalEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, int, void> _glXSwapIntervalEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXSwapIntervalEXT_Lazy(IntPtr dpy, nuint drawable, int interval)
        {
            if (_glXSwapIntervalEXT_fnptr == null)
                _glXSwapIntervalEXT_fnptr = (delegate* unmanaged<IntPtr, nuint, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXSwapIntervalEXT");
            _glXSwapIntervalEXT_fnptr(dpy, drawable, interval);
        }
        
        /// <summary><b>[entry point: <c>glXSwapIntervalMESA</c>]</b></summary>
        public static delegate* unmanaged<uint, int> _glXSwapIntervalMESA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXSwapIntervalMESA_Lazy(uint interval)
        {
            if (_glXSwapIntervalMESA_fnptr == null)
                _glXSwapIntervalMESA_fnptr = (delegate* unmanaged<uint, int>)GLXLoader.BindingsContext.GetProcAddress("glXSwapIntervalMESA");
            return _glXSwapIntervalMESA_fnptr(interval);
        }
        
        /// <summary><b>[entry point: <c>glXSwapIntervalSGI</c>]</b></summary>
        public static delegate* unmanaged<int, int> _glXSwapIntervalSGI_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXSwapIntervalSGI_Lazy(int interval)
        {
            if (_glXSwapIntervalSGI_fnptr == null)
                _glXSwapIntervalSGI_fnptr = (delegate* unmanaged<int, int>)GLXLoader.BindingsContext.GetProcAddress("glXSwapIntervalSGI");
            return _glXSwapIntervalSGI_fnptr(interval);
        }
        
        /// <summary><b>[entry point: <c>glXUseXFont</c>]</b></summary>
        public static delegate* unmanaged<nuint, int, int, int, void> _glXUseXFont_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXUseXFont_Lazy(nuint font, int first, int count, int list)
        {
            if (_glXUseXFont_fnptr == null)
                _glXUseXFont_fnptr = (delegate* unmanaged<nuint, int, int, int, void>)GLXLoader.BindingsContext.GetProcAddress("glXUseXFont");
            _glXUseXFont_fnptr(font, first, count, list);
        }
        
        /// <summary><b>[entry point: <c>glXWaitForMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long, long, long, long*, long*, long*, byte> _glXWaitForMscOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXWaitForMscOML_Lazy(IntPtr dpy, nuint drawable, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc)
        {
            if (_glXWaitForMscOML_fnptr == null)
                _glXWaitForMscOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long, long, long, long*, long*, long*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXWaitForMscOML");
            return _glXWaitForMscOML_fnptr(dpy, drawable, target_msc, divisor, remainder, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>glXWaitForSbcOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, nuint, long, long*, long*, long*, byte> _glXWaitForSbcOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte glXWaitForSbcOML_Lazy(IntPtr dpy, nuint drawable, long target_sbc, long* ust, long* msc, long* sbc)
        {
            if (_glXWaitForSbcOML_fnptr == null)
                _glXWaitForSbcOML_fnptr = (delegate* unmanaged<IntPtr, nuint, long, long*, long*, long*, byte>)GLXLoader.BindingsContext.GetProcAddress("glXWaitForSbcOML");
            return _glXWaitForSbcOML_fnptr(dpy, drawable, target_sbc, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>glXWaitGL</c>]</b></summary>
        public static delegate* unmanaged<void> _glXWaitGL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXWaitGL_Lazy()
        {
            if (_glXWaitGL_fnptr == null)
                _glXWaitGL_fnptr = (delegate* unmanaged<void>)GLXLoader.BindingsContext.GetProcAddress("glXWaitGL");
            _glXWaitGL_fnptr();
        }
        
        /// <summary><b>[entry point: <c>glXWaitVideoSyncSGI</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint*, int> _glXWaitVideoSyncSGI_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int glXWaitVideoSyncSGI_Lazy(int divisor, int remainder, uint* count)
        {
            if (_glXWaitVideoSyncSGI_fnptr == null)
                _glXWaitVideoSyncSGI_fnptr = (delegate* unmanaged<int, int, uint*, int>)GLXLoader.BindingsContext.GetProcAddress("glXWaitVideoSyncSGI");
            return _glXWaitVideoSyncSGI_fnptr(divisor, remainder, count);
        }
        
        /// <summary><b>[entry point: <c>glXWaitX</c>]</b></summary>
        public static delegate* unmanaged<void> _glXWaitX_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void glXWaitX_Lazy()
        {
            if (_glXWaitX_fnptr == null)
                _glXWaitX_fnptr = (delegate* unmanaged<void>)GLXLoader.BindingsContext.GetProcAddress("glXWaitX");
            _glXWaitX_fnptr();
        }
        
    }
}
