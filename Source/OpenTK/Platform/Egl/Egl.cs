#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Egl
{
    struct EGLNativeDisplayType
    {
        public readonly Compute.Handle<EGLNativeDisplayType> Handle;

        public EGLNativeDisplayType(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLNativeDisplayType>(handle);
        }
    }

    struct EGLNativePixmapType
    {
       public readonly Compute.Handle<EGLNativePixmapType> Handle;

        public EGLNativePixmapType(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLNativePixmapType>(handle);
        }
    }

    struct EGLConfig
    {
       public readonly Compute.Handle<EGLConfig> Handle;

        public EGLConfig(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLConfig>(handle);
        }
    }

    struct EGLContext
    {
        public readonly Compute.Handle<EGLContext> Handle;

        public EGLContext(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLContext>(handle);
        }

        public static readonly EGLContext None;
    }

    struct EGLDisplay
    {
        public readonly Compute.Handle<EGLDisplay> Handle;

        public EGLDisplay(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLDisplay>(handle);
        }

        public static readonly EGLDisplay Null;
    }

    struct EGLSurface
    {
        public readonly Compute.Handle<EGLSurface> Handle;

        public EGLSurface(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLSurface>(handle);
        }

        public static readonly EGLSurface None;
    }

    struct EGLClientBuffer
    {
        public readonly Compute.Handle<EGLClientBuffer> Handle;

        public EGLClientBuffer(IntPtr handle)
        {
            Handle = new Compute.Handle<EGLClientBuffer>(handle);
        }
    }

    static partial class Egl
    {
        public const int EGL_VERSION_1_0 = 1;
        public const int EGL_VERSION_1_1 = 1;
        public const int EGL_VERSION_1_2 = 1;
        public const int EGL_VERSION_1_3 = 1;
        public const int EGL_VERSION_1_4 = 1;
        public const int EGL_FALSE = 0;
        public const int EGL_TRUE = 1;
        public const int EGL_DONT_CARE = -1;
        public const int EGL_SUCCESS = 12288;
        public const int EGL_NOT_INITIALIZED = 12289;
        public const int EGL_BAD_ACCESS = 12290;
        public const int EGL_BAD_ALLOC = 12291;
        public const int EGL_BAD_ATTRIBUTE = 12292;
        public const int EGL_BAD_CONFIG = 12293;
        public const int EGL_BAD_CONTEXT = 12294;
        public const int EGL_BAD_CURRENT_SURFACE = 12295;
        public const int EGL_BAD_DISPLAY = 12296;
        public const int EGL_BAD_MATCH = 12297;
        public const int EGL_BAD_NATIVE_PIXMAP = 12298;
        public const int EGL_BAD_NATIVE_WINDOW = 12299;
        public const int EGL_BAD_PARAMETER = 12300;
        public const int EGL_BAD_SURFACE = 12301;
        public const int EGL_CONTEXT_LOST = 12302;
        public const int EGL_BUFFER_SIZE = 12320;
        public const int EGL_ALPHA_SIZE = 12321;
        public const int EGL_BLUE_SIZE = 12322;
        public const int EGL_GREEN_SIZE = 12323;
        public const int EGL_RED_SIZE = 12324;
        public const int EGL_DEPTH_SIZE = 12325;
        public const int EGL_STENCIL_SIZE = 12326;
        public const int EGL_CONFIG_CAVEAT = 12327;
        public const int EGL_CONFIG_ID = 12328;
        public const int EGL_LEVEL = 12329;
        public const int EGL_MAX_PBUFFER_HEIGHT = 12330;
        public const int EGL_MAX_PBUFFER_PIXELS = 12331;
        public const int EGL_MAX_PBUFFER_WIDTH = 12332;
        public const int EGL_NATIVE_RENDERABLE = 12333;
        public const int EGL_NATIVE_VISUAL_ID = 12334;
        public const int EGL_NATIVE_VISUAL_TYPE = 12335;
        public const int EGL_PRESERVED_RESOURCES = 12336;
        public const int EGL_SAMPLES = 12337;
        public const int EGL_SAMPLE_BUFFERS = 12338;
        public const int EGL_SURFACE_TYPE = 12339;
        public const int EGL_TRANSPARENT_TYPE = 12340;
        public const int EGL_TRANSPARENT_BLUE_VALUE = 12341;
        public const int EGL_TRANSPARENT_GREEN_VALUE = 12342;
        public const int EGL_TRANSPARENT_RED_VALUE = 12343;
        public const int EGL_NONE = 12344;
        public const int EGL_BIND_TO_TEXTURE_RGB = 12345;
        public const int EGL_BIND_TO_TEXTURE_RGBA = 12346;
        public const int EGL_MIN_SWAP_INTERVAL = 12347;
        public const int EGL_MAX_SWAP_INTERVAL = 12348;
        public const int EGL_LUMINANCE_SIZE = 12349;
        public const int EGL_ALPHA_MASK_SIZE = 12350;
        public const int EGL_COLOR_BUFFER_TYPE = 12351;
        public const int EGL_RENDERABLE_TYPE = 12352;
        public const int EGL_MATCH_NATIVE_PIXMAP = 12353;
        public const int EGL_CONFORMANT = 12354;
        public const int EGL_SLOW_CONFIG = 12368;
        public const int EGL_NON_CONFORMANT_CONFIG = 12369;
        public const int EGL_TRANSPARENT_RGB = 12370;
        public const int EGL_RGB_BUFFER = 12430;
        public const int EGL_LUMINANCE_BUFFER = 12431;
        public const int EGL_NO_TEXTURE = 12380;
        public const int EGL_TEXTURE_RGB = 12381;
        public const int EGL_TEXTURE_RGBA = 12382;
        public const int EGL_TEXTURE_2D = 12383;
        public const int EGL_PBUFFER_BIT = 1;
        public const int EGL_PIXMAP_BIT = 2;
        public const int EGL_WINDOW_BIT = 4;
        public const int EGL_VG_COLORSPACE_LINEAR_BIT = 32;
        public const int EGL_VG_ALPHA_FORMAT_PRE_BIT = 64;
        public const int EGL_MULTISAMPLE_RESOLVE_BOX_BIT = 512;
        public const int EGL_SWAP_BEHAVIOR_PRESERVED_BIT = 1024;
        public const int EGL_OPENGL_ES_BIT = 1;
        public const int EGL_OPENVG_BIT = 2;
        public const int EGL_OPENGL_ES2_BIT = 4;
        public const int EGL_OPENGL_BIT = 8;
        public const int EGL_VENDOR = 12371;
        public const int EGL_VERSION = 12372;
        public const int EGL_EXTENSIONS = 12373;
        public const int EGL_CLIENT_APIS = 12429;
        public const int EGL_HEIGHT = 12374;
        public const int EGL_WIDTH = 12375;
        public const int EGL_LARGEST_PBUFFER = 12376;
        public const int EGL_TEXTURE_FORMAT = 12416;
        public const int EGL_TEXTURE_TARGET = 12417;
        public const int EGL_MIPMAP_TEXTURE = 12418;
        public const int EGL_MIPMAP_LEVEL = 12419;
        public const int EGL_RENDER_BUFFER = 12422;
        public const int EGL_VG_COLORSPACE = 12423;
        public const int EGL_VG_ALPHA_FORMAT = 12424;
        public const int EGL_HORIZONTAL_RESOLUTION = 12432;
        public const int EGL_VERTICAL_RESOLUTION = 12433;
        public const int EGL_PIXEL_ASPECT_RATIO = 12434;
        public const int EGL_SWAP_BEHAVIOR = 12435;
        public const int EGL_MULTISAMPLE_RESOLVE = 12441;
        public const int EGL_BACK_BUFFER = 12420;
        public const int EGL_SINGLE_BUFFER = 12421;
        public const int EGL_VG_COLORSPACE_sRGB = 12425;
        public const int EGL_VG_COLORSPACE_LINEAR = 12426;
        public const int EGL_VG_ALPHA_FORMAT_NONPRE = 12427;
        public const int EGL_VG_ALPHA_FORMAT_PRE = 12428;
        public const int EGL_DISPLAY_SCALING = 10000;
        public const int EGL_UNKNOWN = -1;
        public const int EGL_BUFFER_PRESERVED = 12436;
        public const int EGL_BUFFER_DESTROYED = 12437;
        public const int EGL_OPENVG_IMAGE = 12438;
        public const int EGL_CONTEXT_CLIENT_TYPE = 12439;
        public const int EGL_CONTEXT_CLIENT_VERSION = 12440;
        public const int EGL_MULTISAMPLE_RESOLVE_DEFAULT = 12442;
        public const int EGL_MULTISAMPLE_RESOLVE_BOX = 12443;
        public const int EGL_OPENGL_ES_API = 12448;
        public const int EGL_OPENVG_API = 12449;
        public const int EGL_OPENGL_API = 12450;
        public const int EGL_DRAW = 12377;
        public const int EGL_READ = 12378;
        public const int EGL_CORE_NATIVE_ENGINE = 12379;
        public const int EGL_COLORSPACE = EGL_VG_COLORSPACE;
        public const int EGL_ALPHA_FORMAT = EGL_VG_ALPHA_FORMAT;
        public const int EGL_COLORSPACE_sRGB = EGL_VG_COLORSPACE_sRGB;
        public const int EGL_COLORSPACE_LINEAR = EGL_VG_COLORSPACE_LINEAR;
        public const int EGL_ALPHA_FORMAT_NONPRE = EGL_VG_ALPHA_FORMAT_NONPRE;
        public const int EGL_ALPHA_FORMAT_PRE = EGL_VG_ALPHA_FORMAT_PRE;

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetError")]
        public static extern int GetError();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetDisplay")]
        static extern IntPtr eglGetDisplay(EGLNativeDisplayType display_id);

        public static EGLDisplay GetDisplay(EGLNativeDisplayType display_id)
        {
            IntPtr ptr = eglGetDisplay(display_id);
            EGLDisplay ret = new EGLDisplay(ptr);
            return ret;
        }

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglInitialize")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool Initialize(EGLDisplay dpy, out int major, out int minor);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglTerminate")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool Terminate(EGLDisplay dpy);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglQueryString")]
        public static extern IntPtr QueryString(EGLDisplay dpy, int name);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetConfigs")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool GetConfigs(EGLDisplay dpy, EGLConfig[] configs, int config_size, out int num_config);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglChooseConfig")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool ChooseConfig(EGLDisplay dpy, int[] attrib_list, EGLConfig[] configs, int config_size, out int num_config);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetConfigAttrib")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool GetConfigAttrib(EGLDisplay dpy, EGLConfig config, int attribute, out int value);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglCreateWindowSurface")]
        static extern IntPtr eglCreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, int[] attrib_list);

        public static EGLSurface CreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, int[] attrib_list)
        {
            IntPtr ptr = eglCreateWindowSurface(dpy, config,  win, attrib_list);
            EGLSurface ret = new EGLSurface(ptr);
            return ret;
        }

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglCreatePbufferSurface")]
        public static extern EGLSurface CreatePbufferSurface(EGLDisplay dpy, EGLConfig config, int[] attrib_list);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglCreatePixmapSurface")]
        public static extern EGLSurface CreatePixmapSurface(EGLDisplay dpy, EGLConfig config, EGLNativePixmapType pixmap, int[] attrib_list);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglDestroySurface")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool DestroySurface(EGLDisplay dpy, EGLSurface surface);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglQuerySurface")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool QuerySurface(EGLDisplay dpy, EGLSurface surface, int attribute, out int value);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglBindAPI")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool BindAPI(int api);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglQueryAPI")]
        public static extern int QueryAPI();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglWaitClient")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool WaitClient();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglReleaseThread")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool ReleaseThread();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglCreatePbufferFromClientBuffer")]
        public static extern EGLSurface CreatePbufferFromClientBuffer(EGLDisplay dpy, int buftype, EGLClientBuffer buffer, EGLConfig config, int[] attrib_list);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglSurfaceAttrib")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SurfaceAttrib(EGLDisplay dpy, EGLSurface surface, int attribute, int value);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglBindTexImage")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool BindTexImage(EGLDisplay dpy, EGLSurface surface, int buffer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglReleaseTexImage")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool ReleaseTexImage(EGLDisplay dpy, EGLSurface surface, int buffer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglSwapInterval")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SwapInterval(EGLDisplay dpy, int interval);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglCreateContext")]
        static extern IntPtr eglCreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, int[] attrib_list);

        public static EGLContext CreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, int[] attrib_list)
        {
            IntPtr ptr = eglCreateContext(dpy, config, share_context, attrib_list);
            EGLContext ret = new EGLContext(ptr);
            return ret;
        }

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglDestroyContext")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool DestroyContext(EGLDisplay dpy, EGLContext ctx);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglMakeCurrent")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool MakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetCurrentContext")]
        public static extern EGLContext GetCurrentContext();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetCurrentSurface")]
        public static extern EGLSurface GetCurrentSurface(int readdraw);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglGetCurrentDisplay")]
        public static extern EGLDisplay GetCurrentDisplay();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglQueryContext")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool QueryContext(EGLDisplay dpy, EGLContext ctx, int attribute, out int value);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglWaitGL")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool WaitGL();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglWaitNative")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool WaitNative(int engine);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglSwapBuffers")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SwapBuffers(EGLDisplay dpy, EGLSurface surface);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "eglCopyBuffers")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool CopyBuffers(EGLDisplay dpy, EGLSurface surface, EGLNativePixmapType target);

    }
#pragma warning restore 0169
}