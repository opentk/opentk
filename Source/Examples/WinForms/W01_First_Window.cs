#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
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

using OpenTK;
using OpenTK.OpenGL;

#endregion

namespace Examples.WinForms
{
    public partial class W01_First_Window : Form, IExample
    {
        public W01_First_Window()
        {
            InitializeComponent();

            this.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            glControl1.CreateContext();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            //GL.ClearColor(0.7f, 0.0f, 0.0f, 0.0f);
            //glControl1.Invalidate();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            //GL.ClearColor(0.0f, 0.5f, 0.0f, 0.0f);
            //glControl1.Invalidate();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            //GL.ClearColor(0.0f, 0.0f, 0.7f, 0.0f);
            //glControl1.Invalidate();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            //GL.Clear(GL.Enums.ClearBufferMask.COLOR_BUFFER_BIT);
            //glControl1.SwapBuffers();
        }

        private void glControl1_Resize(object sender, OpenTK.Platform.ResizeEventArgs e)
        {
            //if (glControl1.ClientSize.Height == 0)
            //    glControl1.ClientSize = new System.Drawing.Size(glControl1.ClientSize.Width, 1);

            //GL.Viewport(0, 0, glControl1.ClientSize.Width, glControl1.ClientSize.Height);
        }

        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        #region IExample Members

        public void Launch()
        {
            
        }

        #endregion
    }
}
