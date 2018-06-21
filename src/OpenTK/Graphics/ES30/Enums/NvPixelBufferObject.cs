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
    public enum NvPixelBufferObject
    {
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER_NV = 0x88EB
        /// </summary>
        PixelPackBufferNv = 0x88eb,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER_NV = 0x88EC
        /// </summary>
        PixelUnpackBufferNv = 0x88ec,

        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER_BINDING_NV = 0x88ED
        /// </summary>
        PixelPackBufferBindingNv = 0x88ed,

        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER_BINDING_NV = 0x88EF
        /// </summary>
        PixelUnpackBufferBindingNv = 0x88ef
    }
}
