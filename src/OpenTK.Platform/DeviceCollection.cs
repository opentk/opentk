﻿//
// DeviceCollection.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenToolkit.Platform
{
    // Holds a collection of hardware devices with an associated id.
    // Note: 'id' refers to a unique hardware-specific device identifier.
    // Note: 'index' refers to the offset of the device in the Devices array.
    //        Indices are allocated sequentially as devices are added to the system.
    //        If a device is removed, its index will be reused for the next device
    //        that is added.
    internal class DeviceCollection<T> : IEnumerable<T>
    {
        private readonly List<T> Devices = new List<T>();

        private readonly Dictionary<long, int> Map = new Dictionary<long, int>();

        public T this[int index] => FromIndex(index);

        public int Count => Map.Count;

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        // This avoids boxing when using foreach loops
        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        /// \internal
        /// <summary>
        /// Adds or replaces a device based on its hardware id.
        /// A zero-based device index will be generated automatically
        /// for the first available device slot.
        /// </summary>
        /// <param name="id">The hardware id for the device.</param>
        /// <param name="device">The device instance.</param>
        public void Add(long id, T device)
        {
            if (!Map.ContainsKey(id))
            {
                var index = GetIndex();
                Map.Add(id, index);
            }

            Devices[Map[id]] = device;
        }

        public void Remove(long id)
        {
            if (!TryRemove(id))
            {
                Debug.Print("Invalid DeviceCollection<{0}> id: {1}", typeof(T).FullName, id);
            }
        }

        public bool TryRemove(long id)
        {
            if (!Map.ContainsKey(id))
            {
                return false;
            }

            Devices[Map[id]] = default(T);
            Map.Remove(id);
            return true;
        }

        public T FromIndex(int index)
        {
            if (index >= 0 && index < Devices.Count)
            {
                return Devices[index];
            }

            return default(T);
        }

        public bool FromIndex(int index, out T device)
        {
            if (index >= 0 && index < Devices.Count)
            {
                device = Devices[index];
                return true;
            }

            device = default(T);
            return false;
        }

        public T FromHardwareId(long id)
        {
            if (Map.ContainsKey(id))
            {
                return FromIndex(Map[id]);
            }

            return default(T);
        }

        public bool FromHardwareId(long id, out T device)
        {
            if (Map.ContainsKey(id))
            {
                device = FromIndex(Map[id]);
                return true;
            }

            device = default(T);
            return false;
        }

        // Return the index of the first empty slot in Devices.
        // If no empty slot exists, append a new one and return
        // that index.
        private int GetIndex()
        {
            for (var i = 0; i < Devices.Count; i++)
            {
                if (Devices[i] == null)
                {
                    return i;
                }
            }

            Devices.Add(default(T));
            return Devices.Count - 1;
        }

        internal struct Enumerator : IEnumerator<T>
        {
            private int Index;
            private readonly DeviceCollection<T> Collection;

            internal Enumerator(DeviceCollection<T> collection)
            {
                Collection = collection;
                Index = -1;
                Current = default(T);
            }

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                do
                {
                    ++Index;
                    if (Index < Collection.Devices.Count)
                    {
                        Current = Collection.Devices[Index];
                    }
                } while (Index < Collection.Devices.Count && Collection.Devices[Index] == null);

                return Index < Collection.Devices.Count;
            }

            public void Reset()
            {
                Index = -1;
                Current = default(T);
            }
        }
    }
}
