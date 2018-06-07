using OpenTK.Core;
using System.Runtime.InteropServices;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Contains the raw input from a device.
    /// </summary>
    /// <remarks>
    ///  <para>The handle to this structure is passed in the lParam parameter of WM_INPUT.</para>
    ///  <para>To get detailed information -- such as the header and the content of the raw input -- call GetRawInputData.</para>
    ///  <para>To get device specific information, call GetRawInputDeviceInfo with the hDevice from RAWINPUTHEADER.</para>
    ///  <para>
    /// Raw input is available only when the application calls RegisterRawInputDevices with valid device
    /// specifications.
    ///  </para>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RAWINPUT
    {
        public RAWINPUTHEADER header;
        public RawInputData data;

        public static readonly int SizeInBytes =
            BlittableValueType<RAWINPUT>.Stride;
    }
}
