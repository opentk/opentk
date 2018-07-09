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
    /// Used in GL.Arb.GetImageHandle and GL.Arb.GetnColorTable, as well as 72 other functions.
    /// </summary>
    public enum PixelFormat
    {
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = 0x1900,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = 0x1902,

        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = 0x1903,

        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = 0x1903,

        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = 0x1904,

        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = 0x1905,

        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = 0x1906,

        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = 0x1907,

        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = 0x1908,

        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = 0x1909,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = 0x190a,

        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = 0x8000,

        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = 0x800c,

        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = 0x800d,

        /// <summary>
        /// Original was GL_BGR = 0x80E0
        /// </summary>
        Bgr = 0x80e0,

        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = 0x80e1,

        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = 0x81bb,

        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = 0x81bc,

        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = 0x8227,

        /// <summary>
        /// Original was GL_RG_INTEGER = 0x8228
        /// </summary>
        RgInteger = 0x8228,

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
        /// Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        /// </summary>
        Luminance16Alpha8IccSgix = 0x846b,

        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = 0x84f9,

        /// <summary>
        /// Original was GL_RED_INTEGER = 0x8D94
        /// </summary>
        RedInteger = 0x8d94,

        /// <summary>
        /// Original was GL_GREEN_INTEGER = 0x8D95
        /// </summary>
        GreenInteger = 0x8d95,

        /// <summary>
        /// Original was GL_BLUE_INTEGER = 0x8D96
        /// </summary>
        BlueInteger = 0x8d96,

        /// <summary>
        /// Original was GL_ALPHA_INTEGER = 0x8D97
        /// </summary>
        AlphaInteger = 0x8d97,

        /// <summary>
        /// Original was GL_RGB_INTEGER = 0x8D98
        /// </summary>
        RgbInteger = 0x8d98,

        /// <summary>
        /// Original was GL_RGBA_INTEGER = 0x8D99
        /// </summary>
        RgbaInteger = 0x8d99,

        /// <summary>
        /// Original was GL_BGR_INTEGER = 0x8D9A
        /// </summary>
        BgrInteger = 0x8d9a,

        /// <summary>
        /// Original was GL_BGRA_INTEGER = 0x8D9B
        /// </summary>
        BgraInteger = 0x8d9b
    }
}
