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

namespace OpenTK.Graphics.ES31
{
    /// <summary>
    /// Used in GL.NV.BlendParameter
    /// </summary>
    public enum NvBlendEquationAdvanced
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = 0,

        /// <summary>
        /// Original was GL_XOR_NV = 0x1506
        /// </summary>
        XorNv = 0x1506,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150a,

        /// <summary>
        /// Original was GL_RED_NV = 0x1903
        /// </summary>
        RedNv = 0x1903,

        /// <summary>
        /// Original was GL_GREEN_NV = 0x1904
        /// </summary>
        GreenNv = 0x1904,

        /// <summary>
        /// Original was GL_BLUE_NV = 0x1905
        /// </summary>
        BlueNv = 0x1905,

        /// <summary>
        /// Original was GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280
        /// </summary>
        BlendPremultipliedSrcNv = 0x9280,

        /// <summary>
        /// Original was GL_BLEND_OVERLAP_NV = 0x9281
        /// </summary>
        BlendOverlapNv = 0x9281,

        /// <summary>
        /// Original was GL_UNCORRELATED_NV = 0x9282
        /// </summary>
        UncorrelatedNv = 0x9282,

        /// <summary>
        /// Original was GL_DISJOINT_NV = 0x9283
        /// </summary>
        DisjointNv = 0x9283,

        /// <summary>
        /// Original was GL_CONJOINT_NV = 0x9284
        /// </summary>
        ConjointNv = 0x9284,

        /// <summary>
        /// Original was GL_SRC_NV = 0x9286
        /// </summary>
        SrcNv = 0x9286,

        /// <summary>
        /// Original was GL_DST_NV = 0x9287
        /// </summary>
        DstNv = 0x9287,

        /// <summary>
        /// Original was GL_SRC_OVER_NV = 0x9288
        /// </summary>
        SrcOverNv = 0x9288,

        /// <summary>
        /// Original was GL_DST_OVER_NV = 0x9289
        /// </summary>
        DstOverNv = 0x9289,

        /// <summary>
        /// Original was GL_SRC_IN_NV = 0x928A
        /// </summary>
        SrcInNv = 0x928a,

        /// <summary>
        /// Original was GL_DST_IN_NV = 0x928B
        /// </summary>
        DstInNv = 0x928b,

        /// <summary>
        /// Original was GL_SRC_OUT_NV = 0x928C
        /// </summary>
        SrcOutNv = 0x928c,

        /// <summary>
        /// Original was GL_DST_OUT_NV = 0x928D
        /// </summary>
        DstOutNv = 0x928d,

        /// <summary>
        /// Original was GL_SRC_ATOP_NV = 0x928E
        /// </summary>
        SrcAtopNv = 0x928e,

        /// <summary>
        /// Original was GL_DST_ATOP_NV = 0x928F
        /// </summary>
        DstAtopNv = 0x928f,

        /// <summary>
        /// Original was GL_PLUS_NV = 0x9291
        /// </summary>
        PlusNv = 0x9291,

        /// <summary>
        /// Original was GL_PLUS_DARKER_NV = 0x9292
        /// </summary>
        PlusDarkerNv = 0x9292,

        /// <summary>
        /// Original was GL_MULTIPLY_NV = 0x9294
        /// </summary>
        MultiplyNv = 0x9294,

        /// <summary>
        /// Original was GL_SCREEN_NV = 0x9295
        /// </summary>
        ScreenNv = 0x9295,

        /// <summary>
        /// Original was GL_OVERLAY_NV = 0x9296
        /// </summary>
        OverlayNv = 0x9296,

        /// <summary>
        /// Original was GL_DARKEN_NV = 0x9297
        /// </summary>
        DarkenNv = 0x9297,

        /// <summary>
        /// Original was GL_LIGHTEN_NV = 0x9298
        /// </summary>
        LightenNv = 0x9298,

        /// <summary>
        /// Original was GL_COLORDODGE_NV = 0x9299
        /// </summary>
        ColordodgeNv = 0x9299,

        /// <summary>
        /// Original was GL_COLORBURN_NV = 0x929A
        /// </summary>
        ColorburnNv = 0x929a,

        /// <summary>
        /// Original was GL_HARDLIGHT_NV = 0x929B
        /// </summary>
        HardlightNv = 0x929b,

        /// <summary>
        /// Original was GL_SOFTLIGHT_NV = 0x929C
        /// </summary>
        SoftlightNv = 0x929c,

        /// <summary>
        /// Original was GL_DIFFERENCE_NV = 0x929E
        /// </summary>
        DifferenceNv = 0x929e,

        /// <summary>
        /// Original was GL_MINUS_NV = 0x929F
        /// </summary>
        MinusNv = 0x929f,

        /// <summary>
        /// Original was GL_EXCLUSION_NV = 0x92A0
        /// </summary>
        ExclusionNv = 0x92a0,

        /// <summary>
        /// Original was GL_CONTRAST_NV = 0x92A1
        /// </summary>
        ContrastNv = 0x92a1,

        /// <summary>
        /// Original was GL_INVERT_RGB_NV = 0x92A3
        /// </summary>
        InvertRgbNv = 0x92a3,

        /// <summary>
        /// Original was GL_LINEARDODGE_NV = 0x92A4
        /// </summary>
        LineardodgeNv = 0x92a4,

        /// <summary>
        /// Original was GL_LINEARBURN_NV = 0x92A5
        /// </summary>
        LinearburnNv = 0x92a5,

        /// <summary>
        /// Original was GL_VIVIDLIGHT_NV = 0x92A6
        /// </summary>
        VividlightNv = 0x92a6,

        /// <summary>
        /// Original was GL_LINEARLIGHT_NV = 0x92A7
        /// </summary>
        LinearlightNv = 0x92a7,

        /// <summary>
        /// Original was GL_PINLIGHT_NV = 0x92A8
        /// </summary>
        PinlightNv = 0x92a8,

        /// <summary>
        /// Original was GL_HARDMIX_NV = 0x92A9
        /// </summary>
        HardmixNv = 0x92a9,

        /// <summary>
        /// Original was GL_HSL_HUE_NV = 0x92AD
        /// </summary>
        HslHueNv = 0x92ad,

        /// <summary>
        /// Original was GL_HSL_SATURATION_NV = 0x92AE
        /// </summary>
        HslSaturationNv = 0x92ae,

        /// <summary>
        /// Original was GL_HSL_COLOR_NV = 0x92AF
        /// </summary>
        HslColorNv = 0x92af,

        /// <summary>
        /// Original was GL_HSL_LUMINOSITY_NV = 0x92B0
        /// </summary>
        HslLuminosityNv = 0x92b0,

        /// <summary>
        /// Original was GL_PLUS_CLAMPED_NV = 0x92B1
        /// </summary>
        PlusClampedNv = 0x92b1,

        /// <summary>
        /// Original was GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2
        /// </summary>
        PlusClampedAlphaNv = 0x92b2,

        /// <summary>
        /// Original was GL_MINUS_CLAMPED_NV = 0x92B3
        /// </summary>
        MinusClampedNv = 0x92b3,

        /// <summary>
        /// Original was GL_INVERT_OVG_NV = 0x92B4
        /// </summary>
        InvertOvgNv = 0x92b4
    }
}
