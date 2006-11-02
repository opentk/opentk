using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK.OpenGL;

namespace QueryDisplayModes
{
    public partial class DisplayModesForm : Form
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayModesForm());
        }

        GLContext context;

        public DisplayModesForm()
        {
            InitializeComponent();

            context = GLContext.Create(this, new OpenTK.OpenGL.ColorDepth(8, 8, 8, 8), 0, 0);

            DisplayMode[] modes = context.EnumDisplayModes();

            for (int i = 0; i < modes.Length; i++)
                listBox1.Items.Add(modes[i]);
        }
    }
}