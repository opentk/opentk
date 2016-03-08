// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics.OpenGL;

namespace OpenTK.Graphics
{
    [Obsolete]
    class RgbaTexture2D : Texture2D
    {
        public RgbaTexture2D(int width, int height)
            : base(width, height)
        { }

        protected override PixelInternalFormat InternalFormat
        {
            get { return PixelInternalFormat.Rgba; }
        }
    }
}
