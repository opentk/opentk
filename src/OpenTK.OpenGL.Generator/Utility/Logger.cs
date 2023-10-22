using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenTK.OpenGL.Generator.Utility
{
    internal class Logger : IDisposable
    {
        private enum MessageSeverity
        {
            Info,
            Warning,
            Error,
            Fatal
        }

        private readonly struct MessageInfo
        {
            private readonly MessageSeverity _severity;
            private readonly DateTime _time;
            private readonly string _message;
            private readonly int _lineNumber;
            private readonly string? _filePath;

            internal MessageInfo(MessageSeverity severity, DateTime time, string message, int lineNumber, string? filePath)
            {
                _severity = severity;
                _time = time;
                _message = message;
                _lineNumber = lineNumber;
                _filePath = Path.GetFileName(filePath);
            }

            [Pure]
            public override string ToString()
            {
                return $"[{_severity} {_time:yyyy-MM-dd hh:mm:ss:fffff} {_filePath}#{_lineNumber}] {_message}\n";
            }

            [Pure]
            internal ConsoleColor GetColor()
            {
                return _severity switch
                {
                    MessageSeverity.Info => ConsoleColor.Gray,
                    MessageSeverity.Warning => ConsoleColor.Yellow,
                    MessageSeverity.Error => ConsoleColor.Red,
                    MessageSeverity.Fatal => ConsoleColor.DarkRed,
                    _ => ConsoleColor.White
                };
            }
        }

        private static FileStream? _fileStream;
        private static Logger? _instance;

        internal static Logger CreateLogger(string logPath) => _instance ??= new Logger(logPath);

        internal Logger(string logPath)
        {
            _fileStream = File.Create(logPath);

            Info("Logger initialized.");
        }

        public void Dispose()
        {
            _fileStream?.Dispose();
            _instance = null;
        }

        internal static void Info(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string? filePath = null) =>
            _instance?.WriteLog(new MessageInfo(MessageSeverity.Info, DateTime.Now, message, lineNumber, filePath));

        internal static void Warning(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string? filePath = null) =>
            _instance?.WriteLog(new MessageInfo(MessageSeverity.Warning, DateTime.Now, message, lineNumber, filePath));

        internal static void Error(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string? filePath = null) =>
            _instance?.WriteLog(new MessageInfo(MessageSeverity.Error, DateTime.Now, message, lineNumber, filePath));

        internal static void Fatal(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string? filePath = null) =>
            _instance?.WriteLog(new MessageInfo(MessageSeverity.Fatal, DateTime.Now, message, lineNumber, filePath));

        private void WriteLog(MessageInfo info)
        {
            var data = Encoding.UTF8.GetBytes(info.ToString());
            _fileStream?.Write(data, 0, data.Length);
            Console.ForegroundColor = info.GetColor();
            Console.Write(info.ToString());
            //Console.Error.Write(info.ToString());
            Console.ResetColor();
        }
    }
}
