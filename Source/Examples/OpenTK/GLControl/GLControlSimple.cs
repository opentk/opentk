// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using System.Windows.Forms;

using OpenTK.Graphics.OpenGL;

namespace Examples.WinForms
{
    [Example("GLControl Simple", ExampleCategory.OpenTK, "GLControl", 1, Documentation="GLControlSimple")]
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();
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
            glControl1.MakeCurrent();

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
            using (SimpleForm example = new SimpleForm())
            {
                Utilities.SetWindowTitle(example);
                example.ShowDialog();
            }
        }

        #endregion
    }
}
