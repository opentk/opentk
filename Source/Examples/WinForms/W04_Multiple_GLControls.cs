using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.OpenGL;

namespace Examples.WinForms
{
    public partial class W04_Multiple_GLControls : Form, IExample
    {
        public W04_Multiple_GLControls()
        {
            InitializeComponent();
        }

        #region IExample Members

        public void Launch()
        {
            
        }

        public static readonly int order = 4;

        #endregion
    }
}