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

using OpenTK.Math;
using OpenTK.OpenGL;
using OpenTK.OpenGL.Enums;
using System.Runtime.InteropServices;


namespace OpenTK.Fonts
{
    /// <summary>
    /// Provides methods to perform layout and print hardware accelerated text.
    /// </summary>
    public class TextPrinter : ITextPrinter
    {
        //static Regex break_point = new Regex("[ .,/*-+?\\!=]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        //static char[] split_chars = new char[] { ' ', '\n', '\t', ',', '.', '/', '?', '!', ';', '\\', '-', '+', '*', '=' };
        static bool use_vbo, use_arb_vbo, use_display_list;
        static bool functionality_checked = false;
        static IPrinter printer;

        #region --- Constructor ---

        /// <summary>
        /// Constructs a new DefaultLayoutProvider object.
        /// </summary>
        public TextPrinter() { }

        #endregion

        /// <summary>
        /// Checks the machine's capabilities and selects the fastest method to print text.
        /// </summary>
        static void CheckNeededFunctionality()
        {
            printer =
                GL.SupportsExtension("VERSION_1_5") ? new VboPrinter() :
                GL.SupportsExtension("ARB_vertex_buffer_object") ? null :
                GL.SupportsExtension("VERSION_1_1") ? null : null;
            
            if (printer == null)
                throw new NotSupportedException("DefaultLayoutProvider requires at least OpenGL 1.1 support.");
            
            functionality_checked = true;
        }

        #region --- ITextPrinter Members ---

        public void Prepare(string text, TextureFont font, out TextHandle handle)
        {
            this.Prepare(text, font, out handle, 0, false, StringAlignment.Near, false);
        }

        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp)
        {
            this.Prepare(text, font, out handle, width, wordWarp, StringAlignment.Near, false);
        }

        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment)
        {
            this.Prepare(text, font, out handle, width, wordWarp, alignment, false);
        }

        public void Prepare(string text, TextureFont font, out TextHandle handle, float width, bool wordWarp, StringAlignment alignment, bool rightToLeft)
        {
            if (!functionality_checked)
                CheckNeededFunctionality();

            if (text == null)
                throw new ArgumentNullException("Parameter cannot be null.", "text");

            if (text.Length > 4096)
                throw new ArgumentOutOfRangeException("text", text.Length, "Text length must be between 1 and 4096 characters");

            Vector2[] vertices = new Vector2[8 * text.Length];  // Interleaved, vertex, texcoord, vertex, etc...
            ushort[] indices = new ushort[6 * text.Length];
            float x_pos = 0, y_pos = 0;
            ushort i = 0, index_count = 0, vertex_count = 0, last_break_point = 0;
            Box2 rect = new Box2();
            float char_width, char_height, measured_width, measured_height;
            int texture;

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

                    if (c == '\n' || c == '\r')
                    {
                        //x_pos = layoutRect.Left;
                        x_pos = 0;
                        y_pos += font.Height;
                    }
                    else
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

        public void Draw(TextHandle handle)
        {
            GL.PushAttrib(AttribMask.TextureBit);
            GL.PushAttrib(AttribMask.EnableBit);

            GL.Enable(EnableCap.Texture2d);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            GL.Enable(EnableCap.Blend);
            GL.BindTexture(TextureTarget.Texture2d, handle.font.Texture);
            
            printer.Draw(handle);

            GL.PopAttrib();
            GL.PopAttrib();
        }

        #endregion
    }

    public class TextHandle
    {
        internal TextHandle(int handle)
        {
            Handle = handle;
        }

        public readonly int Handle;
        internal TextureFont font;
    }

    class VboTextHandle : TextHandle
    {
        public VboTextHandle(int handle) : base(handle) { }

        internal int vbo_id;    // vertex buffer object id.
        internal int ebo_id;    // index buffer object id.
        internal int element_count;     // Number of elements in the ebo.
    }

    interface IPrinter
    {
        TextHandle Load(Vector2[] vertices, ushort[] indices);
        void Draw(TextHandle handle);
    }

    class VboPrinter : IPrinter
    {
        static int allocated_handles;
        static int vector2_size = Marshal.SizeOf(new Vector2());

        #region --- IPrinter Members ---

        public TextHandle Load(Vector2[] vertices, ushort[] indices)
        {
            VboTextHandle handle = new VboTextHandle(++allocated_handles);
            GL.GenBuffers(1, out handle.vbo_id);
            GL.GenBuffers(1, out handle.ebo_id);

            GL.BindBuffer(Version15.ArrayBuffer, handle.vbo_id);
            GL.BufferData(Version15.ArrayBuffer, (IntPtr)(vertices.Length * vector2_size), vertices,
                          Version15.StaticDraw);

            GL.BindBuffer(Version15.ElementArrayBuffer, handle.ebo_id);
            GL.BufferData(Version15.ElementArrayBuffer, (IntPtr)(indices.Length * sizeof(ushort)), indices,
                          Version15.StaticDraw);
            handle.element_count = indices.Length;

            return handle;
        }

        public void Draw(TextHandle handle)
        {
            VboTextHandle vbo = (VboTextHandle)handle;

            GL.PushClientAttrib(ClientAttribMask.ClientVertexArrayBit);

            GL.BindBuffer(Version15.StaticDraw, vbo.vbo_id);
            GL.BindBuffer(Version15.ElementArrayBuffer, vbo.ebo_id);

            GL.EnableClientState(EnableCap.VertexArray);
            GL.EnableClientState(EnableCap.TextureCoordArray);

            GL.TexCoordPointer(2, TexCoordPointerType.Float, vector2_size, (IntPtr)vector2_size);
            GL.VertexPointer(2, VertexPointerType.Float, vector2_size, IntPtr.Zero);

            GL.DrawElements(BeginMode.Triangles, vbo.element_count, All.UnsignedShort, IntPtr.Zero);

            GL.PopClientAttrib();
        }

        #endregion
    }
}
