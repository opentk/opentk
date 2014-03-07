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
    /// <summary>
    /// Represents a 3D vector using three int-precision floating-point numbers.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3i : IEquatable<Vector3i>
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector3.
        /// </summary>
        public int X;

        /// <summary>
        /// The Y component of the Vector3.
        /// </summary>
        public int Y;

        /// <summary>
        /// The Z component of the Vector3.
        /// </summary>
        public int Z;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector3i(int value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Constructs a new Vector3.
        /// </summary>
        /// <param name="x">The x component of the Vector3.</param>
        /// <param name="y">The y component of the Vector3.</param>
        /// <param name="z">The z component of the Vector3.</param>
        public Vector3i(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Constructs a new instance from the given Vector2i.
        /// </summary>
        /// <param name="v">The Vector2i to copy components from.</param>
        public Vector3i(Vector2i v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0;
        }

        /// <summary>
        /// Constructs a new instance from the given Vector3i.
        /// </summary>
        /// <param name="v">The Vector3i to copy components from.</param>
        public Vector3i(Vector3i v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        /// <summary>
        /// Constructs a new instance from the given Vector4d.
        /// </summary>
        /// <param name="v">The Vector4d to copy components from.</param>
        public Vector3i(Vector4i v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
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
                throw new IndexOutOfRangeException("You tried to access this vector at index: " + index);
            } set{
                if(index == 0) X = value;
                else if(index == 1) Y = value;
                else if(index == 2) Z = value;
                else throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
            }
        }

        #region Instance

        #region public void Add()

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Add() method instead.")]
        public void Add(Vector3i right)
        {
            this.X += right.X;
            this.Y += right.Y;
            this.Z += right.Z;
        }

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Add() method instead.")]
        public void Add(ref Vector3i right)
        {
            this.X += right.X;
            this.Y += right.Y;
            this.Z += right.Z;
        }

        #endregion public void Add()

        #region public void Sub()

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(Vector3i right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
            this.Z -= right.Z;
        }

        /// <summary>Subtract the Vector passed as parameter from this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [CLSCompliant(false)]
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(ref Vector3i right)
        {
            this.X -= right.X;
            this.Y -= right.Y;
            this.Z -= right.Z;
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
        }

        #endregion public void Div()

        #region public double Length

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y + Z * Z);
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
                return X * X + Y * Y + Z * Z;
            }
        }

        #endregion

        /// <summary>
        /// Returns a copy of the Vector3i scaled to unit length.
        /// </summary>
        /// <returns></returns>
        public Vector3i Normalized()
        {
            Vector3i v = this;
            v.Normalize();
            return v;
        }

        #region public void Normalize()

        /// <summary>
        /// Scales the Vector3i to unit length.
        /// </summary>
        public void Normalize()
        {
            if (Math.Abs(X) > Math.Abs(Y) && Math.Abs(X) > Math.Abs(Z)) {
                X = 1;
                Y = 0;
                Z = 0;
            } else if (Math.Abs(Y) > Math.Abs(X) && Math.Abs(Y) > Math.Abs(Z)) {
                X = 0;
                Y = 1;
                Z = 0;
            } else {
                X = 0;
                Y = 0;
                Z = 1;
            }
        }

        #endregion

        #region public void Scale()

        /// <summary>
        /// Scales the current Vector3i by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(int sx, int sy, int sz)
        {
            this.X = X * sx;
            this.Y = Y * sy;
            this.Z = Z * sz;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [Obsolete("Use static Multiply() method instead.")]
        [CLSCompliant(false)]
        public void Scale(Vector3i scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
            this.Z *= scale.Z;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [Obsolete("Use static Multiply() method instead.")]
        [CLSCompliant(false)]
        public void Scale(ref Vector3i scale)
        {
            this.X *= scale.X;
            this.Y *= scale.Y;
            this.Z *= scale.Z;
        }

        #endregion public void Scale()

        #endregion

        #region Static

        #region Fields

        /// <summary>
        /// Defines a unit-length Vector3i that points towards the X-axis.
        /// </summary>
        public static readonly Vector3i UnitX = new Vector3i(1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector3i that points towards the Y-axis.
        /// </summary>
        public static readonly Vector3i UnitY = new Vector3i(0, 1, 0);

        /// <summary>
        /// /// Defines a unit-length Vector3i that points towards the Z-axis.
        /// </summary>
        public static readonly Vector3i UnitZ = new Vector3i(0, 0, 1);

        /// <summary>
        /// Defines a zero-length Vector3.
        /// </summary>
        public static readonly Vector3i Zero = new Vector3i(0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector3i One = new Vector3i(1, 1, 1);

        /// <summary>
        /// Defines the size of the Vector3i struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector3i());

        #endregion

        #region Obsolete

        #region Sub

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        [Obsolete("Use static Subtract() method instead.")]
        public static Vector3i Sub(Vector3i a, Vector3i b)
        {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
        }

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">Result of subtraction</param>
        [Obsolete("Use static Subtract() method instead.")]
        public static void Sub(ref Vector3i a, ref Vector3i b, out Vector3i result)
        {
            result.X = a.X - b.X;
            result.Y = a.Y - b.Y;
            result.Z = a.Z - b.Z;
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
        public static Vector3i Mult(Vector3i a, int f)
        {
            a.X *= f;
            a.Y *= f;
            a.Z *= f;
            return a;
        }

        /// <summary>
        /// Multiply a vector and a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <param name="result">Result of the multiplication</param>
        [Obsolete("Use static Multiply() method instead.")]
        public static void Mult(ref Vector3i a, int f, out Vector3i result)
        {
            result.X = a.X * f;
            result.Y = a.Y * f;
            result.Z = a.Z * f;
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
        public static Vector3i Div(Vector3i a, int s)
        {
            a.X /= s;
            a.Y /= s;
            a.Z /= s;
            return a;
        }

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="s">Scalar operand</param>
        /// <param name="result">Result of the division</param>
        [Obsolete("Use static Divide() method instead.")]
        public static void Div(ref Vector3i a, int s, out Vector3i result)
        {
            result.X = a.X / s;
            result.Y = a.Y / s;
            result.Z = a.Z / s;
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
        public static Vector3i Add(Vector3i a, Vector3i b)
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
        public static void Add(ref Vector3i a, ref Vector3i b, out Vector3i result)
        {
            result = new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        #endregion

        #region Subtract

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        public static Vector3i Subtract(Vector3i a, Vector3i b)
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
        public static void Subtract(ref Vector3i a, ref Vector3i b, out Vector3i result)
        {
            result = new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        #endregion

        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3i Multiply(Vector3i vector, int scale)
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
        public static void Multiply(ref Vector3i vector, int scale, out Vector3i result)
        {
            result = new Vector3i(vector.X * scale, vector.Y * scale, vector.Z * scale);
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3i Multiply(Vector3i vector, Vector3i scale)
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
        public static void Multiply(ref Vector3i vector, ref Vector3i scale, out Vector3i result)
        {
            result = new Vector3i(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z);
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3i Divide(Vector3i vector, int scale)
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
        public static void Divide(ref Vector3i vector, int scale, out Vector3i result)
        {
            result = new Vector3i(vector.X / scale, vector.Y / scale, vector.Z / scale);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3i Divide(Vector3i vector, Vector3i scale)
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
        public static void Divide(ref Vector3i vector, ref Vector3i scale, out Vector3i result)
        {
            result = new Vector3i(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z);
        }

        #endregion

        #region ComponentMin

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise minimum</returns>
        public static Vector3i ComponentMin(Vector3i a, Vector3i b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise minimum</param>
        public static void ComponentMin(ref Vector3i a, ref Vector3i b, out Vector3i result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
        }

        #endregion

        #region ComponentMax

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise maximum</returns>
        public static Vector3i ComponentMax(Vector3i a, Vector3i b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise maximum</param>
        public static void ComponentMax(ref Vector3i a, ref Vector3i b, out Vector3i result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
        }

        #endregion

        #region Min

        /// <summary>
        /// Returns the Vector3i with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector3</returns>
        public static Vector3i Min(Vector3i left, Vector3i right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        #endregion

        #region Max

        /// <summary>
        /// Returns the Vector3i with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector3</returns>
        public static Vector3i Max(Vector3i left, Vector3i right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
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
        public static Vector3i Clamp(Vector3i vec, Vector3i min, Vector3i max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector3i vec, ref Vector3i min, ref Vector3i max, out Vector3i result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.Z < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector3i Normalize(Vector3i vec)
        {
            return vec.Normalized();
        }

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector3i vec, out Vector3i result)
        {
            result = vec.Normalized();
        }

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The dot product of the two inputs</returns>
        public static int Dot(Vector3i left, Vector3i right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        /// <summary>
        /// Calculate the dot (scalar) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <param name="result">The dot product of the two inputs</param>
        public static void Dot(ref Vector3i left, ref Vector3i right, out int result)
        {
            result = left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        #endregion

        #region Cross

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        public static Vector3i Cross(Vector3i left, Vector3i right)
        {
            Vector3i result;
            Cross(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Caclulate the cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        /// <param name="result">The cross product of the two inputs</param>
        public static void Cross(ref Vector3i left, ref Vector3i right, out Vector3i result)
        {
            result = new Vector3i(left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X);
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
        public static Vector3i Lerp(Vector3i a, Vector3i b, double blend)
        {
            a.X = (int)(blend * (b.X - a.X) + a.X);
            a.Y = (int)(blend * (b.Y - a.Y) + a.Y);
            a.Z = (int)(blend * (b.Z - a.Z) + a.Z);
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector3i a, ref Vector3i b, double blend, out Vector3i result)
        {
            result.X = (int)(blend * (b.X - a.X) + a.X);
            result.Y = (int)(blend * (b.Y - a.Y) + a.Y);
            result.Z = (int)(blend * (b.Z - a.Z) + a.Z);
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
        public static Vector3i BaryCentric(Vector3i a, Vector3i b, Vector3i c, int u, int v)
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
        public static void BaryCentric(ref Vector3i a, ref Vector3i b, ref Vector3i c, int u, int v, out Vector3i result)
        {
            result = a; // copy

            Vector3i temp = b; // copy
            Subtract(ref temp, ref a, out temp);
            Multiply(ref temp, u, out temp);
            Add(ref result, ref temp, out result);

            temp = c; // copy
            Subtract(ref temp, ref a, out temp);
            Multiply(ref temp, v, out temp);
            Add(ref result, ref temp, out result);
        }

        #endregion

        #region CalculateAngle

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <returns>Angle (in radians) between the vectors.</returns>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static double CalculateAngle(Vector3i first, Vector3i second)
        {
            return System.Math.Acos((Vector3i.Dot(first, second)) / (first.Length * second.Length));
        }

        /// <summary>Calculates the angle (in radians) between two vectors.</summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(ref Vector3i first, ref Vector3i second, out double result)
        {
            int temp;
            Vector3i.Dot(ref first, ref second, out temp);
            result = System.Math.Acos(temp / (first.Length * second.Length));
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
        /// Gets or sets an OpenTK.Vector2i with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zx { get { return new Vector2i(Z, X); } set { Z = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2i with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2i Zy { get { return new Vector2i(Z, Y); } set { Z = value.X; Y = value.Y; } }

        #endregion

        #region 3-component

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Xzy { get { return new Vector3i(X, Z, Y); } set { X = value.X; Z = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yxz { get { return new Vector3i(Y, X, Z); } set { Y = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Yzx { get { return new Vector3i(Y, Z, X); } set { Y = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zxy { get { return new Vector3i(Z, X, Y); } set { Z = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3i with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3i Zyx { get { return new Vector3i(Z, Y, X); } set { Z = value.X; Y = value.Y; X = value.Z; } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector3i operator +(Vector3i left, Vector3i right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            return left;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector3i operator -(Vector3i left, Vector3i right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            return left;
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector3i operator -(Vector3i vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector3i operator *(Vector3i vec, int scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="scale">The scalar.</param>
        /// <param name="vec">The instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector3i operator *(int scale, Vector3i vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        /// <param name="vec">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector3i operator /(Vector3i vec, int scale)
        {
            vec.X /= scale;
            vec.Y /= scale;
            vec.Z /= scale;
            return vec;
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector3i left, Vector3i right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector3i left, Vector3i right)
        {
            return !left.Equals(right);
        }

        /// <summary>Converts OpenTK.Vector3 to OpenTK.Vector3i.</summary>
        /// <param name="v3">The Vector3 to convert.</param>
        /// <returns>The resulting Vector3i.</returns>
        public static explicit operator Vector3i(Vector3 v3)
        {
            return new Vector3i((int)v3.X, (int)v3.Y, (int)v3.Z);
        }

        /// <summary>Converts OpenTK.Vector3i to OpenTK.Vector3.</summary>
        /// <param name="v3d">The Vector3i to convert.</param>
        /// <returns>The resulting Vector3.</returns>
        public static explicit operator Vector3(Vector3i v3d)
        {
            return new Vector3((float)v3d.X, (float)v3d.Y, (float)v3d.Z);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>
        /// Returns a System.String that represents the current Vector3.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("({0}{3} {1}{3} {2})", X, Y, Z, listSeparator);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
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
            if (!(obj is Vector3i))
                return false;

            return this.Equals((Vector3i)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Vector3> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector3i other)
        {
            return
                X == other.X &&
                Y == other.Y &&
                Z == other.Z;
        }

        #endregion
    }
}