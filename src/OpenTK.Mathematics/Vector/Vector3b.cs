using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 2D boolean vector.
    /// </summary>
    /// <remarks>
    /// As bools in C# are not blittable this type is not necessarily suitable for interoperation with unmanaged code.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3b : IEquatable<Vector3b>
    {
        /// <summary>
        /// The X component of the vector.
        /// </summary>
        public bool X;

        /// <summary>
        /// The Y component of the vector.
        /// </summary>
        public bool Y;

        /// <summary>
        /// The Z component of the vector.
        /// </summary>
        public bool Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3b"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3b(bool value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3b"/> struct.
        /// </summary>
        /// <param name="x">The x component of the <see cref="Vector3b"/>.</param>
        /// <param name="y">The y component of the <see cref="Vector3b"/>.</param>
        /// <param name="z">The z component of the <see cref="Vector3b"/>.</param>
        public Vector3b(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3b"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector3b.</param>
        /// <param name="z">The z component of the Vector3b.</param>
        public Vector3b(Vector2b xy, bool z = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3b"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y, and z components of the <see cref="Vector3b"/>.</param>
        public Vector3b(Vector3b xyz)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3b"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y, and z components of the <see cref="Vector3b"/>.</param>
        public Vector3b(Vector4b xyz)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        /// <summary>
        /// Gets or sets the value at the index of the vector.
        /// </summary>
        /// <param name="index">The index of the component from the vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 2.</exception>
        public bool this[int index]
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
        private static ref bool GetElementUnsafe(in Vector3b v, int index)
        {
            ref bool address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Returns the logical negation of this vector.
        /// </summary>
        /// <returns>A vector with each component negated.</returns>
        public readonly Vector3b Not()
        {
            return new Vector3b(!X, !Y, !Z);
        }

        /// <summary>
        /// Returns <see langword="true"/> if all components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <returns>If all of the components of the vector were <see langword="true"/>.</returns>
        public readonly bool All()
        {
            return X && Y && Z;
        }

        /// <summary>
        /// Returns <see langword="true"/> if any component of the vector is <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <returns>If any of the components of the vector were <see langword="true"/>.</returns>
        public readonly bool Any()
        {
            return X || Y || Z;
        }

        /// <summary>
        /// Defines an instance with only the X components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector3b UnitX = new Vector3b(true, false, false);

        /// <summary>
        /// Defines an instance with only the Y components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector3b UnitY = new Vector3b(false, true, false);

        /// <summary>
        /// Defines an instance with only the Z components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector3b UnitZ = new Vector3b(false, false, true);

        /// <summary>
        /// Defines an instance with all components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector3b True = new Vector3b(true, true, true);

        /// <summary>
        /// Defines an instance with all components set to <see langword="false"/>.
        /// </summary>
        public static readonly Vector3b False = new Vector3b(false, false, false);

        /// <summary>
        /// Returns <see langword="true"/> if all components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="vector">The vector to check if all components are <see langword="true"/>.</param>
        /// <returns>If all of the components of the vector were <see langword="true"/>.</returns>
        public static bool All(Vector3b vector)
        {
            return vector.X && vector.Y && vector.Z;
        }

        /// <summary>
        /// Returns <see langword="true"/> if any components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="vector">The vector to check if any components are <see langword="true"/>.</param>
        /// <returns>If any of the components of the vector were <see langword="true"/>.</returns>
        public static bool Any(Vector3b vector)
        {
            return vector.X || vector.Y || vector.Z;
        }

        /// <summary>
        /// Returns the logical negation of a vector.
        /// </summary>
        /// <param name="vec">The vector to logically negate.</param>
        /// <returns>A vector with each component negated.</returns>
        public static Vector3b Not(Vector3b vec)
        {
            return new Vector3b(!vec.X, !vec.Y, !vec.Z);
        }

        /// <summary>
        /// Returns the component-wise logical and of two vectors.
        /// </summary>
        /// <param name="left">The first vector to and.</param>
        /// <param name="right">The second vector to and.</param>
        /// <returns>A vector were each component is the logical and of the input vector components.</returns>
        public static Vector3b And(Vector3b left, Vector3b right)
        {
            return new Vector3b(left.X & right.X, left.Y & right.Y, left.Z & right.Z);
        }

        /// <summary>
        /// Returns the component-wise logical or of two vectors.
        /// </summary>
        /// <param name="left">The first vector to or.</param>
        /// <param name="right">The second vector to or.</param>
        /// <returns>A vector were each component is the logical or of the input vector components.</returns>
        public static Vector3b Or(Vector3b left, Vector3b right)
        {
            return new Vector3b(left.X | right.X, left.Y | right.Y, left.Z | right.Z);
        }

        /// <summary>
        /// Returns the component-wise logical xor of two vectors.
        /// </summary>
        /// <param name="left">The first vector to xor.</param>
        /// <param name="right">The second vector to xor.</param>
        /// <returns>A vector were each component is the logical xor of the input vector components.</returns>
        public static Vector3b Xor(Vector3b left, Vector3b right)
        {
            return new Vector3b(left.X ^ right.X, left.Y ^ right.Y, left.Z ^ right.Z);
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Xy
        {
            get => Unsafe.As<Vector3b, Vector2b>(ref this);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Xz
        {
            readonly get => new Vector2b(X, Z);
            set
            {
                X = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Yx
        {
            readonly get => new Vector2b(Y, X);
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Yz
        {
            readonly get => new Vector2b(Y, Z);
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Zx
        {
            readonly get => new Vector2b(Z, X);
            set
            {
                Z = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Zy
        {
            readonly get => new Vector2b(Z, Y);
            set
            {
                Z = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Xzy
        {
            readonly get => new Vector3b(X, Z, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Yxz
        {
            readonly get => new Vector3b(Y, X, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Yzx
        {
            readonly get => new Vector3b(Y, Z, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Zxy
        {
            readonly get => new Vector3b(Z, X, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Zyx
        {
            readonly get => new Vector3b(Z, Y, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Negates the specified instance.
        /// </summary>
        /// <param name="vector">Operand.</param>
        /// <returns>Result of negation.</returns>
        public static Vector3b operator !(Vector3b vector)
        {
            return new Vector3b(!vector.X, !vector.Y, !vector.Z);
        }

        /// <summary>
        /// ANDs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical AND operation.</returns>
        public static Vector3b operator &(Vector3b left, Vector3b right)
        {
            return new Vector3b(left.X & right.X, left.Y & right.Y, left.Z & right.Z);
        }

        /// <summary>
        /// ORs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical OR operation.</returns>
        public static Vector3b operator |(Vector3b left, Vector3b right)
        {
            return new Vector3b(left.X | right.X, left.Y | right.Y, left.Z | right.Z);
        }

        /// <summary>
        /// XORs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical XOR operation.</returns>
        public static Vector3b operator ^(Vector3b left, Vector3b right)
        {
            return new Vector3b(left.X ^ right.X, left.Y ^ right.Y, left.Z ^ right.Z);
        }

        /// <summary>
        /// Compares the specified instances for equality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector3b left, Vector3b right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified instances for inequality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector3b left, Vector3b right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3b"/> struct using a tuple containing the component values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector3b"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector3b((bool X, bool Y, bool Z) values)
        {
            return new Vector3b(values.X, values.Y, values.Z);
        }

        /// <inheritdoc/>
        public override readonly bool Equals(object obj)
        {
            return obj is Vector3b && Equals((Vector3b)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector3b other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Z == other.Z;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        /// <inheritdoc/>
        public override readonly string ToString()
        {
            return ToString(null);
        }

        /// <inheritdoc cref="IFormattable.ToString(string?, IFormatProvider?)"/>
        public readonly string ToString(IFormatProvider formatProvider)
        {
            return string.Format(
                "({0}{3} {1}{3}, {2})",
                X.ToString(formatProvider),
                Y.ToString(formatProvider),
                Z.ToString(formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        /// <param name="z">The Z component of the vector.</param>
        [Pure]
        public readonly void Deconstruct(out bool x, out bool y, out bool z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
