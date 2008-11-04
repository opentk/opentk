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
using System.Threading;
using System.Reflection;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.OpenGL.Enums;
using OpenTK.Graphics;

namespace Examples.WinForms
{
    [Example("Extensions", ExampleCategory.WinForms, 3)]
    public partial class W03_Extensions : Form
    {
        GLControl glControl = new GLControl(GraphicsMode.Default);
        Type glClass;
        Type delegatesClass;
        //Type importsClass;
        int supported, all;      // Number of supported extensions.
        string driver;

        public W03_Extensions()
        {
            InitializeComponent();

            glClass = typeof(GL);
            delegatesClass = glClass.GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
            //importsClass = glClass.GetNestedType("Imports", BindingFlags.Static | BindingFlags.NonPublic);

            glControl.CreateControl();
            Application.Idle += StartAsync;
        }

        protected override void OnClosed(EventArgs e)
        {
            glControl.Dispose();
        }

        void StartAsync(object sender, EventArgs e)
        {
            Application.Idle -= StartAsync;

            driver =
                GL.GetString(StringName.Vendor) + " " +
                GL.GetString(StringName.Renderer) + " " +
                GL.GetString(StringName.Version);

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
                        ++supported;

                    //if (i % 500 != 0)
                        backgroundWorker1.ReportProgress((int)(((float)i / all) * 100.0f),
                            String.Format("({0}/{1}) {2}:\t{3}", i.ToString(), all, d != null ? "ok" : "failed", f.Name));
                    ++i;
                }
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.ToString(), "An error occured while loading extensions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        List<string> items = new List<string>();
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            items.Add(e.UserState as string);
            //listBox1.Items.Add(e.UserState as string);
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBox1.Items.AddRange(items.ToArray());
            this.Text = String.Format("{0}: {1}/{2} OpenGL functions supported.",
                driver, supported, all);
        }

        #region public static void Main()

        /// <summary>
        /// Entry point of this example.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            using (W03_Extensions example = new W03_Extensions())
            {
                Utilities.SetWindowTitle(example);
                example.ShowDialog();
            }
        }

        #endregion
    }
}