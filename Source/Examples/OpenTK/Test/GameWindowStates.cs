// This code is in the Public Domain. It is provided "as is"
// without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Threading;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tests
{
    [Example("GameWindow states", ExampleCategory.OpenTK, "Test", Documentation = "GameWindowStates")]
    public class GameWindowStates : GameWindow
    {
        static readonly Font TextFont = new Font(FontFamily.GenericSansSerif, 12);
        Bitmap TextBitmap = new Bitmap(512, 512);
        int texture;
        bool mouse_in_window = false;
        bool viewport_changed = true;
        bool refresh_text = true;

        public GameWindowStates()
            : base(800, 600)
        {
            VSync = VSyncMode.On;
            Keyboard.KeyRepeat = true;
            Keyboard.KeyDown += KeyDownHandler;
            
            MouseEnter += delegate { mouse_in_window = true; };
            MouseLeave += delegate { mouse_in_window = false; };
            
            Move += delegate { refresh_text = true; };
            Resize += delegate { refresh_text = true; };
            WindowBorderChanged += delegate { refresh_text = true; };
            WindowStateChanged += delegate { refresh_text = true; };
            Mouse.Move += delegate { refresh_text = true; };
        }

        void KeyDownHandler(object sender, KeyboardKeyEventArgs e)
        {
            switch (e.Key)
            {
                case OpenTK.Input.Key.Escape: this.Exit(); break;

                case Key.Number1: WindowState = WindowState.Normal; break;
                case Key.Number2: WindowState = WindowState.Maximized; break;
                case Key.Number3: WindowState = WindowState.Fullscreen; break;
                case Key.Number4: WindowState = WindowState.Minimized; break;

                case Key.Number5: WindowBorder = WindowBorder.Resizable; break;
                case Key.Number6: WindowBorder = WindowBorder.Fixed; break;
                case Key.Number7: WindowBorder = WindowBorder.Hidden; break;

                case Key.Left: X = X - 16; break;
                case Key.Right: X = X + 16; break;
                case Key.Up: Y = Y - 16; break;
                case Key.Down: Y = Y + 16; break;

                case Key.KeypadPlus:
                case Key.Plus: Size += new Size(16, 16); break;

                case Key.KeypadMinus:
                case Key.Minus: Size -= new Size(16, 16); break;
            }
        }
        
        static int Clamp(int val, int min, int max)
        {
            return val > max ? max : val < min ? min : val;
        }
        
        static void DrawString(Graphics gfx, string str, int line)
        {
            gfx.DrawString(str, TextFont, Brushes.White, new PointF(0, line * TextFont.Height));
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (refresh_text)
            {
                refresh_text = false;
                    
                using (Graphics gfx = Graphics.FromImage(TextBitmap))
                {
                    int line = 0;

                    gfx.Clear(Color.MidnightBlue);
                    gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    DrawString(gfx, String.Format("[1 - 4]: change WindowState (current: {0}).", this.WindowState), line++);
                    DrawString(gfx, String.Format("[5 - 7]: change WindowBorder (current: {0}).", this.WindowBorder), line++);
                    DrawString(gfx, String.Format("Focused: {0}.", this.Focused), line++);
                    DrawString(gfx, String.Format("Mouse {0} window.", mouse_in_window ? "inside" : "outside of"), line++);
                    DrawString(gfx, String.Format("Mouse position: {0}", new Vector3(Mouse.X, Mouse.Y, Mouse.Wheel)), line++);
                    DrawString(gfx, String.Format("Window.Bounds: {0}", Bounds), line++);
                    DrawString(gfx, String.Format("Window.Location: {0}, Size: {1}", Location, Size), line++);
                    DrawString(gfx, String.Format("Window.{{X={0}, Y={1}, Width={2}, Height={3}}}", X, Y, Width, Height), line++);
                    DrawString(gfx, String.Format("Window.ClientRectangle: {0}", ClientRectangle), line++);
                }
            }

            System.Drawing.Imaging.BitmapData data = TextBitmap.LockBits(
                new System.Drawing.Rectangle(0, 0, TextBitmap.Width, TextBitmap.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexSubImage2D(TextureTarget.Texture2D, 0, 0, 0, TextBitmap.Width, TextBitmap.Height, PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);
            TextBitmap.UnlockBits(data);
        }
        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            GL.ClearColor(Color.MidnightBlue);

            GL.Enable(EnableCap.Texture2D);

            texture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, texture);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, TextBitmap.Width, TextBitmap.Height,
                0, PixelFormat.Bgra, PixelType.UnsignedByte, IntPtr.Zero);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Nearest);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            viewport_changed = true;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            
            if (viewport_changed)
            {
                viewport_changed = false;

                GL.Viewport(0, 0, Width, Height);
    
                Matrix4 ortho_projection = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, -1, 1);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadMatrix(ref ortho_projection);
            }

            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(BeginMode.Quads);

            GL.TexCoord2(0, 0); GL.Vertex2(0, 0);
            GL.TexCoord2(1, 0); GL.Vertex2(TextBitmap.Width, 0);
            GL.TexCoord2(1, 1); GL.Vertex2(TextBitmap.Width, TextBitmap.Height);
            GL.TexCoord2(0, 1); GL.Vertex2(0, TextBitmap.Height);

            GL.End();

            SwapBuffers();
        }

        public static void Main()
        {
            using (GameWindowStates ex = new GameWindowStates())
            {
                Utilities.SetWindowTitle(ex);
                ex.Run(30.0);
            }
        }
    }
}
