#region --- License ---
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
#endregion

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OpenTK
{
    /// <summary>
    /// 4-component Vector of the Half type. Occupies 8 Byte total.
    /// </summary>
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Vector4h : ISerializable, IEquatable<Vector4h>
    {
        #region Public Fields

        /// <summary>The X component of the Half4.</summary>
        public Half X;

        /// <summary>The Y component of the Half4.</summary>
        public Half Y;

        /// <summary>The Z component of the Half4.</summary>
        public Half Z;

        /// <summary>The W component of the Half4.</summary>
        public Half W;

        #endregion Public Fields

        #region Constructors

        /// <summary>
        /// The new Half4 instance will avoid conversion and copy directly from the Half parameters.
        /// </summary>
        /// <param name="x">An Half instance of a 16-bit half-precision floating-point number.</param>
        /// <param name="y">An Half instance of a 16-bit half-precision floating-point number.</param>
        /// <param name="z">An Half instance of a 16-bit half-precision floating-point number.</param>
        /// <param name="w">An Half instance of a 16-bit half-precision floating-point number.</param>
        public Vector4h(Half x, Half y, Half z, Half w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        /// <summary>
        /// The new Half4 instance will convert the 4 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">32-bit single-precision floating-point number.</param>
        /// <param name="y">32-bit single-precision floating-point number.</param>
        /// <param name="z">32-bit single-precision floating-point number.</param>
        /// <param name="w">32-bit single-precision floating-point number.</param>
        public Vector4h(Single x, Single y, Single z, Single w)
        {
            X = new Half(x);
            Y = new Half(y);
            Z = new Half(z);
            W = new Half(w);
        }

        /// <summary>
        /// The new Half4 instance will convert the 4 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">32-bit single-precision floating-point number.</param>
        /// <param name="y">32-bit single-precision floating-point number.</param>
        /// <param name="z">32-bit single-precision floating-point number.</param>
        /// <param name="w">32-bit single-precision floating-point number.</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector4h(Single x, Single y, Single z, Single w, bool throwOnError)
        {
            X = new Half(x, throwOnError);
            Y = new Half(y, throwOnError);
            Z = new Half(z, throwOnError);
            W = new Half(w, throwOnError);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector4</param>
        [CLSCompliant(false)]
        public Vector4h(Vector4 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
            W = new Half(v.W);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector4</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector4h(Vector4 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
            W = new Half(v.W, throwOnError);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4 into 16-bit half-precision floating-point.
        /// This is the fastest constructor.
        /// </summary>
        /// <param name="v">OpenTK.Vector4</param>
        public Vector4h(ref Vector4 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
            W = new Half(v.W);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector4</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector4h(ref Vector4 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
            W = new Half(v.W, throwOnError);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector4d</param>
        public Vector4h(Vector4d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
            W = new Half(v.W);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector4d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector4h(Vector4d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
            W = new Half(v.W, throwOnError);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4d into 16-bit half-precision floating-point.
        /// This is the faster constructor.
        /// </summary>
        /// <param name="v">OpenTK.Vector4d</param>
        [CLSCompliant(false)]
        public Vector4h(ref Vector4d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
            W = new Half(v.W);
        }

        /// <summary>
        /// The new Half4 instance will convert the Vector4d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector4d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector4h(ref Vector4d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
            W = new Half(v.W, throwOnError);
        }

        #endregion Constructors

        #region Swizzle

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xy { get { return new Vector2h(X, Y); } set { X = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyz { get { return new Vector3h(X, Y, Z); } set { X = value.X; Y = value.Y; Z = value.Z; } }

        #endregion

        #region Half -> Single

        /// <summary>
        /// Returns this Half4 instance's contents as Vector4.
        /// </summary>
        /// <returns>OpenTK.Vector4</returns>
        public Vector4 ToVector4()
        {
            return new Vector4(X, Y, Z, W);
        }

        /// <summary>
        /// Returns this Half4 instance's contents as Vector4d.
        /// </summary>
        public Vector4d ToVector4d()
        {
            return new Vector4d(X, Y, Z, W);
        }

        #endregion Half -> Single

        #region Conversions

        /// <summary>Converts OpenTK.Vector4 to OpenTK.Half4.</summary>
        /// <param name="v4f">The Vector4 to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector4h(Vector4 v4f)
        {
            return new Vector4h(v4f);
        }

        /// <summary>Converts OpenTK.Vector4d to OpenTK.Half4.</summary>
        /// <param name="v4d">The Vector4d to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector4h(Vector4d v4d)
        {
            return new Vector4h(v4d);
        }

        /// <summary>Converts OpenTK.Half4 to OpenTK.Vector4.</summary>
        /// <param name="h4">The Half4 to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        public static explicit operator Vector4(Vector4h h4)
        {
            Vector4 result = new Vector4();
            result.X = h4.X.ToSingle();
            result.Y = h4.Y.ToSingle();
            result.Z = h4.Z.ToSingle();
            result.W = h4.W.ToSingle();
            return result;
        }

        /// <summary>Converts OpenTK.Half4 to OpenTK.Vector4d.</summary>
        /// <param name="h4">The Half4 to convert.</param>
        /// <returns>The resulting Vector4d.</returns>
        public static explicit operator Vector4d(Vector4h h4)
        {
            Vector4d result = new Vector4d();
            result.X = h4.X.ToSingle();
            result.Y = h4.Y.ToSingle();
            result.Z = h4.Z.ToSingle();
            result.W = h4.W.ToSingle();
            return result;
        }

        #endregion Conversions

        #region Constants

        /// <summary>The size in bytes for an instance of the Half4 struct is 8.</summary>
        public static readonly int SizeInBytes = 8;

        #endregion Constants

        #region ISerializable

        /// <summary>Constructor used by ISerializable to deserialize the object.</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Vector4h(SerializationInfo info, StreamingContext context)
        {
            this.X = (Half)info.GetValue("X", typeof(Half));
            this.Y = (Half)info.GetValue("Y", typeof(Half));
            this.Z = (Half)info.GetValue("Z", typeof(Half));
            this.W = (Half)info.GetValue("W", typeof(Half));
        }

        /// <summary>Used by ISerialize to serialize the object.</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", this.X);
            info.AddValue("Y", this.Y);
            info.AddValue("Z", this.Z);
            info.AddValue("W", this.W);
        }

        #endregion ISerializable

        #region Binary dump

        /// <summary>Updates the X,Y,Z and W components of this instance by reading from a Stream.</summary>
        /// <param name="bin">A BinaryReader instance associated with an open Stream.</param>
        public void FromBinaryStream(BinaryReader bin)
        {
            X.FromBinaryStream(bin);
            Y.FromBinaryStream(bin);
            Z.FromBinaryStream(bin);
            W.FromBinaryStream(bin);
        }

        /// <summary>Writes the X,Y,Z and W components of this instance into a Stream.</summary>
        /// <param name="bin">A BinaryWriter instance associated with an open Stream.</param>
        public void ToBinaryStream(BinaryWriter bin)
        {
            X.ToBinaryStream(bin);
            Y.ToBinaryStream(bin);
            Z.ToBinaryStream(bin);
            W.ToBinaryStream(bin);
        }

        #endregion Binary dump

        #region IEquatable<Half4> Members

        /// <summary>Returns a value indicating whether this instance is equal to a specified OpenTK.Half4 vector.</summary>
        /// <param name="other">OpenTK.Half4 to compare to this instance..</param>
        /// <returns>True, if other is equal to this instance; false otherwise.</returns>
        public bool Equals(Vector4h other)
        {
            return (this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z) && this.W.Equals(other.W));
        }

        #endregion

        #region ToString()

        /// <summary>Returns a string that contains this Half4's numbers in human-legible form.</summary>
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2}, {3})", X.ToString(), Y.ToString(), Z.ToString(), W.ToString());
        }

        #endregion ToString()

        #region BitConverter

        /// <summary>Returns the Half4 as an array of bytes.</summary>
        /// <param name="h">The Half4 to convert.</param>
        /// <returns>The input as byte array.</returns>
        public static byte[] GetBytes(Vector4h h)
        {
            byte[] result = new byte[SizeInBytes];

            byte[] temp = Half.GetBytes(h.X);
            result[0] = temp[0];
            result[1] = temp[1];
            temp = Half.GetBytes(h.Y);
            result[2] = temp[0];
            result[3] = temp[1];
            temp = Half.GetBytes(h.Z);
            result[4] = temp[0];
            result[5] = temp[1];
            temp = Half.GetBytes(h.W);
            result[6] = temp[0];
            result[7] = temp[1];

            return result;
        }

        /// <summary>Converts an array of bytes into Half4.</summary>
        /// <param name="value">A Half4 in it's byte[] representation.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A new Half4 instance.</returns>
        public static Vector4h FromBytes(byte[] value, int startIndex)
        {
            Vector4h h4 = new Vector4h();
            h4.X = Half.FromBytes(value, startIndex);
            h4.Y = Half.FromBytes(value, startIndex + 2);
            h4.Z = Half.FromBytes(value, startIndex + 4);
            h4.W = Half.FromBytes(value, startIndex + 6);
            return h4;
        }

        #endregion BitConverter
    }
}
