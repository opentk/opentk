/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */

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
    public partial class TwoContexts : Form
    {
        Context context1, context2;

        public TwoContexts()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            context1 = Context.Create(panel1, 8, 8, 8, 8, 0, 0, false);
            context2 = Context.Create(panel2, 8, 8, 8, 8, 0, 0, false);

            Text =
                GL.GetString(Enums.StringName.VENDOR) + " " +
                GL.GetString(Enums.StringName.RENDERER) + " " +
                GL.GetString(Enums.StringName.VERSION);

            context1.MakeCurrent();
            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);

            context2.MakeCurrent();
            GL.ClearColor(0.7f, 0.1f, 0.1f, 0.0f);

            panel1_Resize(null, null);
            panel2_Resize(null, null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            context1.MakeCurrent();

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 0.0, 5.0,
                0.0, 0.0, -1.0,
                0.0, 1.0, 0.0
                );

            GL.Begin(Enums.BeginMode.TRIANGLES);

            GL.Color3f(1.0f, 0.0f, 0.0f); GL.Vertex3f(-1.0f, -1.0f, -5.0f);
            GL.Color3f(0.0f, 0.0f, 1.0f); GL.Vertex3f( 1.0f,  1.0f, -5.0f);
            GL.Color3f(0.0f, 1.0f, 0.0f); GL.Vertex3f(-1.0f,  1.0f, -5.0f);

            GL.End();

            context1.SwapBuffers();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            context1.MakeCurrent();

            if (panel1.ClientSize.Height == 0)
                panel1.ClientSize = new System.Drawing.Size(panel1.ClientSize.Width, 1);

            GL.Viewport(0, 0, panel1.ClientSize.Width, panel1.ClientSize.Height);

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();

            Glu.Perspective(45.0, panel1.ClientSize.Width / (double)panel1.ClientSize.Height, 1.0, 64.0);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            context2.MakeCurrent();

            GL.Clear(Enums.ClearBufferMask.COLOR_BUFFER_BIT);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 0.0, 5.0,
                0.0, 0.0, -1.0,
                0.0, 1.0, 0.0
                );

            GL.Begin(Enums.BeginMode.TRIANGLES);

            GL.Color3f(1.0f, 0.0f, 0.0f); GL.Vertex3f(-1.0f, -1.0f, -5.0f);
            GL.Color3f(0.0f, 0.0f, 1.0f); GL.Vertex3f(1.0f, 1.0f, -5.0f);
            GL.Color3f(0.0f, 1.0f, 0.0f); GL.Vertex3f(-1.0f, 1.0f, -5.0f);

            GL.End();

            context2.SwapBuffers();
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            context2.MakeCurrent();

            if (panel2.ClientSize.Height == 0)
                panel2.ClientSize = new System.Drawing.Size(panel2.ClientSize.Width, 1);

            GL.Viewport(0, 0, panel2.ClientSize.Width, panel2.ClientSize.Height);

            GL.MatrixMode(Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();

            Glu.Perspective(45.0, panel2.ClientSize.Width / (double)panel2.ClientSize.Height, 1.0, 64.0);

            GL.MatrixMode(Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new TwoContexts());
        }
    }
}