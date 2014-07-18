#region License
//
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenTK.Platform
{
    // Holds a collection of hardware devices with an associated id.
    // Note: 'id' refers to a unique hardware-specific device identifier.
    // Note: 'index' refers to the offset of the device in the Devices array.
    //        Indices are allocated sequentially as devices are added to the system.
    //        If a device is removed, its index will be reused for the next device
    //        that is added.
    class DeviceCollection<T> : IEnumerable<T>
    {
        readonly Dictionary<int, int> Map = new Dictionary<int, int>();
        readonly List<T> Devices = new List<T>();

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Devices.GetEnumerator();
        }

        #endregion

        #region IEnumerable implementation

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Public Members

        public void Add(int id, T device)
        {
            if (!Map.ContainsKey(id))
            {
                int index = GetIndex();
                Map.Add(id, index);
            }

            Devices[Map[id]] = device;
        }

        public void Remove(int id)
        {
            if (!TryRemove(id))
            {
                Debug.Print("Invalid DeviceCollection<{0}> id: {1}", typeof(T).FullName, id);
            }
        }

        public bool TryRemove(int id)
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
            else
            {
                return default(T);
            }
        }

        public T FromHardwareId(int id)
        {
            if (Map.ContainsKey(id))
            {
                return FromIndex(Map[id]);
            }
            else
            {
                return default(T);
            }
        }

        public int Count
        {
            get { return Map.Count; }
        }

        #endregion

        #region Private Members

        // Return the index of the first empty slot in Devices.
        // If no empty slot exists, append a new one and return
        // that index.
        int GetIndex()
        {
            for (int i = 0; i < Devices.Count; i++)
            {
                if (Devices[i] == null)
                {
                    return i;
                }
            }

            Devices.Add(default(T));
            return Devices.Count - 1;
        }

        #endregion
    }
}

