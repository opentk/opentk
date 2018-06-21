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
    /// Used in GL.Ati.PassTexCoord, GL.Ati.SampleMap
    /// </summary>
    public enum AtiFragmentShader
    {
        /// <summary>
        /// Original was GL_2X_BIT_ATI = 0x00000001
        /// </summary>
        Gl2XBitAti = ((int)0x00000001),

        /// <summary>
        /// Original was GL_RED_BIT_ATI = 0x00000001
        /// </summary>
        RedBitAti = ((int)0x00000001),

        /// <summary>
        /// Original was GL_COMP_BIT_ATI = 0x00000002
        /// </summary>
        CompBitAti = ((int)0x00000002),

        /// <summary>
        /// Original was GL_4X_BIT_ATI = 0x00000002
        /// </summary>
        Gl4XBitAti = ((int)0x00000002),

        /// <summary>
        /// Original was GL_GREEN_BIT_ATI = 0x00000002
        /// </summary>
        GreenBitAti = ((int)0x00000002),

        /// <summary>
        /// Original was GL_BLUE_BIT_ATI = 0x00000004
        /// </summary>
        BlueBitAti = ((int)0x00000004),

        /// <summary>
        /// Original was GL_8X_BIT_ATI = 0x00000004
        /// </summary>
        Gl8XBitAti = ((int)0x00000004),

        /// <summary>
        /// Original was GL_NEGATE_BIT_ATI = 0x00000004
        /// </summary>
        NegateBitAti = ((int)0x00000004),

        /// <summary>
        /// Original was GL_BIAS_BIT_ATI = 0x00000008
        /// </summary>
        BiasBitAti = ((int)0x00000008),

        /// <summary>
        /// Original was GL_HALF_BIT_ATI = 0x00000008
        /// </summary>
        HalfBitAti = ((int)0x00000008),

        /// <summary>
        /// Original was GL_QUARTER_BIT_ATI = 0x00000010
        /// </summary>
        QuarterBitAti = ((int)0x00000010),

        /// <summary>
        /// Original was GL_EIGHTH_BIT_ATI = 0x00000020
        /// </summary>
        EighthBitAti = ((int)0x00000020),

        /// <summary>
        /// Original was GL_SATURATE_BIT_ATI = 0x00000040
        /// </summary>
        SaturateBitAti = ((int)0x00000040),

        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ATI = 0x8920
        /// </summary>
        FragmentShaderAti = 0x8920,

        /// <summary>
        /// Original was GL_REG_0_ATI = 0x8921
        /// </summary>
        Reg0Ati = 0x8921,

        /// <summary>
        /// Original was GL_REG_1_ATI = 0x8922
        /// </summary>
        Reg1Ati = 0x8922,

        /// <summary>
        /// Original was GL_REG_2_ATI = 0x8923
        /// </summary>
        Reg2Ati = 0x8923,

        /// <summary>
        /// Original was GL_REG_3_ATI = 0x8924
        /// </summary>
        Reg3Ati = 0x8924,

        /// <summary>
        /// Original was GL_REG_4_ATI = 0x8925
        /// </summary>
        Reg4Ati = 0x8925,

        /// <summary>
        /// Original was GL_REG_5_ATI = 0x8926
        /// </summary>
        Reg5Ati = 0x8926,

        /// <summary>
        /// Original was GL_REG_6_ATI = 0x8927
        /// </summary>
        Reg6Ati = 0x8927,

        /// <summary>
        /// Original was GL_REG_7_ATI = 0x8928
        /// </summary>
        Reg7Ati = 0x8928,

        /// <summary>
        /// Original was GL_REG_8_ATI = 0x8929
        /// </summary>
        Reg8Ati = 0x8929,

        /// <summary>
        /// Original was GL_REG_9_ATI = 0x892A
        /// </summary>
        Reg9Ati = 0x892a,

        /// <summary>
        /// Original was GL_REG_10_ATI = 0x892B
        /// </summary>
        Reg10Ati = 0x892b,

        /// <summary>
        /// Original was GL_REG_11_ATI = 0x892C
        /// </summary>
        Reg11Ati = 0x892c,

        /// <summary>
        /// Original was GL_REG_12_ATI = 0x892D
        /// </summary>
        Reg12Ati = 0x892d,

        /// <summary>
        /// Original was GL_REG_13_ATI = 0x892E
        /// </summary>
        Reg13Ati = 0x892e,

        /// <summary>
        /// Original was GL_REG_14_ATI = 0x892F
        /// </summary>
        Reg14Ati = 0x892f,

        /// <summary>
        /// Original was GL_REG_15_ATI = 0x8930
        /// </summary>
        Reg15Ati = 0x8930,

        /// <summary>
        /// Original was GL_REG_16_ATI = 0x8931
        /// </summary>
        Reg16Ati = 0x8931,

        /// <summary>
        /// Original was GL_REG_17_ATI = 0x8932
        /// </summary>
        Reg17Ati = 0x8932,

        /// <summary>
        /// Original was GL_REG_18_ATI = 0x8933
        /// </summary>
        Reg18Ati = 0x8933,

        /// <summary>
        /// Original was GL_REG_19_ATI = 0x8934
        /// </summary>
        Reg19Ati = 0x8934,

        /// <summary>
        /// Original was GL_REG_20_ATI = 0x8935
        /// </summary>
        Reg20Ati = 0x8935,

        /// <summary>
        /// Original was GL_REG_21_ATI = 0x8936
        /// </summary>
        Reg21Ati = 0x8936,

        /// <summary>
        /// Original was GL_REG_22_ATI = 0x8937
        /// </summary>
        Reg22Ati = 0x8937,

        /// <summary>
        /// Original was GL_REG_23_ATI = 0x8938
        /// </summary>
        Reg23Ati = 0x8938,

        /// <summary>
        /// Original was GL_REG_24_ATI = 0x8939
        /// </summary>
        Reg24Ati = 0x8939,

        /// <summary>
        /// Original was GL_REG_25_ATI = 0x893A
        /// </summary>
        Reg25Ati = 0x893a,

        /// <summary>
        /// Original was GL_REG_26_ATI = 0x893B
        /// </summary>
        Reg26Ati = 0x893b,

        /// <summary>
        /// Original was GL_REG_27_ATI = 0x893C
        /// </summary>
        Reg27Ati = 0x893c,

        /// <summary>
        /// Original was GL_REG_28_ATI = 0x893D
        /// </summary>
        Reg28Ati = 0x893d,

        /// <summary>
        /// Original was GL_REG_29_ATI = 0x893E
        /// </summary>
        Reg29Ati = 0x893e,

        /// <summary>
        /// Original was GL_REG_30_ATI = 0x893F
        /// </summary>
        Reg30Ati = 0x893f,

        /// <summary>
        /// Original was GL_REG_31_ATI = 0x8940
        /// </summary>
        Reg31Ati = 0x8940,

        /// <summary>
        /// Original was GL_CON_0_ATI = 0x8941
        /// </summary>
        Con0Ati = 0x8941,

        /// <summary>
        /// Original was GL_CON_1_ATI = 0x8942
        /// </summary>
        Con1Ati = 0x8942,

        /// <summary>
        /// Original was GL_CON_2_ATI = 0x8943
        /// </summary>
        Con2Ati = 0x8943,

        /// <summary>
        /// Original was GL_CON_3_ATI = 0x8944
        /// </summary>
        Con3Ati = 0x8944,

        /// <summary>
        /// Original was GL_CON_4_ATI = 0x8945
        /// </summary>
        Con4Ati = 0x8945,

        /// <summary>
        /// Original was GL_CON_5_ATI = 0x8946
        /// </summary>
        Con5Ati = 0x8946,

        /// <summary>
        /// Original was GL_CON_6_ATI = 0x8947
        /// </summary>
        Con6Ati = 0x8947,

        /// <summary>
        /// Original was GL_CON_7_ATI = 0x8948
        /// </summary>
        Con7Ati = 0x8948,

        /// <summary>
        /// Original was GL_CON_8_ATI = 0x8949
        /// </summary>
        Con8Ati = 0x8949,

        /// <summary>
        /// Original was GL_CON_9_ATI = 0x894A
        /// </summary>
        Con9Ati = 0x894a,

        /// <summary>
        /// Original was GL_CON_10_ATI = 0x894B
        /// </summary>
        Con10Ati = 0x894b,

        /// <summary>
        /// Original was GL_CON_11_ATI = 0x894C
        /// </summary>
        Con11Ati = 0x894c,

        /// <summary>
        /// Original was GL_CON_12_ATI = 0x894D
        /// </summary>
        Con12Ati = 0x894d,

        /// <summary>
        /// Original was GL_CON_13_ATI = 0x894E
        /// </summary>
        Con13Ati = 0x894e,

        /// <summary>
        /// Original was GL_CON_14_ATI = 0x894F
        /// </summary>
        Con14Ati = 0x894f,

        /// <summary>
        /// Original was GL_CON_15_ATI = 0x8950
        /// </summary>
        Con15Ati = 0x8950,

        /// <summary>
        /// Original was GL_CON_16_ATI = 0x8951
        /// </summary>
        Con16Ati = 0x8951,

        /// <summary>
        /// Original was GL_CON_17_ATI = 0x8952
        /// </summary>
        Con17Ati = 0x8952,

        /// <summary>
        /// Original was GL_CON_18_ATI = 0x8953
        /// </summary>
        Con18Ati = 0x8953,

        /// <summary>
        /// Original was GL_CON_19_ATI = 0x8954
        /// </summary>
        Con19Ati = 0x8954,

        /// <summary>
        /// Original was GL_CON_20_ATI = 0x8955
        /// </summary>
        Con20Ati = 0x8955,

        /// <summary>
        /// Original was GL_CON_21_ATI = 0x8956
        /// </summary>
        Con21Ati = 0x8956,

        /// <summary>
        /// Original was GL_CON_22_ATI = 0x8957
        /// </summary>
        Con22Ati = 0x8957,

        /// <summary>
        /// Original was GL_CON_23_ATI = 0x8958
        /// </summary>
        Con23Ati = 0x8958,

        /// <summary>
        /// Original was GL_CON_24_ATI = 0x8959
        /// </summary>
        Con24Ati = 0x8959,

        /// <summary>
        /// Original was GL_CON_25_ATI = 0x895A
        /// </summary>
        Con25Ati = 0x895a,

        /// <summary>
        /// Original was GL_CON_26_ATI = 0x895B
        /// </summary>
        Con26Ati = 0x895b,

        /// <summary>
        /// Original was GL_CON_27_ATI = 0x895C
        /// </summary>
        Con27Ati = 0x895c,

        /// <summary>
        /// Original was GL_CON_28_ATI = 0x895D
        /// </summary>
        Con28Ati = 0x895d,

        /// <summary>
        /// Original was GL_CON_29_ATI = 0x895E
        /// </summary>
        Con29Ati = 0x895e,

        /// <summary>
        /// Original was GL_CON_30_ATI = 0x895F
        /// </summary>
        Con30Ati = 0x895f,

        /// <summary>
        /// Original was GL_CON_31_ATI = 0x8960
        /// </summary>
        Con31Ati = 0x8960,

        /// <summary>
        /// Original was GL_MOV_ATI = 0x8961
        /// </summary>
        MovAti = 0x8961,

        /// <summary>
        /// Original was GL_ADD_ATI = 0x8963
        /// </summary>
        AddAti = 0x8963,

        /// <summary>
        /// Original was GL_MUL_ATI = 0x8964
        /// </summary>
        MulAti = 0x8964,

        /// <summary>
        /// Original was GL_SUB_ATI = 0x8965
        /// </summary>
        SubAti = 0x8965,

        /// <summary>
        /// Original was GL_DOT3_ATI = 0x8966
        /// </summary>
        Dot3Ati = 0x8966,

        /// <summary>
        /// Original was GL_DOT4_ATI = 0x8967
        /// </summary>
        Dot4Ati = 0x8967,

        /// <summary>
        /// Original was GL_MAD_ATI = 0x8968
        /// </summary>
        MadAti = 0x8968,

        /// <summary>
        /// Original was GL_LERP_ATI = 0x8969
        /// </summary>
        LerpAti = 0x8969,

        /// <summary>
        /// Original was GL_CND_ATI = 0x896A
        /// </summary>
        CndAti = 0x896a,

        /// <summary>
        /// Original was GL_CND0_ATI = 0x896B
        /// </summary>
        Cnd0Ati = 0x896b,

        /// <summary>
        /// Original was GL_DOT2_ADD_ATI = 0x896C
        /// </summary>
        Dot2AddAti = 0x896c,

        /// <summary>
        /// Original was GL_SECONDARY_INTERPOLATOR_ATI = 0x896D
        /// </summary>
        SecondaryInterpolatorAti = 0x896d,

        /// <summary>
        /// Original was GL_NUM_FRAGMENT_REGISTERS_ATI = 0x896E
        /// </summary>
        NumFragmentRegistersAti = 0x896e,

        /// <summary>
        /// Original was GL_NUM_FRAGMENT_CONSTANTS_ATI = 0x896F
        /// </summary>
        NumFragmentConstantsAti = 0x896f,

        /// <summary>
        /// Original was GL_NUM_PASSES_ATI = 0x8970
        /// </summary>
        NumPassesAti = 0x8970,

        /// <summary>
        /// Original was GL_NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971
        /// </summary>
        NumInstructionsPerPassAti = 0x8971,

        /// <summary>
        /// Original was GL_NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972
        /// </summary>
        NumInstructionsTotalAti = 0x8972,

        /// <summary>
        /// Original was GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973
        /// </summary>
        NumInputInterpolatorComponentsAti = 0x8973,

        /// <summary>
        /// Original was GL_NUM_LOOPBACK_COMPONENTS_ATI = 0x8974
        /// </summary>
        NumLoopbackComponentsAti = 0x8974,

        /// <summary>
        /// Original was GL_COLOR_ALPHA_PAIRING_ATI = 0x8975
        /// </summary>
        ColorAlphaPairingAti = 0x8975,

        /// <summary>
        /// Original was GL_SWIZZLE_STR_ATI = 0x8976
        /// </summary>
        SwizzleStrAti = 0x8976,

        /// <summary>
        /// Original was GL_SWIZZLE_STQ_ATI = 0x8977
        /// </summary>
        SwizzleStqAti = 0x8977,

        /// <summary>
        /// Original was GL_SWIZZLE_STR_DR_ATI = 0x8978
        /// </summary>
        SwizzleStrDrAti = 0x8978,

        /// <summary>
        /// Original was GL_SWIZZLE_STQ_DQ_ATI = 0x8979
        /// </summary>
        SwizzleStqDqAti = 0x8979,

        /// <summary>
        /// Original was GL_SWIZZLE_STRQ_ATI = 0x897A
        /// </summary>
        SwizzleStrqAti = 0x897a,

        /// <summary>
        /// Original was GL_SWIZZLE_STRQ_DQ_ATI = 0x897B
        /// </summary>
        SwizzleStrqDqAti = 0x897b
    }
}
