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
    /// Represents a 4D vector using four single-precision floating-point numbers.
    /// </summary>
    /// <remarks>
    /// The Vector4 structure is suitable for interoperation with unmanaged code requiring four consecutive floats.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4 : IEquatable<Vector4>, IFormattable,
                            IAdditionOperators<Vector4, Vector4, Vector4>,
                            ISubtractionOperators<Vector4, Vector4, Vector4>,
                            IUnaryNegationOperators<Vector4, Vector4>,
                            IUnaryPlusOperators<Vector4, Vector4>,
                            IMultiplyOperators<Vector4, float, Vector4>,
                            IMultiplyOperators<Vector4, Vector4, Vector4>,
                            IMultiplyOperators<Vector4, Matrix4x2, Vector2>,
                            IMultiplyOperators<Vector4, Matrix4x3, Vector3>,
                            IMultiplyOperators<Vector4, Matrix4, Vector4>,
                            IDivisionOperators<Vector4, float, Vector4>,
                            IDivisionOperators<Vector4, Vector4, Vector4>,
                            IEqualityOperators<Vector4, Vector4, bool>,
                            IAdditiveIdentity<Vector4, Vector4>,
                            IMultiplicativeIdentity<Vector4, Vector4>,
                            IMinMaxValue<Vector4>
    {
        /// <summary>
        /// The X component of the Vector4.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector4.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the Vector4.
        /// </summary>
        public float Z;

        /// <summary>
        /// The W component of the Vector4.
        /// </summary>
        public float W;

        /// <summary>
        /// Defines a unit-length Vector4 that points towards the X-axis.
        /// </summary>
        public static readonly Vector4 UnitX = new Vector4(1, 0, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4 that points towards the Y-axis.
        /// </summary>
        public static readonly Vector4 UnitY = new Vector4(0, 1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4 that points towards the Z-axis.
        /// </summary>
        public static readonly Vector4 UnitZ = new Vector4(0, 0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector4 that points towards the W-axis.
        /// </summary>
        public static readonly Vector4 UnitW = new Vector4(0, 0, 0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector4 Zero = new Vector4(0, 0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4 One = new Vector4(1, 1, 1, 1);

        /// <summary>
        /// Defines an instance with all components set to positive infinity.
        /// </summary>
        public static readonly Vector4 PositiveInfinity = new Vector4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        /// <summary>
        /// Defines an instance with all components set to negative infinity.
        /// </summary>
        public static readonly Vector4 NegativeInfinity = new Vector4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);

        /// <summary>
        /// Defines the size of the Vector4 struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector4>();

        /// <summary>
        /// Gets the additive identity of Vector4. Equivalent to Vector4.Zero.
        /// </summary>
        public static Vector4 AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector4. Equivalent to Vector4.One.
        /// </summary>
        public static Vector4 MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the max value for Vector4. Equivalent to Vector4.PositiveInfinity.
        /// </summary>
        public static Vector4 MaxValue => PositiveInfinity;

        /// <summary>
        /// Gets the min value for Vector4. Equivalent to Vector4.NegativeInfinity.
        /// </summary>
        public static Vector4 MinValue => NegativeInfinity;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4(float value)
        {
            this = Vector128.Create(value).AsVector4Otk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector4.</param>
        /// <param name="y">The y component of the Vector4.</param>
        /// <param name="z">The z component of the Vector4.</param>
        /// <param name="w">The w component of the Vector4.</param>
        public Vector4(float x, float y, float z, float w)
        {
            this = Vector128.Create(x, y, z, w).AsVector4Otk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector4.</param>
        /// <param name="z">The z component of the Vector4.</param>
        /// <param name="w">The w component of the Vector4.</param>
        public Vector4(Vector2 xy, float z = default, float w = default)
        {
            this = Vector128.Create(xy.X, xy.Y, z, w).AsVector4Otk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y and z components of the Vector4.</param>
        /// <param name="w">The w component of the Vector4.</param>
        public Vector4(Vector3 xyz, float w = default)
        {
            this = Vector128.Create(xyz.X, xyz.Y, xyz.Z, w).AsVector4Otk();
        }

        /// <summary>
        /// Gets or sets the value at the index of the Vector.
        /// </summary>
        /// <param name="index">The index of the component from the Vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 3.</exception>
        public float this[int index]
        {
            readonly get
            {
                if (((uint)index) >= 4)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this vector at index: {0}", index);
                }

                return GetElementUnsafe(in this, index);
            }

            set
            {
                if (((uint)index) >= 4)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this vector at index: {0}", index);
                }

                GetElementUnsafe(in this, index) = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref float GetElementUnsafe(in Vector4 v, int index)
        {
            ref float address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public readonly float Length => float.Sqrt(LengthSquared);

        /// <summary>
        /// Gets an approximation of 1 over the length (magnitude) of the vector.
        /// </summary>
        public readonly float ReciprocalLengthFast => float.ReciprocalSqrtEstimate(LengthSquared);

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
        /// Returns a copy of the Vector4 scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public readonly Vector4 Normalized()
        {
            return Normalize(this);
        }

        /// <summary>
        /// Scales the Vector4 to unit length.
        /// </summary>
        public void Normalize()
        {
            this = Normalize(this);
        }

        /// <summary>
        /// Scales the Vector4 to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            this = NormalizeFast(this);
        }

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector4 Abs()
        {
            return Abs(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied.
        /// Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <returns>The rounded vector.</returns>
        public readonly Vector4 Round()
        {
            return Round(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise rounding has been applied with the specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The rounded vector.</returns>
        public readonly Vector4 Round(MidpointRounding rounding)
        {
            return Round(this, rounding);
        }

        /// <summary>
        /// Returns a new vector were a component-wise ceiling operation has been applied.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <returns>The ceiled vector.</returns>
        public readonly Vector4 Ceiling()
        {
            return Ceiling(this);
        }

        /// <summary>
        /// Returns a new vector were a component-wise floor operation has been applied.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <returns>The floored vector.</returns>
        public readonly Vector4 Floor()
        {
            return Floor(this);
        }

        /// <summary>
        /// Returns a new vector were component-wise truncation has been applied.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <returns>The truncated vector.</returns>
        public readonly Vector4 Truncate()
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
        public static Vector4 Add(Vector4 a, Vector4 b)
        {
            return (a.AsVector128() + b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <param name="result">Result of operation.</param>
        public static void Add(in Vector4 a, in Vector4 b, out Vector4 result)
        {
            result = (a.AsVector128() + b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector4 Subtract(Vector4 a, Vector4 b)
        {
            return (a.AsVector128() - b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">Result of subtraction.</param>
        public static void Subtract(in Vector4 a, in Vector4 b, out Vector4 result)
        {
            result = (a.AsVector128() - b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4 Multiply(Vector4 vector, float scale)
        {
            return (vector.AsVector128() * Vector128.Create(scale)).AsVector4Otk();
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector4 vector, float scale, out Vector4 result)
        {
            result = (vector.AsVector128() * Vector128.Create(scale)).AsVector4Otk();
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4 Multiply(Vector4 vector, Vector4 scale)
        {
            return (vector.AsVector128() * scale.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Multiplies a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector4 vector, in Vector4 scale, out Vector4 result)
        {
            result = (vector.AsVector128() * scale.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4 Divide(Vector4 vector, float scale)
        {
            return (vector.AsVector128() / Vector128.Create(scale)).AsVector4Otk();
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector4 vector, float scale, out Vector4 result)
        {
            result = (vector.AsVector128() / Vector128.Create(scale)).AsVector4Otk();
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4 Divide(Vector4 vector, Vector4 scale)
        {
            return (vector.AsVector128() / scale.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Divide a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector4 vector, in Vector4 scale, out Vector4 result)
        {
            result = (vector.AsVector128() / scale.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector4 ComponentMin(Vector4 a, Vector4 b)
        {
            return Vector128.Min(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMin(Vector4, Vector4)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector4 ComponentMinNative(Vector4 a, Vector4 b)
        {
            return Vector128.MinNative(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector4 a, in Vector4 b, out Vector4 result)
        {
            result = Vector128.Min(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMin(in Vector4, in Vector4, out Vector4)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void ComponentMinNative(in Vector4 a, in Vector4 b, out Vector4 result)
        {
            result = Vector128.MinNative(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector4 ComponentMax(Vector4 a, Vector4 b)
        {
            return Vector128.Max(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMax(Vector4, Vector4)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Vector4 ComponentMaxNative(Vector4 a, Vector4 b)
        {
            return Vector128.MaxNative(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector4 a, in Vector4 b, out Vector4 result)
        {
            result = Vector128.Max(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="ComponentMax(in Vector4, in Vector4, out Vector4)"/>.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMaxNative(in Vector4 a, in Vector4 b, out Vector4 result)
        {
            result = Vector128.MaxNative(a.AsVector128(), b.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns the Vector4 with the minimum magnitude. If the magnitudes are equal, the second vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The minimum Vector4.</returns>
        [Pure]
        public static Vector4 MagnitudeMin(Vector4 left, Vector4 right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4 with the minimum magnitude. If the magnitudes are equal, the second vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise minimum.</param>
        public static void MagnitudeMin(in Vector4 left, in Vector4 right, out Vector4 result)
        {
            result = left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4 with the maximum magnitude. If the magnitudes are equal, the first vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>The maximum Vector4.</returns>
        [Pure]
        public static Vector4 MagnitudeMax(Vector4 left, Vector4 right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4 with the maximum magnitude. If the magnitudes are equal, the first vector
        /// is selected.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <param name="result">The magnitude-wise maximum.</param>
        public static void MagnitudeMax(in Vector4 left, in Vector4 right, out Vector4 result)
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
        public static Vector4 Clamp(Vector4 vec, Vector4 min, Vector4 max)
        {
            return Vector128.Clamp(vec.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="Clamp(Vector4, Vector4, Vector4)"/>.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <returns>The clamped vector.</returns>
        [Pure]
        public static Vector4 ClampNative(Vector4 vec, Vector4 min, Vector4 max)
        {
            return Vector128.ClampNative(vec.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector4 vec, in Vector4 min, in Vector4 max, out Vector4 result)
        {
            result = Vector128.Clamp(vec.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// This version has platform dependent behaviour for <c>NaN</c> and <c>NegativeZero</c> but potentially faster than <see cref="Clamp(in Vector4, in Vector4, in Vector4, out Vector4)"/>.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void ClampNative(in Vector4 vec, in Vector4 min, in Vector4 max, out Vector4 result)
        {
            result = Vector128.ClampNative(vec.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector4 Abs(Vector4 vec)
        {
            return Vector128.Abs(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector4 vec, out Vector4 result)
        {
            result = Vector128.Abs(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector4 Round(Vector4 vec)
        {
            return Vector128.Round(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise rounding. Equivalent to calling <see cref="MathF.Round(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector4 vec, out Vector4 result)
        {
            result = Vector128.Round(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <returns>The component-wise rounded vector.</returns>
        [Pure]
        public static Vector4 Round(Vector4 vec, MidpointRounding rounding)
        {
            return Vector128.Round(vec.AsVector128(), rounding).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise rounding with specified midpoint rounding rule.
        /// Equivalent to calling <see cref="MathF.Round(float,MidpointRounding)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to round.</param>
        /// <param name="rounding">The midpoint rounding rule to use.</param>
        /// <param name="result">The component-wise rounded vector.</param>
        public static void Round(in Vector4 vec, MidpointRounding rounding, out Vector4 result)
        {
            result = Vector128.Round(vec.AsVector128(), rounding).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <returns>The component-wise ceiling vector.</returns>
        [Pure]
        public static Vector4 Ceiling(Vector4 vec)
        {
            return Vector128.Ceiling(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise ceiling operation.
        /// Equivalent to calling <see cref="MathF.Ceiling(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the ceiling of.</param>
        /// <param name="result">The component-wise ceiling vector.</param>
        public static void Ceiling(in Vector4 vec, out Vector4 result)
        {
            result = Vector128.Ceiling(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <returns>The component-wise floored vector.</returns>
        [Pure]
        public static Vector4 Floor(Vector4 vec)
        {
            return Vector128.Floor(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise floor operation.
        /// Equivalent to calling <see cref="MathF.Floor(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to take the floor of.</param>
        /// <param name="result">The component-wise floored vector.</param>
        public static void Floor(in Vector4 vec, out Vector4 result)
        {
            result = Vector128.Floor(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <returns>The component-wise truncated vector.</returns>
        [Pure]
        public static Vector4 Truncate(Vector4 vec)
        {
            return Vector128.Truncate(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise truncation.
        /// Equivalent to calling <see cref="MathF.Truncate(float)"/> on each component.
        /// </summary>
        /// <param name="vec">The vector to truncate.</param>
        /// <param name="result">The component-wise truncated vector.</param>
        public static void Truncate(in Vector4 vec, out Vector4 result)
        {
            result = Vector128.Truncate(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <returns>The distance.</returns>
        [Pure]
        public static float Distance(Vector4 vec1, Vector4 vec2)
        {
            return (vec1 - vec2).Length;
        }

        /// <summary>
        /// Compute the euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The distance.</param>
        public static void Distance(in Vector4 vec1, in Vector4 vec2, out float result)
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
        public static float DistanceSquared(Vector4 vec1, Vector4 vec2)
        {
            return (vec1 - vec2).LengthSquared;
        }

        /// <summary>
        /// Compute the squared euclidean distance between two vectors.
        /// </summary>
        /// <param name="vec1">The first vector.</param>
        /// <param name="vec2">The second vector.</param>
        /// <param name="result">The squared distance.</param>
        public static void DistanceSquared(in Vector4 vec1, in Vector4 vec2, out float result)
        {
            result = (vec1 - vec2).LengthSquared;
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector4 Normalize(Vector4 vec)
        {
            return (vec.AsVector128() / vec.Length).AsVector4Otk();
        }

        /// <summary>
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized vector.</param>
        public static void Normalize(in Vector4 vec, out Vector4 result)
        {
            result = (vec.AsVector128() / vec.Length).AsVector4Otk();
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector4 NormalizeFast(Vector4 vec)
        {
            return (vec.AsVector128() * vec.ReciprocalLengthFast).AsVector4Otk();
        }

        /// <summary>
        /// Scale a vector to approximately unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <param name="result">The normalized copy.</param>
        public static void NormalizeFast(in Vector4 vec, out Vector4 result)
        {
            result = (vec.AsVector128() * vec.ReciprocalLengthFast).AsVector4Otk();
        }

        /// <summary>
        /// Calculate the dot product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        [Pure]
        public static float Dot(Vector4 left, Vector4 right)
        {
            return Vector128.Dot(left.AsVector128(), right.AsVector128());
        }

        /// <summary>
        /// Calculate the dot product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <param name="result">The dot product of the two inputs.</param>
        public static void Dot(in Vector4 left, in Vector4 right, out float result)
        {
            result = Vector128.Dot(left.AsVector128(), right.AsVector128());
        }

        /// <summary>
        /// Computes the component-wise exponential.
        /// </summary>
        /// <param name="x">The vector to calculate the exponential of.</param>
        /// <returns>The component-wise exponental.</returns>
        public static Vector4 Exp(Vector4 x)
        {
            return Vector128.Exp(x.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the component-wise exponential.
        /// </summary>
        /// <param name="x">The vector to calculate the exponential of.</param>
        /// <param name="result">The component-wise exponental.</param>
        public static void Exp(in Vector4 x, out Vector4 result)
        {
            result = Vector128.Exp(x.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the component-wise natural logarithm.
        /// </summary>
        /// <param name="x">The vector to calculate the natural logarithm of.</param>
        /// <returns>The component-wise natural logarithm.</returns>
        public static Vector4 Log(Vector4 x)
        {
            return Vector128.Log(x.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the component-wise natural logarithm.
        /// </summary>
        /// <param name="x">The vector to calculate the natural logarithm of.</param>
        /// <param name="result">The component-wise natural logarithm.</param>
        public static void Log(in Vector4 x, out Vector4 result)
        {
            result = Vector128.Log(x.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the component-wise base-2 logarithm.
        /// </summary>
        /// <param name="x">The vector to calculate the base-2 logarithm of.</param>
        /// <returns>The component-wise base-2 logarithm.</returns>
        public static Vector4 Log2(Vector4 x)
        {
            return Vector128.Log2(x.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the component-wise base-2 logarithm.
        /// </summary>
        /// <param name="x">The vector to calculate the base-2 logarithm of.</param>
        /// <param name="result">The component-wise base-2 logarithm.</param>
        public static void Log2(in Vector4 x, out Vector4 result)
        {
            result = Vector128.Log2(x.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <returns>Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</returns>
        public static Vector4 Pow(Vector4 x, Vector4 y)
        {
            // FIXME: Proper SIMD implementation?
            return new Vector4(
                MathF.Pow(x.X, y.X),
                MathF.Pow(x.Y, y.Y),
                MathF.Pow(x.Z, y.Z),
                MathF.Pow(x.W, y.W));
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <param name="result">Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</param>
        public static void Pow(in Vector4 x, in Vector4 y, out Vector4 result)
        {
            // FIXME: Proper SIMD implementation?
            result.X = MathF.Pow(x.X, y.X);
            result.Y = MathF.Pow(x.Y, y.Y);
            result.Z = MathF.Pow(x.Z, y.Z);
            result.W = MathF.Pow(x.W, y.W);
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <returns>Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</returns>
        public static Vector4 Pow(Vector4 x, float y)
        {
            // FIXME: Proper SIMD implementation?
            return new Vector4(
                MathF.Pow(x.X, y),
                MathF.Pow(x.Y, y),
                MathF.Pow(x.Z, y),
                MathF.Pow(x.W, y));
        }

        /// <summary>
        /// Computes the component-wise power.
        /// </summary>
        /// <param name="x">The base.</param>
        /// <param name="y">The exponent.</param>
        /// <param name="result">Component-wise <paramref name="x"/> raised to the power of <paramref name="y"/>.</param>
        public static void Pow(in Vector4 x, in float y, out Vector4 result)
        {
            // FIXME: Proper SIMD implementation?
            result.X = MathF.Pow(x.X, y);
            result.Y = MathF.Pow(x.Y, y);
            result.Z = MathF.Pow(x.Z, y);
            result.W = MathF.Pow(x.W, y);
        }

        /// <summary>
        /// Computes <c>x * y + z</c>, as a fused multiply add, only rounding once.
        /// </summary>
        /// <param name="x">The left multiplicand.</param>
        /// <param name="y">The right multiplicand.</param>
        /// <param name="z">The addend.</param>
        /// <returns>Returns <c>x * y + z</c>.</returns>
        public static Vector4 Fma(Vector4 x, Vector4 y, Vector4 z)
        {
            return Vector128.FusedMultiplyAdd(x.AsVector128(), y.AsVector128(), z.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes <c>x * y + z</c>, as a fused multiply add, only rounding once.
        /// </summary>
        /// <param name="x">The left multiplicand.</param>
        /// <param name="y">The right multiplicand.</param>
        /// <param name="z">The addend.</param>
        /// <param name="result"><c>x * y + z</c>.</param>
        public static void Fma(in Vector4 x, in Vector4 y, in Vector4 z, out Vector4 result)
        {
            result = Vector128.FusedMultiplyAdd(x.AsVector128(), y.AsVector128(), z.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector4b LessThan(in Vector4 left, in Vector4 right)
        {
            return new Vector4b(left.X < right.X, left.Y < right.Y, left.Z < right.Z, left.W < right.W);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector4b LessThanOrEqual(in Vector4 left, in Vector4 right)
        {
            return new Vector4b(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z, left.W <= right.W);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector4b GreaterThan(in Vector4 left, in Vector4 right)
        {
            return new Vector4b(left.X > right.X, left.Y > right.Y, left.Z > right.Z, left.W > right.W);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector4b GreaterThanOrEqual(in Vector4 left, in Vector4 right)
        {
            return new Vector4b(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z, left.W >= right.W);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector4b ComponentEqual(in Vector4 left, in Vector4 right)
        {
            return new Vector4b(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector4b ComponentNotEqual(in Vector4 left, in Vector4 right)
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
        public static Vector4 Lerp(Vector4 a, Vector4 b, float blend)
        {
            return Vector128.Lerp(a.AsVector128(), b.AsVector128(), Vector128.Create(blend)).AsVector4Otk();
        }

        /// <summary>
        /// Returns a new vector that is the linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise.</param>
        public static void Lerp(in Vector4 a, in Vector4 b, float blend, out Vector4 result)
        {
            result = Vector128.Lerp(a.AsVector128(), b.AsVector128(), Vector128.Create(blend)).AsVector4Otk();
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</returns>
        [Pure]
        public static Vector4 Lerp(Vector4 a, Vector4 b, Vector4 blend)
        {
            return Vector128.Lerp(a.AsVector128(), b.AsVector128(), blend.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Returns a new vector that is the component-wise linear blend of the 2 given vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a component-wise linear combination otherwise.</param>
        public static void Lerp(in Vector4 a, in Vector4 b, Vector4 blend, out Vector4 result)
        {
            result = Vector128.Lerp(a.AsVector128(), b.AsVector128(), blend.AsVector128()).AsVector4Otk();
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
        public static Vector4 Slerp(Vector4 a, Vector4 b, float t)
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
        public static void Slerp(in Vector4 a, in Vector4 b, float t, out Vector4 result)
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
        public static Vector4 Elerp(Vector4 a, Vector4 b, float t)
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
        public static void Elerp(in Vector4 a, in Vector4 b, float t, out Vector4 result)
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
        public static Vector4 BaryCentric(Vector4 a, Vector4 b, Vector4 c, float u, float v)
        {
            return Fma(c - a, new(v), Fma(b - a, new(u), a));
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
        public static void BaryCentric(in Vector4 a, in Vector4 b, in Vector4 c, float u, float v, out Vector4 result)
        {
            result = Fma(c - a, new(v), Fma(b - a, new(u), a));
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 TransformRow(Vector4 vec, Matrix4 mat)
        {
            return (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2) + (vec.W * mat.Row3);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformRow(in Vector4 vec, in Matrix4 mat, out Vector4 result)
        {
            result = (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2) + (vec.W * mat.Row3);
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4 Transform(Vector4 vec, Quaternion quat)
        {
            Transform(in vec, in quat, out Vector4 result);
            return result;
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Transform(in Vector4 vec, in Quaternion quat, out Vector4 result)
        {
            Quaternion v = new Quaternion(vec.X, vec.Y, vec.Z, vec.W);
            Quaternion.Invert(in quat, out Quaternion i);
            Quaternion.Multiply(in quat, in v, out Quaternion t);
            Quaternion.Multiply(in t, in i, out v);

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
        public static Vector4 TransformColumn(Matrix4 mat, Vector4 vec)
        {
            return new Vector4(Dot(mat.Row0, vec), Dot(mat.Row1, vec), Dot(mat.Row2, vec), Dot(mat.Row3, vec));
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformColumn(in Matrix4 mat, in Vector4 vec, out Vector4 result)
        {
            result = new Vector4(Dot(mat.Row0, vec), Dot(mat.Row1, vec), Dot(mat.Row2, vec), Dot(mat.Row3, vec));
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 TransformTwoDimensionsRow(Vector4 vec, Matrix4x2 mat)
        {
            return (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2) + (vec.W * mat.Row3);
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsRow(in Vector4 vec, in Matrix4x2 mat, out Vector2 result)
        {
            result = (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2) + (vec.W * mat.Row3);
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 TransformThreeDimensionsRow(Vector4 vec, Matrix4x3 mat)
        {
            return (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2) + (vec.W * mat.Row3);
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 4x3 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformThreeDimensionsRow(in Vector4 vec, in Matrix4x3 mat, out Vector3 result)
        {
            result = (vec.X * mat.Row0) + (vec.Y * mat.Row1) + (vec.Z * mat.Row2) + (vec.W * mat.Row3);
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 TransformTwoDimensionsColumn(Matrix2x4 mat, Vector4 vec)
        {
            return new Vector2(Dot(mat.Row0, vec), Dot(mat.Row1, vec));
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 2x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformTwoDimensionsColumn(in Matrix2x4 mat, in Vector4 vec, out Vector2 result)
        {
            result = new Vector2(Dot(mat.Row0, vec), Dot(mat.Row1, vec));
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 TransformThreeDimensionsColumn(Matrix3x4 mat, Vector4 vec)
        {
            return new Vector3(Dot(mat.Row0, vec), Dot(mat.Row1, vec), Dot(mat.Row2, vec));
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 3-dimensional vector using the given 3x4 Matrix.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="result">The transformed vector.</param>
        public static void TransformThreeDimensionsColumn(in Matrix3x4 mat, in Vector4 vec, out Vector3 result)
        {
            result = new Vector3(Dot(mat.Row0, vec), Dot(mat.Row1, vec), Dot(mat.Row2, vec));
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
        /// Gets or sets an OpenTK.Vector2 with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Xw
        {
            readonly get => new Vector2(X, W);
            set
            {
                X = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2 with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Yw
        {
            readonly get => new Vector2(Y, W);
            set
            {
                Y = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2 with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Zw
        {
            readonly get => new Vector2(Z, W);
            set
            {
                Z = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Wx
        {
            readonly get => new Vector2(W, X);
            set
            {
                W = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Wy
        {
            readonly get => new Vector2(W, Y);
            set
            {
                W = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2 Wz
        {
            readonly get => new Vector2(W, Z);
            set
            {
                W = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Xyz
        {
            readonly get => new Vector3(X, Y, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Xyw
        {
            readonly get => new Vector3(X, Y, W);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3 with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Xzw
        {
            readonly get => new Vector3(X, Z, W);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Xwy
        {
            readonly get => new Vector3(X, W, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Xwz
        {
            readonly get => new Vector3(X, W, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3 with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Yxw
        {
            readonly get => new Vector3(Y, X, W);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3 with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Yzw
        {
            readonly get => new Vector3(Y, Z, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Ywx
        {
            readonly get => new Vector3(Y, W, X);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Ywz
        {
            readonly get => new Vector3(Y, W, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3 with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Zxw
        {
            readonly get => new Vector3(Z, X, W);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3 with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Zyw
        {
            readonly get => new Vector3(Z, Y, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Zwx
        {
            readonly get => new Vector3(Z, W, X);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Zwy
        {
            readonly get => new Vector3(Z, W, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Wxy
        {
            readonly get => new Vector3(W, X, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Wxz
        {
            readonly get => new Vector3(W, X, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Wyx
        {
            readonly get => new Vector3(W, Y, X);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Wyz
        {
            readonly get => new Vector3(W, Y, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Wzx
        {
            readonly get => new Vector3(W, Z, X);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3 with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3 Wzy
        {
            readonly get => new Vector3(W, Z, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Xywz
        {
            readonly get => new Vector4(X, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Xzyw
        {
            readonly get => new Vector4(X, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Xzwy
        {
            readonly get => new Vector4(X, Z, W, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Xwyz
        {
            readonly get => new Vector4(X, W, Y, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Xwzy
        {
            readonly get => new Vector4(X, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Yxzw
        {
            readonly get => new Vector4(Y, X, Z, W);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Yxwz
        {
            readonly get => new Vector4(Y, X, W, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Yyzw
        {
            readonly get => new Vector4(Y, Y, Z, W);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Yywz
        {
            readonly get => new Vector4(Y, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Yzxw
        {
            readonly get => new Vector4(Y, Z, X, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Yzwx
        {
            readonly get => new Vector4(Y, Z, W, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Ywxz
        {
            readonly get => new Vector4(Y, W, X, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Ywzx
        {
            readonly get => new Vector4(Y, W, Z, X);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zxyw
        {
            readonly get => new Vector4(Z, X, Y, W);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zxwy
        {
            readonly get => new Vector4(Z, X, W, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zyxw
        {
            readonly get => new Vector4(Z, Y, X, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zywx
        {
            readonly get => new Vector4(Z, Y, W, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zwxy
        {
            readonly get => new Vector4(Z, W, X, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zwyx
        {
            readonly get => new Vector4(Z, W, Y, X);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Zwzy
        {
            readonly get => new Vector4(Z, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wxyz
        {
            readonly get => new Vector4(W, X, Y, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wxzy
        {
            readonly get => new Vector4(W, X, Z, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wyxz
        {
            readonly get => new Vector4(W, Y, X, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wyzx
        {
            readonly get => new Vector4(W, Y, Z, X);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wzxy
        {
            readonly get => new Vector4(W, Z, X, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wzyx
        {
            readonly get => new Vector4(W, Z, Y, X);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4 with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4 Wzyw
        {
            readonly get => new Vector4(W, Z, Y, W);
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
        public static Vector4 operator +(Vector4 left, float right)
        {
            return (left.AsVector128() + Vector128.Create(right)).AsVector4Otk();
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4 operator +(float left, Vector4 right)
        {
            return (Vector128.Create(left) + right.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return (left.AsVector128() + right.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Subtracts an instance by a scalar.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4 operator -(Vector4 left, float right)
        {
            return (left.AsVector128() - Vector128.Create(right)).AsVector4Otk();
        }

        /// <summary>
        /// Subtracts a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4 operator -(float left, Vector4 right)
        {
            return (Vector128.Create(left) - right.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return (left.AsVector128() - right.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4 operator -(Vector4 vec)
        {
            return (-vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Computes the unary plus of the vector.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4 operator +(Vector4 vec)
        {
            return (+vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4 operator *(Vector4 vec, float scale)
        {
            return (vec.AsVector128() * scale).AsVector4Otk();
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4 operator *(float scale, Vector4 vec)
        {
            return (scale * vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise multiplication between the specified instance by a scale vector.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector4 operator *(Vector4 vec, Vector4 scale)
        {
            return (vec.AsVector128() * scale.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 operator *(Vector4 vec, Matrix4x2 mat)
        {
            return TransformTwoDimensionsRow(vec, mat);
        }

        /// <summary>
        /// Transform a 4-dimensional vector into a 2-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector3 operator *(Vector4 vec, Matrix4x3 mat)
        {
            return TransformThreeDimensionsRow(vec, mat);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 operator *(Vector4 vec, Matrix4 mat)
        {
            return TransformRow(vec, mat);
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4 operator /(Vector4 vec, float scale)
        {
            return (vec.AsVector128() / scale).AsVector4Otk();
        }

        /// <summary>
        /// Divides a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4 operator /(float left, Vector4 right)
        {
            return (Vector128.Create(left) / right.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component-wise division between the specified instance by a scale vector.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4 operator /(Vector4 vec, Vector4 scale)
        {
            return (vec.AsVector128() / scale.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Component wise less than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        [Pure]
        public static Vector4b operator <(Vector4 left, Vector4 right)
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
        public static Vector4b operator <=(Vector4 left, Vector4 right)
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
        public static Vector4b operator >(Vector4 left, Vector4 right)
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
        public static Vector4b operator >=(Vector4 left, Vector4 right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector4 left, Vector4 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector4 left, Vector4 right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector4 to OpenTK.Vector4d.
        /// </summary>
        /// <param name="vec">The Vector4 to convert.</param>
        /// <returns>The resulting Vector4d.</returns>
        [Pure]
        public static implicit operator Vector4d(Vector4 vec)
        {
            var (lower, upper) = Vector128.Widen(vec.AsVector128());
            return Vector256.Create(lower, upper).AsVector4dOtk();
        }

        /// <summary>
        /// Converts OpenTK.Vector4 to OpenTK.Vector4h.
        /// </summary>
        /// <param name="vec">The Vector4 to convert.</param>
        /// <returns>The resulting Vector4h.</returns>
        [Pure]
        public static explicit operator Vector4h(Vector4 vec)
        {
            return new Vector4h(vec.X, vec.Y, vec.Z, vec.W);
        }

        /// <summary>
        /// Converts OpenTK.Vector4 to OpenTK.Vector4i.
        /// </summary>
        /// <param name="vec">The Vector4 to convert.</param>
        /// <returns>The resulting Vector4i.</returns>
        [Pure]
        public static explicit operator Vector4i(Vector4 vec)
        {
            return Vector128.ConvertToInt32(vec.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector4"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector4((float X, float Y, float Z, float W) values)
        {
            return new Vector4(values.X, values.Y, values.Z, values.W);
        }

        /// <summary>
        /// Converts <see cref="System.Numerics.Vector4"/> to <see cref="Vector4"/>.
        /// </summary>
        /// <param name="vec">The <see cref="System.Numerics.Vector4"/> to cast.</param>
        [Pure]
        public static explicit operator Vector4(System.Numerics.Vector4 vec)
        {
            return Unsafe.BitCast<System.Numerics.Vector4, Vector4>(vec);
        }

        /// <summary>
        /// Converts <see cref="Vector4"/> to <see cref="System.Numerics.Vector4"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector4"/> to cast.</param>
        [Pure]
        public static explicit operator System.Numerics.Vector4(Vector4 vec)
        {
            return Unsafe.BitCast<Vector4, System.Numerics.Vector4>(vec);
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
            return obj is Vector4 && Equals((Vector4)obj);
        }

        /// <inheritdoc />
        public readonly bool Equals(Vector4 other)
        {
            return this.AsVector128() == other.AsVector128();
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
        public readonly void Deconstruct(out float x, out float y, out float z, out float w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
    }
}
