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
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Represents a 3x4 Matrix.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3x4 : IEquatable<Matrix3x4>
    {
        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector4 Row0;

        /// <summary>
        /// 2nd row of the matrix.
        /// </summary>
        public Vector4 Row1;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector4 Row2;

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static Matrix3x4 Zero = new Matrix3x4(Vector4.Zero, Vector4.Zero, Vector4.Zero);

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3x4"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Second row of the matrix.</param>
        /// <param name="row2">Bottom row of the matrix.</param>
        public Matrix3x4(Vector4 row0, Vector4 row1, Vector4 row2)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3x4"/> struct.
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m02">Third item of the first row of the matrix.</param>
        /// <param name="m03">Fourth item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m12">Third item of the second row of the matrix.</param>
        /// <param name="m13">Fourth item of the second row of the matrix.</param>
        /// <param name="m20">First item of the third row of the matrix.</param>
        /// <param name="m21">Second item of the third row of the matrix.</param>
        /// <param name="m22">Third item of the third row of the matrix.</param>
        /// <param name="m23">Fourth item of the third row of the matrix.</param>
        [SuppressMessage("ReSharper", "SA1117", Justification = "For better readability of Matrix struct.")]
        public Matrix3x4
        (
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23
        )
        {
            Row0 = new Vector4(m00, m01, m02, m03);
            Row1 = new Vector4(m10, m11, m12, m13);
            Row2 = new Vector4(m20, m21, m22, m23);
        }

        /// <summary>
        /// Gets the first column of this matrix.
        /// </summary>
        public Vector3 Column0 => new Vector3(Row0.X, Row1.X, Row2.X);

        /// <summary>
        /// Gets the second column of this matrix.
        /// </summary>
        public Vector3 Column1 => new Vector3(Row0.Y, Row1.Y, Row2.Y);

        /// <summary>
        /// Gets the third column of this matrix.
        /// </summary>
        public Vector3 Column2 => new Vector3(Row0.Z, Row1.Z, Row2.Z);

        /// <summary>
        /// Gets the fourth column of this matrix.
        /// </summary>
        public Vector3 Column3 => new Vector3(Row0.W, Row1.W, Row2.W);

        /// <summary>
        /// Gets or sets the value at row 1, column 1 of this instance.
        /// </summary>
        public float M11
        {
            get => Row0.X;
            set => Row0.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 2 of this instance.
        /// </summary>
        public float M12
        {
            get => Row0.Y;
            set => Row0.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 3 of this instance.
        /// </summary>
        public float M13
        {
            get => Row0.Z;
            set => Row0.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 4 of this instance.
        /// </summary>
        public float M14
        {
            get => Row0.W;
            set => Row0.W = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public float M21
        {
            get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public float M22
        {
            get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 3 of this instance.
        /// </summary>
        public float M23
        {
            get => Row1.Z;
            set => Row1.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 4 of this instance.
        /// </summary>
        public float M24
        {
            get => Row1.W;
            set => Row1.W = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public float M31
        {
            get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public float M32
        {
            get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 3 of this instance.
        /// </summary>
        public float M33
        {
            get => Row2.Z;
            set => Row2.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 4 of this instance.
        /// </summary>
        public float M34
        {
            get => Row2.W;
            set => Row2.W = value;
        }

        /// <summary>
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector3 Diagonal
        {
            get => new Vector3(Row0.X, Row1.Y, Row2.Z);
            set
            {
                Row0.X = value.X;
                Row1.Y = value.Y;
                Row2.Z = value.Z;
            }
        }

        /// <summary>
        /// Gets the trace of the matrix, the sum of the values along the diagonal.
        /// </summary>
        public float Trace => Row0.X + Row1.Y + Row2.Z;

        /// <summary>
        /// Gets or sets the value at a specified row and column.
        /// </summary>
        /// <param name="rowIndex">The index of the row.</param>
        /// <param name="columnIndex">The index of the column.</param>
        /// <returns>The element at the given row and column index.</returns>
        public float this[int rowIndex, int columnIndex]
        {
            get
            {
                if (rowIndex == 0)
                {
                    return Row0[columnIndex];
                }

                if (rowIndex == 1)
                {
                    return Row1[columnIndex];
                }

                if (rowIndex == 2)
                {
                    return Row2[columnIndex];
                }

                throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " +
                                                   columnIndex + ")");
            }

            set
            {
                if (rowIndex == 0)
                {
                    Row0[columnIndex] = value;
                }
                else if (rowIndex == 1)
                {
                    Row1[columnIndex] = value;
                }
                else if (rowIndex == 2)
                {
                    Row2[columnIndex] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " +
                                                       columnIndex + ")");
                }
            }
        }

        /// <summary>
        /// Converts this instance into its inverse.
        /// </summary>
        public void Invert()
        {
            this = Invert(this);
        }

        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <param name="result">A matrix instance.</param>
        public static void CreateFromAxisAngle(Vector3 axis, float angle, out Matrix3x4 result)
        {
            axis.Normalize();
            float axisX = axis.X, axisY = axis.Y, axisZ = axis.Z;

            var cos = (float)Math.Cos(angle);
            var sin = (float)Math.Sin(angle);
            var t = 1.0f - cos;

            float tXX = t * axisX * axisX;
            float tXY = t * axisX * axisY;
            float tXZ = t * axisX * axisZ;
            float tYY = t * axisY * axisY;
            float tYZ = t * axisY * axisZ;
            float tZZ = t * axisZ * axisZ;

            float sinX = sin * axisX;
            float sinY = sin * axisY;
            float sinZ = sin * axisZ;

            result.Row0.X = tXX + cos;
            result.Row0.Y = tXY - sinZ;
            result.Row0.Z = tXZ + sinY;
            result.Row0.W = 0;
            result.Row1.X = tXY + sinZ;
            result.Row1.Y = tYY + cos;
            result.Row1.Z = tYZ - sinX;
            result.Row1.W = 0;
            result.Row2.X = tXZ - sinY;
            result.Row2.Y = tYZ + sinX;
            result.Row2.Z = tZZ + cos;
            result.Row2.W = 0;
        }

        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <returns>A matrix instance.</returns>
        [Pure]
        public static Matrix3x4 CreateFromAxisAngle(Vector3 axis, float angle)
        {
            CreateFromAxisAngle(axis, angle, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion to rotate by.</param>
        /// <param name="result">A matrix instance.</param>
        public static void CreateFromQuaternion(in Quaternion q, out Matrix3x4 result)
        {
            float x = q.X;
            float y = q.Y;
            float z = q.Z;
            float w = q.W;
            float tx = 2 * x;
            float ty = 2 * y;
            float tz = 2 * z;
            float txx = tx * x;
            float tyy = ty * y;
            float tzz = tz * z;
            float txy = tx * y;
            float txz = tx * z;
            float tyz = ty * z;
            float txw = tx * w;
            float tyw = ty * w;
            float tzw = tz * w;

            result.Row0.X = 1f - (tyy + tzz);
            result.Row0.Y = txy + tzw;
            result.Row0.Z = txz - tyw;
            result.Row0.W = 0f;
            result.Row1.X = txy - tzw;
            result.Row1.Y = 1f - (txx + tzz);
            result.Row1.Z = tyz + txw;
            result.Row1.W = 0f;
            result.Row2.X = txz + tyw;
            result.Row2.Y = tyz - txw;
            result.Row2.Z = 1f - (txx + tyy);
            result.Row2.W = 0f;
        }

        /// <summary>
        /// Builds a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion to rotate by.</param>
        /// <returns>A matrix instance.</returns>
        [Pure]
        public static Matrix3x4 CreateFromQuaternion(Quaternion q)
        {
            CreateFromQuaternion(in q, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateRotationX(float angle, out Matrix3x4 result)
        {
            var cos = (float)Math.Cos(angle);
            var sin = (float)Math.Sin(angle);

            result.Row0.X = 1;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row0.W = 0;
            result.Row1.X = 0;
            result.Row1.Y = cos;
            result.Row1.Z = sin;
            result.Row1.W = 0;
            result.Row2.X = 0;
            result.Row2.Y = -sin;
            result.Row2.Z = cos;
            result.Row2.W = 0;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        [Pure]
        public static Matrix3x4 CreateRotationX(float angle)
        {
            CreateRotationX(angle, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateRotationY(float angle, out Matrix3x4 result)
        {
            var cos = (float)Math.Cos(angle);
            var sin = (float)Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = 0;
            result.Row0.Z = -sin;
            result.Row0.W = 0;
            result.Row1.X = 0;
            result.Row1.Y = 1;
            result.Row1.Z = 0;
            result.Row1.W = 0;
            result.Row2.X = sin;
            result.Row2.Y = 0;
            result.Row2.Z = cos;
            result.Row2.W = 0;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        [Pure]
        public static Matrix3x4 CreateRotationY(float angle)
        {
            CreateRotationY(angle, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateRotationZ(float angle, out Matrix3x4 result)
        {
            var cos = (float)Math.Cos(angle);
            var sin = (float)Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row0.Z = 0;
            result.Row0.W = 0;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
            result.Row1.Z = 0;
            result.Row1.W = 0;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = 1;
            result.Row2.W = 0;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        [Pure]
        public static Matrix3x4 CreateRotationZ(float angle)
        {
            CreateRotationZ(angle, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateTranslation(float x, float y, float z, out Matrix3x4 result)
        {
            result.Row0.X = 1;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row0.W = x;
            result.Row1.X = 0;
            result.Row1.Y = 1;
            result.Row1.Z = 0;
            result.Row1.W = y;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = 1;
            result.Row2.W = z;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateTranslation(in Vector3 vector, out Matrix3x4 result)
        {
            result.Row0.X = 1;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row0.W = vector.X;
            result.Row1.X = 0;
            result.Row1.Y = 1;
            result.Row1.Z = 0;
            result.Row1.W = vector.Y;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = 1;
            result.Row2.W = vector.Z;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        [Pure]
        public static Matrix3x4 CreateTranslation(float x, float y, float z)
        {
            CreateTranslation(x, y, z, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        [Pure]
        public static Matrix3x4 CreateTranslation(Vector3 vector)
        {
            CreateTranslation(vector.X, vector.Y, vector.Z, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Build a scaling matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for x,y and z axes.</param>
        /// <returns>A scaling matrix.</returns>
        [Pure]
        public static Matrix3x4 CreateScale(float scale)
        {
            return CreateScale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix.
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes.</param>
        /// <returns>A scaling matrix.</returns>
        [Pure]
        public static Matrix3x4 CreateScale(Vector3 scale)
        {
            return CreateScale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// Build a scaling matrix.
        /// </summary>
        /// <param name="x">Scale factor for x-axis.</param>
        /// <param name="y">Scale factor for y-axis.</param>
        /// <param name="z">Scale factor for z-axis.</param>
        /// <returns>A scaling matrix.</returns>
        [Pure]
        public static Matrix3x4 CreateScale(float x, float y, float z)
        {
            Matrix3x4 result;
            result.Row0.X = x;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row0.W = 0;
            result.Row1.X = 0;
            result.Row1.Y = y;
            result.Row1.Z = 0;
            result.Row1.W = 0;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = z;
            result.Row2.W = 0;
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix3 Mult(Matrix3x4 left, Matrix4x3 right)
        {
            Mult(in left, in right, out Matrix3 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix3x4 left, in Matrix4x3 right, out Matrix3 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM13 = left.Row0.Z;
            float leftM14 = left.Row0.W;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM23 = left.Row1.Z;
            float leftM24 = left.Row1.W;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float leftM33 = left.Row2.Z;
            float leftM34 = left.Row2.W;
            float rightM11 = right.Row0.X;
            float rightM12 = right.Row0.Y;
            float rightM13 = right.Row0.Z;
            float rightM21 = right.Row1.X;
            float rightM22 = right.Row1.Y;
            float rightM23 = right.Row1.Z;
            float rightM31 = right.Row2.X;
            float rightM32 = right.Row2.Y;
            float rightM33 = right.Row2.Z;
            float rightM41 = right.Row3.X;
            float rightM42 = right.Row3.Y;
            float rightM43 = right.Row3.Z;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31) + (leftM14 * rightM41);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32) + (leftM14 * rightM42);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23) + (leftM13 * rightM33) + (leftM14 * rightM43);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31) + (leftM24 * rightM41);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32) + (leftM24 * rightM42);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23) + (leftM23 * rightM33) + (leftM24 * rightM43);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21) + (leftM33 * rightM31) + (leftM34 * rightM41);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22) + (leftM33 * rightM32) + (leftM34 * rightM42);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23) + (leftM33 * rightM33) + (leftM34 * rightM43);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x4 Mult(Matrix3x4 left, Matrix3x4 right)
        {
            Mult(in left, in right, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix3x4 left, in Matrix3x4 right, out Matrix3x4 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM13 = left.Row0.Z;
            float leftM14 = left.Row0.W;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM23 = left.Row1.Z;
            float leftM24 = left.Row1.W;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float leftM33 = left.Row2.Z;
            float leftM34 = left.Row2.W;
            float rightM11 = right.Row0.X;
            float rightM12 = right.Row0.Y;
            float rightM13 = right.Row0.Z;
            float rightM14 = right.Row0.W;
            float rightM21 = right.Row1.X;
            float rightM22 = right.Row1.Y;
            float rightM23 = right.Row1.Z;
            float rightM24 = right.Row1.W;
            float rightM31 = right.Row2.X;
            float rightM32 = right.Row2.Y;
            float rightM33 = right.Row2.Z;
            float rightM34 = right.Row2.W;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23) + (leftM13 * rightM33);
            result.Row0.W = (leftM11 * rightM14) + (leftM12 * rightM24) + (leftM13 * rightM34) + leftM14;
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23) + (leftM23 * rightM33);
            result.Row1.W = (leftM21 * rightM14) + (leftM22 * rightM24) + (leftM23 * rightM34) + leftM24;
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21) + (leftM33 * rightM31);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22) + (leftM33 * rightM32);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23) + (leftM33 * rightM33);
            result.Row2.W = (leftM31 * rightM14) + (leftM32 * rightM24) + (leftM33 * rightM34) + leftM34;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x4 Mult(Matrix3x4 left, float right)
        {
            Mult(in left, right, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix3x4 left, float right, out Matrix3x4 result)
        {
            result.Row0 = left.Row0 * right;
            result.Row1 = left.Row1 * right;
            result.Row2 = left.Row2 * right;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        [Pure]
        public static Matrix3x4 Add(Matrix3x4 left, Matrix3x4 right)
        {
            Add(in left, in right, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix3x4 left, in Matrix3x4 right, out Matrix3x4 result)
        {
            result.Row0 = left.Row0 + right.Row0;
            result.Row1 = left.Row1 + right.Row1;
            result.Row2 = left.Row2 + right.Row2;
        }

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <returns>A new instance that is the result of the subraction.</returns>
        [Pure]
        public static Matrix3x4 Subtract(Matrix3x4 left, Matrix3x4 right)
        {
            Subtract(in left, in right, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <param name="result">A new instance that is the result of the subraction.</param>
        public static void Subtract(in Matrix3x4 left, in Matrix3x4 right, out Matrix3x4 result)
        {
            result.Row0 = left.Row0 - right.Row0;
            result.Row1 = left.Row1 - right.Row1;
            result.Row2 = left.Row2 - right.Row2;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to invert.</param>
        /// <returns>The inverse of the given matrix.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        [Pure]
        public static Matrix3x4 Invert(Matrix3x4 mat)
        {
            Invert(in mat, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to invert.</param>
        /// <param name="result">The inverse of the given matrix if it has one, or the input if it is singular.</param>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static void Invert(in Matrix3x4 mat, out Matrix3x4 result)
        {
            var inverseRotation = new Matrix3(mat.Column0, mat.Column1, mat.Column2);
            inverseRotation.Row0 /= inverseRotation.Row0.LengthSquared;
            inverseRotation.Row1 /= inverseRotation.Row1.LengthSquared;
            inverseRotation.Row2 /= inverseRotation.Row2.LengthSquared;

            var translation = new Vector3(mat.Row0.W, mat.Row1.W, mat.Row2.W);

            result.Row0 = new Vector4(inverseRotation.Row0, -Vector3.Dot(inverseRotation.Row0, translation));
            result.Row1 = new Vector4(inverseRotation.Row1, -Vector3.Dot(inverseRotation.Row1, translation));
            result.Row2 = new Vector4(inverseRotation.Row2, -Vector3.Dot(inverseRotation.Row2, translation));
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <returns>The transpose of the given matrix.</returns>
        [Pure]
        public static Matrix4x3 Transpose(Matrix3x4 mat)
        {
            return new Matrix4x3(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The result of the calculation.</param>
        public static void Transpose(in Matrix3x4 mat, out Matrix4x3 result)
        {
            result.Row0 = mat.Column0;
            result.Row1 = mat.Column1;
            result.Row2 = mat.Column2;
            result.Row3 = mat.Column3;
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3 operator *(Matrix3x4 left, Matrix4x3 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix-scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x4 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x4 operator *(Matrix3x4 left, Matrix3x4 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix-scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x4 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x4 operator *(Matrix3x4 left, float right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x4 which holds the result of the addition.</returns>
        [Pure]
        public static Matrix3x4 operator +(Matrix3x4 left, Matrix3x4 right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x4 which holds the result of the subtraction.</returns>
        [Pure]
        public static Matrix3x4 operator -(Matrix3x4 left, Matrix3x4 right)
        {
            return Subtract(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        [Pure]
        public static bool operator ==(Matrix3x4 left, Matrix3x4 right)
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
        public static bool operator !=(Matrix3x4 left, Matrix3x4 right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a System.String that represents the current Matrix4.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override string ToString()
        {
            return $"{Row0}\n{Row1}\n{Row2}";
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Row0.GetHashCode();
                hashCode = (hashCode * 397) ^ Row1.GetHashCode();
                hashCode = (hashCode * 397) ^ Row2.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        [Pure]
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix3x4))
            {
                return false;
            }

            return Equals((Matrix3x4)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public bool Equals(Matrix3x4 other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1 &&
                Row2 == other.Row2;
        }
    }
}
