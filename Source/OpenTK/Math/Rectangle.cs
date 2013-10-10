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
#if NO_SYSDRAWING
    /// <summary>
    /// Represents a rectangular region on a two-dimensional plane.
    /// </summary>
    public struct Rectangle : IEquatable<Rectangle>
    {
        #region Fields

        Point location;
        Size size;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Rectangle instance.
        /// </summary>
        /// <param name="location">The top-left corner of the Rectangle.</param>
        /// <param name="size">The width and height of the Rectangle.</param>
        public Rectangle(Point location, Size size)
            : this()
        {
            Location = location;
            Size = size;
        }
        
        /// <summary>
        /// Constructs a new Rectangle instance.
        /// </summary>
        /// <param name="x">The x coordinate of the Rectangle.</param>
        /// <param name="y">The y coordinate of the Rectangle.</param>
        /// <param name="width">The width coordinate of the Rectangle.</param>
        /// <param name="height">The height coordinate of the Rectangle.</param>
        public Rectangle(int x, int y, int width, int height)
            : this(new Point(x, y), new Size(width, height))
        { }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets or sets the x coordinate of the Rectangle.
        /// </summary>
        public int X
        {
            get { return Location.X; }
            set { Location = new Point (value, Y); }
        }

        /// <summary>
        /// Gets or sets the y coordinate of the Rectangle.
        /// </summary>
        public int Y
        {
            get { return Location.Y; }
            set { Location = new Point (X, value); }
        }

        /// <summary>
        /// Gets or sets the width of the Rectangle.
        /// </summary>
        public int Width
        { 
            get { return Size.Width; }
            set { Size = new Size (value, Height); }
        }

        /// <summary>
        /// Gets or sets the height of the Rectangle.
        /// </summary>
        public int Height
        {
            get { return Size.Height; }
            set { Size = new Size(Width, value); }
        }

        /// <summary>
        /// Gets or sets a <see cref="Point"/> representing the x and y coordinates
        /// of the Rectangle.
        /// </summary>
        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// Gets or sets a <see cref="Size"/> representing the width and height
        /// of the Rectangle.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Gets the y coordinate of the top edge of this Rectangle.
        /// </summary>
        public int Top { get { return Y; } }

        /// <summary>
        /// Gets the x coordinate of the right edge of this Rectangle.
        /// </summary>
        public int Right { get { return X + Width; } }

        /// <summary>
        /// Gets the y coordinate of the bottom edge of this Rectangle.
        /// </summary>
        public int Bottom { get { return Y + Height; } }

        /// <summary>
        /// Gets the x coordinate of the left edge of this Rectangle.
        /// </summary>
        public int Left { get { return X; } }

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> that indicates whether this
        /// Rectangle is equal to the empty Rectangle.
        /// </summary>
        public bool IsEmpty 
        {
            get { return Location.IsEmpty && Size.IsEmpty; }
        }

        /// <summary>
        /// Defines the empty Rectangle.
        /// </summary>
        public static readonly Rectangle Zero = new Rectangle();

        /// <summary>
        /// Defines the empty Rectangle.
        /// </summary>
        public static readonly Rectangle Empty = new Rectangle();

        /// <summary>
        /// Constructs a new instance with the specified edges.
        /// </summary>
        /// <param name="left">The left edge of the Rectangle.</param>
        /// <param name="top">The top edge of the Rectangle.</param>
        /// <param name="right">The right edge of the Rectangle.</param>
        /// <param name="bottom">The bottom edge of the Rectangle.</param>
        /// <returns>A new Rectangle instance with the specified edges.</returns>
        public static Rectangle FromLTRB(int left, int top, int right, int bottom)
        {
            return new Rectangle(new Point(left, top), new Size(right - left, bottom - top));
        }

        /// <summary>
        /// Tests whether this instance contains the specified Point.
        /// </summary>
        /// <param name="point">The <see cref="Point"/> to test.</param>
        /// <returns>True if this instance contains point; false otherwise.</returns>
        /// <remarks>The left and top edges are inclusive. The right and bottom edges
        /// are exclusive.</remarks>
        public bool Contains(Point point)
        {
            return point.X >= Left && point.X < Right && 
                point.Y >= Top && point.Y < Bottom;
        }

        /// <summary>
        /// Tests whether this instance contains the specified Rectangle.
        /// </summary>
        /// <param name="rect">The <see cref="Rectangle"/> to test.</param>
        /// <returns>True if this instance contains rect; false otherwise.</returns>
        /// <remarks>The left and top edges are inclusive. The right and bottom edges
        /// are exclusive.</remarks>
        public bool Contains(Rectangle rect)
        {
            return Contains(rect.Location) && Contains(rect.Location + rect.Size);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is equal to right; false otherwise.</returns>
        public static bool operator ==(Rectangle left, Rectangle right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(Rectangle left, Rectangle right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Converts an OpenTK.Rectangle instance to a System.Drawing.Rectangle.
        /// </summary>
        /// <param name="rect">
        /// The <see cref="Rectangle"/> instance to convert.
        /// </param>
        /// <returns>
        /// A <see cref="System.Drawing.Rectangle"/> instance equivalent to rect.
        /// </returns>
        public static implicit operator System.Drawing.Rectangle(Rectangle rect)
        {
            return new System.Drawing.Rectangle(rect.Location, rect.Size);
        }

        /// <summary>
        /// Converts a System.Drawing.Rectangle instance to an OpenTK.Rectangle.
        /// </summary>
        /// <param name="rect">
        /// The <see cref="System.Drawing.Rectangle"/> instance to convert.
        /// </param>
        /// <returns>
        /// A <see cref="Rectangle"/> instance equivalent to point.
        /// </returns>
        public static implicit operator Rectangle(System.Drawing.Rectangle rect)
        {
            return new Rectangle(rect.Location, rect.Size);
        }

        /// <summary>
        /// Converts an OpenTK.Rectangle instance to a System.Drawing.RectangleF.
        /// </summary>
        /// <param name="rect">
        /// The <see cref="Rectangle"/> instance to convert.
        /// </param>
        /// <returns>
        /// A <see cref="System.Drawing.RectangleF"/> instance equivalent to rect.
        /// </returns>
        public static implicit operator System.Drawing.RectangleF(Rectangle rect)
        {
            return new System.Drawing.RectangleF(rect.Location, rect.Size);
        }

        /// <summary>
        /// Indicates whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Rectangle)
                return Equals((Rectangle)obj);

            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A <see cref="System.Int32"/> that represents the hash code for this instance./></returns>
        public override int GetHashCode()
        {
            return Location.GetHashCode() & Size.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return String.Format("{{{0}-{1}}}", Location, Location + Size);
        }


        #endregion

        #region IEquatable<Rectangle> Members

        /// <summary>
        /// Indicates whether this instance is equal to the specified Rectangle.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(Rectangle other)
        {
            return Location.Equals(other.Location) &&
                Size.Equals(other.Size);
        }

        #endregion
    }
#endif
}
