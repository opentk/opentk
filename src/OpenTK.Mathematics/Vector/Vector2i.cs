//
//  Vector3i.cs
//
//  Copyright (C) OpenTK
//
//  This software may be modified and distributed under the terms
//  of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 2D vector using two 32-bit integer numbers.
    /// </summary>
    /// <remarks>
    /// The Vector2i structure is suitable for interoperation with unmanaged code requiring two consecutive integers.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2i : IEquatable<Vector2i>, IFormattable,
                            IAdditionOperators<Vector2i, Vector2i, Vector2i>,
                            ISubtractionOperators<Vector2i, Vector2i, Vector2i>,
                            IUnaryNegationOperators<Vector2i, Vector2i>,
                            IUnaryPlusOperators<Vector2i, Vector2i>,
                            IMultiplyOperators<Vector2i, int, Vector2i>,
                            IMultiplyOperators<Vector2i, Vector2i, Vector2i>,
                            IDivisionOperators<Vector2i, int, Vector2i>,
                            IDivisionOperators<Vector2i, Vector2i, Vector2i>,
                            IEqualityOperators<Vector2i, Vector2i, bool>,
                            IAdditiveIdentity<Vector2i, Vector2i>,
                            IMultiplicativeIdentity<Vector2i, Vector2i>,
                            IMinMaxValue<Vector2i>
    {
        /// <summary>
        /// The X component of the Vector2i.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y component of the Vector2i.
        /// </summary>
        public int Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2i"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2i(int value)
        {
            X = value;
            Y = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2i"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector2i.</param>
        /// <param name="y">The y component of the Vector2i.</param>
        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets or sets the value at the index of the vector.
        /// </summary>
        /// <param name="index">The index of the component from the vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 1.</exception>
        public int this[int index]
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
        private static ref int GetElementUnsafe(in Vector2i v, int index)
        {
            ref int address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the manhattan length of the vector.
        /// </summary>
        public readonly int ManhattanLength => Math.Abs(X) + Math.Abs(Y);

        /// <summary>
        /// Gets the squared euclidean length of the vector.
        /// </summary>
        public readonly int EuclideanLengthSquared => (X * X) + (Y * Y);

        /// <summary>
        /// Gets the euclidean length of the vector.
        /// </summary>
        public readonly float EuclideanLength => MathF.Sqrt((X * X) + (Y * Y));

        /// <summary>
        /// Gets the perpendicular vector on the right side of this vector.
        /// </summary>
        public readonly Vector2i PerpendicularRight => new Vector2i(Y, -X);

        /// <summary>
        /// Gets the perpendicular vector on the left side of this vector.
        /// </summary>
        public readonly Vector2i PerpendicularLeft => new Vector2i(-Y, X);

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector2i Abs()
        {
            Vector2i result = this;
            result.X = Math.Abs(result.X);
            result.Y = Math.Abs(result.Y);
            return result;
        }

        /// <summary>
        /// Defines a unit-length <see cref="Vector2i"/> that points towards the X-axis.
        /// </summary>
        public static readonly Vector2i UnitX = new Vector2i(1, 0);

        /// <summary>
        /// Defines a unit-length <see cref="Vector2i"/> that points towards the Y-axis.
        /// </summary>
        public static readonly Vector2i UnitY = new Vector2i(0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector2i Zero = new Vector2i(0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector2i One = new Vector2i(1, 1);

        /// <summary>
        /// Defines the size of the <see cref="Vector2i"/> struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector2i>();

        /// <summary>
        /// Gets the additive identity of Vector2i. Equivalent to Vector2i.Zero.
        /// </summary>
        public static Vector2i AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector2i. Equivalent to Vector2i.One.
        /// </summary>
        public static Vector2i MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the maximum value for Vector2i.
        /// Sets both X and Y components to the largest value for a signed 32-bit integer.
        /// </summary>
        public static Vector2i MaxValue => new Vector2i(int.MaxValue, int.MaxValue);

        /// <summary>
        /// Gets the minimum value for Vector2i.
        /// Sets both X and Y components to the smallest value for a signed 32-bit integer.
        /// </summary>
        public static Vector2i MinValue => new Vector2i(int.MinValue, int.MinValue);

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        [Pure]
        public static Vector2i Add(Vector2i a, Vector2i b)
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
        public static void Add(in Vector2i a, in Vector2i b, out Vector2i result)
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
        public static Vector2i Subtract(Vector2i a, Vector2i b)
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
        public static void Subtract(in Vector2i a, in Vector2i b, out Vector2i result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
        }

        /// <summary>
        /// Multiplies a vector by an integer scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2i Multiply(Vector2i vector, int scale)
        {
            Multiply(in vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Multiplies a vector by an integer scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector2i vector, int scale, out Vector2i result)
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
        public static Vector2i Multiply(Vector2i vector, Vector2i scale)
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
        public static void Multiply(in Vector2i vector, in Vector2i scale, out Vector2i result)
        {
            result.X = vector.X * scale.X;
            result.Y = vector.Y * scale.Y;
        }

        /// <summary>
        /// Divides a vector by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2i Divide(Vector2i vector, int scale)
        {
            Divide(in vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divides a vector by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector2i vector, int scale, out Vector2i result)
        {
            result.X = vector.X / scale;
            result.Y = vector.Y / scale;
        }

        /// <summary>
        /// Divides a vector by the components of a vector using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector2i Divide(Vector2i vector, Vector2i scale)
        {
            Divide(in vector, in scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divides a vector by the components of a vector using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector2i vector, in Vector2i scale, out Vector2i result)
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
        public static Vector2i ComponentMin(Vector2i a, Vector2i b)
        {
            a.X = Math.Min(a.X, b.X);
            a.Y = Math.Min(a.Y, b.Y);
            return a;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector2i a, in Vector2i b, out Vector2i result)
        {
            result.X = Math.Min(a.X, b.X);
            result.Y = Math.Min(a.Y, b.Y);
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector2i ComponentMax(Vector2i a, Vector2i b)
        {
            a.X = Math.Max(a.X, b.X);
            a.Y = Math.Max(a.Y, b.Y);
            return a;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector2i a, in Vector2i b, out Vector2i result)
        {
            result.X = Math.Max(a.X, b.X);
            result.Y = Math.Max(a.Y, b.Y);
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <returns>The clamped vector.</returns>
        [Pure]
        public static Vector2i Clamp(Vector2i vec, Vector2i min, Vector2i max)
        {
            vec.X = Math.Clamp(vec.X, min.X, max.X);
            vec.Y = Math.Clamp(vec.Y, min.Y, max.Y);
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector2i vec, in Vector2i min, in Vector2i max, out Vector2i result)
        {
            result.X = Math.Clamp(vec.X, min.X, max.X);
            result.Y = Math.Clamp(vec.Y, min.Y, max.Y);
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector2i Abs(Vector2i vec)
        {
            vec.X = Math.Abs(vec.X);
            vec.Y = Math.Abs(vec.Y);
            return vec;
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector2i vec, out Vector2i result)
        {
            result.X = Math.Abs(vec.X);
            result.Y = Math.Abs(vec.Y);
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector2b LessThan(in Vector2i left, in Vector2i right)
        {
            return new Vector2b(left.X < right.X, left.Y < right.Y);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector2b LessThanOrEqual(in Vector2i left, in Vector2i right)
        {
            return new Vector2b(left.X <= right.X, left.Y <= right.Y);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector2b GreaterThan(in Vector2i left, in Vector2i right)
        {
            return new Vector2b(left.X > right.X, left.Y > right.Y);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector2b GreaterThanOrEqual(in Vector2i left, in Vector2i right)
        {
            return new Vector2b(left.X >= right.X, left.Y >= right.Y);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector2b ComponentEqual(in Vector2i left, in Vector2i right)
        {
            return new Vector2b(left.X == right.X, left.Y == right.Y);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector2b ComponentNotEqual(in Vector2i left, in Vector2i right)
        {
            return new Vector2b(left.X != right.X, left.Y != right.Y);
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yx
        {
            readonly get => new Vector2i(Y, X);
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets a <see cref="Vector2"/> object with the same component values as the <see cref="Vector2i"/> instance.
        /// </summary>
        /// <returns>The resulting <see cref="Vector3"/> instance.</returns>
        public readonly Vector2 ToVector2()
        {
            return new Vector2(X, Y);
        }

        /// <summary>
        /// Gets a <see cref="Vector2"/> object with the same component values as the <see cref="Vector2i"/> instance.
        /// </summary>
        /// <param name="input">The given <see cref="Vector2i"/> to convert.</param>
        /// <param name="result">The resulting <see cref="Vector2"/>.</param>
        public static void ToVector2(in Vector2i input, out Vector2 result)
        {
            result.X = input.X;
            result.Y = input.Y;
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector2i operator +(Vector2i left, int right)
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
        public static Vector2i operator +(int left, Vector2i right)
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
        public static Vector2i operator +(Vector2i left, Vector2i right)
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
        public static Vector2i operator -(Vector2i left, int right)
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
        public static Vector2i operator -(int left, Vector2i right)
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
        public static Vector2i operator -(Vector2i left, Vector2i right)
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
        public static Vector2i operator -(Vector2i vec)
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
        public static Vector2i operator +(Vector2i vec)
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
        public static Vector2i operator *(Vector2i vec, int scale)
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
        public static Vector2i operator *(int scale, Vector2i vec)
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
        public static Vector2i operator *(Vector2i vec, Vector2i scale)
        {
            vec.X *= scale.X;
            vec.Y *= scale.Y;
            return vec;
        }

        /// <summary>
        /// Divides the instance by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector2i operator /(Vector2i vec, int scale)
        {
            vec.X /= scale;
            vec.Y /= scale;
            return vec;
        }

        /// <summary>
        /// Divides a scalar by the instance using integer division, floor(a/b).
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector2i operator /(int left, Vector2i right)
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
        public static Vector2i operator /(Vector2i vec, Vector2i scale)
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
        public static Vector2b operator <(Vector2i left, Vector2i right)
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
        public static Vector2b operator <=(Vector2i left, Vector2i right)
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
        public static Vector2b operator >(Vector2i left, Vector2i right)
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
        public static Vector2b operator >=(Vector2i left, Vector2i right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares the specified instances for equality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector2i left, Vector2i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified instances for inequality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector2i left, Vector2i right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector2i to OpenTK.Vector2.
        /// </summary>
        /// <param name="vec">The Vector2i to convert.</param>
        /// <returns>The resulting Vector2.</returns>
        [Pure]
        public static implicit operator Vector2(Vector2i vec)
        {
            return new Vector2(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2i to OpenTK.Vector2d.
        /// </summary>
        /// <param name="vec">The Vector2i to convert.</param>
        /// <returns>The resulting Vector2d.</returns>
        [Pure]
        public static implicit operator Vector2d(Vector2i vec)
        {
            return new Vector2d(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2i to OpenTK.Vector2h.
        /// </summary>
        /// <param name="vec">The Vector2i to convert.</param>
        /// <returns>The resulting Vector2h.</returns>
        [Pure]
        public static explicit operator Vector2h(Vector2i vec)
        {
            return new Vector2h(vec.X, vec.Y);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2i"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector2i"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector2i((int X, int Y) values)
        {
            return new Vector2i(values.X, values.Y);
        }

        /// <summary>
        /// Converts <see cref="Vector2i"/> to <see cref="System.Drawing.Point"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector2i"/> to cast.</param>
        /// <returns>The resulting <see cref="System.Drawing.Point"/>.</returns>
        [Pure]
        public static explicit operator System.Drawing.Point(Vector2i vec)
        {
            return new System.Drawing.Point(vec.X, vec.Y);
        }

        /// <summary>
        /// Converts <see cref="Vector2i"/> to <see cref="System.Drawing.Size"/>.
        /// </summary>
        /// <param name="vec">The <see cref="Vector2i"/> to cast.</param>
        /// <returns>The resulting <see cref="System.Drawing.Size"/>.</returns>
        [Pure]
        public static explicit operator System.Drawing.Size(Vector2i vec)
        {
            return new System.Drawing.Size(vec.X, vec.Y);
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
                "({0}{2} {1})",
                X.ToString(format, formatProvider),
                Y.ToString(format, formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <inheritdoc/>
        public override readonly bool Equals(object obj)
        {
            return obj is Vector2i && Equals((Vector2i)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector2i other)
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
        public readonly void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}
