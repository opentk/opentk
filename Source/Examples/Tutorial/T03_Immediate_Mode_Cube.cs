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
using OpenTK.OpenGL.Enums;
using OpenTK.Platform;

#endregion

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates immediate mode rendering. Example is incomplete, and will probably go away in the future.
    /// </summary>
    [Example("Immediate mode", ExampleCategory.Tutorial, 2)]
    public class T03_Immediate_Mode_Cube : GameWindow
    {
        #region --- Fields ---

        float rotation_speed = 3.0f;
        float angle;

        #endregion

        #region --- Constructor ---

        public T03_Immediate_Mode_Cube() : base(new DisplayMode(800, 600))
		{ } 

		#endregion	
		
        #region OnLoad

        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.SteelBlue);
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
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(MatrixMode.Projection);
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
            if (Keyboard[OpenTK.Input.Key.Escape])
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
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Glu.LookAt(0.0, 5.0, 5.0,
                       0.0, 0.0, 0.0,
                       0.0, 1.0, 0.0);
            
            angle += rotation_speed * (float)e.ScaleFactor;
            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

            DrawCube();

            this.SwapBuffers();
        }

        #endregion

        #region private void DrawCube()

        private void DrawCube()
        {
            GL.Begin(BeginMode.Quads);

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

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (T03_Immediate_Mode_Cube example = new T03_Immediate_Mode_Cube())
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
