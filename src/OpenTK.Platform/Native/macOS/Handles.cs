using System;
using OpenTK.Platform;
using OpenTK.Mathematics;

namespace OpenTK.Platform.Native.macOS
{
    internal class NSWindowHandle : WindowHandle
    {
        public IntPtr Window { get; set; }
        public IntPtr View { get; set; }

        // This is used to implement SwapBuffers
        public NSOpenGLContext? Context { get; set; }

        public NSCursorHandle? Cursor { get; set; }

        public NSIconHandle? Icon { get; set; }

        public bool Destroyed { get; set; } = false;

        public int? MinWidth { get; set; } = null;
        public int? MinHeight { get; set; } = null;
        public int? MaxWidth { get; set; } = null;
        public int? MaxHeight { get; set; } = null;

        public HitTest? HitTest { get; set; } = null;
        public bool BackgroundDragEnabled { get; set; } = false;

        public NSScreenHandle? FullscreenScreen { get; set; } = null;
        public bool InNonSpaceFullscreen { get; set; } = false;
        public NSWindowLevel PreviousLevel { get; set; }
        // FIXME: Should we store the intended style?
        public NSWindowStyleMask PreviousStyleMask { get; set; }
        public CGRect PreviousFrame { get; set; }

        public CursorCaptureMode CursorCaptureMode { get; set; } = CursorCaptureMode.Normal;
        // FIXME: Should this be floats and not integers?
        public CGPoint LastMousePosition { get; set; }
        public CGPoint VirtualCursorPosition { get; set; }

        public MouseButtonFlags PressedMouseButtons { get; set; }
        public Vector2 ScrollPosition { get; set; }

        // Is the framebuffer transparent? We need to keep track of this
        // so that if the framebuffer is set to transparent before we
        // create the opengl context we can make the opengl context transparent.
        public WindowTransparencyMode TransparencyMode { get; set; }

        public NSWindowHandle(IntPtr window, IntPtr view, GraphicsApiHints graphicsApiHints) : base(graphicsApiHints)
        {
            Window = window;
            View = view;
        }
    }

    internal class NSOpenGLContext : OpenGLContextHandle
    {
        public IntPtr Context { get; set; }

        public NSOpenGLContext? SharedContext { get; private set; }

        public ContextValues ContextValues { get; private set; }

        public NSOpenGLContext(IntPtr context, NSOpenGLContext? sharedContext, ContextValues contextValues)
        {
            Context = context;
            SharedContext = sharedContext;
            ContextValues = contextValues;
        }
    }

    // FIXME: Is this an NSScreen handle or a CGDirectDisplay handle?
    internal class NSScreenHandle : DisplayHandle
    {
        public uint DirectDisplayID { get; set; }

        // FIXME: Do we need this?
        public uint UnitNumber { get; set; }

        public IntPtr Screen { get; set; }

        public string Name { get; set; } 

        public bool IsPrimary { get; set; }

        public NSScreenHandle(uint directDisplayID, uint unitNumber, IntPtr screen, string name, bool isPrimary)
        {
            DirectDisplayID = directDisplayID;
            UnitNumber = unitNumber;
            Screen = screen;
            Name = name;
            IsPrimary = isPrimary;
        }
    }

    internal class NSCursorHandle : CursorHandle
    {
        public CursorMode Mode = CursorMode.Uninitialized;

        public IntPtr Cursor;

        public IntPtr[]? CursorFrames;
        /// <summary>Delay between frames.</summary>
        public double Delay = 0;
        /// <summary>Used to keep track of this cursors current animation time.</summary>
        public double Time = 0;
        /// <summary>The current frame.</summary>
        public int Frame = 0;
        
        public NSCursorHandle(CursorMode mode, IntPtr cursor)
        {
            Mode = mode;
            Cursor = cursor;
        }

        public NSCursorHandle(CursorMode mode, IntPtr[] cursorFrames, double delay)
        {
            Mode = mode;
            CursorFrames = cursorFrames;
            Delay = delay;
        }

        internal enum CursorMode
        {
            Uninitialized,
            SystemCursor,
            SystemAnimatedCursor,
            CustomCursor,
            CustomAnimatedCursor,
        }
    }

    internal class NSIconHandle : IconHandle
    {
        public IntPtr Image { get; set; }
        public IntPtr SymbolConfiguration { get; set; }

        public NSIconHandle(IntPtr image)
        {
            Image = image;
        }

        public NSIconHandle(IntPtr image, IntPtr symbolConfiguration)
        {
            Image = image;
            SymbolConfiguration = symbolConfiguration;
        }
    }
}

