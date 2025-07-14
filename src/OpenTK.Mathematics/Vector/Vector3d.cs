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
using System.Runtime.Intrinsics;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 3D vector using three double-precision floating-point numbers.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3d : IEquatable<Vector3d>, IFormattable,
                            IAdditionOperators<Vector3d, Vector3d, Vector3d>,
                            ISubtractionOperators<Vector3d, Vector3d, Vector3d>,
                            IUnaryNegationOperators<Vector3d, Vector3d>,
                            IUnaryPlusOperators<Vector3d, Vector3d>,
                            IMultiplyOperators<Vector3d, double, Vector3d>,
                            IMultiplyOperators<Vector3d, Vector3d, Vector3d>,
                            IMultiplyOperators<Vector3d, Matrix3x2d, Vector2d>,
                            IMultiplyOperators<Vector3d, Matrix3d, Vector3d>,
                            IMultiplyOperators<Vector3d, Matrix3x4d, Vector4d>,
                            IDivisionOperators<Vector3d, double, Vector3d>,
                            IDivisionOperators<Vector3d, Vector3d, Vector3d>,
                            IEqualityOperators<Vector3d, Vector3d, bool>,
                            IAdditiveIdentity<Vector3d, Vector3d>,
                            IMultiplicativeIdentity<Vector3d, Vector3d>,
                            IMinMaxValue<Vector3d>
    {
        /// <summary>
        /// The X component of the Vector3.
        /// </summary>
        public double X;

        /// <summary>
        /// The Y component of the Vector3.
        /// </summary>
        public double Y;

        /// <summary>
        /// The Z component of the Vector3.
        /// </summary>
        public double Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3d"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3d(double value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3d"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector3d.</param>
        /// <param name="y">The y component of the Vector3d.</param>
        /// <param name="z">The z component of the Vector3d.</param>
        public Vector3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3d"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector3d.</param>
        /// <param name="z">The z component of the Vector3d.</param>
        public Vector3d(Vector2d xy, double z = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        /// <summary>
        /// Gets or sets the value at the index of the Vector.
        /// </summary>
        /// <param name="index">The index of the component from the Vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 2.</exception>
        public double this[int index]
        {
            readonly get
            {
                if (((uint)index) > 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this vector at index: {0}", index);
                }

                return GetElementUnsafe(in this, index);
            }

            set
            {
                if (((uint)index) > 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this vector at index: {0}", index);
                }

                GetElementUnsafe(in this, index) = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref double GetElementUnsafe(in Vector3d v, int index)
        {
            ref double address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public readonly double Length => Math.Sqrt((X * X) + (Y * Y) + (Z * Z));

        /// <summary>
        /// Gets an approximation of 1 over the length (magnitude) of the vector.
        /// </summary>
        public readonly double ReciprocalLengthFast => Math.ReciprocalSqrtEstimate((X * X) + (Y * Y) + (Z * Z));

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public readonly double LengthFast => 1.0 / Math.ReciprocalSqrtEstimate((X * X) + (Y * Y) + (Z * Z));

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthFast"/>
        public readonly double LengthSquared => (X * X) + (Y * Y) + (Z * Z);

        /// <summary>
        /// Returns a copy of the Vector3d scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public readonly Vector3d Normalized()
        {
            Vector3d v = this;
            v.Normalize();
            return v;
        }

        /// <summary>
        /// Scales the Vector3d to unit length.
        /// </summary>
        public void Normalize()
        {
            double scale = 1.0 / Length;
            X *= scale;
            Y *= scale;
            Z *= scale;
        }

        /// <summary>
        /// Scales the Vector3d to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            double scale = Math.ReciprocalSqrtEstimate((X * X) + (Y * Y) + (Z * Z));
            X *= scale;
            Y *= scale;
            Z *= scale;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector3d Abs()
        {
            Vector3d result = this;
            result.X = Math.Abs(result.X);
            result.Y = Math.Abs(result.Y);
            result.Z = Math.Abs(result.Z);
            return result;
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied.
        /// Equivalent to calling <see cref="Math.Round(double)"/> on each component.
        /// </summary>
        /// <returns>The rounded vector.</returns>
        public readonly Vector3d Round()
        {
            return Round(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied with the specified midpoint rounding rule.
        /// Equivalent to calling <see cref="Math.Round(double,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The rounded vector.</returns>
        public readonly Vector3d Round(MidpointRounding rounding)
        {
            return Round(this, rounding);
        }

        /// <summary>
        /// Returns a new vector were a component-wise ceiling operation has been applied.
        /// Equivalent to calling <see cref="Math.Ceiling(double)"/> on each component.
        /// </summary>
        /// <returns>The ceiled vector.</returns>
        public readonly Vector3d Ceiling()
        {
            return Ceiling(this);
        }

        /// <summary>
        /// Returns a new vector were a component-wise floor operation has been applied.
        /// Equivalent to calling <see cref="Math.Floor(double)"/> on each component.
        /// </summary>
        /// <returns>The floored vector.</returns>
        public readonly Vector3d Floor()
        {
            return Floor(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise truncation has been applied.
        /// Equivalent to calling <see cref="Math.Truncate(double)"/> on each component.
        /// </summary>
        /// <returns>The truncated vector.</returns>
        public readonly Vector3d Truncate()
        {
            return Truncate(this);
        }

        /// <summary>
        /// Defines a unit-length Vector3d that points towards the X-axis.
        /// </summary>
        public static readonly Vector3d UnitX = new Vector3d(1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector3d that points towards the Y-axis.
        /// </summary>
        public static readonly Vector3d UnitY = new Vector3d(0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector3d that points towards the Z-axis.
        /// </summary>
        public static readonly Vector3d UnitZ = new Vector3d(0, 0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector3d Zero = new Vector3d(0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector3d One = new Vector3d(1, 1, 1);

        /// <summary>
        /// Defines an instance with all components set to positive infinity.
        /// </summary>
        public static readonly Vector3d PositiveInfinity = new Vector3d(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);

        /// <summary>
        /// Defines an instance with all components set to negative infinity.
        /// </summary>
        public static readonly Vector3d NegativeInfinity = new Vector3d(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);

        /// <summary>
        /// Defines the size of the Vector3d struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector3d>();

        /// <summary>
        /// Gets the additive identity of Vector3d. Equivalent to Vector3d.Zero.
        /// </summary>
        public static Vector3d AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector3d. Equivalent to Vector3d.One.
        /// </summary>
        public static Vector3d MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the max value for Vector3d. Equivalent to Vector3d.PositiveInfinity.
        /// </summary>
        public static Vector3d MaxValue => PositiveInfinity;

        /// <summary>
        /// Gets the min value for Vector3d. Equivalent to Vector3d.NegativeInfinity.
        /// </summary>
        public static Vector3d MinValue => NegativeInfinity;

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        [Pure]
        public static Vector3d Add(Vector3d a, Vector3d b)
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
        public static void Add(in Vector3d a, in Vector3d b, out Vector3d result)
        {
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector3d Subtract(Vector3d a, Vector3d b)
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
        public static void Subtract(in Vector3d a, in Vector3d b, out Vector3d result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3d Multiply(Vector3d vector, double scale)
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
        public static void Multiply(in Vector3d vector, double scale, out Vector3d result)
        {
            result.X = vector.X * scale;
            result.Y = vector.Y * scale;
            result.Z = vector.Z * scale;
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3d Multiply(Vector3d vector, Vector3d scale)
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
        public static void Multiply(in Vector3d vector, in Vector3d scale, out Vector3d result)
        {
            result.X = vector.X * scale.X;
            result.Y = vector.Y * scale.Y;
            result.Z = vector.Z * scale.Z;
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3d Divide(Vector3d vector, double scale)
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
        public static void Divide(in Vector3d vector, double scale, out Vector3d result)
        {
            result.X = vector.X / scale;
            result.Y = vector.Y / scale;
            result.Z = vector.Z / scale;
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3d Divide(Vector3d vector, Vector3d scale)
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
        public static void Divide(in Vector3d vector, in Vector3d scale, out Vector3d result)
        {
            result.X = vector.X / scale.X;
            result.Y = vector.Y / scale.Y;
            result.Z = vector.Z / scale.Z;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector3d ComponentMin(Vector3d a, Vector3d b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector3d a, in Vector3d b, out Vector3d result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector3d ComponentMax(Vector3d a, Vector3d b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector3d a, in Vector3d b, out Vector3d result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
        }

        /// <summary>
        /// Returns the Vector3d with the minimum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector3d.</returns>
        [Pure]
        public static Vector3d MagnitudeMin(Vector3d left, Vector3d right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3d with the minimum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise minimum.</param>
        public static void MagnitudeMin(in Vector3d left, in Vector3d right, out Vector3d result)
        {
            result = left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3d with the minimum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector3d.</returns>
        [Pure]
        public static Vector3d MagnitudeMax(Vector3d left, Vector3d right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3d with the maximum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise maximum.</param>
        public static void MagnitudeMax(in Vector3d left, in Vector3d right, out Vector3d result)
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
        public static Vector3d Clamp(Vector3d vec, Vector3d min, Vector3d max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector3d vec, in Vector3d min, in Vector3d max, out Vector3d result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector3d Abs(Vector3d vec)
        {
            vec.X = Math.Abs(vec.X);
            vec.Y = Math.Abs(vec.Y);
            vec.Z = Math.Abs(vec.Z);
            return vec;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector3d vec, out Vector3d result)
        {
            result.X = Math.Abs(vec.X);
            result.Y = Math.Abs(vec.Y);
            result.Z = Math.Abs(vec.Z);
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="Math.Round(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector3d Round(Vector3d vec)
        {
            vec.X = Math.Round(vec.X);
            vec.Y = Math.Round(vec.Y);
            vec.Z = Math.Round(vec.Z);
            return vec;
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="Math.Round(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector3d vec, out Vector3d result)
        {
            result.X = Math.Round(vec.X);
            result.Y = Math.Round(vec.Y);
            result.Z = Math.Round(vec.Z);
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="Math.Round(double,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector3d Round(Vector3d vec, MidpointRounding rounding)
        {
            vec.X = Math.Round(vec.X, rounding);
            vec.Y = Math.Round(vec.Y, rounding);
            vec.Z = Math.Round(vec.Z, rounding);
            return vec;
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="Math.Round(double,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector3d vec, MidpointRounding rounding, out Vector3d result)
        {
            result.X = Math.Round(vec.X, rounding);
            result.Y = Math.Round(vec.Y, rounding);
            result.Z = Math.Round(vec.Z, rounding);
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="Math.Ceiling(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <returns>The component-wise ceiling vector.</returns>
        [Pure]
        public static Vector3d Ceiling(Vector3d vec)
        {
            vec.X = Math.Ceiling(vec.X);
            vec.Y = Math.Ceiling(vec.Y);
            vec.Z = Math.Ceiling(vec.Z);
            return vec;
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="Math.Ceiling(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <param name="result">The component-wise ceiling vector.</param>
        public static void Ceiling(in Vector3d vec, out Vector3d result)
        {
            result.X = Math.Ceiling(vec.X);
            result.Y = Math.Ceiling(vec.Y);
            result.Z = Math.Ceiling(vec.Z);
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="Math.Floor(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <returns>The component-wise floored vector.</returns>
        [Pure]
        public static Vector3d Floor(Vector3d vec)
        {
            vec.X = Math.Floor(vec.X);
            vec.Y = Math.Floor(vec.Y);
            vec.Z = Math.Floor(vec.Z);
            return vec;
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="Math.Floor(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <param name="result">The component-wise floored vector.</param>
        public static void Floor(in Vector3d vec, out Vector3d result)
        {
            result.X = Math.Floor(vec.X);
            result.Y = Math.Floor(vec.Y);
            result.Z = Math.Floor(vec.Z);
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="Math.Truncate(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <returns>The component-wise truncated vector.</returns>
        [Pure]
        public static Vector3d Truncate(Vector3d vec)
        {
            vec.X = Math.Truncate(vec.X);
            vec.Y = Math.Truncate(vec.Y);
            vec.Z = Math.Truncate(vec.Z);
            return vec;
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="Math.Truncate(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <param name="result">The component-wise truncated vector.</param>
        public static void Truncate(in Vector3d vec, out Vector3d result)
        {
            result.X = Math.Truncate(vec.X);
            result.Y = Math.Truncate(vec.Y);
            result.Z = Math.Truncate(vec.Z);
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The distance.</returns>
        [Pure]
        public static double Distance(Vector3d vec1, Vector3d vec2)
        {
            Distance(in vec1, in vec2, out double result);
            return result;
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The distance.</param>
        public static void Distance(in Vector3d vec1, in Vector3d vec2, out double result)
        {
            result = Math.Sqrt(((vec2.X - vec1.X) * (vec2.X - vec1.X)) + ((vec2.Y - vec1.Y) * (vec2.Y - vec1.Y)) +
                               ((vec2.Z - vec1.Z) * (vec2.Z - vec1.Z)));
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The squared distance.</returns>
        [Pure]
        public static double DistanceSquared(Vector3d vec1, Vector3d vec2)
        {
            DistanceSquared(in vec1, in vec2, out double result);
            return result;
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The squared distance.</param>
        public static void DistanceSquared(in Vector3d vec1, in Vector3d vec2, out double result)
        {
            result = ((vec2.X - vec1.X) * (vec2.X - vec1.X)) + ((vec2.Y - vec1.Y) * (vec2.Y - vec1.Y)) +
                     ((vec2.Z - vec1.Z) * (vec2.Z - vec1.Z));
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector3d Normalize(Vector3d vec)
        {
            double scale = 1.0 / vec.Length;
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void Normalize(in Vector3d vec, out Vector3d result)
        {
            double scale = 1.0 / vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector3d NormalizeFast(Vector3d vec)
        {
            double scale = Math.ReciprocalSqrtEstimate((vec.X * vec.X) + (vec.Y * vec.Y) + (vec.Z * vec.Z));
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void NormalizeFast(in Vector3d vec, out Vector3d result)
        {
            double scale = Math.ReciprocalSqrtEstimate((vec.X * vec.X) + (vec.Y * vec.Y) + (vec.Z * vec.Z));
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        [Pure]
        public static double Dot(Vector3d left, Vector3d right)
        {
            return (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The dot product of the two inputs.</param>
        public static void Dot(in Vector3d left, in Vector3d right, out double result)
        {
            result = (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z);
        }

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The cross product of the two inputs.</returns>
        [Pure]
        public static Vector3d Cross(Vector3d left, Vector3d right)
        {
            Cross(in left, in right, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The cross product of the two inputs.</param>
        public static void Cross(in Vector3d left, in Vector3d right, out Vector3d result)
        {
            result.X = (left.Y * right.Z) - (left.Z * right.Y);
            result.Y = (left.Z * right.X) - (left.X * right.Z);
            result.Z = (left.X * right.Y) - (left.Y * right.X);
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector3b LessThan(in Vector3d left, in Vector3d right)
        {
            return new Vector3b(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector3b LessThanOrEqual(in Vector3d left, in Vector3d right)
        {
            return new Vector3b(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector3b GreaterThan(in Vector3d left, in Vector3d right)
        {
            return new Vector3b(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector3b GreaterThanOrEqual(in Vector3d left, in Vector3d right)
        {
            return new Vector3b(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector3b ComponentEqual(in Vector3d left, in Vector3d right)
        {
            return new Vector3b(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector3b ComponentNotEqual(in Vector3d left, in Vector3d right)
        {
            return new Vector3b(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise.</returns>
        [Pure]
        public static Vector3d Lerp(Vector3d a, Vector3d b, double blend)
        {
            a.X = (blend * (b.X - a.X)) + a.X;
            a.Y = (blend * (b.Y - a.Y)) + a.Y;
            a.Z = (blend * (b.Z - a.Z)) + a.Z;
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise.</param>
        public static void Lerp(in Vector3d a, in Vector3d b, double blend, out Vector3d result)
        {
            result.X = (blend * (b.X - a.X)) + a.X;
            result.Y = (blend * (b.Y - a.Y)) + a.Y;
            result.Z = (blend * (b.Z - a.Z)) + a.Z;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</returns>
        [Pure]
        public static Vector3d Lerp(Vector3d a, Vector3d b, Vector3d blend)
        {
            a.X = (blend.X * (b.X - a.X)) + a.X;
            a.Y = (blend.Y * (b.Y - a.Y)) + a.Y;
            a.Z = (blend.Z * (b.Z - a.Z)) + a.Z;
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</param>
        public static void Lerp(in Vector3d a, in Vector3d b, Vector3d blend, out Vector3d result)
        {
            result.X = (blend.X * (b.X - a.X)) + a.X;
            result.Y = (blend.Y * (b.Y - a.Y)) + a.Y;
            result.Z = (blend.Z * (b.Z - a.Z)) + a.Z;
        }

        /// <summary>
        /// Returns a new vector that is the spherical interpolation of the two given vectors.
        /// <paramref name="a"/> and <paramref name="b"/> need to be normalized for this function to work properly.
        /// Results are undefined for vectors that point in opposite directions or very close to opposite directions.
        /// </summary>
        /// <param name="a">Unit vector start point.</param>
        /// <param name="b">Unit vector end point.</param>
        /// <param name="t">The blend factor.</param>
        /// <returns><paramref name="a"/> when <paramref name="t"/>=0, <paramref name="b"/> when <paramref name="t"/>=1, and a spherical interpolation between the vectors otherwise.</returns>
        [Pure]
        public static Vector3d Slerp(Vector3d a, Vector3d b, double t)
        {
            double abLength = a.Length * b.Length;
            double cosTheta;
            if (abLength == 0 || Math.Abs(cosTheta = Dot(a, b) / abLength) > 0.99999999)
            {
                return Lerp(a, b, t);
            }
            else
            {
                double theta = Math.Acos(Math.Clamp(cosTheta, -1, 1));
                // We use the fact that:
                // sin(θ) = sqrt(1 - cos(θ)^2)
                // to avoid doing sin(θ) which is slower than sqrt.
                double sinTheta = Math.Sqrt(1 - (cosTheta * cosTheta));
                double acoef = Math.Sin((1 - t) * theta) / sinTheta;
                double bcoef = Math.Sin(t * theta) / sinTheta;
                return (acoef * a) + (bcoef * b);
            }
        }

        /// <summary>
        /// Returns a new vector that is the spherical interpolation of the two given vectors.
        /// <paramref name="a"/> and <paramref name="b"/> need to be normalized for this function to work properly.
        /// Results are undefined for vectors that point in opposite directions or very close to opposite directions.
        /// </summary>
        /// <param name="a">Unit vector start point.</param>
        /// <param name="b">Unit vector end point.</param>
        /// <param name="t">The blend factor.</param>
        /// <param name="result">Is <paramref name="a"/> when <paramref name="t"/>=0, <paramref name="b"/> when <paramref name="t"/>=1, and a spherical interpolation between the vectors otherwise.</param>
        public static void Slerp(in Vector3d a, in Vector3d b, double t, out Vector3d result)
        {
            double abLength = a.Length * b.Length;
            if (abLength == 0)
            {
                Lerp(in a, in b, t, out result);
            }
            else
            {
                Dot(in a, in b, out double cosTheta);
                cosTheta /= abLength;
                if (Math.Abs(cosTheta) > 0.99999999)
                {
                    Lerp(in a, in b, t, out result);
                }
                else
                {
                    double theta = Math.Acos(cosTheta);
                    // We use the fact that:
                    // sin(θ) = sqrt(1 - cos(θ)^2)
                    // to avoid doing sin(θ) which is slower than sqrt.
                    double sinTheta = Math.Sqrt(1 - (cosTheta * cosTheta));
                    double acoef = Math.Sin((1 - t) * theta) / sinTheta;
                    double bcoef = Math.Sin(t * theta) / sinTheta;
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
        /// <seealso cref="MathHelper.Elerp(double, double, double)"/>
        public static Vector3d Elerp(Vector3d a, Vector3d b, double t)
        {
            a.X = Math.Pow(a.X, 1 - t) * Math.Pow(b.X, t);
            a.Y = Math.Pow(a.Y, 1 - t) * Math.Pow(b.Y, t);
            a.Z = Math.Pow(a.Z, 1 - t) * Math.Pow(b.Z, t);
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
        /// <seealso cref="MathHelper.Elerp(double, double, double)"/>
        public static void Elerp(in Vector3d a, in Vector3d b, double t, out Vector3d result)
        {
            result.X = Math.Pow(a.X, 1 - t) * Math.Pow(b.X, t);
            result.Y = Math.Pow(a.Y, 1 - t) * Math.Pow(b.Y, t);
            result.Z = Math.Pow(a.Z, 1 - t) * Math.Pow(b.Z, t);
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
        public static Vector3d BaryCentric(Vector3d a, Vector3d b, Vector3d c, double u, double v)
        {
            BaryCentric(in a, in b, in c, u, v, out Vector3d result);
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
        [Pure]
        public static void BaryCentric
        (
            in Vector3d a,
            in Vector3d b,
            in Vector3d c,
            double u,
            double v,
            out Vector3d result
        )
        {
            Subtract(in b, in a, out Vector3d ab);
            Multiply(in ab, u, out Vector3d abU);
            Add(in a, in abU, out Vector3d uPos);

            Subtract(in c, in a, out Vector3d ac);
            Multiply(in ac, v, out Vector3d acV);
            Add(in uPos, in acV, out result);
        }

        /// <summary>
        /// Transform a direction vector by the given Matrix.
        /// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d TransformVector(Vector3d vec, Matrix4d mat)
        {
            TransformVector(in vec, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a direction vector by the given Matrix.
        /// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformVector(in Vector3d vec, in Matrix4d mat, out Vector3d result)
        {
            result.X = (vec.X * mat.Row0.X) +
                       (vec.Y * mat.Row1.X) +
                       (vec.Z * mat.Row2.X);

            result.Y = (vec.X * mat.Row0.Y) +
                       (vec.Y * mat.Row1.Y) +
                       (vec.Z * mat.Row2.Y);

            result.Z = (vec.X * mat.Row0.Z) +
                       (vec.Y * mat.Row1.Z) +
                       (vec.Z * mat.Row2.Z);
        }

        /// <summary>
        /// Transform a Normal by the given Matrix.
        /// </summary>
        /// <remarks>
        /// This calculates the inverse of the given matrix, use TransformNormalInverse if you
        /// already have the inverse to avoid this extra calculation.
        /// </remarks>
        /// <param name="norm">The normal to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed normal.</returns>
        [Pure]
        public static Vector3d TransformNormal(Vector3d norm, Matrix4d mat)
        {
            mat.Invert();
            return TransformNormalInverse(norm, mat);
        }

        /// <summary>
        /// Transform a Normal by the given Matrix.
        /// </summary>
        /// <remarks>
        /// This calculates the inverse of the given matrix, use TransformNormalInverse if you
        /// already have the inverse to avoid this extra calculation.
        /// </remarks>
        /// <param name="norm">The normal to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed normal.</param>
        public static void TransformNormal(in Vector3d norm, in Matrix4d mat, out Vector3d result)
        {
            Matrix4d inverse = Matrix4d.Invert(mat);
            TransformNormalInverse(in norm, in inverse, out result);
        }

        /// <summary>
        /// Transform a Normal by the (transpose of the) given Matrix.
        /// </summary>
        /// <remarks>
        /// This version doesn't calculate the inverse matrix.
        /// Use this version if you already have the inverse of the desired transform to hand.
        /// </remarks>
        /// <param name="norm">The normal to transform.</param>
        /// <param name="invMat">The inverse of the desired transformation.</param>
        /// <returns>The transformed normal.</returns>
        [Pure]
        public static Vector3d TransformNormalInverse(Vector3d norm, Matrix4d invMat)
        {
            TransformNormalInverse(in norm, in invMat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a Normal by the (transpose of the) given Matrix.
        /// </summary>
        /// <remarks>
        /// This version doesn't calculate the inverse matrix.
        /// Use this version if you already have the inverse of the desired transform to hand.
        /// </remarks>
        /// <param name="norm">The normal to transform.</param>
        /// <param name="invMat">The inverse of the desired transformation.</param>
        /// <param name="result">The transformed normal.</param>
        public static void TransformNormalInverse(in Vector3d norm, in Matrix4d invMat, out Vector3d result)
        {
            result.X = (norm.X * invMat.Row0.X) +
                       (norm.Y * invMat.Row0.Y) +
                       (norm.Z * invMat.Row0.Z);

            result.Y = (norm.X * invMat.Row1.X) +
                       (norm.Y * invMat.Row1.Y) +
                       (norm.Z * invMat.Row1.Z);

            result.Z = (norm.X * invMat.Row2.X) +
                       (norm.Y * invMat.Row2.Y) +
                       (norm.Z * invMat.Row2.Z);
        }

        /// <summary>
        /// Transform a Position by the given Matrix.
        /// </summary>
        /// <param name="pos">The position to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed position.</returns>
        [Pure]
        public static Vector3d TransformPosition(Vector3d pos, Matrix4d mat)
        {
            TransformPosition(in pos, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a Position by the given Matrix.
        /// </summary>
        /// <param name="pos">The position to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed position.</param>
        public static void TransformPosition(in Vector3d pos, in Matrix4d mat, out Vector3d result)
        {
            result.X = (pos.X * mat.Row0.X) +
                       (pos.Y * mat.Row1.X) +
                       (pos.Z * mat.Row2.X) +
                       mat.Row3.X;

            result.Y = (pos.X * mat.Row0.Y) +
                       (pos.Y * mat.Row1.Y) +
                       (pos.Z * mat.Row2.Y) +
                       mat.Row3.Y;

            result.Z = (pos.X * mat.Row0.Z) +
                       (pos.Y * mat.Row1.Z) +
                       (pos.Z * mat.Row2.Z) +
                       mat.Row3.Z;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d TransformRow(Vector3d vec, Matrix3d mat)
        {
            TransformRow(in vec, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformRow(in Vector3d vec, in Matrix3d mat, out Vector3d result)
        {
            result.X = (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X) + (vec.Z * mat.Row2.X);
            result.Y = (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y) + (vec.Z * mat.Row2.Y);
            result.Z = (vec.X * mat.Row0.Z) + (vec.Y * mat.Row1.Z) + (vec.Z * mat.Row2.Z);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2d TransformTwoDimensionsRow(Vector3d vec, Matrix3x2d mat)
        {
            TransformTwoDimensionsRow(in vec, in mat, out Vector2d result);
            return result;
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsRow(in Vector3d vec, in Matrix3x2d mat, out Vector2d result)
        {
            result.X = (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X) + (vec.Z * mat.Row2.X);
            result.Y = (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y) + (vec.Z * mat.Row2.Y);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2d TransformTwoDimensionsColumn(Matrix2x3d mat, Vector3d vec)
        {
            TransformTwoDimensionsColumn(in mat, in vec, out Vector2d result);
            return result;
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsColumn(in Matrix2x3d mat, in Vector3d vec, out Vector2d result)
        {
            result.X = (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y) + (mat.Row0.Z * vec.Z);
            result.Y = (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y) + (mat.Row1.Z * vec.Z);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d TransformFourDimensionsRow(Vector3d vec, Matrix3x4d mat)
        {
            TransformFourDimensionsRow(in vec, in mat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformFourDimensionsRow(in Vector3d vec, in Matrix3x4d mat, out Vector4d result)
        {
            result.X = (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X) + (vec.Z * mat.Row2.X);
            result.Y = (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y) + (vec.Z * mat.Row2.Y);
            result.Z = (vec.X * mat.Row0.Z) + (vec.Y * mat.Row1.Z) + (vec.Z * mat.Row2.Z);
            result.W = (vec.X * mat.Row0.W) + (vec.Y * mat.Row1.W) + (vec.Z * mat.Row2.W);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d TransformFourDimensionsColumn(Matrix4x3d mat, Vector3d vec)
        {
            TransformFourDimensionsColumn(in mat, in vec, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformFourDimensionsColumn(in Matrix4x3d mat, in Vector3d vec, out Vector4d result)
        {
            result.X = (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y) + (mat.Row0.Z * vec.Z);
            result.Y = (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y) + (mat.Row1.Z * vec.Z);
            result.Z = (mat.Row2.X * vec.X) + (mat.Row2.Y * vec.Y) + (mat.Row2.Z * vec.Z);
            result.W = (mat.Row3.X * vec.X) + (mat.Row3.Y * vec.Y) + (mat.Row3.Z * vec.Z);
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3d Transform(Vector3d vec, Quaterniond quat)
        {
            Transform(in vec, in quat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Transform(in Vector3d vec, in Quaterniond quat, out Vector3d result)
        {
            // Since vec.W == 0, we can optimize quat * vec * quat^-1 as follows:
            // vec + 2.0 * cross(quat.xyz, cross(quat.xyz, vec) + quat.w * vec)
            Vector3d xyz = quat.Xyz;
            Cross(in xyz, in vec, out Vector3d temp);
            Multiply(in vec, quat.W, out Vector3d temp2);
            Add(in temp, in temp2, out temp);
            Cross(in xyz, in temp, out temp2);
            Multiply(in temp2, 2f, out temp2);
            Add(in vec, in temp2, out result);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d TransformColumn(Matrix3d mat, Vector3d vec)
        {
            TransformColumn(in mat, in vec, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformColumn(in Matrix3d mat, in Vector3d vec, out Vector3d result)
        {
            result.X = (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y) + (mat.Row0.Z * vec.Z);
            result.Y = (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y) + (mat.Row1.Z * vec.Z);
            result.Z = (mat.Row2.X * vec.X) + (mat.Row2.Y * vec.Y) + (mat.Row2.Z * vec.Z);
        }

        /// <summary>
        /// Transform a Vector3d by the given Matrix, and project the resulting Vector4 back to a Vector3.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d TransformPerspective(Vector3d vec, Matrix4d mat)
        {
            TransformPerspective(in vec, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector3d by the given Matrix, and project the resulting Vector4d back to a Vector3d.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformPerspective(in Vector3d vec, in Matrix4d mat, out Vector3d result)
        {
            Vector4d v = new Vector4d(vec.X, vec.Y, vec.Z, 1);
            Vector4d.TransformRow(in v, in mat, out v);
            result.X = v.X / v.W;
            result.Y = v.Y / v.W;
            result.Z = v.Z / v.W;
        }

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <returns>Angle (in radians) between the vectors.</returns>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        [Pure]
        public static double CalculateAngle(Vector3d first, Vector3d second)
        {
            CalculateAngle(in first, in second, out double result);
            return result;
        }

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(in Vector3d first, in Vector3d second, out double result)
        {
            Dot(in first, in second, out double temp);
            result = Math.Acos(Math.Clamp(temp / (first.Length * second.Length), -1.0, 1.0));
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xy
        {
            readonly get => new Vector2d(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xz
        {
            readonly get => new Vector2d(X, Z);
            set
            {
                X = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yx
        {
            readonly get => new Vector2d(Y, X);
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yz
        {
            readonly get => new Vector2d(Y, Z);
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zx
        {
            readonly get => new Vector2d(Z, X);
            set
            {
                Z = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zy
        {
            readonly get => new Vector2d(Z, Y);
            set
            {
                Z = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzy
        {
            readonly get => new Vector3d(X, Z, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxz
        {
            readonly get => new Vector3d(Y, X, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzx
        {
            readonly get => new Vector3d(Y, Z, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxy
        {
            readonly get => new Vector3d(Z, X, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyx
        {
            readonly get => new Vector3d(Z, Y, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3d operator +(Vector3d left, double right)
        {
            left.X += right;
            left.Y += right;
            left.Z += right;
            return left;
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3d operator +(double left, Vector3d right)
        {
            right.X += left;
            right.Y += left;
            right.Z += left;
            return right;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3d operator +(Vector3d left, Vector3d right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            return left;
        }

        /// <summary>
        /// Subtracts an instance by a scalar.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3d operator -(Vector3d left, double right)
        {
            left.X -= right;
            left.Y -= right;
            left.Z -= right;
            return left;
        }

        /// <summary>
        /// Subtracts a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3d operator -(double left, Vector3d right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
            right.Z = left - right.Z;
            return right;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3d operator -(Vector3d left, Vector3d right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            return left;
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3d operator -(Vector3d vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            return vec;
        }

        /// <summary>
        /// Computes the unary plus of the vector.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3d operator +(Vector3d vec)
        {
            vec.X = +vec.X;
            vec.Y = +vec.Y;
            vec.Z = +vec.Z;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3d operator *(Vector3d vec, double scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3d operator *(double scale, Vector3d vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Component-wise multiplication between the specified instance by a scale vector.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector3d operator *(Vector3d vec, Vector3d scale)
        {
            vec.X *= scale.X;
            vec.Y *= scale.Y;
            vec.Z *= scale.Z;
            return vec;
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2d operator *(Vector3d vec, Matrix3x2d mat)
        {
            TransformTwoDimensionsRow(in vec, in mat, out Vector2d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d operator *(Vector3d vec, Matrix3d mat)
        {
            TransformRow(in vec, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector4d operator *(Vector3d vec, Matrix3x4d mat)
        {
            TransformFourDimensionsRow(in vec, in mat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3d operator /(Vector3d vec, double scale)
        {
            vec.X /= scale;
            vec.Y /= scale;
            vec.Z /= scale;
            return vec;
        }

        /// <summary>
        /// Divides a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3d operator /(double left, Vector3d right)
        {
            right.X = left / right.X;
            right.Y = left / right.Y;
            right.Z = left / right.Z;
            return right;
        }

        /// <summary>
        /// Component-wise division between the specified instance by a scale vector.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3d operator /(Vector3d vec, Vector3d scale)
        {
            vec.X /= scale.X;
            vec.Y /= scale.Y;
            vec.Z /= scale.Z;
            return vec;
        }

        /// <summary>
        /// Component wise less than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        [Pure]
        public static Vector3b operator <(Vector3d left, Vector3d right)
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
        public static Vector3b operator <=(Vector3d left, Vector3d right)
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
        public static Vector3b operator >(Vector3d left, Vector3d right)
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
        public static Vector3b operator >=(Vector3d left, Vector3d right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector3d left, Vector3d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector3d left, Vector3d right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector3d to OpenTK.Vector3.
        /// </summary>
        /// <param name="vec">The Vector3d to convert.</param>
        /// <returns>The resulting Vector3.</returns>
        [Pure]
        public static explicit operator Vector3(Vector3d vec)
        {
            return new Vector3((float)vec.X, (float)vec.Y, (float)vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3d to OpenTK.Vector3h.
        /// </summary>
        /// <param name="vec">The Vector3d to convert.</param>
        /// <returns>The resulting Vector3h.</returns>
        [Pure]
        public static explicit operator Vector3h(Vector3d vec)
        {
            return new Vector3h((Half)vec.X, (Half)vec.Y, (Half)vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3d to OpenTK.Vector3i.
        /// </summary>
        /// <param name="vec">The Vector3d to convert.</param>
        /// <returns>The resulting Vector3i.</returns>
        [Pure]
        public static explicit operator Vector3i(Vector3d vec)
        {
            return new Vector3i((int)vec.X, (int)vec.Y, (int)vec.Z);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3d"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector3d"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector3d((double X, double Y, double Z) values)
        {
            return new Vector3d(values.X, values.Y, values.Z);
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

        /// <inheritdoc />
        public readonly string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format(
                "({0}{3} {1}{3} {2})",
                X.ToString(format, formatProvider),
                Y.ToString(format, formatProvider),
                Z.ToString(format, formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <inheritdoc />
        public override readonly bool Equals(object obj)
        {
            return obj is Vector3d && Equals((Vector3d)obj);
        }

        /// <inheritdoc />
        public readonly bool Equals(Vector3d other)
        {
            Vector128<double> thisXy = Vector128.LoadUnsafe(in X);
            Vector128<double> otherXy = Vector128.LoadUnsafe(in other.X);

            return thisXy == otherXy && Z == other.Z;
        }

        /// <inheritdoc />
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        /// <param name="z">The Z component of the vector.</param>
        [Pure]
        public readonly void Deconstruct(out double x, out double y, out double z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
