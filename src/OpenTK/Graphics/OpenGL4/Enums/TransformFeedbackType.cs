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
    /// Used in GL.GetTransformFeedbackVarying
    /// </summary>
    public enum TransformFeedbackType
    {
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = 0x140a,

        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8b50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8b51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8b52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8b53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8b54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8b55,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8b5a,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8b5b,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8b5c,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8b66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8b67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3x4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8b68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8b69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4x3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8b6a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        /// </summary>
        UnsignedIntVec2 = 0x8dc6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        /// </summary>
        UnsignedIntVec3 = 0x8dc7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        /// </summary>
        UnsignedIntVec4 = 0x8dc8,

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
