using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies the device's display mode.
    /// </summary>
    [Flags]
    public enum DisplayFlags : uint
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
