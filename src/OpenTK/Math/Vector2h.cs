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

    /// <summary>2-component Vector of the Half type. Occupies 4 Byte total.</summary>
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Vector2h : ISerializable, IEquatable<Vector2h>
    {
        #region Fields

        /// <summary>The X component of the Half2.</summary>
        public Half X;

        /// <summary>The Y component of the Half2.</summary>
        public Half Y;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2h(Half value)
        {
            X = value;
            Y = value;
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2h(Single value)
        {
            X = new Half(value);
            Y = new Half(value);
        }

        /// <summary>
        /// The new Half2 instance will avoid conversion and copy directly from the Half parameters.
        /// </summary>
        /// <param name="x">An Half instance of a 16-bit half-precision floating-point number.</param>
        /// <param name="y">An Half instance of a 16-bit half-precision floating-point number.</param>
        public Vector2h(Half x, Half y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// The new Half2 instance will convert the 2 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">32-bit single-precision floating-point number.</param>
        /// <param name="y">32-bit single-precision floating-point number.</param>
        public Vector2h(Single x, Single y)
        {
            X = new Half(x);
            Y = new Half(y);
        }

        /// <summary>
        /// The new Half2 instance will convert the 2 parameters into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="x">32-bit single-precision floating-point number.</param>
        /// <param name="y">32-bit single-precision floating-point number.</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector2h(Single x, Single y, bool throwOnError)
        {
            X = new Half(x, throwOnError);
            Y = new Half(y, throwOnError);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector2</param>
        [CLSCompliant(false)]
        public Vector2h(Vector2 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector2</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector2h(Vector2 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2 into 16-bit half-precision floating-point.
        /// This is the fastest constructor.
        /// </summary>
        /// <param name="v">OpenTK.Vector2</param>
        public Vector2h(ref Vector2 v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2 into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector2</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        public Vector2h(ref Vector2 v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector2d</param>
        [CLSCompliant(false)]
        public Vector2h(Vector2d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector2d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector2h(Vector2d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2d into 16-bit half-precision floating-point.
        /// This is the faster constructor.
        /// </summary>
        /// <param name="v">OpenTK.Vector2d</param>
        [CLSCompliant(false)]
        public Vector2h(ref Vector2d v)
        {
            X = new Half(v.X);
            Y = new Half(v.Y);
        }

        /// <summary>
        /// The new Half2 instance will convert the Vector2d into 16-bit half-precision floating-point.
        /// </summary>
        /// <param name="v">OpenTK.Vector2d</param>
        /// <param name="throwOnError">Enable checks that will throw if the conversion result is not meaningful.</param>
        [CLSCompliant(false)]
        public Vector2h(ref Vector2d v, bool throwOnError)
        {
            X = new Half(v.X, throwOnError);
            Y = new Half(v.Y, throwOnError);
        }

        #endregion Constructors

        #region Swizzle

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yx { get { return new Vector2h(Y, X); } set { Y = value.X; X = value.Y; } }

        #endregion

        #region Half -> Single

        /// <summary>
        /// Returns this Half2 instance's contents as Vector2.
        /// </summary>
        /// <returns>OpenTK.Vector2</returns>
        public Vector2 ToVector2()
        {
            return new Vector2(X, Y);
        }

        /// <summary>
        /// Returns this Half2 instance's contents as Vector2d.
        /// </summary>
        public Vector2d ToVector2d()
        {
            return new Vector2d(X, Y);
        }

        #endregion Half -> Single

        #region Conversions

        /// <summary>Converts OpenTK.Vector2 to OpenTK.Half2.</summary>
        /// <param name="v">The Vector2 to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector2h(Vector2 v)
        {
            return new Vector2h(v);
        }

        /// <summary>Converts OpenTK.Vector2d to OpenTK.Half2.</summary>
        /// <param name="v">The Vector2d to convert.</param>
        /// <returns>The resulting Half vector.</returns>
        public static explicit operator Vector2h(Vector2d v)
        {
            return new Vector2h(v);
        }

        /// <summary>Converts OpenTK.Half2 to OpenTK.Vector2.</summary>
        /// <param name="h">The Half2 to convert.</param>
        /// <returns>The resulting Vector2.</returns>
        public static explicit operator Vector2(Vector2h h)
        {
            return new Vector2(h.X, h.Y);
        }

        /// <summary>Converts OpenTK.Half2 to OpenTK.Vector2d.</summary>
        /// <param name="h">The Half2 to convert.</param>
        /// <returns>The resulting Vector2d.</returns>
        public static explicit operator Vector2d(Vector2h h)
        {
            return new Vector2d(h.X, h.Y);
        }

        #endregion Conversions

        #region Constants

        /// <summary>The size in bytes for an instance of the Half2 struct is 4.</summary>
        public static readonly int SizeInBytes = 4;

        #endregion Constants

        #region ISerializable

        /// <summary>Constructor used by ISerializable to deserialize the object.</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Vector2h(SerializationInfo info, StreamingContext context)
        {
            this.X = (Half)info.GetValue("X", typeof(Half));
            this.Y = (Half)info.GetValue("Y", typeof(Half));
        }

        /// <summary>Used by ISerialize to serialize the object.</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", this.X);
            info.AddValue("Y", this.Y);
        }

        #endregion ISerializable

        #region Binary dump

        /// <summary>Updates the X and Y components of this instance by reading from a Stream.</summary>
        /// <param name="bin">A BinaryReader instance associated with an open Stream.</param>
        public void FromBinaryStream(BinaryReader bin)
        {
            X.FromBinaryStream(bin);
            Y.FromBinaryStream(bin);
        }

        /// <summary>Writes the X and Y components of this instance into a Stream.</summary>
        /// <param name="bin">A BinaryWriter instance associated with an open Stream.</param>
        public void ToBinaryStream(BinaryWriter bin)
        {
            X.ToBinaryStream(bin);
            Y.ToBinaryStream(bin);
        }

        #endregion Binary dump

        #region IEquatable<Half2> Members

        /// <summary>Returns a value indicating whether this instance is equal to a specified OpenTK.Half2 vector.</summary>
        /// <param name="other">OpenTK.Half2 to compare to this instance..</param>
        /// <returns>True, if other is equal to this instance; false otherwise.</returns>
        public bool Equals(Vector2h other)
        {
            return (this.X.Equals(other.X) && this.Y.Equals(other.Y));
        }

        #endregion

        #region ToString()

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>Returns a string that contains this Half2's numbers in human-legible form.</summary>
        public override string ToString()
        {
            return String.Format("({0}{2} {1})", X, Y, listSeparator);
        }

        #endregion ToString()

        #region BitConverter

        /// <summary>Returns the Half2 as an array of bytes.</summary>
        /// <param name="h">The Half2 to convert.</param>
        /// <returns>The input as byte array.</returns>
        public static byte[] GetBytes(Vector2h h)
        {
            byte[] result = new byte[SizeInBytes];

            byte[] temp = Half.GetBytes(h.X);
            result[0] = temp[0];
            result[1] = temp[1];
            temp = Half.GetBytes(h.Y);
            result[2] = temp[0];
            result[3] = temp[1];

            return result;
        }

        /// <summary>Converts an array of bytes into Half2.</summary>
        /// <param name="value">A Half2 in it's byte[] representation.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A new Half2 instance.</returns>
        public static Vector2h FromBytes(byte[] value, int startIndex)
        {
            Vector2h h2 = new Vector2h();
            h2.X = Half.FromBytes(value, startIndex);
            h2.Y = Half.FromBytes(value, startIndex + 2);
            return h2;
        }

        #endregion BitConverter
    }
}