﻿// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates the MouseCursor class.
    /// </summary>
    [Example("MouseCursor Simple", ExampleCategory.OpenTK, "GameWindow", 1, Documentation = "MouseCursorSimple")]
    public class MouseCursorSimple : GameWindow
    {
        public MouseCursorSimple()
            : base(800, 600)
        {
            Keyboard.KeyDown += Keyboard_KeyDown;

            Bitmap bitmap = new Bitmap("Data/Textures/cursor.png");

            var rgba = new byte[bitmap.Width * bitmap.Height * 4];
            var data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height), 
                System.Drawing.Imaging.ImageLockMode.ReadOnly, 
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int y = 0; y < bitmap.Height; ++y)
            {
                var offset = new IntPtr(data.Scan0.ToInt64() + (data.Stride * y));
                var stride = bitmap.Width * 4;
                System.Runtime.InteropServices.Marshal.Copy(
                    offset, rgba, y * stride, stride);
            }
            
            //this.Cursor = new OpenTK.MouseCursor(rgba, bitmap.Width, bitmap.Height, 0, 0);
            this.Cursor = MouseCursor.Default;
        }

        #region Keyboard_KeyDown

        /// <summary>
        /// Occurs when a key is pressed.
        /// </summary>
        /// <param name="sender">The KeyboardDevice which generated this event.</param>
        /// <param name="e">The key that was pressed.</param>
        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Exit();
            }

            if (e.Key == Key.Enter && e.Alt)
            {
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
            }

            if (e.Key == Key.Space)
            {
                if (Cursor == MouseCursor.Default)
                {
                    Cursor = MouseCursor.Empty;
                }
                else
                {
                    Cursor = MouseCursor.Default;
                }
            }
        }

        #endregion

        #region OnLoad

        /// <summary>
        /// Setup OpenGL and load resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
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
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Add your game logic here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // Nothing to do!
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Add your game rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(Color.MidnightBlue);
            GL.Vertex2(-1.0f, 1.0f);
            GL.Color3(Color.SpringGreen);
            GL.Vertex2(0.0f, -1.0f);
            GL.Color3(Color.Ivory);
            GL.Vertex2(1.0f, 1.0f);

            GL.End();

            this.SwapBuffers();
        }

        #endregion
        
        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (MouseCursorSimple example = new MouseCursorSimple())
            {
                // Get the title and category  of this example using reflection.
                Utilities.SetWindowTitle(example);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}
