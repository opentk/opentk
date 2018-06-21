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
    public enum ArbTextureCompression
    {
        /// <summary>
        /// Original was GL_COMPRESSED_ALPHA_ARB = 0x84E9
        /// </summary>
        CompressedAlphaArb = 0x84e9,

        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE_ARB = 0x84EA
        /// </summary>
        CompressedLuminanceArb = 0x84ea,

        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB
        /// </summary>
        CompressedLuminanceAlphaArb = 0x84eb,

        /// <summary>
        /// Original was GL_COMPRESSED_INTENSITY_ARB = 0x84EC
        /// </summary>
        CompressedIntensityArb = 0x84ec,

        /// <summary>
        /// Original was GL_COMPRESSED_RGB_ARB = 0x84ED
        /// </summary>
        CompressedRgbArb = 0x84ed,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ARB = 0x84EE
        /// </summary>
        CompressedRgbaArb = 0x84ee,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        /// </summary>
        TextureCompressionHintArb = 0x84ef,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0
        /// </summary>
        TextureCompressedImageSizeArb = 0x86a0,

        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSED_ARB = 0x86A1
        /// </summary>
        TextureCompressedArb = 0x86a1,

        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2
        /// </summary>
        NumCompressedTextureFormatsArb = 0x86a2,

        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3
        /// </summary>
        CompressedTextureFormatsArb = 0x86a3
    }
}
