//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
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

using System;

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFloatPixels
    {
        /// <summary>
        /// Original was GL_HALF_APPLE = 0x140B
        /// </summary>
        HalfApple = 0x140b,

        /// <summary>
        /// Original was GL_RGBA_FLOAT32_APPLE = 0x8814
        /// </summary>
        RgbaFloat32Apple = 0x8814,

        /// <summary>
        /// Original was GL_RGB_FLOAT32_APPLE = 0x8815
        /// </summary>
        RgbFloat32Apple = 0x8815,

        /// <summary>
        /// Original was GL_ALPHA_FLOAT32_APPLE = 0x8816
        /// </summary>
        AlphaFloat32Apple = 0x8816,

        /// <summary>
        /// Original was GL_INTENSITY_FLOAT32_APPLE = 0x8817
        /// </summary>
        IntensityFloat32Apple = 0x8817,

        /// <summary>
        /// Original was GL_LUMINANCE_FLOAT32_APPLE = 0x8818
        /// </summary>
        LuminanceFloat32Apple = 0x8818,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819
        /// </summary>
        LuminanceAlphaFloat32Apple = 0x8819,

        /// <summary>
        /// Original was GL_RGBA_FLOAT16_APPLE = 0x881A
        /// </summary>
        RgbaFloat16Apple = 0x881a,

        /// <summary>
        /// Original was GL_RGB_FLOAT16_APPLE = 0x881B
        /// </summary>
        RgbFloat16Apple = 0x881b,

        /// <summary>
        /// Original was GL_ALPHA_FLOAT16_APPLE = 0x881C
        /// </summary>
        AlphaFloat16Apple = 0x881c,

        /// <summary>
        /// Original was GL_INTENSITY_FLOAT16_APPLE = 0x881D
        /// </summary>
        IntensityFloat16Apple = 0x881d,

        /// <summary>
        /// Original was GL_LUMINANCE_FLOAT16_APPLE = 0x881E
        /// </summary>
        LuminanceFloat16Apple = 0x881e,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F
        /// </summary>
        LuminanceAlphaFloat16Apple = 0x881f,

        /// <summary>
        /// Original was GL_COLOR_FLOAT_APPLE = 0x8A0F
        /// </summary>
        ColorFloatApple = 0x8a0f
    }
}
