// This file is auto generated, do not edit. Generated: 2025-08-17 15:26:47 GMT+02:00
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Wgl;
using OpenTK.Graphics.Glx;

namespace OpenTK.Graphics.Egl
{
    public static unsafe partial class Egl
    {
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>eglBindAPI</c>]</b><br/>  </summary>
        public static int BindAPI_(RenderApi api) => EglPointers.eglBindAPI_Lazy((uint)api);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>eglBindTexImage</c>]</b><br/>  </summary>
        public static int BindTexImage_(EGLDisplay dpy, EGLSurface surface, int buffer) => EglPointers.eglBindTexImage_Lazy((IntPtr)dpy, (IntPtr)surface, buffer);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglChooseConfig</c>]</b><br/>  </summary>
        public static int ChooseConfig(EGLDisplay dpy, int* attrib_list, EGLConfig* configs, int config_size, int* num_config) => EglPointers.eglChooseConfig_Lazy((IntPtr)dpy, attrib_list, (IntPtr*)configs, config_size, num_config);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglClientWaitSync</c>]</b><br/>  </summary>
        public static WaitSyncStatus ClientWaitSync(EGLDisplay dpy, EGLSync sync, ClientWaitSyncFlags flags, ulong timeout) => (WaitSyncStatus) EglPointers.eglClientWaitSync_Lazy((IntPtr)dpy, (IntPtr)sync, (int)flags, timeout);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglCopyBuffers</c>]</b><br/>  </summary>
        public static int CopyBuffers_(EGLDisplay dpy, EGLSurface surface, IntPtr target) => EglPointers.eglCopyBuffers_Lazy((IntPtr)dpy, (IntPtr)surface, target);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglCreateContext</c>]</b><br/>  </summary>
        public static EGLContext CreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, int* attrib_list) => (EGLContext) EglPointers.eglCreateContext_Lazy((IntPtr)dpy, (IntPtr)config, (IntPtr)share_context, attrib_list);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglCreateImage</c>]</b><br/>  </summary>
        public static EGLImage CreateImage(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, IntPtr* attrib_list) => (EGLImage) EglPointers.eglCreateImage_Lazy((IntPtr)dpy, (IntPtr)ctx, (uint)target, (IntPtr)buffer, attrib_list);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>eglCreatePbufferFromClientBuffer</c>]</b><br/>  </summary>
        public static EGLSurface CreatePbufferFromClientBuffer(EGLDisplay dpy, ClientBufferType buftype, EGLClientBuffer buffer, EGLConfig config, int* attrib_list) => (EGLSurface) EglPointers.eglCreatePbufferFromClientBuffer_Lazy((IntPtr)dpy, (uint)buftype, (IntPtr)buffer, (IntPtr)config, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglCreatePbufferSurface</c>]</b><br/>  </summary>
        public static EGLSurface CreatePbufferSurface(EGLDisplay dpy, EGLConfig config, int* attrib_list) => (EGLSurface) EglPointers.eglCreatePbufferSurface_Lazy((IntPtr)dpy, (IntPtr)config, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglCreatePixmapSurface</c>]</b><br/>  </summary>
        public static EGLSurface CreatePixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr pixmap, int* attrib_list) => (EGLSurface) EglPointers.eglCreatePixmapSurface_Lazy((IntPtr)dpy, (IntPtr)config, pixmap, attrib_list);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglCreatePlatformPixmapSurface</c>]</b><br/>  </summary>
        public static EGLSurface CreatePlatformPixmapSurface(EGLDisplay dpy, EGLConfig config, void* native_pixmap, IntPtr* attrib_list) => (EGLSurface) EglPointers.eglCreatePlatformPixmapSurface_Lazy((IntPtr)dpy, (IntPtr)config, native_pixmap, attrib_list);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglCreatePlatformWindowSurface</c>]</b><br/>  </summary>
        public static EGLSurface CreatePlatformWindowSurface(EGLDisplay dpy, EGLConfig config, void* native_window, IntPtr* attrib_list) => (EGLSurface) EglPointers.eglCreatePlatformWindowSurface_Lazy((IntPtr)dpy, (IntPtr)config, native_window, attrib_list);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglCreateSync</c>]</b><br/>  </summary>
        public static EGLSync CreateSync(EGLDisplay dpy, SyncType type, IntPtr* attrib_list) => (EGLSync) EglPointers.eglCreateSync_Lazy((IntPtr)dpy, (uint)type, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglCreateWindowSurface</c>]</b><br/>  </summary>
        public static EGLSurface CreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, int* attrib_list) => (EGLSurface) EglPointers.eglCreateWindowSurface_Lazy((IntPtr)dpy, (IntPtr)config, win, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglDestroyContext</c>]</b><br/>  </summary>
        public static int DestroyContext_(EGLDisplay dpy, EGLContext ctx) => EglPointers.eglDestroyContext_Lazy((IntPtr)dpy, (IntPtr)ctx);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglDestroyImage</c>]</b><br/>  </summary>
        public static int DestroyImage_(EGLDisplay dpy, EGLImage image) => EglPointers.eglDestroyImage_Lazy((IntPtr)dpy, (IntPtr)image);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglDestroySurface</c>]</b><br/>  </summary>
        public static int DestroySurface_(EGLDisplay dpy, EGLSurface surface) => EglPointers.eglDestroySurface_Lazy((IntPtr)dpy, (IntPtr)surface);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglDestroySync</c>]</b><br/>  </summary>
        public static int DestroySync_(EGLDisplay dpy, EGLSync sync) => EglPointers.eglDestroySync_Lazy((IntPtr)dpy, (IntPtr)sync);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetConfigAttrib</c>]</b><br/>  </summary>
        public static int GetConfigAttrib(EGLDisplay dpy, EGLConfig config, ConfigAttribute attribute, int* value) => EglPointers.eglGetConfigAttrib_Lazy((IntPtr)dpy, (IntPtr)config, (int)attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetConfigs</c>]</b><br/>  </summary>
        public static int GetConfigs(EGLDisplay dpy, EGLConfig* configs, int config_size, int* num_config) => EglPointers.eglGetConfigs_Lazy((IntPtr)dpy, (IntPtr*)configs, config_size, num_config);
        
        /// <summary> <b>[requires: v1.4]</b> <b>[entry point: <c>eglGetCurrentContext</c>]</b><br/>  </summary>
        public static EGLContext GetCurrentContext() => (EGLContext) EglPointers.eglGetCurrentContext_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetCurrentDisplay</c>]</b><br/>  </summary>
        public static EGLDisplay GetCurrentDisplay() => (EGLDisplay) EglPointers.eglGetCurrentDisplay_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetCurrentSurface</c>]</b><br/>  </summary>
        public static EGLSurface GetCurrentSurface(ReadDrawFlags readdraw) => (EGLSurface) EglPointers.eglGetCurrentSurface_Lazy((int)readdraw);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetDisplay</c>]</b><br/>  </summary>
        public static EGLDisplay GetDisplay(IntPtr display_id) => (EGLDisplay) EglPointers.eglGetDisplay_Lazy(display_id);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetError</c>]</b><br/>  </summary>
        public static ErrorCode GetError() => (ErrorCode) EglPointers.eglGetError_Lazy();
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglGetPlatformDisplay</c>]</b><br/>  </summary>
        public static EGLDisplay GetPlatformDisplay(Platform platform, void* native_display, IntPtr* attrib_list) => (EGLDisplay) EglPointers.eglGetPlatformDisplay_Lazy((uint)platform, native_display, attrib_list);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglGetProcAddress</c>]</b><br/>  </summary>
        public static IntPtr GetProcAddress(byte* procname) => EglPointers.eglGetProcAddress_Lazy(procname);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglGetSyncAttrib</c>]</b><br/>  </summary>
        public static int GetSyncAttrib(EGLDisplay dpy, EGLSync sync, int attribute, IntPtr* value) => EglPointers.eglGetSyncAttrib_Lazy((IntPtr)dpy, (IntPtr)sync, attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglInitialize</c>]</b><br/>  </summary>
        public static int Initialize(EGLDisplay dpy, int* major, int* minor) => EglPointers.eglInitialize_Lazy((IntPtr)dpy, major, minor);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglMakeCurrent</c>]</b><br/>  </summary>
        public static int MakeCurrent_(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx) => EglPointers.eglMakeCurrent_Lazy((IntPtr)dpy, (IntPtr)draw, (IntPtr)read, (IntPtr)ctx);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>eglQueryAPI</c>]</b><br/>  </summary>
        public static RenderApi QueryAPI() => (RenderApi) EglPointers.eglQueryAPI_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglQueryContext</c>]</b><br/>  </summary>
        public static int QueryContext(EGLDisplay dpy, EGLContext ctx, ContextQueryAttribute attribute, int* value) => EglPointers.eglQueryContext_Lazy((IntPtr)dpy, (IntPtr)ctx, (int)attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglQueryString</c>]</b><br/>  </summary>
        public static byte* QueryString_(EGLDisplay dpy, StringName name) => EglPointers.eglQueryString_Lazy((IntPtr)dpy, (int)name);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglQuerySurface</c>]</b><br/>  </summary>
        public static int QuerySurface(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, int* value) => EglPointers.eglQuerySurface_Lazy((IntPtr)dpy, (IntPtr)surface, (int)attribute, value);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>eglReleaseTexImage</c>]</b><br/>  </summary>
        public static int ReleaseTexImage_(EGLDisplay dpy, EGLSurface surface, int buffer) => EglPointers.eglReleaseTexImage_Lazy((IntPtr)dpy, (IntPtr)surface, buffer);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>eglReleaseThread</c>]</b><br/>  </summary>
        public static int ReleaseThread_() => EglPointers.eglReleaseThread_Lazy();
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>eglSurfaceAttrib</c>]</b><br/>  </summary>
        public static int SurfaceAttrib_(EGLDisplay dpy, EGLSurface surface, SurfaceAttribute attribute, int value) => EglPointers.eglSurfaceAttrib_Lazy((IntPtr)dpy, (IntPtr)surface, (int)attribute, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglSwapBuffers</c>]</b><br/>  </summary>
        public static int SwapBuffers_(EGLDisplay dpy, EGLSurface surface) => EglPointers.eglSwapBuffers_Lazy((IntPtr)dpy, (IntPtr)surface);
        
        /// <summary> <b>[requires: v1.1]</b> <b>[entry point: <c>eglSwapInterval</c>]</b><br/>  </summary>
        public static int SwapInterval_(EGLDisplay dpy, int interval) => EglPointers.eglSwapInterval_Lazy((IntPtr)dpy, interval);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglTerminate</c>]</b><br/>  </summary>
        public static int Terminate_(EGLDisplay dpy) => EglPointers.eglTerminate_Lazy((IntPtr)dpy);
        
        /// <summary> <b>[requires: v1.2]</b> <b>[entry point: <c>eglWaitClient</c>]</b><br/>  </summary>
        public static int WaitClient_() => EglPointers.eglWaitClient_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglWaitGL</c>]</b><br/>  </summary>
        public static int WaitGL_() => EglPointers.eglWaitGL_Lazy();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>eglWaitNative</c>]</b><br/>  </summary>
        public static int WaitNative_(NativeEngine engine) => EglPointers.eglWaitNative_Lazy((int)engine);
        
        /// <summary> <b>[requires: v1.5]</b> <b>[entry point: <c>eglWaitSync</c>]</b><br/>  </summary>
        public static int WaitSync_(EGLDisplay dpy, EGLSync sync, int flags) => EglPointers.eglWaitSync_Lazy((IntPtr)dpy, (IntPtr)sync, flags);
        
        /// <summary>ANDROID extensions.</summary>
        public static unsafe partial class ANDROID
        {
            /// <summary> <b>[requires: EGL_ANDROID_create_native_client_buffer]</b> <b>[entry point: <c>eglCreateNativeClientBufferANDROID</c>]</b><br/>  </summary>
            public static EGLClientBuffer CreateNativeClientBufferANDROID(int* attrib_list) => (EGLClientBuffer) EglPointers.eglCreateNativeClientBufferANDROID_Lazy(attrib_list);
            
            /// <summary> <b>[requires: EGL_ANDROID_native_fence_sync]</b> <b>[entry point: <c>eglDupNativeFenceFDANDROID</c>]</b><br/>  </summary>
            public static int DupNativeFenceFDANDROID(EGLDisplay dpy, EGLSyncKHR sync) => EglPointers.eglDupNativeFenceFDANDROID_Lazy((IntPtr)dpy, (IntPtr)sync);
            
            /// <summary> <b>[requires: EGL_ANDROID_get_frame_timestamps]</b> <b>[entry point: <c>eglGetCompositorTimingANDROID</c>]</b><br/>  </summary>
            public static int GetCompositorTimingANDROID(EGLDisplay dpy, EGLSurface surface, int numTimestamps, int* names, long* values) => EglPointers.eglGetCompositorTimingANDROID_Lazy((IntPtr)dpy, (IntPtr)surface, numTimestamps, names, values);
            
            /// <summary> <b>[requires: EGL_ANDROID_get_frame_timestamps]</b> <b>[entry point: <c>eglGetCompositorTimingSupportedANDROID</c>]</b><br/>  </summary>
            public static int GetCompositorTimingSupportedANDROID_(EGLDisplay dpy, EGLSurface surface, int name) => EglPointers.eglGetCompositorTimingSupportedANDROID_Lazy((IntPtr)dpy, (IntPtr)surface, name);
            
            /// <summary> <b>[requires: EGL_ANDROID_get_frame_timestamps]</b> <b>[entry point: <c>eglGetFrameTimestampsANDROID</c>]</b><br/>  </summary>
            public static int GetFrameTimestampsANDROID(EGLDisplay dpy, EGLSurface surface, ulong frameId, int numTimestamps, int* timestamps, long* values) => EglPointers.eglGetFrameTimestampsANDROID_Lazy((IntPtr)dpy, (IntPtr)surface, frameId, numTimestamps, timestamps, values);
            
            /// <summary> <b>[requires: EGL_ANDROID_get_frame_timestamps]</b> <b>[entry point: <c>eglGetFrameTimestampSupportedANDROID</c>]</b><br/>  </summary>
            public static int GetFrameTimestampSupportedANDROID_(EGLDisplay dpy, EGLSurface surface, int timestamp) => EglPointers.eglGetFrameTimestampSupportedANDROID_Lazy((IntPtr)dpy, (IntPtr)surface, timestamp);
            
            /// <summary> <b>[requires: EGL_ANDROID_get_native_client_buffer]</b> <b>[entry point: <c>eglGetNativeClientBufferANDROID</c>]</b><br/>  </summary>
            public static EGLClientBuffer GetNativeClientBufferANDROID(AHardwareBuffer buffer) => (EGLClientBuffer) EglPointers.eglGetNativeClientBufferANDROID_Lazy((IntPtr)buffer);
            
            /// <summary> <b>[requires: EGL_ANDROID_get_frame_timestamps]</b> <b>[entry point: <c>eglGetNextFrameIdANDROID</c>]</b><br/>  </summary>
            public static int GetNextFrameIdANDROID(EGLDisplay dpy, EGLSurface surface, ulong* frameId) => EglPointers.eglGetNextFrameIdANDROID_Lazy((IntPtr)dpy, (IntPtr)surface, frameId);
            
            /// <summary> <b>[requires: EGL_ANDROID_presentation_time]</b> <b>[entry point: <c>eglPresentationTimeANDROID</c>]</b><br/>  </summary>
            public static int PresentationTimeANDROID_(EGLDisplay dpy, EGLSurface surface, long time) => EglPointers.eglPresentationTimeANDROID_Lazy((IntPtr)dpy, (IntPtr)surface, time);
            
            /// <summary> <b>[requires: EGL_ANDROID_blob_cache]</b> <b>[entry point: <c>eglSetBlobCacheFuncsANDROID</c>]</b><br/>  </summary>
            public static void SetBlobCacheFuncsANDROID(EGLDisplay dpy, IntPtr set, IntPtr get) => EglPointers.eglSetBlobCacheFuncsANDROID_Lazy((IntPtr)dpy, set, get);
            
        }
        /// <summary>ANGLE extensions.</summary>
        public static unsafe partial class ANGLE
        {
            /// <summary> <b>[requires: EGL_ANGLE_external_context_and_surface]</b> <b>[entry point: <c>eglAcquireExternalContextANGLE</c>]</b><br/>  </summary>
            public static void AcquireExternalContextANGLE(EGLDisplay dpy, EGLSurface drawAndRead) => EglPointers.eglAcquireExternalContextANGLE_Lazy((IntPtr)dpy, (IntPtr)drawAndRead);
            
            /// <summary> <b>[requires: EGL_ANGLE_metal_shared_event_sync]</b> <b>[entry point: <c>eglCopyMetalSharedEventANGLE</c>]</b><br/>  </summary>
            public static void* CopyMetalSharedEventANGLE(EGLDisplay dpy, EGLSyncKHR sync) => EglPointers.eglCopyMetalSharedEventANGLE_Lazy((IntPtr)dpy, (IntPtr)sync);
            
            /// <summary> <b>[requires: EGL_ANGLE_device_creation]</b> <b>[entry point: <c>eglCreateDeviceANGLE</c>]</b><br/>  </summary>
            public static EGLDeviceEXT CreateDeviceANGLE(int device_type, void* native_device, IntPtr* attrib_list) => (EGLDeviceEXT) EglPointers.eglCreateDeviceANGLE_Lazy(device_type, native_device, attrib_list);
            
            /// <summary> <b>[requires: EGL_ANGLE_stream_producer_d3d_texture]</b> <b>[entry point: <c>eglCreateStreamProducerD3DTextureANGLE</c>]</b><br/>  </summary>
            public static int CreateStreamProducerD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, IntPtr* attrib_list) => EglPointers.eglCreateStreamProducerD3DTextureANGLE_Lazy((IntPtr)dpy, (IntPtr)stream, attrib_list);
            
            /// <summary> <b>[requires: EGL_ANGLE_vulkan_image]</b> <b>[entry point: <c>eglExportVkImageANGLE</c>]</b><br/>  </summary>
            public static int ExportVkImageANGLE(EGLDisplay dpy, EGLImage image, void* vk_image, void* vk_image_create_info) => EglPointers.eglExportVkImageANGLE_Lazy((IntPtr)dpy, (IntPtr)image, vk_image, vk_image_create_info);
            
            /// <summary> <b>[requires: EGL_ANGLE_power_preference]</b> <b>[entry point: <c>eglForceGPUSwitchANGLE</c>]</b><br/>  </summary>
            public static void ForceGPUSwitchANGLE(EGLDisplay dpy, int gpuIDHigh, int gpuIDLow) => EglPointers.eglForceGPUSwitchANGLE_Lazy((IntPtr)dpy, gpuIDHigh, gpuIDLow);
            
            /// <summary> <b>[requires: EGL_ANGLE_sync_control_rate]</b> <b>[entry point: <c>eglGetMscRateANGLE</c>]</b><br/>  </summary>
            public static int GetMscRateANGLE(EGLDisplay dpy, EGLSurface surface, int* numerator, int* denominator) => EglPointers.eglGetMscRateANGLE_Lazy((IntPtr)dpy, (IntPtr)surface, numerator, denominator);
            
            /// <summary> <b>[requires: EGL_ANGLE_power_preference]</b> <b>[entry point: <c>eglHandleGPUSwitchANGLE</c>]</b><br/>  </summary>
            public static void HandleGPUSwitchANGLE(EGLDisplay dpy) => EglPointers.eglHandleGPUSwitchANGLE_Lazy((IntPtr)dpy);
            
            /// <summary> <b>[requires: EGL_ANGLE_prepare_swap_buffers]</b> <b>[entry point: <c>eglPrepareSwapBuffersANGLE</c>]</b><br/>  </summary>
            public static int PrepareSwapBuffersANGLE_(EGLDisplay dpy, EGLSurface surface) => EglPointers.eglPrepareSwapBuffersANGLE_Lazy((IntPtr)dpy, (IntPtr)surface);
            
            /// <summary> <b>[requires: EGL_ANGLE_program_cache_control]</b> <b>[entry point: <c>eglProgramCacheGetAttribANGLE</c>]</b><br/>  </summary>
            public static int ProgramCacheGetAttribANGLE(EGLDisplay dpy, All attrib) => EglPointers.eglProgramCacheGetAttribANGLE_Lazy((IntPtr)dpy, (uint)attrib);
            
            /// <summary> <b>[requires: EGL_ANGLE_program_cache_control]</b> <b>[entry point: <c>eglProgramCachePopulateANGLE</c>]</b><br/>  </summary>
            public static void ProgramCachePopulateANGLE(EGLDisplay dpy, void* key, int keysize, void* binary, int binarysize) => EglPointers.eglProgramCachePopulateANGLE_Lazy((IntPtr)dpy, key, keysize, binary, binarysize);
            
            /// <summary> <b>[requires: EGL_ANGLE_program_cache_control]</b> <b>[entry point: <c>eglProgramCacheQueryANGLE</c>]</b><br/>  </summary>
            public static void ProgramCacheQueryANGLE(EGLDisplay dpy, int index, void* key, int* keysize, void* binary, int* binarysize) => EglPointers.eglProgramCacheQueryANGLE_Lazy((IntPtr)dpy, index, key, keysize, binary, binarysize);
            
            /// <summary> <b>[requires: EGL_ANGLE_program_cache_control]</b> <b>[entry point: <c>eglProgramCacheResizeANGLE</c>]</b><br/>  </summary>
            public static int ProgramCacheResizeANGLE(EGLDisplay dpy, int limit, int mode) => EglPointers.eglProgramCacheResizeANGLE_Lazy((IntPtr)dpy, limit, mode);
            
            /// <summary> <b>[requires: EGL_ANGLE_feature_control]</b> <b>[entry point: <c>eglQueryDisplayAttribANGLE</c>]</b><br/>  </summary>
            public static int QueryDisplayAttribANGLE(EGLDisplay dpy, int attribute, IntPtr* value) => EglPointers.eglQueryDisplayAttribANGLE_Lazy((IntPtr)dpy, attribute, value);
            
            /// <summary> <b>[requires: EGL_ANGLE_feature_control]</b> <b>[entry point: <c>eglQueryStringiANGLE</c>]</b><br/>  </summary>
            public static byte* QueryStringiANGLE_(EGLDisplay dpy, int name, int index) => EglPointers.eglQueryStringiANGLE_Lazy((IntPtr)dpy, name, index);
            
            /// <summary> <b>[requires: EGL_ANGLE_query_surface_pointer]</b> <b>[entry point: <c>eglQuerySurfacePointerANGLE</c>]</b><br/>  </summary>
            public static int QuerySurfacePointerANGLE_(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, void** value) => EglPointers.eglQuerySurfacePointerANGLE_Lazy((IntPtr)dpy, (IntPtr)surface, (int)attribute, value);
            
            /// <summary> <b>[requires: EGL_ANGLE_power_preference]</b> <b>[entry point: <c>eglReacquireHighPowerGPUANGLE</c>]</b><br/>  </summary>
            public static void ReacquireHighPowerGPUANGLE(EGLDisplay dpy, EGLContext ctx) => EglPointers.eglReacquireHighPowerGPUANGLE_Lazy((IntPtr)dpy, (IntPtr)ctx);
            
            /// <summary> <b>[requires: EGL_ANGLE_device_creation]</b> <b>[entry point: <c>eglReleaseDeviceANGLE</c>]</b><br/>  </summary>
            public static int ReleaseDeviceANGLE_(EGLDeviceEXT device) => EglPointers.eglReleaseDeviceANGLE_Lazy((IntPtr)device);
            
            /// <summary> <b>[requires: EGL_ANGLE_external_context_and_surface]</b> <b>[entry point: <c>eglReleaseExternalContextANGLE</c>]</b><br/>  </summary>
            public static void ReleaseExternalContextANGLE(EGLDisplay dpy) => EglPointers.eglReleaseExternalContextANGLE_Lazy((IntPtr)dpy);
            
            /// <summary> <b>[requires: EGL_ANGLE_power_preference]</b> <b>[entry point: <c>eglReleaseHighPowerGPUANGLE</c>]</b><br/>  </summary>
            public static void ReleaseHighPowerGPUANGLE(EGLDisplay dpy, EGLContext ctx) => EglPointers.eglReleaseHighPowerGPUANGLE_Lazy((IntPtr)dpy, (IntPtr)ctx);
            
            /// <summary> <b>[requires: EGL_ANGLE_no_error]</b> <b>[entry point: <c>eglSetValidationEnabledANGLE</c>]</b><br/>  </summary>
            public static void SetValidationEnabledANGLE(int validationState) => EglPointers.eglSetValidationEnabledANGLE_Lazy(validationState);
            
            /// <summary> <b>[requires: EGL_ANGLE_stream_producer_d3d_texture]</b> <b>[entry point: <c>eglStreamPostD3DTextureANGLE</c>]</b><br/>  </summary>
            public static int StreamPostD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, void* texture, IntPtr* attrib_list) => EglPointers.eglStreamPostD3DTextureANGLE_Lazy((IntPtr)dpy, (IntPtr)stream, texture, attrib_list);
            
            /// <summary> <b>[requires: EGL_ANGLE_swap_with_frame_token]</b> <b>[entry point: <c>eglSwapBuffersWithFrameTokenANGLE</c>]</b><br/>  </summary>
            public static int SwapBuffersWithFrameTokenANGLE_(EGLDisplay dpy, EGLSurface surface, ulong frametoken) => EglPointers.eglSwapBuffersWithFrameTokenANGLE_Lazy((IntPtr)dpy, (IntPtr)surface, frametoken);
            
            /// <summary> <b>[requires: EGL_ANGLE_wait_until_work_scheduled]</b> <b>[entry point: <c>eglWaitUntilWorkScheduledANGLE</c>]</b><br/>  </summary>
            public static void WaitUntilWorkScheduledANGLE(EGLDisplay dpy) => EglPointers.eglWaitUntilWorkScheduledANGLE_Lazy((IntPtr)dpy);
            
        }
        /// <summary>CHROMIUM extensions.</summary>
        public static unsafe partial class CHROMIUM
        {
            /// <summary> <b>[requires: EGL_CHROMIUM_sync_control]</b> <b>[entry point: <c>eglGetSyncValuesCHROMIUM</c>]</b><br/>  </summary>
            public static int GetSyncValuesCHROMIUM(EGLDisplay dpy, EGLSurface surface, ulong* ust, ulong* msc, ulong* sbc) => EglPointers.eglGetSyncValuesCHROMIUM_Lazy((IntPtr)dpy, (IntPtr)surface, ust, msc, sbc);
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: EGL_EXT_client_sync]</b> <b>[entry point: <c>eglClientSignalSyncEXT</c>]</b><br/>  </summary>
            public static int ClientSignalSyncEXT(EGLDisplay dpy, EGLSync sync, IntPtr* attrib_list) => EglPointers.eglClientSignalSyncEXT_Lazy((IntPtr)dpy, (IntPtr)sync, attrib_list);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorBindTexWindowEXT</c>]</b><br/>  </summary>
            public static int CompositorBindTexWindowEXT_(int external_win_id) => EglPointers.eglCompositorBindTexWindowEXT_Lazy(external_win_id);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorSetContextAttributesEXT</c>]</b><br/>  </summary>
            public static int CompositorSetContextAttributesEXT(int external_ref_id, int* context_attributes, int num_entries) => EglPointers.eglCompositorSetContextAttributesEXT_Lazy(external_ref_id, context_attributes, num_entries);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorSetContextListEXT</c>]</b><br/>  </summary>
            public static int CompositorSetContextListEXT(int* external_ref_ids, int num_entries) => EglPointers.eglCompositorSetContextListEXT_Lazy(external_ref_ids, num_entries);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorSetSizeEXT</c>]</b><br/>  </summary>
            public static int CompositorSetSizeEXT_(int external_win_id, int width, int height) => EglPointers.eglCompositorSetSizeEXT_Lazy(external_win_id, width, height);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorSetWindowAttributesEXT</c>]</b><br/>  </summary>
            public static int CompositorSetWindowAttributesEXT(int external_win_id, int* window_attributes, int num_entries) => EglPointers.eglCompositorSetWindowAttributesEXT_Lazy(external_win_id, window_attributes, num_entries);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorSetWindowListEXT</c>]</b><br/>  </summary>
            public static int CompositorSetWindowListEXT(int external_ref_id, int* external_win_ids, int num_entries) => EglPointers.eglCompositorSetWindowListEXT_Lazy(external_ref_id, external_win_ids, num_entries);
            
            /// <summary> <b>[requires: EGL_EXT_compositor]</b> <b>[entry point: <c>eglCompositorSwapPolicyEXT</c>]</b><br/>  </summary>
            public static int CompositorSwapPolicyEXT_(int external_win_id, int policy) => EglPointers.eglCompositorSwapPolicyEXT_Lazy(external_win_id, policy);
            
            /// <summary> <b>[requires: EGL_EXT_platform_base]</b> <b>[entry point: <c>eglCreatePlatformPixmapSurfaceEXT</c>]</b><br/>  </summary>
            public static EGLSurface CreatePlatformPixmapSurfaceEXT(EGLDisplay dpy, EGLConfig config, void* native_pixmap, int* attrib_list) => (EGLSurface) EglPointers.eglCreatePlatformPixmapSurfaceEXT_Lazy((IntPtr)dpy, (IntPtr)config, native_pixmap, attrib_list);
            
            /// <summary> <b>[requires: EGL_EXT_platform_base]</b> <b>[entry point: <c>eglCreatePlatformWindowSurfaceEXT</c>]</b><br/>  </summary>
            public static EGLSurface CreatePlatformWindowSurfaceEXT(EGLDisplay dpy, EGLConfig config, void* native_window, int* attrib_list) => (EGLSurface) EglPointers.eglCreatePlatformWindowSurfaceEXT_Lazy((IntPtr)dpy, (IntPtr)config, native_window, attrib_list);
            
            /// <summary> <b>[requires: EGL_EXT_display_alloc]</b> <b>[entry point: <c>eglDestroyDisplayEXT</c>]</b><br/>  </summary>
            public static int DestroyDisplayEXT_(EGLDisplay dpy) => EglPointers.eglDestroyDisplayEXT_Lazy((IntPtr)dpy);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglGetOutputLayersEXT</c>]</b><br/>  </summary>
            public static int GetOutputLayersEXT(EGLDisplay dpy, IntPtr* attrib_list, EGLOutputLayerEXT* layers, int max_layers, int* num_layers) => EglPointers.eglGetOutputLayersEXT_Lazy((IntPtr)dpy, attrib_list, (IntPtr*)layers, max_layers, num_layers);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglGetOutputPortsEXT</c>]</b><br/>  </summary>
            public static int GetOutputPortsEXT(EGLDisplay dpy, IntPtr* attrib_list, EGLOutputPortEXT* ports, int max_ports, int* num_ports) => EglPointers.eglGetOutputPortsEXT_Lazy((IntPtr)dpy, attrib_list, (IntPtr*)ports, max_ports, num_ports);
            
            /// <summary> <b>[requires: EGL_EXT_platform_base]</b> <b>[entry point: <c>eglGetPlatformDisplayEXT</c>]</b><br/>  </summary>
            public static EGLDisplay GetPlatformDisplayEXT(Platform platform, void* native_display, int* attrib_list) => (EGLDisplay) EglPointers.eglGetPlatformDisplayEXT_Lazy((uint)platform, native_display, attrib_list);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglOutputLayerAttribEXT</c>]</b><br/>  </summary>
            public static int OutputLayerAttribEXT_(EGLDisplay dpy, EGLOutputLayerEXT layer, int attribute, IntPtr value) => EglPointers.eglOutputLayerAttribEXT_Lazy((IntPtr)dpy, (IntPtr)layer, attribute, value);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglOutputPortAttribEXT</c>]</b><br/>  </summary>
            public static int OutputPortAttribEXT_(EGLDisplay dpy, EGLOutputPortEXT port, int attribute, IntPtr value) => EglPointers.eglOutputPortAttribEXT_Lazy((IntPtr)dpy, (IntPtr)port, attribute, value);
            
            /// <summary> <b>[requires: EGL_EXT_device_base | EGL_EXT_device_query]</b> <b>[entry point: <c>eglQueryDeviceAttribEXT</c>]</b><br/>  </summary>
            public static int QueryDeviceAttribEXT(EGLDeviceEXT device, int attribute, IntPtr* value) => EglPointers.eglQueryDeviceAttribEXT_Lazy((IntPtr)device, attribute, value);
            
            /// <summary> <b>[requires: EGL_EXT_device_persistent_id]</b> <b>[entry point: <c>eglQueryDeviceBinaryEXT</c>]</b><br/>  </summary>
            public static int QueryDeviceBinaryEXT(EGLDeviceEXT device, int name, int max_size, void* value, int* size) => EglPointers.eglQueryDeviceBinaryEXT_Lazy((IntPtr)device, name, max_size, value, size);
            
            /// <summary> <b>[requires: EGL_EXT_device_base | EGL_EXT_device_enumeration]</b> <b>[entry point: <c>eglQueryDevicesEXT</c>]</b><br/>  </summary>
            public static int QueryDevicesEXT(int max_devices, EGLDeviceEXT* devices, int* num_devices) => EglPointers.eglQueryDevicesEXT_Lazy(max_devices, (IntPtr*)devices, num_devices);
            
            /// <summary> <b>[requires: EGL_EXT_device_base | EGL_EXT_device_query]</b> <b>[entry point: <c>eglQueryDeviceStringEXT</c>]</b><br/>  </summary>
            public static byte* QueryDeviceStringEXT_(EGLDeviceEXT device, int name) => EglPointers.eglQueryDeviceStringEXT_Lazy((IntPtr)device, name);
            
            /// <summary> <b>[requires: EGL_EXT_device_base | EGL_EXT_device_query]</b> <b>[entry point: <c>eglQueryDisplayAttribEXT</c>]</b><br/>  </summary>
            public static int QueryDisplayAttribEXT(EGLDisplay dpy, int attribute, IntPtr* value) => EglPointers.eglQueryDisplayAttribEXT_Lazy((IntPtr)dpy, attribute, value);
            
            /// <summary> <b>[requires: EGL_EXT_image_dma_buf_import_modifiers]</b> <b>[entry point: <c>eglQueryDmaBufFormatsEXT</c>]</b><br/>  </summary>
            public static int QueryDmaBufFormatsEXT(EGLDisplay dpy, int max_formats, int* formats, int* num_formats) => EglPointers.eglQueryDmaBufFormatsEXT_Lazy((IntPtr)dpy, max_formats, formats, num_formats);
            
            /// <summary> <b>[requires: EGL_EXT_image_dma_buf_import_modifiers]</b> <b>[entry point: <c>eglQueryDmaBufModifiersEXT</c>]</b><br/>  </summary>
            public static int QueryDmaBufModifiersEXT(EGLDisplay dpy, int format, int max_modifiers, ulong* modifiers, int* external_only, int* num_modifiers) => EglPointers.eglQueryDmaBufModifiersEXT_Lazy((IntPtr)dpy, format, max_modifiers, modifiers, external_only, num_modifiers);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglQueryOutputLayerAttribEXT</c>]</b><br/>  </summary>
            public static int QueryOutputLayerAttribEXT(EGLDisplay dpy, EGLOutputLayerEXT layer, int attribute, IntPtr* value) => EglPointers.eglQueryOutputLayerAttribEXT_Lazy((IntPtr)dpy, (IntPtr)layer, attribute, value);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglQueryOutputLayerStringEXT</c>]</b><br/>  </summary>
            public static byte* QueryOutputLayerStringEXT_(EGLDisplay dpy, EGLOutputLayerEXT layer, int name) => EglPointers.eglQueryOutputLayerStringEXT_Lazy((IntPtr)dpy, (IntPtr)layer, name);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglQueryOutputPortAttribEXT</c>]</b><br/>  </summary>
            public static int QueryOutputPortAttribEXT(EGLDisplay dpy, EGLOutputPortEXT port, int attribute, IntPtr* value) => EglPointers.eglQueryOutputPortAttribEXT_Lazy((IntPtr)dpy, (IntPtr)port, attribute, value);
            
            /// <summary> <b>[requires: EGL_EXT_output_base]</b> <b>[entry point: <c>eglQueryOutputPortStringEXT</c>]</b><br/>  </summary>
            public static byte* QueryOutputPortStringEXT_(EGLDisplay dpy, EGLOutputPortEXT port, int name) => EglPointers.eglQueryOutputPortStringEXT_Lazy((IntPtr)dpy, (IntPtr)port, name);
            
            /// <summary> <b>[requires: EGL_EXT_surface_compression]</b> <b>[entry point: <c>eglQuerySupportedCompressionRatesEXT</c>]</b><br/>  </summary>
            public static int QuerySupportedCompressionRatesEXT(EGLDisplay dpy, EGLConfig config, IntPtr* attrib_list, int* rates, int rate_size, int* num_rates) => EglPointers.eglQuerySupportedCompressionRatesEXT_Lazy((IntPtr)dpy, (IntPtr)config, attrib_list, rates, rate_size, num_rates);
            
            /// <summary> <b>[requires: EGL_EXT_stream_consumer_egloutput]</b> <b>[entry point: <c>eglStreamConsumerOutputEXT</c>]</b><br/>  </summary>
            public static int StreamConsumerOutputEXT_(EGLDisplay dpy, EGLStreamKHR stream, EGLOutputLayerEXT layer) => EglPointers.eglStreamConsumerOutputEXT_Lazy((IntPtr)dpy, (IntPtr)stream, (IntPtr)layer);
            
            /// <summary> <b>[requires: EGL_EXT_swap_buffers_with_damage]</b> <b>[entry point: <c>eglSwapBuffersWithDamageEXT</c>]</b><br/>  </summary>
            public static int SwapBuffersWithDamageEXT(EGLDisplay dpy, EGLSurface surface, int* rects, int n_rects) => EglPointers.eglSwapBuffersWithDamageEXT_Lazy((IntPtr)dpy, (IntPtr)surface, rects, n_rects);
            
            /// <summary> <b>[requires: EGL_EXT_sync_reuse]</b> <b>[entry point: <c>eglUnsignalSyncEXT</c>]</b><br/>  </summary>
            public static int UnsignalSyncEXT(EGLDisplay dpy, EGLSync sync, IntPtr* attrib_list) => EglPointers.eglUnsignalSyncEXT_Lazy((IntPtr)dpy, (IntPtr)sync, attrib_list);
            
        }
        /// <summary>HI extensions.</summary>
        public static unsafe partial class HI
        {
            /// <summary> <b>[requires: EGL_HI_clientpixmap]</b> <b>[entry point: <c>eglCreatePixmapSurfaceHI</c>]</b><br/>  </summary>
            public static EGLSurface CreatePixmapSurfaceHI(EGLDisplay dpy, EGLConfig config, EGLClientPixmapHI* pixmap) => (EGLSurface) EglPointers.eglCreatePixmapSurfaceHI_Lazy((IntPtr)dpy, (IntPtr)config, pixmap);
            
        }
        /// <summary>KHR extensions.</summary>
        public static unsafe partial class KHR
        {
            /// <summary> <b>[requires: EGL_KHR_fence_sync | EGL_KHR_reusable_sync]</b> <b>[entry point: <c>eglClientWaitSyncKHR</c>]</b><br/>  </summary>
            public static WaitSyncStatus ClientWaitSyncKHR(EGLDisplay dpy, EGLSyncKHR sync, ClientWaitSyncFlags flags, ulong timeout) => (WaitSyncStatus) EglPointers.eglClientWaitSyncKHR_Lazy((IntPtr)dpy, (IntPtr)sync, (int)flags, timeout);
            
            /// <summary> <b>[requires: EGL_KHR_image | EGL_KHR_image_base]</b> <b>[entry point: <c>eglCreateImageKHR</c>]</b><br/>  </summary>
            public static EGLImageKHR CreateImageKHR(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, int* attrib_list) => (EGLImageKHR) EglPointers.eglCreateImageKHR_Lazy((IntPtr)dpy, (IntPtr)ctx, (uint)target, (IntPtr)buffer, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_stream_attrib]</b> <b>[entry point: <c>eglCreateStreamAttribKHR</c>]</b><br/>  </summary>
            public static EGLStreamKHR CreateStreamAttribKHR(EGLDisplay dpy, IntPtr* attrib_list) => (EGLStreamKHR) EglPointers.eglCreateStreamAttribKHR_Lazy((IntPtr)dpy, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_stream_cross_process_fd]</b> <b>[entry point: <c>eglCreateStreamFromFileDescriptorKHR</c>]</b><br/>  </summary>
            public static EGLStreamKHR CreateStreamFromFileDescriptorKHR(EGLDisplay dpy, int file_descriptor) => (EGLStreamKHR) EglPointers.eglCreateStreamFromFileDescriptorKHR_Lazy((IntPtr)dpy, file_descriptor);
            
            /// <summary> <b>[requires: EGL_KHR_stream]</b> <b>[entry point: <c>eglCreateStreamKHR</c>]</b><br/>  </summary>
            public static EGLStreamKHR CreateStreamKHR(EGLDisplay dpy, int* attrib_list) => (EGLStreamKHR) EglPointers.eglCreateStreamKHR_Lazy((IntPtr)dpy, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_stream_producer_eglsurface]</b> <b>[entry point: <c>eglCreateStreamProducerSurfaceKHR</c>]</b><br/>  </summary>
            public static EGLSurface CreateStreamProducerSurfaceKHR(EGLDisplay dpy, EGLConfig config, EGLStreamKHR stream, int* attrib_list) => (EGLSurface) EglPointers.eglCreateStreamProducerSurfaceKHR_Lazy((IntPtr)dpy, (IntPtr)config, (IntPtr)stream, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_cl_event2]</b> <b>[entry point: <c>eglCreateSync64KHR</c>]</b><br/>  </summary>
            public static EGLSyncKHR CreateSync64KHR(EGLDisplay dpy, SyncType type, IntPtr* attrib_list) => (EGLSyncKHR) EglPointers.eglCreateSync64KHR_Lazy((IntPtr)dpy, (uint)type, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_fence_sync | EGL_KHR_reusable_sync]</b> <b>[entry point: <c>eglCreateSyncKHR</c>]</b><br/>  </summary>
            public static EGLSyncKHR CreateSyncKHR(EGLDisplay dpy, SyncType type, int* attrib_list) => (EGLSyncKHR) EglPointers.eglCreateSyncKHR_Lazy((IntPtr)dpy, (uint)type, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_debug]</b> <b>[entry point: <c>eglDebugMessageControlKHR</c>]</b><br/>  </summary>
            public static int DebugMessageControlKHR(IntPtr callback, IntPtr* attrib_list) => EglPointers.eglDebugMessageControlKHR_Lazy(callback, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_image | EGL_KHR_image_base]</b> <b>[entry point: <c>eglDestroyImageKHR</c>]</b><br/>  </summary>
            public static int DestroyImageKHR_(EGLDisplay dpy, EGLImageKHR image) => EglPointers.eglDestroyImageKHR_Lazy((IntPtr)dpy, (IntPtr)image);
            
            /// <summary> <b>[requires: EGL_KHR_stream]</b> <b>[entry point: <c>eglDestroyStreamKHR</c>]</b><br/>  </summary>
            public static int DestroyStreamKHR_(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglDestroyStreamKHR_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_KHR_fence_sync | EGL_KHR_reusable_sync]</b> <b>[entry point: <c>eglDestroySyncKHR</c>]</b><br/>  </summary>
            public static int DestroySyncKHR_(EGLDisplay dpy, EGLSyncKHR sync) => EglPointers.eglDestroySyncKHR_Lazy((IntPtr)dpy, (IntPtr)sync);
            
            /// <summary> <b>[requires: EGL_KHR_stream_cross_process_fd]</b> <b>[entry point: <c>eglGetStreamFileDescriptorKHR</c>]</b><br/>  </summary>
            public static int GetStreamFileDescriptorKHR(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglGetStreamFileDescriptorKHR_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_KHR_fence_sync | EGL_KHR_reusable_sync]</b> <b>[entry point: <c>eglGetSyncAttribKHR</c>]</b><br/>  </summary>
            public static int GetSyncAttribKHR(EGLDisplay dpy, EGLSyncKHR sync, int attribute, int* value) => EglPointers.eglGetSyncAttribKHR_Lazy((IntPtr)dpy, (IntPtr)sync, attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_debug]</b> <b>[entry point: <c>eglLabelObjectKHR</c>]</b><br/>  </summary>
            public static int LabelObjectKHR(EGLDisplay display, All objectType, EGLObjectKHR obj, EGLLabelKHR label) => EglPointers.eglLabelObjectKHR_Lazy((IntPtr)display, (uint)objectType, (IntPtr)obj, (IntPtr)label);
            
            /// <summary> <b>[requires: EGL_KHR_lock_surface | EGL_KHR_lock_surface3]</b> <b>[entry point: <c>eglLockSurfaceKHR</c>]</b><br/>  </summary>
            public static int LockSurfaceKHR(EGLDisplay dpy, EGLSurface surface, int* attrib_list) => EglPointers.eglLockSurfaceKHR_Lazy((IntPtr)dpy, (IntPtr)surface, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_debug]</b> <b>[entry point: <c>eglQueryDebugKHR</c>]</b><br/>  </summary>
            public static int QueryDebugKHR(int attribute, IntPtr* value) => EglPointers.eglQueryDebugKHR_Lazy(attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_display_reference]</b> <b>[entry point: <c>eglQueryDisplayAttribKHR</c>]</b><br/>  </summary>
            public static int QueryDisplayAttribKHR(EGLDisplay dpy, int name, IntPtr* value) => EglPointers.eglQueryDisplayAttribKHR_Lazy((IntPtr)dpy, name, value);
            
            /// <summary> <b>[requires: EGL_KHR_stream_attrib]</b> <b>[entry point: <c>eglQueryStreamAttribKHR</c>]</b><br/>  </summary>
            public static int QueryStreamAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, IntPtr* value) => EglPointers.eglQueryStreamAttribKHR_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_stream]</b> <b>[entry point: <c>eglQueryStreamKHR</c>]</b><br/>  </summary>
            public static int QueryStreamKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, int* value) => EglPointers.eglQueryStreamKHR_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_stream_fifo]</b> <b>[entry point: <c>eglQueryStreamTimeKHR</c>]</b><br/>  </summary>
            public static int QueryStreamTimeKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamTime attribute, ulong* value) => EglPointers.eglQueryStreamTimeKHR_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_stream]</b> <b>[entry point: <c>eglQueryStreamu64KHR</c>]</b><br/>  </summary>
            public static int QueryStreamu64KHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryU64Attribute attribute, ulong* value) => EglPointers.eglQueryStreamu64KHR_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_lock_surface3]</b> <b>[entry point: <c>eglQuerySurface64KHR</c>]</b><br/>  </summary>
            public static int QuerySurface64KHR(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, IntPtr* value) => EglPointers.eglQuerySurface64KHR_Lazy((IntPtr)dpy, (IntPtr)surface, (int)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_partial_update]</b> <b>[entry point: <c>eglSetDamageRegionKHR</c>]</b><br/>  </summary>
            public static int SetDamageRegionKHR(EGLDisplay dpy, EGLSurface surface, int* rects, int n_rects) => EglPointers.eglSetDamageRegionKHR_Lazy((IntPtr)dpy, (IntPtr)surface, rects, n_rects);
            
            /// <summary> <b>[requires: EGL_KHR_stream_attrib]</b> <b>[entry point: <c>eglSetStreamAttribKHR</c>]</b><br/>  </summary>
            public static int SetStreamAttribKHR_(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, IntPtr value) => EglPointers.eglSetStreamAttribKHR_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_reusable_sync]</b> <b>[entry point: <c>eglSignalSyncKHR</c>]</b><br/>  </summary>
            public static int SignalSyncKHR_(EGLDisplay dpy, EGLSyncKHR sync, SyncStatus mode) => EglPointers.eglSignalSyncKHR_Lazy((IntPtr)dpy, (IntPtr)sync, (uint)mode);
            
            /// <summary> <b>[requires: EGL_KHR_stream]</b> <b>[entry point: <c>eglStreamAttribKHR</c>]</b><br/>  </summary>
            public static int StreamAttribKHR_(EGLDisplay dpy, EGLStreamKHR stream, StreamAttribute attribute, int value) => EglPointers.eglStreamAttribKHR_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)attribute, value);
            
            /// <summary> <b>[requires: EGL_KHR_stream_attrib]</b> <b>[entry point: <c>eglStreamConsumerAcquireAttribKHR</c>]</b><br/>  </summary>
            public static int StreamConsumerAcquireAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, IntPtr* attrib_list) => EglPointers.eglStreamConsumerAcquireAttribKHR_Lazy((IntPtr)dpy, (IntPtr)stream, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_stream_consumer_gltexture]</b> <b>[entry point: <c>eglStreamConsumerAcquireKHR</c>]</b><br/>  </summary>
            public static int StreamConsumerAcquireKHR_(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglStreamConsumerAcquireKHR_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_KHR_stream_consumer_gltexture]</b> <b>[entry point: <c>eglStreamConsumerGLTextureExternalKHR</c>]</b><br/>  </summary>
            public static int StreamConsumerGLTextureExternalKHR_(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglStreamConsumerGLTextureExternalKHR_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_KHR_stream_attrib]</b> <b>[entry point: <c>eglStreamConsumerReleaseAttribKHR</c>]</b><br/>  </summary>
            public static int StreamConsumerReleaseAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, IntPtr* attrib_list) => EglPointers.eglStreamConsumerReleaseAttribKHR_Lazy((IntPtr)dpy, (IntPtr)stream, attrib_list);
            
            /// <summary> <b>[requires: EGL_KHR_stream_consumer_gltexture]</b> <b>[entry point: <c>eglStreamConsumerReleaseKHR</c>]</b><br/>  </summary>
            public static int StreamConsumerReleaseKHR_(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglStreamConsumerReleaseKHR_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_KHR_swap_buffers_with_damage]</b> <b>[entry point: <c>eglSwapBuffersWithDamageKHR</c>]</b><br/>  </summary>
            public static int SwapBuffersWithDamageKHR(EGLDisplay dpy, EGLSurface surface, int* rects, int n_rects) => EglPointers.eglSwapBuffersWithDamageKHR_Lazy((IntPtr)dpy, (IntPtr)surface, rects, n_rects);
            
            /// <summary> <b>[requires: EGL_KHR_lock_surface | EGL_KHR_lock_surface3]</b> <b>[entry point: <c>eglUnlockSurfaceKHR</c>]</b><br/>  </summary>
            public static int UnlockSurfaceKHR_(EGLDisplay dpy, EGLSurface surface) => EglPointers.eglUnlockSurfaceKHR_Lazy((IntPtr)dpy, (IntPtr)surface);
            
            /// <summary> <b>[requires: EGL_KHR_wait_sync]</b> <b>[entry point: <c>eglWaitSyncKHR</c>]</b><br/>  </summary>
            public static int WaitSyncKHR(EGLDisplay dpy, EGLSyncKHR sync, int flags) => EglPointers.eglWaitSyncKHR_Lazy((IntPtr)dpy, (IntPtr)sync, flags);
            
        }
        /// <summary>MESA extensions.</summary>
        public static unsafe partial class MESA
        {
            /// <summary> <b>[requires: EGL_MESA_drm_image]</b> <b>[entry point: <c>eglCreateDRMImageMESA</c>]</b><br/>  </summary>
            public static EGLImageKHR CreateDRMImageMESA(EGLDisplay dpy, int* attrib_list) => (EGLImageKHR) EglPointers.eglCreateDRMImageMESA_Lazy((IntPtr)dpy, attrib_list);
            
            /// <summary> <b>[requires: EGL_MESA_image_dma_buf_export]</b> <b>[entry point: <c>eglExportDMABUFImageMESA</c>]</b><br/>  </summary>
            public static int ExportDMABUFImageMESA(EGLDisplay dpy, EGLImageKHR image, int* fds, int* strides, int* offsets) => EglPointers.eglExportDMABUFImageMESA_Lazy((IntPtr)dpy, (IntPtr)image, fds, strides, offsets);
            
            /// <summary> <b>[requires: EGL_MESA_image_dma_buf_export]</b> <b>[entry point: <c>eglExportDMABUFImageQueryMESA</c>]</b><br/>  </summary>
            public static int ExportDMABUFImageQueryMESA(EGLDisplay dpy, EGLImageKHR image, int* fourcc, int* num_planes, ulong* modifiers) => EglPointers.eglExportDMABUFImageQueryMESA_Lazy((IntPtr)dpy, (IntPtr)image, fourcc, num_planes, modifiers);
            
            /// <summary> <b>[requires: EGL_MESA_drm_image]</b> <b>[entry point: <c>eglExportDRMImageMESA</c>]</b><br/>  </summary>
            public static int ExportDRMImageMESA(EGLDisplay dpy, EGLImageKHR image, int* name, int* handle, int* stride) => EglPointers.eglExportDRMImageMESA_Lazy((IntPtr)dpy, (IntPtr)image, name, handle, stride);
            
            /// <summary> <b>[requires: EGL_MESA_query_driver]</b> <b>[entry point: <c>eglGetDisplayDriverConfig</c>]</b><br/>  </summary>
            public static byte* GetDisplayDriverConfig_(EGLDisplay dpy) => EglPointers.eglGetDisplayDriverConfig_Lazy((IntPtr)dpy);
            
            /// <summary> <b>[requires: EGL_MESA_query_driver]</b> <b>[entry point: <c>eglGetDisplayDriverName</c>]</b><br/>  </summary>
            public static byte* GetDisplayDriverName_(EGLDisplay dpy) => EglPointers.eglGetDisplayDriverName_Lazy((IntPtr)dpy);
            
        }
        /// <summary>NOK extensions.</summary>
        public static unsafe partial class NOK
        {
            /// <summary> <b>[requires: EGL_NOK_swap_region2]</b> <b>[entry point: <c>eglSwapBuffersRegion2NOK</c>]</b><br/>  </summary>
            public static int SwapBuffersRegion2NOK(EGLDisplay dpy, EGLSurface surface, int numRects, int* rects) => EglPointers.eglSwapBuffersRegion2NOK_Lazy((IntPtr)dpy, (IntPtr)surface, numRects, rects);
            
            /// <summary> <b>[requires: EGL_NOK_swap_region]</b> <b>[entry point: <c>eglSwapBuffersRegionNOK</c>]</b><br/>  </summary>
            public static int SwapBuffersRegionNOK(EGLDisplay dpy, EGLSurface surface, int numRects, int* rects) => EglPointers.eglSwapBuffersRegionNOK_Lazy((IntPtr)dpy, (IntPtr)surface, numRects, rects);
            
        }
        /// <summary>NV extensions.</summary>
        public static unsafe partial class NV
        {
            /// <summary> <b>[requires: EGL_NV_sync]</b> <b>[entry point: <c>eglClientWaitSyncNV</c>]</b><br/>  </summary>
            public static WaitSyncStatus ClientWaitSyncNV(EGLSyncNV sync, ClientWaitSyncFlags flags, ulong timeout) => (WaitSyncStatus) EglPointers.eglClientWaitSyncNV_Lazy((IntPtr)sync, (int)flags, timeout);
            
            /// <summary> <b>[requires: EGL_NV_sync]</b> <b>[entry point: <c>eglCreateFenceSyncNV</c>]</b><br/>  </summary>
            public static EGLSyncNV CreateFenceSyncNV(EGLDisplay dpy, SyncCondition condition, int* attrib_list) => (EGLSyncNV) EglPointers.eglCreateFenceSyncNV_Lazy((IntPtr)dpy, (uint)condition, attrib_list);
            
            /// <summary> <b>[requires: EGL_NV_stream_sync]</b> <b>[entry point: <c>eglCreateStreamSyncNV</c>]</b><br/>  </summary>
            public static EGLSyncKHR CreateStreamSyncNV(EGLDisplay dpy, EGLStreamKHR stream, SyncType type, int* attrib_list) => (EGLSyncKHR) EglPointers.eglCreateStreamSyncNV_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)type, attrib_list);
            
            /// <summary> <b>[requires: EGL_NV_sync]</b> <b>[entry point: <c>eglDestroySyncNV</c>]</b><br/>  </summary>
            public static int DestroySyncNV_(EGLSyncNV sync) => EglPointers.eglDestroySyncNV_Lazy((IntPtr)sync);
            
            /// <summary> <b>[requires: EGL_NV_sync]</b> <b>[entry point: <c>eglFenceNV</c>]</b><br/>  </summary>
            public static int FenceNV_(EGLSyncNV sync) => EglPointers.eglFenceNV_Lazy((IntPtr)sync);
            
            /// <summary> <b>[requires: EGL_NV_sync]</b> <b>[entry point: <c>eglGetSyncAttribNV</c>]</b><br/>  </summary>
            public static int GetSyncAttribNV(EGLSyncNV sync, int attribute, int* value) => EglPointers.eglGetSyncAttribNV_Lazy((IntPtr)sync, attribute, value);
            
            /// <summary> <b>[requires: EGL_NV_system_time]</b> <b>[entry point: <c>eglGetSystemTimeFrequencyNV</c>]</b><br/>  </summary>
            public static ulong GetSystemTimeFrequencyNV() => EglPointers.eglGetSystemTimeFrequencyNV_Lazy();
            
            /// <summary> <b>[requires: EGL_NV_system_time]</b> <b>[entry point: <c>eglGetSystemTimeNV</c>]</b><br/>  </summary>
            public static ulong GetSystemTimeNV() => EglPointers.eglGetSystemTimeNV_Lazy();
            
            /// <summary> <b>[requires: EGL_NV_post_sub_buffer]</b> <b>[entry point: <c>eglPostSubBufferNV</c>]</b><br/>  </summary>
            public static int PostSubBufferNV_(EGLDisplay dpy, EGLSurface surface, int x, int y, int width, int height) => EglPointers.eglPostSubBufferNV_Lazy((IntPtr)dpy, (IntPtr)surface, x, y, width, height);
            
            /// <summary> <b>[requires: EGL_NV_stream_metadata]</b> <b>[entry point: <c>eglQueryDisplayAttribNV</c>]</b><br/>  </summary>
            public static int QueryDisplayAttribNV(EGLDisplay dpy, int attribute, IntPtr* value) => EglPointers.eglQueryDisplayAttribNV_Lazy((IntPtr)dpy, attribute, value);
            
            /// <summary> <b>[requires: EGL_NV_native_query]</b> <b>[entry point: <c>eglQueryNativeDisplayNV</c>]</b><br/>  </summary>
            public static int QueryNativeDisplayNV(EGLDisplay dpy, IntPtr* display_id) => EglPointers.eglQueryNativeDisplayNV_Lazy((IntPtr)dpy, display_id);
            
            /// <summary> <b>[requires: EGL_NV_native_query]</b> <b>[entry point: <c>eglQueryNativePixmapNV</c>]</b><br/>  </summary>
            public static int QueryNativePixmapNV(EGLDisplay dpy, EGLSurface surf, IntPtr* pixmap) => EglPointers.eglQueryNativePixmapNV_Lazy((IntPtr)dpy, (IntPtr)surf, pixmap);
            
            /// <summary> <b>[requires: EGL_NV_native_query]</b> <b>[entry point: <c>eglQueryNativeWindowNV</c>]</b><br/>  </summary>
            public static int QueryNativeWindowNV(EGLDisplay dpy, EGLSurface surf, IntPtr* window) => EglPointers.eglQueryNativeWindowNV_Lazy((IntPtr)dpy, (IntPtr)surf, window);
            
            /// <summary> <b>[requires: EGL_NV_stream_consumer_eglimage]</b> <b>[entry point: <c>eglQueryStreamConsumerEventNV</c>]</b><br/>  </summary>
            public static int QueryStreamConsumerEventNV(EGLDisplay dpy, EGLStreamKHR stream, ulong timeout, All* @event, IntPtr* aux) => EglPointers.eglQueryStreamConsumerEventNV_Lazy((IntPtr)dpy, (IntPtr)stream, timeout, (uint*)@event, aux);
            
            /// <summary> <b>[requires: EGL_NV_stream_metadata]</b> <b>[entry point: <c>eglQueryStreamMetadataNV</c>]</b><br/>  </summary>
            public static int QueryStreamMetadataNV(EGLDisplay dpy, EGLStreamKHR stream, All name, int n, int offset, int size, void* data) => EglPointers.eglQueryStreamMetadataNV_Lazy((IntPtr)dpy, (IntPtr)stream, (uint)name, n, offset, size, data);
            
            /// <summary> <b>[requires: EGL_NV_stream_reset]</b> <b>[entry point: <c>eglResetStreamNV</c>]</b><br/>  </summary>
            public static int ResetStreamNV_(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglResetStreamNV_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_NV_stream_metadata]</b> <b>[entry point: <c>eglSetStreamMetadataNV</c>]</b><br/>  </summary>
            public static int SetStreamMetadataNV(EGLDisplay dpy, EGLStreamKHR stream, int n, int offset, int size, void* data) => EglPointers.eglSetStreamMetadataNV_Lazy((IntPtr)dpy, (IntPtr)stream, n, offset, size, data);
            
            /// <summary> <b>[requires: EGL_NV_sync]</b> <b>[entry point: <c>eglSignalSyncNV</c>]</b><br/>  </summary>
            public static int SignalSyncNV_(EGLSyncNV sync, SyncStatus mode) => EglPointers.eglSignalSyncNV_Lazy((IntPtr)sync, (uint)mode);
            
            /// <summary> <b>[requires: EGL_NV_stream_consumer_eglimage]</b> <b>[entry point: <c>eglStreamAcquireImageNV</c>]</b><br/>  </summary>
            public static int StreamAcquireImageNV(EGLDisplay dpy, EGLStreamKHR stream, EGLImage* pImage, EGLSync sync) => EglPointers.eglStreamAcquireImageNV_Lazy((IntPtr)dpy, (IntPtr)stream, (IntPtr*)pImage, (IntPtr)sync);
            
            /// <summary> <b>[requires: EGL_NV_stream_consumer_gltexture_yuv]</b> <b>[entry point: <c>eglStreamConsumerGLTextureExternalAttribsNV</c>]</b><br/>  </summary>
            public static int StreamConsumerGLTextureExternalAttribsNV(EGLDisplay dpy, EGLStreamKHR stream, IntPtr* attrib_list) => EglPointers.eglStreamConsumerGLTextureExternalAttribsNV_Lazy((IntPtr)dpy, (IntPtr)stream, attrib_list);
            
            /// <summary> <b>[requires: EGL_NV_stream_flush]</b> <b>[entry point: <c>eglStreamFlushNV</c>]</b><br/>  </summary>
            public static int StreamFlushNV_(EGLDisplay dpy, EGLStreamKHR stream) => EglPointers.eglStreamFlushNV_Lazy((IntPtr)dpy, (IntPtr)stream);
            
            /// <summary> <b>[requires: EGL_NV_stream_consumer_eglimage]</b> <b>[entry point: <c>eglStreamImageConsumerConnectNV</c>]</b><br/>  </summary>
            public static int StreamImageConsumerConnectNV(EGLDisplay dpy, EGLStreamKHR stream, int num_modifiers, ulong* modifiers, IntPtr* attrib_list) => EglPointers.eglStreamImageConsumerConnectNV_Lazy((IntPtr)dpy, (IntPtr)stream, num_modifiers, modifiers, attrib_list);
            
            /// <summary> <b>[requires: EGL_NV_stream_consumer_eglimage]</b> <b>[entry point: <c>eglStreamReleaseImageNV</c>]</b><br/>  </summary>
            public static int StreamReleaseImageNV_(EGLDisplay dpy, EGLStreamKHR stream, EGLImage image, EGLSync sync) => EglPointers.eglStreamReleaseImageNV_Lazy((IntPtr)dpy, (IntPtr)stream, (IntPtr)image, (IntPtr)sync);
            
        }
        /// <summary>WL extensions.</summary>
        public static unsafe partial class WL
        {
            /// <summary> <b>[requires: EGL_WL_bind_wayland_display]</b> <b>[entry point: <c>eglBindWaylandDisplayWL</c>]</b><br/>  </summary>
            public static int BindWaylandDisplayWL(EGLDisplay dpy, IntPtr* display) => EglPointers.eglBindWaylandDisplayWL_Lazy((IntPtr)dpy, display);
            
            /// <summary> <b>[requires: EGL_WL_create_wayland_buffer_from_image]</b> <b>[entry point: <c>eglCreateWaylandBufferFromImageWL</c>]</b><br/>  </summary>
            public static IntPtr* CreateWaylandBufferFromImageWL(EGLDisplay dpy, EGLImageKHR image) => EglPointers.eglCreateWaylandBufferFromImageWL_Lazy((IntPtr)dpy, (IntPtr)image);
            
            /// <summary> <b>[requires: EGL_WL_bind_wayland_display]</b> <b>[entry point: <c>eglQueryWaylandBufferWL</c>]</b><br/>  </summary>
            public static int QueryWaylandBufferWL(EGLDisplay dpy, IntPtr* buffer, int attribute, int* value) => EglPointers.eglQueryWaylandBufferWL_Lazy((IntPtr)dpy, buffer, attribute, value);
            
            /// <summary> <b>[requires: EGL_WL_bind_wayland_display]</b> <b>[entry point: <c>eglUnbindWaylandDisplayWL</c>]</b><br/>  </summary>
            public static int UnbindWaylandDisplayWL(EGLDisplay dpy, IntPtr* display) => EglPointers.eglUnbindWaylandDisplayWL_Lazy((IntPtr)dpy, display);
            
        }
    }
}
