namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified Human Interface Device (HID).
    /// </summary>
    public struct RawInputDeviceInfoHid
    {
        /// <summary>
        /// Vendor ID for the HID.
        /// </summary>
        public uint VendorId;

        /// <summary>
        /// Product ID for the HID.
        /// </summary>
        public uint ProductId;

        /// <summary>
        /// Version number for the HID.
        /// </summary>
        public uint VersionNumber;

        /// <summary>
        /// Top-level collection Usage Page for the device.
        /// </summary>
        public ushort UsagePage;

        /// <summary>
        /// Top-level collection Usage for the device.
        /// </summary>
        public ushort Usage;
    }
}
