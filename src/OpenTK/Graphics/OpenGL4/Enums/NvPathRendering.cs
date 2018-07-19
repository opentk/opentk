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
    /// Used in GL.NV.GetProgramResource and GL.NV.MatrixLoad3x2, as well as 13 other functions.
    /// </summary>
    public enum NvPathRendering
    {
        /// <summary>
        /// Original was GL_CLOSE_PATH_NV = 0x00
        /// </summary>
        ClosePathNv = 0x00,

        /// <summary>
        /// Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000
        /// </summary>
        FontXMinBoundsBitNv = 0x00010000,

        /// <summary>
        /// Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        /// </summary>
        FontYMinBoundsBitNv = 0x00020000,

        /// <summary>
        /// Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000
        /// </summary>
        FontXMaxBoundsBitNv = 0x00040000,

        /// <summary>
        /// Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        /// </summary>
        FontYMaxBoundsBitNv = 0x00080000,

        /// <summary>
        /// Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000
        /// </summary>
        FontUnitsPerEmBitNv = 0x00100000,

        /// <summary>
        /// Original was GL_FONT_ASCENDER_BIT_NV = 0x00200000
        /// </summary>
        FontAscenderBitNv = 0x00200000,

        /// <summary>
        /// Original was GL_FONT_DESCENDER_BIT_NV = 0x00400000
        /// </summary>
        FontDescenderBitNv = 0x00400000,

        /// <summary>
        /// Original was GL_FONT_HEIGHT_BIT_NV = 0x00800000
        /// </summary>
        FontHeightBitNv = 0x00800000,

        /// <summary>
        /// Original was GL_BOLD_BIT_NV = 0x01
        /// </summary>
        BoldBitNv = 0x01,

        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        /// </summary>
        GlyphWidthBitNv = 0x01,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000
        /// </summary>
        FontMaxAdvanceWidthBitNv = 0x01000000,

        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        /// </summary>
        GlyphHeightBitNv = 0x02,

        /// <summary>
        /// Original was GL_ITALIC_BIT_NV = 0x02
        /// </summary>
        ItalicBitNv = 0x02,

        /// <summary>
        /// Original was GL_MOVE_TO_NV = 0x02
        /// </summary>
        MoveToNv = 0x02,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000
        /// </summary>
        FontMaxAdvanceHeightBitNv = 0x02000000,

        /// <summary>
        /// Original was GL_RELATIVE_MOVE_TO_NV = 0x03
        /// </summary>
        RelativeMoveToNv = 0x03,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        /// </summary>
        GlyphHorizontalBearingXBitNv = 0x04,

        /// <summary>
        /// Original was GL_LINE_TO_NV = 0x04
        /// </summary>
        LineToNv = 0x04,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000
        /// </summary>
        FontUnderlinePositionBitNv = 0x04000000,

        /// <summary>
        /// Original was GL_RELATIVE_LINE_TO_NV = 0x05
        /// </summary>
        RelativeLineToNv = 0x05,

        /// <summary>
        /// Original was GL_HORIZONTAL_LINE_TO_NV = 0x06
        /// </summary>
        HorizontalLineToNv = 0x06,

        /// <summary>
        /// Original was GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07
        /// </summary>
        RelativeHorizontalLineToNv = 0x07,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        /// </summary>
        GlyphHorizontalBearingYBitNv = 0x08,

        /// <summary>
        /// Original was GL_VERTICAL_LINE_TO_NV = 0x08
        /// </summary>
        VerticalLineToNv = 0x08,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000
        /// </summary>
        FontUnderlineThicknessBitNv = 0x08000000,

        /// <summary>
        /// Original was GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x09
        /// </summary>
        RelativeVerticalLineToNv = 0x09,

        /// <summary>
        /// Original was GL_QUADRATIC_CURVE_TO_NV = 0x0A
        /// </summary>
        QuadraticCurveToNv = 0x0a,

        /// <summary>
        /// Original was GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B
        /// </summary>
        RelativeQuadraticCurveToNv = 0x0b,

        /// <summary>
        /// Original was GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0x0BA3
        /// </summary>
        PathModelviewStackDepthNv = 0x0ba3,

        /// <summary>
        /// Original was GL_PATH_PROJECTION_STACK_DEPTH_NV = 0x0BA4
        /// </summary>
        PathProjectionStackDepthNv = 0x0ba4,

        /// <summary>
        /// Original was GL_PATH_MODELVIEW_MATRIX_NV = 0x0BA6
        /// </summary>
        PathModelviewMatrixNv = 0x0ba6,

        /// <summary>
        /// Original was GL_PATH_PROJECTION_MATRIX_NV = 0x0BA7
        /// </summary>
        PathProjectionMatrixNv = 0x0ba7,

        /// <summary>
        /// Original was GL_CUBIC_CURVE_TO_NV = 0x0C
        /// </summary>
        CubicCurveToNv = 0x0c,

        /// <summary>
        /// Original was GL_RELATIVE_CUBIC_CURVE_TO_NV = 0x0D
        /// </summary>
        RelativeCubicCurveToNv = 0x0d,

        /// <summary>
        /// Original was GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0x0D36
        /// </summary>
        PathMaxModelviewStackDepthNv = 0x0d36,

        /// <summary>
        /// Original was GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0x0D38
        /// </summary>
        PathMaxProjectionStackDepthNv = 0x0d38,

        /// <summary>
        /// Original was GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0E
        /// </summary>
        SmoothQuadraticCurveToNv = 0x0e,

        /// <summary>
        /// Original was GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F
        /// </summary>
        RelativeSmoothQuadraticCurveToNv = 0x0f,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNv = 0x10,

        /// <summary>
        /// Original was GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10
        /// </summary>
        SmoothCubicCurveToNv = 0x10,

        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNv = 0x100,

        /// <summary>
        /// Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        /// </summary>
        FontHasKerningBitNv = 0x10000000,

        /// <summary>
        /// Original was GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11
        /// </summary>
        RelativeSmoothCubicCurveToNv = 0x11,

        /// <summary>
        /// Original was GL_SMALL_CCW_ARC_TO_NV = 0x12
        /// </summary>
        SmallCcwArcToNv = 0x12,

        /// <summary>
        /// Original was GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13
        /// </summary>
        RelativeSmallCcwArcToNv = 0x13,

        /// <summary>
        /// Original was GL_SMALL_CW_ARC_TO_NV = 0x14
        /// </summary>
        SmallCwArcToNv = 0x14,

        /// <summary>
        /// Original was GL_2_BYTES_NV = 0x1407
        /// </summary>
        Gl2BytesNv = 0x1407,

        /// <summary>
        /// Original was GL_3_BYTES_NV = 0x1408
        /// </summary>
        Gl3BytesNv = 0x1408,

        /// <summary>
        /// Original was GL_4_BYTES_NV = 0x1409
        /// </summary>
        Gl4BytesNv = 0x1409,

        /// <summary>
        /// Original was GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15
        /// </summary>
        RelativeSmallCwArcToNv = 0x15,

        /// <summary>
        /// Original was GL_LARGE_CCW_ARC_TO_NV = 0x16
        /// </summary>
        LargeCcwArcToNv = 0x16,

        /// <summary>
        /// Original was GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17
        /// </summary>
        RelativeLargeCcwArcToNv = 0x17,

        /// <summary>
        /// Original was GL_PATH_MODELVIEW_NV = 0x1700
        /// </summary>
        PathModelviewNv = 0x1700,

        /// <summary>
        /// Original was GL_PATH_PROJECTION_NV = 0x1701
        /// </summary>
        PathProjectionNv = 0x1701,

        /// <summary>
        /// Original was GL_LARGE_CW_ARC_TO_NV = 0x18
        /// </summary>
        LargeCwArcToNv = 0x18,

        /// <summary>
        /// Original was GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19
        /// </summary>
        RelativeLargeCwArcToNv = 0x19,

        /// <summary>
        /// Original was GL_CONIC_CURVE_TO_NV = 0x1A
        /// </summary>
        ConicCurveToNv = 0x1a,

        /// <summary>
        /// Original was GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B
        /// </summary>
        RelativeConicCurveToNv = 0x1b,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNv = 0x20,

        /// <summary>
        /// Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        /// </summary>
        FontNumGlyphIndicesBitNv = 0x20000000,

        /// <summary>
        /// Original was GL_EYE_LINEAR_NV = 0x2400
        /// </summary>
        EyeLinearNv = 0x2400,

        /// <summary>
        /// Original was GL_OBJECT_LINEAR_NV = 0x2401
        /// </summary>
        ObjectLinearNv = 0x2401,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNv = 0x40,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNv = 0x80,

        /// <summary>
        /// Original was GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3
        /// </summary>
        PathTransposeModelviewMatrixNv = 0x84e3,

        /// <summary>
        /// Original was GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4
        /// </summary>
        PathTransposeProjectionMatrixNv = 0x84e4,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNv = 0x852c,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNv = 0x852d,

        /// <summary>
        /// Original was GL_CONSTANT_NV = 0x8576
        /// </summary>
        ConstantNv = 0x8576,

        /// <summary>
        /// Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        /// </summary>
        PathFormatSvgNv = 0x9070,

        /// <summary>
        /// Original was GL_PATH_FORMAT_PS_NV = 0x9071
        /// </summary>
        PathFormatPsNv = 0x9071,

        /// <summary>
        /// Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        /// </summary>
        StandardFontNameNv = 0x9072,

        /// <summary>
        /// Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        /// </summary>
        SystemFontNameNv = 0x9073,

        /// <summary>
        /// Original was GL_FILE_NAME_NV = 0x9074
        /// </summary>
        FileNameNv = 0x9074,

        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNv = 0x9075,

        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNv = 0x9076,

        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNv = 0x9077,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNv = 0x9078,

        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNv = 0x9079,

        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNv = 0x907a,

        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNv = 0x907b,

        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNv = 0x907c,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNv = 0x907d,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNv = 0x907e,

        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNv = 0x907f,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNv = 0x9080,

        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNv = 0x9081,

        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNv = 0x9082,

        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNv = 0x9083,

        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNv = 0x9084,

        /// <summary>
        /// Original was GL_COUNT_UP_NV = 0x9088
        /// </summary>
        CountUpNv = 0x9088,

        /// <summary>
        /// Original was GL_COUNT_DOWN_NV = 0x9089
        /// </summary>
        CountDownNv = 0x9089,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNv = 0x908a,

        /// <summary>
        /// Original was GL_CONVEX_HULL_NV = 0x908B
        /// </summary>
        ConvexHullNv = 0x908b,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_NV = 0x908D
        /// </summary>
        BoundingBoxNv = 0x908d,

        /// <summary>
        /// Original was GL_TRANSLATE_X_NV = 0x908E
        /// </summary>
        TranslateXNv = 0x908e,

        /// <summary>
        /// Original was GL_TRANSLATE_Y_NV = 0x908F
        /// </summary>
        TranslateYNv = 0x908f,

        /// <summary>
        /// Original was GL_TRANSLATE_2D_NV = 0x9090
        /// </summary>
        Translate2DNv = 0x9090,

        /// <summary>
        /// Original was GL_TRANSLATE_3D_NV = 0x9091
        /// </summary>
        Translate3DNv = 0x9091,

        /// <summary>
        /// Original was GL_AFFINE_2D_NV = 0x9092
        /// </summary>
        Affine2DNv = 0x9092,

        /// <summary>
        /// Original was GL_AFFINE_3D_NV = 0x9094
        /// </summary>
        Affine3DNv = 0x9094,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_2D_NV = 0x9096
        /// </summary>
        TransposeAffine2DNv = 0x9096,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        /// </summary>
        TransposeAffine3DNv = 0x9098,

        /// <summary>
        /// Original was GL_UTF8_NV = 0x909A
        /// </summary>
        Utf8Nv = 0x909a,

        /// <summary>
        /// Original was GL_UTF16_NV = 0x909B
        /// </summary>
        Utf16Nv = 0x909b,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        /// </summary>
        BoundingBoxOfBoundingBoxesNv = 0x909c,

        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNv = 0x909d,

        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNv = 0x909e,

        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNv = 0x909f,

        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNv = 0x90a0,

        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNv = 0x90a1,

        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNv = 0x90a2,

        /// <summary>
        /// Original was GL_SQUARE_NV = 0x90A3
        /// </summary>
        SquareNv = 0x90a3,

        /// <summary>
        /// Original was GL_ROUND_NV = 0x90A4
        /// </summary>
        RoundNv = 0x90a4,

        /// <summary>
        /// Original was GL_TRIANGULAR_NV = 0x90A5
        /// </summary>
        TriangularNv = 0x90a5,

        /// <summary>
        /// Original was GL_BEVEL_NV = 0x90A6
        /// </summary>
        BevelNv = 0x90a6,

        /// <summary>
        /// Original was GL_MITER_REVERT_NV = 0x90A7
        /// </summary>
        MiterRevertNv = 0x90a7,

        /// <summary>
        /// Original was GL_MITER_TRUNCATE_NV = 0x90A8
        /// </summary>
        MiterTruncateNv = 0x90a8,

        /// <summary>
        /// Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        /// </summary>
        SkipMissingGlyphNv = 0x90a9,

        /// <summary>
        /// Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        /// </summary>
        UseMissingGlyphNv = 0x90aa,

        /// <summary>
        /// Original was GL_PATH_ERROR_POSITION_NV = 0x90AB
        /// </summary>
        PathErrorPositionNv = 0x90ab,

        /// <summary>
        /// Original was GL_PATH_FOG_GEN_MODE_NV = 0x90AC
        /// </summary>
        PathFogGenModeNv = 0x90ac,

        /// <summary>
        /// Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        /// </summary>
        AccumAdjacentPairsNv = 0x90ad,

        /// <summary>
        /// Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        /// </summary>
        AdjacentPairsNv = 0x90ae,

        /// <summary>
        /// Original was GL_FIRST_TO_REST_NV = 0x90AF
        /// </summary>
        FirstToRestNv = 0x90af,

        /// <summary>
        /// Original was GL_PATH_GEN_MODE_NV = 0x90B0
        /// </summary>
        PathGenModeNv = 0x90b0,

        /// <summary>
        /// Original was GL_PATH_GEN_COEFF_NV = 0x90B1
        /// </summary>
        PathGenCoeffNv = 0x90b1,

        /// <summary>
        /// Original was GL_PATH_GEN_COLOR_FORMAT_NV = 0x90B2
        /// </summary>
        PathGenColorFormatNv = 0x90b2,

        /// <summary>
        /// Original was GL_PATH_GEN_COMPONENTS_NV = 0x90B3
        /// </summary>
        PathGenComponentsNv = 0x90b3,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNv = 0x90b4,

        /// <summary>
        /// Original was GL_MOVE_TO_RESETS_NV = 0x90B5
        /// </summary>
        MoveToResetsNv = 0x90b5,

        /// <summary>
        /// Original was GL_MOVE_TO_CONTINUES_NV = 0x90B6
        /// </summary>
        MoveToContinuesNv = 0x90b6,

        /// <summary>
        /// Original was GL_PATH_STENCIL_FUNC_NV = 0x90B7
        /// </summary>
        PathStencilFuncNv = 0x90b7,

        /// <summary>
        /// Original was GL_PATH_STENCIL_REF_NV = 0x90B8
        /// </summary>
        PathStencilRefNv = 0x90b8,

        /// <summary>
        /// Original was GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9
        /// </summary>
        PathStencilValueMaskNv = 0x90b9,

        /// <summary>
        /// Original was GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD
        /// </summary>
        PathStencilDepthOffsetFactorNv = 0x90bd,

        /// <summary>
        /// Original was GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE
        /// </summary>
        PathStencilDepthOffsetUnitsNv = 0x90be,

        /// <summary>
        /// Original was GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF
        /// </summary>
        PathCoverDepthFuncNv = 0x90bf,

        /// <summary>
        /// Original was GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368
        /// </summary>
        FontGlyphsAvailableNv = 0x9368,

        /// <summary>
        /// Original was GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369
        /// </summary>
        FontTargetUnavailableNv = 0x9369,

        /// <summary>
        /// Original was GL_FONT_UNAVAILABLE_NV = 0x936A
        /// </summary>
        FontUnavailableNv = 0x936a,

        /// <summary>
        /// Original was GL_FONT_UNINTELLIGIBLE_NV = 0x936B
        /// </summary>
        FontUnintelligibleNv = 0x936b,

        /// <summary>
        /// Original was GL_STANDARD_FONT_FORMAT_NV = 0x936C
        /// </summary>
        StandardFontFormatNv = 0x936c,

        /// <summary>
        /// Original was GL_FRAGMENT_INPUT_NV = 0x936D
        /// </summary>
        FragmentInputNv = 0x936d,

        /// <summary>
        /// Original was GL_ROUNDED_RECT_NV = 0xE8
        /// </summary>
        RoundedRectNv = 0xe8,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT_NV = 0xE9
        /// </summary>
        RelativeRoundedRectNv = 0xe9,

        /// <summary>
        /// Original was GL_ROUNDED_RECT2_NV = 0xEA
        /// </summary>
        RoundedRect2Nv = 0xea,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB
        /// </summary>
        RelativeRoundedRect2Nv = 0xeb,

        /// <summary>
        /// Original was GL_ROUNDED_RECT4_NV = 0xEC
        /// </summary>
        RoundedRect4Nv = 0xec,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT4_NV = 0xED
        /// </summary>
        RelativeRoundedRect4Nv = 0xed,

        /// <summary>
        /// Original was GL_ROUNDED_RECT8_NV = 0xEE
        /// </summary>
        RoundedRect8Nv = 0xee,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF
        /// </summary>
        RelativeRoundedRect8Nv = 0xef,

        /// <summary>
        /// Original was GL_RESTART_PATH_NV = 0xF0
        /// </summary>
        RestartPathNv = 0xf0,

        /// <summary>
        /// Original was GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2
        /// </summary>
        DupFirstCubicCurveToNv = 0xf2,

        /// <summary>
        /// Original was GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4
        /// </summary>
        DupLastCubicCurveToNv = 0xf4,

        /// <summary>
        /// Original was GL_RECT_NV = 0xF6
        /// </summary>
        RectNv = 0xf6,

        /// <summary>
        /// Original was GL_RELATIVE_RECT_NV = 0xF7
        /// </summary>
        RelativeRectNv = 0xf7,

        /// <summary>
        /// Original was GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8
        /// </summary>
        CircularCcwArcToNv = 0xf8,

        /// <summary>
        /// Original was GL_CIRCULAR_CW_ARC_TO_NV = 0xFA
        /// </summary>
        CircularCwArcToNv = 0xfa,

        /// <summary>
        /// Original was GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC
        /// </summary>
        CircularTangentArcToNv = 0xfc,

        /// <summary>
        /// Original was GL_ARC_TO_NV = 0xFE
        /// </summary>
        ArcToNv = 0xfe,

        /// <summary>
        /// Original was GL_RELATIVE_ARC_TO_NV = 0xFF
        /// </summary>
        RelativeArcToNv = 0xff
    }
}
