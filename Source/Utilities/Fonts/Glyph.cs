#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics
{
    using Graphics = System.Drawing.Graphics;

    /// <summary>
    /// Represents a single character of a specific Font.
    /// </summary>
    [Obsolete]
    struct Glyph : IPackable<Glyph>
    {
        char character;
        Font font;
        SizeF size;

        #region --- Constructors ---

        // Constructs a new Glyph that represents the given character and Font.
        public Glyph(char c, Font f, SizeF s)
        {
            if (f == null)
                throw new ArgumentNullException("f", "You must specify a valid font");
            character = c;
            font = f;
            size = s;
        }

        #endregion

        #region --- Public Methods ---

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

        #region public override bool Equals(object obj)

        /// <summary>
        /// Checks whether the given object is equal (memberwise) to the current Glyph.
        /// </summary>
        /// <param name="obj">The obj to check.</param>
        /// <returns>True, if the object is identical to the current Glyph.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Glyph)
                return this.Equals((Glyph)obj);
            return base.Equals(obj);
        }

        #endregion

        #region public override string ToString()

        /// <summary>
        /// Describes this Glyph object.
        /// </summary>
        /// <returns>Returns a System.String describing this Glyph.</returns>
        public override string ToString()
        {
            return String.Format("'{0}', {1} {2}, {3} {4}, ({5}, {6})", Character, Font.Name, font.Style, font.Size, font.Unit, Width, Height);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Calculates the hashcode for this Glyph.
        /// </summary>
        /// <returns>A System.Int32 containing a hashcode that uniquely identifies this Glyph.</returns>
        public override int GetHashCode()
        {
            return character.GetHashCode() ^ font.GetHashCode() ^ size.GetHashCode();
        }

        #endregion

        #region public SizeF Size

        /// <summary>
        /// Gets the size of this Glyph.
        /// </summary>
        public SizeF Size { get { return size; } }

        #endregion

        #region public RectangleF Rectangle

        /// <summary>
        /// Gets the bounding box of this Glyph.
        /// </summary>
        public RectangleF Rectangle { get { return new RectangleF(PointF.Empty, Size); } }

        #endregion

        #endregion

        #region --- IPackable<T> Members ---

        /// <summary>
        /// Gets an integer representing the width of the Glyph in pixels.
        /// </summary>
        public int Width
        {
            get
            {
                return (int)System.Math.Ceiling(size.Width);
            }
        }

        /// <summary>
        /// Gets an integer representing the height of the Glyph in pixels.
        /// </summary>
        public int Height
        {
            get
            {
                return (int)System.Math.Ceiling(size.Height);
            }
        }

        #endregion

        #region --- IEquatable<Glyph> Members ---

        /// <summary>
        /// Compares the current Glyph with the given Glyph.
        /// </summary>
        /// <param name="other">The Glyph to compare to.</param>
        /// <returns>True if both Glyphs represent the same character of the same Font, false otherwise.</returns>
        public bool Equals(Glyph other)
        {
            return Character == other.Character && Font == other.Font && Size == other.Size;
        }

        #endregion
    }
}
