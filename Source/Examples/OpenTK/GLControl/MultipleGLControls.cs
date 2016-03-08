﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.


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
    [Example("Multiple GLControls", ExampleCategory.OpenTK, "GLControl", 3, Documentation="MultipleGLControls")]
    public partial class MultipleGLControlsForm : Form
    {
        public MultipleGLControlsForm()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            using (MultipleGLControlsForm example = new MultipleGLControlsForm())
            {
                Utilities.SetWindowTitle(example);
                example.ShowDialog();
            }
        }
    }
}