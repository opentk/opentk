using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("{Value}")]
    public struct GLXFBConfig
    {
        public IntPtr Value { get; }

        public GLXFBConfig(IntPtr value)
        {
            Value = value;
        }
    }
}
