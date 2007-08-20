#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Drawing;
using System.Globalization;

namespace OpenTK.Platform
{
    public class ColorDepth
    {
        public byte Red, Green, Blue, Alpha;
        public bool IsIndexed = false;
        public int BitsPerPixel;
        
        public ColorDepth(int bpp)
        {
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
                    IsIndexed = true;
                    break;
                case 4:
                    IsIndexed = true;
                    break;
                default:
                    break;
            }
        }

        public ColorDepth(int red, int green, int blue, int alpha)
        {
            Red = (byte)red;
            Green = (byte)green;
            Blue = (byte)blue;
            Alpha = (byte)alpha;
            BitsPerPixel = red + green + blue + alpha;
        }

        public override bool Equals(object obj)
        {
            return (obj is ColorDepth) ? (this == (ColorDepth)obj) : false;
        }

        public static bool operator ==(ColorDepth left, ColorDepth right)
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

        public static bool operator !=(ColorDepth left, ColorDepth right)
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
    }
}
