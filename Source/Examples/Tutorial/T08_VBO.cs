#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;
using OpenTK.OpenGL;
using OpenTK.Platform;
using System.Threading;
using OpenTK.OpenGL.Enums;

#endregion

namespace Examples.Tutorial
{
    public class T08_VBO : GameWindow, IExample
    {
        #region --- Private Fields ---

        Shapes.Shape shape = new Examples.Shapes.Cube();
            //new Examples.Shapes.Plane(16, 16, 2.0f, 2.0f);
        
        int handle_vertex_buffer, ibo, nbo; // vertex, index and normal buffer objects.
        float angle;

        #endregion

        #region --- Constructor ---

        public T08_VBO() : base(new DisplayMode(800, 600), "OpenTK Tutorial 08: Vertex Buffer Objects") { }

        #endregion

        #region OnLoad override

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!GL.SupportsExtension("VERSION_1_4"))
            {
                System.Windows.Forms.MessageBox.Show("You need at least OpenGL 1.4 to run this example. Aborting.", "VBOs not supported",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                this.Exit();
            }

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
            GL.EnableClientState(EnableCap.VertexArray);
            //GL.EnableClientState(GL.Enums.EnableCap.INDEX_ARRAY);

            // Create the Vertex Buffer Object:
            // 1) Generate the buffer handles.
            // 2) Bind the Vertex Buffer and upload your vertex data. Check that the data was uploaded correctly.
            // 3) Bind the Index Buffer and upload your index data. Check that the data was uploaded correctly.

            int size; // To check whether the buffers were uploaded correctly.
            
            // Generate handles.
            GL.GenBuffers(1, out handle_vertex_buffer);
            //GL.GenBuffers(1, out ibo);

            // Upload the vertex data.
            GL.BindBuffer(Version15.ArrayBuffer, handle_vertex_buffer);
            GL.BufferData(Version15.ArrayBuffer, (IntPtr)shape.Vertices.Length, shape.Vertices, Version15.StaticDraw);
            GL.VertexPointer(3, VertexPointerType.Float, 0, IntPtr.Zero);
            GL.GetBufferParameter(Version15.ArrayBuffer, Version15.BufferSize, out size);
            if (shape.Vertices.Length != size)
                throw new ApplicationException("Vertex array not uploaded correctly");
            /*
            // Upload the index data.
            GL.BindBuffer(GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, ibo);
            GL.BufferData(GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, (IntPtr)shape.Indices.Length, shape.Indices, GL.Enums.VERSION_1_5.STATIC_DRAW);
            GL.GetBufferParameter(GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, GL.Enums.VERSION_1_5.BUFFER_SIZE, out size);
            if (shape.Indices.Length != size)
                throw new ApplicationException("Index array not uploaded correctly");
            */
        }

        #endregion

        #region OnResize override

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            double ratio = e.Width / (double)e.Height;

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
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.DrawElements(BeginMode.Triangles, shape.Indices.Length,
                All.UnsignedInt, shape.Indices);

            Context.SwapBuffers();
        }

        #endregion

        #region public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public void Launch()
        {
            Run(60.0, 60.0);
        }

        #endregion

        public static readonly int order = 8;
    }
}
