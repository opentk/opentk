// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

#region Using Directives

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;

#endregion

namespace Examples.Tutorial
{
    [Example("Simple ES 2.0", ExampleCategory.OpenGLES, "2.0", Documentation = "SimpleES20Window")]
    public class SimpleES20Window : GameWindow
    {
        #region Constructor

        public SimpleES20Window(GraphicsContextFlags flags)
            : base(800, 600, GraphicsMode.Default, "", GameWindowFlags.Default, DisplayDevice.Default, 2, 0, flags)
        { }

        #endregion

        #region OnLoad

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Color4 color = Color4.MidnightBlue;
            GL.ClearColor(color.R, color.G, color.B, color.A);
            GL.Enable(EnableCap.DepthTest);
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
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
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
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            this.SwapBuffers();
        }

        #endregion

        #region private void DrawCube()

        private void DrawCube()
        {
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            SimpleES20Window example;
            try
            {
                example = new SimpleES20Window(GraphicsContextFlags.Embedded);
            }
            catch
            {
                example = new SimpleES20Window(GraphicsContextFlags.Default);
            }

            if (example != null)
            {
                using (example)
                {
                    Utilities.SetWindowTitle(example);
                    example.Run(30.0, 0.0);
                }
            }
        }

        #endregion
    }
}
