//
// Box2i.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Defines an axis-aligned 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Box2i : IEquatable<Box2i>, IFormattable
    {
        /// <summary>
        /// An empty box with Min (0, 0) and Max (0, 0).
        /// </summary>
        public static readonly Box2i Empty = new Box2i(0, 0, 0, 0);

        private Vector2i _min;

        /// <summary>
        /// Gets or sets the minimum boundary of the structure.
        /// </summary>
        public Vector2i Min
        {
            get => _min;
            set
            {
                _max = Vector2i.ComponentMax(_max, value);
                _min = value;
            }
        }

        private Vector2i _max;

        /// <summary>
        /// Gets or sets the maximum boundary of the structure.
        /// </summary>
        public Vector2i Max
        {
            get => _max;
            set
            {
                _min = Vector2i.ComponentMin(_min, value);
                _max = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2i"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        public Box2i(Vector2i min, Vector2i max)
        {
            _min = Vector2i.ComponentMin(min, max);
            _max = Vector2i.ComponentMax(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2i"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        public Box2i(int minX, int minY, int maxX, int maxY)
            : this(new Vector2i(minX, minY), new Vector2i(maxX, maxY))
        {
        }

        /// <summary>
        /// Gets a vector describing the size of the Box2i structure.
        /// </summary>
        [XmlIgnore]
        public Vector2i Size
        {
            get => Max - Min;
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2i HalfSize
        {
            get => Size / 2;
            set
            {
                Vector2i center = new Vector2i((int)Center.X, (int)Center.Y);
                _min = center - value;
                _max = center + value;
            }
        }

        /// <summary>
        /// Gets a vector describing the center of the box.
        /// </summary>
        /// to avoid annoying off-by-one errors in box placement, no setter is provided for this property
        [XmlIgnore]
        public Vector2 Center
        {
            get => _min + ((_max - _min).ToVector2() * 0.5f);
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        [Obsolete("This function excludes borders even though it's documentation says otherwise. Use ContainsInclusive and ContainsExclusive for the desired behaviour.")]
        public bool Contains(Vector2i point)
        {
            return _min.X < point.X && point.X < _max.X &&
                   _min.Y < point.Y && point.Y < _max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool ContainsInclusive(Vector2i point)
        {
            return _min.X <= point.X && point.X <= _max.X &&
                   _min.Y <= point.Y && point.Y <= _max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool ContainsExclusive(Vector2i point)
        {
            return _min.X < point.X && point.X < _max.X &&
                   _min.Y < point.Y && point.Y < _max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <param name="boundaryInclusive">
        /// Whether points on the box boundary should be recognised as contained as well.
        /// </param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool Contains(Vector2i point, bool boundaryInclusive)
        {
            if (boundaryInclusive)
            {
                return ContainsInclusive(point);
            }
            else
            {
                return ContainsExclusive(point);
            }
        }

        /// <summary>
        /// Returns whether the box contains the specified box (borders inclusive).
        /// </summary>
        /// <param name="other">The box to query.</param>
        /// <returns>Whether this box contains the other box.</returns>
        [Pure]
        public bool Contains(Box2i other)
        {
            return _max.X >= other._min.X && _min.X <= other._max.X &&
                   _max.Y >= other._min.Y && _min.Y <= other._max.Y;
        }

        /// <summary>
        /// Creates a rectangle that represents the intersection between a and
        /// b. If there is no intersection, a empty <see cref="Box2i"/> is returned.
        /// </summary>
        /// <param name="a">First rectangle to intersect.</param>
        /// <param name="b">Second rectangle to intersect.</param>
        /// <returns>The <see cref="Box2i"/> that represents the intersection of both Box2i.</returns>
        public static Box2i Intersect(Box2i a, Box2i b)
        {
            Vector2i min = Vector2i.ComponentMax(a.Min, b.Min);
            Vector2i max = Vector2i.ComponentMin(a.Max, b.Max);

            if (max.X >= min.X && max.Y >= min.Y)
            {
                return new Box2i(min, max);
            }
            else
            {
                return Empty;
            }
        }

        /// <summary>
        /// Returns the distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        [Pure]
        public float DistanceToNearestEdge(Vector2i point)
        {
            var dist = new Vector2(
                Math.Max(0f, Math.Max(_min.X - point.X, point.X - _max.X)),
                Math.Max(0f, Math.Max(_min.Y - point.Y, point.Y - _max.Y)));
            return dist.Length;
        }

        /// <summary>
        /// Translates this Box2i by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2i distance)
        {
            _min += distance;
            _max += distance;
        }

        /// <summary>
        /// Returns a Box2i translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        [Pure]
        public Box2i Translated(Vector2i distance)
        {
            // create a local copy of this box
            Box2i box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this Box2i by the given amount.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector2i scale, Vector2i anchor)
        {
            _min = anchor + ((_min - anchor) * scale);
            _max = anchor + ((_max - anchor) * scale);
        }

        /// <summary>
        /// Returns a Box2i scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
        [Pure]
        public Box2i Scaled(Vector2i scale, Vector2i anchor)
        {
            // create a local copy of this box
            Box2i box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflates this Box2i by the given size in all directions. A negative size will shrink the box to a maximum of -HalfSize.
        /// Use the <see cref="Extend"/> method for the point-encapsulation functionality in OpenTK version 4.8.1 and earlier.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        public void Inflate(Vector2i size)
        {
            size = Vector2i.ComponentMax(size, -HalfSize);
            _min -= size;
            _max += size;
        }

        /// <summary>
        /// Inflates this Box2i by the given size in all directions. A negative size will shrink the box to a maximum of -HalfSize.
        /// Use the <see cref="Extended"/> method for the point-encapsulation functionality in OpenTK version 4.8.1 and earlier.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box2i Inflated(Vector2i size)
        {
            // create a local copy of this box
            Box2i box = this;
            box.Inflate(size);
            return box;
        }

        /// <summary>
        /// Extend this Box2i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to contain.</param>
        public void Extend(Vector2i point)
        {
            _min = Vector2i.ComponentMin(_min, point);
            _max = Vector2i.ComponentMax(_max, point);
        }

        /// <summary>
        /// Extend this Box2i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to contain.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box2i Extended(Vector2i point)
        {
            // create a local copy of this box
            Box2i box = this;
            box.Extend(point);
            return box;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box2i left, Box2i right)
        {
            return left.Equals(right);
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

        /// <summary>
        /// Converts this <see cref="Box2i"/> to a <see cref="System.Drawing.Rectangle"/> using <see cref="Min"/> as the position and <see cref="Size"/> as the size.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        [Pure]
        public static explicit operator System.Drawing.Rectangle(Box2i box)
        {
            return new System.Drawing.Rectangle((System.Drawing.Point)box.Min, (System.Drawing.Size)box.Size);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Box2i && Equals((Box2i)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Box2i other)
        {
            return _min.Equals(other._min) &&
                   _max.Equals(other._max);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(_min, _max);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return ToString(null, null);
        }

        /// <inheritdoc cref="ToString(string, IFormatProvider)"/>
        public string ToString(string format)
        {
            return ToString(format, null);
        }

        /// <inheritdoc cref="ToString(string, IFormatProvider)"/>
        public string ToString(IFormatProvider formatProvider)
        {
            return ToString(null, formatProvider);
        }

        /// <inheritdoc/>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"{Min.ToString(format, formatProvider)} - {Max.ToString(format, formatProvider)}";
        }
    }
}
