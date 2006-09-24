/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using OpenTK.OpenGL;

namespace Test
{
    class Program : Form
    {
        public Context context;

        Program()
        {
            context = Context.Create(this, 8, 8, 8, 8, 0, 0, false);
            //this.Text =
            //    GL.GetString(Enums.StringName.VENDOR) + " " +
            //    GL.GetString(Enums.StringName.RENDERER) + " " +
            //    GL.GetString(Enums.StringName.VERSION);
            Text = Width.ToString() + "x" + Height.ToString();
            this.CenterToScreen();
            this.ResizeRedraw = true;
        }

        protected override void OnResize(EventArgs e)
        {
            System.Drawing.Size size = ClientSize;

            if (size.Height == 0)
                size.Height = 1;
            
            // Set the viewport to be the entire window
            GL.Viewport(0, 0, size.Width, size.Height);

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, (double)size.Width / (double)size.Height, 1.0, 20.0);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt( 0.0,  0.0, -5.0,
                        0.0,  0.0,  1.0,
                        0.0,  1.0,  0.0 );

            Text = "Size: " + size.Width.ToString() + "x" + size.Height.ToString();

            ClientSize = size;
            
            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.PushMatrix();

            GL.Begin(Enums.BeginMode.TRIANGLES);

            GL.Color3f(1.0f, 0.0f, 0.0f); GL.Vertex3f(-0.5f, -0.5f, 5.0f);
            GL.Color3f(0.0f, 1.0f, 0.0f); GL.Vertex3f( 0.5f, -0.5f, 5.0f);
            GL.Color3f(0.0f, 0.0f, 1.0f); GL.Vertex3f( 0.0f,  0.5f, 5.0f);

            GL.End();

            GL.PopMatrix();

            context.SwapBuffers();
            
            base.OnPaint(e);
        }

        [STAThread]
        static void Main()
        {
            Thread.Sleep(100);
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Name = "Program";
            this.ResumeLayout(false);

        }
    }
}