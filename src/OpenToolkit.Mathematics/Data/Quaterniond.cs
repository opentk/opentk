/*
Copyright (c) 2006 - 2008 The Open Toolkit library.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Represents a double-precision Quaternion.
    /// </summary>
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct Quaterniond : IEquatable<Quaterniond>
    {
        /// <summary>
        /// The X, Y and Z components of this instance.
        /// </summary>
        public Vector3d Xyz;

        /// <summary>
        /// The W component of this instance.
        /// </summary>
        public double W;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quaterniond"/> struct.
        /// </summary>
        /// <param name="v">The vector part.</param>
        /// <param name="w">The w part.</param>
        public Quaterniond(Vector3d v, double w)
        {
            Xyz = v;
            W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quaterniond"/> struct.
        /// </summary>
        /// <param name="x">The x component.</param>
        /// <param name="y">The y component.</param>
        /// <param name="z">The z component.</param>
        /// <param name="w">The w component.</param>
        public Quaterniond(double x, double y, double z, double w)
            : this(new Vector3d(x, y, z), w)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quaterniond"/> struct from given Euler angles in radians.
        /// </summary>
        /// <param name="pitch">The pitch (attitude), rotation around X axis.</param>
        /// <param name="yaw">The yaw (heading), rotation around Y axis.</param>
        /// <param name="roll">The roll (bank), rotation around Z axis.</param>
        public Quaterniond(double pitch, double yaw, double roll)
        {
            yaw *= 0.5;
            pitch *= 0.5;
            roll *= 0.5;

            var c1 = Math.Cos(yaw);
            var c2 = Math.Cos(pitch);
            var c3 = Math.Cos(roll);
            var s1 = Math.Sin(yaw);
            var s2 = Math.Sin(pitch);
            var s3 = Math.Sin(roll);

            W = (c1 * c2 * c3) - (s1 * s2 * s3);
            Xyz.X = (s1 * s2 * c3) + (c1 * c2 * s3);
            Xyz.Y = (s1 * c2 * c3) - (c1 * s2 * s3);
            Xyz.Z = (c1 * s2 * c3) + (s1 * c2 * s3);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quaterniond"/> struct from given Euler angles in radians.
        /// </summary>
        /// <param name="eulerAngles">The euler angles as a Vector3d.</param>
        public Quaterniond(Vector3d eulerAngles)
            : this(eulerAngles.X, eulerAngles.Y, eulerAngles.Z)
        {
        }

        /// <summary>
        /// Gets or sets the X component of this instance.
        /// </summary>
        [XmlIgnore]
        public double X
        {
            get => Xyz.X;
            set => Xyz.X = value;
        }

        /// <summary>
        /// Gets or sets the Y component of this instance.
        /// </summary>
        [XmlIgnore]
        public double Y
        {
            get => Xyz.Y;
            set => Xyz.Y = value;
        }

        /// <summary>
        /// Gets or sets the Z component of this instance.
        /// </summary>
        [XmlIgnore]
        public double Z
        {
            get => Xyz.Z;
            set => Xyz.Z = value;
        }

        /// <summary>
        /// Convert the current quaternion to axis angle representation.
        /// </summary>
        /// <param name="axis">The resultant axis.</param>
        /// <param name="angle">The resultant angle.</param>
        public void ToAxisAngle(out Vector3d axis, out double angle)
        {
            var result = ToAxisAngle();
            axis = result.Xyz;
            angle = result.W;
        }

        /// <summary>
        /// Convert this instance to an axis-angle representation.
        /// </summary>
        /// <returns>A Vector4 that is the axis-angle representation of this quaternion.</returns>
        public Vector4d ToAxisAngle()
        {
            var q = this;
            if (Math.Abs(q.W) > 1.0d)
            {
                q.Normalize();
            }

            var result = new Vector4d
            {
                W = 2.0d * Math.Acos(q.W) // angle
            };

            var den = Math.Sqrt(1.0 - (q.W * q.W));
            if (den > 0.0001d)
            {
                result.Xyz = q.Xyz / den;
            }
            else
            {
                // This occurs when the angle is zero.
                // Not a problem: just set an arbitrary normalized axis.
                result.Xyz = Vector3d.UnitX;
            }

            return result;
        }

        /// <summary>
        /// Convert the current quaternion to Euler angle representation.
        /// </summary>
        /// <param name="angles">The Euler angles in radians.</param>
        public void ToEulerAngles(out Vector3d angles)
        {
            angles = ToEulerAngles();
        }

        /// <summary>
        /// Convert this instance to an Euler angle representation.
        /// </summary>
        /// <returns>The Euler angles in radians.</returns>
        public Vector3d ToEulerAngles()
        {
            /*
            reference
            http://en.wikipedia.org/wiki/Conversion_between_qernions_and_Euler_angles
            http://www.euclideanspace.com/maths/geometry/rotations/conversions/qernionToEuler/
            */

            var q = this;

            q.Normalize();

            double singularityTest = (q.X * q.Y) - (q.W * q.Z);
            double yawY = 2d * ((q.W * q.X) + (q.Y * q.Z));
            double yawX = 1d - (2d * ((q.Z * q.Z) + (q.X * q.X)));

            // Threshold for the singularities found at the north/south poles.
            // TODO: Think about how this threshold should change with the added precision
            const double SINGULARITY_THRESHOLD = 0.4999995d;

            Vector3d eulerAngles;

            if (singularityTest < -SINGULARITY_THRESHOLD)
            {
                eulerAngles.Z = -Math.PI / 2; // -90 degrees
                eulerAngles.Y = Math.Atan2(yawY, yawX);
                eulerAngles.X = MathHelper.NormalizeRadians(-eulerAngles.Y - (2d * (float)Math.Atan2(q.Y, q.W)));
            }
            else if (singularityTest > SINGULARITY_THRESHOLD)
            {
                eulerAngles.Z = Math.PI / 2; // 90 degrees
                eulerAngles.Y = Math.Atan2(yawY, yawX);
                eulerAngles.X = MathHelper.NormalizeRadians(eulerAngles.Y - (2d * (float)Math.Atan2(q.Y, q.W)));
            }
            else
            {
                eulerAngles.Z = Math.Asin(2d * singularityTest);
                eulerAngles.X = Math.Atan2(yawY, yawX);
                eulerAngles.Y = Math.Atan2(-2d * ((q.W * q.Y) + (q.Z * q.X)), 1d - (2d * ((q.Y * q.Y) + (q.Z * q.Z))));
            }

            return eulerAngles;
        }

        /// <summary>
        /// Gets the length (magnitude) of the Quaterniond.
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        public double Length => Math.Sqrt((W * W) + Xyz.LengthSquared);

        /// <summary>
        /// Gets the square of the Quaterniond length (magnitude).
        /// </summary>
        public double LengthSquared => (W * W) + Xyz.LengthSquared;

        /// <summary>
        /// Returns a copy of the Quaterniond scaled to unit length.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public Quaterniond Normalized()
        {
            var q = this;
            q.Normalize();
            return q;
        }

        /// <summary>
        /// Inverts this Quaterniond.
        /// </summary>
        public void Invert()
        {
            Invert(in this, out this);
        }

        /// <summary>
        /// Returns the inverse of this Quaterniond.
        /// </summary>
        /// <returns>The inverted copy.</returns>
        public Quaterniond Inverted()
        {
            var q = this;
            q.Invert();
            return q;
        }

        /// <summary>
        /// Scales the Quaterniond to unit length.
        /// </summary>
        public void Normalize()
        {
            var scale = 1.0d / Length;
            Xyz *= scale;
            W *= scale;
        }

        /// <summary>
        /// Inverts the Vector3d component of this Quaterniond.
        /// </summary>
        public void Conjugate()
        {
            Xyz = -Xyz;
        }

        /// <summary>
        /// Defines the identity quaternion.
        /// </summary>
        public static readonly Quaterniond Identity = new Quaterniond(0, 0, 0, 1);

        /// <summary>
        /// Add two quaternions.
        /// </summary>
        /// <param name="left">The first operand.</param>
        /// <param name="right">The second operand.</param>
        /// <returns>The result of the addition.</returns>
        [Pure]
        public static Quaterniond Add(Quaterniond left, Quaterniond right)
        {
            return new Quaterniond(
                left.Xyz + right.Xyz,
                left.W + right.W);
        }

        /// <summary>
        /// Add two quaternions.
        /// </summary>
        /// <param name="left">The first operand.</param>
        /// <param name="right">The second operand.</param>
        /// <param name="result">The result of the addition.</param>
        public static void Add(in Quaterniond left, in Quaterniond right, out Quaterniond result)
        {
            result = new Quaterniond(
                left.Xyz + right.Xyz,
                left.W + right.W);
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>The result of the operation.</returns>
        [Pure]
        public static Quaterniond Sub(Quaterniond left, Quaterniond right)
        {
            return new Quaterniond(
                left.Xyz - right.Xyz,
                left.W - right.W);
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Sub(in Quaterniond left, in Quaterniond right, out Quaterniond result)
        {
            result = new Quaterniond(
                left.Xyz - right.Xyz,
                left.W - right.W);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        [Pure]
        public static Quaterniond Multiply(Quaterniond left, Quaterniond right)
        {
            Multiply(in left, in right, out Quaterniond result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(in Quaterniond left, in Quaterniond right, out Quaterniond result)
        {
            result = new Quaterniond(
                (right.W * left.Xyz) + (left.W * right.Xyz) + Vector3d.Cross(left.Xyz, right.Xyz),
                (left.W * right.W) - Vector3d.Dot(left.Xyz, right.Xyz));
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(in Quaterniond quaternion, double scale, out Quaterniond result)
        {
            result = new Quaterniond
            (
                quaternion.X * scale,
                quaternion.Y * scale,
                quaternion.Z * scale,
                quaternion.W * scale
            );
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        [Pure]
        public static Quaterniond Multiply(Quaterniond quaternion, double scale)
        {
            return new Quaterniond
            (
                quaternion.X * scale,
                quaternion.Y * scale,
                quaternion.Z * scale,
                quaternion.W * scale
            );
        }

        /// <summary>
        /// Get the conjugate of the given Quaterniond.
        /// </summary>
        /// <param name="q">The Quaterniond.</param>
        /// <returns>The conjugate of the given Quaterniond.</returns>
        [Pure]
        public static Quaterniond Conjugate(Quaterniond q)
        {
            return new Quaterniond(-q.Xyz, q.W);
        }

        /// <summary>
        /// Get the conjugate of the given Quaterniond.
        /// </summary>
        /// <param name="q">The Quaterniond.</param>
        /// <param name="result">The conjugate of the given Quaterniond.</param>
        public static void Conjugate(in Quaterniond q, out Quaterniond result)
        {
            result = new Quaterniond(-q.Xyz, q.W);
        }

        /// <summary>
        /// Get the inverse of the given Quaterniond.
        /// </summary>
        /// <param name="q">The Quaterniond to invert.</param>
        /// <returns>The inverse of the given Quaterniond.</returns>
        [Pure]
        public static Quaterniond Invert(Quaterniond q)
        {
            Invert(in q, out Quaterniond result);
            return result;
        }

        /// <summary>
        /// Get the inverse of the given Quaterniond.
        /// </summary>
        /// <param name="q">The Quaterniond to invert.</param>
        /// <param name="result">The inverse of the given Quaterniond.</param>
        public static void Invert(in Quaterniond q, out Quaterniond result)
        {
            var lengthSq = q.LengthSquared;
            if (lengthSq != 0.0)
            {
                var i = 1.0d / lengthSq;
                result = new Quaterniond(q.Xyz * -i, q.W * i);
            }
            else
            {
                result = q;
            }
        }

        /// <summary>
        /// Scale the given Quaterniond to unit length.
        /// </summary>
        /// <param name="q">The Quaterniond to normalize.</param>
        /// <returns>The normalized copy.</returns>
        [Pure]
        public static Quaterniond Normalize(Quaterniond q)
        {
            Normalize(in q, out Quaterniond result);
            return result;
        }

        /// <summary>
        /// Scale the given Quaterniond to unit length.
        /// </summary>
        /// <param name="q">The Quaterniond to normalize.</param>
        /// <param name="result">The normalized Quaterniond.</param>
        public static void Normalize(in Quaterniond q, out Quaterniond result)
        {
            var scale = 1.0d / q.Length;
            result = new Quaterniond(q.Xyz * scale, q.W * scale);
        }

        /// <summary>
        /// Build a Quaterniond from the given axis and angle.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The quaternion.</returns>
        [Pure]
        public static Quaterniond FromAxisAngle(Vector3d axis, double angle)
        {
            if (axis.LengthSquared == 0.0d)
            {
                return Identity;
            }

            var result = Identity;

            angle *= 0.5d;
            axis.Normalize();
            result.Xyz = axis * Math.Sin(angle);
            result.W = Math.Cos(angle);

            return Normalize(result);
        }

        /// <summary>
        /// Builds a Quaterniond from the given euler angles.
        /// </summary>
        /// <param name="pitch">The pitch (attitude), rotation around X axis.</param>
        /// <param name="yaw">The yaw (heading), rotation around Y axis.</param>
        /// <param name="roll">The roll (bank), rotation around Z axis.</param>
        /// <returns>The quaternion.</returns>
        [Pure]
        public static Quaterniond FromEulerAngles(double pitch, double yaw, double roll)
        {
            return new Quaterniond(pitch, yaw, roll);
        }

        /// <summary>
        /// Builds a Quaterniond from the given euler angles.
        /// </summary>
        /// <param name="eulerAngles">The euler angles as a vector.</param>
        /// <returns>The equivalent Quaterniond.</returns>
        [Pure]
        public static Quaterniond FromEulerAngles(Vector3d eulerAngles)
        {
            return new Quaterniond(eulerAngles);
        }

        /// <summary>
        /// Builds a Quaterniond from the given euler angles.
        /// </summary>
        /// <param name="eulerAngles">The euler angles as a vector.</param>
        /// <param name="result">The equivalent Quaterniond.</param>
        public static void FromEulerAngles(in Vector3d eulerAngles, out Quaterniond result)
        {
            var c1 = Math.Cos(eulerAngles.Y * 0.5);
            var c2 = Math.Cos(eulerAngles.X * 0.5);
            var c3 = Math.Cos(eulerAngles.Z * 0.5);
            var s1 = Math.Sin(eulerAngles.Y * 0.5);
            var s2 = Math.Sin(eulerAngles.X * 0.5);
            var s3 = Math.Sin(eulerAngles.Z * 0.5);

            result.W = (c1 * c2 * c3) - (s1 * s2 * s3);
            result.Xyz.X = (s1 * s2 * c3) + (c1 * c2 * s3);
            result.Xyz.Y = (s1 * c2 * c3) + (c1 * s2 * s3);
            result.Xyz.Z = (c1 * s2 * c3) - (s1 * c2 * s3);
        }

        /// <summary>
        /// Converts a quaternion to it's euler angle representation.
        /// </summary>
        /// <param name="q">The Quaternion.</param>
        /// <param name="result">The resulting euler angles in radians.</param>
        public static void ToEulerAngles(in Quaterniond q, out Vector3d result)
        {
            q.ToEulerAngles(out result);
        }

        /// <summary>
        /// Builds a quaternion from the given rotation matrix.
        /// </summary>
        /// <param name="matrix">A rotation matrix.</param>
        /// <returns>The equivalent quaternion.</returns>
        [Pure]
        public static Quaterniond FromMatrix(Matrix3d matrix)
        {
            FromMatrix(in matrix, out Quaterniond result);
            return result;
        }

        /// <summary>
        /// Builds a quaternion from the given rotation matrix.
        /// </summary>
        /// <param name="matrix">A rotation matrix.</param>
        /// <param name="result">The equivalent quaternion.</param>
        public static void FromMatrix(in Matrix3d matrix, out Quaterniond result)
        {
            var trace = matrix.Trace;

            if (trace > 0)
            {
                var s = Math.Sqrt(trace + 1) * 2;
                var invS = 1.0 / s;

                result.W = s * 0.25;
                result.Xyz.X = (matrix.Row2.Y - matrix.Row1.Z) * invS;
                result.Xyz.Y = (matrix.Row0.Z - matrix.Row2.X) * invS;
                result.Xyz.Z = (matrix.Row1.X - matrix.Row0.Y) * invS;
            }
            else
            {
                double m00 = matrix.Row0.X, m11 = matrix.Row1.Y, m22 = matrix.Row2.Z;

                if (m00 > m11 && m00 > m22)
                {
                    var s = Math.Sqrt(1 + m00 - m11 - m22) * 2;
                    var invS = 1.0 / s;

                    result.W = (matrix.Row2.Y - matrix.Row1.Z) * invS;
                    result.Xyz.X = s * 0.25;
                    result.Xyz.Y = (matrix.Row0.Y + matrix.Row1.X) * invS;
                    result.Xyz.Z = (matrix.Row0.Z + matrix.Row2.X) * invS;
                }
                else if (m11 > m22)
                {
                    var s = Math.Sqrt(1 + m11 - m00 - m22) * 2;
                    var invS = 1.0 / s;

                    result.W = (matrix.Row0.Z - matrix.Row2.X) * invS;
                    result.Xyz.X = (matrix.Row0.Y + matrix.Row1.X) * invS;
                    result.Xyz.Y = s * 0.25;
                    result.Xyz.Z = (matrix.Row1.Z + matrix.Row2.Y) * invS;
                }
                else
                {
                    var s = Math.Sqrt(1 + m22 - m00 - m11) * 2;
                    var invS = 1.0 / s;

                    result.W = (matrix.Row1.X - matrix.Row0.Y) * invS;
                    result.Xyz.X = (matrix.Row0.Z + matrix.Row2.X) * invS;
                    result.Xyz.Y = (matrix.Row1.Z + matrix.Row2.Y) * invS;
                    result.Xyz.Z = s * 0.25;
                }
            }
        }

        /// <summary>
        /// Do Spherical linear interpolation between two quaternions.
        /// </summary>
        /// <param name="q1">The first Quaterniond.</param>
        /// <param name="q2">The second Quaterniond.</param>
        /// <param name="blend">The blend factor.</param>
        /// <returns>A smooth blend between the given quaternions.</returns>
        [Pure]
        public static Quaterniond Slerp(Quaterniond q1, Quaterniond q2, double blend)
        {
            // if either input is zero, return the other.
            if (q1.LengthSquared == 0.0d)
            {
                if (q2.LengthSquared == 0.0d)
                {
                    return Identity;
                }

                return q2;
            }

            if (q2.LengthSquared == 0.0d)
            {
                return q1;
            }

            var cosHalfAngle = (q1.W * q2.W) + Vector3d.Dot(q1.Xyz, q2.Xyz);

            if (cosHalfAngle >= 1.0d || cosHalfAngle <= -1.0d)
            {
                // angle = 0.0d, so just return one input.
                return q1;
            }

            if (cosHalfAngle < 0.0d)
            {
                q2.Xyz = -q2.Xyz;
                q2.W = -q2.W;
                cosHalfAngle = -cosHalfAngle;
            }

            double blendA;
            double blendB;
            if (cosHalfAngle < 0.99d)
            {
                // do proper slerp for big angles
                var halfAngle = Math.Acos(cosHalfAngle);
                var sinHalfAngle = Math.Sin(halfAngle);
                var oneOverSinHalfAngle = 1.0d / sinHalfAngle;
                blendA = Math.Sin(halfAngle * (1.0d - blend)) * oneOverSinHalfAngle;
                blendB = Math.Sin(halfAngle * blend) * oneOverSinHalfAngle;
            }
            else
            {
                // do lerp if angle is really small.
                blendA = 1.0d - blend;
                blendB = blend;
            }

            var result = new Quaterniond((blendA * q1.Xyz) + (blendB * q2.Xyz), (blendA * q1.W) + (blendB * q2.W));
            if (result.LengthSquared > 0.0d)
            {
                return Normalize(result);
            }

            return Identity;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Quaterniond operator +(Quaterniond left, Quaterniond right)
        {
            left.Xyz += right.Xyz;
            left.W += right.W;
            return left;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Quaterniond operator -(Quaterniond left, Quaterniond right)
        {
            left.Xyz -= right.Xyz;
            left.W -= right.W;
            return left;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        [Pure]
        public static Quaterniond operator *(Quaterniond left, Quaterniond right)
        {
            Multiply(in left, in right, out left);
            return left;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        [Pure]
        public static Quaterniond operator *(Quaterniond quaternion, double scale)
        {
            Multiply(in quaternion, scale, out quaternion);
            return quaternion;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        [Pure]
        public static Quaterniond operator *(double scale, Quaterniond quaternion)
        {
            return new Quaterniond
            (
                quaternion.X * scale,
                quaternion.Y * scale,
                quaternion.Z * scale,
                quaternion.W * scale
            );
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        [Pure]
        public static bool operator ==(Quaterniond left, Quaterniond right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        [Pure]
        public static bool operator !=(Quaterniond left, Quaterniond right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a System.String that represents the current Quaterniond.
        /// </summary>
        /// <returns>A human-readable representation of the quaternion.</returns>
        public override string ToString()
        {
            return $"V: {Xyz}, W: {W}";
        }

        /// <summary>
        /// Compares this object instance to another object for equality.
        /// </summary>
        /// <param name="other">The other object to be used in the comparison.</param>
        /// <returns>True if both objects are Quaternions of equal value. Otherwise it returns false.</returns>
        [Pure]
        public override bool Equals(object other)
        {
            if (other is Quaterniond == false)
            {
                return false;
            }

            return this == (Quaterniond)other;
        }

        /// <summary>
        /// Provides the hash code for this object.
        /// </summary>
        /// <returns>A hash code formed from the bitwise XOR of this objects members.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Xyz.GetHashCode() * 397) ^ W.GetHashCode();
            }
        }

        /// <summary>
        /// Compares this Quaterniond instance to another Quaterniond for equality.
        /// </summary>
        /// <param name="other">The other Quaterniond to be used in the comparison.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        [Pure]
        public bool Equals(Quaterniond other)
        {
            return Xyz == other.Xyz && W == other.W;
        }
    }
}
