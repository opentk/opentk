using System.IO;

namespace OpenTK.Core.Utility
{
    /// <summary>
    /// A logger used to create an opentk debug file in the current directory.
    /// </summary>
    public class DebugFileLogger : ILogger
    {
        /// <inheritdoc/>
        public LogLevel Filter { get; set; } = LogLevel.Debug;

        /// <summary>
        /// The <see cref="TextWriter"/> used to write log data.
        /// </summary>
        public TextWriter Writer { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugFileLogger"/> class.
        /// </summary>
        /// <param name="fileName">A path to the file to write to.</param>
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

        void ILogger.Flush()
        {
            Writer.Flush();
        }
    }
}
