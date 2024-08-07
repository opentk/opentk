using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

    [DebuggerDisplay("{Value}")]
    internal struct GLXWindow
    {
        public IntPtr Value { get; }

        public GLXWindow(IntPtr value)
        {
            Value = value;
        }
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
    }

    [DebuggerDisplay("{Value}")]
    internal struct GLXFBConfig
    {
        public IntPtr Value { get; }

        public GLXFBConfig(IntPtr value)
        {
            Value = value;
        }
    }
}
