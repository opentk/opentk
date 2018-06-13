using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum DeviceModeFieldFlags : DWORD
    {
        LogPixels = 0x00020000,
        BitsPerPel = 0x00040000,
        PelsWidth = 0x00080000,
        PelsHeight = 0x00100000,
        DisplayFlags = 0x00200000,
        DisplayFrequency = 0x00400000
    }
}
