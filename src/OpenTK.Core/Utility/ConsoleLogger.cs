using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Utility
{
    /// <summary>
    /// A simple console logger that will write out log messages to the console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <inheritdoc/>
        public LogLevel Filter { get; set; }

        void ILogger.LogInternal(string str, LogLevel level, string filePath, int line, string member)
        {
            if (level < Filter)
            {
                return;
            }

            TextWriter writer = level switch
            {
                LogLevel.Debug => Console.Out,
                LogLevel.Info => Console.Out,
                LogLevel.Warning => Console.Out,
                LogLevel.Error => Console.Error,
                _ => Console.Out,
            };

            string fileName = Path.GetFileName(filePath);

            ConsoleColor color = level switch
            {
                LogLevel.Warning => ConsoleColor.Yellow,
                LogLevel.Error => ConsoleColor.Red,

                _ => Console.ForegroundColor,
            };

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            // Example format:
            // [Warning] Method ConsoleLogger.cs:123 <Message>
            writer.Write($"[{level}] {member} {Path.GetFileName(fileName)}:{line} ");
            writer.WriteLine(str);

            Console.ForegroundColor = prevColor;
        }

        void ILogger.Flush()
        {
            Console.Out.Flush();
        }
    }
}
