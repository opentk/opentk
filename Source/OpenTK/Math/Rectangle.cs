#region License
 //
 // The Open Toolkit Library License
 //
 // Copyright (c) 2006 - 2009 the Open Toolkit library.
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

namespace OpenTK
{
#if EXPERIMENTAL

    public struct Rectangle : IEquatable<Rectangle>
    {
        #region Fields

        public int X;

        public int Y;

        public int Width;

        public int Height;

        public static readonly Rectangle Empty = new Rectangle();

        #endregion

        #region Constructors

        public Rectangle(Point location, Size size)
            : this()
        {
            Location = location;
            Size = size;
        }
        
        public Rectangle(int x, int y, int width, int height)
            : this(new Point(x, y), new Size(width, height))
        { }

        #endregion

        #region Public Members

        public Point Location
        {
            get { return new Point(X, Y); }
            set { X = value.X; Y = value.Y; }
        }

        public Size Size
        {
            get { return new Size(Width, Height); }
            set { Width = value.Width; Height = value.Height; }
        }

        public int Top { get { return Y; } }
        public int Right { get { return X + Width; } }
        public int Bottom { get { return Y + Height; } }
        public int Left { get { return X; } }

        public bool IsEmpty
        {
            get { return X == 0 && Y == 0 && Width == 0 && Height == 0; }
        }

        public static Rectangle FromLTRB(int left, int top, int right, int bottom)
        {
            return new Rectangle(new Point(left, top), new Size(right - left, bottom - top));
        }

        public bool Contains(Point point)
        {
            return point.X >= Left && point.X < Right &&
                point.Y >= Top && point.Y < Bottom;
        }

        public static bool operator ==(Rectangle left, Rectangle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Rectangle left, Rectangle right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region IEquatable<Rectangle> Members

        public bool Equals(Rectangle other)
        {
            return Location.Equals(other.Location) &&
                Size.Equals(other.Size);
        }

        #endregion
    }

#endif
}
