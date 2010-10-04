#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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
using System.Diagnostics;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Build.Tasks
{
    /// <summary>
    /// Executes specified process, capturing its stdout/stderr output.
    /// Replaces Exec task which does not capture output.
    /// </summary>
    public class Run : Task
    {
        string command, wdir;

        /// <summary>
        /// The command to execute.
        /// </summary>
        [Required]
        public string Command
        {
            get { return command; }
            set { command = value; }
        }

        /// <summary>
        /// The working directory for the command.
        /// </summary>
        public string WorkingDirectory
        {
            get { return wdir; }
            set { wdir = value; }
        }

        public override bool Execute()
        {
            try
            {
                if (String.IsNullOrEmpty(command))
                {
                    return false;
                }

                // Split arguments from command:
                int arg_end = command.IndexOf(' ');
                ProcessStartInfo psi = null;
                if (arg_end > 0)
                {
                    psi = new ProcessStartInfo(command.Substring(0, arg_end), command.Substring(arg_end + 1));
                }
                else
                {
                    psi = new ProcessStartInfo(command);
                }

                psi.UseShellExecute = false;
                if (!String.IsNullOrEmpty(wdir))
                {
                    psi.WorkingDirectory = wdir;
                }
                
                Process p = new Process();
                p.ErrorDataReceived += LogErrors;
                p.OutputDataReceived += LogOutput;
                p.StartInfo = psi;

                Log.LogMessage("Running {0} {1} on directory {2}",
                    psi.FileName,
                    psi.Arguments,
                    String.IsNullOrEmpty(psi.WorkingDirectory) ?
                        Environment.CurrentDirectory : psi.WorkingDirectory);

                if (p.Start())
                    p.WaitForExit();
                return p.ExitCode == 0;
            }
            catch (Exception e)
            {
                Log.LogErrorFromException(e);
                return false;
            }
        }

        void LogErrors(object sender, DataReceivedEventArgs e)
        {
            Log.LogError(e.Data);
        }

        void LogOutput(object sender, DataReceivedEventArgs e)
        {
            Log.LogMessage(e.Data);
        }
    }
}
