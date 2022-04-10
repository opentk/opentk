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
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// 3-component Vector of the Half type. Occupies 6 Byte total.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3h : ISerializable, IEquatable<Vector3h>
    {
        /// <summary>
        /// The X component of the Half3.
        /// </summary>
        public Half X;

        /// <summary>
        /// The Y component of the Half3.
        /// </summary>
        public Half Y;

        /// <summary>
        /// The Z component of the Half3.
        /// </summary>
        public Half Z;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3h(Half value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3h(float value)
        {
            X = (Half)value;
            Y = (Half)value;
            Z = (Half)value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector3h.</param>
        /// <param name="y">The y component of the Vector3h.</param>
        /// <param name="z">The z component of the Vector3h.</param>
        public Vector3h(Half x, Half y, Half z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// The new Half3 instance will convert the 3 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">The x component of the Vector3h.</param>
        /// <param name="y">The y component of the Vector3h.</param>
        /// <param name="z">The z component of the Vector3h.</param>
        public Vector3h(float x, float y, float z)
        {
            X = (Half)x;
            Y = (Half)y;
            Z = (Half)z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector3h.</param>
        /// <param name="z">The z component of the Vector3h.</param>
        public Vector3h(Vector2h xy, float z = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = (Half)z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector3h.</param>
        /// <param name="z">The z component of the Vector3h.</param>
        public Vector3h(Vector2h xy, Half z = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xy
        {
            get => Unsafe.As<Vector3h, Vector2h>(ref this);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xz
        {
            get => new Vector2h(X, Z);
            set
            {
                X = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yx
        {
            get => new Vector2h(Y, X);
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yz
        {
            get => new Vector2h(Y, Z);
            set
            {
                Y = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zx
        {
            get => new Vector2h(Z, X);
            set
            {
                Z = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zy
        {
            get => new Vector2h(Z, Y);
            set
            {
                Z = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xzy
        {
            get => new Vector3h(X, Z, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yxz
        {
            get => new Vector3h(Y, X, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yzx
        {
            get => new Vector3h(Y, Z, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zxy
        {
            get => new Vector3h(Z, X, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zyx
        {
            get => new Vector3h(Z, Y, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Returns this Half3 instance's contents as Vector3.
        /// </summary>
        /// <returns>The vector.</returns>
        public Vector3 ToVector3()
        {
            return new Vector3((float)X, (float)Y, (float)Z);
        }

        /// <summary>
        /// Returns this Half3 instance's contents as Vector3d.
        /// </summary>
        /// <returns>The vector.</returns>
        public Vector3d ToVector3d()
        {
            return new Vector3d((double)X, (double)Y, (double)Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3h to OpenTK.Vector3.
        /// </summary>
        /// <param name="vec">The Vector3h to convert.</param>
        /// <returns>The resulting Vector3.</returns>
        [Pure]
        public static implicit operator Vector3(Vector3h vec)
        {
            return new Vector3((float)vec.X, (float)vec.Y, (float)vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3h to OpenTK.Vector3d.
        /// </summary>
        /// <param name="vec">The Vector3h to convert.</param>
        /// <returns>The resulting Vector3d.</returns>
        [Pure]
        public static implicit operator Vector3d(Vector3h vec)
        {
            return new Vector3d((double)vec.X, (double)vec.Y, (double)vec.Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3h to OpenTK.Vector3i.
        /// </summary>
        /// <param name="vec">The Vector3h to convert.</param>
        /// <returns>The resulting Vector3i.</returns>
        [Pure]
        public static explicit operator Vector3i(Vector3h vec)
        {
            return new Vector3i((int)vec.X, (int)vec.Y, (int)vec.Z);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector3h"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector3h((Half X, Half Y, Half Z) values)
        {
            return new Vector3h(values.X, values.Y, values.Z);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector3h left, Vector3h right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Vector3h left, Vector3h right)
        {
            return !(left == right);
        }

        /// <summary>
        /// The size in bytes for an instance of the Half3 struct is 6.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector3h>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3h"/> struct.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The streaming context.</param>
        [Pure]
        public Vector3h(SerializationInfo info, StreamingContext context)
        {
            X = (Half)info.GetValue("X", typeof(Half));
            Y = (Half)info.GetValue("Y", typeof(Half));
            Z = (Half)info.GetValue("Z", typeof(Half));
        }

        /// <inheritdoc/>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", X);
            info.AddValue("Y", Y);
            info.AddValue("Z", Z);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("({0}{3} {1}{3} {2})", X.ToString(), Y.ToString(), Z.ToString(), MathHelper.ListSeparator);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Vector3h && Equals((Vector3h)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Vector3h other)
        {
            return X.Equals(other.X) &&
                   Y.Equals(other.Y) &&
                   Z.Equals(other.Z);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
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
        public void Deconstruct(out Half x, out Half y, out Half z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
}
