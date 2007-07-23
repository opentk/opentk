using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Platform;

namespace Examples.Windowing
{
    public partial class W01_DisplayModesForm : Form
    {
        OpenTK.Platform.IGLControl glWindow;

        public W01_DisplayModesForm()
        {
            InitializeComponent();

            glWindow = new GLControl();

            IEnumerable<DisplayMode> modes = glWindow.Context.GetDisplayModes();

            foreach (DisplayMode m in modes)
            {
                listBox1.Items.Add(m);
            }

        }
    }
}