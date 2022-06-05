//
// Box3i.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Defines an axis-aligned 3d box (rectangular prism).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Box3i : IEquatable<Box3i>
    {
        /// <summary>
        /// An empty box with Min (0, 0, 0) and Max (0, 0, 0).
        /// </summary>
        public static readonly Box3i Empty = new Box3i(0, 0, 0, 0, 0, 0);

        private Vector3i _min;

        /// <summary>
        /// Gets or sets the minimum boundary of the structure.
        /// </summary>
        public Vector3i Min
        {
            get => _min;
            set
            {
                _max = Vector3i.ComponentMax(_max, value);
                _min = value;
            }
        }

        private Vector3i _max;

        /// <summary>
        /// Gets or sets the maximum boundary of the structure.
        /// </summary>
        public Vector3i Max
        {
            get => _max;
            set
            {
                _min = Vector3i.ComponentMin(_min, value);
                _max = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3i"/> struct.
        /// </summary>
        /// <param name="min">The minimum point in 3D space this box encloses.</param>
        /// <param name="max">The maximum point in 3D space this box encloses.</param>
        public Box3i(Vector3i min, Vector3i max)
        {
            _min = Vector3i.ComponentMin(min, max);
            _max = Vector3i.ComponentMax(min, max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3i"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="minZ">The minimum Z value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        /// <param name="maxZ">The maximum Z value to be enclosed.</param>
        public Box3i(int minX, int minY, int minZ, int maxX, int maxY, int maxZ)
            : this(new Vector3i(minX, minY, minZ), new Vector3i(maxX, maxY, maxZ))
        {
        }

        /// <summary>
        /// Gets a vector describing the size of the Box3i structure.
        /// </summary>
        public Vector3i Size
        {
            get => Max - Min;
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        public Vector3i HalfSize
        {
            get => Size / 2;
            set
            {
                Vector3i center = new Vector3i((int)Center.X, (int)Center.Y, (int)Center.Z);
                _min = center - value;
                _max = center + value;
            }
        }

        /// <summary>
        /// Gets a vector describing the center of the box.
        /// </summary>
        /// to avoid annoying off-by-one errors in box placement, no setter is provided for this property
        public Vector3 Center
        {
            get => _min + ((_max - _min).ToVector3() * 0.5f);
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool Contains(Vector3i point)
        {
            return _min.X < point.X && point.X < _max.X &&
                   _min.Y < point.Y && point.Y < _max.Y &&
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
        public bool Contains(Vector3i point, bool boundaryInclusive)
        {
            if (boundaryInclusive)
            {
                return _min.X <= point.X && point.X <= _max.X &&
                       _min.Y <= point.Y && point.Y <= _max.Y &&
                       _min.Z <= point.Z && point.Z <= _max.Z;
            }
            else
            {
                return _min.X < point.X && point.X < _max.X &&
                       _min.Y < point.Y && point.Y < _max.Y &&
                       _min.Z < point.Z && point.Z < _max.Z;
            }
        }

        /// <summary>
        /// Returns whether the box contains the specified box (borders inclusive).
        /// </summary>
        /// <param name="other">The box to query.</param>
        /// <returns>Whether this box contains the other box.</returns>
        [Pure]
        public bool Contains(Box3i other)
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
        public float DistanceToNearestEdge(Vector3i point)
        {
            var dist = new Vector3(
                Math.Max(0f, Math.Max(_min.X - point.X, point.X - _max.X)),
                Math.Max(0f, Math.Max(_min.Y - point.Y, point.Y - _max.Y)),
                Math.Max(0f, Math.Max(_min.Z - point.Z, point.Z - _max.Z)));
            return dist.Length;
        }

        /// <summary>
        /// Translates this Box3i by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector3i distance)
        {
            _min += distance;
            _max += distance;
        }

        /// <summary>
        /// Returns a Box3i translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        [Pure]
        public Box3i Translated(Vector3i distance)
        {
            // create a local copy of this box
            Box3i box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this Box3i by the given amount.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector3i scale, Vector3i anchor)
        {
            _min = anchor + ((_min - anchor) * scale);
            _max = anchor + ((_max - anchor) * scale);
        }

        /// <summary>
        /// Returns a Box3i scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
        [Pure]
        public Box3i Scaled(Vector3i scale, Vector3i anchor)
        {
            // create a local copy of this box
            Box3i box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflates this Box3i by the given size in all directions. A negative size will shrink the box to a maximum of -HalfSize.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        public void Inflate(Vector3i size)
        {
            size = Vector3i.ComponentMax(size, -HalfSize);
            _min -= size;
            _max += size;
        }

        /// <summary>
        /// Inflates this Box3i by the given size in all directions. A negative size will shrink the box to a maximum of -HalfSize.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        /// <returns>The inflated box.</returns>
        public Box3i Inflated(Vector3i size)
        {
            // create a local copy of this box
            Box3i box = this;
            box.Inflate(size);
            return box;
        }

        /// <summary>
        /// Inflate this Box3i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        public void Union(Vector3i point)
        {
            _min = Vector3i.ComponentMin(_min, point);
            _max = Vector3i.ComponentMax(_max, point);
        }

        /// <summary>
        /// Inflate this Box3i to encapsulate a given Box.
        /// </summary>
        /// <param name="other">The box to include.</param>
        public void Union(Box3i other)
        {
            _min = Vector3i.ComponentMin(_min, other._min);
            _max = Vector3i.ComponentMax(_max, other._max);
        }

        /// <summary>
        /// Inflate this Box3i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box3i Unioned(Vector3i point)
        {
            // create a local copy of this box
            Box3i box = this;
            box.Union(point);
            return box;
        }

        /// <summary>
        /// Inflate this Box3i to encapsulate a given Box.
        /// </summary>
        /// <param name="other">The box to include.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box3i Unioned(Box3i other)
        {
            // create a local copy of this box
            Box3i box = this;
            box.Union(other);
            return box;
        }

        /// <summary>
        /// Equality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box3i left, Box3i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator !=(Box3i left, Box3i right)
        {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Box3i && Equals((Box3i)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Box3i other)
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
