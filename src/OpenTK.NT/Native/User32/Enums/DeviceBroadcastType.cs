using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Used in the <see cref="BroadcastDeviceInterface"/>.
    /// </summary>
    public enum DeviceBroadcastType : DWORD
    {
        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        Oem = 0,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        DevNode = 1,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        Volume = 2,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        Port = 3,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        Net = 4,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        DeviceInterface = 5,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        Handle = 6
    }
}
