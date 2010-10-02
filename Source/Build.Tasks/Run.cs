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
        string command, args, wdir;

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
