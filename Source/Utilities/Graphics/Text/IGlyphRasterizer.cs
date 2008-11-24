using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTK.Graphics.Text;

namespace OpenTK.Graphics.Text
{
    interface IGlyphRasterizer
    {
        Bitmap Rasterize(Glyph glyph);
        //void Rasterize(Glyph glyph, ref Bitmap bmp);
        TextExtents MeasureText(TextBlock block);
        RectangleF MeasureGlyph(Glyph glyph);
    }
}
