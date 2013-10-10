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
    /// Defines a point on a two-dimensional plane.
    /// </summary>
    public struct Point : IEquatable<Point>
    {
        #region Fields

        int x, y;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Point instance.
        /// </summary>
        /// <param name="x">The X coordinate of this instance.</param>
        /// <param name="y">The Y coordinate of this instance.</param>
        public Point(int x, int y)
            : this()
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Gets a <see cref="System.Boolean"/> that indicates whether this instance is empty or zero.
        /// </summary>
        public bool IsEmpty { get { return X == 0 && Y == 0; } }

        /// <summary>
        /// Gets or sets the X coordinate of this instance.
        /// </summary>
        public int X { get { return x; } set { x = value; } }

        /// <summary>
        /// Gets or sets the Y coordinate of this instance.
        /// </summary>
        public int Y { get { return y; } set { y = value; } }

        /// <summary>
        /// Returns the Point (0, 0).
        /// </summary>
        public static readonly Point Zero = new Point();

        /// <summary>
        /// Returns the Point (0, 0).
        /// </summary>
        public static readonly Point Empty = new Point();

        /// <summary>
        /// Translates the specified Point by the specified Size.
        /// </summary>
        /// <param name="point">
        /// The <see cref="Point"/> instance to translate.
        /// </param>
        /// <param name="size">
        /// The <see cref="Size"/> instance to translate point with.
        /// </param>
        /// <returns>
        /// A new <see cref="Point"/> instance translated by size.
        /// </returns>
        public static Point operator +(Point point, Size size)
        {
            return new Point(point.X + size.Width, point.Y + size.Height);
        }

        /// <summary>
        /// Translates the specified Point by the negative of the specified Size.
        /// </summary>
        /// <param name="point">
        /// The <see cref="Point"/> instance to translate.
        /// </param>
        /// <param name="size">
        /// The <see cref="Size"/> instance to translate point with.
        /// </param>
        /// <returns>
        /// A new <see cref="Point"/> instance translated by size.
        /// </returns>
        public static Point operator -(Point point, Size size)
        {
            return new Point(point.X - size.Width, point.Y - size.Height);
          }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is equal to right; false otherwise.</returns>
        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(Point left, Point right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Converts an OpenTK.Point instance to a System.Drawing.Point.
        /// </summary>
        /// <param name="point">
        /// The <see cref="Point"/> instance to convert.
        /// </param>
        /// <returns>
        /// A <see cref="System.Drawing.Point"/> instance equivalent to point.
        /// </returns>
        public static implicit operator System.Drawing.Point(Point point)
        {
            return new System.Drawing.Point(point.X, point.Y);
        }

        /// <summary>
        /// Converts a System.Drawing.Point instance to an OpenTK.Point.
        /// </summary>
        /// <param name="point">
        /// The <see cref="System.Drawing.Point"/> instance to convert.
        /// </param>
        /// <returns>
        /// A <see cref="Point"/> instance equivalent to point.
        /// </returns>
        public static implicit operator Point(System.Drawing.Point point)
        {
            return new Point(point.X, point.Y);
        }

        /// <summary>
        /// Converts an OpenTK.Point instance to a System.Drawing.PointF.
        /// </summary>
        /// <param name="point">
        /// The <see cref="Point"/> instance to convert.
        /// </param>
        /// <returns>
        /// A <see cref="System.Drawing.PointF"/> instance equivalent to point.
        /// </returns>
        public static implicit operator System.Drawing.PointF(Point point)
        {
            return new System.Drawing.PointF(point.X, point.Y);
        }

        /// <summary>
        /// Indicates whether this instance is equal to the specified object.
        /// </summary>
        /// <param name="obj">The object instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Point)
                return Equals((Point)obj);

            return false;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A <see cref="System.Int32"/> that represents the hash code for this instance./></returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that describes this instance.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that describes this instance.</returns>
        public override string ToString()
        {
            return String.Format("{{{0}, {1}}}", X, Y);
        }

        #endregion

        #region IEquatable<Point> Members

        /// <summary>
        /// Indicates whether this instance is equal to the specified Point.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
        }

        #endregion
    }
#endif
}
