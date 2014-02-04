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
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenTK
{
    /// <summary>Represents a 4D vector using four int-precision floating-point numbers.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4i : IEquatable<Vector4i>
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector4i.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y component of the Vector4i.
        /// </summary>
        public int Y;

        /// <summary>
        /// The Z component of the Vector4i.
        /// </summary>
        public int Z;

        /// <summary>
        /// The W component of the Vector4i.
        /// </summary>
        public int W;

        /// <summary>
        /// Defines a unit-length Vector4i that points towards the X-axis.
        /// </summary>
        public static readonly Vector4i UnitX = new Vector4i(1, 0, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4i that points towards the Y-axis.
        /// </summary>
        public static readonly Vector4i UnitY = new Vector4i(0, 1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4i that points towards the Z-axis.
        /// </summary>
        public static readonly Vector4i UnitZ = new Vector4i(0, 0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector4i that points towards the W-axis.
        /// </summary>
        public static readonly Vector4i UnitW = new Vector4i(0, 0, 0, 1);

        /// <summary>
        /// Defines a zero-length Vector4i.
        /// </summary>
        public static readonly Vector4i Zero = new Vector4i(0, 0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4i One = new Vector4i(1, 1, 1, 1);

        /// <summary>
        /// Defines the size of the Vector4i struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector4i());

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4i(int value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Constructs a new Vector4i.
        /// </summary>
        /// <param name="x">The x component of the Vector4i.</param>
        /// <param name="y">The y component of the Vector4i.</param>
        /// <param name="z">The z component of the Vector4i.</param>
        /// <param name="w">The w component of the Vector4i.</param>
        public Vector4i(int x, int y, int z, int w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Constructs a new Vector4i from the given Vector2i.
        /// </summary>
        /// <param name="v">The Vector2i to copy components from.</param>
        public Vector4i(Vector2i v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0;
            W = 0;
        }

        /// <summary>
        /// Constructs a new Vector4i from the given Vector3i.
        /// The w component is initialized to 0.
        /// </summary>
        /// <param name="v">The Vector3i to copy components from.</param>
        /// <remarks><seealso cref="Vector4i(Vector3i, int)"/></remarks>
        public Vector4i(Vector3i v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0;
        }

        /// <summary>
        /// Constructs a new Vector4i from the specified Vector3i and w component.
        /// </summary>
        /// <param name="v">The Vector3i to copy components from.</param>
        /// <param name="w">The w component of the new Vector4.</param>
        public Vector4i(Vector3i v, int w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        /// <summary>
        /// Constructs a new Vector4i from the given Vector4i.
        /// </summary>
        /// <param name="v">The Vector4i to copy components from.</param>
        public Vector4i(Vector4i v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = v.W;
        }

        #endregion

        #region Public Members
        
        /// <summary>
        /// Gets or sets the value at the index of the Vector.
        /// </summary>
        public int this[int index] {
            get{
                if(index == 0) return X;
                else if(index == 1) return Y;
                else if(index == 2) return Z;
                else if(index == 3) return W;
                throw new IndexOutOfRangeException("You tried to access this vector at index: " + index);
            } set{
                if(index == 0) X = value;
                else if(index == 1) Y = value;
                else if(index == 2) Z = value;
                else if(index == 3) W = value;
                else throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
            }
        }

        #region Instance

        #region public void Add()

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Add() method instead.")]
        public void Add(Vector4i right)
        {
            this.X += right.X;
            this.Y += right.Y;
            this.Z += right.Z;
            this.W += right.W;
        }

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Add() method instead.")]
        public void Add(ref Vector4i right)
        {
            this.X += right.X;
            this.Y += right.Y;
            this.Z += right.Z;
            this.W += right.W;
        }

        #endregion public void Add()

        #region public void Sub()

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(Vector4i right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
            this.Z -= right.Z;
            this.W -= right.W;
        }

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(ref Vector4i right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
            this.Z -= right.Z;
            this.W -= right.W;
        }

        #endregion public void Sub()

        #region public void Mult()

        /// <summary>Multiply this instance by a scalar.</summary>
        /// <param name="f">Scalar operand.</param>
        [Obsolete("Use static Multiply() method instead.")]
        public void Mult(int f)
        {
            this.X *= f;
            this.Y *= f;
            this.Z *= f;
            this.W *= f;
        }

        #endregion public void Mult()

        #region public void Div()

        /// <summary>Divide this instance by a scalar.</summary>
        /// <param name="s">Scalar operand.</param>
        [Obsolete("Use static Divide() method instead.")]
        public void Div(int s)
        {
			this.X /= s;
			this.Y /= s;
			this.Z /= s;
			this.W /= s;
        }

        #endregion public void Div()

        #region public int Length

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
            }
        }

        #endregion

        #region public double LengthSquared

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
		public double LengthSquared
        {
            get
            {
                return X * X + Y * Y + Z * Z + W * W;
            }
        }

        #endregion

        /// <summary>
        /// Returns a copy of the Vector4i scaled to unit length.
        /// </summary>
        public Vector4i Normalized()
        {
            Vector4i v = this;
            v.Normalize();
            return v;
        }

        #region public void Normalize()

        /// <summary>
        /// Scales the Vector4i to unit length.
        /// </summary>
		public void Normalize()
		{
			int AbsX = Math.Abs(X);
			int AbsY = Math.Abs(Y);
			int AbsZ = Math.Abs(Z);
			int AbsW = Math.Abs(W);

			if (AbsX > AbsY && AbsX > AbsZ && AbsX > AbsW) {
				X = 1;
				Y = 0;
				Z = 0;
				W = 0;
			} else if (AbsY > AbsX && AbsY > AbsZ && AbsY > AbsW) {
				X = 0;
				Y = 1;
				Z = 0;
				W = 0;
			} else if (AbsZ > AbsY && AbsZ > AbsX && AbsZ > AbsW) {
				X = 0;
				Y = 0;
				Z = 1;
				W = 0;
			} else {
				X = 0;
				Y = 0;
				Z = 0;
				W = 1;
			}
		}

        #endregion

        #region public void Scale()

        /// <summary>
        /// Scales the current Vector4i by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        /// <param name="sw">The scale of the Z component.</param>
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(int sx, int sy, int sz, int sw)
        {
            this.X = X * sx;
            this.Y = Y * sy;
            this.Z = Z * sz;
            this.W = W * sw;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(Vector4i scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
            this.Z *= scale.Z;
            this.W *= scale.W;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(ref Vector4i scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
            this.Z *= scale.Z;
            this.W *= scale.W;
        }

        #endregion public void Scale()

        #endregion

        #region Static

        #region Obsolete

        #region Sub

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        [Obsolete("Use static Subtract() method instead.")]
        public static Vector4i Sub(Vector4i a, Vector4i b)
        {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            a.W -= b.W;
            return a;
        }

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">Result of subtraction</param>
        [Obsolete("Use static Subtract() method instead.")]
        public static void Sub(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
            result.W = a.W - b.W;
        }

        #endregion

        #region Mult

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <returns>Result of the multiplication</returns>
        [Obsolete("Use static Multiply() method instead.")]
        public static Vector4i Mult(Vector4i a, int f)
        {
            a.X *= f;
            a.Y *= f;
            a.Z *= f;
            a.W *= f;
            return a;
        }

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <param name="result">Result of the multiplication</param>
        [Obsolete("Use static Multiply() method instead.")]
        public static void Mult(ref Vector4i a, int f, out Vector4i result)
        {
            result.X = a.X * f;
            result.Y = a.Y * f;
            result.Z = a.Z * f;
            result.W = a.W * f;
        }

        #endregion

        #region Div

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
		/// <param name="s">Scalar operand</param>
        /// <returns>Result of the division</returns>
        [Obsolete("Use static Divide() method instead.")]
        public static Vector4i Div(Vector4i a, int s)
        {
			a.X /= s;
			a.Y /= s;
			a.Z /= s;
			a.W /= s;
            return a;
        }

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
		/// <param name="s">Scalar operand</param>
        /// <param name="result">Result of the division</param>
        [Obsolete("Use static Divide() method instead.")]
		public static void Div(ref Vector4i a, int s, out Vector4i result)
        {
			result.X = a.X / s;
			result.Y = a.Y / s;
			result.Z = a.Z / s;
			result.W = a.W / s;
        }

        #endregion

        #endregion

        #region Add

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <returns>Result of operation.</returns>
        public static Vector4i Add(Vector4i a, Vector4i b)
        {
            Add(ref a, ref b, out a);
            return a;
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">Left operand.</param>
        /// <param name="b">Right operand.</param>
        /// <param name="result">Result of operation.</param>
        public static void Add(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result = new Vector4i(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }

        #endregion

        #region Subtract

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        public static Vector4i Subtract(Vector4i a, Vector4i b)
        {
            Subtract(ref a, ref b, out a);
            return a;
        }

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">Result of subtraction</param>
        public static void Subtract(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result = new Vector4i(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }

        #endregion

        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4i Multiply(Vector4i vector, int scale)
        {
            Multiply(ref vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector4i vector, int scale, out Vector4i result)
        {
            result = new Vector4i(vector.X * scale, vector.Y * scale, vector.Z * scale, vector.W * scale);
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4i Multiply(Vector4i vector, Vector4i scale)
        {
            Multiply(ref vector, ref scale, out vector);
            return vector;
        }

        /// <summary>
        /// Multiplies a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector4i vector, ref Vector4i scale, out Vector4i result)
        {
            result = new Vector4i(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z, vector.W * scale.W);
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4i Divide(Vector4i vector, int scale)
        {
            Divide(ref vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(ref Vector4i vector, int scale, out Vector4i result)
        {
			result = new Vector4i(vector.X / scale, vector.Y / scale, vector.Z / scale, vector.W / scale);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4i Divide(Vector4i vector, Vector4i scale)
        {
            Divide(ref vector, ref scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divide a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(ref Vector4i vector, ref Vector4i scale, out Vector4i result)
        {
            result = new Vector4i(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z, vector.W / scale.W);
        }

        #endregion

        #region Min

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise minimum</returns>
        public static Vector4i Min(Vector4i a, Vector4i b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            a.W = a.W < b.W ? a.W : b.W;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise minimum</param>
        public static void Min(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
            result.W = a.W < b.W ? a.W : b.W;
        }

        #endregion

        #region Max

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise maximum</returns>
        public static Vector4i Max(Vector4i a, Vector4i b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            a.W = a.W > b.W ? a.W : b.W;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise maximum</param>
        public static void Max(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
            result.W = a.W > b.W ? a.W : b.W;
        }

        #endregion

        #region Clamp

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <returns>The clamped vector</returns>
        public static Vector4i Clamp(Vector4i vec, Vector4i min, Vector4i max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            vec.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector4i vec, ref Vector4i min, ref Vector4i max, out Vector4i result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            result.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector4i Normalize(Vector4i vec)
        {
			return vec.Normalized();
        }

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector4i vec, out Vector4i result)
        {
			result = vec.Normalized();
        }

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The dot product of the two inputs</returns>
        public static int Dot(Vector4i left, Vector4i right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <param name="result">The dot product of the two inputs</param>
        public static void Dot(ref Vector4i left, ref Vector4i right, out int result)
        {
            result = left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
        }

        #endregion

        #region Lerp

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise</returns>
        public static Vector4i Lerp(Vector4i a, Vector4i b, double blend)
        {
            a.X = (int)(blend * (b.X - a.X) + a.X);
			a.Y = (int)(blend * (b.Y - a.Y) + a.Y);
            a.Z = (int)(blend * (b.Z - a.Z) + a.Z);
            a.W = (int)(blend * (b.W - a.W) + a.W);
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector4i a, ref Vector4i b, double blend, out Vector4i result)
        {
            result.X = (int)(blend * (b.X - a.X) + a.X);
            result.Y = (int)(blend * (b.Y - a.Y) + a.Y);
            result.Z = (int)(blend * (b.Z - a.Z) + a.Z);
            result.W = (int)(blend * (b.W - a.W) + a.W);
        }

        #endregion

        #region Barycentric

        /// <summary>
        /// Interpolate 3 Vectors using Barycentric coordinates
        /// </summary>
        /// <param name="a">First input Vector</param>
        /// <param name="b">Second input Vector</param>
        /// <param name="c">Third input Vector</param>
        /// <param name="u">First Barycentric Coordinate</param>
        /// <param name="v">Second Barycentric Coordinate</param>
        /// <returns>a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise</returns>
        public static Vector4i BaryCentric(Vector4i a, Vector4i b, Vector4i c, int u, int v)
        {
            return a + u * (b - a) + v * (c - a);
        }

        /// <summary>Interpolate 3 Vectors using Barycentric coordinates</summary>
        /// <param name="a">First input Vector.</param>
        /// <param name="b">Second input Vector.</param>
        /// <param name="c">Third input Vector.</param>
        /// <param name="u">First Barycentric Coordinate.</param>
        /// <param name="v">Second Barycentric Coordinate.</param>
        /// <param name="result">Output Vector. a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise</param>
        public static void BaryCentric(ref Vector4i a, ref Vector4i b, ref Vector4i c, int u, int v, out Vector4i result)
        {
            result = a; // copy

            Vector4i temp = b; // copy
            Subtract(ref temp, ref a, out temp);
            Multiply(ref temp, u, out temp);
            Add(ref result, ref temp, out result);

            temp = c; // copy
            Subtract(ref temp, ref a, out temp);
            Multiply(ref temp, v, out temp);
            Add(ref result, ref temp, out result);
        }

        #endregion

        #endregion

        #region Swizzle

        #region 2-component

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Xy { get { return new Vector2i(X, Y); } set { X = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Xz { get { return new Vector2i(X, Z); } set { X = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Xw { get { return new Vector2i(X, W); } set { X = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yx { get { return new Vector2i(Y, X); } set { Y = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yz { get { return new Vector2i(Y, Z); } set { Y = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yw { get { return new Vector2i(Y, W); } set { Y = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zx { get { return new Vector2i(Z, X); } set { Z = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zy { get { return new Vector2i(Z, Y); } set { Z = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2i with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zw { get { return new Vector2i(Z, W); } set { Z = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Wx { get { return new Vector2i(W, X); } set { W = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Wy { get { return new Vector2i(W, Y); } set { W = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Wz { get { return new Vector2i(W, Z); } set { W = value.X; Z = value.Y; } }

        #endregion

        #region 3-component

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xyz { get { return new Vector3i(X, Y, Z); } set { X = value.X; Y = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xyw { get { return new Vector3i(X, Y, W); } set { X = value.X; Y = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xzy { get { return new Vector3i(X, Z, Y); } set { X = value.X; Z = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xzw { get { return new Vector3i(X, Z, W); } set { X = value.X; Z = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xwy { get { return new Vector3i(X, W, Y); } set { X = value.X; W = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xwz { get { return new Vector3i(X, W, Z); } set { X = value.X; W = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yxz { get { return new Vector3i(Y, X, Z); } set { Y = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yxw { get { return new Vector3i(Y, X, W); } set { Y = value.X; X = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yzx { get { return new Vector3i(Y, Z, X); } set { Y = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yzw { get { return new Vector3i(Y, Z, W); } set { Y = value.X; Z = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Ywx { get { return new Vector3i(Y, W, X); } set { Y = value.X; W = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3i with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Ywz { get { return new Vector3i(Y, W, Z); } set { Y = value.X; W = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zxy { get { return new Vector3i(Z, X, Y); } set { Z = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zxw { get { return new Vector3i(Z, X, W); } set { Z = value.X; X = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zyx { get { return new Vector3i(Z, Y, X); } set { Z = value.X; Y = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zyw { get { return new Vector3i(Z, Y, W); } set { Z = value.X; Y = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zwx { get { return new Vector3i(Z, W, X); } set { Z = value.X; W = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zwy { get { return new Vector3i(Z, W, Y); } set { Z = value.X; W = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wxy { get { return new Vector3i(W, X, Y); } set { W = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wxz { get { return new Vector3i(W, X, Z); } set { W = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wyx { get { return new Vector3i(W, Y, X); } set { W = value.X; Y = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wyz { get { return new Vector3i(W, Y, Z); } set { W = value.X; Y = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wzx { get { return new Vector3i(W, Z, X); } set { W = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Wzy { get { return new Vector3i(W, Z, Y); } set { W = value.X; Z = value.Y; Y = value.Z; } }

        #endregion

        #region 4-component

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xywz { get { return new Vector4i(X, Y, W, Z); } set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xzyw { get { return new Vector4i(X, Z, Y, W); } set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xzwy { get { return new Vector4i(X, Z, W, Y); } set { X = value.X; Z = value.Y; W = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xwyz { get { return new Vector4i(X, W, Y, Z); } set { X = value.X; W = value.Y; Y = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Xwzy { get { return new Vector4i(X, W, Z, Y); } set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yxzw { get { return new Vector4i(Y, X, Z, W); } set { Y = value.X; X = value.Y; Z = value.Z; W = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yxwz { get { return new Vector4i(Y, X, W, Z); } set { Y = value.X; X = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4i with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yyzw { get { return new Vector4i(Y, Y, Z, W); } set { X = value.X; Y = value.Y; Z = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4i with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yywz { get { return new Vector4i(Y, Y, W, Z); } set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yzxw { get { return new Vector4i(Y, Z, X, W); } set { Y = value.X; Z = value.Y; X = value.Z; W = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Yzwx { get { return new Vector4i(Y, Z, W, X); } set { Y = value.X; Z = value.Y; W = value.Z; X = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Ywxz { get { return new Vector4i(Y, W, X, Z); } set { Y = value.X; W = value.Y; X = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Ywzx { get { return new Vector4i(Y, W, Z, X); } set { Y = value.X; W = value.Y; Z = value.Z; X = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zxyw { get { return new Vector4i(Z, X, Y, W); } set { Z = value.X; X = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zxwy { get { return new Vector4i(Z, X, W, Y); } set { Z = value.X; X = value.Y; W = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zyxw { get { return new Vector4i(Z, Y, X, W); } set { Z = value.X; Y = value.Y; X = value.Z; W = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zywx { get { return new Vector4i(Z, Y, W, X); } set { Z = value.X; Y = value.Y; W = value.Z; X = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zwxy { get { return new Vector4i(Z, W, X, Y); } set { Z = value.X; W = value.Y; X = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zwyx { get { return new Vector4i(Z, W, Y, X); } set { Z = value.X; W = value.Y; Y = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4i with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Zwzy { get { return new Vector4i(Z, W, Z, Y); } set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wxyz { get { return new Vector4i(W, X, Y, Z); } set { W = value.X; X = value.Y; Y = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wxzy { get { return new Vector4i(W, X, Z, Y); } set { W = value.X; X = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wyxz { get { return new Vector4i(W, Y, X, Z); } set { W = value.X; Y = value.Y; X = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wyzx { get { return new Vector4i(W, Y, Z, X); } set { W = value.X; Y = value.Y; Z = value.Z; X = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wzxy { get { return new Vector4i(W, Z, X, Y); } set { W = value.X; Z = value.Y; X = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4i with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wzyx { get { return new Vector4i(W, Z, Y, X); } set { W = value.X; Z = value.Y; Y = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4i with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4i Wzyw { get { return new Vector4i(W, Z, Y, W); } set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4i operator +(Vector4i left, Vector4i right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            left.W += right.W;
            return left;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4i operator -(Vector4i left, Vector4i right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            left.W -= right.W;
            return left;
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4i operator -(Vector4i vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            vec.W = -vec.W;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4i operator *(Vector4i vec, int scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4i operator *(int scale, Vector4i vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4i operator /(Vector4i vec, int scale)
        {
			vec.X /= scale;
			vec.Y /= scale;
			vec.Z /= scale;
			vec.W /= scale;
            return vec;
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector4i left, Vector4i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector4i left, Vector4i right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a pointer to the first element of the specified instance.
        /// </summary>
        /// <param name="v">The instance.</param>
        /// <returns>A pointer to the first element of v.</returns>
        [CLSCompliant(false)]
        unsafe public static explicit operator int*(Vector4i v)
        {
            return &v.X;
        }

        /// <summary>
        /// Returns a pointer to the first element of the specified instance.
        /// </summary>
        /// <param name="v">The instance.</param>
        /// <returns>A pointer to the first element of v.</returns>
        public static explicit operator IntPtr(Vector4i v)
        {
            unsafe
            {
                return (IntPtr)(&v.X);
            }
        }

        /// <summary>Converts OpenTK.Vector4 to OpenTK.Vector4i.</summary>
        /// <param name="v4">The Vector4 to convert.</param>
        /// <returns>The resulting Vector4i.</returns>
        public static explicit operator Vector4i(Vector4 v4)
        {
            return new Vector4i((int)v4.X, (int)v4.Y, (int)v4.Z, (int)v4.W);
        }

        /// <summary>Converts OpenTK.Vector4i to OpenTK.Vector4.</summary>
        /// <param name="v4d">The Vector4i to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        public static explicit operator Vector4(Vector4i v4d)
        {
            return new Vector4((float)v4d.X, (float)v4d.Y, (float)v4d.Z, (float)v4d.W);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>
        /// Returns a System.String that represents the current Vector4i.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("({0}{4} {1}{4} {2}{4} {3})", X, Y, Z, W, listSeparator);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode() ^ W.GetHashCode();
        }

        #endregion

        #region public override bool Equals(object obj)

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Vector4i))
                return false;

            return this.Equals((Vector4i)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Vector4i> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector4i other)
        {
            return
                X == other.X &&
                Y == other.Y &&
                Z == other.Z &&
                W == other.W;
        }

        #endregion
    }
}