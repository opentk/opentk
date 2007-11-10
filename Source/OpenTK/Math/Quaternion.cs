#region --- License ---
/* Copyright (c) 2006, 2007 the OpenTK team
 * See license.txt for license info
 * 
 * Implemented by Andy Gill
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a Quaternion
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Quaternion
    {
        #region Fields

		/// <summary>
		/// The vector part of the quaternion
		/// </summary>
		public Vector3 XYZ;
		/// <summary>
		/// The w component of the quaternion
		/// </summary>
		public float W;

		public static Quaternion Identity = new Quaternion(0, 0, 0, 1);

        #endregion

        #region Constructors

		/// <summary>
		/// Construct a new Quaternion from vector and w components
		/// </summary>
		/// <param name="v">The vector part</param>
		/// <param name="w">The w part</param>
		public Quaternion(Vector3 v, float w)
		{
			XYZ = v;
			W = w;
		}

		/// <summary>
		/// Construct a new Quaternion
		/// </summary>
		/// <param name="x">The x component</param>
		/// <param name="y">The y component</param>
		/// <param name="z">The z component</param>
		/// <param name="w">The w component</param>
		public Quaternion(float x, float y, float z, float w)
		{
			XYZ = new Vector3(x, y, z);
			W = w;
		}

        #endregion

        #region Functions

		#region pubilc void ToAxisAngle(out Vector3 axis, out float angle)

		/// <summary>
		/// Convert the current quaternion to axis angle representation
		/// </summary>
		/// <param name="axis">The resultant axis</param>
		/// <param name="angle">The resultant angle</param>
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
			Quaternion q = this;
			if (q.W > 1.0f)
				q.Normalize();

			angle = 2.0f * (float)System.Math.Acos(q.W);
			float den = (float)System.Math.Sqrt(1.0 - q.W * q.W);
			axis = q.XYZ;
			if (den > 0.0001f)
			{
				axis = q.XYZ / den;
			}
		}

		#endregion

		#region public float Length

		/// <summary>
        /// Gets the length (magnitude) of the quaternion.
        /// </summary>
        /// <seealso cref="LengthSquared"/>
		public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(W * W + XYZ.LengthSquared);
            }
        }

        #endregion

		#region public float LengthSquared

		/// <summary>
        /// Gets the square of the quaternion length (magnitude).
        /// </summary>
        public float LengthSquared
        {
            get
            {
                return W * W + XYZ.LengthSquared;
            }
        }

        #endregion

        #region public void Normalize()

        /// <summary>
        /// Scales the Quaternion to unit length.
        /// </summary>
        public void Normalize()
        {
            float scale = 1.0f / this.Length;
            XYZ *= scale;
            W *= scale;
        }

        #endregion

		#region public void Conjugate()

		/// <summary>
		/// Convert this quaternion to its conjugate
		/// </summary>
		public void Conjugate()
		{
			XYZ = -XYZ;
		}

		#endregion

		#endregion

		#region Operator overloads

		public static Quaternion operator +(Quaternion left, Quaternion right)
        {
            left.XYZ += right.XYZ;
            left.W += right.W;
            return left;
        }

		public static Quaternion operator -(Quaternion left, Quaternion right)
        {
            left.XYZ -= right.XYZ;
            left.W -= right.W;
            return left;
        }

		public static Quaternion operator *(Quaternion left, Quaternion right)
		{
			float w = left.W * right.W - Vector3.Dot(left.XYZ, right.XYZ);
			left.XYZ = right.W * left.XYZ + left.W * right.XYZ + Vector3.Cross(left.XYZ, right.XYZ);
			left.W = w;
			return left;
		}

		[CLSCompliant(false)]
		unsafe public static explicit operator float*(Quaternion q)
        {
            return &q.XYZ.X;
        }

		public static explicit operator IntPtr(Quaternion q)
        {
			unsafe
			{
				return (IntPtr)(&q.XYZ.X);
			}
        }

        #endregion

		#region Static functions

		#region Add

		/// <summary>
		/// Add two quaternions
		/// </summary>
		/// <param name="left">The first operand</param>
		/// <param name="right">The second operand</param>
		/// <returns>The result of the addition</returns>
		public static Quaternion Add(Quaternion left, Quaternion right)
        {
            left.XYZ += right.XYZ;
            left.W += right.W;
            return left;
        }

		/// <summary>
		/// Add two quaternions
		/// </summary>
		/// <param name="left">The first operand</param>
		/// <param name="right">The second operand</param>
		/// <param name="result">The result of the addition</param>
		public static void Add(ref Quaternion left, ref Quaternion right, out Quaternion result)
		{
            result.XYZ = left.XYZ + right.XYZ;
            result.W = left.W + right.W;
		}

		#endregion

		#region Sub

		public static Quaternion Sub(Quaternion left, Quaternion right)
        {
            left.XYZ -= right.XYZ;
            left.W -= right.W;
            return left;
		}

		public static void Sub(ref Quaternion left, ref Quaternion right, out Quaternion result)
		{
            result.XYZ = left.XYZ - right.XYZ;
            result.W = left.W - right.W;
		}

		#endregion

		#region Mult

		public static Quaternion Mult(Quaternion left, Quaternion right)
		{
			float w = left.W * right.W - Vector3.Dot(left.XYZ, right.XYZ);
			left.XYZ = right.W * left.XYZ + left.W * right.XYZ + Vector3.Cross(left.XYZ, right.XYZ);
			left.W = w;
			return left;
		}

		public static void Mult(ref Quaternion left, ref Quaternion right, out Quaternion result)
		{
			result.W = left.W * right.W - Vector3.Dot(left.XYZ, right.XYZ);
			result.XYZ = right.W * left.XYZ + left.W * right.XYZ + Vector3.Cross(left.XYZ, right.XYZ);
		}

		#endregion

		#region Conjugate

		/// <summary>
		/// Get the conjugate of the given quaternion
		/// </summary>
		/// <param name="q">The quaternion</param>
		/// <returns>The conjugate of the given quaternion</returns>
		public static Quaternion Conjugate(Quaternion q)
		{
			q.XYZ = -q.XYZ;
			return q;
		}

		/// <summary>
		/// Get the conjugate of the given quaternion
		/// </summary>
		/// <param name="q">The quaternion</param>
		/// <param name="result">The conjugate of the given quaternion</param>
		public static void Conjugate(ref Quaternion q, out Quaternion result)
		{
			result.XYZ = -q.XYZ;
			result.W = q.W;
		}
		
		#endregion

		#region Invert

		/// <summary>
		/// Get the inverse of the given quaternion
		/// </summary>
		/// <param name="q">The quaternion to invert</param>
		/// <returns>The inverse of the given quaternion</returns>
		public static Quaternion Invert(Quaternion q)
		{
			float lengthSq = q.LengthSquared;
			if (lengthSq != 0.0)
			{
				float i = 1.0f / lengthSq;
				q.XYZ *= -i;
				q.W *= i;
			}
			return q;
		}

		/// <summary>
		/// Get the inverse of the given quaternion
		/// </summary>
		/// <param name="q">The quaternion to invert</param>
		/// <param name="result">The inverse of the given quaternion</param>
		public static void Invert(ref Quaternion q, out Quaternion result)
		{
			float lengthSq = q.LengthSquared;
			if (lengthSq != 0.0)
			{
				float i = 1.0f / lengthSq;
				result.XYZ = q.XYZ * -i;
				result.W = q.W * i;
			}
			else
			{
				result = q;
			}
		}
		
		#endregion

		#region Normalize

		/// <summary>
		/// Scale the given quaternion to unit length
		/// </summary>
		/// <param name="q">The quaternion to normalize</param>
		/// <returns>The normalized quaternion</returns>
		public static Quaternion Normalize(Quaternion q)
		{
			float scale = 1.0f / q.Length;
			q.XYZ *= scale;
			q.W *= scale;
			return q;
		}

		/// <summary>
		/// Scale the given quaternion to unit length
		/// </summary>
		/// <param name="q">The quaternion to normalize</param>
		/// <param name="result">The normalized quaternion</param>
		public static void Normalize(ref Quaternion q, out Quaternion result)
		{
			float scale = 1.0f / q.Length;
			result.XYZ = q.XYZ * scale;
			result.W = q.W * scale;
		}

		#endregion

		#region FromAxisAngle

		/// <summary>
		/// Build a quaternion from the given axis and angle
		/// </summary>
		/// <param name="axis">The axis to rotate about</param>
		/// <param name="angle">The rotation angle in radians</param>
		/// <returns></returns>
		public static Quaternion FromAxisAngle(Vector3 axis, float angle)
		{
			if (axis.LengthSquared == 0.0f)
				return Identity;

			Quaternion result = Identity;

			angle *= 0.5f;
			axis.Normalize();
			result.XYZ = axis * (float)System.Math.Sin(angle);
			result.W = (float)System.Math.Cos(angle);

			return Normalize(result);
		}

		#endregion

		#region Slerp

		/// <summary>
		/// Do Spherical linear interpolation between two quaternions 
		/// </summary>
		/// <param name="q1">The first quaternion</param>
		/// <param name="q2">The second quaternion</param>
		/// <param name="blend">The blend factor</param>
		/// <returns>A smooth blend between the given quaternions</returns>
		public static Quaternion Slerp(Quaternion q1, Quaternion q2, float blend)
		{
			// if either input is zero, return the other.
			if (q1.LengthSquared == 0.0f)
			{
				if (q2.LengthSquared == 0.0f)
				{
					return Identity;
				}
				return q2;
			}
			else if (q2.LengthSquared == 0.0f)
			{
				return q1;
			}


			float cosHalfAngle = q1.W * q2.W + Vector3.Dot(q1.XYZ, q2.XYZ);

			if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
			{
				// angle = 0.0f, so just return one input.
				return q1;
			}
			else if (cosHalfAngle < 0.0f)
			{
				q2.XYZ = -q2.XYZ;
				q2.W = -q2.W;
				cosHalfAngle = -cosHalfAngle;
			}

			float blendA;
			float blendB;
			if (cosHalfAngle < 0.99f)
			{
				// do proper slerp for big angles
				float halfAngle = (float)System.Math.Acos(cosHalfAngle);
				float sinHalfAngle = (float)System.Math.Sin(halfAngle);
				float oneOverSinHalfAngle = 1.0f / sinHalfAngle;
				blendA = (float)System.Math.Sin(halfAngle * (1.0f - blend)) * oneOverSinHalfAngle;
				blendB = (float)System.Math.Sin(halfAngle * blend) * oneOverSinHalfAngle;
			}
			else
			{
				// do lerp if angle is really small.
				blendA = 1.0f - blend;
				blendB = blend;
			}

			Quaternion result = new Quaternion(blendA * q1.XYZ + blendB * q2.XYZ, blendA * q1.W + blendB * q2.W);
			if (result.LengthSquared > 0.0f)
				return Normalize(result);
			else
				return Identity;
		}

		#endregion

		#endregion

		#region public override string ToString()

		/// <summary>
        /// Returns a System.String that represents the current Quaternion.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("V: {0}, W: {1}", XYZ, W);
        }

        #endregion
    }
}
