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
    /// <summary>Represents a 4D vector using four double-precision floating-point numbers.</summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4d : IEquatable<Vector4d>
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector4d.
        /// </summary>
        public double X;

        /// <summary>
        /// The Y component of the Vector4d.
        /// </summary>
        public double Y;

        /// <summary>
        /// The Z component of the Vector4d.
        /// </summary>
        public double Z;

        /// <summary>
        /// The W component of the Vector4d.
        /// </summary>
        public double W;

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the X-axis.
        /// </summary>
        public static Vector4d UnitX = new Vector4d(1, 0, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the Y-axis.
        /// </summary>
        public static Vector4d UnitY = new Vector4d(0, 1, 0, 0);

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the Z-axis.
        /// </summary>
        public static Vector4d UnitZ = new Vector4d(0, 0, 1, 0);

        /// <summary>
        /// Defines a unit-length Vector4d that points towards the W-axis.
        /// </summary>
        public static Vector4d UnitW = new Vector4d(0, 0, 0, 1);

        /// <summary>
        /// Defines a zero-length Vector4d.
        /// </summary>
        public static Vector4d Zero = new Vector4d(0, 0, 0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4d One = new Vector4d(1, 1, 1, 1);

        /// <summary>
        /// Defines the size of the Vector4d struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector4d());

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector4d(double value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Constructs a new Vector4d.
        /// </summary>
        /// <param name="x">The x component of the Vector4d.</param>
        /// <param name="y">The y component of the Vector4d.</param>
        /// <param name="z">The z component of the Vector4d.</param>
        /// <param name="w">The w component of the Vector4d.</param>
        public Vector4d(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Constructs a new Vector4d from the given Vector2d.
        /// </summary>
        /// <param name="v">The Vector2d to copy components from.</param>
        public Vector4d(Vector2d v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
            W = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector4d from the given Vector3d.
        /// The w component is initialized to 0.
        /// </summary>
        /// <param name="v">The Vector3d to copy components from.</param>
        /// <remarks><seealso cref="Vector4d(Vector3d, double)"/></remarks>
        public Vector4d(Vector3d v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector4d from the specified Vector3d and w component.
        /// </summary>
        /// <param name="v">The Vector3d to copy components from.</param>
        /// <param name="w">The w component of the new Vector4.</param>
        public Vector4d(Vector3d v, double w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        /// <summary>
        /// Constructs a new Vector4d from the given Vector4d.
        /// </summary>
        /// <param name="v">The Vector4d to copy components from.</param>
        public Vector4d(Vector4d v)
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
        public double this[int index] {
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
                throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
            }
        }

        #region Instance

        #region public void Add()

        /// <summary>Add the Vector passed as parameter to this instance.</summary>
        /// <param name="right">Right operand. This parameter is only read from.</param>
        [Obsolete("Use static Add() method instead.")]
        public void Add(Vector4d right)
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
        public void Add(ref Vector4d right)
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
        [Obsolete("Use static Subtract() method instead.")]
        public void Sub(Vector4d right)
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
        public void Sub(ref Vector4d right)
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
        public void Mult(double f)
        {
            this.X *= f;
            this.Y *= f;
            this.Z *= f;
            this.W *= f;
        }

        #endregion public void Mult()

        #region public void Div()

        /// <summary>Divide this instance by a scalar.</summary>
        /// <param name="f">Scalar operand.</param>
        [Obsolete("Use static Divide() method instead.")]
        public void Div(double f)
        {
            double mult = 1.0 / f;
            this.X *= mult;
            this.Y *= mult;
            this.Z *= mult;
            this.W *= mult;
        }

        #endregion public void Div()

        #region public double Length

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
            }
        }

        #endregion

        #region public double LengthFast

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude, with
        /// an upper error bound of 0.001.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public double LengthFast
        {
            get
            {
                return 1.0 / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
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

        #region public void Normalize()

        /// <summary>
        /// Scales the Vector4d to unit length.
        /// </summary>
        public void Normalize()
        {
            double scale = 1.0 / this.Length;
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
        }

        #endregion

        #region public void NormalizeFast()

        /// <summary>
        /// Scales the Vector4d to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            double scale = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
        }

        #endregion

        #region public void Scale()

        /// <summary>
        /// Scales the current Vector4d by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        /// <param name="sw">The scale of the Z component.</param>
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(double sx, double sy, double sz, double sw)
        {
            this.X = X * sx;
            this.Y = Y * sy;
            this.Z = Z * sz;
            this.W = W * sw;
        }

        /// <summary>Scales this instance by the given parameter.</summary>
        /// <param name="scale">The scaling of the individual components.</param>
        [Obsolete("Use static Multiply() method instead.")]
        public void Scale(Vector4d scale)
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
        public void Scale(ref Vector4d scale)
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
        public static Vector4d Sub(Vector4d a, Vector4d b)
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
        public static void Sub(ref Vector4d a, ref Vector4d b, out Vector4d result)
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
        public static Vector4d Mult(Vector4d a, double f)
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
        public static void Mult(ref Vector4d a, double f, out Vector4d result)
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
        /// <param name="f">Scalar operand</param>
        /// <returns>Result of the division</returns>
        [Obsolete("Use static Divide() method instead.")]
        public static Vector4d Div(Vector4d a, double f)
        {
            double mult = 1.0 / f;
            a.X *= mult;
            a.Y *= mult;
            a.Z *= mult;
            a.W *= mult;
            return a;
        }

        /// <summary>
        /// Divide a vector by a scalar
        /// </summary>
        /// <param name="a">Vector operand</param>
        /// <param name="f">Scalar operand</param>
        /// <param name="result">Result of the division</param>
        [Obsolete("Use static Divide() method instead.")]
        public static void Div(ref Vector4d a, double f, out Vector4d result)
        {
            double mult = 1.0 / f;
            result.X = a.X * mult;
            result.Y = a.Y * mult;
            result.Z = a.Z * mult;
            result.W = a.W * mult;
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
        public static Vector4d Add(Vector4d a, Vector4d b)
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
        public static void Add(ref Vector4d a, ref Vector4d b, out Vector4d result)
        {
            result = new Vector4d(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
        }

        #endregion

        #region Subtract

        /// <summary>
        /// Subtract one Vector from another
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of subtraction</returns>
        public static Vector4d Subtract(Vector4d a, Vector4d b)
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
        public static void Subtract(ref Vector4d a, ref Vector4d b, out Vector4d result)
        {
            result = new Vector4d(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
        }

        #endregion

        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4d Multiply(Vector4d vector, double scale)
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
        public static void Multiply(ref Vector4d vector, double scale, out Vector4d result)
        {
            result = new Vector4d(vector.X * scale, vector.Y * scale, vector.Z * scale, vector.W * scale);
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4d Multiply(Vector4d vector, Vector4d scale)
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
        public static void Multiply(ref Vector4d vector, ref Vector4d scale, out Vector4d result)
        {
            result = new Vector4d(vector.X * scale.X, vector.Y * scale.Y, vector.Z * scale.Z, vector.W * scale.W);
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4d Divide(Vector4d vector, double scale)
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
        public static void Divide(ref Vector4d vector, double scale, out Vector4d result)
        {
            Multiply(ref vector, 1 / scale, out result);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4d Divide(Vector4d vector, Vector4d scale)
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
        public static void Divide(ref Vector4d vector, ref Vector4d scale, out Vector4d result)
        {
            result = new Vector4d(vector.X / scale.X, vector.Y / scale.Y, vector.Z / scale.Z, vector.W / scale.W);
        }

        #endregion

        #region Min

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise minimum</returns>
        public static Vector4d Min(Vector4d a, Vector4d b)
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
        public static void Min(ref Vector4d a, ref Vector4d b, out Vector4d result)
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
        public static Vector4d Max(Vector4d a, Vector4d b)
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
        public static void Max(ref Vector4d a, ref Vector4d b, out Vector4d result)
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
        public static Vector4d Clamp(Vector4d vec, Vector4d min, Vector4d max)
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
        public static void Clamp(ref Vector4d vec, ref Vector4d min, ref Vector4d max, out Vector4d result)
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
        public static Vector4d Normalize(Vector4d vec)
        {
            double scale = 1.0 / vec.Length;
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector4d vec, out Vector4d result)
        {
            double scale = 1.0 / vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
            result.W = vec.W * scale;
        }

        #endregion

        #region NormalizeFast

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector4d NormalizeFast(Vector4d vec)
        {
            double scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z + vec.W * vec.W);
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void NormalizeFast(ref Vector4d vec, out Vector4d result)
        {
            double scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z + vec.W * vec.W);
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
            result.W = vec.W * scale;
        }

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The dot product of the two inputs</returns>
        public static double Dot(Vector4d left, Vector4d right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z + left.W * right.W;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <param name="result">The dot product of the two inputs</param>
        public static void Dot(ref Vector4d left, ref Vector4d right, out double result)
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
        public static Vector4d Lerp(Vector4d a, Vector4d b, double blend)
        {
            a.X = blend * (b.X - a.X) + a.X;
            a.Y = blend * (b.Y - a.Y) + a.Y;
            a.Z = blend * (b.Z - a.Z) + a.Z;
            a.W = blend * (b.W - a.W) + a.W;
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a">First input vector</param>
        /// <param name="b">Second input vector</param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector4d a, ref Vector4d b, double blend, out Vector4d result)
        {
            result.X = blend * (b.X - a.X) + a.X;
            result.Y = blend * (b.Y - a.Y) + a.Y;
            result.Z = blend * (b.Z - a.Z) + a.Z;
            result.W = blend * (b.W - a.W) + a.W;
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
        public static Vector4d BaryCentric(Vector4d a, Vector4d b, Vector4d c, double u, double v)
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
        public static void BaryCentric(ref Vector4d a, ref Vector4d b, ref Vector4d c, double u, double v, out Vector4d result)
        {
            result = a; // copy

            Vector4d temp = b; // copy
            Subtract(ref temp, ref a, out temp);
            Multiply(ref temp, u, out temp);
            Add(ref result, ref temp, out result);

            temp = c; // copy
            Subtract(ref temp, ref a, out temp);
            Multiply(ref temp, v, out temp);
            Add(ref result, ref temp, out result);
        }

        #endregion

        #region Transform

        /// <summary>Transform a Vector by the given Matrix</summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <returns>The transformed vector</returns>
        public static Vector4d Transform(Vector4d vec, Matrix4d mat)
        {
            Vector4d result;
            Transform(ref vec, ref mat, out result);
            return result;
        }

        /// <summary>Transform a Vector by the given Matrix</summary>
        /// <param name="vec">The vector to transform</param>
        /// <param name="mat">The desired transformation</param>
        /// <param name="result">The transformed vector</param>
        public static void Transform(ref Vector4d vec, ref Matrix4d mat, out Vector4d result)
        {
            result = new Vector4d(
                vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X + vec.W * mat.Row3.X,
                vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y + vec.W * mat.Row3.Y,
                vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z + vec.W * mat.Row3.Z,
                vec.X * mat.Row0.W + vec.Y * mat.Row1.W + vec.Z * mat.Row2.W + vec.W * mat.Row3.W);
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <returns>The result of the operation.</returns>
        public static Vector4d Transform(Vector4d vec, Quaterniond quat)
        {
            Vector4d result;
            Transform(ref vec, ref quat, out result);
            return result;
        }

        /// <summary>
        /// Transforms a vector by a quaternion rotation.
        /// </summary>
        /// <param name="vec">The vector to transform.</param>
        /// <param name="quat">The quaternion to rotate the vector by.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Transform(ref Vector4d vec, ref Quaterniond quat, out Vector4d result)
        {
            Quaterniond v = new Quaterniond(vec.X, vec.Y, vec.Z, vec.W), i, t;
            Quaterniond.Invert(ref quat, out i);
            Quaterniond.Multiply(ref quat, ref v, out t);
            Quaterniond.Multiply(ref t, ref i, out v);

            result = new Vector4d(v.X, v.Y, v.Z, v.W);
        }

        #endregion

        #endregion

        #region Swizzle

        #region 2-component

        /// <summary>
        /// Gets an OpenTK.Vector2d with the X and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xx { get { return new Vector2d(X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the X and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xy { get { return new Vector2d(X, Y); } set { X = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xz { get { return new Vector2d(X, Z); } set { X = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Xw { get { return new Vector2d(X, W); } set { X = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Y and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yx { get { return new Vector2d(Y, X); } set { Y = value.X; X = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2d with the Y and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yy { get { return new Vector2d(Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Y and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yz { get { return new Vector2d(Y, Z); } set { Y = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Y and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Yw { get { return new Vector2d(Y, W); } set { Y = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Z and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zx { get { return new Vector2d(Z, X); } set { Z = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the Z and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zy { get { return new Vector2d(Z, Y); } set { Z = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2d with the Z and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zz { get { return new Vector2d(Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector2d with the Z and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Zw { get { return new Vector2d(Z, W); } set { Z = value.X; W = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the W and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wx { get { return new Vector2d(W, X); } set { W = value.X; X = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the W and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wy { get { return new Vector2d(W, Y); } set { W = value.X; Y = value.Y; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector2d with the W and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Wz { get { return new Vector2d(W, Z); } set { W = value.X; Z = value.Y; } }

        /// <summary>
        /// Gets an OpenTK.Vector2d with the W and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector2d Ww { get { return new Vector2d(W, W); } }

        #endregion

        #region 3-component

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xxx { get { return new Vector3d(X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xxy { get { return new Vector3d(X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xxz { get { return new Vector3d(X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xxw { get { return new Vector3d(X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyx { get { return new Vector3d(X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyy { get { return new Vector3d(X, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyz { get { return new Vector3d(X, Y, Z); } set { X = value.X; Y = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xyw { get { return new Vector3d(X, Y, W); } set { X = value.X; Y = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzx { get { return new Vector3d(X, Z, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzy { get { return new Vector3d(X, Z, Y); } set { X = value.X; Z = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzz { get { return new Vector3d(X, Z, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xzw { get { return new Vector3d(X, Z, W); } set { X = value.X; Z = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwx { get { return new Vector3d(X, W, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwy { get { return new Vector3d(X, W, Y); } set { X = value.X; W = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xwz { get { return new Vector3d(X, W, Z); } set { X = value.X; W = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Xww { get { return new Vector3d(X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxx { get { return new Vector3d(Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxy { get { return new Vector3d(Y, X, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxz { get { return new Vector3d(Y, X, Z); } set { Y = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yxw { get { return new Vector3d(Y, X, W); } set { Y = value.X; X = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yyx { get { return new Vector3d(Y, Y, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yyy { get { return new Vector3d(Y, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yyz { get { return new Vector3d(Y, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yyw { get { return new Vector3d(Y, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzx { get { return new Vector3d(Y, Z, X); } set { Y = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzy { get { return new Vector3d(Y, Z, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzz { get { return new Vector3d(Y, Z, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yzw { get { return new Vector3d(Y, Z, W); } set { Y = value.X; Z = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywx { get { return new Vector3d(Y, W, X); } set { Y = value.X; W = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywy { get { return new Vector3d(Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Ywz { get { return new Vector3d(Y, W, Z); } set { Y = value.X; W = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Yww { get { return new Vector3d(Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxx { get { return new Vector3d(Z, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxy { get { return new Vector3d(Z, X, Y); } set { Z = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxz { get { return new Vector3d(Z, X, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zxw { get { return new Vector3d(Z, X, W); } set { Z = value.X; X = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyx { get { return new Vector3d(Z, Y, X); } set { Z = value.X; Y = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyy { get { return new Vector3d(Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyz { get { return new Vector3d(Z, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zyw { get { return new Vector3d(Z, Y, W); } set { Z = value.X; Y = value.Y; W = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zzx { get { return new Vector3d(Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zzy { get { return new Vector3d(Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zzz { get { return new Vector3d(Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zzw { get { return new Vector3d(Z, Z, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwx { get { return new Vector3d(Z, W, X); } set { Z = value.X; W = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwy { get { return new Vector3d(Z, W, Y); } set { Z = value.X; W = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zwz { get { return new Vector3d(Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Zww { get { return new Vector3d(Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxx { get { return new Vector3d(W, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxy { get { return new Vector3d(W, X, Y); } set { W = value.X; X = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxz { get { return new Vector3d(W, X, Z); } set { W = value.X; X = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wxw { get { return new Vector3d(W, X, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyx { get { return new Vector3d(W, Y, X); } set { W = value.X; Y = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyy { get { return new Vector3d(W, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyz { get { return new Vector3d(W, Y, Z); } set { W = value.X; Y = value.Y; Z = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wyw { get { return new Vector3d(W, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzx { get { return new Vector3d(W, Z, X); } set { W = value.X; Z = value.Y; X = value.Z; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3d with the W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzy { get { return new Vector3d(W, Z, Y); } set { W = value.X; Z = value.Y; Y = value.Z; } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzz { get { return new Vector3d(W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wzw { get { return new Vector3d(W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wwx { get { return new Vector3d(W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wwy { get { return new Vector3d(W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Wwz { get { return new Vector3d(W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector3d with the W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector3d Www { get { return new Vector3d(W, W, W); } }

        #endregion

        #region 4-component

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxxx { get { return new Vector4d(X, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxxy { get { return new Vector4d(X, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxxz { get { return new Vector4d(X, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxxw { get { return new Vector4d(X, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxyx { get { return new Vector4d(X, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxyy { get { return new Vector4d(X, X, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxyz { get { return new Vector4d(X, X, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxyw { get { return new Vector4d(X, X, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxzx { get { return new Vector4d(X, X, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxzy { get { return new Vector4d(X, X, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxzz { get { return new Vector4d(X, X, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxzw { get { return new Vector4d(X, X, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxwx { get { return new Vector4d(X, X, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxwy { get { return new Vector4d(X, X, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxwz { get { return new Vector4d(X, X, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xxww { get { return new Vector4d(X, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyxx { get { return new Vector4d(X, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyxy { get { return new Vector4d(X, Y, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyxz { get { return new Vector4d(X, Y, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyxw { get { return new Vector4d(X, Y, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyyx { get { return new Vector4d(X, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyyy { get { return new Vector4d(X, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyyz { get { return new Vector4d(X, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyyw { get { return new Vector4d(X, Y, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyzx { get { return new Vector4d(X, Y, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyzy { get { return new Vector4d(X, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyzz { get { return new Vector4d(X, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xywx { get { return new Vector4d(X, Y, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xywy { get { return new Vector4d(X, Y, W, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xywz { get { return new Vector4d(X, Y, W, Z); } set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xyww { get { return new Vector4d(X, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzxx { get { return new Vector4d(X, Z, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzxy { get { return new Vector4d(X, Z, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzxz { get { return new Vector4d(X, Z, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzxw { get { return new Vector4d(X, Z, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzyx { get { return new Vector4d(X, Z, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzyy { get { return new Vector4d(X, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzyz { get { return new Vector4d(X, Z, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzyw { get { return new Vector4d(X, Z, Y, W); } set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzzx { get { return new Vector4d(X, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzzy { get { return new Vector4d(X, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzzz { get { return new Vector4d(X, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzzw { get { return new Vector4d(X, Z, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzwx { get { return new Vector4d(X, Z, W, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzwy { get { return new Vector4d(X, Z, W, Y); } set { X = value.X; Z = value.Y; W = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzwz { get { return new Vector4d(X, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xzww { get { return new Vector4d(X, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwxx { get { return new Vector4d(X, W, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwxy { get { return new Vector4d(X, W, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwxz { get { return new Vector4d(X, W, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwxw { get { return new Vector4d(X, W, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwyx { get { return new Vector4d(X, W, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwyy { get { return new Vector4d(X, W, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwyz { get { return new Vector4d(X, W, Y, Z); } set { X = value.X; W = value.Y; Y = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwyw { get { return new Vector4d(X, W, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwzx { get { return new Vector4d(X, W, Z, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the X, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwzy { get { return new Vector4d(X, W, Z, Y); } set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwzz { get { return new Vector4d(X, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwzw { get { return new Vector4d(X, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwwx { get { return new Vector4d(X, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwwy { get { return new Vector4d(X, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwwz { get { return new Vector4d(X, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the X, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Xwww { get { return new Vector4d(X, W, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxxx { get { return new Vector4d(Y, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxxy { get { return new Vector4d(Y, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxxz { get { return new Vector4d(Y, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxxw { get { return new Vector4d(Y, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxyx { get { return new Vector4d(Y, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxyy { get { return new Vector4d(Y, X, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxyz { get { return new Vector4d(Y, X, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxyw { get { return new Vector4d(Y, X, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxzx { get { return new Vector4d(Y, X, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxzy { get { return new Vector4d(Y, X, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxzz { get { return new Vector4d(Y, X, Z, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxzw { get { return new Vector4d(Y, X, Z, W); } set { Y = value.X; X = value.Y; Z = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxwx { get { return new Vector4d(Y, X, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxwy { get { return new Vector4d(Y, X, W, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxwz { get { return new Vector4d(Y, X, W, Z); } set { Y = value.X; X = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yxww { get { return new Vector4d(Y, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyxx { get { return new Vector4d(Y, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyxy { get { return new Vector4d(Y, Y, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyxz { get { return new Vector4d(Y, Y, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyxw { get { return new Vector4d(Y, Y, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyyx { get { return new Vector4d(Y, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyyy { get { return new Vector4d(Y, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyyz { get { return new Vector4d(Y, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyyw { get { return new Vector4d(Y, Y, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyzx { get { return new Vector4d(Y, Y, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyzy { get { return new Vector4d(Y, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyzz { get { return new Vector4d(Y, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyzw { get { return new Vector4d(Y, Y, Z, W); } set { X = value.X; Y = value.Y; Z = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yywx { get { return new Vector4d(Y, Y, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yywy { get { return new Vector4d(Y, Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yywz { get { return new Vector4d(Y, Y, W, Z); } set { X = value.X; Y = value.Y; W = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yyww { get { return new Vector4d(Y, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzxx { get { return new Vector4d(Y, Z, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzxy { get { return new Vector4d(Y, Z, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzxz { get { return new Vector4d(Y, Z, X, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzxw { get { return new Vector4d(Y, Z, X, W); } set { Y = value.X; Z = value.Y; X = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzyx { get { return new Vector4d(Y, Z, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzyy { get { return new Vector4d(Y, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzyz { get { return new Vector4d(Y, Z, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzyw { get { return new Vector4d(Y, Z, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzzx { get { return new Vector4d(Y, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzzy { get { return new Vector4d(Y, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzzz { get { return new Vector4d(Y, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzzw { get { return new Vector4d(Y, Z, Z, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzwx { get { return new Vector4d(Y, Z, W, X); } set { Y = value.X; Z = value.Y; W = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzwy { get { return new Vector4d(Y, Z, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzwz { get { return new Vector4d(Y, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Yzww { get { return new Vector4d(Y, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywxx { get { return new Vector4d(Y, W, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywxy { get { return new Vector4d(Y, W, X, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywxz { get { return new Vector4d(Y, W, X, Z); } set { Y = value.X; W = value.Y; X = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywxw { get { return new Vector4d(Y, W, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywyx { get { return new Vector4d(Y, W, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywyy { get { return new Vector4d(Y, W, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywyz { get { return new Vector4d(Y, W, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywyw { get { return new Vector4d(Y, W, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Y, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywzx { get { return new Vector4d(Y, W, Z, X); } set { Y = value.X; W = value.Y; Z = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywzy { get { return new Vector4d(Y, W, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywzz { get { return new Vector4d(Y, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywzw { get { return new Vector4d(Y, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywwx { get { return new Vector4d(Y, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywwy { get { return new Vector4d(Y, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywwz { get { return new Vector4d(Y, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Y, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Ywww { get { return new Vector4d(Y, W, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxxx { get { return new Vector4d(Z, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxxy { get { return new Vector4d(Z, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxxz { get { return new Vector4d(Z, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxxw { get { return new Vector4d(Z, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxyx { get { return new Vector4d(Z, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxyy { get { return new Vector4d(Z, X, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxyz { get { return new Vector4d(Z, X, Y, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxyw { get { return new Vector4d(Z, X, Y, W); } set { Z = value.X; X = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxzx { get { return new Vector4d(Z, X, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxzy { get { return new Vector4d(Z, X, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxzz { get { return new Vector4d(Z, X, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxzw { get { return new Vector4d(Z, X, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxwx { get { return new Vector4d(Z, X, W, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxwy { get { return new Vector4d(Z, X, W, Y); } set { Z = value.X; X = value.Y; W = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxwz { get { return new Vector4d(Z, X, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zxww { get { return new Vector4d(Z, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyxx { get { return new Vector4d(Z, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyxy { get { return new Vector4d(Z, Y, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyxz { get { return new Vector4d(Z, Y, X, Z); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyxw { get { return new Vector4d(Z, Y, X, W); } set { Z = value.X; Y = value.Y; X = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyyx { get { return new Vector4d(Z, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyyy { get { return new Vector4d(Z, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyyz { get { return new Vector4d(Z, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyyw { get { return new Vector4d(Z, Y, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyzx { get { return new Vector4d(Z, Y, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyzy { get { return new Vector4d(Z, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyzz { get { return new Vector4d(Z, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyzw { get { return new Vector4d(Z, Y, Z, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zywx { get { return new Vector4d(Z, Y, W, X); } set { Z = value.X; Y = value.Y; W = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zywy { get { return new Vector4d(Z, Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zywz { get { return new Vector4d(Z, Y, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zyww { get { return new Vector4d(Z, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzxx { get { return new Vector4d(Z, Z, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzxy { get { return new Vector4d(Z, Z, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzxz { get { return new Vector4d(Z, Z, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzxw { get { return new Vector4d(Z, Z, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzyx { get { return new Vector4d(Z, Z, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzyy { get { return new Vector4d(Z, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzyz { get { return new Vector4d(Z, Z, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzyw { get { return new Vector4d(Z, Z, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzzx { get { return new Vector4d(Z, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzzy { get { return new Vector4d(Z, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzzz { get { return new Vector4d(Z, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzzw { get { return new Vector4d(Z, Z, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzwx { get { return new Vector4d(Z, Z, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzwy { get { return new Vector4d(Z, Z, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzwz { get { return new Vector4d(Z, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zzww { get { return new Vector4d(Z, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwxx { get { return new Vector4d(Z, W, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwxy { get { return new Vector4d(Z, W, X, Y); } set { Z = value.X; W = value.Y; X = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwxz { get { return new Vector4d(Z, W, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwxw { get { return new Vector4d(Z, W, X, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the Z, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwyx { get { return new Vector4d(Z, W, Y, X); } set { Z = value.X; W = value.Y; Y = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwyy { get { return new Vector4d(Z, W, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwyz { get { return new Vector4d(Z, W, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwyw { get { return new Vector4d(Z, W, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwzx { get { return new Vector4d(Z, W, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwzy { get { return new Vector4d(Z, W, Z, Y); } set { X = value.X; W = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwzz { get { return new Vector4d(Z, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwzw { get { return new Vector4d(Z, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwwx { get { return new Vector4d(Z, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwwy { get { return new Vector4d(Z, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwwz { get { return new Vector4d(Z, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the Z, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Zwww { get { return new Vector4d(Z, W, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxxx { get { return new Vector4d(W, X, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxxy { get { return new Vector4d(W, X, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, X and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxxz { get { return new Vector4d(W, X, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, X and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxxw { get { return new Vector4d(W, X, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxyx { get { return new Vector4d(W, X, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxyy { get { return new Vector4d(W, X, Y, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxyz { get { return new Vector4d(W, X, Y, Z); } set { W = value.X; X = value.Y; Y = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxyw { get { return new Vector4d(W, X, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxzx { get { return new Vector4d(W, X, Z, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, X, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxzy { get { return new Vector4d(W, X, Z, Y); } set { W = value.X; X = value.Y; Z = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxzz { get { return new Vector4d(W, X, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxzw { get { return new Vector4d(W, X, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxwx { get { return new Vector4d(W, X, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxwy { get { return new Vector4d(W, X, W, Y); } }

        /// <summary>
        /// Getss an OpenTK.Vector4d with the W, X, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxwz { get { return new Vector4d(W, X, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, X, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wxww { get { return new Vector4d(W, X, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyxx { get { return new Vector4d(W, Y, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyxy { get { return new Vector4d(W, Y, X, Y); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Y, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyxz { get { return new Vector4d(W, Y, X, Z); } set { W = value.X; Y = value.Y; X = value.Z; Z = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyxw { get { return new Vector4d(W, Y, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyyx { get { return new Vector4d(W, Y, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyyy { get { return new Vector4d(W, Y, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyyz { get { return new Vector4d(W, Y, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyyw { get { return new Vector4d(W, Y, Y, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Y, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyzx { get { return new Vector4d(W, Y, Z, X); } set { W = value.X; Y = value.Y; Z = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyzy { get { return new Vector4d(W, Y, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyzz { get { return new Vector4d(W, Y, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyzw { get { return new Vector4d(W, Y, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wywx { get { return new Vector4d(W, Y, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wywy { get { return new Vector4d(W, Y, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wywz { get { return new Vector4d(W, Y, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Y, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wyww { get { return new Vector4d(W, Y, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzxx { get { return new Vector4d(W, Z, X, X); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Z, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzxy { get { return new Vector4d(W, Z, X, Y); } set { W = value.X; Z = value.Y; X = value.Z; Y = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzxz { get { return new Vector4d(W, Z, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzxw { get { return new Vector4d(W, Z, X, W); } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector4d with the W, Z, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyx { get { return new Vector4d(W, Z, Y, X); } set { W = value.X; Z = value.Y; Y = value.Z; X = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyy { get { return new Vector4d(W, Z, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyz { get { return new Vector4d(W, Z, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzyw { get { return new Vector4d(W, Z, Y, W); } set { X = value.X; Z = value.Y; Y = value.Z; W = value.W; } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzzx { get { return new Vector4d(W, Z, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzzy { get { return new Vector4d(W, Z, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzzz { get { return new Vector4d(W, Z, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzzw { get { return new Vector4d(W, Z, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzwx { get { return new Vector4d(W, Z, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzwy { get { return new Vector4d(W, Z, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzwz { get { return new Vector4d(W, Z, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, Z, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wzww { get { return new Vector4d(W, Z, W, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, X, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwxx { get { return new Vector4d(W, W, X, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, X, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwxy { get { return new Vector4d(W, W, X, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, X, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwxz { get { return new Vector4d(W, W, X, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, X, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwxw { get { return new Vector4d(W, W, X, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Y, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwyx { get { return new Vector4d(W, W, Y, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Y, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwyy { get { return new Vector4d(W, W, Y, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Y, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwyz { get { return new Vector4d(W, W, Y, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Y, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwyw { get { return new Vector4d(W, W, Y, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Z, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwzx { get { return new Vector4d(W, W, Z, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Z, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwzy { get { return new Vector4d(W, W, Z, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Z, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwzz { get { return new Vector4d(W, W, Z, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, Z, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwzw { get { return new Vector4d(W, W, Z, W); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, W, and X components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwwx { get { return new Vector4d(W, W, W, X); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, W, and Y components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwwy { get { return new Vector4d(W, W, W, Y); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, W, and Z components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwwz { get { return new Vector4d(W, W, W, Z); } }

        /// <summary>
        /// Gets an OpenTK.Vector4d with the W, W, W, and W components of this instance.
        /// </summary>
        [XmlIgnore]
        public Vector4d Wwww { get { return new Vector4d(W, W, W, W); } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Vector4d operator +(Vector4d left, Vector4d right)
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
        public static Vector4d operator -(Vector4d left, Vector4d right)
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
        public static Vector4d operator -(Vector4d vec)
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
        public static Vector4d operator *(Vector4d vec, double scale)
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
        public static Vector4d operator *(double scale, Vector4d vec)
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
        public static Vector4d operator /(Vector4d vec, double scale)
        {
            double mult = 1 / scale;
            vec.X *= mult;
            vec.Y *= mult;
            vec.Z *= mult;
            vec.W *= mult;
            return vec;
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector4d left, Vector4d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector4d left, Vector4d right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a pointer to the first element of the specified instance.
        /// </summary>
        /// <param name="v">The instance.</param>
        /// <returns>A pointer to the first element of v.</returns>
        [CLSCompliant(false)]
        unsafe public static explicit operator double*(Vector4d v)
        {
            return &v.X;
        }

        /// <summary>
        /// Returns a pointer to the first element of the specified instance.
        /// </summary>
        /// <param name="v">The instance.</param>
        /// <returns>A pointer to the first element of v.</returns>
        public static explicit operator IntPtr(Vector4d v)
        {
            unsafe
            {
                return (IntPtr)(&v.X);
            }
        }

        /// <summary>Converts OpenTK.Vector4 to OpenTK.Vector4d.</summary>
        /// <param name="v4">The Vector4 to convert.</param>
        /// <returns>The resulting Vector4d.</returns>
        public static explicit operator Vector4d(Vector4 v4)
        {
            return new Vector4d(v4.X, v4.Y, v4.Z, v4.W);
        }

        /// <summary>Converts OpenTK.Vector4d to OpenTK.Vector4.</summary>
        /// <param name="v4d">The Vector4d to convert.</param>
        /// <returns>The resulting Vector4.</returns>
        public static explicit operator Vector4(Vector4d v4d)
        {
            return new Vector4((float)v4d.X, (float)v4d.Y, (float)v4d.Z, (float)v4d.W);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        private static string listSeparator = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        /// <summary>
        /// Returns a System.String that represents the current Vector4d.
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
            if (!(obj is Vector4d))
                return false;

            return this.Equals((Vector4d)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Vector4d> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector4d other)
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