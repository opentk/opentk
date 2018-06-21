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
    /// Used in GL.NV.GetProgram, GL.NV.GetProgramString and 3 other functions
    /// </summary>
    public enum NvVertexProgram
    {
        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_NV = 0x8620
        /// </summary>
        VertexProgramNv = 0x8620,

        /// <summary>
        /// Original was GL_VERTEX_STATE_PROGRAM_NV = 0x8621
        /// </summary>
        VertexStateProgramNv = 0x8621,

        /// <summary>
        /// Original was GL_ATTRIB_ARRAY_SIZE_NV = 0x8623
        /// </summary>
        AttribArraySizeNv = 0x8623,

        /// <summary>
        /// Original was GL_ATTRIB_ARRAY_STRIDE_NV = 0x8624
        /// </summary>
        AttribArrayStrideNv = 0x8624,

        /// <summary>
        /// Original was GL_ATTRIB_ARRAY_TYPE_NV = 0x8625
        /// </summary>
        AttribArrayTypeNv = 0x8625,

        /// <summary>
        /// Original was GL_CURRENT_ATTRIB_NV = 0x8626
        /// </summary>
        CurrentAttribNv = 0x8626,

        /// <summary>
        /// Original was GL_PROGRAM_LENGTH_NV = 0x8627
        /// </summary>
        ProgramLengthNv = 0x8627,

        /// <summary>
        /// Original was GL_PROGRAM_STRING_NV = 0x8628
        /// </summary>
        ProgramStringNv = 0x8628,

        /// <summary>
        /// Original was GL_MODELVIEW_PROJECTION_NV = 0x8629
        /// </summary>
        ModelviewProjectionNv = 0x8629,

        /// <summary>
        /// Original was GL_IDENTITY_NV = 0x862A
        /// </summary>
        IdentityNv = 0x862a,

        /// <summary>
        /// Original was GL_INVERSE_NV = 0x862B
        /// </summary>
        InverseNv = 0x862b,

        /// <summary>
        /// Original was GL_TRANSPOSE_NV = 0x862C
        /// </summary>
        TransposeNv = 0x862c,

        /// <summary>
        /// Original was GL_INVERSE_TRANSPOSE_NV = 0x862D
        /// </summary>
        InverseTransposeNv = 0x862d,

        /// <summary>
        /// Original was GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E
        /// </summary>
        MaxTrackMatrixStackDepthNv = 0x862e,

        /// <summary>
        /// Original was GL_MAX_TRACK_MATRICES_NV = 0x862F
        /// </summary>
        MaxTrackMatricesNv = 0x862f,

        /// <summary>
        /// Original was GL_MATRIX0_NV = 0x8630
        /// </summary>
        Matrix0Nv = 0x8630,

        /// <summary>
        /// Original was GL_MATRIX1_NV = 0x8631
        /// </summary>
        Matrix1Nv = 0x8631,

        /// <summary>
        /// Original was GL_MATRIX2_NV = 0x8632
        /// </summary>
        Matrix2Nv = 0x8632,

        /// <summary>
        /// Original was GL_MATRIX3_NV = 0x8633
        /// </summary>
        Matrix3Nv = 0x8633,

        /// <summary>
        /// Original was GL_MATRIX4_NV = 0x8634
        /// </summary>
        Matrix4Nv = 0x8634,

        /// <summary>
        /// Original was GL_MATRIX5_NV = 0x8635
        /// </summary>
        Matrix5Nv = 0x8635,

        /// <summary>
        /// Original was GL_MATRIX6_NV = 0x8636
        /// </summary>
        Matrix6Nv = 0x8636,

        /// <summary>
        /// Original was GL_MATRIX7_NV = 0x8637
        /// </summary>
        Matrix7Nv = 0x8637,

        /// <summary>
        /// Original was GL_CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640
        /// </summary>
        CurrentMatrixStackDepthNv = 0x8640,

        /// <summary>
        /// Original was GL_CURRENT_MATRIX_NV = 0x8641
        /// </summary>
        CurrentMatrixNv = 0x8641,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642
        /// </summary>
        VertexProgramPointSizeNv = 0x8642,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643
        /// </summary>
        VertexProgramTwoSideNv = 0x8643,

        /// <summary>
        /// Original was GL_PROGRAM_PARAMETER_NV = 0x8644
        /// </summary>
        ProgramParameterNv = 0x8644,

        /// <summary>
        /// Original was GL_ATTRIB_ARRAY_POINTER_NV = 0x8645
        /// </summary>
        AttribArrayPointerNv = 0x8645,

        /// <summary>
        /// Original was GL_PROGRAM_TARGET_NV = 0x8646
        /// </summary>
        ProgramTargetNv = 0x8646,

        /// <summary>
        /// Original was GL_PROGRAM_RESIDENT_NV = 0x8647
        /// </summary>
        ProgramResidentNv = 0x8647,

        /// <summary>
        /// Original was GL_TRACK_MATRIX_NV = 0x8648
        /// </summary>
        TrackMatrixNv = 0x8648,

        /// <summary>
        /// Original was GL_TRACK_MATRIX_TRANSFORM_NV = 0x8649
        /// </summary>
        TrackMatrixTransformNv = 0x8649,

        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_BINDING_NV = 0x864A
        /// </summary>
        VertexProgramBindingNv = 0x864a,

        /// <summary>
        /// Original was GL_PROGRAM_ERROR_POSITION_NV = 0x864B
        /// </summary>
        ProgramErrorPositionNv = 0x864b,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY0_NV = 0x8650
        /// </summary>
        VertexAttribArray0Nv = 0x8650,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY1_NV = 0x8651
        /// </summary>
        VertexAttribArray1Nv = 0x8651,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY2_NV = 0x8652
        /// </summary>
        VertexAttribArray2Nv = 0x8652,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY3_NV = 0x8653
        /// </summary>
        VertexAttribArray3Nv = 0x8653,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY4_NV = 0x8654
        /// </summary>
        VertexAttribArray4Nv = 0x8654,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY5_NV = 0x8655
        /// </summary>
        VertexAttribArray5Nv = 0x8655,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY6_NV = 0x8656
        /// </summary>
        VertexAttribArray6Nv = 0x8656,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY7_NV = 0x8657
        /// </summary>
        VertexAttribArray7Nv = 0x8657,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY8_NV = 0x8658
        /// </summary>
        VertexAttribArray8Nv = 0x8658,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY9_NV = 0x8659
        /// </summary>
        VertexAttribArray9Nv = 0x8659,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY10_NV = 0x865A
        /// </summary>
        VertexAttribArray10Nv = 0x865a,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY11_NV = 0x865B
        /// </summary>
        VertexAttribArray11Nv = 0x865b,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY12_NV = 0x865C
        /// </summary>
        VertexAttribArray12Nv = 0x865c,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY13_NV = 0x865D
        /// </summary>
        VertexAttribArray13Nv = 0x865d,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY14_NV = 0x865E
        /// </summary>
        VertexAttribArray14Nv = 0x865e,

        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY15_NV = 0x865F
        /// </summary>
        VertexAttribArray15Nv = 0x865f,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB0_4_NV = 0x8660
        /// </summary>
        Map1VertexAttrib04Nv = 0x8660,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB1_4_NV = 0x8661
        /// </summary>
        Map1VertexAttrib14Nv = 0x8661,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB2_4_NV = 0x8662
        /// </summary>
        Map1VertexAttrib24Nv = 0x8662,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB3_4_NV = 0x8663
        /// </summary>
        Map1VertexAttrib34Nv = 0x8663,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB4_4_NV = 0x8664
        /// </summary>
        Map1VertexAttrib44Nv = 0x8664,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB5_4_NV = 0x8665
        /// </summary>
        Map1VertexAttrib54Nv = 0x8665,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB6_4_NV = 0x8666
        /// </summary>
        Map1VertexAttrib64Nv = 0x8666,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB7_4_NV = 0x8667
        /// </summary>
        Map1VertexAttrib74Nv = 0x8667,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB8_4_NV = 0x8668
        /// </summary>
        Map1VertexAttrib84Nv = 0x8668,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB9_4_NV = 0x8669
        /// </summary>
        Map1VertexAttrib94Nv = 0x8669,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB10_4_NV = 0x866A
        /// </summary>
        Map1VertexAttrib104Nv = 0x866a,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB11_4_NV = 0x866B
        /// </summary>
        Map1VertexAttrib114Nv = 0x866b,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB12_4_NV = 0x866C
        /// </summary>
        Map1VertexAttrib124Nv = 0x866c,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB13_4_NV = 0x866D
        /// </summary>
        Map1VertexAttrib134Nv = 0x866d,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB14_4_NV = 0x866E
        /// </summary>
        Map1VertexAttrib144Nv = 0x866e,

        /// <summary>
        /// Original was GL_MAP1_VERTEX_ATTRIB15_4_NV = 0x866F
        /// </summary>
        Map1VertexAttrib154Nv = 0x866f,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB0_4_NV = 0x8670
        /// </summary>
        Map2VertexAttrib04Nv = 0x8670,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB1_4_NV = 0x8671
        /// </summary>
        Map2VertexAttrib14Nv = 0x8671,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB2_4_NV = 0x8672
        /// </summary>
        Map2VertexAttrib24Nv = 0x8672,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB3_4_NV = 0x8673
        /// </summary>
        Map2VertexAttrib34Nv = 0x8673,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB4_4_NV = 0x8674
        /// </summary>
        Map2VertexAttrib44Nv = 0x8674,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB5_4_NV = 0x8675
        /// </summary>
        Map2VertexAttrib54Nv = 0x8675,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB6_4_NV = 0x8676
        /// </summary>
        Map2VertexAttrib64Nv = 0x8676,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB7_4_NV = 0x8677
        /// </summary>
        Map2VertexAttrib74Nv = 0x8677,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB8_4_NV = 0x8678
        /// </summary>
        Map2VertexAttrib84Nv = 0x8678,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB9_4_NV = 0x8679
        /// </summary>
        Map2VertexAttrib94Nv = 0x8679,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB10_4_NV = 0x867A
        /// </summary>
        Map2VertexAttrib104Nv = 0x867a,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB11_4_NV = 0x867B
        /// </summary>
        Map2VertexAttrib114Nv = 0x867b,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB12_4_NV = 0x867C
        /// </summary>
        Map2VertexAttrib124Nv = 0x867c,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB13_4_NV = 0x867D
        /// </summary>
        Map2VertexAttrib134Nv = 0x867d,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB14_4_NV = 0x867E
        /// </summary>
        Map2VertexAttrib144Nv = 0x867e,

        /// <summary>
        /// Original was GL_MAP2_VERTEX_ATTRIB15_4_NV = 0x867F
        /// </summary>
        Map2VertexAttrib154Nv = 0x867f
    }
}
