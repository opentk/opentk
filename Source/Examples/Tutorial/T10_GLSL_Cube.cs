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
using Enums = OpenTK.OpenGL.Enums;
using OpenTK;
using OpenTK.Input;

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
            Context.MakeCurrent();

            //Text =
            //    GL.GetString(Enums.StringName.VENDOR) + " " +
            //    GL.GetString(Enums.StringName.RENDERER) + " " +
            //    GL.GetString(Enums.StringName.VERSION);

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            int vertex_shader_object, fragment_shader_object;
            int status;
            int shader_program;

            vertex_shader_object = GL.CreateShader(Enums.VERSION_2_0.VERTEX_SHADER);
            fragment_shader_object = GL.CreateShader(Enums.VERSION_2_0.FRAGMENT_SHADER);

            GL.ShaderSource(vertex_shader_object, vertex_shader_source.Length, vertex_shader_source, null);
            GL.CompileShader(vertex_shader_object);
            GL.GetShaderiv(vertex_shader_object, Enums.VERSION_2_0.COMPILE_STATUS, out status);
            if (status != (int)Enums.Boolean.TRUE)
            {
                StringBuilder info = new StringBuilder(1024);
                GL.GetShaderInfoLog(vertex_shader_object, info.MaxCapacity, null, info);

                throw new Exception(info.ToString());
            }

            GL.ShaderSource(fragment_shader_object, fragment_shader_source.Length, fragment_shader_source, null);
            GL.CompileShader(fragment_shader_object);
            GL.GetShaderiv(fragment_shader_object, Enums.VERSION_2_0.COMPILE_STATUS, out status);
            if (status != (int)Enums.Boolean.TRUE)
            {
                StringBuilder info = new StringBuilder(1024);
                GL.GetShaderInfoLog(fragment_shader_object, 1024, null, info);

                throw new Exception(info.ToString());
            }

            shader_program = GL.CreateProgram();
            GL.AttachShader(shader_program, fragment_shader_object);
            GL.AttachShader(shader_program, vertex_shader_object);

            GL.LinkProgram(shader_program);
            GL.UseProgram(shader_program);

            OnResize(new OpenTK.Platform.ResizeEventArgs(this.Width, this.Height));
        }

        #endregion

        #region static public void Launch()

        /// <summary>
        /// Launches this example.
        /// </summary>
        /// <remarks>
        /// Provides a simple way for the example launcher to launch the examples.
        /// </remarks>
        static public void Launch()
        {
            using (T10_GLSL_Cube ex = new T10_GLSL_Cube())
            {
                ex.Run();
            }
        }

        #endregion

        #region OnResize

        protected override void OnResize(OpenTK.Platform.ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, this.Width, this.Height);

            double ratio = 0.0;
            ratio = this.Width / (double)this.Height;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region UpdateFrame

        public override void UpdateFrame()
        {
            base.UpdateFrame();

            if (Key.Escape)
            {
                this.Quit = true;
            }

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
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

        #region RenderFrame

        public override void RenderFrame()
        {
 	        base.RenderFrame();

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            Context.SwapBuffers();
        }

        #endregion

        #region DrawCube

        public void DrawCube()
        {
            GL.Begin(Enums.BeginMode.QUADS);

            GL.Color3f(1, 0, 0);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);

            GL.Color3f(1, 1, 0);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);

            GL.Color3f(1, 0, 1);
            GL.Vertex3f(-1.0f, -1.0f, -1.0f);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);

            GL.Color3f(0, 1, 0);
            GL.Vertex3f(-1.0f, -1.0f, 1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);

            GL.Color3f(0, 0, 1);
            GL.Vertex3f(-1.0f, 1.0f, -1.0f);
            GL.Vertex3f(-1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);

            GL.Color3f(0, 1, 1);
            GL.Vertex3f(1.0f, -1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, -1.0f);
            GL.Vertex3f(1.0f, 1.0f, 1.0f);
            GL.Vertex3f(1.0f, -1.0f, 1.0f);

            GL.End();
        }

        #endregion
    }
}
