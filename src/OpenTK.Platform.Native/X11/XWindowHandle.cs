using System;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public class XWindowHandle : WindowHandle
    {
        public XWindow XWindow { get; set; }

        public XWindowHandle(ulong id)
        {
            XWindow = new XWindow(id);
        }
        public XWindowHandle(XWindow xWindow)
        {
            XWindow = xWindow;
        }
    }
}
