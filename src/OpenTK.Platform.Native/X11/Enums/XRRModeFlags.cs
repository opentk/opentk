using System;

namespace OpenTK.Platform.Native.X11
{
    [Flags]
    public enum XRRModeFlags : ulong
    {
        HSyncPositive  = (1 << 0),
        HSyncNegative  = (1 << 1),
        VSyncPositive  = (1 << 2),
        VSyncNegative  = (1 << 3),
        Interlace      = (1 << 4),
        DoubleScan     = (1 << 5),
        CSync          = (1 << 6),
        CSyncPositive  = (1 << 7),
        CSyncNegative  = (1 << 8),
        HSkewPresent   = (1 << 9),
        BCast          = (1 << 10),
        PixelMultiplex = (1 << 11),
        DoubleClock    = (1 << 12),
        ClockDivideBy2 = (1 << 13)
    }
}
