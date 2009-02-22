#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics
{
    abstract class TextureRegion2D
    {
        Rectangle rectangle;

        public Rectangle Rectangle { get { return rectangle; } protected set { rectangle = value; } }
    }

    /// <summary>
    /// Holds part or the whole of a 2d OpenGL texture.
    /// </summary>
    class TextureRegion2D<T> : TextureRegion2D where T : struct
    {
        #region Fields

        T[,] data;

        #endregion

        #region Constructors

        internal TextureRegion2D(Rectangle rect)
        {
            data = new T[rect.Width, rect.Height];
            Rectangle = rect;
        }

        #endregion

        #region Public Members

        public T this[int x, int y]
        {
            get { return data[x, y]; }
            set { data[x, y] = value; }
        }

        #endregion

        #region Internal Members

        internal T[,] Data { get { return data; } }

        #endregion
    }
}
