//
// Box3d.cs
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

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Defines an axis-aligned 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Box3d : IEquatable<Box3d>
    {
        private Vector3d _min;

        /// <summary>
        /// Gets or sets the minimum boundary of the structure.
        /// </summary>
        public Vector3d Min
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
                if (value.Z > _max.Z)
                {
                    _max.Z = value.Z;
                }

                _min = value;
            }
        }

        private Vector3d _max;

        /// <summary>
        /// Gets or sets the maximum boundary of the structure.
        /// </summary>
        public Vector3d Max
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
                if (value.Z < _min.Z)
                {
                    _min.Z = value.Z;
                }

                _max = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3d"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        public Box3d(Vector3d min, Vector3d max)
        {
            _min = Vector3d.ComponentMin(min, max);
            _max = Vector3d.ComponentMax(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3d"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="minZ">The minimum Z value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        /// <param name="maxZ">The maximum Z value to be enclosed.</param>
        public Box3d(double minX, double minY, double minZ, double maxX, double maxY, double maxZ)
            : this(new Vector3d(minX, minY, minZ), new Vector3d(maxX, maxY, maxZ))
        {
        }

        /// <summary>
        /// Gets or sets a vector describing the size of the Box3d structure.
        /// </summary>
        public Vector3d Size
        {
            get => Max - Min;
            set
            {
                Vector3d center = Center;
                _min = center - (value * 0.5f);
                _max = center + (value * 0.5f);
            }
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        public Vector3d HalfSize
        {
            get => Size / 2;
            set => Size = value * 2;
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        public Vector3d Center
        {
            get => HalfSize + _min;
            set => Translate(value - Center);
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool Contains(Vector3d point)
        {
            return _min.X < point.X && point.X < _max.X &&
                   _min.Y < point.Z && point.Y < _max.Y &&
                   _min.Z < point.Z && point.Z < _max.Z;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <param name="boundaryInclusive">
        /// Whether points on the box boundary should be recognised as contained as well.
        /// </param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool Contains(Vector3d point, bool boundaryInclusive)
        {
            if (boundaryInclusive)
            {
                return _min.X <= point.X && point.X <= _max.X &&
                       _min.Y <= point.Y && point.Y <= _max.Y &&
                       _min.Z <= point.Z && point.Z <= _max.Z;
            }
            return _min.X < point.X && point.X < _max.X &&
                   _min.Y < point.Y && point.Y < _max.Y &&
                   _min.Z < point.Z && point.Z < _max.Z;
        }

        /// <summary>
        /// Returns whether the box contains the specified box (borders inclusive).
        /// </summary>
        /// <param name="other">The box to query.</param>
        /// <returns>Whether this box contains the other box.</returns>
        [Pure]
        public bool Contains(Box3d other)
        {
            return _max.X >= other._min.X && _min.X <= other._max.X &&
                   _max.Y >= other._min.Y && _min.Y <= other._max.Y &&
                   _max.Z >= other._min.Z && _min.Z <= other._max.Z;
        }

        /// <summary>
        /// Returns the distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        [Pure]
        public double DistanceToNearestEdge(Vector3d point)
        {
            var distX = new Vector3d(
                Math.Max(0f, Math.Max(_min.X - point.X, point.X - _max.X)),
                Math.Max(0f, Math.Max(_min.Y - point.Y, point.Y - _max.Y)),
                Math.Max(0f, Math.Max(_min.Z - point.Z, point.Z - _max.Z)));
            return distX.Length;
        }

        /// <summary>
        /// Translates this Box3d by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector3d distance)
        {
            _min += distance;
            _max += distance;
        }

        /// <summary>
        /// Returns a Box3d translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        [Pure]
        public Box3d Translated(Vector3d distance)
        {
            // create a local copy of this box
            Box3d box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this Box3d by the given amount.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector3d scale, Vector3d anchor)
        {
            _min = anchor + ((_min - anchor) * scale);
            _max = anchor + ((_max - anchor) * scale);
        }

        /// <summary>
        /// Returns a Box3d scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
        [Pure]
        public Box3d Scaled(Vector3d scale, Vector3d anchor)
        {
            // create a local copy of this box
            Box3d box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflate this Box3d to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        public void Inflate(Vector3d point)
        {
            _min = Vector3d.ComponentMin(_min, point);
            _max = Vector3d.ComponentMax(_max, point);
        }

        /// <summary>
        /// Inflate this Box3d to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box3d Inflated(Vector3d point)
        {
            // create a local copy of this box
            Box3d box = this;
            box.Inflate(point);
            return box;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        [Pure]
        public static bool operator ==(Box3d left, Box3d right)
        {
            return left.Min == right.Min && left.Max == right.Max;
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        [Pure]
        public static bool operator !=(Box3d left, Box3d right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        [Pure]
        public bool Equals(Box3d other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        /// <inheritdoc/>
        [Pure]
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Box3d other && Equals(other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Min.GetHashCode() * 397) ^ Max.GetHashCode();
            }
        }

        private static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"({Min.X}{ListSeparator} {Min.Y}{ListSeparator} {Min.Z}) - ({Max.X}{ListSeparator} {Max.Y}{ListSeparator} {Max.Z})";
        }
    }
}
