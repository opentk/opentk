using System;

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

        #region IDisposable implementation

        public void Dispose()
        {
        }

        #endregion
    }
}

