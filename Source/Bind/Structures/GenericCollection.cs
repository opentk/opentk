#region License
//
// GenericCollection.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
using System.Linq;

namespace Bind.Structures
{
    class GenericCollection<T> : IDictionary<string, List<T>>
        where T : IComparable<T>, IEquatable<T>
    {
        readonly protected Dictionary<string, List<T>> Collection =
            new Dictionary<string, List<T>>();

        public virtual void Add(T item)
        {
            Add(item.ToString(), new List<T> { item });
        }

        public virtual void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public virtual void AddRange(GenericCollection<T> items)
        {
            foreach (var item in items.Values.SelectMany(v => v))
            {
                Add(item);
            }
        }

        #region IDictionary Members

        public void Add(string key, List<T> value)
        {
            Collection.Add(key, value.ToList());
        }

        public bool ContainsKey(string key)
        {
            return Collection.ContainsKey(key);
        }

        public bool Remove(string key)
        {
            return Collection.Remove(key);
        }

        public bool TryGetValue(string key, out List<T> value)
        {
            return Collection.TryGetValue(key, out value);
        }

        public List<T> this[string key]
        {
            get
            {
                return Collection[key];
            }
            set
            {
                Collection[key] = value;
            }
        }

        public ICollection<string> Keys
        {
            get
            {
                return Collection.Keys;
            }
        }

        public ICollection<List<T>> Values
        {
            get
            {
                return Collection.Values;
            }
        }

        #endregion

        #region ICollection implementation

        public void Add(KeyValuePair<string, List<T>> item)
        {
            Collection.Add(item.Key, item.Value.ToList());
        }

        public void Clear()
        {
            Collection.Clear();
        }

        public bool Contains(KeyValuePair<string, List<T>> item)
        {
            return Collection.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, List<T>>[] array, int arrayIndex)
        {
            Array.Copy(Collection.ToArray(), 0, array, arrayIndex, array.Length);
        }

        public bool Remove(KeyValuePair<string, List<T>> item)
        {
            return Collection.Remove(item.Key);
        }

        public int Count
        {
            get
            {
                return Collection.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region IEnumerable implementation

        public IEnumerator<KeyValuePair<string, List<T>>> GetEnumerator()
        {
            return Collection.GetEnumerator();
        }

        #endregion

        #region IEnumerable implementation

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return Collection.GetEnumerator();
        }

        #endregion
    }
}

