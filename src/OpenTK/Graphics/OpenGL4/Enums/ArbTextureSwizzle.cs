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
    public enum ArbTextureSwizzle
    {
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = 0x8e42,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = 0x8e43,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = 0x8e44,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = 0x8e45,

        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        /// </summary>
        TextureSwizzleRgba = 0x8e46
    }
}
