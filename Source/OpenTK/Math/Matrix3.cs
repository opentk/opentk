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
    /// Represents a 3x3 Matrix
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3 : IEquatable<Matrix3>
    {
        #region Fields
        
        /// <summary>
        /// First row of the matrix.
        /// </summary>
        public Vector3 Row0;
        
        /// <summary>
        /// Second row of the matrix.
        /// </summary>
        public Vector3 Row1;
        
        /// <summary>
        /// Third row of the matrix.
        /// </summary>
        public Vector3 Row2;
        
        /// <summary>
        /// The identity matrix.
        /// </summary>
        public static readonly Matrix3 Identity = new Matrix3(Vector3.UnitX, Vector3.UnitY, Vector3.UnitZ);

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix3 Zero = new Matrix3(Vector3.Zero, Vector3.Zero, Vector3.Zero);
        
        #endregion
        
        #region Constructors
        
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="row0">Top row of the matrix</param>
        /// <param name="row1">Second row of the matrix</param>
        /// <param name="row2">Bottom row of the matrix</param>
        public Matrix3(Vector3 row0, Vector3 row1, Vector3 row2)
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
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m12">Third item of the second row of the matrix.</param>
        /// <param name="m20">First item of the third row of the matrix.</param>
        /// <param name="m21">Second item of the third row of the matrix.</param>
        /// <param name="m22">Third item of the third row of the matrix.</param>
        public Matrix3(
            float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            Row0 = new Vector3(m00, m01, m02);
            Row1 = new Vector3(m10, m11, m12);
            Row2 = new Vector3(m20, m21, m22);
        }
        
        #endregion
        
        #region Public Members
        
        #region Properties
        
        /// <summary>
        /// Gets the determinant of this matrix.
        /// </summary>
        public float Determinant
        {
            get
            {
                float m11 = Row0.X, m12 = Row0.Y, m13 = Row0.Z,
                m21 = Row1.X, m22 = Row1.Y, m23 = Row1.Z,
                m31 = Row2.X, m32 = Row2.Y, m33 = Row2.Z;
                
                return m11 * m22 * m33 + m12 * m23 * m31 + m13 * m21 * m32
                     - m13 * m22 * m31 - m11 * m23 * m32 - m12 * m21 * m33;
            }
        }
        
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
                throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
            }
        }

        #endregion

        #region Instance

        #region public void Invert()

        public void Invert()
        {
            this = Matrix3.Invert(this);
        }
        
        #endregion
        
        #region public void Transpose()
        
        public void Transpose()
        {
            this = Matrix3.Transpose(this);
        }
        
        #endregion
        
        #endregion
        
        #region Static
        
        #region CreateFromAxisAngle
        
        public static void CreateFromAxisAngle(Vector3 axis, float angle, out Matrix3 result)
        {
            //normalize and create a local copy of the vector.
            axis.Normalize();
            float axisX = axis.X, axisY = axis.Y, axisZ = axis.Z;
            
            //calculate angles
            float cos = (float)System.Math.Cos(-angle);
            float sin = (float)System.Math.Sin(-angle);
            float t = 1.0f - cos;
            
            //do the conversion math once
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
            result.Row1.X = tXY + sinZ;
            result.Row1.Y = tYY + cos;
            result.Row1.Z = tYZ - sinX;
            result.Row2.X = tXZ - sinY;
            result.Row2.Y = tYZ + sinX;
            result.Row2.Z = tZZ + cos;
        }
        
        public static Matrix3 CreateFromAxisAngle(Vector3 axis, float angle)
        {
            Matrix3 result;
            CreateFromAxisAngle(axis, angle, out result);
            return result;
        }
        
        #endregion
        
        #region CreateFromQuaternion
        
        public static void CreateFromQuaternion(ref Quaternion q, out Matrix3 result)
        {
            Vector3 axis;
            float angle;
            q.ToAxisAngle(out axis, out angle);
            CreateFromAxisAngle(axis, angle, out result);
        }
        
        public static Matrix3 CreateFromQuaternion(Quaternion q)
        {
            Matrix3 result;
            CreateFromQuaternion(ref q, out result);
            return result;
        }
        
        #endregion
        
        #region CreateRotation[XYZ]
        
        public static void CreateRotationX(float angle, out Matrix3 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);
            
            result = Identity;
            result.Row1.Y = cos;
            result.Row1.Z = sin;
            result.Row2.Y = -sin;
            result.Row2.Z = cos;
        }
        
        public static Matrix3 CreateRotationX(float angle)
        {
            Matrix3 result;
            CreateRotationX(angle, out result);
            return result;
        }
        
        public static void CreateRotationY(float angle, out Matrix3 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);
            
            result = Identity;
            result.Row0.X = cos;
            result.Row0.Z = -sin;
            result.Row2.X = sin;
            result.Row2.Z = cos;
        }
        
        public static Matrix3 CreateRotationY(float angle)
        {
            Matrix3 result;
            CreateRotationY(angle, out result);
            return result;
        }
        
        public static void CreateRotationZ(float angle, out Matrix3 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);
            
            result = Identity;
            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
        }
        
        public static Matrix3 CreateRotationZ(float angle)
        {
            Matrix3 result;
            CreateRotationZ(angle, out result);
            return result;
        }
        
        #endregion
        
        #region CreateScale
        
        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix3 CreateScale(float scale)
        {
            Matrix3 result;
            CreateScale(scale, out result);
            return result;
        }
        
        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x, y, and z axes.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix3 CreateScale(Vector3 scale)
        {
            Matrix3 result;
            CreateScale(ref scale, out result);
            return result;
        }
        
        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="z">Scale factor for the z axis.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix3 CreateScale(float x, float y, float z)
        {
            Matrix3 result;
            CreateScale(x, y, z, out result);
            return result;
        }
        
        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float scale, out Matrix3 result)
        {
            result = Identity;
            result.Row0.X = scale;
            result.Row1.Y = scale;
            result.Row2.Z = scale;
        }
        
        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(ref Vector3 scale, out Matrix3 result)
        {
            result = Identity;
            result.Row0.X = scale.X;
            result.Row1.Y = scale.Y;
            result.Row2.Z = scale.Z;
        }
        
        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="z">Scale factor for the z axis.</param>
        /// <param name="result">A scale matrix.</returns>
        public static void CreateScale(float x, float y, float z, out Matrix3 result)
        {
            result = Identity;
            result.Row0.X = x;
            result.Row1.Y = y;
            result.Row2.Z = z;
        }
        
        #endregion
        
        #region Multiply Functions
        
        public static Matrix3 Mult(Matrix3 left, Matrix3 right)
        {
            Matrix3 result;
            Mult(ref left, ref right, out result);
            return result;
        }
        
        public static void Mult(ref Matrix3 left, ref Matrix3 right, out Matrix3 result)
        {
            float   lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z,
            lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z,
            lM31 = left.Row2.X, lM32 = left.Row2.Y, lM33 = left.Row2.Z,
            rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z,
            rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z,
            rM31 = right.Row2.X, rM32 = right.Row2.Y, rM33 = right.Row2.Z;
            
            result.Row0.X = ((lM11 * rM11) + (lM12 * rM21)) + (lM13 * rM31);
            result.Row0.Y = ((lM11 * rM12) + (lM12 * rM22)) + (lM13 * rM32);
            result.Row0.Z = ((lM11 * rM13) + (lM12 * rM23)) + (lM13 * rM33);
            result.Row1.X = ((lM21 * rM11) + (lM22 * rM21)) + (lM23 * rM31);
            result.Row1.Y = ((lM21 * rM12) + (lM22 * rM22)) + (lM23 * rM32);
            result.Row1.Z = ((lM21 * rM13) + (lM22 * rM23)) + (lM23 * rM33);
            result.Row2.X = ((lM31 * rM11) + (lM32 * rM21)) + (lM33 * rM31);
            result.Row2.Y = ((lM31 * rM12) + (lM32 * rM22)) + (lM33 * rM32);
            result.Row2.Z = ((lM31 * rM13) + (lM32 * rM23)) + (lM33 * rM33);
        }
        
        #endregion
        
        #region Invert Functions
        
        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <param name="result">The inverse of the given matrix if it has one, or the input if it is singular</param>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix3 is singular.</exception>
        public static void Invert(ref Matrix3 mat, out Matrix3 result)
        {
            int[] colIdx = { 0, 0, 0 };
            int[] rowIdx = { 0, 0, 0 };
            int[] pivotIdx = { -1, -1, -1 };
            
            float[,] inverse = {{mat.Row0.X, mat.Row0.Y, mat.Row0.Z},
                {mat.Row1.X, mat.Row1.Y, mat.Row1.Z},
                {mat.Row2.X, mat.Row2.Y, mat.Row2.Z}};
            
            int icol = 0;
            int irow = 0;
            for (int i = 0; i < 3; i++)
            {
                float maxPivot = 0.0f;
                for (int j = 0; j < 3; j++)
                {
                    if (pivotIdx[j] != 0)
                    {
                        for (int k = 0; k < 3; ++k)
                        {
                            if (pivotIdx[k] == -1)
                            {
                                float absVal = System.Math.Abs(inverse[j, k]);
                                if (absVal > maxPivot)
                                {
                                    maxPivot = absVal;
                                    irow = j;
                                    icol = k;
                                }
                            }
                            else if (pivotIdx[k] > 0)
                            {
                                result = mat;
                                return;
                            }
                        }
                    }
                }
                
                ++(pivotIdx[icol]);
                
                if (irow != icol)
                {
                    for (int k = 0; k < 3; ++k)
                    {
                        float f = inverse[irow, k];
                        inverse[irow, k] = inverse[icol, k];
                        inverse[icol, k] = f;
                    }
                }
                
                rowIdx[i] = irow;
                colIdx[i] = icol;
                
                float pivot = inverse[icol, icol];
                
                if (pivot == 0.0f)
                {
                    throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
                }
                
                float oneOverPivot = 1.0f / pivot;
                inverse[icol, icol] = 1.0f;
                for (int k = 0; k < 3; ++k)
                    inverse[icol, k] *= oneOverPivot;
                
                for (int j = 0; j < 3; ++j)
                {
                    if (icol != j)
                    {
                        float f = inverse[j, icol];
                        inverse[j, icol] = 0.0f;
                        for (int k = 0; k < 3; ++k)
                            inverse[j, k] -= inverse[icol, k] * f;
                    }
                }
            }
            
            for (int j = 2; j >= 0; --j)
            {
                int ir = rowIdx[j];
                int ic = colIdx[j];
                for (int k = 0; k < 3; ++k)
                {
                    float f = inverse[k, ir];
                    inverse[k, ir] = inverse[k, ic];
                    inverse[k, ic] = f;
                }
            }
            
            result.Row0.X = inverse[0, 0];
            result.Row0.Y = inverse[0, 1];
            result.Row0.Z = inverse[0, 2];
            result.Row1.X = inverse[1, 0];
            result.Row1.Y = inverse[1, 1];
            result.Row1.Z = inverse[1, 2];
            result.Row2.X = inverse[2, 0];
            result.Row2.Y = inverse[2, 1];
            result.Row2.Z = inverse[2, 2];
        }
        
        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static Matrix3 Invert(Matrix3 mat)
        {
            Matrix3 result;
            Invert(ref mat, out result);
            return result;
        }
        
        #endregion
        
        #region Transpose
        
        public static Matrix3 Transpose(Matrix3 mat)
        {
            return new Matrix3(mat.Column0, mat.Column1, mat.Column2);
        }
        
        public static void Transpose(ref Matrix3 mat, out Matrix3 result)
        {
            result.Row0.X = mat.Row0.X;
            result.Row0.Y = mat.Row1.X;
            result.Row0.Z = mat.Row2.X;
            result.Row1.X = mat.Row0.Y;
            result.Row1.Y = mat.Row1.Y;
            result.Row1.Z = mat.Row2.Y;
            result.Row2.X = mat.Row0.Z;
            result.Row2.Y = mat.Row1.Z;
            result.Row2.Z = mat.Row2.Z;
        }
        
        #endregion
        
        #endregion
        
        #region Operators
        
        public static Matrix3 operator *(Matrix3 left, Matrix3 right)
        {
            return Matrix3.Mult(left, right);
        }
        
        public static bool operator ==(Matrix3 left, Matrix3 right)
        {
            return left.Equals(right);
        }
        
        public static bool operator !=(Matrix3 left, Matrix3 right)
        {
            return !left.Equals(right);
        }
        
        #endregion
        
        #region Overrides
        
        #region public override string ToString()
        
        /// <summary>
        /// Returns a System.String that represents the current Matrix3d.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}", Row0, Row1, Row2);
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
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix3))
                return false;
            
            return this.Equals((Matrix3)obj);
        }
        
        #endregion
        
        #endregion
        
        #endregion
        
        #region IEquatable<Matrix3> Members
        
        public bool Equals(Matrix3 other)
        {
            return
                Row0 == other.Row0 &&
                    Row1 == other.Row1 &&
                    Row2 == other.Row2;
        }
        
        #endregion
    }
}