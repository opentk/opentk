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
using OpenTK.OpenGL.Enums;

#endregion

namespace Examples.WinForms
{
    [Example("Simple GLControl", ExampleCategory.WinForms, 1)]
    public partial class W01_First_Window : Form
    {
        public W01_First_Window()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine("Exception during initialization, aborting: {0}", e.ToString());
                this.Close();
                return;
            }
        }

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            glControl1_Resize(this, EventArgs.Empty);   // Ensure the Viewport is set up correctly
            GL.ClearColor(Color.Crimson);
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Crimson);
            glControl1.Invalidate();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Color.ForestGreen);
            glControl1.Invalidate();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            GL.ClearColor(Color.RoyalBlue);
            glControl1.Invalidate();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            glControl1.SwapBuffers();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (glControl1.ClientSize.Height == 0)
                glControl1.ClientSize = new System.Drawing.Size(glControl1.ClientSize.Width, 1);

            GL.Viewport(0, 0, glControl1.ClientSize.Width, glControl1.ClientSize.Height);
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

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (W01_First_Window example = new W01_First_Window())
            {
                // Get the title and category  of this example using reflection.
                ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                example.Text = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                example.ShowDialog();
            }
        }

        #endregion
    }
}
