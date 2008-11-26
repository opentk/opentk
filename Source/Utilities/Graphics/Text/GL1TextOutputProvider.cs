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

        // Triangle lists, sorted by texture.
        Dictionary<Texture2D, List<Vector2>> active_lists = new Dictionary<Texture2D, List<Vector2>>();
        Queue<List<Vector2>> inactive_lists = new Queue<List<Vector2>>();

        #endregion

        #region Constructors

        public GL1TextOutputProvider()
        {
            inactive_lists.Enqueue(new List<Vector2>());
        }

        #endregion

        #region ITextOutputProvider Members

        public void Print(TextBlock block, IGlyphRasterizer rasterizer, GlyphCache cache)
        {
            using (TextExtents extents = rasterizer.MeasureText(block))
            {
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

                // Build layout
                int current = 0;
                foreach (Glyph glyph in block)
                {
                    if (glyph.IsWhiteSpace)
                    {
                        current++;
                        continue;
                    }
                    else if (!cache.Contains(glyph))
                        cache.Add(glyph);

                    CachedGlyphInfo info = cache[glyph];
                    RectangleF position = extents[current++];

                    // Use the real glyph width instead of the measured one (we want to achieve pixel perfect output).
                    position.Size = info.Rectangle.Size;

                    if (!active_lists.ContainsKey(info.Texture))
                        if (inactive_lists.Count > 0)
                            active_lists.Add(info.Texture, inactive_lists.Dequeue());
                        else
                            active_lists.Add(info.Texture, new List<Vector2>());
                    {
                        // Interleaved array: Vertex, TexCoord, Vertex, ...
                        active_lists[info.Texture].Add(new Vector2(info.RectangleNormalized.Left, info.RectangleNormalized.Top));
                        active_lists[info.Texture].Add(new Vector2(position.Left, position.Top));
                        active_lists[info.Texture].Add(new Vector2(info.RectangleNormalized.Left, info.RectangleNormalized.Bottom));
                        active_lists[info.Texture].Add(new Vector2(position.Left, position.Bottom));
                        active_lists[info.Texture].Add(new Vector2(info.RectangleNormalized.Right, info.RectangleNormalized.Bottom));
                        active_lists[info.Texture].Add(new Vector2(position.Right, position.Bottom));

                        active_lists[info.Texture].Add(new Vector2(info.RectangleNormalized.Right, info.RectangleNormalized.Bottom));
                        active_lists[info.Texture].Add(new Vector2(position.Right, position.Bottom));
                        active_lists[info.Texture].Add(new Vector2(info.RectangleNormalized.Right, info.RectangleNormalized.Top));
                        active_lists[info.Texture].Add(new Vector2(position.Right, position.Top));
                        active_lists[info.Texture].Add(new Vector2(info.RectangleNormalized.Left, info.RectangleNormalized.Top));
                        active_lists[info.Texture].Add(new Vector2(position.Left, position.Top));
                    }
                }
            }

            // Render
            foreach (Texture2D key in active_lists.Keys)
            {
                List<Vector2> list = active_lists[key];
                
                key.Bind();
                GL.Begin(BeginMode.Triangles);

                for (int i = 0; i < list.Count; i += 2)
                {
                    GL.TexCoord2(list[i]);
                    GL.Vertex2(list[i + 1]);
                }

                GL.End();
            }

            // Clean layout
            foreach (List<Vector2> list in active_lists.Values)
            {
                list.Clear();
                inactive_lists.Enqueue(list);
            }

            active_lists.Clear();
        }

        #endregion
    }
}
