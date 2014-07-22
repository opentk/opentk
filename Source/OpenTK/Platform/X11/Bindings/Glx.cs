#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Contributions from Erik Ylvisaker
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;

#pragma warning disable 1591

namespace OpenTK.Platform.X11
{
    #region Enums

    enum GLXAttribute : int
    {
        TRANSPARENT_BLUE_VALUE_EXT = 0x27,
        GRAY_SCALE = 0x8006,
        RGBA_TYPE = 0x8014,
        TRANSPARENT_RGB_EXT = 0x8008,
        ACCUM_BLUE_SIZE = 16,
        SHARE_CONTEXT_EXT = 0x800A,
        STEREO = 6,
        ALPHA_SIZE = 11,
        FLOAT_COMPONENTS_NV = 0x20B0,
        NONE = 0x8000,
        DEPTH_SIZE = 12,
        TRANSPARENT_INDEX_VALUE_EXT = 0x24,
        MAX_PBUFFER_WIDTH_SGIX = 0x8016,
        GREEN_SIZE = 9,
        X_RENDERABLE_SGIX = 0x8012,
        LARGEST_PBUFFER = 0x801C,
        DONT_CARE = unchecked((int)0xFFFFFFFF),
        TRANSPARENT_ALPHA_VALUE_EXT = 0x28,
        PSEUDO_COLOR_EXT = 0x8004,
        USE_GL = 1,
        SAMPLE_BUFFERS_SGIS = 100000,
        TRANSPARENT_GREEN_VALUE_EXT = 0x26,
        HYPERPIPE_ID_SGIX = 0x8030,
        COLOR_INDEX_TYPE_SGIX = 0x8015,
        SLOW_CONFIG = 0x8001,
        PRESERVED_CONTENTS = 0x801B,
        ACCUM_RED_SIZE = 14,
        EVENT_MASK = 0x801F,
        VISUAL_ID_EXT = 0x800B,
        EVENT_MASK_SGIX = 0x801F,
        SLOW_VISUAL_EXT = 0x8001,
        TRANSPARENT_GREEN_VALUE = 0x26,
        MAX_PBUFFER_WIDTH = 0x8016,
        DIRECT_COLOR_EXT = 0x8003,
        VISUAL_ID = 0x800B,
        ACCUM_GREEN_SIZE = 15,
        DRAWABLE_TYPE_SGIX = 0x8010,
        SCREEN_EXT = 0x800C,
        SAMPLES = 100001,
        HEIGHT = 0x801E,
        TRANSPARENT_INDEX_VALUE = 0x24,
        SAMPLE_BUFFERS_ARB = 100000,
        PBUFFER = 0x8023,
        RGBA_TYPE_SGIX = 0x8014,
        MAX_PBUFFER_HEIGHT = 0x8017,
        FBCONFIG_ID_SGIX = 0x8013,
        DRAWABLE_TYPE = 0x8010,
        SCREEN = 0x800C,
        RED_SIZE = 8,
        VISUAL_SELECT_GROUP_SGIX = 0x8028,
        VISUAL_CAVEAT_EXT = 0x20,
        PSEUDO_COLOR = 0x8004,
        PBUFFER_HEIGHT = 0x8040,
        STATIC_GRAY = 0x8007,
        PRESERVED_CONTENTS_SGIX = 0x801B,
        RGBA_FLOAT_TYPE_ARB = 0x20B9,
        TRANSPARENT_RED_VALUE = 0x25,
        TRANSPARENT_ALPHA_VALUE = 0x28,
        WINDOW = 0x8022,
        X_RENDERABLE = 0x8012,
        STENCIL_SIZE = 13,
        TRANSPARENT_RGB = 0x8008,
        LARGEST_PBUFFER_SGIX = 0x801C,
        STATIC_GRAY_EXT = 0x8007,
        TRANSPARENT_BLUE_VALUE = 0x27,
        DIGITAL_MEDIA_PBUFFER_SGIX = 0x8024,
        BLENDED_RGBA_SGIS = 0x8025,
        NON_CONFORMANT_VISUAL_EXT = 0x800D,
        COLOR_INDEX_TYPE = 0x8015,
        TRANSPARENT_RED_VALUE_EXT = 0x25,
        GRAY_SCALE_EXT = 0x8006,
        WINDOW_SGIX = 0x8022,
        X_VISUAL_TYPE = 0x22,
        MAX_PBUFFER_HEIGHT_SGIX = 0x8017,
        DOUBLEBUFFER = 5,
        OPTIMAL_PBUFFER_WIDTH_SGIX = 0x8019,
        X_VISUAL_TYPE_EXT = 0x22,
        WIDTH_SGIX = 0x801D,
        STATIC_COLOR_EXT = 0x8005,
        BUFFER_SIZE = 2,
        DIRECT_COLOR = 0x8003,
        MAX_PBUFFER_PIXELS = 0x8018,
        NONE_EXT = 0x8000,
        HEIGHT_SGIX = 0x801E,
        RENDER_TYPE = 0x8011,
        FBCONFIG_ID = 0x8013,
        TRANSPARENT_INDEX_EXT = 0x8009,
        TRANSPARENT_INDEX = 0x8009,
        TRANSPARENT_TYPE_EXT = 0x23,
        ACCUM_ALPHA_SIZE = 17,
        PBUFFER_SGIX = 0x8023,
        MAX_PBUFFER_PIXELS_SGIX = 0x8018,
        OPTIMAL_PBUFFER_HEIGHT_SGIX = 0x801A,
        DAMAGED = 0x8020,
        SAVED_SGIX = 0x8021,
        TRANSPARENT_TYPE = 0x23,
        MULTISAMPLE_SUB_RECT_WIDTH_SGIS = 0x8026,
        NON_CONFORMANT_CONFIG = 0x800D,
        BLUE_SIZE = 10,
        TRUE_COLOR_EXT = 0x8002,
        SAMPLES_SGIS = 100001,
        SAMPLES_ARB = 100001,
        TRUE_COLOR = 0x8002,
        RGBA = 4,
        AUX_BUFFERS = 7,
        SAMPLE_BUFFERS = 100000,
        SAVED = 0x8021,
        MULTISAMPLE_SUB_RECT_HEIGHT_SGIS = 0x8027,
        DAMAGED_SGIX = 0x8020,
        STATIC_COLOR = 0x8005,
        PBUFFER_WIDTH = 0x8041,
        WIDTH = 0x801D,
        LEVEL = 3,
        CONFIG_CAVEAT = 0x20,
        RENDER_TYPE_SGIX = 0x8011,
        SWAP_INTERVAL_EXT = 0x20F1,
        MAX_SWAP_INTERVAL_EXT = 0x20F2,
    }

    enum GLXHyperpipeAttrib : int
    {
        PIPE_RECT_LIMITS_SGIX = 0x00000002,
        PIPE_RECT_SGIX = 0x00000001,
        HYPERPIPE_STEREO_SGIX = 0x00000003,
        HYPERPIPE_PIXEL_AVERAGE_SGIX = 0x00000004,
    }

    enum GLXStringName : int
    {
        EXTENSIONS = 0x3,
        VERSION = 0x2,
        VENDOR = 0x1,
    }

    enum GLXEventMask : int
    {
        PBUFFER_CLOBBER_MASK = 0x08000000,
        BUFFER_CLOBBER_MASK_SGIX = 0x08000000,
    }

    enum GLXRenderTypeMask : int
    {
        COLOR_INDEX_BIT_SGIX = 0x00000002,
        RGBA_BIT = 0x00000001,
        RGBA_FLOAT_BIT_ARB = 0x00000004,
        RGBA_BIT_SGIX = 0x00000001,
        COLOR_INDEX_BIT = 0x00000002,
    }

    enum GLXHyperpipeTypeMask : int
    {
        HYPERPIPE_RENDER_PIPE_SGIX = 0x00000002,
        HYPERPIPE_DISPLAY_PIPE_SGIX = 0x00000001,
    }

    enum GLXPbufferClobberMask : int
    {
        ACCUM_BUFFER_BIT_SGIX = 0x00000080,
        FRONT_LEFT_BUFFER_BIT = 0x00000001,
        BACK_RIGHT_BUFFER_BIT = 0x00000008,
        FRONT_RIGHT_BUFFER_BIT_SGIX = 0x00000002,
        STENCIL_BUFFER_BIT_SGIX = 0x00000040,
        SAMPLE_BUFFERS_BIT_SGIX = 0x00000100,
        STENCIL_BUFFER_BIT = 0x00000040,
        BACK_RIGHT_BUFFER_BIT_SGIX = 0x00000008,
        BACK_LEFT_BUFFER_BIT_SGIX = 0x00000004,
        AUX_BUFFERS_BIT = 0x00000010,
        DEPTH_BUFFER_BIT_SGIX = 0x00000020,
        ACCUM_BUFFER_BIT = 0x00000080,
        AUX_BUFFERS_BIT_SGIX = 0x00000010,
        DEPTH_BUFFER_BIT = 0x00000020,
        FRONT_LEFT_BUFFER_BIT_SGIX = 0x00000001,
        BACK_LEFT_BUFFER_BIT = 0x00000004,
        FRONT_RIGHT_BUFFER_BIT = 0x00000002,
    }

    enum GLXHyperpipeMisc : int
    {
        HYPERPIPE_PIPE_NAME_LENGTH_SGIX = 80,
    }

    enum GLXErrorCode : int
    {
        BAD_CONTEXT = 5,
        NO_EXTENSION = 3,
        BAD_HYPERPIPE_SGIX = 92,
        BAD_ENUM = 7,
        BAD_SCREEN = 1,
        BAD_VALUE = 6,
        BAD_ATTRIBUTE = 2,
        BAD_VISUAL = 4,
        BAD_HYPERPIPE_CONFIG_SGIX = 91,
    }

    enum GLXSyncType : int
    {
        SYNC_SWAP_SGIX = 0x00000001,
        SYNC_FRAME_SGIX = 0x00000000,
    }

    enum GLXDrawableTypeMask : int
    {
        WINDOW_BIT = 0x00000001,
        PIXMAP_BIT = 0x00000002,
        PBUFFER_BIT_SGIX = 0x00000004,
        PBUFFER_BIT = 0x00000004,
        WINDOW_BIT_SGIX = 0x00000001,
        PIXMAP_BIT_SGIX = 0x00000002,
    }

    enum ArbCreateContext : int
    {
        DebugBit = 0x0001,
        ForwardCompatibleBit = 0x0002,
        CoreProfileBit = 0x00000001,
        CompatibilityProfileBit = 0x00000002,
        MajorVersion = 0x2091,
        MinorVersion = 0x2092,
        LayerPlane = 0x2093,
        Flags = 0x2094,
        ErrorInvalidVersion = 0x2095,
        ProfileMask = 0x9126
    }

    enum ErrorCode : int
    {
        NO_ERROR       = 0,
        BAD_SCREEN     = 1,   /* screen # is bad */
        BAD_ATTRIBUTE  = 2,   /* attribute to get is bad */
        NO_EXTENSION   = 3,   /* no glx extension on server */
        BAD_VISUAL     = 4,   /* visual # not known by GLX */
        BAD_CONTEXT    = 5,   /* returned only by import_context EXT? */
        BAD_VALUE      = 6,   /* returned only by glXSwapIntervalSGI? */
        BAD_ENUM       = 7,   /* unused? */
    }

    #endregion

    /// \internal
    /// <summary>
    /// Provides access to GLX functions.
    /// </summary>
    class Glx : Graphics.GraphicsBindingsBase
    {
        const string Library = "libGL.so.1";
        static readonly object sync_root = new object();

        static readonly byte[] EntryPointNames = new byte[]
        {
            // glXCreateContextAttribsARB
            0x67, 0x6c, 0x58, 0x43, 0x72, 0x65, 0x61, 0x74, 0x65, 0x43, 0x6f, 0x6e, 0x74, 0x65, 0x78, 0x74, 0x41, 0x74, 0x74, 0x72, 0x69, 0x62, 0x73, 0x41, 0x52, 0x42, 0,
            // glXSwapIntervalEXT
            0x67, 0x6c, 0x58, 0x53, 0x77, 0x61, 0x70, 0x49, 0x6e, 0x74, 0x65, 0x72, 0x76, 0x61, 0x6c, 0x45, 0x58, 0x54, 0,
            // glXSwapIntervalMESA
            0x67, 0x6c, 0x58, 0x53, 0x77, 0x61, 0x70, 0x49, 0x6e, 0x74, 0x65, 0x72, 0x76, 0x61, 0x6c, 0x4d, 0x45, 0x53, 0x41, 0,
            // glXGetSwapIntervalMESA
            0x67, 0x6c, 0x58, 0x47, 0x65, 0x74, 0x53, 0x77, 0x61, 0x70, 0x49, 0x6e, 0x74, 0x65, 0x72, 0x76, 0x61, 0x6c, 0x4d, 0x45, 0x53, 0x41, 0,
            // glXSwapIntervalSGI
            0x67, 0x6c, 0x58, 0x53, 0x77, 0x61, 0x70, 0x49, 0x6e, 0x74, 0x65, 0x72, 0x76, 0x61, 0x6c, 0x53, 0x47, 0x49, 0,
        };
        static readonly int[] EntryPointOffsets = new int[5];
        static IntPtr[] EntryPoints = new IntPtr[5];

        internal Glx()
        {
            // GLX entry points are not bound to a context.
            // This means we can load them without creating
            // a context first! (unlike WGL)
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointOffsets;

            // Writing the entry point name offsets
            // by hand is error prone. Do it in code
            // instead:
            int offset = 0;
            for (int i = 0, j = 0; i < EntryPointNames.Length; i++)
            {
                if (EntryPointNames[i] == 0)
                {
                    EntryPointOffsets[j++] = offset;
                    offset = i + 1;
                }
            }
        }

        protected override object SyncRoot { get { return sync_root; } }

        protected override IntPtr GetAddress(string funcname)
        {
            return Arb.GetProcAddress(funcname);
        }

        internal override void LoadEntryPoints()
        {
            unsafe
            {
                fixed (byte* name = _EntryPointNamesInstance)
                {
                    for (int i = 0; i < _EntryPointsInstance.Length; i++)
                    {
                        _EntryPointsInstance[i] = Arb.GetProcAddress(
                            new IntPtr(name + _EntryPointNameOffsetsInstance[i]));
                    }
                }
            }
        }

        internal static bool SupportsFunction(string name)
        {
            int index = Array.IndexOf(EntryPointNames, name);
            if (index >= 0)
            {
                return EntryPoints[index] != IntPtr.Zero;
            }
            return false;
        }

        #region GLX functions

        [DllImport(Library, EntryPoint = "glXIsDirect")]
        public static extern bool IsDirect(IntPtr dpy, IntPtr context);

        [DllImport(Library, EntryPoint = "glXQueryDrawable")]
        public static extern ErrorCode QueryDrawable(IntPtr dpy, IntPtr drawable, GLXAttribute attribute, out int value);

        [DllImport(Library, EntryPoint = "glXQueryExtension")]
        public static extern bool QueryExtension(IntPtr dpy, out int errorBase, out int eventBase);

        [DllImport(Library, EntryPoint = "glXQueryExtensionsString")]
        static extern IntPtr QueryExtensionsStringInternal(IntPtr dpy, int screen);

        public static string QueryExtensionsString(IntPtr dpy, int screen)
        {
            return Marshal.PtrToStringAnsi(QueryExtensionsStringInternal(dpy, screen));
        }

        [DllImport(Library, EntryPoint = "glXQueryVersion")]
        public static extern bool QueryVersion(IntPtr dpy, out int major, out int minor);

        [DllImport(Library, EntryPoint = "glXCreateContext")]
        public static extern IntPtr CreateContext(IntPtr dpy, IntPtr vis, IntPtr shareList, bool direct);

        [DllImport(Library, EntryPoint = "glXCreateContext")]
        public static extern IntPtr CreateContext(IntPtr dpy, ref XVisualInfo vis, IntPtr shareList, bool direct);
    
        [DllImport(Library, EntryPoint = "glXDestroyContext")]
        public static extern void DestroyContext(IntPtr dpy, IntPtr context);

        public static void DestroyContext(IntPtr dpy, ContextHandle context)
        {
            DestroyContext(dpy, context.Handle);
        }

        [DllImport(Library, EntryPoint = "glXGetCurrentContext")]
        public static extern IntPtr GetCurrentContext();

        [DllImport(Library, EntryPoint = "glXMakeCurrent")]
        public static extern bool MakeCurrent(IntPtr display, IntPtr drawable, IntPtr context);

        public static bool MakeCurrent(IntPtr display, IntPtr drawable, ContextHandle context)
        {
            return MakeCurrent(display, drawable, context.Handle);
        }

        [DllImport(Library, EntryPoint = "glXSwapBuffers")]
        public static extern void SwapBuffers(IntPtr display, IntPtr drawable);

        [DllImport(Library, EntryPoint = "glXGetProcAddress")]
        public static extern IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPTStr)] string procName);

        [DllImport(Library, EntryPoint = "glXGetProcAddress")]
        public static extern IntPtr GetProcAddress(IntPtr procName);

        [DllImport(Library, EntryPoint = "glXGetConfig")]
        public static extern int GetConfig(IntPtr dpy, ref XVisualInfo vis, GLXAttribute attrib, out int value);

        #region glXChooseVisual

        [DllImport(Library, EntryPoint = "glXChooseVisual")]
        public extern static IntPtr ChooseVisual(IntPtr dpy, int screen, IntPtr attriblist);

        [DllImport(Library, EntryPoint = "glXChooseVisual")]
        public extern static IntPtr ChooseVisual(IntPtr dpy, int screen, ref int attriblist);

        public static IntPtr ChooseVisual(IntPtr dpy, int screen, int[] attriblist)
        {
            unsafe
            {
                fixed (int* attriblist_ptr = attriblist)
                {
                    return ChooseVisual(dpy, screen, (IntPtr)attriblist_ptr);
                }
            }
        }

        // Returns an array of GLXFBConfig structures.
        [DllImport(Library, EntryPoint = "glXChooseFBConfig")]
        unsafe public extern static IntPtr* ChooseFBConfig(IntPtr dpy, int screen, int[] attriblist, out int fbount);

        // Returns a pointer to an XVisualInfo structure.
        [DllImport(Library, EntryPoint = "glXGetVisualFromFBConfig")]
        public unsafe extern static IntPtr GetVisualFromFBConfig(IntPtr dpy, IntPtr fbconfig);

        #endregion

        public partial class Arb
        {
            #region CreateContextAttribs

            [AutoGenerated(EntryPoint = "glXCreateContextAttribsARB")]
            unsafe public static IntPtr CreateContextAttribs(IntPtr display, IntPtr fbconfig, IntPtr share_context, bool direct, int* attribs)
            {
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "glXCreateContextAttribsARB")]
            public static IntPtr CreateContextAttribs(IntPtr display, IntPtr fbconfig, IntPtr share_context, bool direct, int[] attribs)
            {
                throw new NotImplementedException();
            }

            #endregion

            #region GetProcAddress

            // The linux OpenGL ABI 3.6 (1999) requires
            // that glXGetProcAddressARB be available as
            // a static export. The same is *not* true
            // for glXGetProcAddress, so we should use
            // glXGetProcAddressARB instead.
            // See http://www.opengl.org/registry/ABI/
            [DllImport(Library, EntryPoint = "glXGetProcAddressARB")]
            public static extern IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPTStr)] string procName);

            [DllImport(Library, EntryPoint = "glXGetProcAddressARB")]
            public static extern IntPtr GetProcAddress(IntPtr procName);

            #endregion
        }

        public partial class Ext
        {
            [AutoGenerated(EntryPoint = "glXSwapIntervalEXT")]
            public static ErrorCode SwapInterval(IntPtr display, IntPtr drawable, int interval)
            {
                throw new NotImplementedException();
            }
        }

        public partial class Mesa
        {
            [AutoGenerated(EntryPoint = "glXSwapIntervalMESA")]
            public static ErrorCode SwapInterval(int interval)
            {
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "glXGetSwapIntervalMESA")]
            public static int GetSwapInterval()
            {
                throw new NotImplementedException();
            }
        }

        public partial class Sgi
        {
            [AutoGenerated(EntryPoint = "glXSwapIntervalSGI")]
            public static ErrorCode SwapInterval(int interval)
            {
                throw new NotImplementedException();
            }
        }

        [Slot(0)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        internal unsafe static extern IntPtr glXCreateContextAttribsARB(IntPtr display, IntPtr fbconfig, IntPtr share_context, bool direct, int* attribs);
        [Slot(1)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ErrorCode glXSwapIntervalEXT(IntPtr display, IntPtr drawable, int interval);
        [Slot(2)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ErrorCode glXSwapIntervalMESA(int interval);
        [Slot(3)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int glXGetSwapIntervalMESA();
        [Slot(4)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        internal static extern ErrorCode glXSwapIntervalSGI(int interval);

        #endregion
    }
}

#pragma warning restore 1591