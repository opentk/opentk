using System.Runtime.InteropServices;
using OpenToolkit.Input.Hid;
using OpenToolkit.NT.Native.User32.Enums;
using HWND = System.IntPtr;
using USHORT = System.UInt16;

namespace OpenToolkit.NT.Native.User32.Structs
{
    /// <summary>
    /// Defines information for the raw input devices.
    /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="RawInputDevice"/> struct for generic desktop usage.
        /// </summary>
        /// <param name="usage">HID usage for the Generic Desktop page.</param>
        /// <param name="flags">Specifies how to interpret the raw input data.</param>
        /// <param name="target">Handle to the target window.</param>
        public RawInputDevice(HidGenericDesktopUsage usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.GenericDesktop)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawInputDevice"/> struct for consumer usage.
        /// </summary>
        /// <param name="usage">HID usage for the Consumer page.</param>
        /// <param name="flags">Specifies how to interpret the raw input data.</param>
        /// <param name="target">Handle to the target window.</param>
        public RawInputDevice(HidConsumerUsage usage, RawInputDeviceFlags flags, HWND target)
            : this((ushort)usage, flags, target, HidPage.Consumer)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawInputDevice"/> struct for simulation usage.
        /// </summary>
        /// <param name="usage">HID usage for the Simulation page.</param>
        /// <param name="flags">Specifies how to interpret the raw input data.</param>
        /// <param name="target">Handle to the target window.</param>
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

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<RawInputDevice>();

        /// <inheritdoc/>
        public override string ToString() => $"{UsagePage}/{Usage}, flags: {Flags}, window: {Target}";
    }
}
