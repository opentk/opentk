#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    /// <summary>Defines the ColorFormat component of a GraphicsMode.</summary>
    /// <remarks>
    /// <para>A ColorFormat contains Red, Green, Blue and Alpha components that descibe
    /// the allocated bits per pixel for the corresponding color.</para>
    /// </remarks>
    public struct ColorFormat
    {
        byte red, green, blue, alpha;
        bool isIndexed;
        int bitsPerPixel;

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new ColorFormat with the specified aggregate bits per pixel.
        /// </summary>
        /// <param name="bpp">The bits per pixel sum for the Red, Green, Blue and Alpha color channels.</param>
        public ColorFormat(int bpp)
        {
            if (bpp < 0)
                throw new ArgumentOutOfRangeException("bpp", "Must be greater or equal to zero.");
            red = green = blue = alpha = 0;
            bitsPerPixel = bpp;
            isIndexed = false;

            switch (bpp)
            {
                case 32:
                    Red = Green = Blue = Alpha = 8;
                    break;
                case 24:
                    Red = Green = Blue = 8;
                    break;
                case 16:
                    Red = Blue = 5;
                    Green = 6;
                    break;
                case 15:
                    Red = Green = Blue = 5;
                    break;
                case 8:
                    Red = Green = 3;
                    Blue = 2;
                    IsIndexed = true;
                    break;
                case 4:
                    Red = Green = 2;
                    Blue = 1;
                    IsIndexed = true;
                    break;
                case 1:
                    IsIndexed = true;
                    break;
                default:
                    Red = Blue = Alpha = (byte)(bpp / 4);
                    Green = (byte)((bpp / 4) + (bpp % 4));
                    break;
            }
        }

        /// <summary>
        /// Constructs a new ColorFormat with the specified bits per pixel for 
        /// the Red, Green, Blue and Alpha color channels.
        /// </summary>
        /// <param name="red">Bits per pixel for the Red color channel.</param>
        /// <param name="green">Bits per pixel for the Green color channel.</param>
        /// <param name="blue">Bits per pixel for the Blue color channel.</param>
        /// <param name="alpha">Bits per pixel for the Alpha color channel.</param>
        public ColorFormat(int red, int green, int blue, int alpha)
        {
            if (red < 0 || green < 0 || blue < 0 || alpha < 0)
                throw new ArgumentOutOfRangeException("Arguments must be greater or equal to zero.");
            this.red = (byte)red;
            this.green = (byte)green;
            this.blue = (byte)blue;
            this.alpha = (byte)alpha;
            this.bitsPerPixel = red + green + blue + alpha;
            this.isIndexed = false;
            if (this.bitsPerPixel < 15 && this.bitsPerPixel != 0)
                this.isIndexed = true;
        }

        #endregion

        #region --- Public Methods ---

        /// <summary>Gets the bits per pixel for the Red channel.</summary>
        public int Red { get { return red; } private set { red = (byte)value; } }
        /// <summary>Gets the bits per pixel for the Green channel.</summary>
        public int Green { get { return green; } private set { green = (byte)value; } }
        /// <summary>Gets the bits per pixel for the Blue channel.</summary>
        public int Blue { get { return blue; } private set { blue = (byte)value; } }
        /// <summary>Gets the bits per pixel for the Alpha channel.</summary>
        public int Alpha { get { return alpha; } private set { alpha = (byte)value; } }
        /// <summary>Gets a System.Boolean indicating whether this ColorFormat is indexed.</summary>
        public bool IsIndexed { get { return isIndexed; } private set { isIndexed = value; } }
        /// <summary>Gets the sum of Red, Green, Blue and Alpha bits per pixel.</summary>
        public int BitsPerPixel { get { return bitsPerPixel; } private set { bitsPerPixel = value; } }

        #endregion

        #region --- Operator Overloads ---

        /// <summary>
        /// Converts the specified bpp into a new ColorFormat.
        /// </summary>
        /// <param name="bpp">The bits per pixel to convert.</param>
        /// <returns>A ColorFormat with the specified bits per pixel.</returns>
        public static implicit operator ColorFormat(int bpp)
        {
            return new ColorFormat(bpp);
        }

        //public static implicit operator int(ColorFormat mode)
        //{
        //    return mode.BitsPerPixel;
        //}

        #endregion

        #region --- Overrides ---

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns>True if this instance is equal to obj; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            return (obj is ColorFormat) ? (this == (ColorFormat)obj) : false;
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(ColorFormat left, ColorFormat right)
        {
            if ((object)left == (object)null && (object)right != (object)null ||
                (object)left != (object)null && (object)right == (object)null)
                return false;

            if ((object)left == (object)null && (object)right == (object)null)
                return true;

            return left.Red == right.Red &&
                   left.Green == right.Green &&
                   left.Blue == right.Blue &&
                   left.Alpha == right.Alpha;
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(ColorFormat left, ColorFormat right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A System.Int32 with the hash code of this instance.</returns>
        public override int GetHashCode()
        {
            return Red ^ Green ^ Blue ^ Alpha;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1})", BitsPerPixel, (IsIndexed ? " indexed" : Red.ToString() + Green.ToString() + Blue.ToString() + Alpha.ToString()));
        }

        #endregion
    }
}
