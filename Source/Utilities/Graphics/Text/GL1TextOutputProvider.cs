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
        struct Viewport { public int X, Y, Width, Height; }
        #pragma warning restore 0649

        // Used to save the current state in Begin() and restore it in End()
        Stack<Matrix4> projection_stack = new Stack<Matrix4>();
        Stack<Matrix4> modelview_stack = new Stack<Matrix4>();
        Stack<Matrix4> texture_stack = new Stack<Matrix4>();
        Stack<Viewport> viewport_stack = new Stack<Viewport>();

        // Used as temporary storage when saving / restoring the current state.
        Viewport viewport = new Viewport();
        Matrix4 matrix = new Matrix4();

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

            RectangleF position;

            using (TextExtents extents = rasterizer.MeasureText(ref block))
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
                    position = extents[current++];

                    // Use the real glyph width instead of the measured one (we want to achieve pixel perfect output).
                    position.Size = info.Rectangle.Size;

                    if (!active_lists.ContainsKey(info.Texture))
                    {
                        if (inactive_lists.Count > 0)
                        {
                            List<Vector2> list = inactive_lists.Dequeue();
                            list.Clear();
                            active_lists.Add(info.Texture, list);
                        }
                        else
                        {
                            active_lists.Add(info.Texture, new List<Vector2>());
                        }
                    }

                    {
                        // Interleaved array: Vertex, TexCoord, Vertex, ...
                        List<Vector2> current_list = active_lists[info.Texture];
                        current_list.Add(new Vector2(info.RectangleNormalized.Left, info.RectangleNormalized.Top));
                        current_list.Add(new Vector2(position.Left, position.Top));
                        current_list.Add(new Vector2(info.RectangleNormalized.Left, info.RectangleNormalized.Bottom));
                        current_list.Add(new Vector2(position.Left, position.Bottom));
                        current_list.Add(new Vector2(info.RectangleNormalized.Right, info.RectangleNormalized.Bottom));
                        current_list.Add(new Vector2(position.Right, position.Bottom));

                        current_list.Add(new Vector2(info.RectangleNormalized.Right, info.RectangleNormalized.Bottom));
                        current_list.Add(new Vector2(position.Right, position.Bottom));
                        current_list.Add(new Vector2(info.RectangleNormalized.Right, info.RectangleNormalized.Top));
                        current_list.Add(new Vector2(position.Right, position.Top));
                        current_list.Add(new Vector2(info.RectangleNormalized.Left, info.RectangleNormalized.Top));
                        current_list.Add(new Vector2(position.Left, position.Top));
                    }
                }
            }

            // Render
            foreach (Texture2D key in active_lists.Keys)
            {
                List<Vector2> list = active_lists[key];
                
                key.Bind();

                SetColor(color);

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
                //list.Clear();
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

            // Save the state of everything we are going to modify:
            // the current matrix mode, viewport state and the projection, modelview and texture matrices.
            // All these will be restored in the TextPrinter.End() method.
            int current_matrix;
            GL.GetInteger(GetPName.MatrixMode, out current_matrix);

            GL.GetInteger(GetPName.Viewport, out viewport.X);
            viewport_stack.Push(viewport);

            GL.GetFloat(GetPName.ProjectionMatrix, out matrix.Row0.X);
            projection_stack.Push(matrix);
            GL.GetFloat(GetPName.ModelviewMatrix, out matrix.Row0.X);
            modelview_stack.Push(matrix);
            GL.GetFloat(GetPName.TextureMatrix, out matrix.Row0.X);
            texture_stack.Push(matrix);

            // Prepare to draw text. We want pixel perfect precision, so we setup a 2D mode,
            // with size equal to the window (in pixels). 
            // While we could also render text in 3D mode, it would be very hard to get
            // pixel-perfect precision.
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(viewport.X, viewport.Width, viewport.Height, viewport.Y, -1.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.MatrixMode(MatrixMode.Texture);
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

            viewport = viewport_stack.Pop();
            GL.Viewport(viewport.X, viewport.Y, viewport.Width, viewport.Height);

            GL.MatrixMode(MatrixMode.Texture);
            matrix = texture_stack.Pop();
            GL.LoadMatrix(ref matrix);

            GL.MatrixMode(MatrixMode.Modelview);
            matrix = modelview_stack.Pop();
            GL.LoadMatrix(ref matrix);

            GL.MatrixMode(MatrixMode.Projection);
            matrix = projection_stack.Pop();
            GL.LoadMatrix(ref matrix);

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
