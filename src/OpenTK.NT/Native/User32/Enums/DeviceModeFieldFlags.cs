using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Used in the <see cref="DeviceMode"/> structure to specify whether certain members of the structure have been initialized.<para/>
    /// If a member is initialized, its corresponding bit is set, otherwise the bit is clear. A driver supports only those <see cref="DeviceMode"/> members that are appropriate for the printer or display technology.
    /// </summary>
    public enum DeviceModeFieldFlags : DWORD
    {
        /// <summary>
        /// 
        /// </summary>
        Orientation = 0x00000001,
        PaperSize = 0x00000002,
        PaperLength = 0x00000004,
        PaperWidth = 0x00000008,
        Scale = 0x00000010,
        Position = 0x00000020,
        Nup = 0x00000040,
        DisplayOrientation = 0x00000080,
        Copies = 0x00000100,
        DefaultSource = 0x00000200,
        PrintQuality = 0x00000400,
        Color = 0x00000800,
        Duplex = 0x00001000,
        YResolution = 0x00002000,
        TTOption = 0x00004000,
        Collate = 0x00008000,
        FormName = 0x00010000,
        LogPixels = 0x00020000,
        BitsPerPel = 0x00040000,
        PelsWidth = 0x00080000,
        PelsHeight = 0x00100000,
        DisplayFlags = 0x00200000,
        DisplayFrequency = 0x00400000,
        IcmMethod = 0x00800000,
        IcmIntent = 0x01000000,
        MediaType = 0x02000000,
        DitherType = 0x04000000,
        PanningWidth = 0x08000000,
        PanningHeight = 0x10000000,
        DisplayFixedOutput = 0x20000000,
    }
}
