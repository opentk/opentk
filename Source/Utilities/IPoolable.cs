using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    interface IPoolable : IDisposable
    {
        void OnAcquire();
        void OnRelease();
    }

    interface IPoolable<T> : IPoolable where T : IPoolable<T>, new()
    {
        ObjectPool<T> Owner { get; set;  }
    }
}
