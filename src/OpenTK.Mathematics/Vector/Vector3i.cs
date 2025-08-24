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
    /// Represents a 3D vector using three 32-bit integer numbers.
    /// </summary>
    /// <remarks>
    /// The Vector3i structure is suitable for interoperation with unmanaged code requiring three consecutive integers.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3i : IEquatable<Vector3i>, IFormattable,
                            IAdditionOperators<Vector3i, Vector3i, Vector3i>,
                            ISubtractionOperators<Vector3i, Vector3i, Vector3i>,
                            IUnaryNegationOperators<Vector3i, Vector3i>,
                            IUnaryPlusOperators<Vector3i, Vector3i>,
                            IMultiplyOperators<Vector3i, int, Vector3i>,
                            IMultiplyOperators<Vector3i, Vector3i, Vector3i>,
                            IDivisionOperators<Vector3i, int, Vector3i>,
                            IDivisionOperators<Vector3i, Vector3i, Vector3i>,
                            IEqualityOperators<Vector3i, Vector3i, bool>,
                            IAdditiveIdentity<Vector3i, Vector3i>,
                            IMultiplicativeIdentity<Vector3i, Vector3i>,
                            IMinMaxValue<Vector3i>
    {
        /// <summary>
        /// The X component of the Vector3i.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y component of the Vector3i.
        /// </summary>
        public int Y;

        /// <summary>
        /// The Z component of the Vector3i.
        /// </summary>
        public int Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3i"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3i(int value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3i"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector3i.</param>
        /// <param name="y">The y component of the Vector3i.</param>
        /// <param name="z">The z component of the Vector3i.</param>
        public Vector3i(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3i"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector3i.</param>
        /// <param name="z">The z component of the Vector3i.</param>
        public Vector3i(Vector2i xy, int z = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        /// <summary>
        /// Gets or sets the value at the index of the vector.
        /// </summary>
        /// <param name="index">The index of the component from the vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 2.</exception>
        public int this[int index]
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
        private static ref int GetElementUnsafe(in Vector3i v, int index)
        {
            ref int address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the manhattan length of the vector.
        /// </summary>
        public readonly int ManhattanLength => Math.Abs(X) + Math.Abs(Y) + Math.Abs(Z);

        /// <summary>
        /// Gets the squared euclidean length of the vector.
        /// </summary>
        public readonly int EuclideanLengthSquared => (X * X) + (Y * Y) + (Z * Z);

        /// <summary>
        /// Gets the euclidean length of the vector.
        /// </summary>
        public readonly float EuclideanLength => MathF.Sqrt((X * X) + (Y * Y) + (Z * Z));

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector3i Abs()
        {
            Vector3i result = this;
            result.X = Math.Abs(result.X);
            result.Y = Math.Abs(result.Y);
            result.Z = Math.Abs(result.Z);
            return result;
        }

        /// <summary>
        /// Defines a unit-length Vector3i that points towards the X-axis.
        /// </summary>
        public static readonly Vector3i UnitX = new Vector3i(1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector3i that points towards the Y-axis.
        /// </summary>
        public static readonly Vector3i UnitY = new Vector3i(0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector3i that points towards the Z-axis.
        /// </summary>
        public static readonly Vector3i UnitZ = new Vector3i(0, 0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector3i Zero = new Vector3i(0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector3i One = new Vector3i(1, 1, 1);

        /// <summary>
        /// Defines the size of the Vector3i struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector3i>();

        /// <summary>
        /// Gets the additive identity of Vector3i. Equivalent to Vector3i.Zero.
        /// </summary>
        public static Vector3i AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector3i. Equivalent to Vector3i.One.
        /// </summary>
        public static Vector3i MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the maximum value for Vector3i.
        /// Sets X, Y, and Z components to the largest value for a signed 32-bit integer.
        /// </summary>
        public static Vector3i MaxValue => new Vector3i(int.MaxValue, int.MaxValue, int.MaxValue);

        /// <summary>
        /// Gets the minimum value for Vector3i.
        /// Sets X, Y, and Z components to the smallest value for a signed 32-bit integer.
        /// </summary>
        public static Vector3i MinValue => new Vector3i(int.MinValue, int.MinValue, int.MinValue);

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        [Pure]
        public static Vector3i Add(Vector3i a, Vector3i b)
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
        public static void Add(in Vector3i a, in Vector3i b, out Vector3i result)
        {
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;
        }

        /// <summary>
        /// Subtract one vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector3i Subtract(Vector3i a, Vector3i b)
        {
            Subtract(in a, in b, out a);
            return a;
        }

        /// <summary>
        /// Subtract one vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">Result of subtraction.</param>
        public static void Subtract(in Vector3i a, in Vector3i b, out Vector3i result)
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
        public static Vector3i Multiply(Vector3i vector, int scale)
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
        public static void Multiply(in Vector3i vector, int scale, out Vector3i result)
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
        public static Vector3i Multiply(Vector3i vector, Vector3i scale)
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
        public static void Multiply(in Vector3i vector, in Vector3i scale, out Vector3i result)
        {
            result.X = vector.X * scale.X;
            result.Y = vector.Y * scale.Y;
            result.Z = vector.Z * scale.Z;
        }

        /// <summary>
        /// Divides a vector by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3i Divide(Vector3i vector, int scale)
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
        public static void Divide(in Vector3i vector, int scale, out Vector3i result)
        {
            result.X = vector.X / scale;
            result.Y = vector.Y / scale;
            result.Z = vector.Z / scale;
        }

        /// <summary>
        /// Divides a vector by the components of a vector using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector3i Divide(Vector3i vector, Vector3i scale)
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
        public static void Divide(in Vector3i vector, in Vector3i scale, out Vector3i result)
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
        public static Vector3i ComponentMin(Vector3i a, Vector3i b)
        {
            Vector3i result;
            result.X = Math.Min(a.X, b.X);
            result.Y = Math.Min(a.Y, b.Y);
            result.Z = Math.Min(a.Z, b.Z);
            return result;
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector3i a, in Vector3i b, out Vector3i result)
        {
            result.X = Math.Min(a.X, b.X);
            result.Y = Math.Min(a.Y, b.Y);
            result.Z = Math.Min(a.Z, b.Z);
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector3i ComponentMax(Vector3i a, Vector3i b)
        {
            Vector3i result;
            result.X = Math.Max(a.X, b.X);
            result.Y = Math.Max(a.Y, b.Y);
            result.Z = Math.Max(a.Z, b.Z);
            return result;
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector3i a, in Vector3i b, out Vector3i result)
        {
            result.X = Math.Max(a.X, b.X);
            result.Y = Math.Max(a.Y, b.Y);
            result.Z = Math.Max(a.Z, b.Z);
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <returns>The clamped vector.</returns>
        [Pure]
        public static Vector3i Clamp(Vector3i vec, Vector3i min, Vector3i max)
        {
            Vector3i result;
            result.X = Math.Clamp(vec.X, min.X, max.X);
            result.Y = Math.Clamp(vec.Y, min.Y, max.Y);
            result.Z = Math.Clamp(vec.Z, min.Z, max.Z);
            return result;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector3i vec, in Vector3i min, in Vector3i max, out Vector3i result)
        {
            result.X = Math.Clamp(vec.X, min.X, max.X);
            result.Y = Math.Clamp(vec.Y, min.Y, max.Y);
            result.Z = Math.Clamp(vec.Z, min.Z, max.Z);
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector3i Abs(Vector3i vec)
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
        public static void Abs(in Vector3i vec, out Vector3i result)
        {
            result.X = Math.Abs(vec.X);
            result.Y = Math.Abs(vec.Y);
            result.Z = Math.Abs(vec.Z);
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector3b LessThan(in Vector3i left, in Vector3i right)
        {
            return new Vector3b(left.X < right.X, left.Y < right.Y, left.Z < right.Z);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector3b LessThanOrEqual(in Vector3i left, in Vector3i right)
        {
            return new Vector3b(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector3b GreaterThan(in Vector3i left, in Vector3i right)
        {
            return new Vector3b(left.X > right.X, left.Y > right.Y, left.Z > right.Z);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector3b GreaterThanOrEqual(in Vector3i left, in Vector3i right)
        {
            return new Vector3b(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector3b ComponentEqual(in Vector3i left, in Vector3i right)
        {
            return new Vector3b(left.X == right.X, left.Y == right.Y, left.Z == right.Z);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector3b ComponentNotEqual(in Vector3i left, in Vector3i right)
        {
            return new Vector3b(left.X != right.X, left.Y != right.Y, left.Z != right.Z);
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Xy
        {
            readonly get => new Vector2i(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Xz
        {
            readonly get => new Vector2i(X, Z);
            set
            {
                X = value.X;
                Z = value.Y;
            }
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
        /// Gets or sets a <see cref="Vector2i"/> with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yz
        {
            readonly get => new Vector2i(Y, Z);
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zx
        {
            readonly get => new Vector2i(Z, X);
            set
            {
                Z = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zy
        {
            readonly get => new Vector2i(Z, Y);
            set
            {
                Z = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xzy
        {
            readonly get => new Vector3i(X, Z, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yxz
        {
            readonly get => new Vector3i(Y, X, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yzx
        {
            readonly get => new Vector3i(Y, Z, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zxy
        {
            readonly get => new Vector3i(Z, X, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zyx
        {
            readonly get => new Vector3i(Z, Y, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets a <see cref="Vector3"/> object with the same component values as the <see cref="Vector3i"/> instance.
        /// </summary>
        /// <returns>The resulting <see cref="Vector3"/> instance.</returns>
        public readonly Vector3 ToVector3()
        {
            return new Vector3(X, Y, Z);
        }

        /// <summary>
        /// Gets a <see cref="Vector3"/> object with the same component values as the <see cref="Vector3i"/> instance.
        /// </summary>
        /// <param name="input">The given <see cref="Vector3i"/> to convert.</param>
        /// <param name="result">The resulting <see cref="Vector3"/>.</param>
        public static void ToVector3(in Vector3i input, out Vector3 result)
        {
            result.X = input.X;
            result.Y = input.Y;
            result.Z = input.Z;
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector3i operator +(Vector3i left, int right)
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
        public static Vector3i operator +(int left, Vector3i right)
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
        public static Vector3i operator +(Vector3i left, Vector3i right)
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
        public static Vector3i operator -(Vector3i left, int right)
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
        public static Vector3i operator -(int left, Vector3i right)
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
        public static Vector3i operator -(Vector3i left, Vector3i right)
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
        public static Vector3i operator -(Vector3i vec)
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
        public static Vector3i operator +(Vector3i vec)
        {
            vec.X = +vec.X;
            vec.Y = +vec.Y;
            vec.Z = +vec.Z;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by an integer scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3i operator *(Vector3i vec, int scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by an integer scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector3i operator *(int scale, Vector3i vec)
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
        public static Vector3i operator *(Vector3i vec, Vector3i scale)
        {
            vec.X *= scale.X;
            vec.Y *= scale.Y;
            vec.Z *= scale.Z;
            return vec;
        }

        /// <summary>
        /// Divides the instance by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3i operator /(Vector3i vec, int scale)
        {
            vec.X /= scale;
            vec.Y /= scale;
            vec.Z /= scale;
            return vec;
        }

        /// <summary>
        /// Divides a scalar by the instance using integer division, floor(a/b).
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector3i operator /(int left, Vector3i right)
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
        public static Vector3i operator /(Vector3i vec, Vector3i scale)
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
        public static Vector3b operator <(Vector3i left, Vector3i right)
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
        public static Vector3b operator <=(Vector3i left, Vector3i right)
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
        public static Vector3b operator >(Vector3i left, Vector3i right)
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
        public static Vector3b operator >=(Vector3i left, Vector3i right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector3i left, Vector3i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Vector3i left, Vector3i right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector3i to OpenTK.Vector3.
        /// </summary>
        /// <param name="vec">The Vector3i to convert.</param>
        /// <returns>The resulting Vector3.</returns>
        [Pure]
        public static implicit operator Vector3(Vector3i vec)
        {
            return new Vector3(vec.X, vec.Y, vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3i to OpenTK.Vector3d.
        /// </summary>
        /// <param name="vec">The Vector3i to convert.</param>
        /// <returns>The resulting Vector3d.</returns>
        [Pure]
        public static implicit operator Vector3d(Vector3i vec)
        {
            return new Vector3d(vec.X, vec.Y, vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3i to OpenTK.Vector3h.
        /// </summary>
        /// <param name="vec">The Vector3i to convert.</param>
        /// <returns>The resulting Vector3h.</returns>
        [Pure]
        public static explicit operator Vector3h(Vector3i vec)
        {
            return new Vector3h(vec.X, vec.Y, vec.Z);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3i"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector3i"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector3i((int X, int Y, int Z) values)
        {
            return new Vector3i(values.X, values.Y, values.Z);
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
            return obj is Vector3i && Equals((Vector3i)obj);
        }

        /// <inheritdoc />
        public readonly bool Equals(Vector3i other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Z == other.Z;
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
        public readonly void Deconstruct(out int x, out int y, out int z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
