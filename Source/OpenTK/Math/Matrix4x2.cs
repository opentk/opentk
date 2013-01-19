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
	public struct Matrix4x2 : IEquatable<Matrix4x2>
	{
		#region Fields

		public Vector2 Row0;
		public Vector2 Row1;
		public Vector2 Row2;
		public Vector2 Row3;

		#endregion

		#region Constructors

		public Matrix4x2(Vector2 row0, Vector2 row1, Vector2 row2, Vector2 row3)
		{
			Row0 = row0;
			Row1 = row1;
			Row2 = row2;
			Row3 = row3;
		}

		public Matrix4x2(
			float m00, float m01,
			float m10, float m11,
			float m20, float m21,
			float m30, float m31)
		{
			Row0 = new Vector2(m00, m01);
			Row1 = new Vector2(m10, m11);
			Row2 = new Vector2(m20, m21);
			Row3 = new Vector2(m30, m31);
		}

		#endregion

		#region Public Members

		#region Properties

		public Vector4 Column0
		{
			get { return new Vector4(Row0.X, Row1.X, Row2.X, Row3.X); }
			set { Row0.X = value.X; Row1.X = value.Y; Row2.X = value.Z; Row3.X = value.W; }
		}

		public Vector4 Column1
		{
			get { return new Vector4(Row0.Y, Row1.Y, Row2.Y, Row3.X); }
			set { Row0.Y = value.X; Row1.Y = value.Y; Row2.Y = value.Z; Row3.Y = value.W; }
		}

		public float M11 { get { return Row0.X; } set { Row0.X = value; } }
		public float M12 { get { return Row0.Y; } set { Row0.Y = value; } }
		public float M21 { get { return Row1.X; } set { Row1.X = value; } }
		public float M22 { get { return Row1.Y; } set { Row1.Y = value; } }
		public float M31 { get { return Row2.X; } set { Row2.X = value; } }
		public float M32 { get { return Row2.Y; } set { Row2.Y = value; } }
		public float M41 { get { return Row3.X; } set { Row3.X = value; } }
		public float M42 { get { return Row3.Y; } set { Row3.Y = value; } }

		#endregion

		#region Indexers

		/// <summary>
		/// Gets or sets the value at a specified row and column.
		/// </summary>
		public float this[int rowIndex, int columnIndex]
		{
			get
			{
				if (rowIndex == 0) return Row0[columnIndex];
				else if (rowIndex == 1) return Row1[columnIndex];
				else if (rowIndex == 2) return Row2[columnIndex];
				else if (rowIndex == 3) return Row3[columnIndex];
				throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")");
			}
			set
			{
				if (rowIndex == 0) Row0[columnIndex] = value;
				else if (rowIndex == 1) Row1[columnIndex] = value;
				else if (rowIndex == 2) Row2[columnIndex] = value;
				else if (rowIndex == 3) Row3[columnIndex] = value;
				throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
			}
		}

		#endregion

		#endregion

		#region IEquatable<Matrix4x2> Members

		public bool Equals(Matrix4x2 other)
		{
			return
				Row0 == other.Row0 &&
				Row1 == other.Row1 &&
				Row2 == other.Row2 &&
				Row3 == other.Row3;
		}

		#endregion
	}
}
