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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        	try
        	{
	            if (File.Exists("debug.log"))
	                File.Delete("debug.log");
        	}
        	catch (Exception e)
        	{
        		MessageBox.Show("Could not access debug.log", e.ToString());
        	}

        	Debug.Listeners.Add(new TextWriterTraceListener("debug.log"));
            Debug.Listeners.Add(new ConsoleTraceListener());
        	                    
            try
            {
                using (Form exampleLauncher = new ExampleLauncher())
                {
                    Application.EnableVisualStyles();
                    Application.Run(exampleLauncher);
                }
            }
            finally
            {
                Debug.Flush();
                Debug.Close();
                Trace.Flush();
                Trace.Close();
            }
        }

        public ExampleLauncher()
        {
            InitializeComponent();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Type example =
                    Assembly.GetExecutingAssembly().GetType(
                        "Examples." + listBox1.SelectedItem.ToString().Replace(": ", ".").Replace(' ', '_'),
                        true,
                        true);
                
                Debug.Print("Launching example: {0}", example.ToString());

                if (example.BaseType == typeof(GameWindow))
                {
                    // Start the GameWindow in a new thread - it runs its own message loop, and it would
                    // interfere with the message loop of the ExampleLauncher.
                    new Thread(Launch).Start(example);
                }
                else if (example.BaseType == typeof(Form))
                {
                    try
                    {
                        // In this we do not want a different thread: these examples rely on the Application.Idle
                        // event, which would then be raised by both the ExampleLauncher thread *and* the new one!
                        this.AddOwnedForm((Form)example.GetConstructor(Type.EmptyTypes).Invoke(null));
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
                    }
                }
            }
        }

        void Launch(object example)
        {
            Type ex = example as Type;
            try
            {
                (ex.GetConstructor(Type.EmptyTypes).Invoke(null) as IExample).Launch();
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
            }
        }

        public void ExampleLauncher_Load(object sender, EventArgs e)
        {
            SortedList<string, string> sl = new SortedList<string, string>();

            // Get all examples
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                if (type.GetInterface("IExample") != null)
                {
                    sl.Add(
                        (type.Namespace.Replace("Examples.", String.Empty) + ": " + type.Name).Replace('_', ' '),
                        null
                    );
                }
            }

            foreach (string s in sl.Keys)
                listBox1.Items.Add(s);

            // Select first item
            if (listBox1.Items.Count > 0)
            {
                this.listBox1.SelectedIndex = 0;
            }
        }
    }
}
