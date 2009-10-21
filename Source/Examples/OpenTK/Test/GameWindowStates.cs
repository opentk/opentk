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
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Examples.Tests
{
    [Example("GameWindow states", ExampleCategory.OpenTK, "Test", Documentation="GameWindowStates")]
    public class GameWindowStates : GameWindow
    {
        readonly Font TextFont = new Font(FontFamily.GenericSansSerif, 16);
        readonly Bitmap TextBitmap = new Bitmap(1024, 256);
        int texture;
        
        public GameWindowStates()
            : base(800, 600)
        {
            VSync = VSyncMode.On;
            Keyboard.KeyUp += KeyUpHandler;

            WindowBorderChanged += delegate(object sender, EventArgs e) { UpdateText(); };
            WindowStateChanged += delegate(object sender, EventArgs e) { UpdateText(); };
            FocusedChanged += delegate(object sender, EventArgs e) { UpdateText(); };
        }

        void KeyUpHandler(object sender, KeyboardKeyEventArgs e)
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
            }
        }

        void UpdateText()
        {
            using (Graphics gfx = Graphics.FromImage(TextBitmap))
            {
                gfx.Clear(Color.MidnightBlue);
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                gfx.DrawString(String.Format("[1 - 4]: change WindowState (current: {0}).", this.WindowState), TextFont, Brushes.White, new PointF(0, 0));
                gfx.DrawString(String.Format("[5 - 7]: change WindowBorder (current: {0}).", this.WindowBorder), TextFont, Brushes.White, new PointF(0, TextFont.Height));
                gfx.DrawString(String.Format("Focused: {0}.", this.Focused), TextFont, Brushes.White, new PointF(0, 2 * TextFont.Height));
            }

            System.Drawing.Imaging.BitmapData data = TextBitmap.LockBits(new Rectangle(0, 0, TextBitmap.Width, TextBitmap.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexSubImage2D(TextureTarget.Texture2D, 0, 0, 0, TextBitmap.Width, TextBitmap.Height, PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
            TextBitmap.UnlockBits(data);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);

            GL.Enable(EnableCap.Texture2D);

            texture = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, texture);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, TextBitmap.Width, TextBitmap.Height, 0, PixelFormat.Bgra, PixelType.UnsignedByte, IntPtr.Zero);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Nearest);

            // Make sure text is displayed when the application starts.
            UpdateText();
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            Matrix4 ortho_projection = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, -1, 1);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref ortho_projection);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(BeginMode.Quads);

            GL.TexCoord2(0, 0); GL.Vertex2(0, 0);
            GL.TexCoord2(1, 0); GL.Vertex2(TextBitmap.Width, 0);
            GL.TexCoord2(1, 1); GL.Vertex2(TextBitmap.Width, TextBitmap.Height);
            GL.TexCoord2(0, 1); GL.Vertex2(0, TextBitmap.Height);

            GL.End();

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
