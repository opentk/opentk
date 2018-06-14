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
        public HANDLE hDevice;

        /// <summary>
        /// Type of device.
        /// </summary>
        public RawInputDeviceType dwType;

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputDeviceList>();

        public override string ToString()
            => $"{dwType}, Handle: {hDevice}";
    }
}
