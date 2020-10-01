//
// Monitor.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    ///     Wrapper around an implementation-defined monitor struct.
    /// </summary>
    public struct Monitor
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Monitor" /> struct.
        /// </summary>
        /// <param name="ptr">A pointer to the underlying native Monitor.</param>
        public Monitor(IntPtr ptr) => Pointer = ptr;

        /// <summary>
        ///     Gets a pointer to the underlying native Monitor.
        /// </summary>
        public IntPtr Pointer { get; }

        /// <summary>
        ///     Converts the underlying <see cref="Pointer" /> to a unmanaged pointer.
        /// </summary>
        /// <typeparam name="T">The type of the object found at the <see cref="Pointer" /> memory address.</typeparam>
        /// <returns>A unmanaged pointer to the underlying native Monitor.</returns>
        public unsafe T* ToUnsafePtr<T>() where T : unmanaged => (T*)Pointer;
    }
}
