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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AttributeType
    {
        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8B50,

        /// <summary>
        /// Original was GL_FLOAT_VEC2_ARB = 0x8B50
        /// </summary>
        FloatVec2Arb = 0x8B50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8B51,

        /// <summary>
        /// Original was GL_FLOAT_VEC3_ARB = 0x8B51
        /// </summary>
        FloatVec3Arb = 0x8B51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8B52,

        /// <summary>
        /// Original was GL_FLOAT_VEC4_ARB = 0x8B52
        /// </summary>
        FloatVec4Arb = 0x8B52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8B53,

        /// <summary>
        /// Original was GL_INT_VEC2_ARB = 0x8B53
        /// </summary>
        IntVec2Arb = 0x8B53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8B54,

        /// <summary>
        /// Original was GL_INT_VEC3_ARB = 0x8B54
        /// </summary>
        IntVec3Arb = 0x8B54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8B55,

        /// <summary>
        /// Original was GL_INT_VEC4_ARB = 0x8B55
        /// </summary>
        IntVec4Arb = 0x8B55,

        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = 0x8B56,

        /// <summary>
        /// Original was GL_BOOL_ARB = 0x8B56
        /// </summary>
        BoolArb = 0x8B56,

        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = 0x8B57,

        /// <summary>
        /// Original was GL_BOOL_VEC2_ARB = 0x8B57
        /// </summary>
        BoolVec2Arb = 0x8B57,

        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = 0x8B58,

        /// <summary>
        /// Original was GL_BOOL_VEC3_ARB = 0x8B58
        /// </summary>
        BoolVec3Arb = 0x8B58,

        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = 0x8B59,

        /// <summary>
        /// Original was GL_BOOL_VEC4_ARB = 0x8B59
        /// </summary>
        BoolVec4Arb = 0x8B59,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8B5A,

        /// <summary>
        /// Original was GL_FLOAT_MAT2_ARB = 0x8B5A
        /// </summary>
        FloatMat2Arb = 0x8B5A,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8B5B,

        /// <summary>
        /// Original was GL_FLOAT_MAT3_ARB = 0x8B5B
        /// </summary>
        FloatMat3Arb = 0x8B5B,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8B5C,

        /// <summary>
        /// Original was GL_FLOAT_MAT4_ARB = 0x8B5C
        /// </summary>
        FloatMat4Arb = 0x8B5C,

        /// <summary>
        /// Original was GL_SAMPLER1_D = 0x8B5D
        /// </summary>
        Sampler1D = 0x8B5D,

        /// <summary>
        /// Original was GL_SAMPLER1_D_ARB = 0x8B5D
        /// </summary>
        Sampler1DArb = 0x8B5D,

        /// <summary>
        /// Original was GL_SAMPLER2_D = 0x8B5E
        /// </summary>
        Sampler2D = 0x8B5E,

        /// <summary>
        /// Original was GL_SAMPLER2_D_ARB = 0x8B5E
        /// </summary>
        Sampler2DArb = 0x8B5E,

        /// <summary>
        /// Original was GL_SAMPLER3_D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8B5F,

        /// <summary>
        /// Original was GL_SAMPLER3_D_ARB = 0x8B5F
        /// </summary>
        Sampler3DArb = 0x8B5F,

        /// <summary>
        /// Original was GL_SAMPLER3_D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = 0x8B5F,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = 0x8B60,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_ARB = 0x8B60
        /// </summary>
        SamplerCubeArb = 0x8B60,

        /// <summary>
        /// Original was GL_SAMPLER1_D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = 0x8B61,

        /// <summary>
        /// Original was GL_SAMPLER1_D_SHADOW_ARB = 0x8B61
        /// </summary>
        Sampler1DShadowArb = 0x8B61,

        /// <summary>
        /// Original was GL_SAMPLER2_D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8B62,

        /// <summary>
        /// Original was GL_SAMPLER2_D_SHADOW_ARB = 0x8B62
        /// </summary>
        Sampler2DShadowArb = 0x8B62,

        /// <summary>
        /// Original was GL_SAMPLER2_D_SHADOW_EXT = 0x8B62
        /// </summary>
        Sampler2DShadowExt = 0x8B62,

        /// <summary>
        /// Original was GL_SAMPLER2_D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = 0x8B63,

        /// <summary>
        /// Original was GL_SAMPLER2_D_RECT_ARB = 0x8B63
        /// </summary>
        Sampler2DRectArb = 0x8B63,

        /// <summary>
        /// Original was GL_SAMPLER2_D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = 0x8B64,

        /// <summary>
        /// Original was GL_SAMPLER2_D_RECT_SHADOW_ARB = 0x8B64
        /// </summary>
        Sampler2DRectShadowArb = 0x8B64,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8B65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X3_NV = 0x8B65
        /// </summary>
        FloatMat2x3NV = 0x8B65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8B66,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X4_NV = 0x8B66
        /// </summary>
        FloatMat2x4NV = 0x8B66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8B67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X2_NV = 0x8B67
        /// </summary>
        FloatMat3x2NV = 0x8B67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8B68,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X4_NV = 0x8B68
        /// </summary>
        FloatMat3x4NV = 0x8B68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8B69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X2_NV = 0x8B69
        /// </summary>
        FloatMat4x2NV = 0x8B69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8B6A,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X3_NV = 0x8B6A
        /// </summary>
        FloatMat4x3NV = 0x8B6A
    }
}
