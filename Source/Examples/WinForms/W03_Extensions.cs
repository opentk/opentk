using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using OpenTK;
using System.Reflection;
using OpenTK.OpenGL;

namespace Examples.WinForms
{
    public partial class W03_Extensions : Form//, IExample
    {
        GLControl glControl = new GLControl();
        Assembly assembly;
        Type glClass;
        Type delegatesClass;
        Type importsClass;

        public W03_Extensions()
        {
            InitializeComponent();

            assembly = Assembly.Load("OpenTK");
            glClass = assembly.GetType("OpenTK.OpenGL.GL");
            delegatesClass = glClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            importsClass = glClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            glControl.CreateContext();

            FieldInfo[] v = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);

            int i = 0, supported = 0;

            try
            {
                foreach (FieldInfo f in v)
                {
                    Delegate d = GL.GetDelegate(f.Name, f.FieldType);

                    f.SetValue(null, d);
                    this.listBox1.Items.Add(String.Format("{0}/{1} {2}: {3}",
                        (++i).ToString(), v.Length, d != null ? "ok" : "failed", f.Name));

                    if (d != null)
                    {
                        ++supported;
                    }
                }

                this.Text = String.Format("Supported extensions: {0}", supported);
            }
            catch (Exception expt)
            {
                MessageBox.Show("An error occured while loading extensions", "Extension loading failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        #region IExample Members

        public void Launch()
        {
            
        }

        #endregion
    }
}