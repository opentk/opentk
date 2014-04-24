#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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


