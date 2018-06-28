using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum GetRawInputDeviceInfoEnum : UINT
    {
        /// <summary>
        /// pData points to the previously parsed data.
        /// </summary>
        PreparsedData = 0x20000005,

        /// <summary>
        /// pData points to a string that contains the device name.<para/>
        /// For this uiCommand only, the value in pcbSize is the character count (not the byte count).
        /// </summary>
        DeviceName = 0x20000007, // the return valus is the character length, not the byte size

        /// <summary>
        /// pData points to an <see cref="RawInputDeviceInfo"/> structure.
        /// </summary>
        DeviceInfo = 0x2000000b
    }
}
