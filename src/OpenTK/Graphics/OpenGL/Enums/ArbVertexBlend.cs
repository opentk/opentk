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
    /// Used in GL.Arb.WeightPointer
    /// </summary>
    public enum ArbVertexBlend
    {
        /// <summary>
        /// Original was GL_MODELVIEW0_ARB = 0x1700
        /// </summary>
        Modelview0Arb = 0x1700,

        /// <summary>
        /// Original was GL_MODELVIEW1_ARB = 0x850A
        /// </summary>
        Modelview1Arb = 0x850a,

        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_ARB = 0x86A4
        /// </summary>
        MaxVertexUnitsArb = 0x86a4,

        /// <summary>
        /// Original was GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5
        /// </summary>
        ActiveVertexUnitsArb = 0x86a5,

        /// <summary>
        /// Original was GL_WEIGHT_SUM_UNITY_ARB = 0x86A6
        /// </summary>
        WeightSumUnityArb = 0x86a6,

        /// <summary>
        /// Original was GL_VERTEX_BLEND_ARB = 0x86A7
        /// </summary>
        VertexBlendArb = 0x86a7,

        /// <summary>
        /// Original was GL_CURRENT_WEIGHT_ARB = 0x86A8
        /// </summary>
        CurrentWeightArb = 0x86a8,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9
        /// </summary>
        WeightArrayTypeArb = 0x86a9,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA
        /// </summary>
        WeightArrayStrideArb = 0x86aa,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB
        /// </summary>
        WeightArraySizeArb = 0x86ab,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC
        /// </summary>
        WeightArrayPointerArb = 0x86ac,

        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_ARB = 0x86AD
        /// </summary>
        WeightArrayArb = 0x86ad,

        /// <summary>
        /// Original was GL_MODELVIEW2_ARB = 0x8722
        /// </summary>
        Modelview2Arb = 0x8722,

        /// <summary>
        /// Original was GL_MODELVIEW3_ARB = 0x8723
        /// </summary>
        Modelview3Arb = 0x8723,

        /// <summary>
        /// Original was GL_MODELVIEW4_ARB = 0x8724
        /// </summary>
        Modelview4Arb = 0x8724,

        /// <summary>
        /// Original was GL_MODELVIEW5_ARB = 0x8725
        /// </summary>
        Modelview5Arb = 0x8725,

        /// <summary>
        /// Original was GL_MODELVIEW6_ARB = 0x8726
        /// </summary>
        Modelview6Arb = 0x8726,

        /// <summary>
        /// Original was GL_MODELVIEW7_ARB = 0x8727
        /// </summary>
        Modelview7Arb = 0x8727,

        /// <summary>
        /// Original was GL_MODELVIEW8_ARB = 0x8728
        /// </summary>
        Modelview8Arb = 0x8728,

        /// <summary>
        /// Original was GL_MODELVIEW9_ARB = 0x8729
        /// </summary>
        Modelview9Arb = 0x8729,

        /// <summary>
        /// Original was GL_MODELVIEW10_ARB = 0x872A
        /// </summary>
        Modelview10Arb = 0x872a,

        /// <summary>
        /// Original was GL_MODELVIEW11_ARB = 0x872B
        /// </summary>
        Modelview11Arb = 0x872b,

        /// <summary>
        /// Original was GL_MODELVIEW12_ARB = 0x872C
        /// </summary>
        Modelview12Arb = 0x872c,

        /// <summary>
        /// Original was GL_MODELVIEW13_ARB = 0x872D
        /// </summary>
        Modelview13Arb = 0x872d,

        /// <summary>
        /// Original was GL_MODELVIEW14_ARB = 0x872E
        /// </summary>
        Modelview14Arb = 0x872e,

        /// <summary>
        /// Original was GL_MODELVIEW15_ARB = 0x872F
        /// </summary>
        Modelview15Arb = 0x872f,

        /// <summary>
        /// Original was GL_MODELVIEW16_ARB = 0x8730
        /// </summary>
        Modelview16Arb = 0x8730,

        /// <summary>
        /// Original was GL_MODELVIEW17_ARB = 0x8731
        /// </summary>
        Modelview17Arb = 0x8731,

        /// <summary>
        /// Original was GL_MODELVIEW18_ARB = 0x8732
        /// </summary>
        Modelview18Arb = 0x8732,

        /// <summary>
        /// Original was GL_MODELVIEW19_ARB = 0x8733
        /// </summary>
        Modelview19Arb = 0x8733,

        /// <summary>
        /// Original was GL_MODELVIEW20_ARB = 0x8734
        /// </summary>
        Modelview20Arb = 0x8734,

        /// <summary>
        /// Original was GL_MODELVIEW21_ARB = 0x8735
        /// </summary>
        Modelview21Arb = 0x8735,

        /// <summary>
        /// Original was GL_MODELVIEW22_ARB = 0x8736
        /// </summary>
        Modelview22Arb = 0x8736,

        /// <summary>
        /// Original was GL_MODELVIEW23_ARB = 0x8737
        /// </summary>
        Modelview23Arb = 0x8737,

        /// <summary>
        /// Original was GL_MODELVIEW24_ARB = 0x8738
        /// </summary>
        Modelview24Arb = 0x8738,

        /// <summary>
        /// Original was GL_MODELVIEW25_ARB = 0x8739
        /// </summary>
        Modelview25Arb = 0x8739,

        /// <summary>
        /// Original was GL_MODELVIEW26_ARB = 0x873A
        /// </summary>
        Modelview26Arb = 0x873a,

        /// <summary>
        /// Original was GL_MODELVIEW27_ARB = 0x873B
        /// </summary>
        Modelview27Arb = 0x873b,

        /// <summary>
        /// Original was GL_MODELVIEW28_ARB = 0x873C
        /// </summary>
        Modelview28Arb = 0x873c,

        /// <summary>
        /// Original was GL_MODELVIEW29_ARB = 0x873D
        /// </summary>
        Modelview29Arb = 0x873d,

        /// <summary>
        /// Original was GL_MODELVIEW30_ARB = 0x873E
        /// </summary>
        Modelview30Arb = 0x873e,

        /// <summary>
        /// Original was GL_MODELVIEW31_ARB = 0x873F
        /// </summary>
        Modelview31Arb = 0x873f
    }
}
