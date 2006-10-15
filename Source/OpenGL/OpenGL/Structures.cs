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
        public ColorDepth(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public byte Red, Green, Blue, Alpha;
    }

    #endregion
}