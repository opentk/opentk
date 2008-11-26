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
using System.Drawing.Text;

using OpenTK.Graphics.Text;
using OpenTK.Platform;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace OpenTK.Graphics.Text
{
    class GdiPlusGlyphRasterizer : IGlyphRasterizer
    {
        #region Fields

        Dictionary<TextBlock, TextExtents> block_cache = new Dictionary<TextBlock, TextExtents>();
        System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1));

        IntPtr[] regions = new IntPtr[GdiPlus.MaxMeasurableCharacterRanges];
        CharacterRange[] characterRanges = new CharacterRange[GdiPlus.MaxMeasurableCharacterRanges];

        Bitmap glyph_surface;
        System.Drawing.Graphics glyph_renderer;

        readonly ObjectPool<PoolableTextExtents> text_extents_pool = new ObjectPool<PoolableTextExtents>();

        // Check the constructor, too, for additional flags.
        static readonly StringFormat default_string_format = StringFormat.GenericTypographic;
        static readonly StringFormat load_glyph_string_format = StringFormat.GenericDefault;

        static readonly char[] newline_characters = new char[] { '\n', '\r' };

        #endregion

        #region Constructors

        static GdiPlusGlyphRasterizer()
        {
            default_string_format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
        }

        public GdiPlusGlyphRasterizer()
        { }

        #endregion

        #region IGlyphRasterizer Members

        #region Rasterize

        public Bitmap Rasterize(Glyph glyph)
        {
            RectangleF r = MeasureText(new TextBlock(glyph.Character.ToString(), glyph.Font, TextPrinterOptions.NoCache, RectangleF.Empty)).BoundingBox;

            EnsureSurfaceSize(ref glyph_surface, ref glyph_renderer, glyph.Font);

            SetTextRenderingOptions(glyph_renderer, glyph.Font);

            glyph_renderer.Clear(Color.Transparent);
            glyph_renderer.DrawString(glyph.Character.ToString(), glyph.Font, Brushes.White, PointF.Empty,
                glyph.Font.Style == FontStyle.Italic ? load_glyph_string_format : default_string_format);

            RectangleF r2 = FindEdges(glyph_surface);

            return glyph_surface.Clone(r2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        public void Rasterize(Glyph glyph, ref Bitmap bmp, out Rectangle rect)
        {
            EnsureSurfaceSize(ref bmp, ref glyph_renderer, glyph.Font);

            using (System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(bmp))
            {
                SetTextRenderingOptions(gfx, glyph.Font);

                gfx.Clear(Color.Transparent);
                gfx.DrawString(glyph.Character.ToString(), glyph.Font, Brushes.White, PointF.Empty,
                    glyph.Font.Style == FontStyle.Italic ? load_glyph_string_format : default_string_format);
                rect = FindEdges(bmp);
            }
        }

        #endregion

        #region MeasureText

        public TextExtents MeasureText(TextBlock block)
        {
            // First, check if we have cached this text block. Do not use block_cache.TryGetValue, to avoid thrashing
            // the user's TextBlockExtents struct.
            if (block_cache.ContainsKey(block))
                return block_cache[block];

            // If this block is not cached, we have to measure it and (potentially) place it in the cache.
            TextExtents extents = MeasureTextExtents(block);
            if ((block.Options & TextPrinterOptions.NoCache) == 0)
                block_cache.Add(block, extents);

            return extents;
        }

        #endregion

        #endregion

        #region Private Members

        #region EnsureSurfaceSize

        void EnsureSurfaceSize(ref Bitmap bmp, ref System.Drawing.Graphics gfx, Font font)
        {
            if (bmp == null || bmp.Width < 2 * font.Size || bmp.Height < 2 * font.Size)
            {
                if (bmp != null)
                    bmp.Dispose();
                if (gfx != null)
                    gfx.Dispose();

                bmp = new Bitmap((int)(2 * font.Size), (int)(2 * font.Size));
                gfx = System.Drawing.Graphics.FromImage(bmp);
            }
        }

        #endregion

        #region SetRenderingOptions

        // Modify rendering settings (antialiasing, grid fitting) to improve appearance.
        void SetTextRenderingOptions(System.Drawing.Graphics gfx, Font font)
        {
            // Small sizes look blurry without gridfitting, so turn that on. 
            if (font.Size <= 18.0f)
                gfx.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            else
                gfx.TextRenderingHint = TextRenderingHint.AntiAlias;
        }

        #endregion

        #region MeasureTextExtents

        TextExtents MeasureTextExtents(TextBlock block)
        {
            // Todo: Parse layout options:
            StringFormat format = default_string_format;
            //if (block.Font.Style != FontStyle.Regular)
            //    format = load_glyph_string_format;
            //else
            //    format = default_string_format;

            TextExtents extents = text_extents_pool.Acquire();

            PointF origin = PointF.Empty;
            SizeF size = SizeF.Empty;

            SetTextRenderingOptions(graphics, block.Font);

            IntPtr native_graphics = GdiPlus.GetNativeGraphics(graphics);
            IntPtr native_font = GdiPlus.GetNativeFont(block.Font);
            IntPtr native_string_format = GdiPlus.GetNativeStringFormat(format);

            int height = 0;

            // It seems that the mere presence of \n and \r characters
            // is enough for Mono to botch the layout (even if these
            // characters are not processed.) We'll need to find a
            // different way to perform layout on Mono, probably
            // through Pango.
            // Todo: This workaround  allocates memory.
            //if (Configuration.RunningOnMono)
            {
                string[] lines = block.Text.Replace("\r", String.Empty).Split('\n');
                foreach (string s in lines)
                {
                    extents.AddRange(MeasureGlyphExtents(
                        s, height, 0, s.Length,
                        block.LayoutRectangle,
                        native_graphics, native_font, native_string_format));
                    height += block.Font.Height;
                }
            }

            extents.BoundingBox = new RectangleF(extents[0].X, extents[0].Y, extents[extents.Count - 1].Right, extents[extents.Count - 1].Bottom);

            return extents;
        }

        #endregion

        #region MeasureGlyphExtents

        // Gets the bounds of each character in a line of text.
        // The line is processed in blocks of 32 characters (GdiPlus.MaxMeasurableCharacterRanges).
        IEnumerable<RectangleF> MeasureGlyphExtents(string text, int height, int line_start, int line_length,
            RectangleF layoutRect, IntPtr native_graphics, IntPtr native_font, IntPtr native_string_format)
        {
            RectangleF rect = new RectangleF();
            int line_end = line_start + line_length;
            while (line_start < line_end)
            {
                //if (text[line_start] == '\n' || text[line_start] == '\r')
                //{
                //    line_start++;
                //    continue;
                //}

                int num_characters = (line_end - line_start) > GdiPlus.MaxMeasurableCharacterRanges ?
                    GdiPlus.MaxMeasurableCharacterRanges :
                    line_end - line_start;
                int status = 0;

                for (int i = 0; i < num_characters; i++)
                {
                    characterRanges[i] = new CharacterRange(line_start + i, 1);

                    IntPtr region;
                    status = GdiPlus.CreateRegion(out region);
                    regions[i] = region;
                    Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));
                }

                status = GdiPlus.SetStringFormatMeasurableCharacterRanges(native_string_format, num_characters, characterRanges);
                Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));

                status = GdiPlus.MeasureCharacterRanges(native_graphics, text, text.Length,
                                                native_font, ref layoutRect, native_string_format, num_characters, regions);
                Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));

                for (int i = 0; i < num_characters; i++)
                {
                    GdiPlus.GetRegionBounds(regions[i], native_graphics, ref rect);
                    Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));
                    GdiPlus.DeleteRegion(regions[i]);
                    Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));

                    rect.Y += height;
                    
                    yield return rect;
                }

                line_start += num_characters;
            }
        }

        #endregion

        #region FindEdges

        #pragma warning disable 0649

        struct Pixel { public byte B, G, R, A; }

        #pragma warning restore 0649

        Rectangle FindEdges(Bitmap bmp)
        {
            BitmapData data = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            
            Rectangle rect = Rectangle.FromLTRB(
                FindLeftEdge(bmp, data.Scan0),
                FindTopEdge(bmp, data.Scan0),
                FindRightEdge(bmp, data.Scan0),
                FindBottomEdge(bmp, data.Scan0));

            bmp.UnlockBits(data);

            return rect;
        }

        #endregion

        #region Find[Left|Right|Top|Bottom]Edge

        // Iterates through the bmp, and returns the first row or line that contains a non-transparent pixels.

        int FindLeftEdge(Bitmap bmp, IntPtr ptr)
        {
            // Don't trim the left edge, because the layout engine expects it to be 0.
            return 0;
        }

        int FindRightEdge(Bitmap bmp, IntPtr ptr)
        {
            for (int x = bmp.Width - 1; x >= 0; x--)
                for (int y = 0; y < bmp.Height; y++)
                    unsafe
                    {
                        if (((Pixel*)(ptr) + y * bmp.Width + x)->A != 0)
                            return x + 1;
                    }

            return 0;
        }

        int FindTopEdge(Bitmap bmp, IntPtr ptr)
        {
            // Don't trim the top edge, because the layout engine expects it to be 0.
            return 0;
        }

        int FindBottomEdge(Bitmap bmp, IntPtr ptr)
        {
            for (int y = bmp.Height - 1; y >= 0; y--)
                for (int x = 0; x < bmp.Width; x++)
                    unsafe
                    {
                        if (((Pixel*)(ptr) + y * bmp.Width + x)->A != 0)
                            return y + 1;
                    }

            return 0;
        }

        #endregion

        #endregion
    }
}
