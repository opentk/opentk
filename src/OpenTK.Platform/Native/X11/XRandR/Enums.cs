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
        ResourceChange = 5,
        /* V1.6 additions */
        Lease = 6
    }

    /// <summary>
    /// Event mask for XRandR event types.
    /// </summary>
    internal enum RRSelectMask : int
    {
        ScreenChangeNotifyMask = 1 << 0,

        /// <summary>
        /// New in version 1.2
        /// </summary>
        CrtcChangeNotifyMask = 1 << 1,

        /// <summary>
        /// New in version 1.2
        /// </summary>
        OutputChangeNotifyMask = 1 << 2,

        /// <summary>
        /// New in version 1.2
        /// </summary>
        OutputPropertyNotifyMask = 1 << 3,

        /// <summary>
        /// New in version 1.4
        /// </summary>
        ProviderChangeNotifyMask = 1 << 4,

        /// <summary>
        /// New in version 1.4
        /// </summary>
        ProviderPropertyChangeNotifyMask = 1 << 5,

        /// <summary>
        /// New in version 1.4
        /// </summary>
        ResourceChangeNotifyMask = 1 << 6,

        /// <summary>
        /// New in version 1.6
        /// </summary>
        LeaseNotifyMask = 1 << 7
    }

    internal enum RREventType : int
    {
        RRScreenChangeNotify = 0,
        /* V1.2 additions */
        RRNotify = 1,
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

    internal enum RRConfigStatus : int
    {
        Success = 0x0,
        InvalidConfigTime = 0x1,
        InvalidTime = 0x2,
        Failed = 0x3,
    }

}
