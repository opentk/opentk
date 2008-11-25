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
using System.Text;
using System.Drawing;

using OpenTK.Graphics;
using System.Diagnostics;

namespace OpenTK.Graphics.Text
{
    class GlyphCache
    {
        #region Fields

        IGlyphRasterizer rasterizer;
        List<GlyphSheet> sheets = new List<GlyphSheet>();
        Bitmap bmp = new Bitmap(256, 256);

        Dictionary<Glyph, CachedGlyphInfo> cached_glyphs = new Dictionary<Glyph, CachedGlyphInfo>();

        #endregion

        #region Constructors

        public GlyphCache(IGlyphRasterizer rasterizer)
        {
            if (rasterizer == null)
                throw new ArgumentNullException("rasterizer");

            this.rasterizer = rasterizer;
            sheets.Add(new GlyphSheet());
        }

        #endregion

        #region Public Members

        public void Add(char c, Font font)
        {
            Glyph glyph = new Glyph(c, font);
            bool inserted = false;

            using (Bitmap bmp = rasterizer.Rasterize(glyph))
            {
                foreach (GlyphSheet sheet in sheets)
                {
                    try
                    {
                        InsertGlyph(glyph, bmp, sheet);
                        inserted = true;
                        break;
                    }
                    catch (TexturePackerFullException)
                    {
                    }
                }

                if (!inserted)
                {
                    GlyphSheet sheet = new GlyphSheet();
                    sheets.Add(sheet);
                    InsertGlyph(glyph, bmp, sheet);
                }
            }
        }

        void InsertGlyph(Glyph glyph, Bitmap bmp, GlyphSheet sheet)
        {
            Rectangle source = new Rectangle(0, 0, bmp.Width, bmp.Height);
            Rectangle target = sheet.Packer.Add(source);

            sheet.Texture.WriteRegion(source, target, 0, bmp);

            cached_glyphs.Add(glyph, new CachedGlyphInfo(sheet.Texture, target));
        }

        public bool Contains(char c, Font font)
        {
            return cached_glyphs.ContainsKey(new Glyph(c, font));
        }

        public CachedGlyphInfo this[char c, Font font]
        {
            get
            {
                return cached_glyphs[new Glyph(c, font)];
            }
        }

        public CachedGlyphInfo this[Glyph glyph]
        {
            get
            {
                return cached_glyphs[glyph];
            }
        }

        #endregion
    }
}
