#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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
#endregion

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
