// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;

using OpenTK;
using System.Diagnostics;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates Vertex Arrays (in system memory).  Example is incomplete (documentation).
    /// Broken since release 0.3.12.
    /// </summary>
    [Example("Vertex Arrays", ExampleCategory.OpenGL, "1.x", 5, false)]
    class T02_Vertex_Arrays : GameWindow
    {
        float rotation_speed = 3.0f;
        float angle = 0.0f;

        Shapes.Shape shape = new Examples.Shapes.Plane(16, 16, 2.0f, 2.0f);
        //TextureFont sans = new TextureFont(new Font(FontFamily.GenericSansSerif, 32, FontStyle.Regular,
        //                                            GraphicsUnit.Pixel));

        #region Constructor

        public T02_Vertex_Arrays()
            : base(800, 600)
        {
            //this.VSync = VSyncMode.On;
            KeyUp += Keyboard_KeyUp;
        }

        void Keyboard_KeyUp(object sender, KeyboardKeyEventArgs e)
        {
            // F4 cycles between available VSync modes.
            if (e.Key == Key.F4)
            {
                if (this.VSync == VSyncMode.Off)
                    this.VSync = VSyncMode.On;
                else if (this.VSync == VSyncMode.On)
                    this.VSync = VSyncMode.Adaptive;
                else
                    this.VSync = VSyncMode.Off;
            }
        }

        #endregion

        #region OnLoad

        protected override void OnLoad(EventArgs e)
        {
            GL.Enable(EnableCap.Texture2D);

            GL.ClearColor(Color.CadetBlue);
            GL.Enable(EnableCap.DepthTest);
            
            GL.EnableClientState(ArrayCap.VertexArray);
            //GL.EnableClientState(GL.Enums.EnableCap.COLOR_ARRAY);
            GL.VertexPointer(3, VertexPointerType.Float, 0, shape.Vertices);
            //GL.ColorPointer(4, GL.Enums.ColorPointerType.UNSIGNED_BYTE, 0, shape.Colors);
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Called when the user resizes the window.
        /// </summary>
        /// <param name="e">Contains the new width/height of the window.</param>
        /// <remarks>
        /// You want the OpenGL viewport to match the window. This is the place to do it!
        /// </remarks>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double aspect_ratio = Width / (double)Height;

            OpenTK.Matrix4 perspective = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Prepares the next frame for rendering.
        /// </summary>
        /// <remarks>
        /// Place your control logic here. This is the place to respond to user input,
        /// update object positions etc.
        /// </remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            var keyboard = OpenTK.Input.Keyboard.GetState();

            if (keyboard[Key.Escape])
            {
                this.Exit();
                return;
            }

            if (keyboard[Key.F11])
                if (WindowState != WindowState.Fullscreen)
                    WindowState = WindowState.Fullscreen;
                else
                    WindowState = WindowState.Normal;

            // Plus/Minus change the target render frequency.
            // PageUp/PageDown change the target update frequency.
            if (keyboard[Key.Plus] || keyboard[Key.KeypadAdd]) TargetRenderFrequency++;
            if (keyboard[Key.Minus] || keyboard[Key.KeypadSubtract]) TargetRenderFrequency--;
            if (keyboard[Key.PageUp]) TargetUpdateFrequency++;
            if (keyboard[Key.PageDown]) TargetUpdateFrequency--;

            // Right/Left control the rotation speed and direction.
            if (keyboard[Key.Right]) rotation_speed += 0.5f;
            if (keyboard[Key.Left]) rotation_speed -= 0.5f;
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Matrix4 lookat = Matrix4.LookAt(0, 5, 5, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            angle += rotation_speed * (float)e.Time;

            if (angle >= 360.0f)
                angle -= 360.0f;
            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

            GL.DrawElements(PrimitiveType.Triangles, shape.Indices.Length,
                DrawElementsType.UnsignedInt, shape.Indices);

            //GL.Begin(GL.Enums.BeginMode.TRIANGLES);

            //GL.Vertex3(-1.0, -1.0, 5.0);
            //GL.Vertex3(1.0, -1.0, 5.0);
            //GL.Vertex3(1.0, 1.0, 5.0);

            //GL.End();
            
            GL.PushMatrix();

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 1.0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            //GL.Translate(0.7f, 1.0f, 0.0f);
            //sans.Print(String.format("{0:f1}", RenderFrequency));

            GL.PopMatrix();
            
            SwapBuffers();
        }

        #endregion

        #region public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        public void Launch()
        {
            // Lock UpdateFrame rate at 30Hz and RenderFrame rate 85Hz.
            //Run(60.0, 85.0);
            Run(30.0, 85.0);
        }

        #endregion

        public static readonly int order = 2;
    }
}
