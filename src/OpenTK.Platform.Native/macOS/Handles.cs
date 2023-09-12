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

        public NSOpenGLContext(IntPtr context)
        {
            Context = context;
        }
    }
}

