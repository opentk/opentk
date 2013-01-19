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
    public struct Matrix2 : IEquatable<Matrix2>
    {
        #region Fields

        /// <summary>
        /// Top row of the matrix.
        /// </summary>
        public Vector2 Row0;

        /// <summary>
        /// Bottom row of the matrix.
        /// </summary>
        public Vector2 Row1;

        #endregion

        #region Constructors

        public Matrix2(Vector2 row0, Vector2 row1)
        {
            Row0 = row0;
            Row1 = row1;
        }

        public Matrix2(
            float m00, float m01,
            float m10, float m11)
        {
            Row0 = new Vector2(m00, m01);
            Row1 = new Vector2(m10, m11);
        }

        #endregion

        #region Public Members

        #region Properties

        public float Determinant
        {
            get
            {
                float m11 = Row0.X, m12 = Row0.Y,
                      m21 = Row1.X, m22 = Row1.Y;

                return m11 * m22 - m12 * m21;
            }
        }

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

        public float M11 { get { return Row0.X; } set { Row0.X = value; } }
        public float M12 { get { return Row0.Y; } set { Row0.Y = value; } }
        public float M21 { get { return Row1.X; } set { Row1.X = value; } }
        public float M22 { get { return Row1.Y; } set { Row1.Y = value; } }

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

        #region IEquatable<Matrix2> Members

        public bool Equals(Matrix2 other)
        {
            return
                Row0 == other.Row0 &&
                Row1 == other.Row1;
        }

        #endregion
    }
}
