using System;

namespace OpenTK.Platform.Native.X11
{
    public struct XGC
    {
        public IntPtr Value { get; }

        public XGC(IntPtr value)
        {
            Value = value;
        }
    }
}