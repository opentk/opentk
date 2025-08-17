// This file is auto generated, do not edit. Generated: 2025-08-17 15:26:47 GMT+02:00
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Wgl;
using OpenTK.Graphics.Glx;

namespace OpenTK.Graphics.Egl
{
    public static unsafe partial class Egl
    {
        /// <inheritdoc cref="BindAPI_(RenderApi)"/>
        public static unsafe bool BindAPI(RenderApi api)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = BindAPI_(api);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="BindTexImage_(EGLDisplay, EGLSurface, int)"/>
        public static unsafe bool BindTexImage(EGLDisplay dpy, EGLSurface surface, int buffer)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = BindTexImage_(dpy, surface, buffer);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="ChooseConfig(EGLDisplay, int*, EGLConfig*, int, int*)"/>
        public static unsafe bool ChooseConfig(EGLDisplay dpy, ReadOnlySpan<int> attrib_list, Span<EGLConfig> configs, int config_size, Span<int> num_config)
        {
            bool returnValue_bool;
            fixed (int* num_config_ptr = num_config)
            {
                fixed (EGLConfig* configs_ptr = configs)
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    {
                        int returnValue;
                        returnValue = ChooseConfig(dpy, attrib_list_ptr, configs_ptr, config_size, num_config_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="ChooseConfig(EGLDisplay, int*, EGLConfig*, int, int*)"/>
        public static unsafe bool ChooseConfig(EGLDisplay dpy, int[] attrib_list, EGLConfig[] configs, int config_size, int[] num_config)
        {
            bool returnValue_bool;
            fixed (int* num_config_ptr = num_config)
            {
                fixed (EGLConfig* configs_ptr = configs)
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    {
                        int returnValue;
                        returnValue = ChooseConfig(dpy, attrib_list_ptr, configs_ptr, config_size, num_config_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="ChooseConfig(EGLDisplay, int*, EGLConfig*, int, int*)"/>
        public static unsafe bool ChooseConfig(EGLDisplay dpy, ref readonly int attrib_list, ref EGLConfig configs, int config_size, ref int num_config)
        {
            bool returnValue_bool;
            fixed (int* attrib_list_ptr = &attrib_list)
            fixed (EGLConfig* configs_ptr = &configs)
            fixed (int* num_config_ptr = &num_config)
            {
                int returnValue;
                returnValue = ChooseConfig(dpy, attrib_list_ptr, configs_ptr, config_size, num_config_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="CopyBuffers_(EGLDisplay, EGLSurface, IntPtr)"/>
        public static unsafe bool CopyBuffers(EGLDisplay dpy, EGLSurface surface, IntPtr target)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = CopyBuffers_(dpy, surface, target);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="CreateContext(EGLDisplay, EGLConfig, EGLContext, int*)"/>
        public static unsafe EGLContext CreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, ReadOnlySpan<int> attrib_list)
        {
            EGLContext returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateContext(dpy, config, share_context, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(EGLDisplay, EGLConfig, EGLContext, int*)"/>
        public static unsafe EGLContext CreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, int[] attrib_list)
        {
            EGLContext returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateContext(dpy, config, share_context, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(EGLDisplay, EGLConfig, EGLContext, int*)"/>
        public static unsafe EGLContext CreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, ref readonly int attrib_list)
        {
            EGLContext returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateContext(dpy, config, share_context, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(EGLDisplay, EGLContext, TextureTarget, EGLClientBuffer, IntPtr*)"/>
        public static unsafe EGLImage CreateImage(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, ReadOnlySpan<IntPtr> attrib_list)
        {
            EGLImage returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateImage(dpy, ctx, target, buffer, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(EGLDisplay, EGLContext, TextureTarget, EGLClientBuffer, IntPtr*)"/>
        public static unsafe EGLImage CreateImage(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, IntPtr[] attrib_list)
        {
            EGLImage returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateImage(dpy, ctx, target, buffer, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(EGLDisplay, EGLContext, TextureTarget, EGLClientBuffer, IntPtr*)"/>
        public static unsafe EGLImage CreateImage(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, ref readonly IntPtr attrib_list)
        {
            EGLImage returnValue;
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateImage(dpy, ctx, target, buffer, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbufferFromClientBuffer(EGLDisplay, ClientBufferType, EGLClientBuffer, EGLConfig, int*)"/>
        public static unsafe EGLSurface CreatePbufferFromClientBuffer(EGLDisplay dpy, ClientBufferType buftype, EGLClientBuffer buffer, EGLConfig config, ReadOnlySpan<int> attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePbufferFromClientBuffer(dpy, buftype, buffer, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbufferFromClientBuffer(EGLDisplay, ClientBufferType, EGLClientBuffer, EGLConfig, int*)"/>
        public static unsafe EGLSurface CreatePbufferFromClientBuffer(EGLDisplay dpy, ClientBufferType buftype, EGLClientBuffer buffer, EGLConfig config, int[] attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePbufferFromClientBuffer(dpy, buftype, buffer, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbufferFromClientBuffer(EGLDisplay, ClientBufferType, EGLClientBuffer, EGLConfig, int*)"/>
        public static unsafe EGLSurface CreatePbufferFromClientBuffer(EGLDisplay dpy, ClientBufferType buftype, EGLClientBuffer buffer, EGLConfig config, ref readonly int attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePbufferFromClientBuffer(dpy, buftype, buffer, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbufferSurface(EGLDisplay, EGLConfig, int*)"/>
        public static unsafe EGLSurface CreatePbufferSurface(EGLDisplay dpy, EGLConfig config, ReadOnlySpan<int> attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePbufferSurface(dpy, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbufferSurface(EGLDisplay, EGLConfig, int*)"/>
        public static unsafe EGLSurface CreatePbufferSurface(EGLDisplay dpy, EGLConfig config, int[] attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePbufferSurface(dpy, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbufferSurface(EGLDisplay, EGLConfig, int*)"/>
        public static unsafe EGLSurface CreatePbufferSurface(EGLDisplay dpy, EGLConfig config, ref readonly int attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePbufferSurface(dpy, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmapSurface(EGLDisplay, EGLConfig, IntPtr, int*)"/>
        public static unsafe EGLSurface CreatePixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr pixmap, ReadOnlySpan<int> attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePixmapSurface(dpy, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmapSurface(EGLDisplay, EGLConfig, IntPtr, int*)"/>
        public static unsafe EGLSurface CreatePixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr pixmap, int[] attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePixmapSurface(dpy, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmapSurface(EGLDisplay, EGLConfig, IntPtr, int*)"/>
        public static unsafe EGLSurface CreatePixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr pixmap, ref readonly int attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePixmapSurface(dpy, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformPixmapSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformPixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr native_pixmap, ReadOnlySpan<IntPtr> attrib_list)
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                void* native_pixmap_vptr = (void*)native_pixmap;
                returnValue = CreatePlatformPixmapSurface(dpy, config, native_pixmap_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformPixmapSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformPixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr native_pixmap, IntPtr[] attrib_list)
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                void* native_pixmap_vptr = (void*)native_pixmap;
                returnValue = CreatePlatformPixmapSurface(dpy, config, native_pixmap_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformPixmapSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformPixmapSurface(EGLDisplay dpy, EGLConfig config, IntPtr native_pixmap, ref readonly IntPtr attrib_list)
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                void* native_pixmap_vptr = (void*)native_pixmap;
                returnValue = CreatePlatformPixmapSurface(dpy, config, native_pixmap_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformPixmapSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformPixmapSurface<T1>(EGLDisplay dpy, EGLConfig config, Span<T1> native_pixmap, ReadOnlySpan<IntPtr> attrib_list)
            where T1 : unmanaged
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                fixed (void* native_pixmap_ptr = native_pixmap)
                {
                    returnValue = CreatePlatformPixmapSurface(dpy, config, native_pixmap_ptr, attrib_list_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformPixmapSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformPixmapSurface<T1>(EGLDisplay dpy, EGLConfig config, T1[] native_pixmap, IntPtr[] attrib_list)
            where T1 : unmanaged
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                fixed (void* native_pixmap_ptr = native_pixmap)
                {
                    returnValue = CreatePlatformPixmapSurface(dpy, config, native_pixmap_ptr, attrib_list_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformPixmapSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformPixmapSurface<T1>(EGLDisplay dpy, EGLConfig config, ref T1 native_pixmap, ref readonly IntPtr attrib_list)
            where T1 : unmanaged
        {
            EGLSurface returnValue;
            fixed (void* native_pixmap_ptr = &native_pixmap)
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePlatformPixmapSurface(dpy, config, native_pixmap_ptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformWindowSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr native_window, ReadOnlySpan<IntPtr> attrib_list)
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                void* native_window_vptr = (void*)native_window;
                returnValue = CreatePlatformWindowSurface(dpy, config, native_window_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformWindowSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr native_window, IntPtr[] attrib_list)
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                void* native_window_vptr = (void*)native_window;
                returnValue = CreatePlatformWindowSurface(dpy, config, native_window_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformWindowSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr native_window, ref readonly IntPtr attrib_list)
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                void* native_window_vptr = (void*)native_window;
                returnValue = CreatePlatformWindowSurface(dpy, config, native_window_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformWindowSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformWindowSurface<T1>(EGLDisplay dpy, EGLConfig config, Span<T1> native_window, ReadOnlySpan<IntPtr> attrib_list)
            where T1 : unmanaged
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                fixed (void* native_window_ptr = native_window)
                {
                    returnValue = CreatePlatformWindowSurface(dpy, config, native_window_ptr, attrib_list_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformWindowSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformWindowSurface<T1>(EGLDisplay dpy, EGLConfig config, T1[] native_window, IntPtr[] attrib_list)
            where T1 : unmanaged
        {
            EGLSurface returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                fixed (void* native_window_ptr = native_window)
                {
                    returnValue = CreatePlatformWindowSurface(dpy, config, native_window_ptr, attrib_list_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePlatformWindowSurface(EGLDisplay, EGLConfig, void*, IntPtr*)"/>
        public static unsafe EGLSurface CreatePlatformWindowSurface<T1>(EGLDisplay dpy, EGLConfig config, ref T1 native_window, ref readonly IntPtr attrib_list)
            where T1 : unmanaged
        {
            EGLSurface returnValue;
            fixed (void* native_window_ptr = &native_window)
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePlatformWindowSurface(dpy, config, native_window_ptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSync(EGLDisplay, SyncType, IntPtr*)"/>
        public static unsafe EGLSync CreateSync(EGLDisplay dpy, SyncType type, ReadOnlySpan<IntPtr> attrib_list)
        {
            EGLSync returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateSync(dpy, type, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSync(EGLDisplay, SyncType, IntPtr*)"/>
        public static unsafe EGLSync CreateSync(EGLDisplay dpy, SyncType type, IntPtr[] attrib_list)
        {
            EGLSync returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateSync(dpy, type, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSync(EGLDisplay, SyncType, IntPtr*)"/>
        public static unsafe EGLSync CreateSync(EGLDisplay dpy, SyncType type, ref readonly IntPtr attrib_list)
        {
            EGLSync returnValue;
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateSync(dpy, type, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindowSurface(EGLDisplay, EGLConfig, IntPtr, int*)"/>
        public static unsafe EGLSurface CreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, ReadOnlySpan<int> attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateWindowSurface(dpy, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindowSurface(EGLDisplay, EGLConfig, IntPtr, int*)"/>
        public static unsafe EGLSurface CreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, int[] attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateWindowSurface(dpy, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindowSurface(EGLDisplay, EGLConfig, IntPtr, int*)"/>
        public static unsafe EGLSurface CreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, ref readonly int attrib_list)
        {
            EGLSurface returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateWindowSurface(dpy, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DestroyContext_(EGLDisplay, EGLContext)"/>
        public static unsafe bool DestroyContext(EGLDisplay dpy, EGLContext ctx)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = DestroyContext_(dpy, ctx);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="DestroyImage_(EGLDisplay, EGLImage)"/>
        public static unsafe bool DestroyImage(EGLDisplay dpy, EGLImage image)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = DestroyImage_(dpy, image);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="DestroySurface_(EGLDisplay, EGLSurface)"/>
        public static unsafe bool DestroySurface(EGLDisplay dpy, EGLSurface surface)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = DestroySurface_(dpy, surface);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="DestroySync_(EGLDisplay, EGLSync)"/>
        public static unsafe bool DestroySync(EGLDisplay dpy, EGLSync sync)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = DestroySync_(dpy, sync);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetConfigAttrib(EGLDisplay, EGLConfig, ConfigAttribute, int*)"/>
        public static unsafe bool GetConfigAttrib(EGLDisplay dpy, EGLConfig config, ConfigAttribute attribute, out int value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = &value)
            {
                int returnValue;
                returnValue = GetConfigAttrib(dpy, config, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetConfigs(EGLDisplay, EGLConfig*, int, int*)"/>
        public static unsafe bool GetConfig(EGLDisplay dpy, Span<EGLConfig> configs, int config_size, out int num_config)
        {
            bool returnValue_bool;
            fixed (int* num_config_ptr = &num_config)
            {
                fixed (EGLConfig* configs_ptr = configs)
                {
                    int returnValue;
                    returnValue = GetConfigs(dpy, configs_ptr, config_size, num_config_ptr);
                    returnValue_bool = returnValue != 0;
                }
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetConfigs(EGLDisplay, EGLConfig*, int, int*)"/>
        public static unsafe bool GetConfig(EGLDisplay dpy, EGLConfig[] configs, int config_size, out int num_config)
        {
            bool returnValue_bool;
            fixed (int* num_config_ptr = &num_config)
            {
                fixed (EGLConfig* configs_ptr = configs)
                {
                    int returnValue;
                    returnValue = GetConfigs(dpy, configs_ptr, config_size, num_config_ptr);
                    returnValue_bool = returnValue != 0;
                }
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetConfigs(EGLDisplay, EGLConfig*, int, int*)"/>
        public static unsafe bool GetConfig(EGLDisplay dpy, ref EGLConfig configs, int config_size, out int num_config)
        {
            bool returnValue_bool;
            fixed (EGLConfig* configs_ptr = &configs)
            fixed (int* num_config_ptr = &num_config)
            {
                int returnValue;
                returnValue = GetConfigs(dpy, configs_ptr, config_size, num_config_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetPlatformDisplay(Platform, void*, IntPtr*)"/>
        public static unsafe EGLDisplay GetPlatformDisplay(Platform platform, IntPtr native_display, ReadOnlySpan<IntPtr> attrib_list)
        {
            EGLDisplay returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                void* native_display_vptr = (void*)native_display;
                returnValue = GetPlatformDisplay(platform, native_display_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformDisplay(Platform, void*, IntPtr*)"/>
        public static unsafe EGLDisplay GetPlatformDisplay(Platform platform, IntPtr native_display, IntPtr[] attrib_list)
        {
            EGLDisplay returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                void* native_display_vptr = (void*)native_display;
                returnValue = GetPlatformDisplay(platform, native_display_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformDisplay(Platform, void*, IntPtr*)"/>
        public static unsafe EGLDisplay GetPlatformDisplay(Platform platform, IntPtr native_display, ref readonly IntPtr attrib_list)
        {
            EGLDisplay returnValue;
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                void* native_display_vptr = (void*)native_display;
                returnValue = GetPlatformDisplay(platform, native_display_vptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformDisplay(Platform, void*, IntPtr*)"/>
        public static unsafe EGLDisplay GetPlatformDisplay<T1>(Platform platform, Span<T1> native_display, ReadOnlySpan<IntPtr> attrib_list)
            where T1 : unmanaged
        {
            EGLDisplay returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                fixed (void* native_display_ptr = native_display)
                {
                    returnValue = GetPlatformDisplay(platform, native_display_ptr, attrib_list_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformDisplay(Platform, void*, IntPtr*)"/>
        public static unsafe EGLDisplay GetPlatformDisplay<T1>(Platform platform, T1[] native_display, IntPtr[] attrib_list)
            where T1 : unmanaged
        {
            EGLDisplay returnValue;
            fixed (IntPtr* attrib_list_ptr = attrib_list)
            {
                fixed (void* native_display_ptr = native_display)
                {
                    returnValue = GetPlatformDisplay(platform, native_display_ptr, attrib_list_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformDisplay(Platform, void*, IntPtr*)"/>
        public static unsafe EGLDisplay GetPlatformDisplay<T1>(Platform platform, ref T1 native_display, ref readonly IntPtr attrib_list)
            where T1 : unmanaged
        {
            EGLDisplay returnValue;
            fixed (void* native_display_ptr = &native_display)
            fixed (IntPtr* attrib_list_ptr = &attrib_list)
            {
                returnValue = GetPlatformDisplay(platform, native_display_ptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe IntPtr GetProcAddress(string procname)
        {
            IntPtr returnValue;
            byte* procname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(procname);
            returnValue = GetProcAddress(procname_ptr);
            Marshal.FreeCoTaskMem((IntPtr)procname_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetSyncAttrib(EGLDisplay, EGLSync, int, IntPtr*)"/>
        public static unsafe bool GetSyncAttrib(EGLDisplay dpy, EGLSync sync, int attribute, Span<IntPtr> value)
        {
            bool returnValue_bool;
            fixed (IntPtr* value_ptr = value)
            {
                int returnValue;
                returnValue = GetSyncAttrib(dpy, sync, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetSyncAttrib(EGLDisplay, EGLSync, int, IntPtr*)"/>
        public static unsafe bool GetSyncAttrib(EGLDisplay dpy, EGLSync sync, int attribute, IntPtr[] value)
        {
            bool returnValue_bool;
            fixed (IntPtr* value_ptr = value)
            {
                int returnValue;
                returnValue = GetSyncAttrib(dpy, sync, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="GetSyncAttrib(EGLDisplay, EGLSync, int, IntPtr*)"/>
        public static unsafe bool GetSyncAttrib(EGLDisplay dpy, EGLSync sync, int attribute, ref IntPtr value)
        {
            bool returnValue_bool;
            fixed (IntPtr* value_ptr = &value)
            {
                int returnValue;
                returnValue = GetSyncAttrib(dpy, sync, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="Initialize(EGLDisplay, int*, int*)"/>
        public static unsafe bool Initialize(EGLDisplay dpy, out int major, out int minor)
        {
            bool returnValue_bool;
            fixed (int* major_ptr = &major)
            fixed (int* minor_ptr = &minor)
            {
                int returnValue;
                returnValue = Initialize(dpy, major_ptr, minor_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="MakeCurrent_(EGLDisplay, EGLSurface, EGLSurface, EGLContext)"/>
        public static unsafe bool MakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = MakeCurrent_(dpy, draw, read, ctx);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="QueryContext(EGLDisplay, EGLContext, ContextQueryAttribute, int*)"/>
        public static unsafe bool QueryContext(EGLDisplay dpy, EGLContext ctx, ContextQueryAttribute attribute, Span<int> value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = value)
            {
                int returnValue;
                returnValue = QueryContext(dpy, ctx, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="QueryContext(EGLDisplay, EGLContext, ContextQueryAttribute, int*)"/>
        public static unsafe bool QueryContext(EGLDisplay dpy, EGLContext ctx, ContextQueryAttribute attribute, int[] value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = value)
            {
                int returnValue;
                returnValue = QueryContext(dpy, ctx, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="QueryContext(EGLDisplay, EGLContext, ContextQueryAttribute, int*)"/>
        public static unsafe bool QueryContext(EGLDisplay dpy, EGLContext ctx, ContextQueryAttribute attribute, ref int value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = &value)
            {
                int returnValue;
                returnValue = QueryContext(dpy, ctx, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="QueryString_(EGLDisplay, StringName)"/>
        public static unsafe string? QueryString(EGLDisplay dpy, StringName name)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = QueryString_(dpy, name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="QuerySurface(EGLDisplay, EGLSurface, SurfaceQueryAttribute, int*)"/>
        public static unsafe bool QuerySurface(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, Span<int> value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = value)
            {
                int returnValue;
                returnValue = QuerySurface(dpy, surface, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="QuerySurface(EGLDisplay, EGLSurface, SurfaceQueryAttribute, int*)"/>
        public static unsafe bool QuerySurface(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, int[] value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = value)
            {
                int returnValue;
                returnValue = QuerySurface(dpy, surface, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="QuerySurface(EGLDisplay, EGLSurface, SurfaceQueryAttribute, int*)"/>
        public static unsafe bool QuerySurface(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, ref int value)
        {
            bool returnValue_bool;
            fixed (int* value_ptr = &value)
            {
                int returnValue;
                returnValue = QuerySurface(dpy, surface, attribute, value_ptr);
                returnValue_bool = returnValue != 0;
            }
            return returnValue_bool;
        }
        /// <inheritdoc cref="ReleaseTexImage_(EGLDisplay, EGLSurface, int)"/>
        public static unsafe bool ReleaseTexImage(EGLDisplay dpy, EGLSurface surface, int buffer)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = ReleaseTexImage_(dpy, surface, buffer);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="ReleaseThread_()"/>
        public static unsafe bool ReleaseThread()
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = ReleaseThread_();
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="SurfaceAttrib_(EGLDisplay, EGLSurface, SurfaceAttribute, int)"/>
        public static unsafe bool SurfaceAttrib(EGLDisplay dpy, EGLSurface surface, SurfaceAttribute attribute, int value)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = SurfaceAttrib_(dpy, surface, attribute, value);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="SwapBuffers_(EGLDisplay, EGLSurface)"/>
        public static unsafe bool SwapBuffers(EGLDisplay dpy, EGLSurface surface)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = SwapBuffers_(dpy, surface);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="SwapInterval_(EGLDisplay, int)"/>
        public static unsafe bool SwapInterval(EGLDisplay dpy, int interval)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = SwapInterval_(dpy, interval);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="Terminate_(EGLDisplay)"/>
        public static unsafe bool Terminate(EGLDisplay dpy)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = Terminate_(dpy);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="WaitClient_()"/>
        public static unsafe bool WaitClient()
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = WaitClient_();
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="WaitGL_()"/>
        public static unsafe bool WaitGL()
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = WaitGL_();
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="WaitNative_(NativeEngine)"/>
        public static unsafe bool WaitNative(NativeEngine engine)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = WaitNative_(engine);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        /// <inheritdoc cref="WaitSync_(EGLDisplay, EGLSync, int)"/>
        public static unsafe bool WaitSync(EGLDisplay dpy, EGLSync sync, int flags)
        {
            bool returnValue_bool;
            int returnValue;
            returnValue = WaitSync_(dpy, sync, flags);
            returnValue_bool = returnValue != 0;
            return returnValue_bool;
        }
        public static unsafe partial class ANDROID
        {
            /// <inheritdoc cref="CreateNativeClientBufferANDROID(int*)"/>
            public static unsafe EGLClientBuffer CreateNativeClientBufferANDROID(ReadOnlySpan<int> attrib_list)
            {
                EGLClientBuffer returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateNativeClientBufferANDROID(attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateNativeClientBufferANDROID(int*)"/>
            public static unsafe EGLClientBuffer CreateNativeClientBufferANDROID(int[] attrib_list)
            {
                EGLClientBuffer returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateNativeClientBufferANDROID(attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateNativeClientBufferANDROID(int*)"/>
            public static unsafe EGLClientBuffer CreateNativeClientBufferANDROID(ref readonly int attrib_list)
            {
                EGLClientBuffer returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateNativeClientBufferANDROID(attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCompositorTimingANDROID(EGLDisplay, EGLSurface, int, int*, long*)"/>
            public static unsafe bool GetCompositorTimingANDROID(EGLDisplay dpy, EGLSurface surface, int numTimestamps, ReadOnlySpan<int> names, Span<long> values)
            {
                bool returnValue_bool;
                fixed (long* values_ptr = values)
                {
                    fixed (int* names_ptr = names)
                    {
                        int returnValue;
                        returnValue = GetCompositorTimingANDROID(dpy, surface, numTimestamps, names_ptr, values_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetCompositorTimingANDROID(EGLDisplay, EGLSurface, int, int*, long*)"/>
            public static unsafe bool GetCompositorTimingANDROID(EGLDisplay dpy, EGLSurface surface, int numTimestamps, int[] names, long[] values)
            {
                bool returnValue_bool;
                fixed (long* values_ptr = values)
                {
                    fixed (int* names_ptr = names)
                    {
                        int returnValue;
                        returnValue = GetCompositorTimingANDROID(dpy, surface, numTimestamps, names_ptr, values_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetCompositorTimingANDROID(EGLDisplay, EGLSurface, int, int*, long*)"/>
            public static unsafe bool GetCompositorTimingANDROID(EGLDisplay dpy, EGLSurface surface, int numTimestamps, ref readonly int names, ref long values)
            {
                bool returnValue_bool;
                fixed (int* names_ptr = &names)
                fixed (long* values_ptr = &values)
                {
                    int returnValue;
                    returnValue = GetCompositorTimingANDROID(dpy, surface, numTimestamps, names_ptr, values_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetCompositorTimingSupportedANDROID_(EGLDisplay, EGLSurface, int)"/>
            public static unsafe bool GetCompositorTimingSupportedANDROID(EGLDisplay dpy, EGLSurface surface, int name)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = GetCompositorTimingSupportedANDROID_(dpy, surface, name);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetFrameTimestampsANDROID(EGLDisplay, EGLSurface, ulong, int, int*, long*)"/>
            public static unsafe bool GetFrameTimestampsANDROID(EGLDisplay dpy, EGLSurface surface, ulong frameId, int numTimestamps, ReadOnlySpan<int> timestamps, Span<long> values)
            {
                bool returnValue_bool;
                fixed (long* values_ptr = values)
                {
                    fixed (int* timestamps_ptr = timestamps)
                    {
                        int returnValue;
                        returnValue = GetFrameTimestampsANDROID(dpy, surface, frameId, numTimestamps, timestamps_ptr, values_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetFrameTimestampsANDROID(EGLDisplay, EGLSurface, ulong, int, int*, long*)"/>
            public static unsafe bool GetFrameTimestampsANDROID(EGLDisplay dpy, EGLSurface surface, ulong frameId, int numTimestamps, int[] timestamps, long[] values)
            {
                bool returnValue_bool;
                fixed (long* values_ptr = values)
                {
                    fixed (int* timestamps_ptr = timestamps)
                    {
                        int returnValue;
                        returnValue = GetFrameTimestampsANDROID(dpy, surface, frameId, numTimestamps, timestamps_ptr, values_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetFrameTimestampsANDROID(EGLDisplay, EGLSurface, ulong, int, int*, long*)"/>
            public static unsafe bool GetFrameTimestampsANDROID(EGLDisplay dpy, EGLSurface surface, ulong frameId, int numTimestamps, ref readonly int timestamps, ref long values)
            {
                bool returnValue_bool;
                fixed (int* timestamps_ptr = &timestamps)
                fixed (long* values_ptr = &values)
                {
                    int returnValue;
                    returnValue = GetFrameTimestampsANDROID(dpy, surface, frameId, numTimestamps, timestamps_ptr, values_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetFrameTimestampSupportedANDROID_(EGLDisplay, EGLSurface, int)"/>
            public static unsafe bool GetFrameTimestampSupportedANDROID(EGLDisplay dpy, EGLSurface surface, int timestamp)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = GetFrameTimestampSupportedANDROID_(dpy, surface, timestamp);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetNextFrameIdANDROID(EGLDisplay, EGLSurface, ulong*)"/>
            public static unsafe bool GetNextFrameIdANDROID(EGLDisplay dpy, EGLSurface surface, Span<ulong> frameId)
            {
                bool returnValue_bool;
                fixed (ulong* frameId_ptr = frameId)
                {
                    int returnValue;
                    returnValue = GetNextFrameIdANDROID(dpy, surface, frameId_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetNextFrameIdANDROID(EGLDisplay, EGLSurface, ulong*)"/>
            public static unsafe bool GetNextFrameIdANDROID(EGLDisplay dpy, EGLSurface surface, ulong[] frameId)
            {
                bool returnValue_bool;
                fixed (ulong* frameId_ptr = frameId)
                {
                    int returnValue;
                    returnValue = GetNextFrameIdANDROID(dpy, surface, frameId_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetNextFrameIdANDROID(EGLDisplay, EGLSurface, ulong*)"/>
            public static unsafe bool GetNextFrameIdANDROID(EGLDisplay dpy, EGLSurface surface, ref ulong frameId)
            {
                bool returnValue_bool;
                fixed (ulong* frameId_ptr = &frameId)
                {
                    int returnValue;
                    returnValue = GetNextFrameIdANDROID(dpy, surface, frameId_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="PresentationTimeANDROID_(EGLDisplay, EGLSurface, long)"/>
            public static unsafe bool PresentationTimeANDROID(EGLDisplay dpy, EGLSurface surface, long time)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = PresentationTimeANDROID_(dpy, surface, time);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetBlobCacheFuncsANDROID(EGLDisplay, IntPtr, IntPtr)"/>
            public static unsafe void SetBlobCacheFuncsANDROID(EGLDisplay dpy, EGLSetBlobFuncANDROID set, EGLGetBlobFuncANDROID get)
            {
                IntPtr set_ptr = Marshal.GetFunctionPointerForDelegate(set);
                IntPtr get_ptr = Marshal.GetFunctionPointerForDelegate(get);
                SetBlobCacheFuncsANDROID(dpy, set_ptr, get_ptr);
            }
        }
        public static unsafe partial class ANGLE
        {
            /// <inheritdoc cref="CreateDeviceANGLE(int, void*, IntPtr*)"/>
            public static unsafe EGLDeviceEXT CreateDeviceANGLE(int device_type, IntPtr native_device, ReadOnlySpan<IntPtr> attrib_list)
            {
                EGLDeviceEXT returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    void* native_device_vptr = (void*)native_device;
                    returnValue = CreateDeviceANGLE(device_type, native_device_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDeviceANGLE(int, void*, IntPtr*)"/>
            public static unsafe EGLDeviceEXT CreateDeviceANGLE(int device_type, IntPtr native_device, IntPtr[] attrib_list)
            {
                EGLDeviceEXT returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    void* native_device_vptr = (void*)native_device;
                    returnValue = CreateDeviceANGLE(device_type, native_device_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDeviceANGLE(int, void*, IntPtr*)"/>
            public static unsafe EGLDeviceEXT CreateDeviceANGLE(int device_type, IntPtr native_device, ref readonly IntPtr attrib_list)
            {
                EGLDeviceEXT returnValue;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    void* native_device_vptr = (void*)native_device;
                    returnValue = CreateDeviceANGLE(device_type, native_device_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDeviceANGLE(int, void*, IntPtr*)"/>
            public static unsafe EGLDeviceEXT CreateDeviceANGLE<T1>(int device_type, Span<T1> native_device, ReadOnlySpan<IntPtr> attrib_list)
                where T1 : unmanaged
            {
                EGLDeviceEXT returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_device_ptr = native_device)
                    {
                        returnValue = CreateDeviceANGLE(device_type, native_device_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDeviceANGLE(int, void*, IntPtr*)"/>
            public static unsafe EGLDeviceEXT CreateDeviceANGLE<T1>(int device_type, T1[] native_device, IntPtr[] attrib_list)
                where T1 : unmanaged
            {
                EGLDeviceEXT returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_device_ptr = native_device)
                    {
                        returnValue = CreateDeviceANGLE(device_type, native_device_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDeviceANGLE(int, void*, IntPtr*)"/>
            public static unsafe EGLDeviceEXT CreateDeviceANGLE<T1>(int device_type, ref T1 native_device, ref readonly IntPtr attrib_list)
                where T1 : unmanaged
            {
                EGLDeviceEXT returnValue;
                fixed (void* native_device_ptr = &native_device)
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateDeviceANGLE(device_type, native_device_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamProducerD3DTextureANGLE(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool CreateStreamProducerD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = CreateStreamProducerD3DTextureANGLE(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CreateStreamProducerD3DTextureANGLE(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool CreateStreamProducerD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = CreateStreamProducerD3DTextureANGLE(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CreateStreamProducerD3DTextureANGLE(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool CreateStreamProducerD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = CreateStreamProducerD3DTextureANGLE(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportVkImageANGLE(EGLDisplay, EGLImage, void*, void*)"/>
            public static unsafe bool ExportVkImageANGLE(EGLDisplay dpy, EGLImage image, IntPtr vk_image, IntPtr vk_image_create_info)
            {
                bool returnValue_bool;
                void* vk_image_vptr = (void*)vk_image;
                void* vk_image_create_info_vptr = (void*)vk_image_create_info;
                int returnValue;
                returnValue = ExportVkImageANGLE(dpy, image, vk_image_vptr, vk_image_create_info_vptr);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportVkImageANGLE(EGLDisplay, EGLImage, void*, void*)"/>
            public static unsafe bool ExportVkImageANGLE<T1, T2>(EGLDisplay dpy, EGLImage image, Span<T1> vk_image, Span<T2> vk_image_create_info)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* vk_image_create_info_ptr = vk_image_create_info)
                {
                    fixed (void* vk_image_ptr = vk_image)
                    {
                        int returnValue;
                        returnValue = ExportVkImageANGLE(dpy, image, vk_image_ptr, vk_image_create_info_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportVkImageANGLE(EGLDisplay, EGLImage, void*, void*)"/>
            public static unsafe bool ExportVkImageANGLE<T1, T2>(EGLDisplay dpy, EGLImage image, T1[] vk_image, T2[] vk_image_create_info)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* vk_image_create_info_ptr = vk_image_create_info)
                {
                    fixed (void* vk_image_ptr = vk_image)
                    {
                        int returnValue;
                        returnValue = ExportVkImageANGLE(dpy, image, vk_image_ptr, vk_image_create_info_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportVkImageANGLE(EGLDisplay, EGLImage, void*, void*)"/>
            public static unsafe bool ExportVkImageANGLE<T1, T2>(EGLDisplay dpy, EGLImage image, ref T1 vk_image, ref T2 vk_image_create_info)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* vk_image_ptr = &vk_image)
                fixed (void* vk_image_create_info_ptr = &vk_image_create_info)
                {
                    int returnValue;
                    returnValue = ExportVkImageANGLE(dpy, image, vk_image_ptr, vk_image_create_info_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetMscRateANGLE(EGLDisplay, EGLSurface, int*, int*)"/>
            public static unsafe bool GetMscRateANGLE(EGLDisplay dpy, EGLSurface surface, Span<int> numerator, Span<int> denominator)
            {
                bool returnValue_bool;
                fixed (int* denominator_ptr = denominator)
                {
                    fixed (int* numerator_ptr = numerator)
                    {
                        int returnValue;
                        returnValue = GetMscRateANGLE(dpy, surface, numerator_ptr, denominator_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetMscRateANGLE(EGLDisplay, EGLSurface, int*, int*)"/>
            public static unsafe bool GetMscRateANGLE(EGLDisplay dpy, EGLSurface surface, int[] numerator, int[] denominator)
            {
                bool returnValue_bool;
                fixed (int* denominator_ptr = denominator)
                {
                    fixed (int* numerator_ptr = numerator)
                    {
                        int returnValue;
                        returnValue = GetMscRateANGLE(dpy, surface, numerator_ptr, denominator_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetMscRateANGLE(EGLDisplay, EGLSurface, int*, int*)"/>
            public static unsafe bool GetMscRateANGLE(EGLDisplay dpy, EGLSurface surface, ref int numerator, ref int denominator)
            {
                bool returnValue_bool;
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    int returnValue;
                    returnValue = GetMscRateANGLE(dpy, surface, numerator_ptr, denominator_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="PrepareSwapBuffersANGLE_(EGLDisplay, EGLSurface)"/>
            public static unsafe bool PrepareSwapBuffersANGLE(EGLDisplay dpy, EGLSurface surface)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = PrepareSwapBuffersANGLE_(dpy, surface);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="ProgramCachePopulateANGLE(EGLDisplay, void*, int, void*, int)"/>
            public static unsafe void ProgramCachePopulateANGLE(EGLDisplay dpy, IntPtr key, int keysize, IntPtr binary, int binarysize)
            {
                void* key_vptr = (void*)key;
                void* binary_vptr = (void*)binary;
                ProgramCachePopulateANGLE(dpy, key_vptr, keysize, binary_vptr, binarysize);
            }
            /// <inheritdoc cref="ProgramCachePopulateANGLE(EGLDisplay, void*, int, void*, int)"/>
            public static unsafe void ProgramCachePopulateANGLE<T1, T2>(EGLDisplay dpy, ReadOnlySpan<T1> key, int keysize, ReadOnlySpan<T2> binary, int binarysize)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* binary_ptr = binary)
                {
                    fixed (void* key_ptr = key)
                    {
                        ProgramCachePopulateANGLE(dpy, key_ptr, keysize, binary_ptr, binarysize);
                    }
                }
            }
            /// <inheritdoc cref="ProgramCachePopulateANGLE(EGLDisplay, void*, int, void*, int)"/>
            public static unsafe void ProgramCachePopulateANGLE<T1, T2>(EGLDisplay dpy, T1[] key, int keysize, T2[] binary, int binarysize)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* binary_ptr = binary)
                {
                    fixed (void* key_ptr = key)
                    {
                        ProgramCachePopulateANGLE(dpy, key_ptr, keysize, binary_ptr, binarysize);
                    }
                }
            }
            /// <inheritdoc cref="ProgramCachePopulateANGLE(EGLDisplay, void*, int, void*, int)"/>
            public static unsafe void ProgramCachePopulateANGLE<T1, T2>(EGLDisplay dpy, ref readonly T1 key, int keysize, ref readonly T2 binary, int binarysize)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* key_ptr = &key)
                fixed (void* binary_ptr = &binary)
                {
                    ProgramCachePopulateANGLE(dpy, key_ptr, keysize, binary_ptr, binarysize);
                }
            }
            /// <inheritdoc cref="ProgramCacheQueryANGLE(EGLDisplay, int, void*, int*, void*, int*)"/>
            public static unsafe void ProgramCacheQueryANGLE(EGLDisplay dpy, int index, IntPtr key, Span<int> keysize, IntPtr binary, Span<int> binarysize)
            {
                fixed (int* binarysize_ptr = binarysize)
                {
                    fixed (int* keysize_ptr = keysize)
                    {
                        void* key_vptr = (void*)key;
                        void* binary_vptr = (void*)binary;
                        ProgramCacheQueryANGLE(dpy, index, key_vptr, keysize_ptr, binary_vptr, binarysize_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ProgramCacheQueryANGLE(EGLDisplay, int, void*, int*, void*, int*)"/>
            public static unsafe void ProgramCacheQueryANGLE(EGLDisplay dpy, int index, IntPtr key, int[] keysize, IntPtr binary, int[] binarysize)
            {
                fixed (int* binarysize_ptr = binarysize)
                {
                    fixed (int* keysize_ptr = keysize)
                    {
                        void* key_vptr = (void*)key;
                        void* binary_vptr = (void*)binary;
                        ProgramCacheQueryANGLE(dpy, index, key_vptr, keysize_ptr, binary_vptr, binarysize_ptr);
                    }
                }
            }
            /// <inheritdoc cref="ProgramCacheQueryANGLE(EGLDisplay, int, void*, int*, void*, int*)"/>
            public static unsafe void ProgramCacheQueryANGLE(EGLDisplay dpy, int index, IntPtr key, ref int keysize, IntPtr binary, ref int binarysize)
            {
                fixed (int* keysize_ptr = &keysize)
                fixed (int* binarysize_ptr = &binarysize)
                {
                    void* key_vptr = (void*)key;
                    void* binary_vptr = (void*)binary;
                    ProgramCacheQueryANGLE(dpy, index, key_vptr, keysize_ptr, binary_vptr, binarysize_ptr);
                }
            }
            /// <inheritdoc cref="ProgramCacheQueryANGLE(EGLDisplay, int, void*, int*, void*, int*)"/>
            public static unsafe void ProgramCacheQueryANGLE<T1, T2>(EGLDisplay dpy, int index, Span<T1> key, Span<int> keysize, Span<T2> binary, Span<int> binarysize)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (int* binarysize_ptr = binarysize)
                {
                    fixed (void* binary_ptr = binary)
                    {
                        fixed (int* keysize_ptr = keysize)
                        {
                            fixed (void* key_ptr = key)
                            {
                                ProgramCacheQueryANGLE(dpy, index, key_ptr, keysize_ptr, binary_ptr, binarysize_ptr);
                            }
                        }
                    }
                }
            }
            /// <inheritdoc cref="ProgramCacheQueryANGLE(EGLDisplay, int, void*, int*, void*, int*)"/>
            public static unsafe void ProgramCacheQueryANGLE<T1, T2>(EGLDisplay dpy, int index, T1[] key, int[] keysize, T2[] binary, int[] binarysize)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (int* binarysize_ptr = binarysize)
                {
                    fixed (void* binary_ptr = binary)
                    {
                        fixed (int* keysize_ptr = keysize)
                        {
                            fixed (void* key_ptr = key)
                            {
                                ProgramCacheQueryANGLE(dpy, index, key_ptr, keysize_ptr, binary_ptr, binarysize_ptr);
                            }
                        }
                    }
                }
            }
            /// <inheritdoc cref="ProgramCacheQueryANGLE(EGLDisplay, int, void*, int*, void*, int*)"/>
            public static unsafe void ProgramCacheQueryANGLE<T1, T2>(EGLDisplay dpy, int index, ref T1 key, ref int keysize, ref T2 binary, ref int binarysize)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* key_ptr = &key)
                fixed (int* keysize_ptr = &keysize)
                fixed (void* binary_ptr = &binary)
                fixed (int* binarysize_ptr = &binarysize)
                {
                    ProgramCacheQueryANGLE(dpy, index, key_ptr, keysize_ptr, binary_ptr, binarysize_ptr);
                }
            }
            /// <inheritdoc cref="QueryDisplayAttribANGLE(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribANGLE(EGLDisplay dpy, int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribANGLE(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribANGLE(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribANGLE(EGLDisplay dpy, int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribANGLE(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribANGLE(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribANGLE(EGLDisplay dpy, int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribANGLE(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStringiANGLE_(EGLDisplay, int, int)"/>
            public static unsafe string? QueryStringiANGLE(EGLDisplay dpy, int name, int index)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryStringiANGLE_(dpy, name, index);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QuerySurfacePointerANGLE_(EGLDisplay, EGLSurface, SurfaceQueryAttribute, void**)"/>
            public static unsafe bool QuerySurfacePointerANGLE(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, void** value)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = QuerySurfacePointerANGLE_(dpy, surface, attribute, value);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="ReleaseDeviceANGLE_(EGLDeviceEXT)"/>
            public static unsafe bool ReleaseDeviceANGLE(EGLDeviceEXT device)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = ReleaseDeviceANGLE_(device);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamPostD3DTextureANGLE(EGLDisplay, EGLStreamKHR, void*, IntPtr*)"/>
            public static unsafe bool StreamPostD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, IntPtr texture, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    void* texture_vptr = (void*)texture;
                    int returnValue;
                    returnValue = StreamPostD3DTextureANGLE(dpy, stream, texture_vptr, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamPostD3DTextureANGLE(EGLDisplay, EGLStreamKHR, void*, IntPtr*)"/>
            public static unsafe bool StreamPostD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, IntPtr texture, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    void* texture_vptr = (void*)texture;
                    int returnValue;
                    returnValue = StreamPostD3DTextureANGLE(dpy, stream, texture_vptr, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamPostD3DTextureANGLE(EGLDisplay, EGLStreamKHR, void*, IntPtr*)"/>
            public static unsafe bool StreamPostD3DTextureANGLE(EGLDisplay dpy, EGLStreamKHR stream, IntPtr texture, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    void* texture_vptr = (void*)texture;
                    int returnValue;
                    returnValue = StreamPostD3DTextureANGLE(dpy, stream, texture_vptr, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamPostD3DTextureANGLE(EGLDisplay, EGLStreamKHR, void*, IntPtr*)"/>
            public static unsafe bool StreamPostD3DTextureANGLE<T1>(EGLDisplay dpy, EGLStreamKHR stream, Span<T1> texture, ReadOnlySpan<IntPtr> attrib_list)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    fixed (void* texture_ptr = texture)
                    {
                        int returnValue;
                        returnValue = StreamPostD3DTextureANGLE(dpy, stream, texture_ptr, attrib_list_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamPostD3DTextureANGLE(EGLDisplay, EGLStreamKHR, void*, IntPtr*)"/>
            public static unsafe bool StreamPostD3DTextureANGLE<T1>(EGLDisplay dpy, EGLStreamKHR stream, T1[] texture, IntPtr[] attrib_list)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    fixed (void* texture_ptr = texture)
                    {
                        int returnValue;
                        returnValue = StreamPostD3DTextureANGLE(dpy, stream, texture_ptr, attrib_list_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamPostD3DTextureANGLE(EGLDisplay, EGLStreamKHR, void*, IntPtr*)"/>
            public static unsafe bool StreamPostD3DTextureANGLE<T1>(EGLDisplay dpy, EGLStreamKHR stream, ref T1 texture, ref readonly IntPtr attrib_list)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* texture_ptr = &texture)
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = StreamPostD3DTextureANGLE(dpy, stream, texture_ptr, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithFrameTokenANGLE_(EGLDisplay, EGLSurface, ulong)"/>
            public static unsafe bool SwapBuffersWithFrameTokenANGLE(EGLDisplay dpy, EGLSurface surface, ulong frametoken)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = SwapBuffersWithFrameTokenANGLE_(dpy, surface, frametoken);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
        }
        public static unsafe partial class CHROMIUM
        {
            /// <inheritdoc cref="GetSyncValuesCHROMIUM(EGLDisplay, EGLSurface, ulong*, ulong*, ulong*)"/>
            public static unsafe bool GetSyncValuesCHROMIUM(EGLDisplay dpy, EGLSurface surface, Span<ulong> ust, Span<ulong> msc, Span<ulong> sbc)
            {
                bool returnValue_bool;
                fixed (ulong* sbc_ptr = sbc)
                {
                    fixed (ulong* msc_ptr = msc)
                    {
                        fixed (ulong* ust_ptr = ust)
                        {
                            int returnValue;
                            returnValue = GetSyncValuesCHROMIUM(dpy, surface, ust_ptr, msc_ptr, sbc_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncValuesCHROMIUM(EGLDisplay, EGLSurface, ulong*, ulong*, ulong*)"/>
            public static unsafe bool GetSyncValuesCHROMIUM(EGLDisplay dpy, EGLSurface surface, ulong[] ust, ulong[] msc, ulong[] sbc)
            {
                bool returnValue_bool;
                fixed (ulong* sbc_ptr = sbc)
                {
                    fixed (ulong* msc_ptr = msc)
                    {
                        fixed (ulong* ust_ptr = ust)
                        {
                            int returnValue;
                            returnValue = GetSyncValuesCHROMIUM(dpy, surface, ust_ptr, msc_ptr, sbc_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncValuesCHROMIUM(EGLDisplay, EGLSurface, ulong*, ulong*, ulong*)"/>
            public static unsafe bool GetSyncValuesCHROMIUM(EGLDisplay dpy, EGLSurface surface, ref ulong ust, ref ulong msc, ref ulong sbc)
            {
                bool returnValue_bool;
                fixed (ulong* ust_ptr = &ust)
                fixed (ulong* msc_ptr = &msc)
                fixed (ulong* sbc_ptr = &sbc)
                {
                    int returnValue;
                    returnValue = GetSyncValuesCHROMIUM(dpy, surface, ust_ptr, msc_ptr, sbc_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="ClientSignalSyncEXT(EGLDisplay, EGLSync, IntPtr*)"/>
            public static unsafe bool ClientSignalSyncEXT(EGLDisplay dpy, EGLSync sync, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = ClientSignalSyncEXT(dpy, sync, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ClientSignalSyncEXT(EGLDisplay, EGLSync, IntPtr*)"/>
            public static unsafe bool ClientSignalSyncEXT(EGLDisplay dpy, EGLSync sync, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = ClientSignalSyncEXT(dpy, sync, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ClientSignalSyncEXT(EGLDisplay, EGLSync, IntPtr*)"/>
            public static unsafe bool ClientSignalSyncEXT(EGLDisplay dpy, EGLSync sync, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = ClientSignalSyncEXT(dpy, sync, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorBindTexWindowEXT_(int)"/>
            public static unsafe bool CompositorBindTexWindowEXT(int external_win_id)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = CompositorBindTexWindowEXT_(external_win_id);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetContextAttributesEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetContextAttributesEXT(int external_ref_id, ReadOnlySpan<int> context_attributes, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* context_attributes_ptr = context_attributes)
                {
                    int returnValue;
                    returnValue = CompositorSetContextAttributesEXT(external_ref_id, context_attributes_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetContextAttributesEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetContextAttributesEXT(int external_ref_id, int[] context_attributes, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* context_attributes_ptr = context_attributes)
                {
                    int returnValue;
                    returnValue = CompositorSetContextAttributesEXT(external_ref_id, context_attributes_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetContextAttributesEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetContextAttributesEXT(int external_ref_id, ref readonly int context_attributes, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* context_attributes_ptr = &context_attributes)
                {
                    int returnValue;
                    returnValue = CompositorSetContextAttributesEXT(external_ref_id, context_attributes_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetContextListEXT(int*, int)"/>
            public static unsafe bool CompositorSetContextListEXT(ReadOnlySpan<int> external_ref_ids, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* external_ref_ids_ptr = external_ref_ids)
                {
                    int returnValue;
                    returnValue = CompositorSetContextListEXT(external_ref_ids_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetContextListEXT(int*, int)"/>
            public static unsafe bool CompositorSetContextListEXT(int[] external_ref_ids, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* external_ref_ids_ptr = external_ref_ids)
                {
                    int returnValue;
                    returnValue = CompositorSetContextListEXT(external_ref_ids_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetContextListEXT(int*, int)"/>
            public static unsafe bool CompositorSetContextListEXT(ref readonly int external_ref_ids, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* external_ref_ids_ptr = &external_ref_ids)
                {
                    int returnValue;
                    returnValue = CompositorSetContextListEXT(external_ref_ids_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetSizeEXT_(int, int, int)"/>
            public static unsafe bool CompositorSetSizeEXT(int external_win_id, int width, int height)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = CompositorSetSizeEXT_(external_win_id, width, height);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetWindowAttributesEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetWindowAttributesEXT(int external_win_id, ReadOnlySpan<int> window_attributes, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* window_attributes_ptr = window_attributes)
                {
                    int returnValue;
                    returnValue = CompositorSetWindowAttributesEXT(external_win_id, window_attributes_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetWindowAttributesEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetWindowAttributesEXT(int external_win_id, int[] window_attributes, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* window_attributes_ptr = window_attributes)
                {
                    int returnValue;
                    returnValue = CompositorSetWindowAttributesEXT(external_win_id, window_attributes_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetWindowAttributesEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetWindowAttributesEXT(int external_win_id, ref readonly int window_attributes, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* window_attributes_ptr = &window_attributes)
                {
                    int returnValue;
                    returnValue = CompositorSetWindowAttributesEXT(external_win_id, window_attributes_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetWindowListEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetWindowListEXT(int external_ref_id, ReadOnlySpan<int> external_win_ids, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* external_win_ids_ptr = external_win_ids)
                {
                    int returnValue;
                    returnValue = CompositorSetWindowListEXT(external_ref_id, external_win_ids_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetWindowListEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetWindowListEXT(int external_ref_id, int[] external_win_ids, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* external_win_ids_ptr = external_win_ids)
                {
                    int returnValue;
                    returnValue = CompositorSetWindowListEXT(external_ref_id, external_win_ids_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSetWindowListEXT(int, int*, int)"/>
            public static unsafe bool CompositorSetWindowListEXT(int external_ref_id, ref readonly int external_win_ids, int num_entries)
            {
                bool returnValue_bool;
                fixed (int* external_win_ids_ptr = &external_win_ids)
                {
                    int returnValue;
                    returnValue = CompositorSetWindowListEXT(external_ref_id, external_win_ids_ptr, num_entries);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="CompositorSwapPolicyEXT_(int, int)"/>
            public static unsafe bool CompositorSwapPolicyEXT(int external_win_id, int policy)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = CompositorSwapPolicyEXT_(external_win_id, policy);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="CreatePlatformPixmapSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformPixmapSurfaceEXT(EGLDisplay dpy, EGLConfig config, IntPtr native_pixmap, ReadOnlySpan<int> attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    void* native_pixmap_vptr = (void*)native_pixmap;
                    returnValue = CreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformPixmapSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformPixmapSurfaceEXT(EGLDisplay dpy, EGLConfig config, IntPtr native_pixmap, int[] attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    void* native_pixmap_vptr = (void*)native_pixmap;
                    returnValue = CreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformPixmapSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformPixmapSurfaceEXT(EGLDisplay dpy, EGLConfig config, IntPtr native_pixmap, ref readonly int attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* native_pixmap_vptr = (void*)native_pixmap;
                    returnValue = CreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformPixmapSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformPixmapSurfaceEXT<T1>(EGLDisplay dpy, EGLConfig config, Span<T1> native_pixmap, ReadOnlySpan<int> attrib_list)
                where T1 : unmanaged
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_pixmap_ptr = native_pixmap)
                    {
                        returnValue = CreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformPixmapSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformPixmapSurfaceEXT<T1>(EGLDisplay dpy, EGLConfig config, T1[] native_pixmap, int[] attrib_list)
                where T1 : unmanaged
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_pixmap_ptr = native_pixmap)
                    {
                        returnValue = CreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformPixmapSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformPixmapSurfaceEXT<T1>(EGLDisplay dpy, EGLConfig config, ref T1 native_pixmap, ref readonly int attrib_list)
                where T1 : unmanaged
            {
                EGLSurface returnValue;
                fixed (void* native_pixmap_ptr = &native_pixmap)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreatePlatformPixmapSurfaceEXT(dpy, config, native_pixmap_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformWindowSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformWindowSurfaceEXT(EGLDisplay dpy, EGLConfig config, IntPtr native_window, ReadOnlySpan<int> attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    void* native_window_vptr = (void*)native_window;
                    returnValue = CreatePlatformWindowSurfaceEXT(dpy, config, native_window_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformWindowSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformWindowSurfaceEXT(EGLDisplay dpy, EGLConfig config, IntPtr native_window, int[] attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    void* native_window_vptr = (void*)native_window;
                    returnValue = CreatePlatformWindowSurfaceEXT(dpy, config, native_window_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformWindowSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformWindowSurfaceEXT(EGLDisplay dpy, EGLConfig config, IntPtr native_window, ref readonly int attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* native_window_vptr = (void*)native_window;
                    returnValue = CreatePlatformWindowSurfaceEXT(dpy, config, native_window_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformWindowSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformWindowSurfaceEXT<T1>(EGLDisplay dpy, EGLConfig config, Span<T1> native_window, ReadOnlySpan<int> attrib_list)
                where T1 : unmanaged
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_window_ptr = native_window)
                    {
                        returnValue = CreatePlatformWindowSurfaceEXT(dpy, config, native_window_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformWindowSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformWindowSurfaceEXT<T1>(EGLDisplay dpy, EGLConfig config, T1[] native_window, int[] attrib_list)
                where T1 : unmanaged
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_window_ptr = native_window)
                    {
                        returnValue = CreatePlatformWindowSurfaceEXT(dpy, config, native_window_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePlatformWindowSurfaceEXT(EGLDisplay, EGLConfig, void*, int*)"/>
            public static unsafe EGLSurface CreatePlatformWindowSurfaceEXT<T1>(EGLDisplay dpy, EGLConfig config, ref T1 native_window, ref readonly int attrib_list)
                where T1 : unmanaged
            {
                EGLSurface returnValue;
                fixed (void* native_window_ptr = &native_window)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreatePlatformWindowSurfaceEXT(dpy, config, native_window_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DestroyDisplayEXT_(EGLDisplay)"/>
            public static unsafe bool DestroyDisplayEXT(EGLDisplay dpy)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = DestroyDisplayEXT_(dpy);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetOutputLayersEXT(EGLDisplay, IntPtr*, EGLOutputLayerEXT*, int, int*)"/>
            public static unsafe bool GetOutputLayersEXT(EGLDisplay dpy, ReadOnlySpan<IntPtr> attrib_list, Span<EGLOutputLayerEXT> layers, int max_layers, Span<int> num_layers)
            {
                bool returnValue_bool;
                fixed (int* num_layers_ptr = num_layers)
                {
                    fixed (EGLOutputLayerEXT* layers_ptr = layers)
                    {
                        fixed (IntPtr* attrib_list_ptr = attrib_list)
                        {
                            int returnValue;
                            returnValue = GetOutputLayersEXT(dpy, attrib_list_ptr, layers_ptr, max_layers, num_layers_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetOutputLayersEXT(EGLDisplay, IntPtr*, EGLOutputLayerEXT*, int, int*)"/>
            public static unsafe bool GetOutputLayersEXT(EGLDisplay dpy, IntPtr[] attrib_list, EGLOutputLayerEXT[] layers, int max_layers, int[] num_layers)
            {
                bool returnValue_bool;
                fixed (int* num_layers_ptr = num_layers)
                {
                    fixed (EGLOutputLayerEXT* layers_ptr = layers)
                    {
                        fixed (IntPtr* attrib_list_ptr = attrib_list)
                        {
                            int returnValue;
                            returnValue = GetOutputLayersEXT(dpy, attrib_list_ptr, layers_ptr, max_layers, num_layers_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetOutputLayersEXT(EGLDisplay, IntPtr*, EGLOutputLayerEXT*, int, int*)"/>
            public static unsafe bool GetOutputLayersEXT(EGLDisplay dpy, ref readonly IntPtr attrib_list, ref EGLOutputLayerEXT layers, int max_layers, ref int num_layers)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                fixed (EGLOutputLayerEXT* layers_ptr = &layers)
                fixed (int* num_layers_ptr = &num_layers)
                {
                    int returnValue;
                    returnValue = GetOutputLayersEXT(dpy, attrib_list_ptr, layers_ptr, max_layers, num_layers_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetOutputPortsEXT(EGLDisplay, IntPtr*, EGLOutputPortEXT*, int, int*)"/>
            public static unsafe bool GetOutputPortsEXT(EGLDisplay dpy, ReadOnlySpan<IntPtr> attrib_list, Span<EGLOutputPortEXT> ports, int max_ports, Span<int> num_ports)
            {
                bool returnValue_bool;
                fixed (int* num_ports_ptr = num_ports)
                {
                    fixed (EGLOutputPortEXT* ports_ptr = ports)
                    {
                        fixed (IntPtr* attrib_list_ptr = attrib_list)
                        {
                            int returnValue;
                            returnValue = GetOutputPortsEXT(dpy, attrib_list_ptr, ports_ptr, max_ports, num_ports_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetOutputPortsEXT(EGLDisplay, IntPtr*, EGLOutputPortEXT*, int, int*)"/>
            public static unsafe bool GetOutputPortsEXT(EGLDisplay dpy, IntPtr[] attrib_list, EGLOutputPortEXT[] ports, int max_ports, int[] num_ports)
            {
                bool returnValue_bool;
                fixed (int* num_ports_ptr = num_ports)
                {
                    fixed (EGLOutputPortEXT* ports_ptr = ports)
                    {
                        fixed (IntPtr* attrib_list_ptr = attrib_list)
                        {
                            int returnValue;
                            returnValue = GetOutputPortsEXT(dpy, attrib_list_ptr, ports_ptr, max_ports, num_ports_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetOutputPortsEXT(EGLDisplay, IntPtr*, EGLOutputPortEXT*, int, int*)"/>
            public static unsafe bool GetOutputPortsEXT(EGLDisplay dpy, ref readonly IntPtr attrib_list, ref EGLOutputPortEXT ports, int max_ports, ref int num_ports)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                fixed (EGLOutputPortEXT* ports_ptr = &ports)
                fixed (int* num_ports_ptr = &num_ports)
                {
                    int returnValue;
                    returnValue = GetOutputPortsEXT(dpy, attrib_list_ptr, ports_ptr, max_ports, num_ports_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetPlatformDisplayEXT(Platform, void*, int*)"/>
            public static unsafe EGLDisplay GetPlatformDisplayEXT(Platform platform, IntPtr native_display, ReadOnlySpan<int> attrib_list)
            {
                EGLDisplay returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    void* native_display_vptr = (void*)native_display;
                    returnValue = GetPlatformDisplayEXT(platform, native_display_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPlatformDisplayEXT(Platform, void*, int*)"/>
            public static unsafe EGLDisplay GetPlatformDisplayEXT(Platform platform, IntPtr native_display, int[] attrib_list)
            {
                EGLDisplay returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    void* native_display_vptr = (void*)native_display;
                    returnValue = GetPlatformDisplayEXT(platform, native_display_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPlatformDisplayEXT(Platform, void*, int*)"/>
            public static unsafe EGLDisplay GetPlatformDisplayEXT(Platform platform, IntPtr native_display, ref readonly int attrib_list)
            {
                EGLDisplay returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* native_display_vptr = (void*)native_display;
                    returnValue = GetPlatformDisplayEXT(platform, native_display_vptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPlatformDisplayEXT(Platform, void*, int*)"/>
            public static unsafe EGLDisplay GetPlatformDisplayEXT<T1>(Platform platform, Span<T1> native_display, ReadOnlySpan<int> attrib_list)
                where T1 : unmanaged
            {
                EGLDisplay returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_display_ptr = native_display)
                    {
                        returnValue = GetPlatformDisplayEXT(platform, native_display_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPlatformDisplayEXT(Platform, void*, int*)"/>
            public static unsafe EGLDisplay GetPlatformDisplayEXT<T1>(Platform platform, T1[] native_display, int[] attrib_list)
                where T1 : unmanaged
            {
                EGLDisplay returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    fixed (void* native_display_ptr = native_display)
                    {
                        returnValue = GetPlatformDisplayEXT(platform, native_display_ptr, attrib_list_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPlatformDisplayEXT(Platform, void*, int*)"/>
            public static unsafe EGLDisplay GetPlatformDisplayEXT<T1>(Platform platform, ref T1 native_display, ref readonly int attrib_list)
                where T1 : unmanaged
            {
                EGLDisplay returnValue;
                fixed (void* native_display_ptr = &native_display)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = GetPlatformDisplayEXT(platform, native_display_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="OutputLayerAttribEXT_(EGLDisplay, EGLOutputLayerEXT, int, IntPtr)"/>
            public static unsafe bool OutputLayerAttribEXT(EGLDisplay dpy, EGLOutputLayerEXT layer, int attribute, IntPtr value)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = OutputLayerAttribEXT_(dpy, layer, attribute, value);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="OutputPortAttribEXT_(EGLDisplay, EGLOutputPortEXT, int, IntPtr)"/>
            public static unsafe bool OutputPortAttribEXT(EGLDisplay dpy, EGLOutputPortEXT port, int attribute, IntPtr value)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = OutputPortAttribEXT_(dpy, port, attribute, value);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceAttribEXT(EGLDeviceEXT, int, IntPtr*)"/>
            public static unsafe bool QueryDeviceAttribEXT(EGLDeviceEXT device, int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDeviceAttribEXT(device, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceAttribEXT(EGLDeviceEXT, int, IntPtr*)"/>
            public static unsafe bool QueryDeviceAttribEXT(EGLDeviceEXT device, int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDeviceAttribEXT(device, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceAttribEXT(EGLDeviceEXT, int, IntPtr*)"/>
            public static unsafe bool QueryDeviceAttribEXT(EGLDeviceEXT device, int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryDeviceAttribEXT(device, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceBinaryEXT(EGLDeviceEXT, int, int, void*, int*)"/>
            public static unsafe bool QueryDeviceBinaryEXT(EGLDeviceEXT device, int name, int max_size, IntPtr value, Span<int> size)
            {
                bool returnValue_bool;
                fixed (int* size_ptr = size)
                {
                    void* value_vptr = (void*)value;
                    int returnValue;
                    returnValue = QueryDeviceBinaryEXT(device, name, max_size, value_vptr, size_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceBinaryEXT(EGLDeviceEXT, int, int, void*, int*)"/>
            public static unsafe bool QueryDeviceBinaryEXT(EGLDeviceEXT device, int name, int max_size, IntPtr value, int[] size)
            {
                bool returnValue_bool;
                fixed (int* size_ptr = size)
                {
                    void* value_vptr = (void*)value;
                    int returnValue;
                    returnValue = QueryDeviceBinaryEXT(device, name, max_size, value_vptr, size_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceBinaryEXT(EGLDeviceEXT, int, int, void*, int*)"/>
            public static unsafe bool QueryDeviceBinaryEXT(EGLDeviceEXT device, int name, int max_size, IntPtr value, ref int size)
            {
                bool returnValue_bool;
                fixed (int* size_ptr = &size)
                {
                    void* value_vptr = (void*)value;
                    int returnValue;
                    returnValue = QueryDeviceBinaryEXT(device, name, max_size, value_vptr, size_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceBinaryEXT(EGLDeviceEXT, int, int, void*, int*)"/>
            public static unsafe bool QueryDeviceBinaryEXT<T1>(EGLDeviceEXT device, int name, int max_size, Span<T1> value, Span<int> size)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (int* size_ptr = size)
                {
                    fixed (void* value_ptr = value)
                    {
                        int returnValue;
                        returnValue = QueryDeviceBinaryEXT(device, name, max_size, value_ptr, size_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceBinaryEXT(EGLDeviceEXT, int, int, void*, int*)"/>
            public static unsafe bool QueryDeviceBinaryEXT<T1>(EGLDeviceEXT device, int name, int max_size, T1[] value, int[] size)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (int* size_ptr = size)
                {
                    fixed (void* value_ptr = value)
                    {
                        int returnValue;
                        returnValue = QueryDeviceBinaryEXT(device, name, max_size, value_ptr, size_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceBinaryEXT(EGLDeviceEXT, int, int, void*, int*)"/>
            public static unsafe bool QueryDeviceBinaryEXT<T1>(EGLDeviceEXT device, int name, int max_size, ref T1 value, ref int size)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* value_ptr = &value)
                fixed (int* size_ptr = &size)
                {
                    int returnValue;
                    returnValue = QueryDeviceBinaryEXT(device, name, max_size, value_ptr, size_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDevicesEXT(int, EGLDeviceEXT*, int*)"/>
            public static unsafe bool QueryDevicesEXT(int max_devices, Span<EGLDeviceEXT> devices, Span<int> num_devices)
            {
                bool returnValue_bool;
                fixed (int* num_devices_ptr = num_devices)
                {
                    fixed (EGLDeviceEXT* devices_ptr = devices)
                    {
                        int returnValue;
                        returnValue = QueryDevicesEXT(max_devices, devices_ptr, num_devices_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDevicesEXT(int, EGLDeviceEXT*, int*)"/>
            public static unsafe bool QueryDevicesEXT(int max_devices, EGLDeviceEXT[] devices, int[] num_devices)
            {
                bool returnValue_bool;
                fixed (int* num_devices_ptr = num_devices)
                {
                    fixed (EGLDeviceEXT* devices_ptr = devices)
                    {
                        int returnValue;
                        returnValue = QueryDevicesEXT(max_devices, devices_ptr, num_devices_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDevicesEXT(int, EGLDeviceEXT*, int*)"/>
            public static unsafe bool QueryDevicesEXT(int max_devices, ref EGLDeviceEXT devices, ref int num_devices)
            {
                bool returnValue_bool;
                fixed (EGLDeviceEXT* devices_ptr = &devices)
                fixed (int* num_devices_ptr = &num_devices)
                {
                    int returnValue;
                    returnValue = QueryDevicesEXT(max_devices, devices_ptr, num_devices_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDeviceStringEXT_(EGLDeviceEXT, int)"/>
            public static unsafe string? QueryDeviceStringEXT(EGLDeviceEXT device, int name)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryDeviceStringEXT_(device, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QueryDisplayAttribEXT(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribEXT(EGLDisplay dpy, int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribEXT(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribEXT(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribEXT(EGLDisplay dpy, int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribEXT(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribEXT(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribEXT(EGLDisplay dpy, int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribEXT(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDmaBufFormatsEXT(EGLDisplay, int, int*, int*)"/>
            public static unsafe bool QueryDmaBufFormatsEXT(EGLDisplay dpy, int max_formats, Span<int> formats, Span<int> num_formats)
            {
                bool returnValue_bool;
                fixed (int* num_formats_ptr = num_formats)
                {
                    fixed (int* formats_ptr = formats)
                    {
                        int returnValue;
                        returnValue = QueryDmaBufFormatsEXT(dpy, max_formats, formats_ptr, num_formats_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDmaBufFormatsEXT(EGLDisplay, int, int*, int*)"/>
            public static unsafe bool QueryDmaBufFormatsEXT(EGLDisplay dpy, int max_formats, int[] formats, int[] num_formats)
            {
                bool returnValue_bool;
                fixed (int* num_formats_ptr = num_formats)
                {
                    fixed (int* formats_ptr = formats)
                    {
                        int returnValue;
                        returnValue = QueryDmaBufFormatsEXT(dpy, max_formats, formats_ptr, num_formats_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDmaBufFormatsEXT(EGLDisplay, int, int*, int*)"/>
            public static unsafe bool QueryDmaBufFormatsEXT(EGLDisplay dpy, int max_formats, ref int formats, ref int num_formats)
            {
                bool returnValue_bool;
                fixed (int* formats_ptr = &formats)
                fixed (int* num_formats_ptr = &num_formats)
                {
                    int returnValue;
                    returnValue = QueryDmaBufFormatsEXT(dpy, max_formats, formats_ptr, num_formats_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDmaBufModifiersEXT(EGLDisplay, int, int, ulong*, int*, int*)"/>
            public static unsafe bool QueryDmaBufModifiersEXT(EGLDisplay dpy, int format, int max_modifiers, Span<ulong> modifiers, Span<int> external_only, Span<int> num_modifiers)
            {
                bool returnValue_bool;
                fixed (int* num_modifiers_ptr = num_modifiers)
                {
                    fixed (int* external_only_ptr = external_only)
                    {
                        fixed (ulong* modifiers_ptr = modifiers)
                        {
                            int returnValue;
                            returnValue = QueryDmaBufModifiersEXT(dpy, format, max_modifiers, modifiers_ptr, external_only_ptr, num_modifiers_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDmaBufModifiersEXT(EGLDisplay, int, int, ulong*, int*, int*)"/>
            public static unsafe bool QueryDmaBufModifiersEXT(EGLDisplay dpy, int format, int max_modifiers, ulong[] modifiers, int[] external_only, int[] num_modifiers)
            {
                bool returnValue_bool;
                fixed (int* num_modifiers_ptr = num_modifiers)
                {
                    fixed (int* external_only_ptr = external_only)
                    {
                        fixed (ulong* modifiers_ptr = modifiers)
                        {
                            int returnValue;
                            returnValue = QueryDmaBufModifiersEXT(dpy, format, max_modifiers, modifiers_ptr, external_only_ptr, num_modifiers_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDmaBufModifiersEXT(EGLDisplay, int, int, ulong*, int*, int*)"/>
            public static unsafe bool QueryDmaBufModifiersEXT(EGLDisplay dpy, int format, int max_modifiers, ref ulong modifiers, ref int external_only, ref int num_modifiers)
            {
                bool returnValue_bool;
                fixed (ulong* modifiers_ptr = &modifiers)
                fixed (int* external_only_ptr = &external_only)
                fixed (int* num_modifiers_ptr = &num_modifiers)
                {
                    int returnValue;
                    returnValue = QueryDmaBufModifiersEXT(dpy, format, max_modifiers, modifiers_ptr, external_only_ptr, num_modifiers_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputLayerAttribEXT(EGLDisplay, EGLOutputLayerEXT, int, IntPtr*)"/>
            public static unsafe bool QueryOutputLayerAttribEXT(EGLDisplay dpy, EGLOutputLayerEXT layer, int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryOutputLayerAttribEXT(dpy, layer, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputLayerAttribEXT(EGLDisplay, EGLOutputLayerEXT, int, IntPtr*)"/>
            public static unsafe bool QueryOutputLayerAttribEXT(EGLDisplay dpy, EGLOutputLayerEXT layer, int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryOutputLayerAttribEXT(dpy, layer, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputLayerAttribEXT(EGLDisplay, EGLOutputLayerEXT, int, IntPtr*)"/>
            public static unsafe bool QueryOutputLayerAttribEXT(EGLDisplay dpy, EGLOutputLayerEXT layer, int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryOutputLayerAttribEXT(dpy, layer, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputLayerStringEXT_(EGLDisplay, EGLOutputLayerEXT, int)"/>
            public static unsafe string? QueryOutputLayerStringEXT(EGLDisplay dpy, EGLOutputLayerEXT layer, int name)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryOutputLayerStringEXT_(dpy, layer, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QueryOutputPortAttribEXT(EGLDisplay, EGLOutputPortEXT, int, IntPtr*)"/>
            public static unsafe bool QueryOutputPortAttribEXT(EGLDisplay dpy, EGLOutputPortEXT port, int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryOutputPortAttribEXT(dpy, port, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputPortAttribEXT(EGLDisplay, EGLOutputPortEXT, int, IntPtr*)"/>
            public static unsafe bool QueryOutputPortAttribEXT(EGLDisplay dpy, EGLOutputPortEXT port, int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryOutputPortAttribEXT(dpy, port, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputPortAttribEXT(EGLDisplay, EGLOutputPortEXT, int, IntPtr*)"/>
            public static unsafe bool QueryOutputPortAttribEXT(EGLDisplay dpy, EGLOutputPortEXT port, int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryOutputPortAttribEXT(dpy, port, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryOutputPortStringEXT_(EGLDisplay, EGLOutputPortEXT, int)"/>
            public static unsafe string? QueryOutputPortStringEXT(EGLDisplay dpy, EGLOutputPortEXT port, int name)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryOutputPortStringEXT_(dpy, port, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QuerySupportedCompressionRatesEXT(EGLDisplay, EGLConfig, IntPtr*, int*, int, int*)"/>
            public static unsafe bool QuerySupportedCompressionRatesEXT(EGLDisplay dpy, EGLConfig config, ReadOnlySpan<IntPtr> attrib_list, Span<int> rates, int rate_size, Span<int> num_rates)
            {
                bool returnValue_bool;
                fixed (int* num_rates_ptr = num_rates)
                {
                    fixed (int* rates_ptr = rates)
                    {
                        fixed (IntPtr* attrib_list_ptr = attrib_list)
                        {
                            int returnValue;
                            returnValue = QuerySupportedCompressionRatesEXT(dpy, config, attrib_list_ptr, rates_ptr, rate_size, num_rates_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QuerySupportedCompressionRatesEXT(EGLDisplay, EGLConfig, IntPtr*, int*, int, int*)"/>
            public static unsafe bool QuerySupportedCompressionRatesEXT(EGLDisplay dpy, EGLConfig config, IntPtr[] attrib_list, int[] rates, int rate_size, int[] num_rates)
            {
                bool returnValue_bool;
                fixed (int* num_rates_ptr = num_rates)
                {
                    fixed (int* rates_ptr = rates)
                    {
                        fixed (IntPtr* attrib_list_ptr = attrib_list)
                        {
                            int returnValue;
                            returnValue = QuerySupportedCompressionRatesEXT(dpy, config, attrib_list_ptr, rates_ptr, rate_size, num_rates_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QuerySupportedCompressionRatesEXT(EGLDisplay, EGLConfig, IntPtr*, int*, int, int*)"/>
            public static unsafe bool QuerySupportedCompressionRatesEXT(EGLDisplay dpy, EGLConfig config, ref readonly IntPtr attrib_list, ref int rates, int rate_size, ref int num_rates)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                fixed (int* rates_ptr = &rates)
                fixed (int* num_rates_ptr = &num_rates)
                {
                    int returnValue;
                    returnValue = QuerySupportedCompressionRatesEXT(dpy, config, attrib_list_ptr, rates_ptr, rate_size, num_rates_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerOutputEXT_(EGLDisplay, EGLStreamKHR, EGLOutputLayerEXT)"/>
            public static unsafe bool StreamConsumerOutputEXT(EGLDisplay dpy, EGLStreamKHR stream, EGLOutputLayerEXT layer)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamConsumerOutputEXT_(dpy, stream, layer);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithDamageEXT(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SwapBuffersWithDamageEXT(EGLDisplay dpy, EGLSurface surface, ReadOnlySpan<int> rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersWithDamageEXT(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithDamageEXT(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SwapBuffersWithDamageEXT(EGLDisplay dpy, EGLSurface surface, int[] rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersWithDamageEXT(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithDamageEXT(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SwapBuffersWithDamageEXT(EGLDisplay dpy, EGLSurface surface, ref readonly int rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = &rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersWithDamageEXT(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnsignalSyncEXT(EGLDisplay, EGLSync, IntPtr*)"/>
            public static unsafe bool UnsignalSyncEXT(EGLDisplay dpy, EGLSync sync, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = UnsignalSyncEXT(dpy, sync, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnsignalSyncEXT(EGLDisplay, EGLSync, IntPtr*)"/>
            public static unsafe bool UnsignalSyncEXT(EGLDisplay dpy, EGLSync sync, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = UnsignalSyncEXT(dpy, sync, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnsignalSyncEXT(EGLDisplay, EGLSync, IntPtr*)"/>
            public static unsafe bool UnsignalSyncEXT(EGLDisplay dpy, EGLSync sync, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = UnsignalSyncEXT(dpy, sync, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
        }
        public static unsafe partial class HI
        {
            /// <inheritdoc cref="CreatePixmapSurfaceHI(EGLDisplay, EGLConfig, EGLClientPixmapHI*)"/>
            public static unsafe EGLSurface CreatePixmapSurfaceHI(EGLDisplay dpy, EGLConfig config, Span<EGLClientPixmapHI> pixmap)
            {
                EGLSurface returnValue;
                fixed (EGLClientPixmapHI* pixmap_ptr = pixmap)
                {
                    returnValue = CreatePixmapSurfaceHI(dpy, config, pixmap_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePixmapSurfaceHI(EGLDisplay, EGLConfig, EGLClientPixmapHI*)"/>
            public static unsafe EGLSurface CreatePixmapSurfaceHI(EGLDisplay dpy, EGLConfig config, EGLClientPixmapHI[] pixmap)
            {
                EGLSurface returnValue;
                fixed (EGLClientPixmapHI* pixmap_ptr = pixmap)
                {
                    returnValue = CreatePixmapSurfaceHI(dpy, config, pixmap_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePixmapSurfaceHI(EGLDisplay, EGLConfig, EGLClientPixmapHI*)"/>
            public static unsafe EGLSurface CreatePixmapSurfaceHI(EGLDisplay dpy, EGLConfig config, ref EGLClientPixmapHI pixmap)
            {
                EGLSurface returnValue;
                fixed (EGLClientPixmapHI* pixmap_ptr = &pixmap)
                {
                    returnValue = CreatePixmapSurfaceHI(dpy, config, pixmap_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class KHR
        {
            /// <inheritdoc cref="CreateImageKHR(EGLDisplay, EGLContext, TextureTarget, EGLClientBuffer, int*)"/>
            public static unsafe EGLImageKHR CreateImageKHR(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, ReadOnlySpan<int> attrib_list)
            {
                EGLImageKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateImageKHR(dpy, ctx, target, buffer, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateImageKHR(EGLDisplay, EGLContext, TextureTarget, EGLClientBuffer, int*)"/>
            public static unsafe EGLImageKHR CreateImageKHR(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, int[] attrib_list)
            {
                EGLImageKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateImageKHR(dpy, ctx, target, buffer, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateImageKHR(EGLDisplay, EGLContext, TextureTarget, EGLClientBuffer, int*)"/>
            public static unsafe EGLImageKHR CreateImageKHR(EGLDisplay dpy, EGLContext ctx, TextureTarget target, EGLClientBuffer buffer, ref readonly int attrib_list)
            {
                EGLImageKHR returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateImageKHR(dpy, ctx, target, buffer, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamAttribKHR(EGLDisplay, IntPtr*)"/>
            public static unsafe EGLStreamKHR CreateStreamAttribKHR(EGLDisplay dpy, ReadOnlySpan<IntPtr> attrib_list)
            {
                EGLStreamKHR returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamAttribKHR(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamAttribKHR(EGLDisplay, IntPtr*)"/>
            public static unsafe EGLStreamKHR CreateStreamAttribKHR(EGLDisplay dpy, IntPtr[] attrib_list)
            {
                EGLStreamKHR returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamAttribKHR(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamAttribKHR(EGLDisplay, IntPtr*)"/>
            public static unsafe EGLStreamKHR CreateStreamAttribKHR(EGLDisplay dpy, ref readonly IntPtr attrib_list)
            {
                EGLStreamKHR returnValue;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateStreamAttribKHR(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamKHR(EGLDisplay, int*)"/>
            public static unsafe EGLStreamKHR CreateStreamKHR(EGLDisplay dpy, ReadOnlySpan<int> attrib_list)
            {
                EGLStreamKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamKHR(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamKHR(EGLDisplay, int*)"/>
            public static unsafe EGLStreamKHR CreateStreamKHR(EGLDisplay dpy, int[] attrib_list)
            {
                EGLStreamKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamKHR(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamKHR(EGLDisplay, int*)"/>
            public static unsafe EGLStreamKHR CreateStreamKHR(EGLDisplay dpy, ref readonly int attrib_list)
            {
                EGLStreamKHR returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateStreamKHR(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamProducerSurfaceKHR(EGLDisplay, EGLConfig, EGLStreamKHR, int*)"/>
            public static unsafe EGLSurface CreateStreamProducerSurfaceKHR(EGLDisplay dpy, EGLConfig config, EGLStreamKHR stream, ReadOnlySpan<int> attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamProducerSurfaceKHR(dpy, config, stream, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamProducerSurfaceKHR(EGLDisplay, EGLConfig, EGLStreamKHR, int*)"/>
            public static unsafe EGLSurface CreateStreamProducerSurfaceKHR(EGLDisplay dpy, EGLConfig config, EGLStreamKHR stream, int[] attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamProducerSurfaceKHR(dpy, config, stream, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamProducerSurfaceKHR(EGLDisplay, EGLConfig, EGLStreamKHR, int*)"/>
            public static unsafe EGLSurface CreateStreamProducerSurfaceKHR(EGLDisplay dpy, EGLConfig config, EGLStreamKHR stream, ref readonly int attrib_list)
            {
                EGLSurface returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateStreamProducerSurfaceKHR(dpy, config, stream, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSync64KHR(EGLDisplay, SyncType, IntPtr*)"/>
            public static unsafe EGLSyncKHR CreateSync64KHR(EGLDisplay dpy, SyncType type, ReadOnlySpan<IntPtr> attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateSync64KHR(dpy, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSync64KHR(EGLDisplay, SyncType, IntPtr*)"/>
            public static unsafe EGLSyncKHR CreateSync64KHR(EGLDisplay dpy, SyncType type, IntPtr[] attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateSync64KHR(dpy, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSync64KHR(EGLDisplay, SyncType, IntPtr*)"/>
            public static unsafe EGLSyncKHR CreateSync64KHR(EGLDisplay dpy, SyncType type, ref readonly IntPtr attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateSync64KHR(dpy, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSyncKHR(EGLDisplay, SyncType, int*)"/>
            public static unsafe EGLSyncKHR CreateSyncKHR(EGLDisplay dpy, SyncType type, ReadOnlySpan<int> attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateSyncKHR(dpy, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSyncKHR(EGLDisplay, SyncType, int*)"/>
            public static unsafe EGLSyncKHR CreateSyncKHR(EGLDisplay dpy, SyncType type, int[] attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateSyncKHR(dpy, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSyncKHR(EGLDisplay, SyncType, int*)"/>
            public static unsafe EGLSyncKHR CreateSyncKHR(EGLDisplay dpy, SyncType type, ref readonly int attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateSyncKHR(dpy, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DebugMessageControlKHR(IntPtr, IntPtr*)"/>
            public static unsafe int DebugMessageControlKHR(EGLDebugProcKHR callback, ReadOnlySpan<IntPtr> attrib_list)
            {
                int returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    returnValue = DebugMessageControlKHR(callback_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DebugMessageControlKHR(IntPtr, IntPtr*)"/>
            public static unsafe int DebugMessageControlKHR(EGLDebugProcKHR callback, IntPtr[] attrib_list)
            {
                int returnValue;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    returnValue = DebugMessageControlKHR(callback_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DebugMessageControlKHR(IntPtr, IntPtr*)"/>
            public static unsafe int DebugMessageControlKHR(EGLDebugProcKHR callback, ref readonly IntPtr attrib_list)
            {
                int returnValue;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    IntPtr callback_ptr = Marshal.GetFunctionPointerForDelegate(callback);
                    returnValue = DebugMessageControlKHR(callback_ptr, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DestroyImageKHR_(EGLDisplay, EGLImageKHR)"/>
            public static unsafe bool DestroyImageKHR(EGLDisplay dpy, EGLImageKHR image)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = DestroyImageKHR_(dpy, image);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="DestroyStreamKHR_(EGLDisplay, EGLStreamKHR)"/>
            public static unsafe bool DestroyStreamKHR(EGLDisplay dpy, EGLStreamKHR stream)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = DestroyStreamKHR_(dpy, stream);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="DestroySyncKHR_(EGLDisplay, EGLSyncKHR)"/>
            public static unsafe bool DestroySyncKHR(EGLDisplay dpy, EGLSyncKHR sync)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = DestroySyncKHR_(dpy, sync);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncAttribKHR(EGLDisplay, EGLSyncKHR, int, int*)"/>
            public static unsafe bool GetSyncAttribKHR(EGLDisplay dpy, EGLSyncKHR sync, int attribute, Span<int> value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    int returnValue;
                    returnValue = GetSyncAttribKHR(dpy, sync, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncAttribKHR(EGLDisplay, EGLSyncKHR, int, int*)"/>
            public static unsafe bool GetSyncAttribKHR(EGLDisplay dpy, EGLSyncKHR sync, int attribute, int[] value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    int returnValue;
                    returnValue = GetSyncAttribKHR(dpy, sync, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncAttribKHR(EGLDisplay, EGLSyncKHR, int, int*)"/>
            public static unsafe bool GetSyncAttribKHR(EGLDisplay dpy, EGLSyncKHR sync, int attribute, ref int value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = GetSyncAttribKHR(dpy, sync, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="LockSurfaceKHR(EGLDisplay, EGLSurface, int*)"/>
            public static unsafe bool LockSurfaceKHR(EGLDisplay dpy, EGLSurface surface, ReadOnlySpan<int> attrib_list)
            {
                bool returnValue_bool;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = LockSurfaceKHR(dpy, surface, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="LockSurfaceKHR(EGLDisplay, EGLSurface, int*)"/>
            public static unsafe bool LockSurfaceKHR(EGLDisplay dpy, EGLSurface surface, int[] attrib_list)
            {
                bool returnValue_bool;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = LockSurfaceKHR(dpy, surface, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="LockSurfaceKHR(EGLDisplay, EGLSurface, int*)"/>
            public static unsafe bool LockSurfaceKHR(EGLDisplay dpy, EGLSurface surface, ref readonly int attrib_list)
            {
                bool returnValue_bool;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = LockSurfaceKHR(dpy, surface, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDebugKHR(int, IntPtr*)"/>
            public static unsafe bool QueryDebugKHR(int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDebugKHR(attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDebugKHR(int, IntPtr*)"/>
            public static unsafe bool QueryDebugKHR(int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDebugKHR(attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDebugKHR(int, IntPtr*)"/>
            public static unsafe bool QueryDebugKHR(int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryDebugKHR(attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribKHR(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribKHR(EGLDisplay dpy, int name, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribKHR(dpy, name, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribKHR(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribKHR(EGLDisplay dpy, int name, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribKHR(dpy, name, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribKHR(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribKHR(EGLDisplay dpy, int name, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribKHR(dpy, name, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamAttribKHR(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, IntPtr*)"/>
            public static unsafe bool QueryStreamAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamAttribKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamAttribKHR(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, IntPtr*)"/>
            public static unsafe bool QueryStreamAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamAttribKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamAttribKHR(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, IntPtr*)"/>
            public static unsafe bool QueryStreamAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryStreamAttribKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamKHR(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, int*)"/>
            public static unsafe bool QueryStreamKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, Span<int> value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamKHR(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, int*)"/>
            public static unsafe bool QueryStreamKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, int[] value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamKHR(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, int*)"/>
            public static unsafe bool QueryStreamKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, ref int value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryStreamKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamTimeKHR(EGLDisplay, EGLStreamKHR, StreamTime, ulong*)"/>
            public static unsafe bool QueryStreamTimeKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamTime attribute, Span<ulong> value)
            {
                bool returnValue_bool;
                fixed (ulong* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamTimeKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamTimeKHR(EGLDisplay, EGLStreamKHR, StreamTime, ulong*)"/>
            public static unsafe bool QueryStreamTimeKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamTime attribute, ulong[] value)
            {
                bool returnValue_bool;
                fixed (ulong* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamTimeKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamTimeKHR(EGLDisplay, EGLStreamKHR, StreamTime, ulong*)"/>
            public static unsafe bool QueryStreamTimeKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamTime attribute, ref ulong value)
            {
                bool returnValue_bool;
                fixed (ulong* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryStreamTimeKHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamu64KHR(EGLDisplay, EGLStreamKHR, StreamQueryU64Attribute, ulong*)"/>
            public static unsafe bool QueryStreamu64KHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryU64Attribute attribute, Span<ulong> value)
            {
                bool returnValue_bool;
                fixed (ulong* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamu64KHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamu64KHR(EGLDisplay, EGLStreamKHR, StreamQueryU64Attribute, ulong*)"/>
            public static unsafe bool QueryStreamu64KHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryU64Attribute attribute, ulong[] value)
            {
                bool returnValue_bool;
                fixed (ulong* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryStreamu64KHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamu64KHR(EGLDisplay, EGLStreamKHR, StreamQueryU64Attribute, ulong*)"/>
            public static unsafe bool QueryStreamu64KHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryU64Attribute attribute, ref ulong value)
            {
                bool returnValue_bool;
                fixed (ulong* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryStreamu64KHR(dpy, stream, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QuerySurface64KHR(EGLDisplay, EGLSurface, SurfaceQueryAttribute, IntPtr*)"/>
            public static unsafe bool QuerySurface64KHR(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QuerySurface64KHR(dpy, surface, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QuerySurface64KHR(EGLDisplay, EGLSurface, SurfaceQueryAttribute, IntPtr*)"/>
            public static unsafe bool QuerySurface64KHR(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QuerySurface64KHR(dpy, surface, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QuerySurface64KHR(EGLDisplay, EGLSurface, SurfaceQueryAttribute, IntPtr*)"/>
            public static unsafe bool QuerySurface64KHR(EGLDisplay dpy, EGLSurface surface, SurfaceQueryAttribute attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QuerySurface64KHR(dpy, surface, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetDamageRegionKHR(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SetDamageRegionKHR(EGLDisplay dpy, EGLSurface surface, Span<int> rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SetDamageRegionKHR(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetDamageRegionKHR(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SetDamageRegionKHR(EGLDisplay dpy, EGLSurface surface, int[] rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SetDamageRegionKHR(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetDamageRegionKHR(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SetDamageRegionKHR(EGLDisplay dpy, EGLSurface surface, ref int rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = &rects)
                {
                    int returnValue;
                    returnValue = SetDamageRegionKHR(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetStreamAttribKHR_(EGLDisplay, EGLStreamKHR, StreamQueryAttribute, IntPtr)"/>
            public static unsafe bool SetStreamAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamQueryAttribute attribute, IntPtr value)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = SetStreamAttribKHR_(dpy, stream, attribute, value);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="SignalSyncKHR_(EGLDisplay, EGLSyncKHR, SyncStatus)"/>
            public static unsafe bool SignalSyncKHR(EGLDisplay dpy, EGLSyncKHR sync, SyncStatus mode)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = SignalSyncKHR_(dpy, sync, mode);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamAttribKHR_(EGLDisplay, EGLStreamKHR, StreamAttribute, int)"/>
            public static unsafe bool StreamAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, StreamAttribute attribute, int value)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamAttribKHR_(dpy, stream, attribute, value);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerAcquireAttribKHR(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerAcquireAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerAcquireAttribKHR(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerAcquireAttribKHR(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerAcquireAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerAcquireAttribKHR(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerAcquireAttribKHR(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerAcquireAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerAcquireAttribKHR(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerAcquireKHR_(EGLDisplay, EGLStreamKHR)"/>
            public static unsafe bool StreamConsumerAcquireKHR(EGLDisplay dpy, EGLStreamKHR stream)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamConsumerAcquireKHR_(dpy, stream);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerGLTextureExternalKHR_(EGLDisplay, EGLStreamKHR)"/>
            public static unsafe bool StreamConsumerGLTextureExternalKHR(EGLDisplay dpy, EGLStreamKHR stream)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamConsumerGLTextureExternalKHR_(dpy, stream);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerReleaseAttribKHR(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerReleaseAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerReleaseAttribKHR(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerReleaseAttribKHR(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerReleaseAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerReleaseAttribKHR(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerReleaseAttribKHR(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerReleaseAttribKHR(EGLDisplay dpy, EGLStreamKHR stream, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerReleaseAttribKHR(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerReleaseKHR_(EGLDisplay, EGLStreamKHR)"/>
            public static unsafe bool StreamConsumerReleaseKHR(EGLDisplay dpy, EGLStreamKHR stream)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamConsumerReleaseKHR_(dpy, stream);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithDamageKHR(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SwapBuffersWithDamageKHR(EGLDisplay dpy, EGLSurface surface, ReadOnlySpan<int> rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersWithDamageKHR(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithDamageKHR(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SwapBuffersWithDamageKHR(EGLDisplay dpy, EGLSurface surface, int[] rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersWithDamageKHR(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersWithDamageKHR(EGLDisplay, EGLSurface, int*, int)"/>
            public static unsafe bool SwapBuffersWithDamageKHR(EGLDisplay dpy, EGLSurface surface, ref readonly int rects, int n_rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = &rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersWithDamageKHR(dpy, surface, rects_ptr, n_rects);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnlockSurfaceKHR_(EGLDisplay, EGLSurface)"/>
            public static unsafe bool UnlockSurfaceKHR(EGLDisplay dpy, EGLSurface surface)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = UnlockSurfaceKHR_(dpy, surface);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="CreateDRMImageMESA(EGLDisplay, int*)"/>
            public static unsafe EGLImageKHR CreateDRMImageMESA(EGLDisplay dpy, ReadOnlySpan<int> attrib_list)
            {
                EGLImageKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateDRMImageMESA(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDRMImageMESA(EGLDisplay, int*)"/>
            public static unsafe EGLImageKHR CreateDRMImageMESA(EGLDisplay dpy, int[] attrib_list)
            {
                EGLImageKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateDRMImageMESA(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateDRMImageMESA(EGLDisplay, int*)"/>
            public static unsafe EGLImageKHR CreateDRMImageMESA(EGLDisplay dpy, ref readonly int attrib_list)
            {
                EGLImageKHR returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateDRMImageMESA(dpy, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ExportDMABUFImageMESA(EGLDisplay, EGLImageKHR, int*, int*, int*)"/>
            public static unsafe bool ExportDMABUFImageMESA(EGLDisplay dpy, EGLImageKHR image, Span<int> fds, Span<int> strides, Span<int> offsets)
            {
                bool returnValue_bool;
                fixed (int* offsets_ptr = offsets)
                {
                    fixed (int* strides_ptr = strides)
                    {
                        fixed (int* fds_ptr = fds)
                        {
                            int returnValue;
                            returnValue = ExportDMABUFImageMESA(dpy, image, fds_ptr, strides_ptr, offsets_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDMABUFImageMESA(EGLDisplay, EGLImageKHR, int*, int*, int*)"/>
            public static unsafe bool ExportDMABUFImageMESA(EGLDisplay dpy, EGLImageKHR image, int[] fds, int[] strides, int[] offsets)
            {
                bool returnValue_bool;
                fixed (int* offsets_ptr = offsets)
                {
                    fixed (int* strides_ptr = strides)
                    {
                        fixed (int* fds_ptr = fds)
                        {
                            int returnValue;
                            returnValue = ExportDMABUFImageMESA(dpy, image, fds_ptr, strides_ptr, offsets_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDMABUFImageMESA(EGLDisplay, EGLImageKHR, int*, int*, int*)"/>
            public static unsafe bool ExportDMABUFImageMESA(EGLDisplay dpy, EGLImageKHR image, ref int fds, ref int strides, ref int offsets)
            {
                bool returnValue_bool;
                fixed (int* fds_ptr = &fds)
                fixed (int* strides_ptr = &strides)
                fixed (int* offsets_ptr = &offsets)
                {
                    int returnValue;
                    returnValue = ExportDMABUFImageMESA(dpy, image, fds_ptr, strides_ptr, offsets_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDMABUFImageQueryMESA(EGLDisplay, EGLImageKHR, int*, int*, ulong*)"/>
            public static unsafe bool ExportDMABUFImageQueryMESA(EGLDisplay dpy, EGLImageKHR image, Span<int> fourcc, Span<int> num_planes, Span<ulong> modifiers)
            {
                bool returnValue_bool;
                fixed (ulong* modifiers_ptr = modifiers)
                {
                    fixed (int* num_planes_ptr = num_planes)
                    {
                        fixed (int* fourcc_ptr = fourcc)
                        {
                            int returnValue;
                            returnValue = ExportDMABUFImageQueryMESA(dpy, image, fourcc_ptr, num_planes_ptr, modifiers_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDMABUFImageQueryMESA(EGLDisplay, EGLImageKHR, int*, int*, ulong*)"/>
            public static unsafe bool ExportDMABUFImageQueryMESA(EGLDisplay dpy, EGLImageKHR image, int[] fourcc, int[] num_planes, ulong[] modifiers)
            {
                bool returnValue_bool;
                fixed (ulong* modifiers_ptr = modifiers)
                {
                    fixed (int* num_planes_ptr = num_planes)
                    {
                        fixed (int* fourcc_ptr = fourcc)
                        {
                            int returnValue;
                            returnValue = ExportDMABUFImageQueryMESA(dpy, image, fourcc_ptr, num_planes_ptr, modifiers_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDMABUFImageQueryMESA(EGLDisplay, EGLImageKHR, int*, int*, ulong*)"/>
            public static unsafe bool ExportDMABUFImageQueryMESA(EGLDisplay dpy, EGLImageKHR image, ref int fourcc, ref int num_planes, ref ulong modifiers)
            {
                bool returnValue_bool;
                fixed (int* fourcc_ptr = &fourcc)
                fixed (int* num_planes_ptr = &num_planes)
                fixed (ulong* modifiers_ptr = &modifiers)
                {
                    int returnValue;
                    returnValue = ExportDMABUFImageQueryMESA(dpy, image, fourcc_ptr, num_planes_ptr, modifiers_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDRMImageMESA(EGLDisplay, EGLImageKHR, int*, int*, int*)"/>
            public static unsafe bool ExportDRMImageMESA(EGLDisplay dpy, EGLImageKHR image, Span<int> name, Span<int> handle, Span<int> stride)
            {
                bool returnValue_bool;
                fixed (int* stride_ptr = stride)
                {
                    fixed (int* handle_ptr = handle)
                    {
                        fixed (int* name_ptr = name)
                        {
                            int returnValue;
                            returnValue = ExportDRMImageMESA(dpy, image, name_ptr, handle_ptr, stride_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDRMImageMESA(EGLDisplay, EGLImageKHR, int*, int*, int*)"/>
            public static unsafe bool ExportDRMImageMESA(EGLDisplay dpy, EGLImageKHR image, int[] name, int[] handle, int[] stride)
            {
                bool returnValue_bool;
                fixed (int* stride_ptr = stride)
                {
                    fixed (int* handle_ptr = handle)
                    {
                        fixed (int* name_ptr = name)
                        {
                            int returnValue;
                            returnValue = ExportDRMImageMESA(dpy, image, name_ptr, handle_ptr, stride_ptr);
                            returnValue_bool = returnValue != 0;
                        }
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ExportDRMImageMESA(EGLDisplay, EGLImageKHR, int*, int*, int*)"/>
            public static unsafe bool ExportDRMImageMESA(EGLDisplay dpy, EGLImageKHR image, ref int name, ref int handle, ref int stride)
            {
                bool returnValue_bool;
                fixed (int* name_ptr = &name)
                fixed (int* handle_ptr = &handle)
                fixed (int* stride_ptr = &stride)
                {
                    int returnValue;
                    returnValue = ExportDRMImageMESA(dpy, image, name_ptr, handle_ptr, stride_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetDisplayDriverConfig_(EGLDisplay)"/>
            public static unsafe string? GetDisplayDriverConfig(EGLDisplay dpy)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetDisplayDriverConfig_(dpy);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="GetDisplayDriverName_(EGLDisplay)"/>
            public static unsafe string? GetDisplayDriverName(EGLDisplay dpy)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetDisplayDriverName_(dpy);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
        }
        public static unsafe partial class NOK
        {
            /// <inheritdoc cref="SwapBuffersRegion2NOK(EGLDisplay, EGLSurface, int, int*)"/>
            public static unsafe bool SwapBuffersRegion2NOK(EGLDisplay dpy, EGLSurface surface, int numRects, ReadOnlySpan<int> rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersRegion2NOK(dpy, surface, numRects, rects_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersRegion2NOK(EGLDisplay, EGLSurface, int, int*)"/>
            public static unsafe bool SwapBuffersRegion2NOK(EGLDisplay dpy, EGLSurface surface, int numRects, int[] rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersRegion2NOK(dpy, surface, numRects, rects_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersRegion2NOK(EGLDisplay, EGLSurface, int, int*)"/>
            public static unsafe bool SwapBuffersRegion2NOK(EGLDisplay dpy, EGLSurface surface, int numRects, ref readonly int rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = &rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersRegion2NOK(dpy, surface, numRects, rects_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersRegionNOK(EGLDisplay, EGLSurface, int, int*)"/>
            public static unsafe bool SwapBuffersRegionNOK(EGLDisplay dpy, EGLSurface surface, int numRects, ReadOnlySpan<int> rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersRegionNOK(dpy, surface, numRects, rects_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersRegionNOK(EGLDisplay, EGLSurface, int, int*)"/>
            public static unsafe bool SwapBuffersRegionNOK(EGLDisplay dpy, EGLSurface surface, int numRects, int[] rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersRegionNOK(dpy, surface, numRects, rects_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SwapBuffersRegionNOK(EGLDisplay, EGLSurface, int, int*)"/>
            public static unsafe bool SwapBuffersRegionNOK(EGLDisplay dpy, EGLSurface surface, int numRects, ref readonly int rects)
            {
                bool returnValue_bool;
                fixed (int* rects_ptr = &rects)
                {
                    int returnValue;
                    returnValue = SwapBuffersRegionNOK(dpy, surface, numRects, rects_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="CreateFenceSyncNV(EGLDisplay, SyncCondition, int*)"/>
            public static unsafe EGLSyncNV CreateFenceSyncNV(EGLDisplay dpy, SyncCondition condition, ReadOnlySpan<int> attrib_list)
            {
                EGLSyncNV returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateFenceSyncNV(dpy, condition, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFenceSyncNV(EGLDisplay, SyncCondition, int*)"/>
            public static unsafe EGLSyncNV CreateFenceSyncNV(EGLDisplay dpy, SyncCondition condition, int[] attrib_list)
            {
                EGLSyncNV returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateFenceSyncNV(dpy, condition, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFenceSyncNV(EGLDisplay, SyncCondition, int*)"/>
            public static unsafe EGLSyncNV CreateFenceSyncNV(EGLDisplay dpy, SyncCondition condition, ref readonly int attrib_list)
            {
                EGLSyncNV returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateFenceSyncNV(dpy, condition, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamSyncNV(EGLDisplay, EGLStreamKHR, SyncType, int*)"/>
            public static unsafe EGLSyncKHR CreateStreamSyncNV(EGLDisplay dpy, EGLStreamKHR stream, SyncType type, ReadOnlySpan<int> attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamSyncNV(dpy, stream, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamSyncNV(EGLDisplay, EGLStreamKHR, SyncType, int*)"/>
            public static unsafe EGLSyncKHR CreateStreamSyncNV(EGLDisplay dpy, EGLStreamKHR stream, SyncType type, int[] attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateStreamSyncNV(dpy, stream, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateStreamSyncNV(EGLDisplay, EGLStreamKHR, SyncType, int*)"/>
            public static unsafe EGLSyncKHR CreateStreamSyncNV(EGLDisplay dpy, EGLStreamKHR stream, SyncType type, ref readonly int attrib_list)
            {
                EGLSyncKHR returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateStreamSyncNV(dpy, stream, type, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DestroySyncNV_(EGLSyncNV)"/>
            public static unsafe bool DestroySyncNV(EGLSyncNV sync)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = DestroySyncNV_(sync);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="FenceNV_(EGLSyncNV)"/>
            public static unsafe bool FenceNV(EGLSyncNV sync)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = FenceNV_(sync);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncAttribNV(EGLSyncNV, int, int*)"/>
            public static unsafe bool GetSyncAttribNV(EGLSyncNV sync, int attribute, Span<int> value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    int returnValue;
                    returnValue = GetSyncAttribNV(sync, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncAttribNV(EGLSyncNV, int, int*)"/>
            public static unsafe bool GetSyncAttribNV(EGLSyncNV sync, int attribute, int[] value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    int returnValue;
                    returnValue = GetSyncAttribNV(sync, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="GetSyncAttribNV(EGLSyncNV, int, int*)"/>
            public static unsafe bool GetSyncAttribNV(EGLSyncNV sync, int attribute, ref int value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = GetSyncAttribNV(sync, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="PostSubBufferNV_(EGLDisplay, EGLSurface, int, int, int, int)"/>
            public static unsafe bool PostSubBufferNV(EGLDisplay dpy, EGLSurface surface, int x, int y, int width, int height)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = PostSubBufferNV_(dpy, surface, x, y, width, height);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribNV(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribNV(EGLDisplay dpy, int attribute, Span<IntPtr> value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribNV(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribNV(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribNV(EGLDisplay dpy, int attribute, IntPtr[] value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribNV(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryDisplayAttribNV(EGLDisplay, int, IntPtr*)"/>
            public static unsafe bool QueryDisplayAttribNV(EGLDisplay dpy, int attribute, ref IntPtr value)
            {
                bool returnValue_bool;
                fixed (IntPtr* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryDisplayAttribNV(dpy, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativeDisplayNV(EGLDisplay, IntPtr*)"/>
            public static unsafe bool QueryNativeDisplayNV(EGLDisplay dpy, Span<IntPtr> display_id)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_id_ptr = display_id)
                {
                    int returnValue;
                    returnValue = QueryNativeDisplayNV(dpy, display_id_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativeDisplayNV(EGLDisplay, IntPtr*)"/>
            public static unsafe bool QueryNativeDisplayNV(EGLDisplay dpy, IntPtr[] display_id)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_id_ptr = display_id)
                {
                    int returnValue;
                    returnValue = QueryNativeDisplayNV(dpy, display_id_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativeDisplayNV(EGLDisplay, IntPtr*)"/>
            public static unsafe bool QueryNativeDisplayNV(EGLDisplay dpy, ref IntPtr display_id)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_id_ptr = &display_id)
                {
                    int returnValue;
                    returnValue = QueryNativeDisplayNV(dpy, display_id_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativePixmapNV(EGLDisplay, EGLSurface, IntPtr*)"/>
            public static unsafe bool QueryNativePixmapNV(EGLDisplay dpy, EGLSurface surf, Span<IntPtr> pixmap)
            {
                bool returnValue_bool;
                fixed (IntPtr* pixmap_ptr = pixmap)
                {
                    int returnValue;
                    returnValue = QueryNativePixmapNV(dpy, surf, pixmap_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativePixmapNV(EGLDisplay, EGLSurface, IntPtr*)"/>
            public static unsafe bool QueryNativePixmapNV(EGLDisplay dpy, EGLSurface surf, IntPtr[] pixmap)
            {
                bool returnValue_bool;
                fixed (IntPtr* pixmap_ptr = pixmap)
                {
                    int returnValue;
                    returnValue = QueryNativePixmapNV(dpy, surf, pixmap_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativePixmapNV(EGLDisplay, EGLSurface, IntPtr*)"/>
            public static unsafe bool QueryNativePixmapNV(EGLDisplay dpy, EGLSurface surf, ref IntPtr pixmap)
            {
                bool returnValue_bool;
                fixed (IntPtr* pixmap_ptr = &pixmap)
                {
                    int returnValue;
                    returnValue = QueryNativePixmapNV(dpy, surf, pixmap_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativeWindowNV(EGLDisplay, EGLSurface, IntPtr*)"/>
            public static unsafe bool QueryNativeWindowNV(EGLDisplay dpy, EGLSurface surf, Span<IntPtr> window)
            {
                bool returnValue_bool;
                fixed (IntPtr* window_ptr = window)
                {
                    int returnValue;
                    returnValue = QueryNativeWindowNV(dpy, surf, window_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativeWindowNV(EGLDisplay, EGLSurface, IntPtr*)"/>
            public static unsafe bool QueryNativeWindowNV(EGLDisplay dpy, EGLSurface surf, IntPtr[] window)
            {
                bool returnValue_bool;
                fixed (IntPtr* window_ptr = window)
                {
                    int returnValue;
                    returnValue = QueryNativeWindowNV(dpy, surf, window_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryNativeWindowNV(EGLDisplay, EGLSurface, IntPtr*)"/>
            public static unsafe bool QueryNativeWindowNV(EGLDisplay dpy, EGLSurface surf, ref IntPtr window)
            {
                bool returnValue_bool;
                fixed (IntPtr* window_ptr = &window)
                {
                    int returnValue;
                    returnValue = QueryNativeWindowNV(dpy, surf, window_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamConsumerEventNV(EGLDisplay, EGLStreamKHR, ulong, All*, IntPtr*)"/>
            public static unsafe int QueryStreamConsumerEventNV(EGLDisplay dpy, EGLStreamKHR stream, ulong timeout, Span<All> @event, Span<IntPtr> aux)
            {
                int returnValue;
                fixed (IntPtr* aux_ptr = aux)
                {
                    fixed (All* @event_ptr = @event)
                    {
                        returnValue = QueryStreamConsumerEventNV(dpy, stream, timeout, @event_ptr, aux_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryStreamConsumerEventNV(EGLDisplay, EGLStreamKHR, ulong, All*, IntPtr*)"/>
            public static unsafe int QueryStreamConsumerEventNV(EGLDisplay dpy, EGLStreamKHR stream, ulong timeout, All[] @event, IntPtr[] aux)
            {
                int returnValue;
                fixed (IntPtr* aux_ptr = aux)
                {
                    fixed (All* @event_ptr = @event)
                    {
                        returnValue = QueryStreamConsumerEventNV(dpy, stream, timeout, @event_ptr, aux_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryStreamConsumerEventNV(EGLDisplay, EGLStreamKHR, ulong, All*, IntPtr*)"/>
            public static unsafe int QueryStreamConsumerEventNV(EGLDisplay dpy, EGLStreamKHR stream, ulong timeout, ref All @event, ref IntPtr aux)
            {
                int returnValue;
                fixed (All* @event_ptr = &@event)
                fixed (IntPtr* aux_ptr = &aux)
                {
                    returnValue = QueryStreamConsumerEventNV(dpy, stream, timeout, @event_ptr, aux_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryStreamMetadataNV(EGLDisplay, EGLStreamKHR, All, int, int, int, void*)"/>
            public static unsafe bool QueryStreamMetadataNV(EGLDisplay dpy, EGLStreamKHR stream, All name, int n, int offset, int size, IntPtr data)
            {
                bool returnValue_bool;
                void* data_vptr = (void*)data;
                int returnValue;
                returnValue = QueryStreamMetadataNV(dpy, stream, name, n, offset, size, data_vptr);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamMetadataNV(EGLDisplay, EGLStreamKHR, All, int, int, int, void*)"/>
            public static unsafe bool QueryStreamMetadataNV<T1>(EGLDisplay dpy, EGLStreamKHR stream, All name, int n, int offset, int size, Span<T1> data)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* data_ptr = data)
                {
                    int returnValue;
                    returnValue = QueryStreamMetadataNV(dpy, stream, name, n, offset, size, data_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamMetadataNV(EGLDisplay, EGLStreamKHR, All, int, int, int, void*)"/>
            public static unsafe bool QueryStreamMetadataNV<T1>(EGLDisplay dpy, EGLStreamKHR stream, All name, int n, int offset, int size, T1[] data)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* data_ptr = data)
                {
                    int returnValue;
                    returnValue = QueryStreamMetadataNV(dpy, stream, name, n, offset, size, data_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryStreamMetadataNV(EGLDisplay, EGLStreamKHR, All, int, int, int, void*)"/>
            public static unsafe bool QueryStreamMetadataNV<T1>(EGLDisplay dpy, EGLStreamKHR stream, All name, int n, int offset, int size, ref T1 data)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* data_ptr = &data)
                {
                    int returnValue;
                    returnValue = QueryStreamMetadataNV(dpy, stream, name, n, offset, size, data_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="ResetStreamNV_(EGLDisplay, EGLStreamKHR)"/>
            public static unsafe bool ResetStreamNV(EGLDisplay dpy, EGLStreamKHR stream)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = ResetStreamNV_(dpy, stream);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetStreamMetadataNV(EGLDisplay, EGLStreamKHR, int, int, int, void*)"/>
            public static unsafe bool SetStreamMetadataNV(EGLDisplay dpy, EGLStreamKHR stream, int n, int offset, int size, IntPtr data)
            {
                bool returnValue_bool;
                void* data_vptr = (void*)data;
                int returnValue;
                returnValue = SetStreamMetadataNV(dpy, stream, n, offset, size, data_vptr);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetStreamMetadataNV(EGLDisplay, EGLStreamKHR, int, int, int, void*)"/>
            public static unsafe bool SetStreamMetadataNV<T1>(EGLDisplay dpy, EGLStreamKHR stream, int n, int offset, int size, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* data_ptr = data)
                {
                    int returnValue;
                    returnValue = SetStreamMetadataNV(dpy, stream, n, offset, size, data_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetStreamMetadataNV(EGLDisplay, EGLStreamKHR, int, int, int, void*)"/>
            public static unsafe bool SetStreamMetadataNV<T1>(EGLDisplay dpy, EGLStreamKHR stream, int n, int offset, int size, T1[] data)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* data_ptr = data)
                {
                    int returnValue;
                    returnValue = SetStreamMetadataNV(dpy, stream, n, offset, size, data_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SetStreamMetadataNV(EGLDisplay, EGLStreamKHR, int, int, int, void*)"/>
            public static unsafe bool SetStreamMetadataNV<T1>(EGLDisplay dpy, EGLStreamKHR stream, int n, int offset, int size, ref readonly T1 data)
                where T1 : unmanaged
            {
                bool returnValue_bool;
                fixed (void* data_ptr = &data)
                {
                    int returnValue;
                    returnValue = SetStreamMetadataNV(dpy, stream, n, offset, size, data_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="SignalSyncNV_(EGLSyncNV, SyncStatus)"/>
            public static unsafe bool SignalSyncNV(EGLSyncNV sync, SyncStatus mode)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = SignalSyncNV_(sync, mode);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamAcquireImageNV(EGLDisplay, EGLStreamKHR, EGLImage*, EGLSync)"/>
            public static unsafe bool StreamAcquireImageNV(EGLDisplay dpy, EGLStreamKHR stream, Span<EGLImage> pImage, EGLSync sync)
            {
                bool returnValue_bool;
                fixed (EGLImage* pImage_ptr = pImage)
                {
                    int returnValue;
                    returnValue = StreamAcquireImageNV(dpy, stream, pImage_ptr, sync);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamAcquireImageNV(EGLDisplay, EGLStreamKHR, EGLImage*, EGLSync)"/>
            public static unsafe bool StreamAcquireImageNV(EGLDisplay dpy, EGLStreamKHR stream, EGLImage[] pImage, EGLSync sync)
            {
                bool returnValue_bool;
                fixed (EGLImage* pImage_ptr = pImage)
                {
                    int returnValue;
                    returnValue = StreamAcquireImageNV(dpy, stream, pImage_ptr, sync);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamAcquireImageNV(EGLDisplay, EGLStreamKHR, EGLImage*, EGLSync)"/>
            public static unsafe bool StreamAcquireImageNV(EGLDisplay dpy, EGLStreamKHR stream, ref EGLImage pImage, EGLSync sync)
            {
                bool returnValue_bool;
                fixed (EGLImage* pImage_ptr = &pImage)
                {
                    int returnValue;
                    returnValue = StreamAcquireImageNV(dpy, stream, pImage_ptr, sync);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerGLTextureExternalAttribsNV(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerGLTextureExternalAttribsNV(EGLDisplay dpy, EGLStreamKHR stream, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerGLTextureExternalAttribsNV(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerGLTextureExternalAttribsNV(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerGLTextureExternalAttribsNV(EGLDisplay dpy, EGLStreamKHR stream, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerGLTextureExternalAttribsNV(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamConsumerGLTextureExternalAttribsNV(EGLDisplay, EGLStreamKHR, IntPtr*)"/>
            public static unsafe bool StreamConsumerGLTextureExternalAttribsNV(EGLDisplay dpy, EGLStreamKHR stream, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = StreamConsumerGLTextureExternalAttribsNV(dpy, stream, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamFlushNV_(EGLDisplay, EGLStreamKHR)"/>
            public static unsafe bool StreamFlushNV(EGLDisplay dpy, EGLStreamKHR stream)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamFlushNV_(dpy, stream);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamImageConsumerConnectNV(EGLDisplay, EGLStreamKHR, int, ulong*, IntPtr*)"/>
            public static unsafe bool StreamImageConsumerConnectNV(EGLDisplay dpy, EGLStreamKHR stream, int num_modifiers, ReadOnlySpan<ulong> modifiers, ReadOnlySpan<IntPtr> attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    fixed (ulong* modifiers_ptr = modifiers)
                    {
                        int returnValue;
                        returnValue = StreamImageConsumerConnectNV(dpy, stream, num_modifiers, modifiers_ptr, attrib_list_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamImageConsumerConnectNV(EGLDisplay, EGLStreamKHR, int, ulong*, IntPtr*)"/>
            public static unsafe bool StreamImageConsumerConnectNV(EGLDisplay dpy, EGLStreamKHR stream, int num_modifiers, ulong[] modifiers, IntPtr[] attrib_list)
            {
                bool returnValue_bool;
                fixed (IntPtr* attrib_list_ptr = attrib_list)
                {
                    fixed (ulong* modifiers_ptr = modifiers)
                    {
                        int returnValue;
                        returnValue = StreamImageConsumerConnectNV(dpy, stream, num_modifiers, modifiers_ptr, attrib_list_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamImageConsumerConnectNV(EGLDisplay, EGLStreamKHR, int, ulong*, IntPtr*)"/>
            public static unsafe bool StreamImageConsumerConnectNV(EGLDisplay dpy, EGLStreamKHR stream, int num_modifiers, ref readonly ulong modifiers, ref readonly IntPtr attrib_list)
            {
                bool returnValue_bool;
                fixed (ulong* modifiers_ptr = &modifiers)
                fixed (IntPtr* attrib_list_ptr = &attrib_list)
                {
                    int returnValue;
                    returnValue = StreamImageConsumerConnectNV(dpy, stream, num_modifiers, modifiers_ptr, attrib_list_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="StreamReleaseImageNV_(EGLDisplay, EGLStreamKHR, EGLImage, EGLSync)"/>
            public static unsafe bool StreamReleaseImageNV(EGLDisplay dpy, EGLStreamKHR stream, EGLImage image, EGLSync sync)
            {
                bool returnValue_bool;
                int returnValue;
                returnValue = StreamReleaseImageNV_(dpy, stream, image, sync);
                returnValue_bool = returnValue != 0;
                return returnValue_bool;
            }
        }
        public static unsafe partial class WL
        {
            /// <inheritdoc cref="BindWaylandDisplayWL(EGLDisplay, IntPtr*)"/>
            public static unsafe bool BindWaylandDisplayWL(EGLDisplay dpy, Span<IntPtr> display)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_ptr = display)
                {
                    int returnValue;
                    returnValue = BindWaylandDisplayWL(dpy, display_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="BindWaylandDisplayWL(EGLDisplay, IntPtr*)"/>
            public static unsafe bool BindWaylandDisplayWL(EGLDisplay dpy, IntPtr[] display)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_ptr = display)
                {
                    int returnValue;
                    returnValue = BindWaylandDisplayWL(dpy, display_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="BindWaylandDisplayWL(EGLDisplay, IntPtr*)"/>
            public static unsafe bool BindWaylandDisplayWL(EGLDisplay dpy, ref IntPtr display)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_ptr = &display)
                {
                    int returnValue;
                    returnValue = BindWaylandDisplayWL(dpy, display_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryWaylandBufferWL(EGLDisplay, IntPtr*, int, int*)"/>
            public static unsafe bool QueryWaylandBufferWL(EGLDisplay dpy, Span<IntPtr> buffer, int attribute, Span<int> value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    fixed (IntPtr* buffer_ptr = buffer)
                    {
                        int returnValue;
                        returnValue = QueryWaylandBufferWL(dpy, buffer_ptr, attribute, value_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryWaylandBufferWL(EGLDisplay, IntPtr*, int, int*)"/>
            public static unsafe bool QueryWaylandBufferWL(EGLDisplay dpy, IntPtr[] buffer, int attribute, int[] value)
            {
                bool returnValue_bool;
                fixed (int* value_ptr = value)
                {
                    fixed (IntPtr* buffer_ptr = buffer)
                    {
                        int returnValue;
                        returnValue = QueryWaylandBufferWL(dpy, buffer_ptr, attribute, value_ptr);
                        returnValue_bool = returnValue != 0;
                    }
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="QueryWaylandBufferWL(EGLDisplay, IntPtr*, int, int*)"/>
            public static unsafe bool QueryWaylandBufferWL(EGLDisplay dpy, ref IntPtr buffer, int attribute, ref int value)
            {
                bool returnValue_bool;
                fixed (IntPtr* buffer_ptr = &buffer)
                fixed (int* value_ptr = &value)
                {
                    int returnValue;
                    returnValue = QueryWaylandBufferWL(dpy, buffer_ptr, attribute, value_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnbindWaylandDisplayWL(EGLDisplay, IntPtr*)"/>
            public static unsafe bool UnbindWaylandDisplayWL(EGLDisplay dpy, Span<IntPtr> display)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_ptr = display)
                {
                    int returnValue;
                    returnValue = UnbindWaylandDisplayWL(dpy, display_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnbindWaylandDisplayWL(EGLDisplay, IntPtr*)"/>
            public static unsafe bool UnbindWaylandDisplayWL(EGLDisplay dpy, IntPtr[] display)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_ptr = display)
                {
                    int returnValue;
                    returnValue = UnbindWaylandDisplayWL(dpy, display_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
            /// <inheritdoc cref="UnbindWaylandDisplayWL(EGLDisplay, IntPtr*)"/>
            public static unsafe bool UnbindWaylandDisplayWL(EGLDisplay dpy, ref IntPtr display)
            {
                bool returnValue_bool;
                fixed (IntPtr* display_ptr = &display)
                {
                    int returnValue;
                    returnValue = UnbindWaylandDisplayWL(dpy, display_ptr);
                    returnValue_bool = returnValue != 0;
                }
                return returnValue_bool;
            }
        }
    }
}
