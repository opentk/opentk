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
    public enum ExtTexture
    {
        /// <summary>
        /// Original was GL_ALPHA4_EXT = 0x803B
        /// </summary>
        Alpha4Ext = 0x803b,

        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = 0x803c,

        /// <summary>
        /// Original was GL_ALPHA12_EXT = 0x803D
        /// </summary>
        Alpha12Ext = 0x803d,

        /// <summary>
        /// Original was GL_ALPHA16_EXT = 0x803E
        /// </summary>
        Alpha16Ext = 0x803e,

        /// <summary>
        /// Original was GL_LUMINANCE4_EXT = 0x803F
        /// </summary>
        Luminance4Ext = 0x803f,

        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = 0x8040,

        /// <summary>
        /// Original was GL_LUMINANCE12_EXT = 0x8041
        /// </summary>
        Luminance12Ext = 0x8041,

        /// <summary>
        /// Original was GL_LUMINANCE16_EXT = 0x8042
        /// </summary>
        Luminance16Ext = 0x8042,

        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4_EXT = 0x8043
        /// </summary>
        Luminance4Alpha4Ext = 0x8043,

        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2_EXT = 0x8044
        /// </summary>
        Luminance6Alpha2Ext = 0x8044,

        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = 0x8045,

        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4_EXT = 0x8046
        /// </summary>
        Luminance12Alpha4Ext = 0x8046,

        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12_EXT = 0x8047
        /// </summary>
        Luminance12Alpha12Ext = 0x8047,

        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16_EXT = 0x8048
        /// </summary>
        Luminance16Alpha16Ext = 0x8048,

        /// <summary>
        /// Original was GL_INTENSITY_EXT = 0x8049
        /// </summary>
        IntensityExt = 0x8049,

        /// <summary>
        /// Original was GL_INTENSITY4_EXT = 0x804A
        /// </summary>
        Intensity4Ext = 0x804a,

        /// <summary>
        /// Original was GL_INTENSITY8_EXT = 0x804B
        /// </summary>
        Intensity8Ext = 0x804b,

        /// <summary>
        /// Original was GL_INTENSITY12_EXT = 0x804C
        /// </summary>
        Intensity12Ext = 0x804c,

        /// <summary>
        /// Original was GL_INTENSITY16_EXT = 0x804D
        /// </summary>
        Intensity16Ext = 0x804d,

        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = 0x804e,

        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = 0x804f,

        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = 0x8050,

        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = 0x8051,

        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = 0x8052,

        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = 0x8053,

        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = 0x8054,

        /// <summary>
        /// Original was GL_RGBA2_EXT = 0x8055
        /// </summary>
        Rgba2Ext = 0x8055,

        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = 0x8056,

        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = 0x8057,

        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = 0x8058,

        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = 0x8059,

        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = 0x805a,

        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = 0x805b,

        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE_EXT = 0x805C
        /// </summary>
        TextureRedSizeExt = 0x805c,

        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE_EXT = 0x805D
        /// </summary>
        TextureGreenSizeExt = 0x805d,

        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE_EXT = 0x805E
        /// </summary>
        TextureBlueSizeExt = 0x805e,

        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE_EXT = 0x805F
        /// </summary>
        TextureAlphaSizeExt = 0x805f,

        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE_EXT = 0x8060
        /// </summary>
        TextureLuminanceSizeExt = 0x8060,

        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE_EXT = 0x8061
        /// </summary>
        TextureIntensitySizeExt = 0x8061,

        /// <summary>
        /// Original was GL_REPLACE_EXT = 0x8062
        /// </summary>
        ReplaceExt = 0x8062,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = 0x8063,

        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = 0x8064,

        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = 0x8065
    }
}
