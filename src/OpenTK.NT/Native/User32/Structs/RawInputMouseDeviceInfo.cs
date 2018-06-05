using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified mouse.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 2.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputMouseDeviceInfo
    {
        /// <summary>
        /// ID for the mouse device.
        /// </summary>
        internal int Id;

        /// <summary>
        /// Number of buttons for the mouse.
        /// </summary>
        internal int NumberOfButtons;

        /// <summary>
        /// Number of data points per second. This information may not be applicable for every mouse device.
        /// </summary>
        internal int SampleRate;

        /// <summary>
        /// TRUE if the mouse has a wheel for horizontal scrolling; otherwise, FALSE.
        /// </summary>
        /// <remarks>
        /// This member is only supported under Microsoft Windows Vista and later versions.
        /// </remarks>
        internal bool HasHorizontalWheel;
    }
}
