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
    /// Used in GL.Arb.GetVertexAttrib, GL.Arb.GetVertexAttribL and 1 other function
    /// </summary>
    public enum VertexAttribParameterArb
    {
        /// <summary>
        /// Original was GL_ARRAY_ENABLED = 0x8622
        /// </summary>
        ArrayEnabled = 0x8622,

        /// <summary>
        /// Original was GL_ARRAY_SIZE = 0x8623
        /// </summary>
        ArraySize = 0x8623,

        /// <summary>
        /// Original was GL_ARRAY_STRIDE = 0x8624
        /// </summary>
        ArrayStride = 0x8624,

        /// <summary>
        /// Original was GL_ARRAY_TYPE = 0x8625
        /// </summary>
        ArrayType = 0x8625,

        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        /// </summary>
        CurrentVertexAttrib = 0x8626,

        /// <summary>
        /// Original was GL_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        ArrayNormalized = 0x886a,

        /// <summary>
        /// Original was GL_ARRAY_DIVISOR = 0x88FE
        /// </summary>
        ArrayDivisor = 0x88fe
    }
}
