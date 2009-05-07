using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    sealed class GL11TextOutputProvider : GL1TextOutputProvider
    {
        #region Fields

        TextQuality quality;
        GlyphCache cache;

        #endregion

        #region Constuctors

        public GL11TextOutputProvider(TextQuality quality)
        {
            if (quality == TextQuality.High || quality == TextQuality.Default)
                this.quality = TextQuality.Medium;
            else
                this.quality = quality;
        }

        #endregion

        #region Protected Members

        protected override void SetBlendFunction()
        {
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);  // For grayscale
        }

        protected override void SetColor(Color color)
        {
            GL.Color3(color);
        }

        protected override TextQuality TextQuality
        {
            get { return quality; }
        }

        protected override GlyphCache Cache
        {
            get
            {
                if (cache == null)
                {
                    if (GL.GetString(StringName.Renderer).Contains("ProSavage/Twister"))
                        cache = new GlyphCache<RgbaTexture2D>();
                    else
                        cache = new GlyphCache<AlphaTexture2D>();
                }
                return cache;
            }
        }

        #endregion
    }
}
