namespace OpenTK.NT.Native
{
    public enum RawInputDeviceInfoEnum
    {
        PREPARSEDDATA = 0x20000005,
        DEVICENAME = 0x20000007, // the return valus is the character length, not the byte size
        DEVICEINFO = 0x2000000b
    }
}
