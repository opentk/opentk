#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

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
using System.Threading;

namespace Examples.WinForms
{
    public partial class W03_Extensions : Form, IExample
    {
        GLControl glControl = new GLControl();
        Assembly assembly;
        Type glClass;
        Type delegatesClass;
        Type importsClass;
        int supported, all;      // Number of supported extensions.
        string driver;

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

            driver =
                GL.GetString(GL.Enums.StringName.VENDOR) + " " +
                GL.GetString(GL.Enums.StringName.RENDERER) + " " +
                GL.GetString(GL.Enums.StringName.VERSION);

            all = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic).Length;
            this.Text = String.Format("Loading {0} functions...", all);

            this.backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FieldInfo[] v = delegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            int i = 0;
            
            try
            {
                foreach (FieldInfo f in v)
                {
                    object d = f.GetValue(delegatesClass);
                    if (d != null)
                    {
                        ++supported;
                    }

                    backgroundWorker1.ReportProgress((int)(((float)i / all) * 100.0f),
                        String.Format("({0}/{1}) {2}:\t{3}", (++i).ToString(), all, d != null ? "ok" : "failed", f.Name));
                }
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.ToString(), "An error occured while loading extensions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(e.UserState as string);
            /*
            if ((e.UserState as string).Contains("failed"))
            {
                Graphics c = listBox1.CreateGraphics();
                c.
                c.DrawRectangle(new Pen(Color.Gray), listBox1.GetItemRectangle(listBox1.Items.Count - 1));
                c.Dispose();
            }
            else
            {
            }
            */
        }

        #region IExample Members

        public void Launch()
        {

        }

        #endregion

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Text = String.Format("{0}: {1}/{2} OpenGL functions supported.",
                driver, supported, all);
        }
    }
}