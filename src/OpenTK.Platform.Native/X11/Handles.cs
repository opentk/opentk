using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native.X11.XRandR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{

    [DebuggerDisplay("XWindowHandle: Display={Display.Value} Window={Window.Id}")]
    internal class XWindowHandle : WindowHandle
    {
        public XDisplayPtr Display { get; }
        public XWindow Window { get; }
        public GLXFBConfig? FBConfig { get; }
        public ContextPixelFormat PixelFormat { get; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

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

        public XIconHandle? Icon { get; set; } = null;


        public XDisplayHandle? FullscreenDisplay { get; set; } = null;
        public bool IsExclusiveFullscreen { get; set; } = false;

        internal int XDnDVersion { get; set; }
        internal XAtom XDnDType { get; set; }
        internal XAtom XDnDSource { get; set; }

        public XWindowHandle(
            XDisplayPtr display,
            XWindow window,
            GraphicsApiHints hints,
            GLXFBConfig? fbConfig,
            ContextPixelFormat pixelFormat,
            XColorMap? colorMap) : base(hints)
        {
            Display = display;
            Window = window;
            FBConfig = fbConfig;
            PixelFormat = pixelFormat;
            ColorMap = colorMap;
        }
    }

    internal class XOpenGLContextHandle : OpenGLContextHandle
    {
        public XDisplayPtr Display { get; }
        public GLXContext Context { get; }

        public GLXWindow GLXWindow { get; }

        public XWindow Window { get; }

        public XOpenGLContextHandle? SharedContext { get; }

        /// <summary>
        /// We use this value to keep track of the latest swap interval set through GLX_SGI_swap_control.
        /// </summary>
        public int SGISwapInterval { get; set; } = 0;

        public XOpenGLContextHandle(
            XDisplayPtr display,
            GLXContext context,
            GLXWindow glxWindow,
            XWindow window,
            XOpenGLContextHandle? sharedContext)
        {
            Display = display;
            Context = context;
            GLXWindow = glxWindow;
            Window = window;
            SharedContext = sharedContext;
        }
    }

    internal class XDisplayHandle : DisplayHandle
    {
        public RROutput Output { get; set; }

        public RRCrtc Crtc { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// RRMode of the display before any window being fullscreened.
        /// </summary>
        public RRMode OldMode { get; set; } = RRMode.None;

        public XDisplayHandle(RROutput output, RRCrtc crtc, string name)
        {
            Output = output;
            Crtc = crtc;
            Name = name;
        }
    }

    internal class XIconHandle : IconHandle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public X11IconComponent.IconImage[] Images { get; set; }

        public XIconHandle(int width, int height, X11IconComponent.IconImage[] images)
        {
            Width = width;
            Height = height;
            Images = images;
        }
    }

    internal class XCursorHandle : CursorHandle
    {
        public XCursor Cursor { get; set; }

        public CursorMode Mode { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int HotspotX { get; set; }

        public int HotspotY { get; set; }

        public XCursorHandle()
        {
        }

        internal enum CursorMode
        {
            Uninitialized,
            SystemCursor,
            ImageCursor,
        }
    }
}
