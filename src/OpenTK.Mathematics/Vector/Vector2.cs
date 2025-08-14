﻿/*
Copyright (c) 2006 - 2008 The Open Toolkit library.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */

using System;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 2D vector using two single-precision floating-point numbers.
    /// </summary>
    /// <remarks>
    /// The Vector2 structure is suitable for interoperation with unmanaged code requiring two consecutive floats.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2 : IEquatable<Vector2>, IFormattable,
                            IAdditionOperators<Vector2, Vector2, Vector2>,
                            ISubtractionOperators<Vector2, Vector2, Vector2>,
                            IUnaryNegationOperators<Vector2, Vector2>,
                            IUnaryPlusOperators<Vector2, Vector2>,
                            IMultiplyOperators<Vector2, float, Vector2>,
                            IMultiplyOperators<Vector2, Vector2, Vector2>,
                            IMultiplyOperators<Vector2, Matrix2, Vector2>,
                            IMultiplyOperators<Vector2, Matrix2x3, Vector3>,
                            IMultiplyOperators<Vector2, Matrix2x4, Vector4>,
                            IDivisionOperators<Vector2, float, Vector2>,
                            IDivisionOperators<Vector2, Vector2, Vector2>,
                            IEqualityOperators<Vector2, Vector2, bool>,
                            IAdditiveIdentity<Vector2, Vector2>,
                            IMultiplicativeIdentity<Vector2, Vector2>,
                            IMinMaxValue<Vector2>
    {
        /// <summary>
        /// The X component of the Vector2.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector2.
        /// </summary>
        public float Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2(float value)
        {
            X = value;
            Y = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector2.</param>
        /// <param name="y">The y component of the Vector2.</param>
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets or sets the value at the index of the Vector.
        /// </summary>
        /// <param name="index">The index of the component from the Vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 1.</exception>
        public float this[int index]
        {
            readonly get
            {
                if (((uint)index) >= 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this vector at index: {0}", index);
                }

                return GetElementUnsafe(in this, index);
            }

            set
            {
                if (((uint)index) >= 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this vector at index: {0}", index);
                }

                GetElementUnsafe(in this, index) = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref float GetElementUnsafe(in Vector2 v, int index)
        {
            ref float address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public readonly float Length => MathF.Sqrt((X * X) + (Y * Y));

        /// <summary>
        /// Gets an approximation of 1 over the length (magnitude) of the vector.
        /// </summary>
        public readonly float ReciprocalLengthFast => MathF.ReciprocalSqrtEstimate((X * X) + (Y * Y));

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public readonly float LengthFast => 1.0f / MathF.ReciprocalSqrtEstimate((X * X) + (Y * Y));

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthFast"/>
        public readonly float LengthSquared => (X * X) + (Y * Y);

        /// <summary>
        /// Gets the perpendicular vector on the right side of this vector.
        /// </summary>
        public readonly Vector2 PerpendicularRight => new Vector2(Y, -X);

        /// <summary>
        /// Gets the perpendicular vector on the left side of this vector.
        /// </summary>
        public readonly Vector2 PerpendicularLeft => new Vector2(-Y, X);

        /// <summary>
        /// Returns a copy of the Vector2 scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public readonly Vector2 Normalized()
        {
            Vector2 v = this;
            v.Normalize();
            return v;
        }

        /// <summary>
        /// Scales the Vector2 to unit length.
        /// </summary>
        public void Normalize()
        {
            float scale = 1.0f / Length;
            X *= scale;
            Y *= scale;
        }

        /// <summary>
        /// Scales the Vector2 to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            float scale = MathF.ReciprocalSqrtEstimate((X * X) + (Y * Y));
            X *= scale;
            Y *= scale;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector2 Abs()
        {
            Vector2 result = this;
            result.X = MathF.Abs(result.X);
            result.Y = MathF.Abs(result.Y);
            return result;
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied.
        /// Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <returns>The rounded vector.</returns>
        public readonly Vector2 Round()
        {
            return Round(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied with the specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The rounded vector.</returns>
        public readonly Vector2 Round(MidpointRounding rounding)
        {
            return Round(this, rounding);
        }

        /// <summary>
        /// Returns a new vector were a component-wise ceiling operation has been applied.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <returns>The ceiled vector.</returns>
        public readonly Vector2 Ceiling()
        {
            return Ceiling(this);
        }

        /// <summary>
        /// Returns a new vector were a component-wise floor operation has been applied.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <returns>The floored vector.</returns>
        public readonly Vector2 Floor()
        {
            return Floor(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise truncation has been applied.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <returns>The truncated vector.</returns>
        public readonly Vector2 Truncate()
        {
            return Truncate(this);
        }

        /// <summary>
        /// Defines a unit-length Vector2 that points towards the X-axis.
        /// </summary>
        public static readonly Vector2 UnitX = new Vector2(1, 0);

        /// <summary>
        /// Defines a unit-length Vector2 that points towards the Y-axis.
        /// </summary>
        public static readonly Vector2 UnitY = new Vector2(0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector2 Zero = new Vector2(0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector2 One = new Vector2(1, 1);

        /// <summary>
        /// Defines an instance with all components set to positive infinity.
        /// </summary>
        public static readonly Vector2 PositiveInfinity = new Vector2(float.PositiveInfinity, float.PositiveInfinity);

        /// <summary>
        /// Defines an instance with all components set to negative infinity.
        /// </summary>
        public static readonly Vector2 NegativeInfinity = new Vector2(float.NegativeInfinity, float.NegativeInfinity);

        /// <summary>
        /// Defines the size of the Vector2 struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector2>();

        /// <summary>
        /// Gets the additive identity of Vector2. Equivalent to Vector2.Zero.
        /// </summary>
        public static Vector2 AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector2. Equivalent to Vector2.One.
        /// </summary>
        public static Vector2 MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the max value for Vector2. Equivalent to Vector2.PositiveInfinity.
        /// </summary>
        public static Vector2 MaxValue => PositiveInfinity;

        /// <summary>
        /// Gets the min value for Vector2. Equivalent to Vector2.NegativeInfinity.
        /// </summary>
        public static Vector2 MinValue => NegativeInfinity;

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        [Pure]
        public static Vector2 Add(Vector2 a, Vector2 b)
        {
            Add(in a, in b, out a);
            return a;
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <param name="result">Result of operation.</param>
        public static void Add(in Vector2 a, in Vector2 b, out Vector2 result)
        {
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector2 Subtract(Vector2 a, Vector2 b)
        {
            Subtract(in a, in b, out a);
            return a;
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">Result of subtraction.</param>
        public static void Subtract(in Vector2 a, in Vector2 b, out Vector2 result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2 Multiply(Vector2 vector, float scale)
        {
            Multiply(in vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector2 vector, float scale, out Vector2 result)
        {
            result.X = vector.X * scale;
            result.Y = vector.Y * scale;
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2 Multiply(Vector2 vector, Vector2 scale)
        {
            Multiply(in vector, in scale, out vector);
            return vector;
        }

        /// <summary>
        /// Multiplies a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector2 vector, in Vector2 scale, out Vector2 result)
        {
            result.X = vector.X * scale.X;
            result.Y = vector.Y * scale.Y;
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2 Divide(Vector2 vector, float scale)
        {
            Divide(in vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector2 vector, float scale, out Vector2 result)
        {
            result.X = vector.X / scale;
            result.Y = vector.Y / scale;
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2 Divide(Vector2 vector, Vector2 scale)
        {
            Divide(in vector, in scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divide a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector2 vector, in Vector2 scale, out Vector2 result)
        {
            result.X = vector.X / scale.X;
            result.Y = vector.Y / scale.Y;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector2 ComponentMin(Vector2 a, Vector2 b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            return a;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector2 a, in Vector2 b, out Vector2 result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector2 ComponentMax(Vector2 a, Vector2 b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            return a;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector2 a, in Vector2 b, out Vector2 result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
        }

        /// <summary>
        /// Returns the Vector2 with the minimum magnitude. If the magnitudes are equal, the second vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector2.</returns>
        [Pure]
        public static Vector2 MagnitudeMin(Vector2 left, Vector2 right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector2 with the minimum magnitude. If the magnitudes are equal, the second vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise minimum.</param>
        public static void MagnitudeMin(in Vector2 left, in Vector2 right, out Vector2 result)
        {
            result = left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector2 with the maximum magnitude. If the magnitudes are equal, the first vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The maximum Vector2.</returns>
        [Pure]
        public static Vector2 MagnitudeMax(Vector2 left, Vector2 right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector2 with the maximum magnitude. If the magnitudes are equal, the first vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise maximum.</param>
        public static void MagnitudeMax(in Vector2 left, in Vector2 right, out Vector2 result)
        {
            result = left.LengthSquared >= right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <returns>The clamped vector.</returns>
        [Pure]
        public static Vector2 Clamp(Vector2 vec, Vector2 min, Vector2 max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector2 vec, in Vector2 min, in Vector2 max, out Vector2 result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector2 Abs(Vector2 vec)
        {
            vec.X = MathF.Abs(vec.X);
            vec.Y = MathF.Abs(vec.Y);
            return vec;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector2 vec, out Vector2 result)
        {
            result.X = MathF.Abs(vec.X);
            result.Y = MathF.Abs(vec.Y);
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector2 Round(Vector2 vec)
        {
            vec.X = MathF.Round(vec.X);
            vec.Y = MathF.Round(vec.Y);
            return vec;
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector2 vec, out Vector2 result)
        {
            result.X = MathF.Round(vec.X);
            result.Y = MathF.Round(vec.Y);
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector2 Round(Vector2 vec, MidpointRounding rounding)
        {
            vec.X = MathF.Round(vec.X, rounding);
            vec.Y = MathF.Round(vec.Y, rounding);
            return vec;
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector2 vec, MidpointRounding rounding, out Vector2 result)
        {
            result.X = MathF.Round(vec.X, rounding);
            result.Y = MathF.Round(vec.Y, rounding);
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <returns>The component-wise ceiling vector.</returns>
        [Pure]
        public static Vector2 Ceiling(Vector2 vec)
        {
            vec.X = MathF.Ceiling(vec.X);
            vec.Y = MathF.Ceiling(vec.Y);
            return vec;
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <param name="result">The component-wise ceiling vector.</param>
        public static void Ceiling(in Vector2 vec, out Vector2 result)
        {
            result.X = MathF.Ceiling(vec.X);
            result.Y = MathF.Ceiling(vec.Y);
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <returns>The component-wise floored vector.</returns>
        [Pure]
        public static Vector2 Floor(Vector2 vec)
        {
            vec.X = MathF.Floor(vec.X);
            vec.Y = MathF.Floor(vec.Y);
            return vec;
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <param name="result">The component-wise floored vector.</param>
        public static void Floor(in Vector2 vec, out Vector2 result)
        {
            result.X = MathF.Floor(vec.X);
            result.Y = MathF.Floor(vec.Y);
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <returns>The component-wise truncated vector.</returns>
        [Pure]
        public static Vector2 Truncate(Vector2 vec)
        {
            vec.X = MathF.Truncate(vec.X);
            vec.Y = MathF.Truncate(vec.Y);
            return vec;
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <param name="result">The component-wise truncated vector.</param>
        public static void Truncate(in Vector2 vec, out Vector2 result)
        {
            result.X = MathF.Truncate(vec.X);
            result.Y = MathF.Truncate(vec.Y);
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The distance.</returns>
        [Pure]
        public static float Distance(Vector2 vec1, Vector2 vec2)
        {
            Distance(in vec1, in vec2, out float result);
            return result;
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The distance.</param>
        public static void Distance(in Vector2 vec1, in Vector2 vec2, out float result)
        {
            result = MathF.Sqrt(((vec2.X - vec1.X) * (vec2.X - vec1.X)) + ((vec2.Y - vec1.Y) * (vec2.Y - vec1.Y)));
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The squared distance.</returns>
        [Pure]
        public static float DistanceSquared(Vector2 vec1, Vector2 vec2)
        {
            DistanceSquared(in vec1, in vec2, out float result);
            return result;
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The squared distance.</param>
        public static void DistanceSquared(in Vector2 vec1, in Vector2 vec2, out float result)
        {
            result = ((vec2.X - vec1.X) * (vec2.X - vec1.X)) + ((vec2.Y - vec1.Y) * (vec2.Y - vec1.Y));
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector2 Normalize(Vector2 vec)
        {
            float scale = 1.0f / vec.Length;
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void Normalize(in Vector2 vec, out Vector2 result)
        {
            float scale = 1.0f / vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector2 NormalizeFast(Vector2 vec)
        {
            float scale = MathF.ReciprocalSqrtEstimate((vec.X * vec.X) + (vec.Y * vec.Y));
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void NormalizeFast(in Vector2 vec, out Vector2 result)
        {
            float scale = MathF.ReciprocalSqrtEstimate((vec.X * vec.X) + (vec.Y * vec.Y));
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        [Pure]
        public static float Dot(Vector2 left, Vector2 right)
        {
            return (left.X * right.X) + (left.Y * right.Y);
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The dot product of the two inputs.</param>
        public static void Dot(in Vector2 left, in Vector2 right, out float result)
        {
            result = (left.X * right.X) + (left.Y * right.Y);
        }

        /// <summary>
        /// Calculate the perpendicular dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The perpendicular dot product of the two inputs.</returns>
        [Pure]
        public static float PerpDot(Vector2 left, Vector2 right)
        {
            return (left.X * right.Y) - (left.Y * right.X);
        }

        /// <summary>
        /// Calculate the perpendicular dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The perpendicular dot product of the two inputs.</param>
        public static void PerpDot(in Vector2 left, in Vector2 right, out float result)
        {
            result = (left.X * right.Y) - (left.Y * right.X);
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector2b LessThan(in Vector2 left, in Vector2 right)
        {
            return new Vector2b(left.X < right.X, left.Y < right.Y);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector2b LessThanOrEqual(in Vector2 left, in Vector2 right)
        {
            return new Vector2b(left.X <= right.X, left.Y <= right.Y);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector2b GreaterThan(in Vector2 left, in Vector2 right)
        {
            return new Vector2b(left.X > right.X, left.Y > right.Y);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector2b GreaterThanOrEqual(in Vector2 left, in Vector2 right)
        {
            return new Vector2b(left.X >= right.X, left.Y >= right.Y);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector2b ComponentEqual(in Vector2 left, in Vector2 right)
        {
            return new Vector2b(left.X == right.X, left.Y == right.Y);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector2b ComponentNotEqual(in Vector2 left, in Vector2 right)
        {
            return new Vector2b(left.X != right.X, left.Y != right.Y);
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise.</returns>
        [Pure]
        public static Vector2 Lerp(Vector2 a, Vector2 b, float blend)
        {
            a.X = (blend * (b.X - a.X)) + a.X;
            a.Y = (blend * (b.Y - a.Y)) + a.Y;
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise.</param>
        public static void Lerp(in Vector2 a, in Vector2 b, float blend, out Vector2 result)
        {
            result.X = (blend * (b.X - a.X)) + a.X;
            result.Y = (blend * (b.Y - a.Y)) + a.Y;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</returns>
        [Pure]
        public static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 blend)
        {
            a.X = (blend.X * (b.X - a.X)) + a.X;
            a.Y = (blend.Y * (b.Y - a.Y)) + a.Y;
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</param>
        public static void Lerp(in Vector2 a, in Vector2 b, Vector2 blend, out Vector2 result)
        {
            result.X = (blend.X * (b.X - a.X)) + a.X;
            result.Y = (blend.Y * (b.Y - a.Y)) + a.Y;
        }

        /// <summary>
        /// Returns a new vector that is the spherical interpolation of the two given vectors.
        /// <paramref name="a"/> and <paramref name="b"/> need to be normalized for this function to work properly.
        /// </summary>
        /// <param name="a">Unit vector start point.</param>
        /// <param name="b">Unit vector end point.</param>
        /// <param name="t">The blend factor.</param>
        /// <returns><paramref name="a"/> when <paramref name="t"/>=0, <paramref name="b"/> when <paramref name="t"/>=1, and a spherical interpolation between the vectors otherwise.</returns>
        [Pure]
        public static Vector2 Slerp(Vector2 a, Vector2 b, float t)
        {
            float abLength = a.Length * b.Length;
            float cosTheta;
            if (abLength == 0 || Math.Abs(cosTheta = Dot(a, b) / abLength) > 0.9999f)
            {
                return Lerp(a, b, t);
            }
            else
            {
                float theta = MathF.Acos(Math.Clamp(cosTheta, -1, 1));
                // We use the fact that:
                // sin(θ) = sqrt(1 - cos(θ)^2)
                // to avoid doing sin(θ) which is slower than sqrt.
                float sinTheta = MathF.Sqrt(1 - (cosTheta * cosTheta));
                float acoef = MathF.Sin((1 - t) * theta) / sinTheta;
                float bcoef = MathF.Sin(t * theta) / sinTheta;
                return (acoef * a) + (bcoef * b);
            }
        }

        /// <summary>
        /// Returns a new vector that is the spherical interpolation of the two given vectors.
        /// <paramref name="a"/> and <paramref name="b"/> need to be normalized for this function to work properly.
        /// </summary>
        /// <param name="a">Unit vector start point.</param>
        /// <param name="b">Unit vector end point.</param>
        /// <param name="t">The blend factor.</param>
        /// <param name="result">Is <paramref name="a"/> when <paramref name="t"/>=0, <paramref name="b"/> when <paramref name="t"/>=1, and a spherical interpolation between the vectors otherwise.</param>
        public static void Slerp(in Vector2 a, in Vector2 b, float t, out Vector2 result)
        {
            float abLength = a.Length * b.Length;
            if (abLength == 0)
            {
                Lerp(in a, in b, t, out result);
            }
            else
            {
                Dot(in a, in b, out float cosTheta);
                cosTheta /= abLength;
                if (Math.Abs(cosTheta) > 0.9999f)
                {
                    Lerp(in a, in b, t, out result);
                }
                else
                {
                    float theta = MathF.Acos(cosTheta);
                    // We use the fact that:
                    // sin(θ) = sqrt(1 - cos(θ)^2)
                    // to avoid doing sin(θ) which is slower than sqrt.
                    float sinTheta = MathF.Sqrt(1 - (cosTheta * cosTheta));
                    float acoef = MathF.Sin((1 - t) * theta) / sinTheta;
                    float bcoef = MathF.Sin(t * theta) / sinTheta;
                    result = (acoef * a) + (bcoef * b);
                }
            }
        }

        /// <summary>
        /// Returns a new vector that is the exponential interpolation of the two vectors.
        /// Equivalent to <c>a * pow(b/a, t)</c>.
        /// </summary>
        /// <param name="a">The starting value. Must be non-negative.</param>
        /// <param name="b">The end value. Must be non-negative.</param>
        /// <param name="t">The blend factor.</param>
        /// <returns>The exponential interpolation between <paramref name="a"/> and <paramref name="b"/>.</returns>
        /// <seealso cref="MathHelper.Elerp(float, float, float)"/>
        public static Vector2 Elerp(Vector2 a, Vector2 b, float t)
        {
            a.X = MathF.Pow(a.X, 1 - t) * MathF.Pow(b.X, t);
            a.Y = MathF.Pow(a.Y, 1 - t) * MathF.Pow(b.Y, t);
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the exponential interpolation of the two vectors.
        /// Equivalent to <c>a * pow(b/a, t)</c>.
        /// </summary>
        /// <param name="a">The starting value. Must be non-negative.</param>
        /// <param name="b">The end value. Must be non-negative.</param>
        /// <param name="t">The blend factor.</param>
        /// <param name="result">The exponential interpolation between <paramref name="a"/> and <paramref name="b"/>.</param>
        /// <seealso cref="MathHelper.Elerp(float, float, float)"/>
        public static void Elerp(in Vector2 a, in Vector2 b, float t, out Vector2 result)
        {
            result.X = MathF.Pow(a.X, 1 - t) * MathF.Pow(b.X, t);
            result.Y = MathF.Pow(a.Y, 1 - t) * MathF.Pow(b.Y, t);
        }

        /// <summary>
        /// Interpolate 3 Vectors using Barycentric coordinates.
        /// </summary>
        /// <param name="a">First input Vector.</param>
        /// <param name="b">Second input Vector.</param>
        /// <param name="c">Third input Vector.</param>
        /// <param name="u">First Barycentric Coordinate.</param>
        /// <param name="v">Second Barycentric Coordinate.</param>
        /// <returns>a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise.</returns>
        [Pure]
        public static Vector2 BaryCentric(Vector2 a, Vector2 b, Vector2 c, float u, float v)
        {
            BaryCentric(in a, in b, in c, u, v, out Vector2 result);
            return result;
        }

        /// <summary>
        /// Interpolate 3 Vectors using Barycentric coordinates.
        /// </summary>
        /// <param name="a">First input Vector.</param>
        /// <param name="b">Second input Vector.</param>
        /// <param name="c">Third input Vector.</param>
        /// <param name="u">First Barycentric Coordinate.</param>
        /// <param name="v">Second Barycentric Coordinate.</param>
        /// <param name="result">
        /// Output Vector. a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c
        /// otherwise.
        /// </param>
        public static void BaryCentric
        (
            in Vector2 a,
            in Vector2 b,
            in Vector2 c,
            float u,
            float v,
            out Vector2 result
        )
        {
            Subtract(in b, in a, out Vector2 ab);
            Multiply(in ab, u, out Vector2 abU);
            Add(in a, in abU, out Vector2 uPos);

            Subtract(in c, in a, out Vector2 ac);
            Multiply(in ac, v, out Vector2 acV);
            Add(in uPos, in acV, out result);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 TransformRow(Vector2 vec, Matrix2 mat)
        {
            TransformRow(in vec, in mat, out Vector2 result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformRow(in Vector2 vec, in Matrix2 mat, out Vector2 result)
        {
            result = new Vector2(
                (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X),
                (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y));
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector in 3 dimensions.</returns>
        [Pure]
        public static Vector3 TransformThreeDimensionsRow(Vector2 vec, Matrix2x3 mat)
        {
            TransformThreeDimensionsRow(in vec, in mat, out Vector3 result);
            return result;
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed, 3-dimensional vector.</param>
        public static void TransformThreeDimensionsRow(in Vector2 vec, in Matrix2x3 mat, out Vector3 result)
        {
            result = new Vector3(
                (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X),
                (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y),
                (vec.X * mat.Row0.Z) + (vec.Y * mat.Row1.Z)
            );
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector in 3 dimensions.</returns>
        [Pure]
        public static Vector4 TransformFourDimensionsRow(Vector2 vec, Matrix2x4 mat)
        {
            TransformFourDimensionsRow(in vec, in mat, out Vector4 result);
            return result;
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 4-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformFourDimensionsRow(in Vector2 vec, in Matrix2x4 mat, out Vector4 result)
        {
            result = new Vector4(
                (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X),
                (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y),
                (vec.X * mat.Row0.Z) + (vec.Y * mat.Row1.Z),
                (vec.X * mat.Row0.W) + (vec.Y * mat.Row1.W)
            );
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector2 Transform(Vector2 vec, Quaternion quat)
        {
            Transform(in vec, in quat, out Vector2 result);
            return result;
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Transform(in Vector2 vec, in Quaternion quat, out Vector2 result)
        {
            Quaternion v = new Quaternion(vec.X, vec.Y, 0, 0);
            Quaternion.Invert(in quat, out Quaternion i);
            Quaternion.Multiply(in quat, in v, out Quaternion t);
            Quaternion.Multiply(in t, in i, out v);

            result.X = v.X;
            result.Y = v.Y;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 TransformColumn(Matrix2 mat, Vector2 vec)
        {
            TransformColumn(in mat, in vec, out Vector2 result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformColumn(in Matrix2 mat, in Vector2 vec, out Vector2 result)
        {
            result.X = (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y);
            result.Y = (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y);
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector in 3 dimensions.</returns>
        [Pure]
        public static Vector3 TransformThreeDimensionsColumn(Matrix3x2 mat, Vector2 vec)
        {
            TransformThreeDimensionsColumn(in mat, in vec, out Vector3 result);
            return result;
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed, 3-dimensional vector.</param>
        public static void TransformThreeDimensionsColumn(in Matrix3x2 mat, in Vector2 vec, out Vector3 result)
        {
            result.X = (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y);
            result.Y = (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y);
            result.Z = (mat.Row2.X * vec.X) + (mat.Row2.Y * vec.Y);
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector in 3 dimensions.</returns>
        [Pure]
        public static Vector4 TransformFourDimensionsColumn(Matrix4x2 mat, Vector2 vec)
        {
            TransformFourDimensionsColumn(in mat, in vec, out Vector4 result);
            return result;
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed, 3-dimensional vector.</param>
        public static void TransformFourDimensionsColumn(in Matrix4x2 mat, in Vector2 vec, out Vector4 result)
        {
            result.X = (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y);
            result.Y = (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y);
            result.Z = (mat.Row2.X * vec.X) + (mat.Row2.Y * vec.Y);
            result.W = (mat.Row3.X * vec.X) + (mat.Row3.Y * vec.Y);
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Yx
        {
            readonly get => new Vector2(Y, X);
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector2 operator +(Vector2 left, float right)
        {
            left.X += right;
            left.Y += right;
            return left;
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector2 operator +(float left, Vector2 right)
        {
            right.X += left;
            right.Y += left;
            return right;
        }

        /// <summary>
        /// Adds the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the addition.</returns>
        [Pure]
        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            left.X += right.X;
            left.Y += right.Y;
            return left;
        }

        /// <summary>
        /// Subtracts an instance by a scalar.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector2 operator -(Vector2 left, float right)
        {
            left.X -= right;
            left.Y -= right;
            return left;
        }

        /// <summary>
        /// Subtracts a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector2 operator -(float left, Vector2 right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
            return right;
        }

        /// <summary>
        /// Subtracts the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            return left;
        }

        /// <summary>
        /// Negates the specified instance.
        /// </summary>
        /// <param name="vec">Operand.</param>
        /// <returns>Result of negation.</returns>
        [Pure]
        public static Vector2 operator -(Vector2 vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            return vec;
        }

        /// <summary>
        /// Computes the unary plus of the vector.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector2 operator +(Vector2 vec)
        {
            vec.X = +vec.X;
            vec.Y = +vec.Y;
            return vec;
        }

        /// <summary>
        /// Multiplies the specified instance by a scalar.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector2 operator *(Vector2 vec, float scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies the specified instance by a scalar.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector2 operator *(float scale, Vector2 vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Component-wise multiplication between the specified instance by a scale vector.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector2 operator *(Vector2 vec, Vector2 scale)
        {
            vec.X *= scale.X;
            vec.Y *= scale.Y;
            return vec;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 operator *(Vector2 vec, Matrix2 mat)
        {
            TransformRow(in vec, in mat, out Vector2 result);
            return result;
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 3-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 operator *(Vector2 vec, Matrix2x3 mat)
        {
            TransformThreeDimensionsRow(in vec, in mat, out Vector3 result);
            return result;
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 4-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 operator *(Vector2 vec, Matrix2x4 mat)
        {
            TransformFourDimensionsRow(in vec, in mat, out Vector4 result);
            return result;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector2 operator /(Vector2 vec, float scale)
        {
            vec.X /= scale;
            vec.Y /= scale;
            return vec;
        }

        /// <summary>
        /// Divides a scalar by an instance.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector2 operator /(float left, Vector2 right)
        {
            right.X = left / right.X;
            right.Y = left / right.Y;
            return right;
        }

        /// <summary>
        /// Component-wise division between the specified instance by a scale vector.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector2 operator /(Vector2 vec, Vector2 scale)
        {
            vec.X /= scale.X;
            vec.Y /= scale.Y;
            return vec;
        }

        /// <summary>
        /// Component wise less than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        [Pure]
        public static Vector2b operator <(Vector2 left, Vector2 right)
        {
            return LessThan(left, right);
        }

        /// <summary>
        /// Component wise less than or equal comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal the right component.</returns>
        [Pure]
        public static Vector2b operator <=(Vector2 left, Vector2 right)
        {
            return LessThanOrEqual(left, right);
        }

        /// <summary>
        /// Component wise greater than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding greater component is greater than the right component.</returns>
        [Pure]
        public static Vector2b operator >(Vector2 left, Vector2 right)
        {
            return GreaterThan(left, right);
        }

        /// <summary>
        /// Component wise greater than or equal comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal the right component.</returns>
        [Pure]
        public static Vector2b operator >=(Vector2 left, Vector2 right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares the specified instances for equality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified instances for inequality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector2"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector2((float X, float Y) values)
        {
            return new Vector2(values.X, values.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2 to OpenTK.Vector2d.
        /// </summary>
        /// <param name="vec">The Vector2 to convert.</param>
        /// <returns>The resulting Vector2d.</returns>
        [Pure]
        public static implicit operator Vector2d(Vector2 vec)
        {
            return new Vector2d(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2 to OpenTK.Vector2h.
        /// </summary>
        /// <param name="vec">The Vector2 to convert.</param>
        /// <returns>The resulting Vector2h.</returns>
        [Pure]
        public static explicit operator Vector2h(Vector2 vec)
        {
            return new Vector2h(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2 to OpenTK.Vector2i.
        /// </summary>
        /// <param name="vec">The Vector2 to convert.</param>
        /// <returns>The resulting Vector2i.</returns>
        [Pure]
        public static explicit operator Vector2i(Vector2 vec)
        {
            return new Vector2i((int)vec.X, (int)vec.Y);
        }

        /// <summary>
        /// Converts <see cref="Vector2"/> to <see cref="System.Drawing.PointF"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector2"/> to cast.</param>
        /// <returns>The resulting <see cref="System.Drawing.PointF"/>.</returns>
        [Pure]
        public static explicit operator System.Drawing.PointF(Vector2 vec)
        {
            return new System.Drawing.PointF(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts <see cref="Vector2"/> to <see cref="System.Drawing.SizeF"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector2"/> to cast.</param>
        /// <returns>The resulting <see cref="System.Drawing.SizeF"/>.</returns>
        [Pure]
        public static explicit operator System.Drawing.SizeF(Vector2 vec)
        {
            return new System.Drawing.SizeF(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts <see cref="System.Numerics.Vector2"/> to <see cref="Vector2"/>.
        /// </summary>
        /// <param name="vec">The <see cref="System.Numerics.Vector2"/> to cast.</param>
        [Pure]
        public static explicit operator Vector2(System.Numerics.Vector2 vec)
        {
            return Unsafe.As<System.Numerics.Vector2, Vector2>(ref vec);
        }

        /// <summary>
        /// Converts <see cref="Vector2"/> to <see cref="System.Numerics.Vector2"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector2"/> to cast.</param>
        [Pure]
        public static explicit operator System.Numerics.Vector2(Vector2 vec)
        {
            return Unsafe.As<Vector2, System.Numerics.Vector2>(ref vec);
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
            return string.Format(
                "({0}{2} {1})",
                X.ToString(format, formatProvider),
                Y.ToString(format, formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <inheritdoc/>
        public override readonly bool Equals(object obj)
        {
            return obj is Vector2 && Equals((Vector2)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector2 other)
        {
            return X == other.X &&
                   Y == other.Y;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        [Pure]
        public readonly void Deconstruct(out float x, out float y)
        {
            x = X;
            y = Y;
        }
    }
}
