#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using OpenTK;
using OpenTK.Graphics;

namespace Examples.Tests
{
    [Example("GameWindow states.", ExampleCategory.Test)]
    public class GameWindowStates : GameWindow
    {
        public GameWindowStates()
            : base(800, 600)
        {
            this.VSync = VSyncMode.On;
            this.Keyboard.KeyRepeat = true;
            this.Keyboard.KeyUp += new OpenTK.Input.KeyUpEvent(Keyboard_KeyUp);

            GL.ClearColor(System.Drawing.Color.SteelBlue);
        }

        void Keyboard_KeyUp(OpenTK.Input.KeyboardDevice sender, OpenTK.Input.Key key)
        {
            if (key == OpenTK.Input.Key.Escape)
                this.Exit();

            if (key == OpenTK.Input.Key.Space)
            {
                switch (this.WindowState)
                {
                    case WindowState.Normal: this.WindowState = WindowState.Maximized; break;
                    case WindowState.Maximized: this.WindowState = WindowState.Minimized; break;
                    case WindowState.Minimized: this.WindowState = WindowState.Fullscreen; break;
                    case WindowState.Fullscreen: this.WindowState = WindowState.Normal; break;
                }
            }
        }

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            SwapBuffers();
        }

        public static void Main()
        {
            using (GameWindowStates ex = new GameWindowStates())
            {
                Utilities.SetWindowTitle(ex);
                ex.Run(20.0);
            }
        }
    }
}
