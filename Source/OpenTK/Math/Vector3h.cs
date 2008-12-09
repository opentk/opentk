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

namespace OpenTK.Math
{

    /// <summary>3-component Vector of the Half type. Occupies 6 Byte total.</summary>
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Vector3h : ISerializable, IEquatable<Vector3h>
    {
        #region Public Fields

        /// <summary>The X component of the Half3.</summary>
        public Half X;

        /// <summary>The Y component of the Half3.</summary>
        public Half Y;

        /// <summary>The Z component of the Half3.</summary>
        public Half Z;

        #endregion Public Fields

        #region Constructors

        /// <summary>
        /// The new Half3 instance will avoid conversion and copy directly from the Half parameters.
        /// </summary>
        /// <param name="x">An Half instance of a 16-Bit half precision floating point number.</param>
        /// <param name="y">An Half instance of a 16-Bit half precision floating point number.</param>
        /// <param name="z">An Half instance of a 16-Bit half precision floating point number.</param>
        public Vector3h(Half x, Half y, Half z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// The new Half3 instance will convert the 3 parameters into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="x">32-Bit Single precision floating point number.</param>
        /// <param name="y">32-Bit Single precision floating point number.</param>
        /// <param name="z">32-Bit Single precision floating point number.</param>
        public Vector3h(Single x, Single y, Single z)
        {
            X = new Half(x);
            Y = new Half(y);
            Z = new Half(z);
        }

        /// <summary>
        /// The new Half3 instance will convert the 3 parameters into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="x">32-Bit Single precision floating point number.</param>
        /// <param name="y">32-Bit Single precision floating point number.</param>
        /// <param name="z">32-Bit Single precision floating point number.</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(Single x, Single y, Single z, bool throwOnError)
        {
            X = new Half(x, throwOnError);
            Y = new Half(y, throwOnError);
            Z = new Half(z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3</param>
        [CLSCompliant(false)]
        public Vector3h(Vector3 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector3h(Vector3 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-Bit Half precision floating point.
        /// This is the fastest constructor.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3</param>
        public Vector3h(ref Vector3 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3 into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(ref Vector3 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3d</param>
        public Vector3h(Vector3d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector3h(Vector3d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-Bit Half precision floating point.
        /// This is the faster constructor.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3d</param>
        [CLSCompliant(false)]
        public Vector3h(ref Vector3d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
            Z = new Half(v.Z);
        }

        /// <summary>
        /// The new Half3 instance will convert the Vector3d into 16-Bit Half precision floating point.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector3h(ref Vector3d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
            Z = new Half(v.Z, throwOnError);
        }

        #endregion Constructors

        #region Half -> Single

        /// <summary>
        /// Returns this Half3 instance's contents as Vector3.
        /// </summary>
        /// <returns>OpenTK.Math.Vector3</returns>
        public Vector3 ToVector3()
        {
            return new Vector3(X, Y, Z);
        }

        /// <summary>
        /// Returns this Half3 instance's contents as Vector3d.
        /// </summary>
        /// <param name="v">OpenTK.Math.Vector3d</param>
        public Vector3d ToVector3d()
        {
            return new Vector3d(X, Y, Z);
        }

        #endregion Half -> Single

        #region Conversions

        /// <summary>Converts OpenTK.Math.Vector3 to OpenTK.Math.Half3.</summary>
        /// <param name="v4f">The Vector3 to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector3h(Vector3 v3f)
        {
            return new Vector3h(v3f);
        }

        /// <summary>Converts OpenTK.Math.Vector3d to OpenTK.Math.Half3.</summary>
        /// <param name="v4d">The Vector3d to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector3h(Vector3d v3d)
        {
            return new Vector3h(v3d);
        }

        /// <summary>Converts OpenTK.Math.Half3 to OpenTK.Math.Vector3.</summary>
        /// <param name="h4">The Half3 to convert.</param>
        /// <returns>The resulting Vector3.</returns>
        public static explicit operator Vector3(Vector3h h3)
        {
            Vector3 result = new Vector3();
            result.X = h3.X.ToSingle();
            result.Y = h3.Y.ToSingle();
            result.Z = h3.Z.ToSingle();
            return result;
        }

        /// <summary>Converts OpenTK.Math.Half3 to OpenTK.Math.Vector3d.</summary>
        /// <param name="h4">The Half3 to convert.</param>
        /// <returns>The resulting Vector3d.</returns>
        public static explicit operator Vector3d(Vector3h h3)
        {
            Vector3d result = new Vector3d();
            result.X = h3.X.ToSingle();
            result.Y = h3.Y.ToSingle();
            result.Z = h3.Z.ToSingle();
            return result;
        }

        #endregion Conversions

        #region Constants

        /// <summary>The size in bytes for an instance of the Half3 struct is 6.</summary>
        public static readonly int SizeInBytes = 6;

        #endregion Constants

        #region ISerializable

        /// <summary>Constructor used by ISerializable to deserialize the object.</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Vector3h(SerializationInfo info, StreamingContext context)
        {
            this.X = (Half)info.GetValue("X", typeof(Half));
            this.Y = (Half)info.GetValue("Y", typeof(Half));
            this.Z = (Half)info.GetValue("Z", typeof(Half));
        }

        /// <summary>Used by ISerialize to serialize the object.</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", this.X);
            info.AddValue("Y", this.Y);
            info.AddValue("Z", this.Z);
        }

        #endregion ISerializable

        #region Binary dump

        /// <summary>Updates the X,Y and Z components of this instance by reading from a Stream.</summary>
        /// <param name="bin">A BinaryReader instance associated with an open Stream.</param>
        public void FromBinaryStream(BinaryReader bin)
        {
            X.FromBinaryStream(bin);
            Y.FromBinaryStream(bin);
            Z.FromBinaryStream(bin);
        }

        /// <summary>Writes the X,Y and Z components of this instance into a Stream.</summary>
        /// <param name="bin">A BinaryWriter instance associated with an open Stream.</param>
        public void ToBinaryStream(BinaryWriter bin)
        {
            X.ToBinaryStream(bin);
            Y.ToBinaryStream(bin);
            Z.ToBinaryStream(bin);
        }

        #endregion Binary dump

        #region IEquatable<Half3> Members

        /// <summary>Returns a value indicating whether this instance is equal to a specified OpenTK.Math.Half3 vector.</summary>
        /// <param name="other">OpenTK.Math.Half3 to compare to this instance..</param>
        /// <returns>True, if other is equal to this instance; false otherwise.</returns>
        public bool Equals(Vector3h other)
        {
            return (this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z));
        }

        #endregion

        #region ToString()

        /// <summary>Returns a string that contains this Half3's numbers in human-legible form.</summary>
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X.ToString(), Y.ToString(), Z.ToString());
        }

        #endregion ToString()

        #region BitConverter

        /// <summary>Returns the Half3 as an array of bytes.</summary>
        /// <param name="h">The Half3 to convert.</param>
        /// <returns>The input as byte array.</returns>
        public static byte[] GetBytes(Vector3h h)
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

            return result;
        }

        /// <summary>Converts an array of bytes into Half3.</summary>
        /// <param name="value">A Half3 in it's byte[] representation.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A new Half3 instance.</returns>
        public static Vector3h FromBytes(byte[] value, int startIndex)
        {
            Vector3h h3 = new Vector3h();
            h3.X = Half.FromBytes(value, startIndex);
            h3.Y = Half.FromBytes(value, startIndex + 2);
            h3.Z = Half.FromBytes(value, startIndex + 4);
            return h3;
        }

        #endregion BitConverter
    }
}
