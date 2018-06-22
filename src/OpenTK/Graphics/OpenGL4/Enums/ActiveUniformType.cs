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
    /// Used in GL.GetActiveUniform
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
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = 0x8b56,

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
        /// Original was GL_SAMPLER_1D = 0x8B5D
        /// </summary>
        Sampler1D = 0x8b5d,

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
        /// Original was GL_SAMPLER_1D_SHADOW = 0x8B61
        /// </summary>
        Sampler1DShadow = 0x8b61,

        /// <summary>
        /// Original was GL_SAMPLER_2D_SHADOW = 0x8B62
        /// </summary>
        Sampler2DShadow = 0x8b62,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT = 0x8B63
        /// </summary>
        Sampler2DRect = 0x8b63,

        /// <summary>
        /// Original was GL_SAMPLER_2D_RECT_SHADOW = 0x8B64
        /// </summary>
        Sampler2DRectShadow = 0x8b64,

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
        /// Original was GL_SAMPLER_1D_ARRAY = 0x8DC0
        /// </summary>
        Sampler1DArray = 0x8dc0,

        /// <summary>
        /// Original was GL_SAMPLER_2D_ARRAY = 0x8DC1
        /// </summary>
        Sampler2DArray = 0x8dc1,

        /// <summary>
        /// Original was GL_SAMPLER_BUFFER = 0x8DC2
        /// </summary>
        SamplerBuffer = 0x8dc2,

        /// <summary>
        /// Original was GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3
        /// </summary>
        Sampler1DArrayShadow = 0x8dc3,

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
        /// Original was GL_INT_SAMPLER_1D = 0x8DC9
        /// </summary>
        IntSampler1D = 0x8dc9,

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
        /// Original was GL_INT_SAMPLER_2D_RECT = 0x8DCD
        /// </summary>
        IntSampler2DRect = 0x8dcd,

        /// <summary>
        /// Original was GL_INT_SAMPLER_1D_ARRAY = 0x8DCE
        /// </summary>
        IntSampler1DArray = 0x8dce,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_ARRAY = 0x8DCF
        /// </summary>
        IntSampler2DArray = 0x8dcf,

        /// <summary>
        /// Original was GL_INT_SAMPLER_BUFFER = 0x8DD0
        /// </summary>
        IntSamplerBuffer = 0x8dd0,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1
        /// </summary>
        UnsignedIntSampler1D = 0x8dd1,

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
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5
        /// </summary>
        UnsignedIntSampler2DRect = 0x8dd5,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6
        /// </summary>
        UnsignedIntSampler1DArray = 0x8dd6,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7
        /// </summary>
        UnsignedIntSampler2DArray = 0x8dd7,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8
        /// </summary>
        UnsignedIntSamplerBuffer = 0x8dd8,

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
        DoubleVec4 = 0x8ffe,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C
        /// </summary>
        SamplerCubeMapArray = 0x900c,

        /// <summary>
        /// Original was GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D
        /// </summary>
        SamplerCubeMapArrayShadow = 0x900d,

        /// <summary>
        /// Original was GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E
        /// </summary>
        IntSamplerCubeMapArray = 0x900e,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F
        /// </summary>
        UnsignedIntSamplerCubeMapArray = 0x900f,

        /// <summary>
        /// Original was GL_IMAGE_1D = 0x904C
        /// </summary>
        Image1D = 0x904c,

        /// <summary>
        /// Original was GL_IMAGE_2D = 0x904D
        /// </summary>
        Image2D = 0x904d,

        /// <summary>
        /// Original was GL_IMAGE_3D = 0x904E
        /// </summary>
        Image3D = 0x904e,

        /// <summary>
        /// Original was GL_IMAGE_2D_RECT = 0x904F
        /// </summary>
        Image2DRect = 0x904f,

        /// <summary>
        /// Original was GL_IMAGE_CUBE = 0x9050
        /// </summary>
        ImageCube = 0x9050,

        /// <summary>
        /// Original was GL_IMAGE_BUFFER = 0x9051
        /// </summary>
        ImageBuffer = 0x9051,

        /// <summary>
        /// Original was GL_IMAGE_1D_ARRAY = 0x9052
        /// </summary>
        Image1DArray = 0x9052,

        /// <summary>
        /// Original was GL_IMAGE_2D_ARRAY = 0x9053
        /// </summary>
        Image2DArray = 0x9053,

        /// <summary>
        /// Original was GL_IMAGE_CUBE_MAP_ARRAY = 0x9054
        /// </summary>
        ImageCubeMapArray = 0x9054,

        /// <summary>
        /// Original was GL_IMAGE_2D_MULTISAMPLE = 0x9055
        /// </summary>
        Image2DMultisample = 0x9055,

        /// <summary>
        /// Original was GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056
        /// </summary>
        Image2DMultisampleArray = 0x9056,

        /// <summary>
        /// Original was GL_INT_IMAGE_1D = 0x9057
        /// </summary>
        IntImage1D = 0x9057,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D = 0x9058
        /// </summary>
        IntImage2D = 0x9058,

        /// <summary>
        /// Original was GL_INT_IMAGE_3D = 0x9059
        /// </summary>
        IntImage3D = 0x9059,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_RECT = 0x905A
        /// </summary>
        IntImage2DRect = 0x905a,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE = 0x905B
        /// </summary>
        IntImageCube = 0x905b,

        /// <summary>
        /// Original was GL_INT_IMAGE_BUFFER = 0x905C
        /// </summary>
        IntImageBuffer = 0x905c,

        /// <summary>
        /// Original was GL_INT_IMAGE_1D_ARRAY = 0x905D
        /// </summary>
        IntImage1DArray = 0x905d,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_ARRAY = 0x905E
        /// </summary>
        IntImage2DArray = 0x905e,

        /// <summary>
        /// Original was GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F
        /// </summary>
        IntImageCubeMapArray = 0x905f,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060
        /// </summary>
        IntImage2DMultisample = 0x9060,

        /// <summary>
        /// Original was GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061
        /// </summary>
        IntImage2DMultisampleArray = 0x9061,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_1D = 0x9062
        /// </summary>
        UnsignedIntImage1D = 0x9062,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D = 0x9063
        /// </summary>
        UnsignedIntImage2D = 0x9063,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_3D = 0x9064
        /// </summary>
        UnsignedIntImage3D = 0x9064,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065
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
        /// Original was GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068
        /// </summary>
        UnsignedIntImage1DArray = 0x9068,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069
        /// </summary>
        UnsignedIntImage2DArray = 0x9069,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A
        /// </summary>
        UnsignedIntImageCubeMapArray = 0x906a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B
        /// </summary>
        UnsignedIntImage2DMultisample = 0x906b,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C
        /// </summary>
        UnsignedIntImage2DMultisampleArray = 0x906c,

        /// <summary>
        /// Original was GL_SAMPLER_2D_MULTISAMPLE = 0x9108
        /// </summary>
        Sampler2DMultisample = 0x9108,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109
        /// </summary>
        IntSampler2DMultisample = 0x9109,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A
        /// </summary>
        UnsignedIntSampler2DMultisample = 0x910a,

        /// <summary>
        /// Original was GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B
        /// </summary>
        Sampler2DMultisampleArray = 0x910b,

        /// <summary>
        /// Original was GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C
        /// </summary>
        IntSampler2DMultisampleArray = 0x910c,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D
        /// </summary>
        UnsignedIntSampler2DMultisampleArray = 0x910d,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        /// </summary>
        UnsignedIntAtomicCounter = 0x92db
    }
}
