using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    class GL1TextOutputProvider : ITextOutputProvider
    {
        #region Constructors

        public GL1TextOutputProvider() { }

        #endregion

        #region ITextOutputProvider Members

        public void Print(TextBlock block, IGlyphRasterizer rasterizer, GlyphCache cache)
        {
            TextExtents extents = rasterizer.MeasureText(block);

            foreach (char c in block.Text)
                if (c != '\n' && c != '\r' && !Char.IsWhiteSpace(c) && !cache.Contains(c, block.Font))
                    cache.Add(c, block.Font);

            GL.BindTexture(TextureTarget.Texture2D, 2);

            //GL.Begin(BeginMode.Quads);

            //GL.TexCoord2(0, 0);
            //GL.Vertex2(0, 0);
            //GL.TexCoord2(1, 0);
            //GL.Vertex2(256, 0);
            //GL.TexCoord2(1, 1);
            //GL.Vertex2(256, 256);
            //GL.TexCoord2(0, 1);
            //GL.Vertex2(0, 256);

            //GL.End();

            //GL.Translate(0, 256, 0);

            GL.Begin(BeginMode.Triangles);

            int current = 0;
            foreach (char c in block.Text)
            {
                if (c == '\n' || c == '\r')
                    continue;
                else if (Char.IsWhiteSpace(c))
                {
                    current++;
                    continue;
                }

                CachedGlyphInfo info = cache[c, block.Font];
                RectangleF position = extents[current++];

                position.Size = info.Rectangle.Size;

                // Interleaved array: Vertex, TexCoord, Vertex, ...
                GL.TexCoord2(info.RectangleNormalized.Left, info.RectangleNormalized.Top);
                GL.Vertex2(position.Left, position.Top);
                GL.TexCoord2(info.RectangleNormalized.Left, info.RectangleNormalized.Bottom);
                GL.Vertex2(position.Left, position.Bottom);
                GL.TexCoord2(info.RectangleNormalized.Right, info.RectangleNormalized.Bottom);
                GL.Vertex2(position.Right, position.Bottom);

                GL.TexCoord2(info.RectangleNormalized.Right, info.RectangleNormalized.Bottom);
                GL.Vertex2(position.Right, position.Bottom);
                GL.TexCoord2(info.RectangleNormalized.Right, info.RectangleNormalized.Top);
                GL.Vertex2(position.Right, position.Top);
                GL.TexCoord2(info.RectangleNormalized.Left, info.RectangleNormalized.Top);
                GL.Vertex2(position.Left, position.Top);
            }

            GL.End();
        }

        #endregion
    }
}
