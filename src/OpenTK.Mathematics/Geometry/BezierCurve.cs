/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 *
 * Contributions by Georg W�chter.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a bezier curve with as many points as you want.
    /// </summary>
    [Serializable]
    public struct BezierCurve
    {
        private readonly List<Vector2> _points;

        /// <summary>
        /// The parallel value.
        /// </summary>
        /// <remarks>
        /// This value defines whether the curve should be calculated as a
        /// parallel curve to the original bezier curve. A value of 0.0f represents
        /// the original curve, 5.0f i.e. stands for a curve that has always a distance
        /// of 5.0f to the orignal curve at any point.
        /// </remarks>
        public float Parallel;

        /// <summary>
        /// Gets the points of this curve.
        /// </summary>
        /// <remarks>The first point and the last points represent the anchor points.</remarks>
        public IList<Vector2> Points => _points;

        /// <summary>
        /// Initializes a new instance of the <see cref="BezierCurve"/> struct.
        /// </summary>
        /// <param name="points">The points.</param>
        public BezierCurve(IEnumerable<Vector2> points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(points), "Must point to a valid list of Vector2 structures.");
            }

            this._points = new List<Vector2>(points);
            Parallel = 0.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BezierCurve"/> struct.
        /// </summary>
        /// <param name="points">The points.</param>
        public BezierCurve(params Vector2[] points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(points), "Must point to a valid list of Vector2 structures.");
            }

            this._points = new List<Vector2>(points);
            Parallel = 0.0f;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BezierCurve"/> struct.
        /// </summary>
        /// <param name="parallel">The parallel value.</param>
        /// <param name="points">The points.</param>
        public BezierCurve(float parallel, params Vector2[] points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(points), "Must point to a valid list of Vector2 structures.");
            }

            Parallel = parallel;
            this._points = new List<Vector2>(points);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BezierCurve"/> struct.
        /// </summary>
        /// <param name="parallel">The parallel value.</param>
        /// <param name="points">The points.</param>
        public BezierCurve(float parallel, IEnumerable<Vector2> points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(points), "Must point to a valid list of Vector2 structures.");
            }

            Parallel = parallel;
            this._points = new List<Vector2>(points);
        }

        /// <summary>
        /// Calculates the point with the specified t.
        /// </summary>
        /// <param name="t">The t value, between 0.0f and 1.0f.</param>
        /// <returns>Resulting point.</returns>
        [Pure]
        public Vector2 CalculatePoint(float t)
        {
            return CalculatePoint(_points, t, Parallel);
        }

        /// <summary>
        /// Calculates the length of this bezier curve.
        /// </summary>
        /// <param name="precision">The precision.</param>
        /// <returns>Length of curve.</returns>
        /// <remarks>
        /// The precision gets better as the <paramref name="precision"/>
        /// value gets smaller.
        /// </remarks>
        [Pure]
        public float CalculateLength(float precision)
        {
            return CalculateLength(_points, precision, Parallel);
        }

        /// <summary>
        /// Calculates the length of the specified bezier curve.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <param name="precision">The precision value.</param>
        /// <returns>
        /// The precision gets better as the <paramref name="precision"/>
        /// value gets smaller.
        /// </returns>
        [Pure]
        public static float CalculateLength(IList<Vector2> points, float precision)
        {
            return CalculateLength(points, precision, 0.0f);
        }

        /// <summary>
        /// Calculates the length of the specified bezier curve.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <param name="precision">The precision value.</param>
        /// <param name="parallel">The parallel value.</param>
        /// <returns>Length of curve.</returns>
        /// <remarks>
        ///  <para>
        /// The precision gets better as the <paramref name="precision"/>
        /// value gets smaller.
        ///  </para>
        ///  <para>
        /// The <paramref name="parallel"/> parameter defines whether the curve should be calculated as a
        /// parallel curve to the original bezier curve. A value of 0.0f represents
        /// the original curve, 5.0f represents a curve that has always a distance
        /// of 5.0f to the orignal curve.
        ///  </para>
        /// </remarks>
        [Pure]
        public static float CalculateLength(IList<Vector2> points, float precision, float parallel)
        {
            var length = 0.0f;
            var old = CalculatePoint(points, 0.0f, parallel);

            for (var i = precision; i < 1.0f + precision; i += precision)
            {
                var n = CalculatePoint(points, i, parallel);
                length += (n - old).Length;
                old = n;
            }

            return length;
        }

        /// <summary>
        /// Calculates the point on the given bezier curve with the specified t parameter.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <param name="t">The t parameter, a value between 0.0f and 1.0f.</param>
        /// <returns>Resulting point.</returns>
        [Pure]
        public static Vector2 CalculatePoint(IList<Vector2> points, float t)
        {
            return CalculatePoint(points, t, 0.0f);
        }

        /// <summary>
        /// Calculates the point on the given bezier curve with the specified t parameter.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <param name="t">The t parameter, a value between 0.0f and 1.0f.</param>
        /// <param name="parallel">The parallel value.</param>
        /// <returns>Resulting point.</returns>
        /// <remarks>
        /// The <paramref name="parallel"/> parameter defines whether the curve should be calculated as a
        /// parallel curve to the original bezier curve. A value of 0.0f represents
        /// the original curve, 5.0f represents a curve that has always a distance
        /// of 5.0f to the orignal curve.
        /// </remarks>
        [Pure]
        public static Vector2 CalculatePoint(IList<Vector2> points, float t, float parallel)
        {
            var r = default(Vector2);
            var c = 1.0d - t;
            float temp;
            var i = 0;

            foreach (var pt in points)
            {
                temp = MathHelper.BinomialCoefficient
                (
                    points.Count - 1, i) * (float)(Math.Pow(t, i) * Math.Pow(c, points.Count - 1 - i)
                );

                r.X += temp * pt.X;
                r.Y += temp * pt.Y;
                i++;
            }

            if (parallel == 0.0f)
            {
                return r;
            }

            Vector2 perpendicular;

            if (t != 0.0f)
            {
                perpendicular = r - CalculatePointOfDerivative(points, t);
            }
            else
            {
                perpendicular = points[1] - points[0];
            }

            return r + (Vector2.Normalize(perpendicular).PerpendicularRight * parallel);
        }

        /// <summary>
        /// Calculates the point with the specified t of the derivative of the given bezier function.
        /// </summary>
        /// <param name="points">The points.</param>
        /// <param name="t">The t parameter, value between 0.0f and 1.0f.</param>
        /// <returns>Resulting point.</returns>
        [Pure]
        private static Vector2 CalculatePointOfDerivative(IList<Vector2> points, float t)
        {
            var r = default(Vector2);
            var c = 1.0d - t;
            float temp;
            var i = 0;

            foreach (var pt in points)
            {
                temp = MathHelper.BinomialCoefficient
                (
                    points.Count - 2, i) * (float)(Math.Pow(t, i) * Math.Pow(c, points.Count - 2 - i)
                );

                r.X += temp * pt.X;
                r.Y += temp * pt.Y;
                i++;
            }

            return r;
        }
    }
}
