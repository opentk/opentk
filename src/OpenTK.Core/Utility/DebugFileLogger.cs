using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Utility
{
    /// <summary>
    /// A logger used to create an opentk debug file in the current directory.
    /// </summary>
    public class DebugFileLogger : ILogger
    {
        public LogLevel Filter { get; set; } = LogLevel.Debug;

        public TextWriter Writer { get; set; }

        public DebugFileLogger(string fileName = "OpenTK_debug.log")
        {
            string path = Path.Combine(".", fileName);
            Writer = new StreamWriter(path);
        }

        void ILogger.LogInternal(string str, LogLevel level, string filePath, int lineNumber, string member)
        {
            if (level < Filter)
            {
                return;
            }

            Writer.Write($"[{level}] {member} {Path.GetFileName(filePath)}:{lineNumber} ");
            Writer.WriteLine(str);
        }
    }
}
