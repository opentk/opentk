using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenToolkit.Generator
{
    public static class Logger
    {
        private enum MessageSeverity
        {
            Info,
            Warning,
            Error,
            Fatal
        }

        private struct MessageInfo
        {
            private readonly MessageSeverity _severity;
            private readonly DateTime _time;
            private readonly string _message;
            private readonly int _lineNumber;
            private readonly string _filePath;

            public MessageInfo(MessageSeverity severity, DateTime time, string message, int lineNumber, string filePath)
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
                return $"[{_severity} {_time.ToString("yyyy-MM-dd hh:mm:ss:fffff")} {_filePath}#{_lineNumber}] {_message}\n";
            }

            [Pure]
            public ConsoleColor GetColor()
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

        private static FileStream _fileStream;

        public static void Initialize()
        {
            _fileStream = File.Create("log.txt");

            Logger.Info("Logger initialized.");
        }

        public static void Dispose()
        {
            _fileStream.Dispose();
        }

        public static void Info(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = null) =>
            WriteLog(new MessageInfo(MessageSeverity.Info, DateTime.Now, message, lineNumber, filePath));

        public static void Warning(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = null) =>
            WriteLog(new MessageInfo(MessageSeverity.Warning, DateTime.Now, message, lineNumber, filePath));

        public static void Error(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = null) =>
            WriteLog(new MessageInfo(MessageSeverity.Error, DateTime.Now, message, lineNumber, filePath));

        public static void Fatal(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = null) =>
            WriteLog(new MessageInfo(MessageSeverity.Fatal, DateTime.Now, message, lineNumber, filePath));

        private static void WriteLog(MessageInfo info)
        {
            byte[] data = Encoding.UTF8.GetBytes(info.ToString());
            _fileStream.Write(data, 0, data.Length);
            Console.ForegroundColor = info.GetColor();
            Console.Write(info.ToString());
            Console.ResetColor();
        }
    }
}
