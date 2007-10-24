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

        #region public Vector2 Add(Vector2 right)

        /// <summary>
        /// Adds the given Vector2 to the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>The current Vector2, modified by the operation.</returns>
        public Vector2 Add(Vector2 right)
        {
            this.X = X + right.X;
            this.Y = Y + right.Y;
            return this;
        }

        #endregion

        #region public Vector2 Sub(Vector2 right)

        /// <summary>
        /// Subtracts the given Vector2 from the current Vector2.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>The current Vector2, modified by the operation.</returns>
        public Vector2 Sub(Vector2 right)
        {
            this.X = X - right.X;
            this.Y = Y - right.Y;
            return this;
        }

        #endregion

        #region public float Dot(Vector2 right)

        /// <summary>
        /// Computes the dot product between the current Vector2 and the given Vector2.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the operation.</returns>
        public float Dot(Vector2 right)
        {
            return X * right.X + Y * right.Y;
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
                return OpenTK.Math.Functions.SqrtFast(X * X + Y * Y);
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

        #region public Vector2 Normalize()

        /// <summary>
        /// Scales the Vector2 to unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector2 Normalize()
        {
            float length = this.Length;
            return new Vector2(X / length, Y / Length);
        }

        #endregion

        #region public Vector2 NormalizeFast()

        /// <summary>
        /// Scales the Vector2 to unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector2 NormalizeFast()
        {
            float length = this.LengthFast;
            this.X = X / length;
            this.Y = Y / length;
            return this;
        }

        #endregion

        #region public Vector2 Scale(float sx, float sy)

        /// <summary>
        /// Scales the current Vector2 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <returns>The current Vector2, scaled.</returns>
        public Vector2 Scale(float sx, float sy)
        {
            this.X = X * sx;
            this.Y = Y * sy;
            return this;
        }

        #endregion

        #endregion

        #region Operator overloads

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left).Add(right);
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left).Sub(right);
        }

        [CLSCompliant(false)]
        unsafe public static implicit operator float*(Vector2 v)
        {
            return &v.X;
        }

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
