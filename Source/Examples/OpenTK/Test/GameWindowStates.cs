#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tests
{
    [Example("GameWindow states", ExampleCategory.OpenTK, "Test", Documentation="GameWindowStates")]
    public class GameWindowStates : GameWindow
    {
        Font font = new Font(FontFamily.GenericSansSerif, 16.0f);
        TextPrinter printer = new TextPrinter();
        
        public GameWindowStates()
            : base(800, 600)
        {
            this.VSync = VSyncMode.On;
            this.Keyboard.KeyRepeat = true;
            this.Keyboard.KeyUp += new OpenTK.Input.KeyUpEvent(Keyboard_KeyUp);

            GL.ClearColor(System.Drawing.Color.MidnightBlue);
        }

        void Keyboard_KeyUp(KeyboardDevice sender, Key key)
        {
            switch (key)
            {
                case OpenTK.Input.Key.Escape:
                    this.Exit();
                    break;

                case Key.Number1:
                    WindowState = WindowState.Normal;
                    break;
                case Key.Number2:
                    WindowState = WindowState.Maximized;
                    break;
                case Key.Number3:
                    WindowState = WindowState.Fullscreen;
                    break;
                case Key.Number4:
                    WindowState = WindowState.Minimized;
                    break;

                case Key.Number5:
                    WindowBorder = WindowBorder.Resizable;
                    break;
                case Key.Number6:
                    WindowBorder = WindowBorder.Fixed;
                    break;
                case Key.Number7:
                    WindowBorder = WindowBorder.Hidden;
                    break;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            printer.Begin();

            printer.Print("Instructions:", font, Color.White);
            GL.Translate(0, font.Height, 0);
            printer.Print(String.Format("[1 - 4]: change WindowState (current: {0}).", this.WindowState), font, Color.White, RectangleF.Empty);
            GL.Translate(0, font.Height, 0);
            printer.Print(String.Format("[5 - 7]: change WindowBorder (current: {0}).", this.WindowBorder), font, Color.White, RectangleF.Empty);

            printer.End();

            SwapBuffers();
            Thread.Sleep(5);
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
