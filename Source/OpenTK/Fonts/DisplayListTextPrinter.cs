using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.OpenGL;

namespace OpenTK.Fonts
{
    /// <summary>
    /// Provides text printing through OpenGL 1.1 Display Lists.
    /// </summary>
    class DisplayListTextPrinter : ITextPrinterImplementation
    {
        #region IPrinter Members

        public TextHandle Load(OpenTK.Math.Vector2[] vertices, ushort[] indices)
        {
            DisplayListTextHandle handle = new DisplayListTextHandle(GL.GenLists(1));

            GL.NewList(handle.Handle, OpenTK.OpenGL.Enums.ListMode.Compile);
            GL.Begin(OpenTK.OpenGL.Enums.BeginMode.Triangles);

            foreach (ushort index in indices)
            {
                GL.TexCoord2(vertices[index + 1]);
                GL.Vertex2(vertices[index]);
            }

            GL.End();
            GL.EndList();

            return handle;
        }

        public void Draw(TextHandle handle)
        {
            GL.CallList(handle.Handle);
        }

        #endregion
    }

    public class DisplayListTextHandle : TextHandle
    {
        public DisplayListTextHandle(int handle) : base(handle) { }
    }
}
