using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("{Value}")]
    public struct GLXContext
    {
        public IntPtr Value { get; }

        public GLXContext(IntPtr value)
        {
            Value = value;
        }
    }
}
