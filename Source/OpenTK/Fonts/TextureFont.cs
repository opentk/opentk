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

namespace OpenTK.Fonts
{
    public class TextureFont : IFont
    {
        System.Drawing.Font font;
        Dictionary<char, Box2> loaded_glyphs = new Dictionary<char, Box2>(64);

        System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(new System.Drawing.Bitmap(1, 1));
        static int texture;
        static TexturePacker<Glyph> pack;
        static int texture_width, texture_height;
        float[] viewport = new float[6];

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new TextureFont object, using the specified System.Drawing.Font.
        /// </summary>
        /// <param name="font">The System.Drawing.Font to use.</param>
        public TextureFont(System.Drawing.Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font", "Argument to TextureFont constructor cannot be null.");

            this.font = font;
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

        #region private void LoadGlyph(char c, out Box2 rectangle)

        /// <summary>
        /// Adds a glyph to the texture packer.
        /// </summary>
        /// <param name="c">The character of the glyph.</param>
        /// <param name="rectangle">A RectangleF that will hold the data for this glyph.</param>
        private void LoadGlyph(char c, out Box2 rectangle)
        {
            if (pack == null)
                PrepareTexturePacker();

            Glyph g = new Glyph(c, font);
            System.Drawing.Rectangle rect = pack.Add(g);

            using (System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(
                rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            using (System.Drawing.Graphics gfx = System.Drawing.Graphics.FromImage(bmp))
            {
                // Upload texture data.
                GL.BindTexture(TextureTarget.Texture2d, texture);

                //gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                //gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                gfx.TextContrast = 0;
                gfx.Clear(System.Drawing.Color.Transparent);
                gfx.DrawString(g.Character.ToString(), g.Font, System.Drawing.Brushes.White, 0.0f, 0.0f);

                BitmapData bmp_data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, rect.Width, rect.Height), ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                GL.TexSubImage2D(TextureTarget.Texture2d, 0, rect.Left, rect.Top, rect.Width, rect.Height,
                    OpenTK.OpenGL.Enums.PixelFormat.Rgba, PixelType.UnsignedByte, bmp_data.Scan0);
                bmp.UnlockBits(bmp_data);

                rectangle = new Box2(
                    rect.Left / (float)texture_width,
                    rect.Top / (float)texture_height,
                    rect.Right / (float)texture_width,
                    rect.Bottom / (float)texture_height);

                loaded_glyphs.Add(g.Character, rectangle);
            }
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
