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
    public struct RAWINPUTDEVICE
    {
        /// <summary>
        /// Top level collection Usage page for the raw input device.
        /// </summary>
        internal HidPage usUsagePage;

        /// <summary>
        /// Top level collection Usage for the raw input device.
        /// </summary>
        internal USHORT usUsage;

        /// <summary>
        /// Mode flag that specifies how to interpret the information provided by UsagePage and Usage.
        /// By default, the operating system sends raw input from devices with the specified top level collection (TLC)
        /// to the registered application as long as it has the window focus.
        /// </summary>
        internal RAWINPUTDEVICE_FLAGS dwFlags;

        /// <summary>
        /// Handle to the target window. If NULL it follows the keyboard focus.
        /// </summary>
        internal HWND hwndTarget;

        public RAWINPUTDEVICE(HidUsageGD usage, RAWINPUTDEVICE_FLAGS flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.GenericDesktop)
        {
        }

        public RAWINPUTDEVICE(HidUsageCD usage, RAWINPUTDEVICE_FLAGS flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.Consumer)
        {
        }

        public RAWINPUTDEVICE(HidUsageSim usage, RAWINPUTDEVICE_FLAGS flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.Simulation)
        {
        }

        private RAWINPUTDEVICE(ushort usage, RAWINPUTDEVICE_FLAGS flags, HWND target, HidPage usagePage)
        {
            usUsage = usage;
            dwFlags = flags;
            hwndTarget = target;
            usUsagePage = usagePage;
        }

        public override string ToString()
            => $"{usUsagePage}/{usUsage}, flags: {dwFlags}, window: {hwndTarget}";
    }
}
