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

        private TextWriter _writer;

        public DebugFileLogger(string fileName = "OpenTK_debug.log")
        {
            string path = Path.Combine(".", fileName);
            _writer = new StreamWriter(path);
        }

        void ILogger.LogInternal(string str, LogLevel level, string filePath, int lineNumber, string member)
        {
            if (level < Filter)
            {
                return;
            }

            _writer.Write($"[{level}] {member} {Path.GetFileName(filePath)}:{lineNumber} ");
            _writer.WriteLine(str);
        }
    }
}
