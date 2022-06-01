using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OpenTK.Core.Platform;
using OpenTK.Platform.Native.X11;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IWindowComponent
    {
        private XDisplayPtr _display;

        public bool CanSetIcon => false;
        public bool CanGetDisplay => false;
        public bool CanSetCursor => false;
        public IReadOnlyList<WindowEventType> SupportedEvents { get; }
        public IReadOnlyList<WindowStyle> SupportedStyles { get; }
        public IReadOnlyList<WindowMode> SupportedModes { get; }

        public XDisplayPtr Display => _display;

        public void InitializeWindow()
        {
            // Later on we can replace this with a hint.
            string? displayName = null;
            _display = XOpenDisplay(displayName);

            if (_display.Value == IntPtr.Zero)
            {
                throw new PalException(
                    this,
                    (displayName is null) ? "Could not open default X display."
                                          : $"Could not open X display {displayName}."
                    );
            }
        }

        public WindowHandle Create()
        {
            int screen = XDefaultScreen(_display);
            ulong black = XBlackPixel(_display, screen);
            ulong white = XWhitePixel(_display, screen);
            XWindow window = XCreateSimpleWindow(
                _display,
                XDefaultRootWindow(_display),
                0, 0, 800, 600,
                0,
                black);

            XSetStandardProperties(
                _display,
                window,
                "OpenTK Window [Native:X11]",
                "ICO_OPENTK",
                XPixMap.None,
                IntPtr.Zero,
                0,
                ref Unsafe.NullRef<XSizeHints>());

            return new XWindowHandle(_display, window);
        }

        public void Destroy(WindowHandle handle)
        {
            var xhandle = handle.As<XWindowHandle>(this);
            XDestroyWindow(xhandle.Display, xhandle.Window);
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

        public void ScreenToClient(WindowHandle handle, int x, int y, out int clientX, out int clientY)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void ClientToScreen(WindowHandle handle, int clientX, int clientY, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public IEventQueue<WindowEventType, WindowEventArgs> GetEventQueue(WindowHandle handle)
        {
            throw new NotImplementedException();
        }
    }
}
