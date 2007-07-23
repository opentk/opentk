#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;
using Enums = OpenTK.OpenGL.Enums;
using OpenTK;
using OpenTK.Input;

#endregion --- Using Directives ---

namespace Examples.Tutorial
{
    public partial class T07_DisplayLists_Cube : GameWindow, IExample
    {
        #region --- Variables ---

        List<DisplayList> lists = new List<DisplayList>();

        #endregion --- Variables ---

        #region --- Constructors ---

        public T07_DisplayLists_Cube()
        {
            //Text =
            //    "DisplayLists example (" +
            //    GL.GetString(Enums.StringName.RENDERER) + " " +
            //    GL.GetString(Enums.StringName.VERSION)
            //    + ")";

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            // Build some display lists.
            float c = 0;
            const int numDisplayLists = 9;
            for (int i = numDisplayLists; i > 0; i--)
            {
                DisplayList d = new DisplayList();

                d.Begin();

                GL.Color3d(
                    1.0,
                    c,
                    1 - c
                );

                GL.Begin(Enums.BeginMode.QUADS);

                GL.Vertex3f(-1.0f, -1.0f, 1.0f);
                GL.Vertex3f( 1.0f, -1.0f, 1.0f);
                GL.Vertex3f( 1.0f,  1.0f, 1.0f);
                GL.Vertex3f(-1.0f,  1.0f, 1.0f);

                GL.End();

                d.End();

                lists.Add(d);

                c += 1 / (float)numDisplayLists;
            }

            OnResize(new OpenTK.Platform.ResizeEventArgs(this.Width, this.Height));
        }

        #endregion

        #region static public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        static public void Launch()
        {
            using (T03_RotatingCube ex = new T03_RotatingCube())
            {
                ex.Run();
            }
        }

        #endregion

        #region --- Event Handlers ---

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, this.Width, this.Height);

            double ratio = 0.0;
            ratio = this.Width / (double)this.Height;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
            Glu.LookAt(
                0.0, 0.0, 16.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
        }

        #endregion

        #region RenderFrame

        public override void RenderFrame()
        {
            base.RenderFrame();

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            double angle = 0.0;
            foreach (DisplayList d in lists)
            {
                GL.LoadIdentity();
                GL.Rotated(angle, 0.0, 0.0, 1.0);
                GL.Translated(5.0, 0.0, 0.0);

                d.Render();
                angle += 360 / lists.Count;
            }


            Context.SwapBuffers();
        }

        #endregion

        #region UpdateFrame

        public override void UpdateFrame()
        {
	        base.UpdateFrame();

            if (Key.Escape)
            {
                this.Quit = true;
            }
        }

        #endregion

        #endregion --- Event Handlers ---
    }
}