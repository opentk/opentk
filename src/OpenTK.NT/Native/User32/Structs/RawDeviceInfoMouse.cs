using System.Runtime.InteropServices;

using BOOL = System.Boolean;
using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified mouse.
    /// </summary>
    /// <remarks>
    /// For the keyboard, the Usage Page is 1 and the Usage is 2.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawDeviceInfoMouse
    {
        /// <summary>
        /// ID for the mouse device.
        /// </summary>
        public DWORD Id;

        /// <summary>
        /// Number of buttons for the mouse.
        /// </summary>
        public DWORD NumberOfButtons;

        /// <summary>
        /// Number of data points per second. This information may not be applicable for every mouse device.
        /// </summary>
        public DWORD SampleRate;

        /// <summary>
        /// TRUE if the mouse has a wheel for horizontal scrolling; otherwise, FALSE.
        /// </summary>
        /// <remarks>
        /// This member is only supported under Microsoft Windows Vista and later versions.
        /// </remarks>
        public BOOL HasHorizontalWheel;
    }
}
