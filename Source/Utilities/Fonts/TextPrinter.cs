#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Diagnostics;

using OpenTK.Math;
using OpenTK.Graphics;
using OpenTK.Graphics.Text;
using OpenTK.Platform;

namespace OpenTK.Fonts { }

namespace OpenTK.Graphics
{
    /// <summary>
    /// Provides methods to perform layout and print hardware accelerated text.
    /// </summary>
    public sealed class TextPrinter : ITextPrinter
    {
        #region Fields

        GlyphCache glyph_cache;
        IGlyphRasterizer glyph_rasterizer;
        ITextOutputProvider text_output;

        float[] viewport = new float[4];

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new TextPrinter object.
        /// </summary>
        public TextPrinter()
            : this(null, null)
        {
        }

        TextPrinter(IGlyphRasterizer rasterizer, ITextOutputProvider output/*, IGlyphCacheProvider, ITextOutputProvider */)
        {
            if (rasterizer == null)
                rasterizer = new GdiPlusGlyphRasterizer();

            if (output == null)
                output = new GL1TextOutputProvider();

            glyph_rasterizer = rasterizer;
            glyph_cache = new GlyphCache(rasterizer);
            text_output = output;
        }

        #endregion

        #region ITextPrinter Members

        #region public void Begin()

        /// <summary>
        /// Sets up OpenGL state for drawing text.
        /// </summary>
        public void Begin()
        {
            if (GraphicsContext.CurrentContext == null)
                throw new GraphicsContextException("No GraphicsContext is current in the calling thread.");

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

            GL.PushAttrib(AttribMask.TextureBit | AttribMask.EnableBit | AttribMask.ColorBufferBit);

            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            GL.Disable(EnableCap.DepthTest);
        }

        #endregion

        #region public void End()

        /// <summary>
        /// Restores OpenGL state.
        /// </summary>
        public void End()
        {
            GL.PopAttrib();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.PopMatrix();

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
        }

        #endregion

        #region Print

        public void Print(string text, Font font)
        {
            Print(text, font, 0, RectangleF.Empty);
        }

        public void Print(string text, Font font, TextPrinterOptions options)
        {
            Print(text, font, options, RectangleF.Empty);
        }

        public void Print(string text, Font font, TextPrinterOptions options, RectangleF layoutRectangle)
        {
            if (String.IsNullOrEmpty(text))
                return;

            if (font == null)
                throw new ArgumentNullException("font");

            text_output.Print(new TextBlock(text, font, options, layoutRectangle), glyph_rasterizer, glyph_cache);

            //glyph_rasterizer.MeasureText(text, font, options, layoutRectangle, ref text_extents);

            //List<Vector2> vertices = new List<Vector2>();
            //List<int> indices = new List<int>();
            //PerformLayout(new TextBlock(text, font, layoutRectangle, options), text_extents, vertices, indices);

            //GL.Begin(BeginMode.Triangles);
            //foreach (int i in indices)
            //{
            //    GL.TexCoord2(vertices[i + 1]);
            //    GL.Vertex2(vertices[i]);
            //}
            //GL.End();
        }

        #endregion

        #region Measure

        public TextExtents Measure(string text, Font font)
        {
            return Measure(text, font, 0, RectangleF.Empty);
        }
    
        public TextExtents Measure(string text, Font font, TextPrinterOptions options)
        {
            return Measure(text, font, options, RectangleF.Empty);
        }

        public TextExtents Measure(string text, Font font, TextPrinterOptions options, RectangleF layoutRectangle)
        {
            return glyph_rasterizer.MeasureText(new TextBlock(text, font, options, layoutRectangle));
        }

        #endregion

        #endregion

        #region Private Members

        #region PerformLayout

        void PerformLayout(TextBlock block, TextExtents extents, List<Vector2> vertices, List<int> indices)
        {
            vertices.Clear();
            vertices.Capacity = 4 * block.Text.Length;
            indices.Clear();
            indices.Capacity = 6 * block.Text.Length;
            
            float x_pos = 0, y_pos = 0;
            RectangleF rect = new RectangleF();
            float char_width, char_height;

            // Every character comprises of 4 vertices, forming two triangles. We generate an index array which
            // indexes vertices in a triangle-list fashion. 

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
                else if (!glyph_cache.Contains(c, block.Font))
                    glyph_cache.Add(c, block.Font);

                //font.GlyphData(c, out char_width, out char_height, out rect, out texture);
                CachedGlyphInfo cache_info = glyph_cache[c, block.Font];
                RectangleF glyph_position = extents[current];

                x_pos = glyph_position.X;
                y_pos = glyph_position.Y;
                char_width = glyph_position.Width;
                char_height = glyph_position.Height;

                // Interleaved array: Vertex, TexCoord, Vertex, ...
                vertices.Add(new Vector2(x_pos, y_pos)); // Vertex
                vertices.Add(new Vector2(rect.Left, rect.Top));  // Texcoord
                vertices.Add(new Vector2(x_pos, y_pos + char_height));
                vertices.Add(new Vector2(rect.Left, rect.Bottom));

                vertices.Add(new Vector2(x_pos + char_width, y_pos + char_height));
                vertices.Add(new Vector2(rect.Right, rect.Bottom));
                vertices.Add(new Vector2(x_pos + char_width, y_pos));
                vertices.Add(new Vector2(rect.Right, rect.Top));

                indices.Add(vertices.Count - 8);
                indices.Add(vertices.Count - 6);
                indices.Add(vertices.Count - 4);

                indices.Add(vertices.Count - 4);
                indices.Add(vertices.Count - 2);
                indices.Add(vertices.Count - 8);
            }
        }

        #endregion

        #endregion
    }
}
