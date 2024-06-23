
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.macOS
{
    internal static class CGL
    {
        private const string Lib = "/System/Library/Frameworks/OpenGL.framework/Versions/Current/OpenGL";

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static unsafe extern CGLError CGLChoosePixelFormat(CGLPixelFormatAttribute* attribs, out IntPtr /* CGLPixelFormatObj* */ pix, out int /* GLint* */ npix);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGLError CGLDestroyPixelFormat(IntPtr /* CGLPixelFormatObj */ pix);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGLError CGLDescribePixelFormat(IntPtr /* CGLPixelFormatObj */ pix, int /* GLint */ pix_num, CGLPixelFormatAttribute attrib, out int /* GLint* */ value);

        /// <summary>
        /// AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER
        /// </summary>
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void CGLReleasePixelFormat(IntPtr /* CGLPixelFormatObj */ pix);

        /// <summary>
        /// AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER
        /// </summary>
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr /* CGLPixelFormatObj */ CGLRetainPixelFormat(IntPtr /* CGLPixelFormatObj */ pix);

        /// <summary>
        /// AVAILABLE_MAC_OS_X_VERSION_10_5_AND_LATER
        /// </summary>
        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint /* GLuint */ CGLGetPixelFormatRetainCount(IntPtr /* CGLPixelFormatObj */ pix);






        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGLError CGLQueryRendererInfo(uint /* GLuint */ display_mask, out IntPtr /* CGLRendererInfoObj* */ rend, out int /* GLint* */ nrend);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGLError CGLDestroyRendererInfo(IntPtr /* CGLRendererInfoObj */ rend);

        [DllImport(Lib, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CGLError CGLDescribeRenderer(IntPtr /* CGLRendererInfoObj */ rend, int /* GLint */ rend_num, CGLRendererProperty prop, out int /* GLint* */ value);
    }
}

