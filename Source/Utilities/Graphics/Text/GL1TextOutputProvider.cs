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

using OpenTK.Math;

namespace OpenTK.Graphics.Text
{
    class GL1TextOutputProvider : ITextOutputProvider
    {
        #region Fields

        SortedList<int, List<Vector2>> vertices = new SortedList<int,List<Vector2>>();

        #endregion

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

            //GL.BindTexture(TextureTarget.Texture2D, 2);

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
