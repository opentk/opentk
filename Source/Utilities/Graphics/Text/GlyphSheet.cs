using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    class GlyphSheet
    {
        #region Fields

        AlphaTexture2D texture;
        GlyphPacker packer;

        #endregion

        #region Constructors

        public GlyphSheet()
        {
            Texture = new AlphaTexture2D(256, 256);
            Packer = new GlyphPacker(256, 256);
        }

        #endregion

        #region Public Members

        public AlphaTexture2D Texture
        {
            get { return texture; }
            private set { texture = value; }
        }

        public GlyphPacker Packer
        {
            get { return packer; }
            private set { packer = value; }
        }

        #endregion
    }
}
