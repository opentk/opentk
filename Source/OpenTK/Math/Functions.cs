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

namespace OpenTK.Math
{
    /// <summary>
    /// Contains mathematical functions for the OpenTK.Math toolkit.
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Returns an approximation of the inverse square root of a number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>An approximation of the inverse square root of the specified number, with an upper error bound of 0.001</returns>
        /// <remarks>
        /// This is an improved implementation of the the method known as Carmack's inverse square root
        /// which is found in the Quake III source code. This implementation comes from
        /// http://www.codemaestro.com/reviews/review00000105.html. For the history of this method, see
        /// http://www.beyond3d.com/content/articles/8/
        /// </remarks>
        public static float InverseSqrtFast(float x)
        {
            unsafe
            {
                float xhalf = 0.5f * x;
                int i = *(int*)&x;              // Read bits as integer.
                i = 0x5f375a86 - (i >> 1);      // Make an initial guess for Newton-Raphson approximation
                x = *(float*)&i;                // Convert bits back to float
                x = x * (1.5f - xhalf * x * x); // Perform a single Newton-Raphson step.
                return x;
            }
        }
	
		/// <summary>
		/// Convert degrees to radians
		/// </summary>
		/// <param name="degrees">An angle in degrees</param>
		/// <returns>The angle expressed in radians</returns>
		public static float DegreesToRadians(float degrees)
		{
			const float degToRad = (float)System.Math.PI / 180.0f;
			return degrees * degToRad;
		}

		/// <summary>
		/// Convert radians to degrees
		/// </summary>
		/// <param name="degrees">An angle in radians</param>
		/// <returns>The angle expressed in degrees</returns>
		public static float RadiansToDegrees(float radians)
		{
			const float radToDeg = 180.0f / (float)System.Math.PI;
			return radians * radToDeg;
		}
    }

#if false
    public static partial class Math
    {
        #region --- Vectors ---

        #region --- Addition ---

        /// <summary>
        /// Adds the given Vector2 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public static Vector2 Add(Vector2 left, Vector2 right)
        {
            return new Vector2(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector3 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public static Vector3 Add(Vector2 left, Vector3 right)
        {
            return new Vector3(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector4 to the current Vector3. W-coordinate remains unaffected.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public static Vector4 Add(Vector2 left, Vector4 right)
        {
            return new Vector4(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector2 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public static Vector3 Add(Vector3 left, Vector2 right)
        {
            return new Vector3(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector3 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public static Vector3 Add(Vector3 left, Vector3 right)
        {
            return new Vector3(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector4 to the current Vector3. W-coordinate remains unaffected.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public static Vector4 Add(Vector3 left, Vector4 right)
        {
            return new Vector4(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector2 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public static Vector4 Add(Vector4 left, Vector2 right)
        {
            return new Vector4(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector3 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public static Vector4 Add(Vector4 left, Vector3 right)
        {
            return new Vector4(left).Add(right);
        }

        /// <summary>
        /// Adds the given Vector4 to the current Vector3. W-coordinate remains unaffected.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public static Vector4 Add(Vector4 left, Vector4 right)
        {
            return new Vector4(left).Add(right);
        }

        #endregion

        #region --- Subtraction ---



        #endregion

        #region --- Cross ---

        /// <summary>
        /// Computes the cross product between the current and the given Vector3. The current Vector3 is set to the result of the computation.
        /// </summary>
        /// <param name="right">The right operand of the cross product</param>
        /// <returns>The current </returns>
        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            return new Vector3(left).Cross(right);
        }

        #endregion

        #endregion
    }
#endif
}
