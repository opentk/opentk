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
    /// Not used directly.
    /// </summary>
    public enum UniformPName
    {
        /// <summary>
        /// Original was GL_UNIFORM_TYPE = 0x8A37
        /// </summary>
        UniformType = 0x8a37,

        /// <summary>
        /// Original was GL_UNIFORM_SIZE = 0x8A38
        /// </summary>
        UniformSize = 0x8a38,

        /// <summary>
        /// Original was GL_UNIFORM_NAME_LENGTH = 0x8A39
        /// </summary>
        UniformNameLength = 0x8a39,

        /// <summary>
        /// Original was GL_UNIFORM_BLOCK_INDEX = 0x8A3A
        /// </summary>
        UniformBlockIndex = 0x8a3a,

        /// <summary>
        /// Original was GL_UNIFORM_OFFSET = 0x8A3B
        /// </summary>
        UniformOffset = 0x8a3b,

        /// <summary>
        /// Original was GL_UNIFORM_ARRAY_STRIDE = 0x8A3C
        /// </summary>
        UniformArrayStride = 0x8a3c,

        /// <summary>
        /// Original was GL_UNIFORM_MATRIX_STRIDE = 0x8A3D
        /// </summary>
        UniformMatrixStride = 0x8a3d,

        /// <summary>
        /// Original was GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E
        /// </summary>
        UniformIsRowMajor = 0x8a3e,

        /// <summary>
        /// Original was GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        /// </summary>
        UniformAtomicCounterBufferIndex = 0x92da
    }
}
