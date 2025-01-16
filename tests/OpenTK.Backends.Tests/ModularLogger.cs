using System.Collections;
using System.Collections.Generic;
using OpenTK.Core.Utility;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// A logger that relays messages to other loggers and a log callback.
    /// </summary>
    public class ModularLogger : ILogger, IList<ILogger>
    {
        private readonly List<ILogger> _loggers;

        /// <inheritdoc/>
        public LogLevel Filter { get; set; }

        /// <summary>
        /// Raised when a new item is logged.
        /// </summary>
        public event LogCallback? OnLog;

        /// <summary>
        /// Named delegate so that intellisense tells you which parameter is what
        /// when implementing <see cref="OnLog"/>
        /// </summary>
        /// <param name="str">Log message.</param>
        /// <param name="level">Log level</param>
        /// <param name="filePath">Logging source file.</param>
        /// <param name="lineNumber">Source line number.</param>
        /// <param name="member">Logging member name.</param>
        public delegate void LogCallback(string str, LogLevel level, string filePath, int lineNumber, string member);

        /// <summary>
        /// Create a new instance of ModularLogger.
        /// </summary>
        public ModularLogger()
        {
            _loggers = new List<ILogger>();
        }
        /// <summary>
        /// Create a new instance of ModularLogger.
        /// </summary>
        public ModularLogger(IEnumerable<ILogger> loggers)
        {
            _loggers = new List<ILogger>(loggers);
        }

        void ILogger.LogInternal(string str, LogLevel level, string filePath, int lineNumber, string member)
        {
            if (level < Filter)
                return;

            foreach (ILogger logger in _loggers)
                logger.Log(str, level, filePath, lineNumber, member);

            OnLog?.Invoke(str, level, filePath, lineNumber, member);
        }

        void ILogger.Flush()
        {
            foreach (ILogger logger in _loggers)
            {
                logger.Flush();
            }
        }

        #region IList<ILogger>
        /// <inheritdoc/>
        public int Count => ((ICollection<ILogger>)_loggers).Count;

        /// <inheritdoc/>
        public bool IsReadOnly => ((ICollection<ILogger>)_loggers).IsReadOnly;

        /// <inheritdoc/>
        public ILogger this[int index] { get => ((IList<ILogger>)_loggers)[index]; set => ((IList<ILogger>)_loggers)[index] = value; }

        /// <inheritdoc/>
        public int IndexOf(ILogger item)
        {
            return ((IList<ILogger>)_loggers).IndexOf(item);
        }

        /// <inheritdoc/>
        public void Insert(int index, ILogger item)
        {
            ((IList<ILogger>)_loggers).Insert(index, item);
        }

        /// <inheritdoc/>
        public void RemoveAt(int index)
        {
            ((IList<ILogger>)_loggers).RemoveAt(index);
        }

        /// <inheritdoc/>
        public void Add(ILogger item)
        {
            ((ICollection<ILogger>)_loggers).Add(item);
        }

        /// <inheritdoc/>
        public void Clear()
        {
            ((ICollection<ILogger>)_loggers).Clear();
        }

        /// <inheritdoc/>
        public bool Contains(ILogger item)
        {
            return ((ICollection<ILogger>)_loggers).Contains(item);
        }

        /// <inheritdoc/>
        public void CopyTo(ILogger[] array, int arrayIndex)
        {
            ((ICollection<ILogger>)_loggers).CopyTo(array, arrayIndex);
        }

        /// <inheritdoc/>
        public bool Remove(ILogger item)
        {
            return ((ICollection<ILogger>)_loggers).Remove(item);
        }

        /// <inheritdoc/>
        public IEnumerator<ILogger> GetEnumerator()
        {
            return ((IEnumerable<ILogger>)_loggers).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_loggers).GetEnumerator();
        }

        #endregion
    }
}
