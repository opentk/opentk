// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTK.Graphics.OpenGL;

namespace OpenTK.Graphics.Text
{
    [Obsolete]
    sealed class GL12TextOutputProvider : GL1TextOutputProvider
    {
        #region Fields

        TextQuality quality;
        GlyphCache cache;

        #endregion

        #region Constuctors

        public GL12TextOutputProvider(TextQuality quality)
        {
            this.quality = quality;
            
            cache = new GlyphCache<RgbaTexture2D>();
        }

        #endregion

        protected override void SetBlendFunction()
        {
            GL.BlendFunc(BlendingFactorSrc.ConstantColorExt, BlendingFactorDest.OneMinusSrcColor);
        }

        protected override void SetColor(Color color)
        {
            GL.Color3(Color.White);
            GL.BlendColor(color);
        }

        protected override TextQuality TextQuality
        {
            get { return quality; }
        }

        protected override GlyphCache Cache
        {
            get { return cache; }
        }
    }
}
