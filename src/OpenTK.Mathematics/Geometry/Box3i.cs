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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Defines an axis-aligned 3d box (rectangular prism).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
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
        public Vector3i CenteredSize
        {
            get => Max - Min;
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        [XmlIgnore]
        public Vector3i HalfSize
        {
            get => CenteredSize / 2;
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
        [XmlIgnore]
        public Vector3 Center
        {
            get => _min + ((_max - _min).ToVector3() * 0.5f);
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
        /// Gets or sets the depth of the box.
        /// </summary>
        public int Depth
        {
            get => _max.Z - _min.Z;
            set => _max.Z = _min.Z + value;
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
        /// Gets or sets the front location of the box.
        /// </summary>
        public int Front
        {
            get => _min.Z;
            set => _min.Z = value;
        }

        /// <summary>
        /// Gets or sets the back location of the box.
        /// </summary>
        public int Back
        {
            get => _max.Z;
            set => _max.Z = value;
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
        /// Gets or sets the Z location of the box.
        /// </summary>
        public int Z
        {
            get => _min.Z;
            set => _min.Z = value;
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
        /// Gets or sets the vertical size.
        /// </summary>
        public int SizeZ
        {
            get => _max.Z - _min.Z;
            set => _max.Z = _min.Z + value;
        }

        /// <summary>
        /// Gets or sets the size of the box.
        /// </summary>
        public Vector3i Size
        {
            get => new Vector3i(_max.X - _min.X, _max.Y - _min.Y, _max.Z - _min.Z);
            set
            {
                _max.X = _min.X + value.X;
                _max.Y = _min.Y + value.Y;
                _max.Z = _min.Z + value.Z;
            }
        }

        /// <summary>
        /// Gets the location of the box.
        /// </summary>
        public Vector3i Location => _min;

        /// <summary>
        /// Gets a value indicating whether all values are zero.
        /// </summary>
        public bool IsZero => _min.X == 0 && _min.Y == 0 && _min.Z == 0
                           && _max.X == 0 && _max.Y == 0 && _max.Z == 0;

        /// <summary>
        /// Gets a box with a location 0,0,9 with the a size of 1.
        /// </summary>
        public static readonly Box3i UnitSquare = new Box3i(0, 0, 0, 1, 1, 1);

        /// <summary>
        /// Creates a box.
        /// </summary>
        /// <param name="location">The location of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>A box.</returns>
        public static Box3i FromSize(Vector3i location, Vector3i size)
        {
            return new Box3i(location, location + size);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>A box.</returns>
        public static Box3i FromPositions(Vector3i min, Vector3i max)
        {
            return new Box3i(min, max);
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
        /// <returns>A box.</returns>
        public static Box3i FromPositions(int minX, int minY, int minZ, int maxX, int maxY, int maxZ)
        {
            return new Box3i(minX, minY, minZ, maxX, maxY, maxZ);
        }

        /// <summary>
        /// Replaces this Box with the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box3i other)
        {
            Box3i result = Intersect(other, this);

            X = result.X;
            Y = result.Y;
            Z = result.Z;
            Width = result.Width;
            Height = result.Height;
            Depth = result.Depth;
        }

        /// <summary>
        /// Returns the intersection of two Boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of two Boxes.</returns>
        public static Box3i Intersect(Box3i a, Box3i b)
        {
            int minX = a._min.X > b._min.X ? a._min.X : b._min.X;
            int minY = a._min.Y > b._min.Y ? a._min.Y : b._min.Y;
            int minZ = a._min.Z > b._min.Z ? a._min.Z : b._min.Z;
            int maxX = a._max.X < b._max.X ? a._max.X : b._max.X;
            int maxY = a._max.Y < b._max.Y ? a._max.Y : b._max.Y;
            int maxZ = a._max.Z < b._max.Z ? a._max.Z : b._max.Z;

            if (maxX >= minX && maxY >= minY && maxZ >= minZ)
            {
                return new Box3i(minX, minY, minZ, maxX, maxY, maxZ);
            }

            return Empty;
        }

        /// <summary>
        /// Returns the intersection of itself and the specified Box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified Box.</returns>
        public Box3i Intersected(Box3i other)
        {
            return Intersect(other, this);
        }

        /// <summary>
        /// Determines if this Box intersects with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection, otherwise false.</returns>
        public bool IntersectsWith(Box3i other)
        {
            return other._min.X < _max.X
                && _min.X < other._max.X
                && other._min.Y < _max.Y
                && _min.Y < other._max.Y
                && other._min.Z < _max.Z
                && _min.Z < other._max.Z;
        }

        /// <summary>
        /// Determines if this Box intersects or touches with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection or touches, otherwise false.</returns>
        public bool TouchWith(Box3i other)
        {
            return other._min.X <= _max.X
                && _min.X <= other._max.X
                && other._min.Y <= _max.Y
                && _min.Y <= other._max.Y
                && other._min.Z <= _max.Z
                && _min.Z <= other._max.Z;
        }

        /// <summary>
        /// Gets a Box structure that contains the union of two Box structures.
        /// </summary>
        /// <param name="a">A Box to union.</param>
        /// <param name="b">a box to union.</param>
        /// <returns>A Box structure that bounds the union of the two Box structures.</returns>
        public static Box3i Union(Box3i a, Box3i b)
        {
            int minX = a._min.X < b._min.X ? a._min.X : b._min.X;
            int minY = a._min.Y < b._min.Y ? a._min.Y : b._min.Y;
            int minZ = a._min.Z < b._min.Z ? a._min.Z : b._min.Z;
            int maxX = a._max.X > b._max.X ? a._max.X : b._max.X;
            int maxY = a._max.Y > b._max.Y ? a._max.Y : b._max.Y;
            int maxZ = a._max.Z > b._max.Z ? a._max.Z : b._max.Z;

            return new Box3i(minX, minY, minZ, maxX, maxY, maxZ);
        }

        // --

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        [Obsolete("This function excludes borders even though it's documentation says otherwise. Use ContainsInclusive and ContainsExclusive for the desired behaviour.")]
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
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool ContainsInclusive(Vector3i point)
        {
            return _min.X <= point.X && point.X <= _max.X &&
                   _min.Y <= point.Y && point.Y <= _max.Y &&
                   _min.Z <= point.Z && point.Z <= _max.Z;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool ContainsExclusive(Vector3i point)
        {
            return _min.X < point.X && point.X < _max.X &&
                   _min.Y < point.Y && point.Y < _max.Y &&
                   _min.Z < point.Z && point.Z < _max.Z;
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
        public bool Contains(Vector3i point, bool boundaryInclusive)
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
        /// Inflate this Box3i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        public void Inflate(Vector3i point)
        {
            _min = Vector3i.ComponentMin(_min, point);
            _max = Vector3i.ComponentMax(_max, point);
        }

        /// <summary>
        /// Inflate this Box3i to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box3i Inflated(Vector3i point)
        {
            // create a local copy of this box
            Box3i box = this;
            box.Inflate(point);
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
