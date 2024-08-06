using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Utility
{
    /// <summary>
    /// Represents a logging level.
    /// Logging levels are used to indicate the seriousness of logged messages.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// The most verbose level of output.
        /// </summary>
        Debug = 0,

        // FIXME: Formalize what Info, Warning, and Error actually convey.

        /// <summary>
        /// Information that directly affects the operation of the application.
        /// </summary>
        Info = 5,

        /// <summary>
        /// Messages that report things that are likely to not be correct or may break behaviour.
        /// </summary>
        Warning = 10,

        /// <summary>
        /// Messages that report errors that have occured.
        /// The application may continue but is not guaranteed to work as intented if these messages are sent.
        /// </summary>
        Error = 15,
    }

    /// <summary>
    /// Interface used by OpenTK to be able to log diagnostic information.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// The filter level of the logger.
        /// Messages that are below the filter level will not be logged.
        /// </summary>
        LogLevel Filter { get; set; }

        /// <summary>
        /// The internal logging function. An implementor only need to implement this function.
        /// The implementation needs to take into consideration <see cref="Filter"/> when logging.
        /// </summary>
        /// <param name="str">The string to log.</param>
        /// <param name="level">The logging level.</param>
        /// <param name="filePath">The callsite file name.</param>
        /// <param name="lineNumber">The callsite line number.</param>
        /// <param name="member">The member name at the callsite.</param>
        protected void LogInternal(string str, LogLevel level, string filePath, int lineNumber, string member);

        /// <summary>
        /// Logs a message with a specific logging level.
        /// </summary>
        /// <param name="str">The string to log.</param>
        /// <param name="level">The logging level.</param>
        /// <param name="filePath">The callsite file name.</param>
        /// <param name="line">The callsite line number.</param>
        /// <param name="member">The member name at the callsite.</param>
        void Log(string str, LogLevel level, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = -1, [CallerMemberName] string member = null) => LogInternal(str, level, filePath, line, member);

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="str">The debug string to log.</param>
        /// /// <param name="filePath">The callsite file name.</param>
        /// <param name="line">The callsite line number.</param>
        /// <param name="member">The member name at the callsite.</param>
        void LogDebug(string str, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = -1, [CallerMemberName] string member = null) => Log(str, LogLevel.Debug, filePath, line, member);

        /// <summary>
        /// Log a message.
        /// </summary>
        /// <param name="str">The message to log.</param>
        /// /// <param name="filePath">The callsite file name.</param>
        /// <param name="line">The callsite line number.</param>
        /// <param name="member">The member name at the callsite.</param>
        void LogInfo(string str, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = -1, [CallerMemberName] string member = null) => Log(str, LogLevel.Info, filePath, line, member);

        /// <summary>
        /// Logs a warning.
        /// </summary>
        /// <param name="str">The warning to log.</param>
        /// /// <param name="filePath">The callsite file name.</param>
        /// <param name="line">The callsite line number.</param>
        /// <param name="member">The member name at the callsite.</param>
        void LogWarning(string str, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = -1, [CallerMemberName] string member = null) => Log(str, LogLevel.Warning, filePath, line, member);

        /// <summary>
        /// Logs an error.
        /// </summary>
        /// <param name="str">The error to log.</param>
        /// /// <param name="filePath">The callsite file name.</param>
        /// <param name="line">The callsite line number.</param>
        /// <param name="member">The member name at the callsite.</param>
        void LogError(string str, [CallerFilePath] string filePath = null, [CallerLineNumber] int line = -1, [CallerMemberName] string member = null) => Log(str, LogLevel.Error, filePath, line, member);

        /// <summary>
        /// Flushes any pending IO operations.
        /// This is useful when e.g. the application is terminating
        /// and the final log messages containing the termination reason needs to be written.
        /// </summary>
        void Flush();
    }
}
