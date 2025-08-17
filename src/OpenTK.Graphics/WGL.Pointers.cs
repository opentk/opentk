// This file is auto generated, do not edit. Generated: 2025-08-17 15:26:47 GMT+02:00
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Wgl
{
    /// <summary>A collection of all function pointers to all OpenGL entry points.</summary>
    public static unsafe partial class WglPointers
    {
        /// <summary><b>[entry point: <c>ChoosePixelFormat</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, PixelFormatDescriptor*, int> _ChoosePixelFormat_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int ChoosePixelFormat_Lazy(IntPtr hDc, PixelFormatDescriptor* pPfd)
        {
            if (_ChoosePixelFormat_fnptr == null)
            {
                _ChoosePixelFormat_fnptr = (delegate* unmanaged<IntPtr, PixelFormatDescriptor*, int>)WGLLoader.BindingsContext.GetProcAddress("ChoosePixelFormat");
            }
            return _ChoosePixelFormat_fnptr(hDc, pPfd);
        }
        
        /// <summary><b>[entry point: <c>DescribePixelFormat</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, PixelFormatDescriptor*, int> _DescribePixelFormat_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int DescribePixelFormat_Lazy(IntPtr hdc, int ipfd, uint cjpfd, PixelFormatDescriptor* ppfd)
        {
            if (_DescribePixelFormat_fnptr == null)
            {
                _DescribePixelFormat_fnptr = (delegate* unmanaged<IntPtr, int, uint, PixelFormatDescriptor*, int>)WGLLoader.BindingsContext.GetProcAddress("DescribePixelFormat");
            }
            return _DescribePixelFormat_fnptr(hdc, ipfd, cjpfd, ppfd);
        }
        
        /// <summary><b>[entry point: <c>GetEnhMetaFilePixelFormat</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, PixelFormatDescriptor*, uint> _GetEnhMetaFilePixelFormat_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint GetEnhMetaFilePixelFormat_Lazy(IntPtr hemf, uint cbBuffer, PixelFormatDescriptor* ppfd)
        {
            if (_GetEnhMetaFilePixelFormat_fnptr == null)
            {
                _GetEnhMetaFilePixelFormat_fnptr = (delegate* unmanaged<IntPtr, uint, PixelFormatDescriptor*, uint>)WGLLoader.BindingsContext.GetProcAddress("GetEnhMetaFilePixelFormat");
            }
            return _GetEnhMetaFilePixelFormat_fnptr(hemf, cbBuffer, ppfd);
        }
        
        /// <summary><b>[entry point: <c>GetPixelFormat</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _GetPixelFormat_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int GetPixelFormat_Lazy(IntPtr hdc)
        {
            if (_GetPixelFormat_fnptr == null)
            {
                _GetPixelFormat_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("GetPixelFormat");
            }
            return _GetPixelFormat_fnptr(hdc);
        }
        
        /// <summary><b>[entry point: <c>SetPixelFormat</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, PixelFormatDescriptor*, int> _SetPixelFormat_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int SetPixelFormat_Lazy(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd)
        {
            if (_SetPixelFormat_fnptr == null)
            {
                _SetPixelFormat_fnptr = (delegate* unmanaged<IntPtr, int, PixelFormatDescriptor*, int>)WGLLoader.BindingsContext.GetProcAddress("SetPixelFormat");
            }
            return _SetPixelFormat_fnptr(hdc, ipfd, ppfd);
        }
        
        /// <summary><b>[entry point: <c>SwapBuffers</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _SwapBuffers_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int SwapBuffers_Lazy(IntPtr hdc)
        {
            if (_SwapBuffers_fnptr == null)
            {
                _SwapBuffers_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("SwapBuffers");
            }
            return _SwapBuffers_fnptr(hdc);
        }
        
        /// <summary><b>[entry point: <c>wglAllocateMemoryNV</c>]</b></summary>
        public static delegate* unmanaged<int, float, float, float, void*> _wglAllocateMemoryNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void* wglAllocateMemoryNV_Lazy(int size, float readfreq, float writefreq, float priority)
        {
            if (_wglAllocateMemoryNV_fnptr == null)
            {
                _wglAllocateMemoryNV_fnptr = (delegate* unmanaged<int, float, float, float, void*>)WGLLoader.BindingsContext.GetProcAddress("wglAllocateMemoryNV");
            }
            return _wglAllocateMemoryNV_fnptr(size, readfreq, writefreq, priority);
        }
        
        /// <summary><b>[entry point: <c>wglAssociateImageBufferEventsI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, uint*, uint, int> _wglAssociateImageBufferEventsI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglAssociateImageBufferEventsI3D_Lazy(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, uint* pSize, uint count)
        {
            if (_wglAssociateImageBufferEventsI3D_fnptr == null)
            {
                _wglAssociateImageBufferEventsI3D_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, uint*, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglAssociateImageBufferEventsI3D");
            }
            return _wglAssociateImageBufferEventsI3D_fnptr(hDC, pEvent, pAddress, pSize, count);
        }
        
        /// <summary><b>[entry point: <c>wglBeginFrameTrackingI3D</c>]</b></summary>
        public static delegate* unmanaged<int> _wglBeginFrameTrackingI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglBeginFrameTrackingI3D_Lazy()
        {
            if (_wglBeginFrameTrackingI3D_fnptr == null)
            {
                _wglBeginFrameTrackingI3D_fnptr = (delegate* unmanaged<int>)WGLLoader.BindingsContext.GetProcAddress("wglBeginFrameTrackingI3D");
            }
            return _wglBeginFrameTrackingI3D_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglBindDisplayColorTableEXT</c>]</b></summary>
        public static delegate* unmanaged<ushort, byte> _wglBindDisplayColorTableEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte wglBindDisplayColorTableEXT_Lazy(ushort id)
        {
            if (_wglBindDisplayColorTableEXT_fnptr == null)
            {
                _wglBindDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort, byte>)WGLLoader.BindingsContext.GetProcAddress("wglBindDisplayColorTableEXT");
            }
            return _wglBindDisplayColorTableEXT_fnptr(id);
        }
        
        /// <summary><b>[entry point: <c>wglBindSwapBarrierNV</c>]</b></summary>
        public static delegate* unmanaged<uint, uint, int> _wglBindSwapBarrierNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglBindSwapBarrierNV_Lazy(uint group, uint barrier)
        {
            if (_wglBindSwapBarrierNV_fnptr == null)
            {
                _wglBindSwapBarrierNV_fnptr = (delegate* unmanaged<uint, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglBindSwapBarrierNV");
            }
            return _wglBindSwapBarrierNV_fnptr(group, barrier);
        }
        
        /// <summary><b>[entry point: <c>wglBindTexImageARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _wglBindTexImageARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglBindTexImageARB_Lazy(IntPtr hPbuffer, int iBuffer)
        {
            if (_wglBindTexImageARB_fnptr == null)
            {
                _wglBindTexImageARB_fnptr = (delegate* unmanaged<IntPtr, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglBindTexImageARB");
            }
            return _wglBindTexImageARB_fnptr(hPbuffer, iBuffer);
        }
        
        /// <summary><b>[entry point: <c>wglBindVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, int> _wglBindVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglBindVideoCaptureDeviceNV_Lazy(uint uVideoSlot, IntPtr hDevice)
        {
            if (_wglBindVideoCaptureDeviceNV_fnptr == null)
            {
                _wglBindVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<uint, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglBindVideoCaptureDeviceNV");
            }
            return _wglBindVideoCaptureDeviceNV_fnptr(uVideoSlot, hDevice);
        }
        
        /// <summary><b>[entry point: <c>wglBindVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr, int*, int> _wglBindVideoDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglBindVideoDeviceNV_Lazy(IntPtr hDc, uint uVideoSlot, IntPtr hVideoDevice, int* piAttribList)
        {
            if (_wglBindVideoDeviceNV_fnptr == null)
            {
                _wglBindVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglBindVideoDeviceNV");
            }
            return _wglBindVideoDeviceNV_fnptr(hDc, uVideoSlot, hVideoDevice, piAttribList);
        }
        
        /// <summary><b>[entry point: <c>wglBindVideoImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _wglBindVideoImageNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglBindVideoImageNV_Lazy(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer)
        {
            if (_wglBindVideoImageNV_fnptr == null)
            {
                _wglBindVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglBindVideoImageNV");
            }
            return _wglBindVideoImageNV_fnptr(hVideoDevice, hPbuffer, iVideoBuffer);
        }
        
        /// <summary><b>[entry point: <c>wglBlitContextFramebufferAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void> _wglBlitContextFramebufferAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void wglBlitContextFramebufferAMD_Lazy(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
        {
            if (_wglBlitContextFramebufferAMD_fnptr == null)
            {
                _wglBlitContextFramebufferAMD_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void>)WGLLoader.BindingsContext.GetProcAddress("wglBlitContextFramebufferAMD");
            }
            _wglBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        /// <summary><b>[entry point: <c>wglChoosePixelFormatARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int> _wglChoosePixelFormatARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglChoosePixelFormatARB_Lazy(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats)
        {
            if (_wglChoosePixelFormatARB_fnptr == null)
            {
                _wglChoosePixelFormatARB_fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglChoosePixelFormatARB");
            }
            return _wglChoosePixelFormatARB_fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }
        
        /// <summary><b>[entry point: <c>wglChoosePixelFormatEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int> _wglChoosePixelFormatEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglChoosePixelFormatEXT_Lazy(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats)
        {
            if (_wglChoosePixelFormatEXT_fnptr == null)
            {
                _wglChoosePixelFormatEXT_fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglChoosePixelFormatEXT");
            }
            return _wglChoosePixelFormatEXT_fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }
        
        /// <summary><b>[entry point: <c>wglCopyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, int> _wglCopyContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglCopyContext_Lazy(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask)
        {
            if (_wglCopyContext_fnptr == null)
            {
                _wglCopyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglCopyContext");
            }
            return _wglCopyContext_fnptr(hglrcSrc, hglrcDst, mask);
        }
        
        /// <summary><b>[entry point: <c>wglCopyImageSubDataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, int> _wglCopyImageSubDataNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglCopyImageSubDataNV_Lazy(IntPtr hSrcRC, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr hDstRC, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
        {
            if (_wglCopyImageSubDataNV_fnptr == null)
            {
                _wglCopyImageSubDataNV_fnptr = (delegate* unmanaged<IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglCopyImageSubDataNV");
            }
            return _wglCopyImageSubDataNV_fnptr(hSrcRC, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, hDstRC, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
        }
        
        /// <summary><b>[entry point: <c>wglCreateAffinityDCNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr*, IntPtr> _wglCreateAffinityDCNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateAffinityDCNV_Lazy(IntPtr* phGpuList)
        {
            if (_wglCreateAffinityDCNV_fnptr == null)
            {
                _wglCreateAffinityDCNV_fnptr = (delegate* unmanaged<IntPtr*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateAffinityDCNV");
            }
            return _wglCreateAffinityDCNV_fnptr(phGpuList);
        }
        
        /// <summary><b>[entry point: <c>wglCreateAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr> _wglCreateAssociatedContextAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateAssociatedContextAMD_Lazy(uint id)
        {
            if (_wglCreateAssociatedContextAMD_fnptr == null)
            {
                _wglCreateAssociatedContextAMD_fnptr = (delegate* unmanaged<uint, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateAssociatedContextAMD");
            }
            return _wglCreateAssociatedContextAMD_fnptr(id);
        }
        
        /// <summary><b>[entry point: <c>wglCreateAssociatedContextAttribsAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr, int*, IntPtr> _wglCreateAssociatedContextAttribsAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateAssociatedContextAttribsAMD_Lazy(uint id, IntPtr hShareContext, int* attribList)
        {
            if (_wglCreateAssociatedContextAttribsAMD_fnptr == null)
            {
                _wglCreateAssociatedContextAttribsAMD_fnptr = (delegate* unmanaged<uint, IntPtr, int*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateAssociatedContextAttribsAMD");
            }
            return _wglCreateAssociatedContextAttribsAMD_fnptr(id, hShareContext, attribList);
        }
        
        /// <summary><b>[entry point: <c>wglCreateBufferRegionARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, IntPtr> _wglCreateBufferRegionARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateBufferRegionARB_Lazy(IntPtr hDC, int iLayerPlane, uint uType)
        {
            if (_wglCreateBufferRegionARB_fnptr == null)
            {
                _wglCreateBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, int, uint, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateBufferRegionARB");
            }
            return _wglCreateBufferRegionARB_fnptr(hDC, iLayerPlane, uType);
        }
        
        /// <summary><b>[entry point: <c>wglCreateContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _wglCreateContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateContext_Lazy(IntPtr hDc)
        {
            if (_wglCreateContext_fnptr == null)
            {
                _wglCreateContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateContext");
            }
            return _wglCreateContext_fnptr(hDc);
        }
        
        /// <summary><b>[entry point: <c>wglCreateContextAttribsARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr> _wglCreateContextAttribsARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateContextAttribsARB_Lazy(IntPtr hDC, IntPtr hShareContext, int* attribList)
        {
            if (_wglCreateContextAttribsARB_fnptr == null)
            {
                _wglCreateContextAttribsARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateContextAttribsARB");
            }
            return _wglCreateContextAttribsARB_fnptr(hDC, hShareContext, attribList);
        }
        
        /// <summary><b>[entry point: <c>wglCreateDisplayColorTableEXT</c>]</b></summary>
        public static delegate* unmanaged<ushort, byte> _wglCreateDisplayColorTableEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte wglCreateDisplayColorTableEXT_Lazy(ushort id)
        {
            if (_wglCreateDisplayColorTableEXT_fnptr == null)
            {
                _wglCreateDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort, byte>)WGLLoader.BindingsContext.GetProcAddress("wglCreateDisplayColorTableEXT");
            }
            return _wglCreateDisplayColorTableEXT_fnptr(id);
        }
        
        /// <summary><b>[entry point: <c>wglCreateImageBufferI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, IntPtr> _wglCreateImageBufferI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateImageBufferI3D_Lazy(IntPtr hDC, uint dwSize, uint uFlags)
        {
            if (_wglCreateImageBufferI3D_fnptr == null)
            {
                _wglCreateImageBufferI3D_fnptr = (delegate* unmanaged<IntPtr, uint, uint, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateImageBufferI3D");
            }
            return _wglCreateImageBufferI3D_fnptr(hDC, dwSize, uFlags);
        }
        
        /// <summary><b>[entry point: <c>wglCreateLayerContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr> _wglCreateLayerContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreateLayerContext_Lazy(IntPtr hDc, int level)
        {
            if (_wglCreateLayerContext_fnptr == null)
            {
                _wglCreateLayerContext_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreateLayerContext");
            }
            return _wglCreateLayerContext_fnptr(hDc, level);
        }
        
        /// <summary><b>[entry point: <c>wglCreatePbufferARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr> _wglCreatePbufferARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreatePbufferARB_Lazy(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
        {
            if (_wglCreatePbufferARB_fnptr == null)
            {
                _wglCreatePbufferARB_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreatePbufferARB");
            }
            return _wglCreatePbufferARB_fnptr(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
        }
        
        /// <summary><b>[entry point: <c>wglCreatePbufferEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr> _wglCreatePbufferEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglCreatePbufferEXT_Lazy(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
        {
            if (_wglCreatePbufferEXT_fnptr == null)
            {
                _wglCreatePbufferEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglCreatePbufferEXT");
            }
            return _wglCreatePbufferEXT_fnptr(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
        }
        
        /// <summary><b>[entry point: <c>wglDelayBeforeSwapNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, float, int> _wglDelayBeforeSwapNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDelayBeforeSwapNV_Lazy(IntPtr hDC, float seconds)
        {
            if (_wglDelayBeforeSwapNV_fnptr == null)
            {
                _wglDelayBeforeSwapNV_fnptr = (delegate* unmanaged<IntPtr, float, int>)WGLLoader.BindingsContext.GetProcAddress("wglDelayBeforeSwapNV");
            }
            return _wglDelayBeforeSwapNV_fnptr(hDC, seconds);
        }
        
        /// <summary><b>[entry point: <c>wglDeleteAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDeleteAssociatedContextAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDeleteAssociatedContextAMD_Lazy(IntPtr hglrc)
        {
            if (_wglDeleteAssociatedContextAMD_fnptr == null)
            {
                _wglDeleteAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDeleteAssociatedContextAMD");
            }
            return _wglDeleteAssociatedContextAMD_fnptr(hglrc);
        }
        
        /// <summary><b>[entry point: <c>wglDeleteBufferRegionARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _wglDeleteBufferRegionARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void wglDeleteBufferRegionARB_Lazy(IntPtr hRegion)
        {
            if (_wglDeleteBufferRegionARB_fnptr == null)
            {
                _wglDeleteBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, void>)WGLLoader.BindingsContext.GetProcAddress("wglDeleteBufferRegionARB");
            }
            _wglDeleteBufferRegionARB_fnptr(hRegion);
        }
        
        /// <summary><b>[entry point: <c>wglDeleteContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDeleteContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDeleteContext_Lazy(IntPtr oldContext)
        {
            if (_wglDeleteContext_fnptr == null)
            {
                _wglDeleteContext_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDeleteContext");
            }
            return _wglDeleteContext_fnptr(oldContext);
        }
        
        /// <summary><b>[entry point: <c>wglDeleteDCNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDeleteDCNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDeleteDCNV_Lazy(IntPtr hdc)
        {
            if (_wglDeleteDCNV_fnptr == null)
            {
                _wglDeleteDCNV_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDeleteDCNV");
            }
            return _wglDeleteDCNV_fnptr(hdc);
        }
        
        /// <summary><b>[entry point: <c>wglDescribeLayerPlane</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, LayerPlaneDescriptor*, int> _wglDescribeLayerPlane_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDescribeLayerPlane_Lazy(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, LayerPlaneDescriptor* plpd)
        {
            if (_wglDescribeLayerPlane_fnptr == null)
            {
                _wglDescribeLayerPlane_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, LayerPlaneDescriptor*, int>)WGLLoader.BindingsContext.GetProcAddress("wglDescribeLayerPlane");
            }
            return _wglDescribeLayerPlane_fnptr(hDc, pixelFormat, layerPlane, nBytes, plpd);
        }
        
        /// <summary><b>[entry point: <c>wglDestroyDisplayColorTableEXT</c>]</b></summary>
        public static delegate* unmanaged<ushort, void> _wglDestroyDisplayColorTableEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void wglDestroyDisplayColorTableEXT_Lazy(ushort id)
        {
            if (_wglDestroyDisplayColorTableEXT_fnptr == null)
            {
                _wglDestroyDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort, void>)WGLLoader.BindingsContext.GetProcAddress("wglDestroyDisplayColorTableEXT");
            }
            _wglDestroyDisplayColorTableEXT_fnptr(id);
        }
        
        /// <summary><b>[entry point: <c>wglDestroyImageBufferI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglDestroyImageBufferI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDestroyImageBufferI3D_Lazy(IntPtr hDC, IntPtr pAddress)
        {
            if (_wglDestroyImageBufferI3D_fnptr == null)
            {
                _wglDestroyImageBufferI3D_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDestroyImageBufferI3D");
            }
            return _wglDestroyImageBufferI3D_fnptr(hDC, pAddress);
        }
        
        /// <summary><b>[entry point: <c>wglDestroyPbufferARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDestroyPbufferARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDestroyPbufferARB_Lazy(IntPtr hPbuffer)
        {
            if (_wglDestroyPbufferARB_fnptr == null)
            {
                _wglDestroyPbufferARB_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDestroyPbufferARB");
            }
            return _wglDestroyPbufferARB_fnptr(hPbuffer);
        }
        
        /// <summary><b>[entry point: <c>wglDestroyPbufferEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDestroyPbufferEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDestroyPbufferEXT_Lazy(IntPtr hPbuffer)
        {
            if (_wglDestroyPbufferEXT_fnptr == null)
            {
                _wglDestroyPbufferEXT_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDestroyPbufferEXT");
            }
            return _wglDestroyPbufferEXT_fnptr(hPbuffer);
        }
        
        /// <summary><b>[entry point: <c>wglDisableFrameLockI3D</c>]</b></summary>
        public static delegate* unmanaged<int> _wglDisableFrameLockI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDisableFrameLockI3D_Lazy()
        {
            if (_wglDisableFrameLockI3D_fnptr == null)
            {
                _wglDisableFrameLockI3D_fnptr = (delegate* unmanaged<int>)WGLLoader.BindingsContext.GetProcAddress("wglDisableFrameLockI3D");
            }
            return _wglDisableFrameLockI3D_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglDisableGenlockI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDisableGenlockI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDisableGenlockI3D_Lazy(IntPtr hDC)
        {
            if (_wglDisableGenlockI3D_fnptr == null)
            {
                _wglDisableGenlockI3D_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDisableGenlockI3D");
            }
            return _wglDisableGenlockI3D_fnptr(hDC);
        }
        
        /// <summary><b>[entry point: <c>wglDXCloseDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglDXCloseDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDXCloseDeviceNV_Lazy(IntPtr hDevice)
        {
            if (_wglDXCloseDeviceNV_fnptr == null)
            {
                _wglDXCloseDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDXCloseDeviceNV");
            }
            return _wglDXCloseDeviceNV_fnptr(hDevice);
        }
        
        /// <summary><b>[entry point: <c>wglDXLockObjectsNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _wglDXLockObjectsNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDXLockObjectsNV_Lazy(IntPtr hDevice, int count, IntPtr* hObjects)
        {
            if (_wglDXLockObjectsNV_fnptr == null)
            {
                _wglDXLockObjectsNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)WGLLoader.BindingsContext.GetProcAddress("wglDXLockObjectsNV");
            }
            return _wglDXLockObjectsNV_fnptr(hDevice, count, hObjects);
        }
        
        /// <summary><b>[entry point: <c>wglDXObjectAccessNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglDXObjectAccessNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDXObjectAccessNV_Lazy(IntPtr hObject, uint access)
        {
            if (_wglDXObjectAccessNV_fnptr == null)
            {
                _wglDXObjectAccessNV_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglDXObjectAccessNV");
            }
            return _wglDXObjectAccessNV_fnptr(hObject, access);
        }
        
        /// <summary><b>[entry point: <c>wglDXOpenDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<void*, IntPtr> _wglDXOpenDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglDXOpenDeviceNV_Lazy(void* dxDevice)
        {
            if (_wglDXOpenDeviceNV_fnptr == null)
            {
                _wglDXOpenDeviceNV_fnptr = (delegate* unmanaged<void*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglDXOpenDeviceNV");
            }
            return _wglDXOpenDeviceNV_fnptr(dxDevice);
        }
        
        /// <summary><b>[entry point: <c>wglDXRegisterObjectNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, uint, uint, uint, IntPtr> _wglDXRegisterObjectNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglDXRegisterObjectNV_Lazy(IntPtr hDevice, void* dxObject, uint name, uint type, uint access)
        {
            if (_wglDXRegisterObjectNV_fnptr == null)
            {
                _wglDXRegisterObjectNV_fnptr = (delegate* unmanaged<IntPtr, void*, uint, uint, uint, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglDXRegisterObjectNV");
            }
            return _wglDXRegisterObjectNV_fnptr(hDevice, dxObject, name, type, access);
        }
        
        /// <summary><b>[entry point: <c>wglDXSetResourceShareHandleNV</c>]</b></summary>
        public static delegate* unmanaged<void*, IntPtr, int> _wglDXSetResourceShareHandleNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDXSetResourceShareHandleNV_Lazy(void* dxObject, IntPtr shareHandle)
        {
            if (_wglDXSetResourceShareHandleNV_fnptr == null)
            {
                _wglDXSetResourceShareHandleNV_fnptr = (delegate* unmanaged<void*, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDXSetResourceShareHandleNV");
            }
            return _wglDXSetResourceShareHandleNV_fnptr(dxObject, shareHandle);
        }
        
        /// <summary><b>[entry point: <c>wglDXUnlockObjectsNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _wglDXUnlockObjectsNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDXUnlockObjectsNV_Lazy(IntPtr hDevice, int count, IntPtr* hObjects)
        {
            if (_wglDXUnlockObjectsNV_fnptr == null)
            {
                _wglDXUnlockObjectsNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)WGLLoader.BindingsContext.GetProcAddress("wglDXUnlockObjectsNV");
            }
            return _wglDXUnlockObjectsNV_fnptr(hDevice, count, hObjects);
        }
        
        /// <summary><b>[entry point: <c>wglDXUnregisterObjectNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglDXUnregisterObjectNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglDXUnregisterObjectNV_Lazy(IntPtr hDevice, IntPtr hObject)
        {
            if (_wglDXUnregisterObjectNV_fnptr == null)
            {
                _wglDXUnregisterObjectNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglDXUnregisterObjectNV");
            }
            return _wglDXUnregisterObjectNV_fnptr(hDevice, hObject);
        }
        
        /// <summary><b>[entry point: <c>wglEnableFrameLockI3D</c>]</b></summary>
        public static delegate* unmanaged<int> _wglEnableFrameLockI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEnableFrameLockI3D_Lazy()
        {
            if (_wglEnableFrameLockI3D_fnptr == null)
            {
                _wglEnableFrameLockI3D_fnptr = (delegate* unmanaged<int>)WGLLoader.BindingsContext.GetProcAddress("wglEnableFrameLockI3D");
            }
            return _wglEnableFrameLockI3D_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglEnableGenlockI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglEnableGenlockI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEnableGenlockI3D_Lazy(IntPtr hDC)
        {
            if (_wglEnableGenlockI3D_fnptr == null)
            {
                _wglEnableGenlockI3D_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglEnableGenlockI3D");
            }
            return _wglEnableGenlockI3D_fnptr(hDC);
        }
        
        /// <summary><b>[entry point: <c>wglEndFrameTrackingI3D</c>]</b></summary>
        public static delegate* unmanaged<int> _wglEndFrameTrackingI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEndFrameTrackingI3D_Lazy()
        {
            if (_wglEndFrameTrackingI3D_fnptr == null)
            {
                _wglEndFrameTrackingI3D_fnptr = (delegate* unmanaged<int>)WGLLoader.BindingsContext.GetProcAddress("wglEndFrameTrackingI3D");
            }
            return _wglEndFrameTrackingI3D_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglEnumerateVideoCaptureDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, uint> _wglEnumerateVideoCaptureDevicesNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint wglEnumerateVideoCaptureDevicesNV_Lazy(IntPtr hDc, IntPtr* phDeviceList)
        {
            if (_wglEnumerateVideoCaptureDevicesNV_fnptr == null)
            {
                _wglEnumerateVideoCaptureDevicesNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, uint>)WGLLoader.BindingsContext.GetProcAddress("wglEnumerateVideoCaptureDevicesNV");
            }
            return _wglEnumerateVideoCaptureDevicesNV_fnptr(hDc, phDeviceList);
        }
        
        /// <summary><b>[entry point: <c>wglEnumerateVideoDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int> _wglEnumerateVideoDevicesNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEnumerateVideoDevicesNV_Lazy(IntPtr hDc, IntPtr* phDeviceList)
        {
            if (_wglEnumerateVideoDevicesNV_fnptr == null)
            {
                _wglEnumerateVideoDevicesNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)WGLLoader.BindingsContext.GetProcAddress("wglEnumerateVideoDevicesNV");
            }
            return _wglEnumerateVideoDevicesNV_fnptr(hDc, phDeviceList);
        }
        
        /// <summary><b>[entry point: <c>wglEnumGpuDevicesNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, _GPU_DEVICE*, int> _wglEnumGpuDevicesNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEnumGpuDevicesNV_Lazy(IntPtr hGpu, uint iDeviceIndex, _GPU_DEVICE* lpGpuDevice)
        {
            if (_wglEnumGpuDevicesNV_fnptr == null)
            {
                _wglEnumGpuDevicesNV_fnptr = (delegate* unmanaged<IntPtr, uint, _GPU_DEVICE*, int>)WGLLoader.BindingsContext.GetProcAddress("wglEnumGpuDevicesNV");
            }
            return _wglEnumGpuDevicesNV_fnptr(hGpu, iDeviceIndex, lpGpuDevice);
        }
        
        /// <summary><b>[entry point: <c>wglEnumGpusFromAffinityDCNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, int> _wglEnumGpusFromAffinityDCNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEnumGpusFromAffinityDCNV_Lazy(IntPtr hAffinityDC, uint iGpuIndex, IntPtr* hGpu)
        {
            if (_wglEnumGpusFromAffinityDCNV_fnptr == null)
            {
                _wglEnumGpusFromAffinityDCNV_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, int>)WGLLoader.BindingsContext.GetProcAddress("wglEnumGpusFromAffinityDCNV");
            }
            return _wglEnumGpusFromAffinityDCNV_fnptr(hAffinityDC, iGpuIndex, hGpu);
        }
        
        /// <summary><b>[entry point: <c>wglEnumGpusNV</c>]</b></summary>
        public static delegate* unmanaged<uint, IntPtr*, int> _wglEnumGpusNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglEnumGpusNV_Lazy(uint iGpuIndex, IntPtr* phGpu)
        {
            if (_wglEnumGpusNV_fnptr == null)
            {
                _wglEnumGpusNV_fnptr = (delegate* unmanaged<uint, IntPtr*, int>)WGLLoader.BindingsContext.GetProcAddress("wglEnumGpusNV");
            }
            return _wglEnumGpusNV_fnptr(iGpuIndex, phGpu);
        }
        
        /// <summary><b>[entry point: <c>wglFreeMemoryNV</c>]</b></summary>
        public static delegate* unmanaged<void*, void> _wglFreeMemoryNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static void wglFreeMemoryNV_Lazy(void* pointer)
        {
            if (_wglFreeMemoryNV_fnptr == null)
            {
                _wglFreeMemoryNV_fnptr = (delegate* unmanaged<void*, void>)WGLLoader.BindingsContext.GetProcAddress("wglFreeMemoryNV");
            }
            _wglFreeMemoryNV_fnptr(pointer);
        }
        
        /// <summary><b>[entry point: <c>wglGenlockSampleRateI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSampleRateI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGenlockSampleRateI3D_Lazy(IntPtr hDC, uint uRate)
        {
            if (_wglGenlockSampleRateI3D_fnptr == null)
            {
                _wglGenlockSampleRateI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglGenlockSampleRateI3D");
            }
            return _wglGenlockSampleRateI3D_fnptr(hDC, uRate);
        }
        
        /// <summary><b>[entry point: <c>wglGenlockSourceDelayI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSourceDelayI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGenlockSourceDelayI3D_Lazy(IntPtr hDC, uint uDelay)
        {
            if (_wglGenlockSourceDelayI3D_fnptr == null)
            {
                _wglGenlockSourceDelayI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglGenlockSourceDelayI3D");
            }
            return _wglGenlockSourceDelayI3D_fnptr(hDC, uDelay);
        }
        
        /// <summary><b>[entry point: <c>wglGenlockSourceEdgeI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSourceEdgeI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGenlockSourceEdgeI3D_Lazy(IntPtr hDC, uint uEdge)
        {
            if (_wglGenlockSourceEdgeI3D_fnptr == null)
            {
                _wglGenlockSourceEdgeI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglGenlockSourceEdgeI3D");
            }
            return _wglGenlockSourceEdgeI3D_fnptr(hDC, uEdge);
        }
        
        /// <summary><b>[entry point: <c>wglGenlockSourceI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSourceI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGenlockSourceI3D_Lazy(IntPtr hDC, uint uSource)
        {
            if (_wglGenlockSourceI3D_fnptr == null)
            {
                _wglGenlockSourceI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglGenlockSourceI3D");
            }
            return _wglGenlockSourceI3D_fnptr(hDC, uSource);
        }
        
        /// <summary><b>[entry point: <c>wglGetContextGPUIDAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint> _wglGetContextGPUIDAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint wglGetContextGPUIDAMD_Lazy(IntPtr hglrc)
        {
            if (_wglGetContextGPUIDAMD_fnptr == null)
            {
                _wglGetContextGPUIDAMD_fnptr = (delegate* unmanaged<IntPtr, uint>)WGLLoader.BindingsContext.GetProcAddress("wglGetContextGPUIDAMD");
            }
            return _wglGetContextGPUIDAMD_fnptr(hglrc);
        }
        
        /// <summary><b>[entry point: <c>wglGetCurrentAssociatedContextAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _wglGetCurrentAssociatedContextAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetCurrentAssociatedContextAMD_Lazy()
        {
            if (_wglGetCurrentAssociatedContextAMD_fnptr == null)
            {
                _wglGetCurrentAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetCurrentAssociatedContextAMD");
            }
            return _wglGetCurrentAssociatedContextAMD_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetCurrentContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _wglGetCurrentContext_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetCurrentContext_Lazy()
        {
            if (_wglGetCurrentContext_fnptr == null)
            {
                _wglGetCurrentContext_fnptr = (delegate* unmanaged<IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetCurrentContext");
            }
            return _wglGetCurrentContext_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetCurrentDC</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _wglGetCurrentDC_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetCurrentDC_Lazy()
        {
            if (_wglGetCurrentDC_fnptr == null)
            {
                _wglGetCurrentDC_fnptr = (delegate* unmanaged<IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetCurrentDC");
            }
            return _wglGetCurrentDC_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetCurrentReadDCARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _wglGetCurrentReadDCARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetCurrentReadDCARB_Lazy()
        {
            if (_wglGetCurrentReadDCARB_fnptr == null)
            {
                _wglGetCurrentReadDCARB_fnptr = (delegate* unmanaged<IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetCurrentReadDCARB");
            }
            return _wglGetCurrentReadDCARB_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetCurrentReadDCEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _wglGetCurrentReadDCEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetCurrentReadDCEXT_Lazy()
        {
            if (_wglGetCurrentReadDCEXT_fnptr == null)
            {
                _wglGetCurrentReadDCEXT_fnptr = (delegate* unmanaged<IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetCurrentReadDCEXT");
            }
            return _wglGetCurrentReadDCEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetDigitalVideoParametersI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _wglGetDigitalVideoParametersI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetDigitalVideoParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            if (_wglGetDigitalVideoParametersI3D_fnptr == null)
            {
                _wglGetDigitalVideoParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetDigitalVideoParametersI3D");
            }
            return _wglGetDigitalVideoParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglGetExtensionsStringARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*> _wglGetExtensionsStringARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* wglGetExtensionsStringARB_Lazy(IntPtr hdc)
        {
            if (_wglGetExtensionsStringARB_fnptr == null)
            {
                _wglGetExtensionsStringARB_fnptr = (delegate* unmanaged<IntPtr, byte*>)WGLLoader.BindingsContext.GetProcAddress("wglGetExtensionsStringARB");
            }
            return _wglGetExtensionsStringARB_fnptr(hdc);
        }
        
        /// <summary><b>[entry point: <c>wglGetExtensionsStringEXT</c>]</b></summary>
        public static delegate* unmanaged<byte*> _wglGetExtensionsStringEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte* wglGetExtensionsStringEXT_Lazy()
        {
            if (_wglGetExtensionsStringEXT_fnptr == null)
            {
                _wglGetExtensionsStringEXT_fnptr = (delegate* unmanaged<byte*>)WGLLoader.BindingsContext.GetProcAddress("wglGetExtensionsStringEXT");
            }
            return _wglGetExtensionsStringEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetFrameUsageI3D</c>]</b></summary>
        public static delegate* unmanaged<float*, int> _wglGetFrameUsageI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetFrameUsageI3D_Lazy(float* pUsage)
        {
            if (_wglGetFrameUsageI3D_fnptr == null)
            {
                _wglGetFrameUsageI3D_fnptr = (delegate* unmanaged<float*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetFrameUsageI3D");
            }
            return _wglGetFrameUsageI3D_fnptr(pUsage);
        }
        
        /// <summary><b>[entry point: <c>wglGetGammaTableI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int> _wglGetGammaTableI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGammaTableI3D_Lazy(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue)
        {
            if (_wglGetGammaTableI3D_fnptr == null)
            {
                _wglGetGammaTableI3D_fnptr = (delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGammaTableI3D");
            }
            return _wglGetGammaTableI3D_fnptr(hDC, iEntries, puRed, puGreen, puBlue);
        }
        
        /// <summary><b>[entry point: <c>wglGetGammaTableParametersI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _wglGetGammaTableParametersI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGammaTableParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            if (_wglGetGammaTableParametersI3D_fnptr == null)
            {
                _wglGetGammaTableParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGammaTableParametersI3D");
            }
            return _wglGetGammaTableParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglGetGenlockSampleRateI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSampleRateI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGenlockSampleRateI3D_Lazy(IntPtr hDC, uint* uRate)
        {
            if (_wglGetGenlockSampleRateI3D_fnptr == null)
            {
                _wglGetGenlockSampleRateI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGenlockSampleRateI3D");
            }
            return _wglGetGenlockSampleRateI3D_fnptr(hDC, uRate);
        }
        
        /// <summary><b>[entry point: <c>wglGetGenlockSourceDelayI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSourceDelayI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGenlockSourceDelayI3D_Lazy(IntPtr hDC, uint* uDelay)
        {
            if (_wglGetGenlockSourceDelayI3D_fnptr == null)
            {
                _wglGetGenlockSourceDelayI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGenlockSourceDelayI3D");
            }
            return _wglGetGenlockSourceDelayI3D_fnptr(hDC, uDelay);
        }
        
        /// <summary><b>[entry point: <c>wglGetGenlockSourceEdgeI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSourceEdgeI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGenlockSourceEdgeI3D_Lazy(IntPtr hDC, uint* uEdge)
        {
            if (_wglGetGenlockSourceEdgeI3D_fnptr == null)
            {
                _wglGetGenlockSourceEdgeI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGenlockSourceEdgeI3D");
            }
            return _wglGetGenlockSourceEdgeI3D_fnptr(hDC, uEdge);
        }
        
        /// <summary><b>[entry point: <c>wglGetGenlockSourceI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSourceI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGenlockSourceI3D_Lazy(IntPtr hDC, uint* uSource)
        {
            if (_wglGetGenlockSourceI3D_fnptr == null)
            {
                _wglGetGenlockSourceI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGenlockSourceI3D");
            }
            return _wglGetGenlockSourceI3D_fnptr(hDC, uSource);
        }
        
        /// <summary><b>[entry point: <c>wglGetGPUIDsAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, uint*, uint> _wglGetGPUIDsAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static uint wglGetGPUIDsAMD_Lazy(uint maxCount, uint* ids)
        {
            if (_wglGetGPUIDsAMD_fnptr == null)
            {
                _wglGetGPUIDsAMD_fnptr = (delegate* unmanaged<uint, uint*, uint>)WGLLoader.BindingsContext.GetProcAddress("wglGetGPUIDsAMD");
            }
            return _wglGetGPUIDsAMD_fnptr(maxCount, ids);
        }
        
        /// <summary><b>[entry point: <c>wglGetGPUInfoAMD</c>]</b></summary>
        public static delegate* unmanaged<uint, int, uint, uint, void*, int> _wglGetGPUInfoAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetGPUInfoAMD_Lazy(uint id, int property, uint dataType, uint size, void* data)
        {
            if (_wglGetGPUInfoAMD_fnptr == null)
            {
                _wglGetGPUInfoAMD_fnptr = (delegate* unmanaged<uint, int, uint, uint, void*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetGPUInfoAMD");
            }
            return _wglGetGPUInfoAMD_fnptr(id, property, dataType, size, data);
        }
        
        /// <summary><b>[entry point: <c>wglGetLayerPaletteEntries</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, uint*, int> _wglGetLayerPaletteEntries_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetLayerPaletteEntries_Lazy(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint* pcr)
        {
            if (_wglGetLayerPaletteEntries_fnptr == null)
            {
                _wglGetLayerPaletteEntries_fnptr = (delegate* unmanaged<IntPtr, int, int, int, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetLayerPaletteEntries");
            }
            return _wglGetLayerPaletteEntries_fnptr(hdc, iLayerPlane, iStart, cEntries, pcr);
        }
        
        /// <summary><b>[entry point: <c>wglGetMscRateOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int*, int> _wglGetMscRateOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetMscRateOML_Lazy(IntPtr hdc, int* numerator, int* denominator)
        {
            if (_wglGetMscRateOML_fnptr == null)
            {
                _wglGetMscRateOML_fnptr = (delegate* unmanaged<IntPtr, int*, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetMscRateOML");
            }
            return _wglGetMscRateOML_fnptr(hdc, numerator, denominator);
        }
        
        /// <summary><b>[entry point: <c>wglGetPbufferDCARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _wglGetPbufferDCARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetPbufferDCARB_Lazy(IntPtr hPbuffer)
        {
            if (_wglGetPbufferDCARB_fnptr == null)
            {
                _wglGetPbufferDCARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetPbufferDCARB");
            }
            return _wglGetPbufferDCARB_fnptr(hPbuffer);
        }
        
        /// <summary><b>[entry point: <c>wglGetPbufferDCEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _wglGetPbufferDCEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetPbufferDCEXT_Lazy(IntPtr hPbuffer)
        {
            if (_wglGetPbufferDCEXT_fnptr == null)
            {
                _wglGetPbufferDCEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetPbufferDCEXT");
            }
            return _wglGetPbufferDCEXT_fnptr(hPbuffer);
        }
        
        /// <summary><b>[entry point: <c>wglGetPixelFormatAttribfvARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int> _wglGetPixelFormatAttribfvARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetPixelFormatAttribfvARB_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues)
        {
            if (_wglGetPixelFormatAttribfvARB_fnptr == null)
            {
                _wglGetPixelFormatAttribfvARB_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribfvARB");
            }
            return _wglGetPixelFormatAttribfvARB_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
        }
        
        /// <summary><b>[entry point: <c>wglGetPixelFormatAttribfvEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int> _wglGetPixelFormatAttribfvEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetPixelFormatAttribfvEXT_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues)
        {
            if (_wglGetPixelFormatAttribfvEXT_fnptr == null)
            {
                _wglGetPixelFormatAttribfvEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribfvEXT");
            }
            return _wglGetPixelFormatAttribfvEXT_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
        }
        
        /// <summary><b>[entry point: <c>wglGetPixelFormatAttribivARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int> _wglGetPixelFormatAttribivARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetPixelFormatAttribivARB_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues)
        {
            if (_wglGetPixelFormatAttribivARB_fnptr == null)
            {
                _wglGetPixelFormatAttribivARB_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribivARB");
            }
            return _wglGetPixelFormatAttribivARB_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
        }
        
        /// <summary><b>[entry point: <c>wglGetPixelFormatAttribivEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int> _wglGetPixelFormatAttribivEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetPixelFormatAttribivEXT_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues)
        {
            if (_wglGetPixelFormatAttribivEXT_fnptr == null)
            {
                _wglGetPixelFormatAttribivEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribivEXT");
            }
            return _wglGetPixelFormatAttribivEXT_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
        }
        
        /// <summary><b>[entry point: <c>wglGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _wglGetProcAddress_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static IntPtr wglGetProcAddress_Lazy(byte* lpszProc)
        {
            if (_wglGetProcAddress_fnptr == null)
            {
                _wglGetProcAddress_fnptr = (delegate* unmanaged<byte*, IntPtr>)WGLLoader.BindingsContext.GetProcAddress("wglGetProcAddress");
            }
            return _wglGetProcAddress_fnptr(lpszProc);
        }
        
        /// <summary><b>[entry point: <c>wglGetSwapIntervalEXT</c>]</b></summary>
        public static delegate* unmanaged<int> _wglGetSwapIntervalEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetSwapIntervalEXT_Lazy()
        {
            if (_wglGetSwapIntervalEXT_fnptr == null)
            {
                _wglGetSwapIntervalEXT_fnptr = (delegate* unmanaged<int>)WGLLoader.BindingsContext.GetProcAddress("wglGetSwapIntervalEXT");
            }
            return _wglGetSwapIntervalEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>wglGetSyncValuesOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, long*, long*, long*, int> _wglGetSyncValuesOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetSyncValuesOML_Lazy(IntPtr hdc, long* ust, long* msc, long* sbc)
        {
            if (_wglGetSyncValuesOML_fnptr == null)
            {
                _wglGetSyncValuesOML_fnptr = (delegate* unmanaged<IntPtr, long*, long*, long*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetSyncValuesOML");
            }
            return _wglGetSyncValuesOML_fnptr(hdc, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>wglGetVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _wglGetVideoDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetVideoDeviceNV_Lazy(IntPtr hDC, int numDevices, IntPtr* hVideoDevice)
        {
            if (_wglGetVideoDeviceNV_fnptr == null)
            {
                _wglGetVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetVideoDeviceNV");
            }
            return _wglGetVideoDeviceNV_fnptr(hDC, numDevices, hVideoDevice);
        }
        
        /// <summary><b>[entry point: <c>wglGetVideoInfoNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, ulong*, ulong*, int> _wglGetVideoInfoNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglGetVideoInfoNV_Lazy(IntPtr hpVideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo)
        {
            if (_wglGetVideoInfoNV_fnptr == null)
            {
                _wglGetVideoInfoNV_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong*, int>)WGLLoader.BindingsContext.GetProcAddress("wglGetVideoInfoNV");
            }
            return _wglGetVideoInfoNV_fnptr(hpVideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
        }
        
        /// <summary><b>[entry point: <c>wglIsEnabledFrameLockI3D</c>]</b></summary>
        public static delegate* unmanaged<int*, int> _wglIsEnabledFrameLockI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglIsEnabledFrameLockI3D_Lazy(int* pFlag)
        {
            if (_wglIsEnabledFrameLockI3D_fnptr == null)
            {
                _wglIsEnabledFrameLockI3D_fnptr = (delegate* unmanaged<int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglIsEnabledFrameLockI3D");
            }
            return _wglIsEnabledFrameLockI3D_fnptr(pFlag);
        }
        
        /// <summary><b>[entry point: <c>wglIsEnabledGenlockI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int> _wglIsEnabledGenlockI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglIsEnabledGenlockI3D_Lazy(IntPtr hDC, int* pFlag)
        {
            if (_wglIsEnabledGenlockI3D_fnptr == null)
            {
                _wglIsEnabledGenlockI3D_fnptr = (delegate* unmanaged<IntPtr, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglIsEnabledGenlockI3D");
            }
            return _wglIsEnabledGenlockI3D_fnptr(hDC, pFlag);
        }
        
        /// <summary><b>[entry point: <c>wglJoinSwapGroupNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglJoinSwapGroupNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglJoinSwapGroupNV_Lazy(IntPtr hDC, uint group)
        {
            if (_wglJoinSwapGroupNV_fnptr == null)
            {
                _wglJoinSwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglJoinSwapGroupNV");
            }
            return _wglJoinSwapGroupNV_fnptr(hDC, group);
        }
        
        /// <summary><b>[entry point: <c>wglLoadDisplayColorTableEXT</c>]</b></summary>
        public static delegate* unmanaged<ushort*, uint, byte> _wglLoadDisplayColorTableEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static byte wglLoadDisplayColorTableEXT_Lazy(ushort* table, uint length)
        {
            if (_wglLoadDisplayColorTableEXT_fnptr == null)
            {
                _wglLoadDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort*, uint, byte>)WGLLoader.BindingsContext.GetProcAddress("wglLoadDisplayColorTableEXT");
            }
            return _wglLoadDisplayColorTableEXT_fnptr(table, length);
        }
        
        /// <summary><b>[entry point: <c>wglLockVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglLockVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglLockVideoCaptureDeviceNV_Lazy(IntPtr hDc, IntPtr hDevice)
        {
            if (_wglLockVideoCaptureDeviceNV_fnptr == null)
            {
                _wglLockVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglLockVideoCaptureDeviceNV");
            }
            return _wglLockVideoCaptureDeviceNV_fnptr(hDc, hDevice);
        }
        
        /// <summary><b>[entry point: <c>wglMakeAssociatedContextCurrentAMD</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglMakeAssociatedContextCurrentAMD_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglMakeAssociatedContextCurrentAMD_Lazy(IntPtr hglrc)
        {
            if (_wglMakeAssociatedContextCurrentAMD_fnptr == null)
            {
                _wglMakeAssociatedContextCurrentAMD_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglMakeAssociatedContextCurrentAMD");
            }
            return _wglMakeAssociatedContextCurrentAMD_fnptr(hglrc);
        }
        
        /// <summary><b>[entry point: <c>wglMakeContextCurrentARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _wglMakeContextCurrentARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglMakeContextCurrentARB_Lazy(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            if (_wglMakeContextCurrentARB_fnptr == null)
            {
                _wglMakeContextCurrentARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglMakeContextCurrentARB");
            }
            return _wglMakeContextCurrentARB_fnptr(hDrawDC, hReadDC, hglrc);
        }
        
        /// <summary><b>[entry point: <c>wglMakeContextCurrentEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _wglMakeContextCurrentEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglMakeContextCurrentEXT_Lazy(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            if (_wglMakeContextCurrentEXT_fnptr == null)
            {
                _wglMakeContextCurrentEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglMakeContextCurrentEXT");
            }
            return _wglMakeContextCurrentEXT_fnptr(hDrawDC, hReadDC, hglrc);
        }
        
        /// <summary><b>[entry point: <c>wglMakeCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglMakeCurrent_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglMakeCurrent_Lazy(IntPtr hDc, IntPtr newContext)
        {
            if (_wglMakeCurrent_fnptr == null)
            {
                _wglMakeCurrent_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglMakeCurrent");
            }
            return _wglMakeCurrent_fnptr(hDc, newContext);
        }
        
        /// <summary><b>[entry point: <c>wglQueryCurrentContextNV</c>]</b></summary>
        public static delegate* unmanaged<int, int*, int> _wglQueryCurrentContextNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryCurrentContextNV_Lazy(int iAttribute, int* piValue)
        {
            if (_wglQueryCurrentContextNV_fnptr == null)
            {
                _wglQueryCurrentContextNV_fnptr = (delegate* unmanaged<int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryCurrentContextNV");
            }
            return _wglQueryCurrentContextNV_fnptr(iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglQueryFrameCountNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, int> _wglQueryFrameCountNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryFrameCountNV_Lazy(IntPtr hDC, uint* count)
        {
            if (_wglQueryFrameCountNV_fnptr == null)
            {
                _wglQueryFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryFrameCountNV");
            }
            return _wglQueryFrameCountNV_fnptr(hDC, count);
        }
        
        /// <summary><b>[entry point: <c>wglQueryFrameLockMasterI3D</c>]</b></summary>
        public static delegate* unmanaged<int*, int> _wglQueryFrameLockMasterI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryFrameLockMasterI3D_Lazy(int* pFlag)
        {
            if (_wglQueryFrameLockMasterI3D_fnptr == null)
            {
                _wglQueryFrameLockMasterI3D_fnptr = (delegate* unmanaged<int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryFrameLockMasterI3D");
            }
            return _wglQueryFrameLockMasterI3D_fnptr(pFlag);
        }
        
        /// <summary><b>[entry point: <c>wglQueryFrameTrackingI3D</c>]</b></summary>
        public static delegate* unmanaged<uint*, uint*, float*, int> _wglQueryFrameTrackingI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryFrameTrackingI3D_Lazy(uint* pFrameCount, uint* pMissedFrames, float* pLastMissedUsage)
        {
            if (_wglQueryFrameTrackingI3D_fnptr == null)
            {
                _wglQueryFrameTrackingI3D_fnptr = (delegate* unmanaged<uint*, uint*, float*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryFrameTrackingI3D");
            }
            return _wglQueryFrameTrackingI3D_fnptr(pFrameCount, pMissedFrames, pLastMissedUsage);
        }
        
        /// <summary><b>[entry point: <c>wglQueryGenlockMaxSourceDelayI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, uint*, int> _wglQueryGenlockMaxSourceDelayI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryGenlockMaxSourceDelayI3D_Lazy(IntPtr hDC, uint* uMaxLineDelay, uint* uMaxPixelDelay)
        {
            if (_wglQueryGenlockMaxSourceDelayI3D_fnptr == null)
            {
                _wglQueryGenlockMaxSourceDelayI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryGenlockMaxSourceDelayI3D");
            }
            return _wglQueryGenlockMaxSourceDelayI3D_fnptr(hDC, uMaxLineDelay, uMaxPixelDelay);
        }
        
        /// <summary><b>[entry point: <c>wglQueryMaxSwapGroupsNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, uint*, int> _wglQueryMaxSwapGroupsNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryMaxSwapGroupsNV_Lazy(IntPtr hDC, uint* maxGroups, uint* maxBarriers)
        {
            if (_wglQueryMaxSwapGroupsNV_fnptr == null)
            {
                _wglQueryMaxSwapGroupsNV_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryMaxSwapGroupsNV");
            }
            return _wglQueryMaxSwapGroupsNV_fnptr(hDC, maxGroups, maxBarriers);
        }
        
        /// <summary><b>[entry point: <c>wglQueryPbufferARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _wglQueryPbufferARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryPbufferARB_Lazy(IntPtr hPbuffer, int iAttribute, int* piValue)
        {
            if (_wglQueryPbufferARB_fnptr == null)
            {
                _wglQueryPbufferARB_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryPbufferARB");
            }
            return _wglQueryPbufferARB_fnptr(hPbuffer, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglQueryPbufferEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _wglQueryPbufferEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryPbufferEXT_Lazy(IntPtr hPbuffer, int iAttribute, int* piValue)
        {
            if (_wglQueryPbufferEXT_fnptr == null)
            {
                _wglQueryPbufferEXT_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryPbufferEXT");
            }
            return _wglQueryPbufferEXT_fnptr(hPbuffer, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglQuerySwapGroupNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint*, uint*, int> _wglQuerySwapGroupNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQuerySwapGroupNV_Lazy(IntPtr hDC, uint* group, uint* barrier)
        {
            if (_wglQuerySwapGroupNV_fnptr == null)
            {
                _wglQuerySwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQuerySwapGroupNV");
            }
            return _wglQuerySwapGroupNV_fnptr(hDC, group, barrier);
        }
        
        /// <summary><b>[entry point: <c>wglQueryVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _wglQueryVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglQueryVideoCaptureDeviceNV_Lazy(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue)
        {
            if (_wglQueryVideoCaptureDeviceNV_fnptr == null)
            {
                _wglQueryVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglQueryVideoCaptureDeviceNV");
            }
            return _wglQueryVideoCaptureDeviceNV_fnptr(hDc, hDevice, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglRealizeLayerPalette</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int> _wglRealizeLayerPalette_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglRealizeLayerPalette_Lazy(IntPtr hdc, int iLayerPlane, int bRealize)
        {
            if (_wglRealizeLayerPalette_fnptr == null)
            {
                _wglRealizeLayerPalette_fnptr = (delegate* unmanaged<IntPtr, int, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglRealizeLayerPalette");
            }
            return _wglRealizeLayerPalette_fnptr(hdc, iLayerPlane, bRealize);
        }
        
        /// <summary><b>[entry point: <c>wglReleaseImageBufferEventsI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, uint, int> _wglReleaseImageBufferEventsI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleaseImageBufferEventsI3D_Lazy(IntPtr hDC, IntPtr* pAddress, uint count)
        {
            if (_wglReleaseImageBufferEventsI3D_fnptr == null)
            {
                _wglReleaseImageBufferEventsI3D_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleaseImageBufferEventsI3D");
            }
            return _wglReleaseImageBufferEventsI3D_fnptr(hDC, pAddress, count);
        }
        
        /// <summary><b>[entry point: <c>wglReleasePbufferDCARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglReleasePbufferDCARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleasePbufferDCARB_Lazy(IntPtr hPbuffer, IntPtr hDC)
        {
            if (_wglReleasePbufferDCARB_fnptr == null)
            {
                _wglReleasePbufferDCARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleasePbufferDCARB");
            }
            return _wglReleasePbufferDCARB_fnptr(hPbuffer, hDC);
        }
        
        /// <summary><b>[entry point: <c>wglReleasePbufferDCEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglReleasePbufferDCEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleasePbufferDCEXT_Lazy(IntPtr hPbuffer, IntPtr hDC)
        {
            if (_wglReleasePbufferDCEXT_fnptr == null)
            {
                _wglReleasePbufferDCEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleasePbufferDCEXT");
            }
            return _wglReleasePbufferDCEXT_fnptr(hPbuffer, hDC);
        }
        
        /// <summary><b>[entry point: <c>wglReleaseTexImageARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _wglReleaseTexImageARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleaseTexImageARB_Lazy(IntPtr hPbuffer, int iBuffer)
        {
            if (_wglReleaseTexImageARB_fnptr == null)
            {
                _wglReleaseTexImageARB_fnptr = (delegate* unmanaged<IntPtr, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleaseTexImageARB");
            }
            return _wglReleaseTexImageARB_fnptr(hPbuffer, iBuffer);
        }
        
        /// <summary><b>[entry point: <c>wglReleaseVideoCaptureDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglReleaseVideoCaptureDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleaseVideoCaptureDeviceNV_Lazy(IntPtr hDc, IntPtr hDevice)
        {
            if (_wglReleaseVideoCaptureDeviceNV_fnptr == null)
            {
                _wglReleaseVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleaseVideoCaptureDeviceNV");
            }
            return _wglReleaseVideoCaptureDeviceNV_fnptr(hDc, hDevice);
        }
        
        /// <summary><b>[entry point: <c>wglReleaseVideoDeviceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglReleaseVideoDeviceNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleaseVideoDeviceNV_Lazy(IntPtr hVideoDevice)
        {
            if (_wglReleaseVideoDeviceNV_fnptr == null)
            {
                _wglReleaseVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleaseVideoDeviceNV");
            }
            return _wglReleaseVideoDeviceNV_fnptr(hVideoDevice);
        }
        
        /// <summary><b>[entry point: <c>wglReleaseVideoImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _wglReleaseVideoImageNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglReleaseVideoImageNV_Lazy(IntPtr hPbuffer, int iVideoBuffer)
        {
            if (_wglReleaseVideoImageNV_fnptr == null)
            {
                _wglReleaseVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglReleaseVideoImageNV");
            }
            return _wglReleaseVideoImageNV_fnptr(hPbuffer, iVideoBuffer);
        }
        
        /// <summary><b>[entry point: <c>wglResetFrameCountNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _wglResetFrameCountNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglResetFrameCountNV_Lazy(IntPtr hDC)
        {
            if (_wglResetFrameCountNV_fnptr == null)
            {
                _wglResetFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglResetFrameCountNV");
            }
            return _wglResetFrameCountNV_fnptr(hDC);
        }
        
        /// <summary><b>[entry point: <c>wglRestoreBufferRegionARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int> _wglRestoreBufferRegionARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglRestoreBufferRegionARB_Lazy(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
        {
            if (_wglRestoreBufferRegionARB_fnptr == null)
            {
                _wglRestoreBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglRestoreBufferRegionARB");
            }
            return _wglRestoreBufferRegionARB_fnptr(hRegion, x, y, width, height, xSrc, ySrc);
        }
        
        /// <summary><b>[entry point: <c>wglSaveBufferRegionARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int> _wglSaveBufferRegionARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSaveBufferRegionARB_Lazy(IntPtr hRegion, int x, int y, int width, int height)
        {
            if (_wglSaveBufferRegionARB_fnptr == null)
            {
                _wglSaveBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglSaveBufferRegionARB");
            }
            return _wglSaveBufferRegionARB_fnptr(hRegion, x, y, width, height);
        }
        
        /// <summary><b>[entry point: <c>wglSendPbufferToVideoNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, ulong*, int, int> _wglSendPbufferToVideoNV_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSendPbufferToVideoNV_Lazy(IntPtr hPbuffer, int iBufferType, ulong* pulCounterPbuffer, int bBlock)
        {
            if (_wglSendPbufferToVideoNV_fnptr == null)
            {
                _wglSendPbufferToVideoNV_fnptr = (delegate* unmanaged<IntPtr, int, ulong*, int, int>)WGLLoader.BindingsContext.GetProcAddress("wglSendPbufferToVideoNV");
            }
            return _wglSendPbufferToVideoNV_fnptr(hPbuffer, iBufferType, pulCounterPbuffer, bBlock);
        }
        
        /// <summary><b>[entry point: <c>wglSetDigitalVideoParametersI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _wglSetDigitalVideoParametersI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSetDigitalVideoParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            if (_wglSetDigitalVideoParametersI3D_fnptr == null)
            {
                _wglSetDigitalVideoParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglSetDigitalVideoParametersI3D");
            }
            return _wglSetDigitalVideoParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglSetGammaTableI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int> _wglSetGammaTableI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSetGammaTableI3D_Lazy(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue)
        {
            if (_wglSetGammaTableI3D_fnptr == null)
            {
                _wglSetGammaTableI3D_fnptr = (delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int>)WGLLoader.BindingsContext.GetProcAddress("wglSetGammaTableI3D");
            }
            return _wglSetGammaTableI3D_fnptr(hDC, iEntries, puRed, puGreen, puBlue);
        }
        
        /// <summary><b>[entry point: <c>wglSetGammaTableParametersI3D</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _wglSetGammaTableParametersI3D_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSetGammaTableParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            if (_wglSetGammaTableParametersI3D_fnptr == null)
            {
                _wglSetGammaTableParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglSetGammaTableParametersI3D");
            }
            return _wglSetGammaTableParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        /// <summary><b>[entry point: <c>wglSetLayerPaletteEntries</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, uint*, int> _wglSetLayerPaletteEntries_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSetLayerPaletteEntries_Lazy(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint* pcr)
        {
            if (_wglSetLayerPaletteEntries_fnptr == null)
            {
                _wglSetLayerPaletteEntries_fnptr = (delegate* unmanaged<IntPtr, int, int, int, uint*, int>)WGLLoader.BindingsContext.GetProcAddress("wglSetLayerPaletteEntries");
            }
            return _wglSetLayerPaletteEntries_fnptr(hdc, iLayerPlane, iStart, cEntries, pcr);
        }
        
        /// <summary><b>[entry point: <c>wglSetPbufferAttribARB</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int> _wglSetPbufferAttribARB_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSetPbufferAttribARB_Lazy(IntPtr hPbuffer, int* piAttribList)
        {
            if (_wglSetPbufferAttribARB_fnptr == null)
            {
                _wglSetPbufferAttribARB_fnptr = (delegate* unmanaged<IntPtr, int*, int>)WGLLoader.BindingsContext.GetProcAddress("wglSetPbufferAttribARB");
            }
            return _wglSetPbufferAttribARB_fnptr(hPbuffer, piAttribList);
        }
        
        /// <summary><b>[entry point: <c>wglSetStereoEmitterState3DL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglSetStereoEmitterState3DL_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSetStereoEmitterState3DL_Lazy(IntPtr hDC, uint uState)
        {
            if (_wglSetStereoEmitterState3DL_fnptr == null)
            {
                _wglSetStereoEmitterState3DL_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglSetStereoEmitterState3DL");
            }
            return _wglSetStereoEmitterState3DL_fnptr(hDC, uState);
        }
        
        /// <summary><b>[entry point: <c>wglShareLists</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _wglShareLists_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglShareLists_Lazy(IntPtr hrcSrvShare, IntPtr hrcSrvSource)
        {
            if (_wglShareLists_fnptr == null)
            {
                _wglShareLists_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglShareLists");
            }
            return _wglShareLists_fnptr(hrcSrvShare, hrcSrvSource);
        }
        
        /// <summary><b>[entry point: <c>wglSwapBuffersMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, long, long, long, long> _wglSwapBuffersMscOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static long wglSwapBuffersMscOML_Lazy(IntPtr hdc, long target_msc, long divisor, long remainder)
        {
            if (_wglSwapBuffersMscOML_fnptr == null)
            {
                _wglSwapBuffersMscOML_fnptr = (delegate* unmanaged<IntPtr, long, long, long, long>)WGLLoader.BindingsContext.GetProcAddress("wglSwapBuffersMscOML");
            }
            return _wglSwapBuffersMscOML_fnptr(hdc, target_msc, divisor, remainder);
        }
        
        /// <summary><b>[entry point: <c>wglSwapIntervalEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int> _wglSwapIntervalEXT_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSwapIntervalEXT_Lazy(int interval)
        {
            if (_wglSwapIntervalEXT_fnptr == null)
            {
                _wglSwapIntervalEXT_fnptr = (delegate* unmanaged<int, int>)WGLLoader.BindingsContext.GetProcAddress("wglSwapIntervalEXT");
            }
            return _wglSwapIntervalEXT_fnptr(interval);
        }
        
        /// <summary><b>[entry point: <c>wglSwapLayerBuffers</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _wglSwapLayerBuffers_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglSwapLayerBuffers_Lazy(IntPtr hdc, uint fuFlags)
        {
            if (_wglSwapLayerBuffers_fnptr == null)
            {
                _wglSwapLayerBuffers_fnptr = (delegate* unmanaged<IntPtr, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglSwapLayerBuffers");
            }
            return _wglSwapLayerBuffers_fnptr(hdc, fuFlags);
        }
        
        /// <summary><b>[entry point: <c>wglSwapLayerBuffersMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, long, long, long, long> _wglSwapLayerBuffersMscOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static long wglSwapLayerBuffersMscOML_Lazy(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder)
        {
            if (_wglSwapLayerBuffersMscOML_fnptr == null)
            {
                _wglSwapLayerBuffersMscOML_fnptr = (delegate* unmanaged<IntPtr, int, long, long, long, long>)WGLLoader.BindingsContext.GetProcAddress("wglSwapLayerBuffersMscOML");
            }
            return _wglSwapLayerBuffersMscOML_fnptr(hdc, fuPlanes, target_msc, divisor, remainder);
        }
        
        /// <summary><b>[entry point: <c>wglUseFontBitmaps</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, int> _wglUseFontBitmaps_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglUseFontBitmaps_Lazy(IntPtr hDC, uint first, uint count, uint listBase)
        {
            if (_wglUseFontBitmaps_fnptr == null)
            {
                _wglUseFontBitmaps_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglUseFontBitmaps");
            }
            return _wglUseFontBitmaps_fnptr(hDC, first, count, listBase);
        }
        
        /// <summary><b>[entry point: <c>wglUseFontBitmapsA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, int> _wglUseFontBitmapsA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglUseFontBitmapsA_Lazy(IntPtr hDC, uint first, uint count, uint listBase)
        {
            if (_wglUseFontBitmapsA_fnptr == null)
            {
                _wglUseFontBitmapsA_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglUseFontBitmapsA");
            }
            return _wglUseFontBitmapsA_fnptr(hDC, first, count, listBase);
        }
        
        /// <summary><b>[entry point: <c>wglUseFontBitmapsW</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, int> _wglUseFontBitmapsW_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglUseFontBitmapsW_Lazy(IntPtr hDC, uint first, uint count, uint listBase)
        {
            if (_wglUseFontBitmapsW_fnptr == null)
            {
                _wglUseFontBitmapsW_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int>)WGLLoader.BindingsContext.GetProcAddress("wglUseFontBitmapsW");
            }
            return _wglUseFontBitmapsW_fnptr(hDC, first, count, listBase);
        }
        
        /// <summary><b>[entry point: <c>wglUseFontOutlines</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int> _wglUseFontOutlines_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglUseFontOutlines_Lazy(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
        {
            if (_wglUseFontOutlines_fnptr == null)
            {
                _wglUseFontOutlines_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglUseFontOutlines");
            }
            return _wglUseFontOutlines_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        }
        
        /// <summary><b>[entry point: <c>wglUseFontOutlinesA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int> _wglUseFontOutlinesA_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglUseFontOutlinesA_Lazy(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
        {
            if (_wglUseFontOutlinesA_fnptr == null)
            {
                _wglUseFontOutlinesA_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglUseFontOutlinesA");
            }
            return _wglUseFontOutlinesA_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        }
        
        /// <summary><b>[entry point: <c>wglUseFontOutlinesW</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int> _wglUseFontOutlinesW_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglUseFontOutlinesW_Lazy(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
        {
            if (_wglUseFontOutlinesW_fnptr == null)
            {
                _wglUseFontOutlinesW_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int>)WGLLoader.BindingsContext.GetProcAddress("wglUseFontOutlinesW");
            }
            return _wglUseFontOutlinesW_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        }
        
        /// <summary><b>[entry point: <c>wglWaitForMscOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, long, long, long, long*, long*, long*, int> _wglWaitForMscOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglWaitForMscOML_Lazy(IntPtr hdc, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc)
        {
            if (_wglWaitForMscOML_fnptr == null)
            {
                _wglWaitForMscOML_fnptr = (delegate* unmanaged<IntPtr, long, long, long, long*, long*, long*, int>)WGLLoader.BindingsContext.GetProcAddress("wglWaitForMscOML");
            }
            return _wglWaitForMscOML_fnptr(hdc, target_msc, divisor, remainder, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>wglWaitForSbcOML</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, long, long*, long*, long*, int> _wglWaitForSbcOML_fnptr;
        [MethodImpl(MethodImplOptions.NoInlining)]
        internal static int wglWaitForSbcOML_Lazy(IntPtr hdc, long target_sbc, long* ust, long* msc, long* sbc)
        {
            if (_wglWaitForSbcOML_fnptr == null)
            {
                _wglWaitForSbcOML_fnptr = (delegate* unmanaged<IntPtr, long, long*, long*, long*, int>)WGLLoader.BindingsContext.GetProcAddress("wglWaitForSbcOML");
            }
            return _wglWaitForSbcOML_fnptr(hdc, target_sbc, ust, msc, sbc);
        }
        
    }
}
