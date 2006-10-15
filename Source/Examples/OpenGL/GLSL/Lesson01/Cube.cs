#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using OpenTK;
using OpenTK.OpenGL;

namespace OpenTK.Examples.OpenGL.GLSL
{
    public partial class Cube : OpenTK.Frameworks.Framework
    {
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

        #region Load event handler
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            int vertex_shader_object, fragment_shader_object;
            int[] status = new int[1];
            int shader_program;

            vertex_shader_object = GL.CreateShader(Enums.VERSION_2_0.VERTEX_SHADER);
            fragment_shader_object = GL.CreateShader(Enums.VERSION_2_0.FRAGMENT_SHADER);

            GL.ShaderSource(vertex_shader_object, vertex_shader_source.Length, vertex_shader_source, IntPtr.Zero);
            GL.CompileShader(vertex_shader_object);
            GL.GetShaderiv(vertex_shader_object, Enums.VERSION_2_0.COMPILE_STATUS, status);
            if (status[0] != (int)Enums.Boolean.TRUE)
            {
                StringBuilder info = new StringBuilder(1024);
                GL.GetShaderInfoLog(vertex_shader_object, 1024, null, info);

                throw new Exception(info.ToString());
            }

            GL.ShaderSource(fragment_shader_object, fragment_shader_source.Length, fragment_shader_source, IntPtr.Zero);
            GL.CompileShader(fragment_shader_object);
            GL.GetShaderiv(fragment_shader_object, Enums.VERSION_2_0.COMPILE_STATUS, status);
            if (status[0] != (int)Enums.Boolean.TRUE)
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

            OnResize(e);
        }
        #endregion

        #region Resize event handler
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

//            if (this.Context == null)
//                return;
            
            if (ClientSize.Height == 0)
                ClientSize = new System.Drawing.Size(ClientSize.Width, 1);

            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            double ratio = 0.0;
            ratio = ClientSize.Width / (double)ClientSize.Height;
            //if (ClientSize.Width > ClientSize.Height)
            //    ratio = ClientSize.Width / (double)ClientSize.Height;
            //else
            //    ratio = ClientSize.Height / (double)ClientSize.Width;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }
        #endregion

        #region Paint event handler

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.05f;

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            Context.SwapBuffers();
        }

        #endregion

        #region KeyDown event handler

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyData)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;

                case Keys.F1:
                    //this.Fullscreen = !this.Fullscreen;
                    break;
            }
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

        #region Entry point
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Cube());
        }
        #endregion
    }
}
