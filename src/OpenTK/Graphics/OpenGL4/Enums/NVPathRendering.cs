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
    public enum NVPathRendering
    {
        /// <summary>
        /// Original was GL_CLOSE_PATH_NV = 0x0
        /// </summary>
        ClosePathNV = 0x0,

        /// <summary>
        /// Original was GL_BOLD_BIT_NV = 0x1
        /// </summary>
        BoldBitNV = 0x1,

        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x1
        /// </summary>
        GlyphWidthBitNV = 0x1,

        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x2
        /// </summary>
        GlyphHeightBitNV = 0x2,

        /// <summary>
        /// Original was GL_ITALIC_BIT_NV = 0x2
        /// </summary>
        ItalicBitNV = 0x2,

        /// <summary>
        /// Original was GL_MOVE_TO_NV = 0x2
        /// </summary>
        MoveToNV = 0x2,

        /// <summary>
        /// Original was GL_RELATIVE_MOVE_TO_NV = 0x3
        /// </summary>
        RelativeMoveToNV = 0x3,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x4
        /// </summary>
        GlyphHorizontalBearingXBitNV = 0x4,

        /// <summary>
        /// Original was GL_LINE_TO_NV = 0x4
        /// </summary>
        LineToNV = 0x4,

        /// <summary>
        /// Original was GL_RELATIVE_LINE_TO_NV = 0x5
        /// </summary>
        RelativeLineToNV = 0x5,

        /// <summary>
        /// Original was GL_HORIZONTAL_LINE_TO_NV = 0x6
        /// </summary>
        HorizontalLineToNV = 0x6,

        /// <summary>
        /// Original was GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x7
        /// </summary>
        RelativeHorizontalLineToNV = 0x7,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x8
        /// </summary>
        GlyphHorizontalBearingYBitNV = 0x8,

        /// <summary>
        /// Original was GL_VERTICAL_LINE_TO_NV = 0x8
        /// </summary>
        VerticalLineToNV = 0x8,

        /// <summary>
        /// Original was GL_RELATIVE_VERTICAL_LINE_TO_NV = 0x9
        /// </summary>
        RelativeVerticalLineToNV = 0x9,

        /// <summary>
        /// Original was GL_QUADRATIC_CURVE_TO_NV = 0xA
        /// </summary>
        QuadraticCurveToNV = 0xA,

        /// <summary>
        /// Original was GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0xB
        /// </summary>
        RelativeQuadraticCurveToNV = 0xB,

        /// <summary>
        /// Original was GL_CUBIC_CURVE_TO_NV = 0xC
        /// </summary>
        CubicCurveToNV = 0xC,

        /// <summary>
        /// Original was GL_RELATIVE_CUBIC_CURVE_TO_NV = 0xD
        /// </summary>
        RelativeCubicCurveToNV = 0xD,

        /// <summary>
        /// Original was GL_SMOOTH_QUADRATIC_CURVE_TO_NV = 0xE
        /// </summary>
        SmoothQuadraticCurveToNV = 0xE,

        /// <summary>
        /// Original was GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0xF
        /// </summary>
        RelativeSmoothQuadraticCurveToNV = 0xF,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNV = 0x10,

        /// <summary>
        /// Original was GL_SMOOTH_CUBIC_CURVE_TO_NV = 0x10
        /// </summary>
        SmoothCubicCurveToNV = 0x10,

        /// <summary>
        /// Original was GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11
        /// </summary>
        RelativeSmoothCubicCurveToNV = 0x11,

        /// <summary>
        /// Original was GL_SMALL_CCW_ARC_TO_NV = 0x12
        /// </summary>
        SmallCcwArcToNV = 0x12,

        /// <summary>
        /// Original was GL_RELATIVE_SMALL_CCW_ARC_TO_NV = 0x13
        /// </summary>
        RelativeSmallCcwArcToNV = 0x13,

        /// <summary>
        /// Original was GL_SMALL_CW_ARC_TO_NV = 0x14
        /// </summary>
        SmallCWArcToNV = 0x14,

        /// <summary>
        /// Original was GL_RELATIVE_SMALL_CW_ARC_TO_NV = 0x15
        /// </summary>
        RelativeSmallCWArcToNV = 0x15,

        /// <summary>
        /// Original was GL_LARGE_CCW_ARC_TO_NV = 0x16
        /// </summary>
        LargeCcwArcToNV = 0x16,

        /// <summary>
        /// Original was GL_RELATIVE_LARGE_CCW_ARC_TO_NV = 0x17
        /// </summary>
        RelativeLargeCcwArcToNV = 0x17,

        /// <summary>
        /// Original was GL_LARGE_CW_ARC_TO_NV = 0x18
        /// </summary>
        LargeCWArcToNV = 0x18,

        /// <summary>
        /// Original was GL_RELATIVE_LARGE_CW_ARC_TO_NV = 0x19
        /// </summary>
        RelativeLargeCWArcToNV = 0x19,

        /// <summary>
        /// Original was GL_CONIC_CURVE_TO_NV = 0x1A
        /// </summary>
        ConicCurveToNV = 0x1A,

        /// <summary>
        /// Original was GL_RELATIVE_CONIC_CURVE_TO_NV = 0x1B
        /// </summary>
        RelativeConicCurveToNV = 0x1B,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNV = 0x20,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNV = 0x40,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNV = 0x80,

        /// <summary>
        /// Original was GL_ROUNDED_RECT_NV = 0xE8
        /// </summary>
        RoundedRectNV = 0xE8,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT_NV = 0xE9
        /// </summary>
        RelativeRoundedRectNV = 0xE9,

        /// <summary>
        /// Original was GL_ROUNDED_RECT2_NV = 0xEA
        /// </summary>
        RoundedRect2NV = 0xEA,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT2_NV = 0xEB
        /// </summary>
        RelativeRoundedRect2NV = 0xEB,

        /// <summary>
        /// Original was GL_ROUNDED_RECT4_NV = 0xEC
        /// </summary>
        RoundedRect4NV = 0xEC,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT4_NV = 0xED
        /// </summary>
        RelativeRoundedRect4NV = 0xED,

        /// <summary>
        /// Original was GL_ROUNDED_RECT8_NV = 0xEE
        /// </summary>
        RoundedRect8NV = 0xEE,

        /// <summary>
        /// Original was GL_RELATIVE_ROUNDED_RECT8_NV = 0xEF
        /// </summary>
        RelativeRoundedRect8NV = 0xEF,

        /// <summary>
        /// Original was GL_RESTART_PATH_NV = 0xF0
        /// </summary>
        RestartPathNV = 0xF0,

        /// <summary>
        /// Original was GL_DUP_FIRST_CUBIC_CURVE_TO_NV = 0xF2
        /// </summary>
        DupFirstCubicCurveToNV = 0xF2,

        /// <summary>
        /// Original was GL_DUP_LAST_CUBIC_CURVE_TO_NV = 0xF4
        /// </summary>
        DupLastCubicCurveToNV = 0xF4,

        /// <summary>
        /// Original was GL_RECT_NV = 0xF6
        /// </summary>
        RectNV = 0xF6,

        /// <summary>
        /// Original was GL_RELATIVE_RECT_NV = 0xF7
        /// </summary>
        RelativeRectNV = 0xF7,

        /// <summary>
        /// Original was GL_CIRCULAR_CCW_ARC_TO_NV = 0xF8
        /// </summary>
        CircularCcwArcToNV = 0xF8,

        /// <summary>
        /// Original was GL_CIRCULAR_CW_ARC_TO_NV = 0xFA
        /// </summary>
        CircularCWArcToNV = 0xFA,

        /// <summary>
        /// Original was GL_CIRCULAR_TANGENT_ARC_TO_NV = 0xFC
        /// </summary>
        CircularTangentArcToNV = 0xFC,

        /// <summary>
        /// Original was GL_ARC_TO_NV = 0xFE
        /// </summary>
        ArcToNV = 0xFE,

        /// <summary>
        /// Original was GL_RELATIVE_ARC_TO_NV = 0xFF
        /// </summary>
        RelativeArcToNV = 0xFF,

        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNV = 0x100,

        /// <summary>
        /// Original was GL_PATH_MODELVIEW_STACK_DEPTH_NV = 0xBA3
        /// </summary>
        PathModelviewStackDepthNV = 0xBA3,

        /// <summary>
        /// Original was GL_PATH_PROJECTION_STACK_DEPTH_NV = 0xBA4
        /// </summary>
        PathProjectionStackDepthNV = 0xBA4,

        /// <summary>
        /// Original was GL_PATH_MODELVIEW_MATRIX_NV = 0xBA6
        /// </summary>
        PathModelviewMatrixNV = 0xBA6,

        /// <summary>
        /// Original was GL_PATH_PROJECTION_MATRIX_NV = 0xBA7
        /// </summary>
        PathProjectionMatrixNV = 0xBA7,

        /// <summary>
        /// Original was GL_PATH_MAX_MODELVIEW_STACK_DEPTH_NV = 0xD36
        /// </summary>
        PathMaxModelviewStackDepthNV = 0xD36,

        /// <summary>
        /// Original was GL_PATH_MAX_PROJECTION_STACK_DEPTH_NV = 0xD38
        /// </summary>
        PathMaxProjectionStackDepthNV = 0xD38,

        /// <summary>
        /// Original was GL_C2_BYTES_NV = 0x1407
        /// </summary>
        C2BytesNV = 0x1407,

        /// <summary>
        /// Original was GL_C3_BYTES_NV = 0x1408
        /// </summary>
        C3BytesNV = 0x1408,

        /// <summary>
        /// Original was GL_C4_BYTES_NV = 0x1409
        /// </summary>
        C4BytesNV = 0x1409,

        /// <summary>
        /// Original was GL_PATH_MODELVIEW_NV = 0x1700
        /// </summary>
        PathModelviewNV = 0x1700,

        /// <summary>
        /// Original was GL_PATH_PROJECTION_NV = 0x1701
        /// </summary>
        PathProjectionNV = 0x1701,

        /// <summary>
        /// Original was GL_EYE_LINEAR_NV = 0x2400
        /// </summary>
        EyeLinearNV = 0x2400,

        /// <summary>
        /// Original was GL_OBJECT_LINEAR_NV = 0x2401
        /// </summary>
        ObjectLinearNV = 0x2401,

        /// <summary>
        /// Original was GL_PATH_TRANSPOSE_MODELVIEW_MATRIX_NV = 0x84E3
        /// </summary>
        PathTransposeModelviewMatrixNV = 0x84E3,

        /// <summary>
        /// Original was GL_PATH_TRANSPOSE_PROJECTION_MATRIX_NV = 0x84E4
        /// </summary>
        PathTransposeProjectionMatrixNV = 0x84E4,

        /// <summary>
        /// Original was GL_PRIMARY_COLOR_NV = 0x852C
        /// </summary>
        PrimaryColorNV = 0x852C,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_NV = 0x852D
        /// </summary>
        SecondaryColorNV = 0x852D,

        /// <summary>
        /// Original was GL_CONSTANT_NV = 0x8576
        /// </summary>
        ConstantNV = 0x8576,

        /// <summary>
        /// Original was GL_PATH_FORMAT_SVG_NV = 0x9070
        /// </summary>
        PathFormatSvgNV = 0x9070,

        /// <summary>
        /// Original was GL_PATH_FORMAT_PSNV = 0x9071
        /// </summary>
        PathFormatPSNV = 0x9071,

        /// <summary>
        /// Original was GL_STANDARD_FONT_NAME_NV = 0x9072
        /// </summary>
        StandardFontNameNV = 0x9072,

        /// <summary>
        /// Original was GL_SYSTEM_FONT_NAME_NV = 0x9073
        /// </summary>
        SystemFontNameNV = 0x9073,

        /// <summary>
        /// Original was GL_FILE_NAME_NV = 0x9074
        /// </summary>
        FileNameNV = 0x9074,

        /// <summary>
        /// Original was GL_PATH_STROKE_WIDTH_NV = 0x9075
        /// </summary>
        PathStrokeWidthNV = 0x9075,

        /// <summary>
        /// Original was GL_PATH_END_CAPS_NV = 0x9076
        /// </summary>
        PathEndCapsNV = 0x9076,

        /// <summary>
        /// Original was GL_PATH_INITIAL_END_CAP_NV = 0x9077
        /// </summary>
        PathInitialEndCapNV = 0x9077,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_END_CAP_NV = 0x9078
        /// </summary>
        PathTerminalEndCapNV = 0x9078,

        /// <summary>
        /// Original was GL_PATH_JOIN_STYLE_NV = 0x9079
        /// </summary>
        PathJoinStyleNV = 0x9079,

        /// <summary>
        /// Original was GL_PATH_MITER_LIMIT_NV = 0x907A
        /// </summary>
        PathMiterLimitNV = 0x907A,

        /// <summary>
        /// Original was GL_PATH_DASH_CAPS_NV = 0x907B
        /// </summary>
        PathDashCapsNV = 0x907B,

        /// <summary>
        /// Original was GL_PATH_INITIAL_DASH_CAP_NV = 0x907C
        /// </summary>
        PathInitialDashCapNV = 0x907C,

        /// <summary>
        /// Original was GL_PATH_TERMINAL_DASH_CAP_NV = 0x907D
        /// </summary>
        PathTerminalDashCapNV = 0x907D,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_NV = 0x907E
        /// </summary>
        PathDashOffsetNV = 0x907E,

        /// <summary>
        /// Original was GL_PATH_CLIENT_LENGTH_NV = 0x907F
        /// </summary>
        PathClientLengthNV = 0x907F,

        /// <summary>
        /// Original was GL_PATH_FILL_MODE_NV = 0x9080
        /// </summary>
        PathFillModeNV = 0x9080,

        /// <summary>
        /// Original was GL_PATH_FILL_MASK_NV = 0x9081
        /// </summary>
        PathFillMaskNV = 0x9081,

        /// <summary>
        /// Original was GL_PATH_FILL_COVER_MODE_NV = 0x9082
        /// </summary>
        PathFillCoverModeNV = 0x9082,

        /// <summary>
        /// Original was GL_PATH_STROKE_COVER_MODE_NV = 0x9083
        /// </summary>
        PathStrokeCoverModeNV = 0x9083,

        /// <summary>
        /// Original was GL_PATH_STROKE_MASK_NV = 0x9084
        /// </summary>
        PathStrokeMaskNV = 0x9084,

        /// <summary>
        /// Original was GL_COUNT_UP_NV = 0x9088
        /// </summary>
        CountUpNV = 0x9088,

        /// <summary>
        /// Original was GL_COUNT_DOWN_NV = 0x9089
        /// </summary>
        CountDownNV = 0x9089,

        /// <summary>
        /// Original was GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A
        /// </summary>
        PathObjectBoundingBoxNV = 0x908A,

        /// <summary>
        /// Original was GL_CONVEX_HULL_NV = 0x908B
        /// </summary>
        ConvexHullNV = 0x908B,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_NV = 0x908D
        /// </summary>
        BoundingBoxNV = 0x908D,

        /// <summary>
        /// Original was GL_TRANSLATE_XNV = 0x908E
        /// </summary>
        TranslateXNV = 0x908E,

        /// <summary>
        /// Original was GL_TRANSLATE_YNV = 0x908F
        /// </summary>
        TranslateYNV = 0x908F,

        /// <summary>
        /// Original was GL_TRANSLATE2_DNV = 0x9090
        /// </summary>
        Translate2DNV = 0x9090,

        /// <summary>
        /// Original was GL_TRANSLATE3_DNV = 0x9091
        /// </summary>
        Translate3DNV = 0x9091,

        /// <summary>
        /// Original was GL_AFFINE2_DNV = 0x9092
        /// </summary>
        Affine2DNV = 0x9092,

        /// <summary>
        /// Original was GL_AFFINE3_DNV = 0x9094
        /// </summary>
        Affine3DNV = 0x9094,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE2_DNV = 0x9096
        /// </summary>
        TransposeAffine2DNV = 0x9096,

        /// <summary>
        /// Original was GL_TRANSPOSE_AFFINE3_DNV = 0x9098
        /// </summary>
        TransposeAffine3DNV = 0x9098,

        /// <summary>
        /// Original was GL_UTF8_NV = 0x909A
        /// </summary>
        Utf8NV = 0x909A,

        /// <summary>
        /// Original was GL_UTF16_NV = 0x909B
        /// </summary>
        Utf16NV = 0x909B,

        /// <summary>
        /// Original was GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C
        /// </summary>
        BoundingBoxOfBoundingBoxesNV = 0x909C,

        /// <summary>
        /// Original was GL_PATH_COMMAND_COUNT_NV = 0x909D
        /// </summary>
        PathCommandCountNV = 0x909D,

        /// <summary>
        /// Original was GL_PATH_COORD_COUNT_NV = 0x909E
        /// </summary>
        PathCoordCountNV = 0x909E,

        /// <summary>
        /// Original was GL_PATH_DASH_ARRAY_COUNT_NV = 0x909F
        /// </summary>
        PathDashArrayCountNV = 0x909F,

        /// <summary>
        /// Original was GL_PATH_COMPUTED_LENGTH_NV = 0x90A0
        /// </summary>
        PathComputedLengthNV = 0x90A0,

        /// <summary>
        /// Original was GL_PATH_FILL_BOUNDING_BOX_NV = 0x90A1
        /// </summary>
        PathFillBoundingBoxNV = 0x90A1,

        /// <summary>
        /// Original was GL_PATH_STROKE_BOUNDING_BOX_NV = 0x90A2
        /// </summary>
        PathStrokeBoundingBoxNV = 0x90A2,

        /// <summary>
        /// Original was GL_SQUARE_NV = 0x90A3
        /// </summary>
        SquareNV = 0x90A3,

        /// <summary>
        /// Original was GL_ROUND_NV = 0x90A4
        /// </summary>
        RoundNV = 0x90A4,

        /// <summary>
        /// Original was GL_TRIANGULAR_NV = 0x90A5
        /// </summary>
        TriangularNV = 0x90A5,

        /// <summary>
        /// Original was GL_BEVEL_NV = 0x90A6
        /// </summary>
        BevelNV = 0x90A6,

        /// <summary>
        /// Original was GL_MITER_REVERT_NV = 0x90A7
        /// </summary>
        MiterRevertNV = 0x90A7,

        /// <summary>
        /// Original was GL_MITER_TRUNCATE_NV = 0x90A8
        /// </summary>
        MiterTruncateNV = 0x90A8,

        /// <summary>
        /// Original was GL_SKIP_MISSING_GLYPH_NV = 0x90A9
        /// </summary>
        SkipMissingGlyphNV = 0x90A9,

        /// <summary>
        /// Original was GL_USE_MISSING_GLYPH_NV = 0x90AA
        /// </summary>
        UseMissingGlyphNV = 0x90AA,

        /// <summary>
        /// Original was GL_PATH_ERROR_POSITION_NV = 0x90AB
        /// </summary>
        PathErrorPositionNV = 0x90AB,

        /// <summary>
        /// Original was GL_PATH_FOG_GEN_MODE_NV = 0x90AC
        /// </summary>
        PathFogGenModeNV = 0x90AC,

        /// <summary>
        /// Original was GL_ACCUM_ADJACENT_PAIRS_NV = 0x90AD
        /// </summary>
        AccumAdjacentPairsNV = 0x90AD,

        /// <summary>
        /// Original was GL_ADJACENT_PAIRS_NV = 0x90AE
        /// </summary>
        AdjacentPairsNV = 0x90AE,

        /// <summary>
        /// Original was GL_FIRST_TO_REST_NV = 0x90AF
        /// </summary>
        FirstToRestNV = 0x90AF,

        /// <summary>
        /// Original was GL_PATH_GEN_MODE_NV = 0x90B0
        /// </summary>
        PathGenModeNV = 0x90B0,

        /// <summary>
        /// Original was GL_PATH_GEN_COEFF_NV = 0x90B1
        /// </summary>
        PathGenCoeffNV = 0x90B1,

        /// <summary>
        /// Original was GL_PATH_GEN_COLOR_FORMAT_NV = 0x90B2
        /// </summary>
        PathGenColorFormatNV = 0x90B2,

        /// <summary>
        /// Original was GL_PATH_GEN_COMPONENTS_NV = 0x90B3
        /// </summary>
        PathGenComponentsNV = 0x90B3,

        /// <summary>
        /// Original was GL_PATH_DASH_OFFSET_RESET_NV = 0x90B4
        /// </summary>
        PathDashOffsetResetNV = 0x90B4,

        /// <summary>
        /// Original was GL_MOVE_TO_RESETS_NV = 0x90B5
        /// </summary>
        MoveToResetsNV = 0x90B5,

        /// <summary>
        /// Original was GL_MOVE_TO_CONTINUES_NV = 0x90B6
        /// </summary>
        MoveToContinuesNV = 0x90B6,

        /// <summary>
        /// Original was GL_PATH_STENCIL_FUNC_NV = 0x90B7
        /// </summary>
        PathStencilFuncNV = 0x90B7,

        /// <summary>
        /// Original was GL_PATH_STENCIL_REF_NV = 0x90B8
        /// </summary>
        PathStencilRefNV = 0x90B8,

        /// <summary>
        /// Original was GL_PATH_STENCIL_VALUE_MASK_NV = 0x90B9
        /// </summary>
        PathStencilValueMaskNV = 0x90B9,

        /// <summary>
        /// Original was GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD
        /// </summary>
        PathStencilDepthOffsetFactorNV = 0x90BD,

        /// <summary>
        /// Original was GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE
        /// </summary>
        PathStencilDepthOffsetUnitsNV = 0x90BE,

        /// <summary>
        /// Original was GL_PATH_COVER_DEPTH_FUNC_NV = 0x90BF
        /// </summary>
        PathCoverDepthFuncNV = 0x90BF,

        /// <summary>
        /// Original was GL_FONT_GLYPHS_AVAILABLE_NV = 0x9368
        /// </summary>
        FontGlyphsAvailableNV = 0x9368,

        /// <summary>
        /// Original was GL_FONT_TARGET_UNAVAILABLE_NV = 0x9369
        /// </summary>
        FontTargetUnavailableNV = 0x9369,

        /// <summary>
        /// Original was GL_FONT_UNAVAILABLE_NV = 0x936A
        /// </summary>
        FontUnavailableNV = 0x936A,

        /// <summary>
        /// Original was GL_FONT_UNINTELLIGIBLE_NV = 0x936B
        /// </summary>
        FontUnintelligibleNV = 0x936B,

        /// <summary>
        /// Original was GL_STANDARD_FONT_FORMAT_NV = 0x936C
        /// </summary>
        StandardFontFormatNV = 0x936C,

        /// <summary>
        /// Original was GL_FRAGMENT_INPUT_NV = 0x936D
        /// </summary>
        FragmentInputNV = 0x936D,

        /// <summary>
        /// Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x10000
        /// </summary>
        FontXMinBoundsBitNV = 0x10000,

        /// <summary>
        /// Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x20000
        /// </summary>
        FontYMinBoundsBitNV = 0x20000,

        /// <summary>
        /// Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x40000
        /// </summary>
        FontXMaxBoundsBitNV = 0x40000,

        /// <summary>
        /// Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x80000
        /// </summary>
        FontYMaxBoundsBitNV = 0x80000,

        /// <summary>
        /// Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x100000
        /// </summary>
        FontUnitsPerEMBitNV = 0x100000,

        /// <summary>
        /// Original was GL_FONT_ASCENDER_BIT_NV = 0x200000
        /// </summary>
        FontAscenderBitNV = 0x200000,

        /// <summary>
        /// Original was GL_FONT_DESCENDER_BIT_NV = 0x400000
        /// </summary>
        FontDescenderBitNV = 0x400000,

        /// <summary>
        /// Original was GL_FONT_HEIGHT_BIT_NV = 0x800000
        /// </summary>
        FontHeightBitNV = 0x800000,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x1000000
        /// </summary>
        FontMaxAdvanceWidthBitNV = 0x1000000,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x2000000
        /// </summary>
        FontMaxAdvanceHeightBitNV = 0x2000000,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x4000000
        /// </summary>
        FontUnderlinePositionBitNV = 0x4000000,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x8000000
        /// </summary>
        FontUnderlineThicknessBitNV = 0x8000000,

        /// <summary>
        /// Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        /// </summary>
        FontHasKerningBitNV = 0x10000000,

        /// <summary>
        /// Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        /// </summary>
        FontNumGlyphIndicesBitNV = 0x20000000
    }
}
