using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
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
    public struct Vector2b : IEquatable<Vector2b>
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
        /// Initializes a new instance of the <see cref="Vector2b"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2b(bool value)
        {
            X = value;
            Y = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2b"/> struct.
        /// </summary>
        /// <param name="x">The x component of the <see cref="Vector2b"/>.</param>
        /// <param name="y">The y component of the <see cref="Vector2b"/>.</param>
        public Vector2b(bool x, bool y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2b"/> struct.
        /// </summary>
        /// <param name="xy">The x, and y component of the <see cref="Vector2b"/>.</param>
        public Vector2b(Vector2b xy)
        {
            X = xy.X;
            Y = xy.Y;
        }

        /// <summary>
        /// Gets or sets the value at the index of the vector.
        /// </summary>
        /// <param name="index">The index of the component from the vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 1.</exception>
        public bool this[int index]
        {
            readonly get
            {
                if (((uint)index) > 1)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this vector at index: {0}", index);
                }

                return GetElementUnsafe(in this, index);
            }

            set
            {
                if (((uint)index) > 1)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this vector at index: {0}", index);
                }

                GetElementUnsafe(in this, index) = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref bool GetElementUnsafe(in Vector2b v, int index)
        {
            ref bool address = ref Unsafe.AsRef(in v.X);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Returns the logical negation of this vector.
        /// </summary>
        /// <returns>A vector with each component negated.</returns>
        public readonly Vector2b Not()
        {
            return new Vector2b(!X, !Y);
        }

        /// <summary>
        /// Returns <see langword="true"/> if all components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <returns>If all of the components of the vector were <see langword="true"/>.</returns>
        public readonly bool All()
        {
            return X && Y;
        }

        /// <summary>
        /// Returns <see langword="true"/> if any component of the vector is <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <returns>If any of the components of the vector were <see langword="true"/>.</returns>
        public readonly bool Any()
        {
            return X || Y;
        }

        /// <summary>
        /// Defines an instance with only the X components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector2b UnitX = new Vector2b(true, false);

        /// <summary>
        /// Defines an instance with only the Y components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector2b UnitY = new Vector2b(false, true);

        /// <summary>
        /// Defines an instance with all components set to <see langword="true"/>.
        /// </summary>
        public static readonly Vector2b True = new Vector2b(true, true);

        /// <summary>
        /// Defines an instance with all components set to <see langword="false"/>.
        /// </summary>
        public static readonly Vector2b False = new Vector2b(false, false);

        /// <summary>
        /// Returns <see langword="true"/> if all components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="vector">The vector to check if all components are <see langword="true"/>.</param>
        /// <returns>If all of the components of the vector were <see langword="true"/>.</returns>
        public static bool All(Vector2b vector)
        {
            return vector.X && vector.Y;
        }

        /// <summary>
        /// Returns <see langword="true"/> if any components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="vector">The vector to check if any components are <see langword="true"/>.</param>
        /// <returns>If any of the components of the vector were <see langword="true"/>.</returns>
        public static bool Any(Vector2b vector)
        {
            return vector.X || vector.Y;
        }

        /// <summary>
        /// Returns the logical negation of a vector.
        /// </summary>
        /// <param name="vec">The vector to logically negate.</param>
        /// <returns>A vector with each component negated.</returns>
        public static Vector2b Not(Vector2b vec)
        {
            return new Vector2b(!vec.X, !vec.Y);
        }

        /// <summary>
        /// Returns the component-wise logical and of two vectors.
        /// </summary>
        /// <param name="left">The first vector to and.</param>
        /// <param name="right">The second vector to and.</param>
        /// <returns>A vector were each component is the logical and of the input vector components.</returns>
        public static Vector2b And(Vector2b left, Vector2b right)
        {
            return new Vector2b(left.X & right.X, left.Y & right.Y);
        }

        /// <summary>
        /// Returns the component-wise logical or of two vectors.
        /// </summary>
        /// <param name="left">The first vector to or.</param>
        /// <param name="right">The second vector to or.</param>
        /// <returns>A vector were each component is the logical or of the input vector components.</returns>
        public static Vector2b Or(Vector2b left, Vector2b right)
        {
            return new Vector2b(left.X | right.X, left.Y | right.Y);
        }

        /// <summary>
        /// Returns the component-wise logical xor of two vectors.
        /// </summary>
        /// <param name="left">The first vector to xor.</param>
        /// <param name="right">The second vector to xor.</param>
        /// <returns>A vector were each component is the logical xor of the input vector components.</returns>
        public static Vector2b Xor(Vector2b left, Vector2b right)
        {
            return new Vector2b(left.X ^ right.X, left.Y ^ right.Y);
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2 with the Y and X components of this instance.
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
        /// Negates the specified instance.
        /// </summary>
        /// <param name="vector">Operand.</param>
        /// <returns>Result of negation.</returns>
        public static Vector2b operator !(Vector2b vector)
        {
            return new Vector2b(!vector.X, !vector.Y);
        }

        /// <summary>
        /// ANDs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical AND operation.</returns>
        public static Vector2b operator &(Vector2b left, Vector2b right)
        {
            return new Vector2b(left.X & right.X, left.Y & right.Y);
        }

        /// <summary>
        /// ORs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical OR operation.</returns>
        public static Vector2b operator |(Vector2b left, Vector2b right)
        {
            return new Vector2b(left.X | right.X, left.Y | right.Y);
        }

        /// <summary>
        /// XORs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical XOR operation.</returns>
        public static Vector2b operator ^(Vector2b left, Vector2b right)
        {
            return new Vector2b(left.X ^ right.X, left.Y ^ right.Y);
        }

        /// <summary>
        /// Compares the specified instances for equality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector2b left, Vector2b right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified instances for inequality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector2b left, Vector2b right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2b"/> struct using a tuple containing the component values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector2b"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector2b((bool X, bool Y) values)
        {
            return new Vector2b(values.X, values.Y);
        }

        /// <inheritdoc/>
        public override readonly bool Equals(object obj)
        {
            return obj is Vector2b && Equals((Vector2b)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector2b other)
        {
            return X == other.X &&
                   Y == other.Y;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y);
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
                "({0}{2} {1})",
                X.ToString(formatProvider),
                Y.ToString(formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        [Pure]
        public readonly void Deconstruct(out bool x, out bool y)
        {
            x = X;
            y = Y;
        }
    }
}
