#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using OpenTK.OpenGL;
using OpenTK.Math;
using OpenTK.OpenGL.Enums;

namespace OpenTK.Fonts
{
    /// <summary>
    /// Provides text printing through OpenGL 1.5 vertex buffer objects.
    /// </summary>
    class VboTextPrinter : ITextPrinterImplementation
    {
        static int allocated_handles;
        static int vector2_size = Marshal.SizeOf(new Vector2());

        #region --- IPrinter Members ---

        public TextHandle Load(Vector2[] vertices, ushort[] indices, int index_count)
        {
            VboTextHandle handle = new VboTextHandle(++allocated_handles);

            GL.GenBuffers(1, out handle.vbo_id);
            GL.BindBuffer(BufferTarget.ArrayBuffer, handle.vbo_id);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(vertices.Length * vector2_size), vertices,
                          BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            GL.GenBuffers(1, out handle.ebo_id);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, handle.ebo_id);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indices.Length * sizeof(ushort)), indices,
                          BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);

            handle.element_count = indices.Length;
            return handle;
        }

        public void Draw(TextHandle handle)
        {
            VboTextHandle vbo = (VboTextHandle)handle;

            //GL.PushClientAttrib(ClientAttribMask.ClientVertexArrayBit);

            //GL.EnableClientState(EnableCap.TextureCoordArray);
            GL.EnableClientState(EnableCap.VertexArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo.vbo_id);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, vbo.ebo_id);

            GL.TexCoordPointer(2, TexCoordPointerType.Float, vector2_size, (IntPtr)vector2_size);
            GL.VertexPointer(2, VertexPointerType.Float, vector2_size, IntPtr.Zero);

            GL.DrawElements(BeginMode.Triangles, vbo.element_count, All.UnsignedShort, IntPtr.Zero);
            //GL.DrawArrays(BeginMode.LineLoop, 0, vbo.element_count);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);

            GL.DisableClientState(EnableCap.VertexArray);
            //GL.DisableClientState(EnableCap.TextureCoordArray);

            //GL.PopClientAttrib();
        }

        #endregion
    }

    #region class VboTextHandle : TextHandle

    /// <summary>
    /// Contains the necessary information to print text through the VboTextPrinter implementation.
    /// </summary>
    class VboTextHandle : TextHandle
    {
        public VboTextHandle(int handle) : base(handle) { }

        internal int vbo_id;    // vertex buffer object id.
        internal int ebo_id;    // index buffer object id.
        internal int element_count;     // Number of elements in the ebo.

        public override string ToString()
        {
            return String.Format("TextHandle (vbo): {0} ({1} element(s), vbo id: {2}, ebo id: {3}",
                Handle, element_count / 6, vbo_id, ebo_id);
        }
    }

    #endregion
}
