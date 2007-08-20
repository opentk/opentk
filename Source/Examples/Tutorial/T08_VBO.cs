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

#endregion

namespace Examples.Tutorial
{
    public class T08_VBO : OpenTK.GameWindow /*, IExample */
    {
        #region --- Private Fields ---

        int vbo, ibo, nbo; // vertex, index and normal buffer objects.
        float angle;

        // Cube vertices
        float[] vdata =
            {
                 -1.0f, -1.0f,  1.0f ,
                  1.0f, -1.0f,  1.0f ,
                  1.0f,  1.0f,  1.0f ,
                 -1.0f,  1.0f,  1.0f ,
                 -1.0f, -1.0f, -1.0f ,
                  1.0f, -1.0f, -1.0f ,
                  1.0f,  1.0f, -1.0f ,
                 -1.0f,  1.0f, -1.0f ,
            };

        // Cube normals
        float[,] ndata =
            {
                { 1.0f, 0.0f, 0.0f },
                { 0.0f, 1.0f, 0.0f },                
                { 0.0f, 0.0f, 1.0f },
                { -1.0f, 0.0f, 0.0f },
                { 0.0f, -1.0f, 0.0f },                
                { 0.0f, 0.0f, -1.0f },
            };

        // Indices
        ushort[] idata =
            {
                // front face
                0, 1, 2, 3,
                // top face
                3, 4, 6, 7,
                // back face
                7, 6, 5, 4,
                // left face
                4, 0, 3, 7,
                // bottom face
                0, 1, 5, 4,
                // right face
                1, 5, 6, 2,
            };

        #endregion

        #region --- Constructor ---

        public T08_VBO()
        {
            this.CreateWindow(new DisplayMode(800, 600));
        }

        #endregion

        #region OnLoad

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
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);
            GL.EnableClientState(GL.Enums.EnableCap.VERTEX_ARRAY);
            GL.EnableClientState(GL.Enums.EnableCap.INDEX_ARRAY);

            LoadCube();

            this.OnResize(new ResizeEventArgs(this.Width, this.Height));
        }

        #endregion

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, e.Width, e.Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Prepares the next frame for rendering.
        /// </summary>
        /// <remarks>
        /// Place your control logic here. This is the place to respond to user input,
        /// update object positions etc.
        /// </remarks>
        public override void OnUpdateFrame(EventArgs e)
        {
            if (Keyboard[0][OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );

            //GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            //angle += 0.5f;
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(EventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(
                GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT |
                GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            GL.BindBuffer(GL.Enums.VERSION_1_5.ARRAY_BUFFER, vbo);
            GL.VertexPointer(3, GL.Enums.VertexPointerType.FLOAT, 0, 0);

            GL.BindBuffer(GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, ibo);
            GL.IndexPointer(GL.Enums.IndexPointerType.FLOAT, 0, 0);

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.DrawElements(
                GL.Enums.BeginMode.QUADS,
                idata.Length,
                GL.Enums.All.UNSIGNED_SHORT,
                idata);

            GL.BindBuffer(GL.Enums.VERSION_1_5.ARRAY_BUFFER, 0);
            GL.BindBuffer(GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, 0);

            Context.SwapBuffers();
            Thread.Sleep(0);
        }

        #endregion

        #region LoadCube

        private void LoadCube()
        {
            int size; // To check whether the buffers were uploaded correctly.
            
            // First, generate the buffer objects
            GL.GenBuffers(1, out vbo);
            GL.GenBuffers(1, out ibo);

            // Upload the vertex data
            GL.BindBuffer(GL.Enums.VERSION_1_5.ARRAY_BUFFER, vbo);
            GL.BufferData(
                GL.Enums.VERSION_1_5.ARRAY_BUFFER,
                (IntPtr)(vdata.Length * 4),
                vdata,
                GL.Enums.VERSION_1_5.STATIC_DRAW);
            GL.GetBufferParameterv(
                GL.Enums.VERSION_1_5.ARRAY_BUFFER,
                GL.Enums.VERSION_1_5.BUFFER_SIZE,
                out size);
            if (vdata.Length * 4 != size)
            {
                throw new ApplicationException("Vertex array not uploaded correctly");
            }

            // Upload the index data
            GL.BindBuffer(GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER, ibo);
            GL.BufferData(
                GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER,
                (IntPtr)(idata.Length * 2),
                idata,
                GL.Enums.VERSION_1_5.STATIC_DRAW
            );
            GL.GetBufferParameterv(
                GL.Enums.VERSION_1_5.ELEMENT_ARRAY_BUFFER,
                GL.Enums.VERSION_1_5.BUFFER_SIZE,
                out size);
            if (idata.Length * 2 != size)
            {
                throw new ApplicationException("Index array not uploaded correctly");
            }
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
            //using (T08_VBO ex = new T08_VBO())
            {
                //ex.Run();
                Run();
            }
        }

        #endregion
    }
}
