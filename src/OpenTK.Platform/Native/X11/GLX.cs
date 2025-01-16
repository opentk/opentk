using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    internal static class GLX
    {
        private const string glx = "GL";

        static GLX()
        {
            DllResolver.InitLoader();
        }

        internal const int GLX_USE_GL = 1;
        internal const int GLX_BUFFER_SIZE = 2;
        internal const int GLX_LEVEL = 3;
        internal const int GLX_RGBA = 4;
        internal const int GLX_DOUBLEBUFFER = 5;
        internal const int GLX_STEREO = 6;
        internal const int GLX_AUX_BUFFERS = 7;
        internal const int GLX_RED_SIZE = 8;
        internal const int GLX_GREEN_SIZE = 9;
        internal const int GLX_BLUE_SIZE = 10;
        internal const int GLX_ALPHA_SIZE = 11;
        internal const int GLX_DEPTH_SIZE = 12;
        internal const int GLX_STENCIL_SIZE = 13;
        internal const int GLX_ACCUM_RED_SIZE = 14;
        internal const int GLX_ACCUM_GREEN_SIZE = 15;
        internal const int GLX_ACCUM_BLUE_SIZE = 16;
        internal const int GLX_ACCUM_ALPHA_SIZE = 17;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe XVisualInfo* glXChooseVisual(XDisplayPtr display, int screen, int[] attributeList);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe GLXWindow glXCreateWindow(XDisplayPtr display, GLXFBConfig config, XWindow window, IntPtr attrib_list);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXDestroyWindow(XDisplayPtr dpy, GLXWindow win);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GLXContext glXCreateContext(
            XDisplayPtr display,
            ref XVisualInfo visualInfo,
            GLXContext shareList,
            bool direct);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXDestroyContext(XDisplayPtr display, GLXContext context);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool glXMakeCurrent(XDisplayPtr display, GLXDrawable drawable, GLXContext context);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool glXMakeContextCurrent(XDisplayPtr display, GLXDrawable draw, GLXDrawable read, GLXContext ctx);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXCopyContext(
            XDisplayPtr display,
            GLXContext source,
            GLXContext destination,
            ulong mask);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXSwapBuffers(XDisplayPtr display, GLXDrawable drawable);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GLXPixmap glXCreateGLXPixmap(XDisplayPtr display, ref XVisualInfo visualInfo, XPixmap pixMap);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXDestroyGLXPixmap(XDisplayPtr display, GLXPixmap pixMap);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool glXQueryExtension(XDisplayPtr display, out int errorBase, out int eventBase);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool glXQueryVersion(XDisplayPtr display, out int major, out int minor);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool glXIsDirect(XDisplayPtr display, GLXContext context);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe int glXGetConfig(
            XDisplayPtr display,
            XVisualInfo* visualInfo,
            int attribute,
            out int value);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GLXContext glXGetCurrentContext();

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern GLXDrawable glXGetCurrentDrawable();

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXWaitGL();

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXWaitX();


        #region GLX 1.1+

        internal const int GLX_VENDOR = 1;
        internal const int GLX_VERSION = 2;
        internal const int GLX_EXTENSIONS = 3;

        // FIXME: These functions will crash if they are made to LPStr functions.
        // I don't know why, but the runtime will free a string in ".rodata". :facepalm:

        internal static string glXQueryExtensionsString(XDisplayPtr display, int screen)
        {
            return Marshal.PtrToStringUTF8(glXQueryExtensionsString(display, screen))!;

            [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
            static extern IntPtr glXQueryExtensionsString(XDisplayPtr display, int screen);
        }

        internal static string glXQueryServerString(XDisplayPtr display, int screen, int name)
        {
            return Marshal.PtrToStringUTF8(glXQueryServerString(display, screen, name))!;

            [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
            static extern IntPtr glXQueryServerString(XDisplayPtr display, int screen, int name);
        }

        internal static string glXGetClientString(XDisplayPtr display, int name)
        {
            return Marshal.PtrToStringUTF8(glXGetClientString(display, name))!;

            [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
            static extern IntPtr glXGetClientString(XDisplayPtr display, int name);
        }

        #endregion

        #region GLX 1.2+

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern XDisplayPtr glXGetCurrentDisplay();

        #endregion

        #region GLX 1.3+

        internal const int GLX_CONFIG_CAVEAT = 0x20;
        internal const int GLX_DONT_CARE = unchecked((int)0xFFFFFFFF);
        internal const int GLX_X_VISUAL_TYPE = 0x22;
        internal const int GLX_TRANSPARENT_TYPE = 0x23;
        internal const int GLX_TRANSPARENT_INDEX_VALUE = 0x24;
        internal const int GLX_TRANSPARENT_RED_VALUE = 0x25;
        internal const int GLX_TRANSPARENT_GREEN_VALUE = 0x26;
        internal const int GLX_TRANSPARENT_BLUE_VALUE = 0x27;
        internal const int GLX_TRANSPARENT_ALPHA_VALUE = 0x28;
        internal const int GLX_WINDOW_BIT = 0x1;
        internal const int GLX_PIXMAP_BIT = 0x2;
        internal const int GLX_PBUFFER_BIT = 0x4;
        internal const int GLX_AUX_BUFFERS_BIT = 0x10;
        internal const int GLX_FRONT_LEFT_BUFFER_BIT = 0x1;
        internal const int GLX_FRONT_RIGHT_BUFFER_BIT = 0x2;
        internal const int GLX_BACK_LEFT_BUFFER_BIT = 0x4;
        internal const int GLX_BACK_RIGHT_BUFFER_BIT = 0x8;
        internal const int GLX_DEPTH_BUFFER_BIT = 0x20;
        internal const int GLX_STENCIL_BUFFER_BIT = 0x40;
        internal const int GLX_ACCUM_BUFFER_BIT = 0x80;
        internal const int GLX_NONE = 0x8000;
        internal const int GLX_SLOW_CONFIG = 0x8001;
        internal const int GLX_TRUE_COLOR = 0x8002;
        internal const int GLX_DIRECT_COLOR = 0x8003;
        internal const int GLX_PSEUDO_COLOR = 0x8004;
        internal const int GLX_STATIC_COLOR = 0x8005;
        internal const int GLX_GRAY_SCALE = 0x8006;
        internal const int GLX_STATIC_GRAY = 0x8007;
        internal const int GLX_TRANSPARENT_RGB = 0x8008;
        internal const int GLX_TRANSPARENT_INDEX = 0x8009;
        internal const int GLX_VISUAL_ID = 0x800B;
        internal const int GLX_SCREEN = 0x800C;
        internal const int GLX_NON_CONFORMANT_CONFIG = 0x800D;
        internal const int GLX_DRAWABLE_TYPE = 0x8010;
        internal const int GLX_RENDER_TYPE = 0x8011;
        internal const int GLX_X_RENDERABLE = 0x8012;
        internal const int GLX_FBCONFIG_ID = 0x8013;
        internal const int GLX_RGBA_TYPE = 0x8014;
        internal const int GLX_COLOR_INDEX_TYPE = 0x8015;
        internal const int GLX_MAX_PBUFFER_WIDTH = 0x8016;
        internal const int GLX_MAX_PBUFFER_HEIGHT = 0x8017;
        internal const int GLX_MAX_PBUFFER_PIXELS = 0x8018;
        internal const int GLX_PRESEERVED_CONTENTS = 0x801B;
        internal const int GLX_LARGEST_PBUFFER = 0x801C;
        internal const int GLX_WIDTH = 0x801D;
        internal const int GLX_HEIGHT = 0x801E;
        internal const int GLX_EVENT_MASK = 0x801F;
        internal const int GLX_DAMAGED = 0x8020;
        internal const int GLX_SAVED = 0x8021;
        internal const int GLX_PBUFFER = 0x8023;
        internal const int GLX_PBUFFER_HEIGHT = 0x8040;
        internal const int GLX_PBUFFER_WIDTH = 0x8041;
        internal const int GLX_RGBA_BIT = 0x1;
        internal const int GLX_COLOR_INDEX_BIT = 0x2;
        internal const int GLX_PBUFFER_CLOBBER_MASK = 0x08000000;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe GLXFBConfig* glXChooseFBConfig(
            XDisplayPtr display,
            int screen,
            ref int attribList,
            ref int nItems);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int glXGetFBConfigAttrib(
            XDisplayPtr display,
            GLXFBConfig config,
            int attribute,
            out int value);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe GLXFBConfig* glXGetFBConfigs(XDisplayPtr display, int screen, out int elements);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe XVisualInfo* glXGetVisualFromFBConfig(XDisplayPtr display, GLXFBConfig config);

        // [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        // internal static extern GLXContext glXCreateNewContext(
        //     XDisplayPtr display,
        //     XDrawable drawable,
        //     int attribute,
        //     ref uint value);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern unsafe int glXQueryDrawable(XDisplayPtr dpy, GLXDrawable draw, int attribute, out uint value);

        #endregion

        #region GLX 1.4+

        internal const int GLX_SAMPLE_BUFFERS = 0x186a0;
        internal const int GLX_SAMPLES = 0x186a1;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr glXGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

        #endregion

        #region GLX_ARB_get_proc_address

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr glXGetProcAddressARB([MarshalAs(UnmanagedType.LPStr)] string procname);

        #endregion

        #region GLX_ARB_create_context and GLX_ARB_create_context_profile

        internal const int GLX_CONTEXT_MAJOR_VERSION_ARB = 0x2091;
        internal const int GLX_CONTEXT_MINOR_VERSION_ARB = 0x2092;
        internal const int GLX_CONTEXT_FLAGS_ARB = 0x2094;
        internal const int GLX_CONTEXT_PROFILE_MASK_ARB = 0x9126;

        internal const int GLX_CONTEXT_DEBUG_BIT_ARB = 0x1;
        internal const int GLX_CONTEXT_FORWARD_COMPATIBLE_BIT = 0x2;

        internal const int GLX_CONTEXT_CORE_PROFILE_BIT_ARB = 0x1;
        internal const int GLX_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x2;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate GLXContext glXCreateContextAttribARBProc(
            XDisplayPtr display,
            GLXFBConfig config,
            GLXContext shareContext,
            bool direct,
            ref int attribList);

        #endregion

        #region EXT_swap_control

        internal const int GLX_SWAP_INTERVAL_EXT = 0x20F1;
        internal const int GLX_MAX_SWAP_INTERVAL_EXT = 0x20F2;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void glXSwapIntervalEXT(XDisplayPtr dpy, GLXDrawable drawable, int interval);

        #endregion

        #region MESA_swap_control

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int glXSwapIntervalMESA(uint interval);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int glXGetSwapIntervalMESA();

        #endregion

        #region SGI_swap_control

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int glXSwapIntervalSGI(int interval);

        #endregion

        /// <summary>From GLX_ARB_framebuffer_sRGB</summary>
        internal const int GLX_FRAMEBUFFER_SRGB_CAPABLE_ARB = 0x20B2;

        /// <summary>From GLX_ARB_multisample</summary>
        internal const int GLX_SAMPLE_BUFFERS_ARB = 100000;

        /// <summary>From GLX_ARB_multisample</summary>
        internal const int GLX_SAMPLES_ARB = 100001;

        /// <summary>GLX_OML_swap_method</summary>
        internal const int GLX_SWAP_METHOD_OML = 0x8060;

        /// <summary>GLX_OML_swap_method</summary>
        internal const int GLX_SWAP_EXCHANGE_OML = 0x8061;

        /// <summary>GLX_OML_swap_method</summary>
        internal const int GLX_SWAP_COPY_OML = 0x8062;

        /// <summary>GLX_OML_swap_method</summary>
        internal const int GLX_SWAP_UNDEFINED_OML = 0x8063;

        /// <summary>GLX_ARB_fbconfig_float</summary>
        internal const int GLX_RGBA_FLOAT_TYPE = 0x20B9;

        /// <summary>GLX_ARB_fbconfig_float</summary>
        internal const int GLX_RGBA_FLOAT_BIT = 0x00000004;

        /// <summary>GLX_EXT_fbconfig_packed_float</summary>
        internal const int GLX_RGBA_UNSIGNED_FLOAT_TYPE_EXT = 0x20B1;

        /// <summary>GLX_EXT_fbconfig_packed_float</summary>
        internal const int GLX_RGBA_UNSIGNED_FLOAT_BIT_EXT = 0x00000008;

        /// <summary>GLX_ARB_create_context_robustness</summary>
        internal const int GLX_CONTEXT_ROBUST_ACCESS_BIT_ARB = 0x00000004;

        /// <summary>GLX_ARB_create_context_robustness</summary>
        internal const int GLX_CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;

        /// <summary>GLX_ARB_create_context_robustness</summary>
        internal const int GLX_NO_RESET_NOTIFICATION_ARB = 0x8261;

        /// <summary>GLX_ARB_create_context_robustness</summary>
        internal const int GLX_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;

        /// <summary>GLX_ARB_robustness_isolation</summary>
        internal const int GLX_CONTEXT_RESET_ISOLATION_BIT_ARB = 0x00000008;

        /// <summary>GLX_ARB_create_context_no_error</summary>
        internal const int GLX_CONTEXT_OPENGL_NO_ERROR_ARB = 0x31B3;

        /// <summary>GLX_ARB_context_flush_control</summary>
        internal const int GLX_CONTEXT_RELEASE_BEHAVIOR_ARB = 0x2097;

        /// <summary>GLX_ARB_context_flush_control</summary>
        internal const int GLX_CONTEXT_RELEASE_BEHAVIOR_NONE_ARB = 0x0000;

        /// <summary>GLX_ARB_context_flush_control</summary>
        internal const int GLX_CONTEXT_RELEASE_BEHAVIOR_FLUSH_ARB = 0x2098;
    }
}
