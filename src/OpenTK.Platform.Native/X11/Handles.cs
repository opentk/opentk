using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
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

    internal class XOpenGLContextHandle : OpenGLContextHandle
    {
        public XDisplayPtr Display { get; }
        public GLXContext Context { get; }

        public XDrawable Drawable { get; }

        public XOpenGLContextHandle? SharedContext { get; }

        /// <summary>
        /// We use this value to keep track of the latest swap interval set through GLX_SGI_swap_control.
        /// </summary>
        public int SGISwapInterval { get; set; } = 0;

        public XOpenGLContextHandle(
            XDisplayPtr display,
            GLXContext context,
            XDrawable drawable,
            XOpenGLContextHandle? sharedContext = null)
        {
            Display = display;
            Context = context;
            Drawable = drawable;
            SharedContext = sharedContext;
        }
    }

    internal class XRandRDisplayHandle : DisplayHandle
    {
    }

    [DebuggerDisplay("XWindowHandle: Display={Display.Value} Window={Window.Id}")]
    internal class XWindowHandle : WindowHandle
    {
        public XDisplayPtr Display { get; }
        public XWindow Window { get; }
        public GLXFBConfig? FBConfig { get; }

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

        public XIconHandle? Icon { get; set; }

        // FIXME: This will have to change so we know what monitor we are fullscreen on.
        public bool IsFullscreen { get; set; }

        public XWindowHandle(
            XDisplayPtr display,
            XWindow window,
            GraphicsApiHints hints,
            GLXFBConfig? fbConfig = null,
            XColorMap? colorMap = null) : base(hints)
        {
            Display = display;
            Window = window;
            FBConfig = fbConfig;
            ColorMap = colorMap;
        }
    }

    internal class XIconHandle : IconHandle {

        public int Width { get; set; }
        public int Height { get; set; }

        public X11IconComponent.IconImage[]? Images { get; set; }
        
        public XIconHandle()
        {
        }
    }
}
