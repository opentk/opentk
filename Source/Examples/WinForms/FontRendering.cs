using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;

namespace Examples.WinForms
{
    [Example("Font rendering sample", ExampleCategory.WinForms)]
    public partial class FontRendering : Form
    {
        #region Fields

        float[] sizes = new float[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 22, 24, 28, 32, 36, 42, 48 };
        List<Font> fonts = new List<Font>();

        TextPrinter text = new TextPrinter();

        #endregion

        #region Constructors

        public FontRendering()
        {
            InitializeComponent();

            UpdateFontList(fontDialog.Font);
            glControl1_Resize(this, EventArgs.Empty);
        }

        #endregion

        #region Private Members

        void UpdateFontList(Font base_font)
        {
            foreach (Font font in fonts)
                font.Dispose();
            fonts.Clear();
            foreach (float size in sizes)
                fonts.Add(new Font(base_font.Name, size, base_font.Style));
        }

        #endregion

        #region Events

        private void glControl1_Load(object sender, EventArgs e)
        {
            glControl1.MakeCurrent();
            GL.ClearColor(Color.SteelBlue);
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
            GL.ClearColor(Color.Red);
            glControl1.MakeCurrent();
            //GL.ClearColor(Color.Gainsboro);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            //GL.Color4(Color.Blue);
            //GL.BlendColor(0, 0, 0, 0);

            //text.Begin();

            RectangleF rect = new RectangleF();
            foreach (Font font in fonts)
            {
                text.Print(textBox1.Text, font, Color.White, rect);
                rect.Y += font.Height;
            }

            //text.End();

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
            using (FontRendering example = new FontRendering())
            {
                Utilities.SetWindowTitle(example);
                example.ShowDialog();
            }
        }

        #endregion
    }
}
