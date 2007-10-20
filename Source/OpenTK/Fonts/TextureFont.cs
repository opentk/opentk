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
    public class TextureFont
    {
        Font font;
        Dictionary<char, LoadedGlyph> loaded_glyphs = new Dictionary<char, LoadedGlyph>(36);
        Graphics gfx;

        struct LoadedGlyph
        {
            public int List;
            public float Width, Height;
        }
        
        static int texture;
        static TexturePacker<Glyph> pack;
        static int texture_width, texture_height;

        public TextureFont(Font font)
        {
            if (font == null)
                throw new ArgumentNullException("font", "Argument to TextureFont constructor cannot be null.");

            this.font = font;

            if (pack == null)
            {
                // Calculate the size of the texture packer. We want a power-of-two size
                // that is less than 1024 (supported in Geforce256-era cards), but large
                // enough to hold at least 256 (16*16) font glyphs.
                int size = (int)(font.Size*16);
                size = (int)System.Math.Pow(2.0, System.Math.Ceiling(System.Math.Log((double)size, 2.0)));
                if (size > 1024)
                    size = 1024;

                PrepareTexturePacker(size, size);
                gfx = Graphics.FromImage(new Bitmap(1, 1));
            }
        }

        /// <summary>
        /// Not ready yet.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void PrepareTexturePacker(int width, int height)
        {
            texture_width = width;
            texture_height = height;
            pack = new TexturePacker<Glyph>(texture_width, texture_height);
            
            GL.GenTextures(1, out texture);
            GL.BindTexture(GL.Enums.TextureTarget.TEXTURE_2D, texture);
            GL.TexParameter(GL.Enums.TextureTarget.TEXTURE_2D, GL.Enums.TextureParameterName.TEXTURE_MIN_FILTER, (int)GL.Enums.All.LINEAR);
            GL.TexParameter(GL.Enums.TextureTarget.TEXTURE_2D, GL.Enums.TextureParameterName.TEXTURE_MAG_FILTER, (int)GL.Enums.All.LINEAR);

            byte[] data = new byte[texture_height * texture_width * 4];
            GL.TexImage2D(GL.Enums.TextureTarget.TEXTURE_2D, 0, 4, texture_width, texture_height, 0,
                GL.Enums.PixelFormat.RGBA, GL.Enums.PixelType.UNSIGNED_BYTE, data);
        }

        public void LoadGlyphs(string glyphs)
        {
            foreach (char c in glyphs)
            {
                if (!loaded_glyphs.ContainsKey(c))
                    LoadGlyph(c);
            }
        }

        private LoadedGlyph LoadGlyph(char c)
        {
            Glyph g = new Glyph(c, font);
            Rectangle rect = pack.Add(g);

            using (Bitmap bmp = new Bitmap(g.Width, g.Height))
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                // Upload texture and create Display List:
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

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
                float width = (rect.Right - rect.Left); // / (float)screen_width;
                float height = (rect.Top - rect.Bottom); // / (float)screen_height;

                //width /= 2.0f;

                LoadedGlyph lg = new LoadedGlyph();
                
                lg.List = GL.GenLists(1);
                GL.NewList(lg.List, GL.Enums.ListMode.COMPILE);

                //GL.PushAttrib(GL.Enums.AttribMask.ALL_ATTRIB_BITS);

                GL.Enable(GL.Enums.EnableCap.BLEND);
                GL.BlendFunc(GL.Enums.BlendingFactorSrc.ONE, GL.Enums.BlendingFactorDest.ONE_MINUS_SRC_ALPHA);

                GL.Begin(GL.Enums.BeginMode.QUADS);

                GL.TexCoord2(left, top);
                GL.Vertex2(0.375f, 0.375f);

                GL.TexCoord2(right, top);
                GL.Vertex2(0.375f + 2 * width, 0.375f);

                GL.TexCoord2(right, bottom);
                GL.Vertex2(0.375f + 2 * width, 0.375f + 2 * height);

                GL.TexCoord2(left, bottom);
                GL.Vertex2(0.375f, 0.375f + 2 * height);

                GL.End();

                GL.PopAttrib();

                GL.EndList();

                lg.Width = 2 * width;
                lg.Height = 2 * height;

                loaded_glyphs.Add(g.Character, lg);
                
                return lg;
            }
        }

        float[] viewport = new float[6];
        public void Print(char c)
        {
            LoadedGlyph lg;
            GL.GetFloat(GL.Enums.GetPName.VIEWPORT, viewport);

            GL.PushMatrix();

            GL.Scale(1.0f / (viewport[2] - viewport[0]), 1.0f / (viewport[3] - viewport[1]), 1.0f);
            if (loaded_glyphs.TryGetValue(c, out lg))
            {
                GL.CallList(lg.List);
            }
            else
            {
                GL.CallList(LoadGlyph(c).List);
            }
            
            GL.PopMatrix();
        }

        public void Print(string str)
        {
            GL.GetFloat(GL.Enums.GetPName.VIEWPORT, viewport);

            GL.PushMatrix();

            GL.Scale(1.0f / (viewport[2] - viewport[0]), 1.0f / (viewport[3] - viewport[1]), 1.0f);

            LoadGlyphs(str);
            int i = 0;
            foreach (char c in str)
            {
                LoadedGlyph lg = loaded_glyphs[c];
                GL.CallList(lg.List);

                //GL.Translate(lg.Width, 0.0f, 0.0f);
                float width = gfx.MeasureString(str.Substring(i, 1), font, 256, StringFormat.GenericTypographic).Width;
                if (width == 0.0f) width = 8.0f;    // Spacebar.
                GL.Translate(2 * width, 0.0f, 0.0f);
                ++i;
            }

            GL.PopMatrix();
        }

        public void Print(string format, params object[] args)
        {
            Print(String.Format(format, args));
        }

        public float LineSpacing
        {
            get { return font.Height; }
        }
    }
}
