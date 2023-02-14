using System.Diagnostics;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XWindowHandle: Display={Display.Value} Window={Window.Id}")]
    public class XWindowHandle : WindowHandle
    {
        public XDisplayPtr Display { get; }
        public XWindow Window { get; }
        public GLXFBConfig? FBConfig { get; }

        public HitTest? HitTest { get; set; }

        public bool Destroyed { get; set; } = false;

        public XColorMap? ColorMap { get; }

        internal WMState WMState { get; set; }

        public XWindowHandle(
            XDisplayPtr display,
            XWindow window,
            GraphicsApiHints hints,
            GLXFBConfig? fbConfig = null,
            XColorMap? colorMap = null)
        {
            Display = display;
            Window = window;
            GraphicsApiHints = hints;
            FBConfig = fbConfig;
            ColorMap = colorMap;
        }
    }
}
