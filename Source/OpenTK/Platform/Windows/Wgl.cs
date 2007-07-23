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

namespace OpenTK.Platform.Windows
{
    /// <summary>
    /// Provides access to WGL functions.
    /// </summary>
    internal static class Wgl
    {
        // Disable BeforeFieldInit optimization.
        static Wgl() { }

        const string _dll_name = "OPENGL32.DLL";

        /// <summary>
        /// Contains all WGL constants.
        /// </summary>
        public class Constant
        {
            #region WGL constants

            public const int WGLEXT_VERSION = 4;
            public const int FRONT_COLOR_BUFFER_BIT_ARB = 0x00000001;
            public const int BACK_COLOR_BUFFER_BIT_ARB = 0x00000002;
            public const int DEPTH_BUFFER_BIT_ARB = 0x00000004;
            public const int STENCIL_BUFFER_BIT_ARB = 0x00000008;
            public const int SAMPLE_BUFFERS_ARB = 0x2041;
            public const int SAMPLES_ARB = 0x2042;
            public const int NUMBER_PIXEL_FORMATS_ARB = 0x2000;
            public const int DRAW_TO_WINDOW_ARB = 0x2001;
            public const int DRAW_TO_BITMAP_ARB = 0x2002;
            public const int ACCELERATION_ARB = 0x2003;
            public const int NEED_PALETTE_ARB = 0x2004;
            public const int NEED_SYSTEM_PALETTE_ARB = 0x2005;
            public const int SWAP_LAYER_BUFFERS_ARB = 0x2006;
            public const int SWAP_METHOD_ARB = 0x2007;
            public const int NUMBER_OVERLAYS_ARB = 0x2008;
            public const int NUMBER_UNDERLAYS_ARB = 0x2009;
            public const int TRANSPARENT_ARB = 0x200A;
            public const int TRANSPARENT_RED_VALUE_ARB = 0x2037;
            public const int TRANSPARENT_GREEN_VALUE_ARB = 0x2038;
            public const int TRANSPARENT_BLUE_VALUE_ARB = 0x2039;
            public const int TRANSPARENT_ALPHA_VALUE_ARB = 0x203A;
            public const int TRANSPARENT_INDEX_VALUE_ARB = 0x203B;
            public const int SHARE_DEPTH_ARB = 0x200C;
            public const int SHARE_STENCIL_ARB = 0x200D;
            public const int SHARE_ACCUM_ARB = 0x200E;
            public const int SUPPORT_GDI_ARB = 0x200F;
            public const int SUPPORT_OPENGL_ARB = 0x2010;
            public const int DOUBLE_BUFFER_ARB = 0x2011;
            public const int STEREO_ARB = 0x2012;
            public const int PIXEL_TYPE_ARB = 0x2013;
            public const int COLOR_BITS_ARB = 0x2014;
            public const int RED_BITS_ARB = 0x2015;
            public const int RED_SHIFT_ARB = 0x2016;
            public const int GREEN_BITS_ARB = 0x2017;
            public const int GREEN_SHIFT_ARB = 0x2018;
            public const int BLUE_BITS_ARB = 0x2019;
            public const int BLUE_SHIFT_ARB = 0x201A;
            public const int ALPHA_BITS_ARB = 0x201B;
            public const int ALPHA_SHIFT_ARB = 0x201C;
            public const int ACCUM_BITS_ARB = 0x201D;
            public const int ACCUM_RED_BITS_ARB = 0x201E;
            public const int ACCUM_GREEN_BITS_ARB = 0x201F;
            public const int ACCUM_BLUE_BITS_ARB = 0x2020;
            public const int ACCUM_ALPHA_BITS_ARB = 0x2021;
            public const int DEPTH_BITS_ARB = 0x2022;
            public const int STENCIL_BITS_ARB = 0x2023;
            public const int AUX_BUFFERS_ARB = 0x2024;
            public const int NO_ACCELERATION_ARB = 0x2025;
            public const int GENERIC_ACCELERATION_ARB = 0x2026;
            public const int FULL_ACCELERATION_ARB = 0x2027;
            public const int SWAP_EXCHANGE_ARB = 0x2028;
            public const int SWAP_COPY_ARB = 0x2029;
            public const int SWAP_UNDEFINED_ARB = 0x202A;
            public const int TYPE_RGBA_ARB = 0x202B;
            public const int TYPE_COLORINDEX_ARB = 0x202C;
            public const int ERROR_INVALID_PIXEL_TYPE_ARB = 0x2043;
            public const int ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = 0x2054;
            public const int DRAW_TO_PBUFFER_ARB = 0x202D;
            public const int MAX_PBUFFER_PIXELS_ARB = 0x202E;
            public const int MAX_PBUFFER_WIDTH_ARB = 0x202F;
            public const int MAX_PBUFFER_HEIGHT_ARB = 0x2030;
            public const int PBUFFER_LARGEST_ARB = 0x2033;
            public const int PBUFFER_WIDTH_ARB = 0x2034;
            public const int PBUFFER_HEIGHT_ARB = 0x2035;
            public const int PBUFFER_LOST_ARB = 0x2036;
            public const int BIND_TO_TEXTURE_RGB_ARB = 0x2070;
            public const int BIND_TO_TEXTURE_RGBA_ARB = 0x2071;
            public const int TEXTURE_FORMAT_ARB = 0x2072;
            public const int TEXTURE_TARGET_ARB = 0x2073;
            public const int MIPMAP_TEXTURE_ARB = 0x2074;
            public const int TEXTURE_RGB_ARB = 0x2075;
            public const int TEXTURE_RGBA_ARB = 0x2076;
            public const int NO_TEXTURE_ARB = 0x2077;
            public const int TEXTURE_CUBE_MAP_ARB = 0x2078;
            public const int TEXTURE_1D_ARB = 0x2079;
            public const int TEXTURE_2D_ARB = 0x207A;
            public const int MIPMAP_LEVEL_ARB = 0x207B;
            public const int CUBE_MAP_FACE_ARB = 0x207C;
            public const int TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x207D;
            public const int TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x207E;
            public const int TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x207F;
            public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x2080;
            public const int TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x2081;
            public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x2082;
            public const int FRONT_LEFT_ARB = 0x2083;
            public const int FRONT_RIGHT_ARB = 0x2084;
            public const int BACK_LEFT_ARB = 0x2085;
            public const int BACK_RIGHT_ARB = 0x2086;
            public const int AUX0_ARB = 0x2087;
            public const int AUX1_ARB = 0x2088;
            public const int AUX2_ARB = 0x2089;
            public const int AUX3_ARB = 0x208A;
            public const int AUX4_ARB = 0x208B;
            public const int AUX5_ARB = 0x208C;
            public const int AUX6_ARB = 0x208D;
            public const int AUX7_ARB = 0x208E;
            public const int AUX8_ARB = 0x208F;
            public const int AUX9_ARB = 0x2090;
            public const int ERROR_INVALID_PIXEL_TYPE_EXT = 0x2043;
            public const int NUMBER_PIXEL_FORMATS_EXT = 0x2000;
            public const int DRAW_TO_WINDOW_EXT = 0x2001;
            public const int DRAW_TO_BITMAP_EXT = 0x2002;
            public const int ACCELERATION_EXT = 0x2003;
            public const int NEED_PALETTE_EXT = 0x2004;
            public const int NEED_SYSTEM_PALETTE_EXT = 0x2005;
            public const int SWAP_LAYER_BUFFERS_EXT = 0x2006;
            public const int SWAP_METHOD_EXT = 0x2007;
            public const int NUMBER_OVERLAYS_EXT = 0x2008;
            public const int NUMBER_UNDERLAYS_EXT = 0x2009;
            public const int TRANSPARENT_EXT = 0x200A;
            public const int TRANSPARENT_VALUE_EXT = 0x200B;
            public const int SHARE_DEPTH_EXT = 0x200C;
            public const int SHARE_STENCIL_EXT = 0x200D;
            public const int SHARE_ACCUM_EXT = 0x200E;
            public const int SUPPORT_GDI_EXT = 0x200F;
            public const int SUPPORT_OPENGL_EXT = 0x2010;
            public const int DOUBLE_BUFFER_EXT = 0x2011;
            public const int STEREO_EXT = 0x2012;
            public const int PIXEL_TYPE_EXT = 0x2013;
            public const int COLOR_BITS_EXT = 0x2014;
            public const int RED_BITS_EXT = 0x2015;
            public const int RED_SHIFT_EXT = 0x2016;
            public const int GREEN_BITS_EXT = 0x2017;
            public const int GREEN_SHIFT_EXT = 0x2018;
            public const int BLUE_BITS_EXT = 0x2019;
            public const int BLUE_SHIFT_EXT = 0x201A;
            public const int ALPHA_BITS_EXT = 0x201B;
            public const int ALPHA_SHIFT_EXT = 0x201C;
            public const int ACCUM_BITS_EXT = 0x201D;
            public const int ACCUM_RED_BITS_EXT = 0x201E;
            public const int ACCUM_GREEN_BITS_EXT = 0x201F;
            public const int ACCUM_BLUE_BITS_EXT = 0x2020;
            public const int ACCUM_ALPHA_BITS_EXT = 0x2021;
            public const int DEPTH_BITS_EXT = 0x2022;
            public const int STENCIL_BITS_EXT = 0x2023;
            public const int AUX_BUFFERS_EXT = 0x2024;
            public const int NO_ACCELERATION_EXT = 0x2025;
            public const int GENERIC_ACCELERATION_EXT = 0x2026;
            public const int FULL_ACCELERATION_EXT = 0x2027;
            public const int SWAP_EXCHANGE_EXT = 0x2028;
            public const int SWAP_COPY_EXT = 0x2029;
            public const int SWAP_UNDEFINED_EXT = 0x202A;
            public const int TYPE_RGBA_EXT = 0x202B;
            public const int TYPE_COLORINDEX_EXT = 0x202C;
            public const int DRAW_TO_PBUFFER_EXT = 0x202D;
            public const int MAX_PBUFFER_PIXELS_EXT = 0x202E;
            public const int MAX_PBUFFER_WIDTH_EXT = 0x202F;
            public const int MAX_PBUFFER_HEIGHT_EXT = 0x2030;
            public const int OPTIMAL_PBUFFER_WIDTH_EXT = 0x2031;
            public const int OPTIMAL_PBUFFER_HEIGHT_EXT = 0x2032;
            public const int PBUFFER_LARGEST_EXT = 0x2033;
            public const int PBUFFER_WIDTH_EXT = 0x2034;
            public const int PBUFFER_HEIGHT_EXT = 0x2035;
            public const int DEPTH_FLOAT_EXT = 0x2040;
            public const int SAMPLE_BUFFERS_3DFX = 0x2060;
            public const int SAMPLES_3DFX = 0x2061;
            public const int SAMPLE_BUFFERS_EXT = 0x2041;
            public const int SAMPLES_EXT = 0x2042;
            public const int DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = 0x2051;
            public const int DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = 0x2052;
            public const int DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = 0x2053;
            public const int GAMMA_TABLE_SIZE_I3D = 0x204E;
            public const int GAMMA_EXCLUDE_DESKTOP_I3D = 0x204F;
            public const int GENLOCK_SOURCE_MULTIVIEW_I3D = 0x2044;
            public const int GENLOCK_SOURCE_EXTENAL_SYNC_I3D = 0x2045;
            public const int GENLOCK_SOURCE_EXTENAL_FIELD_I3D = 0x2046;
            public const int GENLOCK_SOURCE_EXTENAL_TTL_I3D = 0x2047;
            public const int GENLOCK_SOURCE_DIGITAL_SYNC_I3D = 0x2048;
            public const int GENLOCK_SOURCE_DIGITAL_FIELD_I3D = 0x2049;
            public const int GENLOCK_SOURCE_EDGE_FALLING_I3D = 0x204A;
            public const int GENLOCK_SOURCE_EDGE_RISING_I3D = 0x204B;
            public const int GENLOCK_SOURCE_EDGE_BOTH_I3D = 0x204C;
            public const int IMAGE_BUFFER_MIN_ACCESS_I3D = 0x00000001;
            public const int IMAGE_BUFFER_LOCK_I3D = 0x00000002;
            public const int BIND_TO_TEXTURE_DEPTH_NV = 0x20A3;
            public const int BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = 0x20A4;
            public const int DEPTH_TEXTURE_FORMAT_NV = 0x20A5;
            public const int TEXTURE_DEPTH_COMPONENT_NV = 0x20A6;
            public const int DEPTH_COMPONENT_NV = 0x20A7;
            public const int BIND_TO_TEXTURE_RECTANGLE_RGB_NV = 0x20A0;
            public const int BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = 0x20A1;
            public const int TEXTURE_RECTANGLE_NV = 0x20A2;
            public const int FLOAT_COMPONENTS_NV = 0x20B0;
            public const int TEXTURE_FLOAT_R_NV = 0x20B5;
            public const int TEXTURE_FLOAT_RG_NV = 0x20B6;
            public const int TEXTURE_FLOAT_RGB_NV = 0x20B7;
            public const int TEXTURE_FLOAT_RGBA_NV = 0x20B8;

            #endregion
        }

        #region WGL functions

        [DllImport(_dll_name)]
        public static extern IntPtr GetProcAddress(IntPtr hwnd);

        [DllImport(_dll_name, EntryPoint = "wglGetProcAddress", SetLastError=true)]
        public static extern IntPtr GetProcAddress(string funcname);

        #region public static extern IntPtr CreateContext(IntPtr dc);

        [DllImport(_dll_name, EntryPoint = "wglCreateContext")]
        public static extern IntPtr CreateContext(IntPtr dc);

        #endregion

        #region public static extern bool MakeCurrent(IntPtr dc, IntPtr rc)

        /// <summary>
        /// The wglMakeCurrent function makes a specified OpenGL rendering context the calling thread's current rendering context.
        /// All subsequent OpenGL calls made by the thread are drawn on the device identified by hdc.
        /// You can also use wglMakeCurrent to change the calling thread's current rendering context so it's no longer current.
        /// </summary>
        /// <param name="dc">Device context of device that OpenGL calls are to be drawn on</param>
        /// <param name="rc">OpenGL rendering context to be made the calling thread's current rendering context</param>
        /// <returns>
        /// When the wglMakeCurrent function succeeds, the return value is TRUE; otherwise the return value is FALSE.
        /// To get extended error information, call GetLastError.
        /// </returns>
        /// <remarks>
        /// <para>
        /// The hdc parameter must refer to a drawing surface supported by OpenGL. It need not be the same hdc
        /// that was passed to wglCreateContext when hglrc was created, but it must be on the same device and have
        /// the same pixel format. GDI transformation and clipping in hdc are not supported by the rendering context.
        /// The current rendering context uses the hdc device context until the rendering context is no longer current.
        /// </para>
        /// <para>
        /// Before switching to the new rendering context, OpenGL flushes any previous rendering context
        /// that was current to the calling thread. 
        /// </para>
        /// <para>
        /// A thread can have one current rendering context. A process can have multiple rendering contexts
        /// by means of multithreading. A thread must set a current rendering context before calling any OpenGL functions.
        /// Otherwise, all OpenGL calls are ignored.
        /// </para>
        /// <para>
        /// A rendering context can be current to only one thread at a time. You cannot make a rendering context current
        /// to multiple threads.
        /// </para>
        /// <para>
        /// An application can perform multithread drawing by making different rendering contexts current
        /// to different threads, supplying each thread with its own rendering context and device context.
        /// </para>
        /// <para>
        /// If an error occurs, the wglMakeCurrent function makes the thread's current rendering context not current
        /// before returning.
        /// </para>
        /// </remarks>
        [DllImport(_dll_name, EntryPoint = "wglMakeCurrent")]
        [System.Security.SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MakeCurrent(IntPtr dc, IntPtr rc);

        #endregion

        [DllImport(_dll_name, EntryPoint = "wglDeleteContext", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteContext(IntPtr rc);

        [DllImport(_dll_name, EntryPoint = "wglGetCurrentContext")]
        public static extern IntPtr GetCurrentContext();

        [DllImport(_dll_name, EntryPoint = "wglGetCurrentDC")]
        public static extern IntPtr GetCurrentDC();

        [DllImport(_dll_name, EntryPoint = "wglShareLists")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShareLists(IntPtr r1, IntPtr r2);

        #endregion
    }
}
