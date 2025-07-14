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
    /// Represents a 4D vector using four double-precision floating-point numbers.
    /// </summary>
    /// <remarks>
    /// The Vector4 structure is suitable for interoperation with unmanaged code requiring four consecutive doubles.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4d : IEquatable<Vector4d>, IFormattable,
                            IAdditionOperators<Vector4d, Vector4d, Vector4d>,
                            ISubtractionOperators<Vector4d, Vector4d, Vector4d>,
                            IUnaryNegationOperators<Vector4d, Vector4d>,
                            IUnaryPlusOperators<Vector4d, Vector4d>,
                            IMultiplyOperators<Vector4d, double, Vector4d>,
                            IMultiplyOperators<Vector4d, Vector4d, Vector4d>,
                            IMultiplyOperators<Vector4d, Matrix4x2d, Vector2d>,
                            IMultiplyOperators<Vector4d, Matrix4x3d, Vector3d>,
                            IMultiplyOperators<Vector4d, Matrix4d, Vector4d>,
                            IDivisionOperators<Vector4d, double, Vector4d>,
                            IDivisionOperators<Vector4d, Vector4d, Vector4d>,
                            IEqualityOperators<Vector4d, Vector4d, bool>,
                            IAdditiveIdentity<Vector4d, Vector4d>,
                            IMultiplicativeIdentity<Vector4d, Vector4d>,
                            IMinMaxValue<Vector4d>
    {
        /// <summary>
        /// The X component of the Vector4d.
        /// </summary>
        public double X;

        /// <summary>
        /// The Y component of the Vector4d.
        /// </summary>
        public double Y;

        /// <summary>
        /// The Z component of the Vector4d.
        /// </summary>
        public double Z;

        /// <summary>
        /// The W component of the Vector4d.
        /// </summary>
        public double W;

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the X-axis.
        /// </summary>
        public static readonly Vector4d UnitX = new Vector4d(1, 0, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the Y-axis.
        /// </summary>
        public static readonly Vector4d UnitY = new Vector4d(0, 1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the Z-axis.
        /// </summary>
        public static readonly Vector4d UnitZ = new Vector4d(0, 0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the W-axis.
        /// </summary>
        public static readonly Vector4d UnitW = new Vector4d(0, 0, 0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector4d Zero = new Vector4d(0, 0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4d One = new Vector4d(1, 1, 1, 1);

        /// <summary>
        /// Defines an instance with all components set to positive infinity.
        /// </summary>
        public static readonly Vector4d PositiveInfinity = new Vector4d(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);

        /// <summary>
        /// Defines an instance with all components set to negative infinity.
        /// </summary>
        public static readonly Vector4d NegativeInfinity = new Vector4d(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);

        /// <summary>
        /// Defines the size of the Vector4d struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector4d>();

        /// <summary>
        /// Gets the additive identity of Vector4. Equivalent to Vector4.Zero.
        /// </summary>
        public static Vector4d AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector4. Equivalent to Vector4.One.
        /// </summary>
        public static Vector4d MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the max value for Vector4. Equivalent to Vector4.PositiveInfinity.
        /// </summary>
        public static Vector4d MaxValue => PositiveInfinity;

        /// <summary>
        /// Gets the min value for Vector4. Equivalent to Vector4.NegativeInfinity.
        /// </summary>
        public static Vector4d MinValue => NegativeInfinity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4d(double value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector4d.</param>
        /// <param name="y">The y component of the Vector4d.</param>
        /// <param name="z">The z component of the Vector4d.</param>
        /// <param name="w">The w component of the Vector4d.</param>
        public Vector4d(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector4d.</param>
        /// <param name="z">The z component of the Vector4d.</param>
        /// <param name="w">The w component of the Vector4d.</param>
        public Vector4d(Vector2d xy, double z = default, double w = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y and z components of the Vector4d.</param>
        /// <param name="w">The w component of the Vector4d.</param>
        public Vector4d(Vector3d xyz, double w = default)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        /// <summary>
        /// Gets or sets the value at the index of the Vector.
        /// </summary>
        /// <param name="index">The index of the component from the Vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 3.</exception>
        public double this[int index]
        {
            readonly get
            {
                if (((uint)index) > 3)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this vector at index: {0}", index);
                }

                return GetElementUnsafe(in this, index);
            }

            set
            {
                if (((uint)index) > 3)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this vector at index: {0}", index);
                }

                GetElementUnsafe(in this, index) = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref double GetElementUnsafe(in Vector4d v, int index)
        {
            ref double address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public readonly double Length => Math.Sqrt((X * X) + (Y * Y) + (Z * Z) + (W * W));

        /// <summary>
        /// Gets an approximation of 1 over the length (magnitude) of the vector.
        /// </summary>
        public readonly double ReciprocalLengthFast => Math.ReciprocalSqrtEstimate((X * X) + (Y * Y) + (Z * Z) + (W * W));

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public readonly double LengthFast => 1.0 / Math.ReciprocalSqrtEstimate((X * X) + (Y * Y) + (Z * Z) + (W * W));

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        public readonly double LengthSquared => (X * X) + (Y * Y) + (Z * Z) + (W * W);

        /// <summary>
        /// Returns a copy of the Vector4d scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public readonly Vector4d Normalized()
        {
            Vector4d v = this;
            v.Normalize();
            return v;
        }

        /// <summary>
        /// Scales the Vector4d to unit length.
        /// </summary>
        public void Normalize()
        {
            double scale = 1.0 / Length;
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
        }

        /// <summary>
        /// Scales the Vector4d to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            double scale = Math.ReciprocalSqrtEstimate((X * X) + (Y * Y) + (Z * Z) + (W * W));
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector4d Abs()
        {
            Vector4d result = this;
            result.X = Math.Abs(result.X);
            result.Y = Math.Abs(result.Y);
            result.Z = Math.Abs(result.Z);
            result.W = Math.Abs(result.W);
            return result;
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied.
        /// Equivalent to calling <see cref="Math.Round(double)"/> on each component.
        /// </summary>
        /// <returns>The rounded vector.</returns>
        public readonly Vector4d Round()
        {
            return Round(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied with the specified midpoint rounding rule.
        /// Equivalent to calling <see cref="Math.Round(double,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The rounded vector.</returns>
        public readonly Vector4d Round(MidpointRounding rounding)
        {
            return Round(this, rounding);
        }

        /// <summary>
        /// Returns a new vector were a component-wise ceiling operation has been applied.
        /// Equivalent to calling <see cref="Math.Ceiling(double)"/> on each component.
        /// </summary>
        /// <returns>The ceiled vector.</returns>
        public readonly Vector4d Ceiling()
        {
            return Ceiling(this);
        }

        /// <summary>
        /// Returns a new vector were a component-wise floor operation has been applied.
        /// Equivalent to calling <see cref="Math.Floor(double)"/> on each component.
        /// </summary>
        /// <returns>The floored vector.</returns>
        public readonly Vector4d Floor()
        {
            return Floor(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise truncation has been applied.
        /// Equivalent to calling <see cref="Math.Truncate(double)"/> on each component.
        /// </summary>
        /// <returns>The truncated vector.</returns>
        public readonly Vector4d Truncate()
        {
            return Truncate(this);
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        [Pure]
        public static Vector4d Add(Vector4d a, Vector4d b)
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
        public static void Add(in Vector4d a, in Vector4d b, out Vector4d result)
        {
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;
            result.W = a.W + b.W;
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector4d Subtract(Vector4d a, Vector4d b)
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
        public static void Subtract(in Vector4d a, in Vector4d b, out Vector4d result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
            result.W = a.W - b.W;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4d Multiply(Vector4d vector, double scale)
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
        public static void Multiply(in Vector4d vector, double scale, out Vector4d result)
        {
            result.X = vector.X * scale;
            result.Y = vector.Y * scale;
            result.Z = vector.Z * scale;
            result.W = vector.W * scale;
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4d Multiply(Vector4d vector, Vector4d scale)
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
        public static void Multiply(in Vector4d vector, in Vector4d scale, out Vector4d result)
        {
            result.X = vector.X * scale.X;
            result.Y = vector.Y * scale.Y;
            result.Z = vector.Z * scale.Z;
            result.W = vector.W * scale.W;
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4d Divide(Vector4d vector, double scale)
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
        public static void Divide(in Vector4d vector, double scale, out Vector4d result)
        {
            result.X = vector.X / scale;
            result.Y = vector.Y / scale;
            result.Z = vector.Z / scale;
            result.W = vector.W / scale;
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4d Divide(Vector4d vector, Vector4d scale)
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
        public static void Divide(in Vector4d vector, in Vector4d scale, out Vector4d result)
        {
            result.X = vector.X / scale.X;
            result.Y = vector.Y / scale.Y;
            result.Z = vector.Z / scale.Z;
            result.W = vector.W / scale.W;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector4d ComponentMin(Vector4d a, Vector4d b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            a.W = a.W < b.W ? a.W : b.W;
            return a;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector4d a, in Vector4d b, out Vector4d result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
            result.W = a.W < b.W ? a.W : b.W;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector4d ComponentMax(Vector4d a, Vector4d b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            a.W = a.W > b.W ? a.W : b.W;
            return a;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector4d a, in Vector4d b, out Vector4d result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
            result.W = a.W > b.W ? a.W : b.W;
        }

        /// <summary>
        /// Returns the Vector4d with the minimum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector4d.</returns>
        [Pure]
        public static Vector4d MagnitudeMin(Vector4d left, Vector4d right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4d with the minimum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise minimum.</param>
        public static void MagnitudeMin(in Vector4d left, in Vector4d right, out Vector4d result)
        {
            result = left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4d with the minimum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector4d.</returns>
        [Pure]
        public static Vector4d MagnitudeMax(Vector4d left, Vector4d right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4d with the maximum magnitude.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise maximum.</param>
        public static void MagnitudeMax(in Vector4d left, in Vector4d right, out Vector4d result)
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
        public static Vector4d Clamp(Vector4d vec, Vector4d min, Vector4d max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            vec.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector4d vec, in Vector4d min, in Vector4d max, out Vector4d result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            result.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector4d Abs(Vector4d vec)
        {
            vec.X = Math.Abs(vec.X);
            vec.Y = Math.Abs(vec.Y);
            vec.Z = Math.Abs(vec.Z);
            vec.W = Math.Abs(vec.W);
            return vec;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector4d vec, out Vector4d result)
        {
            result.X = Math.Abs(vec.X);
            result.Y = Math.Abs(vec.Y);
            result.Z = Math.Abs(vec.Z);
            result.W = Math.Abs(vec.W);
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="Math.Round(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector4d Round(Vector4d vec)
        {
            vec.X = Math.Round(vec.X);
            vec.Y = Math.Round(vec.Y);
            vec.Z = Math.Round(vec.Z);
            vec.W = Math.Round(vec.W);
            return vec;
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="Math.Round(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector4d vec, out Vector4d result)
        {
            result.X = Math.Round(vec.X);
            result.Y = Math.Round(vec.Y);
            result.Z = Math.Round(vec.Z);
            result.W = Math.Round(vec.W);
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="Math.Round(double,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector4d Round(Vector4d vec, MidpointRounding rounding)
        {
            vec.X = Math.Round(vec.X, rounding);
            vec.Y = Math.Round(vec.Y, rounding);
            vec.Z = Math.Round(vec.Z, rounding);
            vec.W = Math.Round(vec.W, rounding);
            return vec;
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="Math.Round(double,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector4d vec, MidpointRounding rounding, out Vector4d result)
        {
            result.X = Math.Round(vec.X, rounding);
            result.Y = Math.Round(vec.Y, rounding);
            result.Z = Math.Round(vec.Z, rounding);
            result.W = Math.Round(vec.W, rounding);
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="Math.Ceiling(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <returns>The component-wise ceiling vector.</returns>
        [Pure]
        public static Vector4d Ceiling(Vector4d vec)
        {
            vec.X = Math.Ceiling(vec.X);
            vec.Y = Math.Ceiling(vec.Y);
            vec.Z = Math.Ceiling(vec.Z);
            vec.W = Math.Ceiling(vec.W);
            return vec;
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="Math.Ceiling(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <param name="result">The component-wise ceiling vector.</param>
        public static void Ceiling(in Vector4d vec, out Vector4d result)
        {
            result.X = Math.Ceiling(vec.X);
            result.Y = Math.Ceiling(vec.Y);
            result.Z = Math.Ceiling(vec.Z);
            result.W = Math.Ceiling(vec.W);
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="Math.Floor(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <returns>The component-wise floored vector.</returns>
        [Pure]
        public static Vector4d Floor(Vector4d vec)
        {
            vec.X = Math.Floor(vec.X);
            vec.Y = Math.Floor(vec.Y);
            vec.Z = Math.Floor(vec.Z);
            vec.W = Math.Floor(vec.W);
            return vec;
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="Math.Floor(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <param name="result">The component-wise floored vector.</param>
        public static void Floor(in Vector4d vec, out Vector4d result)
        {
            result.X = Math.Floor(vec.X);
            result.Y = Math.Floor(vec.Y);
            result.Z = Math.Floor(vec.Z);
            result.W = Math.Floor(vec.W);
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="Math.Truncate(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <returns>The component-wise truncated vector.</returns>
        [Pure]
        public static Vector4d Truncate(Vector4d vec)
        {
            vec.X = Math.Truncate(vec.X);
            vec.Y = Math.Truncate(vec.Y);
            vec.Z = Math.Truncate(vec.Z);
            vec.W = Math.Truncate(vec.W);
            return vec;
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="Math.Truncate(double)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <param name="result">The component-wise truncated vector.</param>
        public static void Truncate(in Vector4d vec, out Vector4d result)
        {
            result.X = Math.Truncate(vec.X);
            result.Y = Math.Truncate(vec.Y);
            result.Z = Math.Truncate(vec.Z);
            result.W = Math.Truncate(vec.W);
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The distance.</returns>
        [Pure]
        public static double Distance(Vector4d vec1, Vector4d vec2)
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
        public static void Distance(in Vector4d vec1, in Vector4d vec2, out double result)
        {
            result = Math.Sqrt(((vec2.X - vec1.X) * (vec2.X - vec1.X)) + ((vec2.Y - vec1.Y) * (vec2.Y - vec1.Y)) + ((vec2.Z - vec1.Z) * (vec2.Z - vec1.Z)) + ((vec2.W - vec1.W) * (vec2.W - vec1.W)));
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The squared distance.</returns>
        [Pure]
        public static double DistanceSquared(Vector4d vec1, Vector4d vec2)
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
        public static void DistanceSquared(in Vector4d vec1, in Vector4d vec2, out double result)
        {
            result = ((vec2.X - vec1.X) * (vec2.X - vec1.X)) + ((vec2.Y - vec1.Y) * (vec2.Y - vec1.Y)) + ((vec2.Z - vec1.Z) * (vec2.Z - vec1.Z)) + ((vec2.W - vec1.W) * (vec2.W - vec1.W));
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector4d Normalize(Vector4d vec)
        {
            double scale = 1.0 / vec.Length;
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void Normalize(in Vector4d vec, out Vector4d result)
        {
            double scale = 1.0 / vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
            result.W = vec.W * scale;
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector4d NormalizeFast(Vector4d vec)
        {
            double scale = Math.ReciprocalSqrtEstimate((vec.X * vec.X) + (vec.Y * vec.Y) + (vec.Z * vec.Z) + (vec.W * vec.W));
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void NormalizeFast(in Vector4d vec, out Vector4d result)
        {
            double scale = Math.ReciprocalSqrtEstimate((vec.X * vec.X) + (vec.Y * vec.Y) + (vec.Z * vec.Z) + (vec.W * vec.W));
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
            result.W = vec.W * scale;
        }

        /// <summary>
        /// Calculate the dot product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        [Pure]
        public static double Dot(Vector4d left, Vector4d right)
        {
            return (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);
        }

        /// <summary>
        /// Calculate the dot product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The dot product of the two inputs.</param>
        public static void Dot(in Vector4d left, in Vector4d right, out double result)
        {
            result = (left.X * right.X) + (left.Y * right.Y) + (left.Z * right.Z) + (left.W * right.W);
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector4b LessThan(in Vector4d left, in Vector4d right)
        {
            return new Vector4b(left.X < right.X, left.Y < right.Y, left.Z < right.Z, left.W < right.W);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector4b LessThanOrEqual(in Vector4d left, in Vector4d right)
        {
            return new Vector4b(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z, left.W <= right.W);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector4b GreaterThan(in Vector4d left, in Vector4d right)
        {
            return new Vector4b(left.X > right.X, left.Y > right.Y, left.Z > right.Z, left.W > right.W);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector4b GreaterThanOrEqual(in Vector4d left, in Vector4d right)
        {
            return new Vector4b(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z, left.W >= right.W);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector4b ComponentEqual(in Vector4d left, in Vector4d right)
        {
            return new Vector4b(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector4b ComponentNotEqual(in Vector4d left, in Vector4d right)
        {
            return new Vector4b(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise.</returns>
        [Pure]
        public static Vector4d Lerp(Vector4d a, Vector4d b, double blend)
        {
            a.X = (blend * (b.X - a.X)) + a.X;
            a.Y = (blend * (b.Y - a.Y)) + a.Y;
            a.Z = (blend * (b.Z - a.Z)) + a.Z;
            a.W = (blend * (b.W - a.W)) + a.W;
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise.</param>
        public static void Lerp(in Vector4d a, in Vector4d b, double blend, out Vector4d result)
        {
            result.X = (blend * (b.X - a.X)) + a.X;
            result.Y = (blend * (b.Y - a.Y)) + a.Y;
            result.Z = (blend * (b.Z - a.Z)) + a.Z;
            result.W = (blend * (b.W - a.W)) + a.W;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</returns>
        [Pure]
        public static Vector4d Lerp(Vector4d a, Vector4d b, Vector4d blend)
        {
            a.X = (blend.X * (b.X - a.X)) + a.X;
            a.Y = (blend.Y * (b.Y - a.Y)) + a.Y;
            a.Z = (blend.Z * (b.Z - a.Z)) + a.Z;
            a.W = (blend.W * (b.W - a.W)) + a.W;
            return a;
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</param>
        public static void Lerp(in Vector4d a, in Vector4d b, Vector4d blend, out Vector4d result)
        {
            result.X = (blend.X * (b.X - a.X)) + a.X;
            result.Y = (blend.Y * (b.Y - a.Y)) + a.Y;
            result.Z = (blend.Z * (b.Z - a.Z)) + a.Z;
            result.W = (blend.W * (b.W - a.W)) + a.W;
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
        public static Vector4d Slerp(Vector4d a, Vector4d b, double t)
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
        public static void Slerp(in Vector4d a, in Vector4d b, double t, out Vector4d result)
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
        public static Vector4d Elerp(Vector4d a, Vector4d b, float t)
        {
            a.X = Math.Pow(a.X, 1 - t) * Math.Pow(b.X, t);
            a.Y = Math.Pow(a.Y, 1 - t) * Math.Pow(b.Y, t);
            a.Z = Math.Pow(a.Z, 1 - t) * Math.Pow(b.Z, t);
            a.W = Math.Pow(a.W, 1 - t) * Math.Pow(b.W, t);
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
        public static void Elerp(in Vector4d a, in Vector4d b, float t, out Vector4d result)
        {
            result.X = Math.Pow(a.X, 1 - t) * Math.Pow(b.X, t);
            result.Y = Math.Pow(a.Y, 1 - t) * Math.Pow(b.Y, t);
            result.Z = Math.Pow(a.Z, 1 - t) * Math.Pow(b.Z, t);
            result.W = Math.Pow(a.W, 1 - t) * Math.Pow(b.W, t);
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
        public static Vector4d BaryCentric(Vector4d a, Vector4d b, Vector4d c, double u, double v)
        {
            BaryCentric(in a, in b, in c, u, v, out Vector4d result);
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
            in Vector4d a,
            in Vector4d b,
            in Vector4d c,
            double u,
            double v,
            out Vector4d result
        )
        {
            Subtract(in b, in a, out Vector4d ab);
            Multiply(in ab, u, out Vector4d abU);
            Add(in a, in abU, out Vector4d uPos);

            Subtract(in c, in a, out Vector4d ac);
            Multiply(in ac, v, out Vector4d acV);
            Add(in uPos, in acV, out result);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d TransformRow(Vector4d vec, Matrix4d mat)
        {
            TransformRow(in vec, in mat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformRow(in Vector4d vec, in Matrix4d mat, out Vector4d result)
        {
            result = new Vector4d(
                (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X) + (vec.Z * mat.Row2.X) + (vec.W * mat.Row3.X),
                (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y) + (vec.Z * mat.Row2.Y) + (vec.W * mat.Row3.Y),
                (vec.X * mat.Row0.Z) + (vec.Y * mat.Row1.Z) + (vec.Z * mat.Row2.Z) + (vec.W * mat.Row3.Z),
                (vec.X * mat.Row0.W) + (vec.Y * mat.Row1.W) + (vec.Z * mat.Row2.W) + (vec.W * mat.Row3.W));
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4d Transform(Vector4d vec, Quaterniond quat)
        {
            Transform(in vec, in quat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Transform(in Vector4d vec, in Quaterniond quat, out Vector4d result)
        {
            Quaterniond v = new Quaterniond(vec.X, vec.Y, vec.Z, vec.W);
            Quaterniond.Invert(in quat, out Quaterniond i);
            Quaterniond.Multiply(in quat, in v, out Quaterniond t);
            Quaterniond.Multiply(in t, in i, out v);

            result.X = v.X;
            result.Y = v.Y;
            result.Z = v.Z;
            result.W = v.W;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d TransformColumn(Matrix4d mat, Vector4d vec)
        {
            TransformColumn(in mat, in vec, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformColumn(in Matrix4d mat, in Vector4d vec, out Vector4d result)
        {
            result = new Vector4d(
                (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y) + (mat.Row0.Z * vec.Z) + (mat.Row0.W * vec.W),
                (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y) + (mat.Row1.Z * vec.Z) + (mat.Row1.W * vec.W),
                (mat.Row2.X * vec.X) + (mat.Row2.Y * vec.Y) + (mat.Row2.Z * vec.Z) + (mat.Row2.W * vec.W),
                (mat.Row3.X * vec.X) + (mat.Row3.Y * vec.Y) + (mat.Row3.Z * vec.Z) + (mat.Row3.W * vec.W));
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2d TransformTwoDimensionsRow(Vector4d vec, Matrix4x2d mat)
        {
            TransformTwoDimensionsRow(in vec, in mat, out Vector2d result);
            return result;
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsRow(in Vector4d vec, in Matrix4x2d mat, out Vector2d result)
        {
            result = new Vector2d(
                (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X) + (vec.Z * mat.Row2.X) + (vec.W * mat.Row3.X),
                (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y) + (vec.Z * mat.Row2.Y) + (vec.W * mat.Row3.Y)
            );
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d TransformThreeDimensionsRow(Vector4d vec, Matrix4x3d mat)
        {
            TransformThreeDimensionsRow(in vec, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformThreeDimensionsRow(in Vector4d vec, in Matrix4x3d mat, out Vector3d result)
        {
            result = new Vector3d(
                (vec.X * mat.Row0.X) + (vec.Y * mat.Row1.X) + (vec.Z * mat.Row2.X) + (vec.W * mat.Row3.X),
                (vec.X * mat.Row0.Y) + (vec.Y * mat.Row1.Y) + (vec.Z * mat.Row2.Y) + (vec.W * mat.Row3.Y),
                (vec.X * mat.Row0.Z) + (vec.Y * mat.Row1.Z) + (vec.Z * mat.Row2.Z) + (vec.W * mat.Row3.Z)
            );
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2d TransformTwoDimensionsColumn(Matrix2x4d mat, Vector4d vec)
        {
            TransformTwoDimensionsColumn(in mat, in vec, out Vector2d result);
            return result;
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsColumn(in Matrix2x4d mat, in Vector4d vec, out Vector2d result)
        {
            result = new Vector2d(
                (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y) + (mat.Row0.Z * vec.Z) + (mat.Row0.W * vec.W),
                (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y) + (mat.Row1.Z * vec.Z) + (mat.Row1.W * vec.W)
            );
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3d TransformThreeDimensionsColumn(Matrix3x4d mat, Vector4d vec)
        {
            TransformThreeDimensionsColumn(in mat, in vec, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformThreeDimensionsColumn(in Matrix3x4d mat, in Vector4d vec, out Vector3d result)
        {
            result = new Vector3d(
                (mat.Row0.X * vec.X) + (mat.Row0.Y * vec.Y) + (mat.Row0.Z * vec.Z) + (mat.Row0.W * vec.W),
                (mat.Row1.X * vec.X) + (mat.Row1.Y * vec.Y) + (mat.Row1.Z * vec.Z) + (mat.Row1.W * vec.W),
                (mat.Row2.X * vec.X) + (mat.Row2.Y * vec.Y) + (mat.Row2.Z * vec.Z) + (mat.Row2.W * vec.W)
            );
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
        /// Gets or sets an OpenTK.Vector2d with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xw
        {
            readonly get => new Vector2d(X, W);
            set
            {
                X = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2d with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yw
        {
            readonly get => new Vector2d(Y, W);
            set
            {
                Y = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2d with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zw
        {
            readonly get => new Vector2d(Z, W);
            set
            {
                Z = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wx
        {
            readonly get => new Vector2d(W, X);
            set
            {
                W = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wy
        {
            readonly get => new Vector2d(W, Y);
            set
            {
                W = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wz
        {
            readonly get => new Vector2d(W, Z);
            set
            {
                W = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyz
        {
            readonly get => new Vector3d(X, Y, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyw
        {
            readonly get => new Vector3d(X, Y, W);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3d with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzw
        {
            readonly get => new Vector3d(X, Z, W);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwy
        {
            readonly get => new Vector3d(X, W, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwz
        {
            readonly get => new Vector3d(X, W, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3d with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxw
        {
            readonly get => new Vector3d(Y, X, W);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3d with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzw
        {
            readonly get => new Vector3d(Y, Z, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywx
        {
            readonly get => new Vector3d(Y, W, X);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywz
        {
            readonly get => new Vector3d(Y, W, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3d with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxw
        {
            readonly get => new Vector3d(Z, X, W);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3d with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyw
        {
            readonly get => new Vector3d(Z, Y, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwx
        {
            readonly get => new Vector3d(Z, W, X);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwy
        {
            readonly get => new Vector3d(Z, W, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxy
        {
            readonly get => new Vector3d(W, X, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxz
        {
            readonly get => new Vector3d(W, X, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyx
        {
            readonly get => new Vector3d(W, Y, X);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyz
        {
            readonly get => new Vector3d(W, Y, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzx
        {
            readonly get => new Vector3d(W, Z, X);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzy
        {
            readonly get => new Vector3d(W, Z, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xywz
        {
            readonly get => new Vector4d(X, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzyw
        {
            readonly get => new Vector4d(X, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzwy
        {
            readonly get => new Vector4d(X, Z, W, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwyz
        {
            readonly get => new Vector4d(X, W, Y, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwzy
        {
            readonly get => new Vector4d(X, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxzw
        {
            readonly get => new Vector4d(Y, X, Z, W);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxwz
        {
            readonly get => new Vector4d(Y, X, W, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyzw
        {
            readonly get => new Vector4d(Y, Y, Z, W);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yywz
        {
            readonly get => new Vector4d(Y, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzxw
        {
            readonly get => new Vector4d(Y, Z, X, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzwx
        {
            readonly get => new Vector4d(Y, Z, W, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywxz
        {
            readonly get => new Vector4d(Y, W, X, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywzx
        {
            readonly get => new Vector4d(Y, W, Z, X);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxyw
        {
            readonly get => new Vector4d(Z, X, Y, W);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxwy
        {
            readonly get => new Vector4d(Z, X, W, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyxw
        {
            readonly get => new Vector4d(Z, Y, X, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zywx
        {
            readonly get => new Vector4d(Z, Y, W, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwxy
        {
            readonly get => new Vector4d(Z, W, X, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwyx
        {
            readonly get => new Vector4d(Z, W, Y, X);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwzy
        {
            readonly get => new Vector4d(Z, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxyz
        {
            readonly get => new Vector4d(W, X, Y, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxzy
        {
            readonly get => new Vector4d(W, X, Z, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyxz
        {
            readonly get => new Vector4d(W, Y, X, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyzx
        {
            readonly get => new Vector4d(W, Y, Z, X);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzxy
        {
            readonly get => new Vector4d(W, Z, X, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyx
        {
            readonly get => new Vector4d(W, Z, Y, X);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyw
        {
            readonly get => new Vector4d(W, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4d operator +(Vector4d left, double right)
        {
            left.X += right;
            left.Y += right;
            left.Z += right;
            left.W += right;
            return left;
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4d operator +(double left, Vector4d right)
        {
            right.X += left;
            right.Y += left;
            right.Z += left;
            right.W += left;
            return right;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4d operator +(Vector4d left, Vector4d right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            left.W += right.W;
            return left;
        }

        /// <summary>
        /// Subtracts an instance by a scalar.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4d operator -(Vector4d left, double right)
        {
            left.X -= right;
            left.Y -= right;
            left.Z -= right;
            left.W -= right;
            return left;
        }

        /// <summary>
        /// Subtracts a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4d operator -(double left, Vector4d right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
            right.Z = left - right.Z;
            right.W = left - right.W;
            return right;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4d operator -(Vector4d left, Vector4d right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            left.W -= right.W;
            return left;
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4d operator -(Vector4d vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            vec.W = -vec.W;
            return vec;
        }

        /// <summary>
        /// Computes the unary plus of the vector.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4d operator +(Vector4d vec)
        {
            vec.X = +vec.X;
            vec.Y = +vec.Y;
            vec.Z = +vec.Z;
            vec.W = +vec.W;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4d operator *(Vector4d vec, double scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4d operator *(double scale, Vector4d vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Component-wise multiplication between the specified instance by a scale vector.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector4d operator *(Vector4d vec, Vector4d scale)
        {
            vec.X *= scale.X;
            vec.Y *= scale.Y;
            vec.Z *= scale.Z;
            vec.W *= scale.W;
            return vec;
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector2d operator *(Vector4d vec, Matrix4x2d mat)
        {
            TransformTwoDimensionsRow(in vec, in mat, out Vector2d result);
            return result;
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        public static Vector3d operator *(Vector4d vec, Matrix4x3d mat)
        {
            TransformThreeDimensionsRow(in vec, in mat, out Vector3d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d operator *(Vector4d vec, Matrix4d mat)
        {
            TransformRow(in vec, in mat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4d operator /(Vector4d vec, double scale)
        {
            vec.X /= scale;
            vec.Y /= scale;
            vec.Z /= scale;
            vec.W /= scale;
            return vec;
        }

        /// <summary>
        /// Divides a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4d operator /(double left, Vector4d right)
        {
            right.X = left / right.X;
            right.Y = left / right.Y;
            right.Z = left / right.Z;
            right.W = left / right.W;
            return right;
        }

        /// <summary>
        /// Component-wise division between the specified instance by a scale vector.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4d operator /(Vector4d vec, Vector4d scale)
        {
            vec.X /= scale.X;
            vec.Y /= scale.Y;
            vec.Z /= scale.Z;
            vec.W /= scale.W;
            return vec;
        }

        /// <summary>
        /// Component wise less than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        [Pure]
        public static Vector4b operator <(Vector4d left, Vector4d right)
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
        public static Vector4b operator <=(Vector4d left, Vector4d right)
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
        public static Vector4b operator >(Vector4d left, Vector4d right)
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
        public static Vector4b operator >=(Vector4d left, Vector4d right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector4d left, Vector4d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector4d left, Vector4d right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector4d to OpenTK.Vector4.
        /// </summary>
        /// <param name="vec">The Vector4d to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        [Pure]
        public static explicit operator Vector4(Vector4d vec)
        {
            return new Vector4((float)vec.X, (float)vec.Y, (float)vec.Z, (float)vec.W);
        }

        /// <summary>
        /// Converts OpenTK.Vector4d to OpenTK.Vector4h.
        /// </summary>
        /// <param name="vec">The Vector4d to convert.</param>
        /// <returns>The resulting Vector4h.</returns>
        [Pure]
        public static explicit operator Vector4h(Vector4d vec)
        {
            return new Vector4h((Half)vec.X, (Half)vec.Y, (Half)vec.Z, (Half)vec.W);
        }

        /// <summary>
        /// Converts OpenTK.Vector4d to OpenTK.Vector4i.
        /// </summary>
        /// <param name="vec">The Vector4d to convert.</param>
        /// <returns>The resulting Vector4i.</returns>
        [Pure]
        public static explicit operator Vector4i(Vector4d vec)
        {
            return new Vector4i((int)vec.X, (int)vec.Y, (int)vec.Z, (int)vec.W);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector4d"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector4d((double X, double Y, double Z, double W) values)
        {
            return new Vector4d(values.X, values.Y, values.Z, values.W);
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
                "({0}{4} {1}{4} {2}{4} {3})",
                X.ToString(format, formatProvider),
                Y.ToString(format, formatProvider),
                Z.ToString(format, formatProvider),
                W.ToString(format, formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <inheritdoc />
        public override readonly bool Equals(object obj)
        {
            return obj is Vector4d && Equals((Vector4d)obj);
        }

        /// <inheritdoc />
        public readonly bool Equals(Vector4d other)
        {
            Vector256<double> thisVec = Vector256.LoadUnsafe(in X);
            Vector256<double> otherVec = Vector256.LoadUnsafe(in other.X);

            return thisVec == otherVec;
        }

        /// <inheritdoc />
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z, W);
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        /// <param name="z">The Z component of the vector.</param>
        /// <param name="w">The W component of the vector.</param>
        [Pure]
        public readonly void Deconstruct(out double x, out double y, out double z, out double w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
    }
}
