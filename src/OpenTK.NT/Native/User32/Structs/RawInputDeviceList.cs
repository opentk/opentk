using System.Runtime.InteropServices;

using HANDLE = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about a raw input device.
    /// </summary>
    public struct RawInputDeviceList
    {
        /// <summary>
        /// Handle to the raw input device.
        /// </summary>
        public HANDLE Device;

        /// <summary>
        /// Type of device.
        /// </summary>
        public RawInputDeviceType Type;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputDeviceList>();

        public override string ToString()
            => $"{Type}, Handle: {Device}";
    }
}
