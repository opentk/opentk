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
        /// Represents a three-dimensional vector.
        /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector3.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector3.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the Vector3.
        /// </summary>
        public float Z;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Vector3.
        /// </summary>
        /// <param name="x">The x component of the Vector3.</param>
        /// <param name="y">The y component of the Vector3.</param>
        /// <param name="z">The z component of the Vector3.</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector2.
        /// </summary>
        /// <param name="v">The Vector2 to copy components from.</param>
        public Vector3(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector3.
        /// </summary>
        /// <param name="v">The Vector3 to copy components from.</param>
        public Vector3(Vector3 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector4.
        /// </summary>
        /// <param name="v">The Vector4 to copy components from.</param>
        public Vector3(Vector4 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        #endregion

        #region Functions

        #region public Vector3 Add(Vector3 right)

        /// <summary>
        /// Adds the given Vector3 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>The current Vector3, containing the result of the addition.</returns>
        public Vector3 Add(Vector3 right)
        {
            X += right.X;
            Y += right.Y;
            Z += right.Z;
            return this;
        }

        #endregion

        #region public Vector3 Sub(Vector3 right)

        /// <summary>
        /// Subtracts the given Vector3 from the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector3 containing the result of the subtraction.</returns>
        public Vector3 Sub(Vector3 right)
        {
            X -= right.X;
            Y -= right.Y;
            Z -= right.Z;
            return this;
        }

        #endregion

        #region public float Dot(Vector3 right)

        /// <summary>
        /// Computes the dot product between the current Vector3 and the given Vector3.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector3 right)
        {
            return X * right.X + Y * right.Y + Z * right.Z;
        }

        #endregion

        #region public Vector3 Cross(Vector3 right)

        /// <summary>
        /// Computes the cross product between the current and the given Vector3. The current Vector3 is set to the result of the computation.
        /// </summary>
        /// <param name="right">The right operand of the cross product</param>
        /// <returns>The current </returns>
        public Vector3 Cross(Vector3 right)
        {
            float
                x = Y * right.Z - Z * right.Y,
                y = Z * right.X - X * right.Z,
                z = X * right.Y - Y * right.X;
            X = x;
            Y = y;
            Z = z;
            return this;
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
                return (float)System.Math.Sqrt(X * X + Y * Y + Z * Z);
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
                return 1.0f / OpenTK.Math.Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
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
                return X * X + Y * Y + Z * Z;
            }
        }

        #endregion

        #region public Vector3 Normalize()

        /// <summary>
        /// Scales the Vector3 to unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector3 Normalize()
        {
            float scale = 1.0f / this.Length;
            X *= scale;
            Y *= scale;
            Z *= scale;
            return this;
        }

        #endregion

        #region public Vector3 NormalizeFast()

        /// <summary>
        /// Scales the Vector3 to approximately unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector3 NormalizeFast()
        {
            float scale = Functions.InverseSqrtFast(X * X + Y * Y + Z * Z);
            X *= scale;
            Y *= scale;
            Z *= scale;
            return this;
        }

        #endregion

        #region public Vector3 Scale(float sx, float sy, float sz)

        /// <summary>
        /// Scales the current Vector3 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        /// <returns>The current Vector3, scaled.</returns>
        public Vector3 Scale(float sx, float sy, float sz)
        {
            this.X = X * sx;
            this.Y = Y * sy;
            this.Z = Z * sz;
            return this;
        }

        #endregion

        #endregion

        #region Operator overloads

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.Add(right));
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.Sub(right));
        }

        [CLSCompliant(false)]
        unsafe public static explicit operator float*(Vector3 v)
        {
            return &v.X;
        }

        public static explicit operator IntPtr(Vector3 v)
        {
            unsafe
            {
                return (IntPtr)(&v.X);
            }
        }

        #endregion

        #region Static functions

        #endregion

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
