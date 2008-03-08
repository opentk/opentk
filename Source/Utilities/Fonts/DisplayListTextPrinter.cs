#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics.OpenGL;
using OpenTK.Math;

namespace OpenTK.Graphics
{
    /// <summary>
    /// Provides text printing through OpenGL 1.1 Display Lists.
    /// </summary>
    class DisplayListTextPrinter : ITextPrinterImplementation
    {
        #region IPrinter Members

        public TextHandle Load(Vector2[] vertices, ushort[] indices, int index_count)
        {
            DisplayListTextHandle handle = new DisplayListTextHandle(GL.GenLists(1));

            GL.NewList(handle.Handle, ListMode.Compile);

            this.Draw(vertices, indices, index_count);

            GL.EndList();

            return handle;
        }

        public void Draw(TextHandle handle)
        {
            GL.CallList(handle.Handle);
        }

        public void Draw(Vector2[] vertices, ushort[] indices, int index_count)
        {
            GL.Begin(BeginMode.Triangles);

            for (int i = 0; i < index_count; i++)
            //foreach (ushort index in indices)
            {
                GL.TexCoord2(vertices[indices[i] + 1]);
                GL.Vertex2(vertices[indices[i]]);
            }

            GL.End();
        }

        #endregion
    }
}
