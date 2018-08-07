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
    /// Used in GL.NV.BlendParameter.
    /// </summary>
    public enum NVBlendEquationAdvanced
    {
        /// <summary>
        /// Original was GL_ZERO = 0x0
        /// </summary>
        Zero = 0x0,

        /// <summary>
        /// Original was GL_XOR_NV = 0x1506
        /// </summary>
        XorNV = 0x1506,

        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = 0x150A,

        /// <summary>
        /// Original was GL_RED_NV = 0x1903
        /// </summary>
        RedNV = 0x1903,

        /// <summary>
        /// Original was GL_GREEN_NV = 0x1904
        /// </summary>
        GreenNV = 0x1904,

        /// <summary>
        /// Original was GL_BLUE_NV = 0x1905
        /// </summary>
        BlueNV = 0x1905,

        /// <summary>
        /// Original was GL_BLEND_PREMULTIPLIED_SRC_NV = 0x9280
        /// </summary>
        BlendPremultipliedSrcNV = 0x9280,

        /// <summary>
        /// Original was GL_BLEND_OVERLAP_NV = 0x9281
        /// </summary>
        BlendOverlapNV = 0x9281,

        /// <summary>
        /// Original was GL_UNCORRELATED_NV = 0x9282
        /// </summary>
        UncorrelatedNV = 0x9282,

        /// <summary>
        /// Original was GL_DISJOINT_NV = 0x9283
        /// </summary>
        DisjointNV = 0x9283,

        /// <summary>
        /// Original was GL_CONJOINT_NV = 0x9284
        /// </summary>
        ConjointNV = 0x9284,

        /// <summary>
        /// Original was GL_SRC_NV = 0x9286
        /// </summary>
        SrcNV = 0x9286,

        /// <summary>
        /// Original was GL_DST_NV = 0x9287
        /// </summary>
        DstNV = 0x9287,

        /// <summary>
        /// Original was GL_SRC_OVER_NV = 0x9288
        /// </summary>
        SrcOverNV = 0x9288,

        /// <summary>
        /// Original was GL_DST_OVER_NV = 0x9289
        /// </summary>
        DstOverNV = 0x9289,

        /// <summary>
        /// Original was GL_SRC_IN_NV = 0x928A
        /// </summary>
        SrcInNV = 0x928A,

        /// <summary>
        /// Original was GL_DST_IN_NV = 0x928B
        /// </summary>
        DstInNV = 0x928B,

        /// <summary>
        /// Original was GL_SRC_OUT_NV = 0x928C
        /// </summary>
        SrcOutNV = 0x928C,

        /// <summary>
        /// Original was GL_DST_OUT_NV = 0x928D
        /// </summary>
        DstOutNV = 0x928D,

        /// <summary>
        /// Original was GL_SRC_ATOP_NV = 0x928E
        /// </summary>
        SrcAtopNV = 0x928E,

        /// <summary>
        /// Original was GL_DST_ATOP_NV = 0x928F
        /// </summary>
        DstAtopNV = 0x928F,

        /// <summary>
        /// Original was GL_PLUS_NV = 0x9291
        /// </summary>
        PlusNV = 0x9291,

        /// <summary>
        /// Original was GL_PLUS_DARKER_NV = 0x9292
        /// </summary>
        PlusDarkerNV = 0x9292,

        /// <summary>
        /// Original was GL_MULTIPLY_NV = 0x9294
        /// </summary>
        MultiplyNV = 0x9294,

        /// <summary>
        /// Original was GL_SCREEN_NV = 0x9295
        /// </summary>
        ScreenNV = 0x9295,

        /// <summary>
        /// Original was GL_OVERLAY_NV = 0x9296
        /// </summary>
        OverlayNV = 0x9296,

        /// <summary>
        /// Original was GL_DARKEN_NV = 0x9297
        /// </summary>
        DarkenNV = 0x9297,

        /// <summary>
        /// Original was GL_LIGHTEN_NV = 0x9298
        /// </summary>
        LightenNV = 0x9298,

        /// <summary>
        /// Original was GL_COLORDODGE_NV = 0x9299
        /// </summary>
        ColordodgeNV = 0x9299,

        /// <summary>
        /// Original was GL_COLORBURN_NV = 0x929A
        /// </summary>
        ColorburnNV = 0x929A,

        /// <summary>
        /// Original was GL_HARDLIGHT_NV = 0x929B
        /// </summary>
        HardlightNV = 0x929B,

        /// <summary>
        /// Original was GL_SOFTLIGHT_NV = 0x929C
        /// </summary>
        SoftlightNV = 0x929C,

        /// <summary>
        /// Original was GL_DIFFERENCE_NV = 0x929E
        /// </summary>
        DifferenceNV = 0x929E,

        /// <summary>
        /// Original was GL_MINUS_NV = 0x929F
        /// </summary>
        MinusNV = 0x929F,

        /// <summary>
        /// Original was GL_EXCLUSION_NV = 0x92A0
        /// </summary>
        ExclusionNV = 0x92A0,

        /// <summary>
        /// Original was GL_CONTRAST_NV = 0x92A1
        /// </summary>
        ContrastNV = 0x92A1,

        /// <summary>
        /// Original was GL_INVERT_RGB_NV = 0x92A3
        /// </summary>
        InvertRgbNV = 0x92A3,

        /// <summary>
        /// Original was GL_LINEARDODGE_NV = 0x92A4
        /// </summary>
        LineardodgeNV = 0x92A4,

        /// <summary>
        /// Original was GL_LINEARBURN_NV = 0x92A5
        /// </summary>
        LinearburnNV = 0x92A5,

        /// <summary>
        /// Original was GL_VIVIDLIGHT_NV = 0x92A6
        /// </summary>
        VividlightNV = 0x92A6,

        /// <summary>
        /// Original was GL_LINEARLIGHT_NV = 0x92A7
        /// </summary>
        LinearlightNV = 0x92A7,

        /// <summary>
        /// Original was GL_PINLIGHT_NV = 0x92A8
        /// </summary>
        PinlightNV = 0x92A8,

        /// <summary>
        /// Original was GL_HARDMIX_NV = 0x92A9
        /// </summary>
        HardmixNV = 0x92A9,

        /// <summary>
        /// Original was GL_HSL_HUE_NV = 0x92AD
        /// </summary>
        HslHueNV = 0x92AD,

        /// <summary>
        /// Original was GL_HSL_SATURATION_NV = 0x92AE
        /// </summary>
        HslSaturationNV = 0x92AE,

        /// <summary>
        /// Original was GL_HSL_COLOR_NV = 0x92AF
        /// </summary>
        HslColorNV = 0x92AF,

        /// <summary>
        /// Original was GL_HSL_LUMINOSITY_NV = 0x92B0
        /// </summary>
        HslLuminosityNV = 0x92B0,

        /// <summary>
        /// Original was GL_PLUS_CLAMPED_NV = 0x92B1
        /// </summary>
        PlusClampedNV = 0x92B1,

        /// <summary>
        /// Original was GL_PLUS_CLAMPED_ALPHA_NV = 0x92B2
        /// </summary>
        PlusClampedAlphaNV = 0x92B2,

        /// <summary>
        /// Original was GL_MINUS_CLAMPED_NV = 0x92B3
        /// </summary>
        MinusClampedNV = 0x92B3,

        /// <summary>
        /// Original was GL_INVERT_OVG_NV = 0x92B4
        /// </summary>
        InvertOvgNV = 0x92B4
    }
}
