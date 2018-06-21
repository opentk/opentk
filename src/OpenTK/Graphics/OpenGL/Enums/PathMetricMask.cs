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
    /// Used in GL.NV.GetPathMetricRange, GL.NV.GetPathMetric
    /// </summary>
    [Flags]
    public enum PathMetricMask
    {
        /// <summary>
        /// Original was GL_FONT_X_MIN_BOUNDS_BIT_NV = 0x00010000
        /// </summary>
        FontXMinBoundsBitNv = ((int)0x00010000),

        /// <summary>
        /// Original was GL_FONT_Y_MIN_BOUNDS_BIT_NV = 0x00020000
        /// </summary>
        FontYMinBoundsBitNv = ((int)0x00020000),

        /// <summary>
        /// Original was GL_FONT_X_MAX_BOUNDS_BIT_NV = 0x00040000
        /// </summary>
        FontXMaxBoundsBitNv = ((int)0x00040000),

        /// <summary>
        /// Original was GL_FONT_Y_MAX_BOUNDS_BIT_NV = 0x00080000
        /// </summary>
        FontYMaxBoundsBitNv = ((int)0x00080000),

        /// <summary>
        /// Original was GL_FONT_UNITS_PER_EM_BIT_NV = 0x00100000
        /// </summary>
        FontUnitsPerEmBitNv = ((int)0x00100000),

        /// <summary>
        /// Original was GL_FONT_ASCENDER_BIT_NV = 0x00200000
        /// </summary>
        FontAscenderBitNv = ((int)0x00200000),

        /// <summary>
        /// Original was GL_FONT_DESCENDER_BIT_NV = 0x00400000
        /// </summary>
        FontDescenderBitNv = ((int)0x00400000),

        /// <summary>
        /// Original was GL_FONT_HEIGHT_BIT_NV = 0x00800000
        /// </summary>
        FontHeightBitNv = ((int)0x00800000),

        /// <summary>
        /// Original was GL_GLYPH_WIDTH_BIT_NV = 0x01
        /// </summary>
        GlyphWidthBitNv = 0x01,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV = 0x01000000
        /// </summary>
        FontMaxAdvanceWidthBitNv = ((int)0x01000000),

        /// <summary>
        /// Original was GL_GLYPH_HEIGHT_BIT_NV = 0x02
        /// </summary>
        GlyphHeightBitNv = 0x02,

        /// <summary>
        /// Original was GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV = 0x02000000
        /// </summary>
        FontMaxAdvanceHeightBitNv = ((int)0x02000000),

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04
        /// </summary>
        GlyphHorizontalBearingXBitNv = 0x04,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_POSITION_BIT_NV = 0x04000000
        /// </summary>
        FontUnderlinePositionBitNv = ((int)0x04000000),

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08
        /// </summary>
        GlyphHorizontalBearingYBitNv = 0x08,

        /// <summary>
        /// Original was GL_FONT_UNDERLINE_THICKNESS_BIT_NV = 0x08000000
        /// </summary>
        FontUnderlineThicknessBitNv = ((int)0x08000000),

        /// <summary>
        /// Original was GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10
        /// </summary>
        GlyphHorizontalBearingAdvanceBitNv = 0x10,

        /// <summary>
        /// Original was GL_GLYPH_HAS_KERNING_BIT_NV = 0x100
        /// </summary>
        GlyphHasKerningBitNv = 0x100,

        /// <summary>
        /// Original was GL_FONT_HAS_KERNING_BIT_NV = 0x10000000
        /// </summary>
        FontHasKerningBitNv = ((int)0x10000000),

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20
        /// </summary>
        GlyphVerticalBearingXBitNv = 0x20,

        /// <summary>
        /// Original was GL_FONT_NUM_GLYPH_INDICES_BIT_NV = 0x20000000
        /// </summary>
        FontNumGlyphIndicesBitNv = ((int)0x20000000),

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40
        /// </summary>
        GlyphVerticalBearingYBitNv = 0x40,

        /// <summary>
        /// Original was GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80
        /// </summary>
        GlyphVerticalBearingAdvanceBitNv = 0x80
    }
}
