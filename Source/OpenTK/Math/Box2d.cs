#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Runtime.InteropServices;
namespace OpenTK
{
	/// <summary>
	/// Defines a 2d box (rectangle).
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
    public struct Box2d
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
		/// Creates a new Box2d from the specified corners.
		/// </summary>
		/// <param name="corner1">One of the corners of the box.</param>
		/// <param name="corner2">The opposite corner of the box.</param>
		/// <returns></returns>
        public static Box2d FromCorners(Vector2d corner1, Vector2d corner2)
        {
			Box2d box;
			if (corner1.X < corner2.X)
			{
				box.Left = corner1.X;
				box.Right = corner2.X;
			}
			else
			{
				box.Left = corner2.X;
				box.Right = corner1.X;
			}

			if (corner1.Y < corner2.Y)
			{
				box.Top = corner1.Y;
				box.Bottom = corner2.Y;
			}
			else
			{
				box.Top = corner2.Y;
				box.Bottom = corner1.Y;
			}

			return box;
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
		/// Returns whether the box contains the specified point.
		/// </summary>
		/// <param name="point">The point to query.</param>
		/// <returns>Whether this box contains the point.</returns>
		public bool Contains(Vector2d point)
		{
			return (point.X >= Left != point.X > Right) && (point.Y >= Top != point.Y > Bottom);
		}

		/// <summary>
		/// Returns a Box2d translated by the given amount.
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		public Box2d Translate(Vector2d point)
		{
			return new Box2d(Left + point.X, Top + point.Y, Right + point.X, Bottom + point.Y);
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
		/// <returns></returns>
		public override int GetHashCode()
		{
			return Left.GetHashCode() ^ Right.GetHashCode() ^ Top.GetHashCode() ^ Bottom.GetHashCode();
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
