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
