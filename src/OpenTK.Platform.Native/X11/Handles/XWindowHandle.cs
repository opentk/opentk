using System.Diagnostics;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XWindowHandle: Display={Display.Value} Window={Window.Id}")]
    public class XWindowHandle : WindowHandle
    {
        public XDisplayPtr Display { get; }
        public XWindow Window { get; }

        public XWindowHandle(XDisplayPtr display, XWindow window)
        {
            Display = display;
            Window = window;
        }
    }
}
