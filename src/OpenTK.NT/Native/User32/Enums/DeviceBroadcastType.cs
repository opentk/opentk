using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Used in the <see cref="BroadcastDeviceInterface"/>.
    /// </summary>
    public enum DeviceBroadcastType : DWORD
    {
        Oem = 0,
        Volume = 2,
        Port = 3,
        Interface = 5,
        Handle = 6
    }
}
