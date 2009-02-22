using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics;

namespace Examples.WinForms
{
    public partial class DerivedGLControl : GLControl
    {
        Color clearColor;
        
        public DerivedGLControl()
        {
            this.InitializeComponent();
        }

        public Color ClearColor
        {
            get { return clearColor; }
            set
            {
                clearColor = value;

                if (!this.DesignMode)
                {
                    MakeCurrent();
                    GL.ClearColor(clearColor);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!this.DesignMode)
            {
                MakeCurrent();
                GL.Clear(ClearBufferMask.ColorBufferBit);
                SwapBuffers();
            }
        }
    }
}
