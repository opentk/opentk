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
        /// Returns the absolute value of a decimal number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A decimal number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static decimal Abs(decimal n) => Math.Abs(n);

        /// <summary>
        /// Returns the absolute value of a double number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A double number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static double Abs(double n) => Math.Abs(n);

        /// <summary>
        /// Returns the absolute value of a short number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A short number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static short Abs(short n) => Math.Abs(n);

        /// <summary>
        /// Returns the absolute value of a int number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A int number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static int Abs(int n) => Math.Abs(n);

        /// <summary>
        /// Returns the absolute value of a long number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A long number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static long Abs(long n) => Math.Abs(n);

        /// <summary>
        /// Returns the absolute value of a sbyte number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A sbyte number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static sbyte Abs(sbyte n) => Math.Abs(n);

        /// <summary>
        /// Returns the absolute value of a float number.
        /// </summary>
        /// <param name="n">A number that is greater than or equal to MinValue, but less than or equal to MaxValue.</param>
        /// <returns>A float number, x, such that 0 ≤ x ≤ MaxValue.</returns>
        [Pure]
        public static float Abs(float n) => Math.Abs(n);

        /// <summary>
        /// Returns the sine of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Sine of the angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Sin(double radians) => Math.Sin(radians);

        /// <summary>
        /// Returns the hyperbolic sine of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Hyperbolic sine of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Sinh(double radians) => Math.Sinh(radians);

        /// <summary>
        /// Returns the arc sine of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Arc sine of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Asin(double radians) => Math.Asin(radians);

        /// <summary>
        /// Returns the cosine of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Cosine of the angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Cos(double radians) => Math.Cos(radians);

        /// <summary>
        /// Returns the hyperbolic cosine of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Hyperbolic cosine of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Cosh(double radians) => Math.Cosh(radians);

        /// <summary>
        /// Returns the arc sine of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Arc sine of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Acos(double radians) => Math.Acos(radians);

        /// <summary>
        /// Returns the tangent of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Tangent of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Tan(double radians) => Math.Tan(radians);

        /// <summary>
        /// Returns the hyperbolic tangent of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Hyperbolic tangent of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Tanh(double radians) => Math.Tanh(radians);

        /// <summary>
        /// Returns the arc tangent of the specified angle.
        /// </summary>
        /// <param name="radians">The specified angle.</param>
        /// <returns>Arc tangent of the specified angle. If radians is equal to NaN, NegativeInfinity, or PositiveInfinity, this method returns NaN.</returns>
        [Pure]
        public static double Atan(double radians) => Math.Atan(radians);

        /// <summary>
        /// Returns the angle whose tangent is the quotient of two specified numbers.
        /// </summary>
        /// <param name="y">The y coordinate of a point.</param>
        /// <param name="x">The x coordinate of a point.</param>
        /// <returns>An angle, θ, measured in radians, such that -π ≤ θ ≤ π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane.</returns>
        [Pure]
        public static double Atan2(double y, double x) => Math.Atan2(y, x);

        /// <summary>
        /// Produces the full product of two 32-bit numbers.
        /// </summary>
        /// <param name="a">The first number to multiply.</param>
        /// <param name="b">The second number to multiply.</param>
        /// <returns>The number containing the product of the specified numbers.</returns>
        [Pure]
        public static long BigMul(int a, int b) => Math.BigMul(a, b);

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="n">The number whose square root is to be found.</param>
        /// <returns>The positive square root of n.</returns>
        [Pure]
        public static double Sqrt(double n) => Math.Sqrt(n);

        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="x">A double-precision floating-point number to be raised to a power.</param>
        /// <param name="y">A double-precision floating-point number that specifies a power.</param>
        /// <returns>The number x raised to the power y.</returns>
        [Pure]
        public static double Pow(double x, double y) => Math.Pow(x, y);

        /// <summary>
        /// Returns the smallest integral value greater than or equal to the specified number.
        /// </summary>
        /// <param name="n">A decimal number.</param>
        /// <returns>The smallest integral value that is greater than or equal to n. Note that this method returns a Decimal instead of an integral type.</returns>
        [Pure]
        public static decimal Ceiling(decimal n) => Math.Ceiling(n);

        /// <summary>
        /// Returns the smallest integral value greater than or equal to the specified number.
        /// </summary>
        /// <param name="n">A double-precision floating-point number.</param>
        /// <returns>The smallest integral value that is greater than or equal to n. If n is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned.
        /// Note that this method returns a Double instead of an integral type.</returns>
        [Pure]
        public static double Ceiling(double n) => Math.Ceiling(n);

        /// <summary>
        /// Returns the largest integral value less than or equal to the specified number.
        /// </summary>
        /// <param name="n">A decimal number.</param>
        /// <returns>Returns the largest integral value less than or equal to the specified decimal number.</returns>
        [Pure]
        public static decimal Floor(decimal n) => Math.Floor(n);

        /// <summary>
        /// Returns the largest integral value less than or equal to the specified number.
        /// </summary>
        /// <param name="n">A double-precision floating-point number.</param>
        /// <returns>Returns the largest integral value less than or equal to the specified double-precision floating-point number.</returns>
        [Pure]
        public static double Floor(double n) => Math.Floor(n);

        /// <summary>
        /// Calculates the quotient of two integers and also returns the remainder in an output parameter.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <param name="result">The remainder.</param>
        /// <returns>The quotient of the specified numbers.</returns>
        /// <exception cref="DivideByZeroException">b is zero.</exception>
        [Pure]
        public static int DivRem(int a, int b, out int result) => Math.DivRem(a, b, out result);

        /// <summary>
        /// Calculates the quotient of two longs and also returns the remainder in an output parameter.
        /// </summary>
        /// <param name="a">The dividend.</param>
        /// <param name="b">The divisor.</param>
        /// <param name="result">The remainder.</param>
        /// <returns>The quotient of the specified numbers.</returns>
        /// <exception cref="DivideByZeroException">b is zero.</exception>
        [Pure]
        public static long DivRem(long a, long b, out long result) => Math.DivRem(a, b, out result);

        /// <summary>
        /// Returns the natural (base e) logarithm of a specified number.
        /// </summary>
        /// <param name="n">A number whose logarithm is to be found.</param>
        /// <returns>The natural logarithm of n.</returns>
        [Pure]
        public static double Log(double n) => Math.Log(n);

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <param name="newBase">The specified base.</param>
        /// <returns>The base newBase logarithm of n.</returns>
        [Pure]
        public static double Log(double n, double newBase) => Math.Log(n, newBase);

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The base 10 log of n.</returns>
        [Pure]
        public static double Log10(double n) => Math.Log10(n);

        /// <summary>
        /// Returns the base 2 logarithm of a specified number.
        /// </summary>
        /// <param name="n">The specified number.</param>
        /// <returns>The base 2 log of n.</returns>
        /// <remarks>This one will be implemented by System.Math from .netcore 3.0 and onwards.</remarks>
        [Pure]
        public static double Log2(double n) => Math.Log(n, 2);

        /// <summary>
        /// Returns e raised to the specified power.
        /// </summary>
        /// <param name="n">The specified power.</param>
        /// <returns>The number e raised to the power n. If n equals NaN or PositiveInfinity, that value is returned. If n equals NegativeInfinity, 0 is returned.</returns>
        [Pure]
        public static double Exp(double n) => Math.Exp(n);

        /// <summary>
        /// Returns the remainder resulting from the division of a specified number by another specified number.
        /// </summary>
        /// <param name="a">A dividend.</param>
        /// <param name="b">A divisor.</param>
        /// <returns>A number equal to a - (b Q), where Q is the quotient of a / b rounded to the nearest integer (if a / b falls halfway between two integers, the even integer is returned).
        /// If a - (b Q) is zero, the value +0 is returned if a is positive, or -0 if a is negative.
        /// If b = 0, NaN is returned.</returns>
        [Pure]
        public static double IEEERemainder(double a, double b) => Math.IEEERemainder(a, b);

        /// <summary>
        /// Returns the larger of two bytes.
        /// </summary>
        /// <param name="a">The first of two bytes to compare.</param>
        /// <param name="b">The second of two bytes to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static byte Max(byte a, byte b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two sbytes.
        /// </summary>
        /// <param name="a">The first of two sbytes to compare.</param>
        /// <param name="b">The second of two sbytes to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static sbyte Max(sbyte a, sbyte b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two shorts.
        /// </summary>
        /// <param name="a">The first of two shorts to compare.</param>
        /// <param name="b">The second of two shorts to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static short Max(short a, short b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two ushorts.
        /// </summary>
        /// <param name="a">The first of two ushorts to compare.</param>
        /// <param name="b">The second of two ushorts to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static ushort Max(ushort a, ushort b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two decimals.
        /// </summary>
        /// <param name="a">The first of two decimals to compare.</param>
        /// <param name="b">The second of two decimals to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static decimal Max(decimal a, decimal b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two ints.
        /// </summary>
        /// <param name="a">The first of two ints to compare.</param>
        /// <param name="b">The second of two ints to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static int Max(int a, int b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two uints.
        /// </summary>
        /// <param name="a">The first of two uints to compare.</param>
        /// <param name="b">The second of two uints to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static uint Max(uint a, uint b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two floats.
        /// </summary>
        /// <param name="a">The first of two floats to compare.</param>
        /// <param name="b">The second of two floats to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static float Max(float a, float b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two longs.
        /// </summary>
        /// <param name="a">The first of two longs to compare.</param>
        /// <param name="b">The second of two longs to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static long Max(long a, long b) => Math.Max(a, b);

        /// <summary>
        /// Returns the larger of two ulongs.
        /// </summary>
        /// <param name="a">The first of two ulongs to compare.</param>
        /// <param name="b">The second of two ulongs to compare.</param>
        /// <returns>Parameter a or b, whichever is larger.</returns>
        [Pure]
        public static ulong Max(ulong a, ulong b) => Math.Max(a, b);

        /// <summary>
        /// Returns the smaller of two bytes.
        /// </summary>
        /// <param name="a">The first of two bytes to compare.</param>
        /// <param name="b">The second of two bytes to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static byte Min(byte a, byte b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two sbytes.
        /// </summary>
        /// <param name="a">The first of two sbytes to compare.</param>
        /// <param name="b">The second of two sbytes to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static sbyte Min(sbyte a, sbyte b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two shorts.
        /// </summary>
        /// <param name="a">The first of two shorts to compare.</param>
        /// <param name="b">The second of two shorts to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static short Min(short a, short b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two ushorts.
        /// </summary>
        /// <param name="a">The first of two ushorts to compare.</param>
        /// <param name="b">The second of two ushorts to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static ushort Min(ushort a, ushort b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two decimals.
        /// </summary>
        /// <param name="a">The first of two decimals to compare.</param>
        /// <param name="b">The second of two decimals to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static decimal Min(decimal a, decimal b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two ints.
        /// </summary>
        /// <param name="a">The first of two ints to compare.</param>
        /// <param name="b">The second of two ints to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static int Min(int a, int b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two uints.
        /// </summary>
        /// <param name="a">The first of two uints to compare.</param>
        /// <param name="b">The second of two uints to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static uint Min(uint a, uint b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two floats.
        /// </summary>
        /// <param name="a">The first of two floats to compare.</param>
        /// <param name="b">The second of two floats to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static float Min(float a, float b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two floats.
        /// </summary>
        /// <param name="a">The first of two floats to compare.</param>
        /// <param name="b">The second of two floats to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static double Min(double a, double b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two longs.
        /// </summary>
        /// <param name="a">The first of two longs to compare.</param>
        /// <param name="b">The second of two longs to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static long Min(long a, long b) => Math.Min(a, b);

        /// <summary>
        /// Returns the smaller of two ulongs.
        /// </summary>
        /// <param name="a">The first of two ulongs to compare.</param>
        /// <param name="b">The second of two ulongs to compare.</param>
        /// <returns>Parameter a or b, whichever is smaller.</returns>
        [Pure]
        public static ulong Min(ulong a, ulong b) => Math.Min(a, b);

        /// <summary>
        /// Rounds a decimal value to a specified number of fractional digits, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="digits">The number of decimal places in the return value.</param>
        /// <param name="mode">Specification for how to round d if it is midway between two other numbers.</param>
        /// <returns>The number nearest to d that contains a number of fractional digits equal to digits. If d has fewer fractional digits than digits, d is returned unchanged.</returns>
        /// <exception cref="ArgumentOutOfRangeException">digits is less than 0 or greater than 28.</exception>
        /// <exception cref="ArgumentException">mode is not a valid value of MidpointRounding.</exception>
        /// <exception cref="OverflowException">The result is outside the range of a Decimal.</exception>
        [Pure]
        public static decimal Round(decimal d, int digits, MidpointRounding mode) => Math.Round(d, digits, mode);

        /// <summary>
        /// Rounds a double-precision floating-point value to a specified number of fractional digits, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="d">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <param name="mode">Specification for how to round d if it is midway between two other numbers.</param>
        /// <returns>The number nearest to d that has a number of fractional digits equal to digits. If d has fewer fractional digits than digits, d is returned unchanged.</returns>
        /// <exception cref="ArgumentOutOfRangeException">digits is less than 0 or greater than 15.</exception>
        /// <exception cref="ArgumentException">mode is not a valid value of MidpointRounding.</exception>
        [Pure]
        public static double Round(double d, int digits, MidpointRounding mode) => Math.Round(d, digits, mode);

        /// <summary>
        /// Rounds a decimal value to the nearest integer, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="mode">Specification for how to round d if it is midway between two other numbers.</param>
        /// <returns>The integer nearest d. If d is halfway between two numbers, one of which is even and the other odd, then mode determines which of the two is returned.
        /// Note that this method returns a Decimal instead of an integral type.</returns>
        /// <exception cref="ArgumentException">mode is not a valid value of MidpointRounding.</exception>
        /// <exception cref="OverflowException">The result is outside the range of a Decimal.</exception>
        [Pure]
        public static decimal Round(decimal d, MidpointRounding mode) => Math.Round(d, mode);

        /// <summary>
        /// Rounds a double-precision floating-point value to the nearest integer, and uses the specified rounding convention for midpoint values.
        /// </summary>
        /// <param name="d">A double-precision floating-point number to be rounded.</param>
        /// <param name="mode">Specification for how to round d if it is midway between two other numbers.</param>
        /// <returns>The integer nearest d. If d is halfway between two integers, one of which is even and the other odd, then mode determines which of the two is returned.
        /// Note that this method returns a Double instead of an integral type.</returns>
        /// <exception cref="ArgumentException">mode is not a valid value of MidpointRounding.</exception>
        [Pure]
        public static double Round(double d, MidpointRounding mode) => Math.Round(d, mode);

        /// <summary>
        /// Rounds a decimal value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <returns>The number nearest to d that contains a number of fractional digits equal to digits.</returns>
        /// <exception cref="ArgumentOutOfRangeException"> digits is less than 0 or greater than 15.</exception>
        /// <exception cref="OverflowException">The result is outside the range of a Decimal.</exception>
        [Pure]
        public static decimal Round(decimal d, int digits) => Math.Round(d, digits);

        /// <summary>
        /// Rounds a double-precision floating-point value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="d">A double-precision floating-point number to be rounded.</param>
        /// <param name="digits">The number of fractional digits in the return value.</param>
        /// <returns>The number nearest to value that contains a number of fractional digits equal to digits.</returns>
        /// <exception cref="ArgumentOutOfRangeException"> digits is less than 0 or greater than 15.</exception>
        [Pure]
        public static double Round(double d, int digits) => Math.Round(d, digits);

        /// <summary>
        /// Rounds a decimal value to the nearest integral value, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <returns>The integer nearest the d parameter. If the fractional component of d is halfway between two integers, one of which is even and the other odd, the even number is returned.
        /// Note that this method returns a Decimal instead of an integral type.</returns>
        /// <exception cref="OverflowException">The result is outside the range of a Decimal.</exception>
        [Pure]
        public static decimal Round(decimal d) => Math.Round(d);

        /// <summary>
        /// Rounds a double-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number.
        /// </summary>
        /// <param name="d">A double-precision floating-point number to be rounded.</param>
        /// <returns>The integer nearest d. If the fractional component of d is halfway between two integers, one of which is even and the other odd, then the even number is returned.
        /// Note that this method returns a Double instead of an integral type.</returns>
        [Pure]
        public static double Round(double d) => Math.Round(d);

        /// <summary>
        /// Calculates the integral part of a specified decimal number.
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>The integral part of d; that is, the number that remains after any fractional digits have been discarded.</returns>
        [Pure]
        public static decimal Truncate(decimal d) => Math.Truncate(d);

        /// <summary>
        /// Calculates the integral part of a specified double-precision floating-point number.
        /// </summary>
        /// <param name="d">A number to truncate.</param>
        /// <returns>The integral part of d; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table.</returns>
        [Pure]
        public static double Truncate(double d) => Math.Truncate(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a sbyte.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(sbyte d) => Math.Sign(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a short.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(short d) => Math.Sign(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a int.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(int d) => Math.Sign(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a float.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(float d) => Math.Sign(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a decimal.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(decimal d) => Math.Sign(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a double.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(double d) => Math.Sign(d);

        /// <summary>
        /// Returns an integer that indicates the sign of a long.
        /// </summary>
        /// <param name="d">A signed number.</param>
        /// <returns>If d ≤ -1 returns -1, if 1 ≤ d returns 1 and if d = 0 returns 0.</returns>
        [Pure]
        public static int Sign(long d) => Math.Sign(d);

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
        /// Swaps two double values.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        public static void Swap(ref double a, ref double b)
        {
            var temp = a;
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
            var temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Clamps a number between a minimum and a maximum.
        /// </summary>
        /// <param name="n">The number to clamp.</param>
        /// <param name="min">The minimum allowed value.</param>
        /// <param name="max">The maximum allowed value.</param>
        /// <returns>min, if n is lower than min; max, if n is higher than max; n otherwise.</returns>
        [Pure]
        public static int Clamp(int n, int min, int max)
        {
            return Math.Max(Math.Min(n, max), min);
        }

        /// <summary>
        /// Clamps a number between a minimum and a maximum.
        /// </summary>
        /// <param name="n">The number to clamp.</param>
        /// <param name="min">The minimum allowed value.</param>
        /// <param name="max">The maximum allowed value.</param>
        /// <returns>min, if n is lower than min; max, if n is higher than max; n otherwise.</returns>
        [Pure]
        public static float Clamp(float n, float min, float max)
        {
            return Math.Max(Math.Min(n, max), min);
        }

        /// <summary>
        /// Clamps a number between a minimum and a maximum.
        /// </summary>
        /// <param name="n">The number to clamp.</param>
        /// <param name="min">The minimum allowed value.</param>
        /// <param name="max">The maximum allowed value.</param>
        /// <returns>min, if n is lower than min; max, if n is higher than max; n otherwise.</returns>
        [Pure]
        public static double Clamp(double n, double min, double max)
        {
            return Math.Max(Math.Min(n, max), min);
        }

        [Pure]
        private static unsafe int FloatToInt32Bits(float f)
        {
            return *((int*)&f);
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

            value = Clamp(value, valueMin, valueMax);

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
            t = Clamp(t, 0, 1);
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

            if (angle > PiOver2)
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

            // abs angle so it's in the range [0, 360)
            angle = Abs(angle);

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
            angle = Abs(angle);

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
            angle %= 2 * Pi;

            // abs angle so it's in the range [0,2π)
            angle = Abs(angle);

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
            angle %= 2 * Pi;

            // abs angle so it's in the range [0,2π)
            angle = Abs(angle);

            return angle;
        }

        internal static readonly string ListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
    }
}
