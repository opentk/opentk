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
    // Todo: Remove this warning when the code goes public.
    #pragma warning disable 3019
#if false
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3d : IEquatable<Matrix3d>
    {
        #region Fields & Access

        /// <summary>Row 0, Column 0</summary>
        public double R0C0;

        /// <summary>Row 0, Column 1</summary>
        public double R0C1;

        /// <summary>Row 0, Column 2</summary>
        public double R0C2;

        /// <summary>Row 1, Column 0</summary>
        public double R1C0;

        /// <summary>Row 1, Column 1</summary>
        public double R1C1;

        /// <summary>Row 1, Column 2</summary>
        public double R1C2;

        /// <summary>Row 2, Column 0</summary>
        public double R2C0;

        /// <summary>Row 2, Column 1</summary>
        public double R2C1;

        /// <summary>Row 2, Column 2</summary>
        public double R2C2;

        /// <summary>Gets the component at the given row and column in the matrix.</summary>
        /// <param name="row">The row of the matrix.</param>
        /// <param name="column">The column of the matrix.</param>
        /// <returns>The component at the given row and column in the matrix.</returns>
        public double this[int row, int column]
        {
            get
            {
                switch( row )
                {
                    case 0:
                        switch (column)
                        {
                            case 0: return R0C0;
                            case 1: return R0C1;
                            case 2: return R0C2;
                        }
                        break;

                    case 1:
                        switch (column)
                        {
                            case 0: return R1C0;
                            case 1: return R1C1;
                            case 2: return R1C2;
                        }
                        break;

                    case 2:
                        switch (column)
                        {
                            case 0: return R2C0;
                            case 1: return R2C1;
                            case 2: return R2C2;
                        }
                        break;
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                switch( row )
                {
                    case 0:
                        switch (column)
                        {
                            case 0: R0C0 = value; return;
                            case 1: R0C1 = value; return;
                            case 2: R0C2 = value; return;
                        }
                        break;

                    case 1:
                        switch (column)
                        {
                            case 0: R1C0 = value; return;
                            case 1: R1C1 = value; return;
                            case 2: R1C2 = value; return;
                        }
                        break;

                    case 2:
                        switch (column)
                        {
                            case 0: R2C0 = value; return;
                            case 1: R2C1 = value; return;
                            case 2: R2C2 = value; return;
                        }
                        break;
                }

                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>Gets the component at the index into the matrix.</summary>
        /// <param name="index">The index into the components of the matrix.</param>
        /// <returns>The component at the given index into the matrix.</returns>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return R0C0;
                    case 1: return R0C1;
                    case 2: return R0C2;
                    case 3: return R1C0;
                    case 4: return R1C1;
                    case 5: return R1C2;
                    case 6: return R2C0;
                    case 7: return R2C1;
                    case 8: return R2C2;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: R0C0 = value; return;
                    case 1: R0C1 = value; return;
                    case 2: R0C2 = value; return;
                    case 3: R1C0 = value; return;
                    case 4: R1C1 = value; return;
                    case 5: R1C2 = value; return;
                    case 6: R2C0 = value; return;
                    case 7: R2C1 = value; return;
                    case 8: R2C2 = value; return;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>Converts the matrix into an IntPtr.</summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>An IntPtr for the matrix.</returns>
        public static explicit operator IntPtr(Matrix3d matrix)
        {
            unsafe
            {
                return (IntPtr)(&matrix.R0C0);
            }
        }

        /// <summary>Converts the matrix into left double*.</summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>A double* for the matrix.</returns>
        [CLSCompliant(false)]
        unsafe public static explicit operator double*(Matrix3d matrix)
        {
            return &matrix.R0C0;
        }

        /// <summary>Converts the matrix into an array of doubles.</summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>An array of doubles for the matrix.</returns>
        public static explicit operator double[](Matrix3d matrix)
        {
            return new double[9]
            {
                matrix.R0C0,
                matrix.R0C1,
                matrix.R0C2,
                matrix.R1C0,
                matrix.R1C1,
                matrix.R1C2,
                matrix.R2C0,
                matrix.R2C1,
                matrix.R2C2
            };
        }

        #endregion

        #region Constructors

        /// <summary>Constructs left matrix with the same components as the given matrix.</summary>
        /// <param name="vector">The matrix whose components to copy.</param>
        public Matrix3d(ref Matrix3d matrix)
        {
            this.R0C0 = matrix.R0C0;
            this.R0C1 = matrix.R0C1;
            this.R0C2 = matrix.R0C2;
            this.R1C0 = matrix.R1C0;
            this.R1C1 = matrix.R1C1;
            this.R1C2 = matrix.R1C2;
            this.R2C0 = matrix.R2C0;
            this.R2C1 = matrix.R2C1;
            this.R2C2 = matrix.R2C2;
        }

        /// <summary>Constructs left matrix with the given values.</summary>
        /// <param name="r0c0">The value for row 0 column 0.</param>
        /// <param name="r0c1">The value for row 0 column 1.</param>
        /// <param name="r0c2">The value for row 0 column 2.</param>
        /// <param name="r1c0">The value for row 1 column 0.</param>
        /// <param name="r1c1">The value for row 1 column 1.</param>
        /// <param name="r1c2">The value for row 1 column 2.</param>
        /// <param name="r2c0">The value for row 2 column 0.</param>
        /// <param name="r2c1">The value for row 2 column 1.</param>
        /// <param name="r2c2">The value for row 2 column 2.</param>
        public Matrix3d
        (
            double r0c0,
            double r0c1,
            double r0c2,
            double r1c0,
            double r1c1,
            double r1c2,
            double r2c0,
            double r2c1,
            double r2c2
        )
        {
            this.R0C0 = r0c0;
            this.R0C1 = r0c1;
            this.R0C2 = r0c2;
            this.R1C0 = r1c0;
            this.R1C1 = r1c1;
            this.R1C2 = r1c2;
            this.R2C0 = r2c0;
            this.R2C1 = r2c1;
            this.R2C2 = r2c2;
        }

        /// <summary>Constructs left matrix from the given array of double-precision floating-point numbers.</summary>
        /// <param name="doubleArray">The array of doubles for the components of the matrix.</param>
        public Matrix3d(double[] doubleArray)
        {
            if (doubleArray == null || doubleArray.GetLength(0) < 9) throw new MissingFieldException();

            this.R0C0 = doubleArray[0];
            this.R0C1 = doubleArray[1];
            this.R0C2 = doubleArray[2];
            this.R1C0 = doubleArray[3];
            this.R1C1 = doubleArray[4];
            this.R1C2 = doubleArray[5];
            this.R2C0 = doubleArray[6];
            this.R2C1 = doubleArray[7];
            this.R2C2 = doubleArray[8];
        }

        /// <summary>Constructs left matrix from the given quaternion.</summary>
        /// <param name="quaternion">The quaternion to use to construct the martix.</param>
        public Matrix3d(Quaterniond quaternion)
        {
            quaternion.Normalize();

            double xx = quaternion.X * quaternion.X;
            double yy = quaternion.Y * quaternion.Y;
            double zz = quaternion.Z * quaternion.Z;
            double xy = quaternion.X * quaternion.Y;
            double xz = quaternion.X * quaternion.Z;
            double yz = quaternion.Y * quaternion.Z;
            double wx = quaternion.W * quaternion.X;
            double wy = quaternion.W * quaternion.Y;
            double wz = quaternion.W * quaternion.Z;

            R0C0 = 1 - 2 * (yy + zz);
            R0C1 = 2 * (xy - wz);
            R0C2 = 2 * (xz + wy);

            R1C0 = 2 * (xy + wz);
            R1C1 = 1 - 2 * (xx + zz);
            R1C2 = 2 * (yz - wx);

            R2C0 = 2 * (xz - wy);
            R2C1 = 2 * (yz + wx);
            R2C2 = 1 - 2 * (xx + yy);
        }

        #endregion

        #region Equality

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="matrix">The OpenTK.Matrix3d structure to compare with.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [CLSCompliant(false)]
        public bool Equals(Matrix3d matrix)
        {
            return
                R0C0 == matrix.R0C0 &&
                R0C1 == matrix.R0C1 &&
                R0C2 == matrix.R0C2 &&
                R1C0 == matrix.R1C0 &&
                R1C1 == matrix.R1C1 &&
                R1C2 == matrix.R1C2 &&
                R2C0 == matrix.R2C0 &&
                R2C1 == matrix.R2C1 &&
                R2C2 == matrix.R2C2;
        }

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="matrix">The OpenTK.Matrix3d structure to compare to.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(ref Matrix3d matrix)
        {
            return
                R0C0 == matrix.R0C0 &&
                R0C1 == matrix.R0C1 &&
                R0C2 == matrix.R0C2 &&
                R1C0 == matrix.R1C0 &&
                R1C1 == matrix.R1C1 &&
                R1C2 == matrix.R1C2 &&
                R2C0 == matrix.R2C0 &&
                R2C1 == matrix.R2C1 &&
                R2C2 == matrix.R2C2;
        }

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="left">The left-hand operand.</param>
        /// <param name="right">The right-hand operand.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public static bool Equals(ref Matrix3d left, ref Matrix3d right)
        {
            return
                left.R0C0 == right.R0C0 &&
                left.R0C1 == right.R0C1 &&
                left.R0C2 == right.R0C2 &&
                left.R1C0 == right.R1C0 &&
                left.R1C1 == right.R1C1 &&
                left.R1C2 == right.R1C2 &&
                left.R2C0 == right.R2C0 &&
                left.R2C1 == right.R2C1 &&
                left.R2C2 == right.R2C2;
        }

        /// <summary>Indicates whether the current matrix is approximately equal to another matrix.</summary>
        /// <param name="matrix">The OpenTK.Matrix3d structure to compare with.</param>
        /// <param name="tolerance">The limit below which the matrices are considered equal.</param>
        /// <returns>true if the current matrix is approximately equal to the matrix parameter; otherwise, false.</returns>
        public bool EqualsApprox(ref Matrix3d matrix, double tolerance)
        {
            return
                System.Math.Abs(R0C0 - matrix.R0C0) <= tolerance &&
                System.Math.Abs(R0C1 - matrix.R0C1) <= tolerance &&
                System.Math.Abs(R0C2 - matrix.R0C2) <= tolerance &&
                System.Math.Abs(R1C0 - matrix.R1C0) <= tolerance &&
                System.Math.Abs(R1C1 - matrix.R1C1) <= tolerance &&
                System.Math.Abs(R1C2 - matrix.R1C2) <= tolerance &&
                System.Math.Abs(R2C0 - matrix.R2C0) <= tolerance &&
                System.Math.Abs(R2C1 - matrix.R2C1) <= tolerance &&
                System.Math.Abs(R2C2 - matrix.R2C2) <= tolerance;
        }

        /// <summary>Indicates whether the current matrix is approximately equal to another matrix.</summary>
        /// <param name="left">The left-hand operand.</param>
        /// <param name="right">The right-hand operand.</param>
        /// <param name="tolerance">The limit below which the matrices are considered equal.</param>
        /// <returns>true if the current matrix is approximately equal to the matrix parameter; otherwise, false.</returns>
        public static bool EqualsApprox(ref Matrix3d left, ref Matrix3d right, double tolerance)
        {
            return
                System.Math.Abs(left.R0C0 - right.R0C0) <= tolerance &&
                System.Math.Abs(left.R0C1 - right.R0C1) <= tolerance &&
                System.Math.Abs(left.R0C2 - right.R0C2) <= tolerance &&
                System.Math.Abs(left.R1C0 - right.R1C0) <= tolerance &&
                System.Math.Abs(left.R1C1 - right.R1C1) <= tolerance &&
                System.Math.Abs(left.R1C2 - right.R1C2) <= tolerance &&
                System.Math.Abs(left.R2C0 - right.R2C0) <= tolerance &&
                System.Math.Abs(left.R2C1 - right.R2C1) <= tolerance &&
                System.Math.Abs(left.R2C2 - right.R2C2) <= tolerance;
        }

        #endregion

        #region Arithmetic Operators


        /// <summary>Add left matrix to this matrix.</summary>
        /// <param name="matrix">The matrix to add.</param>
        public void Add(ref Matrix3d matrix)
        {
            R0C0 = R0C0 + matrix.R0C0;
            R0C1 = R0C1 + matrix.R0C1;
            R0C2 = R0C2 + matrix.R0C2;
            R1C0 = R1C0 + matrix.R1C0;
            R1C1 = R1C1 + matrix.R1C1;
            R1C2 = R1C2 + matrix.R1C2;
            R2C0 = R2C0 + matrix.R2C0;
            R2C1 = R2C1 + matrix.R2C1;
            R2C2 = R2C2 + matrix.R2C2;
        }

        /// <summary>Add left matrix to this matrix.</summary>
        /// <param name="matrix">The matrix to add.</param>
        /// <param name="result">The resulting matrix of the addition.</param>
        public void Add(ref Matrix3d matrix, out Matrix3d result)
        {
            result.R0C0 = R0C0 + matrix.R0C0;
            result.R0C1 = R0C1 + matrix.R0C1;
            result.R0C2 = R0C2 + matrix.R0C2;
            result.R1C0 = R1C0 + matrix.R1C0;
            result.R1C1 = R1C1 + matrix.R1C1;
            result.R1C2 = R1C2 + matrix.R1C2;
            result.R2C0 = R2C0 + matrix.R2C0;
            result.R2C1 = R2C1 + matrix.R2C1;
            result.R2C2 = R2C2 + matrix.R2C2;
        }

        /// <summary>Add left matrix to left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the addition.</param>
        public static void Add(ref Matrix3d left, ref Matrix3d right, out Matrix3d result)
        {
            result.R0C0 = left.R0C0 + right.R0C0;
            result.R0C1 = left.R0C1 + right.R0C1;
            result.R0C2 = left.R0C2 + right.R0C2;
            result.R1C0 = left.R1C0 + right.R1C0;
            result.R1C1 = left.R1C1 + right.R1C1;
            result.R1C2 = left.R1C2 + right.R1C2;
            result.R2C0 = left.R2C0 + right.R2C0;
            result.R2C1 = left.R2C1 + right.R2C1;
            result.R2C2 = left.R2C2 + right.R2C2;
        }


        /// <summary>Subtract left matrix from this matrix.</summary>
        /// <param name="matrix">The matrix to subtract.</param>
        public void Subtract(ref Matrix3d matrix)
        {
            R0C0 = R0C0 + matrix.R0C0;
            R0C1 = R0C1 + matrix.R0C1;
            R0C2 = R0C2 + matrix.R0C2;
            R1C0 = R1C0 + matrix.R1C0;
            R1C1 = R1C1 + matrix.R1C1;
            R1C2 = R1C2 + matrix.R1C2;
            R2C0 = R2C0 + matrix.R2C0;
            R2C1 = R2C1 + matrix.R2C1;
            R2C2 = R2C2 + matrix.R2C2;
        }

        /// <summary>Subtract left matrix from this matrix.</summary>
        /// <param name="matrix">The matrix to subtract.</param>
        /// <param name="result">The resulting matrix of the subtraction.</param>
        public void Subtract(ref Matrix3d matrix, out Matrix3d result)
        {
            result.R0C0 = R0C0 + matrix.R0C0;
            result.R0C1 = R0C1 + matrix.R0C1;
            result.R0C2 = R0C2 + matrix.R0C2;
            result.R1C0 = R1C0 + matrix.R1C0;
            result.R1C1 = R1C1 + matrix.R1C1;
            result.R1C2 = R1C2 + matrix.R1C2;
            result.R2C0 = R2C0 + matrix.R2C0;
            result.R2C1 = R2C1 + matrix.R2C1;
            result.R2C2 = R2C2 + matrix.R2C2;
        }

        /// <summary>Subtract left matrix from left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the subtraction.</param>
        public static void Subtract(ref Matrix3d left, ref Matrix3d right, out Matrix3d result)
        {
            result.R0C0 = left.R0C0 + right.R0C0;
            result.R0C1 = left.R0C1 + right.R0C1;
            result.R0C2 = left.R0C2 + right.R0C2;
            result.R1C0 = left.R1C0 + right.R1C0;
            result.R1C1 = left.R1C1 + right.R1C1;
            result.R1C2 = left.R1C2 + right.R1C2;
            result.R2C0 = left.R2C0 + right.R2C0;
            result.R2C1 = left.R2C1 + right.R2C1;
            result.R2C2 = left.R2C2 + right.R2C2;
        }


        /// <summary>Multiply left martix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        public void Multiply(ref Matrix3d matrix)
        {
            double r0c0 = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0;
            double r0c1 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1;
            double r0c2 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2;

            double r1c0 = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0;
            double r1c1 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1;
            double r1c2 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2;

            R2C0 = matrix.R2C0 * R0C0 + matrix.R2C1 * R1C0 + matrix.R2C2 * R2C0;
            R2C1 = matrix.R2C0 * R0C1 + matrix.R2C1 * R1C1 + matrix.R2C2 * R2C1;
            R2C2 = matrix.R2C0 * R0C2 + matrix.R2C1 * R1C2 + matrix.R2C2 * R2C2;


            R0C0 = r0c0;
            R0C1 = r0c1;
            R0C2 = r0c2;

            R1C0 = r1c0;
            R1C1 = r1c1;
            R1C2 = r1c2;
        }

        /// <summary>Multiply matrix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public void Multiply(ref Matrix3d matrix, out Matrix3d result)
        {
            result.R0C0 = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0;
            result.R0C1 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1;
            result.R0C2 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2;
            result.R1C0 = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0;
            result.R1C1 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1;
            result.R1C2 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2;
            result.R2C0 = matrix.R2C0 * R0C0 + matrix.R2C1 * R1C0 + matrix.R2C2 * R2C0;
            result.R2C1 = matrix.R2C0 * R0C1 + matrix.R2C1 * R1C1 + matrix.R2C2 * R2C1;
            result.R2C2 = matrix.R2C0 * R0C2 + matrix.R2C1 * R1C2 + matrix.R2C2 * R2C2;
        }

        /// <summary>Multiply left matrix times left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public static void Multiply(ref Matrix3d left, ref Matrix3d right, out Matrix3d result)
        {
            result.R0C0 = right.R0C0 * left.R0C0 + right.R0C1 * left.R1C0 + right.R0C2 * left.R2C0;
            result.R0C1 = right.R0C0 * left.R0C1 + right.R0C1 * left.R1C1 + right.R0C2 * left.R2C1;
            result.R0C2 = right.R0C0 * left.R0C2 + right.R0C1 * left.R1C2 + right.R0C2 * left.R2C2;
            result.R1C0 = right.R1C0 * left.R0C0 + right.R1C1 * left.R1C0 + right.R1C2 * left.R2C0;
            result.R1C1 = right.R1C0 * left.R0C1 + right.R1C1 * left.R1C1 + right.R1C2 * left.R2C1;
            result.R1C2 = right.R1C0 * left.R0C2 + right.R1C1 * left.R1C2 + right.R1C2 * left.R2C2;
            result.R2C0 = right.R2C0 * left.R0C0 + right.R2C1 * left.R1C0 + right.R2C2 * left.R2C0;
            result.R2C1 = right.R2C0 * left.R0C1 + right.R2C1 * left.R1C1 + right.R2C2 * left.R2C1;
            result.R2C2 = right.R2C0 * left.R0C2 + right.R2C1 * left.R1C2 + right.R2C2 * left.R2C2;
        }


        /// <summary>Multiply matrix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        public void Multiply(double scalar)
        {
            R0C0 = scalar * R0C0;
            R0C1 = scalar * R0C1;
            R0C2 = scalar * R0C2;
            R1C0 = scalar * R1C0;
            R1C1 = scalar * R1C1;
            R1C2 = scalar * R1C2;
            R2C0 = scalar * R2C0;
            R2C1 = scalar * R2C1;
            R2C2 = scalar * R2C2;
        }

        /// <summary>Multiply matrix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public void Multiply(double scalar, out Matrix3d result)
        {
            result.R0C0 = scalar * R0C0;
            result.R0C1 = scalar * R0C1;
            result.R0C2 = scalar * R0C2;
            result.R1C0 = scalar * R1C0;
            result.R1C1 = scalar * R1C1;
            result.R1C2 = scalar * R1C2;
            result.R2C0 = scalar * R2C0;
            result.R2C1 = scalar * R2C1;
            result.R2C2 = scalar * R2C2;
        }

        /// <summary>Multiply left matrix times left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public static void Multiply(ref Matrix3d matrix, double scalar, out Matrix3d result)
        {
            result.R0C0 = scalar * matrix.R0C0;
            result.R0C1 = scalar * matrix.R0C1;
            result.R0C2 = scalar * matrix.R0C2;
            result.R1C0 = scalar * matrix.R1C0;
            result.R1C1 = scalar * matrix.R1C1;
            result.R1C2 = scalar * matrix.R1C2;
            result.R2C0 = scalar * matrix.R2C0;
            result.R2C1 = scalar * matrix.R2C1;
            result.R2C2 = scalar * matrix.R2C2;
        }


        #endregion

        #region Functions

        public double Determinant
        {
            get
            {
                return R0C0 * R1C1 * R2C2 - R0C0 * R1C2 * R2C1 - R0C1 * R1C0 * R2C2 + R0C2 * R1C0 * R2C1 + R0C1 * R1C2 * R2C0 - R0C2 * R1C1 * R2C0;
            }
        }

        public void Transpose()
        {
            Functions.Swap(ref R0C1, ref R1C0);
            Functions.Swap(ref R0C2, ref R2C0);
            Functions.Swap(ref R1C2, ref R2C1);
        }
        public void Transpose(out Matrix3d result)
        {
            result.R0C0 = R0C0;
            result.R0C1 = R1C0;
            result.R0C2 = R2C0;
            result.R1C0 = R0C1;
            result.R1C1 = R1C1;
            result.R1C2 = R2C1;
            result.R2C0 = R0C2;
            result.R2C1 = R1C2;
            result.R2C2 = R2C2;
        }
        public static void Transpose(ref Matrix3d matrix, out Matrix3d result)
        {
            result.R0C0 = matrix.R0C0;
            result.R0C1 = matrix.R1C0;
            result.R0C2 = matrix.R2C0;
            result.R1C0 = matrix.R0C1;
            result.R1C1 = matrix.R1C1;
            result.R1C2 = matrix.R2C1;
            result.R2C0 = matrix.R0C2;
            result.R2C1 = matrix.R1C2;
            result.R2C2 = matrix.R2C2;
        }

        #endregion

        #region Transformation Functions

        public void Transform(ref Vector3d vector)
        {
            double x = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
            double y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
            vector.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
            vector.X = x;
            vector.Y = y;
        }
        public static void Transform(ref Matrix3d matrix, ref Vector3d vector)
        {
            double x = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
            double y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
            vector.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
            vector.X = x;
            vector.Y = y;
        }
        public void Transform(ref Vector3d vector, out Vector3d result)
        {
            result.X = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
            result.Y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
            result.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
        }
        public static void Transform(ref Matrix3d matrix, ref Vector3d vector, out Vector3d result)
        {
            result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
            result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
            result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
        }

        public void Rotate(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double r0c0 = cos * R0C0 + sin * R1C0;
            double r0c1 = cos * R0C1 + sin * R1C1;
            double r0c2 = cos * R0C2 + sin * R1C2;

            R1C0 = cos * R1C0 - sin * R0C0;
            R1C1 = cos * R1C1 - sin * R0C1;
            R1C2 = cos * R1C2 - sin * R0C2;

            R0C0 = r0c0;
            R0C1 = r0c1;
            R0C2 = r0c2;
        }
        public void Rotate(double angle, out Matrix3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos * R0C0 + sin * R1C0;
            result.R0C1 = cos * R0C1 + sin * R1C1;
            result.R0C2 = cos * R0C2 + sin * R1C2;
            result.R1C0 = cos * R1C0 - sin * R0C0;
            result.R1C1 = cos * R1C1 - sin * R0C1;
            result.R1C2 = cos * R1C2 - sin * R0C2;
            result.R2C0 = R2C0;
            result.R2C1 = R2C1;
            result.R2C2 = R2C2;
        }
        public static void Rotate(ref Matrix3d matrix, double angle, out Matrix3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos * matrix.R0C0 + sin * matrix.R1C0;
            result.R0C1 = cos * matrix.R0C1 + sin * matrix.R1C1;
            result.R0C2 = cos * matrix.R0C2 + sin * matrix.R1C2;
            result.R1C0 = cos * matrix.R1C0 - sin * matrix.R0C0;
            result.R1C1 = cos * matrix.R1C1 - sin * matrix.R0C1;
            result.R1C2 = cos * matrix.R1C2 - sin * matrix.R0C2;
            result.R2C0 = matrix.R2C0;
            result.R2C1 = matrix.R2C1;
            result.R2C2 = matrix.R2C2;
        }
        public static void RotateMatrix(double angle, out Matrix3d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos;
            result.R0C1 = sin;
            result.R0C2 = 0;
            result.R1C0 = -sin;
            result.R1C1 = cos;
            result.R1C2 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = 1;
        }

        public Quaterniond ToQuaternion()
        {
            //return new Quaterniond(ref this);
        }

        #endregion

        #region Constants

        /// <summary>The identity matrix.</summary>
        public static readonly Matrix3d Identity = new Matrix3d
        (
            1, 0, 0,
            0, 1, 0,
            0, 0, 1
        );

        /// <summary>A matrix of all zeros.</summary>
        public static readonly Matrix3d Zero = new Matrix3d
        (
            0, 0, 0,
            0, 0, 0,
            0, 0, 0
        );

        #endregion

        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return
                R0C0.GetHashCode() ^ R0C1.GetHashCode() ^ R0C2.GetHashCode() ^
                R1C0.GetHashCode() ^ R1C1.GetHashCode() ^ R1C2.GetHashCode() ^
                R2C0.GetHashCode() ^ R2C1.GetHashCode() ^ R2C2.GetHashCode();
        }

        #endregion

        #region String

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return String.Format(
                "|{00}, {01}, {02}|\n" +
                "|{03}, {04}, {05}|\n" +
                "|{06}, {07}, {18}|\n" +
                R0C0, R0C1, R0C2,
                R1C0, R1C1, R1C2,
                R2C0, R2C1, R2C2);
        }

        #endregion
    }
#endif
    #pragma warning restore 3019
}
