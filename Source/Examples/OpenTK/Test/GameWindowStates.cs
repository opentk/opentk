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

        // time drift
        Stopwatch watch = new Stopwatch();
        double update_time, render_time;

        // timing information
        double timestamp;
        int update_count;
        int update_fps;
        int render_count;
        int render_fps;

        // position of moving objects on screen
        double variable_update_timestep_pos = -1;
        double variable_refresh_timestep_pos = -1;
        double fixed_update_timestep_pos = -1;

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

                case Key.V:
                    VSync = VSync == VSyncMode.On ? VSyncMode.Off : VSyncMode.On;
                    break;

                case Key.BracketLeft: TargetUpdateFrequency--; break;
                case Key.BracketRight: TargetUpdateFrequency++; break;
                case Key.Comma: TargetRenderFrequency--; break;
                case Key.Period: TargetRenderFrequency++; break;
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

        static float DrawString(Graphics gfx, string str, int line)
        {
            return DrawString(gfx, str, line, 0);
        }

        static float DrawString(Graphics gfx, string str, int line, float offset)
        {
            gfx.DrawString(str, TextFont, Brushes.White, new PointF(offset, line * TextFont.Height));
            return offset + gfx.MeasureString(str, TextFont).Width;
        }

        static int DrawKeyboards(Graphics gfx, int line)
        {
            line++;
            DrawString(gfx, "Keyboard:", line++);
            for (int i = 0; i < 4; i++)
            {
                var state = OpenTK.Input.Keyboard.GetState(i);
                if (state.IsConnected)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(i);
                    sb.Append(": ");
                    for (int key_index = 0; key_index < (int)Key.LastKey; key_index++)
                    {
                        Key k = (Key)key_index;
                        if (state[k])
                        {
                            sb.Append(k);
                            sb.Append(" ");
                        }
                    }
                    DrawString(gfx, sb.ToString(), line++);
                }
            }
            return line;
        }

        static int DrawMice(Graphics gfx, int line)
        {
            line++;
            DrawString(gfx, "Mouse:", line++);
            for (int i = 0; i < 4; i++)
            {
                var state = OpenTK.Input.Mouse.GetState(i);
                if (state.IsConnected)
                {
                    StringBuilder sb = new StringBuilder();
                    Vector3 pos = new Vector3(state.X, state.Y, state.WheelPrecise);
                    sb.Append(i);
                    sb.Append(": ");
                    sb.Append(pos);
                    for (int button_index = 0; button_index < (int)MouseButton.LastButton; button_index++)
                    {
                        MouseButton b = (MouseButton)button_index;
                        if (state[b])
                        {
                            sb.Append(b);
                            sb.Append(" ");
                        }
                    }
                    DrawString(gfx, sb.ToString(), line++);
                }
            }
            return line;
        }

        static int DrawLegacyJoysticks(Graphics gfx, IList<JoystickDevice> joysticks, int line)
        {
            line++;
            DrawString(gfx, "Legacy Joystick:", line++);

            int joy_index = -1;
            foreach (var joy in joysticks)
            {
                joy_index++;
                if (!String.IsNullOrEmpty(joy.Description))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(joy_index);
                    sb.Append(": '");
                    sb.Append(joy.Description);
                    sb.Append("' ");

                    for (int i = 0; i < joy.Axis.Count; i++)
                    {
                        sb.Append(joy.Axis[i]);
                        sb.Append(" ");
                    }

                    for (int i = 0; i < joy.Button.Count; i++)
                    {
                        sb.Append(joy.Button[i]);
                        sb.Append(" ");
                    }
                    DrawString(gfx, sb.ToString(), line++);
                }
            }

            return line;
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            double clock_time = watch.Elapsed.TotalSeconds;
            update_time += e.Time;
            timestamp += e.Time;
            update_count++;

            using (Graphics gfx = Graphics.FromImage(TextBitmap))
            {
                int line = 0;

                gfx.Clear(Color.Black);
                gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // OpenGL information
                DrawString(gfx, GL.GetString(StringName.Renderer), line++);
                DrawString(gfx, GL.GetString(StringName.Version), line++);
                DrawString(gfx, Context.GraphicsMode.ToString(), line++);

                // GameWindow information
                line++;
                DrawString(gfx, "GameWindow:", line++);
                DrawString(gfx, String.Format("[1 - 4]:[5 - 7]: WindowState.{0}:WindowBorder.{1}",
                    this.WindowState, this.WindowBorder), line++);
                DrawString(gfx, String.Format("[V]: VSync.{0}.", VSync), line++);
                DrawString(gfx, String.Format("Bounds: {0}", Bounds), line++);
                DrawString(gfx, String.Format("ClientRectangle: {0}", ClientRectangle), line++);
                DrawString(gfx, String.Format("Mouse {0} and {1}. {2}.",
                    mouse_in_window ? "inside" : "outside",
                    CursorVisible ? "visible" : "hidden",
                    Focused ? "Focused" : "Not focused"), line++);
                DrawString(gfx, String.Format("Mouse coordinates: {0}", new Vector3(Mouse.X, Mouse.Y, Mouse.WheelPrecise)), line++);

                // Timing information
                line++;
                DrawString(gfx, "Timing:", line++);
                DrawString(gfx,
                    String.Format("Frequency: update {4} ({0:f2}/{1:f2}); render {5} ({2:f2}/{3:f2})",
                        UpdateFrequency, TargetUpdateFrequency,
                        RenderFrequency, TargetRenderFrequency,
                        update_fps, render_fps),
                    line++);
                DrawString(gfx,
                    String.Format("Period: update {4:N4} ({0:f4}/{1:f4}); render {5:N4} ({2:f4}/{3:f4})",
                        UpdatePeriod, TargetUpdatePeriod,
                        RenderPeriod, TargetRenderPeriod,
                        1.0 / update_fps, 1.0 / render_fps),
                    line++);
                DrawString(gfx, String.Format("Time: update {0:f4}; render {1:f4}",
                    UpdateTime, RenderTime), line++);
                DrawString(gfx, String.Format("Drift: clock {0:f4}; update {1:f4}; render {2:f4}",
                    clock_time, clock_time - update_time, clock_time - render_time), line++);
                DrawString(gfx, String.Format("Text: {0}", TypedText.ToString()), line++);

                if (timestamp >= 1)
                {
                    timestamp -= 1;
                    update_fps = update_count;
                    render_fps = render_count;
                    update_count = 0;
                    render_count = 0;

                }

                // Input information
                line = DrawKeyboards(gfx, line);
                line = DrawMice(gfx, line);
                line = DrawJoysticks(gfx, line);
                line = DrawLegacyJoysticks(gfx, Joysticks, line);
            }

            fixed_update_timestep_pos += TargetUpdatePeriod;
            variable_update_timestep_pos += e.Time;
            if (fixed_update_timestep_pos >= 1)
                fixed_update_timestep_pos -= 2;
            if (variable_update_timestep_pos >= 1)
                variable_update_timestep_pos -= 2;
        }

        int DrawJoysticks(Graphics gfx, int line)
        {
            line++;
            DrawString(gfx, "GamePad:", line++);
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
            DrawString(gfx, "Joystick:", line++);
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
            watch.Start();

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
            render_time += e.Time;
            render_count++;

            GL.Clear(ClearBufferMask.ColorBufferBit);

            if (viewport_changed)
            {
                viewport_changed = false;
                GL.Viewport(0, 0, Width, Height);
            }

            DrawText();

            DrawMovingObjects();

            variable_refresh_timestep_pos += e.Time;
            if (variable_refresh_timestep_pos >= 1)
                variable_refresh_timestep_pos -= 2;

            SwapBuffers();
        }

        // Uploads our text Bitmap to an OpenGL texture
        // and displays is to screen.
        private void DrawText()
        {
            System.Drawing.Imaging.BitmapData data = TextBitmap.LockBits(
                new System.Drawing.Rectangle(0, 0, TextBitmap.Width, TextBitmap.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexSubImage2D(TextureTarget.Texture2D, 0, 0, 0, TextBitmap.Width, TextBitmap.Height, PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);
            TextBitmap.UnlockBits(data);

            Matrix4 text_projection = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, -1, 1);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref text_projection);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.Color4(Color4.White);
            GL.Enable(EnableCap.Texture2D);
            GL.Begin(PrimitiveType.Quads);
            GL.TexCoord2(0, 0); GL.Vertex2(0, 0);
            GL.TexCoord2(1, 0); GL.Vertex2(TextBitmap.Width, 0);
            GL.TexCoord2(1, 1); GL.Vertex2(TextBitmap.Width, TextBitmap.Height);
            GL.TexCoord2(0, 1); GL.Vertex2(0, TextBitmap.Height);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
        }

        // Draws three moving objects, using three different timing methods:
        // 1. fixed framerate based on TargetUpdatePeriod
        // 2. variable framerate based on UpdateFrame e.Time
        // 3. variable framerate based on RenderFrame e.Time
        // If the timing implementation is correct, all three objects
        // should be moving at the same speed, regardless of the current
        // UpdatePeriod and RenderPeriod.
        void DrawMovingObjects()
        {
            Matrix4 thing_projection = Matrix4.CreateOrthographic(2, 2, -1, 1);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref thing_projection);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(fixed_update_timestep_pos, -0.2, 0);
            GL.Color4(Color4.Red);
            DrawRectangle();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(variable_update_timestep_pos, -0.4, 0);
            GL.Color4(Color4.DarkGoldenrod);
            DrawRectangle();

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(variable_refresh_timestep_pos, -0.8, 0);
            GL.Color4(Color4.DarkGreen);
            DrawRectangle();
        }

        private void DrawRectangle()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(-0.05, -0.05);
            GL.Vertex2(+0.05, -0.05);
            GL.Vertex2(+0.05, +0.05);
            GL.Vertex2(-0.05, +0.05);
            GL.End();
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
