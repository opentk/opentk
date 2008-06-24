#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Math;
using OpenTK.Graphics;
using OpenTK.Platform;

namespace OpenTK.Graphics
{
    using Graphics = System.Drawing.Graphics;
    using PixelFormat = OpenTK.Graphics.PixelFormat;

    public class TextureFont : IFont
    {
        Font font;
        Dictionary<char, RectangleF> loaded_glyphs = new Dictionary<char, RectangleF>(64);

        Bitmap bmp;
        Graphics gfx;
        // TODO: We need to be able to use multiple font sheets.
        static int texture;
        static TexturePacker<Glyph> pack;
        static int texture_width, texture_height;
        static StringFormat default_string_format = StringFormat.GenericTypographic;
        static SizeF maximum_graphics_size;

        int[] data = new int[256];  // Used to upload the glyph buffer to the OpenGL texture.

        object upload_lock = new object();

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new TextureFont, using the specified System.Drawing.Font.
        /// </summary>
        /// <param name="font">The System.Drawing.Font to use.</param>
        public TextureFont(Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font", "Argument to TextureFont constructor cannot be null.");

            this.font = font;

            bmp = new Bitmap(font.Height * 2, font.Height * 2);
            gfx = Graphics.FromImage(bmp);
            maximum_graphics_size = gfx.ClipBounds.Size;

            // Adjust font rendering mode. Small sizes look blurry without gridfitting, so turn
            // that on. Increasing contrast also seems to help.
            if (font.Size <= 18.0f)
            {
                gfx.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                gfx.TextContrast = 1;
            }
            else
            {
                gfx.TextRenderingHint = TextRenderingHint.AntiAlias;
                gfx.TextContrast = 0;
            }
        }

        /// <summary>
        /// Constructs a new TextureFont, using the specified parameters.
        /// </summary>
        /// <param name="font">The System.Drawing.FontFamily to use for the typeface.</param>
        /// <param name="emSize">The em size to use for the typeface.</param>
        public TextureFont(FontFamily family, float emSize)
            : this(new Font(family, emSize))
        { }

        /// <summary>
        /// Constructs a new TextureFont, using the specified parameters.
        /// </summary>
        /// <param name="font">The System.Drawing.FontFamily to use for the typeface.</param>
        /// <param name="emSize">The em size to use for the typeface.</param>
        /// <param name="family">The style to use for the typeface.</param>
        public TextureFont(FontFamily family, float emSize, FontStyle style)
            : this(new Font(family, emSize, style))
        { }

        #endregion

        #region --- Public Methods ---

        #region public void LoadGlyphs(string glyphs)

        /// <summary>
        /// Prepares the specified glyphs for rendering.
        /// </summary>
        /// <param name="glyphs">The glyphs to prepare for rendering.</param>
        public void LoadGlyphs(string glyphs)
        {
            RectangleF rect = new RectangleF();
            foreach (char c in glyphs)
            {
                try
                {
                    if (!loaded_glyphs.ContainsKey(c))
                        LoadGlyph(c, out rect);
                }
                catch (Exception e)
                {
                    Debug.Print(e.ToString());
                    throw;
                }
            }
        }

        #endregion

        #region public void LoadGlyph(char glyph)

        /// <summary>
        /// Prepares the specified glyph for rendering.
        /// </summary>
        /// <param name="glyphs">The glyph to prepare for rendering.</param>
        public void LoadGlyph(char glyph)
        {
            RectangleF rect = new RectangleF();
            if (!loaded_glyphs.ContainsKey(glyph))
                LoadGlyph(glyph, out rect);
        }

        #endregion

        #region public bool GlyphData(char glyph, out float width, out float height, out RectangleF textureRectangle, out int texture)

        /// <summary>
        /// Returns the characteristics of a loaded glyph.
        /// </summary>
        /// <param name="glyph">The character corresponding to this glyph.</param>
        /// <param name="width">The width of this glyph.</param>
        /// <param name="height">The height of this glyph (line spacing).</param>
        /// <param name="textureRectangle">The bounding box of the texture buffer of this glyph.</param>
        /// <param name="texture">The handle to the texture that contains this glyph.</param>
        /// <returns>True if the glyph has been loaded, false otherwise.</returns>
        /// <seealso cref="LoadGlyphs"/>
        public bool GlyphData(char glyph, out float width, out float height, out RectangleF textureRectangle, out int texture)
        {
            if (loaded_glyphs.TryGetValue(glyph, out textureRectangle))
            {
                width = textureRectangle.Width * texture_width;
                height = textureRectangle.Height * texture_height;
                texture = TextureFont.texture;
                return true;
            }
            width = height = texture = 0;
            return false;
        }

        #endregion

        #region public float Height

        /// <summary>
        /// Gets a float indicating the default line spacing of this font.
        /// </summary>
        public float Height
        {
            get { return font.Height; }
        }

        #endregion

        #region public float Width

        /// <summary>
        /// Gets a float indicating the default line spacing of this font.
        /// </summary>
        public float Width
        {
            get { return font.SizeInPoints; }
        }

        #endregion

        #region public void MeasureString(string str, out float width, out float height, bool accountForOverhangs)

        /// <summary>
        /// Measures the width of the specified string.
        /// </summary>
        /// <param name="str">The string to measure.</param>
        /// <param name="width">The measured width.</param>
        /// <param name="height">The measured height.</param>
        /// <param name="accountForOverhangs">If true, adds space to account for glyph overhangs. Set to true if you wish to measure a complete string. Set to false if you wish to perform layout on adjacent strings.</param>
        [Obsolete("Returns invalid results - use MeasureText() instead")]
        public void MeasureString(string str, out float width, out float height, bool accountForOverhangs)
        {
            System.Drawing.StringFormat format = accountForOverhangs ? System.Drawing.StringFormat.GenericDefault : System.Drawing.StringFormat.GenericTypographic;
            //format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;

            System.Drawing.SizeF size = gfx.MeasureString(str, font, 16384, format);
            height = size.Height;
            width = size.Width;

            //width = height = 0;

            //RectangleF rect = new RectangleF(0, 0, 0, 0);
            //ICollection<RectangleF> ranges = new List<RectangleF>();
            //MeasureCharacterRanges(gfx, str, font, ref rect, format, ref ranges);
            //foreach (RectangleF range in ranges)
            //{
            //    width += range.Width;
            //    height = range.Height > height ?range.Height : height;
            //}

            //    width = 0;
            //    height = 0;
            //    int i = 0;
            //    foreach (char c in str)
            //    {
            //        if (c != '\n' && c != '\r')
            //        {
            //            SizeF size = gfx.MeasureString(str.Substring(i, 1), font, 16384, System.Drawing.StringFormat.GenericTypographic);
            //            width += size.Width == 0 ? font.SizeInPoints * 0.5f : size.Width;
            //            if (height < size.Height)
            //                height = size.Height;
            //        }
            //        ++i;
            //    }
        }

        #endregion

        #region public void MeasureString(string str, out float width, out float height)

        /// <summary>
        /// Measures the width of the specified string.
        /// </summary>
        /// <param name="str">The string to measure.</param>
        /// <param name="width">The measured width.</param>
        /// <param name="height">The measured height.</param>
        /// <seealso cref="public void MeasureString(string str, out float width, out float height, bool accountForOverhangs)"/>
        [Obsolete("Returns invalid results - use MeasureText() instead")]
        public void MeasureString(string str, out float width, out float height)
        {
            MeasureString(str, out width, out height, true);
        }

        #endregion

        #region public RectangleF MeasureText(string text)

        /// <summary>
        /// Calculates size information for the specified text.
        /// </summary>
        /// <param name="text">The string to measure.</param>
        /// <returns>A RectangleF containing the bounding box for the specified text.</returns>
        public RectangleF MeasureText(string text)
        {
            return MeasureText(text, SizeF.Empty, default_string_format, null);
        }

        #endregion

        #region public RectangleF MeasureText(string text, SizeF bounds)

        /// <summary>
        /// Calculates size information for the specified text.
        /// </summary>
        /// <param name="text">The string to measure.</param>
        /// <param name="bounds">A SizeF structure containing the maximum desired width and height of the text. Default is SizeF.Empty.</param>
        /// <returns>A RectangleF containing the bounding box for the specified text.</returns>
        public RectangleF MeasureText(string text, SizeF bounds)
        {
            return MeasureText(text, bounds, default_string_format, null);
        }

        #endregion

        #region public RectangleF MeasureText(string text, SizeF bounds, StringFormat format)

        /// <summary>
        /// Calculates size information for the specified text.
        /// </summary>
        /// <param name="text">The string to measure.</param>
        /// <param name="bounds">A SizeF structure containing the maximum desired width and height of the text. Pass SizeF.Empty to disable wrapping calculations. A width or height of 0 disables the relevant calculation.</param>
        /// <param name="format">A StringFormat object which specifies the measurement format of the string. Pass null to use the default StringFormat (StringFormat.GenericTypographic).</param>
        /// <returns>A RectangleF containing the bounding box for the specified text.</returns>
        public RectangleF MeasureText(string text, SizeF bounds, StringFormat format)
        {
            return MeasureText(text, bounds, format, null);
        }

        #endregion

        #region public RectangleF MeasureText(string text, SizeF bounds, StringFormat format, IList<RectangleF> ranges)

        /// <summary>
        /// Calculates size information for the specified text.
        /// </summary>
        /// <param name="text">The string to measure.</param>
        /// <param name="bounds">A SizeF structure containing the maximum desired width and height of the text. Pass SizeF.Empty to disable wrapping calculations. A width or height of 0 disables the relevant calculation.</param>
        /// <param name="format">A StringFormat object which specifies the measurement format of the string. Pass null to use the default StringFormat (StringFormat.GenericTypographic).</param>
        /// <param name="ranges">Fills the specified IList of RectangleF structures with position information for individual characters. If this argument is null, these calculations are skipped.</param>
        /// <returns>A RectangleF containing the bounding box for the specified text.</returns>
        public RectangleF MeasureText(string text, SizeF bounds, StringFormat format, IList<RectangleF> ranges)
        {
            int status = 0;

            RectangleF bounding_box = new RectangleF();

            if (String.IsNullOrEmpty(text))
                return RectangleF.Empty;

            if (bounds == SizeF.Empty)
                bounds = maximum_graphics_size;

            if (format == null)
                format = default_string_format;

            IntPtr[] regions = new IntPtr[GdiPlus.MaxMeasurableCharacterRanges];
            CharacterRange[] characterRanges = new CharacterRange[GdiPlus.MaxMeasurableCharacterRanges];

            for (int i = 0; i < text.Length; i += GdiPlus.MaxMeasurableCharacterRanges)
            {
                int num_characters = text.Length - i > GdiPlus.MaxMeasurableCharacterRanges ? GdiPlus.MaxMeasurableCharacterRanges : text.Length - i;

                for (int j = 0; j < num_characters; j++)
                {
                    characterRanges[j] = new CharacterRange(i + j, 1);

                    IntPtr region;
                    status = GdiPlus.CreateRegion(out region);
                    regions[j] = region;
                    if (status != 0)
                        Debug.Print("GDI+ error: {0}", status);
                }

                CharacterRange[] a = (CharacterRange[])characterRanges.Clone();
                Array.Resize(ref a, num_characters);
                format.SetMeasurableCharacterRanges(a);

                IntPtr native_graphics = GdiPlus.GetNativeGraphics(gfx);
                IntPtr native_font = GdiPlus.GetNativeFont(font);
                IntPtr native_string_format = GdiPlus.GetNativeStringFormat(format);
                RectangleF layoutRect = new RectangleF(PointF.Empty, bounds);

                status = GdiPlus.MeasureCharacterRanges(new HandleRef(gfx, native_graphics), text, text.Length,
                                                new HandleRef(font, native_font), ref layoutRect,
                                                new HandleRef(format, (format == null) ? IntPtr.Zero : native_string_format),
                                                num_characters, regions);

                for (int j = 0; j < num_characters; j++)
                {
                    status = GdiPlus.GetRegionBounds(regions[j], new HandleRef(gfx, GdiPlus.GetNativeGraphics(gfx)), ref bounding_box);

                    if (ranges != null)
                        ranges.Add(bounding_box);

                    status = GdiPlus.DeleteRegion(regions[j]);
                }

                bounding_box.Size = new SizeF(bounding_box.X + bounding_box.Width, bounding_box.Y + bounding_box.Height);
                bounding_box.Location = PointF.Empty;
            }
           
            return bounding_box;
        }

        #endregion

        #region private void PrepareTexturePacker()

        /// <summary>
        /// Calculates the optimal size for the font texture and TexturePacker, and creates both.
        /// </summary>
        private void PrepareTexturePacker()
        {
            // Calculate the size of the texture packer. We want a power-of-two size
            // that is less than 1024 (supported in Geforce256-era cards), but large
            // enough to hold at least 256 (16*16) font glyphs.
            // TODO: Find the actual card limits, maybe?
            int size = (int)(font.Size * 16);
            size = (int)System.Math.Pow(2.0, System.Math.Ceiling(System.Math.Log((double)size, 2.0)));
            if (size > 1024)
                size = 1024;

            texture_width = size;
            texture_height = size;
            pack = new TexturePacker<Glyph>(texture_width, texture_height);

            GL.GenTextures(1, out texture);
            GL.BindTexture(TextureTarget.Texture2D, texture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Linear);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Alpha, texture_width, texture_height, 0,
                OpenTK.Graphics.PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
        }

        #endregion

        #region private void LoadGlyph(char c, out Box2 rectangle)

        /// <summary>
        /// Adds a glyph to the texture packer.
        /// </summary>
        /// <param name="c">The character of the glyph.</param>
        /// <param name="rectangle">An OpenTK.Math.Box2 that will hold the buffer for this glyph.</param>
        private void LoadGlyph(char c, out RectangleF rectangle)
        {
            if (pack == null)
                PrepareTexturePacker();

            Glyph g = new Glyph(c, font);
            Rectangle rect = new Rectangle();

            try
            {
                pack.Add(g, out rect);
            }
            catch (InvalidOperationException expt)
            {
                // TODO: The TexturePacker is full, create a new font sheet.
                Trace.WriteLine(expt);
                throw;
            }

            GL.BindTexture(TextureTarget.Texture2D, texture);

            gfx.Clear(System.Drawing.Color.Transparent);
            gfx.DrawString(g.Character.ToString(), g.Font, System.Drawing.Brushes.White, 0.0f, 0.0f);

            //BitmapData bitmap_data = bitmap.LockBits(new Rectangle(0, 0, rect.Width, rect.Height), ImageLockMode.ReadOnly,
            //    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //GL.TexSubImage2D(TextureTarget.Texture2D, 0, rect.Left, rect.Top, rect.Width, rect.Height,
            //    OpenTK.Graphics.Enums.PixelFormat.Rgba, PixelType.UnsignedByte, bitmap_data.Scan0);
            //bitmap.UnlockBits(bitmap_data);

            BitmapData bitmap_data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            int needed_size = rect.Width * rect.Height;
            if (data.Length < needed_size)
                Array.Resize<int>(ref data, needed_size);
            Array.Clear(data, 0, needed_size);
            unsafe
            {
                int* bitmap_data_ptr = (int*)bitmap_data.Scan0;
                for (int y = 0; y < rect.Height; y++)
                    for (int x = 0; x < rect.Width; x++)
                        data[y * rect.Width + x] = *(bitmap_data_ptr + y * bmp.Width + x);

                fixed (int* data_ptr = data)
                    GL.TexSubImage2D(TextureTarget.Texture2D, 0, rect.Left, rect.Top, rect.Width, rect.Height,
                                     OpenTK.Graphics.PixelFormat.Rgba, PixelType.UnsignedByte, (IntPtr)data_ptr);
            }
            bmp.UnlockBits(bitmap_data);

            rectangle = RectangleF.FromLTRB(
                rect.Left / (float)texture_width,
                rect.Top / (float)texture_height,
                rect.Right / (float)texture_width,
                rect.Bottom / (float)texture_height);

            loaded_glyphs.Add(g.Character, rectangle);

        }

        #endregion

        #endregion

        #region --- Internal Methods ---

        #region internal int Texture

        /// <summary>
        /// Gets the handle to the texture were this font resides.
        /// </summary>
        internal int Texture
        {
            get { return TextureFont.texture; }
        }

        #endregion

        #endregion

        #region --- IDisposable Members ---

        bool disposed;

        /// <summary>
        /// Releases all resources used by this OpenTK.Graphics.TextureFont.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        private void Dispose(bool manual)
        {
            if (!disposed)
            {
                pack = null;
                if (manual)
                {
                    GL.DeleteTextures(1, ref texture);
                    font.Dispose();
                    gfx.Dispose();
                }

                disposed = true;
            }
        }

        ~TextureFont()
        {
            Dispose(false);
        }

        #endregion
    }
}
