﻿/*
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 3x2 matrix.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3x2 : IEquatable<Matrix3x2>, IFormattable
    {
        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector2 Row0;

        /// <summary>
        /// Second row of the matrix.
        /// </summary>
        public Vector2 Row1;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector2 Row2;

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix3x2 Zero = new Matrix3x2(Vector2.Zero, Vector2.Zero, Vector2.Zero);

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3x2"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Second row of the matrix.</param>
        /// <param name="row2">Bottom row of the matrix.</param>
        public Matrix3x2(Vector2 row0, Vector2 row1, Vector2 row2)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix3x2"/> struct.
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        /// <param name="m20">First item of the third row of the matrix.</param>
        /// <param name="m21">Second item of the third row of the matrix.</param>
        [SuppressMessage("ReSharper", "SA1117", Justification = "For better readability of Matrix struct.")]
        public Matrix3x2
        (
            float m00, float m01,
            float m10, float m11,
            float m20, float m21
        )
        {
            Row0 = new Vector2(m00, m01);
            Row1 = new Vector2(m10, m11);
            Row2 = new Vector2(m20, m21);
        }

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector3 Column0
        {
            readonly get => new Vector3(Row0.X, Row1.X, Row2.X);
            set
            {
                Row0.X = value.X;
                Row1.X = value.Y;
                Row2.X = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets the second column of this matrix.
        /// </summary>
        public Vector3 Column1
        {
            readonly get => new Vector3(Row0.Y, Row1.Y, Row2.Y);
            set
            {
                Row0.Y = value.X;
                Row1.Y = value.Y;
                Row2.Y = value.Z;
            }
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 1 of this instance.
        /// </summary>
        public float M11
        {
            readonly get => Row0.X;
            set => Row0.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 2 of this instance.
        /// </summary>
        public float M12
        {
            readonly get => Row0.Y;
            set => Row0.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public float M21
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public float M22
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public float M31
        {
            readonly get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public float M32
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector2 Diagonal
        {
            readonly get => new Vector2(Row0.X, Row1.Y);
            set
            {
                Row0.X = value.X;
                Row1.Y = value.Y;
            }
        }

        /// <summary>
        /// Gets the trace of the matrix, the sum of the values along the diagonal.
        /// </summary>
        public readonly float Trace => Row0.X + Row1.Y;

        /// <summary>
        /// Gets or sets the value at a specified row and column.
        /// </summary>
        /// <param name="rowIndex">The index of the row.</param>
        /// <param name="columnIndex">The index of the column.</param>
        /// <returns>The element at the given row and column index.</returns>
        public float this[int rowIndex, int columnIndex]
        {
            readonly get
            {
                if (((uint)rowIndex) < 3 && ((uint)columnIndex) < 2)
                {
                    return GetRowUnsafe(in this, rowIndex)[columnIndex];
                }
                else
                {
                    MathHelper.ThrowOutOfRangeException($"You tried to access this matrix at: ({rowIndex}, {columnIndex})");
                    return default;
                }
            }

            set
            {
                if (((uint)rowIndex) < 3 && ((uint)columnIndex) < 2)
                {
                    GetRowUnsafe(in this, rowIndex)[columnIndex] = value;
                }
                else
                {
                    MathHelper.ThrowOutOfRangeException($"You tried to set this matrix at: ({rowIndex}, {columnIndex})");
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private readonly ref Vector2 GetRowUnsafe(in Matrix3x2 m, int index)
        {
            ref Vector2 address = ref Unsafe.AsRef(in m.Row0);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Returns a transposed copy of this instance.
        /// </summary>
        /// <returns>The transposed copy.</returns>
        public readonly Matrix2x3 Transposed()
        {
            return Transpose(this);
        }

        /// <summary>
        /// Swizzles this instance. Swiches places of the rows of the matrix.
        /// </summary>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        public void Swizzle(int rowForRow0, int rowForRow1, int rowForRow2)
        {
            this = Swizzle(this, rowForRow0, rowForRow1, rowForRow2);
        }

        /// <summary>
        /// Returns a swizzled copy of this instance.
        /// </summary>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <returns>The swizzled copy.</returns>
        public readonly Matrix3x2 Swizzled(int rowForRow0, int rowForRow1, int rowForRow2)
        {
            Matrix3x2 m = this;
            m.Swizzle(rowForRow0, rowForRow1, rowForRow2);
            return m;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix3x2 instance.</param>
        public static void CreateRotation(float angle, out Matrix3x2 result)
        {
            var cos = MathF.Cos(angle);
            var sin = MathF.Sin(angle);

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
        /// <returns>The resulting Matrix3x2 instance.</returns>
        [Pure]
        public static Matrix3x2 CreateRotation(float angle)
        {
            CreateRotation(angle, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float scale, out Matrix3x2 result)
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
        [Pure]
        public static Matrix3x2 CreateScale(float scale)
        {
            CreateScale(scale, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(Vector2 scale, out Matrix3x2 result)
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
        [Pure]
        public static Matrix3x2 CreateScale(Vector2 scale)
        {
            CreateScale(scale, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float x, float y, out Matrix3x2 result)
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
        [Pure]
        public static Matrix3x2 CreateScale(float x, float y)
        {
            CreateScale(x, y, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix3x2 left, float right, out Matrix3x2 result)
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
        [Pure]
        public static Matrix3x2 Mult(Matrix3x2 left, float right)
        {
            Mult(in left, right, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix3x2 left, in Matrix2 right, out Matrix3x2 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float rightM11 = right.Row0.X;
            float rightM12 = right.Row0.Y;
            float rightM21 = right.Row1.X;
            float rightM22 = right.Row1.Y;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x2 Mult(Matrix3x2 left, Matrix2 right)
        {
            Mult(in left, in right, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix3x2 left, in Matrix2x3 right, out Matrix3 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float rightM11 = right.Row0.X;
            float rightM12 = right.Row0.Y;
            float rightM13 = right.Row0.Z;
            float rightM21 = right.Row1.X;
            float rightM22 = right.Row1.Y;
            float rightM23 = right.Row1.Z;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix3 Mult(Matrix3x2 left, Matrix2x3 right)
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
        public static void Mult(in Matrix3x2 left, in Matrix2x4 right, out Matrix3x4 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float rightM11 = right.Row0.X;
            float rightM12 = right.Row0.Y;
            float rightM13 = right.Row0.Z;
            float rightM14 = right.Row0.W;
            float rightM21 = right.Row1.X;
            float rightM22 = right.Row1.Y;
            float rightM23 = right.Row1.Z;
            float rightM24 = right.Row1.W;

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
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x4 Mult(Matrix3x2 left, Matrix2x4 right)
        {
            Mult(in left, in right, out Matrix3x4 result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix3x2 left, in Matrix3x2 right, out Matrix3x2 result)
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
        [Pure]
        public static Matrix3x2 Add(Matrix3x2 left, Matrix3x2 right)
        {
            Add(in left, in right, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <param name="result">A new instance that is the result of the subtraction.</param>
        public static void Subtract(in Matrix3x2 left, in Matrix3x2 right, out Matrix3x2 result)
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
        [Pure]
        public static Matrix3x2 Subtract(Matrix3x2 left, Matrix3x2 right)
        {
            Subtract(in left, in right, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The transpose of the given matrix.</param>
        public static void Transpose(in Matrix3x2 mat, out Matrix2x3 result)
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
        [Pure]
        public static Matrix2x3 Transpose(Matrix3x2 mat)
        {
            Transpose(in mat, out Matrix2x3 result);
            return result;
        }

        /// <summary>
        /// Swizzles a matrix, i.e. switches rows of the matrix.
        /// </summary>
        /// <param name="mat">The matrix to swizzle.</param>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <returns>The swizzled matrix.</returns>
        /// <exception cref="IndexOutOfRangeException">If any of the rows are outside of the range [0, 2].</exception>
        public static Matrix3x2 Swizzle(Matrix3x2 mat, int rowForRow0, int rowForRow1, int rowForRow2)
        {
            Swizzle(mat, rowForRow0, rowForRow1, rowForRow2, out Matrix3x2 result);
            return result;
        }

        /// <summary>
        /// Swizzles a matrix, i.e. switches rows of the matrix.
        /// </summary>
        /// <param name="mat">The matrix to swizzle.</param>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="result">The swizzled matrix.</param>
        /// <exception cref="IndexOutOfRangeException">If any of the rows are outside of the range [0, 2].</exception>
        public static void Swizzle(in Matrix3x2 mat, int rowForRow0, int rowForRow1, int rowForRow2, out Matrix3x2 result)
        {
            result.Row0 = rowForRow0 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow0)} must be a number between 0 and 2. Got {rowForRow0}."),
            };

            result.Row1 = rowForRow1 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow1)} must be a number between 0 and 2. Got {rowForRow1}."),
            };

            result.Row2 = rowForRow2 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow2)} must be a number between 0 and 2. Got {rowForRow2}."),
            };
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x2 operator *(float left, Matrix3x2 right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x2 operator *(Matrix3x2 left, float right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x2 operator *(Matrix3x2 left, Matrix2 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3 operator *(Matrix3x2 left, Matrix2x3 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x4 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix3x4 operator *(Matrix3x2 left, Matrix2x4 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x2 which holds the result of the addition.</returns>
        [Pure]
        public static Matrix3x2 operator +(Matrix3x2 left, Matrix3x2 right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix3x2 which holds the result of the subtraction.</returns>
        [Pure]
        public static Matrix3x2 operator -(Matrix3x2 left, Matrix3x2 right)
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
        public static bool operator ==(Matrix3x2 left, Matrix3x2 right)
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
        public static bool operator !=(Matrix3x2 left, Matrix3x2 right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Converts <see cref="System.Numerics.Matrix3x2"/> to <see cref="Matrix3x2"/>.
        /// </summary>
        /// <param name="mat">The <see cref="System.Numerics.Matrix3x2"/> to cast.</param>
        [Pure]
        public static explicit operator Matrix3x2(System.Numerics.Matrix3x2 mat)
        {
            return Unsafe.As<System.Numerics.Matrix3x2, Matrix3x2>(ref mat);
        }

        /// <summary>
        /// Converts <see cref="Matrix3x2"/> to <see cref="System.Numerics.Matrix3x2"/>.
        /// </summary>
        /// <param name="mat">The <see cref="Matrix3x2"/> to cast.</param>
        [Pure]
        public static explicit operator System.Numerics.Matrix3x2(Matrix3x2 mat)
        {
            return Unsafe.As<Matrix3x2, System.Numerics.Matrix3x2>(ref mat);
        }

        /// <summary>
        /// Returns a System.String that represents the current Matrix3d.
        /// </summary>
        /// <returns>The string representation of the matrix.</returns>
        public override readonly string ToString()
        {
            return ToString(null, null);
        }

        /// <inheritdoc cref="ToString(string, IFormatProvider)"/>
        public readonly string ToString(string format)
        {
            return ToString(format, null);
        }

        /// <inheritdoc cref="ToString(string, IFormatProvider)"/>
        public readonly string ToString(IFormatProvider formatProvider)
        {
            return ToString(null, formatProvider);
        }

        /// <inheritdoc/>
        public readonly string ToString(string format, IFormatProvider formatProvider)
        {
            var row0 = Row0.ToString(format, formatProvider);
            var row1 = Row1.ToString(format, formatProvider);
            var row2 = Row2.ToString(format, formatProvider);
            return $"{row0}\n{row1}\n{row2}";
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Row0, Row1, Row2);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        [Pure]
        public override readonly bool Equals(object obj)
        {
            return obj is Matrix3x2 && Equals((Matrix3x2)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public readonly bool Equals(Matrix3x2 other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1 &&
                Row2 == other.Row2;
        }
    }
}
