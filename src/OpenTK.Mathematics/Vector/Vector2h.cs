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
    /// 2-component Vector of the Half type. Occupies 4 Byte total.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2h : ISerializable, IEquatable<Vector2h>
    {
        /// <summary>
        /// The X component of the Half2.
        /// </summary>
        public Half X;

        /// <summary>
        /// The Y component of the Half2.
        /// </summary>
        public Half Y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2h"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2h(Half value)
        {
            X = value;
            Y = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2h"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2h(float value)
        {
            X = (Half)value;
            Y = (Half)value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2h"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector2h.</param>
        /// <param name="y">The y component of the Vector2h.</param>
        public Vector2h(Half x, Half y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2h"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector2h.</param>
        /// <param name="y">The y component of the Vector2h.</param>
        public Vector2h(float x, float y)
        {
            X = (Half)x;
            Y = (Half)y;
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
        /// Returns this Half2 instance's contents as Vector2.
        /// </summary>
        /// <returns>The vector.</returns>
        public Vector2 ToVector2()
        {
            return new Vector2((float)X, (float)Y);
        }

        /// <summary>
        /// Returns this Half2 instance's contents as Vector2d.
        /// </summary>
        /// <returns>The vector.</returns>
        public Vector2d ToVector2d()
        {
            return new Vector2d((double)X, (double)Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2h to OpenTK.Vector2.
        /// </summary>
        /// <param name="vec">The Vector2h to convert.</param>
        /// <returns>The resulting Vector2.</returns>
        [Pure]
        public static implicit operator Vector2(Vector2h vec)
        {
            return new Vector2((float)vec.X, (float)vec.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2h to OpenTK.Vector2d.
        /// </summary>
        /// <param name="vec">The Vector2h to convert.</param>
        /// <returns>The resulting Vector2d.</returns>
        [Pure]
        public static implicit operator Vector2d(Vector2h vec)
        {
            return new Vector2d((double)vec.X, (double)vec.Y);
        }

        /// <summary>
        /// Converts OpenTK.Vector2h to OpenTK.Vector2i.
        /// </summary>
        /// <param name="vec">The Vector2h to convert.</param>
        /// <returns>The resulting Vector2i.</returns>
        [Pure]
        public static explicit operator Vector2i(Vector2h vec)
        {
            return new Vector2i((int)vec.X, (int)vec.Y);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2h"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector2h"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector2h((Half X, Half Y) values)
        {
            return new Vector2h(values.X, values.Y);
        }

        /// <summary>
        /// Compares the specified instances for equality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector2h left, Vector2h right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares the specified instances for inequality.
        /// </summary>
        /// <param name="left">Left operand.</param>
        /// <param name="right">Right operand.</param>
        /// <returns>True if both instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector2h left, Vector2h right)
        {
            return !(left == right);
        }

        /// <summary>
        /// The size in bytes for an instance of the Half2 struct is 4.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector2h>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2h"/> struct.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The streaming context.</param>
        public Vector2h(SerializationInfo info, StreamingContext context)
        {
            X = (Half)info.GetValue("X", typeof(Half));
            Y = (Half)info.GetValue("Y", typeof(Half));
        }

        /// <inheritdoc/>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", X);
            info.AddValue("Y", Y);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("({0}{2} {1})", X, Y, MathHelper.ListSeparator);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Vector2h && Equals((Vector2h)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Vector2h other)
        {
            return X.Equals(other.X) &&
                   Y.Equals(other.Y);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        [Pure]
        public void Deconstruct(out Half x, out Half y)
        {
            x = X;
            y = Y;
        }
    }
}
