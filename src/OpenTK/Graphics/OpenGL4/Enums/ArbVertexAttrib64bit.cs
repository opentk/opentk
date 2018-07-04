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

#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexAttrib64bit
    {
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = 0x8d83,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2 = 0x8F46
        /// </summary>
        DoubleMat2 = 0x8f46,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3 = 0x8F47
        /// </summary>
        DoubleMat3 = 0x8f47,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4 = 0x8F48
        /// </summary>
        DoubleMat4 = 0x8f48,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2x3 = 0x8F49
        /// </summary>
        DoubleMat2x3 = 0x8f49,

        /// <summary>
        /// Original was GL_DOUBLE_MAT2x4 = 0x8F4A
        /// </summary>
        DoubleMat2x4 = 0x8f4a,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3x2 = 0x8F4B
        /// </summary>
        DoubleMat3x2 = 0x8f4b,

        /// <summary>
        /// Original was GL_DOUBLE_MAT3x4 = 0x8F4C
        /// </summary>
        DoubleMat3x4 = 0x8f4c,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4x2 = 0x8F4D
        /// </summary>
        DoubleMat4x2 = 0x8f4d,

        /// <summary>
        /// Original was GL_DOUBLE_MAT4x3 = 0x8F4E
        /// </summary>
        DoubleMat4x3 = 0x8f4e,

        /// <summary>
        /// Original was GL_DOUBLE_VEC2 = 0x8FFC
        /// </summary>
        DoubleVec2 = 0x8ffc,

        /// <summary>
        /// Original was GL_DOUBLE_VEC3 = 0x8FFD
        /// </summary>
        DoubleVec3 = 0x8ffd,

        /// <summary>
        /// Original was GL_DOUBLE_VEC4 = 0x8FFE
        /// </summary>
        DoubleVec4 = 0x8ffe
    }
}
