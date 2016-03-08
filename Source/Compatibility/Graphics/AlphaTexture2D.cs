// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Encapsulates an OpenGL texture.
    /// </summary>
    [Obsolete]
    class AlphaTexture2D : Texture2D
    {
        #region Constructors

        /// <summary>
        /// Constructs a new Texture.
        /// </summary>
        public AlphaTexture2D(int width, int height)
            : base(width, height)
        { }

        #endregion

        #region Protected Members

        protected override PixelInternalFormat InternalFormat
        {
            get { return PixelInternalFormat.Alpha; }
        }

        #endregion
    }
}
