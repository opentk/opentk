namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in
    /// <see cref="User32.Device.RegisterDeviceNotification(System.IntPtr, System.IntPtr, DeviceNotificationEnum)"/>
    /// to specify additional information.
    /// </summary>
    public enum DeviceNotificationEnum
    {
        /// <summary>
        /// The recipient parameter is a window handle.
        /// </summary>
        WindowHandle = 0x00000000,

        /// <summary>
        /// The recipient parameter is a service status handle.
        /// </summary>
        ServiceHandle = 0x00000001,

        /// <summary>
        /// Notifies the recipient of device interface events for all device interface classes.
        /// (The dbcc_classguid member is ignored.)<para/>
        /// This value can be used only if the dbch_devicetype member is
        /// <see cref="DeviceBroadcastType.DeviceInterface"/>.
        /// </summary>
        AllInterfaceClasses = 0x00000004
    }
}
