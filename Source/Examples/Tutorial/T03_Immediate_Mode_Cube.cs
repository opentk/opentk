#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

using OpenTK;
using OpenTK.OpenGL;
using OpenTK.Platform;

#endregion

namespace Examples.Tutorial
{
    public class T03_Immediate_Mode_Cube : OpenTK.GameWindow, IExample
    {
        #region --- Fields ---

        /// <summary>
        /// Denotes the cube rotation.
        /// </summary>
        float angle = 0.0f;

        #endregion

        #region --- Constructors ---

        public T03_Immediate_Mode_Cube()
        {
            CreateWindow(new DisplayMode(800, 600));
        }

        #endregion

        #region OnLoad

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Called when the user resizes the window.
        /// </summary>
        /// <param name="e">Contains the new width/height of the window.</param>
        /// <remarks>
        /// You want the OpenGL viewport to match the window. This is the place to do it!
        /// </remarks>
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

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
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[0][OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }

            if ((Keyboard[0][OpenTK.Input.Key.AltLeft] || Keyboard[0][OpenTK.Input.Key.AltRight]) &&
                Keyboard[0][OpenTK.Input.Key.Enter])
            {
                Fullscreen = !Fullscreen;
            }

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );

            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            Context.SwapBuffers();
            Thread.Sleep(0);
        }

        #endregion

        #region private void DrawCube()

        private void DrawCube()
        {
            GL.Begin(GL.Enums.BeginMode.QUADS);

            GL.Color3(Color.Silver);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);

            GL.Color3(Color.Honeydew);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);

            GL.Color3(Color.Moccasin);

            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);

            GL.Color3(Color.IndianRed);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);

            GL.Color3(Color.PaleVioletRed);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);

            GL.Color3(Color.ForestGreen);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);

            GL.End();
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
            Run();
        }

        #endregion
    }
}
