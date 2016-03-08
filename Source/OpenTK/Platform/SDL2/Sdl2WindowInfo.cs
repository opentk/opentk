// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Diagnostics;

namespace OpenTK.Platform.SDL2
{
    class Sdl2WindowInfo : IWindowInfo
    {
        public IntPtr Handle { get; set; }
        public Sdl2WindowInfo Parent { get; set; }

        public Sdl2WindowInfo()
        {
        }

        public Sdl2WindowInfo(IntPtr handle, Sdl2WindowInfo parent)
        {
            Handle = handle;
            Parent = parent;
        }

        // For compatibility with whoever thought it would be
        // a good idea to access internal APIs through reflection
        // (e.g. MonoGame)
        public IntPtr WindowHandle { get { return Handle; } set { Handle = value; } }

        #region IDisposable implementation

        public void Dispose()
        {
            Debug.Print("Disposing {0}", GetType());
        }

        #endregion
    }
}

