using System;

namespace OpenTK.Platform.Native.X11.XRandR
{
    internal enum Connection : ushort
    {
        Connected = 0,
        Disconnected = 1,
        UnknownConnection = 2,
    }

    internal enum SubpixelOrder : ushort
    {
        SubPixelUnknown = 0,
        SubPixelHorizontalRGB = 1,
        SubPixelHorizontalBGR = 2,
        SubPixelVerticalRGB = 3,
        SubPixelVerticalBGR = 4,
        SubPixelNone = 5,
    }

    [Flags]
    internal enum Rotation : ushort
    {
        Rotate_0 = 1,
        Rotate_90 = 2,
        Rotate_180 = 4,
        Rotate_270 = 8,
    }

    /// <summary>
    /// Notification subcodes for XRandR.
    /// </summary>
    internal enum RRNotifySubType : int
    {
        CrtcChange = 0,
        OutputChange = 1,
        OutputProperty = 2,
        ProviderChange = 3,
        ProviderProperty = 4,
        ResourceChange = 5
    }

    /// <summary>
    /// Event mask for XRandR event types.
    /// </summary>
    internal enum RREventMask : int
    {
        ScreenChangeNotify = 1 << 0,
        CrtcChangeNotify = 1 << 1,
        OutputChangeNotify = 1 << 2,
        OutputPropertyNotify = 1 << 3,
        ProviderChangeNotify = 1 << 4,
        ProviderPropertyChangeNotify = 1 << 5,
        ResourceChangeNotify = 1 << 6,
        LeaseNotify = 1 << 7
    }

    [Flags]
    internal enum XRRModeFlags : ulong
    {
        HSyncPositive = 1 << 0,
        HSyncNegative = 1 << 1,
        VSyncPositive = 1 << 2,
        VSyncNegative = 1 << 3,
        Interlace = 1 << 4,
        DoubleScan = 1 << 5,
        CSync = 1 << 6,
        CSyncPositive = 1 << 7,
        CSyncNegative = 1 << 8,
        HSkewPresent = 1 << 9,
        BCast = 1 << 10,
        PixelMultiplex = 1 << 11,
        DoubleClock = 1 << 12,
        ClockDivideBy2 = 1 << 13
    }
}
