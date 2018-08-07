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
    /// Used in GL.GetActiveUniform.
    /// </summary>
    public enum ActiveUniformType
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
        Double = 0x140A,

        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = 0x8B50,

        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = 0x8B51,

        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = 0x8B52,

        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = 0x8B53,

        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = 0x8B54,

        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = 0x8B55,

        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = 0x8B56,

        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = 0x8B57,

        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = 0x8B58,

        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = 0x8B59,

        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = 0x8B5A,

        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = 0x8B5B,

        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = 0x8B5C,

        /// <summary>
        /// Original was GL_SAMPLER1_D = 0x8B5D
        /// </summary>
        Sampler1D = 0x8B5D,

        /// <summary>
        /// Original was GL_SAMPLER2_D = 0x8B5E
        /// </summary>
        Sampler2D = 0x8B5E,

        /// <summary>
        /// Original was GL_SAMPLER3_D = 0x8B5F
        /// </summary>
        Sampler3D = 0x8B5F,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = 0x8B60,

        /// <summary>
        /// Original was GL_SAMPLER1_D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = 0x8B61,

        /// <summary>
        /// Original was GL_SAMPLER2_D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8B62,

        /// <summary>
        /// Original was GL_SAMPLER2_D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = 0x8B63,

        /// <summary>
        /// Original was GL_SAMPLER2_D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = 0x8B64,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X3 = 0x8B65
        /// </summary>
        FloatMat2x3 = 0x8B65,

        /// <summary>
        /// Original was GL_FLOAT_MAT2X4 = 0x8B66
        /// </summary>
        FloatMat2x4 = 0x8B66,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X2 = 0x8B67
        /// </summary>
        FloatMat3x2 = 0x8B67,

        /// <summary>
        /// Original was GL_FLOAT_MAT3X4 = 0x8B68
        /// </summary>
        FloatMat3x4 = 0x8B68,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X2 = 0x8B69
        /// </summary>
        FloatMat4x2 = 0x8B69,

        /// <summary>
        /// Original was GL_FLOAT_MAT4X3 = 0x8B6A
        /// </summary>
        FloatMat4x3 = 0x8B6A,

        /// <summary>
        /// Original was GL_SAMPLER1_D_ARRAY = 0x8DC0
        /// </summary>
        Sampler1DArray = 0x8DC0,

        /// <summary>
        /// Original was GL_SAMPLER2_D_ARRAY = 0x8DC1
        /// </summary>
        Sampler2DArray = 0x8DC1,

        /// <summary>
        /// Original was GL_SAMPLER_BUFFER = 0x8DC2
        /// </summary>
        SamplerBuffer = 0x8DC2,

        /// <summary>
        /// Original was GL_SAMPLER1_D_ARRAY_SHADOW = 0x8DC3
        /// </summary>
        Sampler1DArrayShadow = 0x8DC3,

        /// <summary>
        /// Original was GL_SAMPLER2_D_ARRAY_SHADOW = 0x8DC4
        /// </summary>
        Sampler2DArrayShadow = 0x8DC4,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_SHADOW = 0x8DC5
        /// </summary>
        SamplerCubeShadow = 0x8DC5,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC2 = 0x8DC6
        /// </summary>
        UnsignedIntVec2 = 0x8DC6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC3 = 0x8DC7
        /// </summary>
        UnsignedIntVec3 = 0x8DC7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_VEC4 = 0x8DC8
        /// </summary>
        UnsignedIntVec4 = 0x8DC8,

        /// <summary>
        /// Original was GL_INT_SAMPLER1_D = 0x8DC9
        /// </summary>
        IntSampler1D = 0x8DC9,

        /// <summary>
        /// Original was GL_INT_SAMPLER2_D = 0x8DCA
        /// </summary>
        IntSampler2D = 0x8DCA,

        /// <summary>
        /// Original was GL_INT_SAMPLER3_D = 0x8DCB
        /// </summary>
        IntSampler3D = 0x8DCB,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE = 0x8DCC
        /// </summary>
        IntSamplerCube = 0x8DCC,

        /// <summary>
        /// Original was GL_INT_SAMPLER2_D_RECT = 0x8DCD
        /// </summary>
        IntSampler2DRect = 0x8DCD,

        /// <summary>
        /// Original was GL_INT_SAMPLER1_D_ARRAY = 0x8DCE
        /// </summary>
        IntSampler1DArray = 0x8DCE,

        /// <summary>
        /// Original was GL_INT_SAMPLER2_D_ARRAY = 0x8DCF
        /// </summary>
        IntSampler2DArray = 0x8DCF,

        /// <summary>
        /// Original was GL_INT_SAMPLER_BUFFER = 0x8DD0
        /// </summary>
        IntSamplerBuffer = 0x8DD0,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER1_D = 0x8DD1
        /// </summary>
        UnsignedIntSampler1D = 0x8DD1,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER2_D = 0x8DD2
        /// </summary>
        UnsignedIntSampler2D = 0x8DD2,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER3_D = 0x8DD3
        /// </summary>
        UnsignedIntSampler3D = 0x8DD3,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4
        /// </summary>
        UnsignedIntSamplerCube = 0x8DD4,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER2_D_RECT = 0x8DD5
        /// </summary>
        UnsignedIntSampler2DRect = 0x8DD5,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER1_D_ARRAY = 0x8DD6
        /// </summary>
        UnsignedIntSampler1DArray = 0x8DD6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER2_D_ARRAY = 0x8DD7
        /// </summary>
        UnsignedIntSampler2DArray = 0x8DD7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8
        /// </summary>
        UnsignedIntSamplerBuffer = 0x8DD8,

        /// <summary>
        /// Original was GL_DOUBLE_VEC2 = 0x8FFC
        /// </summary>
        DoubleVec2 = 0x8FFC,

        /// <summary>
        /// Original was GL_DOUBLE_VEC3 = 0x8FFD
        /// </summary>
        DoubleVec3 = 0x8FFD,

        /// <summary>
        /// Original was GL_DOUBLE_VEC4 = 0x8FFE
        /// </summary>
        DoubleVec4 = 0x8FFE,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C
        /// </summary>
        SamplerCubeMapArray = 0x900C,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D
        /// </summary>
        SamplerCubeMapArrayShadow = 0x900D,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E
        /// </summary>
        IntSamplerCubeMapArray = 0x900E,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F
        /// </summary>
        UnsignedIntSamplerCubeMapArray = 0x900F,

        /// <summary>
        /// Original was GL_IMAGE1_D = 0x904C
        /// </summary>
        Image1D = 0x904C,

        /// <summary>
        /// Original was GL_IMAGE2_D = 0x904D
        /// </summary>
        Image2D = 0x904D,

        /// <summary>
        /// Original was GL_IMAGE3_D = 0x904E
        /// </summary>
        Image3D = 0x904E,

        /// <summary>
        /// Original was GL_IMAGE2_D_RECT = 0x904F
        /// </summary>
        Image2DRect = 0x904F,

        /// <summary>
        /// Original was GL_IMAGE_CUBE = 0x9050
        /// </summary>
        ImageCube = 0x9050,

        /// <summary>
        /// Original was GL_IMAGE_BUFFER = 0x9051
        /// </summary>
        ImageBuffer = 0x9051,

        /// <summary>
        /// Original was GL_IMAGE1_D_ARRAY = 0x9052
        /// </summary>
        Image1DArray = 0x9052,

        /// <summary>
        /// Original was GL_IMAGE2_D_ARRAY = 0x9053
        /// </summary>
        Image2DArray = 0x9053,

        /// <summary>
        /// Original was GL_IMAGE_CUBE_MAP_ARRAY = 0x9054
        /// </summary>
        ImageCubeMapArray = 0x9054,

        /// <summary>
        /// Original was GL_IMAGE2_D_MULTISAMPLE = 0x9055
        /// </summary>
        Image2DMultisample = 0x9055,

        /// <summary>
        /// Original was GL_IMAGE2_D_MULTISAMPLE_ARRAY = 0x9056
        /// </summary>
        Image2DMultisampleArray = 0x9056,

        /// <summary>
        /// Original was GL_INT_IMAGE1_D = 0x9057
        /// </summary>
        IntImage1D = 0x9057,

        /// <summary>
        /// Original was GL_INT_IMAGE2_D = 0x9058
        /// </summary>
        IntImage2D = 0x9058,

        /// <summary>
        /// Original was GL_INT_IMAGE3_D = 0x9059
        /// </summary>
        IntImage3D = 0x9059,

        /// <summary>
        /// Original was GL_INT_IMAGE2_D_RECT = 0x905A
        /// </summary>
        IntImage2DRect = 0x905A,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE = 0x905B
        /// </summary>
        IntImageCube = 0x905B,

        /// <summary>
        /// Original was GL_INT_IMAGE_BUFFER = 0x905C
        /// </summary>
        IntImageBuffer = 0x905C,

        /// <summary>
        /// Original was GL_INT_IMAGE1_D_ARRAY = 0x905D
        /// </summary>
        IntImage1DArray = 0x905D,

        /// <summary>
        /// Original was GL_INT_IMAGE2_D_ARRAY = 0x905E
        /// </summary>
        IntImage2DArray = 0x905E,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F
        /// </summary>
        IntImageCubeMapArray = 0x905F,

        /// <summary>
        /// Original was GL_INT_IMAGE2_D_MULTISAMPLE = 0x9060
        /// </summary>
        IntImage2DMultisample = 0x9060,

        /// <summary>
        /// Original was GL_INT_IMAGE2_D_MULTISAMPLE_ARRAY = 0x9061
        /// </summary>
        IntImage2DMultisampleArray = 0x9061,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE1_D = 0x9062
        /// </summary>
        UnsignedIntImage1D = 0x9062,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE2_D = 0x9063
        /// </summary>
        UnsignedIntImage2D = 0x9063,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE3_D = 0x9064
        /// </summary>
        UnsignedIntImage3D = 0x9064,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE2_D_RECT = 0x9065
        /// </summary>
        UnsignedIntImage2DRect = 0x9065,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066
        /// </summary>
        UnsignedIntImageCube = 0x9066,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067
        /// </summary>
        UnsignedIntImageBuffer = 0x9067,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE1_D_ARRAY = 0x9068
        /// </summary>
        UnsignedIntImage1DArray = 0x9068,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE2_D_ARRAY = 0x9069
        /// </summary>
        UnsignedIntImage2DArray = 0x9069,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A
        /// </summary>
        UnsignedIntImageCubeMapArray = 0x906A,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE2_D_MULTISAMPLE = 0x906B
        /// </summary>
        UnsignedIntImage2DMultisample = 0x906B,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE2_D_MULTISAMPLE_ARRAY = 0x906C
        /// </summary>
        UnsignedIntImage2DMultisampleArray = 0x906C,

        /// <summary>
        /// Original was GL_SAMPLER2_D_MULTISAMPLE = 0x9108
        /// </summary>
        Sampler2DMultisample = 0x9108,

        /// <summary>
        /// Original was GL_INT_SAMPLER2_D_MULTISAMPLE = 0x9109
        /// </summary>
        IntSampler2DMultisample = 0x9109,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER2_D_MULTISAMPLE = 0x910A
        /// </summary>
        UnsignedIntSampler2DMultisample = 0x910A,

        /// <summary>
        /// Original was GL_SAMPLER2_D_MULTISAMPLE_ARRAY = 0x910B
        /// </summary>
        Sampler2DMultisampleArray = 0x910B,

        /// <summary>
        /// Original was GL_INT_SAMPLER2_D_MULTISAMPLE_ARRAY = 0x910C
        /// </summary>
        IntSampler2DMultisampleArray = 0x910C,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER2_D_MULTISAMPLE_ARRAY = 0x910D
        /// </summary>
        UnsignedIntSampler2DMultisampleArray = 0x910D,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        /// </summary>
        UnsignedIntAtomicCounter = 0x92DB
    }
}
