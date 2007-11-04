#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
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
        //class BBox { public int X, Y, Width, Height; }

        Font font;
        //Dictionary<char, int> loaded_glyphs = new Dictionary<char, int>(36);
        Dictionary<char, RectangleF> loaded_glyphs = new Dictionary<char, RectangleF>(64);

        Graphics gfx = Graphics.FromImage(new Bitmap(1, 1));
        static int texture;
        static TexturePacker<Glyph> pack;
        static int texture_width, texture_height;
        float[] viewport = new float[6];

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
            foreach (char c in glyphs)
            {
                if (!loaded_glyphs.ContainsKey(c))
                    LoadGlyph(c);
            }
        }

        #endregion

        #region private RectangleF LoadGlyph(char c)

        private RectangleF LoadGlyph(char c)
        {
            if (pack == null)
                PrepareTexturePacker();

            Glyph g = new Glyph(c, font);
            Rectangle rect = pack.Add(g);

            using (Bitmap bmp = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                // Upload texture and create Display List:
                GL.BindTexture(TextureTarget.Texture2d, texture);

                //gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                //gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                gfx.Clear(Color.Transparent);
                gfx.DrawString(g.Character.ToString(), g.Font, Brushes.White, 0.0f, 0.0f);

                BitmapData bmp_data = bmp.LockBits(new Rectangle(0, 0, rect.Width, rect.Height), ImageLockMode.ReadOnly,
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                GL.TexSubImage2D(TextureTarget.Texture2d, 0, rect.Left, rect.Top, rect.Width, rect.Height,
                    OpenTK.OpenGL.Enums.PixelFormat.Rgba, PixelType.UnsignedByte, bmp_data.Scan0);
                bmp.UnlockBits(bmp_data);

                RectangleF f_rect = RectangleF.FromLTRB(
                    rect.Left / (float)texture_width,
                    rect.Top / (float)texture_height,
                    rect.Right / (float)texture_width,
                    rect.Bottom / (float)texture_height);
                
                loaded_glyphs.Add(g.Character, f_rect);
                
                return f_rect;

                /*
                byte[] data = new byte[rect.Width * rect.Height * 4];
                int i = 0;
                for (int y = 0; y < rect.Height - 1; y++)
                {
                    for (int x = 0; x < rect.Width - 1; x++)
                    {
                        data[i++] = bmp.GetPixel(x, y).R;
                        data[i++] = bmp.GetPixel(x, y).G;
                        data[i++] = bmp.GetPixel(x, y).B;
                        data[i++] = bmp.GetPixel(x, y).A;
                    }
                }

                unsafe
                {
                    fixed (byte* data_ptr = data)
                        GL.TexSubImage2D(GL.Enums.TextureTarget.TEXTURE_2D, 0, rect.Left, rect.Top, rect.Width, rect.Height,
                            GL.Enums.PixelFormat.RGBA, GL.Enums.PixelType.UNSIGNED_BYTE, (IntPtr)data_ptr);
                }
                
                float left = rect.Left / (float)texture_width;
                float bottom = rect.Bottom / (float)texture_height;
                float right = rect.Right / (float)texture_width;
                float top = rect.Top / (float)texture_height;
                float width = rect.Right - rect.Left;
                float height = rect.Bottom - rect.Top;
                */
                /*
                int list = GL.GenLists(1);
                GL.NewList(list, GL.Enums.ListMode.COMPILE);

                GL.Enable(GL.Enums.EnableCap.BLEND);
                GL.BlendFunc(GL.Enums.BlendingFactorSrc.SRC_ALPHA, GL.Enums.BlendingFactorDest.ONE_MINUS_SRC_ALPHA);

                GL.Begin(GL.Enums.BeginMode.QUADS);

                GL.TexCoord2(left, top);
                //GL.Vertex2(0.375f, 0.375f);
                GL.Vertex2(0.0f, 0.0f);

                GL.TexCoord2(right, top);
                //GL.Vertex2(0.375f + 2 * width, 0.375f);
                GL.Vertex2(width, 0.0f);

                GL.TexCoord2(right, bottom);
                //GL.Vertex2(0.375f + 2 * width, 0.375f + 2 * height);
                GL.Vertex2(width, height);

                GL.TexCoord2(left, bottom);
                //GL.Vertex2(0.375f, 0.375f + 2 * height);
                GL.Vertex2(0.0f, height);

                GL.End();

                GL.EndList();

                loaded_glyphs.Add(g.Character, list);

                return list;
                */
            }
        }

        #endregion

        public void Draw()
        {
            ILayoutProvider l = new DefaultLayoutProvider();
            l.PerformLayout("ato e -et uq39tu, /q3t.q/t.q3t q     34t34qwt .", this,
                new RectangleF(9.0f, 9.0f, 300.0f, 100.0f), StringAlignment.Near, false);
        }

        #region 
        
        public bool GlyphData(char glyph, ref RectangleF textureRectangle, out float width, out float height, out int texture)
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

        #region public RectangleF FindRectangle(char c)

        /// <summary>
        /// Looks up the specified glyph and returns it's bounding System.Drawing.Rectangle in the font texture.
        /// This function will add the glyph to the texture font, if it hasn't been previoulsy loaded through LoadGlyphs().
        /// </summary>
        /// <param name="c">The character representing the glyph.</param>
        /// <returns>The System.Drawing.Rectangle that represents the glyph's bounding box in the font texture.</returns>
        /// <seealso cref="LoadGlyphs"/>
        public RectangleF FindRectangle(char c)
        {
            RectangleF rect;
            return loaded_glyphs.TryGetValue(c, out rect) ? rect : LoadGlyph(c);
        }

        #endregion

        #region public int FindTexture(char c)

        /// <summary>
        /// Returns the handle to the OpenGL texture where the specified glyph is located or zero, if the glyph has not been loaded.
        /// </summary>
        /// <param name="c">The character that corresponds to the glyph.</param>
        /// <returns>A handle to the OpenGL texture, or zero.</returns>
        public int FindTexture(char c)
        {
            if (loaded_glyphs.ContainsKey(c))
                return texture;
            return 0;
        }

        #endregion

        #region public void Print(char c)
#if false
        /// <summary>
        /// Prints a glyph.
        /// </summary>
        /// <param name="c">The character corresponding to the glyph to print.</param>
        /// <remarks>
        /// The print position is specified by the active Modelview matrix.
        /// <para>
        /// To print pixel perfect fonts, you must setup a Projection matrix that is maps one texel to one pixel. This
        /// can be achieved by calling GL.Ortho with width/height set to the actual viewport size, or alternatively,
        /// by calling GL.Scale(1.0f/viewport_width, 1.0f/viewport_height, 0.0f).
        /// </para>
        /// <para>
        /// To avoid filtering artifacts, avoid positioning characters on fractional pixels.
        /// This is usually achieved by adding 0.5f to the glyph's position and extracting the integer component,
        /// i.e. GL.Translate((int)(x_pos + 0.5f), (int)(y_pos + 0.5f), 0.0f);
        /// </para>
        /// </remarks>
        /// <seealso cref="PrintFast"/>
        public void Print(char c)
        {
            GL.BindTexture(GL.Enums.TextureTarget.TEXTURE_2D, texture);

            int list;
            if (loaded_glyphs.TryGetValue(c, out list))
            {
                GL.CallList(list);
            }
            else
            {
                GL.CallList(LoadGlyph(c));
            }
        }
#endif
        #endregion

        #region public void PrintFast(char c)
#if false
        /// <summary>
        /// Prints a previously loaded glyph.
        /// </summary>
        /// <param name="c">The character corresponding to the glyph to print.</param>
        /// <remarks>
        /// You must call the LoadGlyphs function with the corresponding glyph, before using
        /// PrintFast. Otherwise, this function works exactly like Print.
        /// </remarks>
        /// <see cref="Print"/>
        /// <seealso cref="LoadGlyphs"/>
        public void PrintFast(char c)
        {
            GL.CallList(loaded_glyphs[c]);
        }
#endif
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

        #region public float MeasureString(string str)

        /// <summary>
        /// Measures the width of the specified string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public SizeF MeasureString(string str)
        {
            SizeF size = gfx.MeasureString(str, font, 16384, StringFormat.GenericTypographic);
            if (size.Width == 0)
                size.Width = font.SizeInPoints * 0.5f;
            return size;
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
