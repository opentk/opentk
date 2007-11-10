#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 * 
 * Contributions by Andy Gill.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a 2D vector.
    /// </summary>
    /// <remarks>
    /// The Vector2 structure is suitable for interoperation with unmanaged code requiring two consecutive floats.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector2.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector2.
        /// </summary>
        public float Y;

		public static Vector2 UnitX = new Vector2(1, 0);
		public static Vector2 UnitY = new Vector2(0, 1);
		public static Vector2 Zero = new Vector2(0, 0);

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Vector2.
        /// </summary>
        /// <param name="x">The x coordinate of the net Vector2.</param>
        /// <param name="y">The y coordinate of the net Vector2.</param>
        public Vector2(float x, float y)
        {
			X = x;
			Y = y;
        }

        /// <summary>
        /// Constructs a new Vector2 from the given Vector2.
        /// </summary>
        /// <param name="v">The Vector2 to copy components from.</param>
        public Vector2(Vector2 v)
        {
			X = v.X;
			Y = v.Y;
        }

        /// <summary>
        /// Constructs a new Vector2 from the given Vector3.
        /// </summary>
        /// <param name="v">The Vector3 to copy components from. Z is discarded.</param>
        public Vector2(Vector3 v)
        {
			X = v.X;
			Y = v.Y;
        }

        /// <summary>
        /// Constructs a new Vector2 from the given Vector4.
        /// </summary>
        /// <param name="v">The Vector4 to copy components from. Z and W are discarded.</param>
        public Vector2(Vector4 v)
        {
			X = v.X;
			Y = v.Y;
        }

        #endregion

        #region Functions

        #region public float Length

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="FastLength"/>
        /// <seealso cref="LengthSquared"/>
        public float Length
        {
			get
			{
				return (float)System.Math.Sqrt(X * X + Y * Y);
			}
        }

        #endregion

        #region public float LengthFast

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude, with
        /// an upper error bound of 0.001.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        /// <seealso cref="OpenTK.Math.FastSqrt"/>
        public float LengthFast
        {
			get
			{
				return 1.0f / OpenTK.Math.Functions.InverseSqrtFast(X * X + Y * Y);
			}
        }

        #endregion

        #region public float LengthSquared

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="FastLength"/>
        public float LengthSquared
        {
			get
			{
				return X * X + Y * Y;
			}
        }

        #endregion

        #region public void Normalize()

        /// <summary>
        /// Scales the Vector2 to unit length.
        /// </summary>
        public void Normalize()
        {
			float scale = 1.0f / this.Length;
			X *= scale;
			Y *= scale;
        }

        #endregion

        #region public void NormalizeFast()

        /// <summary>
        /// Scales the Vector2 to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
			float scale = Functions.InverseSqrtFast(X * X + Y * Y);
			X *= scale;
			Y *= scale;
        }

        #endregion

        #region public void Scale(float sx, float sy)

        /// <summary>
        /// Scales the current Vector2 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        public void Scale(float sx, float sy)
        {
			this.X = X * sx;
			this.Y = Y * sy;
        }

        #endregion

        #endregion

        #region Operator overloads

		public static Vector2 operator +(Vector2 left, Vector2 right)
		{
			left.X += right.X;
			left.Y += right.Y;
			return left;
		}

		public static Vector2 operator -(Vector2 left, Vector2 right)
		{
			left.X -= right.X;
			left.Y -= right.Y;
			return left;
		}

		public static Vector2 operator -(Vector2 vec)
		{
			vec.X = -vec.X;
			vec.Y = -vec.Y;
			return vec;
		}

		public static Vector2 operator *(Vector2 vec, float f)
		{
			vec.X *= f;
			vec.Y *= f;
			return vec;
		}

		public static Vector2 operator *(float f, Vector2 vec)
		{
			vec.X *= f;
			vec.Y *= f;
			return vec;
		}

		public static Vector2 operator /(Vector2 vec, float f)
		{
			float mult = 1.0f / f;
			vec.X *= mult;
			vec.Y *= mult;
			return vec;
		}

		[CLSCompliant(false)]
		unsafe public static explicit operator float*(Vector2 v)
		{
		    return &v.X;
		}

		public static explicit operator IntPtr(Vector2 v)
		{
			unsafe
			{
				return (IntPtr)(&v.X);
			}
		}

        #endregion

		#region Static functions

		#region Add

		/// <summary>
		/// Add two Vectors
		/// </summary>
		/// <param name="a">First operand</param>
		/// <param name="b">Second operand</param>
		/// <returns>Result of addition</returns>
		public static Vector2 Add(Vector2 a, Vector2 b)
		{
			a.X += b.X;
			a.Y += b.Y;
			return a;
		}

		/// <summary>
		/// Add two Vectors
		/// </summary>
		/// <param name="a">First operand</param>
		/// <param name="b">Second operand</param>
		/// <param name="result">Result of addition</param>
		public static void Add(ref Vector2 a, ref Vector2 b, out Vector2 result)
		{
			result.X = a.X + b.X;
			result.Y = a.Y + b.Y;
		}

		#endregion

		#region Sub

		/// <summary>
		/// Subtract one Vector from another
		/// </summary>
		/// <param name="a">First operand</param>
		/// <param name="b">Second operand</param>
		/// <returns>Result of subtraction</returns>
		public static Vector2 Sub(Vector2 a, Vector2 b)
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
		public static void Sub(ref Vector2 a, ref Vector2 b, out Vector2 result)
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
		/// <param name="f">Scalar operand</param>
		/// <returns>Result of the multiplication</returns>
		public static Vector2 Mult(Vector2 a, float f)
		{
			a.X *= f;
			a.Y *= f;
			return a;
		}

		/// <summary>
		/// Multiply a vector and a scalar
		/// </summary>
		/// <param name="a">Vector operand</param>
		/// <param name="f">Scalar operand</param>
		/// <param name="result">Result of the multiplication</param>
		public static void Mult(ref Vector2 a, float f, out Vector2 result)
		{
			result.X = a.X * f;
			result.Y = a.Y * f;
		}

		#endregion

		#region Div

		/// <summary>
		/// Divide a vector by a scalar
		/// </summary>
		/// <param name="a">Vector operand</param>
		/// <param name="f">Scalar operand</param>
		/// <returns>Result of the division</returns>
		public static Vector2 Div(Vector2 a, float f)
		{
			float mult = 1.0f / f;
			a.X *= mult;
			a.Y *= mult;
			return a;
		}

		/// <summary>
		/// Divide a vector by a scalar
		/// </summary>
		/// <param name="a">Vector operand</param>
		/// <param name="f">Scalar operand</param>
		/// <param name="result">Result of the division</param>
		public static void Div(ref Vector2 a, float f, out Vector2 result)
		{
			float mult = 1.0f / f;
			result.X = a.X * mult;
			result.Y = a.Y * mult;
		}

		#endregion

		#region Min

		/// <summary>
		/// Calculate the component-wise minimum of two vectors
		/// </summary>
		/// <param name="a">First operand</param>
		/// <param name="b">Second operand</param>
		/// <returns>The component-wise minimum</returns>
		public static Vector2 Min(Vector2 a, Vector2 b)
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
		public static void Min(ref Vector2 a, ref Vector2 b, out Vector2 result)
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
		public static Vector2 Max(Vector2 a, Vector2 b)
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
		public static void Max(ref Vector2 a, ref Vector2 b, out Vector2 result)
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
		public static Vector2 Clamp(Vector2 vec, Vector2 min, Vector2 max)
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
		public static void Clamp(ref Vector2 vec, ref Vector2 min, ref Vector2 max, out Vector2 result)
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
		public static Vector2 Normalize(Vector2 vec)
        {
			float scale = 1.0f / vec.Length;
			vec.X *= scale;
			vec.Y *= scale;
			return vec;
        }

		/// <summary>
		/// Scale a vector to unit length
		/// </summary>
		/// <param name="vec">The input vector</param>
		/// <param name="result">The normalized vector</param>
		public static void Normalize(ref Vector2 vec, out Vector2 result)
		{
			float scale = 1.0f / vec.Length;
			result.X = vec.X * scale;
			result.Y = vec.Y * scale;
		}

		#endregion

		#region NormalizeFast

		/// <summary>
		/// Scale a vector to approximately unit length
		/// </summary>
		/// <param name="vec">The input vector</param>
		/// <returns>The normalized vector</returns>
		public static Vector2 NormalizeFast(Vector2 vec)
        {
			float scale = Functions.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
			vec.X *= scale;
			vec.Y *= scale;
			return vec;
        }

		/// <summary>
		/// Scale a vector to approximately unit length
		/// </summary>
		/// <param name="vec">The input vector</param>
		/// <param name="result">The normalized vector</param>
		public static void NormalizeFast(ref Vector2 vec, out Vector2 result)
		{
			float scale = Functions.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
			result.X = vec.X * scale;
			result.Y = vec.Y * scale;
		}

		#endregion

		#region Dot

		/// <summary>
		/// Caclulate the dot (scalar) product of two vectors
		/// </summary>
		/// <param name="left">First operand</param>
		/// <param name="right">Second operand</param>
		/// <returns>The dot product of the two inputs</returns>
		public static float Dot(Vector2 left, Vector2 right)
		{
			return left.X * right.X + left.Y * right.Y;
		}

		#endregion

		#region Lerp

		/// <summary>
		/// Returns a new Vector that is the linear blend of the 2 given Vectors
		/// </summary>
		/// <param name="a">First input vector</param>
		/// <param name="b">Second input vector</param>
		/// <param name="blend">The blend factor</param>
		/// <returns>a when blend=0, b when blend=1, and a linear combination otherwise</returns>
		public static Vector2 Lerp(Vector2 a, Vector2 b, float blend)
		{
			a.X = blend * (b.X - a.X) + a.X;
			a.Y = blend * (b.Y - a.Y) + a.Y;
			return a;
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
		public static Vector2 BaryCentric(Vector2 a, Vector2 b, Vector2 c, float u, float v)
		{
			return a + u * (b - a) + v * (c - a);
		}

		#endregion

		#endregion

		#region public override string ToString()

		/// <summary>
        /// Returns a System.String that represents the current Vector2.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }

        #endregion
    }
}
