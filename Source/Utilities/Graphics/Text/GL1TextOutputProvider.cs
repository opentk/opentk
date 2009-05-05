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
    abstract class GL1TextOutputProvider : ITextOutputProvider
    {
        #region Fields

        // Triangle lists, sorted by texture.
        Dictionary<Texture2D, List<Vector2>> active_lists = new Dictionary<Texture2D, List<Vector2>>();
        Queue<List<Vector2>> inactive_lists = new Queue<List<Vector2>>();

        #pragma warning disable 0649

        struct Viewport { public float Left, Top, Right, Bottom; }

        #pragma warning restore 0649

        bool disposed;

        #endregion

        #region Constructors

        public GL1TextOutputProvider()
        {
            inactive_lists.Enqueue(new List<Vector2>());
        }

        #endregion

        #region ITextOutputProvider Members

        #region Print

        public void Print(TextBlock block, Color color, IGlyphRasterizer rasterizer)
        {
            GL.PushAttrib(AttribMask.CurrentBit | AttribMask.TextureBit | AttribMask.EnableBit | AttribMask.ColorBufferBit | AttribMask.DepthBufferBit);

            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            SetBlendFunction();

            GL.Disable(EnableCap.DepthTest);

            using (TextExtents extents = rasterizer.MeasureText(block))
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
                    else if (!Cache.Contains(glyph))
                        Cache.Add(glyph, rasterizer, TextQuality);

                    CachedGlyphInfo info = Cache[glyph];
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

                //if (!legacy_mode)
                //{
                //    GL.PushMatrix();
                //    GL.GetFloat(GetPName.Viewport, viewport);
                //    GL.Scale(2.0 / (viewport[2] - viewport[0]), -2.0 / (viewport[3] - viewport[1]), 1);
                //}

                SetColor(color);

                GL.Begin(BeginMode.Triangles);

                for (int i = 0; i < list.Count; i += 2)
                {
                    GL.TexCoord2(list[i]);
                    GL.Vertex2(list[i + 1]);
                }

                GL.End();

                //if (!legacy_mode)
                //    GL.PopMatrix();
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

        #region Clear

        public void Clear()
        {
            Cache.Clear();
        }

        #endregion

        #region Begin

        public void Begin()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            GraphicsContext.Assert();

            int current_matrix;
            GL.GetInteger(GetPName.MatrixMode, out current_matrix);

            Viewport viewport = new Viewport();
            GL.GetFloat(GetPName.Viewport, out viewport.Left);

            // Prepare to draw text. We want pixel perfect precision, so we setup a 2D mode,
            // with size equal to the window (in pixels). 
            // While we could also render text in 3D mode, it would be very hard to get
            // pixel-perfect precision.
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(viewport.Left, viewport.Right, viewport.Bottom, viewport.Top, -1.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PushMatrix();
            GL.LoadIdentity();

            GL.MatrixMode(MatrixMode.Texture);
            GL.PushMatrix();
            GL.LoadIdentity();

            GL.MatrixMode((MatrixMode)current_matrix);
        }

        #endregion

        #region End

        public void End()
        {
            if (disposed)
                throw new ObjectDisposedException(this.GetType().ToString());

            GraphicsContext.Assert();

            int current_matrix;
            GL.GetInteger(GetPName.MatrixMode, out current_matrix);

            GL.MatrixMode(MatrixMode.Texture);
            GL.PopMatrix();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();

            GL.MatrixMode((MatrixMode)current_matrix);
        }

        #endregion

        #endregion

        #region Protected Members

        protected abstract void SetBlendFunction();

        protected abstract void SetColor(Color color);

        protected abstract TextQuality TextQuality { get; }

        protected abstract GlyphCache Cache { get; }

        #endregion

        #region Static Members

        public static GL1TextOutputProvider Create(TextQuality quality)
        {
            if (!GL.SupportsExtension("Version12") || !GL.SupportsFunction("BlendColor") || quality == TextQuality.Low || quality == TextQuality.Medium)
                return new GL11TextOutputProvider(quality);
            else
                return new GL12TextOutputProvider(quality);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (!disposed)
            {
                Cache.Dispose();
                disposed = true;
            }
        }

        #endregion
    }
}
