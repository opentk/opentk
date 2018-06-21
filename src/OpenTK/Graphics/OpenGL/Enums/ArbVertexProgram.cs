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
    /// Not used directly.
    /// </summary>
    public enum ArbVertexProgram
    {
        /// <summary>
        /// Original was GL_COLOR_SUM_ARB = 0x8458
        /// </summary>
        ColorSumArb = 0x8458,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_ARB = 0x8620
        /// </summary>
        VertexProgramArb = 0x8620,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622
        /// </summary>
        VertexAttribArrayEnabledArb = 0x8622,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623
        /// </summary>
        VertexAttribArraySizeArb = 0x8623,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624
        /// </summary>
        VertexAttribArrayStrideArb = 0x8624,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625
        /// </summary>
        VertexAttribArrayTypeArb = 0x8625,

        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626
        /// </summary>
        CurrentVertexAttribArb = 0x8626,

        /// <summary>
        /// Original was GL_PROGRAM_LENGTH_ARB = 0x8627
        /// </summary>
        ProgramLengthArb = 0x8627,

        /// <summary>
        /// Original was GL_PROGRAM_STRING_ARB = 0x8628
        /// </summary>
        ProgramStringArb = 0x8628,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E
        /// </summary>
        MaxProgramMatrixStackDepthArb = 0x862e,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_MATRICES_ARB = 0x862F
        /// </summary>
        MaxProgramMatricesArb = 0x862f,

        /// <summary>
        /// Original was GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640
        /// </summary>
        CurrentMatrixStackDepthArb = 0x8640,

        /// <summary>
        /// Original was GL_CURRENT_MATRIX_ARB = 0x8641
        /// </summary>
        CurrentMatrixArb = 0x8641,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642
        /// </summary>
        VertexProgramPointSizeArb = 0x8642,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643
        /// </summary>
        VertexProgramTwoSideArb = 0x8643,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645
        /// </summary>
        VertexAttribArrayPointerArb = 0x8645,

        /// <summary>
        /// Original was GL_PROGRAM_ERROR_POSITION_ARB = 0x864B
        /// </summary>
        ProgramErrorPositionArb = 0x864b,

        /// <summary>
        /// Original was GL_PROGRAM_BINDING_ARB = 0x8677
        /// </summary>
        ProgramBindingArb = 0x8677,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869
        /// </summary>
        MaxVertexAttribsArb = 0x8869,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A
        /// </summary>
        VertexAttribArrayNormalizedArb = 0x886a,

        /// <summary>
        /// Original was GL_PROGRAM_ERROR_STRING_ARB = 0x8874
        /// </summary>
        ProgramErrorStringArb = 0x8874,

        /// <summary>
        /// Original was GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875
        /// </summary>
        ProgramFormatAsciiArb = 0x8875,

        /// <summary>
        /// Original was GL_PROGRAM_FORMAT_ARB = 0x8876
        /// </summary>
        ProgramFormatArb = 0x8876,

        /// <summary>
        /// Original was GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0
        /// </summary>
        ProgramInstructionsArb = 0x88a0,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1
        /// </summary>
        MaxProgramInstructionsArb = 0x88a1,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2
        /// </summary>
        ProgramNativeInstructionsArb = 0x88a2,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3
        /// </summary>
        MaxProgramNativeInstructionsArb = 0x88a3,

        /// <summary>
        /// Original was GL_PROGRAM_TEMPORARIES_ARB = 0x88A4
        /// </summary>
        ProgramTemporariesArb = 0x88a4,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5
        /// </summary>
        MaxProgramTemporariesArb = 0x88a5,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6
        /// </summary>
        ProgramNativeTemporariesArb = 0x88a6,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7
        /// </summary>
        MaxProgramNativeTemporariesArb = 0x88a7,

        /// <summary>
        /// Original was GL_PROGRAM_PARAMETERS_ARB = 0x88A8
        /// </summary>
        ProgramParametersArb = 0x88a8,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9
        /// </summary>
        MaxProgramParametersArb = 0x88a9,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA
        /// </summary>
        ProgramNativeParametersArb = 0x88aa,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB
        /// </summary>
        MaxProgramNativeParametersArb = 0x88ab,

        /// <summary>
        /// Original was GL_PROGRAM_ATTRIBS_ARB = 0x88AC
        /// </summary>
        ProgramAttribsArb = 0x88ac,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD
        /// </summary>
        MaxProgramAttribsArb = 0x88ad,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE
        /// </summary>
        ProgramNativeAttribsArb = 0x88ae,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF
        /// </summary>
        MaxProgramNativeAttribsArb = 0x88af,

        /// <summary>
        /// Original was GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0
        /// </summary>
        ProgramAddressRegistersArb = 0x88b0,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1
        /// </summary>
        MaxProgramAddressRegistersArb = 0x88b1,

        /// <summary>
        /// Original was GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2
        /// </summary>
        ProgramNativeAddressRegistersArb = 0x88b2,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3
        /// </summary>
        MaxProgramNativeAddressRegistersArb = 0x88b3,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4
        /// </summary>
        MaxProgramLocalParametersArb = 0x88b4,

        /// <summary>
        /// Original was GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5
        /// </summary>
        MaxProgramEnvParametersArb = 0x88b5,

        /// <summary>
        /// Original was GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6
        /// </summary>
        ProgramUnderNativeLimitsArb = 0x88b6,

        /// <summary>
        /// Original was GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7
        /// </summary>
        TransposeCurrentMatrixArb = 0x88b7,

        /// <summary>
        /// Original was GL_MATRIX0_ARB = 0x88C0
        /// </summary>
        Matrix0Arb = 0x88c0,

        /// <summary>
        /// Original was GL_MATRIX1_ARB = 0x88C1
        /// </summary>
        Matrix1Arb = 0x88c1,

        /// <summary>
        /// Original was GL_MATRIX2_ARB = 0x88C2
        /// </summary>
        Matrix2Arb = 0x88c2,

        /// <summary>
        /// Original was GL_MATRIX3_ARB = 0x88C3
        /// </summary>
        Matrix3Arb = 0x88c3,

        /// <summary>
        /// Original was GL_MATRIX4_ARB = 0x88C4
        /// </summary>
        Matrix4Arb = 0x88c4,

        /// <summary>
        /// Original was GL_MATRIX5_ARB = 0x88C5
        /// </summary>
        Matrix5Arb = 0x88c5,

        /// <summary>
        /// Original was GL_MATRIX6_ARB = 0x88C6
        /// </summary>
        Matrix6Arb = 0x88c6,

        /// <summary>
        /// Original was GL_MATRIX7_ARB = 0x88C7
        /// </summary>
        Matrix7Arb = 0x88c7,

        /// <summary>
        /// Original was GL_MATRIX8_ARB = 0x88C8
        /// </summary>
        Matrix8Arb = 0x88c8,

        /// <summary>
        /// Original was GL_MATRIX9_ARB = 0x88C9
        /// </summary>
        Matrix9Arb = 0x88c9,

        /// <summary>
        /// Original was GL_MATRIX10_ARB = 0x88CA
        /// </summary>
        Matrix10Arb = 0x88ca,

        /// <summary>
        /// Original was GL_MATRIX11_ARB = 0x88CB
        /// </summary>
        Matrix11Arb = 0x88cb,

        /// <summary>
        /// Original was GL_MATRIX12_ARB = 0x88CC
        /// </summary>
        Matrix12Arb = 0x88cc,

        /// <summary>
        /// Original was GL_MATRIX13_ARB = 0x88CD
        /// </summary>
        Matrix13Arb = 0x88cd,

        /// <summary>
        /// Original was GL_MATRIX14_ARB = 0x88CE
        /// </summary>
        Matrix14Arb = 0x88ce,

        /// <summary>
        /// Original was GL_MATRIX15_ARB = 0x88CF
        /// </summary>
        Matrix15Arb = 0x88cf,

        /// <summary>
        /// Original was GL_MATRIX16_ARB = 0x88D0
        /// </summary>
        Matrix16Arb = 0x88d0,

        /// <summary>
        /// Original was GL_MATRIX17_ARB = 0x88D1
        /// </summary>
        Matrix17Arb = 0x88d1,

        /// <summary>
        /// Original was GL_MATRIX18_ARB = 0x88D2
        /// </summary>
        Matrix18Arb = 0x88d2,

        /// <summary>
        /// Original was GL_MATRIX19_ARB = 0x88D3
        /// </summary>
        Matrix19Arb = 0x88d3,

        /// <summary>
        /// Original was GL_MATRIX20_ARB = 0x88D4
        /// </summary>
        Matrix20Arb = 0x88d4,

        /// <summary>
        /// Original was GL_MATRIX21_ARB = 0x88D5
        /// </summary>
        Matrix21Arb = 0x88d5,

        /// <summary>
        /// Original was GL_MATRIX22_ARB = 0x88D6
        /// </summary>
        Matrix22Arb = 0x88d6,

        /// <summary>
        /// Original was GL_MATRIX23_ARB = 0x88D7
        /// </summary>
        Matrix23Arb = 0x88d7,

        /// <summary>
        /// Original was GL_MATRIX24_ARB = 0x88D8
        /// </summary>
        Matrix24Arb = 0x88d8,

        /// <summary>
        /// Original was GL_MATRIX25_ARB = 0x88D9
        /// </summary>
        Matrix25Arb = 0x88d9,

        /// <summary>
        /// Original was GL_MATRIX26_ARB = 0x88DA
        /// </summary>
        Matrix26Arb = 0x88da,

        /// <summary>
        /// Original was GL_MATRIX27_ARB = 0x88DB
        /// </summary>
        Matrix27Arb = 0x88db,

        /// <summary>
        /// Original was GL_MATRIX28_ARB = 0x88DC
        /// </summary>
        Matrix28Arb = 0x88dc,

        /// <summary>
        /// Original was GL_MATRIX29_ARB = 0x88DD
        /// </summary>
        Matrix29Arb = 0x88dd,

        /// <summary>
        /// Original was GL_MATRIX30_ARB = 0x88DE
        /// </summary>
        Matrix30Arb = 0x88de,

        /// <summary>
        /// Original was GL_MATRIX31_ARB = 0x88DF
        /// </summary>
        Matrix31Arb = 0x88df
    }
}
