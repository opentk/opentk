#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates how to decouple rendering from the main thread.
    /// Note that all OpenGL function calls should take place at the rendering thread -
    /// OpenGL will not be available on the main thread at all!
    /// </summary>
    [Example("Threaded Rendering", ExampleCategory.OpenTK, "GameWindow", Documentation = "ThreadedRendering")]
    public class ThreadedRendering : GameWindow
    {
        bool viewport_changed = true;
        int viewport_width, viewport_height;
        bool exit = false;
        Thread rendering_thread;
        object update_lock = new object();
        const float rotation_speed = 180.0f;
        float angle;
        float aspect_ratio;

        readonly VertexPositionColor[] CubeVertices = new VertexPositionColor[]
        {
                new VertexPositionColor(-1.0f, -1.0f,  1.0f, Color.DarkRed),
                new VertexPositionColor( 1.0f, -1.0f,  1.0f, Color.DarkRed),
                new VertexPositionColor( 1.0f,  1.0f,  1.0f, Color.Gold),
                new VertexPositionColor(-1.0f,  1.0f,  1.0f, Color.Gold),
                new VertexPositionColor(-1.0f, -1.0f, -1.0f, Color.DarkRed),
                new VertexPositionColor( 1.0f, -1.0f, -1.0f, Color.DarkRed), 
                new VertexPositionColor( 1.0f,  1.0f, -1.0f, Color.Gold),
                new VertexPositionColor(-1.0f,  1.0f, -1.0f, Color.Gold) 
        };

        readonly short[] CubeElements = new short[]
        {
            0, 1, 2, 2, 3, 0, // front face
            3, 2, 6, 6, 7, 3, // top face
            7, 6, 5, 5, 4, 7, // back face
            4, 0, 3, 3, 7, 4, // left face
            0, 1, 5, 5, 4, 0, // bottom face
            1, 5, 6, 6, 2, 1, // right face
        };

        public ThreadedRendering()
            : base(800, 600)
        {
            Keyboard.KeyDown += Keyboard_KeyDown;
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
                this.Exit();

            if (e.Key == Key.F11)
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
        }

        #endregion

        #region OnLoad

        /// <summary>
        /// Setup OpenGL and load resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            Context.MakeCurrent(null); // Release the OpenGL context so it can be used on the new thread.

            rendering_thread = new Thread(RenderLoop);
            rendering_thread.IsBackground = true;
            rendering_thread.Start();
        }

        #endregion

        #region OnUnload

        /// <summary>
        /// Release resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnUnload(EventArgs e)
        {
            exit = true; // Set a flag that the rendering thread should stop running.
            rendering_thread.Join();

            base.OnUnload(e);
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
            // Note that we cannot call any OpenGL methods directly. What we can do is set
            // a flag and respond to it from the rendering thread.
            lock (update_lock)
            {
                viewport_changed = true;
                viewport_width = Width;
                viewport_height = Height;
            }
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
        /// Ignored. All rendering is performed on our own rendering function.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
        }

        #endregion

        #region RenderLoop

        void RenderLoop()
        {
            MakeCurrent(); // The context now belongs to this thread. No other thread may use it!

            VSync = VSyncMode.On;

            // Since we don't use OpenTK's timing mechanism, we need to keep time ourselves;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);

            while (!exit)
            {
                Render(watch.Elapsed.TotalSeconds);

                watch.Reset(); //  Stopwatch may be inaccurate over larger intervals.
                watch.Start(); // Plus, timekeeping is easier if we always start counting from 0.

                SwapBuffers();
            }
        }

        #endregion

        #region Render

        /// <summary>
        /// This is our main rendering function, which executes on the rendering thread.
        /// </summary>
        public void Render(double time)
        {
            lock (update_lock)
            {
                if (viewport_changed)
                {
                    GL.Viewport(0, 0, viewport_width, viewport_height);
                    aspect_ratio = viewport_width / (float)viewport_height;
                    viewport_changed = false;
                }
            }

            Matrix4 perspective =
                Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            angle += rotation_speed * (float)time;
            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

            GL.Begin(BeginMode.Triangles);
            for (int i = 0; i < CubeElements.Length; i++)
            {
                int element = CubeElements[i];
                uint color = CubeVertices[element].Color;
                GL.Color4((byte)(color), (byte)(color >> 8), (byte)(color >> 16), (byte)(color >> 24));
                GL.Vertex3(CubeVertices[element].Position);
            }
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
            using (GameWindow example = new ThreadedRendering())
            {
                // Get the title and category  of this example using reflection.
                Utilities.SetWindowTitle(example);
                example.Run(30.0, 0.0);
            }
        }

        #endregion
    }
}
