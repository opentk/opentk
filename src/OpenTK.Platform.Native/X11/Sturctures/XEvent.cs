using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    // Note: The real size of the structure is 192 bytes, but including
    // some more bytes in order to prevent potential segfaults down
    // the line. May be removed later.
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    [DebuggerDisplay("{Type} Display={Any.Display} Window={Any.Window}")]
    public struct XEvent
    {
        [FieldOffset(0)]
        public XEventType Type;
        [FieldOffset(0)]
        public XAnyEvent Any;
    }

    public struct XAnyEvent
    {
        public XEventType Type;
        public ulong Serial;
        public int SendEvent;
        public XDisplayPtr Display;
        public XWindow Window;
    }
}
