using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct GLXDrawable
    {
        public ulong Id { get; }

        public static readonly GLXDrawable None = new GLXDrawable(0);

        public GLXDrawable(ulong id)
        {
            Id = id;
        }

        public static explicit operator GLXDrawable(GLXWindow window)
        {
            return new GLXDrawable((ulong)window.Value);
        }

        public static explicit operator GLXDrawable(GLXPixmap pixmap)
        {
            return new GLXDrawable((ulong)pixmap.Value);
        }

        public static implicit operator Graphics.Glx.GLXDrawable(GLXDrawable drawable) => new Graphics.Glx.GLXDrawable((nuint)drawable.Id);
    }

    [DebuggerDisplay("{Value}")]
    internal struct GLXWindow
    {
        public IntPtr Value { get; }

        public GLXWindow(IntPtr value)
        {
            Value = value;
        }

        public static implicit operator Graphics.Glx.GLXWindow(GLXWindow window) => new Graphics.Glx.GLXWindow((nuint)window.Value);
        public static implicit operator GLXWindow(Graphics.Glx.GLXWindow window) => new GLXWindow((IntPtr)window.XID);
    }

    [DebuggerDisplay("{Value}")]
    internal struct GLXPixmap
    {
        public IntPtr Value { get; }

        public GLXPixmap(IntPtr value)
        {
            Value = value;
        }
    }

    [DebuggerDisplay("{Value}")]
    internal struct GLXContext
    {
        public IntPtr Value { get; }

        public GLXContext(IntPtr value)
        {
            Value = value;
        }

        public static implicit operator Graphics.Glx.GLXContext(GLXContext context) => new Graphics.Glx.GLXContext(context.Value);
        public static implicit operator GLXContext(Graphics.Glx.GLXContext context) => new GLXContext(context.Value);
    }

    // FIXME: Remove this as it's not needed anymore.
    [DebuggerDisplay("{Value}")]
    internal struct GLXFBConfig
    {
        public IntPtr Value { get; }

        public GLXFBConfig(IntPtr value)
        {
            Value = value;
        }

        public static implicit operator Graphics.Glx.GLXFBConfig(GLXFBConfig config) => new Graphics.Glx.GLXFBConfig(config.Value);
    }
}
