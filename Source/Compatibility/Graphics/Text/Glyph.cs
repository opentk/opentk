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
    struct Glyph : IEquatable<Glyph>
    {
        char character;
        Font font;

        #region Constructors

        /// <summary>
        /// Constructs a new Glyph that represents the given character and Font.
        /// </summary>
        /// <param name="c">The character to represent.</param>
        /// <param name="font">The Font of the character.</param>
        public Glyph(char c, Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font");
            character = c;
            this.font = font;
        }

        #endregion

        #region Public Methods 
        
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

        #region public bool IsWhiteSpace

        public bool IsWhiteSpace
        {
            get { return Char.IsWhiteSpace(Character); }
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
