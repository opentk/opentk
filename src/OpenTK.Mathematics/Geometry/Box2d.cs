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
    /// Defines an axis-aligned 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [Serializable]
    public struct Box2d : IEquatable<Box2d>, IFormattable
    {
        /// <summary>
        /// An empty box with <c>Min = Vector2d.PositiveInfinity</c> and <c>Max = Vector2d.NegativeInfinity</c>.
        /// This box can be used with <see cref="Extend(Vector2d)"/> to create a bounding box without a special case for the first point.
        /// </summary>
        /// <example>
        /// For example:
        /// <code>
        /// Vector2d[] points = GetPoints();
        /// Box2d aabb = Box2d.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public static readonly Box2d Empty = new Box2d(Vector2d.PositiveInfinity, Vector2d.NegativeInfinity);

        /// <summary>
        /// A box with a <c>Min = (0, 0)</c> and <c>Max = (1, 1)</c>.
        /// </summary>
        public static readonly Box2d UnitSquare = new Box2d(Vector2d.Zero, Vector2d.One);

        /// <summary>
        /// The minimum boundary of the box.
        /// This field is not guaranteed to be less than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector2d.PositiveInfinity</c> and <c>Max = Vector2d.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        /// <seealso cref="Empty"/>
        /// <seealso cref="IsEmpty"/>
        public Vector2d Min;

        /// <summary>
        /// The maximum boundary of the box.
        /// This field is not guaranteed to be greater than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector2d.PositiveInfinity</c> and <c>Max = Vector2d.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        public Vector2d Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2d"/> struct.
        /// </summary>
        /// <param name="min">The minimum point this box encloses.</param>
        /// <param name="max">The maximum point this box encloses.</param>
        public Box2d(Vector2d min, Vector2d max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2d"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        public Box2d(double minX, double minY, double maxX, double maxY)
        {
            Min = (minX, minY);
            Max = (maxX, maxY);
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2d Center
        {
            readonly get => Min + HalfSize;
            set => Translate(value - Center);
        }

        /// <summary>
        /// Gets the size of the box.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector2d Size
        {
            get => Vector2d.ComponentMax(Vector2d.Zero, Max - Min);
        }

        /// <summary>
        /// Gets half the size of the box.
        /// The distance from the center of the box to the edge of the box in X and Y.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector2d HalfSize
        {
            get => Size / 2.0f;
        }

        /// <summary>
        /// The width of the box.
        /// </summary>
        public readonly double Width => Size.X;

        /// <summary>
        /// The height of the box.
        /// </summary>
        public readonly double Height => Size.Y;

        /// <summary>
        /// The area of the box.
        /// </summary>
        public readonly double Area => Size.X * Size.Y;

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
        public readonly bool HasZeroArea => Area == 0;

        /// <summary>
        /// Creates a box from a point and size.
        /// </summary>
        /// <param name="point">The minimum point of the box.</param>
        /// <param name="size">The size of the box.</param>
        /// <returns>The created box.</returns>
        public static Box2d FromSize(Vector2d point, Vector2d size)
        {
            return new Box2d(point, point + size);
        }

        /// <summary>
        /// Creates a box from a minimum and maximum point.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>The created box.</returns>
        public static Box2d FromPositions(Vector2d min, Vector2d max)
        {
            return new Box2d(min, max);
        }

        /// <summary>
        /// Creates a box from a center point and a half size.
        /// </summary>
        /// <param name="center">The center of the box.</param>
        /// <param name="halfSize">The half size of the box.</param>
        /// <returns>The created box.</returns>
        public static Box2d FromPositionAndHalfSize(Vector2d center, Vector2d halfSize)
        {
            return new Box2d(center - halfSize, center + halfSize);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box2d Intersect(Box2d a, Box2d b)
        {
            return Intersect(in a, in b);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two Boxes.</returns>
        public static Box2d Intersect(in Box2d a, in Box2d b)
        {
            Vector2d.ComponentMax(in a.Min, in b.Min, out Vector2d min);
            Vector2d.ComponentMin(in a.Max, in b.Max, out Vector2d max);
            if (max.X >= min.X && max.Y >= min.Y)
            {
                return new Box2d(min, max);
            }
            else
            {
                return Box2d.Empty;
            }
        }

        /// <summary>
        /// Replaces this box with the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The box with which to intersect.</param>
        public void Intersect(Box2d other)
        {
            this = Intersect(in this, in other);
        }

        /// <summary>
        /// Returns the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified box.</returns>
        public readonly Box2d Intersected(Box2d other)
        {
            return Intersect(this, other);
        }

        /// <summary>
        /// Determines if this box intersects with another box.
        /// </summary>
        /// <remarks>
        /// Two boxes next to each other do not intersect, for detecting that case use <see cref="Touches(Box2d)"/>.
        /// </remarks>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection, otherwise <see langword="false"/>.</returns>
        public readonly bool IntersectsWith(Box2d other)
        {
            return other.Min.X < Max.X && Min.X < other.Max.X &&
                   other.Min.Y < Max.Y && Min.Y < other.Max.Y;
        }

        /// <summary>
        /// Determines if this box intersects or touches with another box.
        /// </summary>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection or touches, otherwise <see langword="false"/>.</returns>
        public readonly bool Touches(Box2d other)
        {
            return other.Min.X <= Max.X && Min.X <= other.Max.X &&
                   other.Min.Y <= Max.Y && Min.Y <= other.Max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        /// <seealso cref="ContainsExclusive(Vector2d)"/>
        public readonly bool ContainsInclusive(Vector2d point)
        {
            return Min.X <= point.X && Min.Y <= point.Y &&
                point.X <= Max.X && point.Y <= Max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        /// <seealso cref="ContainsInclusive(Vector2d)"/>
        public readonly bool ContainsExclusive(Vector2d point)
        {
            return Min.X < point.X && Min.Y < point.Y &&
                point.X < Max.X && point.Y < Max.Y;
        }

        /// <summary>
        /// Returns whether the box <paramref name="other"/> is entirely contained within this box.
        /// A box is considered to be able to contain itself.
        /// </summary>
        /// <param name="other">The box to check.</param>
        /// <returns><see langword="true"/> if the box <paramref name="other"/> is entirely contained within the this box; otherwise, <see langword="false"/>.</returns>
        public readonly bool Contains(Box2d other)
        {
            return Min.X <= other.Min.X && Min.Y <= other.Min.Y &&
                Max.X >= other.Max.X && Max.Y >= other.Max.Y;
        }

        /// <summary>
        /// Returns the distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly double DistanceToNearestEdge(Vector2d point)
        {
            // FIXME: What if the point is inside the box?
            Vector2d dist = Vector2d.ComponentMax(Vector2d.Zero, Vector2d.ComponentMax(Min - point, point - Max));
            return dist.Length;
        }

        /// <summary>
        /// Returns the signed distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly double SignedDistanceToNearestEdge(Vector2d point)
        {
            Vector2d d = Vector2d.Abs(point - Center) - HalfSize;
            return Vector2d.ComponentMax(Vector2d.Zero, d).Length + Math.Min(Math.Max(d.X, d.Y), 0.0);
        }

        /// <summary>
        /// Returns the nearest point in or on the edge of the box to the given point, <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The point for which the nearest point in the box should be found.</param>
        /// <returns>The nearest point on or on the edge of the box to the point, <paramref name="point"/>.</returns>
        public readonly Vector2d NearestPointInBox(Vector2d point)
        {
            return Vector2d.ComponentMin(Max, Vector2d.ComponentMax(Min, point));
        }

        /// <summary>
        /// Returns a box that contains rounded integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded integers.</returns>
        /// <see cref="Ceiling(Box2d)"/>
        /// <see cref="Floor(Box2d)"/>
        /// <see cref="FloorCeiling(Box2d)"/>
        public static Box2d Round(Box2d box)
        {
            return new Box2d(Vector2d.Round(box.Min), Vector2d.Round(box.Max));
        }

        /// <summary>
        /// Returns a box that contains rounded up integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded up integers.</returns>
        /// <see cref="Round(Box2d)"/>
        /// <see cref="Floor(Box2d)"/>
        /// <see cref="FloorCeiling(Box2d)"/>
        public static Box2d Ceiling(Box2d box)
        {
            return new Box2d(Vector2d.Ceiling(box.Min), Vector2d.Ceiling(box.Max));
        }

        /// <summary>
        /// Returns a box that contains rounded down integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded down integers.</returns>
        /// <see cref="Round(Box2d)"/>
        /// <see cref="Ceiling(Box2d)"/>
        /// <see cref="FloorCeiling(Box2d)"/>
        public static Box2d Floor(Box2d box)
        {
            return new Box2d(Vector2d.Floor(box.Min), Vector2d.Floor(box.Max));
        }

        /// <summary>
        /// Returns a box where <see cref="Min"/> has been rounded down and <see cref="Max"/> has been rounded up.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded down integers.</returns>
        /// <see cref="Round(Box2d)"/>
        /// <see cref="Ceiling(Box2d)"/>
        /// <see cref="Floor(Box2d)"/>
        public static Box2d FloorCeiling(Box2d box)
        {
            return new Box2d(Vector2d.Floor(box.Min), Vector2d.Ceiling(box.Max));
        }

        /// <summary>
        /// Translates this box by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2d distance)
        {
            Min += distance;
            Max += distance;
        }

        /// <summary>
        /// Returns a box translated by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        public readonly Box2d Translated(Vector2d distance)
        {
            Box2d box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this box by the given scale, <paramref name="scale"/>, and from the given anchor point, <paramref name="anchor"/>.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector2d scale, Vector2d anchor)
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
        public readonly Box2d Scaled(Vector2d scale, Vector2d anchor)
        {
            Box2d box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflates this box by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        public void Inflate(Vector2d size)
        {
            size = Vector2d.ComponentMax(size, -HalfSize);
            Vector2d newMin = Min - size;
            Vector2d newMax = Max + size;
            Min = Vector2d.ComponentMin(newMin, newMax);
            Max = Vector2d.ComponentMax(newMin, newMax);
        }

        /// <summary>
        /// Returns a box inflated by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        /// <returns>The inflated box.</returns>
        public readonly Box2d Inflated(Vector2d size)
        {
            Box2d box = this;
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
        /// Vector2d[] points = GetPoints();
        /// Box2d aabb = Box2d.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public void Extend(Vector2d point)
        {
            Min = Vector2d.ComponentMin(Min, point);
            Max = Vector2d.ComponentMax(Max, point);
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
        /// Vector2d[] points = GetPoints();
        /// Box2d aabb = Box2d.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb = aabb.Extended(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public readonly Box2d Extended(Vector2d point)
        {
            Box2d box = this;
            box.Extend(point);
            return box;
        }

        /// <inheritdoc/>
        public readonly override bool Equals(object obj)
        {
            return obj is Box2d box && Equals(box);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Box2d other)
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

        /// <summary>
        /// Converts this <see cref="Box2d"/> to a <see cref="Box2"/>.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        public static explicit operator Box2(Box2d box)
        {
            return new Box2((Vector2)box.Min, (Vector2)box.Size);
        }

        /// <summary>
        /// Converts this <see cref="Box2d"/> to a <see cref="Box2i"/> using truncation.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        /// <see cref="Round(Box2d)"/>
        /// <see cref="Ceiling(Box2d)"/>
        /// <see cref="Floor(Box2d)"/>
        /// <see cref="FloorCeiling(Box2d)"/>
        public static explicit operator Box2i(Box2d box)
        {
            return new Box2i((Vector2i)box.Min, (Vector2i)box.Max);
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
