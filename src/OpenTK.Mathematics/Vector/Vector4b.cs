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
    public struct Vector4b : IEquatable<Vector4b>
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
        /// The W component of the vector.
        /// </summary>
        public bool W;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4b"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4b(bool value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4b"/> struct.
        /// </summary>
        /// <param name="x">The x component of the <see cref="Vector4b"/>.</param>
        /// <param name="y">The y component of the <see cref="Vector4b"/>.</param>
        /// <param name="z">The z component of the <see cref="Vector4b"/>.</param>
        /// <param name="w">The w component of the <see cref="Vector4b"/>.</param>
        public Vector4b(bool x, bool y, bool z, bool w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4b"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the <see cref="Vector4b"/>.</param>
        /// <param name="z">The z component of the <see cref="Vector4b"/>.</param>
        /// <param name="w">The w component of the <see cref="Vector4b"/>.</param>
        public Vector4b(Vector2b xy, bool z = default, bool w = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4b"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y, and z components of the <see cref="Vector4b"/>.</param>
        /// <param name="w">The w component of the <see cref="Vector4b"/>.</param>
        public Vector4b(Vector3b xyz, bool w = default)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        /// <summary>
        /// Gets or sets the value at the index of the vector.
        /// </summary>
        /// <param name="index">The index of the component from the vector.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown if the index is less than 0 or greater than 3.</exception>
        public bool this[int index]
        {
            readonly get
            {
                if (((uint)index) < 4)
                {
                    return GetElementUnsafe(in this, index);
                }
                else
                {
                    throw new IndexOutOfRangeException("You tried to access this vector at index: " + index);
                }
            }

            set
            {
                if (((uint)index) < 4)
                {
                    SetElementUnsafe(ref this, index, value);
                }
                else
                {
                    throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool GetElementUnsafe(in Vector4b v, int index)
        {
            ref bool address = ref Unsafe.AsRef(in v.X);
            return Unsafe.Add(ref address, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void SetElementUnsafe(ref Vector4b v, int index, bool value)
        {
            ref bool address = ref Unsafe.AsRef(in v.X);
            Unsafe.Add(ref address, index) = value;
        }

        /// <summary>
        /// Returns the logical negation of this vector.
        /// </summary>
        /// <returns>A vector with each component negated.</returns>
        public readonly Vector4b Not()
        {
            return new Vector4b(!X, !Y, !Z, !W);
        }

        /// <summary>
        /// Returns <see langword="true"/> if all components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <returns>If all of the components of the vector were <see langword="true"/>.</returns>
        public readonly bool All()
        {
            return X && Y && Z && W;
        }

        /// <summary>
        /// Returns <see langword="true"/> if any component of the vector is <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <returns>If any of the components of the vector were <see langword="true"/>.</returns>
        public readonly bool Any()
        {
            return X || Y || Z || W;
        }

        /// <summary>
        /// Returns <see langword="true"/> if all components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="vector">The vector to check if all components are <see langword="true"/>.</param>
        /// <returns>If all of the components of the vector were <see langword="true"/>.</returns>
        public static bool All(Vector4b vector)
        {
            return vector.X && vector.Y && vector.Z && vector.W;
        }

        /// <summary>
        /// Returns <see langword="true"/> if any components of the vector are <see langword="true"/>, <see langword="false"/> otherwise.
        /// </summary>
        /// <param name="vector">The vector to check if any components are <see langword="true"/>.</param>
        /// <returns>If any of the components of the vector were <see langword="true"/>.</returns>
        public static bool Any(Vector4b vector)
        {
            return vector.X || vector.Y || vector.Z || vector.W;
        }

        /// <summary>
        /// Returns the logical negation of a vector.
        /// </summary>
        /// <param name="vec">The vector to logically negate.</param>
        /// <returns>A vector with each component negated.</returns>
        public static Vector4b Not(Vector4b vec)
        {
            return new Vector4b(!vec.X, !vec.Y, !vec.Z, !vec.W);
        }

        /// <summary>
        /// Returns the component-wise logical and of two vectors.
        /// </summary>
        /// <param name="left">The first vector to and.</param>
        /// <param name="right">The second vector to and.</param>
        /// <returns>A vector were each component is the logical and of the input vector components.</returns>
        public static Vector4b And(Vector4b left, Vector4b right)
        {
            return new Vector4b(left.X & right.X, left.Y & right.Y, left.Z & right.Z, left.W & right.W);
        }

        /// <summary>
        /// Returns the component-wise logical or of two vectors.
        /// </summary>
        /// <param name="left">The first vector to or.</param>
        /// <param name="right">The second vector to or.</param>
        /// <returns>A vector were each component is the logical or of the input vector components.</returns>
        public static Vector4b Or(Vector4b left, Vector4b right)
        {
            return new Vector4b(left.X | right.X, left.Y | right.Y, left.Z | right.Z, left.W | right.W);
        }

        /// <summary>
        /// Returns the component-wise logical xor of two vectors.
        /// </summary>
        /// <param name="left">The first vector to xor.</param>
        /// <param name="right">The second vector to xor.</param>
        /// <returns>A vector were each component is the logical xor of the input vector components.</returns>
        public static Vector4b Xor(Vector4b left, Vector4b right)
        {
            return new Vector4b(left.X ^ right.X, left.Y ^ right.Y, left.Z ^ right.Z, left.W ^ right.W);
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Xy
        {
            get => Unsafe.As<Vector4b, Vector2b>(ref this);
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
        /// Gets or sets an OpenTK.Vector2b with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Xw
        {
            readonly get => new Vector2b(X, W);
            set
            {
                X = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2b with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Yw
        {
            readonly get => new Vector2b(Y, W);
            set
            {
                Y = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2b with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Zw
        {
            readonly get => new Vector2b(Z, W);
            set
            {
                Z = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Wx
        {
            readonly get => new Vector2b(W, X);
            set
            {
                W = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Wy
        {
            readonly get => new Vector2b(W, Y);
            set
            {
                W = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2b with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2b Wz
        {
            readonly get => new Vector2b(W, Z);
            set
            {
                W = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Xyz
        {
            get => Unsafe.As<Vector4b, Vector3b>(ref this);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Xyw
        {
            readonly get => new Vector3b(X, Y, W);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3b with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Xzw
        {
            readonly get => new Vector3b(X, Z, W);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Xwy
        {
            readonly get => new Vector3b(X, W, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Xwz
        {
            readonly get => new Vector3b(X, W, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3b with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Yxw
        {
            readonly get => new Vector3b(Y, X, W);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3b with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Yzw
        {
            readonly get => new Vector3b(Y, Z, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Ywx
        {
            readonly get => new Vector3b(Y, W, X);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Ywz
        {
            readonly get => new Vector3b(Y, W, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3b with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Zxw
        {
            readonly get => new Vector3b(Z, X, W);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3b with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Zyw
        {
            readonly get => new Vector3b(Z, Y, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Zwx
        {
            readonly get => new Vector3b(Z, W, X);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Zwy
        {
            readonly get => new Vector3b(Z, W, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Wxy
        {
            readonly get => new Vector3b(W, X, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Wxz
        {
            readonly get => new Vector3b(W, X, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Wyx
        {
            readonly get => new Vector3b(W, Y, X);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Wyz
        {
            readonly get => new Vector3b(W, Y, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Wzx
        {
            readonly get => new Vector3b(W, Z, X);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3b with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3b Wzy
        {
            readonly get => new Vector3b(W, Z, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Xywz
        {
            readonly get => new Vector4b(X, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Xzyw
        {
            readonly get => new Vector4b(X, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Xzwy
        {
            readonly get => new Vector4b(X, Z, W, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Xwyz
        {
            readonly get => new Vector4b(X, W, Y, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Xwzy
        {
            readonly get => new Vector4b(X, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Yxzw
        {
            readonly get => new Vector4b(Y, X, Z, W);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Yxwz
        {
            readonly get => new Vector4b(Y, X, W, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Yyzw
        {
            readonly get => new Vector4b(Y, Y, Z, W);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Yywz
        {
            readonly get => new Vector4b(Y, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Yzxw
        {
            readonly get => new Vector4b(Y, Z, X, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Yzwx
        {
            readonly get => new Vector4b(Y, Z, W, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Ywxz
        {
            readonly get => new Vector4b(Y, W, X, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Ywzx
        {
            readonly get => new Vector4b(Y, W, Z, X);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zxyw
        {
            readonly get => new Vector4b(Z, X, Y, W);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zxwy
        {
            readonly get => new Vector4b(Z, X, W, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zyxw
        {
            readonly get => new Vector4b(Z, Y, X, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zywx
        {
            readonly get => new Vector4b(Z, Y, W, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zwxy
        {
            readonly get => new Vector4b(Z, W, X, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zwyx
        {
            readonly get => new Vector4b(Z, W, Y, X);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Zwzy
        {
            readonly get => new Vector4b(Z, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wxyz
        {
            readonly get => new Vector4b(W, X, Y, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wxzy
        {
            readonly get => new Vector4b(W, X, Z, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wyxz
        {
            readonly get => new Vector4b(W, Y, X, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wyzx
        {
            readonly get => new Vector4b(W, Y, Z, X);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wzxy
        {
            readonly get => new Vector4b(W, Z, X, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wzyx
        {
            readonly get => new Vector4b(W, Z, Y, X);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4b with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4b Wzyw
        {
            readonly get => new Vector4b(W, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Negates the specified instance.
        /// </summary>
        /// <param name="vector">Operand.</param>
        /// <returns>Result of negation.</returns>
        public static Vector4b operator !(Vector4b vector)
        {
            return new Vector4b(!vector.X, !vector.Y, !vector.Z, !vector.W);
        }

        /// <summary>
        /// ANDs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical AND operation.</returns>
        public static Vector4b operator &(Vector4b left, Vector4b right)
        {
            return new Vector4b(left.X & right.X, left.Y & right.Y, left.Z & right.Z, left.W & right.W);
        }

        /// <summary>
        /// ORs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical OR operation.</returns>
        public static Vector4b operator |(Vector4b left, Vector4b right)
        {
            return new Vector4b(left.X | right.X, left.Y | right.Y, left.Z | right.Z, left.W | right.W);
        }

        /// <summary>
        /// XORs the specified instances.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>Result of the logical XOR operation.</returns>
        public static Vector4b operator ^(Vector4b left, Vector4b right)
        {
            return new Vector4b(left.X ^ right.X, left.Y ^ right.Y, left.Z ^ right.Z, left.W ^ right.W);
        }

        /// <summary>
        /// Compares the specified instances for equality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector4b left, Vector4b right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified instances for inequality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector4b left, Vector4b right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4b"/> struct using a tuple containing the component values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector4b"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector4b((bool X, bool Y, bool Z, bool W) values)
        {
            return new Vector4b(values.X, values.Y, values.Z, values.W);
        }

        /// <inheritdoc/>
        public override readonly bool Equals(object obj)
        {
            return obj is Vector4b && Equals((Vector4b)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector4b other)
        {
            return X == other.X &&
                   Y == other.Y &&
                   Z == other.Z &&
                   W == other.W;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z, W);
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
                "({0}{4} {1}{4}, {2}{4}, {3})",
                X.ToString(formatProvider),
                Y.ToString(formatProvider),
                Z.ToString(formatProvider),
                W.ToString(formatProvider),
                MathHelper.GetListSeparator(formatProvider));
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        /// <param name="z">The Z component of the vector.</param>
        /// <param name="w">The W component of the vector.</param>
        [Pure]
        public readonly void Deconstruct(out bool x, out bool y, out bool z, out bool w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
    }
}
