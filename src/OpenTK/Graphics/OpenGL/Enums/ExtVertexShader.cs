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
    /// Used in GL.Ext.BindParameter, GL.Ext.BindTextureUnitParameter and 20 other functions
    /// </summary>
    public enum ExtVertexShader
    {
        /// <summary>
        /// Original was GL_VERTEX_SHADER_EXT = 0x8780
        /// </summary>
        VertexShaderExt = 0x8780,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_BINDING_EXT = 0x8781
        /// </summary>
        VertexShaderBindingExt = 0x8781,

        /// <summary>
        /// Original was GL_OP_INDEX_EXT = 0x8782
        /// </summary>
        OpIndexExt = 0x8782,

        /// <summary>
        /// Original was GL_OP_NEGATE_EXT = 0x8783
        /// </summary>
        OpNegateExt = 0x8783,

        /// <summary>
        /// Original was GL_OP_DOT3_EXT = 0x8784
        /// </summary>
        OpDot3Ext = 0x8784,

        /// <summary>
        /// Original was GL_OP_DOT4_EXT = 0x8785
        /// </summary>
        OpDot4Ext = 0x8785,

        /// <summary>
        /// Original was GL_OP_MUL_EXT = 0x8786
        /// </summary>
        OpMulExt = 0x8786,

        /// <summary>
        /// Original was GL_OP_ADD_EXT = 0x8787
        /// </summary>
        OpAddExt = 0x8787,

        /// <summary>
        /// Original was GL_OP_MADD_EXT = 0x8788
        /// </summary>
        OpMaddExt = 0x8788,

        /// <summary>
        /// Original was GL_OP_FRAC_EXT = 0x8789
        /// </summary>
        OpFracExt = 0x8789,

        /// <summary>
        /// Original was GL_OP_MAX_EXT = 0x878A
        /// </summary>
        OpMaxExt = 0x878a,

        /// <summary>
        /// Original was GL_OP_MIN_EXT = 0x878B
        /// </summary>
        OpMinExt = 0x878b,

        /// <summary>
        /// Original was GL_OP_SET_GE_EXT = 0x878C
        /// </summary>
        OpSetGeExt = 0x878c,

        /// <summary>
        /// Original was GL_OP_SET_LT_EXT = 0x878D
        /// </summary>
        OpSetLtExt = 0x878d,

        /// <summary>
        /// Original was GL_OP_CLAMP_EXT = 0x878E
        /// </summary>
        OpClampExt = 0x878e,

        /// <summary>
        /// Original was GL_OP_FLOOR_EXT = 0x878F
        /// </summary>
        OpFloorExt = 0x878f,

        /// <summary>
        /// Original was GL_OP_ROUND_EXT = 0x8790
        /// </summary>
        OpRoundExt = 0x8790,

        /// <summary>
        /// Original was GL_OP_EXP_BASE_2_EXT = 0x8791
        /// </summary>
        OpExpBase2Ext = 0x8791,

        /// <summary>
        /// Original was GL_OP_LOG_BASE_2_EXT = 0x8792
        /// </summary>
        OpLogBase2Ext = 0x8792,

        /// <summary>
        /// Original was GL_OP_POWER_EXT = 0x8793
        /// </summary>
        OpPowerExt = 0x8793,

        /// <summary>
        /// Original was GL_OP_RECIP_EXT = 0x8794
        /// </summary>
        OpRecipExt = 0x8794,

        /// <summary>
        /// Original was GL_OP_RECIP_SQRT_EXT = 0x8795
        /// </summary>
        OpRecipSqrtExt = 0x8795,

        /// <summary>
        /// Original was GL_OP_SUB_EXT = 0x8796
        /// </summary>
        OpSubExt = 0x8796,

        /// <summary>
        /// Original was GL_OP_CROSS_PRODUCT_EXT = 0x8797
        /// </summary>
        OpCrossProductExt = 0x8797,

        /// <summary>
        /// Original was GL_OP_MULTIPLY_MATRIX_EXT = 0x8798
        /// </summary>
        OpMultiplyMatrixExt = 0x8798,

        /// <summary>
        /// Original was GL_OP_MOV_EXT = 0x8799
        /// </summary>
        OpMovExt = 0x8799,

        /// <summary>
        /// Original was GL_OUTPUT_VERTEX_EXT = 0x879A
        /// </summary>
        OutputVertexExt = 0x879a,

        /// <summary>
        /// Original was GL_OUTPUT_COLOR0_EXT = 0x879B
        /// </summary>
        OutputColor0Ext = 0x879b,

        /// <summary>
        /// Original was GL_OUTPUT_COLOR1_EXT = 0x879C
        /// </summary>
        OutputColor1Ext = 0x879c,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD0_EXT = 0x879D
        /// </summary>
        OutputTextureCoord0Ext = 0x879d,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD1_EXT = 0x879E
        /// </summary>
        OutputTextureCoord1Ext = 0x879e,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD2_EXT = 0x879F
        /// </summary>
        OutputTextureCoord2Ext = 0x879f,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD3_EXT = 0x87A0
        /// </summary>
        OutputTextureCoord3Ext = 0x87a0,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD4_EXT = 0x87A1
        /// </summary>
        OutputTextureCoord4Ext = 0x87a1,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD5_EXT = 0x87A2
        /// </summary>
        OutputTextureCoord5Ext = 0x87a2,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD6_EXT = 0x87A3
        /// </summary>
        OutputTextureCoord6Ext = 0x87a3,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD7_EXT = 0x87A4
        /// </summary>
        OutputTextureCoord7Ext = 0x87a4,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD8_EXT = 0x87A5
        /// </summary>
        OutputTextureCoord8Ext = 0x87a5,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD9_EXT = 0x87A6
        /// </summary>
        OutputTextureCoord9Ext = 0x87a6,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD10_EXT = 0x87A7
        /// </summary>
        OutputTextureCoord10Ext = 0x87a7,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD11_EXT = 0x87A8
        /// </summary>
        OutputTextureCoord11Ext = 0x87a8,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD12_EXT = 0x87A9
        /// </summary>
        OutputTextureCoord12Ext = 0x87a9,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD13_EXT = 0x87AA
        /// </summary>
        OutputTextureCoord13Ext = 0x87aa,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD14_EXT = 0x87AB
        /// </summary>
        OutputTextureCoord14Ext = 0x87ab,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD15_EXT = 0x87AC
        /// </summary>
        OutputTextureCoord15Ext = 0x87ac,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD16_EXT = 0x87AD
        /// </summary>
        OutputTextureCoord16Ext = 0x87ad,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD17_EXT = 0x87AE
        /// </summary>
        OutputTextureCoord17Ext = 0x87ae,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD18_EXT = 0x87AF
        /// </summary>
        OutputTextureCoord18Ext = 0x87af,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD19_EXT = 0x87B0
        /// </summary>
        OutputTextureCoord19Ext = 0x87b0,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD20_EXT = 0x87B1
        /// </summary>
        OutputTextureCoord20Ext = 0x87b1,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD21_EXT = 0x87B2
        /// </summary>
        OutputTextureCoord21Ext = 0x87b2,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD22_EXT = 0x87B3
        /// </summary>
        OutputTextureCoord22Ext = 0x87b3,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD23_EXT = 0x87B4
        /// </summary>
        OutputTextureCoord23Ext = 0x87b4,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD24_EXT = 0x87B5
        /// </summary>
        OutputTextureCoord24Ext = 0x87b5,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD25_EXT = 0x87B6
        /// </summary>
        OutputTextureCoord25Ext = 0x87b6,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD26_EXT = 0x87B7
        /// </summary>
        OutputTextureCoord26Ext = 0x87b7,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD27_EXT = 0x87B8
        /// </summary>
        OutputTextureCoord27Ext = 0x87b8,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD28_EXT = 0x87B9
        /// </summary>
        OutputTextureCoord28Ext = 0x87b9,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD29_EXT = 0x87BA
        /// </summary>
        OutputTextureCoord29Ext = 0x87ba,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD30_EXT = 0x87BB
        /// </summary>
        OutputTextureCoord30Ext = 0x87bb,

        /// <summary>
        /// Original was GL_OUTPUT_TEXTURE_COORD31_EXT = 0x87BC
        /// </summary>
        OutputTextureCoord31Ext = 0x87bc,

        /// <summary>
        /// Original was GL_OUTPUT_FOG_EXT = 0x87BD
        /// </summary>
        OutputFogExt = 0x87bd,

        /// <summary>
        /// Original was GL_SCALAR_EXT = 0x87BE
        /// </summary>
        ScalarExt = 0x87be,

        /// <summary>
        /// Original was GL_VECTOR_EXT = 0x87BF
        /// </summary>
        VectorExt = 0x87bf,

        /// <summary>
        /// Original was GL_MATRIX_EXT = 0x87C0
        /// </summary>
        MatrixExt = 0x87c0,

        /// <summary>
        /// Original was GL_VARIANT_EXT = 0x87C1
        /// </summary>
        VariantExt = 0x87c1,

        /// <summary>
        /// Original was GL_INVARIANT_EXT = 0x87C2
        /// </summary>
        InvariantExt = 0x87c2,

        /// <summary>
        /// Original was GL_LOCAL_CONSTANT_EXT = 0x87C3
        /// </summary>
        LocalConstantExt = 0x87c3,

        /// <summary>
        /// Original was GL_LOCAL_EXT = 0x87C4
        /// </summary>
        LocalExt = 0x87c4,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5
        /// </summary>
        MaxVertexShaderInstructionsExt = 0x87c5,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6
        /// </summary>
        MaxVertexShaderVariantsExt = 0x87c6,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7
        /// </summary>
        MaxVertexShaderInvariantsExt = 0x87c7,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8
        /// </summary>
        MaxVertexShaderLocalConstantsExt = 0x87c8,

        /// <summary>
        /// Original was GL_MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9
        /// </summary>
        MaxVertexShaderLocalsExt = 0x87c9,

        /// <summary>
        /// Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA
        /// </summary>
        MaxOptimizedVertexShaderInstructionsExt = 0x87ca,

        /// <summary>
        /// Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB
        /// </summary>
        MaxOptimizedVertexShaderVariantsExt = 0x87cb,

        /// <summary>
        /// Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC
        /// </summary>
        MaxOptimizedVertexShaderLocalConstantsExt = 0x87cc,

        /// <summary>
        /// Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD
        /// </summary>
        MaxOptimizedVertexShaderInvariantsExt = 0x87cd,

        /// <summary>
        /// Original was GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE
        /// </summary>
        MaxOptimizedVertexShaderLocalsExt = 0x87ce,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF
        /// </summary>
        VertexShaderInstructionsExt = 0x87cf,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_VARIANTS_EXT = 0x87D0
        /// </summary>
        VertexShaderVariantsExt = 0x87d0,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_INVARIANTS_EXT = 0x87D1
        /// </summary>
        VertexShaderInvariantsExt = 0x87d1,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2
        /// </summary>
        VertexShaderLocalConstantsExt = 0x87d2,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_LOCALS_EXT = 0x87D3
        /// </summary>
        VertexShaderLocalsExt = 0x87d3,

        /// <summary>
        /// Original was GL_VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4
        /// </summary>
        VertexShaderOptimizedExt = 0x87d4,

        /// <summary>
        /// Original was GL_X_EXT = 0x87D5
        /// </summary>
        XExt = 0x87d5,

        /// <summary>
        /// Original was GL_Y_EXT = 0x87D6
        /// </summary>
        YExt = 0x87d6,

        /// <summary>
        /// Original was GL_Z_EXT = 0x87D7
        /// </summary>
        ZExt = 0x87d7,

        /// <summary>
        /// Original was GL_W_EXT = 0x87D8
        /// </summary>
        WExt = 0x87d8,

        /// <summary>
        /// Original was GL_NEGATIVE_X_EXT = 0x87D9
        /// </summary>
        NegativeXExt = 0x87d9,

        /// <summary>
        /// Original was GL_NEGATIVE_Y_EXT = 0x87DA
        /// </summary>
        NegativeYExt = 0x87da,

        /// <summary>
        /// Original was GL_NEGATIVE_Z_EXT = 0x87DB
        /// </summary>
        NegativeZExt = 0x87db,

        /// <summary>
        /// Original was GL_NEGATIVE_W_EXT = 0x87DC
        /// </summary>
        NegativeWExt = 0x87dc,

        /// <summary>
        /// Original was GL_ZERO_EXT = 0x87DD
        /// </summary>
        ZeroExt = 0x87dd,

        /// <summary>
        /// Original was GL_ONE_EXT = 0x87DE
        /// </summary>
        OneExt = 0x87de,

        /// <summary>
        /// Original was GL_NEGATIVE_ONE_EXT = 0x87DF
        /// </summary>
        NegativeOneExt = 0x87df,

        /// <summary>
        /// Original was GL_NORMALIZED_RANGE_EXT = 0x87E0
        /// </summary>
        NormalizedRangeExt = 0x87e0,

        /// <summary>
        /// Original was GL_FULL_RANGE_EXT = 0x87E1
        /// </summary>
        FullRangeExt = 0x87e1,

        /// <summary>
        /// Original was GL_CURRENT_VERTEX_EXT = 0x87E2
        /// </summary>
        CurrentVertexExt = 0x87e2,

        /// <summary>
        /// Original was GL_MVP_MATRIX_EXT = 0x87E3
        /// </summary>
        MvpMatrixExt = 0x87e3,

        /// <summary>
        /// Original was GL_VARIANT_VALUE_EXT = 0x87E4
        /// </summary>
        VariantValueExt = 0x87e4,

        /// <summary>
        /// Original was GL_VARIANT_DATATYPE_EXT = 0x87E5
        /// </summary>
        VariantDatatypeExt = 0x87e5,

        /// <summary>
        /// Original was GL_VARIANT_ARRAY_STRIDE_EXT = 0x87E6
        /// </summary>
        VariantArrayStrideExt = 0x87e6,

        /// <summary>
        /// Original was GL_VARIANT_ARRAY_TYPE_EXT = 0x87E7
        /// </summary>
        VariantArrayTypeExt = 0x87e7,

        /// <summary>
        /// Original was GL_VARIANT_ARRAY_EXT = 0x87E8
        /// </summary>
        VariantArrayExt = 0x87e8,

        /// <summary>
        /// Original was GL_VARIANT_ARRAY_POINTER_EXT = 0x87E9
        /// </summary>
        VariantArrayPointerExt = 0x87e9,

        /// <summary>
        /// Original was GL_INVARIANT_VALUE_EXT = 0x87EA
        /// </summary>
        InvariantValueExt = 0x87ea,

        /// <summary>
        /// Original was GL_INVARIANT_DATATYPE_EXT = 0x87EB
        /// </summary>
        InvariantDatatypeExt = 0x87eb,

        /// <summary>
        /// Original was GL_LOCAL_CONSTANT_VALUE_EXT = 0x87EC
        /// </summary>
        LocalConstantValueExt = 0x87ec,

        /// <summary>
        /// Original was GL_LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED
        /// </summary>
        LocalConstantDatatypeExt = 0x87ed
    }
}
