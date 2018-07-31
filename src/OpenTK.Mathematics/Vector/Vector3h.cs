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
using System.Globalization;
using System.IO;
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
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3h(Half value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3h(float value)
        {
            X = new Half(value);
            Y = new Half(value);
            Z = new Half(value);
        }

        /// <summary>
        /// The new Half3 instance will avoid conversion and copy directly from the Half parameters.
        /// </summary>
        /// <param name="x">An Half instance of a 16-bit half-precision floating-point number.</param>
        /// <param name="y">An Half instance of a 16-bit half-precision floating-point number.</param>
        /// <param name="z">An Half instance of a 16-bit half-precision floating-point number.</param>
        public Vector3h(Half x, Half y, Half z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// The new Half3 instance will convert the 3 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">32-bit single-precision floating-point number.</param>
        /// <param name="y">32-bit single-precision floating-point number.</param>
        /// <param name="z">32-bit single-precision floating-point number.</param>
        public Vector3h(float x, float y, float z)
        {
            X = new Half(x);
            Y = new Half(y);
            Z = new Half(z);
        }

        /// <summary>
        /// The new Half3 instance will convert the 3 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">32-bit single-precision floating-point number.</param>
        /// <param name="y">32-bit single-precision floating-point number.</param>
        /// <param name="z">32-bit single-precision floating-point number.</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(float x, float y, float z, bool throwOnError)
        {
            X = new Half(x, throwOnError);
            Y = new Half(y, throwOnError);
            Z = new Half(z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector3</param>
        public Vector3h(Vector3 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector3</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(Vector3 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-bit half-precision floating-point.
        /// This is the fastest constructor.
        /// </summary>
        /// <param name="v">OpenTK.Vector3</param>
        public Vector3h(ref Vector3 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector3</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(ref Vector3 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector3d</param>
        public Vector3h(Vector3d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector3d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(Vector3d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-bit half-precision floating-point.
        /// This is the faster constructor.
        /// </summary>
        /// <param name="v">OpenTK.Vector3d</param>
        public Vector3h(ref Vector3d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector3d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(ref Vector3d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xy
        {
            get => new Vector2h(X, Y);
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
        /// <returns>OpenTK.Vector3</returns>
        public Vector3 ToVector3()
        {
            return new Vector3(X, Y, Z);
        }

        /// <summary>
        /// Returns this Half3 instance's contents as Vector3d.
        /// </summary>
        public Vector3d ToVector3d()
        {
            return new Vector3d(X, Y, Z);
        }

        /// <summary>
        /// Converts OpenTK.Vector3 to OpenTK.Half3.
        /// </summary>
        /// <param name="v3f">The Vector3 to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector3h(Vector3 v3f)
        {
            return new Vector3h(v3f);
        }

        /// <summary>
        /// Converts OpenTK.Vector3d to OpenTK.Half3.
        /// </summary>
        /// <param name="v3d">The Vector3d to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector3h(Vector3d v3d)
        {
            return new Vector3h(v3d);
        }

        /// <summary>
        /// Converts OpenTK.Half3 to OpenTK.Vector3.
        /// </summary>
        /// <param name="h3">The Half3 to convert.</param>
        /// <returns>The resulting Vector3.</returns>
        public static explicit operator Vector3(Vector3h h3)
        {
            return new Vector3(
                h3.X.ToSingle(),
                h3.Y.ToSingle(),
                h3.Z.ToSingle());
        }

        /// <summary>
        /// Converts OpenTK.Half3 to OpenTK.Vector3d.
        /// </summary>
        /// <param name="h3">The Half3 to convert.</param>
        /// <returns>The resulting Vector3d.</returns>
        public static explicit operator Vector3d(Vector3h h3)
        {
            return new Vector3d(
                h3.X.ToSingle(),
                h3.Y.ToSingle(),
                h3.Z.ToSingle());
        }

        /// <summary>
        /// The size in bytes for an instance of the Half3 struct is 6.
        /// </summary>
        public static readonly int SizeInBytes = 6;

        /// <summary>
        /// Constructor used by ISerializable to deserialize the object.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Vector3h(SerializationInfo info, StreamingContext context)
        {
            X = (Half)info.GetValue("X", typeof(Half));
            Y = (Half)info.GetValue("Y", typeof(Half));
            Z = (Half)info.GetValue("Z", typeof(Half));
        }

        /// <summary>
        /// Used by ISerialize to serialize the object.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", X);
            info.AddValue("Y", Y);
            info.AddValue("Z", Z);
        }

        /// <summary>
        /// Updates the X,Y and Z components of this instance by reading from a Stream.
        /// </summary>
        /// <param name="bin">A BinaryReader instance associated with an open Stream.</param>
        public void FromBinaryStream(BinaryReader bin)
        {
            X.FromBinaryStream(bin);
            Y.FromBinaryStream(bin);
            Z.FromBinaryStream(bin);
        }

        /// <summary>
        /// Writes the X,Y and Z components of this instance into a Stream.
        /// </summary>
        /// <param name="bin">A BinaryWriter instance associated with an open Stream.</param>
        public void ToBinaryStream(BinaryWriter bin)
        {
            X.ToBinaryStream(bin);
            Y.ToBinaryStream(bin);
            Z.ToBinaryStream(bin);
        }

        /// <summary>
        /// Returns a value indicating whether this instance is equal to a specified OpenTK.Half3 vector.
        /// </summary>
        /// <param name="other">OpenTK.Half3 to compare to this instance..</param>
        /// <returns>True, if other is equal to this instance; false otherwise.</returns>
        public bool Equals(Vector3h other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        private static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;

        /// <summary>
        /// Returns a string that contains this Half3's numbers in human-legible form.
        /// </summary>
        public override string ToString()
        {
            return string.Format("({0}{3} {1}{3} {2})", X.ToString(), Y.ToString(), Z.ToString(), ListSeparator);
        }

        /// <summary>
        /// Returns the Half3 as an array of bytes.
        /// </summary>
        /// <param name="h">The Half3 to convert.</param>
        /// <returns>The input as byte array.</returns>
        public static byte[] GetBytes(Vector3h h)
        {
            var result = new byte[SizeInBytes];

            var temp = Half.GetBytes(h.X);
            result[0] = temp[0];
            result[1] = temp[1];
            temp = Half.GetBytes(h.Y);
            result[2] = temp[0];
            result[3] = temp[1];
            temp = Half.GetBytes(h.Z);
            result[4] = temp[0];
            result[5] = temp[1];

            return result;
        }

        /// <summary>
        /// Converts an array of bytes into Half3.
        /// </summary>
        /// <param name="value">A Half3 in it's byte[] representation.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A new Half3 instance.</returns>
        public static Vector3h FromBytes(byte[] value, int startIndex)
        {
            return new Vector3h(
                Half.FromBytes(value, startIndex),
                Half.FromBytes(value, startIndex + 2),
                Half.FromBytes(value, startIndex + 4));
        }
    }
}
