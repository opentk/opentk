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
    public enum ExtTextureSrgb
    {
        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = 0x8c40,

        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = 0x8c41,

        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = 0x8c42,

        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = 0x8c43,

        /// <summary>
        /// Original was GL_SLUMINANCE_ALPHA_EXT = 0x8C44
        /// </summary>
        SluminanceAlphaExt = 0x8c44,

        /// <summary>
        /// Original was GL_SLUMINANCE8_ALPHA8_EXT = 0x8C45
        /// </summary>
        Sluminance8Alpha8Ext = 0x8c45,

        /// <summary>
        /// Original was GL_SLUMINANCE_EXT = 0x8C46
        /// </summary>
        SluminanceExt = 0x8c46,

        /// <summary>
        /// Original was GL_SLUMINANCE8_EXT = 0x8C47
        /// </summary>
        Sluminance8Ext = 0x8c47,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_EXT = 0x8C48
        /// </summary>
        CompressedSrgbExt = 0x8c48,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_EXT = 0x8C49
        /// </summary>
        CompressedSrgbAlphaExt = 0x8c49,

        /// <summary>
        /// Original was GL_COMPRESSED_SLUMINANCE_EXT = 0x8C4A
        /// </summary>
        CompressedSluminanceExt = 0x8c4a,

        /// <summary>
        /// Original was GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B
        /// </summary>
        CompressedSluminanceAlphaExt = 0x8c4b,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = 0x8c4c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = 0x8c4d,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = 0x8c4e,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = 0x8c4f
    }
}
