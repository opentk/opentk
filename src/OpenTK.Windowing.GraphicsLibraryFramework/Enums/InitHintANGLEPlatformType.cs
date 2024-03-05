using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    public enum InitHintANGLEPlatformType
    {
        /// <summary>
        /// Specifies the platform type (rendering backend) to request when using OpenGL ES and EGL via ANGLE.
        /// If the requested platform type is unavailable, ANGLE will use its default.
        /// Possible values are one of <see cref="ANGLEPlatformType.None"/>, <see cref="ANGLEPlatformType.OpenGL"/>, <see cref="ANGLEPlatformType.OpenGLES"/>, <see cref="ANGLEPlatformType.D3D9"/>, <see cref="ANGLEPlatformType.D3D11"/>, <see cref="ANGLEPlatformType.Vulkan"/> and <see cref="ANGLEPlatformType.Metal"/>.
        ///
        /// The ANGLE platform type is specified via the EGL_ANGLE_platform_angle extension.
        /// This extension is not used if this hint is GLFW_ANGLE_PLATFORM_TYPE_NONE, which is the default value.
        /// </summary>
        ANGLEPlatformType = 0x00050002,
    }
}
