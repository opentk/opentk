#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a four-dimensional vector.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector4
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector4.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector4.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the Vector4.
        /// </summary>
        public float Z;

        /// <summary>
        /// The Z component of the Vector4.
        /// </summary>
        public float W;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Vector4.
        /// </summary>
        /// <param name="x">The x component of the Vector4.</param>
        /// <param name="y">The y component of the Vector4.</param>
        /// <param name="z">The z component of the Vector4.</param>
        /// <param name="w">The z component of the Vector4.</param>
        public Vector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        /// <summary>
        /// Constructs a new Vector4 from the given Vector2.
        /// </summary>
        /// <param name="v">The Vector2 to copy components from.</param>
        public Vector4(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
            W = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector4 from the given Vector3.
        /// </summary>
        /// <param name="v">The Vector3 to copy components from.</param>
        public Vector4(Vector3 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector4 from the given Vector4.
        /// </summary>
        /// <param name="v">The Vector4 to copy components from.</param>
        public Vector4(Vector4 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = v.W;
        }

        #endregion

        #region Functions

        #region public Vector4 Add(Vector4 right)

        /// <summary>
        /// Adds the given Vector4 to the current Vector4. W-coordinate remains unaffected.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public Vector4 Add(Vector4 right)
        {
            X += right.X;
            Y += right.Y;
            Z += right.Z;
            W += right.W;
            return this;
        }

        #endregion

        #region public Vector4 Sub(Vector4 right)

        /// <summary>
        /// Subtracts the given Vector4 from the current Vector4.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector4 containing the result of the subtraction.</returns>
        public Vector4 Sub(Vector4 right)
        {
            X -= right.X;
            Y -= right.Y;
            Z -= right.Z;
            W -= right.W;
            return this;
        }

        #endregion

        #region public float Dot(Vector4 right)

        /// <summary>
        /// Computes the dot product between the current Vector4 and the given Vector4.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector4 right)
        {
            return X * right.X + Y * right.Y + Z * right.Z + W * right.W;
        }

        #endregion

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
                return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
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
                return 1.0f / OpenTK.Math.Functions.InverseSqrtFast(X * X + Y * Y + Z * Z + W * W);
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
                return X * X + Y * Y + Z * Z + W * W;
            }
        }

        #endregion

        #region public Vector4 Normalize()

        /// <summary>
        /// Scales the Vector4 to unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector4 Normalize()
        {
            float scale = 1.0f / this.Length;
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
            return this;
        }

        #endregion

        #region public Vector4 NormalizeFast()

        /// <summary>
        /// Scales the Vector4 to approximately unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector4 NormalizeFast()
        {
            float scale = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
            X *= scale;
            Y *= scale;
            Z *= scale;
            W *= scale;
            return this;
        }

        #endregion

        #region public Vector4 Scale(float sx, float sy, float sz, float sw)

        /// <summary>
        /// Scales the current Vector4 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        /// <param name="sw">The scale of the Z component.</param>
        /// <returns>The current Vector4, scaled.</returns>
        public Vector4 Scale(float sx, float sy, float sz, float sw)
        {
            return new Vector4(X * sx, Y * sy, Z * sz, W * sw);
        }

        #endregion

        #endregion

        #region Operator overloads

        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return left.Add(right);
        }

        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return left.Sub(right);
        }

        [CLSCompliant(false)]
        unsafe public static explicit operator float*(Vector4 v)
        {
            return &v.X;
        }

        public static explicit operator IntPtr(Vector4 v)
        {
            unsafe
            {
                return (IntPtr)(&v.X);
            }
        }


        #endregion

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2}, {3})", X, Y, Z, W);
        }
    }
}
