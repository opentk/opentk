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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using OpenTK;

namespace Examples
{
    static class Program
    {
        static void LaunchExample(string type)
        {
            try
            {
                if (File.Exists("debug.log"))
                    File.Delete("debug.log");
                if (File.Exists("trace.log"))
                    File.Delete("trace.log");
            }
            catch (Exception e)
            {
                Trace.WriteLine(String.Format("Could not access debug.log", e.ToString()));
            }

            ToolkitOptions options = ToolkitOptions.Default;
            if (type.Contains("GLControl") || type.Contains("Form"))
            {
                // SDL does not currently support embedding in foreign windows
                // such as GLControl. We need to use a native OpenTK.Platform
                // backend in that case. This hack is specific to the example-browser
                // architecture - you do not need to do anything like this in your
                // own code (it will just work).
                options = new ToolkitOptions
                {
                    Backend = PlatformBackend.PreferNative
                };
            }

            using (TextWriterTraceListener dbg = new TextWriterTraceListener("debug.log"))
            using (Toolkit.Init(options))
            {
                Trace.Listeners.Add(dbg);

                try
                {
                    var example = Type.GetType(type);
                    if (example != null)
                    {
                        example.InvokeMember("Main",
                            BindingFlags.InvokeMethod | BindingFlags.Static |
                            BindingFlags.Public | BindingFlags.NonPublic,
                            null, null, null);
                    }
                }
                catch (Exception e)
                {
                    Trace.WriteLine(String.Format("Exception occured in example {0}: {1}",
                        type, e.ToString()));
                }

                Trace.Listeners.Remove(dbg);

                dbg.Flush();
                dbg.Close();
            }
        }

        [STAThread]
        public static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());

            if (args.Length > 0)
            {
                LaunchExample(args[0]);
            }
            else
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    using (Form browser = new ExampleBrowser())
                    {
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
}
