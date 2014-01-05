// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

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
    [Example("GameWindow States", ExampleCategory.OpenTK, "GameWindow", 4, Documentation = "GameWindowStates")]
    public class GameWindowStates : GameWindow
    {
        static readonly Font TextFont = new Font(FontFamily.GenericSansSerif, 11);
        Bitmap TextBitmap = new Bitmap(1024, 1024);
        StringBuilder TypedText = new StringBuilder();
        int texture;
        bool mouse_in_window = false;
        bool viewport_changed = true;
        MouseState mouse;
        KeyboardState keyboard;

        public GameWindowStates()
            : base(800, 600, GraphicsMode.Default)
        {
            VSync = VSyncMode.On;
            Keyboard.KeyRepeat = true;
            KeyDown += KeyDownHandler;
            KeyPress += KeyPressHandler;
            
            MouseEnter += delegate { mouse_in_window = true; };
            MouseLeave += delegate { mouse_in_window = false; };
            
            Mouse.Move += MouseMoveHandler;
            Mouse.ButtonDown += MouseButtonHandler;
            Mouse.ButtonUp += MouseButtonHandler;
        }

        private void KeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (TypedText.Length > 32)
                TypedText.Remove(0, 1);

            TypedText.Append(e.KeyChar);
        }

        void KeyDownHandler(object sender, KeyboardKeyEventArgs e)
        {
            switch (e.Key)
            {
                case OpenTK.Input.Key.Escape:
                    if (!CursorVisible)
                        CursorVisible = true;
                    else
                        Exit();
                    break;

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

        void MouseMoveHandler(object sender, MouseMoveEventArgs e)
        {
        }

        void MouseButtonHandler(object sender, MouseButtonEventArgs e)
        {
            if (e.Button == MouseButton.Left && e.IsPressed)
            {
                CursorVisible = false;
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

        static void DrawString(Graphics gfx, string str, int line, float offset)
        {
            gfx.DrawString(str, TextFont, Brushes.White, new PointF(offset, line * TextFont.Height));
        }

        static void DrawKeyboard(Graphics gfx, KeyboardState keyboard, int line)
        {
            const string str = "Keys pressed:";
            float space = gfx.MeasureString(" ", TextFont).Width;
            float offset = gfx.MeasureString(str, TextFont).Width + space;
            DrawString(gfx, str, line);
            for (int i = 0; i < (int)Key.LastKey; i++)
            {
                Key k = (Key)i;
                if (keyboard[k])
                {
                    string key = k.ToString();
                    DrawString(gfx, key, line, offset);
                    offset += gfx.MeasureString(key, TextFont).Width + space;
                }
            }
        }

        static void DrawMouse(Graphics gfx, MouseState mouse, int line)
        {
            const string str = "Buttons pressed:";
            float space = gfx.MeasureString(" ", TextFont).Width;
            float offset = gfx.MeasureString(str, TextFont).Width + space;
            DrawString(gfx, str, line);
            for (int i = 0; i < (int)MouseButton.LastButton; i++)
            {
                MouseButton b = (MouseButton)i;
                if (mouse[b])
                {
                    string button = b.ToString();
                    DrawString(gfx, button, line, offset);
                    offset += gfx.MeasureString(button, TextFont).Width + space;
                }
            }
        }

        static int DrawJoysticks(Graphics gfx, IList<JoystickDevice> joysticks, int line)
        {
            float space = gfx.MeasureString(" ", TextFont).Width;

            foreach (var joy in joysticks)
            {
                string str = String.Format("Joystick '{0}': ", joy.Description);
                DrawString(gfx, str, line);

                float offset = 0;
                line++;
                for (int i = 0; i < joy.Axis.Count; i++)
                {
                    string axis = joy.Axis[i].ToString();
                    DrawString(gfx, axis, line, offset);
                    offset += gfx.MeasureString(axis, TextFont).Width + space;
                }

                offset = 0;
                line++;
                for (int i = 0; i < joy.Button.Count; i++)
                {
                    string button = joy.Button[i].ToString();
                    DrawString(gfx, button, line, offset);
                    offset += gfx.MeasureString(button, TextFont).Width + space;
                }

                line++;
            }

            return line;
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            InputDriver.Poll();

            mouse = OpenTK.Input.Mouse.GetState();
            keyboard = OpenTK.Input.Keyboard.GetState();

            using (Graphics gfx = Graphics.FromImage(TextBitmap))
            {
                int line = 0;

                gfx.Clear(Color.Black);
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                DrawString(gfx, GL.GetString(StringName.Vendor), line++);
                DrawString(gfx, GL.GetString(StringName.Version), line++);
                DrawString(gfx, GL.GetString(StringName.Renderer), line++);
                DrawString(gfx, Context.GraphicsMode.ToString(), line++);

                DrawString(gfx, String.Format("[1 - 4]: change WindowState (current: {0}).", this.WindowState), line++);
                DrawString(gfx, String.Format("[5 - 7]: change WindowBorder (current: {0}).", this.WindowBorder), line++);
                DrawString(gfx, String.Format("Focused: {0}.", this.Focused), line++);
                DrawString(gfx, String.Format("Mouse {0} window.", mouse_in_window ? "inside" : "outside of"), line++);
                DrawString(gfx, String.Format("Mouse visible: {0}", CursorVisible), line++);
                DrawString(gfx, String.Format("Mouse position (absolute): {0}", new Vector3(Mouse.X, Mouse.Y, Mouse.Wheel)), line++);
                DrawString(gfx, String.Format("Mouse position (relative): {0}", new Vector3(mouse.X, mouse.Y, mouse.WheelPrecise)), line++);
                DrawString(gfx, String.Format("Window.Bounds: {0}", Bounds), line++);
                DrawString(gfx, String.Format("Window.Location: {0}, Size: {1}", Location, Size), line++);
                DrawString(gfx, String.Format("Window: {{X={0},Y={1},Width={2},Height={3}}}", X, Y, Width, Height), line++);
                DrawString(gfx, String.Format("Window.ClientRectangle: {0}", ClientRectangle), line++);
                DrawString(gfx, TypedText.ToString(), line++);
                DrawKeyboard(gfx, keyboard, line++);
                DrawMouse(gfx, mouse, line++);
                line = DrawJoysticks(gfx, Joysticks, line++);
                line = DrawGamePads(gfx, line++);
            }

            System.Drawing.Imaging.BitmapData data = TextBitmap.LockBits(
                new System.Drawing.Rectangle(0, 0, TextBitmap.Width, TextBitmap.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexSubImage2D(TextureTarget.Texture2D, 0, 0, 0, TextBitmap.Width, TextBitmap.Height, PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);
            TextBitmap.UnlockBits(data);
        }

        int DrawGamePads(Graphics gfx, int line)
        {
            line++;
            DrawString(gfx, "GamePads:", line++);
            for (int i = 0; i < 4; i++)
            {
                GamePadCapabilities caps = GamePad.GetCapabilities(i);
                GamePadState state = GamePad.GetState(i);
                if (state.IsConnected)
                {
                    DrawString(gfx, String.Format("{0}: {1}", i, caps), line++);
                    DrawString(gfx, state.ToString(), line++);
                }
            }
            line++;
            DrawString(gfx, "Joysticks:", line++);
            for (int i = 0; i < 4; i++)
            {
                JoystickCapabilities caps = Joystick.GetCapabilities(i);
                JoystickState state = Joystick.GetState(i);
                if (state.IsConnected)
                {
                    DrawString(gfx, String.Format("{0}: {1}", i, caps), line++);
                    DrawString(gfx, state.ToString(), line++);
                }
            }

            return line;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            GL.ClearColor(Color.MidnightBlue);

            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.One, BlendingFactorDest.OneMinusSrcColor);

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
