/*
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
    /// Represents a 3D vector using three single-precision floating-point numbers.
    /// </summary>
    /// <remarks>
    /// The Vector3 structure is suitable for interoperation with unmanaged code requiring three consecutive floats.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3 : IEquatable<Vector3>, IFormattable,
                            IAdditionOperators<Vector3, Vector3, Vector3>,
                            ISubtractionOperators<Vector3, Vector3, Vector3>,
                            IUnaryNegationOperators<Vector3, Vector3>,
                            IUnaryPlusOperators<Vector3, Vector3>,
                            IMultiplyOperators<Vector3, float, Vector3>,
                            IMultiplyOperators<Vector3, Vector3, Vector3>,
                            IMultiplyOperators<Vector3, Matrix3x2, Vector2>,
                            IMultiplyOperators<Vector3, Matrix3, Vector3>,
                            IMultiplyOperators<Vector3, Matrix3x4, Vector4>,
                            IDivisionOperators<Vector3, float, Vector3>,
                            IDivisionOperators<Vector3, Vector3, Vector3>,
                            IEqualityOperators<Vector3, Vector3, bool>,
                            IAdditiveIdentity<Vector3, Vector3>,
                            IMultiplicativeIdentity<Vector3, Vector3>,
                            IMinMaxValue<Vector3>
    {
        /// <summary>
        /// The X component of the Vector3.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector3.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the Vector3.
        /// </summary>
        public float Z;

        /// <summary>
        /// Defines a unit-length Vector3 that points towards the X-axis.
        /// </summary>
        public static readonly Vector3 UnitX = new Vector3(1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector3 that points towards the Y-axis.
        /// </summary>
        public static readonly Vector3 UnitY = new Vector3(0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector3 that points towards the Z-axis.
        /// </summary>
        public static readonly Vector3 UnitZ = new Vector3(0, 0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector3 Zero = new Vector3(0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector3 One = new Vector3(1, 1, 1);

        /// <summary>
        /// Defines an instance with all components set to positive infinity.
        /// </summary>
        public static readonly Vector3 PositiveInfinity = new Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        /// <summary>
        /// Defines an instance with all components set to negative infinity.
        /// </summary>
        public static readonly Vector3 NegativeInfinity = new Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);

        /// <summary>
        /// Defines the size of the Vector3 struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf<Vector3>();

        /// <summary>
        /// Gets the additive identity of Vector3. Equivalent to Vector3.Zero.
        /// </summary>
        public static Vector3 AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector3. Equivalent to Vector3.One.
        /// </summary>
        public static Vector3 MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the max value for Vector3. Equivalent to Vector3.PositiveInfinity.
        /// </summary>
        public static Vector3 MaxValue => PositiveInfinity;

        /// <summary>
        /// Gets the min value for Vector3. Equivalent to Vector3.NegativeInfinity.
        /// </summary>
        public static Vector3 MinValue => NegativeInfinity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3(float value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector3.</param>
        /// <param name="y">The y component of the Vector3.</param>
        /// <param name="z">The z component of the Vector3.</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector3.</param>
        /// <param name="z">The z component of the Vector3.</param>
        public Vector3(Vector2 xy, float z = default)
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
        public float this[int index]
        {
            readonly get
            {
                if (((uint)index) >= 3)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this vector at index: {0}", index);
                }

                return GetElementUnsafe(in this, index);
            }

            set
            {
                if (((uint)index) >= 3)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this vector at index: {0}", index);
                }

                GetElementUnsafe(in this, index) = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref float GetElementUnsafe(in Vector3 v, int index)
        {
            ref float address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public readonly float Length => MathF.Sqrt(LengthSquared);

        /// <summary>
        /// Gets an approximation of 1 over the length (magnitude) of the vector.
        /// </summary>
        public readonly float ReciprocalLengthFast => MathF.ReciprocalSqrtEstimate(LengthSquared);

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public readonly float LengthFast => 1.0f / MathF.ReciprocalSqrtEstimate(LengthSquared);

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthFast"/>
        public readonly float LengthSquared => Dot(this, this);

        /// <summary>
        /// Returns a copy of the Vector3 scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public readonly Vector3 Normalized()
        {
            return Normalize(this);
        }

        /// <summary>
        /// Scales the Vector3 to unit length.
        /// </summary>
        public void Normalize()
        {
            this = Normalize(this);
        }

        /// <summary>
        /// Scales the Vector3 to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            this = NormalizeFast(this);
        }

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector3 Abs()
        {
            return Abs(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied.
        /// Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <returns>The rounded vector.</returns>
        public readonly Vector3 Round()
        {
            return Round(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied with the specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The rounded vector.</returns>
        public readonly Vector3 Round(MidpointRounding rounding)
        {
            return Round(this, rounding);
        }

        /// <summary>
        /// Returns a new vector were a component-wise ceiling operation has been applied.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <returns>The ceiled vector.</returns>
        public readonly Vector3 Ceiling()
        {
            return Ceiling(this);
        }

        /// <summary>
        /// Returns a new vector were a component-wise floor operation has been applied.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <returns>The floored vector.</returns>
        public readonly Vector3 Floor()
        {
            return Floor(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise truncation has been applied.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <returns>The truncated vector.</returns>
        public readonly Vector3 Truncate()
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
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return (a.AsVector128Unsafe() + b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <param name="result">Result of operation.</param>
        public static void Add(in Vector3 a, in Vector3 b, out Vector3 result)
        {
            result = (a.AsVector128Unsafe() + b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return (a.AsVector128Unsafe() - b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">Result of subtraction.</param>
        public static void Subtract(in Vector3 a, in Vector3 b, out Vector3 result)
        {
            result = (a.AsVector128Unsafe() - b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3 Multiply(Vector3 vector, float scale)
        {
            return (vector.AsVector128Unsafe() * Vector128.Create(scale)).AsVector3Otk();
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector3 vector, float scale, out Vector3 result)
        {
            result = (vector.AsVector128Unsafe() * Vector128.Create(scale)).AsVector3Otk();
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3 Multiply(Vector3 vector, Vector3 scale)
        {
            return (vector.AsVector128Unsafe() * scale.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Multiplies a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector3 vector, in Vector3 scale, out Vector3 result)
        {
            result = (vector.AsVector128Unsafe() * scale.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3 Divide(Vector3 vector, float scale)
        {
            return (vector.AsVector128Unsafe() / Vector128.Create(scale)).AsVector3Otk();
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector3 vector, float scale, out Vector3 result)
        {
            result = (vector.AsVector128Unsafe() / Vector128.Create(scale)).AsVector3Otk();
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3 Divide(Vector3 vector, Vector3 scale)
        {
            return (vector.AsVector128Unsafe() / scale.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Divide a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector3 vector, in Vector3 scale, out Vector3 result)
        {
            result = (vector.AsVector128Unsafe() / scale.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector3 ComponentMin(Vector3 a, Vector3 b)
        {
            return Vector128.Min(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMin(Vector3, Vector3)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector3 ComponentMinNative(Vector3 a, Vector3 b)
        {
            return Vector128.MinNative(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector3 a, in Vector3 b, out Vector3 result)
        {
            result = Vector128.Min(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMin(in Vector3, in Vector3, out Vector3)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMinNative(in Vector3 a, in Vector3 b, out Vector3 result)
        {
            result = Vector128.MinNative(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector3 ComponentMax(Vector3 a, Vector3 b)
        {
            return Vector128.Max(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMax(Vector3, Vector3)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector3 ComponentMaxNative(Vector3 a, Vector3 b)
        {
            return Vector128.MaxNative(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector3 a, in Vector3 b, out Vector3 result)
        {
            result = Vector128.Max(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMax(in Vector3, in Vector3, out Vector3)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMaxNative(in Vector3 a, in Vector3 b, out Vector3 result)
        {
            result = Vector128.MaxNative(a.AsVector128Unsafe(), b.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns the Vector3 with the minimum magnitude. If the magnitudes are equal, the second vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector3.</returns>
        [Pure]
        public static Vector3 MagnitudeMin(Vector3 left, Vector3 right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3 with the minimum magnitude. If the magnitudes are equal, the second vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise minimum.</param>
        public static void MagnitudeMin(in Vector3 left, in Vector3 right, out Vector3 result)
        {
            result = left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3 with the maximum magnitude. If the magnitudes are equal, the first vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The maximum Vector3.</returns>
        [Pure]
        public static Vector3 MagnitudeMax(Vector3 left, Vector3 right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3 with the maximum magnitude. If the magnitudes are equal, the first vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise maximum.</param>
        public static void MagnitudeMax(in Vector3 left, in Vector3 right, out Vector3 result)
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
        public static Vector3 Clamp(Vector3 vec, Vector3 min, Vector3 max)
        {
            return Vector128.Clamp(vec.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="Clamp(Vector3, Vector3, Vector3)"/>.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <returns>The clamped vector.</returns>
        [Pure]
        public static Vector3 ClampNative(Vector3 vec, Vector3 min, Vector3 max)
        {
            return Vector128.ClampNative(vec.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector3 vec, in Vector3 min, in Vector3 max, out Vector3 result)
        {
            result = Vector128.Clamp(vec.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="Clamp(in Vector3, in Vector3, in Vector3, out Vector3)"/>.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void ClampNative(in Vector3 vec, in Vector3 min, in Vector3 max, out Vector3 result)
        {
            result = Vector128.ClampNative(vec.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        [Pure]
        public static Vector3 Abs(Vector3 vec)
        {
            return Vector128.Abs(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Abs(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector3 Round(Vector3 vec)
        {
            return Vector128.Round(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Round(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector3 Round(Vector3 vec, MidpointRounding rounding)
        {
            return Vector128.Round(vec.AsVector128Unsafe(), rounding).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector3 vec, MidpointRounding rounding, out Vector3 result)
        {
            result = Vector128.Round(vec.AsVector128Unsafe(), rounding).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <returns>The component-wise ceiling vector.</returns>
        [Pure]
        public static Vector3 Ceiling(Vector3 vec)
        {
            return Vector128.Ceiling(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <param name="result">The component-wise ceiling vector.</param>
        public static void Ceiling(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Ceiling(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <returns>The component-wise floored vector.</returns>
        [Pure]
        public static Vector3 Floor(Vector3 vec)
        {
            return Vector128.Floor(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <param name="result">The component-wise floored vector.</param>
        public static void Floor(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Floor(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <returns>The component-wise truncated vector.</returns>
        [Pure]
        public static Vector3 Truncate(Vector3 vec)
        {
            return Vector128.Truncate(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <param name="result">The component-wise truncated vector.</param>
        public static void Truncate(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Truncate(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The distance.</returns>
        [Pure]
        public static float Distance(Vector3 vec1, Vector3 vec2)
        {
            return (vec1 - vec2).Length;
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The distance.</param>
        public static void Distance(in Vector3 vec1, in Vector3 vec2, out float result)
        {
            result = (vec1 - vec2).Length;
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The squared distance.</returns>
        [Pure]
        public static float DistanceSquared(Vector3 vec1, Vector3 vec2)
        {
            return (vec1 - vec2).LengthSquared;
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The squared distance.</param>
        public static void DistanceSquared(in Vector3 vec1, in Vector3 vec2, out float result)
        {
            result = (vec1 - vec2).LengthSquared;
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector3 Normalize(Vector3 vec)
        {
            return (vec.AsVector128Unsafe() / vec.Length).AsVector3Otk();
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void Normalize(in Vector3 vec, out Vector3 result)
        {
            result = (vec.AsVector128Unsafe() / vec.Length).AsVector3Otk();
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector3 NormalizeFast(Vector3 vec)
        {
            return (vec.AsVector128Unsafe() * vec.ReciprocalLengthFast).AsVector3Otk();
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void NormalizeFast(in Vector3 vec, out Vector3 result)
        {
            result = (vec.AsVector128Unsafe() * vec.ReciprocalLengthFast).AsVector3Otk();
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        [Pure]
        public static float Dot(Vector3 left, Vector3 right)
        {
            return Vector128.Dot(left.AsVector128(), right.AsVector128());
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The dot product of the two inputs.</param>
        public static void Dot(in Vector3 left, in Vector3 right, out float result)
        {
            result = Vector128.Dot(left.AsVector128(), right.AsVector128());
        }

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The cross product of the two inputs.</returns>
        [Pure]
        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            var vleft = left.AsVector128Unsafe();
            var vright = right.AsVector128Unsafe();

            var temp1 = Vector128.Shuffle(vleft, Vector128.Create(1, 2, 0, 0)) * Vector128.Shuffle(vright, Vector128.Create(2, 0, 1, 0));
            var temp2 = Vector128.Shuffle(vleft, Vector128.Create(2, 0, 1, 0)) * Vector128.Shuffle(vright, Vector128.Create(1, 2, 0, 0));

            return (temp1 - temp2).AsVector3Otk();
        }

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The cross product of the two inputs.</param>
        public static void Cross(in Vector3 left, in Vector3 right, out Vector3 result)
        {
            var vleft = left.AsVector128Unsafe();
            var vright = right.AsVector128Unsafe();

            var temp1 = Vector128.Shuffle(vleft, Vector128.Create(1, 2, 0, 0)) * Vector128.Shuffle(vright, Vector128.Create(2, 0, 1, 0));
            var temp2 = Vector128.Shuffle(vleft, Vector128.Create(2, 0, 1, 0)) * Vector128.Shuffle(vright, Vector128.Create(1, 2, 0, 0));

            result = (temp1 - temp2).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise exponential.
        /// </summary>
        /// <param name="vec">The vector to calculate the exponential of.</param>
        /// <returns>The component-wise exponental.</returns>
        public static Vector3 Exp(Vector3 vec)
        {
            return Vector128.Exp(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise exponential.
        /// </summary>
        /// <param name="vec">The vector to calculate the exponential of.</param>
        /// <param name="result">The component-wise exponental.</param>
        public static void Exp(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Exp(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise natural logarithm.
        /// </summary>
        /// <param name="vec">The vector to calculate the natural logarithm of.</param>
        /// <returns>The component-wise natural logarithm.</returns>
        public static Vector3 Log(Vector3 vec)
        {
            return Vector128.Log(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise natural logarithm.
        /// </summary>
        /// <param name="vec">The vector to calculate the natural logarithm of.</param>
        /// <param name="result">The component-wise natural logarithm.</param>
        public static void Log(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Log(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise base-2 logarithm.
        /// </summary>
        /// <param name="vec">The vector to calculate the base-2 logarithm of.</param>
        /// <returns>The component-wise base-2 logarithm.</returns>
        public static Vector3 Log2(Vector3 vec)
        {
            return Vector128.Log2(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise base-2 logarithm.
        /// </summary>
        /// <param name="vec">The vector to calculate the base-2 logarithm of.</param>
        /// <param name="result">The component-wise base-2 logarithm.</param>
        public static void Log2(in Vector3 vec, out Vector3 result)
        {
            result = Vector128.Log2(vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <returns>Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</returns>
        public static Vector3 Pow(Vector3 x, Vector3 y)
        {
            // FIXME: Proper SIMD implementation?
            return new Vector3(
                MathF.Pow(x.X, y.X),
                MathF.Pow(x.Y, y.Y),
                MathF.Pow(x.Z, y.Z));
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <param name="result">Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</param>
        public static void Pow(in Vector3 x, in Vector3 y, out Vector3 result)
        {
            // FIXME: Proper SIMD implementation?
            result.X = MathF.Pow(x.X, y.X);
            result.Y = MathF.Pow(x.Y, y.Y);
            result.Z = MathF.Pow(x.Z, y.Z);
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <returns>Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</returns>
        public static Vector3 Pow(Vector3 x, float y)
        {
            // FIXME: Proper SIMD implementation?
            return new Vector3(
                MathF.Pow(x.X, y),
                MathF.Pow(x.Y, y),
                MathF.Pow(x.Z, y));
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <param name="result">Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</param>
        public static void Pow(in Vector3 x, in float y, out Vector3 result)
        {
            // FIXME: Proper SIMD implementation?
            result.X = MathF.Pow(x.X, y);
            result.Y = MathF.Pow(x.Y, y);
            result.Z = MathF.Pow(x.Z, y);
        }

        /// <summary>
        /// Computes <c>x * y + z</c>, as a fused multiply add, only rounding once.
        /// </summary>
        /// <param name="x">The left multiplicand.</param>
        /// <param name="y">The right multiplicand.</param>
        /// <param name="z">The addend.</param>
        /// <returns>Returns <c>x * y + z</c>.</returns>
        public static Vector3 Fma(Vector3 x, Vector3 y, Vector3 z)
        {
            return Vector128.FusedMultiplyAdd(x.AsVector128Unsafe(), y.AsVector128Unsafe(), z.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes <c>x * y + z</c>, as a fused multiply add, only rounding once.
        /// </summary>
        /// <param name="x">The left multiplicand.</param>
        /// <param name="y">The right multiplicand.</param>
        /// <param name="z">The addend.</param>
        /// <param name="result"><c>x * y + z</c>.</param>
        public static void Fma(in Vector3 x, in Vector3 y, in Vector3 z, out Vector3 result)
        {
            result = Vector128.FusedMultiplyAdd(x.AsVector128Unsafe(), y.AsVector128Unsafe(), z.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector3b LessThan(in Vector3 left, in Vector3 right)
        {
            return new Vector3b(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector3b LessThanOrEqual(in Vector3 left, in Vector3 right)
        {
            return new Vector3b(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector3b GreaterThan(in Vector3 left, in Vector3 right)
        {
            return new Vector3b(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector3b GreaterThanOrEqual(in Vector3 left, in Vector3 right)
        {
            return new Vector3b(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector3b ComponentEqual(in Vector3 left, in Vector3 right)
        {
            return new Vector3b(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector3b ComponentNotEqual(in Vector3 left, in Vector3 right)
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
        public static Vector3 Lerp(Vector3 a, Vector3 b, float blend)
        {
            return Vector128.Lerp(a.AsVector128Unsafe(), b.AsVector128Unsafe(), Vector128.Create(blend)).AsVector3Otk();
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise.</param>
        public static void Lerp(in Vector3 a, in Vector3 b, float blend, out Vector3 result)
        {
            result = Vector128.Lerp(a.AsVector128Unsafe(), b.AsVector128Unsafe(), Vector128.Create(blend)).AsVector3Otk();
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</returns>
        [Pure]
        public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 blend)
        {
            return Vector128.Lerp(a.AsVector128Unsafe(), b.AsVector128Unsafe(), blend.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</param>
        public static void Lerp(in Vector3 a, in Vector3 b, Vector3 blend, out Vector3 result)
        {
            result = Vector128.Lerp(a.AsVector128Unsafe(), b.AsVector128Unsafe(), blend.AsVector128Unsafe()).AsVector3Otk();
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
        public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
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
        /// Results are undefined for vectors that point in opposite directions or very close to opposite directions.
        /// </summary>
        /// <param name="a">Unit vector start point.</param>
        /// <param name="b">Unit vector end point.</param>
        /// <param name="t">The blend factor.</param>
        /// <param name="result">Is <paramref name="a"/> when <paramref name="t"/>=0, <paramref name="b"/> when <paramref name="t"/>=1, and a spherical interpolation between the vectors otherwise.</param>
        public static void Slerp(in Vector3 a, in Vector3 b, float t, out Vector3 result)
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
        [Pure]
        public static Vector3 Elerp(Vector3 a, Vector3 b, float t)
        {
            return Pow(a, 1 - t) * Pow(b, t);
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
        public static void Elerp(in Vector3 a, in Vector3 b, float t, out Vector3 result)
        {
            result = Pow(a, 1 - t) * Pow(b, t);
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
        public static Vector3 BaryCentric(Vector3 a, Vector3 b, Vector3 c, float u, float v)
        {
            // The JIT doesn't deal with intermediate results casting back to Vector3 from Vector128
            // so to avoid a ton of copies we just bitcast to S.N. types that the JIT has special
            // knowledge about and is able to never cast back to Vector3 from SIMD registers
            // during the calculations and only do this conversion at the very end.
            // - Noggin_bops 2025-12-31
            System.Numerics.Vector3 sna = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(a);
            System.Numerics.Vector3 snb = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(b);
            System.Numerics.Vector3 snc = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(c);
            return Unsafe.BitCast<System.Numerics.Vector3, Vector3>(
                System.Numerics.Vector3.FusedMultiplyAdd(snc - sna, new(v), System.Numerics.Vector3.FusedMultiplyAdd(snb - sna, new(u), sna)));
        }

        /// <summary>
        /// Interpolate 3 Vectors using Barycentric coordinates.
        /// </summary>
        /// <param name="a">First input Vector.</param>
        /// <param name="b">Second input Vector.</param>
        /// <param name="c">Third input Vector.</param>
        /// <param name="u">First Barycentric Coordinate.</param>
        /// <param name="v">Second Barycentric Coordinate.</param>
        /// <param name="result">Output Vector. a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise.</param>
        [Pure]
        public static void BaryCentric(in Vector3 a, in Vector3 b, in Vector3 c, float u, float v, out Vector3 result)
        {
            // The JIT doesn't deal with intermediate results casting back to Vector3 from Vector128
            // so to avoid a ton of copies we just bitcast to S.N. types that the JIT has special
            // knowledge about and is able to never cast back to Vector3 from SIMD registers
            // during the calculations and only do this conversion at the very end.
            // - Noggin_bops 2025-12-31
            System.Numerics.Vector3 sna = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(a);
            System.Numerics.Vector3 snb = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(b);
            System.Numerics.Vector3 snc = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(c);
            result = Unsafe.BitCast<System.Numerics.Vector3, Vector3>(
                System.Numerics.Vector3.FusedMultiplyAdd(snc - sna, new(v), System.Numerics.Vector3.FusedMultiplyAdd(snb - sna, new(u), sna)));
        }

        /// <summary>
        /// Transform a direction vector by the given Matrix.
        /// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 TransformVector(Vector3 vec, Matrix4 mat)
        {
            return ((vec.AsVector128Unsafe() * mat.Row0.AsVector128()) +
                     (vec.AsVector128Unsafe() * mat.Row1.AsVector128()) +
                     (vec.AsVector128Unsafe() * mat.Row2.AsVector128())).AsVector3Otk();
        }

        /// <summary>
        /// Transform a direction vector by the given Matrix.
        /// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformVector(in Vector3 vec, in Matrix4 mat, out Vector3 result)
        {
            result = ((vec.AsVector128Unsafe() * mat.Row0.AsVector128()) +
                     (vec.AsVector128Unsafe() * mat.Row1.AsVector128()) +
                     (vec.AsVector128Unsafe() * mat.Row2.AsVector128())).AsVector3Otk();
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
        public static Vector3 TransformNormal(Vector3 norm, Matrix4 mat)
        {
            Matrix4 inverse = Matrix4.Invert(mat);
            return TransformNormalInverse(norm, inverse);
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
        public static void TransformNormal(in Vector3 norm, in Matrix4 mat, out Vector3 result)
        {
            Matrix4 inverse = Matrix4.Invert(mat);
            result = TransformNormalInverse(norm, inverse);
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
        public static Vector3 TransformNormalInverse(Vector3 norm, Matrix4 invMat)
        {
            // This seems to be the easiest way to convince the JIT to produce
            // any kind of reasonable code for this as it does tons of needless
            // copying of data to the stack and back...
            // - Noggin_bops 2025-12-31
            System.Numerics.Vector3 snNorm = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(norm);
            System.Numerics.Matrix4x4 snInvMat = Unsafe.BitCast<Matrix4, System.Numerics.Matrix4x4>(invMat);
            return new System.Numerics.Vector3(
                System.Numerics.Vector3.Dot(snNorm, snInvMat.GetRow(0).AsVector3()),
                System.Numerics.Vector3.Dot(snNorm, snInvMat.GetRow(1).AsVector3()),
                System.Numerics.Vector3.Dot(snNorm, snInvMat.GetRow(2).AsVector3())).AsVector128Unsafe().AsVector3Otk();
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
        public static void TransformNormalInverse(in Vector3 norm, in Matrix4 invMat, out Vector3 result)
        {
            // This seems to be the easiest way to convince the JIT to produce
            // any kind of reasonable code for this as it does tons of needless
            // copying of data to the stack and back...
            // - Noggin_bops 2025-12-31
            System.Numerics.Vector3 snNorm = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(norm);
            System.Numerics.Matrix4x4 snInvMat = Unsafe.BitCast<Matrix4, System.Numerics.Matrix4x4>(invMat);
            result = new System.Numerics.Vector3(
                System.Numerics.Vector3.Dot(snNorm, snInvMat.GetRow(0).AsVector3()),
                System.Numerics.Vector3.Dot(snNorm, snInvMat.GetRow(1).AsVector3()),
                System.Numerics.Vector3.Dot(snNorm, snInvMat.GetRow(2).AsVector3())).AsVector128Unsafe().AsVector3Otk();
        }

        /// <summary>
        /// Transform a Position by the given Matrix.
        /// </summary>
        /// <param name="pos">The position to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed position.</returns>
        [Pure]
        public static Vector3 TransformPosition(Vector3 pos, Matrix4 mat)
        {
            return ((Vector128.Create(pos.X) * mat.Row0.AsVector128()) +
                    (Vector128.Create(pos.Y) * mat.Row1.AsVector128()) +
                    (Vector128.Create(pos.Z) * mat.Row2.AsVector128()) +
                    mat.Row3.AsVector128()).AsVector3Otk();
        }

        /// <summary>
        /// Transform a Position by the given Matrix.
        /// </summary>
        /// <param name="pos">The position to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed position.</param>
        public static void TransformPosition(in Vector3 pos, in Matrix4 mat, out Vector3 result)
        {
            result = ((Vector128.Create(pos.X) * mat.Row0.AsVector128()) +
                      (Vector128.Create(pos.Y) * mat.Row1.AsVector128()) +
                      (Vector128.Create(pos.Z) * mat.Row2.AsVector128()) +
                      mat.Row3.AsVector128()).AsVector3Otk();
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 TransformRow(Vector3 vec, Matrix3 mat)
        {
            return ((vec.AsVector128Unsafe() * mat.Row0.AsVector128Unsafe()) +
                    (vec.AsVector128Unsafe() * mat.Row1.AsVector128Unsafe()) +
                    (vec.AsVector128Unsafe() * mat.Row2.AsVector128Unsafe())).AsVector3Otk();
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformRow(in Vector3 vec, in Matrix3 mat, out Vector3 result)
        {
            result = ((vec.AsVector128Unsafe() * mat.Row0.AsVector128Unsafe()) +
                      (vec.AsVector128Unsafe() * mat.Row1.AsVector128Unsafe()) +
                      (vec.AsVector128Unsafe() * mat.Row2.AsVector128Unsafe())).AsVector3Otk();
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 TransformColumn(Matrix3 mat, Vector3 vec)
        {
            // This seems to be the easiest way to convince the JIT to produce
            // any kind of reasonable code for this as it does tons of needless
            // copying of data to the stack and back...
            // - Noggin_bops 2025-12-31
            System.Numerics.Vector3 snRow0 = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(mat.Row0);
            System.Numerics.Vector3 snRow1 = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(mat.Row1);
            System.Numerics.Vector3 snRow2 = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(mat.Row2);

            System.Numerics.Vector3 snVec = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(vec);

            return new Vector3(
                System.Numerics.Vector3.Dot(snRow0, snVec),
                System.Numerics.Vector3.Dot(snRow1, snVec),
                System.Numerics.Vector3.Dot(snRow2, snVec));
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformColumn(in Matrix3 mat, in Vector3 vec, out Vector3 result)
        {
            // This seems to be the easiest way to convince the JIT to produce
            // any kind of reasonable code for this as it does tons of needless
            // copying of data to the stack and back...
            // - Noggin_bops 2025-12-31
            System.Numerics.Vector3 snRow0 = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(mat.Row0);
            System.Numerics.Vector3 snRow1 = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(mat.Row1);
            System.Numerics.Vector3 snRow2 = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(mat.Row2);

            System.Numerics.Vector3 snVec = Unsafe.BitCast<Vector3, System.Numerics.Vector3>(vec);

            result = new Vector3(
                System.Numerics.Vector3.Dot(snRow0, snVec),
                System.Numerics.Vector3.Dot(snRow1, snVec),
                System.Numerics.Vector3.Dot(snRow2, snVec));
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3 Transform(Vector3 vec, Quaternion quat)
        {
            Transform(in vec, in quat, out Vector3 result);
            return result;
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Transform(in Vector3 vec, in Quaternion quat, out Vector3 result)
        {
            // Since vec.W == 0, we can optimize quat * vec * quat^-1 as follows:
            // vec + 2.0 * cross(quat.xyz, cross(quat.xyz, vec) + quat.w * vec)
            Vector3 xyz = quat.Xyz;
            Cross(in xyz, in vec, out Vector3 temp);
            Multiply(in vec, quat.W, out Vector3 temp2);
            Add(in temp, in temp2, out temp);
            Cross(in xyz, in temp, out temp2);
            Multiply(in temp2, 2f, out temp2);
            Add(in vec, in temp2, out result);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 TransformTwoDimensionsRow(Vector3 vec, Matrix3x2 mat)
        {
            return (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsRow(in Vector3 vec, in Matrix3x2 mat, out Vector2 result)
        {
            result = (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 TransformFourDimensionsRow(Vector3 vec, Matrix3x4 mat)
        {
            return (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformFourDimensionsRow(in Vector3 vec, in Matrix3x4 mat, out Vector4 result)
        {
            result = (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 TransformTwoDimensionsColumn(Matrix2x3 mat, Vector3 vec)
        {
            return new Vector2(
                Vector128.Dot(mat.Row0.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row1.AsVector128(), vec.AsVector128()));
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 2x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsColumn(in Matrix2x3 mat, in Vector3 vec, out Vector2 result)
        {
            result = new Vector2(
                Vector128.Dot(mat.Row0.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row1.AsVector128(), vec.AsVector128()));
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 TransformFourDimensionsColumn(Matrix4x3 mat, Vector3 vec)
        {
            return new Vector4(
                Vector128.Dot(mat.Row0.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row1.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row2.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row3.AsVector128(), vec.AsVector128()));
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformFourDimensionsColumn(in Matrix4x3 mat, in Vector3 vec, out Vector4 result)
        {
            result = new Vector4(
                Vector128.Dot(mat.Row0.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row1.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row2.AsVector128(), vec.AsVector128()),
                Vector128.Dot(mat.Row3.AsVector128(), vec.AsVector128()));
        }

        /// <summary>
        /// Transform a Vector3 by the given Matrix, and project the resulting Vector4 back to a Vector3.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 TransformPerspective(Vector3 vec, Matrix4 mat)
        {
            var v = ((Vector128.Create(vec.X) * mat.Row0.AsVector128()) +
                     (Vector128.Create(vec.Y) * mat.Row1.AsVector128()) +
                     (Vector128.Create(vec.Z) * mat.Row2.AsVector128()) +
                      mat.Row3.AsVector128()).AsVector4Otk();
            return (v / v.W).AsVector128().AsVector3Otk();
        }

        /// <summary>
        /// Transform a Vector3 by the given Matrix, and project the resulting Vector4 back to a Vector3.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformPerspective(in Vector3 vec, in Matrix4 mat, out Vector3 result)
        {
            var v = ((Vector128.Create(vec.X) * mat.Row0.AsVector128()) +
                     (Vector128.Create(vec.Y) * mat.Row1.AsVector128()) +
                     (Vector128.Create(vec.Z) * mat.Row2.AsVector128()) +
                      mat.Row3.AsVector128()).AsVector4Otk();
            result = (v / v.W).AsVector128().AsVector3Otk();
        }

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <returns>Angle (in radians) between the vectors.</returns>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        [Pure]
        public static float CalculateAngle(Vector3 first, Vector3 second)
        {
            var vfirst = first.AsVector128();
            var vsecond = second.AsVector128();

            // denom = first.Length * second.Length = sqrt(first.LengthSquared * second.LengthSquared)
            var denom = float.Sqrt(Vector128.Dot(vfirst, vfirst) * Vector128.Dot(vsecond, vsecond));

            return float.Acos(float.Clamp(Vector128.Dot(vfirst, vsecond) / denom, -1.0f, 1.0f));
        }

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(in Vector3 first, in Vector3 second, out float result)
        {
            var vfirst = first.AsVector128();
            var vsecond = second.AsVector128();

            // denom = first.Length * second.Length = sqrt(first.LengthSquared * second.LengthSquared)
            var denom = float.Sqrt(Vector128.Dot(vfirst, vfirst) * Vector128.Dot(vsecond, vsecond));

            result = float.Acos(float.Clamp(Vector128.Dot(vfirst, vsecond) / denom, -1.0f, 1.0f));
        }

        /// <summary>
        /// Projects a vector from object space into screen space.
        /// </summary>
        /// <param name="vector">The vector to project.</param>
        /// <param name="x">The X coordinate of the viewport.</param>
        /// <param name="y">The Y coordinate of the viewport.</param>
        /// <param name="width">The width of the viewport.</param>
        /// <param name="height">The height of the viewport.</param>
        /// <param name="minZ">The minimum depth of the viewport.</param>
        /// <param name="maxZ">The maximum depth of the viewport.</param>
        /// <param name="worldViewProjection">The world-view-projection matrix.</param>
        /// <returns>The vector in screen space.</returns>
        /// <remarks>
        /// To project to normalized device coordinates (NDC) use the following parameters:
        /// Project(vector, -1, -1, 2, 2, -1, 1, worldViewProjection).
        /// </remarks>
        [Pure]
        public static Vector3 Project(Vector3 vector, float x, float y, float width, float height, float minZ, float maxZ, Matrix4 worldViewProjection)
        {
            Vector4 result;

            result.X =
                (vector.X * worldViewProjection.M11) +
                (vector.Y * worldViewProjection.M21) +
                (vector.Z * worldViewProjection.M31) +
                worldViewProjection.M41;

            result.Y =
                (vector.X * worldViewProjection.M12) +
                (vector.Y * worldViewProjection.M22) +
                (vector.Z * worldViewProjection.M32) +
                worldViewProjection.M42;

            result.Z =
                (vector.X * worldViewProjection.M13) +
                (vector.Y * worldViewProjection.M23) +
                (vector.Z * worldViewProjection.M33) +
                worldViewProjection.M43;

            result.W =
                (vector.X * worldViewProjection.M14) +
                (vector.Y * worldViewProjection.M24) +
                (vector.Z * worldViewProjection.M34) +
                worldViewProjection.M44;

            result /= result.W;

            result.X = x + (width * ((result.X + 1.0f) / 2.0f));
            result.Y = y + (height * ((result.Y + 1.0f) / 2.0f));
            result.Z = minZ + ((maxZ - minZ) * ((result.Z + 1.0f) / 2.0f));

            return new Vector3(result.X, result.Y, result.Z);
        }

        /// <summary>
        /// Projects a vector from screen space into object space.
        /// </summary>
        /// <param name="vector">The vector to project.</param>
        /// <param name="x">The X coordinate of the viewport.</param>
        /// <param name="y">The Y coordinate of the viewport.</param>
        /// <param name="width">The width of the viewport.</param>
        /// <param name="height">The height of the viewport.</param>
        /// <param name="minZ">The minimum depth of the viewport.</param>
        /// <param name="maxZ">The maximum depth of the viewport.</param>
        /// <param name="inverseWorldViewProjection">The inverse of the world-view-projection matrix.</param>
        /// <returns>The vector in object space.</returns>
        /// <remarks>
        /// To project from normalized device coordinates (NDC) use the following parameters:
        /// Project(vector, -1, -1, 2, 2, -1, 1, inverseWorldViewProjection).
        /// </remarks>
        [Pure]
        public static Vector3 Unproject(Vector3 vector, float x, float y, float width, float height, float minZ, float maxZ, Matrix4 inverseWorldViewProjection)
        {
            float tempX = ((vector.X - x) / width * 2.0f) - 1.0f;
            float tempY = ((vector.Y - y) / height * 2.0f) - 1.0f;
            float tempZ = ((vector.Z - minZ) / (maxZ - minZ) * 2.0f) - 1.0f;

            Vector3 result;
            result.X =
                (tempX * inverseWorldViewProjection.M11) +
                (tempY * inverseWorldViewProjection.M21) +
                (tempZ * inverseWorldViewProjection.M31) +
                inverseWorldViewProjection.M41;

            result.Y =
                (tempX * inverseWorldViewProjection.M12) +
                (tempY * inverseWorldViewProjection.M22) +
                (tempZ * inverseWorldViewProjection.M32) +
                inverseWorldViewProjection.M42;

            result.Z =
                (tempX * inverseWorldViewProjection.M13) +
                (tempY * inverseWorldViewProjection.M23) +
                (tempZ * inverseWorldViewProjection.M33) +
                inverseWorldViewProjection.M43;

            float tempW =
                (tempX * inverseWorldViewProjection.M14) +
                (tempY * inverseWorldViewProjection.M24) +
                (tempZ * inverseWorldViewProjection.M34) +
                inverseWorldViewProjection.M44;

            result /= tempW;

            return result;
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Xy
        {
            readonly get => new Vector2(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Xz
        {
            readonly get => new Vector2(X, Z);
            set
            {
                X = value.X;
                Z = value.Y;
            }
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
        /// Gets or sets an OpenTK.Vector2 with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Yz
        {
            readonly get => new Vector2(Y, Z);
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Zx
        {
            readonly get => new Vector2(Z, X);
            set
            {
                Z = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Zy
        {
            readonly get => new Vector2(Z, Y);
            set
            {
                Z = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Xzy
        {
            readonly get => new Vector3(X, Z, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Yxz
        {
            readonly get => new Vector3(Y, X, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Yzx
        {
            readonly get => new Vector3(Y, Z, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Zxy
        {
            readonly get => new Vector3(Z, X, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Zyx
        {
            readonly get => new Vector3(Z, Y, X);
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
        public static Vector3 operator +(Vector3 left, float right)
        {
            return (left.AsVector128Unsafe() + Vector128.Create(right)).AsVector3Otk();
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3 operator +(float left, Vector3 right)
        {
            return (Vector128.Create(left) + right.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return (left.AsVector128Unsafe() + right.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Subtracts an instance by a scalar.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3 operator -(Vector3 left, float right)
        {
            return (left.AsVector128Unsafe() - Vector128.Create(right)).AsVector3Otk();
        }

        /// <summary>
        /// Subtracts a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3 operator -(float left, Vector3 right)
        {
            return (Vector128.Create(left) - right.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return (left.AsVector128Unsafe() - right.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3 operator -(Vector3 vec)
        {
            return (-vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Computes the unary plus of the vector.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3 operator +(Vector3 vec)
        {
            return (+vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3 operator *(Vector3 vec, float scale)
        {
            return (vec.AsVector128Unsafe() * Vector128.Create(scale)).AsVector3Otk();
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3 operator *(float scale, Vector3 vec)
        {
            return (Vector128.Create(scale) * vec.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise multiplication between the specified instance by a scale vector.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector3 operator *(Vector3 vec, Vector3 scale)
        {
            return (vec.AsSNVector3() * scale.AsSNVector3()).AsVector3Otk();
            return (vec.AsVector128Unsafe() * scale.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 2-dimensional vector using the given 3x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 operator *(Vector3 vec, Matrix3x2 mat)
        {
            return TransformTwoDimensionsRow(vec, mat);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 operator *(Vector3 vec, Matrix3 mat)
        {
            return TransformRow(vec, mat);
        }

        /// <summary>
        /// Transform a 3-dimensional vector into a 4-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 operator *(Vector3 vec, Matrix3x4 mat)
        {
            return TransformFourDimensionsRow(vec, mat);
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3 operator /(Vector3 vec, float scale)
        {
            return (vec.AsSNVector3() / scale).AsVector3Otk();
            return (vec.AsVector128Unsafe() / Vector128.Create(scale)).AsVector3Otk();
        }

        /// <summary>
        /// Divides a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3 operator /(float left, Vector3 right)
        {
            return (Vector128.Create(left) / right.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component-wise division between the specified instance by a scale vector.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3 operator /(Vector3 vec, Vector3 scale)
        {
            return (vec.AsVector128Unsafe() / scale.AsVector128Unsafe()).AsVector3Otk();
        }

        /// <summary>
        /// Component wise less than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        [Pure]
        public static Vector3b operator <(Vector3 left, Vector3 right)
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
        public static Vector3b operator <=(Vector3 left, Vector3 right)
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
        public static Vector3b operator >(Vector3 left, Vector3 right)
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
        public static Vector3b operator >=(Vector3 left, Vector3 right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector3 to OpenTK.Vector3d.
        /// </summary>
        /// <param name="vec">The Vector3 to convert.</param>
        /// <returns>The resulting Vector3d.</returns>
        [Pure]
        public static implicit operator Vector3d(Vector3 vec)
        {
            return new Vector3d(vec.X, vec.Y, vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3 to OpenTK.Vector3h.
        /// </summary>
        /// <param name="vec">The Vector3 to convert.</param>
        /// <returns>The resulting Vector3h.</returns>
        [Pure]
        public static explicit operator Vector3h(Vector3 vec)
        {
            return new Vector3h(vec.X, vec.Y, vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3 to OpenTK.Vector3i.
        /// </summary>
        /// <param name="vec">The Vector3 to convert.</param>
        /// <returns>The resulting Vector3i.</returns>
        [Pure]
        public static explicit operator Vector3i(Vector3 vec)
        {
            return new Vector3i((int)vec.X, (int)vec.Y, (int)vec.Z);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector3"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector3((float X, float Y, float Z) values)
        {
            return new Vector3(values.X, values.Y, values.Z);
        }

        /// <summary>
        /// Converts <see cref="System.Numerics.Vector3"/> to <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vec">The <see cref="System.Numerics.Vector3"/> to cast.</param>
        [Pure]
        public static explicit operator Vector3(System.Numerics.Vector3 vec)
        {
            return Unsafe.As<System.Numerics.Vector3, Vector3>(ref vec);
        }

        /// <summary>
        /// Converts <see cref="Vector3"/> to <see cref="System.Numerics.Vector3"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector3"/> to cast.</param>
        [Pure]
        public static explicit operator System.Numerics.Vector3(Vector3 vec)
        {
            return Unsafe.As<Vector3, System.Numerics.Vector3>(ref vec);
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
            return obj is Vector3 && Equals((Vector3)obj);
        }

        /// <inheritdoc />
        public readonly bool Equals(Vector3 other)
        {
            return this.AsVector128() == other.AsVector128();
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
        public readonly void Deconstruct(out float x, out float y, out float z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
