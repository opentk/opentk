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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using OpenTK.Platform;

namespace OpenTK.Graphics.Text
{
    sealed class GdiPlusGlyphRasterizer : IGlyphRasterizer
    {
        #region Fields

        Dictionary<TextBlock, TextExtents> block_cache = new Dictionary<TextBlock, TextExtents>();
        System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1));

        IntPtr[] regions = new IntPtr[GdiPlus.MaxMeasurableCharacterRanges];
        CharacterRange[] characterRanges = new CharacterRange[GdiPlus.MaxMeasurableCharacterRanges];

        Bitmap glyph_surface;
        System.Drawing.Graphics glyph_renderer;

        readonly List<RectangleF> measured_glyphs = new List<RectangleF>(256);

        readonly ObjectPool<PoolableTextExtents> text_extents_pool = new ObjectPool<PoolableTextExtents>();

        // Check the constructor, too, for additional flags.
        // Used for measuring text. Can set the leftToRight, rightToLeft, vertical and measure trailing spaces flags.
        readonly StringFormat measure_string_format = new StringFormat(StringFormat.GenericDefault);
        readonly StringFormat measure_string_format_tight = new StringFormat(StringFormat.GenericTypographic);
        // Used for loading glyphs. Only use leftToRight!
        readonly StringFormat load_glyph_string_format = new StringFormat(StringFormat.GenericDefault);
        readonly StringFormat load_glyph_string_format_tight = new StringFormat(StringFormat.GenericTypographic);

        static readonly char[] newline_characters = new char[] { '\n', '\r' };

        static readonly SizeF MaximumGraphicsClipSize;

        #endregion

        #region Constructors

        static GdiPlusGlyphRasterizer()
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            using (System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(bmp))
            {
                MaximumGraphicsClipSize = gfx.ClipBounds.Size;
            }
        }

        public GdiPlusGlyphRasterizer()
        {
            measure_string_format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces | StringFormatFlags.NoClip;
            measure_string_format_tight.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
        }

        #endregion

        #region IGlyphRasterizer Members

        #region Rasterize

        public Bitmap Rasterize(Glyph glyph)
        {
            return Rasterize(glyph, TextQuality.Default);
        }

        public Bitmap Rasterize(Glyph glyph, TextQuality quality)
        {
            EnsureSurfaceSize(ref glyph_surface, ref glyph_renderer, glyph.Font);
            SetTextRenderingOptions(glyph_renderer, glyph.Font, quality);

            RectangleF r2 = new RectangleF();

            glyph_renderer.Clear(Color.Transparent);

            glyph_renderer.DrawString(glyph.Character.ToString(), glyph.Font, Brushes.White, Point.Empty, //new Point(glyph_surface.Width, 0),
                glyph.Font.Style == FontStyle.Italic ? load_glyph_string_format : load_glyph_string_format_tight);

            r2 = FindEdges(glyph_surface, true);
                
            //if ((default_string_format.FormatFlags & StringFormatFlags.DirectionRightToLeft) != 0)
            //{
            //    glyph_renderer.DrawString(glyph.Character.ToString(), glyph.Font, Brushes.White, Point.Empty, //new Point(glyph_surface.Width, 0),
            //        load_glyph_string_format);//glyph.Font.Style == FontStyle.Italic ? load_glyph_string_format : default_string_format);

            //    r2 = FindEdges(glyph_surface, true);
            //}
            //else
            //{
            //    glyph_renderer.DrawString(glyph.Character.ToString(), glyph.Font, Brushes.White, Point.Empty,
            //        load_glyph_string_format_tight); //glyph.Font.Style == FontStyle.Italic ? load_glyph_string_format : default_string_format);

            //    r2 = FindEdges(glyph_surface, false);
            //}

            return glyph_surface.Clone(r2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        #endregion

        #region MeasureText

        public TextExtents MeasureText(TextBlock block)
        {
            return MeasureText(block, TextQuality.Default);
        }

        public TextExtents MeasureText(TextBlock block, TextQuality quality)
        {
            // First, check if we have cached this text block. Do not use block_cache.TryGetValue, to avoid thrashing
            // the user's TextBlockExtents struct.
            if (block_cache.ContainsKey(block))
                return block_cache[block];

            // If this block is not cached, we have to measure it and (potentially) place it in the cache.
            TextExtents extents = MeasureTextExtents(block, quality);
            
            if ((block.Options & TextPrinterOptions.NoCache) == 0)
                block_cache.Add(block, extents);

            return extents;
        }

        #endregion

        #region Clear

        public void Clear()
        {
            block_cache.Clear();
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
        void SetTextRenderingOptions(System.Drawing.Graphics gfx, Font font, TextQuality quality)
        {
            switch (quality)
            {
                case TextQuality.Default:
                    gfx.TextRenderingHint = TextRenderingHint.SystemDefault;
                    break;

                case TextQuality.High:
                    gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                    break;
                    
                case TextQuality.Medium:
                    if (font.Size <= 18.0f)
                        gfx.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    else
                        gfx.TextRenderingHint = TextRenderingHint.AntiAlias;
                    break;

                case TextQuality.Low:
                    if (font.Size <= 18.0f)
                        gfx.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
                    else
                        gfx.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
                    break;
            }
        }

        #endregion

        #region MeasureTextExtents

        TextExtents MeasureTextExtents(TextBlock block, TextQuality quality)
        {
            // Todo: Parse layout options:
            StringFormat format = block.Font.Italic ? measure_string_format : measure_string_format_tight;
            //StringFormat format = measure_string_format_tight;

            if (block.Direction == TextDirection.Vertical)
                format.FormatFlags |= StringFormatFlags.DirectionVertical;
            else
                format.FormatFlags &= ~StringFormatFlags.DirectionVertical;

            if (block.Direction == TextDirection.RightToLeft)
                format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            else
                format.FormatFlags &= ~StringFormatFlags.DirectionRightToLeft;

            if (block.Alignment == TextAlignment.Near)
                format.Alignment = StringAlignment.Near;
            else if (block.Alignment == TextAlignment.Center)
                format.Alignment = StringAlignment.Center;
            else
                format.Alignment = StringAlignment.Far;

            TextExtents extents = text_extents_pool.Acquire();

            RectangleF rect = block.Bounds;
            // Work around Mono/GDI+ bug, which causes incorrect
            // text wraping when block.Bounds == SizeF.Empty.
            if (block.Bounds.Size == SizeF.Empty)
                rect.Size = MaximumGraphicsClipSize;

            SetTextRenderingOptions(graphics, block.Font, quality);

            IntPtr native_graphics = GdiPlus.GetNativeGraphics(graphics);
            IntPtr native_font = GdiPlus.GetNativeFont(block.Font);
            IntPtr native_string_format = GdiPlus.GetNativeStringFormat(format);

            float max_width = 0, max_height = 0;

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
                    float width, height;

                    extents.AddRange(MeasureGlyphExtents(
                        ref block, s,
                        native_graphics, native_font, native_string_format,
                        ref rect, out width, out height));

                    if ((block.Direction & TextDirection.Vertical) == 0)
                        rect.Y += block.Font.Height;
                    else
                        rect.X += block.Font.Height;

                    if (width > max_width)
                        max_width = width;
                    if (height > max_height)
                        max_height = height;
                }
            }

            extents.BoundingBox = new RectangleF(extents[0].X, extents[0].Y, max_width, max_height);

            return extents;
        }

        #endregion

        #region MeasureGlyphExtents

        // Gets the bounds of each character in a line of text.
        // Each line is processed in blocks of 32 characters (GdiPlus.MaxMeasurableCharacterRanges).
        IEnumerable<RectangleF> MeasureGlyphExtents(
            ref TextBlock block, string text,
            IntPtr native_graphics, IntPtr native_font, IntPtr native_string_format,
            ref RectangleF layoutRect, out float max_width, out float max_height)
        {
            measured_glyphs.Clear();
            max_width = layoutRect.Left;
            max_height = layoutRect.Top;
            float last_line_width = 0, last_line_height = 0;

             int current = 0;
             while (current < text.Length)
             {
                 int num_characters = (text.Length - current) > GdiPlus.MaxMeasurableCharacterRanges ?
                     GdiPlus.MaxMeasurableCharacterRanges :
                     text.Length - current;
                 int status = 0;

                 // Prepare the character ranges and region structs for the measurement.
                 for (int i = 0; i < num_characters; i++)
                 {
                     if (text[current + i] == '\n' || text[current + i] == '\r')
                         throw new NotSupportedException();

                     characterRanges[i] = new CharacterRange(current + i, 1);

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

                 // Read back the results of the measurement.
                 for (int i = 0; i < num_characters; i++)
                 {
                     RectangleF rect = new RectangleF();

                     GdiPlus.GetRegionBounds(regions[i], native_graphics, ref rect);
                     Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));
                     GdiPlus.DeleteRegion(regions[i]);
                     Debug.Assert(status == 0, String.Format("GDI+ error: {0}", status));

                     if (rect.Bottom > max_height)
                         max_height = rect.Bottom;
                     if (rect.Right > max_width)
                         max_width = rect.Right;

                     if (rect.X > last_line_width)
                         last_line_width = rect.X;
                     if (rect.Y > last_line_height)
                         last_line_height = rect.Y;
                     
                     measured_glyphs.Add(rect);
                 }

                 current += num_characters;
             }

             // Make sure the current height is updated, if the the current line has wrapped due to word-wraping.
             // Otherwise, the next line will overlap with the current one.
             if (measured_glyphs.Count > 1)
             {
                 if ((block.Direction & TextDirection.Vertical) == 0)
                 {
                     if (layoutRect.Y < last_line_height)
                         layoutRect.Y = last_line_height;
                 }
                 else
                 {
                     if (layoutRect.X < last_line_width)
                         layoutRect.X = last_line_width;
                 }
             }

            return measured_glyphs;
        }

        #endregion

        #region FindEdges

        #pragma warning disable 0649

        struct Pixel { public byte B, G, R, A; }

        #pragma warning restore 0649

        // Note: The bool parameter is not used at this point.
        // We might need it if we ever load true rightToLeft glyphs.
        Rectangle FindEdges(Bitmap bmp, bool rightToLeft)
        {
            BitmapData data = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            //Rectangle rect = rightToLeft ?
            //    Rectangle.FromLTRB(FindLeftEdge(bmp, data.Scan0), 0, bmp.Width - 1, FindBottomEdge(bmp, data.Scan0)) :
            //    Rectangle.FromLTRB(0, 0, FindRightEdge(bmp, data.Scan0), FindBottomEdge(bmp, data.Scan0));

            Rectangle rect =
                Rectangle.FromLTRB(0, 0, FindRightEdge(bmp, data.Scan0), FindBottomEdge(bmp, data.Scan0));
               //Rectangle.FromLTRB(FindLeftEdge(bmp, data.Scan0), 0, FindRightEdge(bmp, data.Scan0), FindBottomEdge(bmp, data.Scan0));

            bmp.UnlockBits(data);

            return rect;
        }

        #endregion

        #region Find[Left|Right|Top|Bottom]Edge

        // Iterates through the bmp, and returns the first row or line that contains a non-transparent pixels.

        int FindLeftEdge(Bitmap bmp, IntPtr ptr)
        {
            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                    unsafe
                    {
                        if (((Pixel*)(ptr) + y * bmp.Width + x)->A != 0)
                            return x;
                    }

            return bmp.Width - 1;
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
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    unsafe
                    {
                        if (((Pixel*)(ptr) + y * bmp.Width + x)->A != 0)
                            return y;
                    }

            return bmp.Height - 1;
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
