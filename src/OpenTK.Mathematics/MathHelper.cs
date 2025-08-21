/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 *
 * Contributions by Andy Gill, James Talton and Georg Wächter.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Contains common mathematical functions and constants.
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Defines the value of Pi as a <see cref="float"/>.
        /// </summary>
        public const float Pi = 3.1415927f;

        /// <summary>
        /// Defines the value of Pi divided by two as a <see cref="float"/>.
        /// </summary>
        public const float PiOver2 = Pi / 2;

        /// <summary>
        /// Defines the value of Pi divided by three as a <see cref="float"/>.
        /// </summary>
        public const float PiOver3 = Pi / 3;

        /// <summary>
        /// Defines the value of  Pi divided by four as a <see cref="float"/>.
        /// </summary>
        public const float PiOver4 = Pi / 4;

        /// <summary>
        /// Defines the value of Pi divided by six as a <see cref="float"/>.
        /// </summary>
        public const float PiOver6 = Pi / 6;

        /// <summary>
        /// Defines the value of Pi multiplied by two as a <see cref="float"/>.
        /// </summary>
        public const float TwoPi = 2 * Pi;

        /// <summary>
        /// Defines the value of Pi multiplied by 3 and divided by two as a <see cref="float"/>.
        /// </summary>
        public const float ThreePiOver2 = 3 * Pi / 2;

        /// <summary>
        /// Defines the value of E as a <see cref="float"/>.
        /// </summary>
        public const float E = 2.7182817f;

        /// <summary>
        /// Defines the base-10 logarithm of E.
        /// </summary>
        public const float Log10E = 0.4342945f;

        /// <summary>
        /// Defines the base-2 logarithm of E.
        /// </summary>
        public const float Log2E = 1.442695f;

        /// <summary>
        /// Defines the constant that you should multiply by to convert Radians to Degrees.
        /// </summary>
        public const float RadToDeg = 180.0f / MathF.PI;

        /// <summary>
        /// Defines the constant that you should multiply by to convert Degrees to Radians.
        /// </summary>
        public const float DegToRad = MathF.PI / 180.0f;

        /// <summary>
        /// Defines the constant that you should multiply by to convert Radians to Degrees.
        /// </summary>
        public const double RadToDegd = 180.0d / Math.PI;

        /// <summary>
        /// Defines the constant that you should multiply by to convert Degrees to Radians.
        /// </summary>
        public const double DegToRadd = Math.PI / 180.0d;

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
        /// Convert degrees to radians.
        /// </summary>
        /// <param name="degrees">An angle in degrees.</param>
        /// <returns>The angle expressed in radians.</returns>
        [Pure]
        public static float DegreesToRadians(float degrees)
        {
            return degrees * DegToRad;
        }

        /// <summary>
        /// Convert radians to degrees.
        /// </summary>
        /// <param name="radians">An angle in radians.</param>
        /// <returns>The angle expressed in degrees.</returns>
        [Pure]
        public static float RadiansToDegrees(float radians)
        {
            return radians * RadToDeg;
        }

        /// <summary>
        /// Convert degrees to radians.
        /// </summary>
        /// <param name="degrees">An angle in degrees.</param>
        /// <returns>The angle expressed in radians.</returns>
        [Pure]
        public static double DegreesToRadians(double degrees)
        {
            return degrees * DegToRadd;
        }

        /// <summary>
        /// Convert radians to degrees.
        /// </summary>
        /// <param name="radians">An angle in radians.</param>
        /// <returns>The angle expressed in degrees.</returns>
        [Pure]
        public static double RadiansToDegrees(double radians)
        {
            return radians * RadToDegd;
        }

        /// <summary>
        /// Swaps two values.
        /// </summary>
        /// <typeparam name="T">The type of the values to swap.</typeparam>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        public static void Swap<T>(ref T a, ref T b) => (a, b) = (b, a);

        /// <summary>
        /// Scales the specified number linearly between a minimum and a maximum.
        /// </summary>
        /// <remarks>If the value range is zero, this function will throw a divide by zero exception.</remarks>
        /// <param name="value">The number to scale.</param>
        /// <param name="valueMin">The minimum expected number (inclusive).</param>
        /// <param name="valueMax">The maximum expected number (inclusive).</param>
        /// <param name="resultMin">The minimum output number (inclusive).</param>
        /// <param name="resultMax">The maximum output number (inclusive).</param>
        /// <returns>The number, scaled linearly between min and max.</returns>
        [Pure]
        public static int MapRange(int value, int valueMin, int valueMax, int resultMin, int resultMax)
        {
            int inRange = valueMax - valueMin;
            int resultRange = resultMax - resultMin;
            return resultMin + (resultRange * ((value - valueMin) / inRange));
        }

        /// <summary>
        /// Scales the specified number linearly between a minimum and a maximum.
        /// </summary>
        /// <remarks>If the value range is zero, this function will throw a divide by zero exception.</remarks>
        /// <param name="value">The number to scale.</param>
        /// <param name="valueMin">The minimum expected number (inclusive).</param>
        /// <param name="valueMax">The maximum expected number (inclusive).</param>
        /// <param name="resultMin">The minimum output number (inclusive).</param>
        /// <param name="resultMax">The maximum output number (inclusive).</param>
        /// <returns>The number, scaled linearly between min and max.</returns>
        [Pure]
        public static float MapRange(float value, float valueMin, float valueMax, float resultMin, float resultMax)
        {
            float inRange = valueMax - valueMin;
            float resultRange = resultMax - resultMin;
            return resultMin + (resultRange * ((value - valueMin) / inRange));
        }

        /// <summary>
        /// Scales the specified number linearly between a minimum and a maximum.
        /// </summary>
        /// <remarks>If the value range is zero, this function will throw a divide by zero exception.</remarks>
        /// <param name="value">The number to scale.</param>
        /// <param name="valueMin">The minimum expected number (inclusive).</param>
        /// <param name="valueMax">The maximum expected number (inclusive).</param>
        /// <param name="resultMin">The minimum output number (inclusive).</param>
        /// <param name="resultMax">The maximum output number (inclusive).</param>
        /// <returns>The number, scaled linearly between min and max.</returns>
        [Pure]
        public static double MapRange(double value, double valueMin, double valueMax, double resultMin, double resultMax)
        {
            double inRange = valueMax - valueMin;
            double resultRange = resultMax - resultMin;
            return resultMin + (resultRange * ((value - valueMin) / inRange));
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
            long k = BitConverter.SingleToInt32Bits(a);
            if (k < 0)
            {
                k = int.MinValue - k;
            }

            long l = BitConverter.SingleToInt32Bits(b);
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
        /// Linearly interpolates between <paramref name="start"/> and <paramref name="end"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="start">Start value.</param>
        /// <param name="end">End value.</param>
        /// <param name="t">Value of the interpolation between <paramref name="start"/> and <paramref name="end"/>. Not clamped.</param>
        /// <returns>The interpolated result between the <paramref name="start"/> and <paramref name="end"/> values.</returns>
        [Pure]
        public static float Lerp(float start, float end, float t)
        {
            return start + (t * (end - start));
        }

        /// <summary>
        /// Linearly interpolates between <paramref name="start"/> and <paramref name="end"/> by <paramref name="t"/>.
        /// </summary>
        /// <param name="start">Start value.</param>
        /// <param name="end">End value.</param>
        /// <param name="t">Value of the interpolation between <paramref name="start"/> and <paramref name="end"/>. Not clamped.</param>
        /// <returns>The interpolated result between the <paramref name="start"/> and <paramref name="end"/> values.</returns>
        [Pure]
        public static double Lerp(double start, double end, double t)
        {
            return start + (t * (end - start));
        }

        /// <summary>
        /// Exponentially interpolates between <paramref name="start"/> and <paramref name="end"/> by <paramref name="t"/>.
        /// Equivalent to <c>start * pow(end/start, t)</c>.
        /// Useful for scaling and zooms where constant change in <paramref name="t"/> should result in a multiplicative change in output.
        /// </summary>
        /// <param name="start">Start value. Must be non-negative.</param>
        /// <param name="end">End value. Must be non-negative.</param>
        /// <param name="t">Value of the interpolation between <paramref name="start"/> and <paramref name="end"/>. Not clamped.</param>
        /// <returns>The interpolated result between the <paramref name="start"/> and <paramref name="end"/> values.</returns>
        public static float Elerp(float start, float end, float t)
        {
            return start + MathF.Pow(end / start, t);
        }

        /// <summary>
        /// Exponentially interpolates between <paramref name="start"/> and <paramref name="end"/> by <paramref name="t"/>.
        /// Equivalent to <c>start * pow(end/start, t)</c>.
        /// Useful for scaling and zooms where constant change in <paramref name="t"/> should result in a multiplicative change in output.
        /// </summary>
        /// <param name="start">Start value. Must be non-negative.</param>
        /// <param name="end">End value. Must be non-negative.</param>
        /// <param name="t">Value of the interpolation between <paramref name="start"/> and <paramref name="end"/>. Not clamped.</param>
        /// <returns>The interpolated result between the <paramref name="start"/> and <paramref name="end"/> values.</returns>
        public static double Elerp(double start, double end, double t)
        {
            return start + Math.Pow(end / start, t);
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

            if (angle > Pi)
            {
                // shift angle to range (-π, π]
                angle -= 2 * Pi;
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

            if (angle > Pi)
            {
                // shift angle to range (-π, π]
                angle -= 2 * Pi;
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

            if (angle < 0.0f)
            {
                // shift angle to the range [0, 360)
                angle += 360f;
            }

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
            angle %= 360d;

            if (angle < 0.0d)
            {
                // shift angle to the range [0, 360)
                angle += 360d;
            }

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
            angle %= TwoPi;

            if (angle < 0.0f)
            {
                // shift angle to the range [0,2π)
                angle += TwoPi;
            }

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
            angle %= 2d * Math.PI;

            if (angle < 0.0d)
            {
                // shift angle to the range [0,2π)
                angle += 2d * Math.PI;
            }

            return angle;
        }

        internal static string GetListSeparator(IFormatProvider formatProvider)
        {
            if (formatProvider is CultureInfo cultureInfo)
            {
                return cultureInfo.TextInfo.ListSeparator;
            }

            if (formatProvider?.GetFormat(typeof(TextInfo)) is TextInfo textInfo)
            {
                return textInfo.ListSeparator;
            }

            return CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        }

        [DoesNotReturn]
        internal static void ThrowOutOfRangeException<T>(string message, T arg0)
        {
            throw new IndexOutOfRangeException(string.Format(message, arg0));
        }

        [DoesNotReturn]
        internal static void ThrowOutOfRangeException<T>(string message, T arg0, T arg1)
        {
            throw new IndexOutOfRangeException(string.Format(message, arg0, arg1));
        }
    }
}
