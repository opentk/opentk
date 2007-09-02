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
        SortedList<string, string> examples = new SortedList<string, string>();

        public ExampleLauncher()
        {
            InitializeComponent();
        }

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
            foreach (Type type in types)
            {
                if (type.GetInterface("IExample") != null)
                {
                    examples.Add(
                        type.Namespace.Replace("Examples.", String.Empty) + " " +
                        type.Name.Substring(1, 2) + ": " +
                        type.Name.Substring(3).Replace('_', ' '),
                        type.Namespace + "." + type.Name);
                }
            }

            foreach (string s in examples.Keys)
                listBox1.Items.Add(s);

            // Select first item
            if (listBox1.Items.Count > 0)
            {
                this.listBox1.SelectedIndex = 0;
            }
        }

        delegate void LaunchDelegate(object example);

        void Launch(object example)
        {
            Type ex = example as Type;
            try
            {
                (ex.GetConstructor(Type.EmptyTypes).Invoke(null) as IExample).Launch();
            }
            catch (Exception expt)
            {
                MessageBox.Show(String.Format("Stacktrace:{0}{1}{0}{0}Inner exception:{0}{2}",
                    System.Environment.NewLine, expt.StackTrace, expt.InnerException), expt.Message);
            }
        }

        private void RunExample()
        {
            if (listBox1.SelectedItem != null)
            {
                Type example = Assembly.GetExecutingAssembly().GetType(
                    examples[listBox1.SelectedItem.ToString()], true, true);

                Debug.Print("Launching example: {0}", example.ToString());
                this.Visible = false;

                if (example.BaseType == typeof(GameWindow))
                {
                    // Start the GameWindow in a new thread - it runs its own message loop, and it would
                    // interfere with the message loop of the ExampleLauncher.
                    //Thread t = new Thread(Launch);
                    //t.Start(example);
                    //t = null;
                    Launch(example);
                    //IAsyncResult res = BeginInvoke(new LaunchDelegate(Launch), example);
                    //EndInvoke(res);
                }
                else if (example.BaseType == typeof(Form))
                {
                    try
                    {
                        // In this we do not want a different thread: these examples rely on the Application.Idle
                        // event, which would then be raised by both the ExampleLauncher thread *and* the new one!
                        Form f = (Form)example.GetConstructor(Type.EmptyTypes).Invoke(null);
                        f.ShowDialog(this);
                        f.Dispose();
                        f = null;
                    }
                    catch (Exception expt)
                    {
                        MessageBox.Show(
                            String.Format(
                                "Stacktrace:{0}{1}{0}{0}Inner exception:{0}{2}",
                                System.Environment.NewLine,
                                expt.StackTrace,
                                expt.InnerException
                            ),
                            expt.Message);

                        throw;
                    }
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
