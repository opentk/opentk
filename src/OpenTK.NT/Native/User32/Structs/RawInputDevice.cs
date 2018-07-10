using System.Runtime.InteropServices;
using OpenTK.Input.Hid;

using HWND = System.IntPtr;
using USHORT = System.UInt16;

namespace OpenTK.NT.Native
{
    public struct RawInputDevice
    {
        /// <summary>
        /// Top level collection Usage page for the raw input device.
        /// </summary>
        public HidPage UsagePage;

        /// <summary>
        /// Top level collection Usage for the raw input device.
        /// </summary>
        public USHORT Usage;

        /// <summary>
        /// Mode flag that specifies how to interpret the information provided by UsagePage and Usage.
        /// By default, the operating system sends raw input from devices with the specified top level collection (TLC)
        /// to the registered application as long as it has the window focus.
        /// </summary>
        public RawInputDeviceFlags Flags;

        /// <summary>
        /// Handle to the target window. If NULL it follows the keyboard focus.
        /// </summary>
        public HWND Target;

        public RawInputDevice(HidGenericDesktopUsage usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.GenericDesktop)
        {
        }

        public RawInputDevice(HidConsumerUsage usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.Consumer)
        {
        }

        public RawInputDevice(HidSimulationUsage usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.Simulation)
        {
        }

        private RawInputDevice(ushort usage, RawInputDeviceFlags flags, HWND target, HidPage usagePage)
        {
            Usage = usage;
            Flags = flags;
            Target = target;
            UsagePage = usagePage;
        }

        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputDevice>();

        public override string ToString()
            => $"{UsagePage}/{Usage}, flags: {Flags}, window: {Target}";
    }
}
