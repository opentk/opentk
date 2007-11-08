#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
//using System.Drawing;
using System.Drawing.Text;

using OpenTK.Math;
using OpenTK.OpenGL;
using OpenTK.OpenGL.Enums;
using System.Drawing.Imaging;
using OpenTK.Platform;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace OpenTK.Fonts
{
    public class TextureFont : IFont
    {
        Font font;
        Dictionary<char, Box2> loaded_glyphs = new Dictionary<char, Box2>(64);

        Bitmap bmp;
        Graphics gfx;
        // TODO: We need to be able to use multiple font sheets.
        static int texture;
        static TexturePacker<Glyph> pack;
        static int texture_width, texture_height;

        int[] data = new int[256];  // Used to upload glyph data to the OpenGL texture.
        
        object upload_lock = new object();

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new TextureFont object, using the specified System.Drawing.Font.
        /// </summary>
        /// <param name="font">The System.Drawing.Font to use.</param>
        public TextureFont(Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font", "Argument to TextureFont constructor cannot be null.");

            this.font = font;

            bmp = new Bitmap(font.Height * 2, font.Height * 2);
            gfx = Graphics.FromImage(bmp);

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
            GL.BindTexture(TextureTarget.Texture2d, texture);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)All.Linear);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)All.Linear);

            GL.TexImage2D(TextureTarget.Texture2d, 0, PixelInternalFormat.Alpha, texture_width, texture_height, 0,
                OpenTK.OpenGL.Enums.PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
        }

        #endregion

        #region public void LoadGlyphs(string glyphs)

        /// <summary>
        /// Prepares the specified glyphs for rendering.
        /// </summary>
        /// <param name="glyphs">The glyphs to prepare for rendering.</param>
        public void LoadGlyphs(string glyphs)
        {
            Box2 rect = new Box2();
            foreach (char c in glyphs)
            {
                if (!loaded_glyphs.ContainsKey(c))
                    LoadGlyph(c, out rect);
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
            Box2 rect = new Box2();
            if (!loaded_glyphs.ContainsKey(glyph))
                LoadGlyph(glyph, out rect);
        }

        #endregion

        #region private void LoadGlyph(char c, out Box2 rectangle)

        /// <summary>
        /// Adds a glyph to the texture packer.
        /// </summary>
        /// <param name="c">The character of the glyph.</param>
        /// <param name="rectangle">An OpenTK.Math.Box2 that will hold the data for this glyph.</param>
        private void LoadGlyph(char c, out Box2 rectangle)
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

            GL.BindTexture(TextureTarget.Texture2d, texture);

            gfx.Clear(System.Drawing.Color.Transparent);
            gfx.DrawString(g.Character.ToString(), g.Font, System.Drawing.Brushes.White, 0.0f, 0.0f);

            //BitmapData bitmap_data = bitmap.LockBits(new Rectangle(0, 0, rect.Width, rect.Height), ImageLockMode.ReadOnly,
            //    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //GL.TexSubImage2D(TextureTarget.Texture2d, 0, rect.Left, rect.Top, rect.Width, rect.Height,
            //    OpenTK.OpenGL.Enums.PixelFormat.Rgba, PixelType.UnsignedByte, bitmap_data.Scan0);
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
                {
                    for (int x = 0; x < rect.Width; x++)
                    {
                        data[y * rect.Width + x] = *(bitmap_data_ptr + y * bmp.Width + x);
                    }
                }

                fixed (int* data_ptr = data)
                    GL.TexSubImage2D(TextureTarget.Texture2d, 0, rect.Left, rect.Top, rect.Width, rect.Height,
                                     OpenTK.OpenGL.Enums.PixelFormat.Rgba, PixelType.UnsignedByte, (IntPtr)data_ptr);
            }
            bmp.UnlockBits(bitmap_data);

            rectangle = new Box2(
                rect.Left / (float)texture_width,
                rect.Top / (float)texture_height,
                rect.Right / (float)texture_width,
                rect.Bottom / (float)texture_height);

            loaded_glyphs.Add(g.Character, rectangle);

        }

        #endregion

        #region public bool GlyphData(char glyph, out float width, out float height, out Box2 textureRectangle, out int texture)

        /// <summary>
        /// Returns the characteristics of a loaded glyph.
        /// </summary>
        /// <param name="glyph">The character corresponding to this glyph.</param>
        /// <param name="width">The width of this glyph.</param>
        /// <param name="height">The height of this glyph (line spacing).</param>
        /// <param name="textureRectangle">The bounding box of the texture data of this glyph.</param>
        /// <param name="texture">The handle to the texture that contains this glyph.</param>
        /// <returns>True if the glyph has been loaded, false otherwise.</returns>
        /// <seealso cref="LoadGlyphs"/>
        public bool GlyphData(char glyph, out float width, out float height, out Box2 textureRectangle, out int texture)
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

        #region internal int Texture

        /// <summary>
        /// Gets the handle to the texture were this font resides.
        /// </summary>
        internal int Texture
        {
            get { return TextureFont.texture; }
        }

        #endregion

        #region public void MeasureString(string str, out float width, out float height)

        /// <summary>
        /// Measures the width of the specified string.
        /// </summary>
        /// <param name="str">The string to measure.</param>
        /// <param name="width">The measured width.</param>
        /// <param name="height">The measured height.</param>
        public void MeasureString(string str, out float width, out float height)
        {
            System.Drawing.SizeF size = gfx.MeasureString(str, font, 16384, System.Drawing.StringFormat.GenericTypographic);
            if (size.Width == 0)
                width = font.SizeInPoints * 0.5f;
            else
                width = size.Width;
            height = size.Height;
        }

        #endregion

        #region --- IDisposable Members ---

        bool disposed;

        /// <summary>
        /// Releases all resources used by this OpenTK.Fonts.TextureFont.
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
