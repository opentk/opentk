using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("{Value}")]
    public struct XDisplayPtr
    {
        public IntPtr Value { get; }

        public XDisplayPtr(IntPtr value)
        {
            Value = value;
        }
    }
}
