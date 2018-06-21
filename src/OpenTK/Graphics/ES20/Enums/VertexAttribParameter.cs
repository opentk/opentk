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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.GetVertexAttrib
    /// </summary>
    public enum VertexAttribParameter
    {
        /// <summary>
        /// Original was GL_VertexAttribArrayEnabled = 0X8622
        /// </summary>
        VertexAttribArrayEnabled = 0X8622,

        /// <summary>
        /// Original was GL_VertexAttribArraySize = 0X8623
        /// </summary>
        VertexAttribArraySize = 0X8623,

        /// <summary>
        /// Original was GL_VertexAttribArrayStride = 0X8624
        /// </summary>
        VertexAttribArrayStride = 0X8624,

        /// <summary>
        /// Original was GL_VertexAttribArrayType = 0X8625
        /// </summary>
        VertexAttribArrayType = 0X8625,

        /// <summary>
        /// Original was GL_CurrentVertexAttrib = 0X8626
        /// </summary>
        CurrentVertexAttrib = 0X8626,

        /// <summary>
        /// Original was GL_VertexAttribArrayNormalized = 0X886a
        /// </summary>
        VertexAttribArrayNormalized = 0X886a,

        /// <summary>
        /// Original was GL_VertexAttribArrayBufferBinding = 0X889f
        /// </summary>
        VertexAttribArrayBufferBinding = 0X889f
    }
}
