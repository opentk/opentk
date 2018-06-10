namespace OpenTK.NT.Native
{
    public enum GetRawInputDeviceInfoEnum : uint
    {
        /// <summary>
        /// pData points to the previously parsed data.
        /// </summary>
        PREPARSEDDATA = 0x20000005,

        /// <summary>
        /// pData points to a string that contains the device name.<br/>
        /// For this uiCommand only, the value in pcbSize is the character count (not the byte count).
        /// </summary>
        DEVICENAME = 0x20000007, // the return valus is the character length, not the byte size

        /// <summary>
        /// pData points to an <see cref="RID_DEVICE_INFO"/> structure.
        /// </summary>
        DEVICEINFO = 0x2000000b
    }
}
