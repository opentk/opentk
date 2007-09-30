#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using OpenTK.OpenGL;
using OpenTK;

#endregion --- Using Directives ---

namespace Examples.Tutorial
{
    /// <summary>
    /// Demonstrates how to load and use a simple OpenGL shader program. Example is incomplete (documentation).
    /// </summary>
    public class T10_GLSL_Cube : GameWindow, IExample
    {
        #region --- Fields ---

        #region Shaders

        string[] vertex_shader_source =
{@"
void main()
{
    gl_FrontColor = gl_Color;
    gl_Position = ftransform();
}
"};

        string[] fragment_shader_source =
{@"
void main()
{
    gl_FragColor = gl_Color;
}
"};

        #endregion

        static float angle;
        int vertex_shader_object, fragment_shader_object, shader_program;

        Shapes.Cube shape = new Examples.Shapes.Cube();

        #endregion

        #region --- Constructors ---

        public T10_GLSL_Cube()
        {
            this.CreateWindow(new DisplayMode(800, 600), "OpenTK | GLSL Example 1");
        }

        #endregion

        #region OnLoad

        /// <summary>
        /// This is the place to load resources that change little
        /// during the lifetime of the GameWindow. In this case, we
        /// check for GLSL support, and load the shaders.
        /// </summary>
        /// <param name="e">Not used.</param>
        public override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            // Check for necessary capabilities:
            if (!GL.SupportsExtension("VERSION_2_0"))
            {
                MessageBox.Show("You need at least OpenGL 2.0 to run this example. Aborting.", "GLSL not supported",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Exit();
                return;
            }

            GL.ClearColor(Color.MidnightBlue);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);

            GL.EnableClientState(GL.Enums.EnableCap.VERTEX_ARRAY);
            GL.EnableClientState(GL.Enums.EnableCap.COLOR_ARRAY);
            GL.VertexPointer(3, GL.Enums.VertexPointerType.FLOAT, 0, shape.Vertices);
            GL.ColorPointer(4, GL.Enums.ColorPointerType.UNSIGNED_BYTE, 0, shape.Colors);

            int status;

            vertex_shader_object = GL.CreateShader(GL.Enums.VERSION_2_0.VERTEX_SHADER);
            fragment_shader_object = GL.CreateShader(GL.Enums.VERSION_2_0.FRAGMENT_SHADER);

            unsafe { GL.ShaderSource(vertex_shader_object, vertex_shader_source.Length, vertex_shader_source, (int*)null); }
            GL.CompileShader(vertex_shader_object);
            GL.GetShader(vertex_shader_object, GL.Enums.VERSION_2_0.COMPILE_STATUS, out status);
            if (status != (int)GL.Enums.Boolean.TRUE)
            {
                int length = 0;
                GL.GetShader(vertex_shader_object, GL.Enums.VERSION_2_0.INFO_LOG_LENGTH, out length);
                StringBuilder info = new StringBuilder(length);
                GL.GetShaderInfoLog(vertex_shader_object, info.Capacity, out length, info);

                throw new Exception(info.ToString());
            }

            unsafe { GL.ShaderSource(fragment_shader_object, fragment_shader_source.Length, fragment_shader_source, (int*)null); }
            GL.CompileShader(fragment_shader_object);
            GL.GetShader(fragment_shader_object, GL.Enums.VERSION_2_0.COMPILE_STATUS, out status);
            if (status != (int)GL.Enums.Boolean.TRUE)
            {
                int length;
                GL.GetShader(vertex_shader_object, GL.Enums.VERSION_2_0.INFO_LOG_LENGTH, out length);
                StringBuilder info = new StringBuilder(length);
                GL.GetShaderInfoLog(fragment_shader_object, info.Capacity, out length, info);

                throw new Exception(info.ToString());
            }

            shader_program = GL.CreateProgram();
            GL.AttachShader(shader_program, fragment_shader_object);
            GL.AttachShader(shader_program, vertex_shader_object);

            GL.LinkProgram(shader_program);
            GL.UseProgram(shader_program);

            //OnResize(new OpenTK.Platform.ResizeEventArgs(this.Width, this.Height));
        }

        #endregion

        #region OnUnload

        public override void OnUnload(EventArgs e)
        {
            if (shader_program != 0)
                GL.DeleteProgram(shader_program);
            if (fragment_shader_object != 0)
                GL.DeleteShader(fragment_shader_object);
            if (vertex_shader_object != 0)
                GL.DeleteShader(vertex_shader_object);
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
        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);

            double ratio = e.Width / (double)e.Height;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
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
        public override void OnUpdateFrame(UpdateFrameEventArgs e)
        {
            if (Keyboard[OpenTK.Input.Key.Escape])
            {
                this.Exit();
                return;
            }

            if ((Keyboard[OpenTK.Input.Key.AltLeft] || Keyboard[OpenTK.Input.Key.AltRight]) &&
                Keyboard[OpenTK.Input.Key.Enter])
            {
                Fullscreen = !Fullscreen;
            }

            //angle += 180.0f * (float)e.Time;
            angle += 3.0f;
            if (angle > 720.0f)
                angle -= 720.0f;
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Place your rendering code here.
        /// </summary>
        public override void OnRenderFrame(RenderFrameEventArgs e)
        {
            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotate(angle, 0.0f, 1.0f, 0.0f);

            GL.DrawElements(GL.Enums.BeginMode.TRIANGLES, shape.Indices.Length,
                GL.Enums.All.UNSIGNED_SHORT, shape.Indices);

            Context.SwapBuffers();
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
            // Lock UpdateFrame and RenderFrame at 60Hz.
            Run(60.0, 60.0);
        }

        #endregion
    }
}
