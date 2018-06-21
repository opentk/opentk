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
    /// Used in GL.GetActiveUniform
    /// </summary>
    public enum ActiveUniformType
    {
        /// <summary>
        /// Original was GL_Int = 0X1404
        /// </summary>
        Int = 0X1404,

        /// <summary>
        /// Original was GL_Float = 0X1406
        /// </summary>
        Float = 0X1406,

        /// <summary>
        /// Original was GL_Bool = 0X8b56
        /// </summary>
        Bool = 0X8b56,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

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
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = 0x8b57,

        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = 0x8b58,

        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = 0x8b59,

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
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = 0x8b5e,

        /// <summary>
        /// Original was GL_SAMPLER_3D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8b5f,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = 0x8b60,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8b62,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8b65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2x4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8b66,

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
        /// Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        /// </summary>
        Sampler2DArray = 0x8dc1,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4
        /// </summary>
        Sampler2DArrayShadow = 0x8dc4,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        /// </summary>
        SamplerCubeShadow = 0x8dc5,

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
        /// Original was GL_INT_SAMPLER_2D = 0x8DCA
        /// </summary>
        IntSampler2D = 0x8dca,

        /// <summary>
        /// Original was GL_INT_SAMPLER_3D = 0x8DCB
        /// </summary>
        IntSampler3D = 0x8dcb,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        /// </summary>
        IntSamplerCube = 0x8dcc,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        /// </summary>
        IntSampler2DArray = 0x8dcf,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2
        /// </summary>
        UnsignedIntSampler2D = 0x8dd2,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3
        /// </summary>
        UnsignedIntSampler3D = 0x8dd3,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        /// </summary>
        UnsignedIntSamplerCube = 0x8dd4,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        /// </summary>
        UnsignedIntSampler2DArray = 0x8dd7
    }
}
