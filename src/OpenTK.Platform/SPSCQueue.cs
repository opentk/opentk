using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Single-producer single-consumer thread safe fixed size queue
    /// where overflow overwrites the oldest values in the queue.
    /// </summary>
    internal class SPSCRingBuffer<T>
    {
        private readonly T[] _data;
        private readonly Lock _dataLock = new Lock();
        private int _readHead, _writeHead;

        /// <summary>
        /// Creates a new fixed sized ring buffer of size <paramref name="size"/>.
        /// </summary>
        /// <param name="size">The number of elements the ring buffer should be able to contain.</param>
        public SPSCRingBuffer(int size)
        {
            // We always keep an empty space between the write head and read head so we can differentiate full and empty.
            _data = new T[size + 1];
        }

        private int MoveNextIndex(int i) => (i + 1) % _data.Length;

        /// <summary>
        /// Adds an element to the buffer, possibly overwriting old unread data.
        /// </summary>
        /// <param name="value">The value to add to the buffer.</param>
        /// <returns><see langword="true"/> if the buffer was full and data was discarded, <see langword="false"/> otherwise.</returns>
        public bool Enqueue(T value)
        {
            bool overwrote = false;
            lock (_dataLock) {
                _data[_writeHead] = value;
                _writeHead = MoveNextIndex(_writeHead);
                if (_writeHead == _readHead)
                {
                    _readHead = MoveNextIndex(_readHead);
                    overwrote = true;
                }
            }
            return overwrote;
        }

        /// <summary>
        /// Tries to read data from the buffer.
        /// </summary>
        /// <param name="value">The dequeued item if there where items to dequeue, otherwise the default value for the type <typeparamref name="T"/>.</param>
        /// <returns><see langword="true"/> if data was dequeued, <see langword="false"/> otherwise.</returns>
        public bool TryDequeue([MaybeNullWhen(false)] out T? value)
        {
            lock (_dataLock)
            {
                if (_readHead == _writeHead)
                {
                    value = default;
                    return false;
                }
                else
                {
                    value = _data[_readHead]!;
                    _readHead = MoveNextIndex(_readHead);
                    return true;
                }
            }
        }
    }
}
