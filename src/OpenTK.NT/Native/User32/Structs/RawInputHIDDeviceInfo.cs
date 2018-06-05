using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified Human Interface Device (HID).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct RawInputHIDDeviceInfo
    {
        /// <summary>
        /// Vendor ID for the HID.
        /// </summary>
        internal int VendorId;

        /// <summary>
        /// Product ID for the HID.
        /// </summary>
        internal int ProductId;

        /// <summary>
        /// Version number for the HID.
        /// </summary>
        internal int VersionNumber;

        /// <summary>
        /// Top-level collection Usage Page for the device.
        /// </summary>
        //internal USHORT UsagePage;
        internal short UsagePage;

        /// <summary>
        /// Top-level collection Usage for the device.
        /// </summary>
        //internal USHORT Usage;
        internal short Usage;
    }
}
