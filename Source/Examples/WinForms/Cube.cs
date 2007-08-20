#region --- License ---
/* This source file is released under the MIT license. See License.txt for more information.
 * Coded by Erik Ylvisaker and Stefanos Apostolopoulos.
 */
#endregion

#region --- Using directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using OpenTK.OpenGL;
//using Enums = OpenTK.OpenGL.GL.Enums;
using OpenTK.Platform;
using System.Threading;

#endregion

namespace Examples.WinForms
{
    public partial class Cube : Form, IExample
    {
        static float angle;

        #region --- Constructor ---

        public Cube()
        {
            InitializeComponent();
           
            Application.Idle += Application_Idle;

            this.ShowDialog();
        }

        #endregion

        #region Closing event

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            Application.Idle -= Application_Idle;
        }

        #endregion

        #region Application_Idle event

        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl.IsIdle)
            {
                Render();
            }
        }

        #endregion

        #region private void Render()

        private void Render()
        {
            GL.MatrixMode(GL.Enums.MatrixMode.MODELVIEW);
            GL.LoadIdentity();
            Glu.LookAt(
                0.0, 5.0, 5.0,
                0.0, 0.0, 0.0,
                0.0, 1.0, 0.0
            );
            GL.Rotatef(angle, 0.0f, 1.0f, 0.0f);
            angle += 0.5f;

            GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT | GL.Enums.ClearBufferMask.DEPTH_BUFFER_BIT);

            DrawCube();

            glControl.Context.SwapBuffers();
            Thread.Sleep(0);
        }

        #endregion

        #region Load event handler

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text =
                GL.GetString(GL.Enums.StringName.VENDOR) + " " +
                GL.GetString(GL.Enums.StringName.RENDERER) + " " +
                GL.GetString(GL.Enums.StringName.VERSION);

            GL.ClearColor(0.1f, 0.1f, 0.5f, 0.0f);
            GL.Enable(GL.Enums.EnableCap.DEPTH_TEST);

            glControl.KeyDown += new KeyEventHandler(Cube_KeyDown);

            OnResize(e);
        }
        
        #endregion

        #region Resize event handler

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (ClientSize.Height == 0)
                ClientSize = new System.Drawing.Size(ClientSize.Width, 1);

            GL.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

            double ratio = 0.0;
            ratio = ClientSize.Width / (double)ClientSize.Height;
            //if (ClientSize.Width > ClientSize.Height)
            //    ratio = ClientSize.Width / (double)ClientSize.Height;
            //else
            //    ratio = ClientSize.Height / (double)ClientSize.Width;

            GL.MatrixMode(GL.Enums.MatrixMode.PROJECTION);
            GL.LoadIdentity();
            Glu.Perspective(45.0, ratio, 1.0, 64.0);
        }

        #endregion

        #region Paint event handler

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Render();
        }

        #endregion

        #region KeyDown event handler

        void Cube_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Shift)
            {
                //this.SetResolution(this.Width, this.Height, this.ColorDepth, !this.IsFullscreen);
                glControl.Fullscreen = !glControl.Fullscreen;
            }

            switch (e.KeyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        #endregion

		#region private void DrawCube()

        private void DrawCube()
        {
            GL.Begin(GL.Enums.BeginMode.QUADS);

            GL.Color3((byte)Color.Silver.R, (byte)Color.Silver.G, (byte)Color.Silver.B);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);

            GL.Color3((byte)Color.Honeydew.R, (byte)Color.Honeydew.G, (byte)Color.Honeydew.B);
            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);

            GL.Color3((byte)Color.Moccasin.R, (byte)Color.Moccasin.G, (byte)Color.Moccasin.B);

            GL.Vertex3(-1.0f, -1.0f, -1.0f);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);

            GL.Color3((byte)Color.IndianRed.R, (byte)Color.IndianRed.G, (byte)Color.IndianRed.B);
            GL.Vertex3(-1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);

            GL.Color3((byte)Color.PaleVioletRed.R, (byte)Color.PaleVioletRed.G, (byte)Color.PaleVioletRed.B);
            GL.Vertex3(-1.0f, 1.0f, -1.0f);
            GL.Vertex3(-1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);

            GL.Color3((byte)Color.ForestGreen.R, (byte)Color.ForestGreen.G, (byte)Color.ForestGreen.B);
            GL.Vertex3(1.0f, -1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, -1.0f);
            GL.Vertex3(1.0f, 1.0f, 1.0f);
            GL.Vertex3(1.0f, -1.0f, 1.0f);

            GL.End();
        }

        #endregion
        
        #region IExample Members

        public void Launch()
        {
            
        }

        #endregion
    }
}
