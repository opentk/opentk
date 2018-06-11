using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum RawInputDeviceType : DWORD
    {
        /// <summary>
        /// Data comes from a mouse.
        /// </summary>
        MOUSE = 0,

        /// <summary>
        /// Data comes from a keyboard.
        /// </summary>
        KEYBOARD = 1,

        /// <summary>
        /// Data comes from an HID that is not a keyboard or a mouse.
        /// </summary>
        HID = 2
    }
}
