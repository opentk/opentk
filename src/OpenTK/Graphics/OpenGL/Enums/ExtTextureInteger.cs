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
    public enum ExtTextureInteger
    {
        /// <summary>
        /// Original was GL_RGBA32UI_EXT = 0x8D70
        /// </summary>
        Rgba32uiExt = 0x8d70,

        /// <summary>
        /// Original was GL_RGB32UI_EXT = 0x8D71
        /// </summary>
        Rgb32uiExt = 0x8d71,

        /// <summary>
        /// Original was GL_ALPHA32UI_EXT = 0x8D72
        /// </summary>
        Alpha32uiExt = 0x8d72,

        /// <summary>
        /// Original was GL_INTENSITY32UI_EXT = 0x8D73
        /// </summary>
        Intensity32uiExt = 0x8d73,

        /// <summary>
        /// Original was GL_LUMINANCE32UI_EXT = 0x8D74
        /// </summary>
        Luminance32uiExt = 0x8d74,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32UI_EXT = 0x8D75
        /// </summary>
        LuminanceAlpha32uiExt = 0x8d75,

        /// <summary>
        /// Original was GL_RGBA16UI_EXT = 0x8D76
        /// </summary>
        Rgba16uiExt = 0x8d76,

        /// <summary>
        /// Original was GL_RGB16UI_EXT = 0x8D77
        /// </summary>
        Rgb16uiExt = 0x8d77,

        /// <summary>
        /// Original was GL_ALPHA16UI_EXT = 0x8D78
        /// </summary>
        Alpha16uiExt = 0x8d78,

        /// <summary>
        /// Original was GL_INTENSITY16UI_EXT = 0x8D79
        /// </summary>
        Intensity16uiExt = 0x8d79,

        /// <summary>
        /// Original was GL_LUMINANCE16UI_EXT = 0x8D7A
        /// </summary>
        Luminance16uiExt = 0x8d7a,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16UI_EXT = 0x8D7B
        /// </summary>
        LuminanceAlpha16uiExt = 0x8d7b,

        /// <summary>
        /// Original was GL_RGBA8UI_EXT = 0x8D7C
        /// </summary>
        Rgba8uiExt = 0x8d7c,

        /// <summary>
        /// Original was GL_RGB8UI_EXT = 0x8D7D
        /// </summary>
        Rgb8uiExt = 0x8d7d,

        /// <summary>
        /// Original was GL_ALPHA8UI_EXT = 0x8D7E
        /// </summary>
        Alpha8uiExt = 0x8d7e,

        /// <summary>
        /// Original was GL_INTENSITY8UI_EXT = 0x8D7F
        /// </summary>
        Intensity8uiExt = 0x8d7f,

        /// <summary>
        /// Original was GL_LUMINANCE8UI_EXT = 0x8D80
        /// </summary>
        Luminance8uiExt = 0x8d80,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA8UI_EXT = 0x8D81
        /// </summary>
        LuminanceAlpha8uiExt = 0x8d81,

        /// <summary>
        /// Original was GL_RGBA32I_EXT = 0x8D82
        /// </summary>
        Rgba32iExt = 0x8d82,

        /// <summary>
        /// Original was GL_RGB32I_EXT = 0x8D83
        /// </summary>
        Rgb32iExt = 0x8d83,

        /// <summary>
        /// Original was GL_ALPHA32I_EXT = 0x8D84
        /// </summary>
        Alpha32iExt = 0x8d84,

        /// <summary>
        /// Original was GL_INTENSITY32I_EXT = 0x8D85
        /// </summary>
        Intensity32iExt = 0x8d85,

        /// <summary>
        /// Original was GL_LUMINANCE32I_EXT = 0x8D86
        /// </summary>
        Luminance32iExt = 0x8d86,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32I_EXT = 0x8D87
        /// </summary>
        LuminanceAlpha32iExt = 0x8d87,

        /// <summary>
        /// Original was GL_RGBA16I_EXT = 0x8D88
        /// </summary>
        Rgba16iExt = 0x8d88,

        /// <summary>
        /// Original was GL_RGB16I_EXT = 0x8D89
        /// </summary>
        Rgb16iExt = 0x8d89,

        /// <summary>
        /// Original was GL_ALPHA16I_EXT = 0x8D8A
        /// </summary>
        Alpha16iExt = 0x8d8a,

        /// <summary>
        /// Original was GL_INTENSITY16I_EXT = 0x8D8B
        /// </summary>
        Intensity16iExt = 0x8d8b,

        /// <summary>
        /// Original was GL_LUMINANCE16I_EXT = 0x8D8C
        /// </summary>
        Luminance16iExt = 0x8d8c,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16I_EXT = 0x8D8D
        /// </summary>
        LuminanceAlpha16iExt = 0x8d8d,

        /// <summary>
        /// Original was GL_RGBA8I_EXT = 0x8D8E
        /// </summary>
        Rgba8iExt = 0x8d8e,

        /// <summary>
        /// Original was GL_RGB8I_EXT = 0x8D8F
        /// </summary>
        Rgb8iExt = 0x8d8f,

        /// <summary>
        /// Original was GL_ALPHA8I_EXT = 0x8D90
        /// </summary>
        Alpha8iExt = 0x8d90,

        /// <summary>
        /// Original was GL_INTENSITY8I_EXT = 0x8D91
        /// </summary>
        Intensity8iExt = 0x8d91,

        /// <summary>
        /// Original was GL_LUMINANCE8I_EXT = 0x8D92
        /// </summary>
        Luminance8iExt = 0x8d92,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA8I_EXT = 0x8D93
        /// </summary>
        LuminanceAlpha8iExt = 0x8d93,

        /// <summary>
        /// Original was GL_RED_INTEGER_EXT = 0x8D94
        /// </summary>
        RedIntegerExt = 0x8d94,

        /// <summary>
        /// Original was GL_GREEN_INTEGER_EXT = 0x8D95
        /// </summary>
        GreenIntegerExt = 0x8d95,

        /// <summary>
        /// Original was GL_BLUE_INTEGER_EXT = 0x8D96
        /// </summary>
        BlueIntegerExt = 0x8d96,

        /// <summary>
        /// Original was GL_ALPHA_INTEGER_EXT = 0x8D97
        /// </summary>
        AlphaIntegerExt = 0x8d97,

        /// <summary>
        /// Original was GL_RGB_INTEGER_EXT = 0x8D98
        /// </summary>
        RgbIntegerExt = 0x8d98,

        /// <summary>
        /// Original was GL_RGBA_INTEGER_EXT = 0x8D99
        /// </summary>
        RgbaIntegerExt = 0x8d99,

        /// <summary>
        /// Original was GL_BGR_INTEGER_EXT = 0x8D9A
        /// </summary>
        BgrIntegerExt = 0x8d9a,

        /// <summary>
        /// Original was GL_BGRA_INTEGER_EXT = 0x8D9B
        /// </summary>
        BgraIntegerExt = 0x8d9b,

        /// <summary>
        /// Original was GL_LUMINANCE_INTEGER_EXT = 0x8D9C
        /// </summary>
        LuminanceIntegerExt = 0x8d9c,

        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D
        /// </summary>
        LuminanceAlphaIntegerExt = 0x8d9d,

        /// <summary>
        /// Original was GL_RGBA_INTEGER_MODE_EXT = 0x8D9E
        /// </summary>
        RgbaIntegerModeExt = 0x8d9e
    }
}
