using System;
using System.Collections;
using System.Collections.Generic;
using OpenTK.Core.Utility;

namespace OpenTK.Backends.Tests
{
    public class ModularLogger : ILogger, IList<ILogger>
    {
        private readonly List<ILogger> _loggers;

        public LogLevel Filter { get; set; }

        public event LogCallback? OnLog;

        public delegate void LogCallback(string str, LogLevel level, string filePath, int lineNumber, string member); 

        public ModularLogger()
        {
            _loggers = new List<ILogger>();
        }
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


        #region IList<ILogger>
        public int Count => ((ICollection<ILogger>)_loggers).Count;

        public bool IsReadOnly => ((ICollection<ILogger>)_loggers).IsReadOnly;

        public ILogger this[int index] { get => ((IList<ILogger>)_loggers)[index]; set => ((IList<ILogger>)_loggers)[index] = value; }

        public int IndexOf(ILogger item)
        {
            return ((IList<ILogger>)_loggers).IndexOf(item);
        }

        public void Insert(int index, ILogger item)
        {
            ((IList<ILogger>)_loggers).Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            ((IList<ILogger>)_loggers).RemoveAt(index);
        }

        public void Add(ILogger item)
        {
            ((ICollection<ILogger>)_loggers).Add(item);
        }

        public void Clear()
        {
            ((ICollection<ILogger>)_loggers).Clear();
        }

        public bool Contains(ILogger item)
        {
            return ((ICollection<ILogger>)_loggers).Contains(item);
        }

        public void CopyTo(ILogger[] array, int arrayIndex)
        {
            ((ICollection<ILogger>)_loggers).CopyTo(array, arrayIndex);
        }

        public bool Remove(ILogger item)
        {
            return ((ICollection<ILogger>)_loggers).Remove(item);
        }

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