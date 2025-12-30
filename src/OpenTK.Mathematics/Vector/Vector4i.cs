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
using System.Runtime.Intrinsics;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 4D vector using four 32-bit integer numbers.
    /// </summary>
    /// <remarks>
    /// The Vector4i structure is suitable for interoperation with unmanaged code requiring four consecutive integers.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4i : IEquatable<Vector4i>, IFormattable,
                            IAdditionOperators<Vector4i, Vector4i, Vector4i>,
                            ISubtractionOperators<Vector4i, Vector4i, Vector4i>,
                            IUnaryNegationOperators<Vector4i, Vector4i>,
                            IUnaryPlusOperators<Vector4i, Vector4i>,
                            IMultiplyOperators<Vector4i, int, Vector4i>,
                            IMultiplyOperators<Vector4i, Vector4i, Vector4i>,
                            IDivisionOperators<Vector4i, int, Vector4i>,
                            IDivisionOperators<Vector4i, Vector4i, Vector4i>,
                            IEqualityOperators<Vector4i, Vector4i, bool>,
                            IAdditiveIdentity<Vector4i, Vector4i>,
                            IMultiplicativeIdentity<Vector4i, Vector4i>,
                            IMinMaxValue<Vector4i>
    {
        /// <summary>
        /// The X component of the Vector4i.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y component of the Vector4i.
        /// </summary>
        public int Y;

        /// <summary>
        /// The Z component of the Vector4i.
        /// </summary>
        public int Z;

        /// <summary>
        /// The W component of the Vector4i.
        /// </summary>
        public int W;

        /// <summary>
        /// Defines a unit-length <see cref="Vector4i"/> that points towards the X-axis.
        /// </summary>
        public static readonly Vector4i UnitX = new Vector4i(1, 0, 0, 0);

        /// <summary>
        /// Defines a unit-length <see cref="Vector4i"/> that points towards the Y-axis.
        /// </summary>
        public static readonly Vector4i UnitY = new Vector4i(0, 1, 0, 0);

        /// <summary>
        /// Defines a unit-length <see cref="Vector4i"/> that points towards the Z-axis.
        /// </summary>
        public static readonly Vector4i UnitZ = new Vector4i(0, 0, 1, 0);

        /// <summary>
        /// Defines a unit-length <see cref="Vector4i"/> that points towards the W-axis.
        /// </summary>
        public static readonly Vector4i UnitW = new Vector4i(0, 0, 0, 1);

        /// <summary>
        /// Defines an instance with all components set to 0.
        /// </summary>
        public static readonly Vector4i Zero = new Vector4i(0, 0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4i One = new Vector4i(1, 1, 1, 1);

        /// <summary>
        /// Defines the size of the <see cref="Vector4i"/> struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector4i>();

        /// <summary>
        /// Gets the additive identity of Vector4i. Equivalent to Vector4i.Zero.
        /// </summary>
        public static Vector4i AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of Vector4i. Equivalent to Vector4i.One.
        /// </summary>
        public static Vector4i MultiplicativeIdentity => One;

        /// <summary>
        /// Gets the maximum value for Vector4i.
        /// Sets X, Y, Z, and W components to the largest value for a signed 32-bit integer.
        /// </summary>
        public static Vector4i MaxValue => new Vector4i(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);

        /// <summary>
        /// Gets the minimum value for Vector4i.
        /// Sets X, Y, Z, and W components to the smallest value for a signed 32-bit integer.
        /// </summary>
        public static Vector4i MinValue => new Vector4i(int.MinValue, int.MinValue, int.MinValue, int.MinValue);

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4i"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4i(int value)
        {
            this = Vector128.Create(value).AsVector4iOtk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4i"/> struct.
        /// </summary>
        /// <param name="x">The X component of the Vector4i.</param>
        /// <param name="y">The Y component of the Vector4i.</param>
        /// <param name="z">The Z component of the Vector4i.</param>
        /// <param name="w">The W component of the Vector4i.</param>
        public Vector4i(int x, int y, int z, int w)
        {
            this = Vector128.Create(x, y, z, w).AsVector4iOtk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4i"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector4i.</param>
        /// <param name="z">The z component of the Vector4i.</param>
        /// <param name="w">The w component of the Vector4i.</param>
        public Vector4i(Vector2i xy, int z = default, int w = default)
        {
            this = Vector128.Create(xy.X, xy.Y, z, w).AsVector4iOtk();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4i"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y and z components of the Vector4i.</param>
        /// <param name="w">The w component of the Vector4i.</param>
        public Vector4i(Vector3i xyz, int w = default)
        {
            this = Vector128.Create(xyz.X, xyz.Y, xyz.Z, w).AsVector4iOtk();
        }

        /// <summary>
        /// Gets or sets the value at the index of the vector.
        /// </summary>
        /// <param name="index">The index of the component from the vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 3.</exception>
        public int this[int index]
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
        private static ref int GetElementUnsafe(in Vector4i v, int index)
        {
            ref int address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Gets the manhattan length of the vector.
        /// </summary>
        public readonly int ManhattanLength
        {
            get
            {
                var a = Abs(this);
                return Sum(a);
            }
        }

        /// <summary>
        /// Gets the squared euclidean length of the vector.
        /// </summary>
        public readonly int EuclideanLengthSquared => Dot(this, this);

        /// <summary>
        /// Gets the euclidean length of the vector.
        /// </summary>
        public readonly float EuclideanLength => MathF.Sqrt(EuclideanLengthSquared);

        /// <summary>
        /// Returns a new vector that is the component-wise absolute value of the vector.
        /// </summary>
        /// <returns>The component-wise absolute value vector.</returns>
        public readonly Vector4i Abs()
        {
            return Abs(this);
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        [Pure]
        public static Vector4i Add(Vector4i a, Vector4i b)
        {
            return (a.AsVector128() + b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <param name="result">Result of operation.</param>
        public static void Add(in Vector4i a, in Vector4i b, out Vector4i result)
        {
            result = (a.AsVector128() + b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>Result of the subtraction.</returns>
        [Pure]
        public static Vector4i Subtract(Vector4i a, Vector4i b)
        {
            return (a.AsVector128() - b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Subtract one Vector from another.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">Result of subtraction.</param>
        public static void Subtract(in Vector4i a, in Vector4i b, out Vector4i result)
        {
            result = (a.AsVector128() - b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Multiplies a vector by an integer scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4i Multiply(Vector4i vector, int scale)
        {
            return (vector.AsVector128() * scale).AsVector4iOtk();
        }

        /// <summary>
        /// Multiplies a vector by an integer scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector4i vector, int scale, out Vector4i result)
        {
            result = (vector.AsVector128() * scale).AsVector4iOtk();
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4i Multiply(Vector4i vector, Vector4i scale)
        {
            return (vector.AsVector128() * scale.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Multiplies a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(in Vector4i vector, in Vector4i scale, out Vector4i result)
        {
            result = (vector.AsVector128() * scale.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Divides a vector by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4i Divide(Vector4i vector, int scale)
        {
            return (vector.AsVector128() / scale).AsVector4iOtk();
        }

        /// <summary>
        /// Divides a vector by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector4i vector, int scale, out Vector4i result)
        {
            result = (vector.AsVector128() / scale).AsVector4iOtk();
        }

        /// <summary>
        /// Divides a vector by the components of a vector using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        [Pure]
        public static Vector4i Divide(Vector4i vector, Vector4i scale)
        {
            return (vector.AsVector128() / scale.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Divides a vector by the components of a vector using integer division, floor(a/b).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(in Vector4i vector, in Vector4i scale, out Vector4i result)
        {
            result = (vector.AsVector128() / scale.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise minimum.</returns>
        [Pure]
        public static Vector4i ComponentMin(Vector4i a, Vector4i b)
        {
            return Vector128.Min(a.AsVector128(), b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Returns a vector created from the smallest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise minimum.</param>
        public static void ComponentMin(in Vector4i a, in Vector4i b, out Vector4i result)
        {
            result = Vector128.Min(a.AsVector128(), b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <returns>The component-wise maximum.</returns>
        [Pure]
        public static Vector4i ComponentMax(Vector4i a, Vector4i b)
        {
            return Vector128.Max(a.AsVector128(), b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Returns a vector created from the largest of the corresponding components of the given vectors.
        /// </summary>
        /// <param name="a">First operand.</param>
        /// <param name="b">Second operand.</param>
        /// <param name="result">The component-wise maximum.</param>
        public static void ComponentMax(in Vector4i a, in Vector4i b, out Vector4i result)
        {
            result = Vector128.Max(a.AsVector128(), b.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <returns>The clamped vector.</returns>
        [Pure]
        public static Vector4i Clamp(Vector4i vec, Vector4i min, Vector4i max)
        {
            return Vector128.Clamp(vec.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors.
        /// </summary>
        /// <param name="vec">Input vector.</param>
        /// <param name="min">Minimum vector.</param>
        /// <param name="max">Maximum vector.</param>
        /// <param name="result">The clamped vector.</param>
        public static void Clamp(in Vector4i vec, in Vector4i min, in Vector4i max, out Vector4i result)
        {
            result = Vector128.Clamp(vec.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <returns>The component-wise absolute value vector.</returns>
        public static Vector4i Abs(Vector4i vec)
        {
            return Vector128.Abs(vec.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Take the component-wise absolute value of a vector.
        /// </summary>
        /// <param name="vec">The vector to apply component-wise absolute value to.</param>
        /// <param name="result">The component-wise absolute value vector.</param>
        public static void Abs(in Vector4i vec, out Vector4i result)
        {
            result = Vector128.Abs(vec.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Calculate the dot product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        public static int Dot(Vector4i left, Vector4i right)
        {
            return Vector128.Dot(left.AsVector128(), right.AsVector128());
        }

        /// <summary>
        /// Calculate the dot product of two vectors.
        /// </summary>
        /// <param name="left">First operand.</param>
        /// <param name="right">Second operand.</param>
        /// <returns>The dot product of the two inputs.</returns>
        public static int Dot(in Vector4i left, in Vector4i right)
        {
            return Vector128.Dot(left.AsVector128(), right.AsVector128());
        }

        /// <summary>
        /// Calculate the sum of the elements of the vector.
        /// </summary>
        /// <param name="vec">The vector whose elements will be summed.</param>
        /// <returns>The sum of the components.</returns>
        public static int Sum(Vector4i vec)
        {
            return Vector128.Sum(vec.AsVector128());
        }

        /// <summary>
        /// Calculate the sum of the elements of the vector.
        /// </summary>
        /// <param name="vec">The vector whose elements will be summed.</param>
        /// <returns>The sum of the components.</returns>
        public static int Sum(in Vector4i vec)
        {
            return Vector128.Sum(vec.AsVector128());
        }

        /// <summary>
        /// Component wise less than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        public static Vector4b LessThan(in Vector4i left, in Vector4i right)
        {
            return new Vector4b(left.X < right.X, left.Y < right.Y, left.Z < right.Z, left.W < right.W);
        }

        /// <summary>
        /// Component wise less than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than or equal to the right component.</returns>
        public static Vector4b LessThanOrEqual(in Vector4i left, in Vector4i right)
        {
            return new Vector4b(left.X <= right.X, left.Y <= right.Y, left.Z <= right.Z, left.W <= right.W);
        }

        /// <summary>
        /// Component wise greater than comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than the right component.</returns>
        public static Vector4b GreaterThan(in Vector4i left, in Vector4i right)
        {
            return new Vector4b(left.X > right.X, left.Y > right.Y, left.Z > right.Z, left.W > right.W);
        }

        /// <summary>
        /// Component wise greater than or equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is greater than or equal to the right component.</returns>
        public static Vector4b GreaterThanOrEqual(in Vector4i left, in Vector4i right)
        {
            return new Vector4b(left.X >= right.X, left.Y >= right.Y, left.Z >= right.Z, left.W >= right.W);
        }

        /// <summary>
        /// Component wise equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is equal to the right component.</returns>
        public static Vector4b ComponentEqual(in Vector4i left, in Vector4i right)
        {
            return new Vector4b(left.X == right.X, left.Y == right.Y, left.Z == right.Z, left.W == right.W);
        }

        /// <summary>
        /// Component wise not equal comparision of two vectors.
        /// </summary>
        /// <param name="left">The left vector.</param>
        /// <param name="right">The right vector.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is not equal to the right component.</returns>
        public static Vector4b ComponentNotEqual(in Vector4i left, in Vector4i right)
        {
            return new Vector4b(left.X != right.X, left.Y != right.Y, left.Z != right.Z, left.W != right.W);
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
        /// Gets or sets a <see cref="Vector2i"/> with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Xw
        {
            readonly get => new Vector2i(X, W);
            set
            {
                X = value.X;
                W = value.Y;
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
        /// Gets or sets a <see cref="Vector2i"/> with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yw
        {
            readonly get => new Vector2i(Y, W);
            set
            {
                Y = value.X;
                W = value.Y;
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
        /// Gets or sets a <see cref="Vector2i"/> with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zw
        {
            readonly get => new Vector2i(Z, W);
            set
            {
                Z = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Wx
        {
            readonly get => new Vector2i(W, X);
            set
            {
                W = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Wy
        {
            readonly get => new Vector2i(W, Y);
            set
            {
                W = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector2i"/> with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Wz
        {
            readonly get => new Vector2i(W, Z);
            set
            {
                W = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xyz
        {
            readonly get => new Vector3i(X, Y, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xyw
        {
            readonly get => new Vector3i(X, Y, W);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
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
        /// Gets or sets a <see cref="Vector3i"/> with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xzw
        {
            readonly get => new Vector3i(X, Z, W);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xwy
        {
            readonly get => new Vector3i(X, W, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xwz
        {
            readonly get => new Vector3i(X, W, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets a <see cref="Vector3i"/> with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yxw
        {
            readonly get => new Vector3i(Y, X, W);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets a <see cref="Vector3i"/> with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yzw
        {
            readonly get => new Vector3i(Y, Z, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Ywx
        {
            readonly get => new Vector3i(Y, W, X);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Ywz
        {
            readonly get => new Vector3i(Y, W, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets a <see cref="Vector3i"/> with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zxw
        {
            readonly get => new Vector3i(Z, X, W);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets a <see cref="Vector3i"/> with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zyw
        {
            readonly get => new Vector3i(Z, Y, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zwx
        {
            readonly get => new Vector3i(Z, W, X);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zwy
        {
            readonly get => new Vector3i(Z, W, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wxy
        {
            readonly get => new Vector3i(W, X, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wxz
        {
            readonly get => new Vector3i(W, X, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wyx
        {
            readonly get => new Vector3i(W, Y, X);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wyz
        {
            readonly get => new Vector3i(W, Y, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wzx
        {
            readonly get => new Vector3i(W, Z, X);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector3i"/> with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wzy
        {
            readonly get => new Vector3i(W, Z, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xywz
        {
            readonly get => new Vector4i(X, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xzyw
        {
            readonly get => new Vector4i(X, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xzwy
        {
            readonly get => new Vector4i(X, Z, W, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xwyz
        {
            readonly get => new Vector4i(X, W, Y, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xwzy
        {
            readonly get => new Vector4i(X, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yxzw
        {
            readonly get => new Vector4i(Y, X, Z, W);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yxwz
        {
            readonly get => new Vector4i(Y, X, W, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yyzw
        {
            readonly get => new Vector4i(Y, Y, Z, W);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yywz
        {
            readonly get => new Vector4i(Y, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yzxw
        {
            readonly get => new Vector4i(Y, Z, X, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yzwx
        {
            readonly get => new Vector4i(Y, Z, W, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Ywxz
        {
            readonly get => new Vector4i(Y, W, X, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Ywzx
        {
            readonly get => new Vector4i(Y, W, Z, X);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zxyw
        {
            readonly get => new Vector4i(Z, X, Y, W);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zxwy
        {
            readonly get => new Vector4i(Z, X, W, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zyxw
        {
            readonly get => new Vector4i(Z, Y, X, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zywx
        {
            readonly get => new Vector4i(Z, Y, W, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zwxy
        {
            readonly get => new Vector4i(Z, W, X, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zwyx
        {
            readonly get => new Vector4i(Z, W, Y, X);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zwzy
        {
            readonly get => new Vector4i(Z, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wxyz
        {
            readonly get => new Vector4i(W, X, Y, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wxzy
        {
            readonly get => new Vector4i(W, X, Z, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wyxz
        {
            readonly get => new Vector4i(W, Y, X, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wyzx
        {
            readonly get => new Vector4i(W, Y, Z, X);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wzxy
        {
            readonly get => new Vector4i(W, Z, X, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wzyx
        {
            readonly get => new Vector4i(W, Z, Y, X);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="Vector4i"/> with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wzyw
        {
            readonly get => new Vector4i(W, Z, Y, W);
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
        public static Vector4i operator +(Vector4i left, int right)
        {
            return (left.AsVector128() + Vector128.Create(right)).AsVector4iOtk();
        }

        /// <summary>
        /// Adds a scalar to an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4i operator +(int left, Vector4i right)
        {
            return (Vector128.Create(left) + right.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4i operator +(Vector4i left, Vector4i right)
        {
            return (left.AsVector128() + right.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Subtracts an instance by a scalar.
        /// </summary>
        /// <param name="left">The instance.</param>
        /// <param name="right">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4i operator -(Vector4i left, int right)
        {
            return (left.AsVector128() - Vector128.Create(right)).AsVector4iOtk();
        }

        /// <summary>
        /// Subtracts a scalar by an instance.
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Vector4i operator -(int left, Vector4i right)
        {
            return (Vector128.Create(left) - right.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4i operator -(Vector4i left, Vector4i right)
        {
            return (left.AsVector128() - right.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4i operator -(Vector4i vec)
        {
            return (-vec.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Computes the unary plus of the vector.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4i operator +(Vector4i vec)
        {
            return (+vec.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Multiplies an instance by an integer scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4i operator *(Vector4i vec, int scale)
        {
            return (vec.AsVector128() * Vector128.Create(scale)).AsVector4iOtk();
        }

        /// <summary>
        /// Multiplies an instance by an integer scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Vector4i operator *(int scale, Vector4i vec)
        {
            return (Vector128.Create(scale) * vec.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Component-wise multiplication between the specified instance by a scale vector.
        /// </summary>
        /// <param name="scale">Left operand.</param>
        /// <param name="vec">Right operand.</param>
        /// <returns>Result of the multiplication.</returns>
        [Pure]
        public static Vector4i operator *(Vector4i vec, Vector4i scale)
        {
            return (vec.AsVector128() * scale.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Divides the instance by a scalar using integer division, floor(a/b).
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4i operator /(Vector4i vec, int scale)
        {
            return (vec.AsVector128() / Vector128.Create(scale)).AsVector4iOtk();
        }

        /// <summary>
        /// Divides a scalar by the instance using integer division, floor(a/b).
        /// </summary>
        /// <param name="left">The scalar.</param>
        /// <param name="right">The instance.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4i operator /(int left, Vector4i right)
        {
            return (Vector128.Create(left) / right.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Component-wise division between the specified instance by a scale vector.
        /// </summary>
        /// <param name="vec">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the division.</returns>
        [Pure]
        public static Vector4i operator /(Vector4i vec, Vector4i scale)
        {
            return (vec.AsVector128() / scale.AsVector128()).AsVector4iOtk();
        }

        /// <summary>
        /// Component wise less than comparision between the specified instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>A component wise boolean vector whose compoennts are true when the corresponding left component is less than the right component.</returns>
        [Pure]
        public static Vector4b operator <(Vector4i left, Vector4i right)
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
        public static Vector4b operator <=(Vector4i left, Vector4i right)
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
        public static Vector4b operator >(Vector4i left, Vector4i right)
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
        public static Vector4b operator >=(Vector4i left, Vector4i right)
        {
            return GreaterThanOrEqual(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector4i left, Vector4i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector4i left, Vector4i right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Converts OpenTK.Vector4i to OpenTK.Vector4.
        /// </summary>
        /// <param name="vec">The Vector4i to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        [Pure]
        public static implicit operator Vector4(Vector4i vec)
        {
            return Vector128.ConvertToSingle(vec.AsVector128()).AsVector4Otk();
        }

        /// <summary>
        /// Converts OpenTK.Vector4i to OpenTK.Vector4d.
        /// </summary>
        /// <param name="vec">The Vector4i to convert.</param>
        /// <returns>The resulting Vector4d.</returns>
        [Pure]
        public static implicit operator Vector4d(Vector4i vec)
        {
            return VectorExtensions.ConvertToVector256Double(vec.AsVector128()).AsVector4dOtk();
        }

        /// <summary>
        /// Converts OpenTK.Vector4i to OpenTK.Vector4h.
        /// </summary>
        /// <param name="vec">The Vector4i to convert.</param>
        /// <returns>The resulting Vector4h.</returns>
        [Pure]
        public static explicit operator Vector4h(Vector4i vec)
        {
            return new Vector4h(vec.X, vec.Y, vec.Z, vec.W);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4i"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector4i"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector4i((int X, int Y, int Z, int W) values)
        {
            return new Vector4i(values.X, values.Y, values.Z, values.W);
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
            return obj is Vector4i && Equals((Vector4i)obj);
        }

        /// <inheritdoc />
        public readonly bool Equals(Vector4i other)
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
        public readonly void Deconstruct(out int x, out int y, out int z, out int w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
    }
}
