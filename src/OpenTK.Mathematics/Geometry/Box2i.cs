using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        /// An empty box with <c>Min = Vector2i.MaxValue</c> and <c>Max = Vector2i.MinValue</c>.
        /// This box can be used with <see cref="Extend(Vector2i)"/> to create a bounding box without a special case for the first point.
        /// </summary>
        /// <example>
        /// For example:
        /// <code>
        /// Vector2i[] points = GetPoints();
        /// Box2i aabb = Box2i.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public static readonly Box2i Empty = new Box2i(Vector2i.MaxValue, Vector2i.MinValue);

        /// <summary>
        /// A box with a <c>Min = (0, 0)</c> and <c>Max = (1, 1)</c>.
        /// </summary>
        public static readonly Box2i UnitSquare = new Box2i(Vector2i.Zero, Vector2i.One);

        /// <summary>
        /// The minimum boundary of the box.
        /// This field is not guaranteed to be less than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector2i.PositiveInfinity</c> and <c>Max = Vector2i.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        /// <seealso cref="Empty"/>
        /// <seealso cref="IsEmpty"/>
        public Vector2i Min;

        /// <summary>
        /// The maximum boundary of the box.
        /// This field is not guaranteed to be greater than <see cref="Max"/>.
        /// </summary>
        /// <remarks>
        /// A box with a minimum point greater than the maximum is not considered valid
        /// except for a single configuration where <c>Min = Vector2i.PositiveInfinity</c> and <c>Max = Vector2i.NegativeInfinity</c> as is the case with <see cref="Empty"/>.
        /// </remarks>
        public Vector2i Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2i"/> struct.
        /// </summary>
        /// <param name="min">The minimum point this box encloses.</param>
        /// <param name="max">The maximum point this box encloses.</param>
        public Box2i(Vector2i min, Vector2i max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2i"/> struct.
        /// </summary>
        /// <param name="minX">The minimum X value to be enclosed.</param>
        /// <param name="minY">The minimum Y value to be enclosed.</param>
        /// <param name="maxX">The maximum X value to be enclosed.</param>
        /// <param name="maxY">The maximum Y value to be enclosed.</param>
        public Box2i(int minX, int minY, int maxX, int maxY)
        {
            Min = (minX, minY);
            Max = (maxX, maxY);
        }

        /// <summary>
        /// Gets a vector describing the center of the box.
        /// </summary>
        public readonly Vector2 Center
        {
             get => Min + HalfSize;
        }

        /// <summary>
        /// Gets the size of the box.
        /// </summary>
        /// <remarks>
        /// This function never returns negative values, so <see cref="Empty"/> will have a size of (0, 0).
        /// </remarks>
        public readonly Vector2i Size
        {
            get => Vector2i.ComponentMax(Vector2i.Zero, Max - Min);
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
            get => (Vector2)Size / 2.0f;
        }

        /// <summary>
        /// The width of the box.
        /// </summary>
        public readonly int Width => Size.X;

        /// <summary>
        /// The height of the box.
        /// </summary>
        public readonly int Height => Size.Y;

        /// <summary>
        /// The area of the box.
        /// </summary>
        public readonly int Area => Size.X * Size.Y;

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
        public static Box2i FromSize(Vector2i point, Vector2i size)
        {
            return new Box2i(point, point + size);
        }

        /// <summary>
        /// Creates a box from a minimum and maximum point.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        /// <returns>The created box.</returns>
        public static Box2i FromPositions(Vector2i min, Vector2i max)
        {
            return new Box2i(min, max);
        }

        /// <summary>
        /// Creates a box from a center point and a half size.
        /// </summary>
        /// <param name="center">The center of the box.</param>
        /// <param name="halfSize">The half size of the box.</param>
        /// <returns>The created box.</returns>
        public static Box2i FromPositionAndHalfSize(Vector2i center, Vector2i halfSize)
        {
            return new Box2i(center - halfSize, center + halfSize);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box2i Intersect(Box2i a, Box2i b)
        {
            return Intersect(in a, in b);
        }

        /// <summary>
        /// Returns the intersection of two boxes.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of the two boxes.</returns>
        public static Box2i Intersect(in Box2i a, in Box2i b)
        {
            Vector2i.ComponentMax(in a.Min, in b.Min, out Vector2i min);
            Vector2i.ComponentMin(in a.Max, in b.Max, out Vector2i max);
            if (max.X >= min.X && max.Y >= min.Y)
            {
                return new Box2i(min, max);
            }
            else
            {
                return Box2i.Empty;
            }
        }

        /// <summary>
        /// Replaces this box with the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box2i other)
        {
            this = Intersect(in this, in other);
        }

        /// <summary>
        /// Returns the intersection of itself and the specified box.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified box.</returns>
        public readonly Box2i Intersected(Box2i other)
        {
            return Intersect(this, other);
        }

        /// <summary>
        /// Determines if this box intersects with another box.
        /// </summary>
        /// <remarks>
        /// Two boxes next to each other do not intersect, for detecting that case use <see cref="Touches(Box2i)"/>.
        /// </remarks>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection, otherwise <see langword="false"/>.</returns>
        public readonly bool IntersectsWith(Box2i other)
        {
            return other.Min.X < Max.X && Min.X < other.Max.X &&
                   other.Min.Y < Max.Y && Min.Y < other.Max.Y;
        }

        /// <summary>
        /// Determines if this box intersects or touches with another box.
        /// </summary>
        /// <param name="other">The box to test.</param>
        /// <returns>This method returns <see langword="true"/> if there is any intersection or touches, otherwise <see langword="false"/>.</returns>
        public readonly bool Touches(Box2i other)
        {
            return other.Min.X <= Max.X && Min.X <= other.Max.X &&
                   other.Min.Y <= Max.Y && Min.Y <= other.Max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        public readonly bool ContainsInclusive(Vector2i point)
        {
            return Min.X <= point.X && Min.Y <= point.Y &&
                point.X <= Max.X && point.Y <= Max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        public readonly bool ContainsExclusive(Vector2i point)
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
        public readonly bool Contains(Box2i other)
        {
            return Min.X <= other.Min.X && Min.Y <= other.Min.Y &&
                Max.X >= other.Max.X && Max.Y >= other.Max.Y;
        }

        /// <summary>
        /// Returns the euclidian distance between the nearest point on an edge and the specified point.
        /// </summary>
        /// <remarks>
        /// The distance to points inside the box is zero.
        /// </remarks>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly float EuclidianDistanceToNearestEdge(Vector2i point)
        {
            Vector2i dist = Vector2i.ComponentMax(Vector2i.Zero, Vector2i.ComponentMax(Min - point, point - Max));
            return dist.EuclideanLength;
        }

        /// <summary>
        /// Returns the manhattan distance between the nearest point on an edge and the specified point.
        /// </summary>
        /// <remarks>
        /// The distance to points inside the box is zero.
        /// </remarks>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly int ManhattanDistanceToNearestEdge(Vector2i point)
        {
            Vector2i dist = Vector2i.ComponentMax(Vector2i.Zero, Vector2i.ComponentMax(Min - point, point - Max));
            return dist.ManhattanLength;
        }

        /// <summary>
        /// Returns the signed distance between the nearest edge and the specified point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public readonly float SignedEuclidianDistanceToNearestEdge(Vector2 point)
        {
            Vector2 d = Vector2.Abs(point - Center) - HalfSize;
            return Vector2.ComponentMax(Vector2.Zero, d).Length + MathF.Min(MathF.Max(d.X, d.Y), 0.0f);
        }

        /// <summary>
        /// Returns the nearest point in or on the edge of the box to the given point, <paramref name="point"/>.
        /// </summary>
        /// <param name="point">The point for which the nearest point in the box should be found.</param>
        /// <returns>The nearest point on or on the edge of the box to the point, <paramref name="point"/>.</returns>
        public readonly Vector2i NearestPointInBox(Vector2i point)
        {
            return Vector2i.ComponentMin(Max, Vector2i.ComponentMax(Min, point));
        }

        /// <summary>
        /// Translates this box by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2i distance)
        {
            Min += distance;
            Max += distance;
        }

        /// <summary>
        /// Returns a box translated by the given distance.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        public readonly Box2i Translated(Vector2i distance)
        {
            Box2i box = this;
            box.Translate(distance);
            return box;
        }

        /// <summary>
        /// Scales this box by the given scale, <paramref name="scale"/>, and from the given anchor point, <paramref name="anchor"/>.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        public void Scale(Vector2i scale, Vector2i anchor)
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
        public readonly Box2i Scaled(Vector2i scale, Vector2i anchor)
        {
            Box2i box = this;
            box.Scale(scale, anchor);
            return box;
        }

        /// <summary>
        /// Inflates this box by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        public void Inflate(Vector2i size)
        {
            size = Vector2i.ComponentMax(size, -(Size / 2));
            Vector2i newMin = Min - size;
            Vector2i newMax = Max + size;
            Min = Vector2i.ComponentMin(newMin, newMax);
            Max = Vector2i.ComponentMax(newMin, newMax);
        }

        /// <summary>
        /// Returns a box inflated by the given size in all directions.
        /// A negative size will shrink the box to a maximum of -<see cref="HalfSize"/>.
        /// </summary>
        /// <param name="size">The size to inflate by.</param>
        /// <returns>The inflated box.</returns>
        public readonly Box2i Inflated(Vector2i size)
        {
            Box2i box = this;
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
        /// Vector2i[] points = GetPoints();
        /// Box2i aabb = Box2i.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb.Extend(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public void Extend(Vector2i point)
        {
            Min = Vector2i.ComponentMin(Min, point);
            Max = Vector2i.ComponentMax(Max, point);
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
        /// Vector2i[] points = GetPoints();
        /// Box2i aabb = Box2i.Empty;
        /// for (int i = 0; i &lt; points.Length; i++)
        /// {
        ///     aabb = aabb.Extended(points[i]):
        /// }
        /// </code>
        /// Will calculate the bounding box of all the points in the array without needing a special case for the first point.
        /// </example>
        public readonly Box2i Extended(Vector2i point)
        {
            Box2i box = this;
            box.Extend(point);
            return box;
        }

        /// <inheritdoc/>
        public readonly override bool Equals(object obj)
        {
            return obj is Box2i box && Equals(box);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Box2i other)
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
        public static explicit operator System.Drawing.RectangleF(Box2i box)
        {
            return new System.Drawing.Rectangle((System.Drawing.Point)box.Min, (System.Drawing.Size)box.Size);
        }

        /// <summary>
        /// Converts this <see cref="Box2i"/> to a <see cref="Box2"/>.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        public static explicit operator Box2(Box2i box)
        {
            return new Box2(box.Min, box.Max);
        }

        /// <summary>
        /// Converts this <see cref="Box2i"/> to a <see cref="Box2d"/>.
        /// </summary>
        /// <param name="box">The box to cast.</param>
        public static explicit operator Box2d(Box2i box)
        {
            return new Box2d(box.Min, box.Max);
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
