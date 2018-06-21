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

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvSrgbFormats
    {
        /// <summary>
        /// Original was GL_ETC1_SRGB8_NV = 0x88EE
        /// </summary>
        Etc1Srgb8Nv = 0x88ee,

        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = 0x8c41,

        /// <summary>
        /// Original was GL_SLUMINANCE_ALPHA_NV = 0x8C44
        /// </summary>
        SluminanceAlphaNv = 0x8c44,

        /// <summary>
        /// Original was GL_SLUMINANCE8_ALPHA8_NV = 0x8C45
        /// </summary>
        Sluminance8Alpha8Nv = 0x8c45,

        /// <summary>
        /// Original was GL_SLUMINANCE_NV = 0x8C46
        /// </summary>
        SluminanceNv = 0x8c46,

        /// <summary>
        /// Original was GL_SLUMINANCE8_NV = 0x8C47
        /// </summary>
        Sluminance8Nv = 0x8c47,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_NV = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Nv = 0x8c4c,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Nv = 0x8c4d,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Nv = 0x8c4e,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Nv = 0x8c4f
    }
}
