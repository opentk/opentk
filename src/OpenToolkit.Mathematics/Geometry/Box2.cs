//
// Box2.cs
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
    public struct Box2 : IEquatable<Box2>
    {
        /// <summary>
        /// The minimum boundary of the structure.
        /// </summary>
        public Vector2 Min;

        /// <summary>
        /// The maximum boundary of the structure.
        /// </summary>
        public Vector2 Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">An Vector2 describing the top-left corner of the Box2.</param>
        /// <param name="max">A Vector2 describing the bottom-right corner of the Box2.</param>
        public Box2(Vector2 min, Vector2 max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="minX">The position of the left boundary.</param>
        /// <param name="minY">The position of the top boundary.</param>
        /// <param name="maxX">The position of the right boundary.</param>
        /// <param name="maxY">The position of the bottom boundary.</param>
        public Box2(float minX, float minY, float maxX, float maxY)
        {
            Min = new Vector2(minX, minY);
            Max = new Vector2(maxX, maxY);
        }

        /// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        /// <returns>A new OpenToolkit.Box2 with the specified dimensions.</returns>
        public static Box2 FromTLRB(float top, float left, float right, float bottom)
        {
            return new Box2(left, top, right, bottom);
        }

        /// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="minX">The position of the left boundary.</param>
        /// <param name="minY">The position of the top boundary.</param>
        /// <param name="width">The width of the box.</param>
        /// <param name="height">The height of the box.</param>
        /// <returns>A new OpenToolkit.Box2 with the specified dimensions.</returns>
        public static Box2 FromDimensions(float minX, float minY, float width, float height)
        {
            return new Box2(minX, minY, minX + width, minY + height);
        }

        /// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="position">The position of the top-left corner.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A new OpenToolkit.Box2 with the specified dimensions.</returns>
        public static Box2 FromDimensions(Vector2 position, Vector2 size)
        {
            return FromDimensions(position.X, position.Y, size.X, size.Y);
        }

        /// <summary>
        /// Gets a float describing the width of the Box2 structure.
        /// </summary>
        public float Width => Math.Abs(Min.X - Max.X);

        /// <summary>
        /// Gets a float describing the height of the Box2 structure.
        /// </summary>
        public float Height => Math.Abs(Min.Y - Max.Y);

        /// <summary>
        /// Returns whether the box contains the specified point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <param name="closedRegion">Whether to include the box boundary in the test region.</param>
        /// <returns>Whether this box contains the point.</returns>
        public bool Contains(Vector2 point, bool closedRegion = true)
        {
            var containsX = closedRegion == Min.X <= Max.X
                ? point.X >= Min.X != point.X > Max.X
                : point.X > Min.X != point.X >= Max.X;

            var containsY = closedRegion == Min.Y <= Max.Y
                ? point.Y >= Min.Y != point.Y > Min.X
                : point.Y > Min.Y != point.Y >= Max.Y;

            return containsX && containsY;
        }

        /// <summary>
        /// Returns a Box2 translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        public Box2 Translated(Vector2 distance)
        {
            return new Box2(Min + distance, Max + distance);
        }

        /// <summary>
        /// Translates this Box2 by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2 distance)
        {
            Min += distance;
            Max += distance;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box2 left, Box2 right)
        {
            return left.Min == right.Min && left.Max == right.Max;
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator !=(Box2 left, Box2 right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public bool Equals(Box2 other)
        {
            return this == other;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Box2 box && Equals(box);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Min.X.GetHashCode();
                hashCode = (hashCode * 397) ^ Min.Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Max.X.GetHashCode();
                hashCode = (hashCode * 397) ^ Max.Y.GetHashCode();
                return hashCode;
            }
        }

        private static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("({0}{4} {1}) - ({2}{4} {3})", Min.X, Min.Y, Max.X, Max.Y, ListSeparator);
        }
    }
}
