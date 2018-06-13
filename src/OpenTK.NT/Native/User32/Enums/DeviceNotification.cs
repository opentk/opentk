namespace OpenTK.NT.Native
{
    public enum DeviceNotificationEnum
    {
        /// <summary>
        /// The hRecipient parameter is a window handle.
        /// </summary>
        WindowHandle = 0x00000000,

        /// <summary>
        /// The hRecipient parameter is a service status handle.
        /// </summary>
        ServiceHandle = 0x00000001,

        /// <summary>
        /// Notifies the recipient of device interface events for all device interface classes. (The dbcc_classguid member is ignored.)<br/>
        /// This value can be used only if the dbch_devicetype member is DBT_DEVTYP_DEVICEINTERFACE.
        /// </summary>
        AllInterfaceClasses = 0x00000004
    }
}
