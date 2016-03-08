// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    /// <summary>
    /// Represents an item that can be packed with the TexturePacker.
    /// </summary>
    /// <typeparam name="T">The type of the packable item.</typeparam>
    interface IPackable<T> : IEquatable<T>
    {
        int Width { get; }
        int Height { get; }
    }
}
