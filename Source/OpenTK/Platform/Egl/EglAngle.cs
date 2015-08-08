using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Egl
{
    using EGLDisplay = IntPtr;
    using EGLNativeDisplayType = IntPtr;
    using EGLSurface = IntPtr;
    using ShareHandle = IntPtr;

    static partial class Egl
    {
        // See
        // - ANGLE_platform_angle
        // - ANGLE_platform_angle_d3d
        // - ANGLE_platform_angle_opengl
        public const int PLATFORM_ANGLE = 0x3202;
        public const int PLATFORM_ANGLE_TYPE = 0x3203;
        public const int PLATFORM_ANGLE_MAX_VERSION_MAJOR = 0x3204;
        public const int PLATFORM_ANGLE_MAX_VERSION_MINOR = 0x3205;
        public const int PLATFORM_ANGLE_TYPE_DEFAULT = 0x3206;
        public const int PLATFORM_ANGLE_TYPE_D3D9 = 0x3207;
        public const int PLATFORM_ANGLE_TYPE_D3D11 = 0x3208;
        public const int PLATFORM_ANGLE_DEVICE_TYPE = 0x3209;
        public const int PLATFORM_ANGLE_DEVICE_TYPE_HARDWARE = 0x320A;
        public const int PLATFORM_ANGLE_DEVICE_TYPE_WARP = 0x320B;
        public const int PLATFORM_ANGLE_DEVICE_TYPE_REFERENCE = 0x320C;
        public const int PLATFORM_ANGLE_TYPE_OPENGL = 0x320D;
        public const int PLATFORM_ANGLE_TYPE_OPENGLES = 0x320E;
        // See EGL_ANGLE_surface_d3d_texture_2d_share_handle
        public const int EGL_D3D_TEXTURE_2D_SHARE_HANDLE_ANGLE = 0x3200;

        [DllImport("libEGL.dll", EntryPoint = "eglGetPlatformDisplayEXT")]
        public static extern EGLDisplay GetPlatformDisplay(int platform, EGLNativeDisplayType display_id,
            int[] attrib_list);

    }
}