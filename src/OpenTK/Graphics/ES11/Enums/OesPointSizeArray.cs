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

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Used in GL.Oes.PointSizePointer
    /// </summary>
    public enum OesPointSizeArray
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = 0x898a,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = 0x898b,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = 0x898c,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = 0x8b9c,

        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = 0x8b9f
    }
}
