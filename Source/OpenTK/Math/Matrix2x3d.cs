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
using System.Collections.Generic;

namespace OpenTK
{
    /// <summary>
    /// Represents a 2x3 matrix.
    /// </summary>
    public struct Matrix2x3d : IEquatable<Matrix2x3d>
    {
        #region Fields

        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector3d Row0;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector3d Row1;

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix2x3d Zero = new Matrix2x3d(Vector3d.Zero, Vector3d.Zero);

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Bottom row of the matrix.</param>
        public Matrix2x3d(Vector3d row0, Vector3d row1)
        {
            Row0 = row0;
            Row1 = row1;
        }

        /// <summary>
        /// Constructs a new instance
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m02">Third item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m12">Third item of the second row of the matrix.</param>
        public Matrix2x3d(
            double m00, double m01, double m02,
            double m10, double m11, double m12)
        {
            Row0 = new Vector3d(m00, m01, m02);
            Row1 = new Vector3d(m10, m11, m12);
        }

        #endregion

        #region Public Members

        #region Properties

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector2d Column0
        {
            get { return new Vector2d(Row0.X, Row1.X); }
            set { Row0.X = value.X; Row1.X = value.Y; }
        }

        /// <summary>
        /// Gets or sets the second column of this matrix.
        /// </summary>
        public Vector2d Column1
        {
            get { return new Vector2d(Row0.Y, Row1.Y); }
            set { Row0.Y = value.X; Row1.Y = value.Y; }
        }

        /// <summary>
        /// Gets or sets the third column of this matrix.
        /// </summary>
        public Vector2d Column2
        {
            get { return new Vector2d(Row0.Z, Row1.Z); }
            set { Row0.Z = value.X; Row1.Z = value.Y; }
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
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector2d Diagonal
        {
            get
            {
                return new Vector2d(Row0.X, Row1.Y);
            }
            set
            {
                Row0.X = value.X;
                Row1.Y = value.Y;
            }
        }

        /// <summary>
        /// Gets the trace of the matrix, the sum of the values along the diagonal.
        /// </summary>
        public double Trace { get { return Row0.X + Row1.Y; } }

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
                throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")");
            }
            set
            {
                if (rowIndex == 0) Row0[columnIndex] = value;
                else if (rowIndex == 1) Row1[columnIndex] = value;
                else throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
            }
        }

        #endregion

        #region Instance
        #endregion

        #region Static

        #region CreateRotation

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix2x3d instance.</param>
        public static void CreateRotation(double angle, out Matrix2x3d result)
        {
            double cos = System.Math.Cos(angle);
            double sin = System.Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row0.Z = 0;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
            result.Row1.Z = 0;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix2x3d instance.</returns>
        public static Matrix2x3d CreateRotation(double angle)
        {
            Matrix2x3d result;
            CreateRotation(angle, out result);
            return result;
        }

        #endregion

        #region CreateScale

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double scale, out Matrix2x3d result)
        {
            result.Row0.X = scale;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale;
            result.Row1.Z = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix2x3d CreateScale(double scale)
        {
            Matrix2x3d result;
            CreateScale(scale, out result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(Vector2d scale, out Matrix2x3d result)
        {
            result.Row0.X = scale.X;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale.Y;
            result.Row1.Z = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix2x3d CreateScale(Vector2d scale)
        {
            Matrix2x3d result;
            CreateScale(scale, out result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double x, double y, out Matrix2x3d result)
        {
            result.Row0.X = x;
            result.Row0.Y = 0;
            result.Row0.Z = 0;
            result.Row1.X = 0;
            result.Row1.Y = y;
            result.Row1.Z = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix2x3d CreateScale(double x, double y)
        {
            Matrix2x3d result;
            CreateScale(x, y, out result);
            return result;
        }

        #endregion

        #region Multiply Functions

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix2x3d left, double right, out Matrix2x3d result)
        {
            result.Row0.X = left.Row0.X * right;
            result.Row0.Y = left.Row0.Y * right;
            result.Row0.Z = left.Row0.Z * right;
            result.Row1.X = left.Row1.X * right;
            result.Row1.Y = left.Row1.Y * right;
            result.Row1.Z = left.Row1.Z * right;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix2x3d Mult(Matrix2x3d left, double right)
        {
            Matrix2x3d result;
            Mult(ref left, right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix2x3d left, ref Matrix3x2 right, out Matrix2d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z,
                rM11 = right.Row0.X, rM12 = right.Row0.Y,
                rM21 = right.Row1.X, rM22 = right.Row1.Y,
                rM31 = right.Row2.X, rM32 = right.Row2.Y;

            result.Row0.X = ((lM11 * rM11) + (lM12 * rM21)) + (lM13 * rM31);
            result.Row0.Y = ((lM11 * rM12) + (lM12 * rM22)) + (lM13 * rM32);
            result.Row1.X = ((lM21 * rM11) + (lM22 * rM21)) + (lM23 * rM31);
            result.Row1.Y = ((lM21 * rM12) + (lM22 * rM22)) + (lM23 * rM32);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix2d Mult(Matrix2x3d left, Matrix3x2 right)
        {
            Matrix2d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix2x3d left, ref Matrix3 right, out Matrix2x3d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z,
                rM31 = right.Row2.X, rm32 = right.Row2.Y, rM33 = right.Row2.Z;

            result.Row0.X = ((lM11 * rM11) + (lM12 * rM21)) + (lM13 * rM31);
            result.Row0.Y = ((lM11 * rM12) + (lM12 * rM22)) + (lM13 * rm32);
            result.Row0.Z = ((lM11 * rM13) + (lM12 * rM23)) + (lM13 * rM33);
            result.Row1.X = ((lM21 * rM11) + (lM22 * rM21)) + (lM23 * rM31);
            result.Row1.Y = ((lM21 * rM12) + (lM22 * rM22)) + (lM23 * rm32);
            result.Row1.Z = ((lM21 * rM13) + (lM22 * rM23)) + (lM23 * rM33);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix2x3d Mult(Matrix2x3d left, Matrix3 right)
        {
            Matrix2x3d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix2x3d left, ref Matrix3x4 right, out Matrix2x4d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y, lM13 = left.Row0.Z,
                lM21 = left.Row1.X, lM22 = left.Row1.Y, lM23 = left.Row1.Z,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z, rM14 = right.Row0.W,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z, rM24 = right.Row1.W,
                rM31 = right.Row2.X, rm32 = right.Row2.Y, rM33 = right.Row2.Z, rM34 = right.Row2.W;

            result.Row0.X = ((lM11 * rM11) + (lM12 * rM21)) + (lM13 * rM31);
            result.Row0.Y = ((lM11 * rM12) + (lM12 * rM22)) + (lM13 * rm32);
            result.Row0.Z = ((lM11 * rM13) + (lM12 * rM23)) + (lM13 * rM33);
            result.Row0.W = ((lM11 * rM14) + (lM12 * rM24)) + (lM13 * rM34);
            result.Row1.X = ((lM21 * rM11) + (lM22 * rM21)) + (lM23 * rM31);
            result.Row1.Y = ((lM21 * rM12) + (lM22 * rM22)) + (lM23 * rm32);
            result.Row1.Z = ((lM21 * rM13) + (lM22 * rM23)) + (lM23 * rM33);
            result.Row1.W = ((lM21 * rM14) + (lM22 * rM24)) + (lM23 * rM34);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix2x4d Mult(Matrix2x3d left, Matrix3x4 right)
        {
            Matrix2x4d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        #endregion

        #region Add

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(ref Matrix2x3d left, ref Matrix2x3d right, out Matrix2x3d result)
        {
            result.Row0.X = left.Row0.X + right.Row0.X;
            result.Row0.Y = left.Row0.Y + right.Row0.Y;
            result.Row0.Z = left.Row0.Z + right.Row0.Z;
            result.Row1.X = left.Row1.X + right.Row1.X;
            result.Row1.Y = left.Row1.Y + right.Row1.Y;
            result.Row1.Z = left.Row1.Z + right.Row1.Z;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        public static Matrix2x3d Add(Matrix2x3d left, Matrix2x3d right)
        {
            Matrix2x3d result;
            Add(ref left, ref right, out result);
            return result;
        }

        #endregion

        #region Subtract

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <param name="result">A new instance that is the result of the subtraction.</param>
        public static void Subtract(ref Matrix2x3d left, ref Matrix2x3d right, out Matrix2x3d result)
        {
            result.Row0.X = left.Row0.X - right.Row0.X;
            result.Row0.Y = left.Row0.Y - right.Row0.Y;
            result.Row0.Z = left.Row0.Z - right.Row0.Z;
            result.Row1.X = left.Row1.X - right.Row1.X;
            result.Row1.Y = left.Row1.Y - right.Row1.Y;
            result.Row1.Z = left.Row1.Z - right.Row1.Z;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new instance that is the result of the subtraction.</returns>
        public static Matrix2x3d Subtract(Matrix2x3d left, Matrix2x3d right)
        {
            Matrix2x3d result;
            Subtract(ref left, ref right, out result);
            return result;
        }

        #endregion

        #region Transpose

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The transpose of the given matrix.</param>
        public static void Transpose(ref Matrix2x3d mat, out Matrix3x2d result)
        {
            result.Row0.X = mat.Row0.X;
            result.Row0.Y = mat.Row1.X;
            result.Row1.X = mat.Row0.Y;
            result.Row1.Y = mat.Row1.Y;
            result.Row2.X = mat.Row0.Z;
            result.Row2.Y = mat.Row1.Z;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <returns>The transpose of the given matrix.</returns>
        public static Matrix3x2d Transpose(Matrix2x3d mat)
        {
            Matrix3x2d result;
            Transpose(ref mat, out result);
            return result;
        }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2x3d which holds the result of the multiplication</returns>
        public static Matrix2x3d operator *(double left, Matrix2x3d right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2x3d which holds the result of the multiplication</returns>
        public static Matrix2x3d operator *(Matrix2x3d left, double right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2d which holds the result of the multiplication</returns>
        public static Matrix2d operator *(Matrix2x3d left, Matrix3x2 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2x3d which holds the result of the multiplication</returns>
        public static Matrix2x3d operator *(Matrix2x3d left, Matrix3 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2x4d which holds the result of the multiplication</returns>
        public static Matrix2x4d operator *(Matrix2x3d left, Matrix3x4 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2x3d which holds the result of the addition</returns>
        public static Matrix2x3d operator +(Matrix2x3d left, Matrix2x3d right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix2x3d which holds the result of the subtraction</returns>
        public static Matrix2x3d operator -(Matrix2x3d left, Matrix2x3d right)
        {
            return Subtract(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Matrix2x3d left, Matrix2x3d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Matrix2x3d left, Matrix2x3d right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current Matrix2x3d.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override string ToString()
        {
            return String.Format("{0}\n{1}", Row0, Row1);
        }

        #endregion

        #region public override int GetHashCode()

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            return Row0.GetHashCode() ^ Row1.GetHashCode();
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
            if (!(obj is Matrix2x3d))
                return false;

            return this.Equals((Matrix2x3d)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Matrix2x3d> Members

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(Matrix2x3d other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1;
        }

        #endregion
    }
}
