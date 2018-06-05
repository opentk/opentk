using System.Runtime.InteropServices;

using HANDLE = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about a raw input device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputDeviceList
    {
        /// <summary>
        /// Handle to the raw input device.
        /// </summary>
        internal HANDLE Device;

        /// <summary>
        /// Type of device.
        /// </summary>
        internal RawInputDeviceType Type;

        public override string ToString()
        {
            return $"{Type}, Handle: {Device}";
        }
    }
}
