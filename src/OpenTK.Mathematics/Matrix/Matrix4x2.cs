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
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace OpenTK.Mathematics
{
    /// <summary>
    /// Represents a 4x2 matrix.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4x2 : IEquatable<Matrix4x2>, IFormattable,
                                IMultiplyOperators<Matrix4x2, float, Matrix4x2>,
                                IMultiplyOperators<Matrix4x2, Vector2, Vector4>,
                                IMultiplyOperators<Matrix4x2, Matrix2, Matrix4x2>,
                                IMultiplyOperators<Matrix4x2, Matrix2x3, Matrix4x3>,
                                IMultiplyOperators<Matrix4x2, Matrix2x4, Matrix4>,
                                IAdditionOperators<Matrix4x2, Matrix4x2, Matrix4x2>,
                                ISubtractionOperators<Matrix4x2, Matrix4x2, Matrix4x2>,
                                IEqualityOperators<Matrix4x2, Matrix4x2, bool>,
                                IAdditiveIdentity<Matrix4x2, Matrix4x2>
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
        /// Third row of the matrix.
        /// </summary>
        public Vector2 Row2;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector2 Row3;

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix4x2 Zero = new Matrix4x2(Vector2.Zero, Vector2.Zero, Vector2.Zero, Vector2.Zero);

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4x2"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Second row of the matrix.</param>
        /// <param name="row2">Third row of the matrix.</param>
        /// <param name="row3">Bottom row of the matrix.</param>
        public Matrix4x2(Vector2 row0, Vector2 row1, Vector2 row2, Vector2 row3)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4x2"/> struct.
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
        public Matrix4x2
        (
            float m00, float m01,
            float m10, float m11,
            float m20, float m21,
            float m30, float m31
        )
        {
            Row0 = new Vector2(m00, m01);
            Row1 = new Vector2(m10, m11);
            Row2 = new Vector2(m20, m21);
            Row3 = new Vector2(m30, m31);
        }

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector4 Column0
        {
            readonly get => new Vector4(Row0.X, Row1.X, Row2.X, Row3.X);
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
        public Vector4 Column1
        {
            readonly get => new Vector4(Row0.Y, Row1.Y, Row2.Y, Row3.X);
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
        /// Gets or sets the value at row 4, column 1 of this instance.
        /// </summary>
        public float M41
        {
            readonly get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 2 of this instance.
        /// </summary>
        public float M42
        {
            readonly get => Row3.Y;
            set => Row3.Y = value;
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
        public static Matrix4x2 AdditiveIdentity => Zero;

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
                if (((uint)rowIndex) >= 4 || ((uint)columnIndex) >= 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this matrix at: ({0}, {1})", rowIndex, columnIndex);
                }

                return GetRowUnsafe(in this, rowIndex)[columnIndex];
            }

            set
            {
                if (((uint)rowIndex) >= 4 || ((uint)columnIndex) >= 2)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this matrix at: ({0}, {1})", rowIndex, columnIndex);
                }

                GetRowUnsafe(in this, rowIndex)[columnIndex] = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref Vector2 GetRowUnsafe(in Matrix4x2 m, int index)
        {
            ref Vector2 address = ref Unsafe.AsRef(in m.Row0);
            return ref Unsafe.Add(ref address, index);
        }

        /// <summary>
        /// Returns a transposed copy of this instance.
        /// </summary>
        /// <returns>The transposed copy.</returns>
        public readonly Matrix2x4 Transposed()
        {
            return Transpose(this);
        }

        /// <summary>
        /// Swizzles this instance. Swiches places of the rows of the matrix.
        /// </summary>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="rowForRow3">Which row to place in <see cref="Row3"/>.</param>
        public void Swizzle(int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3)
        {
            this = Swizzle(this, rowForRow0, rowForRow1, rowForRow2, rowForRow3);
        }

        /// <summary>
        /// Returns a swizzled copy of this instance.
        /// </summary>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="rowForRow3">Which row to place in <see cref="Row3"/>.</param>
        /// <returns>The swizzled copy.</returns>
        public readonly Matrix4x2 Swizzled(int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3)
        {
            Matrix4x2 m = this;
            m.Swizzle(rowForRow0, rowForRow1, rowForRow2, rowForRow3);
            return m;
        }

        /// <summary>
        /// Builds a rotation matrix.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix3x2 instance.</param>
        public static void CreateRotation(float angle, out Matrix4x2 result)
        {
            float cos = MathF.Cos(angle);
            float sin = MathF.Sin(angle);

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
        public static Matrix4x2 CreateRotation(float angle)
        {
            CreateRotation(angle, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float scale, out Matrix4x2 result)
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
        public static Matrix4x2 CreateScale(float scale)
        {
            CreateScale(scale, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x and y axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(Vector2 scale, out Matrix4x2 result)
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
        public static Matrix4x2 CreateScale(Vector2 scale)
        {
            CreateScale(scale, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(float x, float y, out Matrix4x2 result)
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
        public static Matrix4x2 CreateScale(float x, float y)
        {
            CreateScale(x, y, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Multiplies and instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2 left, float right, out Matrix4x2 result)
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
        public static Matrix4x2 Mult(Matrix4x2 left, float right)
        {
            Mult(in left, right, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2 left, in Matrix2 right, out Matrix4x2 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float leftM41 = left.Row3.X;
            float leftM42 = left.Row3.Y;
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
        public static Matrix4x2 Mult(Matrix4x2 left, Matrix2 right)
        {
            Mult(in left, in right, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2 left, in Matrix2x3 right, out Matrix4x3 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float leftM41 = left.Row3.X;
            float leftM42 = left.Row3.Y;
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
        public static Matrix4x3 Mult(Matrix4x2 left, Matrix2x3 right)
        {
            Mult(in left, in right, out Matrix4x3 result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4x2 left, in Matrix2x4 right, out Matrix4 result)
        {
            float leftM11 = left.Row0.X;
            float leftM12 = left.Row0.Y;
            float leftM21 = left.Row1.X;
            float leftM22 = left.Row1.Y;
            float leftM31 = left.Row2.X;
            float leftM32 = left.Row2.Y;
            float leftM41 = left.Row3.X;
            float leftM42 = left.Row3.Y;
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
        public static Matrix4 Mult(Matrix4x2 left, Matrix2x4 right)
        {
            Mult(in left, in right, out Matrix4 result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix4x2 left, in Matrix4x2 right, out Matrix4x2 result)
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
        public static Matrix4x2 Add(Matrix4x2 left, Matrix4x2 right)
        {
            Add(in left, in right, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left operand of the subtraction.</param>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <param name="result">A new instance that is the result of the subtraction.</param>
        public static void Subtract(in Matrix4x2 left, in Matrix4x2 right, out Matrix4x2 result)
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
        public static Matrix4x2 Subtract(Matrix4x2 left, Matrix4x2 right)
        {
            Subtract(in left, in right, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The transpose of the given matrix.</param>
        public static void Transpose(in Matrix4x2 mat, out Matrix2x4 result)
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
        public static Matrix2x4 Transpose(Matrix4x2 mat)
        {
            Transpose(in mat, out Matrix2x4 result);
            return result;
        }

        /// <summary>
        /// Swizzles a matrix, i.e. switches rows of the matrix.
        /// </summary>
        /// <param name="mat">The matrix to swizzle.</param>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="rowForRow3">Which row to place in <see cref="Row3"/>.</param>
        /// <returns>The swizzled matrix.</returns>
        /// <exception cref="IndexOutOfRangeException">If any of the rows are outside of the range [0, 3].</exception>
        public static Matrix4x2 Swizzle(Matrix4x2 mat, int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3)
        {
            Swizzle(mat, rowForRow0, rowForRow1, rowForRow2, rowForRow3, out Matrix4x2 result);
            return result;
        }

        /// <summary>
        /// Swizzles a matrix, i.e. switches rows of the matrix.
        /// </summary>
        /// <param name="mat">The matrix to swizzle.</param>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="rowForRow3">Which row to place in <see cref="Row3"/>.</param>
        /// <param name="result">The swizzled matrix.</param>
        /// <exception cref="IndexOutOfRangeException">If any of the rows are outside of the range [0, 3].</exception>
        public static void Swizzle(in Matrix4x2 mat, int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3, out Matrix4x2 result)
        {
            result.Row0 = rowForRow0 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                3 => mat.Row3,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow0)} must be a number between 0 and 3. Got {rowForRow0}."),
            };

            result.Row1 = rowForRow1 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                3 => mat.Row3,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow1)} must be a number between 0 and 3. Got {rowForRow1}."),
            };

            result.Row2 = rowForRow2 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                3 => mat.Row3,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow2)} must be a number between 0 and 3. Got {rowForRow2}."),
            };

            result.Row3 = rowForRow3 switch
            {
                0 => mat.Row0,
                1 => mat.Row1,
                2 => mat.Row2,
                3 => mat.Row3,
                _ => throw new IndexOutOfRangeException($"{nameof(rowForRow3)} must be a number between 0 and 2. Got {rowForRow3}."),
            };
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2 operator *(float left, Matrix4x2 right)
        {
            return Mult(right, left);
        }

        /// <summary>
        /// Scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2 operator *(Matrix4x2 left, float right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Transform a 2-dimensional vector into a 4-dimensional vector using the given 4x2 Matrix.
        /// </summary>
        /// <param name="mat">The vector to transform.</param>
        /// <param name="vec">The desired transformation.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4 operator *(Matrix4x2 mat, Vector2 vec)
        {
            Vector2.TransformFourDimensionsColumn(in mat, in vec, out Vector4 result);
            return result;
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix2 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2 operator *(Matrix4x2 left, Matrix2 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x3 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x3 operator *(Matrix4x2 left, Matrix2x3 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4 which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4 operator *(Matrix4x2 left, Matrix2x4 right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2 which holds the result of the addition.</returns>
        [Pure]
        public static Matrix4x2 operator +(Matrix4x2 left, Matrix4x2 right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2 which holds the result of the subtraction.</returns>
        [Pure]
        public static Matrix4x2 operator -(Matrix4x2 left, Matrix4x2 right)
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
        public static bool operator ==(Matrix4x2 left, Matrix4x2 right)
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
        public static bool operator !=(Matrix4x2 left, Matrix4x2 right)
        {
            return !left.Equals(right);
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
            string row0 = Row0.ToString(format, formatProvider);
            string row1 = Row1.ToString(format, formatProvider);
            string row2 = Row2.ToString(format, formatProvider);
            string row3 = Row3.ToString(format, formatProvider);
            return $"{row0}\n{row1}\n{row2}\n{row3}";
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Row0, Row1, Row2, Row3);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the instances are equal; false otherwise.</returns>
        [Pure]
        public override readonly bool Equals(object obj)
        {
            return obj is Matrix4x2 && Equals((Matrix4x2)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public readonly bool Equals(Matrix4x2 other)
        {
            Vector256<float> aRow0123 = Vector256.LoadUnsafe(in Row0.X);

            Vector256<float> bRow0123 = Vector256.LoadUnsafe(in other.Row0.X);

            return aRow0123 == bRow0123;
        }
    }
}
