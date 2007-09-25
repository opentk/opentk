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

        #region Add

        /// <summary>
        /// Adds the given Vector2 to the current Vector4.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public Vector4 Add(Vector2 right)
        {
            return new Vector4(X + right.X, Y + right.Y, Z, W);
        }

        /// <summary>
        /// Adds the given Vector3 to the current Vector4.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public Vector4 Add(Vector3 right)
        {
            return new Vector4(X + right.X, Y + right.Y, Z + right.Z, W);
        }

        /// <summary>
        /// Adds the given Vector4 to the current Vector4. W-coordinate remains unaffected.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public Vector4 Add(Vector4 right)
        {
            return new Vector4(X + right.X, Y + right.Y, Z + right.Z, W + right.W);
        }

        #endregion

        #region Sub

        /// <summary>
        /// Subtracts the given Vector2 from the current Vector4.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector4 containing the result of the subtraction.</returns>
        public Vector4 Sub(Vector2 right)
        {
            return new Vector4(X - right.X, Y - right.Y, Z, W);
        }

        /// <summary>
        /// Subtracts the given Vector3 from the current Vector4.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector4 containing the result of the subtraction.</returns>
        public Vector4 Sub(Vector3 right)
        {
            return new Vector4(X - right.X, Y - right.Y, Z - right.Z, W);
        }

        /// <summary>
        /// Subtracts the given Vector4 from the current Vector4.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector4 containing the result of the subtraction.</returns>
        public Vector4 Sub(Vector4 right)
        {
            return new Vector4(X - right.X, Y - right.Y, Z - right.Z, W - right.W);
        }

        #endregion

        #region Dot

        /// <summary>
        /// Computes the dot product between the current Vector4 and the given Vector2.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector2 right)
        {
            return X * right.X + Y * right.Y;
        }

        /// <summary>
        /// Computes the dot product between the current Vector4 and the given Vector3.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector3 right)
        {
            return X * right.X + Y * right.Y + Z * right.Z;
        }

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
        /*
        #region Cross

        /// <summary>
        /// Computes the cross product between the current and the given Vector3.
        /// </summary>
        /// <param name="right">The right operand of the cross product</param>
        /// <returns>A new Vector3 containing the result of the computation.</returns>
        public Vector3 Cross(Vector3 right)
        {
            return new Vector3(
                Y * right.Z - Z * right.Y,
                Z * right.X - X * right.Z,
                X * right.Y - Y * right.X);
        }

        #endregion
        */
        #region public float Length

        /// <summary>
        /// Gets the length of the vector.
        /// </summary>
        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(this.LengthSquared);
            }
        }

        #endregion

        #region public float LengthSquared

        /// <summary>
        /// Gets the square of the vector length.
        /// </summary>
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
            float length = this.Length;
            return new Vector4(X / length, Y / Length, Z / length, W / length);
        }

        #endregion

        #region public Vector2 Scale(float sx, float sy, float sz, float sw)

        /// <summary>
        /// Scales the current Vector4 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        /// <param name="sw">The scale of the Z component.</param>
        /// <returns>A new, scaled Vector4.</returns>
        public Vector4 Scale(float sx, float sy, float sz, float sw)
        {
            return new Vector4(X * sx, Y * sy, Z * sz, W * sw);
        }

        #endregion

        #endregion

        #region Operator overloads

        public static Vector4 operator +(Vector4 left, Vector2 right)
        {
            return left.Add(right);
        }

        public static Vector4 operator +(Vector4 left, Vector3 right)
        {
            return left.Add(right);
        }

        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return left.Add(right);
        }

        public static Vector4 operator -(Vector4 left, Vector2 right)
        {
            return left.Sub(right);
        }

        public static Vector4 operator -(Vector4 left, Vector3 right)
        {
            return left.Sub(right);
        }

        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return left.Sub(right);
        }

        [CLSCompliant(false)]
        unsafe public static implicit operator float*(Vector4 v)
        {
            return &v.X;
        }

        #endregion

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2}, {3})", X, Y, Z, W);
        }
    }
}
