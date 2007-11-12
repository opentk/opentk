#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

using OpenTK.Math;
using OpenTK.OpenGL;
using OpenTK.OpenGL.Enums;
using System.Diagnostics;

namespace OpenTK.Fonts
{
    /// <summary>
    /// Provides methods to perform layout and print hardware accelerated text.
    /// </summary>
    public class TextPrinter : ITextPrinter
    {
        //static Regex break_point = new Regex("[ .,/*-+?\\!=]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        //static char[] split_chars = new char[] { ' ', '\n', '\t', ',', '.', '/', '?', '!', ';', '\\', '-', '+', '*', '=' };
        static bool functionality_checked = false;
        static ITextPrinterImplementation printer;
        float[] viewport = new float[6];

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new DefaultLayoutProvider object.
        /// </summary>
        public TextPrinter() { }

        #endregion

        #region static void CheckNeededFunctionality()

        /// <summary>
        /// Checks the machine's capabilities and selects the fastest method to print text.
        /// </summary>
        static void CheckNeededFunctionality()
        {
            printer = new DisplayListTextPrinter();
                /*
                GL.SupportsExtension("VERSION_1_5") ? new VboTextPrinter() :
                GL.SupportsExtension("ARB_vertex_buffer_object") ? null :
                GL.SupportsExtension("VERSION_1_1") ? null : null;
                */
            if (printer == null)
                throw new NotSupportedException("DefaultLayoutProvider requires at least OpenGL 1.1 support.");
            
            functionality_checked = true;

            Debug.Print("Using {0} for font printing.", printer);
        }

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
        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment, bool rightToLeft)
        {
            if (!functionality_checked)
                CheckNeededFunctionality();

            if (text == null)
                throw new ArgumentNullException("Parameter cannot be null.", "text");

            if (text.Length > 8192)
                throw new ArgumentOutOfRangeException("text", text.Length, "Text length must be between 1 and 8192 characters");

            if (wordWarp || rightToLeft || alignment != StringAlignment.Near)
                throw new NotImplementedException();

            Vector2[] vertices = new Vector2[8 * text.Length];  // Interleaved, vertex, texcoord, vertex, etc...
            ushort[] indices = new ushort[6 * text.Length];
            float x_pos = 0, y_pos = 0;
            ushort i = 0, index_count = 0, vertex_count = 0, last_break_point = 0;
            Box2 rect = new Box2();
            float char_width, char_height, measured_width, measured_height;
            int texture;

            font.LoadGlyphs(text);

            // Every character comprises of 4 vertices, forming two triangles. We generate an index array which
            // indexes vertices in a triangle-strip fashion. To create a single strip for the whole string, we
            // need to add a degenerate triangle (0 height) to connect the last vertex of the previous line with
            // the first vertex of the next line.
            // This algorithm works for left-to-right scripts.

            if (alignment == StringAlignment.Near && !rightToLeft || alignment == StringAlignment.Far && rightToLeft)
            {
                foreach (char c in text)
                {
                    if (Char.IsSeparator(c))
                        last_break_point = index_count;

                    if (c != '\n' && c != '\r')
                    {
                        font.GlyphData(c, out char_width, out char_height, out rect, out texture);

                        vertices[vertex_count].X    = x_pos;                // Vertex
                        vertices[vertex_count++].Y  = y_pos;
                        vertices[vertex_count].X    = rect.Left;            // Texcoord
                        vertices[vertex_count++].Y  = rect.Top;
                        vertices[vertex_count].X    = x_pos;                // Vertex
                        vertices[vertex_count++].Y  = y_pos + char_height;
                        vertices[vertex_count].X    = rect.Left;            // Texcoord
                        vertices[vertex_count++].Y  = rect.Bottom;

                        vertices[vertex_count].X    = x_pos + char_width;   // Vertex
                        vertices[vertex_count++].Y = y_pos + char_height;
                        vertices[vertex_count].X    = rect.Right;           // Texcoord
                        vertices[vertex_count++].Y  = rect.Bottom;
                        vertices[vertex_count].X    = x_pos + char_width;   // Vertex
                        vertices[vertex_count++].Y  = y_pos;
                        vertices[vertex_count].X    = rect.Right;           // Texcoord
                        vertices[vertex_count++].Y  = rect.Top;

                        indices[index_count++] = (ushort)(vertex_count - 8);
                        indices[index_count++] = (ushort)(vertex_count - 6);
                        indices[index_count++] = (ushort)(vertex_count - 4);

                        indices[index_count++] = (ushort)(vertex_count - 4);
                        indices[index_count++] = (ushort)(vertex_count - 2);
                        indices[index_count++] = (ushort)(vertex_count - 8);


                        font.MeasureString(text.Substring(i, 1), out measured_width, out measured_height);
                        x_pos += measured_width;
                    }
                    else if (c == '\n')
                    {
                        //x_pos = layoutRect.Left;
                        x_pos = 0;
                        y_pos += font.Height;
                    }
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

            handle = printer.Load(vertices, indices);
            handle.font = font;
        }

        #endregion

        #region public void Draw(TextHandle handle)

        /// <summary>
        /// Draws the cached text referred to by the TextHandle.
        /// </summary>
        /// <param name="handle">The TextHandle to the cached text.</param>
        public void Draw(TextHandle handle)
        {
            GL.BindTexture(TextureTarget.Texture2d, handle.font.Texture);
            
            printer.Draw(handle);
        }

        #endregion

        #region public void Draw(string text)

        #endregion

        #region public void Begin()

        /// <summary>
        /// Sets up OpenGL state for drawing text.
        /// </summary>
        public void Begin()
        {
            GL.PushMatrix();

            GL.GetFloat(GetPName.Viewport, viewport);

            // Prepare to draw text. We want pixel perfect precision, so we setup a 2D mode,
            // with size equal to the window (in pixels). 
            // While we could also render text in 3D mode, it would be very hard to get
            // pixel-perfect precision.
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(viewport[0], viewport[2], viewport[3], viewport[1], 0.0, 1.0);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.PushAttrib(AttribMask.TextureBit);
            GL.PushAttrib(AttribMask.EnableBit);

            GL.Enable(EnableCap.Texture2d);
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
            GL.PopAttrib();
            GL.PopMatrix();
        }

        #endregion

        #endregion
    }
}
