// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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
