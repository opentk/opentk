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
    /// Represents a 3x2 matrix.
    /// </summary>
    public struct Matrix3x2d : IEquatable<Matrix3x2d>
    {
        #region Fields

        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector2d Row0;

        /// <summary>
        /// Second row of the matrix.
        /// </summary>
        public Vector2d Row1;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector2d Row2;

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix3x2d Zero = new Matrix3x2d(Vector2d.Zero, Vector2d.Zero, Vector2d.Zero);

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Second row of the matrix.</param>
        /// <param name="row2">Bottom row of the matrix.</param>
        public Matrix3x2d(Vector2d row0, Vector2d row1, Vector2d row2)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
        }

        /// <summary>
        /// Constructs a new instance
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m20">First item of the third row of the matrix.</param>
        /// <param name="m21">Second item of the third row of the matrix.</param>
        public Matrix3x2d(
            double m00, double m01,
            double m10, double m11,
            double m20, double m21)
        {
            Row0 = new Vector2d(m00, m01);
            Row1 = new Vector2d(m10, m11);
            Row2 = new Vector2d(m20, m21);
        }

        #endregion

        #region Public Members

        #region Properties

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector3d Column0
        {
            get { return new Vector3d(Row0.X, Row1.X, Row2.X); }
            set { Row0.X = value.X; Row1.X = value.Y; Row2.X = value.Z; }
        }

        /// <summary>
        /// Gets or sets the second column of this matrix.
        /// </summary>
        public Vector3d Column1
        {
            get { return new Vector3d(Row0.Y, Row1.Y, Row2.Y); }
            set { Row0.Y = value.X; Row1.Y = value.Y; Row2.Y = value.Z; }
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
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public double M21 { get { return Row1.X; } set { Row1.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public double M22 { get { return Row1.Y; } set { Row1.Y = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public double M31 { get { return Row2.X; } set { Row2.X = value; } }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public double M32 { get { return Row2.Y; } set { Row2.Y = value; } }

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
        #endregion

        #region Static

        #region CreateRotation

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix3x2d instance.</param>
        public static void CreateRotation(double angle, out Matrix3x2d result)
        {
            double cos = System.Math.Cos(angle);
            double sin = System.Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
            result.Row2.X = 0;
            result.Row2.Y = 0;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix3x2d instance.</returns>
        public static Matrix3x2d CreateRotation(double angle)
        {
            Matrix3x2d result;
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
        public static void CreateScale(double scale, out Matrix3x2d result)
        {
            result.Row0.X = scale;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale;
            result.Row2.X = 0;
            result.Row2.Y = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix3x2d CreateScale(double scale)
        {
            Matrix3x2d result;
            CreateScale(scale, out result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(Vector2d scale, out Matrix3x2d result)
        {
            result.Row0.X = scale.X;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale.Y;
            result.Row2.X = 0;
            result.Row2.Y = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix3x2d CreateScale(Vector2d scale)
        {
            Matrix3x2d result;
            CreateScale(scale, out result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double x, double y, out Matrix3x2d result)
        {
            result.Row0.X = x;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = y;
            result.Row2.X = 0;
            result.Row2.Y = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <returns>A scale matrix.</returns>
        public static Matrix3x2d CreateScale(double x, double y)
        {
            Matrix3x2d result;
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
        public static void Mult(ref Matrix3x2d left, double right, out Matrix3x2d result)
        {
            result.Row0.X = left.Row0.X * right;
            result.Row0.Y = left.Row0.Y * right;
            result.Row1.X = left.Row1.X * right;
            result.Row1.Y = left.Row1.Y * right;
            result.Row2.X = left.Row2.X * right;
            result.Row2.Y = left.Row2.Y * right;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix3x2d Mult(Matrix3x2d left, double right)
        {
            Matrix3x2d result;
            Mult(ref left, right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix3x2d left, ref Matrix2d right, out Matrix3x2d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y,
                lM21 = left.Row1.X, lM22 = left.Row1.Y,
                lM31 = left.Row2.X, lM32 = left.Row2.Y,
                rM11 = right.Row0.X, rM12 = right.Row0.Y,
                rM21 = right.Row1.X, rM22 = right.Row1.Y;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21);
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22);
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21);
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22);
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21);
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix3x2d Mult(Matrix3x2d left, Matrix2d right)
        {
            Matrix3x2d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix3x2d left, ref Matrix2x3d right, out Matrix3d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y,
                lM21 = left.Row1.X, lM22 = left.Row1.Y,
                lM31 = left.Row2.X, lM32 = left.Row2.Y,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21);
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22);
            result.Row0.Z = (lM11 * rM13) + (lM12 * rM23);
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21);
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22);
            result.Row1.Z = (lM21 * rM13) + (lM22 * rM23);
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21);
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22);
            result.Row2.Z = (lM31 * rM13) + (lM32 * rM23);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix3d Mult(Matrix3x2d left, Matrix2x3d right)
        {
            Matrix3d result;
            Mult(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(ref Matrix3x2d left, ref Matrix2x4d right, out Matrix3x4d result)
        {
            double lM11 = left.Row0.X, lM12 = left.Row0.Y,
                lM21 = left.Row1.X, lM22 = left.Row1.Y,
                lM31 = left.Row2.X, lM32 = left.Row2.Y,
                rM11 = right.Row0.X, rM12 = right.Row0.Y, rM13 = right.Row0.Z, rM14 = right.Row0.W,
                rM21 = right.Row1.X, rM22 = right.Row1.Y, rM23 = right.Row1.Z, rM24 = right.Row1.W;

            result.Row0.X = (lM11 * rM11) + (lM12 * rM21);
            result.Row0.Y = (lM11 * rM12) + (lM12 * rM22);
            result.Row0.Z = (lM11 * rM13) + (lM12 * rM23);
            result.Row0.W = (lM11 * rM14) + (lM12 * rM24);
            result.Row1.X = (lM21 * rM11) + (lM22 * rM21);
            result.Row1.Y = (lM21 * rM12) + (lM22 * rM22);
            result.Row1.Z = (lM21 * rM13) + (lM22 * rM23);
            result.Row1.W = (lM21 * rM14) + (lM22 * rM24);
            result.Row2.X = (lM31 * rM11) + (lM32 * rM21);
            result.Row2.Y = (lM31 * rM12) + (lM32 * rM22);
            result.Row2.Z = (lM31 * rM13) + (lM32 * rM23);
            result.Row2.W = (lM31 * rM14) + (lM32 * rM24);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        public static Matrix3x4d Mult(Matrix3x2d left, Matrix2x4d right)
        {
            Matrix3x4d result;
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
        public static void Add(ref Matrix3x2d left, ref Matrix3x2d right, out Matrix3x2d result)
        {
            result.Row0.X = left.Row0.X + right.Row0.X;
            result.Row0.Y = left.Row0.Y + right.Row0.Y;
            result.Row1.X = left.Row1.X + right.Row1.X;
            result.Row1.Y = left.Row1.Y + right.Row1.Y;
            result.Row2.X = left.Row2.X + right.Row2.X;
            result.Row2.Y = left.Row2.Y + right.Row2.Y;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        public static Matrix3x2d Add(Matrix3x2d left, Matrix3x2d right)
        {
            Matrix3x2d result;
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
        public static void Subtract(ref Matrix3x2d left, ref Matrix3x2d right, out Matrix3x2d result)
        {
            result.Row0.X = left.Row0.X - right.Row0.X;
            result.Row0.Y = left.Row0.Y - right.Row0.Y;
            result.Row1.X = left.Row1.X - right.Row1.X;
            result.Row1.Y = left.Row1.Y - right.Row1.Y;
            result.Row2.X = left.Row2.X - right.Row2.X;
            result.Row2.Y = left.Row2.Y - right.Row2.Y;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new instance that is the result of the subtraction.</returns>
        public static Matrix3x2d Subtract(Matrix3x2d left, Matrix3x2d right)
        {
            Matrix3x2d result;
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
        public static void Transpose(ref Matrix3x2d mat, out Matrix2x3d result)
        {
            result.Row0.X = mat.Row0.X;
            result.Row0.Y = mat.Row1.X;
            result.Row0.Z = mat.Row2.X;
            result.Row1.X = mat.Row0.Y;
            result.Row1.Y = mat.Row1.Y;
            result.Row1.Z = mat.Row2.Y;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <returns>The transpose of the given matrix.</returns>
        public static Matrix2x3d Transpose(Matrix3x2d mat)
        {
            Matrix2x3d result;
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
        /// <returns>A new Matrix3x2d which holds the result of the multiplication</returns>
        public static Matrix3x2d operator *(double left, Matrix3x2d right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x2d which holds the result of the multiplication</returns>
        public static Matrix3x2d operator *(Matrix3x2d left, double right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x2d which holds the result of the multiplication</returns>
        public static Matrix3x2d operator *(Matrix3x2d left, Matrix2d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3d which holds the result of the multiplication</returns>
        public static Matrix3d operator *(Matrix3x2d left, Matrix2x3d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x4 which holds the result of the multiplication</returns>
        public static Matrix3x4d operator *(Matrix3x2d left, Matrix2x4d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x2d which holds the result of the addition</returns>
        public static Matrix3x2d operator +(Matrix3x2d left, Matrix3x2d right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix3x2d which holds the result of the subtraction</returns>
        public static Matrix3x2d operator -(Matrix3x2d left, Matrix3x2d right)
        {
            return Subtract(left, right);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Matrix3x2d left, Matrix3x2d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Matrix3x2d left, Matrix3x2d right)
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
            if (!(obj is Matrix3x2d))
                return false;

            return this.Equals((Matrix3x2d)obj);
        }

        #endregion

        #endregion

        #endregion

        #region IEquatable<Matrix3x2d> Members

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(Matrix3x2d other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1 &&
                Row2 == other.Row2;
        }

        #endregion
    }
}
