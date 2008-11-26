using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics
{
    class RgbaTexture2D : Texture2D
    {
        public RgbaTexture2D(int width, int height)
            : base(width, height)
        { }

        protected override PixelInternalFormat InternalFormat
        {
            get { return PixelInternalFormat.CompressedRgba; }
        }
    }
}
