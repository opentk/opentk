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
    /// Represents a 4x4 matrix containing 3D rotation, scale, transform, and projection with double-precision components.
    /// </summary>
    /// <seealso cref="Matrix4"/>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4d : IEquatable<Matrix4d>, IFormattable,
                            IMultiplyOperators<Matrix4d, Vector4d, Vector4d>,
                            IMultiplyOperators<Matrix4d, Matrix4d, Matrix4d>,
                            IMultiplyOperators<Matrix4d, double, Matrix4d>,
                            IAdditionOperators<Matrix4d, Matrix4d, Matrix4d>,
                            IMultiplyOperators<Matrix4d, Matrix4x2d, Matrix4x2d>,
                            IMultiplyOperators<Matrix4d, Matrix4x3d, Matrix4x3d>,
                            ISubtractionOperators<Matrix4d, Matrix4d, Matrix4d>,
                            IEqualityOperators<Matrix4d, Matrix4d, bool>,
                            IAdditiveIdentity<Matrix4d, Matrix4d>,
                            IMultiplicativeIdentity<Matrix4d, Matrix4d>
    {
        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector4d Row0;

        /// <summary>
        /// 2nd row of the matrix.
        /// </summary>
        public Vector4d Row1;

        /// <summary>
        /// 3rd row of the matrix.
        /// </summary>
        public Vector4d Row2;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector4d Row3;

        /// <summary>
        /// The identity matrix.
        /// </summary>
        public static readonly Matrix4d Identity = new Matrix4d(Vector4d.UnitX, Vector4d.UnitY, Vector4d.UnitZ, Vector4d.UnitW);

        /// <summary>
        /// The zero matrix.
        /// </summary>
        public static readonly Matrix4d Zero = new Matrix4d(Vector4d.Zero, Vector4d.Zero, Vector4d.Zero, Vector4d.Zero);

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4d"/> struct.
        /// </summary>
        /// <param name="row0">Top row of the matrix.</param>
        /// <param name="row1">Second row of the matrix.</param>
        /// <param name="row2">Third row of the matrix.</param>
        /// <param name="row3">Bottom row of the matrix.</param>
        public Matrix4d(Vector4d row0, Vector4d row1, Vector4d row2, Vector4d row3)
        {
            Row0 = row0;
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4d"/> struct.
        /// </summary>
        /// <param name="m00">First item of the first row.</param>
        /// <param name="m01">Second item of the first row.</param>
        /// <param name="m02">Third item of the first row.</param>
        /// <param name="m03">Fourth item of the first row.</param>
        /// <param name="m10">First item of the second row.</param>
        /// <param name="m11">Second item of the second row.</param>
        /// <param name="m12">Third item of the second row.</param>
        /// <param name="m13">Fourth item of the second row.</param>
        /// <param name="m20">First item of the third row.</param>
        /// <param name="m21">Second item of the third row.</param>
        /// <param name="m22">Third item of the third row.</param>
        /// <param name="m23">Fourth item of the third row.</param>
        /// <param name="m30">First item of the fourth row.</param>
        /// <param name="m31">Second item of the fourth row.</param>
        /// <param name="m32">Third item of the fourth row.</param>
        /// <param name="m33">Fourth item of the fourth row.</param>
        [SuppressMessage("ReSharper", "SA1117", Justification = "For better readability of Matrix struct.")]
        public Matrix4d
        (
            double m00, double m01, double m02, double m03,
            double m10, double m11, double m12, double m13,
            double m20, double m21, double m22, double m23,
            double m30, double m31, double m32, double m33
        )
        {
            Row0 = new Vector4d(m00, m01, m02, m03);
            Row1 = new Vector4d(m10, m11, m12, m13);
            Row2 = new Vector4d(m20, m21, m22, m23);
            Row3 = new Vector4d(m30, m31, m32, m33);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix4d"/> struct.
        /// </summary>
        /// <param name="topLeft">The top left 3x3 of the matrix.</param>
        public Matrix4d(Matrix3d topLeft)
        {
            Row0.X = topLeft.Row0.X;
            Row0.Y = topLeft.Row0.Y;
            Row0.Z = topLeft.Row0.Z;
            Row0.W = 0;
            Row1.X = topLeft.Row1.X;
            Row1.Y = topLeft.Row1.Y;
            Row1.Z = topLeft.Row1.Z;
            Row1.W = 0;
            Row2.X = topLeft.Row2.X;
            Row2.Y = topLeft.Row2.Y;
            Row2.Z = topLeft.Row2.Z;
            Row2.W = 0;
            Row3.X = 0;
            Row3.Y = 0;
            Row3.Z = 0;
            Row3.W = 1;
        }

        /// <summary>
        /// Gets the determinant of this matrix.
        /// </summary>
        public readonly double Determinant => (Row0.X * Row1.Y * Row2.Z * Row3.W) - (Row0.X * Row1.Y * Row2.W * Row3.Z) +
                                     (Row0.X * Row1.Z * Row2.W * Row3.Y) - (Row0.X * Row1.Z * Row2.Y * Row3.W)
                                     + (Row0.X * Row1.W * Row2.Y * Row3.Z) - (Row0.X * Row1.W * Row2.Z * Row3.Y) -
                                     (Row0.Y * Row1.Z * Row2.W * Row3.X) + (Row0.Y * Row1.Z * Row2.X * Row3.W)
                                     - (Row0.Y * Row1.W * Row2.X * Row3.Z) + (Row0.Y * Row1.W * Row2.Z * Row3.X) -
                                     (Row0.Y * Row1.X * Row2.Z * Row3.W) + (Row0.Y * Row1.X * Row2.W * Row3.Z)
                                                                       + (Row0.Z * Row1.W * Row2.X * Row3.Y) -
                                     (Row0.Z * Row1.W * Row2.Y * Row3.X) + (Row0.Z * Row1.X * Row2.Y * Row3.W) -
                                     (Row0.Z * Row1.X * Row2.W * Row3.Y)
                                     + (Row0.Z * Row1.Y * Row2.W * Row3.X) - (Row0.Z * Row1.Y * Row2.X * Row3.W) -
                                     (Row0.W * Row1.X * Row2.Y * Row3.Z) + (Row0.W * Row1.X * Row2.Z * Row3.Y)
                                     - (Row0.W * Row1.Y * Row2.Z * Row3.X) + (Row0.W * Row1.Y * Row2.X * Row3.Z) -
                                     (Row0.W * Row1.Z * Row2.X * Row3.Y) + (Row0.W * Row1.Z * Row2.Y * Row3.X);

        /// <summary>
        /// Gets or sets the first column of this matrix.
        /// </summary>
        public Vector4d Column0
        {
            readonly get => new Vector4d(Row0.X, Row1.X, Row2.X, Row3.X);
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
            readonly get => new Vector4d(Row0.Y, Row1.Y, Row2.Y, Row3.Y);
            set
            {
                Row0.Y = value.X;
                Row1.Y = value.Y;
                Row2.Y = value.Z;
                Row3.Y = value.W;
            }
        }

        /// <summary>
        /// Gets or sets the third column of this matrix.
        /// </summary>
        public Vector4d Column2
        {
            readonly get => new Vector4d(Row0.Z, Row1.Z, Row2.Z, Row3.Z);
            set
            {
                Row0.Z = value.X;
                Row1.Z = value.Y;
                Row2.Z = value.Z;
                Row3.Z = value.W;
            }
        }

        /// <summary>
        /// Gets or sets the fourth column of this matrix.
        /// </summary>
        public Vector4d Column3
        {
            readonly get => new Vector4d(Row0.W, Row1.W, Row2.W, Row3.W);
            set
            {
                Row0.W = value.X;
                Row1.W = value.Y;
                Row2.W = value.Z;
                Row3.W = value.W;
            }
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 1 of this instance.
        /// </summary>
        public double M11
        {
            readonly get => Row0.X;
            set => Row0.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 2 of this instance.
        /// </summary>
        public double M12
        {
            readonly get => Row0.Y;
            set => Row0.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 3 of this instance.
        /// </summary>
        public double M13
        {
            readonly get => Row0.Z;
            set => Row0.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 1, column 4 of this instance.
        /// </summary>
        public double M14
        {
            readonly get => Row0.W;
            set => Row0.W = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 1 of this instance.
        /// </summary>
        public double M21
        {
            readonly get => Row1.X;
            set => Row1.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 2 of this instance.
        /// </summary>
        public double M22
        {
            readonly get => Row1.Y;
            set => Row1.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 3 of this instance.
        /// </summary>
        public double M23
        {
            readonly get => Row1.Z;
            set => Row1.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 2, column 4 of this instance.
        /// </summary>
        public double M24
        {
            readonly get => Row1.W;
            set => Row1.W = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 1 of this instance.
        /// </summary>
        public double M31
        {
            readonly get => Row2.X;
            set => Row2.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 2 of this instance.
        /// </summary>
        public double M32
        {
            readonly get => Row2.Y;
            set => Row2.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 3 of this instance.
        /// </summary>
        public double M33
        {
            readonly get => Row2.Z;
            set => Row2.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 3, column 4 of this instance.
        /// </summary>
        public double M34
        {
            readonly get => Row2.W;
            set => Row2.W = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 1 of this instance.
        /// </summary>
        public double M41
        {
            readonly get => Row3.X;
            set => Row3.X = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 2 of this instance.
        /// </summary>
        public double M42
        {
            readonly get => Row3.Y;
            set => Row3.Y = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 3 of this instance.
        /// </summary>
        public double M43
        {
            readonly get => Row3.Z;
            set => Row3.Z = value;
        }

        /// <summary>
        /// Gets or sets the value at row 4, column 4 of this instance.
        /// </summary>
        public double M44
        {
            readonly get => Row3.W;
            set => Row3.W = value;
        }

        /// <summary>
        /// Gets or sets the values along the main diagonal of the matrix.
        /// </summary>
        public Vector4d Diagonal
        {
            readonly get => new Vector4d(Row0.X, Row1.Y, Row2.Z, Row3.W);
            set
            {
                Row0.X = value.X;
                Row1.Y = value.Y;
                Row2.Z = value.Z;
                Row3.W = value.W;
            }
        }

        /// <summary>
        /// Gets the trace of the matrix, the sum of the values along the diagonal.
        /// </summary>
        public readonly double Trace => Row0.X + Row1.Y + Row2.Z + Row3.W;

        /// <summary>
        /// Gets the additive identity of the matrix, which is the zero matrix.
        /// </summary>
        public static Matrix4d AdditiveIdentity => Zero;

        /// <summary>
        /// Gets the multiplicative identity of the matrix, which is the identity matrix.
        /// </summary>
        public static Matrix4d MultiplicativeIdentity => Identity;

        /// <summary>
        /// Gets or sets the value at a specified row and column.
        /// </summary>
        /// <param name="rowIndex">The index of the row.</param>
        /// <param name="columnIndex">The index of the column.</param>
        /// <returns>The element at the given row and column index.</returns>
        public double this[int rowIndex, int columnIndex]
        {
            readonly get
            {
                if (((uint)rowIndex) > 3 || ((uint)columnIndex) > 3)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to access this matrix at: ({0}, {1})", rowIndex, columnIndex);
                }

                return GetRowUnsafe(in this, rowIndex)[columnIndex];
            }

            set
            {
                if (((uint)rowIndex) > 3 || ((uint)columnIndex) > 3)
                {
                    MathHelper.ThrowOutOfRangeException("You tried to set this matrix at: ({0}, {1})", rowIndex, columnIndex);
                }

                GetRowUnsafe(in this, rowIndex)[columnIndex] = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ref Vector4d GetRowUnsafe(in Matrix4d m, int index)
        {
            ref Vector4d address = ref Unsafe.AsRef(in m.Row0);
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
        /// <remarks>
        /// If the matrix is singular this function does not throw an exception,
        /// instead it returns the original un-inverted matrix.
        /// </remarks>
        /// <returns>The inverted copy.</returns>
        public readonly Matrix4d Inverted()
        {
            var m = this;
            if (m.Determinant != 0)
            {
                m.Invert();
            }

            return m;
        }

        /// <summary>
        /// Converts this instance into its transpose.
        /// </summary>
        public void Transpose()
        {
            this = Transpose(this);
        }

        /// <summary>
        /// Returns a transposed copy of this instance.
        /// </summary>
        /// <returns>The transposed copy.</returns>
        public readonly Matrix4d Transposed()
        {
            Matrix4d m = this;
            m.Transpose();
            return m;
        }

        /// <summary>
        /// Divides each element in the Matrix by the <see cref="Determinant"/>.
        /// </summary>
        public void Normalize()
        {
            var determinant = Determinant;
            Row0 /= determinant;
            Row1 /= determinant;
            Row2 /= determinant;
            Row3 /= determinant;
        }

        /// <summary>
        /// Returns a normalized copy of this instance.
        /// </summary>
        /// <returns>The normalized copy.</returns>
        public readonly Matrix4d Normalized()
        {
            var m = this;
            m.Normalize();
            return m;
        }

        /// <summary>
        /// Swizzles this instance. Switches places of the rows of the matrix.
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
        public readonly Matrix4d Swizzled(int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3)
        {
            Matrix4d m = this;
            m.Swizzle(rowForRow0, rowForRow1, rowForRow2, rowForRow3);
            return m;
        }

        /// <summary>
        /// Returns a copy of this Matrix4d without translation.
        /// </summary>
        /// <returns>The matrix without translation.</returns>
        public readonly Matrix4d ClearTranslation()
        {
            var m = this;
            m.Row3.Xyz = Vector3d.Zero;
            return m;
        }

        /// <summary>
        /// Returns a copy of this Matrix4d without scale.
        /// </summary>
        /// <returns>The matrix without scaling.</returns>
        public readonly Matrix4d ClearScale()
        {
            var m = this;
            m.Row0.Xyz = m.Row0.Xyz.Normalized();
            m.Row1.Xyz = m.Row1.Xyz.Normalized();
            m.Row2.Xyz = m.Row2.Xyz.Normalized();
            return m;
        }

        /// <summary>
        /// Returns a copy of this Matrix4d without rotation.
        /// </summary>
        /// <returns>The matrix without rotation.</returns>
        public readonly Matrix4d ClearRotation()
        {
            var m = this;
            m.Row0.Xyz = new Vector3d(m.Row0.Xyz.Length, 0, 0);
            m.Row1.Xyz = new Vector3d(0, m.Row1.Xyz.Length, 0);
            m.Row2.Xyz = new Vector3d(0, 0, m.Row2.Xyz.Length);
            return m;
        }

        /// <summary>
        /// Returns a copy of this Matrix4d without projection. (equivalent to setting <see cref="Column3"/> = (0, 0, 0, 0)).
        /// </summary>
        /// <returns>The matrix without projection.</returns>
        [Obsolete("This function doesn't actually clear the projection of the matrix. This is equivalent of setting Column3 = (0, 0, 0, 0).")]
        public readonly Matrix4d ClearProjection()
        {
            var m = this;
            m.Column3 = Vector4d.Zero;
            return m;
        }

        /// <summary>
        /// Returns the translation component of this instance.
        /// </summary>
        /// <returns>The translation.</returns>
        public readonly Vector3d ExtractTranslation()
        {
            return Row3.Xyz;
        }

        /// <summary>
        /// Returns the scale component of this instance.
        /// </summary>
        /// <returns>The scale.</returns>
        public readonly Vector3d ExtractScale()
        {
            return new Vector3d(Row0.Xyz.Length, Row1.Xyz.Length, Row2.Xyz.Length);
        }

        /// <summary>
        /// Returns the rotation component of this instance. Quite slow.
        /// </summary>
        /// <param name="rowNormalize">
        /// Whether the method should row-normalize (i.e. remove scale from) the Matrix. Pass false if
        /// you know it's already normalized.
        /// </param>
        /// <returns>The rotation.</returns>
        [Pure]
        public readonly Quaterniond ExtractRotation(bool rowNormalize = true)
        {
            var row0 = Row0.Xyz;
            var row1 = Row1.Xyz;
            var row2 = Row2.Xyz;

            if (rowNormalize)
            {
                row0 = row0.Normalized();
                row1 = row1.Normalized();
                row2 = row2.Normalized();
            }

            // code below adapted from Blender
            var q = default(Quaterniond);
            var trace = 0.25 * (row0[0] + row1[1] + row2[2] + 1.0);

            if (trace > 0)
            {
                var sq = Math.Sqrt(trace);

                q.W = sq;
                sq = 1.0 / (4.0 * sq);
                q.X = (row1[2] - row2[1]) * sq;
                q.Y = (row2[0] - row0[2]) * sq;
                q.Z = (row0[1] - row1[0]) * sq;
            }
            else if (row0[0] > row1[1] && row0[0] > row2[2])
            {
                var sq = 2.0 * Math.Sqrt(1.0 + row0[0] - row1[1] - row2[2]);

                q.X = 0.25 * sq;
                sq = 1.0 / sq;
                q.W = (row2[1] - row1[2]) * sq;
                q.Y = (row1[0] + row0[1]) * sq;
                q.Z = (row2[0] + row0[2]) * sq;
            }
            else if (row1[1] > row2[2])
            {
                var sq = 2.0 * Math.Sqrt(1.0 + row1[1] - row0[0] - row2[2]);

                q.Y = 0.25 * sq;
                sq = 1.0 / sq;
                q.W = (row2[0] - row0[2]) * sq;
                q.X = (row1[0] + row0[1]) * sq;
                q.Z = (row2[1] + row1[2]) * sq;
            }
            else
            {
                var sq = 2.0 * Math.Sqrt(1.0 + row2[2] - row0[0] - row1[1]);

                q.Z = 0.25 * sq;
                sq = 1.0 / sq;
                q.W = (row1[0] - row0[1]) * sq;
                q.X = (row2[0] + row0[2]) * sq;
                q.Y = (row2[1] + row1[2]) * sq;
            }

            q.Normalize();
            return q;
        }

        /// <summary>
        /// Returns the projection component of this instance (equivalent to <see cref="Column3"/>).
        /// </summary>
        /// <returns>The projection (<see cref="Column3"/>).</returns>
        [Obsolete("Use Column3 if the old behaviour is needed, or use ExtractPerspective*() or ExtractOrthographic* instead.")]
        public readonly Vector4d ExtractProjection()
        {
            return Column3;
        }

        /// <summary>
        /// Returns the off-center projection parameters of this instance.
        /// This only works if the matrix was created using <see cref="CreatePerspectiveOffCenter(double, double, double, double, double, double)"/>.
        /// </summary>
        /// <param name="left">The left edge of the view frustum.</param>
        /// <param name="right">The right edge of the view frustum.</param>
        /// <param name="bottom">The bottom edge of the view frustum.</param>
        /// <param name="top">The top edge of the view frustum.</param>
        /// <param name="depthNear">The distance to the near clip plane.</param>
        /// <param name="depthFar">The distance to the far clip plane.</param>
        public readonly void ExtractPerspectiveOffCenter
        (
            out double left,
            out double right,
            out double bottom,
            out double top,
            out double depthNear,
            out double depthFar
        )
        {
            depthNear = Row3.Z / (Row2.Z - 1);
            depthFar = Row3.Z / (Row2.Z + 1);
            left = depthNear * (Row2.X - 1) / Row0.X;
            right = depthNear * (Row2.X + 1) / Row0.X;
            bottom = depthNear * (Row2.Y - 1) / Row1.Y;
            top = depthNear * (Row2.Y + 1) / Row1.Y;
        }

        /// <summary>
        /// Returns the field of view projection parameters of this instance.
        /// This only works if the matrix was created using <see cref="CreatePerspectiveFieldOfView(double, double, double, double)"/>.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians).</param>
        /// <param name="aspect">Aspect ratio of the view (width / height).</param>
        /// <param name="depthNear">The distance to the near clip plane.</param>
        /// <param name="depthFar">The distance to the far clip plane.</param>
        public readonly void ExtractPerspectiveFieldOfView(out double fovy, out double aspect, out double depthNear, out double depthFar)
        {
            fovy = 2.0f * Math.Atan(1 / Row1.Y);
            aspect = Row1.Y / Row0.X;
            depthNear = Row3.Z / (Row2.Z - 1);
            depthFar = Row3.Z / (Row2.Z + 1);
        }

        /// <summary>
        /// Returns the off-center orthographic projection parameters of this instance.
        /// This only works if the matrix was created using <see cref="CreateOrthographicOffCenter(double, double, double, double, double, double)"/>.
        /// </summary>
        /// <param name="left">The left edge of the projection volume.</param>
        /// <param name="right">The right edge of the projection volume.</param>
        /// <param name="bottom">The bottom edge of the projection volume.</param>
        /// <param name="top">The top edge of the projection volume.</param>
        /// <param name="depthNear">The distance to the near clip plane.</param>
        /// <param name="depthFar">The distance to the far clip plane.</param>
        public readonly void ExtractOrthographicOffCenter
        (
            out double left,
            out double right,
            out double bottom,
            out double top,
            out double depthNear,
            out double depthFar
        )
        {
            left = -(1 + Row3.X) / Row0.X;
            right = (1 - Row3.X) / Row0.X;
            bottom = -(1 + Row3.Y) / Row1.Y;
            top = (1 - Row3.Y) / Row1.Y;
            depthNear = (1 + Row3.Z) / Row2.Z;
            depthFar = -(1 - Row3.Z) / Row2.Z;
        }

        /// <summary>
        /// Returns the orthographic projection parameters of this instance.
        /// This only works if the matrix was created using <see cref="CreateOrthographic(double, double, double, double)"/>.
        /// </summary>
        /// <param name="width">The width of the projection volume.</param>
        /// <param name="height">The height of the projection volume.</param>
        /// <param name="depthNear">The distance to the near clip plane.</param>
        /// <param name="depthFar">The distance to the far clip plane.</param>
        public readonly void ExtractOrthographic(out double width, out double height, out double depthNear, out double depthFar)
        {
            double left = -(1 + Row3.X) / Row0.X;
            double right = (1 - Row3.X) / Row0.X;
            width = right - left;
            double bottom = -(1 + Row3.Y) / Row1.Y;
            double top = (1 - Row3.Y) / Row1.Y;
            height = top - bottom;
            depthNear = (1 + Row3.Z) / Row2.Z;
            depthFar = -(1 - Row3.Z) / Row2.Z;
        }

        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <param name="result">A matrix instance.</param>
        public static void CreateFromAxisAngle(Vector3d axis, double angle, out Matrix4d result)
        {
            // normalize and create a local copy of the vector.
            axis.Normalize();
            double axisX = axis.X, axisY = axis.Y, axisZ = axis.Z;

            // calculate angles
            var cos = Math.Cos(-angle);
            var sin = Math.Sin(-angle);
            var t = 1.0f - cos;

            // do the conversion math once
            double tXX = t * axisX * axisX;
            double tXY = t * axisX * axisY;
            double tXZ = t * axisX * axisZ;
            double tYY = t * axisY * axisY;
            double tYZ = t * axisY * axisZ;
            double tZZ = t * axisZ * axisZ;

            double sinX = sin * axisX;
            double sinY = sin * axisY;
            double sinZ = sin * axisZ;

            result.Row0.X = tXX + cos;
            result.Row0.Y = tXY - sinZ;
            result.Row0.Z = tXZ + sinY;
            result.Row0.W = 0;
            result.Row1.X = tXY + sinZ;
            result.Row1.Y = tYY + cos;
            result.Row1.Z = tYZ - sinX;
            result.Row1.W = 0;
            result.Row2.X = tXZ - sinY;
            result.Row2.Y = tYZ + sinX;
            result.Row2.Z = tZZ + cos;
            result.Row2.W = 0;
            result.Row3 = Vector4d.UnitW;
        }

        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <returns>A matrix instance.</returns>
        [Pure]
        public static Matrix4d CreateFromAxisAngle(Vector3d axis, double angle)
        {
            CreateFromAxisAngle(axis, angle, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Build a rotation matrix from the specified quaternion.
        /// </summary>
        /// <param name="q">Quaternion to translate.</param>
        /// <param name="result">Matrix result.</param>
        public static void CreateFromQuaternion(in Quaterniond q, out Matrix4d result)
        {
            // Adapted from https://en.wikipedia.org/wiki/Quaternions_and_spatial_rotation#Quaternion-derived_rotation_matrix
            // with the caviat that opentk uses row-major matrices so the matrix we create is transposed
            double sqx = q.X * q.X;
            double sqy = q.Y * q.Y;
            double sqz = q.Z * q.Z;
            double sqw = q.W * q.W;

            double xy = q.X * q.Y;
            double xz = q.X * q.Z;
            double xw = q.X * q.W;

            double yz = q.Y * q.Z;
            double yw = q.Y * q.W;

            double zw = q.Z * q.W;

            double s2 = 2d / (sqx + sqy + sqz + sqw);

            result.Row0.X = 1d - (s2 * (sqy + sqz));
            result.Row1.Y = 1d - (s2 * (sqx + sqz));
            result.Row2.Z = 1d - (s2 * (sqx + sqy));

            result.Row0.Y = s2 * (xy + zw);
            result.Row1.X = s2 * (xy - zw);

            result.Row2.X = s2 * (xz + yw);
            result.Row0.Z = s2 * (xz - yw);

            result.Row2.Y = s2 * (yz - xw);
            result.Row1.Z = s2 * (yz + xw);

            result.Row0.W = 0;
            result.Row1.W = 0;
            result.Row2.W = 0;
            result.Row3 = new Vector4d(0, 0, 0, 1d);
        }

        /// <summary>
        /// Builds a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion to rotate by.</param>
        /// <returns>A matrix instance.</returns>
        [Pure]
        public static Matrix4d CreateFromQuaternion(Quaterniond q)
        {
            CreateFromQuaternion(in q, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateRotationX(double angle, out Matrix4d result)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            result.Row0 = Vector4d.UnitX;
            result.Row1 = new Vector4d(0, cos, sin, 0);
            result.Row2 = new Vector4d(0, -sin, cos, 0);
            result.Row3 = Vector4d.UnitW;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateRotationX(double angle)
        {
            CreateRotationX(angle, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateRotationY(double angle, out Matrix4d result)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            result.Row0 = new Vector4d(cos, 0, -sin, 0);
            result.Row1 = Vector4d.UnitY;
            result.Row2 = new Vector4d(sin, 0, cos, 0);
            result.Row3 = Vector4d.UnitW;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateRotationY(double angle)
        {
            CreateRotationY(angle, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateRotationZ(double angle, out Matrix4d result)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            result.Row0 = new Vector4d(cos, sin, 0, 0);
            result.Row1 = new Vector4d(-sin, cos, 0, 0);
            result.Row2 = Vector4d.UnitZ;
            result.Row3 = Vector4d.UnitW;
        }

        /// <summary>
        /// Builds a rotation matrix for a rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The counter-clockwise angle in radians.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateRotationZ(double angle)
        {
            CreateRotationZ(angle, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateTranslation(double x, double y, double z, out Matrix4d result)
        {
            result = Identity;
            result.Row3 = new Vector4d(x, y, z, 1);
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateTranslation(in Vector3d vector, out Matrix4d result)
        {
            result = Identity;
            result.Row3 = new Vector4d(vector.X, vector.Y, vector.Z, 1);
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateTranslation(double x, double y, double z)
        {
            CreateTranslation(x, y, z, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateTranslation(Vector3d vector)
        {
            CreateTranslation(vector.X, vector.Y, vector.Z, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix4d CreateScale(double scale)
        {
            CreateScale(scale, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Scale factors for the x, y, and z axes.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix4d CreateScale(Vector3d scale)
        {
            CreateScale(in scale, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="x">Scale factor for the x axis.</param>
        /// <param name="y">Scale factor for the y axis.</param>
        /// <param name="z">Scale factor for the z axis.</param>
        /// <returns>A scale matrix.</returns>
        [Pure]
        public static Matrix4d CreateScale(double x, double y, double z)
        {
            CreateScale(x, y, z, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for the x, y, and z axes.</param>
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double scale, out Matrix4d result)
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
        public static void CreateScale(in Vector3d scale, out Matrix4d result)
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
        /// <param name="result">A scale matrix.</param>
        public static void CreateScale(double x, double y, double z, out Matrix4d result)
        {
            result = Identity;
            result.Row0.X = x;
            result.Row1.Y = y;
            result.Row2.Z = z;
        }

        /// <summary>
        /// Create a swizzle matrix that can be used to change the row order of matrices.
        /// </summary>
        /// <remarks>
        /// If you are looking to swizzle vectors there are properties like <see cref="Vector3.Zyx"/> that can do this more effectively.
        /// </remarks>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="rowForRow3">Which row to place in <see cref="Row3"/>.</param>
        /// <returns>The resulting swizzle matrix.</returns>
        public static Matrix4d CreateSwizzle(int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3)
        {
            CreateSwizzle(rowForRow0, rowForRow1, rowForRow2, rowForRow3, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Create a swizzle matrix that can be used to change the row order of matrices.
        /// </summary>
        /// /// <remarks>
        /// If you are looking to swizzle vectors there are properties like <see cref="Vector3.Zyx"/> that can do this more effectively.
        /// </remarks>
        /// <param name="rowForRow0">Which row to place in <see cref="Row0"/>.</param>
        /// <param name="rowForRow1">Which row to place in <see cref="Row1"/>.</param>
        /// <param name="rowForRow2">Which row to place in <see cref="Row2"/>.</param>
        /// <param name="rowForRow3">Which row to place in <see cref="Row3"/>.</param>
        /// <param name="result">The resulting swizzle matrix.</param>
        public static void CreateSwizzle(int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3, out Matrix4d result)
        {
            if (rowForRow0 < 0 || rowForRow0 >= 4)
            {
                throw new IndexOutOfRangeException($"{nameof(rowForRow0)} must be a number between 0 and 3. Got {rowForRow0}.");
            }
            if (rowForRow1 < 0 || rowForRow1 >= 4)
            {
                throw new IndexOutOfRangeException($"{nameof(rowForRow1)} must be a number between 0 and 3. Got {rowForRow1}.");
            }
            if (rowForRow2 < 0 || rowForRow2 >= 4)
            {
                throw new IndexOutOfRangeException($"{nameof(rowForRow2)} must be a number between 0 and 3. Got {rowForRow2}.");
            }
            if (rowForRow3 < 0 || rowForRow3 >= 4)
            {
                throw new IndexOutOfRangeException($"{nameof(rowForRow3)} must be a number between 0 and 3. Got {rowForRow3}.");
            }

            result = Zero;
            result[0, rowForRow0] = 1.0;
            result[1, rowForRow1] = 1.0;
            result[2, rowForRow2] = 1.0;
            result[3, rowForRow3] = 1.0;
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="width">The width of the projection volume.</param>
        /// <param name="height">The height of the projection volume.</param>
        /// <param name="depthNear">The near edge of the projection volume.</param>
        /// <param name="depthFar">The far edge of the projection volume.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateOrthographic
        (
            double width,
            double height,
            double depthNear,
            double depthFar,
            out Matrix4d result
        )
        {
            CreateOrthographicOffCenter(-width / 2, width / 2, -height / 2, height / 2, depthNear, depthFar, out result);
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="width">The width of the projection volume.</param>
        /// <param name="height">The height of the projection volume.</param>
        /// <param name="depthNear">The near edge of the projection volume.</param>
        /// <param name="depthFar">The far edge of the projection volume.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateOrthographic(double width, double height, double depthNear, double depthFar)
        {
            CreateOrthographicOffCenter(-width / 2, width / 2, -height / 2, height / 2, depthNear, depthFar, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="left">The left edge of the projection volume.</param>
        /// <param name="right">The right edge of the projection volume.</param>
        /// <param name="bottom">The bottom edge of the projection volume.</param>
        /// <param name="top">The top edge of the projection volume.</param>
        /// <param name="depthNear">The near edge of the projection volume.</param>
        /// <param name="depthFar">The far edge of the projection volume.</param>
        /// <param name="result">The resulting Matrix4d instance.</param>
        public static void CreateOrthographicOffCenter
        (
            double left,
            double right,
            double bottom,
            double top,
            double depthNear,
            double depthFar,
            out Matrix4d result
        )
        {
            var invRL = 1 / (right - left);
            var invTB = 1 / (top - bottom);
            var invFN = 1 / (depthFar - depthNear);

            result = new Matrix4d
            {
                M11 = 2 * invRL,
                M22 = 2 * invTB,
                M33 = -2 * invFN,

                M41 = -(right + left) * invRL,
                M42 = -(top + bottom) * invTB,
                M43 = -(depthFar + depthNear) * invFN,
                M44 = 1
            };
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="left">The left edge of the projection volume.</param>
        /// <param name="right">The right edge of the projection volume.</param>
        /// <param name="bottom">The bottom edge of the projection volume.</param>
        /// <param name="top">The top edge of the projection volume.</param>
        /// <param name="depthNear">The near edge of the projection volume.</param>
        /// <param name="depthFar">The far edge of the projection volume.</param>
        /// <returns>The resulting Matrix4d instance.</returns>
        [Pure]
        public static Matrix4d CreateOrthographicOffCenter
        (
            double left,
            double right,
            double bottom,
            double top,
            double depthNear,
            double depthFar
        )
        {
            CreateOrthographicOffCenter(left, right, bottom, top, depthNear, depthFar, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates a perspective projection matrix.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians).</param>
        /// <param name="aspect">Aspect ratio of the view (width / height).</param>
        /// <param name="depthNear">Distance to the near clip plane.</param>
        /// <param name="depthFar">Distance to the far clip plane.</param>
        /// <param name="result">A projection matrix that transforms camera space to raster space.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        ///  <list type="bullet">
        ///  <item>fovy is zero, less than zero or larger than Math.PI</item>
        ///  <item>aspect is negative or zero</item>
        ///  <item>depthNear is negative or zero</item>
        ///  <item>depthFar is negative or zero</item>
        ///  <item>depthNear is larger than depthFar</item>
        ///  </list>
        /// </exception>
        public static void CreatePerspectiveFieldOfView
        (
            double fovy,
            double aspect,
            double depthNear,
            double depthFar,
            out Matrix4d result
        )
        {
            if (fovy <= 0 || fovy > Math.PI)
            {
                throw new ArgumentOutOfRangeException(nameof(fovy));
            }

            if (aspect <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(aspect));
            }

            if (depthNear <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(depthNear));
            }

            if (depthFar <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(depthFar));
            }

            var maxY = depthNear * Math.Tan(0.5 * fovy);
            var minY = -maxY;
            var minX = minY * aspect;
            var maxX = maxY * aspect;

            CreatePerspectiveOffCenter(minX, maxX, minY, maxY, depthNear, depthFar, out result);
        }

        /// <summary>
        /// Creates a perspective projection matrix.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians).</param>
        /// <param name="aspect">Aspect ratio of the view (width / height).</param>
        /// <param name="depthNear">Distance to the near clip plane.</param>
        /// <param name="depthFar">Distance to the far clip plane.</param>
        /// <returns>A projection matrix that transforms camera space to raster space.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        ///  <list type="bullet">
        ///  <item>fovy is zero, less than zero or larger than Math.PI</item>
        ///  <item>aspect is negative or zero</item>
        ///  <item>depthNear is negative or zero</item>
        ///  <item>depthFar is negative or zero</item>
        ///  <item>depthNear is larger than depthFar</item>
        ///  </list>
        /// </exception>
        [Pure]
        public static Matrix4d CreatePerspectiveFieldOfView(double fovy, double aspect, double depthNear, double depthFar)
        {
            CreatePerspectiveFieldOfView(fovy, aspect, depthNear, depthFar, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Creates an perspective projection matrix.
        /// </summary>
        /// <param name="left">Left edge of the view frustum.</param>
        /// <param name="right">Right edge of the view frustum.</param>
        /// <param name="bottom">Bottom edge of the view frustum.</param>
        /// <param name="top">Top edge of the view frustum.</param>
        /// <param name="depthNear">Distance to the near clip plane.</param>
        /// <param name="depthFar">Distance to the far clip plane.</param>
        /// <param name="result">A projection matrix that transforms camera space to raster space.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        ///  <list type="bullet">
        ///  <item>depthNear is negative or zero</item>
        ///  <item>depthFar is negative or zero</item>
        ///  <item>depthNear is larger than depthFar</item>
        ///  </list>
        /// </exception>
        public static void CreatePerspectiveOffCenter
        (
            double left,
            double right,
            double bottom,
            double top,
            double depthNear,
            double depthFar,
            out Matrix4d result
        )
        {
            if (depthNear <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(depthNear));
            }

            if (depthFar <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(depthFar));
            }

            if (depthNear >= depthFar)
            {
                throw new ArgumentOutOfRangeException(nameof(depthNear));
            }

            var x = 2.0 * depthNear / (right - left);
            var y = 2.0 * depthNear / (top - bottom);
            var a = (right + left) / (right - left);
            var b = (top + bottom) / (top - bottom);
            var c = -(depthFar + depthNear) / (depthFar - depthNear);
            var d = -(2.0 * depthFar * depthNear) / (depthFar - depthNear);

#pragma warning disable SA1117 // Parameters should be on same line or separate lines
            result = new Matrix4d
            (
                x, 0, 0, 0,
                0, y, 0, 0,
                a, b, c, -1,
                0, 0, d, 0
            );
#pragma warning restore SA1117 // Parameters should be on same line or separate lines
        }

        /// <summary>
        /// Creates an perspective projection matrix.
        /// </summary>
        /// <param name="left">Left edge of the view frustum.</param>
        /// <param name="right">Right edge of the view frustum.</param>
        /// <param name="bottom">Bottom edge of the view frustum.</param>
        /// <param name="top">Top edge of the view frustum.</param>
        /// <param name="depthNear">Distance to the near clip plane.</param>
        /// <param name="depthFar">Distance to the far clip plane.</param>
        /// <returns>A projection matrix that transforms camera space to raster space.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        ///  <list type="bullet">
        ///  <item>depthNear is negative or zero</item>
        ///  <item>depthFar is negative or zero</item>
        ///  <item>depthNear is larger than depthFar</item>
        ///  </list>
        /// </exception>
        [Pure]
        public static Matrix4d CreatePerspectiveOffCenter
        (
            double left,
            double right,
            double bottom,
            double top,
            double depthNear,
            double depthFar
        )
        {
            CreatePerspectiveOffCenter(left, right, bottom, top, depthNear, depthFar, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Build a scaling matrix.
        /// </summary>
        /// <param name="scale">Single scale factor for x,y and z axes.</param>
        /// <returns>A scaling matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateScale) + " instead.")]
        public static Matrix4d Scale(double scale)
        {
            return Scale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix.
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes.</param>
        /// <returns>A scaling matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateScale) + " instead.")]
        public static Matrix4d Scale(Vector3d scale)
        {
            return Scale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// Build a scaling matrix.
        /// </summary>
        /// <param name="x">Scale factor for x-axis.</param>
        /// <param name="y">Scale factor for y-axis.</param>
        /// <param name="z">Scale factor for z-axis.</param>
        /// <returns>A scaling matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateScale) + " instead.")]
        public static Matrix4d Scale(double x, double y, double z)
        {
            Matrix4d result;
            result.Row0 = Vector4d.UnitX * x;
            result.Row1 = Vector4d.UnitY * y;
            result.Row2 = Vector4d.UnitZ * z;
            result.Row3 = Vector4d.UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix that rotates about the x-axis.
        /// </summary>
        /// <param name="angle">The angle in radians to rotate counter-clockwise around the x-axis.</param>
        /// <returns>A rotation matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateRotationX) + " instead.")]
        public static Matrix4d RotateX(double angle)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            Matrix4d result;
            result.Row0 = Vector4d.UnitX;
            result.Row1 = new Vector4d(0.0, cos, sin, 0.0);
            result.Row2 = new Vector4d(0.0, -sin, cos, 0.0);
            result.Row3 = Vector4d.UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix that rotates about the y-axis.
        /// </summary>
        /// <param name="angle">The angle in radians to rotate counter-clockwise around the y-axis.</param>
        /// <returns>A rotation matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateRotationY) + " instead.")]
        public static Matrix4d RotateY(double angle)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            Matrix4d result;
            result.Row0 = new Vector4d(cos, 0.0, -sin, 0.0);
            result.Row1 = Vector4d.UnitY;
            result.Row2 = new Vector4d(sin, 0.0, cos, 0.0);
            result.Row3 = Vector4d.UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix that rotates about the z-axis.
        /// </summary>
        /// <param name="angle">The angle in radians to rotate counter-clockwise around the z-axis.</param>
        /// <returns>A rotation matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateRotationZ) + " instead.")]
        public static Matrix4d RotateZ(double angle)
        {
            var cos = Math.Cos(angle);
            var sin = Math.Sin(angle);

            Matrix4d result;
            result.Row0 = new Vector4d(cos, sin, 0.0, 0.0);
            result.Row1 = new Vector4d(-sin, cos, 0.0, 0.0);
            result.Row2 = Vector4d.UnitZ;
            result.Row3 = Vector4d.UnitW;
            return result;
        }

        /// <summary>
        /// Build a rotation matrix to rotate about the given axis.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">
        /// angle in radians to rotate counter-clockwise (looking in the direction of the given axis).
        /// </param>
        /// <returns>A rotation matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateFromAxisAngle) + " instead.")]
        public static Matrix4d Rotate(Vector3d axis, double angle)
        {
            var cos = Math.Cos(-angle);
            var sin = Math.Sin(-angle);
            var t = 1.0 - cos;

            axis.Normalize();

            return new Matrix4d
            (
                new Vector4d
                (
                    (t * axis.X * axis.X) + cos,
                    (t * axis.X * axis.Y) - (sin * axis.Z),
                    (t * axis.X * axis.Z) + (sin * axis.Y),
                    0.0
                ),
                new Vector4d
                (
                    (t * axis.X * axis.Y) + (sin * axis.Z),
                    (t * axis.Y * axis.Y) + cos,
                    (t * axis.Y * axis.Z) - (sin * axis.X),
                    0.0
                ),
                new Vector4d
                (
                    (t * axis.X * axis.Z) - (sin * axis.Y),
                    (t * axis.Y * axis.Z) + (sin * axis.X),
                    (t * axis.Z * axis.Z) + cos,
                    0.0
                ),
                Vector4d.UnitW
            );
        }

        /// <summary>
        /// Build a rotation matrix from a quaternion.
        /// </summary>
        /// <param name="q">The quaternion.</param>
        /// <returns>A rotation matrix.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreateFromQuaternion) + " instead.")]
        public static Matrix4d Rotate(Quaterniond q)
        {
            q.ToAxisAngle(out Vector3d axis, out double angle);
            return Rotate(axis, angle);
        }

        /// <summary>
        /// Build a world space to camera space matrix.
        /// </summary>
        /// <param name="eye">Eye (camera) position in world space.</param>
        /// <param name="target">Target position in world space.</param>
        /// <param name="up">Up vector in world space (should not be parallel to the camera direction, that is target - eye).</param>
        /// <returns>A Matrix that transforms world space to camera space.</returns>
        [Pure]
        public static Matrix4d LookAt(Vector3d eye, Vector3d target, Vector3d up)
        {
            var z = Vector3d.Normalize(eye - target);
            var x = Vector3d.Normalize(Vector3d.Cross(up, z));
            var y = Vector3d.Normalize(Vector3d.Cross(z, x));

            var rot = new Matrix4d
            (
                new Vector4d(x.X, y.X, z.X, 0.0),
                new Vector4d(x.Y, y.Y, z.Y, 0.0),
                new Vector4d(x.Z, y.Z, z.Z, 0.0),
                Vector4d.UnitW
            );

            var trans = CreateTranslation(-eye);

            return trans * rot;
        }

        /// <summary>
        /// Build a world space to camera space matrix.
        /// </summary>
        /// <param name="eyeX">Eye (camera) X-position in world space.</param>
        /// <param name="eyeY">Eye (camera) Y-position in world space.</param>
        /// <param name="eyeZ">Eye (camera) Z-position in world space.</param>
        /// <param name="targetX">Target X-position in world space.</param>
        /// <param name="targetY">Target Y-position in world space.</param>
        /// <param name="targetZ">Target Z-position in world space.</param>
        /// <param name="upX">
        /// X of the up vector in world space (should not be parallel to the camera direction, that is target - eye).
        /// </param>
        /// <param name="upY">
        /// Y of the up vector in world space (should not be parallel to the camera direction, that is target - eye).
        /// </param>
        /// <param name="upZ">
        /// Z of the up vector in world space (should not be parallel to the camera direction, that is target - eye).
        /// </param>
        /// <returns>A Matrix4 that transforms world space to camera space.</returns>
        [Pure]
        public static Matrix4d LookAt
        (
            double eyeX,
            double eyeY,
            double eyeZ,
            double targetX,
            double targetY,
            double targetZ,
            double upX,
            double upY,
            double upZ
        )
        {
            return LookAt
            (
                new Vector3d(eyeX, eyeY, eyeZ),
                new Vector3d(targetX, targetY, targetZ),
                new Vector3d(upX, upY, upZ)
            );
        }

        /// <summary>
        /// Build a projection matrix.
        /// </summary>
        /// <param name="left">Left edge of the view frustum.</param>
        /// <param name="right">Right edge of the view frustum.</param>
        /// <param name="bottom">Bottom edge of the view frustum.</param>
        /// <param name="top">Top edge of the view frustum.</param>
        /// <param name="depthNear">Distance to the near clip plane.</param>
        /// <param name="depthFar">Distance to the far clip plane.</param>
        /// <returns>A projection matrix that transforms camera space to raster space.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreatePerspectiveOffCenter) + " instead.")]
        public static Matrix4d Frustum(double left, double right, double bottom, double top, double depthNear, double depthFar)
        {
            var invRL = 1.0 / (right - left);
            var invTB = 1.0 / (top - bottom);
            var invFN = 1.0 / (depthFar - depthNear);
            return new Matrix4d
            (
                new Vector4d(2.0 * depthNear * invRL, 0.0, 0.0, 0.0),
                new Vector4d(0.0, 2.0 * depthNear * invTB, 0.0, 0.0),
                new Vector4d((right + left) * invRL, (top + bottom) * invTB, -(depthFar + depthNear) * invFN, -1.0),
                new Vector4d(0.0, 0.0, -2.0 * depthFar * depthNear * invFN, 0.0)
            );
        }

        /// <summary>
        /// Build a projection matrix.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians).</param>
        /// <param name="aspect">Aspect ratio of the view (width / height).</param>
        /// <param name="depthNear">Distance to the near clip plane.</param>
        /// <param name="depthFar">Distance to the far clip plane.</param>
        /// <returns>A projection matrix that transforms camera space to raster space.</returns>
        [Pure]
        [Obsolete("Use " + nameof(CreatePerspectiveFieldOfView) + " instead.")]
        public static Matrix4d Perspective(double fovy, double aspect, double depthNear, double depthFar)
        {
            var yMax = depthNear * Math.Tan(0.5f * fovy);
            var yMin = -yMax;
            var xMin = yMin * aspect;
            var xMax = yMax * aspect;

            return Frustum(xMin, xMax, yMin, yMax, depthNear, depthFar);
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new instance that is the result of the addition.</returns>
        [Pure]
        public static Matrix4d Add(Matrix4d left, Matrix4d right)
        {
            Add(in left, in right, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The left operand of the addition.</param>
        /// <param name="right">The right operand of the addition.</param>
        /// <param name="result">A new instance that is the result of the addition.</param>
        public static void Add(in Matrix4d left, in Matrix4d right, out Matrix4d result)
        {
            result.Row0 = left.Row0 + right.Row0;
            result.Row1 = left.Row1 + right.Row1;
            result.Row2 = left.Row2 + right.Row2;
            result.Row3 = left.Row3 + right.Row3;
        }

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <returns>A new instance that is the result of the subraction.</returns>
        [Pure]
        public static Matrix4d Subtract(Matrix4d left, Matrix4d right)
        {
            Subtract(in left, in right, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Subtracts one instance from another.
        /// </summary>
        /// <param name="left">The left operand of the subraction.</param>
        /// <param name="right">The right operand of the subraction.</param>
        /// <param name="result">A new instance that is the result of the subraction.</param>
        public static void Subtract(in Matrix4d left, in Matrix4d right, out Matrix4d result)
        {
            result.Row0 = left.Row0 - right.Row0;
            result.Row1 = left.Row1 - right.Row1;
            result.Row2 = left.Row2 - right.Row2;
            result.Row3 = left.Row3 - right.Row3;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2d Mult(Matrix4d left, Matrix4x2d right)
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
        public static void Mult(in Matrix4d left, in Matrix4x2d right, out Matrix4x2d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM13 = left.Row0.Z;
            double leftM14 = left.Row0.W;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM23 = left.Row1.Z;
            double leftM24 = left.Row1.W;
            double leftM31 = left.Row2.X;
            double leftM32 = left.Row2.Y;
            double leftM33 = left.Row2.Z;
            double leftM34 = left.Row2.W;
            double leftM41 = left.Row3.X;
            double leftM42 = left.Row3.Y;
            double leftM43 = left.Row3.Z;
            double leftM44 = left.Row3.W;

            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM31 = right.Row2.X;
            double rightM32 = right.Row2.Y;
            double rightM41 = right.Row3.X;
            double rightM42 = right.Row3.Y;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31) + (leftM14 * rightM41);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32) + (leftM14 * rightM42);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31) + (leftM24 * rightM41);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32) + (leftM24 * rightM42);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21) + (leftM33 * rightM31) + (leftM34 * rightM41);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22) + (leftM33 * rightM32) + (leftM34 * rightM42);
            result.Row3.X = (leftM41 * rightM11) + (leftM42 * rightM21) + (leftM43 * rightM31) + (leftM44 * rightM41);
            result.Row3.Y = (leftM41 * rightM12) + (leftM42 * rightM22) + (leftM43 * rightM32) + (leftM44 * rightM42);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x3d Mult(Matrix4d left, Matrix4x3d right)
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
        public static void Mult(in Matrix4d left, in Matrix4x3d right, out Matrix4x3d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM13 = left.Row0.Z;
            double leftM14 = left.Row0.W;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM23 = left.Row1.Z;
            double leftM24 = left.Row1.W;
            double leftM31 = left.Row2.X;
            double leftM32 = left.Row2.Y;
            double leftM33 = left.Row2.Z;
            double leftM34 = left.Row2.W;
            double leftM41 = left.Row3.X;
            double leftM42 = left.Row3.Y;
            double leftM43 = left.Row3.Z;
            double leftM44 = left.Row3.W;

            double rightM11 = right.Row0.X;
            double rightM12 = right.Row0.Y;
            double rightM13 = right.Row0.Z;
            double rightM21 = right.Row1.X;
            double rightM22 = right.Row1.Y;
            double rightM23 = right.Row1.Z;
            double rightM31 = right.Row2.X;
            double rightM32 = right.Row2.Y;
            double rightM33 = right.Row2.Z;
            double rightM41 = right.Row3.X;
            double rightM42 = right.Row3.Y;
            double rightM43 = right.Row3.Z;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31) + (leftM14 * rightM41);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32) + (leftM14 * rightM42);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23) + (leftM13 * rightM33) + (leftM14 * rightM43);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31) + (leftM24 * rightM41);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32) + (leftM24 * rightM42);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23) + (leftM23 * rightM33) + (leftM24 * rightM43);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21) + (leftM33 * rightM31) + (leftM34 * rightM41);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22) + (leftM33 * rightM32) + (leftM34 * rightM42);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23) + (leftM33 * rightM33) + (leftM34 * rightM43);
            result.Row3.X = (leftM41 * rightM11) + (leftM42 * rightM21) + (leftM43 * rightM31) + (leftM44 * rightM41);
            result.Row3.Y = (leftM41 * rightM12) + (leftM42 * rightM22) + (leftM43 * rightM32) + (leftM44 * rightM42);
            result.Row3.Z = (leftM41 * rightM13) + (leftM42 * rightM23) + (leftM43 * rightM33) + (leftM44 * rightM43);
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4d Mult(Matrix4d left, Matrix4d right)
        {
            Mult(in left, in right, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4d left, in Matrix4d right, out Matrix4d result)
        {
            double leftM11 = left.Row0.X;
            double leftM12 = left.Row0.Y;
            double leftM13 = left.Row0.Z;
            double leftM14 = left.Row0.W;
            double leftM21 = left.Row1.X;
            double leftM22 = left.Row1.Y;
            double leftM23 = left.Row1.Z;
            double leftM24 = left.Row1.W;
            double leftM31 = left.Row2.X;
            double leftM32 = left.Row2.Y;
            double leftM33 = left.Row2.Z;
            double leftM34 = left.Row2.W;
            double leftM41 = left.Row3.X;
            double leftM42 = left.Row3.Y;
            double leftM43 = left.Row3.Z;
            double leftM44 = left.Row3.W;
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
            double rightM41 = right.Row3.X;
            double rightM42 = right.Row3.Y;
            double rightM43 = right.Row3.Z;
            double rightM44 = right.Row3.W;

            result.Row0.X = (leftM11 * rightM11) + (leftM12 * rightM21) + (leftM13 * rightM31) + (leftM14 * rightM41);
            result.Row0.Y = (leftM11 * rightM12) + (leftM12 * rightM22) + (leftM13 * rightM32) + (leftM14 * rightM42);
            result.Row0.Z = (leftM11 * rightM13) + (leftM12 * rightM23) + (leftM13 * rightM33) + (leftM14 * rightM43);
            result.Row0.W = (leftM11 * rightM14) + (leftM12 * rightM24) + (leftM13 * rightM34) + (leftM14 * rightM44);
            result.Row1.X = (leftM21 * rightM11) + (leftM22 * rightM21) + (leftM23 * rightM31) + (leftM24 * rightM41);
            result.Row1.Y = (leftM21 * rightM12) + (leftM22 * rightM22) + (leftM23 * rightM32) + (leftM24 * rightM42);
            result.Row1.Z = (leftM21 * rightM13) + (leftM22 * rightM23) + (leftM23 * rightM33) + (leftM24 * rightM43);
            result.Row1.W = (leftM21 * rightM14) + (leftM22 * rightM24) + (leftM23 * rightM34) + (leftM24 * rightM44);
            result.Row2.X = (leftM31 * rightM11) + (leftM32 * rightM21) + (leftM33 * rightM31) + (leftM34 * rightM41);
            result.Row2.Y = (leftM31 * rightM12) + (leftM32 * rightM22) + (leftM33 * rightM32) + (leftM34 * rightM42);
            result.Row2.Z = (leftM31 * rightM13) + (leftM32 * rightM23) + (leftM33 * rightM33) + (leftM34 * rightM43);
            result.Row2.W = (leftM31 * rightM14) + (leftM32 * rightM24) + (leftM33 * rightM34) + (leftM34 * rightM44);
            result.Row3.X = (leftM41 * rightM11) + (leftM42 * rightM21) + (leftM43 * rightM31) + (leftM44 * rightM41);
            result.Row3.Y = (leftM41 * rightM12) + (leftM42 * rightM22) + (leftM43 * rightM32) + (leftM44 * rightM42);
            result.Row3.Z = (leftM41 * rightM13) + (leftM42 * rightM23) + (leftM43 * rightM33) + (leftM44 * rightM43);
            result.Row3.W = (leftM41 * rightM14) + (leftM42 * rightM24) + (leftM43 * rightM34) + (leftM44 * rightM44);
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <returns>A new instance that is the result of the multiplication.</returns>
        [Pure]
        public static Matrix4d Mult(Matrix4d left, double right)
        {
            Mult(in left, right, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication.</param>
        public static void Mult(in Matrix4d left, double right, out Matrix4d result)
        {
            result.Row0 = left.Row0 * right;
            result.Row1 = left.Row1 * right;
            result.Row2 = left.Row2 * right;
            result.Row3 = left.Row3 * right;
        }

        /// <summary>
        /// Calculate the inverse of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to invert.</param>
        /// <param name="result">The inverted matrix.</param>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4d is singular.</exception>
        [Pure]
        public static void Invert(in Matrix4d mat, out Matrix4d result)
        {
            // Original implementation can be found here:
            // https://github.com/dotnet/runtime/blob/79ae74f5ca5c8a6fe3a48935e85bd7374959c570/src/libraries/System.Private.CoreLib/src/System/Numerics/Matrix4x4.cs#L1556
#pragma warning disable SA1407 // Arithmetic expressions should declare precedence
            double a = mat.M11, b = mat.M21, c = mat.M31, d = mat.M41;
            double e = mat.M12, f = mat.M22, g = mat.M32, h = mat.M42;
            double i = mat.M13, j = mat.M23, k = mat.M33, l = mat.M43;
            double m = mat.M14, n = mat.M24, o = mat.M34, p = mat.M44;

            double kp_lo = k * p - l * o;
            double jp_ln = j * p - l * n;
            double jo_kn = j * o - k * n;
            double ip_lm = i * p - l * m;
            double io_km = i * o - k * m;
            double in_jm = i * n - j * m;

            double a11 = +(f * kp_lo - g * jp_ln + h * jo_kn);
            double a12 = -(e * kp_lo - g * ip_lm + h * io_km);
            double a13 = +(e * jp_ln - f * ip_lm + h * in_jm);
            double a14 = -(e * jo_kn - f * io_km + g * in_jm);

            double det = a * a11 + b * a12 + c * a13 + d * a14;

            if (Math.Abs(det) < double.Epsilon)
            {
                throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
            }

            double invDet = 1.0f / det;

            result.Row0 = new Vector4d(a11, a12, a13, a14) * invDet;

            result.Row1 = new Vector4d(
                -(b * kp_lo - c * jp_ln + d * jo_kn),
                +(a * kp_lo - c * ip_lm + d * io_km),
                -(a * jp_ln - b * ip_lm + d * in_jm),
                +(a * jo_kn - b * io_km + c * in_jm)) * invDet;

            double gp_ho = g * p - h * o;
            double fp_hn = f * p - h * n;
            double fo_gn = f * o - g * n;
            double ep_hm = e * p - h * m;
            double eo_gm = e * o - g * m;
            double en_fm = e * n - f * m;

            result.Row2 = new Vector4d(
                +(b * gp_ho - c * fp_hn + d * fo_gn),
                -(a * gp_ho - c * ep_hm + d * eo_gm),
                +(a * fp_hn - b * ep_hm + d * en_fm),
                -(a * fo_gn - b * eo_gm + c * en_fm)) * invDet;

            double gl_hk = g * l - h * k;
            double fl_hj = f * l - h * j;
            double fk_gj = f * k - g * j;
            double el_hi = e * l - h * i;
            double ek_gi = e * k - g * i;
            double ej_fi = e * j - f * i;

            result.Row3 = new Vector4d(
                -(b * gl_hk - c * fl_hj + d * fk_gj),
                +(a * gl_hk - c * el_hi + d * ek_gi),
                -(a * fl_hj - b * el_hi + d * ej_fi),
                +(a * fk_gj - b * ek_gi + c * ej_fi)) * invDet;
#pragma warning restore SA1407 // Arithmetic expressions should declare precedence
        }

        /// <summary>
        /// Calculate the inverse of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to invert.</param>
        /// <returns>The inverse of the given matrix.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4d is singular.</exception>
        [Pure]
        public static Matrix4d Invert(in Matrix4d mat)
        {
            Invert(mat, out Matrix4d result);
            return result;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <returns>The transpose of the given matrix.</returns>
        [Pure]
        public static Matrix4d Transpose(Matrix4d mat)
        {
            return new Matrix4d(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
        }

        /// <summary>
        /// Calculate the transpose of the given matrix.
        /// </summary>
        /// <param name="mat">The matrix to transpose.</param>
        /// <param name="result">The result of the calculation.</param>
        public static void Transpose(in Matrix4d mat, out Matrix4d result)
        {
            result.Row0 = mat.Column0;
            result.Row1 = mat.Column1;
            result.Row2 = mat.Column2;
            result.Row3 = mat.Column3;
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
        public static Matrix4d Swizzle(Matrix4d mat, int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3)
        {
            Swizzle(mat, rowForRow0, rowForRow1, rowForRow2, rowForRow3, out Matrix4d result);
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
        public static void Swizzle(in Matrix4d mat, int rowForRow0, int rowForRow1, int rowForRow2, int rowForRow3, out Matrix4d result)
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
        /// Transform a Vector by the given Matrix using right-handed notation.
        /// </summary>
        /// <param name="mat">The desired transformation.</param>
        /// <param name="vec">The vector to transform.</param>
        /// <returns>The transformed vector.</returns>
        [Pure]
        public static Vector4d operator *(Matrix4d mat, Vector4d vec)
        {
            Vector4d.TransformColumn(in mat, in vec, out Vector4d result);
            return result;
        }

        /// <summary>
        /// Matrix multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4x2d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4x2d operator *(Matrix4d left, Matrix4x2d right)
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
        public static Matrix4x3d operator *(Matrix4d left, Matrix4x3d right)
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
        public static Matrix4d operator *(Matrix4d left, Matrix4d right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix-scalar multiplication.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4d which holds the result of the multiplication.</returns>
        [Pure]
        public static Matrix4d operator *(Matrix4d left, double right)
        {
            return Mult(left, right);
        }

        /// <summary>
        /// Matrix addition.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4d which holds the result of the addition.</returns>
        [Pure]
        public static Matrix4d operator +(Matrix4d left, Matrix4d right)
        {
            return Add(left, right);
        }

        /// <summary>
        /// Matrix subtraction.
        /// </summary>
        /// <param name="left">left-hand operand.</param>
        /// <param name="right">right-hand operand.</param>
        /// <returns>A new Matrix4d which holds the result of the subtraction.</returns>
        [Pure]
        public static Matrix4d operator -(Matrix4d left, Matrix4d right)
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
        public static bool operator ==(Matrix4d left, Matrix4d right)
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
        public static bool operator !=(Matrix4d left, Matrix4d right)
        {
            return !left.Equals(right);
        }

        /// <inheritdoc />
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
            var row3 = Row3.ToString(format, formatProvider);
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
            return obj is Matrix4d && Equals((Matrix4d)obj);
        }

        /// <summary>
        /// Indicates whether the current matrix is equal to another matrix.
        /// </summary>
        /// <param name="other">A matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        [Pure]
        public readonly bool Equals(Matrix4d other)
        {
            Vector512<double> aRow01 = Vector512.LoadUnsafe(in Row0.X);
            Vector512<double> aRow23 = Vector512.LoadUnsafe(in Row2.X);

            Vector512<double> bRow01 = Vector512.LoadUnsafe(in other.Row0.X);
            Vector512<double> bRow23 = Vector512.LoadUnsafe(in other.Row2.X);

            return aRow01 == bRow01 && aRow23 == bRow23;
        }
    }
}
