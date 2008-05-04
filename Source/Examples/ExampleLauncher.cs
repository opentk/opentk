#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.IO;

using OpenTK;

#endregion

namespace Examples
{
    public partial class ExampleLauncher : Form
    {
        bool show_hidden;
        List<ExampleInfo> hidden_items = new List<ExampleInfo>();

        #region class ExampleInfo

        /// <summary>
        /// Contains the information necessary to display and launch an example thorugh the ExampleLauncer.
        /// </summary>
        class ExampleInfo
        {
            public Type Example;
            public ExampleAttribute Attributes;

            public ExampleInfo(Type example, ExampleAttribute attr)
            {
                Example = example;
                Attributes = attr;
            }

            public override string ToString()
            {
                return Attributes.ToString();
            }
        }

        #endregion

        #region --- Constructor ---

        public ExampleLauncher()
        {
            InitializeComponent();
        }

        #endregion

        #region public void ExampleLauncher_Load(object sender, EventArgs e)

        public void ExampleLauncher_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("debug.log"))
                    File.Delete("debug.log");
            }
            catch (Exception expt)
            {
                MessageBox.Show("Could not access debug.log", expt.ToString());
            }

            Debug.Listeners.Clear();
            Debug.Listeners.Add(new TextWriterTraceListener("debug.log"));
            Debug.Listeners.Add(new ConsoleTraceListener());
            Debug.AutoFlush = true;

            // Get all examples
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            StringBuilder sb = new StringBuilder();
            foreach (Type type in types)
            {
                object[] attributes = type.GetCustomAttributes(false);
                ExampleAttribute example = null;
                foreach (object attr in attributes)
                    if (attr is ExampleAttribute)
                        example = (ExampleAttribute)attr;

                if (example != null)
                {
                    //sb.Append(example.Category);
                    //sb.Append(" ");
                    //if (example.Difficulty < 10)
                    //    sb.Append("0");         // To keep items nicely sorted.
                    //sb.Append(example.Difficulty);
                    //sb.Append(": ");
                    ////sb.Append(type.Name);
                    //sb.Append(example.Title);

                    if (example.Visible)
                        listBox1.Items.Add(new ExampleInfo(type, example));
                    else
                    {
#if DEBUG
                        example.Title += " (hidden)";
                        listBox1.Items.Add(new ExampleInfo(type, example));
#else
                        hidden_items.Add(new ExampleInfo(type, example));
#endif
                    }
                        // Clean the StringBuilder for the next pass.
                    sb.Remove(0, sb.Length);
                }
            }
            // Select first item
            if (listBox1.Items.Count > 0)
                this.listBox1.SelectedIndex = 0;

            RaiseWindow();
        }

        #endregion

        void RaiseWindow()
        {
            // Force the ExampleLauncher to appear.
            this.TopMost = false;
            this.TopMost = true;
            this.TopMost = false;
        }

        #region private void RunExample()

        private void RunExample()
        {
            if (listBox1.SelectedItem != null)
            {
                try
                {
                    ExampleInfo info = (ExampleInfo)listBox1.SelectedItem;
                    Type example = info.Example;

                    Debug.Print("Launching example: {0}", example.ToString());
                    this.Visible = false;

                    example.GetMethod("Main").Invoke(null, null);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();

                }
                catch (TargetInvocationException expt)
                {
                    string ex_info;
                    if (expt.InnerException != null)
                        ex_info = expt.InnerException.ToString();
                    else
                        ex_info = expt.ToString();
                    MessageBox.Show(ex_info, "An OpenTK example encountered an error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Debug.Print(expt.ToString());
#if DEBUG
                    //throw;
#endif
                }
                catch (NullReferenceException expt)
                {
                    MessageBox.Show(expt.ToString(), "The Example launcher failed to load the example.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    this.Visible = true;
                    RaiseWindow();
                }
            }
        }

        #endregion

        #region Launcher events

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            RunExample();
        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    RunExample();
                    break;

                // On Ctrl+F1 enable hidden items (for debugging/testing OpenTK)
                case Keys.F1:
                    if (e.Control)
                        show_hidden = !show_hidden;

                    if (show_hidden)
                        listBox1.Items.AddRange(hidden_items.ToArray());
                    else
                        foreach (ExampleInfo item in hidden_items)
                            listBox1.Items.Remove(item);

                    break;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            RunExample();
        }

        private void ExampleLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Flush();
            Debug.Close();
            Trace.Flush();
            Trace.Close();
        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //FileIOPermission fileIO = new FileIOPermission(FileIOPermissionAccess.AllAccess, ".");
                //fileIO.Demand();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);
                using (Form exampleLauncher = new ExampleLauncher())
                {
                    Application.Run(exampleLauncher);
                }

            }
            catch (System.Security.SecurityException e)
            {
                MessageBox.Show("The Example Launcher failed to start, due to insufficient permissions. This may happen if you execute the application from a network share.", "OpenTK Example Launcher failed to start.",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Trace.WriteLine(e.ToString());
            }
        }
    }
}
