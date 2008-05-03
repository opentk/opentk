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
using OpenTK.Input;

namespace Examples.Tests
{
    [Example("GameWindow states.", ExampleCategory.Test)]
    public class GameWindowStates : GameWindow
    {
        TextureFont font = new TextureFont(new Font(FontFamily.GenericSansSerif, 16.0f));
        TextPrinter printer = new TextPrinter();
        
        WindowState[] window_state_sequence = new WindowState[]
        {
            WindowState.Normal,
            WindowState.Maximized,
            WindowState.Fullscreen,
            WindowState.Minimized
        };

        WindowBorder[] window_border_sequence = new WindowBorder[]
        {
            WindowBorder.Resizable,
            WindowBorder.Fixed,
            WindowBorder.Hidden,
        };
        
        int window_state_counter = 0;
        int WindowStateCounter
        {
            get { return window_state_counter; }
            set
            {
                if (value < 0)
                    window_state_counter = window_state_sequence.Length - 1;
                else
                    window_state_counter = ++window_state_counter % window_state_sequence.Length;
            }
        }
        
        int window_border_counter = 0;
        int WindowBorderCounter
        {
            get { return window_border_counter; }
            set
            {
                if (value < 0)
                    window_border_counter = window_border_sequence.Length - 1;
                else
                    window_border_counter = ++window_border_counter % window_border_sequence.Length;
            }
        }
        


        public GameWindowStates()
            : base(800, 600)
        {
            this.VSync = VSyncMode.On;
            this.Keyboard.KeyRepeat = true;
            this.Keyboard.KeyUp += new OpenTK.Input.KeyUpEvent(Keyboard_KeyUp);

            GL.ClearColor(System.Drawing.Color.SteelBlue);
        }

        void Keyboard_KeyUp(KeyboardDevice sender, Key key)
        {
            switch (key)
            {
                case OpenTK.Input.Key.Escape:
                    this.Exit();
                    break;

                case OpenTK.Input.Key.Number1:
                    if (sender[Key.ShiftLeft] || sender[Key.ShiftRight])
                        WindowStateCounter--;
                    else
                        WindowStateCounter++;
                    WindowState = window_state_sequence[WindowStateCounter];
                    
//                    switch (this.WindowState)
//                    {
//                        case WindowState.Normal: this.WindowState = WindowState.Maximized; break;1
//                        case WindowState.Maximized: this.WindowState = WindowState.Fullscreen; break;
//                        case WindowState.Fullscreen:
//                            this.WindowState = WindowState.Normal;
//                            this.WindowState = WindowState.Minimized;
//                            break;
//                        case WindowState.Minimized: this.WindowState = WindowState.Normal;
//                            break;
//
//                    }
                    break;

                case OpenTK.Input.Key.Number2:
                    if (sender[Key.ShiftLeft] || sender[Key.ShiftRight])
                        WindowBorderCounter--;
                    else
                        WindowBorderCounter++;
                    WindowBorder = window_border_sequence[WindowBorderCounter];
//                    this.WindowState = WindowState.Normal;
//                    switch (this.WindowBorder)
//                    {
//                        case WindowBorder.Fixed: this.WindowBorder = WindowBorder.Hidden; break;
//                        case WindowBorder.Hidden: this.WindowBorder = WindowBorder.Resizable; break;
//                        case WindowBorder.Resizable: this.WindowBorder = WindowBorder.Fixed; break;
//                    }

                    break;
                    
                case OpenTK.Input.Key.Number3:
                    if (this.WindowState == WindowState.Fullscreen)
                        this.WindowState = WindowState.Normal;
                    else
                        this.WindowState = WindowState.Fullscreen;
                    
                    break;
            }
        }

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            printer.Begin();

            printer.Draw("Instructions:", font); GL.Translate(0, font.Height, 0);
            printer.Draw(String.Format("1 - cycle through window styles (current: {0}).", this.WindowState), font);
            GL.Translate(0, font.Height, 0);
            printer.Draw(String.Format("2 - cycle through window borders (current: {0}).", this.WindowBorder), font);
            GL.Translate(0, font.Height, 0);
            printer.Draw(String.Format("3 - toggle fullscreen (current: {0}).",
                                       this.WindowState == WindowState.Fullscreen ? "enabled" : "disabled"), font);
            

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
