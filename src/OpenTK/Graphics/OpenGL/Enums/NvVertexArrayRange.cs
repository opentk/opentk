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
    public enum NvVertexArrayRange
    {
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_RANGE_NV = 0x851D
        /// </summary>
        VertexArrayRangeNv = 0x851d,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E
        /// </summary>
        VertexArrayRangeLengthNv = 0x851e,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F
        /// </summary>
        VertexArrayRangeValidNv = 0x851f,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520
        /// </summary>
        MaxVertexArrayRangeElementNv = 0x8520,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521
        /// </summary>
        VertexArrayRangePointerNv = 0x8521
    }
}
