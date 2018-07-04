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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixIccTexture
    {
        /// <summary>
        /// Original was GL_RGB_ICC_SGIX = 0x8460
        /// </summary>
        RgbIccSgix = 0x8460,

        /// <summary>
        /// Original was GL_RGBA_ICC_SGIX = 0x8461
        /// </summary>
        RgbaIccSgix = 0x8461,

        /// <summary>
        /// Original was GL_ALPHA_ICC_SGIX = 0x8462
        /// </summary>
        AlphaIccSgix = 0x8462,

        /// <summary>
        /// Original was GL_LUMINANCE_ICC_SGIX = 0x8463
        /// </summary>
        LuminanceIccSgix = 0x8463,

        /// <summary>
        /// Original was GL_INTENSITY_ICC_SGIX = 0x8464
        /// </summary>
        IntensityIccSgix = 0x8464,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA_ICC_SGIX = 0x8465
        /// </summary>
        LuminanceAlphaIccSgix = 0x8465,

        /// <summary>
        /// Original was GL_R5_G6_B5_ICC_SGIX = 0x8466
        /// </summary>
        R5G6B5IccSgix = 0x8466,

        /// <summary>
        /// Original was GL_R5_G6_B5_A8_ICC_SGIX = 0x8467
        /// </summary>
        R5G6B5A8IccSgix = 0x8467,

        /// <summary>
        /// Original was GL_ALPHA16_ICC_SGIX = 0x8468
        /// </summary>
        Alpha16IccSgix = 0x8468,

        /// <summary>
        /// Original was GL_LUMINANCE16_ICC_SGIX = 0x8469
        /// </summary>
        Luminance16IccSgix = 0x8469,

        /// <summary>
        /// Original was GL_INTENSITY16_ICC_SGIX = 0x846A
        /// </summary>
        Intensity16IccSgix = 0x846a,

        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        /// </summary>
        Luminance16Alpha8IccSgix = 0x846b
    }
}
