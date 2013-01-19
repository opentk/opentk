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
using System.Collections.Generic;

namespace OpenTK
{
	public struct Matrix2x3 : IEquatable<Matrix2x3>
	{
		#region Fields

		public Vector3 Row0;
		public Vector3 Row1;

		#endregion

		#region Constructors

		public Matrix2x3(Vector3 row0, Vector3 row1)
		{
			Row0 = row0;
			Row1 = row1;
		}

		public Matrix2x3(
			float m00, float m01, float m02,
			float m10, float m11, float m12)
		{
			Row0 = new Vector3(m00, m01, m02);
			Row1 = new Vector3(m10, m11, m12);
		}

		#endregion

		#region Public Members

		#region Properties

		public Vector2 Column0
		{
			get { return new Vector2(Row0.X, Row1.X); }
			set { Row0.X = value.X; Row1.X = value.Y; }
		}

		public Vector2 Column1
		{
			get { return new Vector2(Row0.Y, Row1.Y); }
			set { Row0.Y = value.X; Row1.Y = value.Y; }
		}

		public Vector2 Column2
		{
			get { return new Vector2(Row0.Z, Row1.Z); }
			set { Row0.Z = value.X; Row1.Z = value.Y; }
		}

		public float M11 { get { return Row0.X; } set { Row0.X = value; } }
		public float M12 { get { return Row0.Y; } set { Row0.Y = value; } }
		public float M13 { get { return Row0.Z; } set { Row0.Z = value; } }
		public float M21 { get { return Row1.X; } set { Row1.X = value; } }
		public float M22 { get { return Row1.Y; } set { Row1.Y = value; } }
		public float M23 { get { return Row1.Z; } set { Row1.Z = value; } }

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
				throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")");
			}
			set
			{
				if (rowIndex == 0) Row0[columnIndex] = value;
				else if (rowIndex == 1) Row1[columnIndex] = value;
				throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
			}
		}

		#endregion

		#endregion

		#region IEquatable<Matrix2x3> Members

		public bool Equals(Matrix2x3 other)
		{
			return
				Row0 == other.Row0 &&
				Row1 == other.Row1;
		}

		#endregion
	}
}
