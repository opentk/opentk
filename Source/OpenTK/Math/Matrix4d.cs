#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 * 
 * Contributions by James Talton.
 */
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4d : IEquatable<Matrix4d>
    {
        #region Fields & Access

        /// <summary>Row 0, Column 0</summary>
        public double R0C0;

        /// <summary>Row 0, Column 1</summary>
        public double R0C1;

        /// <summary>Row 0, Column 2</summary>
        public double R0C2;

        /// <summary>Row 0, Column 3</summary>
        public double R0C3;

        /// <summary>Row 1, Column 0</summary>
        public double R1C0;

        /// <summary>Row 1, Column 1</summary>
        public double R1C1;

        /// <summary>Row 1, Column 2</summary>
        public double R1C2;

        /// <summary>Row 1, Column 3</summary>
        public double R1C3;

        /// <summary>Row 2, Column 0</summary>
        public double R2C0;

        /// <summary>Row 2, Column 1</summary>
        public double R2C1;

        /// <summary>Row 2, Column 2</summary>
        public double R2C2;

        /// <summary>Row 2, Column 3</summary>
        public double R2C3;

        /// <summary>Row 3, Column 0</summary>
        public double R3C0;

        /// <summary>Row 3, Column 1</summary>
        public double R3C1;

        /// <summary>Row 3, Column 2</summary>
        public double R3C2;

        /// <summary>Row 3, Column 3</summary>
        public double R3C3;

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
                            case 3: return R0C3;
                        }
                        break;

                    case 1:
                        switch (column)
                        {
                            case 0: return R1C0;
                            case 1: return R1C1;
                            case 2: return R1C2;
                            case 3: return R1C3;
                        }
                        break;

                    case 2:
                        switch (column)
                        {
                            case 0: return R2C0;
                            case 1: return R2C1;
                            case 2: return R2C2;
                            case 3: return R2C3;
                        }
                        break;

                    case 3:
                        switch (column)
                        {
                            case 0: return R3C0;
                            case 1: return R3C1;
                            case 2: return R3C2;
                            case 3: return R3C3;
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
                            case 3: R0C3 = value; return;
                        }
                        break;

                    case 1:
                        switch (column)
                        {
                            case 0: R1C0 = value; return;
                            case 1: R1C1 = value; return;
                            case 2: R1C2 = value; return;
                            case 3: R1C3 = value; return;
                        }
                        break;

                    case 2:
                        switch (column)
                        {
                            case 0: R2C0 = value; return;
                            case 1: R2C1 = value; return;
                            case 2: R2C2 = value; return;
                            case 3: R2C3 = value; return;
                        }
                        break;

                    case 3:
                        switch (column)
                        {
                            case 0: R3C0 = value; return;
                            case 1: R3C1 = value; return;
                            case 2: R3C2 = value; return;
                            case 3: R3C3 = value; return;
                        }
                        break;
                }

                throw new IndexOutOfRangeException();
            }        }

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
                    case 3: return R0C3;
                    case 4: return R1C0;
                    case 5: return R1C1;
                    case 6: return R1C2;
                    case 7: return R1C3;
                    case 8: return R2C0;
                    case 9: return R2C1;
                    case 10: return R2C2;
                    case 11: return R2C3;
                    case 12: return R3C0;
                    case 13: return R3C1;
                    case 14: return R3C2;
                    case 15: return R3C3;
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
                    case 3: R0C3 = value; return;
                    case 4: R1C0 = value; return;
                    case 5: R1C1 = value; return;
                    case 6: R1C2 = value; return;
                    case 7: R1C3 = value; return;
                    case 8: R2C0 = value; return;
                    case 9: R2C1 = value; return;
                    case 10: R2C2 = value; return;
                    case 11: R2C3 = value; return;
                    case 12: R3C0 = value; return;
                    case 13: R3C1 = value; return;
                    case 14: R3C2 = value; return;
                    case 15: R3C3 = value; return;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>Converts the matrix into an IntPtr.</summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>An IntPtr for the matrix.</returns>
        public static explicit operator IntPtr(Matrix4d matrix)
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
        unsafe public static explicit operator double*(Matrix4d matrix)
        {
            return &matrix.R0C0;
        }

        /// <summary>Converts the matrix into an array of doubles.</summary>
        /// <param name="matrix">The matrix to convert.</param>
        /// <returns>An array of doubles for the matrix.</returns>
        public static explicit operator double[](Matrix4d matrix)
        {
            return new double[16]
            {
                matrix.R0C0,
                matrix.R0C1,
                matrix.R0C2,
                matrix.R0C3,
                matrix.R1C0,
                matrix.R1C1,
                matrix.R1C2,
                matrix.R1C3,
                matrix.R2C0,
                matrix.R2C1,
                matrix.R2C2,
                matrix.R2C3,
                matrix.R3C0,
                matrix.R3C1,
                matrix.R3C2,
                matrix.R3C3
            };
        }

        #endregion

        #region Constructors

        /// <summary>Constructs left matrix with the same components as the given matrix.</summary>
        /// <param name="vector">The matrix whose components to copy.</param>
        public Matrix4d(ref Matrix4d matrix)
        {
            this.R0C0 = matrix.R0C0;
            this.R0C1 = matrix.R0C1;
            this.R0C2 = matrix.R0C2;
            this.R0C3 = matrix.R0C3;
            this.R1C0 = matrix.R1C0;
            this.R1C1 = matrix.R1C1;
            this.R1C2 = matrix.R1C2;
            this.R1C3 = matrix.R1C3;
            this.R2C0 = matrix.R2C0;
            this.R2C1 = matrix.R2C1;
            this.R2C2 = matrix.R2C2;
            this.R2C3 = matrix.R2C3;
            this.R3C0 = matrix.R3C0;
            this.R3C1 = matrix.R3C1;
            this.R3C2 = matrix.R3C2;
            this.R3C3 = matrix.R3C3;
        }

        /// <summary>Constructs left matrix with the given values.</summary>
        /// <param name="r0c0">The value for row 0 column 0.</param>
        /// <param name="r0c1">The value for row 0 column 1.</param>
        /// <param name="r0c2">The value for row 0 column 2.</param>
        /// <param name="r0c3">The value for row 0 column 3.</param>
        /// <param name="r1c0">The value for row 1 column 0.</param>
        /// <param name="r1c1">The value for row 1 column 1.</param>
        /// <param name="r1c2">The value for row 1 column 2.</param>
        /// <param name="r1c3">The value for row 1 column 3.</param>
        /// <param name="r2c0">The value for row 2 column 0.</param>
        /// <param name="r2c1">The value for row 2 column 1.</param>
        /// <param name="r2c2">The value for row 2 column 2.</param>
        /// <param name="r2c3">The value for row 2 column 3.</param>
        /// <param name="r3c0">The value for row 3 column 0.</param>
        /// <param name="r3c1">The value for row 3 column 1.</param>
        /// <param name="r3c2">The value for row 3 column 2.</param>
        /// <param name="r3c3">The value for row 3 column 3.</param>
        public Matrix4d
        (
            double r0c0,
            double r0c1,
            double r0c2,
            double r0c3,
            double r1c0,
            double r1c1,
            double r1c2,
            double r1c3,
            double r2c0,
            double r2c1,
            double r2c2,
            double r2c3,
            double r3c0,
            double r3c1,
            double r3c2,
            double r3c3
        )
        {
            this.R0C0 = r0c0;
            this.R0C1 = r0c1;
            this.R0C2 = r0c2;
            this.R0C3 = r0c3;
            this.R1C0 = r1c0;
            this.R1C1 = r1c1;
            this.R1C2 = r1c2;
            this.R1C3 = r1c3;
            this.R2C0 = r2c0;
            this.R2C1 = r2c1;
            this.R2C2 = r2c2;
            this.R2C3 = r2c3;
            this.R3C0 = r3c0;
            this.R3C1 = r3c1;
            this.R3C2 = r3c2;
            this.R3C3 = r3c3;
        }

        /// <summary>Constructs left matrix from the given array of double-precision floating point numbers.</summary>
        /// <param name="doubleArray">The array of doubles for the components of the matrix.</param>
        public Matrix4d(double[] doubleArray)
        {
            if (doubleArray == null || doubleArray.GetLength(0) < 16) throw new MissingFieldException();

            this.R0C0 = doubleArray[0];
            this.R0C1 = doubleArray[1];
            this.R0C2 = doubleArray[2];
            this.R0C3 = doubleArray[3];
            this.R1C0 = doubleArray[4];
            this.R1C1 = doubleArray[5];
            this.R1C2 = doubleArray[6];
            this.R1C3 = doubleArray[7];
            this.R2C0 = doubleArray[8];
            this.R2C1 = doubleArray[9];
            this.R2C2 = doubleArray[10];
            this.R2C3 = doubleArray[11];
            this.R3C0 = doubleArray[12];
            this.R3C1 = doubleArray[13];
            this.R3C2 = doubleArray[14];
            this.R3C3 = doubleArray[15];
        }

        /// <summary>Constructs left matrix from the given quaternion.</summary>
        /// <param name="quaternion">The quaternion to use to construct the martix.</param>
        public Matrix4d(ref Quaterniond quaternion)
        {
            Quaterniond quaternionNormalized;
            quaternion.Normalize(out quaternionNormalized);

            double xx = quaternionNormalized.X * quaternionNormalized.X;
            double yy = quaternionNormalized.Y * quaternionNormalized.Y;
            double zz = quaternionNormalized.Z * quaternionNormalized.Z;
            double xy = quaternionNormalized.X * quaternionNormalized.Y;
            double xz = quaternionNormalized.X * quaternionNormalized.Z;
            double yz = quaternionNormalized.Y * quaternionNormalized.Z;
            double wx = quaternionNormalized.W * quaternionNormalized.X;
            double wy = quaternionNormalized.W * quaternionNormalized.Y;
            double wz = quaternionNormalized.W * quaternionNormalized.Z;

            R0C0 = 1 - 2 * (yy + zz);
            R0C1 = 2 * (xy - wz);
            R0C2 = 2 * (xz + wy);
            R0C3 = 0;

            R1C0 = 2 * (xy + wz);
            R1C1 = 1 - 2 * (xx + zz);
            R1C2 = 2 * (yz - wx);
            R1C3 = 0;

            R2C0 = 2 * (xz - wy);
            R2C1 = 2 * (yz + wx);
            R2C2 = 1 - 2 * (xx + yy);
            R2C3 = 0;

            R3C0 = 0;
            R3C1 = 0;
            R3C2 = 0;
            R3C3 = 1;
        }

        #endregion

        #region Equality

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="matrix">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [CLSCompliant(false)]
        public bool Equals(Matrix4d matrix)
        {
            return
                R0C0 == matrix.R0C0 &&
                R0C1 == matrix.R0C1 &&
                R0C2 == matrix.R0C2 &&
                R0C3 == matrix.R0C3 &&
                R1C0 == matrix.R1C0 &&
                R1C1 == matrix.R1C1 &&
                R1C2 == matrix.R1C2 &&
                R1C3 == matrix.R1C3 &&
                R2C0 == matrix.R2C0 &&
                R2C1 == matrix.R2C1 &&
                R2C2 == matrix.R2C2 &&
                R2C3 == matrix.R2C3 &&
                R3C0 == matrix.R3C0 &&
                R3C1 == matrix.R3C1 &&
                R3C2 == matrix.R3C2 &&
                R3C3 == matrix.R3C3;

        }

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="matrix">The OpenTK.Math.Matrix4d structure to compare to.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(ref Matrix4d matrix)
        {
            return
                R0C0 == matrix.R0C0 &&
                R0C1 == matrix.R0C1 &&
                R0C2 == matrix.R0C2 &&
                R0C3 == matrix.R0C3 &&
                R1C0 == matrix.R1C0 &&
                R1C1 == matrix.R1C1 &&
                R1C2 == matrix.R1C2 &&
                R1C3 == matrix.R1C3 &&
                R2C0 == matrix.R2C0 &&
                R2C1 == matrix.R2C1 &&
                R2C2 == matrix.R2C2 &&
                R2C3 == matrix.R2C3 &&
                R3C0 == matrix.R3C0 &&
                R3C1 == matrix.R3C1 &&
                R3C2 == matrix.R3C2 &&
                R3C3 == matrix.R3C3;

        }

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="left">The left-hand operand.</param>
        /// <param name="right">The right-hand operand.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public static bool Equals(ref Matrix4d left, ref Matrix4d right)
        {
            return
                left.R0C0 == right.R0C0 &&
                left.R0C1 == right.R0C1 &&
                left.R0C2 == right.R0C2 &&
                left.R0C3 == right.R0C3 &&
                left.R1C0 == right.R1C0 &&
                left.R1C1 == right.R1C1 &&
                left.R1C2 == right.R1C2 &&
                left.R1C3 == right.R1C3 &&
                left.R2C0 == right.R2C0 &&
                left.R2C1 == right.R2C1 &&
                left.R2C2 == right.R2C2 &&
                left.R2C3 == right.R2C3 &&
                left.R3C0 == right.R3C0 &&
                left.R3C1 == right.R3C1 &&
                left.R3C2 == right.R3C2 &&
                left.R3C3 == right.R3C3;
        }

        /// <summary>Indicates whether the current matrix is approximately equal to another matrix.</summary>
        /// <param name="matrix">The OpenTK.Math.Matrix4d structure to compare with.</param>
        /// <param name="tolerance">The limit below which the matrices are considered equal.</param>
        /// <returns>true if the current matrix is approximately equal to the matrix parameter; otherwise, false.</returns>
        public bool EqualsApprox(ref Matrix4d matrix, double tolerance)
        {
            return
                System.Math.Abs(R0C0 - matrix.R0C0) <= tolerance &&
                System.Math.Abs(R0C1 - matrix.R0C1) <= tolerance &&
                System.Math.Abs(R0C2 - matrix.R0C2) <= tolerance &&
                System.Math.Abs(R0C3 - matrix.R0C3) <= tolerance &&
                System.Math.Abs(R1C0 - matrix.R1C0) <= tolerance &&
                System.Math.Abs(R1C1 - matrix.R1C1) <= tolerance &&
                System.Math.Abs(R1C2 - matrix.R1C2) <= tolerance &&
                System.Math.Abs(R1C3 - matrix.R1C3) <= tolerance &&
                System.Math.Abs(R2C0 - matrix.R2C0) <= tolerance &&
                System.Math.Abs(R2C1 - matrix.R2C1) <= tolerance &&
                System.Math.Abs(R2C2 - matrix.R2C2) <= tolerance &&
                System.Math.Abs(R2C3 - matrix.R2C3) <= tolerance &&
                System.Math.Abs(R3C0 - matrix.R3C0) <= tolerance &&
                System.Math.Abs(R3C1 - matrix.R3C1) <= tolerance &&
                System.Math.Abs(R3C2 - matrix.R3C2) <= tolerance &&
                System.Math.Abs(R3C3 - matrix.R3C3) <= tolerance;
        }

        /// <summary>Indicates whether the current matrix is approximately equal to another matrix.</summary>
        /// <param name="left">The left-hand operand.</param>
        /// <param name="right">The right-hand operand.</param>
        /// <param name="tolerance">The limit below which the matrices are considered equal.</param>
        /// <returns>true if the current matrix is approximately equal to the matrix parameter; otherwise, false.</returns>
        public static bool EqualsApprox(ref Matrix4d left, ref Matrix4d right, double tolerance)
        {
            return
                System.Math.Abs(left.R0C0 - right.R0C0) <= tolerance &&
                System.Math.Abs(left.R0C1 - right.R0C1) <= tolerance &&
                System.Math.Abs(left.R0C2 - right.R0C2) <= tolerance &&
                System.Math.Abs(left.R0C3 - right.R0C3) <= tolerance &&
                System.Math.Abs(left.R1C0 - right.R1C0) <= tolerance &&
                System.Math.Abs(left.R1C1 - right.R1C1) <= tolerance &&
                System.Math.Abs(left.R1C2 - right.R1C2) <= tolerance &&
                System.Math.Abs(left.R1C3 - right.R1C3) <= tolerance &&
                System.Math.Abs(left.R2C0 - right.R2C0) <= tolerance &&
                System.Math.Abs(left.R2C1 - right.R2C1) <= tolerance &&
                System.Math.Abs(left.R2C2 - right.R2C2) <= tolerance &&
                System.Math.Abs(left.R2C3 - right.R2C3) <= tolerance &&
                System.Math.Abs(left.R3C0 - right.R3C0) <= tolerance &&
                System.Math.Abs(left.R3C1 - right.R3C1) <= tolerance &&
                System.Math.Abs(left.R3C2 - right.R3C2) <= tolerance &&
                System.Math.Abs(left.R3C3 - right.R3C3) <= tolerance;
        }

        #endregion

        #region Arithmetic Operators


        /// <summary>Add left matrix to this matrix.</summary>
        /// <param name="matrix">The matrix to add.</param>
        public void Add(ref Matrix4d matrix)
        {
            R0C0 = R0C0 + matrix.R0C0;
            R0C1 = R0C1 + matrix.R0C1;
            R0C2 = R0C2 + matrix.R0C2;
            R0C3 = R0C3 + matrix.R0C3;
            R1C0 = R1C0 + matrix.R1C0;
            R1C1 = R1C1 + matrix.R1C1;
            R1C2 = R1C2 + matrix.R1C2;
            R1C3 = R1C3 + matrix.R1C3;
            R2C0 = R2C0 + matrix.R2C0;
            R2C1 = R2C1 + matrix.R2C1;
            R2C2 = R2C2 + matrix.R2C2;
            R2C3 = R2C3 + matrix.R2C3;
            R3C0 = R3C0 + matrix.R3C0;
            R3C1 = R3C1 + matrix.R3C1;
            R3C2 = R3C2 + matrix.R3C2;
            R3C3 = R3C3 + matrix.R3C3;
        }

        /// <summary>Add left matrix to this matrix.</summary>
        /// <param name="matrix">The matrix to add.</param>
        /// <param name="result">The resulting matrix of the addition.</param>
        public void Add(ref Matrix4d matrix, out Matrix4d result)
        {
            result.R0C0 = R0C0 + matrix.R0C0;
            result.R0C1 = R0C1 + matrix.R0C1;
            result.R0C2 = R0C2 + matrix.R0C2;
            result.R0C3 = R0C3 + matrix.R0C3;
            result.R1C0 = R1C0 + matrix.R1C0;
            result.R1C1 = R1C1 + matrix.R1C1;
            result.R1C2 = R1C2 + matrix.R1C2;
            result.R1C3 = R1C3 + matrix.R1C3;
            result.R2C0 = R2C0 + matrix.R2C0;
            result.R2C1 = R2C1 + matrix.R2C1;
            result.R2C2 = R2C2 + matrix.R2C2;
            result.R2C3 = R2C3 + matrix.R2C3;
            result.R3C0 = R3C0 + matrix.R3C0;
            result.R3C1 = R3C1 + matrix.R3C1;
            result.R3C2 = R3C2 + matrix.R3C2;
            result.R3C3 = R3C3 + matrix.R3C3;
        }

        /// <summary>Add left matrix to left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the addition.</param>
        public static void Add(ref Matrix4d left, ref Matrix4d right, out Matrix4d result)
        {
            result.R0C0 = left.R0C0 + right.R0C0;
            result.R0C1 = left.R0C1 + right.R0C1;
            result.R0C2 = left.R0C2 + right.R0C2;
            result.R0C3 = left.R0C3 + right.R0C3;
            result.R1C0 = left.R1C0 + right.R1C0;
            result.R1C1 = left.R1C1 + right.R1C1;
            result.R1C2 = left.R1C2 + right.R1C2;
            result.R1C3 = left.R1C3 + right.R1C3;
            result.R2C0 = left.R2C0 + right.R2C0;
            result.R2C1 = left.R2C1 + right.R2C1;
            result.R2C2 = left.R2C2 + right.R2C2;
            result.R2C3 = left.R2C3 + right.R2C3;
            result.R3C0 = left.R3C0 + right.R3C0;
            result.R3C1 = left.R3C1 + right.R3C1;
            result.R3C2 = left.R3C2 + right.R3C2;
            result.R3C3 = left.R3C3 + right.R3C3;
        }


        /// <summary>Subtract left matrix from this matrix.</summary>
        /// <param name="matrix">The matrix to subtract.</param>
        public void Subtract(ref Matrix4d matrix)
        {
            R0C0 = R0C0 + matrix.R0C0;
            R0C1 = R0C1 + matrix.R0C1;
            R0C2 = R0C2 + matrix.R0C2;
            R0C3 = R0C3 + matrix.R0C3;
            R1C0 = R1C0 + matrix.R1C0;
            R1C1 = R1C1 + matrix.R1C1;
            R1C2 = R1C2 + matrix.R1C2;
            R1C3 = R1C3 + matrix.R1C3;
            R2C0 = R2C0 + matrix.R2C0;
            R2C1 = R2C1 + matrix.R2C1;
            R2C2 = R2C2 + matrix.R2C2;
            R2C3 = R2C3 + matrix.R2C3;
            R3C0 = R3C0 + matrix.R3C0;
            R3C1 = R3C1 + matrix.R3C1;
            R3C2 = R3C2 + matrix.R3C2;
            R3C3 = R3C3 + matrix.R3C3;
        }

        /// <summary>Subtract left matrix from this matrix.</summary>
        /// <param name="matrix">The matrix to subtract.</param>
        /// <param name="result">The resulting matrix of the subtraction.</param>
        public void Subtract(ref Matrix4d matrix, out Matrix4d result)
        {
            result.R0C0 = R0C0 + matrix.R0C0;
            result.R0C1 = R0C1 + matrix.R0C1;
            result.R0C2 = R0C2 + matrix.R0C2;
            result.R0C3 = R0C3 + matrix.R0C3;
            result.R1C0 = R1C0 + matrix.R1C0;
            result.R1C1 = R1C1 + matrix.R1C1;
            result.R1C2 = R1C2 + matrix.R1C2;
            result.R1C3 = R1C3 + matrix.R1C3;
            result.R2C0 = R2C0 + matrix.R2C0;
            result.R2C1 = R2C1 + matrix.R2C1;
            result.R2C2 = R2C2 + matrix.R2C2;
            result.R2C3 = R2C3 + matrix.R2C3;
            result.R3C0 = R3C0 + matrix.R3C0;
            result.R3C1 = R3C1 + matrix.R3C1;
            result.R3C2 = R3C2 + matrix.R3C2;
            result.R3C3 = R3C3 + matrix.R3C3;
        }

        /// <summary>Subtract left matrix from left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the subtraction.</param>
        public static void Subtract(ref Matrix4d left, ref Matrix4d right, out Matrix4d result)
        {
            result.R0C0 = left.R0C0 + right.R0C0;
            result.R0C1 = left.R0C1 + right.R0C1;
            result.R0C2 = left.R0C2 + right.R0C2;
            result.R0C3 = left.R0C3 + right.R0C3;
            result.R1C0 = left.R1C0 + right.R1C0;
            result.R1C1 = left.R1C1 + right.R1C1;
            result.R1C2 = left.R1C2 + right.R1C2;
            result.R1C3 = left.R1C3 + right.R1C3;
            result.R2C0 = left.R2C0 + right.R2C0;
            result.R2C1 = left.R2C1 + right.R2C1;
            result.R2C2 = left.R2C2 + right.R2C2;
            result.R2C3 = left.R2C3 + right.R2C3;
            result.R3C0 = left.R3C0 + right.R3C0;
            result.R3C1 = left.R3C1 + right.R3C1;
            result.R3C2 = left.R3C2 + right.R3C2;
            result.R3C3 = left.R3C3 + right.R3C3;
        }


        /// <summary>Multiply left martix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        public void Multiply(ref Matrix4d matrix)
        {
            double r0c0 = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0 + matrix.R0C3 * R3C0;
            double r0c1 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1 + matrix.R0C3 * R3C1;
            double r0c2 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2 + matrix.R0C3 * R3C2;
            double r0c3 = matrix.R0C0 * R0C3 + matrix.R0C1 * R1C3 + matrix.R0C2 * R2C3 + matrix.R0C3 * R3C3;
            double r1c0 = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0 + matrix.R1C3 * R3C0;
            double r1c1 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1 + matrix.R1C3 * R3C1;
            double r1c2 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2 + matrix.R1C3 * R3C2;
            double r1c3 = matrix.R1C0 * R0C3 + matrix.R1C1 * R1C3 + matrix.R1C2 * R2C3 + matrix.R1C3 * R3C3;
            double r2c0 = matrix.R2C0 * R0C0 + matrix.R2C1 * R1C0 + matrix.R2C2 * R2C0 + matrix.R2C3 * R3C0;
            double r2c1 = matrix.R2C0 * R0C1 + matrix.R2C1 * R1C1 + matrix.R2C2 * R2C1 + matrix.R2C3 * R3C1;
            double r2c2 = matrix.R2C0 * R0C2 + matrix.R2C1 * R1C2 + matrix.R2C2 * R2C2 + matrix.R2C3 * R3C2;
            double r2c3 = matrix.R2C0 * R0C3 + matrix.R2C1 * R1C3 + matrix.R2C2 * R2C3 + matrix.R2C3 * R3C3;

            R3C0 = matrix.R3C0 * R0C0 + matrix.R3C1 * R1C0 + matrix.R3C2 * R2C0 + matrix.R3C3 * R3C0;
            R3C1 = matrix.R3C0 * R0C1 + matrix.R3C1 * R1C1 + matrix.R3C2 * R2C1 + matrix.R3C3 * R3C1;
            R3C2 = matrix.R3C0 * R0C2 + matrix.R3C1 * R1C2 + matrix.R3C2 * R2C2 + matrix.R3C3 * R3C2;
            R3C3 = matrix.R3C0 * R0C3 + matrix.R3C1 * R1C3 + matrix.R3C2 * R2C3 + matrix.R3C3 * R3C3;

            R0C0 = r0c0;
            R0C1 = r0c1;
            R0C2 = r0c2;
            R0C3 = r0c3;
            R1C0 = r1c0;
            R1C1 = r1c1;
            R1C2 = r1c2;
            R1C3 = r1c3;
            R2C0 = r2c0;
            R2C1 = r2c1;
            R2C2 = r2c2;
            R2C3 = r2c3;
        }

        /// <summary>Multiply matrix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public void Multiply(ref Matrix4d matrix, out Matrix4d result)
        {
            result.R0C0 = matrix.R0C0 * R0C0 + matrix.R0C1 * R1C0 + matrix.R0C2 * R2C0 + matrix.R0C3 * R3C0;
            result.R0C1 = matrix.R0C0 * R0C1 + matrix.R0C1 * R1C1 + matrix.R0C2 * R2C1 + matrix.R0C3 * R3C1;
            result.R0C2 = matrix.R0C0 * R0C2 + matrix.R0C1 * R1C2 + matrix.R0C2 * R2C2 + matrix.R0C3 * R3C2;
            result.R0C3 = matrix.R0C0 * R0C3 + matrix.R0C1 * R1C3 + matrix.R0C2 * R2C3 + matrix.R0C3 * R3C3;
            result.R1C0 = matrix.R1C0 * R0C0 + matrix.R1C1 * R1C0 + matrix.R1C2 * R2C0 + matrix.R1C3 * R3C0;
            result.R1C1 = matrix.R1C0 * R0C1 + matrix.R1C1 * R1C1 + matrix.R1C2 * R2C1 + matrix.R1C3 * R3C1;
            result.R1C2 = matrix.R1C0 * R0C2 + matrix.R1C1 * R1C2 + matrix.R1C2 * R2C2 + matrix.R1C3 * R3C2;
            result.R1C3 = matrix.R1C0 * R0C3 + matrix.R1C1 * R1C3 + matrix.R1C2 * R2C3 + matrix.R1C3 * R3C3;
            result.R2C0 = matrix.R2C0 * R0C0 + matrix.R2C1 * R1C0 + matrix.R2C2 * R2C0 + matrix.R2C3 * R3C0;
            result.R2C1 = matrix.R2C0 * R0C1 + matrix.R2C1 * R1C1 + matrix.R2C2 * R2C1 + matrix.R2C3 * R3C1;
            result.R2C2 = matrix.R2C0 * R0C2 + matrix.R2C1 * R1C2 + matrix.R2C2 * R2C2 + matrix.R2C3 * R3C2;
            result.R2C3 = matrix.R2C0 * R0C3 + matrix.R2C1 * R1C3 + matrix.R2C2 * R2C3 + matrix.R2C3 * R3C3;
            result.R3C0 = matrix.R3C0 * R0C0 + matrix.R3C1 * R1C0 + matrix.R3C2 * R2C0 + matrix.R3C3 * R3C0;
            result.R3C1 = matrix.R3C0 * R0C1 + matrix.R3C1 * R1C1 + matrix.R3C2 * R2C1 + matrix.R3C3 * R3C1;
            result.R3C2 = matrix.R3C0 * R0C2 + matrix.R3C1 * R1C2 + matrix.R3C2 * R2C2 + matrix.R3C3 * R3C2;
            result.R3C3 = matrix.R3C0 * R0C3 + matrix.R3C1 * R1C3 + matrix.R3C2 * R2C3 + matrix.R3C3 * R3C3;

        }

        /// <summary>Multiply left matrix times left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public static void Multiply(ref Matrix4d left, ref Matrix4d right, out Matrix4d result)
        {
            result.R0C0 = right.R0C0 * left.R0C0 + right.R0C1 * left.R1C0 + right.R0C2 * left.R2C0 + right.R0C3 * left.R3C0;
            result.R0C1 = right.R0C0 * left.R0C1 + right.R0C1 * left.R1C1 + right.R0C2 * left.R2C1 + right.R0C3 * left.R3C1;
            result.R0C2 = right.R0C0 * left.R0C2 + right.R0C1 * left.R1C2 + right.R0C2 * left.R2C2 + right.R0C3 * left.R3C2;
            result.R0C3 = right.R0C0 * left.R0C3 + right.R0C1 * left.R1C3 + right.R0C2 * left.R2C3 + right.R0C3 * left.R3C3;
            result.R1C0 = right.R1C0 * left.R0C0 + right.R1C1 * left.R1C0 + right.R1C2 * left.R2C0 + right.R1C3 * left.R3C0;
            result.R1C1 = right.R1C0 * left.R0C1 + right.R1C1 * left.R1C1 + right.R1C2 * left.R2C1 + right.R1C3 * left.R3C1;
            result.R1C2 = right.R1C0 * left.R0C2 + right.R1C1 * left.R1C2 + right.R1C2 * left.R2C2 + right.R1C3 * left.R3C2;
            result.R1C3 = right.R1C0 * left.R0C3 + right.R1C1 * left.R1C3 + right.R1C2 * left.R2C3 + right.R1C3 * left.R3C3;
            result.R2C0 = right.R2C0 * left.R0C0 + right.R2C1 * left.R1C0 + right.R2C2 * left.R2C0 + right.R2C3 * left.R3C0;
            result.R2C1 = right.R2C0 * left.R0C1 + right.R2C1 * left.R1C1 + right.R2C2 * left.R2C1 + right.R2C3 * left.R3C1;
            result.R2C2 = right.R2C0 * left.R0C2 + right.R2C1 * left.R1C2 + right.R2C2 * left.R2C2 + right.R2C3 * left.R3C2;
            result.R2C3 = right.R2C0 * left.R0C3 + right.R2C1 * left.R1C3 + right.R2C2 * left.R2C3 + right.R2C3 * left.R3C3;
            result.R3C0 = right.R3C0 * left.R0C0 + right.R3C1 * left.R1C0 + right.R3C2 * left.R2C0 + right.R3C3 * left.R3C0;
            result.R3C1 = right.R3C0 * left.R0C1 + right.R3C1 * left.R1C1 + right.R3C2 * left.R2C1 + right.R3C3 * left.R3C1;
            result.R3C2 = right.R3C0 * left.R0C2 + right.R3C1 * left.R1C2 + right.R3C2 * left.R2C2 + right.R3C3 * left.R3C2;
            result.R3C3 = right.R3C0 * left.R0C3 + right.R3C1 * left.R1C3 + right.R3C2 * left.R2C3 + right.R3C3 * left.R3C3;
        }


        /// <summary>Multiply matrix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        public void Multiply(double scalar)
        {
            R0C0 = scalar * R0C0;
            R0C1 = scalar * R0C1;
            R0C2 = scalar * R0C2;
            R0C3 = scalar * R0C3;
            R1C0 = scalar * R1C0;
            R1C1 = scalar * R1C1;
            R1C2 = scalar * R1C2;
            R1C3 = scalar * R1C3;
            R2C0 = scalar * R2C0;
            R2C1 = scalar * R2C1;
            R2C2 = scalar * R2C2;
            R2C3 = scalar * R2C3;
            R3C0 = scalar * R3C0;
            R3C1 = scalar * R3C1;
            R3C2 = scalar * R3C2;
            R3C3 = scalar * R3C3;
        }

        /// <summary>Multiply matrix times this matrix.</summary>
        /// <param name="matrix">The matrix to multiply.</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public void Multiply(double scalar, out Matrix4d result)
        {
            result.R0C0 = scalar * R0C0;
            result.R0C1 = scalar * R0C1;
            result.R0C2 = scalar * R0C2;
            result.R0C3 = scalar * R0C3;
            result.R1C0 = scalar * R1C0;
            result.R1C1 = scalar * R1C1;
            result.R1C2 = scalar * R1C2;
            result.R1C3 = scalar * R1C3;
            result.R2C0 = scalar * R2C0;
            result.R2C1 = scalar * R2C1;
            result.R2C2 = scalar * R2C2;
            result.R2C3 = scalar * R2C3;
            result.R3C0 = scalar * R3C0;
            result.R3C1 = scalar * R3C1;
            result.R3C2 = scalar * R3C2;
            result.R3C3 = scalar * R3C3;
        }

        /// <summary>Multiply left matrix times left matrix.</summary>
        /// <param name="matrix">The matrix on the matrix side of the equation.</param>
        /// <param name="right">The matrix on the right side of the equation</param>
        /// <param name="result">The resulting matrix of the multiplication.</param>
        public static void Multiply(ref Matrix4d matrix, double scalar, out Matrix4d result)
        {
            result.R0C0 = scalar * matrix.R0C0;
            result.R0C1 = scalar * matrix.R0C1;
            result.R0C2 = scalar * matrix.R0C2;
            result.R0C3 = scalar * matrix.R0C3;
            result.R1C0 = scalar * matrix.R1C0;
            result.R1C1 = scalar * matrix.R1C1;
            result.R1C2 = scalar * matrix.R1C2;
            result.R1C3 = scalar * matrix.R1C3;
            result.R2C0 = scalar * matrix.R2C0;
            result.R2C1 = scalar * matrix.R2C1;
            result.R2C2 = scalar * matrix.R2C2;
            result.R2C3 = scalar * matrix.R2C3;
            result.R3C0 = scalar * matrix.R3C0;
            result.R3C1 = scalar * matrix.R3C1;
            result.R3C2 = scalar * matrix.R3C2;
            result.R3C3 = scalar * matrix.R3C3;
        }


        #endregion

        #region Functions

        public double Cofacter(int row, int column)
        {
            switch (row)
            {
                case 0:
                    switch (column)
                    {
                        case 0: return +(R1C1 * R2C2 * R3C3 - R1C1 * R2C3 * R3C2 - R1C2 * R2C1 * R3C3 + R1C3 * R2C1 * R3C2 + R1C2 * R2C3 * R3C1 - R1C3 * R2C2 * R3C1);
                        case 1: return -(R1C0 * R2C2 * R3C3 - R1C0 * R2C3 * R3C2 - R1C2 * R2C0 * R3C3 + R1C3 * R2C0 * R3C2 + R1C2 * R2C3 * R3C0 - R1C3 * R2C2 * R3C0);
                        case 2: return +(R1C0 * R2C1 * R3C3 - R1C0 * R2C3 * R3C1 - R1C1 * R2C0 * R3C3 + R1C3 * R2C0 * R3C1 + R1C1 * R2C3 * R3C0 - R1C3 * R2C1 * R3C0);
                        case 3: return -(R1C0 * R2C1 * R3C2 - R1C0 * R2C2 * R3C1 - R1C1 * R2C0 * R3C2 + R1C2 * R2C0 * R3C1 + R1C1 * R2C2 * R3C0 - R1C2 * R2C1 * R3C0);
                    }
                    break;

                case 1:
                    switch (column)
                    {
                        case 0: return -(R0C1 * R2C2 * R3C3 - R0C1 * R2C3 * R3C2 - R0C2 * R2C1 * R3C3 + R0C3 * R2C1 * R3C2 + R0C2 * R2C3 * R3C1 - R0C3 * R2C2 * R3C1);
                        case 1: return +(R0C0 * R2C2 * R3C3 - R0C0 * R2C3 * R3C2 - R0C2 * R2C0 * R3C3 + R0C3 * R2C0 * R3C2 + R0C2 * R2C3 * R3C0 - R0C3 * R2C2 * R3C0);
                        case 2: return -(R0C0 * R2C1 * R3C3 - R0C0 * R2C3 * R3C1 - R0C1 * R2C0 * R3C3 + R0C3 * R2C0 * R3C1 + R0C1 * R2C3 * R3C0 - R0C3 * R2C1 * R3C0);
                        case 3: return +(R0C0 * R2C1 * R3C2 - R0C0 * R2C2 * R3C1 - R0C1 * R2C0 * R3C2 + R0C2 * R2C0 * R3C1 + R0C1 * R2C2 * R3C0 - R0C2 * R2C1 * R3C0);
                    }
                    break;

                case 2:
                    switch (column)
                    {
                        case 0: return +(R0C1 * R1C2 * R3C3 - R0C1 * R1C3 * R3C2 - R0C2 * R1C1 * R3C3 + R0C3 * R1C1 * R3C2 + R0C2 * R1C3 * R3C1 - R0C3 * R1C2 * R3C1);
                        case 1: return -(R0C0 * R1C2 * R3C3 - R0C0 * R1C3 * R3C2 - R0C2 * R1C0 * R3C3 + R0C3 * R1C0 * R3C2 + R0C2 * R1C3 * R3C0 - R0C3 * R1C2 * R3C0);
                        case 2: return +(R0C0 * R1C1 * R3C3 - R0C0 * R1C3 * R3C1 - R0C1 * R1C0 * R3C3 + R0C3 * R1C0 * R3C1 + R0C1 * R1C3 * R3C0 - R0C3 * R1C1 * R3C0);
                        case 3: return -(R0C0 * R1C1 * R3C2 - R0C0 * R1C2 * R3C1 - R0C1 * R1C0 * R3C2 + R0C2 * R1C0 * R3C1 + R0C1 * R1C2 * R3C0 - R0C2 * R1C1 * R3C0);
                    }
                    break;

                case 3:
                    switch (column)
                    {
                        case 0: return -(R0C1 * R1C2 * R2C3 - R0C1 * R1C3 * R2C2 - R0C2 * R1C1 * R2C3 + R0C3 * R1C1 * R2C2 + R0C2 * R1C3 * R2C1 - R0C3 * R1C2 * R2C1);
                        case 1: return +(R0C0 * R1C2 * R2C3 - R0C0 * R1C3 * R2C2 - R0C2 * R1C0 * R2C3 + R0C3 * R1C0 * R2C2 + R0C2 * R1C3 * R2C0 - R0C3 * R1C2 * R2C0);
                        case 2: return -(R0C0 * R1C1 * R2C3 - R0C0 * R1C3 * R2C1 - R0C1 * R1C0 * R2C3 + R0C3 * R1C0 * R2C1 + R0C1 * R1C3 * R2C0 - R0C3 * R1C1 * R2C0);
                        case 3: return +(R0C0 * R1C1 * R2C2 - R0C0 * R1C2 * R2C1 - R0C1 * R1C0 * R2C2 + R0C2 * R1C0 * R2C1 + R0C1 * R1C2 * R2C0 - R0C2 * R1C1 * R2C0);
                    }
                    break;
            }

            throw new IndexOutOfRangeException();
        }

        public double Determinant
        {
            get
            {
                return
                R2C3 * R3C2 * R0C1 * R1C0 - R2C2 * R3C3 * R0C1 * R1C0 - R2C3 * R3C1 * R0C2 * R1C0 + R2C1 * R3C3 * R0C2 * R1C0 +
                R2C2 * R3C1 * R0C3 * R1C0 - R2C1 * R3C2 * R0C3 * R1C0 - R0C0 * R2C3 * R3C2 * R1C1 + R0C0 * R2C2 * R3C3 * R1C1 +
                R2C3 * R3C0 * R0C2 * R1C1 - R2C2 * R3C0 * R0C3 * R1C1 + R0C0 * R2C3 * R3C1 * R1C2 - R0C0 * R2C1 * R3C3 * R1C2 -
                R2C3 * R3C0 * R0C1 * R1C2 + R2C1 * R3C0 * R0C3 * R1C2 - R0C0 * R2C2 * R3C1 * R1C3 + R0C0 * R2C1 * R3C2 * R1C3 +
                R2C2 * R3C0 * R0C1 * R1C3 - R2C1 * R3C0 * R0C2 * R1C3 - R3C3 * R0C2 * R1C1 * R2C0 + R3C2 * R0C3 * R1C1 * R2C0 +
                R3C3 * R0C1 * R1C2 * R2C0 - R3C1 * R0C3 * R1C2 * R2C0 - R3C2 * R0C1 * R1C3 * R2C0 + R3C1 * R0C2 * R1C3 * R2C0;
            }
        }

        public void Minor(int row, int column, out Matrix3d result)
        {
            switch (row)
            {
                case 0:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = R1C1;
                            result.R0C1 = R1C2;
                            result.R0C2 = R1C3;
                            result.R1C0 = R2C1;
                            result.R1C1 = R2C2;
                            result.R1C2 = R2C3;
                            result.R2C0 = R3C1;
                            result.R2C1 = R3C2;
                            result.R2C2 = R3C3;
                            return;

                        case 1:
                            result.R0C0 = R1C0;
                            result.R0C1 = R1C2;
                            result.R0C2 = R1C3;
                            result.R1C0 = R2C0;
                            result.R1C1 = R2C2;
                            result.R1C2 = R2C3;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C2;
                            result.R2C2 = R3C3;
                            return;

                        case 2:
                            result.R0C0 = R1C0;
                            result.R0C1 = R1C1;
                            result.R0C2 = R1C3;
                            result.R1C0 = R2C0;
                            result.R1C1 = R2C1;
                            result.R1C2 = R2C3;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C1;
                            result.R2C2 = R3C3;
                            return;

                        case 3:
                            result.R0C0 = R1C0;
                            result.R0C1 = R1C1;
                            result.R0C2 = R1C2;
                            result.R1C0 = R2C0;
                            result.R1C1 = R2C1;
                            result.R1C2 = R2C2;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C1;
                            result.R2C2 = R3C2;
                            return;
                    }
                    break;

                case 1:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = R0C1;
                            result.R0C1 = R0C2;
                            result.R0C2 = R0C3;
                            result.R1C0 = R2C1;
                            result.R1C1 = R2C2;
                            result.R1C2 = R2C3;
                            result.R2C0 = R3C1;
                            result.R2C1 = R3C2;
                            result.R2C2 = R3C3;
                            return;

                        case 1:
                            result.R0C0 = R0C0;
                            result.R0C1 = R0C2;
                            result.R0C2 = R0C3;
                            result.R1C0 = R2C0;
                            result.R1C1 = R2C2;
                            result.R1C2 = R2C3;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C2;
                            result.R2C2 = R3C3;
                            return;

                        case 2:
                            result.R0C0 = R0C0;
                            result.R0C1 = R0C1;
                            result.R0C2 = R0C3;
                            result.R1C0 = R2C0;
                            result.R1C1 = R2C1;
                            result.R1C2 = R2C3;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C1;
                            result.R2C2 = R3C3;
                            return;
                    }
                    break;

                case 2:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = R0C1;
                            result.R0C1 = R0C2;
                            result.R0C2 = R0C3;
                            result.R1C0 = R1C1;
                            result.R1C1 = R1C2;
                            result.R1C2 = R1C3;
                            result.R2C0 = R3C1;
                            result.R2C1 = R3C2;
                            result.R2C2 = R3C3;
                            return;

                        case 1:
                            result.R0C0 = R0C0;
                            result.R0C1 = R0C2;
                            result.R0C2 = R0C3;
                            result.R1C0 = R1C0;
                            result.R1C1 = R1C2;
                            result.R1C2 = R1C3;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C2;
                            result.R2C2 = R3C3;
                            return;

                        case 2:
                            result.R0C0 = R0C0;
                            result.R0C1 = R0C1;
                            result.R0C2 = R0C3;
                            result.R1C0 = R1C0;
                            result.R1C1 = R1C1;
                            result.R1C2 = R1C3;
                            result.R2C0 = R3C0;
                            result.R2C1 = R3C1;
                            result.R2C2 = R3C3;
                            return;
                    }
                    break;

            }

            throw new IndexOutOfRangeException();
        }
        public static void Minor(ref Matrix4d matrix, int row, int column, out Matrix3d result)
        {
            switch (row)
            {
                case 0:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = matrix.R1C1;
                            result.R0C1 = matrix.R1C2;
                            result.R0C2 = matrix.R1C3;
                            result.R1C0 = matrix.R2C1;
                            result.R1C1 = matrix.R2C2;
                            result.R1C2 = matrix.R2C3;
                            result.R2C0 = matrix.R3C1;
                            result.R2C1 = matrix.R3C2;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 1:
                            result.R0C0 = matrix.R1C0;
                            result.R0C1 = matrix.R1C2;
                            result.R0C2 = matrix.R1C3;
                            result.R1C0 = matrix.R2C0;
                            result.R1C1 = matrix.R2C2;
                            result.R1C2 = matrix.R2C3;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C2;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 2:
                            result.R0C0 = matrix.R1C0;
                            result.R0C1 = matrix.R1C1;
                            result.R0C2 = matrix.R1C3;
                            result.R1C0 = matrix.R2C0;
                            result.R1C1 = matrix.R2C1;
                            result.R1C2 = matrix.R2C3;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C1;
                            result.R2C2 = matrix.R3C3;
                            return;
                    }
                    break;

                case 1:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = matrix.R0C1;
                            result.R0C1 = matrix.R0C2;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R2C1;
                            result.R1C1 = matrix.R2C2;
                            result.R1C2 = matrix.R2C3;
                            result.R2C0 = matrix.R3C1;
                            result.R2C1 = matrix.R3C2;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 1:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C2;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R2C0;
                            result.R1C1 = matrix.R2C2;
                            result.R1C2 = matrix.R2C3;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C2;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 2:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C1;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R2C0;
                            result.R1C1 = matrix.R2C1;
                            result.R1C2 = matrix.R2C3;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C1;
                            result.R2C2 = matrix.R3C3;
                            return;
                    }
                    break;

                case 2:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = matrix.R0C1;
                            result.R0C1 = matrix.R0C2;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R1C1;
                            result.R1C1 = matrix.R1C2;
                            result.R1C2 = matrix.R1C3;
                            result.R2C0 = matrix.R3C1;
                            result.R2C1 = matrix.R3C2;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 1:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C2;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R1C0;
                            result.R1C1 = matrix.R1C2;
                            result.R1C2 = matrix.R1C3;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C2;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 2:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C1;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R1C0;
                            result.R1C1 = matrix.R1C1;
                            result.R1C2 = matrix.R1C3;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C1;
                            result.R2C2 = matrix.R3C3;
                            return;

                        case 3:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C1;
                            result.R0C2 = matrix.R0C2;
                            result.R1C0 = matrix.R1C0;
                            result.R1C1 = matrix.R1C1;
                            result.R1C2 = matrix.R1C2;
                            result.R2C0 = matrix.R3C0;
                            result.R2C1 = matrix.R3C1;
                            result.R2C2 = matrix.R3C2;
                            return;
                    }
                    break;

                case 3:
                    switch (column)
                    {
                        case 0:
                            result.R0C0 = matrix.R0C1;
                            result.R0C1 = matrix.R0C2;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R1C1;
                            result.R1C1 = matrix.R1C2;
                            result.R1C2 = matrix.R1C3;
                            result.R2C0 = matrix.R2C1;
                            result.R2C1 = matrix.R2C2;
                            result.R2C2 = matrix.R2C3;
                            return;

                        case 1:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C2;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R1C0;
                            result.R1C1 = matrix.R1C2;
                            result.R1C2 = matrix.R1C3;
                            result.R2C0 = matrix.R2C0;
                            result.R2C1 = matrix.R2C2;
                            result.R2C2 = matrix.R2C3;
                            return;

                        case 2:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C1;
                            result.R0C2 = matrix.R0C3;
                            result.R1C0 = matrix.R1C0;
                            result.R1C1 = matrix.R1C1;
                            result.R1C2 = matrix.R1C3;
                            result.R2C0 = matrix.R2C0;
                            result.R2C1 = matrix.R2C1;
                            result.R2C2 = matrix.R2C3;
                            return;

                        case 3:
                            result.R0C0 = matrix.R0C0;
                            result.R0C1 = matrix.R0C1;
                            result.R0C2 = matrix.R0C2;
                            result.R1C0 = matrix.R1C0;
                            result.R1C1 = matrix.R1C1;
                            result.R1C2 = matrix.R1C2;
                            result.R2C0 = matrix.R2C0;
                            result.R2C1 = matrix.R2C1;
                            result.R2C2 = matrix.R2C2;
                            return;
                    }
                    break;
            }

            throw new IndexOutOfRangeException();
        }

        public void CofacterMatrix(out Matrix4d result)
        {
            result.R0C0 = Cofacter(0, 0);
            result.R0C1 = Cofacter(0, 1);
            result.R0C2 = Cofacter(0, 2);
            result.R0C3 = Cofacter(0, 3);
            result.R1C0 = Cofacter(1, 0);
            result.R1C1 = Cofacter(1, 1);
            result.R1C2 = Cofacter(1, 2);
            result.R1C3 = Cofacter(1, 3);
            result.R2C0 = Cofacter(2, 0);
            result.R2C1 = Cofacter(2, 1);
            result.R2C2 = Cofacter(2, 2);
            result.R2C3 = Cofacter(2, 3);
            result.R3C0 = Cofacter(3, 0);
            result.R3C1 = Cofacter(3, 1);
            result.R3C2 = Cofacter(3, 2);
            result.R3C3 = Cofacter(3, 3);
        }
        public static void CofacterMatrix(ref Matrix4d matrix, out Matrix4d result)
        {
            result.R0C0 = matrix.Cofacter(0, 0);
            result.R0C1 = matrix.Cofacter(0, 1);
            result.R0C2 = matrix.Cofacter(0, 2);
            result.R0C3 = matrix.Cofacter(0, 3);
            result.R1C0 = matrix.Cofacter(1, 0);
            result.R1C1 = matrix.Cofacter(1, 1);
            result.R1C2 = matrix.Cofacter(1, 2);
            result.R1C3 = matrix.Cofacter(1, 3);
            result.R2C0 = matrix.Cofacter(2, 0);
            result.R2C1 = matrix.Cofacter(2, 1);
            result.R2C2 = matrix.Cofacter(2, 2);
            result.R2C3 = matrix.Cofacter(2, 3);
            result.R3C0 = matrix.Cofacter(3, 0);
            result.R3C1 = matrix.Cofacter(3, 1);
            result.R3C2 = matrix.Cofacter(3, 2);
            result.R3C3 = matrix.Cofacter(3, 3);
        }

        public void Transpose()
        {
            Functions.Swap(ref R0C1, ref R1C0);
            Functions.Swap(ref R0C2, ref R2C0);
            Functions.Swap(ref R0C3, ref R3C0);
            Functions.Swap(ref R1C2, ref R2C1);
            Functions.Swap(ref R1C3, ref R3C1);
            Functions.Swap(ref R2C3, ref R3C2);
        }
        public void Transpose(out Matrix4d result)
        {
            result.R0C0 = R0C0;
            result.R0C1 = R1C0;
            result.R0C2 = R2C0;
            result.R0C3 = R3C0;
            result.R1C0 = R0C1;
            result.R1C1 = R1C1;
            result.R1C2 = R2C1;
            result.R1C3 = R3C1;
            result.R2C0 = R0C2;
            result.R2C1 = R1C2;
            result.R2C2 = R2C2;
            result.R2C3 = R3C2;
            result.R3C0 = R0C3;
            result.R3C1 = R1C3;
            result.R3C2 = R2C3;
            result.R3C3 = R3C3;
        }
        public static void Transpose(ref Matrix4d matrix, out Matrix4d result)
        {
            result.R0C0 = matrix.R0C0;
            result.R0C1 = matrix.R1C0;
            result.R0C2 = matrix.R2C0;
            result.R0C3 = matrix.R3C0;
            result.R1C0 = matrix.R0C1;
            result.R1C1 = matrix.R1C1;
            result.R1C2 = matrix.R2C1;
            result.R1C3 = matrix.R3C1;
            result.R2C0 = matrix.R0C2;
            result.R2C1 = matrix.R1C2;
            result.R2C2 = matrix.R2C2;
            result.R2C3 = matrix.R3C2;
            result.R3C0 = matrix.R0C3;
            result.R3C1 = matrix.R1C3;
            result.R3C2 = matrix.R2C3;
            result.R3C3 = matrix.R3C3;
        }

        public void Adjoint(out Matrix4d result)
        {
            CofacterMatrix(out result);
            result.Transpose();
        }
        public static void Adjoint(ref Matrix4d matrix, out Matrix4d result)
        {
            matrix.CofacterMatrix(out result);
            result.Transpose();
        }

        public void Inverse(out Matrix4d result)
        {
            CofacterMatrix(out result);
            result.Transpose();
            result.Multiply(1 / Determinant);
        }
        public static void Inverse(ref Matrix4d matrix, out Matrix4d result)
        {
            matrix.CofacterMatrix(out result);
            result.Transpose();
            result.Multiply(1 / result.Determinant);
        }

        #endregion

        #region Transformation Functions

        public void Transform(ref Vector4d vector)
        {
            double x = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z + R0C3 * vector.W;
            double y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z + R1C3 * vector.W;
            double z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z + R2C3 * vector.W;
            vector.W = R3C0 * vector.X + R3C1 * vector.Y + R3C2 * vector.Z + R3C3 * vector.W;
            vector.X = x;
            vector.Y = y;
            vector.Z = z;
        }
        public static void Transform(ref Matrix4d matrix, ref Vector4d vector)
        {
            double x = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z + matrix.R0C3 * vector.W;
            double y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z + matrix.R1C3 * vector.W;
            double z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z + matrix.R2C3 * vector.W;
            vector.W = matrix.R3C0 * vector.X + matrix.R3C1 * vector.Y + matrix.R3C2 * vector.Z + matrix.R3C3 * vector.W;
            vector.X = x;
            vector.Y = y;
            vector.Z = z;
        }
        public void Transform(ref Vector4d vector, out Vector4d result)
        {
            result.X = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z + R0C3 * vector.W;
            result.Y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z + R1C3 * vector.W;
            result.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z + R2C3 * vector.W;
            result.W = R3C0 * vector.X + R3C1 * vector.Y + R3C2 * vector.Z + R3C3 * vector.W;
        }
        public static void Transform(ref Matrix4d matrix, ref Vector4d vector, out Vector4d result)
        {
            result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z + matrix.R0C3 * vector.W;
            result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z + matrix.R1C3 * vector.W;
            result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z + matrix.R2C3 * vector.W;
            result.W = matrix.R3C0 * vector.X + matrix.R3C1 * vector.Y + matrix.R3C2 * vector.Z + matrix.R3C3 * vector.W;
        }
        public void Transform(ref Vector3d vector)
        {
            double x = R0C0 * vector.X + R0C1 * vector.Y + R0C2 * vector.Z;
            double y = R1C0 * vector.X + R1C1 * vector.Y + R1C2 * vector.Z;
            vector.Z = R2C0 * vector.X + R2C1 * vector.Y + R2C2 * vector.Z;
            vector.X = x;
            vector.Y = y;
        }
        public static void Transform(ref Matrix4d matrix, ref Vector3d vector)
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
        public static void Transform(ref Matrix4d matrix, ref Vector3d vector, out Vector3d result)
        {
            result.X = matrix.R0C0 * vector.X + matrix.R0C1 * vector.Y + matrix.R0C2 * vector.Z;
            result.Y = matrix.R1C0 * vector.X + matrix.R1C1 * vector.Y + matrix.R1C2 * vector.Z;
            result.Z = matrix.R2C0 * vector.X + matrix.R2C1 * vector.Y + matrix.R2C2 * vector.Z;
        }

        public void RotateX(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double r1c0 = cos * R1C0 + sin * R2C0;
            double r1c1 = cos * R1C1 + sin * R2C1;
            double r1c2 = cos * R1C2 + sin * R2C2;
            double r1c3 = cos * R1C3 + sin * R2C3;

            R2C0 = cos * R2C0 - sin * R1C0;
            R2C1 = cos * R2C1 - sin * R1C1;
            R2C2 = cos * R2C2 - sin * R1C2;
            R2C3 = cos * R2C3 - sin * R1C3;

            R1C0 = r1c0;
            R1C1 = r1c1;
            R1C2 = r1c2;
            R1C3 = r1c3;
        }
        public void RotateX(double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = R0C0;
            result.R0C1 = R0C1;
            result.R0C2 = R0C2;
            result.R0C3 = R0C3;
            result.R1C0 = cos * R1C0 + sin * R2C0;
            result.R1C1 = cos * R1C1 + sin * R2C1;
            result.R1C2 = cos * R1C2 + sin * R2C2;
            result.R1C3 = cos * R1C3 + sin * R2C3;
            result.R2C0 = cos * R2C0 - sin * R1C0;
            result.R2C1 = cos * R2C1 - sin * R1C1;
            result.R2C2 = cos * R2C2 - sin * R1C2;
            result.R2C3 = cos * R2C3 - sin * R1C3;
            result.R3C0 = R3C0;
            result.R3C1 = R3C1;
            result.R3C2 = R3C2;
            result.R3C3 = R3C3;
        }
        public static void RotateX(ref Matrix4d matrix, double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = matrix.R0C0;
            result.R0C1 = matrix.R0C1;
            result.R0C2 = matrix.R0C2;
            result.R0C3 = matrix.R0C3;
            result.R1C0 = cos * matrix.R1C0 + sin * matrix.R2C0;
            result.R1C1 = cos * matrix.R1C1 + sin * matrix.R2C1;
            result.R1C2 = cos * matrix.R1C2 + sin * matrix.R2C2;
            result.R1C3 = cos * matrix.R1C3 + sin * matrix.R2C3;
            result.R2C0 = cos * matrix.R2C0 - sin * matrix.R1C0;
            result.R2C1 = cos * matrix.R2C1 - sin * matrix.R1C1;
            result.R2C2 = cos * matrix.R2C2 - sin * matrix.R1C2;
            result.R2C3 = cos * matrix.R2C3 - sin * matrix.R1C3;
            result.R3C0 = matrix.R3C0;
            result.R3C1 = matrix.R3C1;
            result.R3C2 = matrix.R3C2;
            result.R3C3 = matrix.R3C3;
        }
        public static void RotateXMatrix(double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = 1;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = cos;
            result.R1C2 = sin;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = -sin;
            result.R2C2 = cos;
            result.R2C3 = 0;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = 0;
            result.R3C3 = 1;
        }

        public void RotateY(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double r0c0 = cos * R0C0 - sin * R2C0;
            double r0c1 = cos * R0C1 - sin * R2C1;
            double r0c2 = cos * R0C2 - sin * R2C2;
            double r0c3 = cos * R0C3 - sin * R2C3;

            R2C0 = sin * R0C0 + cos * R2C0;
            R2C1 = sin * R0C1 + cos * R2C1;
            R2C2 = sin * R0C2 + cos * R2C2;
            R2C3 = sin * R0C3 + cos * R2C3;

            R0C0 = r0c0;
            R0C1 = r0c1;
            R0C2 = r0c2;
            R0C3 = r0c3;

        }
        public void RotateY(double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos * R0C0 - sin * R2C0;
            result.R0C1 = cos * R0C1 - sin * R2C1;
            result.R0C2 = cos * R0C2 - sin * R2C2;
            result.R0C3 = cos * R0C3 - sin * R2C3;
            result.R1C0 = R1C0;
            result.R1C1 = R1C1;
            result.R1C2 = R1C2;
            result.R1C3 = R1C3;
            result.R2C0 = sin * R0C0 + cos * R2C0;
            result.R2C1 = sin * R0C1 + cos * R2C1;
            result.R2C2 = sin * R0C2 + cos * R2C2;
            result.R2C3 = sin * R0C3 + cos * R2C3;
            result.R3C0 = R3C0;
            result.R3C1 = R3C1;
            result.R3C2 = R3C2;
            result.R3C3 = R3C3;
        }
        public static void RotateY(ref Matrix4d matrix, double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos * matrix.R0C0 - sin * matrix.R2C0;
            result.R0C1 = cos * matrix.R0C1 - sin * matrix.R2C1;
            result.R0C2 = cos * matrix.R0C2 - sin * matrix.R2C2;
            result.R0C3 = cos * matrix.R0C3 - sin * matrix.R2C3;
            result.R1C0 = matrix.R1C0;
            result.R1C1 = matrix.R1C1;
            result.R1C2 = matrix.R1C2;
            result.R1C3 = matrix.R1C3;
            result.R2C0 = sin * matrix.R0C0 + cos * matrix.R2C0;
            result.R2C1 = sin * matrix.R0C1 + cos * matrix.R2C1;
            result.R2C2 = sin * matrix.R0C2 + cos * matrix.R2C2;
            result.R2C3 = sin * matrix.R0C3 + cos * matrix.R2C3;
            result.R3C0 = matrix.R3C0;
            result.R3C1 = matrix.R3C1;
            result.R3C2 = matrix.R3C2;
            result.R3C3 = matrix.R3C3;
        }
        public static void RotateYMatrix(double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos;
            result.R0C1 = 0;
            result.R0C2 = -sin;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = 1;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = sin;
            result.R2C1 = 0;
            result.R2C2 = cos;
            result.R2C3 = 0;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = 0;
            result.R3C3 = 1;
        }

        public void RotateZ(double angle)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            double r0c0 = cos * R0C0 + sin * R1C0;
            double r0c1 = cos * R0C1 + sin * R1C1;
            double r0c2 = cos * R0C2 + sin * R1C2;
            double r0c3 = cos * R0C3 + sin * R1C3;

            R1C0 = cos * R1C0 - sin * R0C0;
            R1C1 = cos * R1C1 - sin * R0C1;
            R1C2 = cos * R1C2 - sin * R0C2;
            R1C3 = cos * R1C3 - sin * R0C3;

            R0C0 = r0c0;
            R0C1 = r0c1;
            R0C2 = r0c2;
            R0C3 = r0c3;
        }
        public void RotateZ(double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos * R0C0 + sin * R1C0;
            result.R0C1 = cos * R0C1 + sin * R1C1;
            result.R0C2 = cos * R0C2 + sin * R1C2;
            result.R0C3 = cos * R0C3 + sin * R1C3;
            result.R1C0 = cos * R1C0 - sin * R0C0;
            result.R1C1 = cos * R1C1 - sin * R0C1;
            result.R1C2 = cos * R1C2 - sin * R0C2;
            result.R1C3 = cos * R1C3 - sin * R0C3;
            result.R2C0 = R2C0;
            result.R2C1 = R2C1;
            result.R2C2 = R2C2;
            result.R2C3 = R2C3;
            result.R3C0 = R3C0;
            result.R3C1 = R3C1;
            result.R3C2 = R3C2;
            result.R3C3 = R3C3;
        }
        public static void RotateZ(ref Matrix4d matrix, double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos * matrix.R0C0 + sin * matrix.R1C0;
            result.R0C1 = cos * matrix.R0C1 + sin * matrix.R1C1;
            result.R0C2 = cos * matrix.R0C2 + sin * matrix.R1C2;
            result.R0C3 = cos * matrix.R0C3 + sin * matrix.R1C3;
            result.R1C0 = cos * matrix.R1C0 - sin * matrix.R0C0;
            result.R1C1 = cos * matrix.R1C1 - sin * matrix.R0C1;
            result.R1C2 = cos * matrix.R1C2 - sin * matrix.R0C2;
            result.R1C3 = cos * matrix.R1C3 - sin * matrix.R0C3;
            result.R2C0 = matrix.R2C0;
            result.R2C1 = matrix.R2C1;
            result.R2C2 = matrix.R2C2;
            result.R2C3 = matrix.R2C3;
            result.R3C0 = matrix.R3C0;
            result.R3C1 = matrix.R3C1;
            result.R3C2 = matrix.R3C2;
            result.R3C3 = matrix.R3C3;
        }
        public static void RotateZMatrix(double angle, out Matrix4d result)
        {
            double angleRadians = Functions.DTOR * angle;
            double sin = (double)System.Math.Sin(angleRadians);
            double cos = (double)System.Math.Cos(angleRadians);

            result.R0C0 = cos;
            result.R0C1 = sin;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = -sin;
            result.R1C1 = cos;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = 1;
            result.R2C3 = 0;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = 0;
            result.R3C3 = 1;
        }

        public void Rotate(ref Vector3d axis, double angle)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            double rotateR0C0 = xxOneMinusCos + cos;
            double rotateR0C1 = xyOneMinusCos + zSin;
            double rotateR0C2 = xzOneMinusCos - ySin;
            double rotateR1C0 = xyOneMinusCos - zSin;
            double rotateR1C1 = yyOneMinusCos + cos;
            double rotateR1C2 = yzOneMinusCos + xSin;
            double rotateR2C0 = xzOneMinusCos + ySin;
            double rotateR2C1 = yzOneMinusCos - xSin;
            double rotateR2C2 = zzOneMinusCos + cos;

            double r0c0 = rotateR0C0 * R0C0 + rotateR0C1 * R1C0 + rotateR0C2 * R2C0;
            double r0c1 = rotateR0C0 * R0C1 + rotateR0C1 * R1C1 + rotateR0C2 * R2C1;
            double r0c2 = rotateR0C0 * R0C2 + rotateR0C1 * R1C2 + rotateR0C2 * R2C2;
            double r0c3 = rotateR0C0 * R0C3 + rotateR0C1 * R1C3 + rotateR0C2 * R2C3;

            double r1c0 = rotateR1C0 * R0C0 + rotateR1C1 * R1C0 + rotateR1C2 * R2C0;
            double r1c1 = rotateR1C0 * R0C1 + rotateR1C1 * R1C1 + rotateR1C2 * R2C1;
            double r1c2 = rotateR1C0 * R0C2 + rotateR1C1 * R1C2 + rotateR1C2 * R2C2;
            double r1c3 = rotateR1C0 * R0C3 + rotateR1C1 * R1C3 + rotateR1C2 * R2C3;

            R2C0 = rotateR2C0 * R0C0 + rotateR2C1 * R1C0 + rotateR2C2 * R2C0;
            R2C1 = rotateR2C0 * R0C1 + rotateR2C1 * R1C1 + rotateR2C2 * R2C1;
            R2C2 = rotateR2C0 * R0C2 + rotateR2C1 * R1C2 + rotateR2C2 * R2C2;
            R2C3 = rotateR2C0 * R0C3 + rotateR2C1 * R1C3 + rotateR2C2 * R2C3;

            R0C0 = r0c0;
            R0C1 = r0c1;
            R0C2 = r0c2;
            R0C3 = r0c3;

            R1C0 = r1c0;
            R1C1 = r1c1;
            R1C2 = r1c2;
            R1C3 = r1c3;
        }
        public void Rotate(ref Vector3d axis, double angle, out Matrix4d result)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            double rotateR0C0 = xxOneMinusCos + cos;
            double rotateR0C1 = xyOneMinusCos + zSin;
            double rotateR0C2 = xzOneMinusCos - ySin;
            double rotateR1C0 = xyOneMinusCos - zSin;
            double rotateR1C1 = yyOneMinusCos + cos;
            double rotateR1C2 = yzOneMinusCos + xSin;
            double rotateR2C0 = xzOneMinusCos + ySin;
            double rotateR2C1 = yzOneMinusCos - xSin;
            double rotateR2C2 = zzOneMinusCos + cos;

            result.R0C0 = rotateR0C0 * R0C0 + rotateR0C1 * R1C0 + rotateR0C2 * R2C0;
            result.R0C1 = rotateR0C0 * R0C1 + rotateR0C1 * R1C1 + rotateR0C2 * R2C1;
            result.R0C2 = rotateR0C0 * R0C2 + rotateR0C1 * R1C2 + rotateR0C2 * R2C2;
            result.R0C3 = rotateR0C0 * R0C3 + rotateR0C1 * R1C3 + rotateR0C2 * R2C3;
            result.R1C0 = rotateR1C0 * R0C0 + rotateR1C1 * R1C0 + rotateR1C2 * R2C0;
            result.R1C1 = rotateR1C0 * R0C1 + rotateR1C1 * R1C1 + rotateR1C2 * R2C1;
            result.R1C2 = rotateR1C0 * R0C2 + rotateR1C1 * R1C2 + rotateR1C2 * R2C2;
            result.R1C3 = rotateR1C0 * R0C3 + rotateR1C1 * R1C3 + rotateR1C2 * R2C3;
            result.R2C0 = rotateR2C0 * R0C0 + rotateR2C1 * R1C0 + rotateR2C2 * R2C0;
            result.R2C1 = rotateR2C0 * R0C1 + rotateR2C1 * R1C1 + rotateR2C2 * R2C1;
            result.R2C2 = rotateR2C0 * R0C2 + rotateR2C1 * R1C2 + rotateR2C2 * R2C2;
            result.R2C3 = rotateR2C0 * R0C3 + rotateR2C1 * R1C3 + rotateR2C2 * R2C3;
            result.R3C0 = R3C0;
            result.R3C1 = R3C1;
            result.R3C2 = R3C2;
            result.R3C3 = R3C3;
        }
        public static void Rotate(ref Matrix4d matrix, ref Vector3d axis, double angle, out Matrix4d result)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            double rotateR0C0 = xxOneMinusCos + cos;
            double rotateR0C1 = xyOneMinusCos + zSin;
            double rotateR0C2 = xzOneMinusCos - ySin;
            double rotateR1C0 = xyOneMinusCos - zSin;
            double rotateR1C1 = yyOneMinusCos + cos;
            double rotateR1C2 = yzOneMinusCos + xSin;
            double rotateR2C0 = xzOneMinusCos + ySin;
            double rotateR2C1 = yzOneMinusCos - xSin;
            double rotateR2C2 = zzOneMinusCos + cos;


            result.R0C0 = rotateR0C0 * matrix.R0C0 + rotateR0C1 * matrix.R1C0 + rotateR0C2 * matrix.R2C0;
            result.R0C1 = rotateR0C0 * matrix.R0C1 + rotateR0C1 * matrix.R1C1 + rotateR0C2 * matrix.R2C1;
            result.R0C2 = rotateR0C0 * matrix.R0C2 + rotateR0C1 * matrix.R1C2 + rotateR0C2 * matrix.R2C2;
            result.R0C3 = rotateR0C0 * matrix.R0C3 + rotateR0C1 * matrix.R1C3 + rotateR0C2 * matrix.R2C3;
            result.R1C0 = rotateR1C0 * matrix.R0C0 + rotateR1C1 * matrix.R1C0 + rotateR1C2 * matrix.R2C0;
            result.R1C1 = rotateR1C0 * matrix.R0C1 + rotateR1C1 * matrix.R1C1 + rotateR1C2 * matrix.R2C1;
            result.R1C2 = rotateR1C0 * matrix.R0C2 + rotateR1C1 * matrix.R1C2 + rotateR1C2 * matrix.R2C2;
            result.R1C3 = rotateR1C0 * matrix.R0C3 + rotateR1C1 * matrix.R1C3 + rotateR1C2 * matrix.R2C3;
            result.R2C0 = rotateR2C0 * matrix.R0C0 + rotateR2C1 * matrix.R1C0 + rotateR2C2 * matrix.R2C0;
            result.R2C1 = rotateR2C0 * matrix.R0C1 + rotateR2C1 * matrix.R1C1 + rotateR2C2 * matrix.R2C1;
            result.R2C2 = rotateR2C0 * matrix.R0C2 + rotateR2C1 * matrix.R1C2 + rotateR2C2 * matrix.R2C2;
            result.R2C3 = rotateR2C0 * matrix.R0C3 + rotateR2C1 * matrix.R1C3 + rotateR2C2 * matrix.R2C3;
            result.R3C0 = matrix.R3C0;
            result.R3C1 = matrix.R3C1;
            result.R3C2 = matrix.R3C2;
            result.R3C3 = matrix.R3C3;
        }
        public static void RotateMatrix(ref Vector3d axis, double angle, out Matrix4d result)
        {
            Vector3d axisNormalized;
            axis.Normalize(out axisNormalized);
            double x = axisNormalized.X;
            double y = axisNormalized.Y;
            double z = axisNormalized.Z;
            double angleRadians = Functions.DTOR * angle;
            double cos = (double)System.Math.Cos(angleRadians);
            double sin = (double)System.Math.Sin(angleRadians);
            double oneMinusCos = 1 - cos;
            double xOneMinusCos = x * oneMinusCos;
            double yOneMinusCos = y * oneMinusCos;
            double zOneMinusCos = z * oneMinusCos;
            double xxOneMinusCos = x * xOneMinusCos;
            double xyOneMinusCos = x * yOneMinusCos;
            double xzOneMinusCos = x * zOneMinusCos;
            double yyOneMinusCos = y * yOneMinusCos;
            double yzOneMinusCos = y * zOneMinusCos;
            double zzOneMinusCos = z * zOneMinusCos;
            double xSin = x * sin;
            double ySin = y * sin;
            double zSin = z * sin;

            result.R0C0 = xxOneMinusCos + cos;
            result.R0C1 = xyOneMinusCos + zSin;
            result.R0C2 = xzOneMinusCos - ySin;
            result.R0C3 = 0;
            result.R1C0 = xyOneMinusCos - zSin;
            result.R1C1 = yyOneMinusCos + cos;
            result.R1C2 = yzOneMinusCos + xSin;
            result.R1C3 = 0;
            result.R2C0 = xzOneMinusCos + ySin;
            result.R2C1 = yzOneMinusCos - xSin;
            result.R2C2 = zzOneMinusCos + cos;
            result.R2C3 = 0;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = 0;
            result.R3C3 = 1;
        }

        public void Translate(double x, double y, double z)
        {
            R3C0 = x * R0C0 + y * R1C0 + z * R2C0 + R3C0;
            R3C1 = x * R0C1 + y * R1C1 + z * R2C1 + R3C1;
            R3C2 = x * R0C2 + y * R1C2 + z * R2C2 + R3C2;
            R3C3 = x * R0C3 + y * R1C3 + z * R2C3 + R3C3;
        }
        public void Translate(double x, double y, double z, out Matrix4d result)
        {
            result.R0C0 = R0C0;
            result.R0C1 = R0C1;
            result.R0C2 = R0C2;
            result.R0C3 = R0C3;
            result.R1C0 = R1C0;
            result.R1C1 = R1C1;
            result.R1C2 = R1C2;
            result.R1C3 = R1C3;
            result.R2C0 = R2C0;
            result.R2C1 = R2C1;
            result.R2C2 = R2C2;
            result.R2C3 = R2C3;
            result.R3C0 = x * R0C0 + y * R1C0 + z * R2C0 + R3C0;
            result.R3C1 = x * R0C1 + y * R1C1 + z * R2C1 + R3C1;
            result.R3C2 = x * R0C2 + y * R1C2 + z * R2C2 + R3C2;
            result.R3C3 = x * R0C3 + y * R1C3 + z * R2C3 + R3C3;
        }
        public static void Translate(ref Matrix4d matrix, double x, double y, double z, out Matrix4d result)
        {
            result.R0C0 = matrix.R0C0;
            result.R0C1 = matrix.R0C1;
            result.R0C2 = matrix.R0C2;
            result.R0C3 = matrix.R0C3;
            result.R1C0 = matrix.R1C0;
            result.R1C1 = matrix.R1C1;
            result.R1C2 = matrix.R1C2;
            result.R1C3 = matrix.R1C3;
            result.R2C0 = matrix.R2C0;
            result.R2C1 = matrix.R2C1;
            result.R2C2 = matrix.R2C2;
            result.R2C3 = matrix.R2C3;
            result.R3C0 = x * matrix.R0C0 + y * matrix.R1C0 + z * matrix.R2C0 + matrix.R3C0;
            result.R3C1 = x * matrix.R0C1 + y * matrix.R1C1 + z * matrix.R2C1 + matrix.R3C1;
            result.R3C2 = x * matrix.R0C2 + y * matrix.R1C2 + z * matrix.R2C2 + matrix.R3C2;
            result.R3C3 = x * matrix.R0C3 + y * matrix.R1C3 + z * matrix.R2C3 + matrix.R3C3;
        }
        public static void TranslateMatrix(double x, double y, double z, out Matrix4d result)
        {
            result.R0C0 = 1;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = 1;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = 1;
            result.R2C3 = 0;
            result.R3C0 = x;
            result.R3C1 = y;
            result.R3C2 = z;
            result.R3C3 = 1;
        }

        public void Translate(ref Vector3d vector)
        {
            R3C0 = vector.X * R0C0 + vector.Y * R1C0 + vector.Z * R2C0 + R3C0;
            R3C1 = vector.X * R0C1 + vector.Y * R1C1 + vector.Z * R2C1 + R3C1;
            R3C2 = vector.X * R0C2 + vector.Y * R1C2 + vector.Z * R2C2 + R3C2;
            R3C3 = vector.X * R0C3 + vector.Y * R1C3 + vector.Z * R2C3 + R3C3;
        }
        public void Translate(ref Vector3d vector, out Matrix4d result)
        {
            result.R0C0 = R0C0;
            result.R0C1 = R0C1;
            result.R0C2 = R0C2;
            result.R0C3 = R0C3;
            result.R1C0 = R1C0;
            result.R1C1 = R1C1;
            result.R1C2 = R1C2;
            result.R1C3 = R1C3;
            result.R2C0 = R2C0;
            result.R2C1 = R2C1;
            result.R2C2 = R2C2;
            result.R2C3 = R2C3;
            result.R3C0 = vector.X * R0C0 + vector.Y * R1C0 + vector.Z * R2C0 + R3C0;
            result.R3C1 = vector.X * R0C1 + vector.Y * R1C1 + vector.Z * R2C1 + R3C1;
            result.R3C2 = vector.X * R0C2 + vector.Y * R1C2 + vector.Z * R2C2 + R3C2;
            result.R3C3 = vector.X * R0C3 + vector.Y * R1C3 + vector.Z * R2C3 + R3C3;
        }
        public static void Translate(ref Matrix4d matrix, ref Vector3d vector, out Matrix4d result)
        {
            result.R0C0 = matrix.R0C0;
            result.R0C1 = matrix.R0C1;
            result.R0C2 = matrix.R0C2;
            result.R0C3 = matrix.R0C3;
            result.R1C0 = matrix.R1C0;
            result.R1C1 = matrix.R1C1;
            result.R1C2 = matrix.R1C2;
            result.R1C3 = matrix.R1C3;
            result.R2C0 = matrix.R2C0;
            result.R2C1 = matrix.R2C1;
            result.R2C2 = matrix.R2C2;
            result.R2C3 = matrix.R2C3;
            result.R3C0 = vector.X * matrix.R0C0 + vector.Y * matrix.R1C0 + vector.Z * matrix.R2C0 + matrix.R3C0;
            result.R3C1 = vector.X * matrix.R0C1 + vector.Y * matrix.R1C1 + vector.Z * matrix.R2C1 + matrix.R3C1;
            result.R3C2 = vector.X * matrix.R0C2 + vector.Y * matrix.R1C2 + vector.Z * matrix.R2C2 + matrix.R3C2;
            result.R3C3 = vector.X * matrix.R0C3 + vector.Y * matrix.R1C3 + vector.Z * matrix.R2C3 + matrix.R3C3;
        }
        public static void TranslateMatrix(ref Vector3d vector, out Matrix4d result)
        {
            result.R0C0 = 1;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = 1;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = 1;
            result.R2C3 = 0;
            result.R3C0 = vector.X;
            result.R3C1 = vector.Y;
            result.R3C2 = vector.Z;
            result.R3C3 = 1;
        }

        public void Scale(double x, double y, double z)
        {
            R0C0 = x * R0C0;
            R0C1 = x * R0C1;
            R0C2 = x * R0C2;
            R0C3 = x * R0C3;
            R1C0 = y * R1C0;
            R1C1 = y * R1C1;
            R1C2 = y * R1C2;
            R1C3 = y * R1C3;
            R2C0 = z * R2C0;
            R2C1 = z * R2C1;
            R2C2 = z * R2C2;
            R2C3 = z * R2C3;
        }
        public void Scale(double x, double y, double z, out Matrix4d result)
        {
            result.R0C0 = x * R0C0;
            result.R0C1 = x * R0C1;
            result.R0C2 = x * R0C2;
            result.R0C3 = x * R0C3;
            result.R1C0 = y * R1C0;
            result.R1C1 = y * R1C1;
            result.R1C2 = y * R1C2;
            result.R1C3 = y * R1C3;
            result.R2C0 = z * R2C0;
            result.R2C1 = z * R2C1;
            result.R2C2 = z * R2C2;
            result.R2C3 = z * R2C3;
            result.R3C0 = R3C0;
            result.R3C1 = R3C1;
            result.R3C2 = R3C2;
            result.R3C3 = R3C3;
        }
        public static void Scale(ref Matrix4d matrix, double x, double y, double z, out Matrix4d result)
        {
            result.R0C0 = x * matrix.R0C0;
            result.R0C1 = x * matrix.R0C1;
            result.R0C2 = x * matrix.R0C2;
            result.R0C3 = x * matrix.R0C3;
            result.R1C0 = y * matrix.R1C0;
            result.R1C1 = y * matrix.R1C1;
            result.R1C2 = y * matrix.R1C2;
            result.R1C3 = y * matrix.R1C3;
            result.R2C0 = z * matrix.R2C0;
            result.R2C1 = z * matrix.R2C1;
            result.R2C2 = z * matrix.R2C2;
            result.R2C3 = z * matrix.R2C3;
            result.R3C0 = matrix.R3C0;
            result.R3C1 = matrix.R3C1;
            result.R3C2 = matrix.R3C2;
            result.R3C3 = matrix.R3C3;
        }
        public static void ScaleMatrix(double x, double y, double z, out Matrix4d result)
        {
            result.R0C0 = x;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = y;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = z;
            result.R2C3 = 0;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = 0;
            result.R3C3 = 1;
        }

        public void Scale(ref Vector3d vector)
        {
            R0C0 = vector.X * R0C0;
            R0C1 = vector.X * R0C1;
            R0C2 = vector.X * R0C2;
            R0C3 = vector.X * R0C3;
            R1C0 = vector.Y * R1C0;
            R1C1 = vector.Y * R1C1;
            R1C2 = vector.Y * R1C2;
            R1C3 = vector.Y * R1C3;
            R2C0 = vector.Z * R2C0;
            R2C1 = vector.Z * R2C1;
            R2C2 = vector.Z * R2C2;
            R2C3 = vector.Z * R2C3;
        }
        public void Scale(ref Vector3d vector, out Matrix4d result)
        {
            result.R0C0 = vector.X * R0C0;
            result.R0C1 = vector.X * R0C1;
            result.R0C2 = vector.X * R0C2;
            result.R0C3 = vector.X * R0C3;
            result.R1C0 = vector.Y * R1C0;
            result.R1C1 = vector.Y * R1C1;
            result.R1C2 = vector.Y * R1C2;
            result.R1C3 = vector.Y * R1C3;
            result.R2C0 = vector.Z * R2C0;
            result.R2C1 = vector.Z * R2C1;
            result.R2C2 = vector.Z * R2C2;
            result.R2C3 = vector.Z * R2C3;
            result.R3C0 = R3C0;
            result.R3C1 = R3C1;
            result.R3C2 = R3C2;
            result.R3C3 = R3C3;
        }
        public static void Scale(ref Matrix4d matrix, ref Vector3d vector, out Matrix4d result)
        {
            result.R0C0 = vector.X * matrix.R0C0;
            result.R0C1 = vector.X * matrix.R0C1;
            result.R0C2 = vector.X * matrix.R0C2;
            result.R0C3 = vector.X * matrix.R0C3;
            result.R1C0 = vector.Y * matrix.R1C0;
            result.R1C1 = vector.Y * matrix.R1C1;
            result.R1C2 = vector.Y * matrix.R1C2;
            result.R1C3 = vector.Y * matrix.R1C3;
            result.R2C0 = vector.Z * matrix.R2C0;
            result.R2C1 = vector.Z * matrix.R2C1;
            result.R2C2 = vector.Z * matrix.R2C2;
            result.R2C3 = vector.Z * matrix.R2C3;
            result.R3C0 = matrix.R3C0;
            result.R3C1 = matrix.R3C1;
            result.R3C2 = matrix.R3C2;
            result.R3C3 = matrix.R3C3;
        }
        public static void ScaleMatrix(ref Vector3d vector, out Matrix4d result)
        {
            result.R0C0 = vector.X;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = vector.Y;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = vector.Z;
            result.R2C3 = 0;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = 0;
            result.R3C3 = 1;
        }

        /// <summary>Gets left viewing matrix derived from an eye point, left reference point indicating the center of the scene, and an UP vector.</summary>
        /// <param name="eyeX">The eye position X coordinate.</param>
        /// <param name="eyeY">The eye position Y coordinate.</param>
        /// <param name="eyeZ">The eye position Z coordinate.</param>
        /// <param name="centerX">The center position X coordinate.</param>
        /// <param name="centerY">The center position Y coordinate.</param>
        /// <param name="centerZ">The center position Z coordinate.</param>
        /// <param name="upX">The up direction X coordinate.</param>
        /// <param name="upY">The up direction Y coordinate.</param>
        /// <param name="upZ">The up direction Z coordinate.</param>
        /// <returns>A viewing matrix derived from an eye point, left reference point indicating the center of the scene, and an UP vector.</returns>
        public static void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ, out Matrix4d result)
        {
            Vector3d eye = new Vector3d(eyeX, eyeY, eyeZ);
            Vector3d center = new Vector3d(centerX, centerY, centerZ);
            Vector3d up = new Vector3d(upX, upY, upZ);
            LookAt(ref eye, ref center, ref up, out result);
        }

        /// <summary>Gets left viewing matrix derived from an eye point, left reference point indicating the center of the scene, and an UP vector.</summary>
        /// <param name="eye">The position of the eye.</param>
        /// <param name="center">The position of reference point.</param>
        /// <param name="up">The direction of the up vector</param>
        /// <returns>A viewing matrix derived from an eye point, left reference point indicating the center of the scene, and an UP vector.</returns>
        public static void LookAt(ref Vector3d eye, ref Vector3d center, ref Vector3d up, out Matrix4d result)
        {
            Vector3d f;
            center.Subtract(ref eye, out f);
            f.Normalize();

            Vector3d upNormalized;
            up.Normalize(out upNormalized);

            Vector3d s;
            Vector3d.CrossProduct(ref f, ref upNormalized, out s);
            s.Normalize();

            Vector3d u;
            Vector3d.CrossProduct(ref s, ref f, out u);

            result.R0C0 = s.X;
            result.R0C1 = u.X;
            result.R0C2 = -f.X;
            result.R0C3 = 0;
            result.R1C0 = s.Y;
            result.R1C1 = u.Y;
            result.R1C2 = -f.Y;
            result.R1C3 = 0;
            result.R2C0 = s.Z;
            result.R2C1 = u.Z;
            result.R2C2 = -f.Z;
            result.R2C3 = 0;
            result.R3C0 = -eye.X * s.X - eye.Y * s.Y - eye.Z * s.Z;
            result.R3C1 = -eye.X * u.X - eye.Y * u.Y - eye.Z * u.Z;
            result.R3C2 = +eye.X * f.X + eye.Y * f.Y + eye.Z * f.Z;
            result.R3C3 = 1;
        }

        /// <summary>Gets left perspective matrix that produces left perspective projection.</summary>
        /// <param name="matrix">The matrix vertical clipping plane.</param>
        /// <param name="right">The right vertical clipping plane.</param>
        /// <param name="bottom">The bottom horizontal clipping plane.</param>
        /// <param name="top">The top horizontal clipping plane.</param>
        /// <param name="near">The distances to the near depth clipping plane. Must be positive.</param>
        /// <param name="far">The distances to the far depth clipping plane. Must be positive.</param>
        /// <returns>A perspective matrix for the perspective projection.</returns>
        public static void Frustum(double left, double right, double bottom, double top, double near, double far, out Matrix4d result)
        {
            double horizontalDelta = right - left;
            double verticalDelta = top - bottom;
            double negativeDepthDelta = -(far - near);
            double near2 = near * 2;

            result.R0C0 = near2 / horizontalDelta;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = near2 / verticalDelta;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = (right + left) / horizontalDelta;
            result.R2C1 = (top + bottom) / verticalDelta;
            result.R2C2 = (far + near) / negativeDepthDelta;
            result.R2C3 = -1;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = near2 * far / negativeDepthDelta;
            result.R3C3 = 0;
        }

        /// <summary>Gets left viewing frustum into the world coordinate system.</summary>
        /// <param name="fovy">The field of view angle, in degrees, in the y direction.</param>
        /// <param name="aspect">the aspect ratio that determines the field of view in the x direction.  The aspect ratio is the ratio of x (width) to y (height).</param>
        /// <param name="near">the distance from the viewer to the near clipping plane (always positive).</param>
        /// <param name="far">the distance from the viewer to the far clipping plane (always positive).</param>
        /// <returns>A viewing frustum into the world coordinate system.</returns>
        public static void Perspective(double fovy, double aspect, double near, double far, out Matrix4d result)
        {
            double cot = System.Math.Tan(fovy * Functions.DTOR / 2.0d);
            double f = 1 / cot;

            result.R0C0 = f / aspect;
            result.R0C1 = 0;
            result.R0C2 = 0;
            result.R0C3 = 0;
            result.R1C0 = 0;
            result.R1C1 = f;
            result.R1C2 = 0;
            result.R1C3 = 0;
            result.R2C0 = 0;
            result.R2C1 = 0;
            result.R2C2 = (far + near) / (near - far);
            result.R2C3 = -1;
            result.R3C0 = 0;
            result.R3C1 = 0;
            result.R3C2 = (2 * far * near) / (near - far);
            result.R3C3 = 0;
        }

        public void Quaternion(out Quaterniond quaternion)
        {
            quaternion = new Quaterniond(ref this);
        }

        #endregion

        #region Constants

        /// <summary>The identity matrix.</summary>
        public static readonly Matrix4d Identity = new Matrix4d
        (
            1, 0, 0, 0,
            0, 1, 0, 0,
            0, 0, 1, 0,
            0, 0, 0, 1
        );

        /// <summary>A matrix of all zeros.</summary>
        public static readonly Matrix4d Zero = new Matrix4d
        (
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0
        );

        #endregion

        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return
                R0C0.GetHashCode() ^ R0C1.GetHashCode() ^ R0C2.GetHashCode() ^ R0C3.GetHashCode() ^
                R1C0.GetHashCode() ^ R1C1.GetHashCode() ^ R1C2.GetHashCode() ^ R1C3.GetHashCode() ^
                R2C0.GetHashCode() ^ R2C1.GetHashCode() ^ R2C2.GetHashCode() ^ R2C3.GetHashCode() ^
                R3C0.GetHashCode() ^ R3C1.GetHashCode() ^ R3C2.GetHashCode() ^ R3C3.GetHashCode();
        }

        #endregion

        #region String

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return String.Format(
                "|{00}, {01}, {02}, {03}|\n" +
                "|{04}, {05}, {06}, {07}|\n" +
                "|{08}, {09}, {10}, {11}|\n" +
                "|{12}, {13}, {14}, {15}|",
                R0C0, R0C1, R0C2, R0C3,
                R1C0, R1C1, R1C2, R1C3,
                R2C0, R2C1, R2C2, R2C3,
                R3C0, R3C1, R3C2, R3C3);
        }

        #endregion
    }
}
