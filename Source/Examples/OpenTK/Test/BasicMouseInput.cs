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

        public BasicMouseInput()
            : base(800, 600)
        { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
          
            this.Mouse.ButtonUp += (object sender, MouseButtonEventArgs buttonEvent) => {
                Console.WriteLine("Mouse button up: " + buttonEvent.Button + " at: " + buttonEvent.Position);
            };

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            // Here's the big test!
            if(OpenTK.Input.Mouse.GetState()[MouseButton.Left]){
                Console.WriteLine("The left mouse button is down!");
            }

         
            // While we are here, test keyboard.
            if(OpenTK.Input.Keyboard.GetState()[Key.A]){
               Console.WriteLine("The A key is down!");
            }

            if (Keyboard[OpenTK.Input.Key.Escape])
                this.Exit();

            if (Keyboard[OpenTK.Input.Key.F11])
                if (WindowState != WindowState.Fullscreen)
                    WindowState = WindowState.Fullscreen;
                else
                    WindowState = WindowState.Normal;
        }

     
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            SwapBuffers();
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
