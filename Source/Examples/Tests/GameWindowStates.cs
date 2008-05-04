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
    [Example("GameWindow states", ExampleCategory.Test)]
    public class GameWindowStates : GameWindow
    {
        TextureFont font = new TextureFont(new Font(FontFamily.GenericSansSerif, 16.0f));
        TextPrinter printer = new TextPrinter();
        
        #region GetNext and GetPrevious methods for enums.         
        
        T GetNext<T>(T t)
        {
            if (!(t is Enum))
                throw new ArgumentException(String.Format("Should be an Enum type (is {0}).", t.GetType().ToString()),
                                            "t");
            
            string[] names = Enum.GetNames(t.GetType());
            T[] values = (T[])Enum.GetValues(t.GetType());
   
            int current_index = Array.IndexOf(names, t.ToString());
            if (current_index >= values.Length - 1)
                return values[0];
            else
                return values[current_index + 1];

        }
        
        T GetPrevious<T>(T t)
        {
            if (!(t is Enum))
                throw new ArgumentException(String.Format("Should be an Enum type (is {0}).", t.GetType().ToString()),
                                            "t");
                     
            string[] names = Enum.GetNames(t.GetType());
            T[] values = (T[])Enum.GetValues(t.GetType());

            int current_index = Array.IndexOf(names, t.ToString());
            if (current_index <= 0)
                return values[values.Length - 1];
            else
                return values[current_index - 1];
        }
        
        #endregion
        
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
                        WindowState = GetPrevious(WindowState);
                    else
                        WindowState = GetNext(WindowState);
                    
                    break;

                case OpenTK.Input.Key.Number2:
                    
                    if (sender[Key.ShiftLeft] || sender[Key.ShiftRight])
                        WindowBorder = GetPrevious(WindowBorder);
                    else
                        WindowBorder = GetNext(WindowBorder);

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
