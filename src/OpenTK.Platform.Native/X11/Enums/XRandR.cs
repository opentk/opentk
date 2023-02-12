using System;

namespace OpenTK.Platform.Native.X11
{
    public enum Connection : ushort
    {
        Connected = 0,
        Disconnected = 1,
        UnknownConnection = 2,
    }

    public enum SubpixelOrder : ushort 
    {
        SubPixelUnknown = 0,
        SubPixelHorizontalRGB = 1,
        SubPixelHorizontalBGR = 2,
        SubPixelVerticalRGB = 3,
        SubPixelVerticalBGR = 4,
        SubPixelNone = 5,
    }

    [Flags]
    public enum Rotation : ushort
    {
        Rotate_0 = 1,
        Rotate_90 = 2,
        Rotate_180 = 4,
        Rotate_270 = 8,
    }
}