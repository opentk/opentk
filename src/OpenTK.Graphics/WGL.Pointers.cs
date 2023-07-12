// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Wgl
{
    /// <summary>A collection of all function pointers to all OpenGL entry points.</summary>
    public static unsafe partial class WGLPointers
    {
        internal static delegate* unmanaged<IntPtr, PixelFormatDescriptor*, int> _ChoosePixelFormat_fnptr = &ChoosePixelFormat_Lazy;
        [UnmanagedCallersOnly]
        private static int ChoosePixelFormat_Lazy(IntPtr hDc, PixelFormatDescriptor* pPfd)
        {
            _ChoosePixelFormat_fnptr = (delegate* unmanaged<IntPtr, PixelFormatDescriptor*, int>)GLLoader.BindingsContext.GetProcAddress("ChoosePixelFormat");
            return _ChoosePixelFormat_fnptr(hDc, pPfd);
        }
        
        internal static delegate* unmanaged<IntPtr, int, uint, PixelFormatDescriptor*, int> _DescribePixelFormat_fnptr = &DescribePixelFormat_Lazy;
        [UnmanagedCallersOnly]
        private static int DescribePixelFormat_Lazy(IntPtr hdc, int ipfd, uint cjpfd, PixelFormatDescriptor* ppfd)
        {
            _DescribePixelFormat_fnptr = (delegate* unmanaged<IntPtr, int, uint, PixelFormatDescriptor*, int>)GLLoader.BindingsContext.GetProcAddress("DescribePixelFormat");
            return _DescribePixelFormat_fnptr(hdc, ipfd, cjpfd, ppfd);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _GetPixelFormat_fnptr = &GetPixelFormat_Lazy;
        [UnmanagedCallersOnly]
        private static int GetPixelFormat_Lazy(IntPtr hdc)
        {
            _GetPixelFormat_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("GetPixelFormat");
            return _GetPixelFormat_fnptr(hdc);
        }
        
        internal static delegate* unmanaged<IntPtr, int, PixelFormatDescriptor*, int> _SetPixelFormat_fnptr = &SetPixelFormat_Lazy;
        [UnmanagedCallersOnly]
        private static int SetPixelFormat_Lazy(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd)
        {
            _SetPixelFormat_fnptr = (delegate* unmanaged<IntPtr, int, PixelFormatDescriptor*, int>)GLLoader.BindingsContext.GetProcAddress("SetPixelFormat");
            return _SetPixelFormat_fnptr(hdc, ipfd, ppfd);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _SwapBuffers_fnptr = &SwapBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static int SwapBuffers_Lazy(IntPtr hdc)
        {
            _SwapBuffers_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("SwapBuffers");
            return _SwapBuffers_fnptr(hdc);
        }
        
        internal static delegate* unmanaged<int, float, float, float, void*> _wglAllocateMemoryNV_fnptr = &wglAllocateMemoryNV_Lazy;
        [UnmanagedCallersOnly]
        private static void* wglAllocateMemoryNV_Lazy(int size, float readfreq, float writefreq, float priority)
        {
            _wglAllocateMemoryNV_fnptr = (delegate* unmanaged<int, float, float, float, void*>)GLLoader.BindingsContext.GetProcAddress("wglAllocateMemoryNV");
            return _wglAllocateMemoryNV_fnptr(size, readfreq, writefreq, priority);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, uint*, uint, int> _wglAssociateImageBufferEventsI3D_fnptr = &wglAssociateImageBufferEventsI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglAssociateImageBufferEventsI3D_Lazy(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, uint* pSize, uint count)
        {
            _wglAssociateImageBufferEventsI3D_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, uint*, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglAssociateImageBufferEventsI3D");
            return _wglAssociateImageBufferEventsI3D_fnptr(hDC, pEvent, pAddress, pSize, count);
        }
        
        internal static delegate* unmanaged<int> _wglBeginFrameTrackingI3D_fnptr = &wglBeginFrameTrackingI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglBeginFrameTrackingI3D_Lazy()
        {
            _wglBeginFrameTrackingI3D_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("wglBeginFrameTrackingI3D");
            return _wglBeginFrameTrackingI3D_fnptr();
        }
        
        internal static delegate* unmanaged<ushort, byte> _wglBindDisplayColorTableEXT_fnptr = &wglBindDisplayColorTableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte wglBindDisplayColorTableEXT_Lazy(ushort id)
        {
            _wglBindDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort, byte>)GLLoader.BindingsContext.GetProcAddress("wglBindDisplayColorTableEXT");
            return _wglBindDisplayColorTableEXT_fnptr(id);
        }
        
        internal static delegate* unmanaged<uint, uint, int> _wglBindSwapBarrierNV_fnptr = &wglBindSwapBarrierNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglBindSwapBarrierNV_Lazy(uint group, uint barrier)
        {
            _wglBindSwapBarrierNV_fnptr = (delegate* unmanaged<uint, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglBindSwapBarrierNV");
            return _wglBindSwapBarrierNV_fnptr(group, barrier);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int> _wglBindTexImageARB_fnptr = &wglBindTexImageARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglBindTexImageARB_Lazy(IntPtr hPbuffer, int iBuffer)
        {
            _wglBindTexImageARB_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLLoader.BindingsContext.GetProcAddress("wglBindTexImageARB");
            return _wglBindTexImageARB_fnptr(hPbuffer, iBuffer);
        }
        
        internal static delegate* unmanaged<uint, IntPtr, int> _wglBindVideoCaptureDeviceNV_fnptr = &wglBindVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglBindVideoCaptureDeviceNV_Lazy(uint uVideoSlot, IntPtr hDevice)
        {
            _wglBindVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<uint, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglBindVideoCaptureDeviceNV");
            return _wglBindVideoCaptureDeviceNV_fnptr(uVideoSlot, hDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, IntPtr, int*, int> _wglBindVideoDeviceNV_fnptr = &wglBindVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglBindVideoDeviceNV_Lazy(IntPtr hDc, uint uVideoSlot, IntPtr hVideoDevice, int* piAttribList)
        {
            _wglBindVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglBindVideoDeviceNV");
            return _wglBindVideoDeviceNV_fnptr(hDc, uVideoSlot, hVideoDevice, piAttribList);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int, int> _wglBindVideoImageNV_fnptr = &wglBindVideoImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglBindVideoImageNV_Lazy(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer)
        {
            _wglBindVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)GLLoader.BindingsContext.GetProcAddress("wglBindVideoImageNV");
            return _wglBindVideoImageNV_fnptr(hVideoDevice, hPbuffer, iVideoBuffer);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void> _wglBlitContextFramebufferAMD_fnptr = &wglBlitContextFramebufferAMD_Lazy;
        [UnmanagedCallersOnly]
        private static void wglBlitContextFramebufferAMD_Lazy(IntPtr dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter)
        {
            _wglBlitContextFramebufferAMD_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int, int, uint, uint, void>)GLLoader.BindingsContext.GetProcAddress("wglBlitContextFramebufferAMD");
            _wglBlitContextFramebufferAMD_fnptr(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        internal static delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int> _wglChoosePixelFormatARB_fnptr = &wglChoosePixelFormatARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglChoosePixelFormatARB_Lazy(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats)
        {
            _wglChoosePixelFormatARB_fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglChoosePixelFormatARB");
            return _wglChoosePixelFormatARB_fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }
        
        internal static delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int> _wglChoosePixelFormatEXT_fnptr = &wglChoosePixelFormatEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglChoosePixelFormatEXT_Lazy(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats)
        {
            _wglChoosePixelFormatEXT_fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglChoosePixelFormatEXT");
            return _wglChoosePixelFormatEXT_fnptr(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, uint, int> _wglCopyContext_fnptr = &wglCopyContext_Lazy;
        [UnmanagedCallersOnly]
        private static int wglCopyContext_Lazy(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask)
        {
            _wglCopyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglCopyContext");
            return _wglCopyContext_fnptr(hglrcSrc, hglrcDst, mask);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, int> _wglCopyImageSubDataNV_fnptr = &wglCopyImageSubDataNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglCopyImageSubDataNV_Lazy(IntPtr hSrcRC, uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, IntPtr hDstRC, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
        {
            _wglCopyImageSubDataNV_fnptr = (delegate* unmanaged<IntPtr, uint, uint, int, int, int, int, IntPtr, uint, uint, int, int, int, int, int, int, int, int>)GLLoader.BindingsContext.GetProcAddress("wglCopyImageSubDataNV");
            return _wglCopyImageSubDataNV_fnptr(hSrcRC, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, hDstRC, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
        }
        
        internal static delegate* unmanaged<IntPtr*, IntPtr> _wglCreateAffinityDCNV_fnptr = &wglCreateAffinityDCNV_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateAffinityDCNV_Lazy(IntPtr* phGpuList)
        {
            _wglCreateAffinityDCNV_fnptr = (delegate* unmanaged<IntPtr*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateAffinityDCNV");
            return _wglCreateAffinityDCNV_fnptr(phGpuList);
        }
        
        internal static delegate* unmanaged<uint, IntPtr> _wglCreateAssociatedContextAMD_fnptr = &wglCreateAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateAssociatedContextAMD_Lazy(uint id)
        {
            _wglCreateAssociatedContextAMD_fnptr = (delegate* unmanaged<uint, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateAssociatedContextAMD");
            return _wglCreateAssociatedContextAMD_fnptr(id);
        }
        
        internal static delegate* unmanaged<uint, IntPtr, int*, IntPtr> _wglCreateAssociatedContextAttribsAMD_fnptr = &wglCreateAssociatedContextAttribsAMD_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateAssociatedContextAttribsAMD_Lazy(uint id, IntPtr hShareContext, int* attribList)
        {
            _wglCreateAssociatedContextAttribsAMD_fnptr = (delegate* unmanaged<uint, IntPtr, int*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateAssociatedContextAttribsAMD");
            return _wglCreateAssociatedContextAttribsAMD_fnptr(id, hShareContext, attribList);
        }
        
        internal static delegate* unmanaged<IntPtr, int, uint, IntPtr> _wglCreateBufferRegionARB_fnptr = &wglCreateBufferRegionARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateBufferRegionARB_Lazy(IntPtr hDC, int iLayerPlane, uint uType)
        {
            _wglCreateBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, int, uint, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateBufferRegionARB");
            return _wglCreateBufferRegionARB_fnptr(hDC, iLayerPlane, uType);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr> _wglCreateContext_fnptr = &wglCreateContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateContext_Lazy(IntPtr hDc)
        {
            _wglCreateContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateContext");
            return _wglCreateContext_fnptr(hDc);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr> _wglCreateContextAttribsARB_fnptr = &wglCreateContextAttribsARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateContextAttribsARB_Lazy(IntPtr hDC, IntPtr hShareContext, int* attribList)
        {
            _wglCreateContextAttribsARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateContextAttribsARB");
            return _wglCreateContextAttribsARB_fnptr(hDC, hShareContext, attribList);
        }
        
        internal static delegate* unmanaged<ushort, byte> _wglCreateDisplayColorTableEXT_fnptr = &wglCreateDisplayColorTableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte wglCreateDisplayColorTableEXT_Lazy(ushort id)
        {
            _wglCreateDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort, byte>)GLLoader.BindingsContext.GetProcAddress("wglCreateDisplayColorTableEXT");
            return _wglCreateDisplayColorTableEXT_fnptr(id);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, IntPtr> _wglCreateImageBufferI3D_fnptr = &wglCreateImageBufferI3D_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateImageBufferI3D_Lazy(IntPtr hDC, uint dwSize, uint uFlags)
        {
            _wglCreateImageBufferI3D_fnptr = (delegate* unmanaged<IntPtr, uint, uint, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateImageBufferI3D");
            return _wglCreateImageBufferI3D_fnptr(hDC, dwSize, uFlags);
        }
        
        internal static delegate* unmanaged<IntPtr, int, IntPtr> _wglCreateLayerContext_fnptr = &wglCreateLayerContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreateLayerContext_Lazy(IntPtr hDc, int level)
        {
            _wglCreateLayerContext_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreateLayerContext");
            return _wglCreateLayerContext_fnptr(hDc, level);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr> _wglCreatePbufferARB_fnptr = &wglCreatePbufferARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreatePbufferARB_Lazy(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
        {
            _wglCreatePbufferARB_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreatePbufferARB");
            return _wglCreatePbufferARB_fnptr(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr> _wglCreatePbufferEXT_fnptr = &wglCreatePbufferEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglCreatePbufferEXT_Lazy(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
        {
            _wglCreatePbufferEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglCreatePbufferEXT");
            return _wglCreatePbufferEXT_fnptr(hDC, iPixelFormat, iWidth, iHeight, piAttribList);
        }
        
        internal static delegate* unmanaged<IntPtr, float, int> _wglDelayBeforeSwapNV_fnptr = &wglDelayBeforeSwapNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDelayBeforeSwapNV_Lazy(IntPtr hDC, float seconds)
        {
            _wglDelayBeforeSwapNV_fnptr = (delegate* unmanaged<IntPtr, float, int>)GLLoader.BindingsContext.GetProcAddress("wglDelayBeforeSwapNV");
            return _wglDelayBeforeSwapNV_fnptr(hDC, seconds);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDeleteAssociatedContextAMD_fnptr = &wglDeleteAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDeleteAssociatedContextAMD_Lazy(IntPtr hglrc)
        {
            _wglDeleteAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDeleteAssociatedContextAMD");
            return _wglDeleteAssociatedContextAMD_fnptr(hglrc);
        }
        
        internal static delegate* unmanaged<IntPtr, void> _wglDeleteBufferRegionARB_fnptr = &wglDeleteBufferRegionARB_Lazy;
        [UnmanagedCallersOnly]
        private static void wglDeleteBufferRegionARB_Lazy(IntPtr hRegion)
        {
            _wglDeleteBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, void>)GLLoader.BindingsContext.GetProcAddress("wglDeleteBufferRegionARB");
            _wglDeleteBufferRegionARB_fnptr(hRegion);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDeleteContext_fnptr = &wglDeleteContext_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDeleteContext_Lazy(IntPtr oldContext)
        {
            _wglDeleteContext_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDeleteContext");
            return _wglDeleteContext_fnptr(oldContext);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDeleteDCNV_fnptr = &wglDeleteDCNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDeleteDCNV_Lazy(IntPtr hdc)
        {
            _wglDeleteDCNV_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDeleteDCNV");
            return _wglDeleteDCNV_fnptr(hdc);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, uint, LayerPlaneDescriptor*, int> _wglDescribeLayerPlane_fnptr = &wglDescribeLayerPlane_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDescribeLayerPlane_Lazy(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, LayerPlaneDescriptor* plpd)
        {
            _wglDescribeLayerPlane_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, LayerPlaneDescriptor*, int>)GLLoader.BindingsContext.GetProcAddress("wglDescribeLayerPlane");
            return _wglDescribeLayerPlane_fnptr(hDc, pixelFormat, layerPlane, nBytes, plpd);
        }
        
        internal static delegate* unmanaged<ushort, void> _wglDestroyDisplayColorTableEXT_fnptr = &wglDestroyDisplayColorTableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void wglDestroyDisplayColorTableEXT_Lazy(ushort id)
        {
            _wglDestroyDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort, void>)GLLoader.BindingsContext.GetProcAddress("wglDestroyDisplayColorTableEXT");
            _wglDestroyDisplayColorTableEXT_fnptr(id);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglDestroyImageBufferI3D_fnptr = &wglDestroyImageBufferI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDestroyImageBufferI3D_Lazy(IntPtr hDC, IntPtr pAddress)
        {
            _wglDestroyImageBufferI3D_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDestroyImageBufferI3D");
            return _wglDestroyImageBufferI3D_fnptr(hDC, pAddress);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDestroyPbufferARB_fnptr = &wglDestroyPbufferARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDestroyPbufferARB_Lazy(IntPtr hPbuffer)
        {
            _wglDestroyPbufferARB_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDestroyPbufferARB");
            return _wglDestroyPbufferARB_fnptr(hPbuffer);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDestroyPbufferEXT_fnptr = &wglDestroyPbufferEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDestroyPbufferEXT_Lazy(IntPtr hPbuffer)
        {
            _wglDestroyPbufferEXT_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDestroyPbufferEXT");
            return _wglDestroyPbufferEXT_fnptr(hPbuffer);
        }
        
        internal static delegate* unmanaged<int> _wglDisableFrameLockI3D_fnptr = &wglDisableFrameLockI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDisableFrameLockI3D_Lazy()
        {
            _wglDisableFrameLockI3D_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("wglDisableFrameLockI3D");
            return _wglDisableFrameLockI3D_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDisableGenlockI3D_fnptr = &wglDisableGenlockI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDisableGenlockI3D_Lazy(IntPtr hDC)
        {
            _wglDisableGenlockI3D_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDisableGenlockI3D");
            return _wglDisableGenlockI3D_fnptr(hDC);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglDXCloseDeviceNV_fnptr = &wglDXCloseDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDXCloseDeviceNV_Lazy(IntPtr hDevice)
        {
            _wglDXCloseDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDXCloseDeviceNV");
            return _wglDXCloseDeviceNV_fnptr(hDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, int, IntPtr*, int> _wglDXLockObjectsNV_fnptr = &wglDXLockObjectsNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDXLockObjectsNV_Lazy(IntPtr hDevice, int count, IntPtr* hObjects)
        {
            _wglDXLockObjectsNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)GLLoader.BindingsContext.GetProcAddress("wglDXLockObjectsNV");
            return _wglDXLockObjectsNV_fnptr(hDevice, count, hObjects);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglDXObjectAccessNV_fnptr = &wglDXObjectAccessNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDXObjectAccessNV_Lazy(IntPtr hObject, uint access)
        {
            _wglDXObjectAccessNV_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglDXObjectAccessNV");
            return _wglDXObjectAccessNV_fnptr(hObject, access);
        }
        
        internal static delegate* unmanaged<void*, IntPtr> _wglDXOpenDeviceNV_fnptr = &wglDXOpenDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglDXOpenDeviceNV_Lazy(void* dxDevice)
        {
            _wglDXOpenDeviceNV_fnptr = (delegate* unmanaged<void*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglDXOpenDeviceNV");
            return _wglDXOpenDeviceNV_fnptr(dxDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, void*, uint, uint, uint, IntPtr> _wglDXRegisterObjectNV_fnptr = &wglDXRegisterObjectNV_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglDXRegisterObjectNV_Lazy(IntPtr hDevice, void* dxObject, uint name, uint type, uint access)
        {
            _wglDXRegisterObjectNV_fnptr = (delegate* unmanaged<IntPtr, void*, uint, uint, uint, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglDXRegisterObjectNV");
            return _wglDXRegisterObjectNV_fnptr(hDevice, dxObject, name, type, access);
        }
        
        internal static delegate* unmanaged<void*, IntPtr, int> _wglDXSetResourceShareHandleNV_fnptr = &wglDXSetResourceShareHandleNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDXSetResourceShareHandleNV_Lazy(void* dxObject, IntPtr shareHandle)
        {
            _wglDXSetResourceShareHandleNV_fnptr = (delegate* unmanaged<void*, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDXSetResourceShareHandleNV");
            return _wglDXSetResourceShareHandleNV_fnptr(dxObject, shareHandle);
        }
        
        internal static delegate* unmanaged<IntPtr, int, IntPtr*, int> _wglDXUnlockObjectsNV_fnptr = &wglDXUnlockObjectsNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDXUnlockObjectsNV_Lazy(IntPtr hDevice, int count, IntPtr* hObjects)
        {
            _wglDXUnlockObjectsNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)GLLoader.BindingsContext.GetProcAddress("wglDXUnlockObjectsNV");
            return _wglDXUnlockObjectsNV_fnptr(hDevice, count, hObjects);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglDXUnregisterObjectNV_fnptr = &wglDXUnregisterObjectNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglDXUnregisterObjectNV_Lazy(IntPtr hDevice, IntPtr hObject)
        {
            _wglDXUnregisterObjectNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglDXUnregisterObjectNV");
            return _wglDXUnregisterObjectNV_fnptr(hDevice, hObject);
        }
        
        internal static delegate* unmanaged<int> _wglEnableFrameLockI3D_fnptr = &wglEnableFrameLockI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEnableFrameLockI3D_Lazy()
        {
            _wglEnableFrameLockI3D_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("wglEnableFrameLockI3D");
            return _wglEnableFrameLockI3D_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglEnableGenlockI3D_fnptr = &wglEnableGenlockI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEnableGenlockI3D_Lazy(IntPtr hDC)
        {
            _wglEnableGenlockI3D_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglEnableGenlockI3D");
            return _wglEnableGenlockI3D_fnptr(hDC);
        }
        
        internal static delegate* unmanaged<int> _wglEndFrameTrackingI3D_fnptr = &wglEndFrameTrackingI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEndFrameTrackingI3D_Lazy()
        {
            _wglEndFrameTrackingI3D_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("wglEndFrameTrackingI3D");
            return _wglEndFrameTrackingI3D_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr*, uint> _wglEnumerateVideoCaptureDevicesNV_fnptr = &wglEnumerateVideoCaptureDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static uint wglEnumerateVideoCaptureDevicesNV_Lazy(IntPtr hDc, IntPtr* phDeviceList)
        {
            _wglEnumerateVideoCaptureDevicesNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, uint>)GLLoader.BindingsContext.GetProcAddress("wglEnumerateVideoCaptureDevicesNV");
            return _wglEnumerateVideoCaptureDevicesNV_fnptr(hDc, phDeviceList);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr*, int> _wglEnumerateVideoDevicesNV_fnptr = &wglEnumerateVideoDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEnumerateVideoDevicesNV_Lazy(IntPtr hDc, IntPtr* phDeviceList)
        {
            _wglEnumerateVideoDevicesNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)GLLoader.BindingsContext.GetProcAddress("wglEnumerateVideoDevicesNV");
            return _wglEnumerateVideoDevicesNV_fnptr(hDc, phDeviceList);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, _GPU_DEVICE*, int> _wglEnumGpuDevicesNV_fnptr = &wglEnumGpuDevicesNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEnumGpuDevicesNV_Lazy(IntPtr hGpu, uint iDeviceIndex, _GPU_DEVICE* lpGpuDevice)
        {
            _wglEnumGpuDevicesNV_fnptr = (delegate* unmanaged<IntPtr, uint, _GPU_DEVICE*, int>)GLLoader.BindingsContext.GetProcAddress("wglEnumGpuDevicesNV");
            return _wglEnumGpuDevicesNV_fnptr(hGpu, iDeviceIndex, lpGpuDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, IntPtr*, int> _wglEnumGpusFromAffinityDCNV_fnptr = &wglEnumGpusFromAffinityDCNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEnumGpusFromAffinityDCNV_Lazy(IntPtr hAffinityDC, uint iGpuIndex, IntPtr* hGpu)
        {
            _wglEnumGpusFromAffinityDCNV_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, int>)GLLoader.BindingsContext.GetProcAddress("wglEnumGpusFromAffinityDCNV");
            return _wglEnumGpusFromAffinityDCNV_fnptr(hAffinityDC, iGpuIndex, hGpu);
        }
        
        internal static delegate* unmanaged<uint, IntPtr*, int> _wglEnumGpusNV_fnptr = &wglEnumGpusNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglEnumGpusNV_Lazy(uint iGpuIndex, IntPtr* phGpu)
        {
            _wglEnumGpusNV_fnptr = (delegate* unmanaged<uint, IntPtr*, int>)GLLoader.BindingsContext.GetProcAddress("wglEnumGpusNV");
            return _wglEnumGpusNV_fnptr(iGpuIndex, phGpu);
        }
        
        internal static delegate* unmanaged<void*, void> _wglFreeMemoryNV_fnptr = &wglFreeMemoryNV_Lazy;
        [UnmanagedCallersOnly]
        private static void wglFreeMemoryNV_Lazy(void* pointer)
        {
            _wglFreeMemoryNV_fnptr = (delegate* unmanaged<void*, void>)GLLoader.BindingsContext.GetProcAddress("wglFreeMemoryNV");
            _wglFreeMemoryNV_fnptr(pointer);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSampleRateI3D_fnptr = &wglGenlockSampleRateI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGenlockSampleRateI3D_Lazy(IntPtr hDC, uint uRate)
        {
            _wglGenlockSampleRateI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglGenlockSampleRateI3D");
            return _wglGenlockSampleRateI3D_fnptr(hDC, uRate);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSourceDelayI3D_fnptr = &wglGenlockSourceDelayI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGenlockSourceDelayI3D_Lazy(IntPtr hDC, uint uDelay)
        {
            _wglGenlockSourceDelayI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglGenlockSourceDelayI3D");
            return _wglGenlockSourceDelayI3D_fnptr(hDC, uDelay);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSourceEdgeI3D_fnptr = &wglGenlockSourceEdgeI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGenlockSourceEdgeI3D_Lazy(IntPtr hDC, uint uEdge)
        {
            _wglGenlockSourceEdgeI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglGenlockSourceEdgeI3D");
            return _wglGenlockSourceEdgeI3D_fnptr(hDC, uEdge);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglGenlockSourceI3D_fnptr = &wglGenlockSourceI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGenlockSourceI3D_Lazy(IntPtr hDC, uint uSource)
        {
            _wglGenlockSourceI3D_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglGenlockSourceI3D");
            return _wglGenlockSourceI3D_fnptr(hDC, uSource);
        }
        
        internal static delegate* unmanaged<IntPtr, uint> _wglGetContextGPUIDAMD_fnptr = &wglGetContextGPUIDAMD_Lazy;
        [UnmanagedCallersOnly]
        private static uint wglGetContextGPUIDAMD_Lazy(IntPtr hglrc)
        {
            _wglGetContextGPUIDAMD_fnptr = (delegate* unmanaged<IntPtr, uint>)GLLoader.BindingsContext.GetProcAddress("wglGetContextGPUIDAMD");
            return _wglGetContextGPUIDAMD_fnptr(hglrc);
        }
        
        internal static delegate* unmanaged<IntPtr> _wglGetCurrentAssociatedContextAMD_fnptr = &wglGetCurrentAssociatedContextAMD_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetCurrentAssociatedContextAMD_Lazy()
        {
            _wglGetCurrentAssociatedContextAMD_fnptr = (delegate* unmanaged<IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetCurrentAssociatedContextAMD");
            return _wglGetCurrentAssociatedContextAMD_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr> _wglGetCurrentContext_fnptr = &wglGetCurrentContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetCurrentContext_Lazy()
        {
            _wglGetCurrentContext_fnptr = (delegate* unmanaged<IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetCurrentContext");
            return _wglGetCurrentContext_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr> _wglGetCurrentDC_fnptr = &wglGetCurrentDC_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetCurrentDC_Lazy()
        {
            _wglGetCurrentDC_fnptr = (delegate* unmanaged<IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetCurrentDC");
            return _wglGetCurrentDC_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr> _wglGetCurrentReadDCARB_fnptr = &wglGetCurrentReadDCARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetCurrentReadDCARB_Lazy()
        {
            _wglGetCurrentReadDCARB_fnptr = (delegate* unmanaged<IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetCurrentReadDCARB");
            return _wglGetCurrentReadDCARB_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr> _wglGetCurrentReadDCEXT_fnptr = &wglGetCurrentReadDCEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetCurrentReadDCEXT_Lazy()
        {
            _wglGetCurrentReadDCEXT_fnptr = (delegate* unmanaged<IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetCurrentReadDCEXT");
            return _wglGetCurrentReadDCEXT_fnptr();
        }
        
        internal static delegate* unmanaged<char*, IntPtr> _wglGetDefaultProcAddress_fnptr = &wglGetDefaultProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetDefaultProcAddress_Lazy(char* lpszProc)
        {
            _wglGetDefaultProcAddress_fnptr = (delegate* unmanaged<char*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetDefaultProcAddress");
            return _wglGetDefaultProcAddress_fnptr(lpszProc);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int*, int> _wglGetDigitalVideoParametersI3D_fnptr = &wglGetDigitalVideoParametersI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetDigitalVideoParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            _wglGetDigitalVideoParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetDigitalVideoParametersI3D");
            return _wglGetDigitalVideoParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, PixelFormatDescriptor*, uint> _GetEnhMetaFilePixelFormat_fnptr = &GetEnhMetaFilePixelFormat_Lazy;
        [UnmanagedCallersOnly]
        private static uint GetEnhMetaFilePixelFormat_Lazy(IntPtr hemf, uint cbBuffer, PixelFormatDescriptor* ppfd)
        {
            _GetEnhMetaFilePixelFormat_fnptr = (delegate* unmanaged<IntPtr, uint, PixelFormatDescriptor*, uint>)GLLoader.BindingsContext.GetProcAddress("GetEnhMetaFilePixelFormat");
            return _GetEnhMetaFilePixelFormat_fnptr(hemf, cbBuffer, ppfd);
        }
        
        internal static delegate* unmanaged<IntPtr, byte*> _wglGetExtensionsStringARB_fnptr = &wglGetExtensionsStringARB_Lazy;
        [UnmanagedCallersOnly]
        private static byte* wglGetExtensionsStringARB_Lazy(IntPtr hdc)
        {
            _wglGetExtensionsStringARB_fnptr = (delegate* unmanaged<IntPtr, byte*>)GLLoader.BindingsContext.GetProcAddress("wglGetExtensionsStringARB");
            return _wglGetExtensionsStringARB_fnptr(hdc);
        }
        
        internal static delegate* unmanaged<byte*> _wglGetExtensionsStringEXT_fnptr = &wglGetExtensionsStringEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* wglGetExtensionsStringEXT_Lazy()
        {
            _wglGetExtensionsStringEXT_fnptr = (delegate* unmanaged<byte*>)GLLoader.BindingsContext.GetProcAddress("wglGetExtensionsStringEXT");
            return _wglGetExtensionsStringEXT_fnptr();
        }
        
        internal static delegate* unmanaged<float*, int> _wglGetFrameUsageI3D_fnptr = &wglGetFrameUsageI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetFrameUsageI3D_Lazy(float* pUsage)
        {
            _wglGetFrameUsageI3D_fnptr = (delegate* unmanaged<float*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetFrameUsageI3D");
            return _wglGetFrameUsageI3D_fnptr(pUsage);
        }
        
        internal static delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int> _wglGetGammaTableI3D_fnptr = &wglGetGammaTableI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGammaTableI3D_Lazy(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue)
        {
            _wglGetGammaTableI3D_fnptr = (delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGammaTableI3D");
            return _wglGetGammaTableI3D_fnptr(hDC, iEntries, puRed, puGreen, puBlue);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int*, int> _wglGetGammaTableParametersI3D_fnptr = &wglGetGammaTableParametersI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGammaTableParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            _wglGetGammaTableParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGammaTableParametersI3D");
            return _wglGetGammaTableParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSampleRateI3D_fnptr = &wglGetGenlockSampleRateI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGenlockSampleRateI3D_Lazy(IntPtr hDC, uint* uRate)
        {
            _wglGetGenlockSampleRateI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGenlockSampleRateI3D");
            return _wglGetGenlockSampleRateI3D_fnptr(hDC, uRate);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSourceDelayI3D_fnptr = &wglGetGenlockSourceDelayI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGenlockSourceDelayI3D_Lazy(IntPtr hDC, uint* uDelay)
        {
            _wglGetGenlockSourceDelayI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGenlockSourceDelayI3D");
            return _wglGetGenlockSourceDelayI3D_fnptr(hDC, uDelay);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSourceEdgeI3D_fnptr = &wglGetGenlockSourceEdgeI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGenlockSourceEdgeI3D_Lazy(IntPtr hDC, uint* uEdge)
        {
            _wglGetGenlockSourceEdgeI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGenlockSourceEdgeI3D");
            return _wglGetGenlockSourceEdgeI3D_fnptr(hDC, uEdge);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, int> _wglGetGenlockSourceI3D_fnptr = &wglGetGenlockSourceI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGenlockSourceI3D_Lazy(IntPtr hDC, uint* uSource)
        {
            _wglGetGenlockSourceI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGenlockSourceI3D");
            return _wglGetGenlockSourceI3D_fnptr(hDC, uSource);
        }
        
        internal static delegate* unmanaged<uint, uint*, uint> _wglGetGPUIDsAMD_fnptr = &wglGetGPUIDsAMD_Lazy;
        [UnmanagedCallersOnly]
        private static uint wglGetGPUIDsAMD_Lazy(uint maxCount, uint* ids)
        {
            _wglGetGPUIDsAMD_fnptr = (delegate* unmanaged<uint, uint*, uint>)GLLoader.BindingsContext.GetProcAddress("wglGetGPUIDsAMD");
            return _wglGetGPUIDsAMD_fnptr(maxCount, ids);
        }
        
        internal static delegate* unmanaged<uint, int, uint, uint, void*, int> _wglGetGPUInfoAMD_fnptr = &wglGetGPUInfoAMD_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetGPUInfoAMD_Lazy(uint id, int property, uint dataType, uint size, void* data)
        {
            _wglGetGPUInfoAMD_fnptr = (delegate* unmanaged<uint, int, uint, uint, void*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetGPUInfoAMD");
            return _wglGetGPUInfoAMD_fnptr(id, property, dataType, size, data);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, uint*, int> _wglGetLayerPaletteEntries_fnptr = &wglGetLayerPaletteEntries_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetLayerPaletteEntries_Lazy(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint* pcr)
        {
            _wglGetLayerPaletteEntries_fnptr = (delegate* unmanaged<IntPtr, int, int, int, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetLayerPaletteEntries");
            return _wglGetLayerPaletteEntries_fnptr(hdc, iLayerPlane, iStart, cEntries, pcr);
        }
        
        internal static delegate* unmanaged<IntPtr, int*, int*, int> _wglGetMscRateOML_fnptr = &wglGetMscRateOML_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetMscRateOML_Lazy(IntPtr hdc, int* numerator, int* denominator)
        {
            _wglGetMscRateOML_fnptr = (delegate* unmanaged<IntPtr, int*, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetMscRateOML");
            return _wglGetMscRateOML_fnptr(hdc, numerator, denominator);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr> _wglGetPbufferDCARB_fnptr = &wglGetPbufferDCARB_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetPbufferDCARB_Lazy(IntPtr hPbuffer)
        {
            _wglGetPbufferDCARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetPbufferDCARB");
            return _wglGetPbufferDCARB_fnptr(hPbuffer);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr> _wglGetPbufferDCEXT_fnptr = &wglGetPbufferDCEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetPbufferDCEXT_Lazy(IntPtr hPbuffer)
        {
            _wglGetPbufferDCEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetPbufferDCEXT");
            return _wglGetPbufferDCEXT_fnptr(hPbuffer);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int> _wglGetPixelFormatAttribfvARB_fnptr = &wglGetPixelFormatAttribfvARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetPixelFormatAttribfvARB_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues)
        {
            _wglGetPixelFormatAttribfvARB_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribfvARB");
            return _wglGetPixelFormatAttribfvARB_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int> _wglGetPixelFormatAttribfvEXT_fnptr = &wglGetPixelFormatAttribfvEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetPixelFormatAttribfvEXT_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues)
        {
            _wglGetPixelFormatAttribfvEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, float*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribfvEXT");
            return _wglGetPixelFormatAttribfvEXT_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int> _wglGetPixelFormatAttribivARB_fnptr = &wglGetPixelFormatAttribivARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetPixelFormatAttribivARB_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues)
        {
            _wglGetPixelFormatAttribivARB_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribivARB");
            return _wglGetPixelFormatAttribivARB_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int> _wglGetPixelFormatAttribivEXT_fnptr = &wglGetPixelFormatAttribivEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetPixelFormatAttribivEXT_Lazy(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues)
        {
            _wglGetPixelFormatAttribivEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetPixelFormatAttribivEXT");
            return _wglGetPixelFormatAttribivEXT_fnptr(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues);
        }
        
        internal static delegate* unmanaged<char*, IntPtr> _wglGetProcAddress_fnptr = &wglGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr wglGetProcAddress_Lazy(char* lpszProc)
        {
            _wglGetProcAddress_fnptr = (delegate* unmanaged<char*, IntPtr>)GLLoader.BindingsContext.GetProcAddress("wglGetProcAddress");
            return _wglGetProcAddress_fnptr(lpszProc);
        }
        
        internal static delegate* unmanaged<int> _wglGetSwapIntervalEXT_fnptr = &wglGetSwapIntervalEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetSwapIntervalEXT_Lazy()
        {
            _wglGetSwapIntervalEXT_fnptr = (delegate* unmanaged<int>)GLLoader.BindingsContext.GetProcAddress("wglGetSwapIntervalEXT");
            return _wglGetSwapIntervalEXT_fnptr();
        }
        
        internal static delegate* unmanaged<IntPtr, long*, long*, long*, int> _wglGetSyncValuesOML_fnptr = &wglGetSyncValuesOML_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetSyncValuesOML_Lazy(IntPtr hdc, long* ust, long* msc, long* sbc)
        {
            _wglGetSyncValuesOML_fnptr = (delegate* unmanaged<IntPtr, long*, long*, long*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetSyncValuesOML");
            return _wglGetSyncValuesOML_fnptr(hdc, ust, msc, sbc);
        }
        
        internal static delegate* unmanaged<IntPtr, int, IntPtr*, int> _wglGetVideoDeviceNV_fnptr = &wglGetVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetVideoDeviceNV_Lazy(IntPtr hDC, int numDevices, IntPtr* hVideoDevice)
        {
            _wglGetVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetVideoDeviceNV");
            return _wglGetVideoDeviceNV_fnptr(hDC, numDevices, hVideoDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, ulong*, ulong*, int> _wglGetVideoInfoNV_fnptr = &wglGetVideoInfoNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglGetVideoInfoNV_Lazy(IntPtr hpVideoDevice, ulong* pulCounterOutputPbuffer, ulong* pulCounterOutputVideo)
        {
            _wglGetVideoInfoNV_fnptr = (delegate* unmanaged<IntPtr, ulong*, ulong*, int>)GLLoader.BindingsContext.GetProcAddress("wglGetVideoInfoNV");
            return _wglGetVideoInfoNV_fnptr(hpVideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo);
        }
        
        internal static delegate* unmanaged<int*, int> _wglIsEnabledFrameLockI3D_fnptr = &wglIsEnabledFrameLockI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglIsEnabledFrameLockI3D_Lazy(int* pFlag)
        {
            _wglIsEnabledFrameLockI3D_fnptr = (delegate* unmanaged<int*, int>)GLLoader.BindingsContext.GetProcAddress("wglIsEnabledFrameLockI3D");
            return _wglIsEnabledFrameLockI3D_fnptr(pFlag);
        }
        
        internal static delegate* unmanaged<IntPtr, int*, int> _wglIsEnabledGenlockI3D_fnptr = &wglIsEnabledGenlockI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglIsEnabledGenlockI3D_Lazy(IntPtr hDC, int* pFlag)
        {
            _wglIsEnabledGenlockI3D_fnptr = (delegate* unmanaged<IntPtr, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglIsEnabledGenlockI3D");
            return _wglIsEnabledGenlockI3D_fnptr(hDC, pFlag);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglJoinSwapGroupNV_fnptr = &wglJoinSwapGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglJoinSwapGroupNV_Lazy(IntPtr hDC, uint group)
        {
            _wglJoinSwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglJoinSwapGroupNV");
            return _wglJoinSwapGroupNV_fnptr(hDC, group);
        }
        
        internal static delegate* unmanaged<ushort*, uint, byte> _wglLoadDisplayColorTableEXT_fnptr = &wglLoadDisplayColorTableEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte wglLoadDisplayColorTableEXT_Lazy(ushort* table, uint length)
        {
            _wglLoadDisplayColorTableEXT_fnptr = (delegate* unmanaged<ushort*, uint, byte>)GLLoader.BindingsContext.GetProcAddress("wglLoadDisplayColorTableEXT");
            return _wglLoadDisplayColorTableEXT_fnptr(table, length);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglLockVideoCaptureDeviceNV_fnptr = &wglLockVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglLockVideoCaptureDeviceNV_Lazy(IntPtr hDc, IntPtr hDevice)
        {
            _wglLockVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglLockVideoCaptureDeviceNV");
            return _wglLockVideoCaptureDeviceNV_fnptr(hDc, hDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglMakeAssociatedContextCurrentAMD_fnptr = &wglMakeAssociatedContextCurrentAMD_Lazy;
        [UnmanagedCallersOnly]
        private static int wglMakeAssociatedContextCurrentAMD_Lazy(IntPtr hglrc)
        {
            _wglMakeAssociatedContextCurrentAMD_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglMakeAssociatedContextCurrentAMD");
            return _wglMakeAssociatedContextCurrentAMD_fnptr(hglrc);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _wglMakeContextCurrentARB_fnptr = &wglMakeContextCurrentARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglMakeContextCurrentARB_Lazy(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            _wglMakeContextCurrentARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglMakeContextCurrentARB");
            return _wglMakeContextCurrentARB_fnptr(hDrawDC, hReadDC, hglrc);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _wglMakeContextCurrentEXT_fnptr = &wglMakeContextCurrentEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglMakeContextCurrentEXT_Lazy(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            _wglMakeContextCurrentEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglMakeContextCurrentEXT");
            return _wglMakeContextCurrentEXT_fnptr(hDrawDC, hReadDC, hglrc);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglMakeCurrent_fnptr = &wglMakeCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static int wglMakeCurrent_Lazy(IntPtr hDc, IntPtr newContext)
        {
            _wglMakeCurrent_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglMakeCurrent");
            return _wglMakeCurrent_fnptr(hDc, newContext);
        }
        
        internal static delegate* unmanaged<int, int*, int> _wglQueryCurrentContextNV_fnptr = &wglQueryCurrentContextNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryCurrentContextNV_Lazy(int iAttribute, int* piValue)
        {
            _wglQueryCurrentContextNV_fnptr = (delegate* unmanaged<int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryCurrentContextNV");
            return _wglQueryCurrentContextNV_fnptr(iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, int> _wglQueryFrameCountNV_fnptr = &wglQueryFrameCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryFrameCountNV_Lazy(IntPtr hDC, uint* count)
        {
            _wglQueryFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryFrameCountNV");
            return _wglQueryFrameCountNV_fnptr(hDC, count);
        }
        
        internal static delegate* unmanaged<int*, int> _wglQueryFrameLockMasterI3D_fnptr = &wglQueryFrameLockMasterI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryFrameLockMasterI3D_Lazy(int* pFlag)
        {
            _wglQueryFrameLockMasterI3D_fnptr = (delegate* unmanaged<int*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryFrameLockMasterI3D");
            return _wglQueryFrameLockMasterI3D_fnptr(pFlag);
        }
        
        internal static delegate* unmanaged<uint*, uint*, float*, int> _wglQueryFrameTrackingI3D_fnptr = &wglQueryFrameTrackingI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryFrameTrackingI3D_Lazy(uint* pFrameCount, uint* pMissedFrames, float* pLastMissedUsage)
        {
            _wglQueryFrameTrackingI3D_fnptr = (delegate* unmanaged<uint*, uint*, float*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryFrameTrackingI3D");
            return _wglQueryFrameTrackingI3D_fnptr(pFrameCount, pMissedFrames, pLastMissedUsage);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, uint*, int> _wglQueryGenlockMaxSourceDelayI3D_fnptr = &wglQueryGenlockMaxSourceDelayI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryGenlockMaxSourceDelayI3D_Lazy(IntPtr hDC, uint* uMaxLineDelay, uint* uMaxPixelDelay)
        {
            _wglQueryGenlockMaxSourceDelayI3D_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryGenlockMaxSourceDelayI3D");
            return _wglQueryGenlockMaxSourceDelayI3D_fnptr(hDC, uMaxLineDelay, uMaxPixelDelay);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, uint*, int> _wglQueryMaxSwapGroupsNV_fnptr = &wglQueryMaxSwapGroupsNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryMaxSwapGroupsNV_Lazy(IntPtr hDC, uint* maxGroups, uint* maxBarriers)
        {
            _wglQueryMaxSwapGroupsNV_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryMaxSwapGroupsNV");
            return _wglQueryMaxSwapGroupsNV_fnptr(hDC, maxGroups, maxBarriers);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int*, int> _wglQueryPbufferARB_fnptr = &wglQueryPbufferARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryPbufferARB_Lazy(IntPtr hPbuffer, int iAttribute, int* piValue)
        {
            _wglQueryPbufferARB_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryPbufferARB");
            return _wglQueryPbufferARB_fnptr(hPbuffer, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int*, int> _wglQueryPbufferEXT_fnptr = &wglQueryPbufferEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryPbufferEXT_Lazy(IntPtr hPbuffer, int iAttribute, int* piValue)
        {
            _wglQueryPbufferEXT_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryPbufferEXT");
            return _wglQueryPbufferEXT_fnptr(hPbuffer, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, uint*, uint*, int> _wglQuerySwapGroupNV_fnptr = &wglQuerySwapGroupNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQuerySwapGroupNV_Lazy(IntPtr hDC, uint* group, uint* barrier)
        {
            _wglQuerySwapGroupNV_fnptr = (delegate* unmanaged<IntPtr, uint*, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglQuerySwapGroupNV");
            return _wglQuerySwapGroupNV_fnptr(hDC, group, barrier);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _wglQueryVideoCaptureDeviceNV_fnptr = &wglQueryVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglQueryVideoCaptureDeviceNV_Lazy(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue)
        {
            _wglQueryVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglQueryVideoCaptureDeviceNV");
            return _wglQueryVideoCaptureDeviceNV_fnptr(hDc, hDevice, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int> _wglRealizeLayerPalette_fnptr = &wglRealizeLayerPalette_Lazy;
        [UnmanagedCallersOnly]
        private static int wglRealizeLayerPalette_Lazy(IntPtr hdc, int iLayerPlane, int bRealize)
        {
            _wglRealizeLayerPalette_fnptr = (delegate* unmanaged<IntPtr, int, int, int>)GLLoader.BindingsContext.GetProcAddress("wglRealizeLayerPalette");
            return _wglRealizeLayerPalette_fnptr(hdc, iLayerPlane, bRealize);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr*, uint, int> _wglReleaseImageBufferEventsI3D_fnptr = &wglReleaseImageBufferEventsI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleaseImageBufferEventsI3D_Lazy(IntPtr hDC, IntPtr* pAddress, uint count)
        {
            _wglReleaseImageBufferEventsI3D_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglReleaseImageBufferEventsI3D");
            return _wglReleaseImageBufferEventsI3D_fnptr(hDC, pAddress, count);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglReleasePbufferDCARB_fnptr = &wglReleasePbufferDCARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleasePbufferDCARB_Lazy(IntPtr hPbuffer, IntPtr hDC)
        {
            _wglReleasePbufferDCARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglReleasePbufferDCARB");
            return _wglReleasePbufferDCARB_fnptr(hPbuffer, hDC);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglReleasePbufferDCEXT_fnptr = &wglReleasePbufferDCEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleasePbufferDCEXT_Lazy(IntPtr hPbuffer, IntPtr hDC)
        {
            _wglReleasePbufferDCEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglReleasePbufferDCEXT");
            return _wglReleasePbufferDCEXT_fnptr(hPbuffer, hDC);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int> _wglReleaseTexImageARB_fnptr = &wglReleaseTexImageARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleaseTexImageARB_Lazy(IntPtr hPbuffer, int iBuffer)
        {
            _wglReleaseTexImageARB_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLLoader.BindingsContext.GetProcAddress("wglReleaseTexImageARB");
            return _wglReleaseTexImageARB_fnptr(hPbuffer, iBuffer);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglReleaseVideoCaptureDeviceNV_fnptr = &wglReleaseVideoCaptureDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleaseVideoCaptureDeviceNV_Lazy(IntPtr hDc, IntPtr hDevice)
        {
            _wglReleaseVideoCaptureDeviceNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglReleaseVideoCaptureDeviceNV");
            return _wglReleaseVideoCaptureDeviceNV_fnptr(hDc, hDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglReleaseVideoDeviceNV_fnptr = &wglReleaseVideoDeviceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleaseVideoDeviceNV_Lazy(IntPtr hVideoDevice)
        {
            _wglReleaseVideoDeviceNV_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglReleaseVideoDeviceNV");
            return _wglReleaseVideoDeviceNV_fnptr(hVideoDevice);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int> _wglReleaseVideoImageNV_fnptr = &wglReleaseVideoImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglReleaseVideoImageNV_Lazy(IntPtr hPbuffer, int iVideoBuffer)
        {
            _wglReleaseVideoImageNV_fnptr = (delegate* unmanaged<IntPtr, int, int>)GLLoader.BindingsContext.GetProcAddress("wglReleaseVideoImageNV");
            return _wglReleaseVideoImageNV_fnptr(hPbuffer, iVideoBuffer);
        }
        
        internal static delegate* unmanaged<IntPtr, int> _wglResetFrameCountNV_fnptr = &wglResetFrameCountNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglResetFrameCountNV_Lazy(IntPtr hDC)
        {
            _wglResetFrameCountNV_fnptr = (delegate* unmanaged<IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglResetFrameCountNV");
            return _wglResetFrameCountNV_fnptr(hDC);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, int, int, int, int> _wglRestoreBufferRegionARB_fnptr = &wglRestoreBufferRegionARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglRestoreBufferRegionARB_Lazy(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
        {
            _wglRestoreBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, int, int>)GLLoader.BindingsContext.GetProcAddress("wglRestoreBufferRegionARB");
            return _wglRestoreBufferRegionARB_fnptr(hRegion, x, y, width, height, xSrc, ySrc);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, int, int> _wglSaveBufferRegionARB_fnptr = &wglSaveBufferRegionARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSaveBufferRegionARB_Lazy(IntPtr hRegion, int x, int y, int width, int height)
        {
            _wglSaveBufferRegionARB_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int>)GLLoader.BindingsContext.GetProcAddress("wglSaveBufferRegionARB");
            return _wglSaveBufferRegionARB_fnptr(hRegion, x, y, width, height);
        }
        
        internal static delegate* unmanaged<IntPtr, int, ulong*, int, int> _wglSendPbufferToVideoNV_fnptr = &wglSendPbufferToVideoNV_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSendPbufferToVideoNV_Lazy(IntPtr hPbuffer, int iBufferType, ulong* pulCounterPbuffer, int bBlock)
        {
            _wglSendPbufferToVideoNV_fnptr = (delegate* unmanaged<IntPtr, int, ulong*, int, int>)GLLoader.BindingsContext.GetProcAddress("wglSendPbufferToVideoNV");
            return _wglSendPbufferToVideoNV_fnptr(hPbuffer, iBufferType, pulCounterPbuffer, bBlock);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int*, int> _wglSetDigitalVideoParametersI3D_fnptr = &wglSetDigitalVideoParametersI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSetDigitalVideoParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            _wglSetDigitalVideoParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglSetDigitalVideoParametersI3D");
            return _wglSetDigitalVideoParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int> _wglSetGammaTableI3D_fnptr = &wglSetGammaTableI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSetGammaTableI3D_Lazy(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue)
        {
            _wglSetGammaTableI3D_fnptr = (delegate* unmanaged<IntPtr, int, ushort*, ushort*, ushort*, int>)GLLoader.BindingsContext.GetProcAddress("wglSetGammaTableI3D");
            return _wglSetGammaTableI3D_fnptr(hDC, iEntries, puRed, puGreen, puBlue);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int*, int> _wglSetGammaTableParametersI3D_fnptr = &wglSetGammaTableParametersI3D_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSetGammaTableParametersI3D_Lazy(IntPtr hDC, int iAttribute, int* piValue)
        {
            _wglSetGammaTableParametersI3D_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglSetGammaTableParametersI3D");
            return _wglSetGammaTableParametersI3D_fnptr(hDC, iAttribute, piValue);
        }
        
        internal static delegate* unmanaged<IntPtr, int, int, int, uint*, int> _wglSetLayerPaletteEntries_fnptr = &wglSetLayerPaletteEntries_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSetLayerPaletteEntries_Lazy(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, uint* pcr)
        {
            _wglSetLayerPaletteEntries_fnptr = (delegate* unmanaged<IntPtr, int, int, int, uint*, int>)GLLoader.BindingsContext.GetProcAddress("wglSetLayerPaletteEntries");
            return _wglSetLayerPaletteEntries_fnptr(hdc, iLayerPlane, iStart, cEntries, pcr);
        }
        
        internal static delegate* unmanaged<IntPtr, int*, int> _wglSetPbufferAttribARB_fnptr = &wglSetPbufferAttribARB_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSetPbufferAttribARB_Lazy(IntPtr hPbuffer, int* piAttribList)
        {
            _wglSetPbufferAttribARB_fnptr = (delegate* unmanaged<IntPtr, int*, int>)GLLoader.BindingsContext.GetProcAddress("wglSetPbufferAttribARB");
            return _wglSetPbufferAttribARB_fnptr(hPbuffer, piAttribList);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglSetStereoEmitterState3DL_fnptr = &wglSetStereoEmitterState3DL_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSetStereoEmitterState3DL_Lazy(IntPtr hDC, uint uState)
        {
            _wglSetStereoEmitterState3DL_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglSetStereoEmitterState3DL");
            return _wglSetStereoEmitterState3DL_fnptr(hDC, uState);
        }
        
        internal static delegate* unmanaged<IntPtr, IntPtr, int> _wglShareLists_fnptr = &wglShareLists_Lazy;
        [UnmanagedCallersOnly]
        private static int wglShareLists_Lazy(IntPtr hrcSrvShare, IntPtr hrcSrvSource)
        {
            _wglShareLists_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglShareLists");
            return _wglShareLists_fnptr(hrcSrvShare, hrcSrvSource);
        }
        
        internal static delegate* unmanaged<IntPtr, long, long, long, long> _wglSwapBuffersMscOML_fnptr = &wglSwapBuffersMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static long wglSwapBuffersMscOML_Lazy(IntPtr hdc, long target_msc, long divisor, long remainder)
        {
            _wglSwapBuffersMscOML_fnptr = (delegate* unmanaged<IntPtr, long, long, long, long>)GLLoader.BindingsContext.GetProcAddress("wglSwapBuffersMscOML");
            return _wglSwapBuffersMscOML_fnptr(hdc, target_msc, divisor, remainder);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, int> _wglSwapLayerBuffers_fnptr = &wglSwapLayerBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSwapLayerBuffers_Lazy(IntPtr hdc, uint fuFlags)
        {
            _wglSwapLayerBuffers_fnptr = (delegate* unmanaged<IntPtr, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglSwapLayerBuffers");
            return _wglSwapLayerBuffers_fnptr(hdc, fuFlags);
        }
        
        internal static delegate* unmanaged<int, int> _wglSwapIntervalEXT_fnptr = &wglSwapIntervalEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int wglSwapIntervalEXT_Lazy(int interval)
        {
            _wglSwapIntervalEXT_fnptr = (delegate* unmanaged<int, int>)GLLoader.BindingsContext.GetProcAddress("wglSwapIntervalEXT");
            return _wglSwapIntervalEXT_fnptr(interval);
        }
        
        internal static delegate* unmanaged<IntPtr, int, long, long, long, long> _wglSwapLayerBuffersMscOML_fnptr = &wglSwapLayerBuffersMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static long wglSwapLayerBuffersMscOML_Lazy(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder)
        {
            _wglSwapLayerBuffersMscOML_fnptr = (delegate* unmanaged<IntPtr, int, long, long, long, long>)GLLoader.BindingsContext.GetProcAddress("wglSwapLayerBuffersMscOML");
            return _wglSwapLayerBuffersMscOML_fnptr(hdc, fuPlanes, target_msc, divisor, remainder);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, uint, int> _wglUseFontBitmaps_fnptr = &wglUseFontBitmaps_Lazy;
        [UnmanagedCallersOnly]
        private static int wglUseFontBitmaps_Lazy(IntPtr hDC, uint first, uint count, uint listBase)
        {
            _wglUseFontBitmaps_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglUseFontBitmaps");
            return _wglUseFontBitmaps_fnptr(hDC, first, count, listBase);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, uint, int> _wglUseFontBitmapsA_fnptr = &wglUseFontBitmapsA_Lazy;
        [UnmanagedCallersOnly]
        private static int wglUseFontBitmapsA_Lazy(IntPtr hDC, uint first, uint count, uint listBase)
        {
            _wglUseFontBitmapsA_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglUseFontBitmapsA");
            return _wglUseFontBitmapsA_fnptr(hDC, first, count, listBase);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, uint, int> _wglUseFontBitmapsW_fnptr = &wglUseFontBitmapsW_Lazy;
        [UnmanagedCallersOnly]
        private static int wglUseFontBitmapsW_Lazy(IntPtr hDC, uint first, uint count, uint listBase)
        {
            _wglUseFontBitmapsW_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, int>)GLLoader.BindingsContext.GetProcAddress("wglUseFontBitmapsW");
            return _wglUseFontBitmapsW_fnptr(hDC, first, count, listBase);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int> _wglUseFontOutlines_fnptr = &wglUseFontOutlines_Lazy;
        [UnmanagedCallersOnly]
        private static int wglUseFontOutlines_Lazy(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
        {
            _wglUseFontOutlines_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglUseFontOutlines");
            return _wglUseFontOutlines_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int> _wglUseFontOutlinesA_fnptr = &wglUseFontOutlinesA_Lazy;
        [UnmanagedCallersOnly]
        private static int wglUseFontOutlinesA_Lazy(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
        {
            _wglUseFontOutlinesA_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglUseFontOutlinesA");
            return _wglUseFontOutlinesA_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        }
        
        internal static delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int> _wglUseFontOutlinesW_fnptr = &wglUseFontOutlinesW_Lazy;
        [UnmanagedCallersOnly]
        private static int wglUseFontOutlinesW_Lazy(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, IntPtr lpgmf)
        {
            _wglUseFontOutlinesW_fnptr = (delegate* unmanaged<IntPtr, uint, uint, uint, float, float, int, IntPtr, int>)GLLoader.BindingsContext.GetProcAddress("wglUseFontOutlinesW");
            return _wglUseFontOutlinesW_fnptr(hDC, first, count, listBase, deviation, extrusion, format, lpgmf);
        }
        
        internal static delegate* unmanaged<IntPtr, long, long, long, long*, long*, long*, int> _wglWaitForMscOML_fnptr = &wglWaitForMscOML_Lazy;
        [UnmanagedCallersOnly]
        private static int wglWaitForMscOML_Lazy(IntPtr hdc, long target_msc, long divisor, long remainder, long* ust, long* msc, long* sbc)
        {
            _wglWaitForMscOML_fnptr = (delegate* unmanaged<IntPtr, long, long, long, long*, long*, long*, int>)GLLoader.BindingsContext.GetProcAddress("wglWaitForMscOML");
            return _wglWaitForMscOML_fnptr(hdc, target_msc, divisor, remainder, ust, msc, sbc);
        }
        
        internal static delegate* unmanaged<IntPtr, long, long*, long*, long*, int> _wglWaitForSbcOML_fnptr = &wglWaitForSbcOML_Lazy;
        [UnmanagedCallersOnly]
        private static int wglWaitForSbcOML_Lazy(IntPtr hdc, long target_sbc, long* ust, long* msc, long* sbc)
        {
            _wglWaitForSbcOML_fnptr = (delegate* unmanaged<IntPtr, long, long*, long*, long*, int>)GLLoader.BindingsContext.GetProcAddress("wglWaitForSbcOML");
            return _wglWaitForSbcOML_fnptr(hdc, target_sbc, ust, msc, sbc);
        }
        
    }
}
