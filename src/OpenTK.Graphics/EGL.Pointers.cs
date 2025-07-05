// This file is auto generated, do not edit. Generated: 2025-07-05 14:56:17 GMT+02:00
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Egl
{
    /// <summary>A collection of all function pointers to all OpenGL entry points.</summary>
    public static unsafe partial class EglPointers
    {
        /// <summary><b>[entry point: <c>eglAcquireExternalContextANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _eglAcquireExternalContextANGLE_fnptr = &eglAcquireExternalContextANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglAcquireExternalContextANGLE_Lazy(IntPtr dpy, IntPtr drawAndRead)
        {
            _eglAcquireExternalContextANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglAcquireExternalContextANGLE");
            _eglAcquireExternalContextANGLE_fnptr(dpy, drawAndRead);
        }
        
        /// <summary><b>[entry point: <c>eglBindAPI</c>]</b></summary>
        public static delegate* unmanaged<uint, int> _eglBindAPI_fnptr = &eglBindAPI_Lazy;
        [UnmanagedCallersOnly]
        private static int eglBindAPI_Lazy(uint api)
        {
            _eglBindAPI_fnptr = (delegate* unmanaged<uint, int>)EGLLoader.BindingsContext.GetProcAddress("eglBindAPI");
            return _eglBindAPI_fnptr(api);
        }
        
        /// <summary><b>[entry point: <c>eglBindTexImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _eglBindTexImage_fnptr = &eglBindTexImage_Lazy;
        [UnmanagedCallersOnly]
        private static int eglBindTexImage_Lazy(IntPtr dpy, IntPtr surface, int buffer)
        {
            _eglBindTexImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglBindTexImage");
            return _eglBindTexImage_fnptr(dpy, surface, buffer);
        }
        
        /// <summary><b>[entry point: <c>eglBindWaylandDisplayWL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int> _eglBindWaylandDisplayWL_fnptr = &eglBindWaylandDisplayWL_Lazy;
        [UnmanagedCallersOnly]
        private static int eglBindWaylandDisplayWL_Lazy(IntPtr dpy, IntPtr* display)
        {
            _eglBindWaylandDisplayWL_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglBindWaylandDisplayWL");
            return _eglBindWaylandDisplayWL_fnptr(dpy, display);
        }
        
        /// <summary><b>[entry point: <c>eglChooseConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, IntPtr*, int, int*, int> _eglChooseConfig_fnptr = &eglChooseConfig_Lazy;
        [UnmanagedCallersOnly]
        private static int eglChooseConfig_Lazy(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config)
        {
            _eglChooseConfig_fnptr = (delegate* unmanaged<IntPtr, int*, IntPtr*, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglChooseConfig");
            return _eglChooseConfig_fnptr(dpy, attrib_list, configs, config_size, num_config);
        }
        
        /// <summary><b>[entry point: <c>eglClientSignalSyncEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglClientSignalSyncEXT_fnptr = &eglClientSignalSyncEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglClientSignalSyncEXT_Lazy(IntPtr dpy, IntPtr sync, IntPtr* attrib_list)
        {
            _eglClientSignalSyncEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglClientSignalSyncEXT");
            return _eglClientSignalSyncEXT_fnptr(dpy, sync, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglClientWaitSync</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, ulong, int> _eglClientWaitSync_fnptr = &eglClientWaitSync_Lazy;
        [UnmanagedCallersOnly]
        private static int eglClientWaitSync_Lazy(IntPtr dpy, IntPtr sync, int flags, ulong timeout)
        {
            _eglClientWaitSync_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, ulong, int>)EGLLoader.BindingsContext.GetProcAddress("eglClientWaitSync");
            return _eglClientWaitSync_fnptr(dpy, sync, flags, timeout);
        }
        
        /// <summary><b>[entry point: <c>eglClientWaitSyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, ulong, int> _eglClientWaitSyncKHR_fnptr = &eglClientWaitSyncKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglClientWaitSyncKHR_Lazy(IntPtr dpy, IntPtr sync, int flags, ulong timeout)
        {
            _eglClientWaitSyncKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, ulong, int>)EGLLoader.BindingsContext.GetProcAddress("eglClientWaitSyncKHR");
            return _eglClientWaitSyncKHR_fnptr(dpy, sync, flags, timeout);
        }
        
        /// <summary><b>[entry point: <c>eglClientWaitSyncNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, ulong, int> _eglClientWaitSyncNV_fnptr = &eglClientWaitSyncNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglClientWaitSyncNV_Lazy(IntPtr sync, int flags, ulong timeout)
        {
            _eglClientWaitSyncNV_fnptr = (delegate* unmanaged<IntPtr, int, ulong, int>)EGLLoader.BindingsContext.GetProcAddress("eglClientWaitSyncNV");
            return _eglClientWaitSyncNV_fnptr(sync, flags, timeout);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorBindTexWindowEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int> _eglCompositorBindTexWindowEXT_fnptr = &eglCompositorBindTexWindowEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorBindTexWindowEXT_Lazy(int external_win_id)
        {
            _eglCompositorBindTexWindowEXT_fnptr = (delegate* unmanaged<int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorBindTexWindowEXT");
            return _eglCompositorBindTexWindowEXT_fnptr(external_win_id);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorSetContextAttributesEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, int, int> _eglCompositorSetContextAttributesEXT_fnptr = &eglCompositorSetContextAttributesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorSetContextAttributesEXT_Lazy(int external_ref_id, int* context_attributes, int num_entries)
        {
            _eglCompositorSetContextAttributesEXT_fnptr = (delegate* unmanaged<int, int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorSetContextAttributesEXT");
            return _eglCompositorSetContextAttributesEXT_fnptr(external_ref_id, context_attributes, num_entries);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorSetContextListEXT</c>]</b></summary>
        public static delegate* unmanaged<int*, int, int> _eglCompositorSetContextListEXT_fnptr = &eglCompositorSetContextListEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorSetContextListEXT_Lazy(int* external_ref_ids, int num_entries)
        {
            _eglCompositorSetContextListEXT_fnptr = (delegate* unmanaged<int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorSetContextListEXT");
            return _eglCompositorSetContextListEXT_fnptr(external_ref_ids, num_entries);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorSetSizeEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int> _eglCompositorSetSizeEXT_fnptr = &eglCompositorSetSizeEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorSetSizeEXT_Lazy(int external_win_id, int width, int height)
        {
            _eglCompositorSetSizeEXT_fnptr = (delegate* unmanaged<int, int, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorSetSizeEXT");
            return _eglCompositorSetSizeEXT_fnptr(external_win_id, width, height);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorSetWindowAttributesEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, int, int> _eglCompositorSetWindowAttributesEXT_fnptr = &eglCompositorSetWindowAttributesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorSetWindowAttributesEXT_Lazy(int external_win_id, int* window_attributes, int num_entries)
        {
            _eglCompositorSetWindowAttributesEXT_fnptr = (delegate* unmanaged<int, int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorSetWindowAttributesEXT");
            return _eglCompositorSetWindowAttributesEXT_fnptr(external_win_id, window_attributes, num_entries);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorSetWindowListEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, int, int> _eglCompositorSetWindowListEXT_fnptr = &eglCompositorSetWindowListEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorSetWindowListEXT_Lazy(int external_ref_id, int* external_win_ids, int num_entries)
        {
            _eglCompositorSetWindowListEXT_fnptr = (delegate* unmanaged<int, int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorSetWindowListEXT");
            return _eglCompositorSetWindowListEXT_fnptr(external_ref_id, external_win_ids, num_entries);
        }
        
        /// <summary><b>[entry point: <c>eglCompositorSwapPolicyEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int, int> _eglCompositorSwapPolicyEXT_fnptr = &eglCompositorSwapPolicyEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCompositorSwapPolicyEXT_Lazy(int external_win_id, int policy)
        {
            _eglCompositorSwapPolicyEXT_fnptr = (delegate* unmanaged<int, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglCompositorSwapPolicyEXT");
            return _eglCompositorSwapPolicyEXT_fnptr(external_win_id, policy);
        }
        
        /// <summary><b>[entry point: <c>eglCopyBuffers</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _eglCopyBuffers_fnptr = &eglCopyBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCopyBuffers_Lazy(IntPtr dpy, IntPtr surface, IntPtr target)
        {
            _eglCopyBuffers_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglCopyBuffers");
            return _eglCopyBuffers_fnptr(dpy, surface, target);
        }
        
        /// <summary><b>[entry point: <c>eglCopyMetalSharedEventANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*> _eglCopyMetalSharedEventANGLE_fnptr = &eglCopyMetalSharedEventANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void* eglCopyMetalSharedEventANGLE_Lazy(IntPtr dpy, IntPtr sync)
        {
            _eglCopyMetalSharedEventANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*>)EGLLoader.BindingsContext.GetProcAddress("eglCopyMetalSharedEventANGLE");
            return _eglCopyMetalSharedEventANGLE_fnptr(dpy, sync);
        }
        
        /// <summary><b>[entry point: <c>eglCreateContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr> _eglCreateContext_fnptr = &eglCreateContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateContext_Lazy(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list)
        {
            _eglCreateContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateContext");
            return _eglCreateContext_fnptr(dpy, config, share_context, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateDeviceANGLE</c>]</b></summary>
        public static delegate* unmanaged<int, void*, IntPtr*, IntPtr> _eglCreateDeviceANGLE_fnptr = &eglCreateDeviceANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateDeviceANGLE_Lazy(int device_type, void* native_device, IntPtr* attrib_list)
        {
            _eglCreateDeviceANGLE_fnptr = (delegate* unmanaged<int, void*, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateDeviceANGLE");
            return _eglCreateDeviceANGLE_fnptr(device_type, native_device, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateDRMImageMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, IntPtr> _eglCreateDRMImageMESA_fnptr = &eglCreateDRMImageMESA_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateDRMImageMESA_Lazy(IntPtr dpy, int* attrib_list)
        {
            _eglCreateDRMImageMESA_fnptr = (delegate* unmanaged<IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateDRMImageMESA");
            return _eglCreateDRMImageMESA_fnptr(dpy, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateFenceSyncNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int*, IntPtr> _eglCreateFenceSyncNV_fnptr = &eglCreateFenceSyncNV_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateFenceSyncNV_Lazy(IntPtr dpy, uint condition, int* attrib_list)
        {
            _eglCreateFenceSyncNV_fnptr = (delegate* unmanaged<IntPtr, uint, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateFenceSyncNV");
            return _eglCreateFenceSyncNV_fnptr(dpy, condition, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, IntPtr*, IntPtr> _eglCreateImage_fnptr = &eglCreateImage_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateImage_Lazy(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list)
        {
            _eglCreateImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateImage");
            return _eglCreateImage_fnptr(dpy, ctx, target, buffer, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateImageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, int*, IntPtr> _eglCreateImageKHR_fnptr = &eglCreateImageKHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateImageKHR_Lazy(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, int* attrib_list)
        {
            _eglCreateImageKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateImageKHR");
            return _eglCreateImageKHR_fnptr(dpy, ctx, target, buffer, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateNativeClientBufferANDROID</c>]</b></summary>
        public static delegate* unmanaged<int*, IntPtr> _eglCreateNativeClientBufferANDROID_fnptr = &eglCreateNativeClientBufferANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateNativeClientBufferANDROID_Lazy(int* attrib_list)
        {
            _eglCreateNativeClientBufferANDROID_fnptr = (delegate* unmanaged<int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateNativeClientBufferANDROID");
            return _eglCreateNativeClientBufferANDROID_fnptr(attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePbufferFromClientBuffer</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr, IntPtr, int*, IntPtr> _eglCreatePbufferFromClientBuffer_fnptr = &eglCreatePbufferFromClientBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePbufferFromClientBuffer_Lazy(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list)
        {
            _eglCreatePbufferFromClientBuffer_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePbufferFromClientBuffer");
            return _eglCreatePbufferFromClientBuffer_fnptr(dpy, buftype, buffer, config, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePbufferSurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr> _eglCreatePbufferSurface_fnptr = &eglCreatePbufferSurface_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePbufferSurface_Lazy(IntPtr dpy, IntPtr config, int* attrib_list)
        {
            _eglCreatePbufferSurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePbufferSurface");
            return _eglCreatePbufferSurface_fnptr(dpy, config, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePixmapSurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr> _eglCreatePixmapSurface_fnptr = &eglCreatePixmapSurface_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePixmapSurface_Lazy(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list)
        {
            _eglCreatePixmapSurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePixmapSurface");
            return _eglCreatePixmapSurface_fnptr(dpy, config, pixmap, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePixmapSurfaceHI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, EGLClientPixmapHI*, IntPtr> _eglCreatePixmapSurfaceHI_fnptr = &eglCreatePixmapSurfaceHI_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePixmapSurfaceHI_Lazy(IntPtr dpy, IntPtr config, EGLClientPixmapHI* pixmap)
        {
            _eglCreatePixmapSurfaceHI_fnptr = (delegate* unmanaged<IntPtr, IntPtr, EGLClientPixmapHI*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePixmapSurfaceHI");
            return _eglCreatePixmapSurfaceHI_fnptr(dpy, config, pixmap);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePlatformPixmapSurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, IntPtr*, IntPtr> _eglCreatePlatformPixmapSurface_fnptr = &eglCreatePlatformPixmapSurface_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePlatformPixmapSurface_Lazy(IntPtr dpy, IntPtr config, void* native_pixmap, IntPtr* attrib_list)
        {
            _eglCreatePlatformPixmapSurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePlatformPixmapSurface");
            return _eglCreatePlatformPixmapSurface_fnptr(dpy, config, native_pixmap, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePlatformPixmapSurfaceEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, int*, IntPtr> _eglCreatePlatformPixmapSurfaceEXT_fnptr = &eglCreatePlatformPixmapSurfaceEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePlatformPixmapSurfaceEXT_Lazy(IntPtr dpy, IntPtr config, void* native_pixmap, int* attrib_list)
        {
            _eglCreatePlatformPixmapSurfaceEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePlatformPixmapSurfaceEXT");
            return _eglCreatePlatformPixmapSurfaceEXT_fnptr(dpy, config, native_pixmap, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePlatformWindowSurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, IntPtr*, IntPtr> _eglCreatePlatformWindowSurface_fnptr = &eglCreatePlatformWindowSurface_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePlatformWindowSurface_Lazy(IntPtr dpy, IntPtr config, void* native_window, IntPtr* attrib_list)
        {
            _eglCreatePlatformWindowSurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePlatformWindowSurface");
            return _eglCreatePlatformWindowSurface_fnptr(dpy, config, native_window, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreatePlatformWindowSurfaceEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, int*, IntPtr> _eglCreatePlatformWindowSurfaceEXT_fnptr = &eglCreatePlatformWindowSurfaceEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreatePlatformWindowSurfaceEXT_Lazy(IntPtr dpy, IntPtr config, void* native_window, int* attrib_list)
        {
            _eglCreatePlatformWindowSurfaceEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreatePlatformWindowSurfaceEXT");
            return _eglCreatePlatformWindowSurfaceEXT_fnptr(dpy, config, native_window, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateStreamAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, IntPtr> _eglCreateStreamAttribKHR_fnptr = &eglCreateStreamAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateStreamAttribKHR_Lazy(IntPtr dpy, IntPtr* attrib_list)
        {
            _eglCreateStreamAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateStreamAttribKHR");
            return _eglCreateStreamAttribKHR_fnptr(dpy, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateStreamFromFileDescriptorKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr> _eglCreateStreamFromFileDescriptorKHR_fnptr = &eglCreateStreamFromFileDescriptorKHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateStreamFromFileDescriptorKHR_Lazy(IntPtr dpy, int file_descriptor)
        {
            _eglCreateStreamFromFileDescriptorKHR_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateStreamFromFileDescriptorKHR");
            return _eglCreateStreamFromFileDescriptorKHR_fnptr(dpy, file_descriptor);
        }
        
        /// <summary><b>[entry point: <c>eglCreateStreamKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, IntPtr> _eglCreateStreamKHR_fnptr = &eglCreateStreamKHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateStreamKHR_Lazy(IntPtr dpy, int* attrib_list)
        {
            _eglCreateStreamKHR_fnptr = (delegate* unmanaged<IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateStreamKHR");
            return _eglCreateStreamKHR_fnptr(dpy, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateStreamProducerD3DTextureANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglCreateStreamProducerD3DTextureANGLE_fnptr = &eglCreateStreamProducerD3DTextureANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglCreateStreamProducerD3DTextureANGLE_Lazy(IntPtr dpy, IntPtr stream, IntPtr* attrib_list)
        {
            _eglCreateStreamProducerD3DTextureANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglCreateStreamProducerD3DTextureANGLE");
            return _eglCreateStreamProducerD3DTextureANGLE_fnptr(dpy, stream, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateStreamProducerSurfaceKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr> _eglCreateStreamProducerSurfaceKHR_fnptr = &eglCreateStreamProducerSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateStreamProducerSurfaceKHR_Lazy(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list)
        {
            _eglCreateStreamProducerSurfaceKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateStreamProducerSurfaceKHR");
            return _eglCreateStreamProducerSurfaceKHR_fnptr(dpy, config, stream, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateStreamSyncNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, int*, IntPtr> _eglCreateStreamSyncNV_fnptr = &eglCreateStreamSyncNV_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateStreamSyncNV_Lazy(IntPtr dpy, IntPtr stream, uint type, int* attrib_list)
        {
            _eglCreateStreamSyncNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateStreamSyncNV");
            return _eglCreateStreamSyncNV_fnptr(dpy, stream, type, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateSync</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr> _eglCreateSync_fnptr = &eglCreateSync_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateSync_Lazy(IntPtr dpy, uint type, IntPtr* attrib_list)
        {
            _eglCreateSync_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateSync");
            return _eglCreateSync_fnptr(dpy, type, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateSync64KHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr> _eglCreateSync64KHR_fnptr = &eglCreateSync64KHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateSync64KHR_Lazy(IntPtr dpy, uint type, IntPtr* attrib_list)
        {
            _eglCreateSync64KHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateSync64KHR");
            return _eglCreateSync64KHR_fnptr(dpy, type, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateSyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int*, IntPtr> _eglCreateSyncKHR_fnptr = &eglCreateSyncKHR_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateSyncKHR_Lazy(IntPtr dpy, uint type, int* attrib_list)
        {
            _eglCreateSyncKHR_fnptr = (delegate* unmanaged<IntPtr, uint, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateSyncKHR");
            return _eglCreateSyncKHR_fnptr(dpy, type, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglCreateWaylandBufferFromImageWL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*> _eglCreateWaylandBufferFromImageWL_fnptr = &eglCreateWaylandBufferFromImageWL_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr* eglCreateWaylandBufferFromImageWL_Lazy(IntPtr dpy, IntPtr image)
        {
            _eglCreateWaylandBufferFromImageWL_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*>)EGLLoader.BindingsContext.GetProcAddress("eglCreateWaylandBufferFromImageWL");
            return _eglCreateWaylandBufferFromImageWL_fnptr(dpy, image);
        }
        
        /// <summary><b>[entry point: <c>eglCreateWindowSurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr> _eglCreateWindowSurface_fnptr = &eglCreateWindowSurface_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglCreateWindowSurface_Lazy(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list)
        {
            _eglCreateWindowSurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglCreateWindowSurface");
            return _eglCreateWindowSurface_fnptr(dpy, config, win, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglDebugMessageControlKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int> _eglDebugMessageControlKHR_fnptr = &eglDebugMessageControlKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDebugMessageControlKHR_Lazy(IntPtr callback, IntPtr* attrib_list)
        {
            _eglDebugMessageControlKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglDebugMessageControlKHR");
            return _eglDebugMessageControlKHR_fnptr(callback, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglDestroyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroyContext_fnptr = &eglDestroyContext_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroyContext_Lazy(IntPtr dpy, IntPtr ctx)
        {
            _eglDestroyContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroyContext");
            return _eglDestroyContext_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>eglDestroyDisplayEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _eglDestroyDisplayEXT_fnptr = &eglDestroyDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroyDisplayEXT_Lazy(IntPtr dpy)
        {
            _eglDestroyDisplayEXT_fnptr = (delegate* unmanaged<IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroyDisplayEXT");
            return _eglDestroyDisplayEXT_fnptr(dpy);
        }
        
        /// <summary><b>[entry point: <c>eglDestroyImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroyImage_fnptr = &eglDestroyImage_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroyImage_Lazy(IntPtr dpy, IntPtr image)
        {
            _eglDestroyImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroyImage");
            return _eglDestroyImage_fnptr(dpy, image);
        }
        
        /// <summary><b>[entry point: <c>eglDestroyImageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroyImageKHR_fnptr = &eglDestroyImageKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroyImageKHR_Lazy(IntPtr dpy, IntPtr image)
        {
            _eglDestroyImageKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroyImageKHR");
            return _eglDestroyImageKHR_fnptr(dpy, image);
        }
        
        /// <summary><b>[entry point: <c>eglDestroyStreamKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroyStreamKHR_fnptr = &eglDestroyStreamKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroyStreamKHR_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglDestroyStreamKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroyStreamKHR");
            return _eglDestroyStreamKHR_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglDestroySurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroySurface_fnptr = &eglDestroySurface_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroySurface_Lazy(IntPtr dpy, IntPtr surface)
        {
            _eglDestroySurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroySurface");
            return _eglDestroySurface_fnptr(dpy, surface);
        }
        
        /// <summary><b>[entry point: <c>eglDestroySync</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroySync_fnptr = &eglDestroySync_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroySync_Lazy(IntPtr dpy, IntPtr sync)
        {
            _eglDestroySync_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroySync");
            return _eglDestroySync_fnptr(dpy, sync);
        }
        
        /// <summary><b>[entry point: <c>eglDestroySyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDestroySyncKHR_fnptr = &eglDestroySyncKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroySyncKHR_Lazy(IntPtr dpy, IntPtr sync)
        {
            _eglDestroySyncKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroySyncKHR");
            return _eglDestroySyncKHR_fnptr(dpy, sync);
        }
        
        /// <summary><b>[entry point: <c>eglDestroySyncNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _eglDestroySyncNV_fnptr = &eglDestroySyncNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDestroySyncNV_Lazy(IntPtr sync)
        {
            _eglDestroySyncNV_fnptr = (delegate* unmanaged<IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDestroySyncNV");
            return _eglDestroySyncNV_fnptr(sync);
        }
        
        /// <summary><b>[entry point: <c>eglDupNativeFenceFDANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglDupNativeFenceFDANDROID_fnptr = &eglDupNativeFenceFDANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglDupNativeFenceFDANDROID_Lazy(IntPtr dpy, IntPtr sync)
        {
            _eglDupNativeFenceFDANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglDupNativeFenceFDANDROID");
            return _eglDupNativeFenceFDANDROID_fnptr(dpy, sync);
        }
        
        /// <summary><b>[entry point: <c>eglExportDMABUFImageMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int*, int*, int> _eglExportDMABUFImageMESA_fnptr = &eglExportDMABUFImageMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int eglExportDMABUFImageMESA_Lazy(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets)
        {
            _eglExportDMABUFImageMESA_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglExportDMABUFImageMESA");
            return _eglExportDMABUFImageMESA_fnptr(dpy, image, fds, strides, offsets);
        }
        
        /// <summary><b>[entry point: <c>eglExportDMABUFImageQueryMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int*, ulong*, int> _eglExportDMABUFImageQueryMESA_fnptr = &eglExportDMABUFImageQueryMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int eglExportDMABUFImageQueryMESA_Lazy(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, ulong* modifiers)
        {
            _eglExportDMABUFImageQueryMESA_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int*, ulong*, int>)EGLLoader.BindingsContext.GetProcAddress("eglExportDMABUFImageQueryMESA");
            return _eglExportDMABUFImageQueryMESA_fnptr(dpy, image, fourcc, num_planes, modifiers);
        }
        
        /// <summary><b>[entry point: <c>eglExportDRMImageMESA</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int*, int*, int> _eglExportDRMImageMESA_fnptr = &eglExportDRMImageMESA_Lazy;
        [UnmanagedCallersOnly]
        private static int eglExportDRMImageMESA_Lazy(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride)
        {
            _eglExportDRMImageMESA_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglExportDRMImageMESA");
            return _eglExportDRMImageMESA_fnptr(dpy, image, name, handle, stride);
        }
        
        /// <summary><b>[entry point: <c>eglExportVkImageANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, void*, int> _eglExportVkImageANGLE_fnptr = &eglExportVkImageANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglExportVkImageANGLE_Lazy(IntPtr dpy, IntPtr image, void* vk_image, void* vk_image_create_info)
        {
            _eglExportVkImageANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, void*, int>)EGLLoader.BindingsContext.GetProcAddress("eglExportVkImageANGLE");
            return _eglExportVkImageANGLE_fnptr(dpy, image, vk_image, vk_image_create_info);
        }
        
        /// <summary><b>[entry point: <c>eglFenceNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _eglFenceNV_fnptr = &eglFenceNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglFenceNV_Lazy(IntPtr sync)
        {
            _eglFenceNV_fnptr = (delegate* unmanaged<IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglFenceNV");
            return _eglFenceNV_fnptr(sync);
        }
        
        /// <summary><b>[entry point: <c>eglForceGPUSwitchANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void> _eglForceGPUSwitchANGLE_fnptr = &eglForceGPUSwitchANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglForceGPUSwitchANGLE_Lazy(IntPtr dpy, int gpuIDHigh, int gpuIDLow)
        {
            _eglForceGPUSwitchANGLE_fnptr = (delegate* unmanaged<IntPtr, int, int, void>)EGLLoader.BindingsContext.GetProcAddress("eglForceGPUSwitchANGLE");
            _eglForceGPUSwitchANGLE_fnptr(dpy, gpuIDHigh, gpuIDLow);
        }
        
        /// <summary><b>[entry point: <c>eglGetCompositorTimingANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, long*, int> _eglGetCompositorTimingANDROID_fnptr = &eglGetCompositorTimingANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetCompositorTimingANDROID_Lazy(IntPtr dpy, IntPtr surface, int numTimestamps, int* names, long* values)
        {
            _eglGetCompositorTimingANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, long*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetCompositorTimingANDROID");
            return _eglGetCompositorTimingANDROID_fnptr(dpy, surface, numTimestamps, names, values);
        }
        
        /// <summary><b>[entry point: <c>eglGetCompositorTimingSupportedANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _eglGetCompositorTimingSupportedANDROID_fnptr = &eglGetCompositorTimingSupportedANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetCompositorTimingSupportedANDROID_Lazy(IntPtr dpy, IntPtr surface, int name)
        {
            _eglGetCompositorTimingSupportedANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetCompositorTimingSupportedANDROID");
            return _eglGetCompositorTimingSupportedANDROID_fnptr(dpy, surface, name);
        }
        
        /// <summary><b>[entry point: <c>eglGetConfigAttrib</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _eglGetConfigAttrib_fnptr = &eglGetConfigAttrib_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetConfigAttrib_Lazy(IntPtr dpy, IntPtr config, int attribute, int* value)
        {
            _eglGetConfigAttrib_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetConfigAttrib");
            return _eglGetConfigAttrib_fnptr(dpy, config, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglGetConfigs</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int, int*, int> _eglGetConfigs_fnptr = &eglGetConfigs_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetConfigs_Lazy(IntPtr dpy, IntPtr* configs, int config_size, int* num_config)
        {
            _eglGetConfigs_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetConfigs");
            return _eglGetConfigs_fnptr(dpy, configs, config_size, num_config);
        }
        
        /// <summary><b>[entry point: <c>eglGetCurrentContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _eglGetCurrentContext_fnptr = &eglGetCurrentContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetCurrentContext_Lazy()
        {
            _eglGetCurrentContext_fnptr = (delegate* unmanaged<IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetCurrentContext");
            return _eglGetCurrentContext_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglGetCurrentDisplay</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _eglGetCurrentDisplay_fnptr = &eglGetCurrentDisplay_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetCurrentDisplay_Lazy()
        {
            _eglGetCurrentDisplay_fnptr = (delegate* unmanaged<IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetCurrentDisplay");
            return _eglGetCurrentDisplay_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglGetCurrentSurface</c>]</b></summary>
        public static delegate* unmanaged<int, IntPtr> _eglGetCurrentSurface_fnptr = &eglGetCurrentSurface_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetCurrentSurface_Lazy(int readdraw)
        {
            _eglGetCurrentSurface_fnptr = (delegate* unmanaged<int, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetCurrentSurface");
            return _eglGetCurrentSurface_fnptr(readdraw);
        }
        
        /// <summary><b>[entry point: <c>eglGetDisplay</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _eglGetDisplay_fnptr = &eglGetDisplay_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetDisplay_Lazy(IntPtr display_id)
        {
            _eglGetDisplay_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetDisplay");
            return _eglGetDisplay_fnptr(display_id);
        }
        
        /// <summary><b>[entry point: <c>eglGetDisplayDriverConfig</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*> _eglGetDisplayDriverConfig_fnptr = &eglGetDisplayDriverConfig_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglGetDisplayDriverConfig_Lazy(IntPtr dpy)
        {
            _eglGetDisplayDriverConfig_fnptr = (delegate* unmanaged<IntPtr, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglGetDisplayDriverConfig");
            return _eglGetDisplayDriverConfig_fnptr(dpy);
        }
        
        /// <summary><b>[entry point: <c>eglGetDisplayDriverName</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*> _eglGetDisplayDriverName_fnptr = &eglGetDisplayDriverName_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglGetDisplayDriverName_Lazy(IntPtr dpy)
        {
            _eglGetDisplayDriverName_fnptr = (delegate* unmanaged<IntPtr, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglGetDisplayDriverName");
            return _eglGetDisplayDriverName_fnptr(dpy);
        }
        
        /// <summary><b>[entry point: <c>eglGetError</c>]</b></summary>
        public static delegate* unmanaged<int> _eglGetError_fnptr = &eglGetError_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetError_Lazy()
        {
            _eglGetError_fnptr = (delegate* unmanaged<int>)EGLLoader.BindingsContext.GetProcAddress("eglGetError");
            return _eglGetError_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglGetFrameTimestampsANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong, int, int*, long*, int> _eglGetFrameTimestampsANDROID_fnptr = &eglGetFrameTimestampsANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetFrameTimestampsANDROID_Lazy(IntPtr dpy, IntPtr surface, ulong frameId, int numTimestamps, int* timestamps, long* values)
        {
            _eglGetFrameTimestampsANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong, int, int*, long*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetFrameTimestampsANDROID");
            return _eglGetFrameTimestampsANDROID_fnptr(dpy, surface, frameId, numTimestamps, timestamps, values);
        }
        
        /// <summary><b>[entry point: <c>eglGetFrameTimestampSupportedANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _eglGetFrameTimestampSupportedANDROID_fnptr = &eglGetFrameTimestampSupportedANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetFrameTimestampSupportedANDROID_Lazy(IntPtr dpy, IntPtr surface, int timestamp)
        {
            _eglGetFrameTimestampSupportedANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetFrameTimestampSupportedANDROID");
            return _eglGetFrameTimestampSupportedANDROID_fnptr(dpy, surface, timestamp);
        }
        
        /// <summary><b>[entry point: <c>eglGetMscRateANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int*, int> _eglGetMscRateANGLE_fnptr = &eglGetMscRateANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetMscRateANGLE_Lazy(IntPtr dpy, IntPtr surface, int* numerator, int* denominator)
        {
            _eglGetMscRateANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetMscRateANGLE");
            return _eglGetMscRateANGLE_fnptr(dpy, surface, numerator, denominator);
        }
        
        /// <summary><b>[entry point: <c>eglGetNativeClientBufferANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _eglGetNativeClientBufferANDROID_fnptr = &eglGetNativeClientBufferANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetNativeClientBufferANDROID_Lazy(IntPtr buffer)
        {
            _eglGetNativeClientBufferANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetNativeClientBufferANDROID");
            return _eglGetNativeClientBufferANDROID_fnptr(buffer);
        }
        
        /// <summary><b>[entry point: <c>eglGetNextFrameIdANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, int> _eglGetNextFrameIdANDROID_fnptr = &eglGetNextFrameIdANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetNextFrameIdANDROID_Lazy(IntPtr dpy, IntPtr surface, ulong* frameId)
        {
            _eglGetNextFrameIdANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetNextFrameIdANDROID");
            return _eglGetNextFrameIdANDROID_fnptr(dpy, surface, frameId);
        }
        
        /// <summary><b>[entry point: <c>eglGetOutputLayersEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, int, int*, int> _eglGetOutputLayersEXT_fnptr = &eglGetOutputLayersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetOutputLayersEXT_Lazy(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers)
        {
            _eglGetOutputLayersEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetOutputLayersEXT");
            return _eglGetOutputLayersEXT_fnptr(dpy, attrib_list, layers, max_layers, num_layers);
        }
        
        /// <summary><b>[entry point: <c>eglGetOutputPortsEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, int, int*, int> _eglGetOutputPortsEXT_fnptr = &eglGetOutputPortsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetOutputPortsEXT_Lazy(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports)
        {
            _eglGetOutputPortsEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, IntPtr*, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetOutputPortsEXT");
            return _eglGetOutputPortsEXT_fnptr(dpy, attrib_list, ports, max_ports, num_ports);
        }
        
        /// <summary><b>[entry point: <c>eglGetPlatformDisplay</c>]</b></summary>
        public static delegate* unmanaged<uint, void*, IntPtr*, IntPtr> _eglGetPlatformDisplay_fnptr = &eglGetPlatformDisplay_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetPlatformDisplay_Lazy(uint platform, void* native_display, IntPtr* attrib_list)
        {
            _eglGetPlatformDisplay_fnptr = (delegate* unmanaged<uint, void*, IntPtr*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetPlatformDisplay");
            return _eglGetPlatformDisplay_fnptr(platform, native_display, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglGetPlatformDisplayEXT</c>]</b></summary>
        public static delegate* unmanaged<uint, void*, int*, IntPtr> _eglGetPlatformDisplayEXT_fnptr = &eglGetPlatformDisplayEXT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetPlatformDisplayEXT_Lazy(uint platform, void* native_display, int* attrib_list)
        {
            _eglGetPlatformDisplayEXT_fnptr = (delegate* unmanaged<uint, void*, int*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetPlatformDisplayEXT");
            return _eglGetPlatformDisplayEXT_fnptr(platform, native_display, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _eglGetProcAddress_fnptr = &eglGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr eglGetProcAddress_Lazy(byte* procname)
        {
            _eglGetProcAddress_fnptr = (delegate* unmanaged<byte*, IntPtr>)EGLLoader.BindingsContext.GetProcAddress("eglGetProcAddress");
            return _eglGetProcAddress_fnptr(procname);
        }
        
        /// <summary><b>[entry point: <c>eglGetStreamFileDescriptorKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglGetStreamFileDescriptorKHR_fnptr = &eglGetStreamFileDescriptorKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetStreamFileDescriptorKHR_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglGetStreamFileDescriptorKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetStreamFileDescriptorKHR");
            return _eglGetStreamFileDescriptorKHR_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglGetSyncAttrib</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int> _eglGetSyncAttrib_fnptr = &eglGetSyncAttrib_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetSyncAttrib_Lazy(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value)
        {
            _eglGetSyncAttrib_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetSyncAttrib");
            return _eglGetSyncAttrib_fnptr(dpy, sync, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglGetSyncAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _eglGetSyncAttribKHR_fnptr = &eglGetSyncAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetSyncAttribKHR_Lazy(IntPtr dpy, IntPtr sync, int attribute, int* value)
        {
            _eglGetSyncAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetSyncAttribKHR");
            return _eglGetSyncAttribKHR_fnptr(dpy, sync, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglGetSyncAttribNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int> _eglGetSyncAttribNV_fnptr = &eglGetSyncAttribNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetSyncAttribNV_Lazy(IntPtr sync, int attribute, int* value)
        {
            _eglGetSyncAttribNV_fnptr = (delegate* unmanaged<IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetSyncAttribNV");
            return _eglGetSyncAttribNV_fnptr(sync, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglGetSyncValuesCHROMIUM</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong*, ulong*, ulong*, int> _eglGetSyncValuesCHROMIUM_fnptr = &eglGetSyncValuesCHROMIUM_Lazy;
        [UnmanagedCallersOnly]
        private static int eglGetSyncValuesCHROMIUM_Lazy(IntPtr dpy, IntPtr surface, ulong* ust, ulong* msc, ulong* sbc)
        {
            _eglGetSyncValuesCHROMIUM_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong*, ulong*, ulong*, int>)EGLLoader.BindingsContext.GetProcAddress("eglGetSyncValuesCHROMIUM");
            return _eglGetSyncValuesCHROMIUM_fnptr(dpy, surface, ust, msc, sbc);
        }
        
        /// <summary><b>[entry point: <c>eglGetSystemTimeFrequencyNV</c>]</b></summary>
        public static delegate* unmanaged<ulong> _eglGetSystemTimeFrequencyNV_fnptr = &eglGetSystemTimeFrequencyNV_Lazy;
        [UnmanagedCallersOnly]
        private static ulong eglGetSystemTimeFrequencyNV_Lazy()
        {
            _eglGetSystemTimeFrequencyNV_fnptr = (delegate* unmanaged<ulong>)EGLLoader.BindingsContext.GetProcAddress("eglGetSystemTimeFrequencyNV");
            return _eglGetSystemTimeFrequencyNV_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglGetSystemTimeNV</c>]</b></summary>
        public static delegate* unmanaged<ulong> _eglGetSystemTimeNV_fnptr = &eglGetSystemTimeNV_Lazy;
        [UnmanagedCallersOnly]
        private static ulong eglGetSystemTimeNV_Lazy()
        {
            _eglGetSystemTimeNV_fnptr = (delegate* unmanaged<ulong>)EGLLoader.BindingsContext.GetProcAddress("eglGetSystemTimeNV");
            return _eglGetSystemTimeNV_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglHandleGPUSwitchANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _eglHandleGPUSwitchANGLE_fnptr = &eglHandleGPUSwitchANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglHandleGPUSwitchANGLE_Lazy(IntPtr dpy)
        {
            _eglHandleGPUSwitchANGLE_fnptr = (delegate* unmanaged<IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglHandleGPUSwitchANGLE");
            _eglHandleGPUSwitchANGLE_fnptr(dpy);
        }
        
        /// <summary><b>[entry point: <c>eglInitialize</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, int*, int> _eglInitialize_fnptr = &eglInitialize_Lazy;
        [UnmanagedCallersOnly]
        private static int eglInitialize_Lazy(IntPtr dpy, int* major, int* minor)
        {
            _eglInitialize_fnptr = (delegate* unmanaged<IntPtr, int*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglInitialize");
            return _eglInitialize_fnptr(dpy, major, minor);
        }
        
        /// <summary><b>[entry point: <c>eglLabelObjectKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, IntPtr, IntPtr, int> _eglLabelObjectKHR_fnptr = &eglLabelObjectKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglLabelObjectKHR_Lazy(IntPtr display, uint objectType, IntPtr obj, IntPtr label)
        {
            _eglLabelObjectKHR_fnptr = (delegate* unmanaged<IntPtr, uint, IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglLabelObjectKHR");
            return _eglLabelObjectKHR_fnptr(display, objectType, obj, label);
        }
        
        /// <summary><b>[entry point: <c>eglLockSurfaceKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int> _eglLockSurfaceKHR_fnptr = &eglLockSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglLockSurfaceKHR_Lazy(IntPtr dpy, IntPtr surface, int* attrib_list)
        {
            _eglLockSurfaceKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglLockSurfaceKHR");
            return _eglLockSurfaceKHR_fnptr(dpy, surface, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglMakeCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr, int> _eglMakeCurrent_fnptr = &eglMakeCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static int eglMakeCurrent_Lazy(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
        {
            _eglMakeCurrent_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglMakeCurrent");
            return _eglMakeCurrent_fnptr(dpy, draw, read, ctx);
        }
        
        /// <summary><b>[entry point: <c>eglOutputLayerAttribEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, int> _eglOutputLayerAttribEXT_fnptr = &eglOutputLayerAttribEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglOutputLayerAttribEXT_Lazy(IntPtr dpy, IntPtr layer, int attribute, IntPtr value)
        {
            _eglOutputLayerAttribEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglOutputLayerAttribEXT");
            return _eglOutputLayerAttribEXT_fnptr(dpy, layer, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglOutputPortAttribEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, int> _eglOutputPortAttribEXT_fnptr = &eglOutputPortAttribEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglOutputPortAttribEXT_Lazy(IntPtr dpy, IntPtr port, int attribute, IntPtr value)
        {
            _eglOutputPortAttribEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglOutputPortAttribEXT");
            return _eglOutputPortAttribEXT_fnptr(dpy, port, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglPostSubBufferNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int, int, int, int> _eglPostSubBufferNV_fnptr = &eglPostSubBufferNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglPostSubBufferNV_Lazy(IntPtr dpy, IntPtr surface, int x, int y, int width, int height)
        {
            _eglPostSubBufferNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int, int, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglPostSubBufferNV");
            return _eglPostSubBufferNV_fnptr(dpy, surface, x, y, width, height);
        }
        
        /// <summary><b>[entry point: <c>eglPrepareSwapBuffersANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglPrepareSwapBuffersANGLE_fnptr = &eglPrepareSwapBuffersANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglPrepareSwapBuffersANGLE_Lazy(IntPtr dpy, IntPtr surface)
        {
            _eglPrepareSwapBuffersANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglPrepareSwapBuffersANGLE");
            return _eglPrepareSwapBuffersANGLE_fnptr(dpy, surface);
        }
        
        /// <summary><b>[entry point: <c>eglPresentationTimeANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, long, int> _eglPresentationTimeANDROID_fnptr = &eglPresentationTimeANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static int eglPresentationTimeANDROID_Lazy(IntPtr dpy, IntPtr surface, long time)
        {
            _eglPresentationTimeANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, long, int>)EGLLoader.BindingsContext.GetProcAddress("eglPresentationTimeANDROID");
            return _eglPresentationTimeANDROID_fnptr(dpy, surface, time);
        }
        
        /// <summary><b>[entry point: <c>eglProgramCacheGetAttribANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _eglProgramCacheGetAttribANGLE_fnptr = &eglProgramCacheGetAttribANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglProgramCacheGetAttribANGLE_Lazy(IntPtr dpy, uint attrib)
        {
            _eglProgramCacheGetAttribANGLE_fnptr = (delegate* unmanaged<IntPtr, uint, int>)EGLLoader.BindingsContext.GetProcAddress("eglProgramCacheGetAttribANGLE");
            return _eglProgramCacheGetAttribANGLE_fnptr(dpy, attrib);
        }
        
        /// <summary><b>[entry point: <c>eglProgramCachePopulateANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int, void*, int, void> _eglProgramCachePopulateANGLE_fnptr = &eglProgramCachePopulateANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglProgramCachePopulateANGLE_Lazy(IntPtr dpy, void* key, int keysize, void* binary, int binarysize)
        {
            _eglProgramCachePopulateANGLE_fnptr = (delegate* unmanaged<IntPtr, void*, int, void*, int, void>)EGLLoader.BindingsContext.GetProcAddress("eglProgramCachePopulateANGLE");
            _eglProgramCachePopulateANGLE_fnptr(dpy, key, keysize, binary, binarysize);
        }
        
        /// <summary><b>[entry point: <c>eglProgramCacheQueryANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void*, int*, void*, int*, void> _eglProgramCacheQueryANGLE_fnptr = &eglProgramCacheQueryANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglProgramCacheQueryANGLE_Lazy(IntPtr dpy, int index, void* key, int* keysize, void* binary, int* binarysize)
        {
            _eglProgramCacheQueryANGLE_fnptr = (delegate* unmanaged<IntPtr, int, void*, int*, void*, int*, void>)EGLLoader.BindingsContext.GetProcAddress("eglProgramCacheQueryANGLE");
            _eglProgramCacheQueryANGLE_fnptr(dpy, index, key, keysize, binary, binarysize);
        }
        
        /// <summary><b>[entry point: <c>eglProgramCacheResizeANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int> _eglProgramCacheResizeANGLE_fnptr = &eglProgramCacheResizeANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglProgramCacheResizeANGLE_Lazy(IntPtr dpy, int limit, int mode)
        {
            _eglProgramCacheResizeANGLE_fnptr = (delegate* unmanaged<IntPtr, int, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglProgramCacheResizeANGLE");
            return _eglProgramCacheResizeANGLE_fnptr(dpy, limit, mode);
        }
        
        /// <summary><b>[entry point: <c>eglQueryAPI</c>]</b></summary>
        public static delegate* unmanaged<uint> _eglQueryAPI_fnptr = &eglQueryAPI_Lazy;
        [UnmanagedCallersOnly]
        private static uint eglQueryAPI_Lazy()
        {
            _eglQueryAPI_fnptr = (delegate* unmanaged<uint>)EGLLoader.BindingsContext.GetProcAddress("eglQueryAPI");
            return _eglQueryAPI_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglQueryContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _eglQueryContext_fnptr = &eglQueryContext_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryContext_Lazy(IntPtr dpy, IntPtr ctx, int attribute, int* value)
        {
            _eglQueryContext_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryContext");
            return _eglQueryContext_fnptr(dpy, ctx, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDebugKHR</c>]</b></summary>
        public static delegate* unmanaged<int, IntPtr*, int> _eglQueryDebugKHR_fnptr = &eglQueryDebugKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDebugKHR_Lazy(int attribute, IntPtr* value)
        {
            _eglQueryDebugKHR_fnptr = (delegate* unmanaged<int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDebugKHR");
            return _eglQueryDebugKHR_fnptr(attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDeviceAttribEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _eglQueryDeviceAttribEXT_fnptr = &eglQueryDeviceAttribEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDeviceAttribEXT_Lazy(IntPtr device, int attribute, IntPtr* value)
        {
            _eglQueryDeviceAttribEXT_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDeviceAttribEXT");
            return _eglQueryDeviceAttribEXT_fnptr(device, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDeviceBinaryEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void*, int*, int> _eglQueryDeviceBinaryEXT_fnptr = &eglQueryDeviceBinaryEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDeviceBinaryEXT_Lazy(IntPtr device, int name, int max_size, void* value, int* size)
        {
            _eglQueryDeviceBinaryEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, void*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDeviceBinaryEXT");
            return _eglQueryDeviceBinaryEXT_fnptr(device, name, max_size, value, size);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDevicesEXT</c>]</b></summary>
        public static delegate* unmanaged<int, IntPtr*, int*, int> _eglQueryDevicesEXT_fnptr = &eglQueryDevicesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDevicesEXT_Lazy(int max_devices, IntPtr* devices, int* num_devices)
        {
            _eglQueryDevicesEXT_fnptr = (delegate* unmanaged<int, IntPtr*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDevicesEXT");
            return _eglQueryDevicesEXT_fnptr(max_devices, devices, num_devices);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDeviceStringEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _eglQueryDeviceStringEXT_fnptr = &eglQueryDeviceStringEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglQueryDeviceStringEXT_Lazy(IntPtr device, int name)
        {
            _eglQueryDeviceStringEXT_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDeviceStringEXT");
            return _eglQueryDeviceStringEXT_fnptr(device, name);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDisplayAttribANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _eglQueryDisplayAttribANGLE_fnptr = &eglQueryDisplayAttribANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDisplayAttribANGLE_Lazy(IntPtr dpy, int attribute, IntPtr* value)
        {
            _eglQueryDisplayAttribANGLE_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDisplayAttribANGLE");
            return _eglQueryDisplayAttribANGLE_fnptr(dpy, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDisplayAttribEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _eglQueryDisplayAttribEXT_fnptr = &eglQueryDisplayAttribEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDisplayAttribEXT_Lazy(IntPtr dpy, int attribute, IntPtr* value)
        {
            _eglQueryDisplayAttribEXT_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDisplayAttribEXT");
            return _eglQueryDisplayAttribEXT_fnptr(dpy, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDisplayAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _eglQueryDisplayAttribKHR_fnptr = &eglQueryDisplayAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDisplayAttribKHR_Lazy(IntPtr dpy, int name, IntPtr* value)
        {
            _eglQueryDisplayAttribKHR_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDisplayAttribKHR");
            return _eglQueryDisplayAttribKHR_fnptr(dpy, name, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDisplayAttribNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, IntPtr*, int> _eglQueryDisplayAttribNV_fnptr = &eglQueryDisplayAttribNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDisplayAttribNV_Lazy(IntPtr dpy, int attribute, IntPtr* value)
        {
            _eglQueryDisplayAttribNV_fnptr = (delegate* unmanaged<IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDisplayAttribNV");
            return _eglQueryDisplayAttribNV_fnptr(dpy, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDmaBufFormatsEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int*, int> _eglQueryDmaBufFormatsEXT_fnptr = &eglQueryDmaBufFormatsEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDmaBufFormatsEXT_Lazy(IntPtr dpy, int max_formats, int* formats, int* num_formats)
        {
            _eglQueryDmaBufFormatsEXT_fnptr = (delegate* unmanaged<IntPtr, int, int*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDmaBufFormatsEXT");
            return _eglQueryDmaBufFormatsEXT_fnptr(dpy, max_formats, formats, num_formats);
        }
        
        /// <summary><b>[entry point: <c>eglQueryDmaBufModifiersEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, ulong*, int*, int*, int> _eglQueryDmaBufModifiersEXT_fnptr = &eglQueryDmaBufModifiersEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryDmaBufModifiersEXT_Lazy(IntPtr dpy, int format, int max_modifiers, ulong* modifiers, int* external_only, int* num_modifiers)
        {
            _eglQueryDmaBufModifiersEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, ulong*, int*, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryDmaBufModifiersEXT");
            return _eglQueryDmaBufModifiersEXT_fnptr(dpy, format, max_modifiers, modifiers, external_only, num_modifiers);
        }
        
        /// <summary><b>[entry point: <c>eglQueryNativeDisplayNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int> _eglQueryNativeDisplayNV_fnptr = &eglQueryNativeDisplayNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryNativeDisplayNV_Lazy(IntPtr dpy, IntPtr* display_id)
        {
            _eglQueryNativeDisplayNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryNativeDisplayNV");
            return _eglQueryNativeDisplayNV_fnptr(dpy, display_id);
        }
        
        /// <summary><b>[entry point: <c>eglQueryNativePixmapNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglQueryNativePixmapNV_fnptr = &eglQueryNativePixmapNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryNativePixmapNV_Lazy(IntPtr dpy, IntPtr surf, IntPtr* pixmap)
        {
            _eglQueryNativePixmapNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryNativePixmapNV");
            return _eglQueryNativePixmapNV_fnptr(dpy, surf, pixmap);
        }
        
        /// <summary><b>[entry point: <c>eglQueryNativeWindowNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglQueryNativeWindowNV_fnptr = &eglQueryNativeWindowNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryNativeWindowNV_Lazy(IntPtr dpy, IntPtr surf, IntPtr* window)
        {
            _eglQueryNativeWindowNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryNativeWindowNV");
            return _eglQueryNativeWindowNV_fnptr(dpy, surf, window);
        }
        
        /// <summary><b>[entry point: <c>eglQueryOutputLayerAttribEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int> _eglQueryOutputLayerAttribEXT_fnptr = &eglQueryOutputLayerAttribEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryOutputLayerAttribEXT_Lazy(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value)
        {
            _eglQueryOutputLayerAttribEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryOutputLayerAttribEXT");
            return _eglQueryOutputLayerAttribEXT_fnptr(dpy, layer, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryOutputLayerStringEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, byte*> _eglQueryOutputLayerStringEXT_fnptr = &eglQueryOutputLayerStringEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglQueryOutputLayerStringEXT_Lazy(IntPtr dpy, IntPtr layer, int name)
        {
            _eglQueryOutputLayerStringEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglQueryOutputLayerStringEXT");
            return _eglQueryOutputLayerStringEXT_fnptr(dpy, layer, name);
        }
        
        /// <summary><b>[entry point: <c>eglQueryOutputPortAttribEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int> _eglQueryOutputPortAttribEXT_fnptr = &eglQueryOutputPortAttribEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryOutputPortAttribEXT_Lazy(IntPtr dpy, IntPtr port, int attribute, IntPtr* value)
        {
            _eglQueryOutputPortAttribEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryOutputPortAttribEXT");
            return _eglQueryOutputPortAttribEXT_fnptr(dpy, port, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryOutputPortStringEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, byte*> _eglQueryOutputPortStringEXT_fnptr = &eglQueryOutputPortStringEXT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglQueryOutputPortStringEXT_Lazy(IntPtr dpy, IntPtr port, int name)
        {
            _eglQueryOutputPortStringEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglQueryOutputPortStringEXT");
            return _eglQueryOutputPortStringEXT_fnptr(dpy, port, name);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStreamAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr*, int> _eglQueryStreamAttribKHR_fnptr = &eglQueryStreamAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryStreamAttribKHR_Lazy(IntPtr dpy, IntPtr stream, uint attribute, IntPtr* value)
        {
            _eglQueryStreamAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStreamAttribKHR");
            return _eglQueryStreamAttribKHR_fnptr(dpy, stream, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStreamConsumerEventNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong, uint*, IntPtr*, int> _eglQueryStreamConsumerEventNV_fnptr = &eglQueryStreamConsumerEventNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryStreamConsumerEventNV_Lazy(IntPtr dpy, IntPtr stream, ulong timeout, uint* @event, IntPtr* aux)
        {
            _eglQueryStreamConsumerEventNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong, uint*, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStreamConsumerEventNV");
            return _eglQueryStreamConsumerEventNV_fnptr(dpy, stream, timeout, @event, aux);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStreamKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, int*, int> _eglQueryStreamKHR_fnptr = &eglQueryStreamKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryStreamKHR_Lazy(IntPtr dpy, IntPtr stream, uint attribute, int* value)
        {
            _eglQueryStreamKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStreamKHR");
            return _eglQueryStreamKHR_fnptr(dpy, stream, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStreamMetadataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, int, int, int, void*, int> _eglQueryStreamMetadataNV_fnptr = &eglQueryStreamMetadataNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryStreamMetadataNV_Lazy(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, void* data)
        {
            _eglQueryStreamMetadataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int, int, int, void*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStreamMetadataNV");
            return _eglQueryStreamMetadataNV_fnptr(dpy, stream, name, n, offset, size, data);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStreamTimeKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, ulong*, int> _eglQueryStreamTimeKHR_fnptr = &eglQueryStreamTimeKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryStreamTimeKHR_Lazy(IntPtr dpy, IntPtr stream, uint attribute, ulong* value)
        {
            _eglQueryStreamTimeKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, ulong*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStreamTimeKHR");
            return _eglQueryStreamTimeKHR_fnptr(dpy, stream, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStreamu64KHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, ulong*, int> _eglQueryStreamu64KHR_fnptr = &eglQueryStreamu64KHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryStreamu64KHR_Lazy(IntPtr dpy, IntPtr stream, uint attribute, ulong* value)
        {
            _eglQueryStreamu64KHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, ulong*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStreamu64KHR");
            return _eglQueryStreamu64KHR_fnptr(dpy, stream, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _eglQueryString_fnptr = &eglQueryString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglQueryString_Lazy(IntPtr dpy, int name)
        {
            _eglQueryString_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglQueryString");
            return _eglQueryString_fnptr(dpy, name);
        }
        
        /// <summary><b>[entry point: <c>eglQueryStringiANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, byte*> _eglQueryStringiANGLE_fnptr = &eglQueryStringiANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static byte* eglQueryStringiANGLE_Lazy(IntPtr dpy, int name, int index)
        {
            _eglQueryStringiANGLE_fnptr = (delegate* unmanaged<IntPtr, int, int, byte*>)EGLLoader.BindingsContext.GetProcAddress("eglQueryStringiANGLE");
            return _eglQueryStringiANGLE_fnptr(dpy, name, index);
        }
        
        /// <summary><b>[entry point: <c>eglQuerySupportedCompressionRatesEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int*, int, int*, int> _eglQuerySupportedCompressionRatesEXT_fnptr = &eglQuerySupportedCompressionRatesEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQuerySupportedCompressionRatesEXT_Lazy(IntPtr dpy, IntPtr config, IntPtr* attrib_list, int* rates, int rate_size, int* num_rates)
        {
            _eglQuerySupportedCompressionRatesEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int*, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQuerySupportedCompressionRatesEXT");
            return _eglQuerySupportedCompressionRatesEXT_fnptr(dpy, config, attrib_list, rates, rate_size, num_rates);
        }
        
        /// <summary><b>[entry point: <c>eglQuerySurface</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _eglQuerySurface_fnptr = &eglQuerySurface_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQuerySurface_Lazy(IntPtr dpy, IntPtr surface, int attribute, int* value)
        {
            _eglQuerySurface_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQuerySurface");
            return _eglQuerySurface_fnptr(dpy, surface, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQuerySurface64KHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int> _eglQuerySurface64KHR_fnptr = &eglQuerySurface64KHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQuerySurface64KHR_Lazy(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value)
        {
            _eglQuerySurface64KHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQuerySurface64KHR");
            return _eglQuerySurface64KHR_fnptr(dpy, surface, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQuerySurfacePointerANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, void**, int> _eglQuerySurfacePointerANGLE_fnptr = &eglQuerySurfacePointerANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQuerySurfacePointerANGLE_Lazy(IntPtr dpy, IntPtr surface, int attribute, void** value)
        {
            _eglQuerySurfacePointerANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, void**, int>)EGLLoader.BindingsContext.GetProcAddress("eglQuerySurfacePointerANGLE");
            return _eglQuerySurfacePointerANGLE_fnptr(dpy, surface, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglQueryWaylandBufferWL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int, int*, int> _eglQueryWaylandBufferWL_fnptr = &eglQueryWaylandBufferWL_Lazy;
        [UnmanagedCallersOnly]
        private static int eglQueryWaylandBufferWL_Lazy(IntPtr dpy, IntPtr* buffer, int attribute, int* value)
        {
            _eglQueryWaylandBufferWL_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglQueryWaylandBufferWL");
            return _eglQueryWaylandBufferWL_fnptr(dpy, buffer, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglReacquireHighPowerGPUANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _eglReacquireHighPowerGPUANGLE_fnptr = &eglReacquireHighPowerGPUANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglReacquireHighPowerGPUANGLE_Lazy(IntPtr dpy, IntPtr ctx)
        {
            _eglReacquireHighPowerGPUANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglReacquireHighPowerGPUANGLE");
            _eglReacquireHighPowerGPUANGLE_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>eglReleaseDeviceANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _eglReleaseDeviceANGLE_fnptr = &eglReleaseDeviceANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglReleaseDeviceANGLE_Lazy(IntPtr device)
        {
            _eglReleaseDeviceANGLE_fnptr = (delegate* unmanaged<IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglReleaseDeviceANGLE");
            return _eglReleaseDeviceANGLE_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>eglReleaseExternalContextANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _eglReleaseExternalContextANGLE_fnptr = &eglReleaseExternalContextANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglReleaseExternalContextANGLE_Lazy(IntPtr dpy)
        {
            _eglReleaseExternalContextANGLE_fnptr = (delegate* unmanaged<IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglReleaseExternalContextANGLE");
            _eglReleaseExternalContextANGLE_fnptr(dpy);
        }
        
        /// <summary><b>[entry point: <c>eglReleaseHighPowerGPUANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void> _eglReleaseHighPowerGPUANGLE_fnptr = &eglReleaseHighPowerGPUANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglReleaseHighPowerGPUANGLE_Lazy(IntPtr dpy, IntPtr ctx)
        {
            _eglReleaseHighPowerGPUANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglReleaseHighPowerGPUANGLE");
            _eglReleaseHighPowerGPUANGLE_fnptr(dpy, ctx);
        }
        
        /// <summary><b>[entry point: <c>eglReleaseTexImage</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _eglReleaseTexImage_fnptr = &eglReleaseTexImage_Lazy;
        [UnmanagedCallersOnly]
        private static int eglReleaseTexImage_Lazy(IntPtr dpy, IntPtr surface, int buffer)
        {
            _eglReleaseTexImage_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglReleaseTexImage");
            return _eglReleaseTexImage_fnptr(dpy, surface, buffer);
        }
        
        /// <summary><b>[entry point: <c>eglReleaseThread</c>]</b></summary>
        public static delegate* unmanaged<int> _eglReleaseThread_fnptr = &eglReleaseThread_Lazy;
        [UnmanagedCallersOnly]
        private static int eglReleaseThread_Lazy()
        {
            _eglReleaseThread_fnptr = (delegate* unmanaged<int>)EGLLoader.BindingsContext.GetProcAddress("eglReleaseThread");
            return _eglReleaseThread_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglResetStreamNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglResetStreamNV_fnptr = &eglResetStreamNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglResetStreamNV_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglResetStreamNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglResetStreamNV");
            return _eglResetStreamNV_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglSetBlobCacheFuncsANDROID</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, void> _eglSetBlobCacheFuncsANDROID_fnptr = &eglSetBlobCacheFuncsANDROID_Lazy;
        [UnmanagedCallersOnly]
        private static void eglSetBlobCacheFuncsANDROID_Lazy(IntPtr dpy, IntPtr set, IntPtr get)
        {
            _eglSetBlobCacheFuncsANDROID_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglSetBlobCacheFuncsANDROID");
            _eglSetBlobCacheFuncsANDROID_fnptr(dpy, set, get);
        }
        
        /// <summary><b>[entry point: <c>eglSetDamageRegionKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int, int> _eglSetDamageRegionKHR_fnptr = &eglSetDamageRegionKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSetDamageRegionKHR_Lazy(IntPtr dpy, IntPtr surface, int* rects, int n_rects)
        {
            _eglSetDamageRegionKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglSetDamageRegionKHR");
            return _eglSetDamageRegionKHR_fnptr(dpy, surface, rects, n_rects);
        }
        
        /// <summary><b>[entry point: <c>eglSetStreamAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, int> _eglSetStreamAttribKHR_fnptr = &eglSetStreamAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSetStreamAttribKHR_Lazy(IntPtr dpy, IntPtr stream, uint attribute, IntPtr value)
        {
            _eglSetStreamAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglSetStreamAttribKHR");
            return _eglSetStreamAttribKHR_fnptr(dpy, stream, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglSetStreamMetadataNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int, int, void*, int> _eglSetStreamMetadataNV_fnptr = &eglSetStreamMetadataNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSetStreamMetadataNV_Lazy(IntPtr dpy, IntPtr stream, int n, int offset, int size, void* data)
        {
            _eglSetStreamMetadataNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int, int, void*, int>)EGLLoader.BindingsContext.GetProcAddress("eglSetStreamMetadataNV");
            return _eglSetStreamMetadataNV_fnptr(dpy, stream, n, offset, size, data);
        }
        
        /// <summary><b>[entry point: <c>eglSetValidationEnabledANGLE</c>]</b></summary>
        public static delegate* unmanaged<int, void> _eglSetValidationEnabledANGLE_fnptr = &eglSetValidationEnabledANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglSetValidationEnabledANGLE_Lazy(int validationState)
        {
            _eglSetValidationEnabledANGLE_fnptr = (delegate* unmanaged<int, void>)EGLLoader.BindingsContext.GetProcAddress("eglSetValidationEnabledANGLE");
            _eglSetValidationEnabledANGLE_fnptr(validationState);
        }
        
        /// <summary><b>[entry point: <c>eglSignalSyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, int> _eglSignalSyncKHR_fnptr = &eglSignalSyncKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSignalSyncKHR_Lazy(IntPtr dpy, IntPtr sync, uint mode)
        {
            _eglSignalSyncKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int>)EGLLoader.BindingsContext.GetProcAddress("eglSignalSyncKHR");
            return _eglSignalSyncKHR_fnptr(dpy, sync, mode);
        }
        
        /// <summary><b>[entry point: <c>eglSignalSyncNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int> _eglSignalSyncNV_fnptr = &eglSignalSyncNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSignalSyncNV_Lazy(IntPtr sync, uint mode)
        {
            _eglSignalSyncNV_fnptr = (delegate* unmanaged<IntPtr, uint, int>)EGLLoader.BindingsContext.GetProcAddress("eglSignalSyncNV");
            return _eglSignalSyncNV_fnptr(sync, mode);
        }
        
        /// <summary><b>[entry point: <c>eglStreamAcquireImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, IntPtr, int> _eglStreamAcquireImageNV_fnptr = &eglStreamAcquireImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamAcquireImageNV_Lazy(IntPtr dpy, IntPtr stream, IntPtr* pImage, IntPtr sync)
        {
            _eglStreamAcquireImageNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamAcquireImageNV");
            return _eglStreamAcquireImageNV_fnptr(dpy, stream, pImage, sync);
        }
        
        /// <summary><b>[entry point: <c>eglStreamAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, uint, int, int> _eglStreamAttribKHR_fnptr = &eglStreamAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamAttribKHR_Lazy(IntPtr dpy, IntPtr stream, uint attribute, int value)
        {
            _eglStreamAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, uint, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamAttribKHR");
            return _eglStreamAttribKHR_fnptr(dpy, stream, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerAcquireAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglStreamConsumerAcquireAttribKHR_fnptr = &eglStreamConsumerAcquireAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerAcquireAttribKHR_Lazy(IntPtr dpy, IntPtr stream, IntPtr* attrib_list)
        {
            _eglStreamConsumerAcquireAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerAcquireAttribKHR");
            return _eglStreamConsumerAcquireAttribKHR_fnptr(dpy, stream, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerAcquireKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglStreamConsumerAcquireKHR_fnptr = &eglStreamConsumerAcquireKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerAcquireKHR_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglStreamConsumerAcquireKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerAcquireKHR");
            return _eglStreamConsumerAcquireKHR_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerGLTextureExternalAttribsNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglStreamConsumerGLTextureExternalAttribsNV_fnptr = &eglStreamConsumerGLTextureExternalAttribsNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerGLTextureExternalAttribsNV_Lazy(IntPtr dpy, IntPtr stream, IntPtr* attrib_list)
        {
            _eglStreamConsumerGLTextureExternalAttribsNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerGLTextureExternalAttribsNV");
            return _eglStreamConsumerGLTextureExternalAttribsNV_fnptr(dpy, stream, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerGLTextureExternalKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglStreamConsumerGLTextureExternalKHR_fnptr = &eglStreamConsumerGLTextureExternalKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerGLTextureExternalKHR_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglStreamConsumerGLTextureExternalKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerGLTextureExternalKHR");
            return _eglStreamConsumerGLTextureExternalKHR_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerOutputEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, int> _eglStreamConsumerOutputEXT_fnptr = &eglStreamConsumerOutputEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerOutputEXT_Lazy(IntPtr dpy, IntPtr stream, IntPtr layer)
        {
            _eglStreamConsumerOutputEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerOutputEXT");
            return _eglStreamConsumerOutputEXT_fnptr(dpy, stream, layer);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerReleaseAttribKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglStreamConsumerReleaseAttribKHR_fnptr = &eglStreamConsumerReleaseAttribKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerReleaseAttribKHR_Lazy(IntPtr dpy, IntPtr stream, IntPtr* attrib_list)
        {
            _eglStreamConsumerReleaseAttribKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerReleaseAttribKHR");
            return _eglStreamConsumerReleaseAttribKHR_fnptr(dpy, stream, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglStreamConsumerReleaseKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglStreamConsumerReleaseKHR_fnptr = &eglStreamConsumerReleaseKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamConsumerReleaseKHR_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglStreamConsumerReleaseKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamConsumerReleaseKHR");
            return _eglStreamConsumerReleaseKHR_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglStreamFlushNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglStreamFlushNV_fnptr = &eglStreamFlushNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamFlushNV_Lazy(IntPtr dpy, IntPtr stream)
        {
            _eglStreamFlushNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamFlushNV");
            return _eglStreamFlushNV_fnptr(dpy, stream);
        }
        
        /// <summary><b>[entry point: <c>eglStreamImageConsumerConnectNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, ulong*, IntPtr*, int> _eglStreamImageConsumerConnectNV_fnptr = &eglStreamImageConsumerConnectNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamImageConsumerConnectNV_Lazy(IntPtr dpy, IntPtr stream, int num_modifiers, ulong* modifiers, IntPtr* attrib_list)
        {
            _eglStreamImageConsumerConnectNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, ulong*, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamImageConsumerConnectNV");
            return _eglStreamImageConsumerConnectNV_fnptr(dpy, stream, num_modifiers, modifiers, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglStreamPostD3DTextureANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, void*, IntPtr*, int> _eglStreamPostD3DTextureANGLE_fnptr = &eglStreamPostD3DTextureANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamPostD3DTextureANGLE_Lazy(IntPtr dpy, IntPtr stream, void* texture, IntPtr* attrib_list)
        {
            _eglStreamPostD3DTextureANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, void*, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamPostD3DTextureANGLE");
            return _eglStreamPostD3DTextureANGLE_fnptr(dpy, stream, texture, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglStreamReleaseImageNV</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr, int> _eglStreamReleaseImageNV_fnptr = &eglStreamReleaseImageNV_Lazy;
        [UnmanagedCallersOnly]
        private static int eglStreamReleaseImageNV_Lazy(IntPtr dpy, IntPtr stream, IntPtr image, IntPtr sync)
        {
            _eglStreamReleaseImageNV_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglStreamReleaseImageNV");
            return _eglStreamReleaseImageNV_fnptr(dpy, stream, image, sync);
        }
        
        /// <summary><b>[entry point: <c>eglSurfaceAttrib</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int, int> _eglSurfaceAttrib_fnptr = &eglSurfaceAttrib_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSurfaceAttrib_Lazy(IntPtr dpy, IntPtr surface, int attribute, int value)
        {
            _eglSurfaceAttrib_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglSurfaceAttrib");
            return _eglSurfaceAttrib_fnptr(dpy, surface, attribute, value);
        }
        
        /// <summary><b>[entry point: <c>eglSwapBuffers</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglSwapBuffers_fnptr = &eglSwapBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapBuffers_Lazy(IntPtr dpy, IntPtr surface)
        {
            _eglSwapBuffers_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapBuffers");
            return _eglSwapBuffers_fnptr(dpy, surface);
        }
        
        /// <summary><b>[entry point: <c>eglSwapBuffersRegion2NOK</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _eglSwapBuffersRegion2NOK_fnptr = &eglSwapBuffersRegion2NOK_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapBuffersRegion2NOK_Lazy(IntPtr dpy, IntPtr surface, int numRects, int* rects)
        {
            _eglSwapBuffersRegion2NOK_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapBuffersRegion2NOK");
            return _eglSwapBuffersRegion2NOK_fnptr(dpy, surface, numRects, rects);
        }
        
        /// <summary><b>[entry point: <c>eglSwapBuffersRegionNOK</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int*, int> _eglSwapBuffersRegionNOK_fnptr = &eglSwapBuffersRegionNOK_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapBuffersRegionNOK_Lazy(IntPtr dpy, IntPtr surface, int numRects, int* rects)
        {
            _eglSwapBuffersRegionNOK_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int*, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapBuffersRegionNOK");
            return _eglSwapBuffersRegionNOK_fnptr(dpy, surface, numRects, rects);
        }
        
        /// <summary><b>[entry point: <c>eglSwapBuffersWithDamageEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int, int> _eglSwapBuffersWithDamageEXT_fnptr = &eglSwapBuffersWithDamageEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapBuffersWithDamageEXT_Lazy(IntPtr dpy, IntPtr surface, int* rects, int n_rects)
        {
            _eglSwapBuffersWithDamageEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapBuffersWithDamageEXT");
            return _eglSwapBuffersWithDamageEXT_fnptr(dpy, surface, rects, n_rects);
        }
        
        /// <summary><b>[entry point: <c>eglSwapBuffersWithDamageKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int*, int, int> _eglSwapBuffersWithDamageKHR_fnptr = &eglSwapBuffersWithDamageKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapBuffersWithDamageKHR_Lazy(IntPtr dpy, IntPtr surface, int* rects, int n_rects)
        {
            _eglSwapBuffersWithDamageKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapBuffersWithDamageKHR");
            return _eglSwapBuffersWithDamageKHR_fnptr(dpy, surface, rects, n_rects);
        }
        
        /// <summary><b>[entry point: <c>eglSwapBuffersWithFrameTokenANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, ulong, int> _eglSwapBuffersWithFrameTokenANGLE_fnptr = &eglSwapBuffersWithFrameTokenANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapBuffersWithFrameTokenANGLE_Lazy(IntPtr dpy, IntPtr surface, ulong frametoken)
        {
            _eglSwapBuffersWithFrameTokenANGLE_fnptr = (delegate* unmanaged<IntPtr, IntPtr, ulong, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapBuffersWithFrameTokenANGLE");
            return _eglSwapBuffersWithFrameTokenANGLE_fnptr(dpy, surface, frametoken);
        }
        
        /// <summary><b>[entry point: <c>eglSwapInterval</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _eglSwapInterval_fnptr = &eglSwapInterval_Lazy;
        [UnmanagedCallersOnly]
        private static int eglSwapInterval_Lazy(IntPtr dpy, int interval)
        {
            _eglSwapInterval_fnptr = (delegate* unmanaged<IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglSwapInterval");
            return _eglSwapInterval_fnptr(dpy, interval);
        }
        
        /// <summary><b>[entry point: <c>eglTerminate</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _eglTerminate_fnptr = &eglTerminate_Lazy;
        [UnmanagedCallersOnly]
        private static int eglTerminate_Lazy(IntPtr dpy)
        {
            _eglTerminate_fnptr = (delegate* unmanaged<IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglTerminate");
            return _eglTerminate_fnptr(dpy);
        }
        
        /// <summary><b>[entry point: <c>eglUnbindWaylandDisplayWL</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr*, int> _eglUnbindWaylandDisplayWL_fnptr = &eglUnbindWaylandDisplayWL_Lazy;
        [UnmanagedCallersOnly]
        private static int eglUnbindWaylandDisplayWL_Lazy(IntPtr dpy, IntPtr* display)
        {
            _eglUnbindWaylandDisplayWL_fnptr = (delegate* unmanaged<IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglUnbindWaylandDisplayWL");
            return _eglUnbindWaylandDisplayWL_fnptr(dpy, display);
        }
        
        /// <summary><b>[entry point: <c>eglUnlockSurfaceKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int> _eglUnlockSurfaceKHR_fnptr = &eglUnlockSurfaceKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglUnlockSurfaceKHR_Lazy(IntPtr dpy, IntPtr surface)
        {
            _eglUnlockSurfaceKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int>)EGLLoader.BindingsContext.GetProcAddress("eglUnlockSurfaceKHR");
            return _eglUnlockSurfaceKHR_fnptr(dpy, surface);
        }
        
        /// <summary><b>[entry point: <c>eglUnsignalSyncEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int> _eglUnsignalSyncEXT_fnptr = &eglUnsignalSyncEXT_Lazy;
        [UnmanagedCallersOnly]
        private static int eglUnsignalSyncEXT_Lazy(IntPtr dpy, IntPtr sync, IntPtr* attrib_list)
        {
            _eglUnsignalSyncEXT_fnptr = (delegate* unmanaged<IntPtr, IntPtr, IntPtr*, int>)EGLLoader.BindingsContext.GetProcAddress("eglUnsignalSyncEXT");
            return _eglUnsignalSyncEXT_fnptr(dpy, sync, attrib_list);
        }
        
        /// <summary><b>[entry point: <c>eglWaitClient</c>]</b></summary>
        public static delegate* unmanaged<int> _eglWaitClient_fnptr = &eglWaitClient_Lazy;
        [UnmanagedCallersOnly]
        private static int eglWaitClient_Lazy()
        {
            _eglWaitClient_fnptr = (delegate* unmanaged<int>)EGLLoader.BindingsContext.GetProcAddress("eglWaitClient");
            return _eglWaitClient_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglWaitGL</c>]</b></summary>
        public static delegate* unmanaged<int> _eglWaitGL_fnptr = &eglWaitGL_Lazy;
        [UnmanagedCallersOnly]
        private static int eglWaitGL_Lazy()
        {
            _eglWaitGL_fnptr = (delegate* unmanaged<int>)EGLLoader.BindingsContext.GetProcAddress("eglWaitGL");
            return _eglWaitGL_fnptr();
        }
        
        /// <summary><b>[entry point: <c>eglWaitNative</c>]</b></summary>
        public static delegate* unmanaged<int, int> _eglWaitNative_fnptr = &eglWaitNative_Lazy;
        [UnmanagedCallersOnly]
        private static int eglWaitNative_Lazy(int engine)
        {
            _eglWaitNative_fnptr = (delegate* unmanaged<int, int>)EGLLoader.BindingsContext.GetProcAddress("eglWaitNative");
            return _eglWaitNative_fnptr(engine);
        }
        
        /// <summary><b>[entry point: <c>eglWaitSync</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _eglWaitSync_fnptr = &eglWaitSync_Lazy;
        [UnmanagedCallersOnly]
        private static int eglWaitSync_Lazy(IntPtr dpy, IntPtr sync, int flags)
        {
            _eglWaitSync_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglWaitSync");
            return _eglWaitSync_fnptr(dpy, sync, flags);
        }
        
        /// <summary><b>[entry point: <c>eglWaitSyncKHR</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr, int, int> _eglWaitSyncKHR_fnptr = &eglWaitSyncKHR_Lazy;
        [UnmanagedCallersOnly]
        private static int eglWaitSyncKHR_Lazy(IntPtr dpy, IntPtr sync, int flags)
        {
            _eglWaitSyncKHR_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int, int>)EGLLoader.BindingsContext.GetProcAddress("eglWaitSyncKHR");
            return _eglWaitSyncKHR_fnptr(dpy, sync, flags);
        }
        
        /// <summary><b>[entry point: <c>eglWaitUntilWorkScheduledANGLE</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _eglWaitUntilWorkScheduledANGLE_fnptr = &eglWaitUntilWorkScheduledANGLE_Lazy;
        [UnmanagedCallersOnly]
        private static void eglWaitUntilWorkScheduledANGLE_Lazy(IntPtr dpy)
        {
            _eglWaitUntilWorkScheduledANGLE_fnptr = (delegate* unmanaged<IntPtr, void>)EGLLoader.BindingsContext.GetProcAddress("eglWaitUntilWorkScheduledANGLE");
            _eglWaitUntilWorkScheduledANGLE_fnptr(dpy);
        }
        
    }
}
