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

using System.Collections.Generic;
using System.Drawing;
using OpenTK.Math;
using System;

namespace OpenTK.Graphics.Text
{
    class GL1TextOutputProvider : ITextOutputProvider
    {
        #region Fields

        // Triangle lists, sorted by texture.
        Dictionary<Texture2D, List<Vector2>> active_lists = new Dictionary<Texture2D, List<Vector2>>();
        Queue<List<Vector2>> inactive_lists = new Queue<List<Vector2>>();
        float[] viewport = new float[4];
        bool legacy_mode = false;

        #endregion

        #region Constructors

        public GL1TextOutputProvider()
        {
            inactive_lists.Enqueue(new List<Vector2>());
        }

        #endregion

        #region ITextOutputProvider Members

        #region Print

        public void Print(TextBlock block, PointF location, Color color, IGlyphRasterizer rasterizer, GlyphCache cache)
        {
            GL.PushAttrib(AttribMask.TextureBit | AttribMask.EnableBit | AttribMask.ColorBufferBit | AttribMask.DepthBufferBit);

            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.ConstantColorExt, BlendingFactorDest.OneMinusSrcColor);   // For subpixel with color

            GL.Disable(EnableCap.DepthTest);

            //GL.TexEnv(TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, (int)TextureEnvMode.Modulate);
            //GL.Enable(EnableCap.ColorMaterial);
            //GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);  // For grayscale
            //GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcColor);   // For subpixel

            using (TextExtents extents = rasterizer.MeasureText(block, location))
            {
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

                GL.Translate(location.X, location.Y, 0);
                if (!legacy_mode)
                {
                    GL.Scale(2.0 / (viewport[2] - viewport[0]), -2.0 / (viewport[3] - viewport[1]), 1);
                }
                GL.BlendColor(color);

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

            GL.PopAttrib();
        }

        #endregion

        #region Begin

        [Obsolete]
        public void Begin()
        {
            GraphicsContext.Assert();

            legacy_mode = true;

            GL.GetFloat(GetPName.Viewport, viewport);

            // Prepare to draw text. We want pixel perfect precision, so we setup a 2D mode,
            // with size equal to the window (in pixels). 
            // While we could also render text in 3D mode, it would be very hard to get
            // pixel-perfect precision.
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(viewport[0], viewport[2], viewport[3], viewport[1], -1.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            GL.LoadIdentity();
        }

        #endregion

        #region End

        [Obsolete]
        public void End()
        {
            GraphicsContext.Assert();

            legacy_mode = false;

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
        }

        #endregion

        #endregion
    }
}
