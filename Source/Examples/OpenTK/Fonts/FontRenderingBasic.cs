// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Examples.WinForms
{
    [Example("Font rendering (basic)", ExampleCategory.OpenTK, "Fonts", Difficulty = 1, Documentation = "FontRenderingBasic", Visible=false)]
    public partial class FontRenderingBasic : Form
    {
        #region Fields

        float[] sizes = new float[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, 20, 24 };
        List<Font> fonts = new List<Font>();

        //TextPrinter printer = new TextPrinter();

        #endregion

        #region Constructors

        public FontRenderingBasic()
        {
            InitializeComponent();
            ResizeRedraw = true;

            glControl1.Width = ClientSize.Width;
            glControl1.Height = ClientSize.Height;
            
            UpdateFontList(fontDialog.Font);
            glControl1_Resize(this, EventArgs.Empty);
        }

        #endregion

        #region Private Members

        void UpdateFontList(Font base_font)
        {
            //printer.Clear();

            foreach (Font font in fonts)
                font.Dispose();
            fonts.Clear();
            foreach (float size in sizes)
                fonts.Add(new Font(base_font.Name, base_font.SizeInPoints + size, base_font.Style));
        }

        #endregion

        #region Events

        private void glControl1_Load(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();
        }

        private void changeFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                UpdateFontList(fontDialog.Font);
                glControl1.Invalidate();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            glControl1.Invalidate();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            glControl1.MakeCurrent();
            GL.ClearColor(Color.MidnightBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, glControl1.ClientSize.Width, glControl1.ClientSize.Height, 0, -1, 1);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            foreach (Font font in fonts)
            {
                //printer.Print(textBox1.Text, font, Color.White);
                GL.Translate(0, font.Height + 5, 0);
            }

            glControl1.SwapBuffers();
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();

            if (glControl1.ClientSize.Height == 0)
                glControl1.ClientSize = new System.Drawing.Size(glControl1.ClientSize.Width, 1);

            GL.Viewport(0, 0, glControl1.ClientSize.Width, glControl1.ClientSize.Height);
        }

        #endregion

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (FontRenderingBasic example = new FontRenderingBasic())
            {
                Utilities.SetWindowTitle(example);
                example.ShowDialog();
            }
        }

        #endregion
    }
}
