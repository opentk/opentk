using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XWindowHandle: Display={Display.Value} Window={Window.Id}")]
    public class XWindowHandle : WindowHandle
    {
        public XDisplayPtr Display { get; }
        public XWindow Window { get; }
        public GLXFBConfig? FBConfig { get; }

        /// <summary>This is the size the window had when we fixed the window size.</summary>
        public Vector2i FixedSize { get; set; } = (-1, -1);

        /// <summary>This is the last set min size of the window.</summary>
        public (int? Width, int? Height) MinSize { get; set; } = (null, null);

        /// <summary>This is the last max size of the the window.</summary>
        public (int? Width, int? Height) MaxSize { get; set; } = (null, null);

        public HitTest? HitTest { get; set; }

        public bool Destroyed { get; set; } = false;

        public XColorMap? ColorMap { get; }

        internal WMState WMState { get; set; }

        public CursorCaptureMode CaptureMode { get; set; }
        public Vector2 VirtualCursorPosition { get; set; }
        public Vector2i LastMousePosition { get; set; }

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
