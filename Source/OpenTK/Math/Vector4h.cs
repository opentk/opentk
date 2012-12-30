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
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4h(Half value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4h(Single value)
        {
            X = new Half(value);
            Y = new Half(value);
            Z = new Half(value);
            W = new Half(value);
        }

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

        #region 2-component

        /// <summary>
        /// Gets an OpenTK.Vector2h with the X and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xx { get { return new Vector2h(X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xy { get { return new Vector2h(X, Y); } set { X = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xz { get { return new Vector2h(X, Z); } set { X = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xw { get { return new Vector2h(X, W); } set { X = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yx { get { return new Vector2h(Y, X); } set { Y = value.X; X = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2h with the Y and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yy { get { return new Vector2h(Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yz { get { return new Vector2h(Y, Z); } set { Y = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yw { get { return new Vector2h(Y, W); } set { Y = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zx { get { return new Vector2h(Z, X); } set { Z = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zy { get { return new Vector2h(Z, Y); } set { Z = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2h with the Z and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zz { get { return new Vector2h(Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector2h with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zw { get { return new Vector2h(Z, W); } set { Z = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Wx { get { return new Vector2h(W, X); } set { W = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Wy { get { return new Vector2h(W, Y); } set { W = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Wz { get { return new Vector2h(W, Z); } set { W = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2h with the W and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Ww { get { return new Vector2h(W, W); } }

        #endregion

        #region 3-component

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xxx { get { return new Vector3h(X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xxy { get { return new Vector3h(X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xxz { get { return new Vector3h(X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xxw { get { return new Vector3h(X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyx { get { return new Vector3h(X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyy { get { return new Vector3h(X, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyz { get { return new Vector3h(X, Y, Z); } set { X = value.X; Y = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyw { get { return new Vector3h(X, Y, W); } set { X = value.X; Y = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xzx { get { return new Vector3h(X, Z, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xzy { get { return new Vector3h(X, Z, Y); } set { X = value.X; Z = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xzz { get { return new Vector3h(X, Z, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xzw { get { return new Vector3h(X, Z, W); } set { X = value.X; Z = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xwx { get { return new Vector3h(X, W, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xwy { get { return new Vector3h(X, W, Y); } set { X = value.X; W = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xwz { get { return new Vector3h(X, W, Z); } set { X = value.X; W = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xww { get { return new Vector3h(X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yxx { get { return new Vector3h(Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yxy { get { return new Vector3h(Y, X, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yxz { get { return new Vector3h(Y, X, Z); } set { Y = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yxw { get { return new Vector3h(Y, X, W); } set { Y = value.X; X = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yyx { get { return new Vector3h(Y, Y, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yyy { get { return new Vector3h(Y, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yyz { get { return new Vector3h(Y, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yyw { get { return new Vector3h(Y, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yzx { get { return new Vector3h(Y, Z, X); } set { Y = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yzy { get { return new Vector3h(Y, Z, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yzz { get { return new Vector3h(Y, Z, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yzw { get { return new Vector3h(Y, Z, W); } set { Y = value.X; Z = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Ywx { get { return new Vector3h(Y, W, X); } set { Y = value.X; W = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Ywy { get { return new Vector3h(Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Ywz { get { return new Vector3h(Y, W, Z); } set { Y = value.X; W = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yww { get { return new Vector3h(Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zxx { get { return new Vector3h(Z, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zxy { get { return new Vector3h(Z, X, Y); } set { Z = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zxz { get { return new Vector3h(Z, X, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zxw { get { return new Vector3h(Z, X, W); } set { Z = value.X; X = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zyx { get { return new Vector3h(Z, Y, X); } set { Z = value.X; Y = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zyy { get { return new Vector3h(Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zyz { get { return new Vector3h(Z, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zyw { get { return new Vector3h(Z, Y, W); } set { Z = value.X; Y = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zzx { get { return new Vector3h(Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zzy { get { return new Vector3h(Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zzz { get { return new Vector3h(Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zzw { get { return new Vector3h(Z, Z, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zwx { get { return new Vector3h(Z, W, X); } set { Z = value.X; W = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zwy { get { return new Vector3h(Z, W, Y); } set { Z = value.X; W = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zwz { get { return new Vector3h(Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zww { get { return new Vector3h(Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wxx { get { return new Vector3h(W, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wxy { get { return new Vector3h(W, X, Y); } set { W = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wxz { get { return new Vector3h(W, X, Z); } set { W = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wxw { get { return new Vector3h(W, X, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wyx { get { return new Vector3h(W, Y, X); } set { W = value.X; Y = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wyy { get { return new Vector3h(W, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wyz { get { return new Vector3h(W, Y, Z); } set { W = value.X; Y = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wyw { get { return new Vector3h(W, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wzx { get { return new Vector3h(W, Z, X); } set { W = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wzy { get { return new Vector3h(W, Z, Y); } set { W = value.X; Z = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wzz { get { return new Vector3h(W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wzw { get { return new Vector3h(W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wwx { get { return new Vector3h(W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wwy { get { return new Vector3h(W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wwz { get { return new Vector3h(W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3h with the W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Www { get { return new Vector3h(W, W, W); } }

        #endregion

        #region 4-component

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxxx { get { return new Vector4h(X, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxxy { get { return new Vector4h(X, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxxz { get { return new Vector4h(X, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxxw { get { return new Vector4h(X, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxyx { get { return new Vector4h(X, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxyy { get { return new Vector4h(X, X, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxyz { get { return new Vector4h(X, X, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxyw { get { return new Vector4h(X, X, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxzx { get { return new Vector4h(X, X, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxzy { get { return new Vector4h(X, X, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxzz { get { return new Vector4h(X, X, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxzw { get { return new Vector4h(X, X, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxwx { get { return new Vector4h(X, X, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxwy { get { return new Vector4h(X, X, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxwz { get { return new Vector4h(X, X, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xxww { get { return new Vector4h(X, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyxx { get { return new Vector4h(X, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyxy { get { return new Vector4h(X, Y, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyxz { get { return new Vector4h(X, Y, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyxw { get { return new Vector4h(X, Y, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyyx { get { return new Vector4h(X, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyyy { get { return new Vector4h(X, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyyz { get { return new Vector4h(X, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyyw { get { return new Vector4h(X, Y, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyzx { get { return new Vector4h(X, Y, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyzy { get { return new Vector4h(X, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyzz { get { return new Vector4h(X, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xywx { get { return new Vector4h(X, Y, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xywy { get { return new Vector4h(X, Y, W, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xywz { get { return new Vector4h(X, Y, W, Z); } set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xyww { get { return new Vector4h(X, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzxx { get { return new Vector4h(X, Z, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzxy { get { return new Vector4h(X, Z, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzxz { get { return new Vector4h(X, Z, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzxw { get { return new Vector4h(X, Z, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzyx { get { return new Vector4h(X, Z, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzyy { get { return new Vector4h(X, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzyz { get { return new Vector4h(X, Z, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzyw { get { return new Vector4h(X, Z, Y, W); } set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzzx { get { return new Vector4h(X, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzzy { get { return new Vector4h(X, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzzz { get { return new Vector4h(X, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzzw { get { return new Vector4h(X, Z, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzwx { get { return new Vector4h(X, Z, W, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzwy { get { return new Vector4h(X, Z, W, Y); } set { X = value.X; Z = value.Y; W = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzwz { get { return new Vector4h(X, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzww { get { return new Vector4h(X, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwxx { get { return new Vector4h(X, W, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwxy { get { return new Vector4h(X, W, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwxz { get { return new Vector4h(X, W, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwxw { get { return new Vector4h(X, W, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwyx { get { return new Vector4h(X, W, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwyy { get { return new Vector4h(X, W, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwyz { get { return new Vector4h(X, W, Y, Z); } set { X = value.X; W = value.Y; Y = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwyw { get { return new Vector4h(X, W, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwzx { get { return new Vector4h(X, W, Z, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwzy { get { return new Vector4h(X, W, Z, Y); } set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwzz { get { return new Vector4h(X, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwzw { get { return new Vector4h(X, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwwx { get { return new Vector4h(X, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwwy { get { return new Vector4h(X, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwwz { get { return new Vector4h(X, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the X, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwww { get { return new Vector4h(X, W, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxxx { get { return new Vector4h(Y, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxxy { get { return new Vector4h(Y, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxxz { get { return new Vector4h(Y, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxxw { get { return new Vector4h(Y, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxyx { get { return new Vector4h(Y, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxyy { get { return new Vector4h(Y, X, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxyz { get { return new Vector4h(Y, X, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxyw { get { return new Vector4h(Y, X, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxzx { get { return new Vector4h(Y, X, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxzy { get { return new Vector4h(Y, X, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxzz { get { return new Vector4h(Y, X, Z, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxzw { get { return new Vector4h(Y, X, Z, W); } set { Y = value.X; X = value.Y; Z = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxwx { get { return new Vector4h(Y, X, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxwy { get { return new Vector4h(Y, X, W, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxwz { get { return new Vector4h(Y, X, W, Z); } set { Y = value.X; X = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxww { get { return new Vector4h(Y, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyxx { get { return new Vector4h(Y, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyxy { get { return new Vector4h(Y, Y, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyxz { get { return new Vector4h(Y, Y, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyxw { get { return new Vector4h(Y, Y, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyyx { get { return new Vector4h(Y, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyyy { get { return new Vector4h(Y, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyyz { get { return new Vector4h(Y, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyyw { get { return new Vector4h(Y, Y, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyzx { get { return new Vector4h(Y, Y, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyzy { get { return new Vector4h(Y, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyzz { get { return new Vector4h(Y, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyzw { get { return new Vector4h(Y, Y, Z, W); } set { X = value.X; Y = value.Y; Z = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yywx { get { return new Vector4h(Y, Y, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yywy { get { return new Vector4h(Y, Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yywz { get { return new Vector4h(Y, Y, W, Z); } set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyww { get { return new Vector4h(Y, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzxx { get { return new Vector4h(Y, Z, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzxy { get { return new Vector4h(Y, Z, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzxz { get { return new Vector4h(Y, Z, X, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzxw { get { return new Vector4h(Y, Z, X, W); } set { Y = value.X; Z = value.Y; X = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzyx { get { return new Vector4h(Y, Z, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzyy { get { return new Vector4h(Y, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzyz { get { return new Vector4h(Y, Z, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzyw { get { return new Vector4h(Y, Z, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzzx { get { return new Vector4h(Y, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzzy { get { return new Vector4h(Y, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzzz { get { return new Vector4h(Y, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzzw { get { return new Vector4h(Y, Z, Z, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzwx { get { return new Vector4h(Y, Z, W, X); } set { Y = value.X; Z = value.Y; W = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzwy { get { return new Vector4h(Y, Z, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzwz { get { return new Vector4h(Y, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzww { get { return new Vector4h(Y, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywxx { get { return new Vector4h(Y, W, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywxy { get { return new Vector4h(Y, W, X, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywxz { get { return new Vector4h(Y, W, X, Z); } set { Y = value.X; W = value.Y; X = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywxw { get { return new Vector4h(Y, W, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywyx { get { return new Vector4h(Y, W, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywyy { get { return new Vector4h(Y, W, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywyz { get { return new Vector4h(Y, W, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywyw { get { return new Vector4h(Y, W, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywzx { get { return new Vector4h(Y, W, Z, X); } set { Y = value.X; W = value.Y; Z = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywzy { get { return new Vector4h(Y, W, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywzz { get { return new Vector4h(Y, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywzw { get { return new Vector4h(Y, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywwx { get { return new Vector4h(Y, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywwy { get { return new Vector4h(Y, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywwz { get { return new Vector4h(Y, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Y, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywww { get { return new Vector4h(Y, W, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxxx { get { return new Vector4h(Z, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxxy { get { return new Vector4h(Z, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxxz { get { return new Vector4h(Z, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxxw { get { return new Vector4h(Z, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxyx { get { return new Vector4h(Z, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxyy { get { return new Vector4h(Z, X, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxyz { get { return new Vector4h(Z, X, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxyw { get { return new Vector4h(Z, X, Y, W); } set { Z = value.X; X = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxzx { get { return new Vector4h(Z, X, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxzy { get { return new Vector4h(Z, X, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxzz { get { return new Vector4h(Z, X, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxzw { get { return new Vector4h(Z, X, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxwx { get { return new Vector4h(Z, X, W, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxwy { get { return new Vector4h(Z, X, W, Y); } set { Z = value.X; X = value.Y; W = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxwz { get { return new Vector4h(Z, X, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxww { get { return new Vector4h(Z, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyxx { get { return new Vector4h(Z, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyxy { get { return new Vector4h(Z, Y, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyxz { get { return new Vector4h(Z, Y, X, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyxw { get { return new Vector4h(Z, Y, X, W); } set { Z = value.X; Y = value.Y; X = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyyx { get { return new Vector4h(Z, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyyy { get { return new Vector4h(Z, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyyz { get { return new Vector4h(Z, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyyw { get { return new Vector4h(Z, Y, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyzx { get { return new Vector4h(Z, Y, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyzy { get { return new Vector4h(Z, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyzz { get { return new Vector4h(Z, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyzw { get { return new Vector4h(Z, Y, Z, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zywx { get { return new Vector4h(Z, Y, W, X); } set { Z = value.X; Y = value.Y; W = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zywy { get { return new Vector4h(Z, Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zywz { get { return new Vector4h(Z, Y, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyww { get { return new Vector4h(Z, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzxx { get { return new Vector4h(Z, Z, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzxy { get { return new Vector4h(Z, Z, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzxz { get { return new Vector4h(Z, Z, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzxw { get { return new Vector4h(Z, Z, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzyx { get { return new Vector4h(Z, Z, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzyy { get { return new Vector4h(Z, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzyz { get { return new Vector4h(Z, Z, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzyw { get { return new Vector4h(Z, Z, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzzx { get { return new Vector4h(Z, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzzy { get { return new Vector4h(Z, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzzz { get { return new Vector4h(Z, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzzw { get { return new Vector4h(Z, Z, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzwx { get { return new Vector4h(Z, Z, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzwy { get { return new Vector4h(Z, Z, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzwz { get { return new Vector4h(Z, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zzww { get { return new Vector4h(Z, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwxx { get { return new Vector4h(Z, W, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwxy { get { return new Vector4h(Z, W, X, Y); } set { Z = value.X; W = value.Y; X = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwxz { get { return new Vector4h(Z, W, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwxw { get { return new Vector4h(Z, W, X, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwyx { get { return new Vector4h(Z, W, Y, X); } set { Z = value.X; W = value.Y; Y = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwyy { get { return new Vector4h(Z, W, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwyz { get { return new Vector4h(Z, W, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwyw { get { return new Vector4h(Z, W, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwzx { get { return new Vector4h(Z, W, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwzy { get { return new Vector4h(Z, W, Z, Y); } set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwzz { get { return new Vector4h(Z, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwzw { get { return new Vector4h(Z, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwwx { get { return new Vector4h(Z, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwwy { get { return new Vector4h(Z, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwwz { get { return new Vector4h(Z, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the Z, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwww { get { return new Vector4h(Z, W, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxxx { get { return new Vector4h(W, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxxy { get { return new Vector4h(W, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxxz { get { return new Vector4h(W, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxxw { get { return new Vector4h(W, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxyx { get { return new Vector4h(W, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxyy { get { return new Vector4h(W, X, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxyz { get { return new Vector4h(W, X, Y, Z); } set { W = value.X; X = value.Y; Y = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxyw { get { return new Vector4h(W, X, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxzx { get { return new Vector4h(W, X, Z, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxzy { get { return new Vector4h(W, X, Z, Y); } set { W = value.X; X = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxzz { get { return new Vector4h(W, X, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxzw { get { return new Vector4h(W, X, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxwx { get { return new Vector4h(W, X, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxwy { get { return new Vector4h(W, X, W, Y); } }

        /// <summary>
        /// Getss an OpenTK.Vector4h with the W, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxwz { get { return new Vector4h(W, X, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxww { get { return new Vector4h(W, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyxx { get { return new Vector4h(W, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyxy { get { return new Vector4h(W, Y, X, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyxz { get { return new Vector4h(W, Y, X, Z); } set { W = value.X; Y = value.Y; X = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyxw { get { return new Vector4h(W, Y, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyyx { get { return new Vector4h(W, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyyy { get { return new Vector4h(W, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyyz { get { return new Vector4h(W, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyyw { get { return new Vector4h(W, Y, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyzx { get { return new Vector4h(W, Y, Z, X); } set { W = value.X; Y = value.Y; Z = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyzy { get { return new Vector4h(W, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyzz { get { return new Vector4h(W, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyzw { get { return new Vector4h(W, Y, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wywx { get { return new Vector4h(W, Y, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wywy { get { return new Vector4h(W, Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wywz { get { return new Vector4h(W, Y, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyww { get { return new Vector4h(W, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzxx { get { return new Vector4h(W, Z, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzxy { get { return new Vector4h(W, Z, X, Y); } set { W = value.X; Z = value.Y; X = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzxz { get { return new Vector4h(W, Z, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzxw { get { return new Vector4h(W, Z, X, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzyx { get { return new Vector4h(W, Z, Y, X); } set { W = value.X; Z = value.Y; Y = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzyy { get { return new Vector4h(W, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzyz { get { return new Vector4h(W, Z, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzyw { get { return new Vector4h(W, Z, Y, W); } set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzzx { get { return new Vector4h(W, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzzy { get { return new Vector4h(W, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzzz { get { return new Vector4h(W, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzzw { get { return new Vector4h(W, Z, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzwx { get { return new Vector4h(W, Z, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzwy { get { return new Vector4h(W, Z, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzwz { get { return new Vector4h(W, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzww { get { return new Vector4h(W, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwxx { get { return new Vector4h(W, W, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwxy { get { return new Vector4h(W, W, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwxz { get { return new Vector4h(W, W, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwxw { get { return new Vector4h(W, W, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwyx { get { return new Vector4h(W, W, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwyy { get { return new Vector4h(W, W, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwyz { get { return new Vector4h(W, W, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwyw { get { return new Vector4h(W, W, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwzx { get { return new Vector4h(W, W, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwzy { get { return new Vector4h(W, W, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwzz { get { return new Vector4h(W, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwzw { get { return new Vector4h(W, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwwx { get { return new Vector4h(W, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwwy { get { return new Vector4h(W, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwwz { get { return new Vector4h(W, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4h with the W, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wwww { get { return new Vector4h(W, W, W, W); } }

        #endregion

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

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>Returns a string that contains this Half4's numbers in human-legible form.</summary>
        public override string ToString()
        {
            return String.Format("({0}{4} {1}{4} {2}{4} {3})", X.ToString(), Y.ToString(), Z.ToString(), W.ToString(), listSeparator);
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
