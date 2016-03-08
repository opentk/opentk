// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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
        readonly Dictionary<long, int> Map = new Dictionary<long, int>();
        readonly List<T> Devices = new List<T>();

        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
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

        // This avoids boxing when using foreach loops
        public List<T>.Enumerator GetEnumerator()
        {
            return Devices.GetEnumerator();
        }

        public T this[int index]
        {
            get { return FromIndex(index); }
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
                int index = GetIndex();
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
            else
            {
                return default(T);
            }
        }

        public bool FromIndex(int index, out T device)
        {
            if (index >= 0 && index < Devices.Count)
            {
                device = Devices[index];
                return true;
            }
            else
            {
                device = default(T);
                return false;
            }
        }

        public T FromHardwareId(long id)
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

        public bool FromHardwareId(long id, out T device)
        {
            if (Map.ContainsKey(id))
            {
                device = FromIndex(Map[id]);
                return true;
            }
            else
            {
                device = default(T);
                return false;
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

