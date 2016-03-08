// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    class ObjectPool<T> where T : IPoolable<T>, new()
    {
        Queue<T> pool = new Queue<T>();

        public ObjectPool()
        { }

        public T Acquire()
        {
            T item;

            if (pool.Count > 0)
            {
                item = pool.Dequeue();
                item.OnAcquire();
            }
            else
            {
                item = new T();
                item.Owner = this;
                item.OnAcquire();
            }
            
            return item;
        }

        public void Release(T item)
        {
            if (item == null)
                throw new ArgumentNullException("item");

            item.OnRelease();
            pool.Enqueue(item);
        }
    }
}
