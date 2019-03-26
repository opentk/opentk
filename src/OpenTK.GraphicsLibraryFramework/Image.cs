//
// Image.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Opaque handle to a GLFW image.
    /// </summary>
    public struct Image: IDisposable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public IntPtr Pixels { get; set; }

        public void Dispose()
        {
            Marshal.FreeHGlobal(Pixels);
        }
    }
}
