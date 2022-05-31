using System;
using System.Collections.Generic;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IWindowComponent
    {
        public bool CanSetIcon { get; }
        public bool CanGetDisplay { get; }
        public bool CanSetCursor { get; }
        public IReadOnlyList<WindowEventType> SupportedEvents { get; }
        public IReadOnlyList<WindowStyle> SupportedStyles { get; }
        public IReadOnlyList<WindowMode> SupportedModes { get; }

        public WindowHandle Create()
        {
            throw new NotImplementedException();
        }

        public void Destroy(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public string GetTitle(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetTitle(WindowHandle handle, string title)
        {
            throw new NotImplementedException();
        }

        public IconHandle GetIcon(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetIcon(WindowHandle handle, IconHandle icon)
        {
            throw new NotImplementedException();
        }

        public void GetPosition(WindowHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void GetSize(WindowHandle handle, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void SetSize(WindowHandle handle, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void GetClientPosition(WindowHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void SetClientPosition(WindowHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void GetClientSize(WindowHandle handle, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void SetClientSize(WindowHandle handle, int width, int height)
        {
            throw new NotImplementedException();
        }

        public DisplayHandle GetDisplay(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public WindowMode GetMode(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetMode(WindowHandle handle, WindowMode mode)
        {
            throw new NotImplementedException();
        }

        public WindowStyle GetBorderStyle(WindowHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetBorderStyle(WindowHandle handle, WindowStyle style)
        {
            throw new NotImplementedException();
        }

        public void SetCursor(WindowHandle handle, CursorHandle cursor)
        {
            throw new NotImplementedException();
        }

        public IEventQueue<WindowEventType, WindowEventArgs> GetEventQueue(WindowHandle handle)
        {
            throw new NotImplementedException();
        }
    }
}
