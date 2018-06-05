using System;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum TrackMouseEventFlags : uint
    {
        HOVER = 0x00000001,
        LEAVE = 0x00000002,
        NONCLIENT = 0x00000010,
        QUERY = 0x40000000,
        CANCEL = 0x80000000
    }
}
