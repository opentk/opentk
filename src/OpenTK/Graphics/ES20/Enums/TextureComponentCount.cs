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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.TexImage2D, GL.Oes.TexImage3D
    /// </summary>
    public enum TextureComponentCount
    {
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
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = 0x803c,

        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = 0x8045,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = 0x8229,

        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = 0x822b,

        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = 0x822d,

        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = 0x822e,

        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = 0x822f,

        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = 0x8230,

        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = 0x8814,

        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = 0x8815,

        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = 0x8816,

        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = 0x8818,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = 0x8819,

        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = 0x881a,

        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = 0x881b,

        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = 0x881c,

        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = 0x881e,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = 0x881f,

        /// <summary>
        /// Original was GL_RGB_RAW_422_APPLE = 0x8A51
        /// </summary>
        RgbRaw422Apple = 0x8a51,

        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = 0x93a1
    }
}
