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
	public struct Matrix3x2 : IEquatable<Matrix3x2>
	{
		#region Fields

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
		public static Matrix3x2 Zero = new Matrix3x2(Vector2.Zero, Vector2.Zero, Vector2.Zero);

		#endregion

		#region Constructors

		public Matrix3x2(Vector2 row0, Vector2 row1, Vector2 row2)
		{
			Row0 = row0;
			Row1 = row1;
			Row2 = row2;
		}

		public Matrix3x2(
			float m00, float m01,
			float m10, float m11,
			float m20, float m21)
		{
			Row0 = new Vector2(m00, m01);
			Row1 = new Vector2(m10, m11);
			Row2 = new Vector2(m20, m21);
		}

		#endregion

		#region Public Members

		#region Properties

		public Vector3 Column0
		{
			get { return new Vector3(Row0.X, Row1.X, Row2.X); }
			set { Row0.X = value.X; Row1.X = value.Y; Row2.X = value.Z; }
		}

		public Vector3 Column1
		{
			get { return new Vector3(Row0.Y, Row1.Y, Row2.Y); }
			set { Row0.Y = value.X; Row1.Y = value.Y; Row2.Y = value.Z; }
		}

		public float M11 { get { return Row0.X; } set { Row0.X = value; } }
		public float M12 { get { return Row0.Y; } set { Row0.Y = value; } }
		public float M21 { get { return Row1.X; } set { Row1.X = value; } }
		public float M22 { get { return Row1.Y; } set { Row1.Y = value; } }
		public float M31 { get { return Row2.X; } set { Row2.X = value; } }
		public float M32 { get { return Row2.Y; } set { Row2.Y = value; } }

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
				throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")");
			}
			set
			{
				if (rowIndex == 0) Row0[columnIndex] = value;
				else if (rowIndex == 1) Row1[columnIndex] = value;
				else if (rowIndex == 2) Row2[columnIndex] = value;
				throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
			}
		}

		#endregion

		#region Instance
		#endregion

		#region Static
		#endregion

		#region Operators
		#endregion

		#region Overrides

		#region public override string ToString()

		/// <summary>
		/// Returns a System.String that represents the current Matrix3d.
		/// </summary>
		/// <returns>The string representation of the matrix.</returns>
		public override string ToString()
		{
			return String.Format("{0}\n{1}\n{2}", Row0, Row1, Row2);
		}

		#endregion

		#region public override int GetHashCode()

		/// <summary>
		/// Returns the hashcode for this instance.
		/// </summary>
		/// <returns>A System.Int32 containing the unique hashcode for this instance.</returns>
		public override int GetHashCode()
		{
			return Row0.GetHashCode() ^ Row1.GetHashCode() ^ Row2.GetHashCode();
		}

		#endregion

		#region public override bool Equals(object obj)

		/// <summary>
		/// Indicates whether this instance and a specified object are equal.
		/// </summary>
		/// <param name="obj">The object to compare to.</param>
		/// <returns>True if the instances are equal; false otherwise.</returns>
		public override bool Equals(object obj)
		{
			if (!(obj is Matrix3x2))
				return false;

			return this.Equals((Matrix3x2)obj);
		}

		#endregion

		#endregion

		#endregion

		#region IEquatable<Matrix3x2> Members

		public bool Equals(Matrix3x2 other)
		{
			return
				Row0 == other.Row0 &&
				Row1 == other.Row1 &&
				Row2 == other.Row2;
		}

		#endregion
	}
}
