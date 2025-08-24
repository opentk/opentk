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
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 2x2 matrix.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix2 : IEquatable<Matrix2>, IFormattable,
                            IMultiplyOperators<Matrix2, float, Matrix2>,
                            IMultiplyOperators<Matrix2, Vector2, Vector2>,
                            IMultiplyOperators<Matrix2, Matrix2, Matrix2>,
                            IMultiplyOperators<Matrix2, Matrix2x3, Matrix2x3>,
                            IMultiplyOperators<Matrix2, Matrix2x4, Matrix2x4>,
                            IAdditionOperators<Matrix2, Matrix2, Matrix2>,
                            ISubtractionOperators<Matrix2, Matrix2, Matrix2>,
                            IEqualityOperators<Matrix2, Matrix2, bool>,
                            IAdditiveIdentity<Matrix2, Matrix2>,
                            IMultiplicativeIdentity<Matrix2, Matrix2>
    {
        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector2 Row0;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector2 Row1;

        /// <summary>
        /// The identity matrix.
        /// </summary>
        public static readonly Matrix2 Identity = new Matrix2(Vector2.UnitX, Vector2.UnitY);

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix2 Zero = new Matrix2(Vector2.Zero, Vector2.Zero);

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Bottom row of the matrix.</param>
        public Matrix2(Vector2 row0, Vector2 row1)
        {
            Row0 = row0;
            Row1 = row1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix2"/> struct.
        /// </summary>
        /// <param name="m00">First item of the first row of the matrix.</param>
        /// <param name="m01">Second item of the first row of the matrix.</param>
        /// <param name="m10">First item of the second row of the matrix.</param>
        /// <param name="m11">Second item of the second row of the matrix.</param>
        [SuppressMessage("ReSharper", "SA1117", Justification = "For better readability of Matrix struct.")]
        public Matrix2
        (
            float m00, float m01,
            float m10, float m11
        )
        {
            Row0 = new Vector2(m00, m01);
            Row1 = new Vector2(m10, m11);
        }

        /// <summary>
        /// Gets the determinant of this matrix.
        /// </summary>
        public readonly float Determinant
        {
            get
            {
                float m11 = Row0.X;
                float m12 = Row0.Y;
                float m21 = Row1.X;
                float m22 = Row1.Y;

                return (m11 * m22) - (m12 * m21);
            }
        }

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector2 Column0
        {
            readonly get => new Vector2(Row0.X, Row1.X);
            set
            {
                Row0.X = value.X;
                Row1.X = value.Y;
            }
        }

        /// <summary>
        /// Gets or sets the second column of this matrix.
        /// </summary>
        public Vector2 Column1
        {
            readonly get => new Vector2(Row0.Y, Row1.Y);
            set
            {
                Row0.Y = value.X;
                Row1.Y = value.Y;
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
        /// Gets the additive identity of the matrix, which is the zero matrix.
        /// </summary>
        public static Matrix2 AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of the matrix, which is the identity matrix.
        /// </summary>
        public static Matrix2 MultiplicativeIdentity => Identity;

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
                if (((uint)rowIndex) >= 2 || ((uint)columnIndex) >= 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this matrix at: ({0}, {1})", rowIndex, columnIndex);
                }

                return GetRowUnsafe(in this, rowIndex)[columnIndex];
            }

            set
            {
                if (((uint)rowIndex) >= 2 || ((uint)columnIndex) >= 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this matrix at: ({0}, {1})", rowIndex, columnIndex);
                }

                GetRowUnsafe(in this, rowIndex)[columnIndex] = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref Vector2 GetRowUnsafe(in Matrix2 m, int index)
        {
            ref Vector2 address = ref Unsafe.AsRef(in m.Row0);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Converts this instance into its inverse.
        /// </summary>
        public void Invert()
        {
            this = Invert(this);
        }

        /// <summary>
        /// Returns an inverted copy of this instance.
        /// </summary>
        /// <returns>The inverted copy.</returns>
        public readonly Matrix2 Inverted()
        {
            Matrix2 m = this;
            m.Invert();
            return m;
        }

        /// <summary>
        /// Converts this instance to it's transpose.
        /// </summary>
        public void Transpose()
        {
            this = Transpose(this);
        }

        /// <summary>
        /// Returns a transposed copy of this instance.
        /// </summary>
        /// <returns>The transposed copy.</returns>
        public readonly Matrix2 Transposed()
        {
            Matrix2 m = this;
            m.Transpose();
            return m;
        }

        /// <summary>
        /// Swizzles this instance. Swiches places of the rows of the matrix.
        /// </summary>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        public void Swizzle(int rowForRow0, int rowForRow1)
        {
            this = Swizzle(this, rowForRow0, rowForRow1);
        }

        /// <summary>
        /// Returns a swizzled copy of this instance.
        /// </summary>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <returns>The swizzled copy.</returns>
        public readonly Matrix2 Swizzled(int rowForRow0, int rowForRow1)
        {
            Matrix2 m = this;
            m.Swizzle(rowForRow0, rowForRow1);
            return m;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix2 instance.</param>
        public static void CreateRotation(float angle, out Matrix2 result)
        {
            float cos = MathF.Cos(angle);
            float sin = MathF.Sin(angle);

            result.Row0.X = cos;
            result.Row0.Y = sin;
            result.Row1.X = -sin;
            result.Row1.Y = cos;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix2 instance.</returns>
        [Pure]
        public static Matrix2 CreateRotation(float angle)
        {
            CreateRotation(angle, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float scale, out Matrix2 result)
        {
            result.Row0.X = scale;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix2 CreateScale(float scale)
        {
            CreateScale(scale, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(Vector2 scale, out Matrix2 result)
        {
            result.Row0.X = scale.X;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = scale.Y;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix2 CreateScale(Vector2 scale)
        {
            CreateScale(scale, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float x, float y, out Matrix2 result)
        {
            result.Row0.X = x;
            result.Row0.Y = 0;
            result.Row1.X = 0;
            result.Row1.Y = y;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix2 CreateScale(float x, float y)
        {
            CreateScale(x, y, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Create a swizzle matrix that can be used to change the row order of matrices.
        /// </summary>
        /// <remarks>
        /// If you are looking to swizzle vectors there are properties like <see cref="Vector2.Yx"/> that can do this more effectively.
        /// </remarks>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <returns>The resulting swizzle matrix.</returns>
        public static Matrix2 CreateSwizzle(int rowForRow0, int rowForRow1)
        {
            CreateSwizzle(rowForRow0, rowForRow1, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Create a swizzle matrix that can be used to change the row order of matrices.
        /// </summary>
        /// /// <remarks>
        /// If you are looking to swizzle vectors there are properties like <see cref="Vector2.Yx"/> that can do this more effectively.
        /// </remarks>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="result">The resulting swizzle matrix.</param>
        public static void CreateSwizzle(int rowForRow0, int rowForRow1, out Matrix2 result)
        {
            if (rowForRow0 < 0 || rowForRow0 >= 2)
            {
                throw new IndexOutOfRangeException($"{nameof(rowForRow0)} must be a number between 0 and 1. Got {rowForRow0}.");
            }
            if (rowForRow1 < 0 || rowForRow1 >= 2)
            {
                throw new IndexOutOfRangeException($"{nameof(rowForRow1)} must be a number between 0 and 1. Got {rowForRow1}.");
            }

            result = Zero;
            result[0, rowForRow0] = 1.0f;
            result[1, rowForRow1] = 1.0f;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2 left, float right, out Matrix2 result)
        {
            result.Row0.X = left.Row0.X * right;
            result.Row0.Y = left.Row0.Y * right;
            result.Row1.X = left.Row1.X * right;
            result.Row1.Y = left.Row1.Y * right;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2 Mult(Matrix2 left, float right)
        {
            Mult(in left, right, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2 left, in Matrix2 right, out Matrix2 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float rightM11 = right.Row0.X;
            float rightM12 = right.Row0.Y;
            float rightM21 = right.Row1.X;
            float rightM22 = right.Row1.Y;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2 Mult(Matrix2 left, Matrix2 right)
        {
            Mult(in left, in right, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2 left, in Matrix2x3 right, out Matrix2x3 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
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
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x3 Mult(Matrix2 left, Matrix2x3 right)
        {
            Mult(in left, in right, out Matrix2x3 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix2 left, in Matrix2x4 right, out Matrix2x4 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
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
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x4 Mult(Matrix2 left, Matrix2x4 right)
        {
            Mult(in left, in right, out Matrix2x4 result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix2 left, in Matrix2 right, out Matrix2 result)
        {
            result.Row0.X = left.Row0.X + right.Row0.X;
            result.Row0.Y = left.Row0.Y + right.Row0.Y;
            result.Row1.X = left.Row1.X + right.Row1.X;
            result.Row1.Y = left.Row1.Y + right.Row1.Y;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        [Pure]
        public static Matrix2 Add(Matrix2 left, Matrix2 right)
        {
            Add(in left, in right, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <param name="result">A new instance that is the result of the subtraction.</param>
        public static void Subtract(in Matrix2 left, in Matrix2 right, out Matrix2 result)
        {
            result.Row0.X = left.Row0.X - right.Row0.X;
            result.Row0.Y = left.Row0.Y - right.Row0.Y;
            result.Row1.X = left.Row1.X - right.Row1.X;
            result.Row1.Y = left.Row1.Y - right.Row1.Y;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new instance that is the result of the subtraction.</returns>
        [Pure]
        public static Matrix2 Subtract(Matrix2 left, Matrix2 right)
        {
            Subtract(in left, in right, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to invert.</param>
        /// <param name="result">The inverse of the given matrix.</param>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix2 is singular.</exception>
        public static void Invert(in Matrix2 mat, out Matrix2 result)
        {
            float det = (mat.Row0.X * mat.Row1.Y) - (mat.Row0.Y * mat.Row1.X);

            if (det == 0)
            {
                MathHelper.ThrowInvalidOperationException("Matrix is singular and cannot be inverted.");
            }

            float invDet = 1f / det;

            // Because the c# jit assumes alias for byref types we need to
            // save this value as the write to result.Row0.X could change the
            // value of mat.Row0.X.
            float row0x = mat.Row0.X;

            result.Row0.X = mat.Row1.Y * invDet;
            result.Row0.Y = -mat.Row0.Y * invDet;
            result.Row1.X = -mat.Row1.X * invDet;
            result.Row1.Y = row0x * invDet;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to invert.</param>
        /// <returns>The inverse of the given matrix.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix2 is singular.</exception>
        /// <returns>The inverted copy.</returns>
        [Pure]
        public static Matrix2 Invert(Matrix2 mat)
        {
            Invert(in mat, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The transpose of the given matrix.</param>
        public static void Transpose(in Matrix2 mat, out Matrix2 result)
        {
            result.Row0.X = mat.Row0.X;
            result.Row0.Y = mat.Row1.X;
            result.Row1.X = mat.Row0.Y;
            result.Row1.Y = mat.Row1.Y;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <returns>The transpose of the given matrix.</returns>
        [Pure]
        public static Matrix2 Transpose(Matrix2 mat)
        {
            Transpose(in mat, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Swizzles a matrix, i.e. switches rows of the matrix.
        /// </summary>
        /// <param name="mat">The matrix to swizzle.</param>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <returns>The swizzled matrix.</returns>
        /// <exception cref="IndexOutOfRangeException">If any of the rows are outside of the range [0, 1].</exception>
        public static Matrix2 Swizzle(Matrix2 mat, int rowForRow0, int rowForRow1)
        {
            Swizzle(mat, rowForRow0, rowForRow1, out Matrix2 result);
            return result;
        }

        /// <summary>
        /// Swizzles a matrix, i.e. switches rows of the matrix.
        /// </summary>
        /// <param name="mat">The matrix to swizzle.</param>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="result">The swizzled matrix.</param>
        /// <exception cref="IndexOutOfRangeException">If any of the rows are outside of the range [0, 1].</exception>
        public static void Swizzle(in Matrix2 mat, int rowForRow0, int rowForRow1, out Matrix2 result)
        {
            result.Row0 = rowForRow0 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow0)} must be a number between 0 and 1. Got {rowForRow0}."),
            };

            result.Row1 = rowForRow1 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow1)} must be a number between 0 and 1. Got {rowForRow1}."),
            };
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2 operator *(float left, Matrix2 right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2 operator *(Matrix2 left, float right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector2 operator *(Matrix2 mat, Vector2 vec)
        {
            Vector2.TransformColumn(in mat, in vec, out Vector2 result);
            return result;
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2 operator *(Matrix2 left, Matrix2 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x3 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x3 operator *(Matrix2 left, Matrix2x3 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2x4 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix2x4 operator *(Matrix2 left, Matrix2x4 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2 which holds the result of the addition.</returns>
        [Pure]
        public static Matrix2 operator +(Matrix2 left, Matrix2 right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2 which holds the result of the subtraction.</returns>
        [Pure]
        public static Matrix2 operator -(Matrix2 left, Matrix2 right)
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
        public static bool operator ==(Matrix2 left, Matrix2 right)
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
        public static bool operator !=(Matrix2 left, Matrix2 right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Returns a System.String that represents the current Matrix4.
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
            string row0 = Row0.ToString(format, formatProvider);
            string row1 = Row1.ToString(format, formatProvider);
            return $"{row0}\n{row1}";
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Row0, Row1);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        [Pure]
        public override readonly bool Equals(object obj)
        {
            return obj is Matrix2 && Equals((Matrix2)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public readonly bool Equals(Matrix2 other)
        {
            Vector128<float> aRow01 = Vector128.LoadUnsafe(in Row0.X);

            Vector128<float> bRow01 = Vector128.LoadUnsafe(in other.Row0.X);

            return aRow01 == bRow01;
        }
    }
}
