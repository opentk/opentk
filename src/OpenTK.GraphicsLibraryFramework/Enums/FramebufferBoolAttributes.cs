//
// FramebufferBoolAttributes.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Defines available parameters for
    /// <see cref="IGLFW.WindowHint(FramebufferBoolAttributes,bool)"/>.
    /// </summary>
    public enum FramebufferBoolAttributes
    {
        /// <summary>
        /// Specifies whether to use stereoscopic rendering. This is a hard constraint.
        /// </summary>
        Stereo = 0x0002100C,

        /// <summary>
        /// Specifies whether the framebuffer should be double buffered.
        /// You nearly always want to use double buffering. This is a hard constraint.
        /// </summary>
        DoubleBuffer = 0x00021010,

        /// <summary>
        /// Specifies whether the framebuffer should be sRGB capable.
        /// If supported, a created OpenGL context will support the
        /// <c>GL_FRAMEBUFFER_SRGB</c> enable( also called <c>GL_FRAMEBUFFER_SRGB_EXT</c>)
        /// for controlling sRGB rendering and a created OpenGL ES context will always have sRGB rendering enabled.
        /// </summary>
        SrgbCapable = 0x0002100E,
    }
}
