//
// Box2.cs
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
    public struct Box2 : IEquatable<Box2>
    {
        private Vector2 _min;

        /// <summary>
        /// Gets or sets the minimum boundary of the structure.
        /// </summary>
        public Vector2 Min
        {
            get => _min;
            set
            {
                if (value.X > _max.X)
                {
                    _max.X = value.X;
                }
                if (value.Y > _max.Y)
                {
                    _max.Y = value.Y;
                }

                _min = value;
            }
        }

        private Vector2 _max;

        /// <summary>
        /// Gets or sets the maximum boundary of the structure.
        /// </summary>
        public Vector2 Max
        {
            get => _max;
            set
            {
                if (value.X < _min.X)
                {
                    _min.X = value.X;
                }
                if (value.Y < _min.Y)
                {
                    _min.Y = value.Y;
                }

                _max = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        public Box2(Vector2 min, Vector2 max)
        {
            _min = Vector2.ComponentMin(min, max);
            _max = Vector2.ComponentMax(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        public Box2(float minX, float minY, float maxX, float maxY)
            : this(new Vector2(minX, minY), new Vector2(maxX, maxY))
        {
        }

        /// <summary>
        /// Gets or sets a vector describing the size of the Box2 structure.
        /// </summary>
        public Vector2 CenteredSize
        {
            get => Max - Min;
            set
            {
                Vector2 center = Center;
                _min = center - (value * 0.5f);
                _max = center + (value * 0.5f);
            }
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2 HalfSize
        {
            get => CenteredSize / 2;
            set => CenteredSize = value * 2;
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2 Center
        {
            get => HalfSize + _min;
            set => Translate(value - Center);
        }

        // --

        /// <summary>
        /// Gets or sets the width of the box.
        /// </summary>
        public float Width
        {
            get => _max.X - _min.X;
            set => _max.X = _min.X + value;
        }

        /// <summary>
        /// Gets or sets the height of the box.
        /// </summary>
        public float Height
        {
            get => _max.Y - _min.Y;
            set => _max.Y = _min.Y + value;
        }

        /// <summary>
        /// Gets or sets the left location of the box.
        /// </summary>
        public float Left
        {
            get => _min.X;
            set => _min.X = value;
        }

        /// <summary>
        /// Gets or sets the top location of the box.
        /// </summary>
        public float Top
        {
            get => _min.Y;
            set => _min.Y = value;
        }

        /// <summary>
        /// Gets or sets the right location of the box.
        /// </summary>
        public float Right
        {
            get => _max.X;
            set => _max.X = value;
        }

        /// <summary>
        /// Gets or sets the bottom location of the box.
        /// </summary>
        public float Bottom
        {
            get => _max.Y;
            set => _max.Y = value;
        }

        /// <summary>
        /// Gets or sets the X location of the box.
        /// </summary>
        public float X
        {
            get => _min.X;
            set => _min.X = value;
        }

        /// <summary>
        /// Gets or sets the Y location of the box.
        /// </summary>
        public float Y
        {
            get => _min.Y;
            set => _min.Y = value;
        }

        /// <summary>
        /// Gets or sets the horizontal size.
        /// </summary>
        public float SizeX
        {
            get => _max.X - _min.X;
            set => _max.X = _min.X + value;
        }

        /// <summary>
        /// Gets or sets the vertical size.
        /// </summary>
        public float SizeY
        {
            get => _max.Y - _min.Y;
            set => _max.Y = _min.Y + value;
        }

        /// <summary>
        /// Gets or sets the size of the box.
        /// </summary>
        public Vector2 Size
        {
            get => new Vector2(_max.X - _min.X, _max.Y - _min.Y);
            set
            {
                _max.X = _min.X + value.X;
                _max.Y = _min.Y + value.Y;
            }
        }

        /// <summary>
        /// Gets the location of the box.
        /// </summary>
        public Vector2 Location => _min;

        /// <summary>
        /// Gets a value indicating whether all values are zero.
        /// </summary>
        public bool IsZero => _min.X == 0 && _min.Y == 0 && _max.X == 0 && _max.Y == 0;

        /// <summary>
        /// Gets a box with all components zero.
        /// </summary>
        public static readonly Box2 Empty = new Box2(0, 0, 0, 0);

        /// <summary>
        /// Gets a box with a location 0,0 with the a size of 1.
        /// </summary>
        public static readonly Box2 UnitSquare = new Box2(0, 0, 1, 1);

        /// <summary>
        /// Creates a box.
        /// </summary>
        /// <param name="location">The location of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A box.</returns>
        public static Box2 FromSize(Vector2 location, Vector2 size)
        {
            return new Box2(location, location + size);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>A box.</returns>
        public static Box2 FromPositions(Vector2 min, Vector2 max)
        {
            return new Box2(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        /// <returns>A box.</returns>
        public static Box2 FromPositions(float minX, float minY, float maxX, float maxY)
        {
            return new Box2(minX, minY, maxX, maxY);
        }

        /// <summary>
        /// Replaces this Box with the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box2 other)
        {
            Box2 result = Intersect(other, this);

            X = result.X;
            Y = result.Y;
            Width = result.Width;
            Height = result.Height;
        }

        /// <summary>
        /// Returns the intersection of two Boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of two Boxes.</returns>
        public static Box2 Intersect(Box2 a, Box2 b)
        {
            float minX = a._min.X > b._min.X ? a._min.X : b._min.X;
            float minY = a._min.Y > b._min.Y ? a._min.Y : b._min.Y;
            float maxX = a._max.X < b._max.X ? a._max.X : b._max.X;
            float maxY = a._max.Y < b._max.Y ? a._max.Y : b._max.Y;

            if (maxX >= minX && maxY >= minY)
            {
                return new Box2(minX, minY, maxX, maxY);
            }
            return Box2.Empty;
        }

        /// <summary>
        /// Returns the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified Box.</returns>
        public Box2 Intersected(Box2 other)
        {
            return Intersect(other, this);
        }

        /// <summary>
        /// Determines if this Box intersects with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection, otherwise false.</returns>
        public bool IntersectsWith(Box2 other)
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
        public bool TouchWith(Box2 other)
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
        public static Box2 Union(Box2 a, Box2 b)
        {
            float minX = a._min.X < b._min.X ? a._min.X : b._min.X;
            float minY = a._min.Y < b._min.Y ? a._min.Y : b._min.Y;
            float maxX = a._max.X > b._max.X ? a._max.X : b._max.X;
            float maxY = a._max.Y > b._max.Y ? a._max.Y : b._max.Y;

            return new Box2(minX, minY, maxX, maxY);
        }

        /// <summary>
        /// Gets a Box structure that contains rounded integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded integers.</returns>
        public static Box2i Round(Box2 value)
        {
            return new Box2i(
                (int)MathHelper.Round(value.Min.X),
                (int)MathHelper.Round(value.Min.Y),
                (int)MathHelper.Round(value.Max.X),
                (int)MathHelper.Round(value.Max.Y));
        }

        /// <summary>
        /// Gets a Box structure that contains rounded up integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded up integers.</returns>
        public static Box2i Ceiling(Box2 value)
        {
            int x = (int)MathHelper.Ceiling(value._min.X);
            int y = (int)MathHelper.Ceiling(value._min.Y);
            int sizeX = (int)MathHelper.Ceiling(value.Width);
            int sizeY = (int)MathHelper.Ceiling(value.Height);

            return new Box2i(x, y, x + sizeX, y + sizeY);
        }

        /// <summary>
        /// Gets a Box structure that contains rounded down integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded down integers.</returns>
        public static Box2i Floor(Box2 value)
        {
            int x = (int)MathHelper.Floor(value._min.X);
            int y = (int)MathHelper.Floor(value._min.Y);
            int sizeX = (int)MathHelper.Floor(value.Width);
            int sizeY = (int)MathHelper.Floor(value.Height);

            return new Box2i(x, y, x + sizeX, y + sizeY);
        }

        // --

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        [Obsolete("This function used to exclude borders, but to follow changes from the other Box structs it's deprecated. Use ContainsInclusive and ContainsExclusive for the desired behaviour.")]
        public bool Contains(Vector2 point)
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
        public bool ContainsInclusive(Vector2 point)
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
        public bool ContainsExclusive(Vector2 point)
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
        public bool Contains(Vector2 point, bool boundaryInclusive)
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
        public bool Contains(Box2 other)
        {
            return _max.X >= other._min.X && _min.X <= other._max.X &&
                   _max.Y >= other._min.Y && _min.Y <= other._max.Y;
        }

        /// <summary>
        /// Returns the distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        [Pure]
        public float DistanceToNearestEdge(Vector2 point)
        {
            var distX = new Vector2(
                Math.Max(0f, Math.Max(_min.X - point.X, point.X - _max.X)),
                Math.Max(0f, Math.Max(_min.Y - point.Y, point.Y - _max.Y)));
            return distX.Length;
        }

        /// <summary>
        /// Translates this Box2 by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2 distance)
        {
            _min += distance;
            _max += distance;
        }

        /// <summary>
        /// Returns a Box2 translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        [Pure]
        public Box2 Translated(Vector2 distance)
        {
            // create a local copy of this box
            Box2 box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this Box2 by the given amount.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector2 scale, Vector2 anchor)
        {
            _min = anchor + ((_min - anchor) * scale);
            _max = anchor + ((_max - anchor) * scale);
        }

        /// <summary>
        /// Returns a Box2 scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
        [Pure]
        public Box2 Scaled(Vector2 scale, Vector2 anchor)
        {
            // create a local copy of this box
            Box2 box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflate this Box2 to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        public void Inflate(Vector2 point)
        {
            _min = Vector2.ComponentMin(_min, point);
            _max = Vector2.ComponentMax(_max, point);
        }

        /// <summary>
        /// Inflate this Box2 to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box2 Inflated(Vector2 point)
        {
            // create a local copy of this box
            Box2 box = this;
            box.Inflate(point);
            return box;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box2 left, Box2 right)
        {
            return left.Equals(right);
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
        public override bool Equals(object obj)
        {
            return obj is Box2 && Equals((Box2)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Box2 other)
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
