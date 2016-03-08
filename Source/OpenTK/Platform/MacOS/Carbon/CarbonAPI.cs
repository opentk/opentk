// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
//  Created by Erik Ylvisaker on 3/17/08.


using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS.Carbon
{
    #region --- Types defined in HIGeometry.h ---

    [StructLayout(LayoutKind.Sequential)]
    internal struct HIPoint
    {
        public float X;
        public float Y;

        public HIPoint(float x, float y)
        {
            X = x;
            Y = y;
        }

        public HIPoint(double x, double y)
            : this((float)x, (float)y)
        { }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct HISize
    {
        public float Width;
        public float Height;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct HIRect
    {
        public HIPoint Origin;
        public HISize Size;

        public override string ToString()
        {
            return string.Format(
                "Rect: [{0}, {1}, {2}, {3}]", Origin.X, Origin.Y, Size.Width, Size.Height);
        }
    }

    #endregion
}


