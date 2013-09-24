#region --- License ---
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
    /// Represents a 3x4 matrix.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4x3d : IEquatable<Matrix4x3d>
    {
        #region Fields

        /// <summary>
        /// Top row of the matrix
        /// </summary>
        public Vector3d Row0;

        /// <summary>
        /// 2nd row of the matrix
        /// </summary>
        public Vector3d Row1;

        /// <summary>
        /// 3rd row of the matrix
        /// </summary>
        public Vector3d Row2;

        /// <summary>
        /// Bottom row of the matrix
        /// </summary>
        public Vector3d Row3;

        /// <summary>
        /// The zero matrix
        /// </summary>
        public static Matrix4x3d Zero = new Matrix4x3d(Vector3d.Zero, Vector3d.Zero, Vector3d.Zero, Vector3d.Zero);

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="row0">Top row of the matrix</param>
        /// <param name="row1">Second row of the matrix</param>
        /// <param name="row2">Third row of the matrix</param>
        /// <param name="row3">Bottom row of the matrix</param>
        public Matrix4x3d(Vector3d row0, Vector3d row1, Vector3d row2, Vector3d row3)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m02">Third item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m12">Third item of the second row of the matrix.</param>
        /// <param name="m20">First item of the third row of the matrix.</param>
        /// <param name="m21">Second item of the third row of the matrix.</param>
        /// <param name="m22">Third item of the third row of the matrix.</param>
        /// <param name="m30">First item of the fourth row of the matrix.</param>
        /// <param name="m31">Second item of the fourth row of the matrix.</param>
        /// <param name="m32">Third item of the fourth row of the matrix.</param>
        public Matrix4x3d(
            double m00, double m01, double m02,
            double m10, double m11, double m12,
            double m20, double m21, double m22,
            double m30, double m31, double m32)
        {
            Row0 = new Vector3d(m00, m01, m02);
            Row1 = new Vector3d(m10, m11, m12);
            Row2 = new Vector3d(m20, m21, m22);
            Row3 = new Vector3d(m30, m31, m32);
        }

        #endregion

        #region Public Members

        #region Properties

        /// <summary>
        /// Gets the first column of this matrix.
        /// </summary>
        public Vector4d Column0
        {
            get { return new Vector4d(Row0.X, Row1.X, Row2.X, Row3.X); }
        }

        /// <summary>
        /// Gets the second column of this matrix.
        /// </summary>
        public Vector4d Column1
        {
            get { return new Vector4d(Row0.Y, Row1.Y, Row2.Y, Row3.Y); }
        }

        /// <summary>
        /// Gets the third column of this matrix.
        /// </summary>
        public Vector4d Column2
        {
            get { return new Vector4d(Row0.Z, Row1.Z, Row2.Z, Row3.Z); }
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 1 of this instance.
        /// </summary>
        public double M11 { get { return Row0.X; } set { Row0.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 1, column 2 of this instance.
        /// </summary>
        public double M12 { get { return Row0.Y; } set { Row0.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 1, column 3 of this instance.
        /// </summary>
        public double M13 { get { return Row0.Z; } set { Row0.Z = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public double M21 { get { return Row1.X; } set { Row1.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public double M22 { get { return Row1.Y; } set { Row1.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 3 of this instance.
        /// </summary>
        public double M23 { get { return Row1.Z; } set { Row1.Z = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public double M31 { get { return Row2.X; } set { Row2.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public double M32 { get { return Row2.Y; } set { Row2.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 3 of this instance.
        /// </summary>
        public double M33 { get { return Row2.Z; } set { Row2.Z = value; } }

        /// <summary>
        /// Gets or sets the value at row 4, column 1 of this instance.
        /// </summary>
        public double M41 { get { return Row3.X; } set { Row3.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 4, column 2 of this instance.
        /// </summary>
        public double M42 { get { return Row3.Y; } set { Row3.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 4, column 3 of this instance.
        /// </summary>
        public double M43 { get { return Row3.Z; } set { Row3.Z = value; } }

        /// <summary>
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector3d Diagonal
        {
            get
            {
                return new Vector3d(Row0.X, Row1.Y, Row2.Z);
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
        public double Trace { get { return Row0.X + Row1.Y + Row2.Z; } }

        #endregion

        #region Indexers

        /// <summary>
        /// Gets or sets the value at a specified row and column.
        /// </summary>
        public double this[int rowIndex, int columnIndex]
        {
            get
            {
                if (rowIndex == 0) return Row0[columnIndex];
                else if (rowIndex == 1) return Row1[columnIndex];
                else if (rowIndex == 2) return Row2[columnIndex];
                else if (rowIndex == 3) return Row3[columnIndex];
                throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")");
            }
            set
            {
                if (rowIndex == 0) Row0[columnIndex] = value;
                else if (rowIndex == 1) Row1[columnIndex] = value;
                else if (rowIndex == 2) Row2[columnIndex] = value;
                else if (rowIndex == 3) Row3[columnIndex] = value;
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
            this = Matrix4x3d.Invert(this);
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
        public static void CreateFromAxisAngle(Vector3d axis, double angle, out Matrix4x3d result)
        {
            axis.Normalize();
            double axisX = axis.X, axisY = axis.Y, axisZ = axis.Z;

            double cos = (double)System.Math.Cos(-angle);
            double sin = (double)System.Math.Sin(-angle);
            double t = 1.0f - cos;

            double tXX = t * axisX * axisX,
                tXY = t * axisX * axisY,
                tXZ = t * axisX * axisZ,
                tYY = t * axisY * axisY,
                tYZ = t * axisY * axisZ,
                tZZ = t * axisZ * axisZ;

            double sinX = sin * axisX,
                sinY = sin * axisY,
                sinZ = sin * axisZ;

            result.Row0.X = tXX + cos;
            result.Row0.Y = tXY - sinZ;
            result.Row0.Z = tXZ + sinY;
            result.Row1.X = tXY + sinZ;
            result.Row1.Y = tYY + cos;
            result.Row1.Z = tYZ - sinX;
            result.Row2.X = tXZ - sinY;
            result.Row2.Y = tYZ + sinX;
            result.Row2.Z = tZZ + cos;
            result.Row3.X = 0;
            result.Row3.Y = 0;
            result.Row3.Z = 0;
        }

        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <returns>A matrix instance.</returns>
        public static Matrix4x3d CreateFromAxisAngle(Vector3d axis, double angle)
        {
            Matrix4x3d result;
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
        public static void CreateFromQuaternion(ref Quaternion q, out Matrix4x3d result)
        {
            double x = q.X, y = q.Y, z = q.Z, w = q.W,
                tx = 2 * x, ty = 2 * y, tz = 2 * z,
                txx = tx * x, tyy = ty * y, tzz = tz * z,
                txy = tx * y, txz = tx * z, tyz = ty * z,
                twx = w * tx, twy = w * ty, twz = w * tz;

            result.Row0.X = 1f - tyy - tzz;
            result.Row0.Y = txy - twz;
            result.Row0.Z = txz + twy;
            result.Row1.X = txy + twz;
            result.Row1.Y = 1f - txx - tzz;
            result.Row1.Z = tyz - twx;
            result.Row2.X = txz - twy;
            result.Row2.Y = tyz + twx;
            result.Row2.Z = 1f - txx - tyy;
            result.Row3.X = 0;
            result.Row3.Y = 0;
            result.Row3.Z = 0;

            /*Vector3d axis;
            double angle;
            q.ToAxisAngle(out axis, out angle);
            CreateFromAxisAngle(axis, angle, out result);*/
        }

        /// <summary>
        /// Builds a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion to rotate by.</param>
        /// <returns>A matrix instance.</returns>
        public static Matrix4x3d CreateFromQuaternion(Quaternion q)
        {
            Matrix4x3d result;
            CreateFromQuaternion(ref q, out result);
            return result;
        }

        #endregion

        #region CreateRotation[XYZ]

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4dinstance.</param>
        public static void CreateRotationX(double angle, out Matrix4x3d result)
        {
            double cos = (double)System.Math.Cos(angle);
            double sin = (double)System.Math.Sin(angle);

            result.Row0.X = 1;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = cos;
            result.Row1.Z = sin;
            result.Row2.X = 0;
            result.Row2.Y = -sin;
            result.Row2.Z = cos;
            result.Row3.X = 0;
            result.Row3.Y = 0;
            result.Row3.Z = 0;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4dinstance.</returns>
        public static Matrix4x3d CreateRotationX(double angle)
        {
            Matrix4x3d result;
            CreateRotationX(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4dinstance.</param>
        public static void CreateRotationY(double angle, out Matrix4x3d result)
        {
            double cos = (double)System.Math.Cos(angle);
            double sin = (double)System.Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = 0;
            result.Row0.Z = -sin;
            result.Row1.X = 0;
            result.Row1.Y = 1;
            result.Row1.Z = 0;
            result.Row2.X = sin;
            result.Row2.Y = 0;
            result.Row2.Z = cos;
            result.Row3.X = 0;
            result.Row3.Y = 0;
            result.Row3.Z = 0;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4dinstance.</returns>
        public static Matrix4x3d CreateRotationY(double angle)
        {
            Matrix4x3d result;
            CreateRotationY(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4dinstance.</param>
        public static void CreateRotationZ(double angle, out Matrix4x3d result)
        {
            double cos = (double)System.Math.Cos(angle);
            double sin = (double)System.Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row0.Z = 0;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
            result.Row1.Z = 0;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = 1;
            result.Row3.X = 0;
            result.Row3.Y = 0;
            result.Row3.Z = 0;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4dinstance.</returns>
        public static Matrix4x3d CreateRotationZ(double angle)
        {
            Matrix4x3d result;
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
        /// <param name="result">The resulting Matrix4dinstance.</param>
        public static void CreateTranslation(double x, double y, double z, out Matrix4x3d result)
        {
            result.Row0.X = 1;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = 1;
            result.Row1.Z = 0;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = 1;
            result.Row3.X = x;
            result.Row3.Y = y;
            result.Row3.Z = z;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <param name="result">The resulting Matrix4dinstance.</param>
        public static void CreateTranslation(ref Vector3d vector, out Matrix4x3d result)
        {
            result.Row0.X = 1;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = 1;
            result.Row1.Z = 0;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = 1;
            result.Row3.X = vector.X;
            result.Row3.Y = vector.Y;
            result.Row3.Z = vector.Z;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <returns>The resulting Matrix4dinstance.</returns>
        public static Matrix4x3d CreateTranslation(double x, double y, double z)
        {
            Matrix4x3d result;
            CreateTranslation(x, y, z, out result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The resulting Matrix4dinstance.</returns>
        public static Matrix4x3d CreateTranslation(Vector3d vector)
        {
            Matrix4x3d result;
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
        public static Matrix4x3d CreateScale(double scale)
        {
            return CreateScale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix4x3d CreateScale(Vector3d scale)
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
        public static Matrix4x3d CreateScale(double x, double y, double z)
        {
            Matrix4x3d result;
            result.Row0.X = x;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = y;
            result.Row1.Z = 0;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row2.Z = z;
            result.Row3.X = 0;
            result.Row3.Y = 0;
            result.Row3.Z = 0;
            return result;
        }

        #endregion

        #region Multiply Functions

        /// <summary>
        /// This isn't quite a multiply, but the result may be useful in some situations.
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication</returns>
        public static Matrix4d Mult(Matrix4x3d left, Matrix3x4d right)
        {
            Matrix4d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// This isn't quite a multiply, but the result may be useful in some situations.
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Mult(ref Matrix4x3d left, ref Matrix3x4d right, out Matrix4d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z,
                lM31 = left.Row2.X, lM32 = left.Row2.Y, lM33 = left.Row2.Z,
                lM41 = left.Row3.X, lM42 = left.Row3.Y, lM43 = left.Row3.Z,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z, rM14 = right.Row0.W,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z, rM24 = right.Row1.W,
                rM31 = right.Row2.X, rM32 = right.Row2.Y, rM33 = right.Row2.Z, rM34 = right.Row2.W;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21) + (lM13 * rM31);
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22) + (lM13 * rM32);
            result.Row0.Z = (lM11 * rM13) + (lM12 * rM23) + (lM13 * rM33);
            result.Row0.W = (lM11 * rM14) + (lM12 * rM24) + (lM13 * rM34);
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21) + (lM23 * rM31);
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22) + (lM23 * rM32);
            result.Row1.Z = (lM21 * rM13) + (lM22 * rM23) + (lM23 * rM33);
            result.Row1.W = (lM21 * rM14) + (lM22 * rM24) + (lM23 * rM34);
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21) + (lM33 * rM31);
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22) + (lM33 * rM32);
            result.Row2.Z = (lM31 * rM13) + (lM32 * rM23) + (lM33 * rM33);
            result.Row2.W = (lM31 * rM14) + (lM32 * rM24) + (lM33 * rM34);
            result.Row3.X = (lM41 * rM11) + (lM42 * rM21) + (lM43 * rM31);
            result.Row3.Y = (lM41 * rM12) + (lM42 * rM22) + (lM43 * rM32);
            result.Row3.Z = (lM41 * rM13) + (lM42 * rM23) + (lM43 * rM33);
            result.Row3.W = (lM41 * rM14) + (lM42 * rM24) + (lM43 * rM34);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication</returns>
        public static Matrix4x3d Mult(Matrix4x3d left, Matrix4x3d right)
        {
            Matrix4x3d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Mult(ref Matrix4x3d left, ref Matrix4x3d right, out Matrix4x3d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z,
                lM31 = left.Row2.X, lM32 = left.Row2.Y, lM33 = left.Row2.Z,
                lM41 = left.Row3.X, lM42 = left.Row3.Y, lM43 = left.Row3.Z,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z,
                rM31 = right.Row2.X, rM32 = right.Row2.Y, rM33 = right.Row2.Z,
                rM41 = right.Row3.X, rM42 = right.Row3.Y, rM43 = right.Row3.Z;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21) + (lM13 * rM31) + rM41;
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22) + (lM13 * rM32) + rM42;
            result.Row0.Z = (lM11 * rM13) + (lM12 * rM23) + (lM13 * rM33) + rM43;
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21) + (lM23 * rM31) + rM41;
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22) + (lM23 * rM32) + rM42;
            result.Row1.Z = (lM21 * rM13) + (lM22 * rM23) + (lM23 * rM33) + rM43;
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21) + (lM33 * rM31) + rM41;
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22) + (lM33 * rM32) + rM42;
            result.Row2.Z = (lM31 * rM13) + (lM32 * rM23) + (lM33 * rM33) + rM43;
            result.Row3.X = (lM41 * rM11) + (lM42 * rM21) + (lM43 * rM31) + rM41;
            result.Row3.Y = (lM41 * rM12) + (lM42 * rM22) + (lM43 * rM32) + rM42;
            result.Row3.Z = (lM41 * rM13) + (lM42 * rM23) + (lM43 * rM33) + rM43;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication</returns>
        public static Matrix4x3d Mult(Matrix4x3d left, double right)
        {
            Matrix4x3d result;
            Mult(ref left, right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Mult(ref Matrix4x3d left, double right, out Matrix4x3d result)
        {
            result.Row0 = left.Row0 * right;
            result.Row1 = left.Row1 * right;
            result.Row2 = left.Row2 * right;
            result.Row3 = left.Row3 * right;
        }

        #endregion

        #region Add Functions

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        public static Matrix4x3d Add(Matrix4x3d left, Matrix4x3d right)
        {
            Matrix4x3d result;
            Add(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(ref Matrix4x3d left, ref Matrix4x3d right, out Matrix4x3d result)
        {
            result.Row0 = left.Row0 + right.Row0;
            result.Row1 = left.Row1 + right.Row1;
            result.Row2 = left.Row2 + right.Row2;
            result.Row3 = left.Row3 + right.Row3;
        }

        #endregion

        #region Subtract Functions

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <returns>A new instance that is the result of the subraction.</returns>
        public static Matrix4x3d Subtract(Matrix4x3d left, Matrix4x3d right)
        {
            Matrix4x3d result;
            Subtract(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <param name="result">A new instance that is the result of the subraction.</param>
        public static void Subtract(ref Matrix4x3d left, ref Matrix4x3d right, out Matrix4x3d result)
        {
            result.Row0 = left.Row0 - right.Row0;
            result.Row1 = left.Row1 - right.Row1;
            result.Row2 = left.Row2 - right.Row2;
            result.Row3 = left.Row3 - right.Row3;
        }

        #endregion

        #region Invert Functions

        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static Matrix4x3d Invert(Matrix4x3d mat)
        {
            Matrix4x3d result;
            Invert(ref mat, out result);
            return result;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <param name="result">The inverse of the given matrix if it has one, or the input if it is singular</param>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static void Invert(ref Matrix4x3d mat, out Matrix4x3d result)
        {
            Matrix3d inverseRotation = new Matrix3d(mat.Column0.Xyz, mat.Column1.Xyz, mat.Column2.Xyz);
            inverseRotation.Row0 /= inverseRotation.Row0.LengthSquared;
            inverseRotation.Row1 /= inverseRotation.Row1.LengthSquared;
            inverseRotation.Row2 /= inverseRotation.Row2.LengthSquared;

            Vector3d translation = mat.Row3;

            result.Row0 = inverseRotation.Row0;
            result.Row1 = inverseRotation.Row1;
            result.Row2 = inverseRotation.Row2;
            result.Row3 = new Vector3d(-Vector3d.Dot(inverseRotation.Row0, translation), -Vector3d.Dot(inverseRotation.Row1, translation), -Vector3d.Dot(inverseRotation.Row2, translation));
        }

        #endregion

        #region Transpose

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <returns>The transpose of the given matrix</returns>
        public static Matrix3x4d Transpose(Matrix4x3d mat)
        {
            return new Matrix3x4d(mat.Column0, mat.Column1, mat.Column2);
        }

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <param name="result">The result of the calculation</param>
        public static void Transpose(ref Matrix4x3d mat, out Matrix3x4d result)
        {
            result.Row0 = mat.Column0;
            result.Row1 = mat.Column1;
            result.Row2 = mat.Column2;
        }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix4d which holds the result of the multiplication</returns>
        public static Matrix4d operator *(Matrix4x3d left, Matrix3x4d right)
        {
            return Matrix4x3d.Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix4x3d which holds the result of the multiplication</returns>
        public static Matrix4x3d operator *(Matrix4x3d left, Matrix4x3d right)
        {
            return Matrix4x3d.Mult(left, right);
        }

        /// <summary>
        /// Matrix-scalar multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix4x3d which holds the result of the multiplication</returns>
        public static Matrix4x3d operator *(Matrix4x3d left, double right)
        {
            return Matrix4x3d.Mult(left, right);
        }

        /// <summary>
        /// Matrix addition
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix4x3d which holds the result of the addition</returns>
        public static Matrix4x3d operator +(Matrix4x3d left, Matrix4x3d right)
        {
            return Matrix4x3d.Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix4x3d which holds the result of the subtraction</returns>
        public static Matrix4x3d operator -(Matrix4x3d left, Matrix4x3d right)
        {
            return Matrix4x3d.Subtract(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Matrix4x3d left, Matrix4x3d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Matrix4x3d left, Matrix4x3d right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current Matrix4x3d.
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
            return Row0.GetHashCode() ^ Row1.GetHashCode() ^ Row2.GetHashCode();
        }

        #endregion

        #region public override bool Equals(object obj)

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare tresult.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix4x3d))
                return false;

            return this.Equals((Matrix4x3d)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Matrix4x3d> Members

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(Matrix4x3d other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1 &&
                Row2 == other.Row2 &&
                Row3 == other.Row3;
        }

        #endregion
    }
}
