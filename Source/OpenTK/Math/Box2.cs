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
    public struct Box2
    {
        /// <summary>
        /// The left boundary of the structure.
        /// </summary>
        public float Left;

        /// <summary>
        /// The right boundary of the structure.
        /// </summary>
        public float Right;

        /// <summary>
        /// The top boundary of the structure.
        /// </summary>
        public float Top;

        /// <summary>
        /// The bottom boundary of the structure.
        /// </summary>
        public float Bottom;

        /// <summary>
        /// Constructs a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="topLeft">An OpenTK.Vector2 describing the top-left corner of the Box2.</param>
        /// <param name="bottomRight">An OpenTK.Vector2 describing the bottom-right corner of the Box2.</param>
        public Box2(Vector2 topLeft, Vector2 bottomRight)
        {
            Left = topLeft.X;
            Top = topLeft.Y;
            Right = bottomRight.X;
            Bottom = bottomRight.Y;
        }

        /// <summary>
        /// Constructs a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        public Box2(float left, float top, float right, float bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        /// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        /// <returns>A new OpenTK.Box2 with the specfied dimensions.</returns>
        public static Box2 FromTLRB(float top, float left, float right, float bottom)
        {
            return new Box2(left, top, right, bottom);
        }

		/// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
		/// <param name="width">The width of the box.</param>
		/// <param name="height">The height of the box.</param>
        /// <returns>A new OpenTK.Box2 with the specfied dimensions.</returns>
		public static Box2 FromDimensions(float left, float top, float width, float height)
		{
			return new Box2(left, top, left + width, top + height);
		}

		/// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="position">The position of the top left corner.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A new OpenTK.Box2 with the specfied dimensions.</returns>
		public static Box2 FromDimensions(Vector2 position, Vector2 size)
		{
			return FromDimensions(position.X, position.Y, size.X, size.Y);
		}

		/// <summary>
		/// Creates a new Box2 from the specified corners.
		/// </summary>
		/// <param name="corner1">One of the corners of the box.</param>
		/// <param name="corner2">The opposite corner of the box.</param>
		/// <returns></returns>
        public static Box2 FromCorners(Vector2 corner1, Vector2 corner2)
        {
			Box2 box;
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
        /// Gets a float describing the width of the Box2 structure.
        /// </summary>
        public float Width { get { return (float)System.Math.Abs(Right - Left); } }

        /// <summary>
        /// Gets a float describing the height of the Box2 structure.
        /// </summary>
        public float Height { get { return (float)System.Math.Abs(Bottom - Top); } }

		/// <summary>
		/// Returns whether the box contains the specified point.
		/// </summary>
		/// <param name="point">The point to query.</param>
		/// <returns>Whether this box contains the point.</returns>
		public bool Contains(Vector2 point)
		{
			return (point.X >= Left != point.X > Right) && (point.Y >= Top != point.Y > Bottom);
		}

		/// <summary>
		/// Returns a Box2 translated by the given amount.
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		public Box2 Translate(Vector2 point)
		{
			return new Box2(Left + point.X, Top + point.Y, Right + point.X, Bottom + point.Y);
		}

		/// <summary>
		/// Equality comparator.
		/// </summary>
		public static bool operator ==(Box2 left, Box2 right)
		{
			return left.Bottom == right.Bottom && left.Top == right.Top &&
				left.Left == right.Left && left.Right == right.Right;
		}

		/// <summary>
		/// Inequality comparator.
		/// </summary>
		public static bool operator !=(Box2 left, Box2 right)
		{
			return !(left == right);
		}

		/// <summary>
		/// Functional equality comparator.
		/// </summary>
		public bool Equals(Box2 other)
		{
			return this == other;
		}

		/// <summary>
		/// Implements Object.Equals.
		/// </summary>
		public override bool Equals(object obj)
		{
			return obj is Box2 && Equals((Box2) obj);
		}

		/// <summary>
		/// Gets the hash code for this Box2.
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
