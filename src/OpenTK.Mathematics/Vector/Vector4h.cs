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
    /// 4-component Vector of the Half type. Occupies 8 Byte total.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4h : ISerializable, IEquatable<Vector4h>
    {
        /// <summary>
        /// The X component of the Half4.
        /// </summary>
        public Half X;

        /// <summary>
        /// The Y component of the Half4.
        /// </summary>
        public Half Y;

        /// <summary>
        /// The Z component of the Half4.
        /// </summary>
        public Half Z;

        /// <summary>
        /// The W component of the Half4.
        /// </summary>
        public Half W;

        /// <summary>
        /// Defines the size of the Vector4d struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Unsafe.SizeOf<Vector4h>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
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
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4h(float value)
        {
            X = (Half)value;
            Y = (Half)value;
            Z = (Half)value;
            W = (Half)value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector4h.</param>
        /// <param name="y">The y component of the Vector4h.</param>
        /// <param name="z">The z component of the Vector4h.</param>
        /// <param name="w">The w component of the Vector4h.</param>
        public Vector4h(Half x, Half y, Half z, Half w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="x">The x component of the Vector4h.</param>
        /// <param name="y">The y component of the Vector4h.</param>
        /// <param name="z">The z component of the Vector4h.</param>
        /// <param name="w">The w component of the Vector4h.</param>
        public Vector4h(float x, float y, float z, float w)
        {
            X = (Half)x;
            Y = (Half)y;
            Z = (Half)z;
            W = (Half)w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector4h.</param>
        /// <param name="z">The z component of the Vector4h.</param>
        /// <param name="w">The w component of the Vector4h.</param>
        public Vector4h(Vector2h xy, float z = default, float w = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = (Half)z;
            W = (Half)w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="xy">The x and y components of the Vector4h.</param>
        /// <param name="z">The z component of the Vector4h.</param>
        /// <param name="w">The w component of the Vector4h.</param>
        public Vector4h(Vector2h xy, Half z = default, Half w = default)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y and z components of the Vector4h.</param>
        /// <param name="w">The w component of the Vector4h.</param>
        public Vector4h(Vector3h xyz, float w = default)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = (Half)w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="xyz">The x, y and z components of the Vector4h.</param>
        /// <param name="w">The w component of the Vector4h.</param>
        public Vector4h(Vector3h xyz, Half w = default)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xy
        {
            get => Unsafe.As<Vector4h, Vector2h>(ref this);
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
        /// Gets or sets an OpenTK.Vector2h with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Xw
        {
            get => new Vector2h(X, W);
            set
            {
                X = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2h with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Yw
        {
            get => new Vector2h(Y, W);
            set
            {
                Y = value.X;
                W = value.Y;
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
        /// Gets or sets an OpenTK.Vector2h with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Zw
        {
            get => new Vector2h(Z, W);
            set
            {
                Z = value.X;
                W = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Wx
        {
            get => new Vector2h(W, X);
            set
            {
                W = value.X;
                X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Wy
        {
            get => new Vector2h(W, Y);
            set
            {
                W = value.X;
                Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2h with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2h Wz
        {
            get => new Vector2h(W, Z);
            set
            {
                W = value.X;
                Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyz
        {
            get => Unsafe.As<Vector4h, Vector3h>(ref this);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xyw
        {
            get => new Vector3h(X, Y, W);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3h with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xzw
        {
            get => new Vector3h(X, Z, W);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xwy
        {
            get => new Vector3h(X, W, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Xwz
        {
            get => new Vector3h(X, W, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3h with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yxw
        {
            get => new Vector3h(Y, X, W);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3h with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Yzw
        {
            get => new Vector3h(Y, Z, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Ywx
        {
            get => new Vector3h(Y, W, X);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Ywz
        {
            get => new Vector3h(Y, W, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
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
        /// Gets or sets an OpenTK.Vector3h with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zxw
        {
            get => new Vector3h(Z, X, W);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
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
        /// Gets or sets an OpenTK.Vector3h with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zyw
        {
            get => new Vector3h(Z, Y, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zwx
        {
            get => new Vector3h(Z, W, X);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Zwy
        {
            get => new Vector3h(Z, W, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wxy
        {
            get => new Vector3h(W, X, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wxz
        {
            get => new Vector3h(W, X, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wyx
        {
            get => new Vector3h(W, Y, X);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wyz
        {
            get => new Vector3h(W, Y, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wzx
        {
            get => new Vector3h(W, Z, X);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3h with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3h Wzy
        {
            get => new Vector3h(W, Z, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xywz
        {
            get => new Vector4h(X, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzyw
        {
            get => new Vector4h(X, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xzwy
        {
            get => new Vector4h(X, Z, W, Y);
            set
            {
                X = value.X;
                Z = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwyz
        {
            get => new Vector4h(X, W, Y, Z);
            set
            {
                X = value.X;
                W = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Xwzy
        {
            get => new Vector4h(X, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxzw
        {
            get => new Vector4h(Y, X, Z, W);
            set
            {
                Y = value.X;
                X = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yxwz
        {
            get => new Vector4h(Y, X, W, Z);
            set
            {
                Y = value.X;
                X = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yyzw
        {
            get => new Vector4h(Y, Y, Z, W);
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yywz
        {
            get => new Vector4h(Y, Y, W, Z);
            set
            {
                X = value.X;
                Y = value.Y;
                W = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzxw
        {
            get => new Vector4h(Y, Z, X, W);
            set
            {
                Y = value.X;
                Z = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Yzwx
        {
            get => new Vector4h(Y, Z, W, X);
            set
            {
                Y = value.X;
                Z = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywxz
        {
            get => new Vector4h(Y, W, X, Z);
            set
            {
                Y = value.X;
                W = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Ywzx
        {
            get => new Vector4h(Y, W, Z, X);
            set
            {
                Y = value.X;
                W = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxyw
        {
            get => new Vector4h(Z, X, Y, W);
            set
            {
                Z = value.X;
                X = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zxwy
        {
            get => new Vector4h(Z, X, W, Y);
            set
            {
                Z = value.X;
                X = value.Y;
                W = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zyxw
        {
            get => new Vector4h(Z, Y, X, W);
            set
            {
                Z = value.X;
                Y = value.Y;
                X = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zywx
        {
            get => new Vector4h(Z, Y, W, X);
            set
            {
                Z = value.X;
                Y = value.Y;
                W = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwxy
        {
            get => new Vector4h(Z, W, X, Y);
            set
            {
                Z = value.X;
                W = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwyx
        {
            get => new Vector4h(Z, W, Y, X);
            set
            {
                Z = value.X;
                W = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Zwzy
        {
            get => new Vector4h(Z, W, Z, Y);
            set
            {
                X = value.X;
                W = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxyz
        {
            get => new Vector4h(W, X, Y, Z);
            set
            {
                W = value.X;
                X = value.Y;
                Y = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wxzy
        {
            get => new Vector4h(W, X, Z, Y);
            set
            {
                W = value.X;
                X = value.Y;
                Z = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyxz
        {
            get => new Vector4h(W, Y, X, Z);
            set
            {
                W = value.X;
                Y = value.Y;
                X = value.Z;
                Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wyzx
        {
            get => new Vector4h(W, Y, Z, X);
            set
            {
                W = value.X;
                Y = value.Y;
                Z = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzxy
        {
            get => new Vector4h(W, Z, X, Y);
            set
            {
                W = value.X;
                Z = value.Y;
                X = value.Z;
                Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzyx
        {
            get => new Vector4h(W, Z, Y, X);
            set
            {
                W = value.X;
                Z = value.Y;
                Y = value.Z;
                X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4h with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4h Wzyw
        {
            get => new Vector4h(W, Z, Y, W);
            set
            {
                X = value.X;
                Z = value.Y;
                Y = value.Z;
                W = value.W;
            }
        }

        /// <summary>
        /// Returns this Half4 instance's contents as Vector4.
        /// </summary>
        /// <returns>The vector.</returns>
        public Vector4 ToVector4()
        {
            return new Vector4((float)X, (float)Y, (float)Z, (float)W);
        }

        /// <summary>
        /// Returns this Half4 instance's contents as Vector4d.
        /// </summary>
        /// <returns>The vector.</returns>
        public Vector4d ToVector4d()
        {
            return new Vector4d((double)X, (double)Y, (double)Z, (double)W);
        }

        /// <summary>
        /// Converts OpenTK.Vector4h to OpenTK.Vector4.
        /// </summary>
        /// <param name="vec">The Vector4h to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        [Pure]
        public static implicit operator Vector4(Vector4h vec)
        {
            return new Vector4((float)vec.X, (float)vec.Y, (float)vec.Z, (float)vec.W);
        }

        /// <summary>
        /// Converts OpenTK.Vector4h to OpenTK.Vector4d.
        /// </summary>
        /// <param name="vec">The Vector4h to convert.</param>
        /// <returns>The resulting Vector4d.</returns>
        [Pure]
        public static implicit operator Vector4d(Vector4h vec)
        {
            return new Vector4d((double)vec.X, (double)vec.Y, (double)vec.Z, (double)vec.W);
        }

        /// <summary>
        /// Converts OpenTK.Vector4h to OpenTK.Vector4i.
        /// </summary>
        /// <param name="vec">The Vector4h to convert.</param>
        /// <returns>The resulting Vector4i.</returns>
        [Pure]
        public static explicit operator Vector4i(Vector4h vec)
        {
            return new Vector4i((int)vec.X, (int)vec.Y, (int)vec.Z, (int)vec.W);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct using a tuple containing the component
        /// values.
        /// </summary>
        /// <param name="values">A tuple containing the component values.</param>
        /// <returns>A new instance of the <see cref="Vector4h"/> struct with the given component values.</returns>
        [Pure]
        public static implicit operator Vector4h((Half X, Half Y, Half Z, Half W) values)
        {
            return new Vector4h(values.X, values.Y, values.Z, values.W);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector4h left, Vector4h right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector4h left, Vector4h right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4h"/> struct.
        /// </summary>
        /// <param name="info">The serialization info.</param>
        /// <param name="context">The streaming context.</param>
        public Vector4h(SerializationInfo info, StreamingContext context)
        {
            X = (Half)info.GetValue("X", typeof(Half));
            Y = (Half)info.GetValue("Y", typeof(Half));
            Z = (Half)info.GetValue("Z", typeof(Half));
            W = (Half)info.GetValue("W", typeof(Half));
        }

        /// <inheritdoc />
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("X", X);
            info.AddValue("Y", Y);
            info.AddValue("Z", Z);
            info.AddValue("W", W);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format
            (
                "({0}{4} {1}{4} {2}{4} {3})",
                X.ToString(),
                Y.ToString(),
                Z.ToString(),
                W.ToString(),
                MathHelper.ListSeparator
            );
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Vector4h && Equals((Vector4h)obj);
        }

        /// <inheritdoc/>
        public bool Equals(Vector4h other)
        {
            return X.Equals(other.X) &&
                   Y.Equals(other.Y) &&
                   Z.Equals(other.Z) &&
                   W.Equals(other.W);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z, W);
        }

        /// <summary>
        /// Deconstructs the vector into it's individual components.
        /// </summary>
        /// <param name="x">The X component of the vector.</param>
        /// <param name="y">The Y component of the vector.</param>
        /// <param name="z">The Z component of the vector.</param>
        /// <param name="w">The W component of the vector.</param>
        [Pure]
        public void Deconstruct(out Half x, out Half y, out Half z, out Half w)
        {
            x = X;
            y = Y;
            z = Z;
            w = W;
        }
    }
}
