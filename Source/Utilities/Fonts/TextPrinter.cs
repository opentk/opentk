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
        //static Regex break_point = new Regex("[ .,/*-+?\\!=]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        //static char[] split_chars = new char[]
        //{
        //    ' ', '\n', '\t', ',', '.', '/', '?', '!', ';', '\\', '-', '+', '*', '='
        //};
        static ITextPrinterImplementation printer;
        float[] viewport = new float[4];
          // Interleaved, vertex, texcoord, vertex, etc... Starts with 8 chars, will expand as needed.
        Vector2[] vertices = new Vector2[8 * 8];
        ushort[] indices = new ushort[6 * 8];
        List<RectangleF> ranges = new List<RectangleF>();


        #region --- Constructors ---

        public TextPrinter(ITextPrinterImplementation implementation)
        {
            if (implementation == null)
                throw new ArgumentNullException("implementation");
            printer = implementation;
        }

        #endregion

        #region --- Private Members ---

        #region static ITextPrinterImplementation Printer

        /// <summary>
        /// Checks the machine's capabilities and selects the fastest method to print text.
        /// </summary>
        static ITextPrinterImplementation Printer
        {
            get
            {
                if (printer == null)
                {

                    printer = (ITextPrinterImplementation)new DisplayListTextPrinter();
                    //GL.SupportsExtension("VERSION_1_5") ?
                    //(ITextPrinterImplementation)new VboTextPrinter() :
                    //GL.SupportsExtension("ARB_vertex_buffer_object") ? null :
                    //GL.SupportsExtension("VERSION_1_1") ? null : null;
                    if (printer == null)
                        throw new NotSupportedException("TextPrinter requires at least OpenGL 1.1 support.");

                    Debug.Print("Using {0} for font printing.", printer);
                }
                return printer;
            }
        }

        #endregion

        #endregion

        #region --- ITextPrinter Members ---

        #region public void Prepare(string text, TextureFont font, out TextHandle handle)

        /// <summary>
        /// Prepares text for drawing.
        /// </summary>
        /// <param name="text">The string to draw.</param>
        /// <param name="font">The font to use for drawing.</param>
        /// <param name="handle">The handle to the cached text. Use this to draw the text with the Draw() function.</param>
        /// <see cref="TextPrinter.Draw()"/>
        public void Prepare(string text, TextureFont font, out TextHandle handle)
        {
            this.Prepare(text, font, out handle, 0, false, StringAlignment.Near, false);
        }

        #endregion

        #region public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp)

        /// <summary>
        /// Prepares text for drawing.
        /// </summary>
        /// <param name="text">The string to draw.</param>
        /// <param name="font">The font to use for drawing.</param>
        /// <param name="handle">The handle to the cached text. Use this to draw the text with the Draw() function.</param>
        /// <param name="width">Not implemented.</param>
        /// <param name="wordWarp">Not implemented.</param>
        /// <see cref="TextPrinter.Draw()"/>
        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp)
        {
            this.Prepare(text, font, out handle, width, wordWarp, StringAlignment.Near, false);
        }

        #endregion

        #region public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment)

        /// <summary>
        /// Prepares text for drawing.
        /// </summary>
        /// <param name="text">The string to draw.</param>
        /// <param name="font">The font to use for drawing.</param>
        /// <param name="handle">The handle to the cached text. Use this to draw the text with the Draw() function.</param>
        /// <param name="width">Not implemented.</param>
        /// <param name="wordWarp">Not implemented.</param>
        /// <param name="alignment">Not implemented.</param>
        /// <see cref="TextPrinter.Draw()"/>
        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment)
        {
            this.Prepare(text, font, out handle, width, wordWarp, alignment, false);
        }

        #endregion

        #region public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment, bool rightToLeft)

        /// <summary>
        /// Prepares text for drawing.
        /// </summary>
        /// <param name="text">The string to draw.</param>
        /// <param name="font">The font to use for drawing.</param>
        /// <param name="handle">The handle to the cached text. Use this to draw the text with the Draw() function.</param>
        /// <param name="width">Not implemented.</param>
        /// <param name="wordWarp">Not implemented.</param>
        /// <param name="alignment">Not implemented.</param>
        /// <param name="rightToLeft">Not implemented.</param>
        /// <see cref="TextPrinter.Draw()"/>
        /// <exception cref="NotSupportedException">Occurs when OpenGL 1.1 is not supported.</exception>
        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment, bool rightToLeft)
        {
            int num_indices;

            PerformLayout(text, font, width, wordWarp, alignment, rightToLeft, ref vertices, ref indices, out num_indices);

            handle = Printer.Load(vertices, indices, num_indices);
            handle.Font = font;
        }

        #endregion

        #region void PerformLayout(string text, TextureFont font, float width, bool wordWarp, StringAlignment alignment, bool rightToLeft, ref Vector2[] vertices, ref ushort[] indices, out int num_indices)

        // Performs layout on the given string.
        void PerformLayout(string text, TextureFont font, float width, bool wordWarp, StringAlignment alignment,
                           bool rightToLeft, ref Vector2[] vertices, ref ushort[] indices, out int num_indices)
        {
            if (text == null)
                throw new ArgumentNullException("Parameter cannot be null.", "text");

            if (text.Length > 8192)
                throw new ArgumentOutOfRangeException("text", text.Length, "Text length must be between 1 and 8192 characters");

            if (wordWarp || rightToLeft || alignment != StringAlignment.Near)
                throw new NotImplementedException();

            if (8 * text.Length > vertices.Length)
                vertices = new Vector2[Math.Functions.NextPowerOfTwo(8 * text.Length)];

            if (6 * text.Length > indices.Length)
                indices = new ushort[Math.Functions.NextPowerOfTwo(6 * text.Length)];

            num_indices = 6 * text.Length;

            //Vector2[] vertices = new Vector2[8 * text.Length];  // Interleaved, vertex, texcoord, vertex, etc...
            //ushort[] indices = new ushort[6 * text.Length];
            float x_pos = 0, y_pos = 0;
            ushort i = 0, index_count = 0, vertex_count = 0;
            RectangleF rect = new RectangleF();
            float char_width, char_height;
            int texture;

            font.LoadGlyphs(text);

            // Every character comprises of 4 vertices, forming two triangles. We generate an index array which
            // indexes vertices in a triangle-list fashion. 
            // This algorithm works for left-to-right scripts.

            if (alignment == StringAlignment.Near && !rightToLeft || alignment == StringAlignment.Far && rightToLeft)
            {
                font.MeasureText(text, SizeF.Empty, null, ranges);

                int current = 0;

                foreach (char c  in text)
                {
                    if (c == '\n' || c == '\r')
                        continue;
                    else if (Char.IsWhiteSpace(c))
                    {
                        current++;
                        continue;
                    }

                    RectangleF range = ranges[current++];

                    x_pos = range.X;
                    y_pos = range.Y;

                    font.GlyphData(c, out char_width, out char_height, out rect, out texture);

                    vertices[vertex_count].X = x_pos;                // Vertex
                    vertices[vertex_count++].Y = y_pos;
                    vertices[vertex_count].X = rect.Left;            // Texcoord
                    vertices[vertex_count++].Y = rect.Top;
                    vertices[vertex_count].X = x_pos;                // Vertex
                    vertices[vertex_count++].Y = y_pos + char_height;
                    vertices[vertex_count].X = rect.Left;            // Texcoord
                    vertices[vertex_count++].Y = rect.Bottom;

                    vertices[vertex_count].X = x_pos + char_width;   // Vertex
                    vertices[vertex_count++].Y = y_pos + char_height;
                    vertices[vertex_count].X = rect.Right;           // Texcoord
                    vertices[vertex_count++].Y = rect.Bottom;
                    vertices[vertex_count].X = x_pos + char_width;   // Vertex
                    vertices[vertex_count++].Y = y_pos;
                    vertices[vertex_count].X = rect.Right;           // Texcoord
                    vertices[vertex_count++].Y = rect.Top;

                    indices[index_count++] = (ushort)(vertex_count - 8);
                    indices[index_count++] = (ushort)(vertex_count - 6);
                    indices[index_count++] = (ushort)(vertex_count - 4);

                    indices[index_count++] = (ushort)(vertex_count - 4);
                    indices[index_count++] = (ushort)(vertex_count - 2);
                    indices[index_count++] = (ushort)(vertex_count - 8);

                    ++i;
                }
            }
            else if (alignment != StringAlignment.Center)
            {
                throw new NotImplementedException("This feature is not yet implemented. Sorry for the inconvenience.");
            }
            else
            {
                throw new NotImplementedException("This feature is not yet implemented. Sorry for the inconvenience.");
            }
        }

        #endregion

        #region public void Draw(TextHandle handle)

        /// <summary>
        /// Draws the cached text referred to by the TextHandle.
        /// </summary>
        /// <param name="handle">The TextHandle to the cached text.</param>
        public void Draw(TextHandle handle)
        {
            GL.BindTexture(TextureTarget.Texture2D, handle.Font.Texture);

            Printer.Draw(handle);
        }

        #endregion

        #region public void Draw(string text, TextureFont font)

        /// <summary>
        /// Draws dynamic text without caching. Not implemented yet!
        /// </summary>
        /// <param name="text">The System.String to draw.</param>
        /// <param name="font">The OpenTK.Graphics.TextureFont to draw the text in.</param>
        public void Draw(string text, TextureFont font)
        {
            int num_indices;
            PerformLayout(text, font, 0, false, StringAlignment.Near, false, ref vertices, ref indices, out num_indices);

            GL.BindTexture(TextureTarget.Texture2D, font.Texture);

            Printer.Draw(vertices, indices, num_indices);
        }

        #endregion

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

        #endregion

        #region New Implementation

        #region Fields

        Dictionary<Font, TextureFont> font_cache = new Dictionary<Font, TextureFont>();

        GlyphCache glyph_cache;
        IGlyphRasterizer glyph_rasterizer;
        ITextOutputProvider text_output;

        //TextExtents text_extents = new TextExtents();

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

        #region Public Members

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

        #endregion
    }
}
