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
    /// Represents a 2D vector.
    /// </summary>
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

        #endregion

        #region Add

        /// <summary>
        /// Adds the given Vector2 to the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector2 containing the result of the addition.</returns>
        public Vector2 Add(Vector2 right)
        {
            return new Vector2(X + right.X, Y + right.Y);
        }

        /// <summary>
        /// Adds the given Vector3 to the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public Vector3 Add(Vector3 right)
        {
            return new Vector3(X + right.X, Y + right.Y, right.Z);
        }

        /// <summary>
        /// Adds the given Vector4 to the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public Vector4 Add(Vector4 right)
        {
            return new Vector4(X + right.X, Y + right.Y, right.Z, right.W);
        }

        #endregion

        #region Sub

        /// <summary>
        /// Subtracts the given Vector2 from the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector2 containing the result of the subtraction.</returns>
        public Vector2 Sub(Vector2 right)
        {
            return new Vector2(X - right.X, Y - right.Y);
        }

        /// <summary>
        /// Subtracts the given Vector3 from the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector3 containing the result of the subtraction.</returns>
        public Vector3 Sub(Vector3 right)
        {
            return new Vector3(X - right.X, Y - right.Y, -right.Z);
        }

        /// <summary>
        /// Subtracts the given Vector4 from the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector4 containing the result of the subtraction.</returns>
        public Vector4 Sub(Vector4 right)
        {
            return new Vector4(X - right.X, Y - right.Y, -right.Z, -right.W);
        }

        #endregion

        #region Dot

        /// <summary>
        /// Computes the dot product between the current Vector2 and the given Vector2.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector2 right)
        {
            return X * right.X + Y * right.Y;
        }

        /// <summary>
        /// Computes the dot product between the current Vector2 and the given Vector3.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector3 right)
        {
            return X * right.X + Y * right.Y;
        }

        /// <summary>
        /// Computes the dot product between the current Vector2 and the given Vector4.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector4 right)
        {
            return X * right.X + Y * right.Y;
        }

        #endregion

        #region Operator overloads

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return left.Add(right);
        }

        public static Vector3 operator +(Vector2 left, Vector3 right)
        {
            return left.Add(right);
        }

        public static Vector4 operator +(Vector2 left, Vector4 right)
        {
            return left.Add(right);
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return left.Sub(right);
        }

        public static Vector3 operator -(Vector2 left, Vector3 right)
        {
            return left.Sub(right);
        }

        public static Vector4 operator -(Vector2 left, Vector4 right)
        {
            return left.Sub(right);
        }

        [CLSCompliant(false)]
        unsafe public static implicit operator float*(Vector2 v)
        {
            return &v.X;
        }

        #endregion
    }
}
