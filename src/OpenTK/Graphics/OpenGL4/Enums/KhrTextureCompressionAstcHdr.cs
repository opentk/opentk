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
    public enum KhrTextureCompressionAstcHdr
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC4X4_KHR = 0x93B0
        /// </summary>
        CompressedRgbaAstc4x4Khr = 0x93B0,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC5X4_KHR = 0x93B1
        /// </summary>
        CompressedRgbaAstc5x4Khr = 0x93B1,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC5X5_KHR = 0x93B2
        /// </summary>
        CompressedRgbaAstc5x5Khr = 0x93B2,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC6X5_KHR = 0x93B3
        /// </summary>
        CompressedRgbaAstc6x5Khr = 0x93B3,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC6X6_KHR = 0x93B4
        /// </summary>
        CompressedRgbaAstc6x6Khr = 0x93B4,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC8X5_KHR = 0x93B5
        /// </summary>
        CompressedRgbaAstc8x5Khr = 0x93B5,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC8X6_KHR = 0x93B6
        /// </summary>
        CompressedRgbaAstc8x6Khr = 0x93B6,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC8X8_KHR = 0x93B7
        /// </summary>
        CompressedRgbaAstc8x8Khr = 0x93B7,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC10X5_KHR = 0x93B8
        /// </summary>
        CompressedRgbaAstc10x5Khr = 0x93B8,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC10X6_KHR = 0x93B9
        /// </summary>
        CompressedRgbaAstc10x6Khr = 0x93B9,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC10X8_KHR = 0x93BA
        /// </summary>
        CompressedRgbaAstc10x8Khr = 0x93BA,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC10X10_KHR = 0x93BB
        /// </summary>
        CompressedRgbaAstc10x10Khr = 0x93BB,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC12X10_KHR = 0x93BC
        /// </summary>
        CompressedRgbaAstc12x10Khr = 0x93BC,

        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC12X12_KHR = 0x93BD
        /// </summary>
        CompressedRgbaAstc12x12Khr = 0x93BD,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC4X4_KHR = 0x93D0
        /// </summary>
        CompressedSrgb8Alpha8Astc4x4Khr = 0x93D0,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC5X4_KHR = 0x93D1
        /// </summary>
        CompressedSrgb8Alpha8Astc5x4Khr = 0x93D1,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC5X5_KHR = 0x93D2
        /// </summary>
        CompressedSrgb8Alpha8Astc5x5Khr = 0x93D2,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC6X5_KHR = 0x93D3
        /// </summary>
        CompressedSrgb8Alpha8Astc6x5Khr = 0x93D3,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC6X6_KHR = 0x93D4
        /// </summary>
        CompressedSrgb8Alpha8Astc6x6Khr = 0x93D4,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC8X5_KHR = 0x93D5
        /// </summary>
        CompressedSrgb8Alpha8Astc8x5Khr = 0x93D5,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC8X6_KHR = 0x93D6
        /// </summary>
        CompressedSrgb8Alpha8Astc8x6Khr = 0x93D6,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC8X8_KHR = 0x93D7
        /// </summary>
        CompressedSrgb8Alpha8Astc8x8Khr = 0x93D7,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC10X5_KHR = 0x93D8
        /// </summary>
        CompressedSrgb8Alpha8Astc10x5Khr = 0x93D8,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC10X6_KHR = 0x93D9
        /// </summary>
        CompressedSrgb8Alpha8Astc10x6Khr = 0x93D9,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC10X8_KHR = 0x93DA
        /// </summary>
        CompressedSrgb8Alpha8Astc10x8Khr = 0x93DA,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC10X10_KHR = 0x93DB
        /// </summary>
        CompressedSrgb8Alpha8Astc10x10Khr = 0x93DB,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC12X10_KHR = 0x93DC
        /// </summary>
        CompressedSrgb8Alpha8Astc12x10Khr = 0x93DC,

        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC12X12_KHR = 0x93DD
        /// </summary>
        CompressedSrgb8Alpha8Astc12x12Khr = 0x93DD
    }
}
