#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;
using Enums = OpenTK.OpenGL.Enums;
using OpenTK;
using OpenTK.Platform;

#endregion

namespace Examples.Windowing
{
    public partial class W02_Multiple_GLControls : Form
    {
        OpenTK.GLControl glWindow1, glWindow2;
        
        public W02_Multiple_GLControls()
        {
            InitializeComponent();

            timer1.Enabled = true;

            throw new NotImplementedException();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (glWindow1 != null)
                glWindow1.Dispose();

            if (glWindow2 != null)
                glWindow2.Dispose();
        }
        static float angle;

        #region Load event handler

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            OnResize(e);
        }

        #endregion
        
        int count;

        private void timer1_Tick(object sender, EventArgs e)
        {
            PaintGLScene();

            count++;

            if (count == 20)
                create1_Click(null, EventArgs.Empty);

            if (glWindow1 == null)
                return;

            //if (count == 60) 
            //    ToggleFullScreen();

            if (glWindow1.Fullscreen)
            {
                this.Location = new Point(this.Location.X + (int)(Math.Sin(count / (5 * Math.PI)) * 3),
                    this.Location.Y);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintGLScene();
        }

        private void PaintGLScene()
        {
            RenderToContext(glWindow1, 0);
            RenderToContext(glWindow2, 45);

        }

        private void RenderToContext(OpenTK.GLControl glWindow, float angle_add)
        {
            glWindow.Context.MakeCurrent();

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(Enums.EnableCap.DEPTH_TEST);

            GL.Viewport(0, 0, glWindow.Width, glWindow.Height);

            double ratio = 0.0;
            ratio = glWindow.Width / (double)glWindow.Height;

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);


            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotatef(angle + angle_add, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT | Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            glWindow.Context.SwapBuffers();
        }

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
                    //this.SetResolution(this.Width, this.Height, this.ColorDepth, !this.Fullscreen);
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

        private void create1_Click(object sender, EventArgs e)
        {
            glWindow1 = new OpenTK.GLControl();

            create1.Enabled = false;
            dispose1.Enabled = true;


            Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);

        }

        private void create2_Click(object sender, EventArgs e)
        {
            //glWindow2 = GLContext.Create(panel2, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 8, 0);
            glWindow2 = new GLControl(
                new DisplayMode(0, 0, new OpenTK.Platform.ColorDepth(32), 16, 0, 0, 2, false, false, false, 0.0f));

            create2.Enabled = false;
            dispose2.Enabled = true;
        }

        private void dispose1_Click(object sender, EventArgs e)
        {
            glWindow1.Dispose();
            glWindow1 = null;
            panel1.Invalidate();

            create1.Enabled = true;
            dispose1.Enabled = false;
        }

        private void dispose2_Click(object sender, EventArgs e)
        {
            glWindow2.Dispose();
            glWindow2 = null;
            panel2.Invalidate();

            create2.Enabled = true;
            dispose2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (glWindow1 == null)
                return;

            if (e.KeyCode == Keys.F1)
            {
                ToggleFullScreen();
            }
        }

        private void ToggleFullScreen()
        {
            glWindow1.Fullscreen = !glWindow1.Fullscreen;
            /*
            if (glWindow1.Fullscreen)
                glWindow1.SetWindowed();
            else
            {
                glWindow1.SetFullScreen(640, 480, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8));
            }
            */
        }
    }
}