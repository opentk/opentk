// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;

namespace OpenTK.Graphics.Text
{
    [Obsolete]
    interface IGlyphCache : IDisposable
    {
        void Add(Glyph glyph, IGlyphRasterizer rasterizer, TextQuality quality);
        bool Contains(Glyph glyph);
        CachedGlyphInfo this[Glyph glyph] { get; }
        void Clear();
    }
}
