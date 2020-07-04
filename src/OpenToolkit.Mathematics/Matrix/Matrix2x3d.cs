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

namespace OpenToolkit.Mathematics
{
    /// <summary>
    /// Represents a 2x3 matrix.
    /// </summary>
    public struct Matrix2x3d : IEquatable<Matrix2x3d>
    {
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2x3d"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Bottom row of the matrix.</param>
        public Matrix2x3d(Vector3d row0, Vector3d row1)
        {
            Row0 = row0;
            Row1 = row1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2x3d"/> struct.
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m02">Third item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m12">Third item of the second row of the matrix.</param>
        [SuppressMessage("ReSharper", "SA1117", Justification = "For better readability of Matrix struct.")]
        public Matrix2x3d
        (
            double m00, double m01, double m02,
            double m10, double m11, double m12
        )
        {
            Row0 = new Vector3d(m00, m01, m02);
            Row1 = new Vector3d(m10, m11, m12);
        }

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector2d Column0
        {
            get => new Vector2d(Row0.X, Row1.X);
            set
            {
                Row0.X = value.X;
                Row1.X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets the second column of this matrix.
        /// </summary>
        public Vector2d Column1
        {
            get => new Vector2d(Row0.Y, Row1.Y);
            set
            {
                Row0.Y = value.X;
                Row1.Y = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets the third column of this matrix.
        /// </summary>
        public Vector2d Column2
        {
            get => new Vector2d(Row0.Z, Row1.Z);
            set
            {
                Row0.Z = value.X;
                Row1.Z = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 1 of this instance.
        /// </summary>
        public double M11
        {
            get => Row0.X;
            set => Row0.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 2 of this instance.
        /// </summary>
        public double M12
        {
            get => Row0.Y;
            set => Row0.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 3 of this instance.
        /// </summary>
        public double M13
        {
            get => Row0.Z;
            set => Row0.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public double M21
        {
            get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public double M22
        {
            get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 3 of this instance.
        /// </summary>
        public double M23
        {
            get => Row1.Z;
            set => Row1.Z = value;
        }

        /// <summary>
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector2d Diagonal
        {
            get => new Vector2d(Row0.X, Row1.Y);
            set
            {
                Row0.X = value.X;
                Row1.Y = value.Y;
            }
        }

        /// <summary>
        /// Gets the trace of the matrix, the sum of the values along the diagonal.
        /// </summary>
        public double Trace => Row0.X + Row1.Y;

        /// <summary>
        /// Gets or sets the value at a specified row and column.
        /// </summary>
        /// <param name="rowIndex">The index of the row.</param>
        /// <param name="columnIndex">The index of the column.</param>
        public double this[int rowIndex, int columnIndex]
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
                else
                {
                    throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " +
                                                       columnIndex + ")");
                }
            }
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix2x3d instance.</param>
        public static void CreateRotation(double angle, out Matrix2x3d result)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

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
        [Pure]
        public static Matrix2x3d CreateRotation(double angle)
        {
            CreateRotation(angle, out Matrix2x3d result);
            return result;
        }

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
        [Pure]
        public static Matrix2x3d CreateScale(double scale)
        {
            CreateScale(scale, out Matrix2x3d result);
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
        [Pure]
        public static Matrix2x3d CreateScale(Vector2d scale)
        {
            CreateScale(scale, out Matrix2x3d result);
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
        [Pure]
        public static Matrix2x3d CreateScale(double x, double y)
        {
            CreateScale(x, y, out Matrix2x3d result);
            return result;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2x3d left, double right, out Matrix2x3d result)
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
        [Pure]
        public static Matrix2x3d Mult(Matrix2x3d left, double right)
        {
            Mult(in left, right, out Matrix2x3d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2x3d left, in Matrix3x2 right, out Matrix2d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM13 = left.Row0.Z;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM23 = left.Row1.Z;
            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM31 = right.Row2.X;
            double rightM32 = right.Row2.Y;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2d Mult(Matrix2x3d left, Matrix3x2 right)
        {
            Mult(in left, in right, out Matrix2d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2x3d left, in Matrix3 right, out Matrix2x3d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM13 = left.Row0.Z;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM23 = left.Row1.Z;
            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM13 = right.Row0.Z;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM23 = right.Row1.Z;
            double rightM31 = right.Row2.X;
            double rightM32 = right.Row2.Y;
            double rightM33 = right.Row2.Z;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23) + (leftM13 * rightM33);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23) + (leftM23 * rightM33);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x3d Mult(Matrix2x3d left, Matrix3 right)
        {
            Mult(in left, in right, out Matrix2x3d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2x3d left, in Matrix3x4 right, out Matrix2x4d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM13 = left.Row0.Z;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM23 = left.Row1.Z;
            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM13 = right.Row0.Z;
            double rightM14 = right.Row0.W;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM23 = right.Row1.Z;
            double rightM24 = right.Row1.W;
            double rightM31 = right.Row2.X;
            double rightM32 = right.Row2.Y;
            double rightM33 = right.Row2.Z;
            double rightM34 = right.Row2.W;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23) + (leftM13 * rightM33);
            result.Row0.W = (leftM11 * rightM14) + (leftM12 * rightM24) + (leftM13 * rightM34);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23) + (leftM23 * rightM33);
            result.Row1.W = (leftM21 * rightM14) + (leftM22 * rightM24) + (leftM23 * rightM34);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x4d Mult(Matrix2x3d left, Matrix3x4 right)
        {
            Mult(in left, in right, out Matrix2x4d result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix2x3d left, in Matrix2x3d right, out Matrix2x3d result)
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
        [Pure]
        public static Matrix2x3d Add(Matrix2x3d left, Matrix2x3d right)
        {
            Add(in left, in right, out Matrix2x3d result);
            return result;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <param name="result">A new instance that is the result of the subtraction.</param>
        public static void Subtract(in Matrix2x3d left, in Matrix2x3d right, out Matrix2x3d result)
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
        [Pure]
        public static Matrix2x3d Subtract(Matrix2x3d left, Matrix2x3d right)
        {
            Subtract(in left, in right, out Matrix2x3d result);
            return result;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The transpose of the given matrix.</param>
        public static void Transpose(in Matrix2x3d mat, out Matrix3x2d result)
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
        [Pure]
        public static Matrix3x2d Transpose(Matrix2x3d mat)
        {
            Transpose(in mat, out Matrix3x2d result);
            return result;
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x3d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x3d operator *(double left, Matrix2x3d right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x3d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x3d operator *(Matrix2x3d left, double right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2d operator *(Matrix2x3d left, Matrix3x2 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x3d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x3d operator *(Matrix2x3d left, Matrix3 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x4d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x4d operator *(Matrix2x3d left, Matrix3x4 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x3d which holds the result of the addition.</returns>
        [Pure]
        public static Matrix2x3d operator +(Matrix2x3d left, Matrix2x3d right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x3d which holds the result of the subtraction.</returns>
        [Pure]
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
        [Pure]
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
        [Pure]
        public static bool operator !=(Matrix2x3d left, Matrix2x3d right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a System.String that represents the current Matrix2x3d.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override string ToString()
        {
            return $"{Row0}\n{Row1}";
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Row0.GetHashCode() * 397) ^ Row1.GetHashCode();
            }
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare tresult.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        [Pure]
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix2x3d))
            {
                return false;
            }

            return Equals((Matrix2x3d)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public bool Equals(Matrix2x3d other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1;
        }
    }
}
