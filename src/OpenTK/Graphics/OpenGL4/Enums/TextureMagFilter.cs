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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMagFilter
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = 0x2600,

        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = 0x2601,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        /// </summary>
        LinearDetailSgis = 0x8097,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        /// </summary>
        LinearDetailAlphaSgis = 0x8098,

        /// <summary>
        /// Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        /// </summary>
        LinearDetailColorSgis = 0x8099,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        /// </summary>
        LinearSharpenSgis = 0x80ad,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        /// </summary>
        LinearSharpenAlphaSgis = 0x80ae,

        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        /// </summary>
        LinearSharpenColorSgis = 0x80af,

        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = 0x8146,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = 0x8184,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = 0x8185,

        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = 0x8186
    }
}
