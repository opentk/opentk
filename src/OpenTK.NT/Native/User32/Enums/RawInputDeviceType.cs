using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum RawInputDeviceType : DWORD
    {
        MOUSE = 0,
        KEYBOARD = 1,
        HID = 2
    }
}
