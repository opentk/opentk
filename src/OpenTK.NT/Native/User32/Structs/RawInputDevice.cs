using OpenTK.Core.Platform.Common;
using System.Runtime.InteropServices;

using HWND = System.IntPtr;
using USHORT = System.UInt16;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Defines information for the raw input devices.
    /// </summary>
    /// <remarks>
    /// If RIDEV_NOLEGACY is set for a mouse or a keyboard, the system does not generate any legacy message for that device
    /// for the application. For example, if the mouse TLC is set with RIDEV_NOLEGACY, WM_LBUTTONDOWN and related legacy
    /// mouse messages are not generated. Likewise, if the keyboard TLC is set with RIDEV_NOLEGACY, WM_KEYDOWN and related
    /// legacy keyboard messages are not generated.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
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

        public RawInputDevice(HidUsageGD usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.GenericDesktop)
        {
        }

        public RawInputDevice(HidUsageCD usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.Consumer)
        {
        }

        public RawInputDevice(HidUsageSim usage, RawInputDeviceFlags flags, HWND target)
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
