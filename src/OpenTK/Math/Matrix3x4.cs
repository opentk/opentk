﻿#region --- License ---
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
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK
{
    /// <summary>
    /// Represents a 3x4 Matrix
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3x4 : IEquatable<Matrix3x4>
    {
        #region Fields

        /// <summary>
        /// Top row of the matrix
        /// </summary>
        public Vector4 Row0;

        /// <summary>
        /// 2nd row of the matrix
        /// </summary>
        public Vector4 Row1;

        /// <summary>
        /// Bottom row of the matrix
        /// </summary>
        public Vector4 Row2;

        /// <summary>
        /// The zero matrix
        /// </summary>
        public static Matrix3x4 Zero = new Matrix3x4(Vector4.Zero, Vector4.Zero, Vector4.Zero);

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="row0">Top row of the matrix</param>
        /// <param name="row1">Second row of the matrix</param>
        /// <param name="row2">Bottom row of the matrix</param>
        public Matrix3x4(Vector4 row0, Vector4 row1, Vector4 row2)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
        }

        /// <summary>
        /// Constructs a new instance.
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
        /// <param name="m23">First item of the third row of the matrix.</param>
        public Matrix3x4(
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23)
        {
            Row0 = new Vector4(m00, m01, m02, m03);
            Row1 = new Vector4(m10, m11, m12, m13);
            Row2 = new Vector4(m20, m21, m22, m23);
        }

        #endregion

        #region Public Members

        #region Properties

        /// <summary>
        /// Gets the first column of this matrix.
        /// </summary>
        public Vector3 Column0
        {
            get { return new Vector3(Row0.X, Row1.X, Row2.X); }
        }

        /// <summary>
        /// Gets the second column of this matrix.
        /// </summary>
        public Vector3 Column1
        {
            get { return new Vector3(Row0.Y, Row1.Y, Row2.Y); }
        }

        /// <summary>
        /// Gets the third column of this matrix.
        /// </summary>
        public Vector3 Column2
        {
            get { return new Vector3(Row0.Z, Row1.Z, Row2.Z); }
        }

        /// <summary>
        /// Gets the fourth column of this matrix.
        /// </summary>
        public Vector3 Column3
        {
            get { return new Vector3(Row0.W, Row1.W, Row2.W); }
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 1 of this instance.
        /// </summary>
        public float M11 { get { return Row0.X; } set { Row0.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 1, column 2 of this instance.
        /// </summary>
        public float M12 { get { return Row0.Y; } set { Row0.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 1, column 3 of this instance.
        /// </summary>
        public float M13 { get { return Row0.Z; } set { Row0.Z = value; } }

        /// <summary>
        /// Gets or sets the value at row 1, column 4 of this instance.
        /// </summary>
        public float M14 { get { return Row0.W; } set { Row0.W = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public float M21 { get { return Row1.X; } set { Row1.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public float M22 { get { return Row1.Y; } set { Row1.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 3 of this instance.
        /// </summary>
        public float M23 { get { return Row1.Z; } set { Row1.Z = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 4 of this instance.
        /// </summary>
        public float M24 { get { return Row1.W; } set { Row1.W = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public float M31 { get { return Row2.X; } set { Row2.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public float M32 { get { return Row2.Y; } set { Row2.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 3 of this instance.
        /// </summary>
        public float M33 { get { return Row2.Z; } set { Row2.Z = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 4 of this instance.
        /// </summary>
        public float M34 { get { return Row2.W; } set { Row2.W = value; } }

        /// <summary>
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector3 Diagonal
        {
            get
            {
                return new Vector3(Row0.X, Row1.Y, Row2.Z);
            }
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
        public float Trace { get { return Row0.X + Row1.Y + Row2.Z; } }

        #endregion

        #region Indexers

        /// <summary>
        /// Gets or sets the value at a specified row and column.
        /// </summary>
        public float this[int rowIndex, int columnIndex]
        {
            get
            {
                if (rowIndex == 0) return Row0[columnIndex];
                else if (rowIndex == 1) return Row1[columnIndex];
                else if (rowIndex == 2) return Row2[columnIndex];
                throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")");
            }
            set
            {
                if (rowIndex == 0) Row0[columnIndex] = value;
                else if (rowIndex == 1) Row1[columnIndex] = value;
                else if (rowIndex == 2) Row2[columnIndex] = value;
                else throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
            }
        }

        #endregion

        #region Instance

        #region public void Invert()

        /// <summary>
        /// Converts this instance into its inverse.
        /// </summary>
        public void Invert()
        {
            this = Matrix3x4.Invert(this);
        }

        #endregion

        #endregion

        #region Static

        #region CreateFromAxisAngle

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

            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);
            float t = 1.0f - cos;

            float tXX = t * axisX * axisX,
                tXY = t * axisX * axisY,
                tXZ = t * axisX * axisZ,
                tYY = t * axisY * axisY,
                tYZ = t * axisY * axisZ,
                tZZ = t * axisZ * axisZ;

            float sinX = sin * axisX,
                sinY = sin * axisY,
                sinZ = sin * axisZ;

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
        public static Matrix3x4 CreateFromAxisAngle(Vector3 axis, float angle)
        {
            Matrix3x4 result;
            CreateFromAxisAngle(axis, angle, out result);
            return result;
        }

        #endregion

        #region CreateFromQuaternion

        /// <summary>
        /// Builds a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion to rotate by.</param>
        /// <param name="result">A matrix instance.</param>
        public static void CreateFromQuaternion(ref Quaternion q, out Matrix3x4 result)
        {
            float x = q.X, y = q.Y, z = q.Z, w = q.W,
                tx = 2 * x, ty = 2 * y, tz = 2 * z,
                txx = tx * x, tyy = ty * y, tzz = tz * z,
                txy = tx * y, txz = tx * z, tyz = ty * z,
                txw = tx * w, tyw = ty * w, tzw = tz * w;

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

            /*Vector3 axis;
            float angle;
            q.ToAxisAngle(out axis, out angle);
            CreateFromAxisAngle(axis, angle, out result);*/
        }

        /// <summary>
        /// Builds a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion to rotate by.</param>
        /// <returns>A matrix instance.</returns>
        public static Matrix3x4 CreateFromQuaternion(Quaternion q)
        {
            Matrix3x4 result;
            CreateFromQuaternion(ref q, out result);
            return result;
        }

        #endregion

        #region CreateRotation[XYZ]

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateRotationX(float angle, out Matrix3x4 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);

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
        public static Matrix3x4 CreateRotationX(float angle)
        {
            Matrix3x4 result;
            CreateRotationX(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateRotationY(float angle, out Matrix3x4 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);

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
        public static Matrix3x4 CreateRotationY(float angle)
        {
            Matrix3x4 result;
            CreateRotationY(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void CreateRotationZ(float angle, out Matrix3x4 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);

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
        public static Matrix3x4 CreateRotationZ(float angle)
        {
            Matrix3x4 result;
            CreateRotationZ(angle, out result);
            return result;
        }

        #endregion

        #region CreateTranslation

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
        public static void CreateTranslation(ref Vector3 vector, out Matrix3x4 result)
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
        public static Matrix3x4 CreateTranslation(float x, float y, float z)
        {
            Matrix3x4 result;
            CreateTranslation(x, y, z, out result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix3x4 CreateTranslation(Vector3 vector)
        {
            Matrix3x4 result;
            CreateTranslation(vector.X, vector.Y, vector.Z, out result);
            return result;
        }

        #endregion

        #region CreateScale

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Single scale factor for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix3x4 CreateScale(float scale)
        {
            return CreateScale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix3x4 CreateScale(Vector3 scale)
        {
            return CreateScale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="x">Scale factor for x-axis</param>
        /// <param name="y">Scale factor for y-axis</param>
        /// <param name="z">Scale factor for z-axis</param>
        /// <returns>A scaling matrix</returns>
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

        #endregion

        #region Multiply Functions

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication</returns>
        public static Matrix3 Mult(Matrix3x4 left, Matrix4x3 right)
        {
            Matrix3 result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Mult(ref Matrix3x4 left, ref Matrix4x3 right, out Matrix3 result)
        {
            float lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z, lM14 = left.Row0.W,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z, lM24 = left.Row1.W,
                lM31 = left.Row2.X, lM32 = left.Row2.Y, lM33 = left.Row2.Z, lM34 = left.Row2.W,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z,
                rM31 = right.Row2.X, rM32 = right.Row2.Y, rM33 = right.Row2.Z,
                rM41 = right.Row3.X, rM42 = right.Row3.Y, rM43 = right.Row3.Z;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21) + (lM13 * rM31) + (lM14 * rM41);
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22) + (lM13 * rM32) + (lM14 * rM42);
            result.Row0.Z = (lM11 * rM13) + (lM12 * rM23) + (lM13 * rM33) + (lM14 * rM43);
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21) + (lM23 * rM31) + (lM24 * rM41);
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22) + (lM23 * rM32) + (lM24 * rM42);
            result.Row1.Z = (lM21 * rM13) + (lM22 * rM23) + (lM23 * rM33) + (lM24 * rM43);
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21) + (lM33 * rM31) + (lM34 * rM41);
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22) + (lM33 * rM32) + (lM34 * rM42);
            result.Row2.Z = (lM31 * rM13) + (lM32 * rM23) + (lM33 * rM33) + (lM34 * rM43);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication</returns>
        public static Matrix3x4 Mult(Matrix3x4 left, Matrix3x4 right)
        {
            Matrix3x4 result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Mult(ref Matrix3x4 left, ref Matrix3x4 right, out Matrix3x4 result)
        {
            float lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z, lM14 = left.Row0.W,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z, lM24 = left.Row1.W,
                lM31 = left.Row2.X, lM32 = left.Row2.Y, lM33 = left.Row2.Z, lM34 = left.Row2.W,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z, rM14 = right.Row0.W,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z, rM24 = right.Row1.W,
                rM31 = right.Row2.X, rM32 = right.Row2.Y, rM33 = right.Row2.Z, rM34 = right.Row2.W;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21) + (lM13 * rM31);
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22) + (lM13 * rM32);
            result.Row0.Z = (lM11 * rM13) + (lM12 * rM23) + (lM13 * rM33);
            result.Row0.W = (lM11 * rM14) + (lM12 * rM24) + (lM13 * rM34) + lM14;
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21) + (lM23 * rM31);
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22) + (lM23 * rM32);
            result.Row1.Z = (lM21 * rM13) + (lM22 * rM23) + (lM23 * rM33);
            result.Row1.W = (lM21 * rM14) + (lM22 * rM24) + (lM23 * rM34) + lM24;
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21) + (lM33 * rM31);
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22) + (lM33 * rM32);
            result.Row2.Z = (lM31 * rM13) + (lM32 * rM23) + (lM33 * rM33);
            result.Row2.W = (lM31 * rM14) + (lM32 * rM24) + (lM33 * rM34) + lM34;

            /*result.Row0 = (right.Row0 * lM11 + right.Row1 * lM12 + right.Row2 * lM13);
            result.Row0.W += lM14;

            result.Row1 = (right.Row0 * lM21 + right.Row1 * lM22 + right.Row2 * lM23);
            result.Row1.W += lM24;

            result.Row2 = (right.Row0 * lM31 + right.Row1 * lM32 + right.Row2 * lM33);
            result.Row2.W += lM34;*/
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication</returns>
        public static Matrix3x4 Mult(Matrix3x4 left, float right)
        {
            Matrix3x4 result;
            Mult(ref left, right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Mult(ref Matrix3x4 left, float right, out Matrix3x4 result)
        {
            result.Row0 = left.Row0 * right;
            result.Row1 = left.Row1 * right;
            result.Row2 = left.Row2 * right;
        }

        #endregion

        #region Add Functions

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        public static Matrix3x4 Add(Matrix3x4 left, Matrix3x4 right)
        {
            Matrix3x4 result;
            Add(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(ref Matrix3x4 left, ref Matrix3x4 right, out Matrix3x4 result)
        {
            result.Row0 = left.Row0 + right.Row0;
            result.Row1 = left.Row1 + right.Row1;
            result.Row2 = left.Row2 + right.Row2;
        }

        #endregion

        #region Subtract Functions

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <returns>A new instance that is the result of the subraction.</returns>
        public static Matrix3x4 Subtract(Matrix3x4 left, Matrix3x4 right)
        {
            Matrix3x4 result;
            Subtract(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <param name="result">A new instance that is the result of the subraction.</param>
        public static void Subtract(ref Matrix3x4 left, ref Matrix3x4 right, out Matrix3x4 result)
        {
            result.Row0 = left.Row0 - right.Row0;
            result.Row1 = left.Row1 - right.Row1;
            result.Row2 = left.Row2 - right.Row2;
        }

        #endregion

        #region Invert Functions

        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static Matrix3x4 Invert(Matrix3x4 mat)
        {
            Matrix3x4 result;
            Invert(ref mat, out result);
            return result;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <param name="result">The inverse of the given matrix if it has one, or the input if it is singular</param>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static void Invert(ref Matrix3x4 mat, out Matrix3x4 result)
        {
            Matrix3 inverseRotation = new Matrix3(mat.Column0, mat.Column1, mat.Column2);
            inverseRotation.Row0 /= inverseRotation.Row0.LengthSquared;
            inverseRotation.Row1 /= inverseRotation.Row1.LengthSquared;
            inverseRotation.Row2 /= inverseRotation.Row2.LengthSquared;

            Vector3 translation = new Vector3(mat.Row0.W, mat.Row1.W, mat.Row2.W);

            result.Row0 = new Vector4(inverseRotation.Row0, -Vector3.Dot(inverseRotation.Row0, translation));
            result.Row1 = new Vector4(inverseRotation.Row1, -Vector3.Dot(inverseRotation.Row1, translation));
            result.Row2 = new Vector4(inverseRotation.Row2, -Vector3.Dot(inverseRotation.Row2, translation));
        }

        #endregion

        #region Transpose

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <returns>The transpose of the given matrix</returns>
        public static Matrix4x3 Transpose(Matrix3x4 mat)
        {
            return new Matrix4x3(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
        }

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <param name="result">The result of the calculation</param>
        public static void Transpose(ref Matrix3x4 mat, out Matrix4x3 result)
        {
            result.Row0 = mat.Column0;
            result.Row1 = mat.Column1;
            result.Row2 = mat.Column2;
            result.Row3 = mat.Column3;
        }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3 which holds the result of the multiplication</returns>
        public static Matrix3 operator *(Matrix3x4 left, Matrix4x3 right)
        {
            return Matrix3x4.Mult(left, right);
        }

        /// <summary>
        /// Matrix-scalar multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x4 which holds the result of the multiplication</returns>
        public static Matrix3x4 operator *(Matrix3x4 left, Matrix3x4 right)
        {
            return Matrix3x4.Mult(left, right);
        }

        /// <summary>
        /// Matrix-scalar multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x4 which holds the result of the multiplication</returns>
        public static Matrix3x4 operator *(Matrix3x4 left, float right)
        {
            return Matrix3x4.Mult(left, right);
        }

        /// <summary>
        /// Matrix addition
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x4 which holds the result of the addition</returns>
        public static Matrix3x4 operator +(Matrix3x4 left, Matrix3x4 right)
        {
            return Matrix3x4.Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x4 which holds the result of the subtraction</returns>
        public static Matrix3x4 operator -(Matrix3x4 left, Matrix3x4 right)
        {
            return Matrix3x4.Subtract(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
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
        public static bool operator !=(Matrix3x4 left, Matrix3x4 right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current Matrix4.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}", Row0, Row1, Row2);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.Row0.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Row1.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Row2.GetHashCode();
                return hashCode;
            }
        }

        #endregion

        #region public override bool Equals(object obj)

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix3x4))
                return false;

            return this.Equals((Matrix3x4)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Matrix3x4> Members

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(Matrix3x4 other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1 &&
                Row2 == other.Row2;
        }

        #endregion
    }
}
