using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    // Uniquely identifies a block of text. This structure can be used to identify text blocks for caching.
    struct TextBlock : IEquatable<TextBlock>
    {
        #region Fields

        public readonly string Text;

        public readonly Font Font;

        public readonly RectangleF LayoutRectangle;

        public readonly TextPrinterOptions Options;

        public int UsageCount;     // Used to identify old and unused blocks of text.

        #endregion

        #region Constructors

        public TextBlock(string text, Font font, TextPrinterOptions options, RectangleF layoutRectangle)
        {
            Text = text;
            Font = font;
            LayoutRectangle = layoutRectangle;
            Options = options;
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
            return Text.GetHashCode() ^ Font.GetHashCode() ^ LayoutRectangle.GetHashCode() ^ Options.GetHashCode();
        }

        #endregion

        #region IEquatable<TextBlock> Members

        public bool Equals(TextBlock other)
        {
            return
                Text == other.Text &&
                Font == other.Font &&
                LayoutRectangle == other.LayoutRectangle &&
                Options == other.Options;
        }

        #endregion
    }
}
