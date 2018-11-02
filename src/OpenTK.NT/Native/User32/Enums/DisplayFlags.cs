using System;
using DWORD = System.UInt32;

namespace OpenToolkit.NT.Native.User32.Enums
{
    /// <summary>
    /// Specifies the device's display mode.
    /// </summary>
    [Flags]
    public enum DisplayFlags : DWORD
    {
        /// <summary>
        /// Specifies that the display is a noncolor device. If this flag is not set, color is assumed.
        /// </summary>
        Grayscale = 0x00000001,

        /// <summary>
        /// Specifies that the display mode is interlaced. If the flag is not set, noninterlaced is assumed.
        /// </summary>
        Interlaced = 0x00000002,
    }
}
