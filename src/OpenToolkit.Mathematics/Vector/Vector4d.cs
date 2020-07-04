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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Represents a 4D vector using four double-precision floating-point numbers.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4d : IEquatable<Vector4d>
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
        /// Defines a zero-length Vector4d.
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
        public static readonly int SizeInBytes = Marshal.SizeOf<Vector4d>();

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
        /// <param name="v">The Vector2d to copy components from.</param>
        public Vector4d(Vector2d v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
            W = 0.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="v">The Vector3d to copy components from.</param>
        /// <remarks>
        /// <seealso cref="Vector4d(Vector3d, double)"/>.
        /// </remarks>
        public Vector4d(Vector3d v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="v">The Vector3d to copy components from.</param>
        /// <param name="w">The w component of the new Vector4.</param>
        public Vector4d(Vector3d v, double w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4d"/> struct.
        /// </summary>
        /// <param name="v">The Vector4d to copy components from.</param>
        public Vector4d(Vector4d v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = v.W;
        }

        /// <summary>
        /// Gets or sets the value at the index of the Vector.
        /// </summary>
        /// <param name="index">The index of the component from the Vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 3.</exception>
        public double this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return X;
                }

                if (index == 1)
                {
                    return Y;
                }

                if (index == 2)
                {
                    return Z;
                }

                if (index == 3)
                {
                    return W;
                }

                throw new IndexOutOfRangeException("You tried to access this vector at index: " + index);
            }

            set
            {
                if (index == 0)
                {
                    X = value;
                }
                else if (index == 1)
                {
                    Y = value;
                }
                else if (index == 2)
                {
                    Z = value;
                }
                else if (index == 3)
                {
                    W = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
                }
            }
        }

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public double Length => Math.Sqrt((X * X) + (Y * Y) + (Z * Z) + (W * W));

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude, with
        /// an upper error bound of 0.001.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public double LengthFast => 1.0 / MathHelper.InverseSqrtFast((X * X) + (Y * Y) + (Z * Z) + (W * W));

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        public double LengthSquared => (X * X) + (Y * Y) + (Z * Z) + (W * W);

        /// <summary>
        /// Returns a copy of the Vector4d scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public Vector4d Normalized()
        {
            var v = this;
            v.Normalize();
            return v;
        }

        /// <summary>
        /// Scales the Vector4d to unit length.
        /// </summary>
        public void Normalize()
        {
            var scale = 1.0 / Length;
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
            var scale = MathHelper.InverseSqrtFast((X * X) + (Y * Y) + (Z * Z) + (W * W));
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
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
        /// <returns>Result of subtraction.</returns>
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
        /// Scale a vector to unit length.
        /// </summary>
        /// <param name="vec">The input vector.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Vector4d Normalize(Vector4d vec)
        {
            var scale = 1.0 / vec.Length;
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
            var scale = 1.0 / vec.Length;
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
            var scale = MathHelper.InverseSqrtFast((vec.X * vec.X) + (vec.Y * vec.Y) + (vec.Z * vec.Z) + (vec.W * vec.W));
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
            var scale = MathHelper.InverseSqrtFast((vec.X * vec.X) + (vec.Y * vec.Y) + (vec.Z * vec.Z) + (vec.W * vec.W));
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
        /// Returns a new Vector that is the linear blend of the 2 given Vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
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
        /// Returns a new Vector that is the linear blend of the 2 given Vectors.
        /// </summary>
        /// <param name="a">First input vector.</param>
        /// <param name="b">Second input vector.</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise.</param>
        public static void Lerp(in Vector4d a, in Vector4d b, double blend, out Vector4d result)
        {
            result.X = (blend * (b.X - a.X)) + a.X;
            result.Y = (blend * (b.Y - a.Y)) + a.Y;
            result.Z = (blend * (b.Z - a.Z)) + a.Z;
            result.W = (blend * (b.W - a.W)) + a.W;
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
            BaryCentric(in a, in b, in c, u, v, out var result);
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
            Subtract(in b, in a, out var ab);
            Multiply(in ab, u, out var abU);
            Add(in a, in abU, out var uPos);

            Subtract(in c, in a, out var ac);
            Multiply(in ac, v, out var acV);
            Add(in uPos, in acV, out result);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d Transform(Vector4d vec, Matrix4d mat)
        {
            Transform(in vec, in mat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Transform a Vector by the given Matrix.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="result">The transformed vector.</param>
        public static void Transform(in Vector4d vec, in Matrix4d mat, out Vector4d result)
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
        /// Gets or sets an OpenToolkit.Vector2d with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xy
        {
            get => Unsafe.As<Vector4d, Vector2d>(ref this);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xz
        {
            get => new Vector2d(X, Z);
            set
            {
                X = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xw
        {
            get => new Vector2d(X, W);
            set
            {
                X = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yx
        {
            get => new Vector2d(Y, X);
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yz
        {
            get => new Vector2d(Y, Z);
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yw
        {
            get => new Vector2d(Y, W);
            set
            {
                Y = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zx
        {
            get => new Vector2d(Z, X);
            set
            {
                Z = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zy
        {
            get => new Vector2d(Z, Y);
            set
            {
                Z = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zw
        {
            get => new Vector2d(Z, W);
            set
            {
                Z = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wx
        {
            get => new Vector2d(W, X);
            set
            {
                W = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wy
        {
            get => new Vector2d(W, Y);
            set
            {
                W = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector2d with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wz
        {
            get => new Vector2d(W, Z);
            set
            {
                W = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyz
        {
            get => Unsafe.As<Vector4d, Vector3d>(ref this);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyw
        {
            get => new Vector3d(X, Y, W);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzy
        {
            get => new Vector3d(X, Z, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzw
        {
            get => new Vector3d(X, Z, W);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwy
        {
            get => new Vector3d(X, W, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwz
        {
            get => new Vector3d(X, W, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxz
        {
            get => new Vector3d(Y, X, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxw
        {
            get => new Vector3d(Y, X, W);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzx
        {
            get => new Vector3d(Y, Z, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzw
        {
            get => new Vector3d(Y, Z, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywx
        {
            get => new Vector3d(Y, W, X);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywz
        {
            get => new Vector3d(Y, W, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxy
        {
            get => new Vector3d(Z, X, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxw
        {
            get => new Vector3d(Z, X, W);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyx
        {
            get => new Vector3d(Z, Y, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyw
        {
            get => new Vector3d(Z, Y, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwx
        {
            get => new Vector3d(Z, W, X);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwy
        {
            get => new Vector3d(Z, W, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxy
        {
            get => new Vector3d(W, X, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxz
        {
            get => new Vector3d(W, X, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyx
        {
            get => new Vector3d(W, Y, X);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyz
        {
            get => new Vector3d(W, Y, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzx
        {
            get => new Vector3d(W, Z, X);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector3d with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzy
        {
            get => new Vector3d(W, Z, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xywz
        {
            get => new Vector4d(X, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzyw
        {
            get => new Vector4d(X, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzwy
        {
            get => new Vector4d(X, Z, W, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwyz
        {
            get => new Vector4d(X, W, Y, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwzy
        {
            get => new Vector4d(X, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxzw
        {
            get => new Vector4d(Y, X, Z, W);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxwz
        {
            get => new Vector4d(Y, X, W, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyzw
        {
            get => new Vector4d(Y, Y, Z, W);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yywz
        {
            get => new Vector4d(Y, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzxw
        {
            get => new Vector4d(Y, Z, X, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzwx
        {
            get => new Vector4d(Y, Z, W, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywxz
        {
            get => new Vector4d(Y, W, X, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywzx
        {
            get => new Vector4d(Y, W, Z, X);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxyw
        {
            get => new Vector4d(Z, X, Y, W);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxwy
        {
            get => new Vector4d(Z, X, W, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyxw
        {
            get => new Vector4d(Z, Y, X, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zywx
        {
            get => new Vector4d(Z, Y, W, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwxy
        {
            get => new Vector4d(Z, W, X, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwyx
        {
            get => new Vector4d(Z, W, Y, X);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwzy
        {
            get => new Vector4d(Z, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxyz
        {
            get => new Vector4d(W, X, Y, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxzy
        {
            get => new Vector4d(W, X, Z, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyxz
        {
            get => new Vector4d(W, Y, X, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyzx
        {
            get => new Vector4d(W, Y, Z, X);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzxy
        {
            get => new Vector4d(W, Z, X, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyx
        {
            get => new Vector4d(W, Z, Y, X);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenToolkit.Vector4d with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyw
        {
            get => new Vector4d(W, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
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
        /// <returns>Result of multiplication.</returns>
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
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d operator *(Quaterniond quat, Vector4d vec)
        {
            Transform(in vec, in quat, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
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
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        [Pure]
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
        [Pure]
        public static bool operator !=(Vector4d left, Vector4d right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a pointer to the first element of the specified instance.
        /// </summary>
        /// <param name="v">The instance.</param>
        /// <returns>A pointer to the first element of v.</returns>
        [Pure]
        public static unsafe explicit operator double*(Vector4d v)
        {
            return &v.X;
        }

        /// <summary>
        /// Returns a pointer to the first element of the specified instance.
        /// </summary>
        /// <param name="v">The instance.</param>
        /// <returns>A pointer to the first element of v.</returns>
        [Pure]
        public static explicit operator IntPtr(Vector4d v)
        {
            unsafe
            {
                return (IntPtr)(&v.X);
            }
        }

        /// <summary>
        /// Converts OpenToolkit.Vector4 to OpenToolkit.Vector4d.
        /// </summary>
        /// <param name="v4">The Vector4 to convert.</param>
        /// <returns>The resulting Vector4d.</returns>
        [Pure]
        public static explicit operator Vector4d(Vector4 v4)
        {
            return new Vector4d(v4.X, v4.Y, v4.Z, v4.W);
        }

        /// <summary>
        /// Converts OpenToolkit.Vector4d to OpenToolkit.Vector4.
        /// </summary>
        /// <param name="v4d">The Vector4d to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        [Pure]
        public static explicit operator Vector4(Vector4d v4d)
        {
            return new Vector4((float)v4d.X, (float)v4d.Y, (float)v4d.Z, (float)v4d.W);
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

        private static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        /// <inheritdoc />
        public override string ToString()
        {
            return string.Format("({0}{4} {1}{4} {2}{4} {3})", X, Y, Z, W, ListSeparator);
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                hashCode = (hashCode * 397) ^ W.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        [Pure]
        public override bool Equals(object obj)
        {
            if (!(obj is Vector4d))
            {
                return false;
            }

            return Equals((Vector4d)obj);
        }

        /// <summary>
        /// Indicates whether the current vector is equal to another vector.
        /// </summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        [Pure]
        public bool Equals(Vector4d other)
        {
            return
                X == other.X &&
                Y == other.Y &&
                Z == other.Z &&
                W == other.W;
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        /// <param name="z">The Z component of the vector.</param>
        /// <param name="w">The W component of the vector.</param>
        [Pure]
        public void Deconstruct(out double x, out double y, out double z, out double w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
    }
}
