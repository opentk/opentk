//
// Box2i.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Defines a 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Box2i : IEquatable<Box2i>
    {
        /// <summary>
        /// The left boundary of the structure.
        /// </summary>
        public int Left;

        /// <summary>
        /// The right boundary of the structure.
        /// </summary>
        public int Right;

        /// <summary>
        /// The top boundary of the structure.
        /// </summary>
        public int Top;

        /// <summary>
        /// The bottom boundary of the structure.
        /// </summary>
        public int Bottom;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2i"/> struct.
        /// </summary>
        /// <param name="topLeft">An OpenToolkit.Vector2 describing the top-left corner of the Box2.</param>
        /// <param name="bottomRight">An OpenToolkit.Vector2 describing the bottom-right corner of the Box2.</param>
        public Box2i(Vector2i topLeft, Vector2i bottomRight)
        {
            Left = topLeft.X;
            Top = topLeft.Y;
            Right = bottomRight.X;
            Bottom = bottomRight.Y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2i"/> struct.
        /// </summary>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        public Box2i(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        /// <summary>
        /// Creates a new <see cref="Box2i"/> with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        /// <returns>A new OpenToolkit.Box2 with the specfied dimensions.</returns>
        public static Box2i FromTLRB(int top, int left, int right, int bottom)
        {
            return new Box2i(left, top, right, bottom);
        }

        /// <summary>
        /// Creates a new <see cref="Box2i"/> with the specified dimensions.
        /// </summary>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="width">The width of the box.</param>
        /// <param name="height">The height of the box.</param>
        /// <returns>A new OpenToolkit.Box2 with the specfied dimensions.</returns>
        public static Box2i FromDimensions(int left, int top, int width, int height)
        {
            return new Box2i(left, top, left + width, top + height);
        }

        /// <summary>
        /// Creates a new <see cref="Box2i"/> with the specified dimensions.
        /// </summary>
        /// <param name="position">The position of the top left corner.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A new OpenToolkit.Box2 with the specfied dimensions.</returns>
        public static Box2i FromDimensions(Vector2i position, Vector2i size)
        {
            return FromDimensions(position.X, position.Y, size.X, size.Y);
        }

        /// <summary>
        /// Gets a float describing the width of the <see cref="Box2i"/> structure.
        /// </summary>
        public int Width => MathHelper.Abs(Right - Left);

        /// <summary>
        /// Gets a float describing the height of the <see cref="Box2i"/> structure.
        /// </summary>
        public int Height => MathHelper.Abs(Bottom - Top);

        /// <summary>
        /// Returns whether the <see cref="Box2i"/> contains the specified point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <param name="closedRegion">Whether to include the box boundary in the test region.</param>
        /// <returns>Whether this box contains the point.</returns>
        public bool Contains(Vector2i point, bool closedRegion = true)
        {
            var containsX = closedRegion == Left <= Right
                ? point.X >= Left != point.X > Right
                : point.X > Left != point.X >= Right;

            var containsY = closedRegion == Top <= Bottom
                ? point.Y >= Top != point.Y > Bottom
                : point.Y > Top != point.Y >= Bottom;

            return containsX && containsY;
        }

        /// <summary>
        /// Returns a <see cref="Box2i"/> translated by the given amount.
        /// </summary>
        /// <param name="point">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        public Box2 Translated(Vector2i point)
        {
            return new Box2(Left + point.X, Top + point.Y, Right + point.X, Bottom + point.Y);
        }

        /// <summary>
        /// Translates this <see cref="Box2i"/> by the given amount.
        /// </summary>
        /// <param name="point">The distance to translate the box.</param>
        public void Translate(Vector2i point)
        {
            Left += point.X;
            Right += point.X;
            Top += point.Y;
            Bottom += point.Y;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box2i left, Box2i right)
        {
            return left.Bottom == right.Bottom && left.Top == right.Top &&
                   left.Left == right.Left && left.Right == right.Right;
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator !=(Box2i left, Box2i right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public bool Equals(Box2i other)
        {
            return this == other;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Box2i box && Equals(box);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Left.GetHashCode();
                hashCode = (hashCode * 397) ^ Right.GetHashCode();
                hashCode = (hashCode * 397) ^ Top.GetHashCode();
                hashCode = (hashCode * 397) ^ Bottom.GetHashCode();
                return hashCode;
            }
        }

        private static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("({0}{4} {1}) - ({2}{4} {3})", Left, Top, Right, Bottom, ListSeparator);
        }
    }
}
