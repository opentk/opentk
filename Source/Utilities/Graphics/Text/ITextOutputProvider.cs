using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics.Text
{
    interface ITextOutputProvider
    {
        void Print(TextBlock block, IGlyphRasterizer rasterizer, GlyphCache cache);
    }
}
