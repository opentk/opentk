using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace Examples
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (Form browser = new ExampleBrowser())
                {
                    try
                    {
                        if (File.Exists("debug.log"))
                            File.Delete("debug.log");
                        if (File.Exists("trace.log"))
                            File.Delete("trace.log");
                    }
                    catch (Exception expt)
                    {
                        MessageBox.Show("Could not access debug.log", expt.ToString());
                    }

                    Debug.Listeners.Clear();
                    Debug.Listeners.Add(new TextWriterTraceListener("debug.log"));
                    Debug.Listeners.Add(new ConsoleTraceListener());

                    Trace.Listeners.Clear();
                    Trace.Listeners.Add(new TextWriterTraceListener("debug.log"));
                    Trace.Listeners.Add(new ConsoleTraceListener());

                    Application.Run(browser);
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
