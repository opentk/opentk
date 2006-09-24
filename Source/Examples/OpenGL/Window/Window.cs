using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenTK.OpenGL;


namespace OpenTK.OpenGL.Test
{
    public partial class Window : Form
    {
        public Context context;

        public Window()
        {
            InitializeComponent();
            context = Context.Create(this, 8, 8, 8, 8, 16, 0, false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);
            
            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);

            OnResize(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (ClientSize.Height == 0)
                ClientSize = new System.Drawing.Size(ClientSize.Width, 1);

            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();

            Glu.Perspective(45.0, ClientSize.Width / (double)ClientSize.Height, 1.0, 64.0);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 0.0, 5.0,
                0.0, 0.0, -1.0,
                0.0, 1.0, 0.0
                );

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.Begin(Enums.BeginMode.TRIANGLES);

            GL.Color3f(1.0f, 0.0f, 0.0f); GL.Vertex3i(-1, -1, 1);
            GL.Color3f(0.0f, 0.0f, 1.0f); GL.Vertex3i(1, -1, 1);
            GL.Color3f(0.0f, 1.0f, 0.0f); GL.Vertex3i(1, 1, 1);

            GL.End();

            context.SwapBuffers();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Window());
        }
    }
}