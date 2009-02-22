#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Globalization;

namespace OpenTK
{
    /// <summary>Defines a color mode for OpenGL rendering.</summary>
    /// <remarks>
    /// <para>A ColorMode contains Red, Green, Blue and Alpha components that descibe
    /// the allocated bits per pixel for the corresponding color.</para>
    /// </remarks>
    [Obsolete("Use OpenTK.Graphics.ColorFormat instead.")]
    public sealed class ColorMode
    {
        byte red, green, blue, alpha;
        bool isIndexed = false;
        int bitsPerPixel;

        #region --- Constructors ---

        /// <summary>
        /// Constructs a new ColorMode with the specified aggregate bits per pixel.
        /// </summary>
        /// <param name="bpp">The bits per pixel sum for the Red, Green, Blue and Alpha color channels.</param>
        public ColorMode(int bpp)
        {
            if (bpp < 0)
                throw new ArgumentOutOfRangeException("bpp", "Must be greater or equal to zero.");
            Red = Green = Blue = Alpha = 0;
            BitsPerPixel = bpp;

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
        /// Constructs a new ColorMode with the specified bits per pixel for 
        /// the Red, Green, Blue and Alpha color channels.
        /// </summary>
        /// <param name="red">Bits per pixel for the Red color channel.</param>
        /// <param name="green">Bits per pixel for the Green color channel.</param>
        /// <param name="blue">Bits per pixel for the Blue color channel.</param>
        /// <param name="alpha">Bits per pixel for the Alpha color channel.</param>
        public ColorMode(int red, int green, int blue, int alpha)
        {
            if (red < 0 || green < 0 || blue < 0 || alpha < 0)
                throw new ArgumentOutOfRangeException("Arguments must be greater or equal to zero.");
            Red = (byte)red;
            Green = (byte)green;
            Blue = (byte)blue;
            Alpha = (byte)alpha;
            BitsPerPixel = red + green + blue + alpha;
            if (BitsPerPixel < 15)
                IsIndexed = true;
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
        /// <summary>Gets a System.Boolean indicating whether this ColorMode is indexed.</summary>
        public bool IsIndexed { get { return isIndexed; } private set { isIndexed = value; } }
        /// <summary>Gets the sum of Red, Green, Blue and Alpha bits per pixel.</summary>
        public int BitsPerPixel { get { return bitsPerPixel; } private set { bitsPerPixel = value; } }

        #endregion

        #region --- Operator Overloads ---

        /// <summary>
        /// Converts the specified bpp into a new ColorMode.
        /// </summary>
        /// <param name="bpp">The bits per pixel to convert.</param>
        /// <returns>A ColorMode with the specified bits per pixel.</returns>
        public static implicit operator ColorMode(int bpp)
        {
            return new ColorMode(bpp);
        }

        //public static implicit operator int(ColorMode mode)
        //{
        //    return mode.BitsPerPixel;
        //}

        #endregion

        #region --- Overrides ---

        public override bool Equals(object obj)
        {
            return (obj is ColorMode) ? (this == (ColorMode)obj) : false;
        }

        public static bool operator ==(ColorMode left, ColorMode right)
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

        public static bool operator !=(ColorMode left, ColorMode right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return Red ^ Green ^ Blue ^ Alpha;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", BitsPerPixel, (IsIndexed ? " indexed" : Red.ToString() + Green.ToString() + Blue.ToString() + Alpha.ToString()));
        }

        #endregion
    }
}
