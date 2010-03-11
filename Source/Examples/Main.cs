#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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
