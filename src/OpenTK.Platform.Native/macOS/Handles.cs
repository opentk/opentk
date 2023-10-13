using System;
using OpenTK.Core.Platform;
namespace OpenTK.Platform.Native.macOS
{
    public class NSWindowHandle : WindowHandle
    {
        public IntPtr Window { get; set; }
        public IntPtr View { get; set; }


        // This is used to implement SwapBuffers
        public NSOpenGLContext? Context { get; set; }

        public bool Destroyed { get; set; } = false;

        public NSWindowHandle(IntPtr window, IntPtr view, GraphicsApiHints graphicsApiHints) : base(graphicsApiHints)
        {
            Window = window;
            View = view;
        }
    }

    public class NSOpenGLContext : OpenGLContextHandle
    {
        public IntPtr Context { get; set; }

        public NSOpenGLContext? SharedContext { get; private set; }

        public NSOpenGLContext(IntPtr context, NSOpenGLContext? sharedContext)
        {
            Context = context;
            SharedContext = sharedContext;
        }
    }

    // FIXME: Is this an NSScreen handle or a CGDirectDisplay handle?
    public class NSScreenHandle : DisplayHandle
    {
        public uint DirectDisplayID { get; set; }

        // FIXME: Do we need this?
        public uint UnitNumber { get; set; }

        public IntPtr Screen { get; set; }

        public string Name { get; set; } 

        public bool IsPrimary { get; set; }

        public DisplayResolution Resolution { get; set; }

        public double RefreshRate { get; set; }

        public NSScreenHandle(uint directDisplayID, uint unitNumber, IntPtr screen)
        {
            DirectDisplayID = directDisplayID;
            UnitNumber = unitNumber;
            Screen = screen;
        }
    }
}

