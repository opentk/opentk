// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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
        Bitmap Rasterize(Glyph glyph, TextQuality quality);
        TextExtents MeasureText(ref TextBlock block);
        TextExtents MeasureText(ref TextBlock block, TextQuality quality);
        void Clear();
    }
}
