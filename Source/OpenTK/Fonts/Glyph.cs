#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Fonts
{
    /// <summary>
    /// Represents a single character of a specific Font.
    /// </summary>
    class Glyph : IPackable<Glyph>
    {
        char character;
        Font font;
        int width;
        static Bitmap bmp = new Bitmap(1, 1);
        object obj = new object();

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new Glyph that represents the given character and Font.
        /// </summary>
        /// <param name="c">The character to represent.</param>
        /// <param name="f">The Font of the character.</param>
        public Glyph(char c, Font f)
        {
            if (f == null)
                throw new ArgumentNullException("f", "You must specify a valid font");
            character = c;
            font = f;
        }

        #endregion

        #region public char Character

        /// <summary>
        /// Gets the character represented by this Glyph.
        /// </summary>
        public char Character
        {
            get { return character; }
            private set { character = value; }
        }

        #endregion

        #region public Font Font

        /// <summary>
        ///  Gets the Font of this Glyph.
        /// </summary>
        public Font Font
        {
            get { return font; }
            private set
            {
                if (value == null)
                    throw new ArgumentNullException("Font", "Glyph font cannot be null");

                font = value;
            }
        }

        #endregion

        #region IPackable<T> Members

        /// <summary>
        /// Gets an integer representing the width of the Glyph in pixels.
        /// </summary>
        public int Width
        {
            get
            {
                if (width == 0)
                {
                    lock (obj)
                    using (Graphics gfx = Graphics.FromImage(bmp))
                    {
                        float w = gfx.MeasureString(Character.ToString(), font).Width;
                        width = (int)System.Math.Ceiling(w);
                    }
                }

                return width;
            }
        }

        /// <summary>
        /// Gets an integer representing the height of the Glyph in pixels.
        /// </summary>
        public int Height
        {
            get
            {
                return font.Height;
            }
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj is Glyph)
                return this.Equals((Glyph)obj);
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return String.Format("'{0}', {1} {2}, {3} {4}", Character, Font.Name, font.Style, font.Size, font.Unit);
        }

        public override int GetHashCode()
        {
            return character.GetHashCode() ^ font.Style.GetHashCode() ^ font.Size.GetHashCode() ^ font.Unit.GetHashCode();
        }

        #region IEquatable<Glyph> Members

        /// <summary>
        /// Compares the current Glyph with the given Glyph.
        /// </summary>
        /// <param name="other">The Glyph to compare to.</param>
        /// <returns>True if both Glyphs represent the same character of the same Font, false otherwise.</returns>
        public bool Equals(Glyph other)
        {
            return Character == other.Character && Font == other.Font;
        }

        #endregion
    }
}
