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
    /// <summary>Represents a 2D vector using two int-precision numbers.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2i : IEquatable<Vector2i>
    {
        #region Fields

        /// <summary>The X coordinate of this instance.</summary>
        public int X;

        /// <summary>The Y coordinate of this instance.</summary>
        public int Y;

        /// <summary>
        /// Defines a unit-length Vector2i that points towards the X-axis.
        /// </summary>
        public static readonly Vector2i UnitX = new Vector2i(1, 0);

        /// <summary>
        /// Defines a unit-length Vector2i that points towards the Y-axis.
        /// </summary>
        public static readonly Vector2i UnitY = new Vector2i(0, 1);

        /// <summary>
        /// Defines a zero-length Vector2i.
        /// </summary>
        public static readonly Vector2i Zero = new Vector2i(0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector2i One = new Vector2i(1, 1);

        /// <summary>
        /// Defines the size of the Vector2i struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector2i());

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2i(int value)
        {
            X = value;
            Y = value;
        }

        /// <summary>Constructs left vector with the given coordinates.</summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        public Vector2i(int x, int y)
        {
            this.X = x;
            this.Y = y;
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
                throw new IndexOutOfRangeException("You tried to access this vector at index: " + index);
            } set{
                if(index == 0) X = value;
                else if(index == 1) Y = value;
                else throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
            }
        }

        #region Instance

        #region public void Add()

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Add() method instead.")]
        public void Add(Vector2i right)
        {
            this.X += right.X;
            this.Y += right.Y;
        }

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Add() method instead.")]
        public void Add(ref Vector2i right)
        {
            this.X += right.X;
            this.Y += right.Y;
        }

        #endregion public void Add()

        #region public void Sub()

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(Vector2i right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
        }

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(ref Vector2i right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
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
        }

        #endregion public void Mult()

        #region public void Div()

        /// <summary>Divide this instance by a scalar.</summary>
        /// <param name="f">Scalar operand.</param>
        [Obsolete("Use static Divide() method instead.")]
        public void Div(int f)
        {
            this.X /= f;
            this.Y /= f;
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
                return System.Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion

        #region public int LengthSquared

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
                return X * X + Y * Y;
            }
        }

        #endregion

        #region public Vector2i PerpendicularRight

        /// <summary>
        /// Gets the perpendicular vector on the right side of this vector.
        /// </summary>
        public Vector2i PerpendicularRight
        {
            get
            {
                return new Vector2i(Y, -X);
            }
        }

        #endregion

        #region public Vector2i PerpendicularLeft

        /// <summary>
        /// Gets the perpendicular vector on the left side of this vector.
        /// </summary>
        public Vector2i PerpendicularLeft
        {
            get
            {
                return new Vector2i(-Y, X);
            }
        }

        #endregion

        /// <summary>
        /// Returns a copy of the Vector2i scaled to unit length.
        /// </summary>
        /// <returns></returns>
        public Vector2i Normalized()
        {
            Vector2i v = this;
            v.Normalize();
            return v;
        }

        #region public void Normalize()

        /// <summary>
        /// Scales the Vector2 to unit length.
        /// </summary>
        public void Normalize()
        {
            if (Math.Abs(this.X) > Math.Abs(this.Y)) {
                this.X = Math.Sign(this.X);
                this.Y = 0;
            } else {
                this.X = 0;
                this.Y = Math.Sign(this.X);
            }
        }

        #endregion

        #region public void Scale()

        /// <summary>
        /// Scales the current Vector2 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(int sx, int sy)
        {
            X *= sx;
            Y *= sy;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(Vector2i scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(ref Vector2i scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
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
        public static Vector2i Sub(Vector2i a, Vector2i b)
        {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
        }

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">Result of subtraction</param>
        [Obsolete("Use static Subtract() method instead.")]
        public static void Sub(ref Vector2i a, ref Vector2i b, out Vector2i result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
        }

        #endregion

        #region Mult

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="d">Scalar operand</param>
        /// <returns>Result of the multiplication</returns>
        [Obsolete("Use static Multiply() method instead.")]
        public static Vector2i Mult(Vector2i a, int d)
        {
            a.X *= d;
            a.Y *= d;
            return a;
        }

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="d">Scalar operand</param>
        /// <param name="result">Result of the multiplication</param>
        [Obsolete("Use static Multiply() method instead.")]
        public static void Mult(ref Vector2i a, int d, out Vector2i result)
        {
            result.X = a.X * d;
            result.Y = a.Y * d;
        }

        #endregion

        #region Div

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="d">Scalar operand</param>
        /// <returns>Result of the division</returns>
        [Obsolete("Use static Divide() method instead.")]
        public static Vector2i Div(Vector2i a, int d)
        {
            a.X /= d;
            a.Y /= d;
            return a;
        }

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="d">Scalar operand</param>
        /// <param name="result">Result of the division</param>
        [Obsolete("Use static Divide() method instead.")]
        public static void Div(ref Vector2i a, int d, out Vector2i result)
        {
            result.X = a.X / d;
            result.Y = a.Y / d;
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
        public static Vector2i Add(Vector2i a, Vector2i b)
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
        public static void Add(ref Vector2i a, ref Vector2i b, out Vector2i result)
        {
            result = new Vector2i(a.X + b.X, a.Y + b.Y);
        }

        #endregion

        #region Subtract

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        public static Vector2i Subtract(Vector2i a, Vector2i b)
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
        public static void Subtract(ref Vector2i a, ref Vector2i b, out Vector2i result)
        {
            result = new Vector2i(a.X - b.X, a.Y - b.Y);
        }

        #endregion

        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector2i Multiply(Vector2i vector, int scale)
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
        public static void Multiply(ref Vector2i vector, int scale, out Vector2i result)
        {
            result = new Vector2i(vector.X * scale, vector.Y * scale);
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector2i Multiply(Vector2i vector, Vector2i scale)
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
        public static void Multiply(ref Vector2i vector, ref Vector2i scale, out Vector2i result)
        {
            result = new Vector2i(vector.X * scale.X, vector.Y * scale.Y);
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector2i Divide(Vector2i vector, int scale)
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
        public static void Divide(ref Vector2i vector, int scale, out Vector2i result)
        {
            result = new Vector2i(vector.X / scale, vector.Y / scale);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector2i Divide(Vector2i vector, Vector2i scale)
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
        public static void Divide(ref Vector2i vector, ref Vector2i scale, out Vector2i result)
        {
            result = new Vector2i(vector.X / scale.X, vector.Y / scale.Y);
        }

        #endregion

        #region Min

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise minimum</returns>
        public static Vector2i Min(Vector2i a, Vector2i b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise minimum</param>
        public static void Min(ref Vector2i a, ref Vector2i b, out Vector2i result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
        }

        #endregion

        #region Max

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise maximum</returns>
        public static Vector2i Max(Vector2i a, Vector2i b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise maximum</param>
        public static void Max(ref Vector2i a, ref Vector2i b, out Vector2i result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
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
        public static Vector2i Clamp(Vector2i vec, Vector2i min, Vector2i max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector2i vec, ref Vector2i min, ref Vector2i max, out Vector2i result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector2i Normalize(Vector2i vec)
        {
            if (Math.Abs(vec.X) > Math.Abs(vec.Y)) {
                vec.X = Math.Sign(vec.X);
                vec.Y = 0;
            } else {
                vec.X = 0;
                vec.Y = Math.Sign(vec.X);
            }
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector2i vec, out Vector2i result)
        {
            if (Math.Abs(vec.X) > Math.Abs(vec.Y)) {
                result.X = Math.Sign(vec.X);
                result.Y = 0;
            } else {
                result.X = 0;
                result.Y = Math.Sign(vec.X);
            }
        }

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The dot product of the two inputs</returns>
        public static int Dot(Vector2i left, Vector2i right)
        {
            return left.X * right.X + left.Y * right.Y;
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <param name="result">The dot product of the two inputs</param>
        public static void Dot(ref Vector2i left, ref Vector2i right, out int result)
        {
            result = left.X * right.X + left.Y * right.Y;
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
        public static Vector2i Lerp(Vector2i a, Vector2i b, double blend)
        {
            a.X = (int)(blend * (b.X - a.X) + a.X);
            a.Y = (int)(blend * (b.Y - a.Y) + a.Y);
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector2i a, ref Vector2i b, double blend, out Vector2i result)
        {
            result.X = (int)(blend * (b.X - a.X) + a.X);
            result.Y = (int)(blend * (b.Y - a.Y) + a.Y);
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
        public static Vector2i BaryCentric(Vector2i a, Vector2i b, Vector2i c, int u, int v)
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
        public static void BaryCentric(ref Vector2i a, ref Vector2i b, ref Vector2i c, int u, int v, out Vector2i result)
        {
            result = a; // copy

            Vector2i temp = b; // copy
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

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Yx { get { return new Vector2i(Y, X); } set { Y = value.X; X = value.Y; } }

        #endregion

        #region Operators

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector2i operator +(Vector2i left, Vector2i right)
        {
            left.X += right.X;
            left.Y += right.Y;
            return left;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector2i operator -(Vector2i left, Vector2i right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            return left;
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector2i operator -(Vector2i vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="s">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector2i operator *(Vector2i vec, int s)
        {
            vec.X *= s;
            vec.Y *= s;
            return vec;
        }

        /// <summary>
        /// Multiply an instance by a scalar.
        /// </summary>
        /// <param name="s">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector2i operator *(int s, Vector2i vec)
        {
            vec.X *= s;
            vec.Y *= s;
            return vec;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="s">The scalar.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector2i operator /(Vector2i vec, int s)
        {
            vec.X /= s;
            vec.Y /= s;
            return vec;
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>True, if both instances are equal; false otherwise.</returns>
        public static bool operator ==(Vector2i left, Vector2i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for ienquality.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>True, if the instances are not equal; false otherwise.</returns>
        public static bool operator !=(Vector2i left, Vector2i right)
        {
            return !left.Equals(right);
        }

        /// <summary>Converts OpenTK.Vector2 to OpenTK.Vector2i.</summary>
        /// <param name="v2">The Vector2 to convert.</param>
        /// <returns>The resulting Vector2i.</returns>
        public static explicit operator Vector2i(Vector2 v2)
        {
            return new Vector2i((int)v2.X, (int)v2.Y);
        }

        /// <summary>Converts OpenTK.Vector2i to OpenTK.Vector2.</summary>
        /// <param name="v2d">The Vector2i to convert.</param>
        /// <returns>The resulting Vector2.</returns>
        public static explicit operator Vector2(Vector2i v2d)
        {
            return new Vector2((float)v2d.X, (float)v2d.Y);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>
        /// Returns a System.String that represents the current instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("({0}{2} {1})", X, Y, listSeparator);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
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
            if (!(obj is Vector2i))
                return false;

            return this.Equals((Vector2i)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Vector2i> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector2i other)
        {
            return
                X == other.X &&
                Y == other.Y;
        }

        #endregion
    }
}