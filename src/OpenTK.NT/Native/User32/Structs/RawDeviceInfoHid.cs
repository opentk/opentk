using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using USHORT = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified Human Interface Device (HID).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawDeviceInfoHid
    {
        /// <summary>
        /// Vendor ID for the HID.
        /// </summary>
        public DWORD dwVendorId;

        /// <summary>
        /// Product ID for the HID.
        /// </summary>
        public DWORD dwProductId;

        /// <summary>
        /// Version number for the HID.
        /// </summary>
        public DWORD dwVersionNumber;

        /// <summary>
        /// Top-level collection Usage Page for the device.
        /// </summary>
        public USHORT usUsagePage;

        /// <summary>
        /// Top-level collection Usage for the device.
        /// </summary>
        public USHORT usUsage;
    }
}
