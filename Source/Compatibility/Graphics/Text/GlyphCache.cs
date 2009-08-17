#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    abstract class GlyphCache : IGlyphCache
    {
        #region IGlyphCache Members

        public abstract void Add(Glyph glyph, IGlyphRasterizer rasterizer, TextQuality quality);

        public abstract bool Contains(Glyph glyph);

        public abstract CachedGlyphInfo this[Glyph glyph] { get; }

        public abstract void Clear();

        public abstract void Dispose();

        #endregion
    }

    sealed class GlyphCache<T> : GlyphCache where T : Texture2D
    {
        #region Fields

        List<GlyphSheet<T>> sheets = new List<GlyphSheet<T>>();

        Dictionary<Glyph, CachedGlyphInfo> cached_glyphs = new Dictionary<Glyph, CachedGlyphInfo>();

        bool disposed;

        const int SheetWidth = 512, SheetHeight = 512;

        #endregion

        #region Constructors

        public GlyphCache()
        {
            sheets.Add(new GlyphSheet<T>(SheetWidth, SheetHeight));
        }

        #endregion

        #region IGlyphCache Members

        public override void Add(Glyph glyph, IGlyphRasterizer rasterizer, TextQuality quality)
        {
            if (rasterizer == null)
                throw new ArgumentNullException("rasterizer");

            bool inserted = false;

            using (Bitmap bmp = rasterizer.Rasterize(glyph, quality))
            {
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                foreach (GlyphSheet<T> sheet in sheets)
                {
                     inserted = InsertGlyph(glyph, bmp, rect, sheet);
                     if (inserted)
                         break;
                }

                if (!inserted)
                {
                    GlyphSheet<T> sheet = new GlyphSheet<T>(SheetWidth, SheetHeight);
                    sheets.Add(sheet);
                    InsertGlyph(glyph, bmp, rect, sheet);
                }
            }
        }

        public override bool Contains(Glyph glyph)
        {
            return cached_glyphs.ContainsKey(glyph);
        }

        public override CachedGlyphInfo this[Glyph glyph]
        {
            get
            {
                return cached_glyphs[glyph];
            }
        }
        public override void Clear()
        {
            for (int i = 0; i < sheets.Count; i++)
                sheets[i].Dispose();

            sheets.Clear();
        }

        #endregion

        #region Private Members

        // Asks the packer for an empty space and writes the glyph there.
        bool InsertGlyph(Glyph glyph, Bitmap bmp, Rectangle source, GlyphSheet<T> sheet)
        {
            Rectangle target = new Rectangle();
            if (!sheet.Packer.TryAdd(source, out target))
                return false;

            sheet.Texture.WriteRegion(source, target, 0, bmp);
            cached_glyphs.Add(glyph, new CachedGlyphInfo(sheet.Texture, target));

            return true;
        }

        #endregion

        #region IDisposable Members

        public override void Dispose()
        {
             if (!disposed)
            {
                Clear();
                disposed = true;
             }
        }

        #endregion
    }
}
