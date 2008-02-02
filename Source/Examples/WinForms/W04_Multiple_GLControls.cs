using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Examples.WinForms
{
    [Example("Multiple GLControls test", ExampleCategory.WinForms, 4)]
    public partial class W04_Multiple_GLControls : Form
    {
        public W04_Multiple_GLControls()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            using (W04_Multiple_GLControls example = new W04_Multiple_GLControls())
            {
                Utilities.SetWindowTitle(example);
                example.ShowDialog();
            }
        }
    }
}