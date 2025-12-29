using OpenTK.Platform;
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
        public ContextValues ContextValues { get; }

        public bool VisualSupportsFramebufferTransparency { get; set; }

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

        public MouseButtonFlags PressedMouseButtons { get; set; }
        public Vector2 ScrollPosition { get; set; }

        public XIconHandle? Icon { get; set; } = null;


        public XDisplayHandle? FullscreenDisplay { get; set; } = null;
        public bool IsExclusiveFullscreen { get; set; } = false;

        internal int XDnDVersion { get; set; }
        internal XAtom XDnDType { get; set; }
        internal XAtom XDnDSource { get; set; }

        /// <summary>
        /// Can be null.
        /// </summary>
        internal XIC IC { get; set; }
        internal StringBuilder PreeditText { get; } = new StringBuilder();

        internal XCursorHandle? Cursor { get; set; }

        public XWindowHandle(
            XDisplayPtr display,
            XWindow window,
            GraphicsApiHints hints,
            GLXFBConfig? fbConfig,
            ContextValues contextValues,
            bool visualSupportsFramebufferTransparency,
            XColorMap? colorMap,
            XIC ic) : base(hints)
        {
            Display = display;
            Window = window;
            FBConfig = fbConfig;
            ContextValues = contextValues;
            VisualSupportsFramebufferTransparency = visualSupportsFramebufferTransparency;
            ColorMap = colorMap;
            IC = ic;
        }
    }

    internal class XOpenGLContextHandle : OpenGLContextHandle
    {
        public XDisplayPtr Display { get; }
        public GLXContext Context { get; }

        public GLXWindow GLXWindow { get; }

        public XWindow Window { get; }

        public XOpenGLContextHandle? SharedContext { get; }

        public ContextValues ContextValues { get; }

        /// <summary>
        /// We use this value to keep track of the latest swap interval set through GLX_SGI_swap_control.
        /// </summary>
        public int SGISwapInterval { get; set; } = 0;

        public XOpenGLContextHandle(
            XDisplayPtr display,
            GLXContext context,
            GLXWindow glxWindow,
            XWindow window,
            XWindowHandle windowHandle,
            XOpenGLContextHandle? sharedContext,
            ContextValues contextValues)
        {
            Display = display;
            Context = context;
            GLXWindow = glxWindow;
            Window = window;
            WindowHandle = windowHandle;
            SharedContext = sharedContext;
            ContextValues = contextValues;
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


        /// <summary>Only updated in <see cref="X11DisplayComponent.UpdateDisplayValues()"/>.</summary>
        public VideoMode VideoMode { get; set; }
        /// <summary>Only updated in <see cref="X11DisplayComponent.UpdateDisplayValues()"/>.</summary>
        public Vector2i VirtualPosition { get; set; }
        /// <summary>Only updated in <see cref="X11DisplayComponent.UpdateDisplayValues()"/>.</summary>
        public Box2i WorkArea { get; set; }
        /// <summary>Only updated in <see cref="X11DisplayComponent.UpdateDisplayValues()"/>.</summary>
        public Vector2 Scale { get; set; }


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
