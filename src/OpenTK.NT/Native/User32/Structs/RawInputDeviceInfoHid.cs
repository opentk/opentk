﻿using DWORD = System.UInt32;
using USHORT = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines the raw input data coming from the specified Human Interface Device (HID).
    /// </summary>
    public struct RawInputDeviceInfoHid
    {
        /// <summary>
        /// Vendor ID for the HID.
        /// </summary>
        public DWORD VendorId;

        /// <summary>
        /// Product ID for the HID.
        /// </summary>
        public DWORD ProductId;

        /// <summary>
        /// Version number for the HID.
        /// </summary>
        public DWORD VersionNumber;

        /// <summary>
        /// Top-level collection Usage Page for the device.
        /// </summary>
        public USHORT UsagePage;

        /// <summary>
        /// Top-level collection Usage for the device.
        /// </summary>
        public USHORT Usage;
    }
}
