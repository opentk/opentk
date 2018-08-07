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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Used in GL.NV.GetPathMetricRange and GL.NV.GetPathMetric.
    /// </summary>
    [Flags]
    public enum PathMetricMask
    {
        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x1
        /// </summary>
        GlyphWidthBitNV = 0x1,

        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x2
        /// </summary>
        GlyphHeightBitNV = 0x2,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x4
        /// </summary>
        GlyphHorizontalBearingXBitNV = 0x4,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x8
        /// </summary>
        GlyphHorizontalBearingYBitNV = 0x8,

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNV = 0x10,

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
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNV = 0x100,

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
