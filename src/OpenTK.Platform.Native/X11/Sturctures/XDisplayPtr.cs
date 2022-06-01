using System;

namespace OpenTK.Platform.Native.X11
{
    public struct XDisplayPtr
    {
        public IntPtr Value { get; }

        public XDisplayPtr(IntPtr value)
        {
            Value = value;
        }
    }
}
