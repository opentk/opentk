using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Defines an axis-aligned 3d box (cube).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Box3 : IEquatable<Box3>, IFormattable
    {
        /// <summary>
        /// An empty box with <c>Min = Vector3.PositiveInfinity</c> and <c>Max = Vector3.NegativeInfinity</c>.
        /// This box can be used with <see cref="Extend(Vector3)"/> to create a bounding box without a special case for the first point.
        /// </summary>
        /// <example>
        /// For example:
        /// <code>
        /// Vector3[] points = GetPoints();
        /// Box3 aabb = Box3.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public static readonly Box3 Empty = new Box3(Vector3.PositiveInfinity, Vector3.NegativeInfinity);

        /// <summary>
        /// A box with a <c>Min = (0, 0, 0)</c> and <c>Max = (1, 1, 1)</c>.
        /// </summary>
        public static readonly Box3 UnitCube = new Box3(Vector3.Zero, Vector3.One);

        /// <summary>
        /// The minimum boundary of the box.
        /// This field is not guaranteed to be less than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector3.PositiveInfinity</c> and <c>Max = Vector3.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        /// <seealso cref="Empty"/>
        /// <seealso cref="IsEmpty"/>
        public Vector3 Min;

        /// <summary>
        /// The maximum boundary of the box.
        /// This field is not guaranteed to be greater than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector3.PositiveInfinity</c> and <c>Max = Vector3.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        public Vector3 Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3"/> struct.
        /// </summary>
        /// <param name="min">The minimum point this box encloses.</param>
        /// <param name="max">The maximum point this box encloses.</param>
        public Box3(Vector3 min, Vector3 max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box3"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="minZ">The minimum Z value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        /// <param name="maxZ">The maximum Z value to be enclosed.</param>
        public Box3(float minX, float minY, float minZ, float maxX, float maxY, float maxZ)
        {
            Min = (minX, minY, minZ);
            Max = (maxX, maxY, maxZ);
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        [XmlIgnore]
        public Vector3 Center
        {
            readonly get => Min + HalfSize;
            set => Translate(value - Center);
        }

        /// <summary>
        /// Gets the location of the box from a Location + Size perspective. Basically an alias for <see cref="Min"/>.
        /// </summary>
        public readonly Vector3 Location => Min;

        /// <summary>
        /// Gets the size of the box.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector3 Size
        {
            get => Vector3.ComponentMax(Vector3.Zero, Max - Min);
        }

        /// <summary>
        /// Gets half the size of the box.
        /// The distance from the center of the box to the edge of the box in X and Y.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector3 HalfSize
        {
            get => Size / 2.0f;
        }

        /// <summary>
        /// The width of the box.
        /// </summary>
        public float Width => Size.X;

        /// <summary>
        /// The height of the box.
        /// </summary>
        public float Height => Size.Y;

        /// <summary>
        /// The depth of the box.
        /// </summary>
        public float Depth => Size.Z;

        /// <summary>
        /// The volume of the box.
        /// </summary>
        public readonly float Volume => Size.X * Size.Y * Size.Z;

        /// <summary>
        /// If this box is equal to <see cref="Empty"/>.
        /// </summary>
        public readonly bool IsEmpty => this == Empty;

        /// <summary>
        /// If this box is a point, i.e. its minimum point is equal to its maximum point.
        /// </summary>
        public readonly bool IsPoint => Min == Max;

        /// <summary>
        /// If this box has zero area.
        /// </summary>
        public readonly bool HasZeroVolume => Volume == 0;

        /// <summary>
        /// Creates a box from a point and size.
        /// </summary>
        /// <param name="point">The minimum point of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>The created box.</returns>
        public static Box3 FromSize(Vector3 point, Vector3 size)
        {
            return new Box3(point, point + size);
        }

        /// <summary>
        /// Creates a box from a minimum and maximum point.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>The created box.</returns>
        public static Box3 FromMinMax(Vector3 min, Vector3 max)
        {
            return new Box3(min, max);
        }

        /// <summary>
        /// Create a box from two unordered points, i.e. creates a box that contains two points.
        /// </summary>
        /// <param name="p1">The first point to contain.</param>
        /// <param name="p2">The second point to contain.</param>
        /// <returns>The created box.</returns>
        public static Box3 FromTwoPoints(Vector3 p1, Vector3 p2)
        {
            Vector3 min = Vector3.ComponentMin(p1, p2);
            Vector3 max = Vector3.ComponentMax(p1, p2);
            return new Box3(min, max);
        }

        /// <summary>
        /// Creates a box from a center point and a half size.
        /// </summary>
        /// <param name="center">The center of the box.</param>
        /// <param name="halfSize">The half size of the box.</param>
        /// <returns>The created box.</returns>
        public static Box3 FromCenterAndHalfSize(Vector3 center, Vector3 halfSize)
        {
            return new Box3(center - halfSize, center + halfSize);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box3 Intersect(Box3 a, Box3 b)
        {
            Vector3 min = Vector3.ComponentMax(a.Min, b.Min);
            Vector3 max = Vector3.ComponentMin(a.Max, b.Max);
            if (max.X >= min.X && max.Y >= min.Y && max.Z >= min.Z)
            {
                return new Box3(min, max);
            }
            else
            {
                return Box3.Empty;
            }
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box3 Intersect(in Box3 a, in Box3 b)
        {
            Vector3.ComponentMax(in a.Min, in b.Min, out Vector3 min);
            Vector3.ComponentMin(in a.Max, in b.Max, out Vector3 max);
            if (max.X >= min.X && max.Y >= min.Y && max.Z >= min.Z)
            {
                return new Box3(min, max);
            }
            else
            {
                return Box3.Empty;
            }
        }

        /// <summary>
        /// Replaces this box with the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The box with which to intersect.</param>
        public void Intersect(Box3 other)
        {
            this = Intersect(in this, in other);
        }

        /// <summary>
        /// Returns the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified box.</returns>
        public readonly Box3 Intersected(Box3 other)
        {
            return Intersect(this, other);
        }

        /// <summary>
        /// Determines if this box intersects with another box.
        /// </summary>
        /// <remarks>
        /// Two boxes next to each other do not intersect, for detecting that case use <see cref="Touches(Box3)"/>.
        /// </remarks>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection, otherwise <see langword="false"/>.</returns>
        public readonly bool IntersectsWith(Box3 other)
        {
            return other.Min.X < Max.X && Min.X < other.Max.X &&
                   other.Min.Y < Max.Y && Min.Y < other.Max.Y &&
                   other.Min.Z < Max.Z && Min.Z < other.Max.Z;
        }

        /// <summary>
        /// Determines if this box intersects or touches with another box.
        /// </summary>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection or touches, otherwise <see langword="false"/>.</returns>
        public readonly bool Touches(Box3 other)
        {
            return other.Min.X <= Max.X && Min.X <= other.Max.X &&
                   other.Min.Y <= Max.Y && Min.Y <= other.Max.Y &&
                   other.Min.Z <= Max.Z && Min.Z <= other.Max.Z;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        /// <seealso cref="ContainsExclusive(Vector3)"/>
        public readonly bool ContainsInclusive(Vector3 point)
        {
            return Min.X <= point.X && Min.Y <= point.Y && Min.Z <= point.Z &&
                point.X <= Max.X && point.Y <= Max.Y && point.Z <= Max.Z;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        /// <seealso cref="ContainsInclusive(Vector3)"/>
        public readonly bool ContainsExclusive(Vector3 point)
        {
            return Min.X < point.X && Min.Y < point.Y && Min.Z < point.Z &&
                point.X < Max.X && point.Y < Max.Y && point.Z < Max.Z;
        }

        /// <summary>
        /// Returns whether the box <paramref name="other"/> is entirely contained within this box.
        /// A box is considered to be able to contain itself.
        /// </summary>
        /// <param name="other">The box to check.</param>
        /// <returns><see langword="true"/> if the box <paramref name="other"/> is entirely contained within the this box; otherwise, <see langword="false"/>.</returns>
        public readonly bool Contains(Box3 other)
        {
            return Min.X <= other.Min.X && Min.Y <= other.Min.Y && Min.Z <= other.Min.Z &&
                   Max.X >= other.Max.X && Max.Y >= other.Max.Y && Max.Z >= other.Max.Z;
        }

        /// <summary>
        /// Returns the distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly float DistanceToNearestEdge(Vector3 point)
        {
            // FIXME: What if the point is inside the box?
            Vector3 dist = Vector3.ComponentMax(Vector3.Zero, Vector3.ComponentMax(Min - point, point - Max));
            return dist.Length;
        }

        /// <summary>
        /// Returns the signed distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly float SignedDistanceToNearestEdge(Vector3 point)
        {
            Vector3 d = Vector3.Abs(point - Center) - HalfSize;
            return Vector3.ComponentMax(Vector3.Zero, d).Length + MathF.Min(MathF.Max(d.X, MathF.Max(d.Y, d.Z)), 0.0f);
        }

        /// <summary>
        /// Returns the nearest point in or on the edge of the box to the given point, <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The point for which the nearest point in the box should be found.</param>
        /// <returns>The nearest point on or on the edge of the box to the point, <paramref name="point"/>.</returns>
        public readonly Vector3 NearestPointInBox(Vector3 point)
        {
            return Vector3.ComponentMin(Max, Vector3.ComponentMax(Min, point));
        }

        /// <summary>
        /// Returns a box that contains rounded integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded integers.</returns>
        /// <see cref="Ceiling(Box3)"/>
        /// <see cref="Floor(Box3)"/>
        /// <see cref="FloorCeiling(Box3)"/>
        public static Box3 Round(Box3 box)
        {
            return new Box3(Vector3.Round(box.Min), Vector3.Round(box.Max));
        }

        /// <summary>
        /// Returns a box that contains rounded up integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded up integers.</returns>
        /// <see cref="Round(Box3)"/>
        /// <see cref="Floor(Box3)"/>
        /// <see cref="FloorCeiling(Box3)"/>
        public static Box3 Ceiling(Box3 box)
        {
            return new Box3(Vector3.Ceiling(box.Min), Vector3.Ceiling(box.Max));
        }

        /// <summary>
        /// Returns a box that contains rounded down integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded down integers.</returns>
        /// <see cref="Round(Box3)"/>
        /// <see cref="Ceiling(Box3)"/>
        /// <see cref="FloorCeiling(Box3)"/>
        public static Box3 Floor(Box3 box)
        {
            return new Box3(Vector3.Floor(box.Min), Vector3.Floor(box.Max));
        }

        /// <summary>
        /// Returns a box where <see cref="Min"/> has been rounded down and <see cref="Max"/> has been rounded up.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded down integers.</returns>
        /// <see cref="Round(Box3)"/>
        /// <see cref="Ceiling(Box3)"/>
        /// <see cref="Floor(Box3)"/>
        public static Box3 FloorCeiling(Box3 box)
        {
            return new Box3(Vector3.Floor(box.Min), Vector3.Ceiling(box.Max));
        }

        /// <summary>
        /// Translates this box by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector3 distance)
        {
            Min += distance;
            Max += distance;
        }

        /// <summary>
        /// Returns a box translated by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        public readonly Box3 Translated(Vector3 distance)
        {
            Box3 box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this box by the given scale, <paramref name="scale"/>, and from the given anchor point, <paramref name="anchor"/>.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector3 scale, Vector3 anchor)
        {
            Min = anchor + ((Min - anchor) * scale);
            Max = anchor + ((Max - anchor) * scale);
        }

        /// <summary>
        /// Returns a box scaled by the given scale, <paramref name="scale"/>, and from the given anchor point, <paramref name="anchor"/>.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
        public readonly Box3 Scaled(Vector3 scale, Vector3 anchor)
        {
            Box3 box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflates this box by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        public void Inflate(Vector3 size)
        {
            size = Vector3.ComponentMax(size, -HalfSize);
            Vector3 newMin = Min - size;
            Vector3 newMax = Max + size;
            Min = Vector3.ComponentMin(newMin, newMax);
            Max = Vector3.ComponentMax(newMin, newMax);
        }

        /// <summary>
        /// Returns a box inflated by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        /// <returns>The inflated box.</returns>
        public readonly Box3 Inflated(Vector3 size)
        {
            Box3 box = this;
            box.Inflate(size);
            return box;
        }

        /// <summary>
        /// Extends this box to encapsulate a given point.
        /// </summary>
        /// <remarks>
        /// This can be used in combination with <see cref="Empty"/> to make an efficient bounding box calculation.
        /// </remarks>
        /// <param name="point">The point to contain.</param>
        /// <example>
        /// For example:
        /// <code>
        /// Vector3[] points = GetPoints();
        /// Box3 aabb = Box3.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public void Extend(Vector3 point)
        {
            Min = Vector3.ComponentMin(Min, point);
            Max = Vector3.ComponentMax(Max, point);
        }

        /// <summary>
        /// Returns a box that is extended to encapsulate a given point.
        /// </summary>
        /// <remarks>
        /// This can be used in combination with <see cref="Empty"/> to make an efficient bounding box calculation.
        /// </remarks>
        /// <param name="point">The point to contain.</param>
        /// <returns>The extended box.</returns>
        /// <example>
        /// For example:
        /// <code>
        /// Vector3[] points = GetPoints();
        /// Box3 aabb = Box3.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb = aabb.Extended(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public readonly Box3 Extended(Vector3 point)
        {
            Box3 box = this;
            box.Extend(point);
            return box;
        }

        /// <inheritdoc/>
        public readonly override bool Equals(object obj)
        {
            return obj is Box3 box && Equals(box);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Box3 other)
        {
            return Min.Equals(other.Min) &&
                   Max.Equals(other.Max);
        }

        /// <inheritdoc/>
        public readonly override int GetHashCode()
        {
            return HashCode.Combine(Min, Max);
        }

        /// <summary>
        /// Equality comparator.
        /// Two boxes are considered equal if both the <see cref="Min"/> and <see cref="Max"/> fields are equal.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator ==(Box3 left, Box3 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Inequality comparator.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        public static bool operator !=(Box3 left, Box3 right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts this <see cref="Box3"/> to a <see cref="Box3d"/>.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        public static explicit operator Box3d(Box3 box)
        {
            return new Box3d(box.Min, box.Max);
        }

        /// <summary>
        /// Converts this <see cref="Box3"/> to a <see cref="Box3i"/> using truncation.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        /// <see cref="Round(Box3)"/>
        /// <see cref="Ceiling(Box3)"/>
        /// <see cref="Floor(Box3)"/>
        /// <see cref="FloorCeiling(Box3)"/>
        public static explicit operator Box3i(Box3 box)
        {
            return new Box3i((Vector3i)box.Min, (Vector3i)box.Max);
        }

        /// <inheritdoc/>
        public override readonly string ToString()
        {
            return ToString(null, null);
        }

        /// <inheritdoc cref="ToString(string, IFormatProvider)"/>
        public readonly string ToString(string format)
        {
            return ToString(format, null);
        }

        /// <inheritdoc cref="ToString(string, IFormatProvider)"/>
        public readonly string ToString(IFormatProvider formatProvider)
        {
            return ToString(null, formatProvider);
        }

        /// <inheritdoc/>
        public readonly string ToString(string format, IFormatProvider formatProvider)
        {
            return $"{Min.ToString(format, formatProvider)} - {Max.ToString(format, formatProvider)}";
        }
    }
}
