#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;

namespace OpenTK.OpenGL
{
    #region ColorDepth struct

    public struct ColorDepth
    {
        public ColorDepth(int bpp)
        {
            Red = Green = Blue = Alpha = 0;

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
            }
        }

        public ColorDepth(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public byte Red, Green, Blue, Alpha;

        public static bool operator ==(ColorDepth left, ColorDepth right)
        {
            return left.Red == right.Red &&
                   left.Green == right.Green &&
                   left.Blue == right.Blue &&
                   left.Alpha == right.Alpha;
        }

        public static bool operator !=(ColorDepth left, ColorDepth right)
        {
            return !(left == right);
        }
    }

    #endregion
}