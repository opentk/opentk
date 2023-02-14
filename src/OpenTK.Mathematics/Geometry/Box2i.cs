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
    public struct Box2i : IEquatable<Box2i>
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
        public Vector2i CenteredSize
        {
            get => Max - Min;
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2i HalfSize
        {
            get => CenteredSize / 2;
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

        // --

        /// <summary>
        /// Gets or sets the width of the box.
        /// </summary>
        public int Width
        {
            get => _max.X - _min.X;
            set => _max.X = _min.X + value;
        }

        /// <summary>
        /// Gets or sets the height of the box.
        /// </summary>
        public int Height
        {
            get => _max.Y - _min.Y;
            set => _max.Y = _min.Y + value;
        }

        /// <summary>
        /// Gets or sets the left location of the box.
        /// </summary>
        public int Left
        {
            get => _min.X;
            set => _min.X = value;
        }

        /// <summary>
        /// Gets or sets the top location of the box.
        /// </summary>
        public int Top
        {
            get => _min.Y;
            set => _min.Y = value;
        }

        /// <summary>
        /// Gets or sets the right location of the box.
        /// </summary>
        public int Right
        {
            get => _max.X;
            set => _max.X = value;
        }

        /// <summary>
        /// Gets or sets the bottom location of the box.
        /// </summary>
        public int Bottom
        {
            get => _max.Y;
            set => _max.Y = value;
        }

        /// <summary>
        /// Gets or sets the X location of the box.
        /// </summary>
        public int X
        {
            get => _min.X;
            set => _min.X = value;
        }

        /// <summary>
        /// Gets or sets the Y location of the box.
        /// </summary>
        public int Y
        {
            get => _min.Y;
            set => _min.Y = value;
        }

        /// <summary>
        /// Gets or sets the horizontal size.
        /// </summary>
        public int SizeX
        {
            get => _max.X - _min.X;
            set => _max.X = _min.X + value;
        }

        /// <summary>
        /// Gets or sets the vertical size.
        /// </summary>
        public int SizeY
        {
            get => _max.Y - _min.Y;
            set => _max.Y = _min.Y + value;
        }

        /// <summary>
        /// Gets or sets the size of the box.
        /// </summary>
        public Vector2i Size
        {
            get => new Vector2i(_max.X - _min.X, _max.Y - _min.Y);
            set
            {
                _max.X = _min.X + value.X;
                _max.Y = _min.Y + value.Y;
            }
        }

        /// <summary>
        /// Gets the location of the box.
        /// </summary>
        public Vector2i Location => _min;

        /// <summary>
        /// Gets a value indicating whether all values are zero.
        /// </summary>
        public bool IsZero => _min.X == 0 && _min.Y == 0 && _max.X == 0 && _max.Y == 0;

        /// <summary>
        /// Gets a box with a location 0,0 with the a size of 1.
        /// </summary>
        public static readonly Box2i UnitSquare = new Box2i(0, 0, 1, 1);

        /// <summary>
        /// Creates a box.
        /// </summary>
        /// <param name="location">The location of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A box.</returns>
        public static Box2i FromSize(Vector2i location, Vector2i size)
        {
            return new Box2i(location, location + size);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>A box.</returns>
        public static Box2i FromPositions(Vector2i min, Vector2i max)
        {
            return new Box2i(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        /// <returns>A box.</returns>
        public static Box2i FromPositions(int minX, int minY, int maxX, int maxY)
        {
            return new Box2i(minX, minY, maxX, maxY);
        }

        /// <summary>
        /// Replaces this Box with the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box2i other)
        {
            Box2i result = Intersect(other, this);

            X = result.X;
            Y = result.Y;
            Width = result.Width;
            Height = result.Height;
        }

        /// <summary>
        /// Returns the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified Box.</returns>
        public Box2i Intersected(Box2i other)
        {
            return Intersect(other, this);
        }

        /// <summary>
        /// Determines if this Box intersects with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection, otherwise false.</returns>
        public bool IntersectsWith(Box2i other)
        {
            return other._min.X < _max.X
                && _min.X < other._max.X
                && other._min.Y < _max.Y
                && _min.Y < other._max.Y;
        }

        /// <summary>
        /// Determines if this Box intersects or touches with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection or touches, otherwise false.</returns>
        public bool TouchWith(Box2i other)
        {
            return other._min.X <= _max.X
                && _min.X <= other._max.X
                && other._min.Y <= _max.Y
                && _min.Y <= other._max.Y;
        }

        /// <summary>
        /// Gets a Box structure that contains the union of two Box structures.
        /// </summary>
        /// <param name="a">A Box to union.</param>
        /// <param name="b">a box to union.</param>
        /// <returns>A Box structure that bounds the union of the two Box structures.</returns>
        public static Box2i Union(Box2i a, Box2i b)
        {
            int minX = a._min.X < b._min.X ? a._min.X : b._min.X;
            int minY = a._min.Y < b._min.Y ? a._min.Y : b._min.Y;
            int maxX = a._max.X > b._max.X ? a._max.X : b._max.X;
            int maxY = a._max.Y > b._max.Y ? a._max.Y : b._max.Y;

            return new Box2i(minX, minY, maxX, maxY);
        }

        // --

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
        /// Inflate this Box2i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        public void Inflate(Vector2i point)
        {
            _min = Vector2i.ComponentMin(_min, point);
            _max = Vector2i.ComponentMax(_max, point);
        }

        /// <summary>
        /// Inflate this Box2i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box2i Inflated(Vector2i point)
        {
            // create a local copy of this box
            Box2i box = this;
            box.Inflate(point);
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
            return $"{Min} - {Max}";
        }
    }
}
