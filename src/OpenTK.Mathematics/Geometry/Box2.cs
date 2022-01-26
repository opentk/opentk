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

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Defines an axis-aligned 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Box2 : IEquatable<Box2>
    {
        /// <summary>
        /// An empty box with Min (0, 0) and Max (0, 0).
        /// </summary>
        public static readonly Box2 Empty = new Box2(0, 0, 0, 0);

        /// <summary>
        /// A unit square with Min (0, 0) and Max (1, 1).
        /// </summary>
        public static readonly Box2 UnitBox = new Box2(0, 0, 1, 1);

        /// <summary>
        /// The minimum boundary of the structure. The user is responsible for keeping Max >= Min.
        /// </summary>
        public Vector2 Min;

        /// <summary>
        /// The minimum boundary of the structure. The user is responsible for keeping Min &lt;= Max.
        /// </summary>
        public Vector2 Max;

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
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
            Min = new Vector2(minX, minY);
            Max = new Vector2(maxX, maxY);
        }

        /// <summary>
        /// Gets or sets the size of the Box2 structure.
        /// Setting this value will expand/shrink the box while keeping Min at it's original value.
        /// </summary>
        public Vector2 Size
        {
            get => Max - Min;
            set => Max = Min + value;
        }

        /// <summary>
        /// Gets or sets the centered size of the Box2 structure.
        /// This will change Min and Max while keeping their center at the same location.
        /// </summary>
        public Vector2 CenteredSize
        {
            get => Max - Min;
            set
            {
                Vector2 center = Center;
                Min = center - (value * 0.5f);
                Max = center + (value * 0.5f);
            }
        }

        /// <summary>
        /// Gets or sets the width of the box.
        /// Setting this value will expand/shrink the box while keeping Min.X at it's original value.
        /// </summary>
        public float Width
        {
            get => Max.X - Min.X;
            set => Max.X = Min.X + value;
        }

        /// <summary>
        /// Sets the centered width of the Box2 structure.
        /// This will change Min.X and Max.X while keeping their center at the same location.
        /// </summary>
        public float CenteredWidth
        {
            set
            {
                float centerX = Center.X;
                Min.X = centerX - value;
                Max.X = centerX + value;
            }
        }

        /// <summary>
        /// Gets the height of the box.
        /// Setting this value will expand/shrink the box while keeping Min.Y at it's original value.
        /// </summary>
        public float Height
        {
            get => Max.Y - Min.Y;
            set => Max.Y = Min.Y + value;
        }

        /// <summary>
        /// Sets the centered width of the Box2 structure.
        /// This will change Min.X and Max.X while keeping their center at the same location.
        /// </summary>
        public float CenteredHeight
        {
            set
            {
                float centerX = Center.X;
                Min.X = centerX - value;
                Max.X = centerX + value;
            }
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        public Vector2 HalfSize
        {
            get => CenteredSize / 2;
            set => CenteredSize = value * 2;
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        public Vector2 Center
        {
            get => HalfSize + Min;
            set => Translate(value - Center);
        }

        // --

        /// <summary>
        /// Gets or sets the left location of the box.
        /// This is equivalent to <c>Min.X</c>.
        /// </summary>
        public float Left
        {
            get => Min.X;
            set => Min.X = value;
        }

        /// <summary>
        /// Gets or sets the top location of the box.
        /// This is equivalent to <c>Min.Y</c>.
        /// </summary>
        public float Top
        {
            get => Min.Y;
            set => Min.Y = value;
        }

        /// <summary>
        /// Gets or sets the right location of the box.
        /// This is equivalent to <c>Max.X</c>.
        /// </summary>
        public float Right
        {
            get => Max.X;
            set => Max.X = value;
        }

        /// <summary>
        /// Gets or sets the bottom location of the box.
        /// This is equivalent to <c>Max.Y</c>.
        /// </summary>
        public float Bottom
        {
            get => Max.Y;
            set => Max.Y = value;
        }

        /// <summary>
        /// Gets the location of the box.
        /// </summary>
        public Vector2 Location => Min;

        /// <summary>
        /// Gets a value indicating whether all values are zero.
        /// </summary>
        public bool IsZero => Min == Vector2.Zero && Max == Vector2.Zero;

        /// <summary>
        /// Gets a box with a location 0,0 with the a size of 1.
        /// </summary>
        public static readonly Box2 UnitSquare = new Box2(0, 0, 1, 1);

        /// <summary>
        /// Creates a box from a location and size.
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
        /// <param name="min">The minimum point this box encloses.</param>
        /// <param name="max">The maximum point this box encloses.</param>
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
        /// Replaces this Box with the intersection of itself and the specified Box or <see cref="Empty"/> if the boxes do not intersect.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        public void Intersect(Box2 other)
        {
            this = Intersect(this, other);
        }

        /// <summary>
        /// Returns the intersection of two Boxes or <see cref="Empty"/> if the boxes do not intersect.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <returns>The intersection of two Boxes.</returns>
        public static Box2 Intersect(Box2 a, Box2 b)
        {
            Box2 result;
            result.Min = Vector2.ComponentMax(a.Min, b.Min);
            result.Max = Vector2.ComponentMin(a.Max, b.Max);

            if (result.Max.X >= result.Min.X && result.Max.Y >= result.Min.Y)
            {
                return result;
            }
            else
            {
                return Box2.Empty;
            }
        }

        /// <summary>
        /// Returns the intersection of itself and the specified Box or <see cref="Empty"/> if the boxes do not intersect.
        /// </summary>
        /// <param name="other">The Box with which to intersect.</param>
        /// <returns>The intersection of itself and the specified Box.</returns>
        public Box2 Intersected(Box2 other)
        {
            return Intersect(this, other);
        }

        /// <summary>
        /// Determines if this Box intersects with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection, otherwise false.</returns>
        public bool IntersectsWith(Box2 other)
        {
            return other.Min.X < Max.X
                && Min.X < other.Max.X
                && other.Min.Y < Max.Y
                && Min.Y < other.Max.Y;
        }

        /// <summary>
        /// Determines if this Box intersects or touches with another Box.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection or touches, otherwise false.</returns>
        public bool TouchWith(Box2 other)
        {
            return other.Min.X <= Max.X
                && Min.X <= other.Max.X
                && other.Min.Y <= Max.Y
                && Min.Y <= other.Max.Y;
        }

        /// <summary>
        /// Gets a Box structure that contains rounded integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded integers.</returns>
        public static Box2i Round(Box2 value)
        {
            return new Box2i(
                Vector2.Round(value.Min),
                Vector2.Round(value.Max));
        }

        /// <summary>
        /// Gets a Box structure that contains rounded up integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded up integers.</returns>
        public static Box2i Ceiling(Box2 value)
        {
            return new Box2i(
                Vector2.Ceiling(value.Min),
                Vector2.Ceiling(value.Max));
        }

        /// <summary>
        /// Gets a Box structure that contains rounded down integers.
        /// </summary>
        /// <param name="value">A Box to round.</param>
        /// <returns>A Box structure that contains rounded down integers.</returns>
        public static Box2i Floor(Box2 value)
        {
            return new Box2i(
                Vector2.Floor(value.Min),
                Vector2.Floor(value.Max));
        }

        // --

        /// <summary>
        /// Returns whether the box contains the specified point (borders exclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        [Pure]
        public bool Contains(Vector2 point)
        {
            return Min.X < point.X && point.X < Max.X &&
                   Min.Y < point.Y && point.Y < Max.Y;
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
                return Min.X <= point.X && point.X <= Max.X &&
                       Min.Y <= point.Y && point.Y <= Max.Y;
            }
            else
            {
                return Min.X < point.X && point.X < Max.X &&
                   Min.Y < point.Y && point.Y < Max.Y;
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
            return Contains(in this, in other);
        }

        /// <summary>
        /// Checks if <paramref name="bigger"/> fully contains <paramref name="smaller"/> (inclusive bounds).
        /// </summary>
        /// <param name="bigger">The box to check contains the other box.</param>
        /// <param name="smaller">The box to check if contained by the other box.</param>
        /// <returns>If <paramref name="smaller"/> was fully contained in <paramref name="bigger"/>.</returns>
        public static bool Contains(in Box2 bigger, in Box2 smaller)
        {
            return bigger.Min.X <= smaller.Min.X && bigger.Max.X >= smaller.Max.X &&
                   bigger.Min.Y <= smaller.Min.Y && bigger.Max.Y >= smaller.Max.Y;
        }

        /// <summary>
        /// <see cref="Touches(Box2)"/> for the same check with exclusive bounds.
        /// </summary>
        /// <param name="other">The box to test.</param>
        /// <returns>Wether the box intersected this box.</returns>
        public bool Intersects(Box2 other)
        {
            return Intersects(this, other);
        }

        /// <summary>
        /// Checks if the boxes intersect not including the bounds.
        /// <see cref="Touches(Box2, Box2)"/> for the same check with exclusive bounds.
        /// </summary>
        /// <param name="a">The first box to check intersection with.</param>
        /// <param name="b">The second box to check intersection with.</param>
        /// <returns>If the boxes intersected (excluding bounds).</returns>
        public static bool Intersects(Box2 a, Box2 b)
        {
            return a.Min.X < b.Max.X &&
                   b.Min.X < a.Max.X &&
                   a.Min.Y < b.Max.Y &&
                   b.Min.Y < a.Max.Y;
        }

        /// <summary>
        /// Determines if this Box intersects or touches with another Box.
        /// <see cref="Intersects(Box2)"/> for the same check with exclusive bounds.
        /// </summary>
        /// <param name="other">The Box to test.</param>
        /// <returns>This method returns true if there is any intersection or touches, otherwise false.</returns>
        public bool Touches(Box2 other)
        {
            return Touches(this, other);
        }

        /// <summary>
        /// Determines if this Box intersects or touches with another Box.
        /// <see cref="Intersects(Box2, Box2)"/> for the same check with exclusive bounds.
        /// </summary>
        /// <param name="a">asdf.</param>
        /// <param name="b">aasdf.</param>
        /// <returns>This method returns true if there is any intersection or touches, otherwise false.</returns>
        public static bool Touches(Box2 a, Box2 b)
        {
            return a.Min.X <= b.Max.X &&
                   b.Min.X <= a.Max.X &&
                   a.Min.Y <= b.Max.Y &&
                   b.Min.Y <= a.Max.Y;
        }

        /// <summary>
        /// Get the distance to the nearset edge from a point.
        /// </summary>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        [Pure]
        public float DistanceToNearestEdge(Vector2 point)
        {
            Vector2 dist = Vector2.ComponentMax(
                Vector2.Zero,
                Vector2.ComponentMax(Min - point, point - Max));
            return dist.Length;
        }

        /// <summary>
        /// Get the distance to the nearset edge from a point.
        /// </summary>
        /// <param name="box">The box which edges to meeasure from.</param>
        /// <param name="point">The point to find distance for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        public static float DistanceToNearestEdge(in Box2 box, Vector2 point)
        {
            Vector2 dist = Vector2.ComponentMax(
               Vector2.Zero,
               Vector2.ComponentMax(box.Min - point, point - box.Max));
            return dist.Length;
        }

        /// <summary>
        /// Finds the closest point on the box to a point.
        /// If the point is inside the box the same point is returned.
        /// </summary>
        /// <param name="point">The point to find the closest point for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        [Pure]
        public Vector2 ClosestPoint(Vector2 point)
        {
            return Vector2.Clamp(point, Min, Max);
        }

        /// <summary>
        /// Finds the closest point on the box to a point.
        /// If the point is inside the box the same point is returned.
        /// </summary>
        /// <param name="box">The box to find the closest point on.</param>
        /// <param name="point">The point to find the closest point for.</param>
        /// <returns>The distance between the specified point and the nearest edge.</returns>
        [Pure]
        public static Vector2 ClosestPoint(in Box2 box, Vector2 point)
        {
            return Vector2.Clamp(point, box.Min, box.Max);
        }

        /// <summary>
        /// Translate a Box2 by the given offset.
        /// </summary>
        /// <param name="offset">The distance to translate the box.</param>
        public void Translate(Vector2 offset)
        {
            Min += offset;
            Max += offset;
        }

        /// <summary>
        /// Translate a Box2 by the given offset.
        /// </summary>
        /// <param name="box">The box to translate.</param>
        /// <param name="offset">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
        [Pure]
        public static Box2 Translated(in Box2 box, Vector2 offset)
        {
            Translate(box, offset, out Box2 result);
            return result;
        }

        /// <summary>
        /// Translate a Box2 by the given offset.
        /// </summary>
        /// <param name="box">The box to translate.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="result">The translated box.</param>
        public static void Translate(in Box2 box, Vector2 offset, out Box2 result)
        {
            result.Min = box.Min + offset;
            result.Max = box.Max + offset;
        }

        /// <summary>
        /// Scales this Box2 by the given amount.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor to scale from.</param>
        public void Scale(Vector2 scale, Vector2 anchor)
        {
            Min = anchor + ((Min - anchor) * scale);
            Max = anchor + ((Max - anchor) * scale);
        }

        /// <summary>
        /// Returns a Box2 scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor to scale from.</param>
        /// <returns>The scaled box.</returns>
        [Pure]
        public Box2 Scaled(Vector2 scale, Vector2 anchor)
        {
            Scale(this, scale, anchor, out Box2 result);
            return result;
        }

        /// <summary>
        /// Scale a box by a given amount from an anchor point.
        /// </summary>
        /// <param name="box">The box to scale.</param>
        /// <param name="scale">The scale.</param>
        /// <param name="anchor">The anchor to scale from.</param>
        /// <param name="result">The scaled box.</param>
        public static void Scale(in Box2 box, Vector2 scale, Vector2 anchor, out Box2 result)
        {
            result.Min = anchor + ((box.Min - anchor) * scale);
            result.Max = anchor + ((box.Max - anchor) * scale);
        }

        /// <summary>
        /// Inflate a Box2 to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to encapsulate.</param>
        public void Inflate(Vector2 point)
        {
            Min = Vector2.ComponentMin(Min, point);
            Max = Vector2.ComponentMax(Max, point);
        }

        /// <summary>
        /// Inflate a Box2 to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to encapsulate.</param>
        /// <returns>The inflated box.</returns>
        [Pure]
        public Box2 Inflated(Vector2 point)
        {
            Inflate(this, point, out Box2 result);
            return result;
        }

        /// <summary>
        /// Inflate a Box2 to encapsulate a given point.
        /// </summary>
        /// <param name="box">The box to inflate.</param>
        /// <param name="point">The point to encapsulate.</param>
        /// <param name="result">The inflated box.</param>
        public static void Inflate(in Box2 box, Vector2 point, out Box2 result)
        {
            result.Min = Vector2.ComponentMin(box.Min, point);
            result.Max = Vector2.ComponentMax(box.Max, point);
        }

        /// <summary>
        /// Union two boxes to get a box that contains both.
        /// </summary>
        /// <param name="other">TODO.</param>
        public void Union(in Box2 other)
        {
            Min = Vector2.ComponentMin(Min, other.Min);
            Max = Vector2.ComponentMax(Max, other.Max);
        }

        /// <summary>
        /// Union two boxes to get a box that contains both.
        /// </summary>
        /// <param name="other">TODO.</param>
        /// <returns>TODO2.</returns>
        public Box2 Unioned(in Box2 other)
        {
            Box2 result;
            result.Min = Vector2.ComponentMin(Min, other.Min);
            result.Max = Vector2.ComponentMax(Max, other.Max);
            return result;
        }

        /// <summary>
        /// Union two boxes to get a box that contains both.
        /// </summary>
        /// <param name="a">The first box.</param>
        /// <param name="b">The second box.</param>
        /// <param name="result">The unioned box.</param>
        public static void Union(in Box2 a, in Box2 b, out Box2 result)
        {
            result.Min = Vector2.ComponentMin(a.Min, b.Min);
            result.Max = Vector2.ComponentMax(a.Max, b.Max);
        }

        /// <summary>
        /// Gets a Box structure that contains the union of two Box structures.
        /// </summary>
        /// <param name="a">A Box to union.</param>
        /// <param name="b">a box to union.</param>
        /// <returns>A Box structure that bounds the union of the two Box structures.</returns>
        public static Box2 Union(Box2 a, Box2 b)
        {
            Box2 result;
            result.Min = Vector2.ComponentMin(a.Min, b.Min);
            result.Max = Vector2.ComponentMax(a.Max, b.Max);
            return result;
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
            return Min.Equals(other.Min) &&
                   Max.Equals(other.Max);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(Min, Max);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Min} - {Max}";
        }
    }
}
