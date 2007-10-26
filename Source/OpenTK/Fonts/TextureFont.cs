using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;

using OpenTK.Math;
using OpenTK.OpenGL;
using System.Drawing.Imaging;
using OpenTK.Platform;

namespace OpenTK.Fonts
{
    public class TextureFont : IDisposable
    {
        Font font;
        Dictionary<char, int> loaded_glyphs = new Dictionary<char, int>(36);
        Graphics gfx = Graphics.FromImage(new Bitmap(1, 1));

        static int texture;
        static TexturePacker<Glyph> pack;
        static int texture_width, texture_height;
        float[] viewport = new float[6];

        /// <summary>
        /// Constructs a new TextureFont object, using the specified System.Drawing.Font.
        /// </summary>
        /// <param name="font"></param>
        public TextureFont(Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font", "Argument to TextureFont constructor cannot be null.");

            this.font = font;
        }

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

        private int LoadGlyph(char c)
        {
            if (pack == null)
                PrepareTexturePacker();

            Glyph g = new Glyph(c, font);
            Rectangle rect = pack.Add(g);

            using (Bitmap bmp = new Bitmap(g.Width, g.Height, PixelFormat.Format32bppArgb))
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                // Upload texture and create Display List:
                GL.BindTexture(GL.Enums.TextureTarget.TEXTURE_2D, texture);

                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                //gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                gfx.Clear(Color.Transparent);
                gfx.DrawString(g.Character.ToString(), g.Font, Brushes.White, 0.0f, 0.0f);
                BitmapData data = bmp.LockBits(new Rectangle(0, 0, g.Width, g.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                GL.TexSubImage2D(GL.Enums.TextureTarget.TEXTURE_2D, 0, rect.Left, rect.Top, rect.Width, rect.Height,
                    GL.Enums.PixelFormat.RGBA, GL.Enums.PixelType.UNSIGNED_BYTE, data.Scan0);
                bmp.UnlockBits(data);

                float left = rect.Left / (float)texture_width;
                float bottom = rect.Bottom / (float)texture_height;
                float right = rect.Right / (float)texture_width;
                float top = rect.Top / (float)texture_height;
                float width = rect.Right - rect.Left;
                float height = rect.Bottom - rect.Top;

                int list = GL.GenLists(1);
                GL.NewList(list, GL.Enums.ListMode.COMPILE);

                GL.Enable(GL.Enums.EnableCap.BLEND);
                GL.BlendFunc(GL.Enums.BlendingFactorSrc.ONE, GL.Enums.BlendingFactorDest.ONE_MINUS_SRC_ALPHA);

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
            }
        }

        /// <summary>
        /// Calculates the optimal size for the font texture and TexturePacker, and creates both.
        /// </summary>
        private void PrepareTexturePacker()
        {
            // Calculate the size of the texture packer. We want a power-of-two size
            // that is less than 1024 (supported in Geforce256-era cards), but large
            // enough to hold at least 256 (16*16) font glyphs.
            int size = (int)(font.Size * 16);
            size = (int)System.Math.Pow(2.0, System.Math.Ceiling(System.Math.Log((double)size, 2.0)));
            if (size > 1024)
                size = 1024;

            texture_width = size;
            texture_height = size;
            pack = new TexturePacker<Glyph>(texture_width, texture_height);

            GL.GenTextures(1, out texture);
            GL.BindTexture(GL.Enums.TextureTarget.TEXTURE_2D, texture);
            GL.TexParameter(GL.Enums.TextureTarget.TEXTURE_2D, GL.Enums.TextureParameterName.TEXTURE_MIN_FILTER, (int)GL.Enums.All.LINEAR);
            GL.TexParameter(GL.Enums.TextureTarget.TEXTURE_2D, GL.Enums.TextureParameterName.TEXTURE_MAG_FILTER, (int)GL.Enums.All.NEAREST);

            byte[] data = new byte[texture_height * texture_width * 4];
            GL.TexImage2D(GL.Enums.TextureTarget.TEXTURE_2D, 0, 4, texture_width, texture_height, 0,
                GL.Enums.PixelFormat.RGBA, GL.Enums.PixelType.UNSIGNED_BYTE, data);
        }

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

        /// <summary>
        /// Gets a float indicating the default line spacing of this font.
        /// </summary>
        public float LineSpacing
        {
            get { return font.Height; }
        }

        /// <summary>
        /// Measures the width of the specified string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public float MeasureWidth(string str)
        {
            float distance = gfx.MeasureString(str, font, 16384, StringFormat.GenericTypographic).Width;
            if (distance == 0)
                distance = font.SizeInPoints * 0.5f;
            return distance;
        }

        #region IDisposable Members

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
