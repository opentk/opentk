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
    public enum ExtTextureCompressionLatc
    {
        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70
        /// </summary>
        CompressedLuminanceLatc1Ext = 0x8c70,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71
        /// </summary>
        CompressedSignedLuminanceLatc1Ext = 0x8c71,

        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72
        /// </summary>
        CompressedLuminanceAlphaLatc2Ext = 0x8c72,

        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73
        /// </summary>
        CompressedSignedLuminanceAlphaLatc2Ext = 0x8c73
    }
}
