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
using Enums = OpenTK.OpenGL.GL.Enums;
using OpenTK;
using System.Threading;

#endregion --- Using Directives ---

namespace Examples.Tutorial
{
    public partial class T07_Display_Lists_Flower : GameWindow, IExample
    {
        #region --- Variables ---

        List<DisplayList> lists = new List<DisplayList>();

        #endregion --- Variables ---

        #region --- Constructors ---

        public T07_Display_Lists_Flower()
        {
            this.CreateWindow(new DisplayMode(800, 600));
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

                GL.Color3(
                    1.0,
                    c,
                    1 - c
                );

                GL.Begin(Enums.BeginMode.QUADS);

                GL.Vertex3(-1.0f, -1.0f, 1.0f);
                GL.Vertex3( 1.0f, -1.0f, 1.0f);
                GL.Vertex3( 1.0f,  1.0f, 1.0f);
                GL.Vertex3(-1.0f,  1.0f, 1.0f);

                GL.End();

                d.End();

                lists.Add(d);

                c += 1 / (float)numDisplayLists;
            }

            OnResize(new OpenTK.Platform.ResizeEventArgs(this.Width, this.Height));
        }

        #endregion         

        #region --- Event Handlers ---

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

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

        #region OnUpdateFrame

        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
            }
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            double angle = 0.0;
            foreach (DisplayList d in lists)
            {
                GL.LoadIdentity();
                GL.Rotate(angle, 0.0, 0.0, 1.0);
                GL.Translate(5.0, 0.0, 0.0);

                d.Render();
                angle += 360 / lists.Count;
            }


            Context.SwapBuffers();
            Thread.Sleep(0);
        }

        #endregion

        #endregion --- Event Handlers ---

        #region public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public void Launch()
        {
            this.Run(30.0, 5.0);
        }

        #endregion
    }
}