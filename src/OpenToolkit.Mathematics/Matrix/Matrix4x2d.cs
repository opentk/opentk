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
    /// Represents a 4x2 matrix.
    /// </summary>
    public struct Matrix4x2d : IEquatable<Matrix4x2d>
    {
        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector2d Row0;

        /// <summary>
        /// Second row of the matrix.
        /// </summary>
        public Vector2d Row1;

        /// <summary>
        /// Third row of the matrix.
        /// </summary>
        public Vector2d Row2;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector2d Row3;

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix4x2d Zero = new Matrix4x2d
        (
            Vector2d.Zero,
            Vector2d.Zero,
            Vector2d.Zero,
            Vector2d.Zero
        );

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4x2d"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Second row of the matrix.</param>
        /// <param name="row2">Third row of the matrix.</param>
        /// <param name="row3">Bottom row of the matrix.</param>
        public Matrix4x2d(Vector2d row0, Vector2d row1, Vector2d row2, Vector2d row3)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4x2d"/> struct.
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m20">First item of the third row of the matrix.</param>
        /// <param name="m21">Second item of the third row of the matrix.</param>
        /// <param name="m30">First item of the fourth row of the matrix.</param>
        /// <param name="m31">Second item of the fourth row of the matrix.</param>
        [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1117", Justification = "For better readability of Matrix struct.")]
        public Matrix4x2d
        (
            double m00, double m01,
            double m10, double m11,
            double m20, double m21,
            double m30, double m31
        )
        {
            Row0 = new Vector2d(m00, m01);
            Row1 = new Vector2d(m10, m11);
            Row2 = new Vector2d(m20, m21);
            Row3 = new Vector2d(m30, m31);
        }

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector4d Column0
        {
            get => new Vector4d(Row0.X, Row1.X, Row2.X, Row3.X);
            set
            {
                Row0.X = value.X;
                Row1.X = value.Y;
                Row2.X = value.Z;
                Row3.X = value.W;
            }
        }

        /// <summary>
        /// Gets or sets the second column of this matrix.
        /// </summary>
        public Vector4d Column1
        {
            get => new Vector4d(Row0.Y, Row1.Y, Row2.Y, Row3.X);
            set
            {
                Row0.Y = value.X;
                Row1.Y = value.Y;
                Row2.Y = value.Z;
                Row3.Y = value.W;
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
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public double M31
        {
            get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public double M32
        {
            get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 1 of this instance.
        /// </summary>
        public double M41
        {
            get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 2 of this instance.
        /// </summary>
        public double M42
        {
            get => Row3.Y;
            set => Row3.Y = value;
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
        /// <returns>The element at the given row and column index.</returns>
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

                if (rowIndex == 2)
                {
                    return Row2[columnIndex];
                }

                if (rowIndex == 3)
                {
                    return Row3[columnIndex];
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
                else if (rowIndex == 3)
                {
                    Row3[columnIndex] = value;
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
        /// <param name="result">The resulting Matrix3x2 instance.</param>
        public static void CreateRotation(double angle, out Matrix4x2d result)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row3.X = 0;
            result.Row3.Y = 0;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix3x2 instance.</returns>
        [Pure]
        public static Matrix4x2d CreateRotation(double angle)
        {
            CreateRotation(angle, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double scale, out Matrix4x2d result)
        {
            result.Row0.X = scale;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row3.X = 0;
            result.Row3.Y = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix4x2d CreateScale(double scale)
        {
            CreateScale(scale, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(Vector2d scale, out Matrix4x2d result)
        {
            result.Row0.X = scale.X;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale.Y;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row3.X = 0;
            result.Row3.Y = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix4x2d CreateScale(Vector2d scale)
        {
            CreateScale(scale, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double x, double y, out Matrix4x2d result)
        {
            result.Row0.X = x;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = y;
            result.Row2.X = 0;
            result.Row2.Y = 0;
            result.Row3.X = 0;
            result.Row3.Y = 0;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix4x2d CreateScale(double x, double y)
        {
            CreateScale(x, y, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2d left, double right, out Matrix4x2d result)
        {
            result.Row0.X = left.Row0.X * right;
            result.Row0.Y = left.Row0.Y * right;
            result.Row1.X = left.Row1.X * right;
            result.Row1.Y = left.Row1.Y * right;
            result.Row2.X = left.Row2.X * right;
            result.Row2.Y = left.Row2.Y * right;
            result.Row3.X = left.Row3.X * right;
            result.Row3.Y = left.Row3.Y * right;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2d Mult(Matrix4x2d left, double right)
        {
            Mult(in left, right, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2d left, in Matrix2d right, out Matrix4x2d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM31 = left.Row2.X;
            double leftM32 = left.Row2.Y;
            double leftM41 = left.Row3.X;
            double leftM42 = left.Row3.Y;
            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22);
            result.Row3.X = (leftM41 * rightM11) + (leftM42 * rightM21);
            result.Row3.Y = (leftM41 * rightM12) + (leftM42 * rightM22);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2d Mult(Matrix4x2d left, Matrix2d right)
        {
            Mult(in left, in right, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2d left, in Matrix2x3d right, out Matrix4x3d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM31 = left.Row2.X;
            double leftM32 = left.Row2.Y;
            double leftM41 = left.Row3.X;
            double leftM42 = left.Row3.Y;
            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM13 = right.Row0.Z;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM23 = right.Row1.Z;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23);
            result.Row3.X = (leftM41 * rightM11) + (leftM42 * rightM21);
            result.Row3.Y = (leftM41 * rightM12) + (leftM42 * rightM22);
            result.Row3.Z = (leftM41 * rightM13) + (leftM42 * rightM23);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x3d Mult(Matrix4x2d left, Matrix2x3d right)
        {
            Mult(in left, in right, out Matrix4x3d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2d left, in Matrix2x4d right, out Matrix4d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM31 = left.Row2.X;
            double leftM32 = left.Row2.Y;
            double leftM41 = left.Row3.X;
            double leftM42 = left.Row3.Y;
            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM13 = right.Row0.Z;
            double rightM14 = right.Row0.W;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM23 = right.Row1.Z;
            double rightM24 = right.Row1.W;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23);
            result.Row0.W = (leftM11 * rightM14) + (leftM12 * rightM24);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23);
            result.Row1.W = (leftM21 * rightM14) + (leftM22 * rightM24);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23);
            result.Row2.W = (leftM31 * rightM14) + (leftM32 * rightM24);
            result.Row3.X = (leftM41 * rightM11) + (leftM42 * rightM21);
            result.Row3.Y = (leftM41 * rightM12) + (leftM42 * rightM22);
            result.Row3.Z = (leftM41 * rightM13) + (leftM42 * rightM23);
            result.Row3.W = (leftM41 * rightM14) + (leftM42 * rightM24);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4d Mult(Matrix4x2d left, Matrix2x4d right)
        {
            Mult(in left, in right, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix4x2d left, in Matrix4x2d right, out Matrix4x2d result)
        {
            result.Row0.X = left.Row0.X + right.Row0.X;
            result.Row0.Y = left.Row0.Y + right.Row0.Y;
            result.Row1.X = left.Row1.X + right.Row1.X;
            result.Row1.Y = left.Row1.Y + right.Row1.Y;
            result.Row2.X = left.Row2.X + right.Row2.X;
            result.Row2.Y = left.Row2.Y + right.Row2.Y;
            result.Row3.X = left.Row3.X + right.Row3.X;
            result.Row3.Y = left.Row3.Y + right.Row3.Y;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        [Pure]
        public static Matrix4x2d Add(Matrix4x2d left, Matrix4x2d right)
        {
            Add(in left, in right, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <param name="result">A new instance that is the result of the subtraction.</param>
        public static void Subtract(in Matrix4x2d left, in Matrix4x2d right, out Matrix4x2d result)
        {
            result.Row0.X = left.Row0.X - right.Row0.X;
            result.Row0.Y = left.Row0.Y - right.Row0.Y;
            result.Row1.X = left.Row1.X - right.Row1.X;
            result.Row1.Y = left.Row1.Y - right.Row1.Y;
            result.Row2.X = left.Row2.X - right.Row2.X;
            result.Row2.Y = left.Row2.Y - right.Row2.Y;
            result.Row3.X = left.Row3.X - right.Row3.X;
            result.Row3.Y = left.Row3.Y - right.Row3.Y;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new instance that is the result of the subtraction.</returns>
        [Pure]
        public static Matrix4x2d Subtract(Matrix4x2d left, Matrix4x2d right)
        {
            Subtract(in left, in right, out Matrix4x2d result);
            return result;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The transpose of the given matrix.</param>
        public static void Transpose(in Matrix4x2d mat, out Matrix2x4d result)
        {
            result.Row0.X = mat.Row0.X;
            result.Row0.Y = mat.Row1.X;
            result.Row0.Z = mat.Row2.X;
            result.Row0.W = mat.Row3.X;
            result.Row1.X = mat.Row0.Y;
            result.Row1.Y = mat.Row1.Y;
            result.Row1.Z = mat.Row2.Y;
            result.Row1.W = mat.Row3.Y;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <returns>The transpose of the given matrix.</returns>
        [Pure]
        public static Matrix2x4d Transpose(Matrix4x2d mat)
        {
            Transpose(in mat, out Matrix2x4d result);
            return result;
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2d operator *(double left, Matrix4x2d right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2d operator *(Matrix4x2d left, double right)
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
        public static Matrix4x2d operator *(Matrix4x2d left, Matrix2d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x3d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x3d operator *(Matrix4x2d left, Matrix2x3d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4d operator *(Matrix4x2d left, Matrix2x4d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2d which holds the result of the addition.</returns>
        [Pure]
        public static Matrix4x2d operator +(Matrix4x2d left, Matrix4x2d right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2d which holds the result of the subtraction.</returns>
        [Pure]
        public static Matrix4x2d operator -(Matrix4x2d left, Matrix4x2d right)
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
        public static bool operator ==(Matrix4x2d left, Matrix4x2d right)
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
        public static bool operator !=(Matrix4x2d left, Matrix4x2d right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a System.String that represents the current Matrix3d.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override string ToString()
        {
            return $"{Row0}\n{Row1}\n{Row2}\n{Row3}";
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
                hashCode = (hashCode * 397) ^ Row3.GetHashCode();
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
            if (!(obj is Matrix4x2d))
            {
                return false;
            }

            return Equals((Matrix4x2d)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public bool Equals(Matrix4x2d other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1 &&
                Row2 == other.Row2 &&
                Row3 == other.Row3;
        }
    }
}
