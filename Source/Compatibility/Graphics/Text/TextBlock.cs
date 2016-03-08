// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    // Uniquely identifies a block of text. This structure can be used to identify text blocks for caching.
    struct TextBlock : IEquatable<TextBlock>, IEnumerable<Glyph>
    {
        #region Fields

        public readonly string Text;

        public readonly Font Font;

        public readonly RectangleF Bounds;

        public readonly TextPrinterOptions Options;

        public readonly TextAlignment Alignment;

        public readonly TextDirection Direction;

        public readonly int UsageCount;

        #endregion

        #region Constructors

        public TextBlock(string text, Font font, RectangleF bounds, TextPrinterOptions options, TextAlignment alignment, TextDirection direction)
        {
            Text = text;
            Font = font;
            Bounds = bounds;
            Options = options;
            Alignment = alignment;
            Direction = direction;
            UsageCount = 0;
        }

        #endregion

        #region Public Members

        public override bool Equals(object obj)
        {
            if (!(obj is TextBlock))
                return false;

            return Equals((TextBlock)obj);
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode() ^ Font.GetHashCode() ^ Bounds.GetHashCode() ^ Options.GetHashCode();
        }

        public Glyph this[int i]
        {
            get { return new Glyph(Text[i], Font); }
        }

        #endregion

        #region IEquatable<TextBlock> Members

        public bool Equals(TextBlock other)
        {
            return
                Text == other.Text &&
                Font == other.Font &&
                Bounds == other.Bounds &&
                Options == other.Options;
        }

        #endregion

        #region IEnumerable<Glyph> Members

        public IEnumerator<Glyph> GetEnumerator()
        {
            return new GlyphEnumerator(Text, Font);
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new GlyphEnumerator(Text, Font);
        }

        #endregion
    }
}
