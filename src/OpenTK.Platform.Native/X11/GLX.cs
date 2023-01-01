using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    public static class GLX
    {
        private const string glx = "GL";

        static GLX()
        {
            DllResolver.InitLoader();
        }

        public const int GLX_USE_GL = 1;
        public const int GLX_BUFFER_SIZE = 2;
        public const int GLX_LEVEL = 3;
        public const int GLX_RGBA = 4;
        public const int GLX_DOUBLEBUFFER = 5;
        public const int GLX_STEREO = 6;
        public const int GLX_AUX_BUFFERS = 7;
        public const int GLX_RED_SIZE = 8;
        public const int GLX_GREEN_SIZE = 9;
        public const int GLX_BLUE_SIZE = 10;
        public const int GLX_ALPHA_SIZE = 11;
        public const int GLX_DEPTH_SIZE = 12;
        public const int GLX_STENCIL_SIZE = 13;
        public const int GLX_ACCUM_RED_SIZE = 14;
        public const int GLX_ACCUM_GREEN_SIZE = 15;
        public const int GLX_ACCUM_BLUE_SIZE = 16;
        public const int GLX_ACCUM_ALPHA_SIZE = 17;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe XVisualInfo* glXChooseVisual(XDisplayPtr display, int screen, int[] attributeList);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern GLXContext glXCreateContext(
            XDisplayPtr display,
            ref XVisualInfo visualInfo,
            GLXContext shareList,
            bool direct);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXDestroyContext(XDisplayPtr display, GLXContext context);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool glXMakeCurrent(XDisplayPtr display, XDrawable drawable, GLXContext context);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXCopyContext(
            XDisplayPtr display,
            GLXContext source,
            GLXContext destination,
            ulong mask);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXSwapBuffers(XDisplayPtr display, XDrawable drawable);

        // TODO: Replace XPixMap for GLXPixMap in these functions, as they are different XIDs.

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern XPixMap glXCreateGLXPixmap(XDisplayPtr display, ref XVisualInfo visualInfo, XPixMap pixMap);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXDestroyGLXPixmap(XDisplayPtr display, XPixMap pixMap);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool glXQueryExtension(XDisplayPtr display, out int errorBase, out int eventBase);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool glXQueryVersion(XDisplayPtr display, out int major, out int minor);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool glXIsDirect(XDisplayPtr display, GLXContext context);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int glXGetConfig(
            XDisplayPtr display,
            XVisualInfo* visualInfo,
            int attribute,
            [MarshalAs(UnmanagedType.LPArray)]int[] values);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern GLXContext glXGetCurrentContext();

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern XDrawable glXGetCurrentDrawable();

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXWaitGL();

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXWaitX();


        #region GLX 1.1+

        public const int GLX_VENDOR = 1;
        public const int GLX_VERSION = 2;
        public const int GLX_EXTENSIONS = 3;

        // FIXME: These functions will crash if they are made to LPStr functions.
        // I don't know why, but the runtime will free a string in ".rodata". :facepalm:

        public static string glXQueryExtensionsString(XDisplayPtr display, int screen)
        {
            return Marshal.PtrToStringUTF8(glXQueryExtensionsString(display, screen))!;

            [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
            static extern IntPtr glXQueryExtensionsString(XDisplayPtr display, int screen);
        }

        public static string glXQueryServerString(XDisplayPtr display, int screen, int name)
        {
            return Marshal.PtrToStringUTF8(glXQueryServerString(display, screen, name))!;

            [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
            static extern IntPtr glXQueryServerString(XDisplayPtr display, int screen, int name);
        }

        public static string glXGetClientString(XDisplayPtr display, int name)
        {
            return Marshal.PtrToStringUTF8(glXGetClientString(display, name))!;

            [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
            static extern IntPtr glXGetClientString(XDisplayPtr display, int name);
        }

        #endregion

        #region GLX 1.2+

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern XDisplayPtr glXGetCurrentDisplay();

        #endregion

        #region GLX 1.3+

        public const int GLX_CONFIG_CAVEAT = 0x20;
        public const int GLX_DONT_CARE = unchecked((int)0xFFFFFFFF);
        public const int GLX_X_VISUAL_TYPE = 0x22;
        public const int GLX_TRANSPARENT_TYPE = 0x23;
        public const int GLX_TRANSPARENT_INDEX_VALUE = 0x24;
        public const int GLX_TRANSPARENT_RED_VALUE = 0x25;
        public const int GLX_TRANSPARENT_GREEN_VALUE = 0x26;
        public const int GLX_TRANSPARENT_BLUE_VALUE = 0x27;
        public const int GLX_TRANSPARENT_ALPHA_VALUE = 0x28;
        public const int GLX_WINDOW_BIT = 0x1;
        public const int GLX_PIXMAP_BIT = 0x2;
        public const int GLX_PBUFFER_BIT = 0x4;
        public const int GLX_AUX_BUFFERS_BIT = 0x10;
        public const int GLX_FRONT_LEFT_BUFFER_BIT = 0x1;
        public const int GLX_FRONT_RIGHT_BUFFER_BIT = 0x2;
        public const int GLX_BACK_LEFT_BUFFER_BIT = 0x4;
        public const int GLX_BACK_RIGHT_BUFFER_BIT = 0x8;
        public const int GLX_DEPTH_BUFFER_BIT = 0x20;
        public const int GLX_STENCIL_BUFFER_BIT = 0x40;
        public const int GLX_ACCUM_BUFFER_BIT = 0x80;
        public const int GLX_NONE = 0x8000;
        public const int GLX_SLOW_CONFIG = 0x8001;
        public const int GLX_TRUE_COLOR = 0x8002;
        public const int GLX_DIRECT_COLOR = 0x8003;
        public const int GLX_PSEUDO_COLOR = 0x8004;
        public const int GLX_STATIC_COLOR = 0x8005;
        public const int GLX_GRAY_SCALE = 0x8006;
        public const int GLX_STATIC_GRAY = 0x8007;
        public const int GLX_TRANSPARENT_RGB = 0x8008;
        public const int GLX_TRANSPARENT_INDEX = 0x8009;
        public const int GLX_VISUAL_ID = 0x800B;
        public const int GLX_SCREEN = 0x800C;
        public const int GLX_NON_CONFORMANT_CONFIG = 0x800D;
        public const int GLX_DRAWABLE_TYPE = 0x8010;
        public const int GLX_RENDER_TYPE = 0x8011;
        public const int GLX_X_RENDERABLE = 0x8012;
        public const int GLX_FBCONFIG_ID = 0x8013;
        public const int GLX_RGBA_TYPE = 0x8014;
        public const int GLX_COLOR_INDEX_TYPE = 0x8015;
        public const int GLX_MAX_PBUFFER_WIDTH = 0x8016;
        public const int GLX_MAX_PBUFFER_HEIGHT = 0x8017;
        public const int GLX_MAX_PBUFFER_PIXELS = 0x8018;
        public const int GLX_PRESEERVED_CONTENTS = 0x801B;
        public const int GLX_LARGEST_PBUFFER = 0x801C;
        public const int GLX_WIDTH = 0x801D;
        public const int GLX_HEIGHT = 0x801E;
        public const int GLX_EVENT_MASK = 0x801F;
        public const int GLX_DAMAGED = 0x8020;
        public const int GLX_SAVED = 0x8021;
        public const int GLX_PBUFFER = 0x8023;
        public const int GLX_PBUFFER_HEIGHT = 0x8040;
        public const int GLX_PBUFFER_WIDTH = 0x8041;
        public const int GLX_RGBA_BIT = 0x1;
        public const int GLX_COLOR_INDEX_BIT = 0x2;
        public const int GLX_PBUFFER_CLOBBER_MASK = 0x08000000;


        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe GLXFBConfig *glXChooseFBConfig(
            XDisplayPtr display,
            int screen,
            ref int attribList,
            ref int nItems);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glXGetFBConfigAttrib(
            XDisplayPtr display,
            GLXFBConfig config,
            int attribute,
            ref int value);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe GLXFBConfig* glXGetFBConfigs(XDisplayPtr display, int screen, out int elements);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe XVisualInfo* glXGetVisualFromFBConfig(XDisplayPtr display, GLXFBConfig config);

        // [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        // public static extern GLXContext glXCreateNewContext(
        //     XDisplayPtr display,
        //     XDrawable drawable,
        //     int attribute,
        //     ref uint value);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe int glXQueryDrawable(XDisplayPtr dpy, XDrawable draw, int attribute, out uint value);

        #endregion

        #region GLX 1.4+

        public const int GLX_SAMPLE_BUFFERS = 0x186a0;
        public const int GLX_SAMPLES = 0x186a1;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr glXGetProcAddress([MarshalAs(UnmanagedType.LPStr)]string procname);

        #endregion

        #region GLX_ARB_get_proc_address

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr glXGetProcAddressARB([MarshalAs(UnmanagedType.LPStr)]string procname);

        #endregion

        #region GLX_ARB_create_context and GLX_ARB_create_context_profile

        public const int GLX_CONTEXT_MAJOR_VERSION_ARB = 0x2091;
        public const int GLX_CONTEXT_MINOR_VERSION_ARB = 0x2092;
        public const int GLX_CONTEXT_FLAGS_ARB = 0x2094;
        public const int GLX_CONTEXT_PROFILE_MASK_ARB = 0x9126;

        public const int GLX_CONTEXT_DEBUG_BIT_ARB = 0x1;
        public const int GLX_CONTEXT_FORWARD_COMPATIBLE_BIT = 0x2;

        public const int GLX_CONTEXT_CORE_PROFILE_BIT_ARB = 0x1;
        public const int GLX_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x2;

        public delegate GLXContext glXCreateContextAttribARBProc(
            XDisplayPtr display,
            GLXFBConfig config,
            GLXContext shareContext,
            bool direct,
            ref int attribList);

        #endregion

        #region EXT_swap_control

        public const int GLX_SWAP_INTERVAL_EXT = 0x20F1;
        public const int GLX_MAX_SWAP_INTERVAL_EXT = 0x20F2;

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern void glXSwapIntervalEXT(XDisplayPtr dpy, XDrawable drawable, int interval);

        #endregion

        #region MESA_swap_control

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glXSwapIntervalMESA(uint interval);

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glXGetSwapIntervalMESA();

        #endregion

        #region SGI_swap_control

        [DllImport(glx, CallingConvention = CallingConvention.Cdecl)]
        public static extern int glXSwapIntervalSGI(int interval);

        #endregion
    }
}
