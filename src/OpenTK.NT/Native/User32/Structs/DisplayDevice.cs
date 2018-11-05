using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Receives information about the display device specified by the iDevNum parameter of the
    /// <see cref="User32.DeviceContext.EnumDisplayDevices(string, uint, out DisplayDevice, uint)"/> function.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DisplayDevice
    {
        /// <summary>
        /// Size, in bytes, of the structure. This must be initialized prior to calling
        /// <see cref="User32.DeviceContext.EnumDisplayDevices(string, uint, out DisplayDevice, uint)"/>.
        /// </summary>
        /// <seealso cref="SizeInBytes"/>
        public uint Size;

        /// <summary>
        /// An array of characters identifying the device name.
        /// This is either the adapter device or the monitor device.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        /// <summary>
        /// An array of characters containing the device context string.
        /// This is either a description of the display adapter or of the display monitor.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;

        /// <summary>
        /// Device state flags. It can be any reasonable combination of <see cref="DisplayDeviceStateFlags"/>.
        /// </summary>
        public DisplayDeviceStateFlags StateFlags;

        /// <summary>
        /// Not used.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        /// <summary>
        /// Reserved.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<DisplayDevice>();
    }
}
