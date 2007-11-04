#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
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
        #region class ExampleInfo

        /// <summary>
        /// Contains the information necessary to display and launch an example thorugh the ExampleLauncer.
        /// </summary>
        class ExampleInfo
        {
            public string Name;
            public string Description;
            public Type Example;

            public ExampleInfo(string name, string description, Type example)
            {
                Name = name;
                Description = description;
                Example = example;
            }

            public override string ToString()
            {
 	             return Name;
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
                if (type.GetInterface("IExample") != null)
                {
                    sb.Append(type.Namespace);
                    sb.Replace("Examples.", String.Empty);
                    sb.Append(" ");
                    int order;
                    try
                    {
                        FieldInfo info = type.GetField("order");
                        order = (int)info.GetValue(null);
                    }
                    catch (NullReferenceException nre)
                    {
                        Debug.Print("Example {0} does not have ordering info", type.FullName);
                        order = 0;
                    }
                    if (order < 10)
                        sb.Append("0"); // To keep items sorted nicely.
                    sb.Append(order.ToString());
                    sb.Append(": ");
                    sb.Append(type.Name);

                    listBox1.Items.Add(new ExampleInfo(sb.ToString(), "", type));
                    
                    // Clean the StringBuilder for the next pass.
                    sb.Remove(0, sb.Length);
                }
            }
            // Select first item
            if (listBox1.Items.Count > 0)
                this.listBox1.SelectedIndex = 0;
        }

        #endregion

        private void RunExample()
        {
            if (listBox1.SelectedItem != null)
            {
                Type example = (listBox1.SelectedItem as ExampleInfo).Example;

                Debug.Print("Launching example: {0}", example.ToString());
                this.Visible = false;

                try
                {
                    if (example.BaseType == typeof(GameWindow))
                    {
                        using (GameWindow gw = (GameWindow)(example.GetConstructor(Type.EmptyTypes).Invoke(null)))
                        {
                            (gw as IExample).Launch();
                        }
                    }
                    else if (example.BaseType == typeof(Form))
                    {
                        using (Form f = (Form)example.GetConstructor(Type.EmptyTypes).Invoke(null))
                        {
                            f.ShowDialog(this);
                        }
                    }
                    else
                    {
                        // Console application.
                        IExample ex = (IExample)example.GetConstructor(Type.EmptyTypes).Invoke(null);
                        ex.Launch();
                    }

                }
                catch (Exception expt)
                {
#if DEBUG
                    throw;
#else
                    if (expt.InnerException != null)
                        MessageBox.Show(expt.InnerException.ToString(), "An error has occured: \"" +
                                        expt.InnerException.Message + "\"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show(expt.ToString(), "An error has occured: \"" + expt.Message + "\"",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
#endif

                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                this.Visible = true;
            }
        }

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
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            RunExample();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Form exampleLauncher = new ExampleLauncher())
            {
                Application.EnableVisualStyles();
                Application.Run(exampleLauncher);
            }
        }

        private void ExampleLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.Flush();
            Debug.Close();
            Trace.Flush();
            Trace.Close();
        }
    }
}
