#region --- License ---
// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
#endregion

using System;
using System.Runtime.InteropServices;
namespace OpenTK
{
    /// <summary>
    /// Defines a 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Box2d : IEquatable<Box2d>
    {

        /// <summary>
        /// The left boundary of the structure.
        /// </summary>
        public double Left;

        /// <summary>
        /// The right boundary of the structure.
        /// </summary>
        public double Right;

        /// <summary>
        /// The top boundary of the structure.
        /// </summary>
        public double Top;

        /// <summary>
        /// The bottom boundary of the structure.
        /// </summary>
        public double Bottom;

        /// <summary>
        /// Constructs a new Box2d with the specified dimensions.
        /// </summary>
        /// <param name="topLeft">An OpenTK.Vector2d describing the top-left corner of the Box2d.</param>
        /// <param name="bottomRight">An OpenTK.Vector2d describing the bottom-right corner of the Box2d.</param>
        public Box2d(Vector2d topLeft, Vector2d bottomRight)
        {
            Left = topLeft.X;
            Top = topLeft.Y;
            Right = bottomRight.X;
            Bottom = bottomRight.Y;
        }

        /// <summary>
        /// Constructs a new Box2d with the specified dimensions.
        /// </summary>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        public Box2d(double left, double top, double right, double bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        /// <summary>
        /// Creates a new Box2d with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        /// <returns>A new OpenTK.Box2d with the specfied dimensions.</returns>
        public static Box2d FromTLRB(double top, double left, double right, double bottom)
        {
            return new Box2d(left, top, right, bottom);
        }

        /// <summary>
        /// Creates a new Box2d with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="width">The width of the box.</param>
        /// <param name="height">The height of the box.</param>
        /// <returns>A new OpenTK.Box2d with the specfied dimensions.</returns>
        public static Box2d FromDimensions(double left, double top, double width, double height)
        {
            return new Box2d(left, top, left + width, top + height);
        }

        /// <summary>
        /// Creates a new Box2d with the specified dimensions.
        /// </summary>
        /// <param name="position">The position of the top left corner.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A new OpenTK.Box2d with the specfied dimensions.</returns>
        public static Box2d FromDimensions(Vector2d position, Vector2d size)
        {
            return FromDimensions(position.X, position.Y, size.X, size.Y);
        }

        /// <summary>
        /// Gets a double describing the width of the Box2d structure.
        /// </summary>
        public double Width { get { return (double)System.Math.Abs(Right - Left); } }

        /// <summary>
        /// Gets a double describing the height of the Box2d structure.
        /// </summary>
        public double Height { get { return (double)System.Math.Abs(Bottom - Top); } }

        /// <summary>
        /// Returns whether the box contains the specified point on the closed region described by this Box2.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        public bool Contains(Vector2d point)
        {
            return Contains(point, true);
        }

        /// <summary>
        /// Returns whether the box contains the specified point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <param name="closedRegion">Whether to include the box boundary in the test region.</param>
        /// <returns>Whether this box contains the point.</returns>
        public bool Contains(Vector2d point, bool closedRegion)
        {
            bool xOK = (closedRegion == Left <= Right) ?
                (point.X >= Left != point.X > Right) :
                (point.X > Left != point.X >= Right);

            bool yOK = (closedRegion == Top <= Bottom) ?
                (point.Y >= Top != point.Y > Bottom) :
                (point.Y > Top != point.Y >= Bottom);

            return xOK && yOK;
        }

        /// <summary>
        /// Returns a Box2d translated by the given amount.
        /// </summary>
        public Box2d Translated(Vector2d point)
        {
            return new Box2d(Left + point.X, Top + point.Y, Right + point.X, Bottom + point.Y);
        }

        /// <summary>
        /// Translates this Box2d by the given amount.
        /// </summary>
        public void Translate(Vector2d point)
        {
            Left += point.X;
            Right += point.X;
            Top += point.Y;
            Bottom += point.Y;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        public static bool operator ==(Box2d left, Box2d right)
        {
            return left.Bottom == right.Bottom && left.Top == right.Top &&
                left.Left == right.Left && left.Right == right.Right;
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        public static bool operator !=(Box2d left, Box2d right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Functional equality comparator.
        /// </summary>
        public bool Equals(Box2d other)
        {
            return this == other;
        }

        /// <summary>
        /// Implements Object.Equals.
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Box2d && Equals((Box2d) obj);
        }

        /// <summary>
        /// Gets the hash code for this Box2d.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.Left.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Right.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Top.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Bottom.GetHashCode();
                return hashCode;
            }
        }

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>
        /// Returns a <see cref="System.String"/> describing the current instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("({0}{4} {1}) - ({2}{4} {3})", Left, Top, Right, Bottom, listSeparator);
        }
    }
}
