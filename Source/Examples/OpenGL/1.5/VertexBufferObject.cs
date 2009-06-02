#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Math;

#endregion

namespace Examples.Tutorial
{
    [Example("Vertex Buffer Objects", ExampleCategory.OpenGL, "1.5", false, Documentation="VertexBufferObject")]
    public class T08_VBO : GameWindow
    {
        #region --- Private Fields ---

        Shapes.Shape cube = new Examples.Shapes.Cube();

        struct Vbo
        {
            public int VboID, EboID, NumElements;
        }
        Vbo[] vbo = new Vbo[2];

        public static readonly int order = 8;

        #endregion

        #region --- Constructor ---

        public T08_VBO() : base(800, 600) { }

        #endregion

        #region OnLoad override

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!GL.SupportsExtension("VERSION_1_5"))
            {
                System.Windows.Forms.MessageBox.Show("You need at least OpenGL 1.5 to run this example. Aborting.", "VBOs not supported",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                this.Exit();
            }

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(EnableCap.DepthTest);

            // Create the Vertex Buffer Object:
            // 1) Generate the buffer handles.
            // 2) Bind the Vertex Buffer and upload your vertex buffer. Check that the buffer was uploaded correctly.
            // 3) Bind the Index Buffer and upload your index buffer. Check that the buffer was uploaded correctly.

            vbo[0] = LoadVBO(cube.Vertices, cube.Indices);
            vbo[1] = LoadVBO(cube.Vertices, cube.Indices);
        }

        #endregion

        #region OnResize override

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            double ratio = Width / (double)Height;

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region OnUpdateFrame override

        /// <summary>
        /// Prepares the next frame for rendering.
        /// </summary>
        /// <remarks>
        /// Place your control logic here. This is the place to respond to user input,
        /// update object positions etc.
        /// </remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Glu.LookAt(0.0, 5.0, 5.0,
                       0.0, 0.0, 0.0,
                       0.0, 1.0, 0.0);

            GL.Color4(System.Drawing.Color.Black);
            Draw(vbo[0]);

            SwapBuffers();
        }

        #endregion

        Vbo LoadVBO(Vector3[] vertices, int[] indices)
        {
            Vbo handle = new Vbo();
            int size;

            GL.GenBuffers(1, out handle.VboID);
            GL.BindBuffer(BufferTarget.ArrayBuffer, handle.VboID);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(vertices.Length * Vector3.SizeInBytes), vertices,
                          BufferUsageHint.StaticDraw);
            GL.GetBufferParameter(BufferTarget.ArrayBuffer, BufferParameterName.BufferSize, out size);
            if (vertices.Length * Vector3.SizeInBytes != size)
                throw new ApplicationException("Vertex array not uploaded correctly");
            //GL.BindBuffer(Version15.ArrayBuffer, 0);

            GL.GenBuffers(1, out handle.EboID);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, handle.EboID);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(indices.Length * sizeof(int)), indices,
                          BufferUsageHint.StaticDraw);
            GL.GetBufferParameter(BufferTarget.ElementArrayBuffer, BufferParameterName.BufferSize, out size);
            if (indices.Length * sizeof(int) != size)
                throw new ApplicationException("Element array not uploaded correctly");
            //GL.BindBuffer(Version15.ElementArrayBuffer, 0);

            handle.NumElements = indices.Length;
            return handle;
        }

        void Draw(Vbo handle)
        {
            //GL.PushClientAttrib(ClientAttribMask.ClientVertexArrayBit);

            //GL.EnableClientState(EnableCap.TextureCoordArray);
            GL.EnableClientState(EnableCap.VertexArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, handle.VboID);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, handle.EboID);

            //GL.TexCoordPointer(2, TexCoordPointerType.Float, vector2_size, (IntPtr)vector2_size);
            GL.VertexPointer(3, VertexPointerType.Float, Vector3.SizeInBytes, IntPtr.Zero);

            GL.DrawElements(BeginMode.Triangles, handle.NumElements, DrawElementsType.UnsignedInt, IntPtr.Zero);
            //GL.DrawArrays(BeginMode.LineLoop, 0, vbo.element_count);

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);

            GL.DisableClientState(EnableCap.VertexArray);
            //GL.DisableClientState(EnableCap.TextureCoordArray);

            //GL.PopClientAttrib();
        }

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (T08_VBO example = new T08_VBO())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}
