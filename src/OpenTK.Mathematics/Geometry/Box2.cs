using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
    public struct Box2 : IEquatable<Box2>, IFormattable
    {
        /// <summary>
        /// An empty box with <c>Min = Vector2.PositiveInfinity</c> and <c>Max = Vector2.NegativeInfinity</c>.
        /// This box can be used with <see cref="Extend(Vector2)"/> to create a bounding box without a special case for the first point.
        /// </summary>
        /// <example>
        /// For example:
        /// <code>
        /// Vector2[] points = GetPoints();
        /// Box2 aabb = Box2.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public static readonly Box2 Empty = new Box2(Vector2.PositiveInfinity, Vector2.NegativeInfinity);

        /// <summary>
        /// A box with a <c>Min = (0, 0)</c> and <c>Max = (1, 1)</c>.
        /// </summary>
        public static readonly Box2 UnitSquare = new Box2(Vector2.Zero, Vector2.One);

        /// <summary>
        /// The minimum boundary of the box.
        /// This field is not guaranteed to be less than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector2.PositiveInfinity</c> and <c>Max = Vector2.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        /// <seealso cref="Empty"/>
        /// <seealso cref="IsEmpty"/>
        public Vector2 Min;

        /// <summary>
        /// The maximum boundary of the box.
        /// This field is not guaranteed to be greater than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector2.PositiveInfinity</c> and <c>Max = Vector2.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        public Vector2 Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point this box encloses.</param>
        /// <param name="max">The maximum point this box encloses.</param>
        public Box2(Vector2 min, Vector2 max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        public Box2(float minX, float minY, float maxX, float maxY)
        {
            Min = (minX, minY);
            Max = (maxX, maxY);
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        [XmlIgnore]
        public Vector2 Center
        {
            readonly get => Min + HalfSize;
            set => Translate(value - Center);
        }

        /// <summary>
        /// Gets the location of the box from a Location + Size perspective. Basically an alias for <see cref="Min"/>.
        /// </summary>
        public readonly Vector2 Location => Min;

        /// <summary>
        /// Gets the size of the box.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector2 Size
        {
            get => Vector2.ComponentMax(Vector2.Zero, Max - Min);
        }

        /// <summary>
        /// Gets half the size of the box.
        /// The distance from the center of the box to the edge of the box in X and Y.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector2 HalfSize
        {
            get => Size / 2.0f;
        }

        /// <summary>
        /// The width of the box.
        /// </summary>
        public readonly float Width => Size.X;

        /// <summary>
        /// The height of the box.
        /// </summary>
        public readonly float Height => Size.Y;

        /// <summary>
        /// The area of the box.
        /// </summary>
        public readonly float Area => Size.X * Size.Y;

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
        public static Box2 FromSize(Vector2 point, Vector2 size)
        {
            return new Box2(point, point + size);
        }

        /// <summary>
        /// Creates a box from a minimum and maximum point.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>The created box.</returns>
        public static Box2 FromMinMax(Vector2 min, Vector2 max)
        {
            return new Box2(min, max);
        }

        /// <summary>
        /// Create a box from two unordered points, i.e. creates a box that contains two points.
        /// </summary>
        /// <param name="p1">The first point to contain.</param>
        /// <param name="p2">The second point to contain.</param>
        /// <returns>The created box.</returns>
        public static Box2 FromTwoPoints(Vector2 p1, Vector2 p2)
        {
            Vector2 min = Vector2.ComponentMin(p1, p2);
            Vector2 max = Vector2.ComponentMax(p1, p2);
            return new Box2(min, max);
        }

        /// <summary>
        /// Creates a box from a center point and a half size.
        /// </summary>
        /// <param name="center">The center of the box.</param>
        /// <param name="halfSize">The half size of the box.</param>
        /// <returns>The created box.</returns>
        public static Box2 FromCenterAndHalfSize(Vector2 center, Vector2 halfSize)
        {
            return new Box2(center - halfSize, center + halfSize);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box2 Intersect(Box2 a, Box2 b)
        {
            return Intersect(in a, in b);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box2 Intersect(in Box2 a, in Box2 b)
        {
            Vector2.ComponentMax(in a.Min, in b.Min, out Vector2 min);
            Vector2.ComponentMin(in a.Max, in b.Max, out Vector2 max);
            if (max.X >= min.X && max.Y >= min.Y)
            {
                return new Box2(min, max);
            }
            else
            {
                return Box2.Empty;
            }
        }

        /// <summary>
        /// Replaces this box with the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box2 other)
        {
            this = Intersect(in this, in other);
        }

        /// <summary>
        /// Returns the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified box.</returns>
        public readonly Box2 Intersected(Box2 other)
        {
            return Intersect(this, other);
        }

        /// <summary>
        /// Determines if this box intersects with another box.
        /// </summary>
        /// <remarks>
        /// Two boxes next to each other do not intersect, for detecting that case use <see cref="Touches(Box2)"/>.
        /// </remarks>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection, otherwise <see langword="false"/>.</returns>
        public readonly bool IntersectsWith(Box2 other)
        {
            return other.Min.X < Max.X && Min.X < other.Max.X &&
                   other.Min.Y < Max.Y && Min.Y < other.Max.Y;
        }

        /// <summary>
        /// Determines if this box intersects or touches with another box.
        /// </summary>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection or touches, otherwise <see langword="false"/>.</returns>
        public readonly bool Touches(Box2 other)
        {
            return other.Min.X <= Max.X && Min.X <= other.Max.X &&
                   other.Min.Y <= Max.Y && Min.Y <= other.Max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        /// <seealso cref="ContainsExclusive(Vector2)"/>
        public readonly bool ContainsInclusive(Vector2 point)
        {
            return Min.X <= point.X && Min.Y <= point.Y &&
                point.X <= Max.X && point.Y <= Max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        /// <seealso cref="ContainsInclusive(Vector2)"/>
        public readonly bool ContainsExclusive(Vector2 point)
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
        public readonly bool Contains(Box2 other)
        {
            return Min.X <= other.Min.X && Min.Y <= other.Min.Y &&
                Max.X >= other.Max.X && Max.Y >= other.Max.Y;
        }

        /// <summary>
        /// Returns the distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly float DistanceToNearestEdge(Vector2 point)
        {
            // FIXME: What if the point is inside the box?
            Vector2 dist = Vector2.ComponentMax(Vector2.Zero, Vector2.ComponentMax(Min - point, point - Max));
            return dist.Length;
        }

        /// <summary>
        /// Returns the signed distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly float SignedDistanceToNearestEdge(Vector2 point)
        {
            Vector2 d = Vector2.Abs(point - Center) - HalfSize;
            return Vector2.ComponentMax(Vector2.Zero, d).Length + MathF.Min(MathF.Max(d.X, d.Y), 0.0f);
        }

        /// <summary>
        /// Returns the nearest point in or on the edge of the box to the given point, <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The point for which the nearest point in the box should be found.</param>
        /// <returns>The nearest point on or on the edge of the box to the point, <paramref name="point"/>.</returns>
        public readonly Vector2 NearestPointInBox(Vector2 point)
        {
            return Vector2.ComponentMin(Max, Vector2.ComponentMax(Min, point));
        }

        /// <summary>
        /// Returns a box that contains rounded integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded integers.</returns>
        /// <see cref="Ceiling(Box2)"/>
        /// <see cref="Floor(Box2)"/>
        /// <see cref="FloorCeiling(Box2)"/>
        public static Box2 Round(Box2 box)
        {
            return new Box2(Vector2.Round(box.Min), Vector2.Round(box.Max));
        }

        /// <summary>
        /// Returns a box that contains rounded up integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded up integers.</returns>
        /// <see cref="Round(Box2)"/>
        /// <see cref="Floor(Box2)"/>
        /// <see cref="FloorCeiling(Box2)"/>
        public static Box2 Ceiling(Box2 box)
        {
            return new Box2(Vector2.Ceiling(box.Min), Vector2.Ceiling(box.Max));
        }

        /// <summary>
        /// Returns a box that contains rounded down integers.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded down integers.</returns>
        /// <see cref="Round(Box2)"/>
        /// <see cref="Ceiling(Box2)"/>
        /// <see cref="FloorCeiling(Box2)"/>
        public static Box2 Floor(Box2 box)
        {
            return new Box2(Vector2.Floor(box.Min), Vector2.Floor(box.Max));
        }

        /// <summary>
        /// Returns a box where <see cref="Min"/> has been rounded down and <see cref="Max"/> has been rounded up.
        /// </summary>
        /// <param name="box">The box to round.</param>
        /// <returns>The box that contains rounded down integers.</returns>
        /// <see cref="Round(Box2)"/>
        /// <see cref="Ceiling(Box2)"/>
        /// <see cref="Floor(Box2)"/>
        public static Box2 FloorCeiling(Box2 box)
        {
            return new Box2(Vector2.Floor(box.Min), Vector2.Ceiling(box.Max));
        }

        /// <summary>
        /// Translates this box by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2 distance)
        {
            Min += distance;
            Max += distance;
        }

        /// <summary>
        /// Returns a box translated by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        public readonly Box2 Translated(Vector2 distance)
        {
            Box2 box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this box by the given scale, <paramref name="scale"/>, and from the given anchor point, <paramref name="anchor"/>.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector2 scale, Vector2 anchor)
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
        public readonly Box2 Scaled(Vector2 scale, Vector2 anchor)
        {
            Box2 box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflates this box by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        public void Inflate(Vector2 size)
        {
            size = Vector2.ComponentMax(size, -HalfSize);
            Vector2 newMin = Min - size;
            Vector2 newMax = Max + size;
            Min = Vector2.ComponentMin(newMin, newMax);
            Max = Vector2.ComponentMax(newMin, newMax);
        }

        /// <summary>
        /// Returns a box inflated by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        /// <returns>The inflated box.</returns>
        public readonly Box2 Inflated(Vector2 size)
        {
            Box2 box = this;
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
        /// Vector2[] points = GetPoints();
        /// Box2 aabb = Box2.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public void Extend(Vector2 point)
        {
            Min = Vector2.ComponentMin(Min, point);
            Max = Vector2.ComponentMax(Max, point);
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
        /// Vector2[] points = GetPoints();
        /// Box2 aabb = Box2.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb = aabb.Extended(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public readonly Box2 Extended(Vector2 point)
        {
            Box2 box = this;
            box.Extend(point);
            return box;
        }

        /// <inheritdoc/>
        public readonly override bool Equals(object obj)
        {
            return obj is Box2 box && Equals(box);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Box2 other)
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

        /// <summary>
        /// Converts this <see cref="Box2"/> to a <see cref="System.Drawing.Rectangle"/> using <see cref="Min"/> as the position and <see cref="Size"/> as the size.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        public static explicit operator System.Drawing.RectangleF(Box2 box)
        {
            return new System.Drawing.RectangleF((System.Drawing.PointF)box.Min, (System.Drawing.SizeF)box.Size);
        }

        /// <summary>
        /// Converts this <see cref="Box2"/> to a <see cref="Box2d"/>.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        public static explicit operator Box2d(Box2 box)
        {
            return new Box2d(box.Min, box.Max);
        }

        /// <summary>
        /// Converts this <see cref="Box2"/> to a <see cref="Box2i"/> using truncation.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        /// <see cref="Round(Box2)"/>
        /// <see cref="Ceiling(Box2)"/>
        /// <see cref="Floor(Box2)"/>
        /// <see cref="FloorCeiling(Box2)"/>
        public static explicit operator Box2i(Box2 box)
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
