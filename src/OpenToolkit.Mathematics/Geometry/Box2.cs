//
// Box2.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Defines a 2d box (rectangle).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
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
                    _min.X = _max.X;
                    _max.X = value.X;
                }
                else
                {
                    _min.X = value.X;
                }

                if (value.Y > _max.Y)
                {
                    _min.Y = _max.Y;
                    _max.Y = value.Y;
                }
                else
                {
                    _min.Y = value.Y;
                }
            }
        }

        private Vector2 _max;

        /// <summary>
        /// Gets or sets the maximum boundary of the structure.
        /// </summary>
        public Vector2 Max
        {
            get => _min;
            set
            {
                if (value.X < _min.X)
                {
                    _max.X = _min.X;
                    _min.X = value.X;
                }
                else
                {
                    _max.X = value.X;
                }

                if (value.Y < _min.Y)
                {
                    _max.Y = _min.Y;
                    _min.Y = value.Y;
                }
                else
                {
                    _max.Y = value.Y;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Box2"/> struct.
        /// </summary>
        /// <param name="min">The minimum point on the XY plane this box encloses.</param>
        /// <param name="max">The maximum point on the XY plane this box encloses.</param>
        public Box2(Vector2 min, Vector2 max)
        {
            if (min.X < max.X)
            {
                _min.X = min.X;
                _max.X = max.X;
            }
            else
            {
                _min.X = max.X;
                _max.X = min.X;
            }

            if (min.Y < max.Y)
            {
                _min.Y = min.Y;
                _max.Y = max.Y;
            }
            else
            {
                _min.Y = max.Y;
                _max.Y = min.Y;
            }
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
        public Vector2 Size
        {
            get => Max - Min;
            set => Scale(Size - value, Center);
        }

        /// <summary>
        /// Gets or sets a vector describing half the size of the box.
        /// </summary>
        public Vector2 HalfSize
        {
            get => Size / 2;
            set => Size = value / 2;
        }

        /// <summary>
        /// Gets or sets a vector describing the center of the box.
        /// </summary>
        public Vector2 Center
        {
            get => (_min + _max) * 0.5f;
            set => Translate(Center - value);
        }

        /// <summary>
        /// Returns whether the box contains the specified point (borders inclusive).
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>Whether this box contains the point.</returns>
        public bool Contains(Vector2 point)
        {
            return _min.X <= point.X && point.X <= _max.X &&
                   _min.Y <= point.X && point.Y <= _max.Y;
        }

        /// <summary>
        /// Returns whether the box contains the specified box (borders inclusive).
        /// </summary>
        /// <param name="other">The box to query.</param>
        /// <returns>Whether this box contains the other box.</returns>
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
        public float DistanceToNearestEdge(Vector2 point)
        {
            var distMin = _min - point;
            var distMax = point - _max;
            var dist = new Vector2(MathHelper.Min(distMin.X, distMax.X), MathHelper.Min(distMin.Y, distMax.Y));
            return dist.Length;
        }

        /// <summary>
        /// Translates this Box2 by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        public void Translate(Vector2 distance)
        {
            Min += distance;
            Max += distance;
        }

        /// <summary>
        /// Returns a Box2 translated by the given amount.
        /// </summary>
        /// <param name="distance">The distance to translate the box.</param>
        /// <returns>The translated box.</returns>
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
            var newDistMin = (anchor - _min) * scale;
            _min = new Vector2(
                anchor.X + _min.X > anchor.X ? newDistMin.X : -newDistMin.X,
                anchor.Y + _min.Y > anchor.Y ? newDistMin.Y : -newDistMin.Y);

            var newDistMax = (anchor - _max) * scale;
            _max = new Vector2(
                anchor.X + _max.X > anchor.X ? newDistMax.X : -newDistMax.X,
                anchor.Y + _min.Y > anchor.Y ? newDistMax.Y : -newDistMax.Y);
        }

        /// <summary>
        /// Returns a Box2 scaled by a given amount from an anchor point.
        /// </summary>
        /// <param name="scale">The scale to scale the box.</param>
        /// <param name="anchor">The anchor to scale the box from.</param>
        /// <returns>The scaled box.</returns>
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
            var distMin = _min - point;
            var distMax = point - _max;

            if (distMin.X < distMax.X)
            {
                _min.X = point.X;
            }
            else
            {
                _max.X = point.X;
            }

            if (distMin.Y < distMax.Y)
            {
                _min.Y = point.Y;
            }
            else
            {
                _max.Y = point.Y;
            }
        }

        /// <summary>
        /// Inflate this Box2 to encapsulate a given point.
        /// </summary>
        /// <param name="point">The point to query.</param>
        /// <returns>The inflated box.</returns>
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
            return left.Min == right.Min && left.Max == right.Max;
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
        public bool Equals(Box2 other)
        {
            return Min.Equals(other.Min) && Max.Equals(other.Max);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is Box2 other && Equals(other);
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
            return $"({Min.X}{ListSeparator} {Min.Y}) - ({Max.X}{ListSeparator} {Max.Y})";
        }
    }
}
