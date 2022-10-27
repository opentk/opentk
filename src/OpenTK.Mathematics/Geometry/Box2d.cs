//
// Box2d.cs
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
    public struct Box2d : IEquatable<Box2d>
    {
        private Vector2d _min;

        /// <summary>
        /// Gets or sets the minimum boundary of the structure.
        /// </summary>
        public Vector2d Min
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

        private Vector2d _max;

        /// <summary>
        /// Gets or sets the maximum boundary of the structure.
        /// </summary>
        public Vector2d Max
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
        /// Initializes a new instance of the <see cref="Box2d"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        public Box2d(Vector2d min, Vector2d max)
        {
            _min = Vector2d.ComponentMin(min, max);
            _max = Vector2d.ComponentMax(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2d"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        public Box2d(double minX, double minY, double maxX, double maxY)
            : this(new Vector2d(minX, minY), new Vector2d(maxX, maxY))
        {
        }

        /// <summary>
        /// Gets or sets a vector describing the size of the Box2d structure.
        /// </summary>
        public Vector2d CenteredSize
        {
            get => Max - Min;
            set
            {
                Vector2d center = Center;
                _min = center - (value * 0.5f);
                _max = center + (value * 0.5f);
            }
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2d HalfSize
        {
            get => CenteredSize / 2;
            set => CenteredSize = value * 2;
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2d Center
        {
            get => HalfSize + _min;
            set => Translate(value - Center);
        }

        // --

        /// <summary>
        /// Gets or sets the width of the box.
        /// </summary>
        public double Width
        {
            get => _max.X - _min.X;
            set => _max.X = _min.X + value;
        }

        /// <summary>
        /// Gets or sets the height of the box.
        /// </summary>
        public double Height
        {
            get => _max.Y - _min.Y;
            set => _max.Y = _min.Y + value;
        }

        /// <summary>
        /// Gets or sets the left location of the box.
        /// </summary>
        public double Left
        {
            get => _min.X;
            set => _min.X = value;
        }

        /// <summary>
        /// Gets or sets the top location of the box.
        /// </summary>
        public double Top
        {
            get => _min.Y;
            set => _min.Y = value;
        }

        /// <summary>
        /// Gets or sets the right location of the box.
        /// </summary>
        public double Right
        {
            get => _max.X;
            set => _max.X = value;
        }

        /// <summary>
        /// Gets or sets the bottom location of the box.
        /// </summary>
        public double Bottom
        {
            get => _max.Y;
            set => _max.Y = value;
        }

        /// <summary>
        /// Gets or sets the X location of the box.
        /// </summary>
        public double X
        {
            get => _min.X;
            set => _min.X = value;
        }

        /// <summary>
        /// Gets or sets the Y location of the box.
        /// </summary>
        public double Y
        {
            get => _min.Y;
            set => _min.Y = value;
        }

        /// <summary>
        /// Gets or sets the horizontal size.
        /// </summary>
        public double SizeX
        {
            get => _max.X - _min.X;
            set => _max.X = _min.X + value;
        }

        /// <summary>
        /// Gets or sets the vertical size.
        /// </summary>
        public double SizeY
        {
            get => _max.Y - _min.Y;
            set => _max.Y = _min.Y + value;
        }

        /// <summary>
        /// Gets or sets the size of the box.
        /// </summary>
        public Vector2d Size
        {
            get => new Vector2d(_max.X - _min.X, _max.Y - _min.Y);
            set
            {
                _max.X = _min.X + value.X;
                _max.Y = _min.Y + value.Y;
            }
        }

        /// <summary>
        /// Gets the location of the box.
        /// </summary>
        public Vector2d Location => _min;

        /// <summary>
        /// Gets a value indicating whether all values are zero.
        /// </summary>
        public bool IsZero => _min.X == 0 && _min.Y == 0 && _max.X == 0 && _max.Y == 0;

        /// <summary>
        /// Gets a box with all components zero.
        /// </summary>
        public static readonly Box2d Empty = new Box2d(0, 0, 0, 0);

        /// <summary>
        /// Gets a box with a location 0,0 with the a size of 1.
        /// </summary>
        public static readonly Box2d UnitSquare = new Box2d(0, 0, 1, 1);

        /// <summary>
        /// Creates a box.
        /// </summary>
        /// <param name="location">The location of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A box.</returns>
        public static Box2d FromSize(Vector2d location, Vector2d size)
        {
            return new Box2d(location, location + size);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>A box.</returns>
        public static Box2d FromPositions(Vector2d min, Vector2d max)
        {
            return new Box2d(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        /// <returns>A box.</returns>
        public static Box2d FromPositions(double minX, double minY, double maxX, double maxY)
        {
            return new Box2d(minX, minY, maxX, maxY);
        }

        /// <summary>
        /// Replaces this Box with the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box2d other)
        {
            Box2d result = Intersect(other, this);

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
        public static Box2d Intersect(Box2d a, Box2d b)
        {
            double minX = a._min.X > b._min.X ? a._min.X : b._min.X;
            double minY = a._min.Y > b._min.Y ? a._min.Y : b._min.Y;
            double maxX = a._max.X < b._max.X ? a._max.X : b._max.X;
            double maxY = a._max.Y < b._max.Y ? a._max.Y : b._max.Y;

            if (maxX >= minX && maxY >= minY)
            {
                return new Box2d(minX, minY, maxX, maxY);
            }
            return Box2d.Empty;
        }

        /// <summary>
        /// Returns the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified Box.</returns>
        public Box2d Intersected(Box2d other)
        {
            return Intersect(other, this);
        }

        /// <summary>
        /// Determines if this Box intersects with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection, otherwise false.</returns>
        public bool IntersectsWith(Box2d other)
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
        public bool TouchWith(Box2d other)
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
        public static Box2d Union(Box2d a, Box2d b)
        {
            double minX = a._min.X < b._min.X ? a._min.X : b._min.X;
            double minY = a._min.Y < b._min.Y ? a._min.Y : b._min.Y;
            double maxX = a._max.X > b._max.X ? a._max.X : b._max.X;
            double maxY = a._max.Y > b._max.Y ? a._max.Y : b._max.Y;

            return new Box2d(minX, minY, maxX, maxY);
        }

        /// <summary>
        /// Gets a Box structure that contains rounded integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded integers.</returns>
        public static Box2i Round(Box2d value)
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
        public static Box2i Ceiling(Box2d value)
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
        public static Box2i Floor(Box2d value)
        {
            int x = (int)MathHelper.Floor(value._min.X);
            int y = (int)MathHelper.Floor(value._min.Y);
            int sizeX = (int)MathHelper.Floor(value.Width);
            int sizeY = (int)MathHelper.Floor(value.Height);

            return new Box2i(x, y, x + sizeX, y + sizeY);
        }

        // --

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        [Obsolete("This function excludes borders even though it's documentation says otherwise. Use ContainsInclusive and ContainsExclusive for the desired behaviour.")]
        public bool Contains(Vector2d point)
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
        public bool ContainsInclusive(Vector2d point)
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
        public bool ContainsExclusive(Vector2d point)
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
        public bool Contains(Vector2d point, bool boundaryInclusive)
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
        public bool Contains(Box2d other)
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
        public double DistanceToNearestEdge(Vector2d point)
        {
            var distX = new Vector2d(
                Math.Max(0f, Math.Max(_min.X - point.X, point.X - _max.X)),
                Math.Max(0f, Math.Max(_min.Y - point.Y, point.Y - _max.Y)));
            return distX.Length;
        }

        /// <summary>
        /// Translates this Box2d by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2d distance)
        {
            _min += distance;
            _max += distance;
        }

        /// <summary>
        /// Returns a Box2d translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        [Pure]
        public Box2d Translated(Vector2d distance)
        {
            // create a local copy of this box
            Box2d box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this Box2d by the given amount.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector2d scale, Vector2d anchor)
        {
            _min = anchor + ((_min - anchor) * scale);
            _max = anchor + ((_max - anchor) * scale);
        }

        /// <summary>
        /// Returns a Box2d scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
        [Pure]
        public Box2d Scaled(Vector2d scale, Vector2d anchor)
        {
            // create a local copy of this box
            Box2d box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflate this Box2d to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        public void Inflate(Vector2d point)
        {
            _min = Vector2d.ComponentMin(_min, point);
            _max = Vector2d.ComponentMax(_max, point);
        }

        /// <summary>
        /// Inflate this Box2d to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box2d Inflated(Vector2d point)
        {
            // create a local copy of this box
            Box2d box = this;
            box.Inflate(point);
            return box;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box2d left, Box2d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator !=(Box2d left, Box2d right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Box2d && Equals((Box2d)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Box2d other)
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
