#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

using OpenTK;
using OpenTK.OpenGL;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates the GameWindow class.
    /// </summary>
    public class T01_Simple_Window : GameWindow, IExample
    {
        public T01_Simple_Window() : base(new DisplayMode(800, 600), "OpenTK | Tutorial 1: Simple Window")
        {
        }

        #region OnLoad

        /// <summary>
        /// Setup OpenGL and load resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        public override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Respond to resize events here.
        /// </summary>
        /// <param name="e">Contains information on the new GameWindow size.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width, e.Height);

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);

            base.OnResize(e);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Add your game logic here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[OpenTK.Input.Key.Escape])
                this.Exit();
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Add your game rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.Begin(GL.Enums.BeginMode.TRIANGLES);

            GL.Color3(Color.SpringGreen);
            GL.Vertex2(-1.0f, 1.0f);
            GL.Color3(Color.SteelBlue);
            GL.Vertex2(0.0f, -1.0f);
            GL.Color3(Color.PeachPuff);
            GL.Vertex2(1.0f, 1.0f);

            GL.End();

            this.SwapBuffers();
        }

        #endregion

        #region IExample Members

        /// <summary>
        /// Only used by the ExampleLauncher application, no need to add a Launch() method in your code.
        /// Add a call to Run() in your Main() function instead.
        /// </summary>
        public void Launch()
        {
            this.Run(30.0, 5.0);
        }

        public static readonly int order = 1;

        #endregion
    }
}
