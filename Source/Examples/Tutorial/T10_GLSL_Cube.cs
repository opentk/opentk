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
    public class T10_GLSL_Cube : GameWindow, IExample
    {
        #region --- Fields ---

        #region Shaders

        string[] vertex_shader_source =
        {
            "void main() {",
            "gl_FrontColor = gl_Color;",
            "gl_Position = ftransform();",
            "}",
        };

        string[] fragment_shader_source =
        {
            "void main() { gl_FragColor = gl_Color; }\0"
        };

        #endregion

        static float angle;

        #endregion

        #region --- Constructors ---

        public T10_GLSL_Cube()
        {
            this.CreateWindow(new OpenTK.Platform.DisplayMode(800, 600));
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
            Run();
        }

        #endregion

        #region OnCreate

        /// <summary>
        /// This is the place to change window parameters.
        /// </summary>
        /// <param name="e">Not used.</param>
        public override void OnCreate(EventArgs e)
        {
            base.OnCreate(e);

            //Text =
            //    GL.GetString(Enums.StringName.VENDOR) + " " +
            //    GL.GetString(Enums.StringName.RENDERER) + " " +
            //    GL.GetString(Enums.StringName.VERSION);
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
            }

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);

            uint vertex_shader_object, fragment_shader_object;
            int status;
            uint shader_program;

            vertex_shader_object = (uint)GL.CreateShader(GL.Enums.VERSION_2_0.VERTEX_SHADER);
            fragment_shader_object = (uint)GL.CreateShader(GL.Enums.VERSION_2_0.FRAGMENT_SHADER);

            GL.ShaderSource(vertex_shader_object, vertex_shader_source.Length, vertex_shader_source, (int[])null);
            GL.CompileShader(vertex_shader_object);
            GL.GetShaderv(vertex_shader_object, GL.Enums.VERSION_2_0.COMPILE_STATUS, out status);
            if (status != (int)GL.Enums.Boolean.TRUE)
            {
                int length = 0;
                GL.GetShaderv(vertex_shader_object, GL.Enums.VERSION_2_0.INFO_LOG_LENGTH, out length);
                StringBuilder info = new StringBuilder(length);
                GL.GetShaderInfoLog(vertex_shader_object, info.Capacity, out length, info);

                throw new Exception(info.ToString());
            }

            GL.ShaderSource(fragment_shader_object, fragment_shader_source.Length, fragment_shader_source, (int[])null);
            GL.CompileShader(fragment_shader_object);
            GL.GetShaderv(fragment_shader_object, GL.Enums.VERSION_2_0.COMPILE_STATUS, out status);
            if (status != (int)GL.Enums.Boolean.TRUE)
            {
                int length;
                GL.GetShaderv(vertex_shader_object, GL.Enums.VERSION_2_0.INFO_LOG_LENGTH, out length);
                StringBuilder info = new StringBuilder(length);
                GL.GetShaderInfoLog(fragment_shader_object, info.Capacity, out length, info);

                throw new Exception(info.ToString());
            }

            shader_program = (uint)GL.CreateProgram();
            GL.AttachShader(shader_program, fragment_shader_object);
            GL.AttachShader(shader_program, vertex_shader_object);

            GL.LinkProgram(shader_program);
            GL.UseProgram(shader_program);

            OnResize(new OpenTK.Platform.ResizeEventArgs(this.Width, this.Height));
        }

        #endregion

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, this.Width, this.Height);

            double ratio = 0.0;
            ratio = this.Width / (double)this.Height;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Occurs when it is time to update the next frame.
        /// </summary>
        /// <param name="e">Not used yet.</param>
        public override void OnUpdateFrame(EventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[0][OpenTK.Input.Key.Escape])
            {
                this.Exit();
            }

            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.05f;
        }

        #endregion

        #region OnRenderFrame

        public override void OnRenderFrame(EventArgs e)
        {
 	        base.OnRenderFrame(e);

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            Context.SwapBuffers();
            Thread.Sleep(0);
        }

        #endregion

        #region private void DrawCube()

        private void DrawCube()
        {
            GL.Begin(GL.Enums.BeginMode.QUADS);

            GL.Color3(1.0f, 0.0f, 0.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);

            GL.Color3(1.0f, 1.0f, 0.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);

            GL.Color3(1.0f, 0.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);

            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);

            GL.Color3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);

            GL.Color3(0.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);

            GL.End();
        }

        #endregion
    }
}
