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
using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    // Note: the Workaround structs declared in each type below work around
    // gmcs 2.4.2 bug #530270 (https://bugzilla.novell.com/show_bug.cgi?id=530270).
    // They don't cause any change in functionality other than make the compiler happy.
    
    struct EGLNativeDisplayType
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }

        public readonly Compute.Handle<Workaround> Handle;

        public EGLNativeDisplayType(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }

        public static readonly EGLNativeDisplayType Default = new EGLNativeDisplayType();
    }

    struct EGLNativePixmapType
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }
        
       public readonly Compute.Handle<Workaround> Handle;

        public EGLNativePixmapType(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }
    }

    struct EGLConfig
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }
        
       public readonly Compute.Handle<Workaround> Handle;

        public EGLConfig(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }
    }

    struct EGLContext
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }

        public readonly Compute.Handle<Workaround> Handle;

        public EGLContext(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }

        public static readonly EGLContext None;
    }

    struct EGLDisplay
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }

        public readonly Compute.Handle<Workaround> Handle;

        public EGLDisplay(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }

        public static readonly EGLDisplay Null = default(EGLDisplay);
    }

    struct EGLSurface
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }

        public readonly Compute.Handle<Workaround> Handle;

        public EGLSurface(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }

        public static readonly EGLSurface None = default(EGLSurface);
    }

    struct EGLClientBuffer
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public struct Workaround { }

        public readonly Compute.Handle<Workaround> Handle;

        public EGLClientBuffer(IntPtr handle)
        {
            Handle = new Compute.Handle<Workaround>(handle);
        }
    }

    static partial class Egl
    {
        public const int VERSION_1_0 = 1;
        public const int VERSION_1_1 = 1;
        public const int VERSION_1_2 = 1;
        public const int VERSION_1_3 = 1;
        public const int VERSION_1_4 = 1;
        public const int FALSE = 0;
        public const int TRUE = 1;
        public const int DONT_CARE = -1;
        public const int SUCCESS = 12288;
        public const int NOT_INITIALIZED = 12289;
        public const int BAD_ACCESS = 12290;
        public const int BAD_ALLOC = 12291;
        public const int BAD_ATTRIBUTE = 12292;
        public const int BAD_CONFIG = 12293;
        public const int BAD_CONTEXT = 12294;
        public const int BAD_CURRENT_SURFACE = 12295;
        public const int BAD_DISPLAY = 12296;
        public const int BAD_MATCH = 12297;
        public const int BAD_NATIVE_PIXMAP = 12298;
        public const int BAD_NATIVE_WINDOW = 12299;
        public const int BAD_PARAMETER = 12300;
        public const int BAD_SURFACE = 12301;
        public const int CONTEXT_LOST = 12302;
        public const int BUFFER_SIZE = 12320;
        public const int ALPHA_SIZE = 12321;
        public const int BLUE_SIZE = 12322;
        public const int GREEN_SIZE = 12323;
        public const int RED_SIZE = 12324;
        public const int DEPTH_SIZE = 12325;
        public const int STENCIL_SIZE = 12326;
        public const int CONFIG_CAVEAT = 12327;
        public const int CONFIG_ID = 12328;
        public const int LEVEL = 12329;
        public const int MAX_PBUFFER_HEIGHT = 12330;
        public const int MAX_PBUFFER_PIXELS = 12331;
        public const int MAX_PBUFFER_WIDTH = 12332;
        public const int NATIVE_RENDERABLE = 12333;
        public const int NATIVE_VISUAL_ID = 12334;
        public const int NATIVE_VISUAL_TYPE = 12335;
        public const int PRESERVED_RESOURCES = 12336;
        public const int SAMPLES = 12337;
        public const int SAMPLE_BUFFERS = 12338;
        public const int SURFACE_TYPE = 12339;
        public const int TRANSPARENT_TYPE = 12340;
        public const int TRANSPARENT_BLUE_VALUE = 12341;
        public const int TRANSPARENT_GREEN_VALUE = 12342;
        public const int TRANSPARENT_RED_VALUE = 12343;
        public const int NONE = 12344;
        public const int BIND_TO_TEXTURE_RGB = 12345;
        public const int BIND_TO_TEXTURE_RGBA = 12346;
        public const int MIN_SWAP_INTERVAL = 12347;
        public const int MAX_SWAP_INTERVAL = 12348;
        public const int LUMINANCE_SIZE = 12349;
        public const int ALPHA_MASK_SIZE = 12350;
        public const int COLOR_BUFFER_TYPE = 12351;
        public const int RENDERABLE_TYPE = 12352;
        public const int MATCH_NATIVE_PIXMAP = 12353;
        public const int CONFORMANT = 12354;
        public const int SLOW_CONFIG = 12368;
        public const int NON_CONFORMANT_CONFIG = 12369;
        public const int TRANSPARENT_RGB = 12370;
        public const int RGB_BUFFER = 12430;
        public const int LUMINANCE_BUFFER = 12431;
        public const int NO_TEXTURE = 12380;
        public const int TEXTURE_RGB = 12381;
        public const int TEXTURE_RGBA = 12382;
        public const int TEXTURE_2D = 12383;
        public const int PBUFFER_BIT = 1;
        public const int PIXMAP_BIT = 2;
        public const int WINDOW_BIT = 4;
        public const int VG_COLORSPACE_LINEAR_BIT = 32;
        public const int VG_ALPHA_FORMAT_PRE_BIT = 64;
        public const int MULTISAMPLE_RESOLVE_BOX_BIT = 512;
        public const int SWAP_BEHAVIOR_PRESERVED_BIT = 1024;
        public const int OPENGL_ES_BIT = 1;
        public const int OPENVG_BIT = 2;
        public const int OPENGL_ES2_BIT = 4;
        public const int OPENGL_BIT = 8;
        public const int VENDOR = 12371;
        public const int VERSION = 12372;
        public const int EXTENSIONS = 12373;
        public const int CLIENT_APIS = 12429;
        public const int HEIGHT = 12374;
        public const int WIDTH = 12375;
        public const int LARGEST_PBUFFER = 12376;
        public const int TEXTURE_FORMAT = 12416;
        public const int TEXTURE_TARGET = 12417;
        public const int MIPMAP_TEXTURE = 12418;
        public const int MIPMAP_LEVEL = 12419;
        public const int RENDER_BUFFER = 12422;
        public const int VG_COLORSPACE = 12423;
        public const int VG_ALPHA_FORMAT = 12424;
        public const int HORIZONTAL_RESOLUTION = 12432;
        public const int VERTICAL_RESOLUTION = 12433;
        public const int PIXEL_ASPECT_RATIO = 12434;
        public const int SWAP_BEHAVIOR = 12435;
        public const int MULTISAMPLE_RESOLVE = 12441;
        public const int BACK_BUFFER = 12420;
        public const int SINGLE_BUFFER = 12421;
        public const int VG_COLORSPACE_sRGB = 12425;
        public const int VG_COLORSPACE_LINEAR = 12426;
        public const int VG_ALPHA_FORMAT_NONPRE = 12427;
        public const int VG_ALPHA_FORMAT_PRE = 12428;
        public const int DISPLAY_SCALING = 10000;
        public const int UNKNOWN = -1;
        public const int BUFFER_PRESERVED = 12436;
        public const int BUFFER_DESTROYED = 12437;
        public const int OPENVG_IMAGE = 12438;
        public const int CONTEXT_CLIENT_TYPE = 12439;
        public const int CONTEXT_CLIENT_VERSION = 12440;
        public const int MULTISAMPLE_RESOLVE_DEFAULT = 12442;
        public const int MULTISAMPLE_RESOLVE_BOX = 12443;
        public const int OPENGL_ES_API = 12448;
        public const int OPENVG_API = 12449;
        public const int OPENGL_API = 12450;
        public const int DRAW = 12377;
        public const int READ = 12378;
        public const int CORE_NATIVE_ENGINE = 12379;
        public const int COLORSPACE = VG_COLORSPACE;
        public const int ALPHA_FORMAT = VG_ALPHA_FORMAT;
        public const int COLORSPACE_sRGB = VG_COLORSPACE_sRGB;
        public const int COLORSPACE_LINEAR = VG_COLORSPACE_LINEAR;
        public const int ALPHA_FORMAT_NONPRE = VG_ALPHA_FORMAT_NONPRE;
        public const int ALPHA_FORMAT_PRE = VG_ALPHA_FORMAT_PRE;

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetError")]
        public static extern int GetError();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetDisplay")]
        static extern IntPtr eglGetDisplay(EGLNativeDisplayType display_id);

        public static EGLDisplay GetDisplay(EGLNativeDisplayType display_id)
        {
            IntPtr ptr = eglGetDisplay(display_id);
            EGLDisplay ret = new EGLDisplay(ptr);
            return ret;
        }

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglInitialize")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool Initialize(EGLDisplay dpy, out int major, out int minor);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglTerminate")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool Terminate(EGLDisplay dpy);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglQueryString")]
        public static extern IntPtr QueryString(EGLDisplay dpy, int name);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetConfigs")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool GetConfigs(EGLDisplay dpy, EGLConfig[] configs, int config_size, out int num_config);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglChooseConfig")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool ChooseConfig(EGLDisplay dpy, int[] attrib_list, [In, Out] EGLConfig[] configs, int config_size, out int num_config);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetConfigAttrib")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool GetConfigAttrib(EGLDisplay dpy, EGLConfig config, int attribute, out int value);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCreateWindowSurface")]
        static extern IntPtr eglCreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, int[] attrib_list);

        public static EGLSurface CreateWindowSurface(EGLDisplay dpy, EGLConfig config, IntPtr win, int[] attrib_list)
        {
            IntPtr ptr = eglCreateWindowSurface(dpy, config,  win, attrib_list);
            EGLSurface ret = new EGLSurface(ptr);
            return ret;
        }

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCreatePbufferSurface")]
        public static extern EGLSurface CreatePbufferSurface(EGLDisplay dpy, EGLConfig config, int[] attrib_list);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCreatePixmapSurface")]
        public static extern EGLSurface CreatePixmapSurface(EGLDisplay dpy, EGLConfig config, EGLNativePixmapType pixmap, int[] attrib_list);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglDestroySurface")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool DestroySurface(EGLDisplay dpy, EGLSurface surface);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglQuerySurface")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool QuerySurface(EGLDisplay dpy, EGLSurface surface, int attribute, out int value);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglBindAPI")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool BindAPI(int api);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglQueryAPI")]
        public static extern int QueryAPI();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglWaitClient")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool WaitClient();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglReleaseThread")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool ReleaseThread();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCreatePbufferFromClientBuffer")]
        public static extern EGLSurface CreatePbufferFromClientBuffer(EGLDisplay dpy, int buftype, EGLClientBuffer buffer, EGLConfig config, int[] attrib_list);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglSurfaceAttrib")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SurfaceAttrib(EGLDisplay dpy, EGLSurface surface, int attribute, int value);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglBindTexImage")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool BindTexImage(EGLDisplay dpy, EGLSurface surface, int buffer);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglReleaseTexImage")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool ReleaseTexImage(EGLDisplay dpy, EGLSurface surface, int buffer);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglSwapInterval")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SwapInterval(EGLDisplay dpy, int interval);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCreateContext")]
        static extern IntPtr eglCreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, int[] attrib_list);

        public static EGLContext CreateContext(EGLDisplay dpy, EGLConfig config, EGLContext share_context, int[] attrib_list)
        {
            IntPtr ptr = eglCreateContext(dpy, config, share_context, attrib_list);
            if (ptr == EGLContext.None.Handle.Value)
                throw new GraphicsContextException(String.Format("Failed to create EGL context, error: {0}.", Egl.GetError()));
            return new EGLContext(ptr);
        }

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglDestroyContext")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool DestroyContext(EGLDisplay dpy, EGLContext ctx);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglMakeCurrent")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool MakeCurrent(EGLDisplay dpy, EGLSurface draw, EGLSurface read, EGLContext ctx);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetCurrentContext")]
        public static extern EGLContext GetCurrentContext();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetCurrentSurface")]
        public static extern EGLSurface GetCurrentSurface(int readdraw);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglGetCurrentDisplay")]
        public static extern EGLDisplay GetCurrentDisplay();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglQueryContext")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool QueryContext(EGLDisplay dpy, EGLContext ctx, int attribute, out int value);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglWaitGL")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool WaitGL();

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglWaitNative")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool WaitNative(int engine);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglSwapBuffers")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool SwapBuffers(EGLDisplay dpy, EGLSurface surface);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCopyBuffers")]
        [return: MarshalAsAttribute(UnmanagedType.I1)]
        public static extern bool CopyBuffers(EGLDisplay dpy, EGLSurface surface, EGLNativePixmapType target);

        [DllImportAttribute("libEGL.dll", EntryPoint = "eglCopyBuffers")]
        public static extern IntPtr GetProcAddress(string funcname);

        // Returns true if Egl drivers exist on the system.
        public static bool IsSupported
        {
            get
            {
                try { GetCurrentContext(); }
                catch (Exception) { return false;  }
                return true;
            }
        }

    }
#pragma warning restore 0169
}