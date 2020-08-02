﻿/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 *
 * Contributions by Andy Gill, James Talton and Georg Wächter.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Contains common mathematical functions and constants.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Defines the value of Pi divided by two as a <see cref="float"/>.
        /// </summary>
        public const float PiOver2 = MathF.PI / 2;

        /// <summary>
        /// Defines the value of Pi divided by three as a <see cref="float"/>.
        /// </summary>
        public const float PiOver3 = MathF.PI / 3;

        /// <summary>
        /// Defines the value of  Pi divided by four as a <see cref="float"/>.
        /// </summary>
        public const float PiOver4 = MathF.PI / 4;

        /// <summary>
        /// Defines the value of Pi divided by six as a <see cref="float"/>.
        /// </summary>
        public const float PiOver6 = MathF.PI / 6;

        /// <summary>
        /// Defines the value of Pi multiplied by two as a <see cref="float"/>.
        /// </summary>
        public const float TwoPi = 2 * MathF.PI;

        /// <summary>
        /// Defines the value of Pi multiplied by 3 and divided by two as a <see cref="float"/>.
        /// </summary>
        public const float ThreePiOver2 = 3 * MathF.PI / 2;

        /// <summary>
        /// Defines the base-10 logarithm of E.
        /// </summary>
        public const float Log10E = 0.4342945f;

        /// <summary>
        /// Defines the base-2 logarithm of E.
        /// </summary>
        public const float Log2E = 1.442695f;

        /// <summary>
        /// Returns the next power of two that is greater than or equal to the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        [Pure]
        public static long NextPowerOfTwo(long n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be positive.");
            }

            return (long)Math.Pow(2, Math.Ceiling(Math.Log(n, 2)));
        }

        /// <summary>
        /// Returns the next power of two that is greater than or equal to the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        [Pure]
        public static int NextPowerOfTwo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be positive.");
            }

            return (int)Math.Pow(2, Math.Ceiling(Math.Log(n, 2)));
        }

        /// <summary>
        /// Returns the next power of two that is greater than or equal to the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        [Pure]
        public static float NextPowerOfTwo(float n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be positive.");
            }

            return MathF.Pow(2, MathF.Ceiling(MathF.Log(n, 2)));
        }

        /// <summary>
        /// Returns the next power of two that is greater than or equal to the specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The next power of two.</returns>
        [Pure]
        public static double NextPowerOfTwo(double n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Must be positive.");
            }

            return Math.Pow(2, Math.Ceiling(Math.Log(n, 2)));
        }

        /// <summary>
        /// Calculates the factorial of a given natural number.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>The factorial of <paramref name="n"/>.</returns>
        [Pure]
        public static long Factorial(int n)
        {
            long result = 1;

            for (; n > 1; n--)
            {
                result *= n;
            }

            return result;
        }

        /// <summary>
        /// Calculates the binomial coefficient <paramref name="n"/> above <paramref name="k"/>.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="k">The k.</param>
        /// <returns>n! / (k! * (n - k)!).</returns>
        [Pure]
        public static long BinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        /// <summary>
        /// Returns an approximation of the inverse square root of left number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>An approximation of the inverse square root of the specified number, with an upper error bound of 0.001.</returns>
        /// <remarks>
        /// This is an improved implementation of the the method known as Carmack's inverse square root
        /// which is found in the Quake III source code. This implementation comes from
        /// http://www.codemaestro.com/reviews/review00000105.html. For the history of this method, see
        /// http://www.beyond3d.com/content/articles/8/.
        /// </remarks>
        [Pure]
        public static float InverseSqrtFast(float x)
        {
            unsafe
            {
                var xhalf = 0.5f * x;
                var i = *(int*)&x; // Read bits as integer.
                i = 0x5f375a86 - (i >> 1); // Make an initial guess for Newton-Raphson approximation
                x = *(float*)&i; // Convert bits back to float
                x = x * (1.5f - (xhalf * x * x)); // Perform left single Newton-Raphson step.
                return x;
            }
        }

        /// <summary>
        /// Returns an approximation of the inverse square root of left number.
        /// </summary>
        /// <param name="x">A number.</param>
        /// <returns>An approximation of the inverse square root of the specified number, with an upper error bound of 0.001.</returns>
        /// <remarks>
        /// This is an improved implementation of the the method known as Carmack's inverse square root
        /// which is found in the Quake III source code. This implementation comes from
        /// http://www.codemaestro.com/reviews/review00000105.html. For the history of this method, see
        /// http://www.beyond3d.com/content/articles/8/.
        /// double magic number from: https://cs.uwaterloo.ca/~m32rober/rsqrt.pdf
        /// chapter 4.8.
        /// </remarks>
        [Pure]
        public static double InverseSqrtFast(double x)
        {
            unsafe
            {
                double xhalf = 0.5 * x;
                long i = *(long*)&x; // Read bits as long.
                i = 0x5fe6eb50c7b537a9 - (i >> 1); // Make an initial guess for Newton-Raphson approximation
                x = *(double*)&i; // Convert bits back to double
                x = x * (1.5 - (xhalf * x * x)); // Perform left single Newton-Raphson step.
                return x;
            }
        }

        /// <summary>
        /// Convert degrees to radians.
        /// </summary>
        /// <param name="degrees">An angle in degrees.</param>
        /// <returns>The angle expressed in radians.</returns>
        [Pure]
        public static float DegreesToRadians(float degrees)
        {
            const float degToRad = MathF.PI / 180.0f;
            return degrees * degToRad;
        }

        /// <summary>
        /// Convert radians to degrees.
        /// </summary>
        /// <param name="radians">An angle in radians.</param>
        /// <returns>The angle expressed in degrees.</returns>
        [Pure]
        public static float RadiansToDegrees(float radians)
        {
            const float radToDeg = 180.0f / MathF.PI;
            return radians * radToDeg;
        }

        /// <summary>
        /// Convert degrees to radians.
        /// </summary>
        /// <param name="degrees">An angle in degrees.</param>
        /// <returns>The angle expressed in radians.</returns>
        [Pure]
        public static double DegreesToRadians(double degrees)
        {
            const double degToRad = Math.PI / 180.0;
            return degrees * degToRad;
        }

        /// <summary>
        /// Convert radians to degrees.
        /// </summary>
        /// <param name="radians">An angle in radians.</param>
        /// <returns>The angle expressed in degrees.</returns>
        [Pure]
        public static double RadiansToDegrees(double radians)
        {
            const double radToDeg = 180.0 / Math.PI;
            return radians * radToDeg;
        }

        /// <summary>
        /// Swaps two values.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <typeparam name="T">The type of the values to be swapped.</typeparam>
        public static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T temp = a;
            a = b;
            b = temp;
        }

        [Pure]
        private static unsafe int FloatToInt32Bits(float f)
        {
            return *(int*)&f;
        }

        /// <summary>
        /// Scales the specified number linearly between a minimum and a maximum.
        /// </summary>
        /// <param name="value">The number to scale.</param>
        /// <param name="valueMin">The minimum expected number (inclusive).</param>
        /// <param name="valueMax">The maximum expected number (inclusive).</param>
        /// <param name="resultMin">The minimum output number (inclusive).</param>
        /// <param name="resultMax">The maximum output number (inclusive).</param>
        /// <returns>The number, scaled linearly between min and max.</returns>
        [Pure]
        public static int ScaleValue
        (
            int value,
            int valueMin,
            int valueMax,
            int resultMin,
            int resultMax
        )
        {
            if (valueMin >= valueMax || resultMin >= resultMax)
            {
                throw new ArgumentOutOfRangeException();
            }

            value = Math.Clamp(value, valueMin, valueMax);

            var range = resultMax - resultMin;
            long temp = (value - valueMin) * range; // need long to avoid overflow
            return (int)((temp / (valueMax - valueMin)) + resultMin);
        }

        /// <summary>
        /// Approximates floating point equality with a maximum number of different bits.
        /// This is typically used in place of an epsilon comparison.
        /// see: https://randomascii.wordpress.com/2012/02/25/comparing-floating-point-numbers-2012-edition/
        /// see: https://stackoverflow.com/questions/3874627/floating-point-comparison-functions-for-c-sharp.
        /// </summary>
        /// <param name="a">the first value to compare.</param>
        /// <param name="b">>the second value to compare.</param>
        /// <param name="maxDeltaBits">the number of floating point bits to check.</param>
        /// <returns>true if the values are approximately equal; otherwise, false.</returns>
        [Pure]
        public static bool ApproximatelyEqual(float a, float b, int maxDeltaBits)
        {
            // we use longs here, otherwise we run into a two's complement problem, causing this to fail with -2 and 2.0
            long k = FloatToInt32Bits(a);
            if (k < 0)
            {
                k = int.MinValue - k;
            }

            long l = FloatToInt32Bits(b);
            if (l < 0)
            {
                l = int.MinValue - l;
            }

            var intDiff = Math.Abs(k - l);
            return intDiff <= 1 << maxDeltaBits;
        }

        /// <summary>
        /// Approximates double-precision floating point equality by an epsilon (maximum error) value.
        /// This method is designed as a "fits-all" solution and attempts to handle as many cases as possible.
        /// </summary>
        /// <param name="a">The first float.</param>
        /// <param name="b">The second float.</param>
        /// <param name="epsilon">The maximum error between the two.</param>
        /// <returns>
        ///  <value>true</value> if the values are approximately equal within the error margin; otherwise,
        /// <value>false</value>.
        /// </returns>
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator", Justification = "Used for early bailout.")]
        [Pure]
        public static bool ApproximatelyEqualEpsilon(double a, double b, double epsilon)
        {
            const double doubleNormal = (1L << 52) * double.Epsilon;
            var absA = Math.Abs(a);
            var absB = Math.Abs(b);
            var diff = Math.Abs(a - b);

            if (a == b)
            {
                // Shortcut, handles infinities
                return true;
            }

            if (a == 0.0f || b == 0.0f || diff < doubleNormal)
            {
                // a or b is zero, or both are extremely close to it.
                // relative error is less meaningful here
                return diff < epsilon * doubleNormal;
            }

            // use relative error
            return diff / Math.Min(absA + absB, double.MaxValue) < epsilon;
        }

        /// <summary>
        /// Approximates single-precision floating point equality by an epsilon (maximum error) value.
        /// This method is designed as a "fits-all" solution and attempts to handle as many cases as possible.
        /// </summary>
        /// <param name="a">The first float.</param>
        /// <param name="b">The second float.</param>
        /// <param name="epsilon">The maximum error between the two.</param>
        /// <returns>
        ///  <value>true</value> if the values are approximately equal within the error margin; otherwise,
        ///  <value>false</value>.
        /// </returns>
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator", Justification = "Used for early bailout.")]
        [Pure]
        public static bool ApproximatelyEqualEpsilon(float a, float b, float epsilon)
        {
            const float floatNormal = (1 << 23) * float.Epsilon;
            var absA = Math.Abs(a);
            var absB = Math.Abs(b);
            var diff = Math.Abs(a - b);

            if (a == b)
            {
                // Shortcut, handles infinities
                return true;
            }

            if (a == 0.0f || b == 0.0f || diff < floatNormal)
            {
                // a or b is zero, or both are extremely close to it.
                // relative error is less meaningful here
                return diff < epsilon * floatNormal;
            }

            // use relative error
            var relativeError = diff / Math.Min(absA + absB, float.MaxValue);
            return relativeError < epsilon;
        }

        /// <summary>
        /// Approximates equivalence between two single-precision floating-point numbers on a direct human scale.
        /// It is important to note that this does not approximate equality - instead, it merely checks whether or not
        /// two numbers could be considered equivalent to each other within a certain tolerance. The tolerance is
        /// inclusive.
        /// </summary>
        /// <param name="a">The first value to compare.</param>
        /// <param name="b">The second value to compare.</param>
        /// <param name="tolerance">The tolerance within which the two values would be considered equivalent.</param>
        /// <returns>Whether or not the values can be considered equivalent within the tolerance.</returns>
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator", Justification = "Used for early bailout.")]
        [Pure]
        public static bool ApproximatelyEquivalent(float a, float b, float tolerance)
        {
            if (a == b)
            {
                // Early bailout, handles infinities
                return true;
            }

            var diff = Math.Abs(a - b);
            return diff <= tolerance;
        }

        /// <summary>
        /// Approximates equivalence between two double-precision floating-point numbers on a direct human scale.
        /// It is important to note that this does not approximate equality - instead, it merely checks whether or not
        /// two numbers could be considered equivalent to each other within a certain tolerance. The tolerance is
        /// inclusive.
        /// </summary>
        /// <param name="a">The first value to compare.</param>
        /// <param name="b">The second value to compare.</param>
        /// <param name="tolerance">The tolerance within which the two values would be considered equivalent.</param>
        /// <returns>Whether or not the values can be considered equivalent within the tolerance.</returns>
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator", Justification = "Used for early bailout.")]
        [Pure]
        public static bool ApproximatelyEquivalent(double a, double b, double tolerance)
        {
            if (a == b)
            {
                // Early bailout, handles infinities
                return true;
            }

            var diff = Math.Abs(a - b);
            return diff <= tolerance;
        }

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="start">Start value.</param>
        /// <param name="end">End value.</param>
        /// <param name="t">Value of the interpollation between a and b.</param>
        /// <returns>The interpolated result between the a and b values.</returns>
        [Pure]
        public static float Lerp(float start, float end, float t)
        {
            t = Math.Clamp(t, 0, 1);
            return start + (t * (end - start));
        }

        /// <summary>
        /// Normalizes an angle to the range (-180, 180].
        /// </summary>
        /// <param name="angle">The angle in degrees to normalize.</param>
        /// <returns>The normalized angle in the range (-180, 180].</returns>
        public static float NormalizeAngle(float angle)
        {
            // returns angle in the range [0, 360)
            angle = ClampAngle(angle);

            if (angle > 180f)
            {
                // shift angle to range (-180, 180]
                angle -= 360f;
            }

            return angle;
        }

        /// <summary>
        /// Normalizes an angle to the range (-180, 180].
        /// </summary>
        /// <param name="angle">The angle in degrees to normalize.</param>
        /// <returns>The normalized angle in the range (-180, 180].</returns>
        public static double NormalizeAngle(double angle)
        {
            // returns angle in the range [0, 360)
            angle = ClampAngle(angle);

            if (angle > 180f)
            {
                // shift angle to range (-180, 180]
                angle -= 360f;
            }

            return angle;
        }

        /// <summary>
        /// Normalizes an angle to the range (-π, π].
        /// </summary>
        /// <param name="angle">The angle in radians to normalize.</param>
        /// <returns>The normalized angle in the range (-π, π].</returns>
        public static float NormalizeRadians(float angle)
        {
            // returns angle in the range [0, 2π).
            angle = ClampRadians(angle);

            if (angle > PiOver2)
            {
                // shift angle to range (-π, π]
                angle -= 2 * MathF.PI;
            }

            return angle;
        }

        /// <summary>
        /// Normalizes an angle to the range (-π, π].
        /// </summary>
        /// <param name="angle">The angle in radians to normalize.</param>
        /// <returns>The normalized angle in the range (-π, π].</returns>
        public static double NormalizeRadians(double angle)
        {
            // returns angle in the range [0, 2π).
            angle = ClampRadians(angle);

            if (angle > PiOver2)
            {
                // shift angle to range (-π, π]
                angle -= 2 * MathF.PI;
            }

            return angle;
        }

        /// <summary>
        /// Clamps an angle to the range [0, 360).
        /// </summary>
        /// <param name="angle">The angle to clamp in degrees.</param>
        /// <returns>The clamped angle in the range [0, 360).</returns>
        public static float ClampAngle(float angle)
        {
            // mod angle so it's in the range (-360, 360)
            angle %= 360f;

            // abs angle so it's in the range [0, 360)
            angle = MathF.Abs(angle);

            return angle;
        }

        /// <summary>
        /// Clamps an angle to the range [0, 360).
        /// </summary>
        /// <param name="angle">The angle to clamp in degrees.</param>
        /// <returns>The clamped angle in the range [0, 360).</returns>
        public static double ClampAngle(double angle)
        {
            // mod angle so it's in the range (-360, 360)
            angle %= 360f;

            // abs angle so it's in the range [0, 360)
            angle = Math.Abs(angle);

            return angle;
        }

        /// <summary>
        /// Clamps an angle to the range [0, 2π).
        /// </summary>
        /// <param name="angle">The angle to clamp in radians.</param>
        /// <returns>The clamped angle in the range [0, 2π).</returns>
        public static float ClampRadians(float angle)
        {
            // mod angle so it's in the range (-2π,2π)
            angle %= 2 * MathF.PI;

            // abs angle so it's in the range [0,2π)
            angle = Math.Abs(angle);

            return angle;
        }

        /// <summary>
        /// Clamps an angle to the range [0, 2π).
        /// </summary>
        /// <param name="angle">The angle to clamp in radians.</param>
        /// <returns>The clamped angle in the range [0, 2π).</returns>
        public static double ClampRadians(double angle)
        {
            // mod angle so it's in the range (-2π,2π)
            angle %= 2 * MathF.PI;

            // abs angle so it's in the range [0,2π)
            angle = Math.Abs(angle);

            return angle;
        }
    }
}
