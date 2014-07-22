// This code was written for the OpenTK library and has been released
// to the Public Domain by Andy Korth
// It is provided "as is" without express or implied warranty of any kind.

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Drawing;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

#endregion --- Using Directives ---

namespace Examples.Tests
{
    /// <summary>
    /// Demonstrates basic recommended mouse input, and to see if it actually works
    /// </summary>
    [Example("Basic Mouse Input", ExampleCategory.OpenTK,"Basic Mouse Input")]
    public class BasicMouseInput : GameWindow
    {
        List<Vector2> lines = new List<Vector2>();

        public BasicMouseInput()
            : base(800, 600)
        {
            MouseMove += (sender, e) =>
            {
                if (e.Mouse[MouseButton.Left])
                {
                    // Scale mouse coordinates from
                    // (0, 0):(Width, Height) to
                    // (-1, -1):(+1, +1)
                    // Note, we must flip the y-coordinate
                    // since mouse is reported with (0, 0)
                    // at top-left and our projection uses
                    // (-1, -1) at bottom left.
                    float x = (e.X - Width) / (float)Width;
                    float y = (Height- e.Y) / (float)Height;
                    lines.Add(new Vector2(2 * x + 1, 2 * y - 1));
                }
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            MouseUp += (object sender, MouseButtonEventArgs buttonEvent) => {
                Console.WriteLine("Mouse button up: " + buttonEvent.Button + " at: " + buttonEvent.Position);
            };
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            // Here's the big test!
            if(OpenTK.Input.Mouse.GetState()[MouseButton.Left]){
                Console.WriteLine("The left mouse button is down!");
            }

            // While we are here, test keyboard.
            if(OpenTK.Input.Keyboard.GetState()[Key.A]){
               Console.WriteLine("The A key is down!");
            }

            var keyboard = OpenTK.Input.Keyboard.GetState();

            if (keyboard[OpenTK.Input.Key.Escape])
                this.Exit();

            if (keyboard[OpenTK.Input.Key.F11])
                if (WindowState != WindowState.Fullscreen)
                    WindowState = WindowState.Fullscreen;
                else
                    WindowState = WindowState.Normal;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Viewport(ClientRectangle);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1, 1, -1, 1, -1, 1);

            GL.Begin(PrimitiveType.LineStrip);
            foreach (var p in lines)
            {
                GL.Color4(Color.White);
                GL.Vertex2(p);
            }
            GL.End();

            SwapBuffers();

            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[Key.Space])
            {
                // Simulate high load (4 fps) to check
                // mouse input behavior
                System.Threading.Thread.Sleep(250);
            }
        }

        [STAThread]
        public static void Main()
        {
            using (BasicMouseInput example = new BasicMouseInput())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);

                example.Run(30.0);
            }
        }

    }
}
