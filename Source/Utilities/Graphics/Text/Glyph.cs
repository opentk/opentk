using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    struct Glyph : IEquatable<Glyph>
    {
        char character;
        Font font;

        #region Constructors

        /// <summary>
        /// Constructs a new Glyph that represents the given character and Font.
        /// </summary>
        /// <param name="c">The character to represent.</param>
        /// <param name="f">The Font of the character.</param>
        public Glyph(char c, Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font");
            character = c;
            this.font = font;
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
            return String.Format("'{0}', {1} {2}, {3} {4}", Character, Font.Name, font.Style, font.Size, font.Unit);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Calculates the hashcode for this Glyph.
        /// </summary>
        /// <returns>A System.Int32 containing a hashcode that uniquely identifies this Glyph.</returns>
        public override int GetHashCode()
        {
            return character.GetHashCode() ^ font.GetHashCode();
        }

        #endregion

        #endregion

        #region IEquatable<Glyph> Members

        public bool Equals(Glyph other)
        {
            return Character == other.Character && Font == other.Font;
        }

        #endregion
    }
}
