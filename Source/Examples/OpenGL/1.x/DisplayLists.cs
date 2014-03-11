﻿// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using OpenTK;
using OpenTK.Graphics.OpenGL;

#endregion --- Using Directives ---

namespace Examples.Tutorial
{
    [Example("Display Lists", ExampleCategory.OpenGL, "1.x", 2, Documentation = "DisplayLists")]
    public class T07_Display_Lists_Flower : GameWindow
    {
        #region --- Fields ---

        const int num_lists = 13;
        int[] lists = new int[num_lists];

        #endregion

        #region --- Constructor ---

        public T07_Display_Lists_Flower()
            : base(800, 600)
        {
        }

        #endregion

        #region OnLoad

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            // Build some display lists.
            int first_list = GL.GenLists(num_lists);
            float c = 0;
            for (int i = 0; i < num_lists; i++)
            {
                lists[i] = first_list + i;
                GL.NewList(first_list + i, ListMode.Compile);

                GL.Color3(0.3 + 0.7 * c * c, 0.3 + 1.4 * c * c, 0.7 - 0.7 * c * c);
                c += 1 / (float)num_lists;

                GL.PushMatrix();

                GL.Rotate(c * 360.0f, 0.0, 0.0, 1.0);
                GL.Translate(5.0, 0.0, 0.0);

                GL.Begin(PrimitiveType.Quads);

                GL.Vertex3(-1.0f, -1.0f, 1.0f);
                GL.Vertex3(1.0f, -1.0f, 1.0f);
                GL.Vertex3(1.0f, 1.0f, 1.0f);
                GL.Vertex3(-1.0f, 1.0f, 1.0f);

                GL.End();

                GL.PopMatrix();

                GL.EndList();
            }
        }

        #endregion

        #region OnUnload

        protected override void OnUnload(EventArgs e)
        {
            GL.DeleteLists(lists[0], num_lists);
        }

        #endregion

        #region OnResize

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(ClientRectangle);

            float aspect = this.ClientSize.Width / (float)this.ClientSize.Height;

            Matrix4 projection_matrix;
            Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, aspect, 1, 64, out projection_matrix);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection_matrix);
        }

        #endregion

        #region OnUpdateFrame

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
            }
        }

        #endregion

        #region OnRenderFrame

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            Matrix4 lookat = Matrix4.LookAt(0, 0, 16, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.CallLists(num_lists, ListNameType.Int, lists);

            SwapBuffers();
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (T07_Display_Lists_Flower example = new T07_Display_Lists_Flower())
            {
                Utilities.SetWindowTitle(example);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}