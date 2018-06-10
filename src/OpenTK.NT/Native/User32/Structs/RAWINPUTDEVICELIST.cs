using System.Runtime.InteropServices;

using HANDLE = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains information about a raw input device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RAWINPUTDEVICELIST
    {
        /// <summary>
        /// Handle to the raw input device.
        /// </summary>
        internal HANDLE hDevice;

        /// <summary>
        /// Type of device.
        /// </summary>
        internal RAWINPUTDEVICE_TYPE dwType;

        public override string ToString()
            => $"{dwType}, Handle: {hDevice}";
    }
}
