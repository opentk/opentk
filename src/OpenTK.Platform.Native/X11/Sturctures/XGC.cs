using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11
{
    [DebuggerDisplay("{Value}")]
    public struct XGC
    {
        public IntPtr Value { get; }

        public XGC(IntPtr value)
        {
            Value = value;
        }
    }
}
