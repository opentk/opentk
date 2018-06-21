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
    /// Used in GL.NV.CombinerInput, GL.NV.CombinerOutput and 5 other functions
    /// </summary>
    public enum NvRegisterCombiners
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = 0x0b60,

        /// <summary>
        /// Original was GL_TEXTURE0_ARB = 0x84C0
        /// </summary>
        Texture0Arb = 0x84c0,

        /// <summary>
        /// Original was GL_TEXTURE1_ARB = 0x84C1
        /// </summary>
        Texture1Arb = 0x84c1,

        /// <summary>
        /// Original was GL_REGISTER_COMBINERS_NV = 0x8522
        /// </summary>
        RegisterCombinersNv = 0x8522,

        /// <summary>
        /// Original was GL_VARIABLE_A_NV = 0x8523
        /// </summary>
        VariableANv = 0x8523,

        /// <summary>
        /// Original was GL_VARIABLE_B_NV = 0x8524
        /// </summary>
        VariableBNv = 0x8524,

        /// <summary>
        /// Original was GL_VARIABLE_C_NV = 0x8525
        /// </summary>
        VariableCNv = 0x8525,

        /// <summary>
        /// Original was GL_VARIABLE_D_NV = 0x8526
        /// </summary>
        VariableDNv = 0x8526,

        /// <summary>
        /// Original was GL_VARIABLE_E_NV = 0x8527
        /// </summary>
        VariableENv = 0x8527,

        /// <summary>
        /// Original was GL_VARIABLE_F_NV = 0x8528
        /// </summary>
        VariableFNv = 0x8528,

        /// <summary>
        /// Original was GL_VARIABLE_G_NV = 0x8529
        /// </summary>
        VariableGNv = 0x8529,

        /// <summary>
        /// Original was GL_CONSTANT_COLOR0_NV = 0x852A
        /// </summary>
        ConstantColor0Nv = 0x852a,

        /// <summary>
        /// Original was GL_CONSTANT_COLOR1_NV = 0x852B
        /// </summary>
        ConstantColor1Nv = 0x852b,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNv = 0x852c,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNv = 0x852d,

        /// <summary>
        /// Original was GL_SPARE0_NV = 0x852E
        /// </summary>
        Spare0Nv = 0x852e,

        /// <summary>
        /// Original was GL_SPARE1_NV = 0x852F
        /// </summary>
        Spare1Nv = 0x852f,

        /// <summary>
        /// Original was GL_DISCARD_NV = 0x8530
        /// </summary>
        DiscardNv = 0x8530,

        /// <summary>
        /// Original was GL_E_TIMES_F_NV = 0x8531
        /// </summary>
        ETimesFNv = 0x8531,

        /// <summary>
        /// Original was GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532
        /// </summary>
        Spare0PlusSecondaryColorNv = 0x8532,

        /// <summary>
        /// Original was GL_UNSIGNED_IDENTITY_NV = 0x8536
        /// </summary>
        UnsignedIdentityNv = 0x8536,

        /// <summary>
        /// Original was GL_UNSIGNED_INVERT_NV = 0x8537
        /// </summary>
        UnsignedInvertNv = 0x8537,

        /// <summary>
        /// Original was GL_EXPAND_NORMAL_NV = 0x8538
        /// </summary>
        ExpandNormalNv = 0x8538,

        /// <summary>
        /// Original was GL_EXPAND_NEGATE_NV = 0x8539
        /// </summary>
        ExpandNegateNv = 0x8539,

        /// <summary>
        /// Original was GL_HALF_BIAS_NORMAL_NV = 0x853A
        /// </summary>
        HalfBiasNormalNv = 0x853a,

        /// <summary>
        /// Original was GL_HALF_BIAS_NEGATE_NV = 0x853B
        /// </summary>
        HalfBiasNegateNv = 0x853b,

        /// <summary>
        /// Original was GL_SIGNED_IDENTITY_NV = 0x853C
        /// </summary>
        SignedIdentityNv = 0x853c,

        /// <summary>
        /// Original was GL_SIGNED_NEGATE_NV = 0x853D
        /// </summary>
        SignedNegateNv = 0x853d,

        /// <summary>
        /// Original was GL_SCALE_BY_TWO_NV = 0x853E
        /// </summary>
        ScaleByTwoNv = 0x853e,

        /// <summary>
        /// Original was GL_SCALE_BY_FOUR_NV = 0x853F
        /// </summary>
        ScaleByFourNv = 0x853f,

        /// <summary>
        /// Original was GL_SCALE_BY_ONE_HALF_NV = 0x8540
        /// </summary>
        ScaleByOneHalfNv = 0x8540,

        /// <summary>
        /// Original was GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541
        /// </summary>
        BiasByNegativeOneHalfNv = 0x8541,

        /// <summary>
        /// Original was GL_COMBINER_INPUT_NV = 0x8542
        /// </summary>
        CombinerInputNv = 0x8542,

        /// <summary>
        /// Original was GL_COMBINER_MAPPING_NV = 0x8543
        /// </summary>
        CombinerMappingNv = 0x8543,

        /// <summary>
        /// Original was GL_COMBINER_COMPONENT_USAGE_NV = 0x8544
        /// </summary>
        CombinerComponentUsageNv = 0x8544,

        /// <summary>
        /// Original was GL_COMBINER_AB_DOT_PRODUCT_NV = 0x8545
        /// </summary>
        CombinerAbDotProductNv = 0x8545,

        /// <summary>
        /// Original was GL_COMBINER_CD_DOT_PRODUCT_NV = 0x8546
        /// </summary>
        CombinerCdDotProductNv = 0x8546,

        /// <summary>
        /// Original was GL_COMBINER_MUX_SUM_NV = 0x8547
        /// </summary>
        CombinerMuxSumNv = 0x8547,

        /// <summary>
        /// Original was GL_COMBINER_SCALE_NV = 0x8548
        /// </summary>
        CombinerScaleNv = 0x8548,

        /// <summary>
        /// Original was GL_COMBINER_BIAS_NV = 0x8549
        /// </summary>
        CombinerBiasNv = 0x8549,

        /// <summary>
        /// Original was GL_COMBINER_AB_OUTPUT_NV = 0x854A
        /// </summary>
        CombinerAbOutputNv = 0x854a,

        /// <summary>
        /// Original was GL_COMBINER_CD_OUTPUT_NV = 0x854B
        /// </summary>
        CombinerCdOutputNv = 0x854b,

        /// <summary>
        /// Original was GL_COMBINER_SUM_OUTPUT_NV = 0x854C
        /// </summary>
        CombinerSumOutputNv = 0x854c,

        /// <summary>
        /// Original was GL_MAX_GENERAL_COMBINERS_NV = 0x854D
        /// </summary>
        MaxGeneralCombinersNv = 0x854d,

        /// <summary>
        /// Original was GL_NUM_GENERAL_COMBINERS_NV = 0x854E
        /// </summary>
        NumGeneralCombinersNv = 0x854e,

        /// <summary>
        /// Original was GL_COLOR_SUM_CLAMP_NV = 0x854F
        /// </summary>
        ColorSumClampNv = 0x854f,

        /// <summary>
        /// Original was GL_COMBINER0_NV = 0x8550
        /// </summary>
        Combiner0Nv = 0x8550,

        /// <summary>
        /// Original was GL_COMBINER1_NV = 0x8551
        /// </summary>
        Combiner1Nv = 0x8551,

        /// <summary>
        /// Original was GL_COMBINER2_NV = 0x8552
        /// </summary>
        Combiner2Nv = 0x8552,

        /// <summary>
        /// Original was GL_COMBINER3_NV = 0x8553
        /// </summary>
        Combiner3Nv = 0x8553,

        /// <summary>
        /// Original was GL_COMBINER4_NV = 0x8554
        /// </summary>
        Combiner4Nv = 0x8554,

        /// <summary>
        /// Original was GL_COMBINER5_NV = 0x8555
        /// </summary>
        Combiner5Nv = 0x8555,

        /// <summary>
        /// Original was GL_COMBINER6_NV = 0x8556
        /// </summary>
        Combiner6Nv = 0x8556,

        /// <summary>
        /// Original was GL_COMBINER7_NV = 0x8557
        /// </summary>
        Combiner7Nv = 0x8557
    }
}
