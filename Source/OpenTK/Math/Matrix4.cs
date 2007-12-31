#region --- License ---
/* Copyright (c) 2006, 2007 the OpenTK team
 * See license.txt for license info
 * 
 * Implemented by Andy Gill
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a 4x4 Matrix
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4
    {
        #region Fields

		/// <summary>
		/// Top row of the matrix
		/// </summary>
		public Vector4 Row0;
		/// <summary>
		/// 2nd row of the matrix
		/// </summary>
		public Vector4 Row1;
		/// <summary>
		/// 3rd row of the matrix
		/// </summary>
		public Vector4 Row2;
		/// <summary>
		/// Bottom row of the matrix
		/// </summary>
		public Vector4 Row3;
 
		/// <summary>
		/// The identity matrix
		/// </summary>
		public static Matrix4 Identity = new Matrix4(Vector4.UnitX, Vector4.UnitY, Vector4.UnitZ, Vector4.UnitW);

        #endregion

        #region Constructors

		/// <summary>
		/// Construct a new matrix from 4 vectors representing each row
		/// </summary>
		/// <param name="row0">Top row of the matrix</param>
		/// <param name="row1">2nd row of the matrix</param>
		/// <param name="row2">3rd row of the matrix</param>
		/// <param name="row3">Bottom row of the matrix</param>
		public Matrix4(Vector4 row0, Vector4 row1, Vector4 row2, Vector4 row3)
		{
			Row0 = row0;
			Row1 = row1;
			Row2 = row2;
			Row3 = row3;
		}

        #endregion

        #region Functions

		#region public void Invert()

		public void Invert()
		{
			this = Matrix4.Invert(this);
		}
		
		#endregion

		#region public void Transpose()

		public void Transpose()
		{
			this = Matrix4.Transpose(this);
		}
		
		#endregion

		#endregion

		#region Properties

		/// <summary>
		/// The determinant of this matrix
		/// </summary>
		public float Determinant
		{
			get
			{
				return
                    Row0.X * Row1.Y * Row2.Z * Row3.W - Row0.X * Row1.Y * Row2.W * Row3.Z + Row0.X * Row1.Z * Row2.W * Row3.Y - Row0.X * Row1.Z * Row2.Y * Row3.W
				  + Row0.X * Row1.W * Row2.Y * Row3.Z - Row0.X * Row1.W * Row2.Z * Row3.Y - Row0.Y * Row1.Z * Row2.W * Row3.X + Row0.Y * Row1.Z * Row2.X * Row3.W
				  - Row0.Y * Row1.W * Row2.X * Row3.Z + Row0.Y * Row1.W * Row2.Z * Row3.X - Row0.Y * Row1.X * Row2.Z * Row3.W + Row0.Y * Row1.X * Row2.W * Row3.Z
				  + Row0.Z * Row1.W * Row2.X * Row3.Y - Row0.Z * Row1.W * Row2.Y * Row3.X + Row0.Z * Row1.X * Row2.Y * Row3.W - Row0.Z * Row1.X * Row2.W * Row3.Y
				  + Row0.Z * Row1.Y * Row2.W * Row3.X - Row0.Z * Row1.Y * Row2.X * Row3.W - Row0.W * Row1.X * Row2.Y * Row3.Z + Row0.W * Row1.X * Row2.Z * Row3.Y
				  - Row0.W * Row1.Y * Row2.Z * Row3.X + Row0.W * Row1.Y * Row2.X * Row3.Z - Row0.W * Row1.Z * Row2.X * Row3.Y + Row0.W * Row1.Z * Row2.Y * Row3.X;
			}
		}

		/// <summary>
		/// The first column of this matrix
		/// </summary>
		public Vector4 Column0
		{
			get { return new Vector4(Row0.X, Row1.X, Row2.X, Row3.X); }
		}

		/// <summary>
		/// The second column of this matrix
		/// </summary>
		public Vector4 Column1
		{
			get { return new Vector4(Row0.Y, Row1.Y, Row2.Y, Row3.Y); }
		}

		/// <summary>
		/// The third column of this matrix
		/// </summary>
		public Vector4 Column2
		{
			get { return new Vector4(Row0.Z, Row1.Z, Row2.Z, Row3.Z); }
		}

		/// <summary>
		/// The fourth column of this matrix
		/// </summary>
		public Vector4 Column3
		{
			get { return new Vector4(Row0.W, Row1.W, Row2.W, Row3.W); }
		}

		#endregion

		#region Operator overloads

		/// <summary>
		/// Matrix multiplication
		/// </summary>
		/// <param name="left">left-hand operand</param>
		/// <param name="right">right-hand operand</param>
		/// <returns>A new Matrix44 which holds the result of the multiplication</returns>
		public static Matrix4 operator *(Matrix4 left, Matrix4 right)
		{
			return Matrix4.Mult(left, right);
		}

        public float get(int x, int y)
        {
            throw new NotImplementedException();
        }

        #endregion

		#region Static functions

		#region Scale Functions

		/// <summary>
		/// Build a scaling matrix
		/// </summary>
		/// <param name="scale">Single scale factor for x,y and z axes</param>
		/// <returns>A scaling matrix</returns>
		public static Matrix4 Scale(float scale)
		{
			return Scale(scale, scale, scale);
		}

		/// <summary>
		/// Build a scaling matrix
		/// </summary>
		/// <param name="scale">Scale factors for x,y and z axes</param>
		/// <returns>A scaling matrix</returns>
		public static Matrix4 Scale(Vector3 scale)
		{
			return Scale(scale.X, scale.Y, scale.Z);
		}

		/// <summary>
		/// Build a scaling matrix
		/// </summary>
		/// <param name="x">Scale factor for x-axis</param>
		/// <param name="y">Scale factor for y-axis</param>
		/// <param name="z">Scale factor for z-axis</param>
		/// <returns>A scaling matrix</returns>
		public static Matrix4 Scale(float x, float y, float z)
		{
			Matrix4 result;
			result.Row0 = Vector4.UnitX * x;
			result.Row1 = Vector4.UnitY * y;
			result.Row2 = Vector4.UnitZ * z;
			result.Row3 = Vector4.UnitW;
			return result;
		}

		#endregion

		#region Translation Functions

		/// <summary>
		/// Build a translation matrix with the given translation
		/// </summary>
		/// <param name="trans">The vector to translate along</param>
		/// <returns>A Translation matrix</returns>
		public static Matrix4 Translation(Vector3 trans)
		{
			return Translation(trans.X, trans.Y, trans.Z);
		}

		/// <summary>
		/// Build a translation matrix with the given translation
		/// </summary>
		/// <param name="x">X translation</param>
		/// <param name="y">Y translation</param>
		/// <param name="z">Z translation</param>
		/// <returns>A Translation matrix</returns>
		public static Matrix4 Translation(float x, float y, float z)
		{
			Matrix4 result = Identity;
			result.Row3 = new Vector4(x, y, z, 1.0f);
			return result;
		}

		#endregion

		#region Rotation Functions

		/// <summary>
		/// Build a rotation matrix that rotates about the x-axis
		/// </summary>
		/// <param name="angle">angle in radians to rotate counter-clockwise around the x-axis</param>
		/// <returns>A rotation matrix</returns>
		public static Matrix4 RotateX(float angle)
		{
			float cos = (float)System.Math.Cos(angle);
			float sin = (float)System.Math.Sin(angle);

			Matrix4 result;
			result.Row0 = Vector4.UnitX;
			result.Row1 = new Vector4(0.0f, cos, sin, 0.0f);
			result.Row2 = new Vector4(0.0f, -sin, cos, 0.0f);
			result.Row3 = Vector4.UnitW;
			return result;
		}

		/// <summary>
		/// Build a rotation matrix that rotates about the y-axis
		/// </summary>
		/// <param name="angle">angle in radians to rotate counter-clockwise around the y-axis</param>
		/// <returns>A rotation matrix</returns>
		public static Matrix4 RotateY(float angle)
		{
			float cos = (float)System.Math.Cos(angle);
			float sin = (float)System.Math.Sin(angle);

			Matrix4 result;
			result.Row0 = new Vector4(cos, 0.0f, -sin, 0.0f);
			result.Row1 = Vector4.UnitY;
			result.Row2 = new Vector4(sin, 0.0f, cos, 0.0f);
			result.Row3 = Vector4.UnitW;
			return result;
		}

		/// <summary>
		/// Build a rotation matrix that rotates about the z-axis
		/// </summary>
		/// <param name="angle">angle in radians to rotate counter-clockwise around the z-axis</param>
		/// <returns>A rotation matrix</returns>
		public static Matrix4 RotateZ(float angle)
		{
			float cos = (float)System.Math.Cos(angle);
			float sin = (float)System.Math.Sin(angle);

			Matrix4 result;
			result.Row0 = new Vector4(cos, sin, 0.0f, 0.0f);
			result.Row1 = new Vector4(-sin, cos, 0.0f, 0.0f);
			result.Row2 = Vector4.UnitZ;
			result.Row3 = Vector4.UnitW;
			return result;
		}

		/// <summary>
		/// Build a rotation matrix to rotate about the given axis
		/// </summary>
		/// <param name="axis">the axis to rotate about</param>
		/// <param name="angle">angle in radians to rotate counter-clockwise (looking in the direction of the given axis)</param>
		/// <returns>A rotation matrix</returns>
		public static Matrix4 Rotate(Vector3 axis, float angle)
		{
			float cos = (float)System.Math.Cos(-angle);
			float sin = (float)System.Math.Sin(-angle);
			float t = 1.0f - cos;

			axis.Normalize();

			Matrix4 result;
			result.Row0 = new Vector4(t * axis.X * axis.X + cos, t * axis.X * axis.Y - sin * axis.Z, t * axis.X * axis.Z + sin * axis.Y, 0.0f);
			result.Row1 = new Vector4(t * axis.X * axis.Y + sin * axis.Z, t * axis.Y * axis.Y + cos, t * axis.Y * axis.Z - sin * axis.X, 0.0f);
			result.Row2 = new Vector4(t * axis.X * axis.Z - sin * axis.Y, t * axis.Y * axis.Z + sin * axis.X, t * axis.Z * axis.Z + cos, 0.0f);
			result.Row3 = Vector4.UnitW;
			return result;
		}

		/// <summary>
		/// Build a rotation matrix from a quaternion
		/// </summary>
		/// <param name="q">the quaternion</param>
		/// <returns>A rotation matrix</returns>
		public static Matrix4 Rotate(Quaternion q)
		{
			Vector3 axis;
			float angle;
			q.ToAxisAngle(out axis, out angle);
			return Rotate(axis, angle);
		}

		#endregion

		#region Camera Helper Functions

		/// <summary>
		/// Build a world space to camera space matrix
		/// </summary>
		/// <param name="eye">Eye (camera) position in world space</param>
		/// <param name="target">Target position in world space</param>
		/// <param name="up">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
		/// <returns>A Matrix that transforms world space to camera space</returns>
		public static Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
		{
			Vector3 z = Vector3.Normalize(eye - target);
			Vector3 x = Vector3.Normalize(Vector3.Cross(up, z));
			Vector3 y = Vector3.Normalize(Vector3.Cross(z, x));

			Matrix4 rot = new Matrix4(new Vector4(x.X, y.X, z.X, 0.0f),
										new Vector4(x.Y, y.Y, z.Y, 0.0f),
										new Vector4(x.Z, y.Z, z.Z, 0.0f),
										Vector4.UnitW);

			Matrix4 trans = Matrix4.Translation(-eye);

			return trans * rot;
		}

		/// <summary>
		/// Build a projection matrix
		/// </summary>
		/// <param name="left">Left edge of the view frustum</param>
		/// <param name="right">Right edge of the view frustum</param>
		/// <param name="bottom">Bottom edge of the view frustum</param>
		/// <param name="top">Top edge of the view frustum</param>
		/// <param name="near">Distance to the near clip plane</param>
		/// <param name="far">Distance to the far clip plane</param>
		/// <returns>A projection matrix that transforms camera space to raster space</returns>
		public static Matrix4 Frustum(float left, float right, float bottom, float top, float near, float far)
		{
			float invRL = 1.0f / (right - left);
			float invTB = 1.0f / (top - bottom);
			float invFN = 1.0f / (far - near);
			return new Matrix4(new Vector4(2.0f * near * invRL, 0.0f, (right + left) * invRL, 0.0f),
								new Vector4(0.0f, 2.0f * near * invTB, (top + bottom) * invTB, 0.0f),
								new Vector4(0.0f, 0.0f, -(far + near) * invFN, -1.0f),
								new Vector4(0.0f, 0.0f, -2.0f * far * near * invFN, 0.0f));
		}

		/// <summary>
		/// Build a projection matrix
		/// </summary>
		/// <param name="fovy">Angle of the field of view in the y direction (in radians)</param>
		/// <param name="aspect">Aspect ratio of the view (width / height)</param>
		/// <param name="near">Distance to the near clip plane</param>
		/// <param name="far">Distance to the far clip plane</param>
		/// <returns>A projection matrix that transforms camera space to raster space</returns>
		public static Matrix4 Perspective(float fovy, float aspect, float near, float far)
		{
			float yMax = near * (float)System.Math.Tan(0.5f * fovy);
			float yMin = -yMax;
			float xMin = yMin * aspect;
			float xMax = yMax * aspect;

			return Frustum(xMin, xMax, yMin, yMax, near, far);
		}

		#endregion

		#region Multiply Functions

		/// <summary>
		/// Post multiply this matrix by another matrix
		/// </summary>
		/// <param name="right">The matrix to multiply</param>
		/// <returns>A new Matrix44 that is the result of the multiplication</returns>
		public static Matrix4 Mult(Matrix4 left, Matrix4 right)
		{
			Vector4 col0 = right.Column0;
			Vector4 col1 = right.Column1;
			Vector4 col2 = right.Column2;
			Vector4 col3 = right.Column3;

			left.Row0 = new Vector4(Vector4.Dot(left.Row0, col0), Vector4.Dot(left.Row0, col1), Vector4.Dot(left.Row0, col2), Vector4.Dot(left.Row0, col3));
			left.Row1 = new Vector4(Vector4.Dot(left.Row1, col0), Vector4.Dot(left.Row1, col1), Vector4.Dot(left.Row1, col2), Vector4.Dot(left.Row1, col3));
			left.Row2 = new Vector4(Vector4.Dot(left.Row2, col0), Vector4.Dot(left.Row2, col1), Vector4.Dot(left.Row2, col2), Vector4.Dot(left.Row2, col3));
			left.Row3 = new Vector4(Vector4.Dot(left.Row3, col0), Vector4.Dot(left.Row3, col1), Vector4.Dot(left.Row3, col2), Vector4.Dot(left.Row3, col3));
			return left;
		}

		public static void Mult(ref Matrix4 left, ref Matrix4 right, out Matrix4 result)
		{
			Vector4 col0 = right.Column0;
			Vector4 col1 = right.Column1;
			Vector4 col2 = right.Column2;
			Vector4 col3 = right.Column3;

			result.Row0 = new Vector4(Vector4.Dot(left.Row0, col0), Vector4.Dot(left.Row0, col1), Vector4.Dot(left.Row0, col2), Vector4.Dot(left.Row0, col3));
			result.Row1 = new Vector4(Vector4.Dot(left.Row1, col0), Vector4.Dot(left.Row1, col1), Vector4.Dot(left.Row1, col2), Vector4.Dot(left.Row1, col3));
			result.Row2 = new Vector4(Vector4.Dot(left.Row2, col0), Vector4.Dot(left.Row2, col1), Vector4.Dot(left.Row2, col2), Vector4.Dot(left.Row2, col3));
			result.Row3 = new Vector4(Vector4.Dot(left.Row3, col0), Vector4.Dot(left.Row3, col1), Vector4.Dot(left.Row3, col2), Vector4.Dot(left.Row3, col3));
		}

		#endregion

		#region Invert Functions

		/// <summary>
		/// Calculate the inverse of the given matrix
		/// </summary>
		/// <param name="mat">The matrix to invert</param>
		/// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
		public static Matrix4 Invert(Matrix4 mat)
		{
			int[] colIdx = { 0, 0, 0, 0 };
			int[] rowIdx = { 0, 0, 0, 0 };
			int[] pivotIdx = { -1, -1, -1, -1 };

			// convert the matrix to an array for easy looping
			float[,] inverse = {{mat.Row0.X, mat.Row0.Y, mat.Row0.Z, mat.Row0.W}, 
								{mat.Row1.X, mat.Row1.Y, mat.Row1.Z, mat.Row1.W}, 
								{mat.Row2.X, mat.Row2.Y, mat.Row2.Z, mat.Row2.W}, 
								{mat.Row3.X, mat.Row3.Y, mat.Row3.Z, mat.Row3.W} };
			int icol = 0;
			int irow = 0;
			for (int i = 0; i < 4; i++)
			{
				// Find the largest pivot value
				float maxPivot = 0.0f;
				for (int j = 0; j < 4; j++)
				{
					if (pivotIdx[j] != 0)
					{
						for (int k = 0; k < 4; ++k)
						{
							if (pivotIdx[k] == -1)
							{
								float absVal = System.Math.Abs(inverse[j, k]);
								if (absVal > maxPivot)
								{
									maxPivot = absVal;
									irow = j;
									icol = k;
								}
							}
							else if (pivotIdx[k] > 0)
							{
								return mat;
							}
						}
					}
				}

				++(pivotIdx[icol]);

				// Swap rows over so pivot is on diagonal
				if (irow != icol)
				{
					for (int k = 0; k < 4; ++k)
					{
						float f = inverse[irow, k];
						inverse[irow, k] = inverse[icol, k];
						inverse[icol, k] = f;
					}
				}

				rowIdx[i] = irow;
				colIdx[i] = icol;

				float pivot = inverse[icol, icol];
				// check for singular matrix
				if (pivot == 0.0f)
				{
                    throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
					//return mat;
				}

				// Scale row so it has a unit diagonal
				float oneOverPivot = 1.0f / pivot;
				inverse[icol, icol] = 1.0f;
				for (int k = 0; k < 4; ++k)
					inverse[icol, k] *= oneOverPivot;

				// Do elimination of non-diagonal elements
				for (int j = 0; j < 4; ++j)
				{
					// check this isn't on the diagonal
					if (icol != j)
					{
						float f = inverse[j, icol];
						inverse[j, icol] = 0.0f;
						for (int k = 0; k < 4; ++k)
							inverse[j, k] -= inverse[icol, k] * f;
					}
				}
			}

			for (int j = 3; j >= 0; --j)
			{
				int ir = rowIdx[j];
				int ic = colIdx[j];
				for (int k = 0; k < 4; ++k)
				{
					float f = inverse[k, ir];
					inverse[k, ir] = inverse[k, ic];
					inverse[k, ic] = f;
				}
			}

			mat.Row0 = new Vector4(inverse[0, 0], inverse[0, 1], inverse[0, 2], inverse[0, 3]);
			mat.Row1 = new Vector4(inverse[1, 0], inverse[1, 1], inverse[1, 2], inverse[1, 3]);
			mat.Row2 = new Vector4(inverse[2, 0], inverse[2, 1], inverse[2, 2], inverse[2, 3]);
			mat.Row3 = new Vector4(inverse[3, 0], inverse[3, 1], inverse[3, 2], inverse[3, 3]);
			return mat;
		}

		#endregion

		#region Transpose

		/// <summary>
		/// Calculate the transpose of the given matrix
		/// </summary>
		/// <param name="mat">The matrix to transpose</param>
		/// <returns>The transpose of the given matrix</returns>
		public static Matrix4 Transpose(Matrix4 mat)
		{
			return new Matrix4(mat.Column0, mat.Column1, mat.Column2, mat.Column3);
		}


		/// <summary>
		/// Calculate the transpose of the given matrix
		/// </summary>
		/// <param name="mat">The matrix to transpose</param>
		public static void Transpose(ref Matrix4 mat, out Matrix4 result)
		{
			result.Row0 = mat.Column0;
			result.Row1 = mat.Column1;
			result.Row2 = mat.Column2;
			result.Row3 = mat.Column3;
		}

		#endregion

		#endregion

		#region public override string ToString()

		/// <summary>
        /// Returns a System.String that represents the current Matrix44.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n{3}", Row0, Row1, Row2, Row3);
        }

        #endregion
    }
}
