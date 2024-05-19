using System;
namespace OpenTK.Platform.Native.macOS
{
    internal enum CGError : int
    {
        Success = 0,
        Failure = 1000,
        IllegalArgument = 1001,
        InvalidConnection = 1002,
        InvalidContext = 1003,
        CannotComplete = 1004,
        NotImplemented = 1006,
        RangeCheck = 1007,
        TypeCheck = 1008,
        InvalidOperation = 1010,
        NoneAvailable = 1011,
    }

    [Flags]
    internal enum DisplayModeIOFlags : uint
    {
        DisplayModeValidFlag = 0x00000001,
        DisplayModeSafeFlag = 0x00000002,
        DisplayModeDefaultFlag = 0x00000004,

        DisplayModeSafetyFlags = 0x00000007,

        DisplayModeAlwaysShowFlag = 0x00000008,
        DisplayModeNeverShowFlag = 0x00000080,
        DisplayModeNotResizeFlag = 0x00000010,
        DisplayModeRequiresPanFlag = 0x00000020,

        DisplayModeInterlacedFlag = 0x00000040,

        DisplayModeSimulscanFlag = 0x00000100,
        DisplayModeBuiltInFlag = 0x00000400,
        DisplayModeNotPresetFlag = 0x00000200,
        DisplayModeStretchedFlag = 0x00000800,
        DisplayModeNotGraphicsQualityFlag = 0x00001000,
        DisplayModeValidateAgainstDisplay = 0x00002000,
        DisplayModeTelevisionFlag = 0x00100000,
        DisplayModeValidForMirroringFlag = 0x00200000,
    }

    internal enum CGImageAlphaInfo
    {
        kCGImageAlphaNone = 0,
        kCGImageAlphaPremultipliedLast = 1,
        kCGImageAlphaPremultipliedFirst = 2,
        kCGImageAlphaLast = 3,
        kCGImageAlphaFirst = 4,
        kCGImageAlphaNoneSkipLast = 5,
        kCGImageAlphaNoneSkipFirst = 6,
        kCGImageAlphaOnly = 7,
    }

    internal enum CGBitmapInfo
    {
        kCGBitmapAlphaInfoMask = 0x1F,
        kCGBitmapFloatComponents = (1 << 8),
        kCGBitmapByteOrderMask = 0x7000,
        kCGBitmapByteOrderDefault = (0 << 12),
        kCGBitmapByteOrder16Little = (1 << 12),
        kCGBitmapByteOrder32Little = (2 << 12),
        kCGBitmapByteOrder16Big = (3 << 12),
        kCGBitmapByteOrder32Big = (4 << 12),
    }
}

