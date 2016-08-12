#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 * 
 * Contributions by Andy Gill, James Talton and Georg Wächter.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    /// <summary>
    /// Contains mathematical functions for the OpenTK.Math toolkit.
    /// </summary>
    [Obsolete("Use OpenTK.MathHelper instead.")]
    public static class Functions
    {
        #region NextPowerOfTwo

        /// <summary>
        /// Returns the next power of two that is larger than the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        public static long NextPowerOfTwo(long n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Must be positive.");
            return (long)System.Math.Pow(2, System.Math.Ceiling(System.Math.Log((double)n, 2)));
        }

        /// <summary>
        /// Returns the next power of two that is larger than the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        public static int NextPowerOfTwo(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Must be positive.");
            return (int)System.Math.Pow(2, System.Math.Ceiling(System.Math.Log((double)n, 2)));
        }

        /// <summary>
        /// Returns the next power of two that is larger than the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        public static float NextPowerOfTwo(float n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Must be positive.");
            return (float)System.Math.Pow(2, System.Math.Ceiling(System.Math.Log((double)n, 2)));
        }

        /// <summary>
        /// Returns the next power of two that is larger than the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        public static double NextPowerOfTwo(double n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Must be positive.");
            return System.Math.Pow(2, System.Math.Ceiling(System.Math.Log((double)n, 2)));
        }

        #endregion

        #region Factorial

        /// <summary>Calculates the factorial of a given natural number.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>n!</returns>
        public static long Factorial(int n)
        {
            long result = 1;

            for (; n > 1; n--)
                result *= n;

            return result;
        }

        #endregion

        #region BinomialCoefficient

        /// <summary>
        /// Calculates the binomial coefficient <paramref name="n"/> above <paramref name="k"/>.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="k">The k.</param>
        /// <returns>n! / (k! * (n - k)!)</returns>
        public static long BinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        #endregion

        #region InverseSqrtFast

        /// <summary>
        /// Returns an approximation of the inverse square root of left number.
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
                x = x * (1.5f - xhalf * x * x); // Perform left single Newton-Raphson step.
                return x;
            }
        }

        /// <summary>
        /// Returns an approximation of the inverse square root of left number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>An approximation of the inverse square root of the specified number, with an upper error bound of 0.001</returns>
        /// <remarks>
        /// This is an improved implementation of the the method known as Carmack's inverse square root
        /// which is found in the Quake III source code. This implementation comes from
        /// http://www.codemaestro.com/reviews/review00000105.html. For the history of this method, see
        /// http://www.beyond3d.com/content/articles/8/
        /// </remarks>
        public static double InverseSqrtFast(double x)
        {
            return InverseSqrtFast((float)x);
            // TODO: The following code is wrong. Fix it, to improve precision.
#if false
            unsafe
            {
                double xhalf = 0.5f * x;
                int i = *(int*)&x;              // Read bits as integer.
                i = 0x5f375a86 - (i >> 1);      // Make an initial guess for Newton-Raphson approximation
                x = *(float*)&i;                // Convert bits back to float
                x = x * (1.5f - xhalf * x * x); // Perform left single Newton-Raphson step.
                return x;
            }
#endif
        }

        #endregion

        #region DegreesToRadians

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
        /// <param name="radians">An angle in radians</param>
        /// <returns>The angle expressed in degrees</returns>
        public static float RadiansToDegrees(float radians)
        {
            const float radToDeg = 180.0f / (float)System.Math.PI;
            return radians * radToDeg;
        }

        #endregion

        #region Mathematical constants

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        public static readonly float PIF = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930382f;

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        public static readonly float RTODF = 180.0f / PIF;

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        public static readonly float DTORF = PIF / 180.0f;

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        public static readonly double PI = 3.141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930382d;

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        public static readonly double RTOD = 180.0d / PIF;

        /// <summary>
        /// Obsolete. Do not use.
        /// </summary>
        public static readonly double DTOR = PIF / 180.0d;

        #endregion

        #region Swap

        /// <summary>
        /// Swaps two float values.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Swaps two float values.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        public static void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }

        #endregion
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
