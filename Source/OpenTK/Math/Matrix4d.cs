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

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a 4x4 Matrix with double-precision components.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4d : IEquatable<Matrix4d>
    {
        #region Fields

		/// <summary>
		/// Top row of the matrix
		/// </summary>
        public Vector4d  Row0;
		/// <summary>
		/// 2nd row of the matrix
		/// </summary>
        public Vector4d  Row1;
		/// <summary>
		/// 3rd row of the matrix
		/// </summary>
        public Vector4d  Row2;
		/// <summary>
		/// Bottom row of the matrix
		/// </summary>
        public Vector4d  Row3;
 
		/// <summary>
		/// The identity matrix
		/// </summary>
		public static Matrix4d Identity = new Matrix4d(Vector4d .UnitX, Vector4d .UnitY, Vector4d .UnitZ, Vector4d .UnitW);

        #endregion

        #region Constructors

		/// <summary>
		/// Construct a new matrix from 4 vectors representing each row.
		/// </summary>
		/// <param name="row0">Top row of the matrix</param>
		/// <param name="row1">2nd row of the matrix</param>
		/// <param name="row2">3rd row of the matrix</param>
		/// <param name="row3">Bottom row of the matrix</param>
		public Matrix4d(Vector4d row0, Vector4d row1, Vector4d row2, Vector4d row3)
		{
			Row0 = row0;
			Row1 = row1;
			Row2 = row2;
			Row3 = row3;
		}

        #endregion

        #region Public Members

        #region Properties

        /// <summary>
        /// The determinant of this matrix
        /// </summary>
        public double Determinant
        {
            get
            {
                return
                    Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W
                  + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W
                  - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z
                  + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y
                  + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y
                  - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;
            }
        }

        /// <summary>
        /// The first column of this matrix
        /// </summary>
        public Vector4d  Column0
        {
            get { return new Vector4d (Row0.X, Row1.X, Row2.X, Row3.X); }
        }

        /// <summary>
        /// The second column of this matrix
        /// </summary>
        public Vector4d  Column1
        {
            get { return new Vector4d (Row0.Y, Row1.Y, Row2.Y, Row3.Y); }
        }

        /// <summary>
        /// The third column of this matrix
        /// </summary>
        public Vector4d  Column2
        {
            get { return new Vector4d (Row0.Z, Row1.Z, Row2.Z, Row3.Z); }
        }

        /// <summary>
        /// The fourth column of this matrix
        /// </summary>
        public Vector4d  Column3
        {
            get { return new Vector4d (Row0.W, Row1.W, Row2.W, Row3.W); }
        }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i > 3)
                    throw new ArgumentOutOfRangeException("i");

                if (j < 0 || j > 3)
                    throw new ArgumentOutOfRangeException("j");

                unsafe
                {
                    fixed (Matrix4d* ptr = &this)
                        return *((double*)ptr + i + j * 4);
                }
            }
            set
            {
                if (i < 0 || i > 3)
                    throw new ArgumentOutOfRangeException("i");

                if (j < 0 || j > 3)
                    throw new ArgumentOutOfRangeException("j");

                unsafe
                {
                    fixed (Matrix4d* ptr = &this)
                        *((double*)ptr + i + j * 4) = value;
                }
            }
        }

        #endregion

        #region Instance

        #region public void Invert()

        public void Invert()
        {
            this = Matrix4d.Invert(this);
        }

        #endregion

        #region public void Transpose()

        public void Transpose()
        {
            this = Matrix4d.Transpose(this);
        }

        #endregion

        #endregion

        #region Static

        #region Scale Functions

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Single scale factor for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix4d Scale(double scale)
        {
            return Scale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix4d Scale(Vector3d scale)
        {
            return Scale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="x">Scale factor for x-axis</param>
        /// <param name="y">Scale factor for y-axis</param>
        /// <param name="z">Scale factor for z-axis</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix4d Scale(double x, double y, double z)
        {
            Matrix4d result;
            result.Row0 = Vector4d .UnitX * x;
            result.Row1 = Vector4d .UnitY * y;
            result.Row2 = Vector4d .UnitZ * z;
            result.Row3 = Vector4d .UnitW;
            return result;
        }

        #endregion

        #region Translation Functions

        /// <summary>
        /// Build a translation matrix with the given translation
        /// </summary>
        /// <param name="trans">The vector to translate along</param>
        /// <returns>A Translation matrix</returns>
        public static Matrix4d Translation(Vector3d trans)
        {
            return Translation(trans.X, trans.Y, trans.Z);
        }

        /// <summary>
        /// Build a translation matrix with the given translation
        /// </summary>
        /// <param name="x">X translation</param>
        /// <param name="y">Y translation</param>
        /// <param name="z">Z translation</param>
        /// <returns>A Translation matrix</returns>
        public static Matrix4d Translation(double x, double y, double z)
        {
            Matrix4d result = Identity;
            result.Row3 = new Vector4d (x, y, z, 1.0f);
            return result;
        }

        #endregion

        #region Rotation Functions

        /// <summary>
        /// Build a rotation matrix that rotates about the x-axis
        /// </summary>
        /// <param name="angle">angle in radians to rotate counter-clockwise around the x-axis</param>
        /// <returns>A rotation matrix</returns>
        public static Matrix4d RotateX(double angle)
        {
            double cos = (double)System.Math.Cos(angle);
            double sin = (double)System.Math.Sin(angle);

            Matrix4d result;
            result.Row0 = Vector4d .UnitX;
            result.Row1 = new Vector4d (0.0f, cos, sin, 0.0f);
            result.Row2 = new Vector4d (0.0f, -sin, cos, 0.0f);
            result.Row3 = Vector4d .UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix that rotates about the y-axis
        /// </summary>
        /// <param name="angle">angle in radians to rotate counter-clockwise around the y-axis</param>
        /// <returns>A rotation matrix</returns>
        public static Matrix4d RotateY(double angle)
        {
            double cos = (double)System.Math.Cos(angle);
            double sin = (double)System.Math.Sin(angle);

            Matrix4d result;
            result.Row0 = new Vector4d (cos, 0.0f, -sin, 0.0f);
            result.Row1 = Vector4d .UnitY;
            result.Row2 = new Vector4d (sin, 0.0f, cos, 0.0f);
            result.Row3 = Vector4d .UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix that rotates about the z-axis
        /// </summary>
        /// <param name="angle">angle in radians to rotate counter-clockwise around the z-axis</param>
        /// <returns>A rotation matrix</returns>
        public static Matrix4d RotateZ(double angle)
        {
            double cos = (double)System.Math.Cos(angle);
            double sin = (double)System.Math.Sin(angle);

            Matrix4d result;
            result.Row0 = new Vector4d (cos, sin, 0.0f, 0.0f);
            result.Row1 = new Vector4d (-sin, cos, 0.0f, 0.0f);
            result.Row2 = Vector4d .UnitZ;
            result.Row3 = Vector4d .UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix to rotate about the given axis
        /// </summary>
        /// <param name="axis">the axis to rotate about</param>
        /// <param name="angle">angle in radians to rotate counter-clockwise (looking in the direction of the given axis)</param>
        /// <returns>A rotation matrix</returns>
        public static Matrix4d Rotate(Vector3d axis, double angle)
        {
            double cos = (double)System.Math.Cos(-angle);
            double sin = (double)System.Math.Sin(-angle);
            double t = 1.0f - cos;

            axis.Normalize();

            Matrix4d result;
            result.Row0 = new Vector4d (t * axis.X * axis.X + cos, t * axis.X * axis.Y - sin * axis.Z, t * axis.X * axis.Z + sin * axis.Y, 0.0f);
            result.Row1 = new Vector4d (t * axis.X * axis.Y + sin * axis.Z, t * axis.Y * axis.Y + cos, t * axis.Y * axis.Z - sin * axis.X, 0.0f);
            result.Row2 = new Vector4d (t * axis.X * axis.Z - sin * axis.Y, t * axis.Y * axis.Z + sin * axis.X, t * axis.Z * axis.Z + cos, 0.0f);
            result.Row3 = Vector4d .UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix from a quaternion
        /// </summary>
        /// <param name="q">the quaternion</param>
        /// <returns>A rotation matrix</returns>
        public static Matrix4d Rotate(Quaterniond q)
        {
            Vector3d axis;
            double angle;
            q.ToAxisAngle(out axis, out angle);
            return Rotate(axis, angle);
        }

        #endregion

        #region Camera Helper Functions

        /// <summary>
        /// Build a world space to camera space matrix
        /// </summary>
        /// <param name="eye">Eye (camera) position in world space</param>
        /// <param name="target">Target position in world space</param>
        /// <param name="up">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <returns>A Matrix that transforms world space to camera space</returns>
        public static Matrix4d LookAt(Vector3d eye, Vector3d target, Vector3d up)
        {
            Vector3d z = Vector3d.Normalize(eye - target);
            Vector3d x = Vector3d.Normalize(Vector3d.Cross(up, z));
            Vector3d y = Vector3d.Normalize(Vector3d.Cross(z, x));

            Matrix4d rot = new Matrix4d(new Vector4d (x.X, y.X, z.X, 0.0f),
                                        new Vector4d (x.Y, y.Y, z.Y, 0.0f),
                                        new Vector4d (x.Z, y.Z, z.Z, 0.0f),
                                        Vector4d .UnitW);

            Matrix4d trans = Matrix4d.Translation(-eye);

            return trans * rot;
        }

        /// <summary>
        /// Build a projection matrix
        /// </summary>
        /// <param name="left">Left edge of the view frustum</param>
        /// <param name="right">Right edge of the view frustum</param>
        /// <param name="bottom">Bottom edge of the view frustum</param>
        /// <param name="top">Top edge of the view frustum</param>
        /// <param name="near">Distance to the near clip plane</param>
        /// <param name="far">Distance to the far clip plane</param>
        /// <returns>A projection matrix that transforms camera space to raster space</returns>
        public static Matrix4d Frustum(double left, double right, double bottom, double top, double near, double far)
        {
            double invRL = 1.0f / (right - left);
            double invTB = 1.0f / (top - bottom);
            double invFN = 1.0f / (far - near);
            return new Matrix4d(new Vector4d (2.0f * near * invRL, 0.0f, 0.0f, 0.0f),
                               new Vector4d (0.0f, 2.0f * near * invTB, 0.0f, 0.0f),
                               new Vector4d ((right + left) * invRL, (top + bottom) * invTB, -(far + near) * invFN, -1.0f),
                               new Vector4d (0.0f, 0.0f, -2.0f * far * near * invFN, 0.0f));
        }

        /// <summary>
        /// Build a projection matrix
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians)</param>
        /// <param name="aspect">Aspect ratio of the view (width / height)</param>
        /// <param name="near">Distance to the near clip plane</param>
        /// <param name="far">Distance to the far clip plane</param>
        /// <returns>A projection matrix that transforms camera space to raster space</returns>
        public static Matrix4d Perspective(double fovy, double aspect, double near, double far)
        {
            double yMax = near * (double)System.Math.Tan(0.5f * fovy);
            double yMin = -yMax;
            double xMin = yMin * aspect;
            double xMax = yMax * aspect;

            return Frustum(xMin, xMax, yMin, yMax, near, far);
        }

        #endregion

        #region Multiply Functions

        /// <summary>
        /// Post multiply this matrix by another matrix
        /// </summary>
        /// <param name="right">The matrix to multiply</param>
        /// <returns>A new Matrix44 that is the result of the multiplication</returns>
        public static Matrix4d Mult(Matrix4d left, Matrix4d right)
        {
            Vector4d  col0 = right.Column0;
            Vector4d  col1 = right.Column1;
            Vector4d  col2 = right.Column2;
            Vector4d  col3 = right.Column3;

            left.Row0 = new Vector4d (Vector4d .Dot(left.Row0, col0), Vector4d .Dot(left.Row0, col1), Vector4d .Dot(left.Row0, col2), Vector4d .Dot(left.Row0, col3));
            left.Row1 = new Vector4d (Vector4d .Dot(left.Row1, col0), Vector4d .Dot(left.Row1, col1), Vector4d .Dot(left.Row1, col2), Vector4d .Dot(left.Row1, col3));
            left.Row2 = new Vector4d (Vector4d .Dot(left.Row2, col0), Vector4d .Dot(left.Row2, col1), Vector4d .Dot(left.Row2, col2), Vector4d .Dot(left.Row2, col3));
            left.Row3 = new Vector4d (Vector4d .Dot(left.Row3, col0), Vector4d .Dot(left.Row3, col1), Vector4d .Dot(left.Row3, col2), Vector4d .Dot(left.Row3, col3));
            return left;
        }

        public static void Mult(ref Matrix4d left, ref Matrix4d right, out Matrix4d result)
        {
            Vector4d  col0 = right.Column0;
            Vector4d  col1 = right.Column1;
            Vector4d  col2 = right.Column2;
            Vector4d  col3 = right.Column3;

            result.Row0 = new Vector4d (Vector4d .Dot(left.Row0, col0), Vector4d .Dot(left.Row0, col1), Vector4d .Dot(left.Row0, col2), Vector4d .Dot(left.Row0, col3));
            result.Row1 = new Vector4d (Vector4d .Dot(left.Row1, col0), Vector4d .Dot(left.Row1, col1), Vector4d .Dot(left.Row1, col2), Vector4d .Dot(left.Row1, col3));
            result.Row2 = new Vector4d (Vector4d .Dot(left.Row2, col0), Vector4d .Dot(left.Row2, col1), Vector4d .Dot(left.Row2, col2), Vector4d .Dot(left.Row2, col3));
            result.Row3 = new Vector4d (Vector4d .Dot(left.Row3, col0), Vector4d .Dot(left.Row3, col1), Vector4d .Dot(left.Row3, col2), Vector4d .Dot(left.Row3, col3));
        }

        #endregion

        #region Invert Functions

        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4d is singular.</exception>
        public static Matrix4d Invert(Matrix4d mat)
        {
            int[] colIdx = { 0, 0, 0, 0 };
            int[] rowIdx = { 0, 0, 0, 0 };
            int[] pivotIdx = { -1, -1, -1, -1 };

            // convert the matrix to an array for easy looping
            double[,] inverse = {{mat.Row0.X, mat.Row0.Y, mat.Row0.Z, mat.Row0.W}, 
								{mat.Row1.X, mat.Row1.Y, mat.Row1.Z, mat.Row1.W}, 
								{mat.Row2.X, mat.Row2.Y, mat.Row2.Z, mat.Row2.W}, 
								{mat.Row3.X, mat.Row3.Y, mat.Row3.Z, mat.Row3.W} };
            int icol = 0;
            int irow = 0;
            for (int i = 0; i < 4; i++)
            {
                // Find the largest pivot value
                double maxPivot = 0.0f;
                for (int j = 0; j < 4; j++)
                {
                    if (pivotIdx[j] != 0)
                    {
                        for (int k = 0; k < 4; ++k)
                        {
                            if (pivotIdx[k] == -1)
                            {
                                double absVal = System.Math.Abs(inverse[j, k]);
                                if (absVal > maxPivot)
                                {
                                    maxPivot = absVal;
                                    irow = j;
                                    icol = k;
                                }
                            }
                            else if (pivotIdx[k] > 0)
                            {
                                return mat;
                            }
                        }
                    }
                }

                ++(pivotIdx[icol]);

                // Swap rows over so pivot is on diagonal
                if (irow != icol)
                {
                    for (int k = 0; k < 4; ++k)
                    {
                        double f = inverse[irow, k];
                        inverse[irow, k] = inverse[icol, k];
                        inverse[icol, k] = f;
                    }
                }

                rowIdx[i] = irow;
                colIdx[i] = icol;

                double pivot = inverse[icol, icol];
                // check for singular matrix
                if (pivot == 0.0f)
                {
                    throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
                    //return mat;
                }

                // Scale row so it has a unit diagonal
                double oneOverPivot = 1.0f / pivot;
                inverse[icol, icol] = 1.0f;
                for (int k = 0; k < 4; ++k)
                    inverse[icol, k] *= oneOverPivot;

                // Do elimination of non-diagonal elements
                for (int j = 0; j < 4; ++j)
                {
                    // check this isn't on the diagonal
                    if (icol != j)
                    {
                        double f = inverse[j, icol];
                        inverse[j, icol] = 0.0f;
                        for (int k = 0; k < 4; ++k)
                            inverse[j, k] -= inverse[icol, k] * f;
                    }
                }
            }

            for (int j = 3; j >= 0; --j)
            {
                int ir = rowIdx[j];
                int ic = colIdx[j];
                for (int k = 0; k < 4; ++k)
                {
                    double f = inverse[k, ir];
                    inverse[k, ir] = inverse[k, ic];
                    inverse[k, ic] = f;
                }
            }

            mat.Row0 = new Vector4d (inverse[0, 0], inverse[0, 1], inverse[0, 2], inverse[0, 3]);
            mat.Row1 = new Vector4d (inverse[1, 0], inverse[1, 1], inverse[1, 2], inverse[1, 3]);
            mat.Row2 = new Vector4d (inverse[2, 0], inverse[2, 1], inverse[2, 2], inverse[2, 3]);
            mat.Row3 = new Vector4d (inverse[3, 0], inverse[3, 1], inverse[3, 2], inverse[3, 3]);
            return mat;
        }

        #endregion

        #region Transpose

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <returns>The transpose of the given matrix</returns>
        public static Matrix4d Transpose(Matrix4d mat)
        {
            return new Matrix4d(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
        }


        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        public static void Transpose(ref Matrix4d mat, out Matrix4d result)
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
        /// <returns>A new Matrix44 which holds the result of the multiplication</returns>
        public static Matrix4d operator *(Matrix4d left, Matrix4d right)
        {
            return Matrix4d.Mult(left, right);
        }

        public static bool operator ==(Matrix4d left, Matrix4d right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Matrix4d left, Matrix4d right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current Matrix44.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n{3}", Row0, Row1, Row2, Row3);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return Row0.GetHashCode() ^ Row1.GetHashCode() ^ Row2.GetHashCode() ^ Row3.GetHashCode();
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
            if (!(obj is Matrix4d))
                return false;

            return this.Equals((Matrix4d)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Matrix4d> Members

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="matrix">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(Matrix4d other)
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