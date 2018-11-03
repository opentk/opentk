using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Used in <see cref="RawInputDevice"/> to specify how to interpret the data in the structure.
    /// </summary>
    [Flags]
    public enum RawInputDeviceFlags : uint
    {
        /// <summary>
        /// If set, this removes the top level collection from the inclusion list.
        /// This tells the operating system to stop reading from a device which matches the top level collection.
        /// </summary>
        Remove = 0x00000001,

        /// <summary>
        /// If set, this specifies the top level collections to exclude when reading a complete usage page.
        /// This flag only affects a TLC whose usage page is already specified with RawInputDeviceEnum.PAGEONLY.
        /// </summary>
        Exclude = 0x00000010,

        /// <summary>
        /// If set, this specifies all devices whose top level collection is from the specified UsagePage.
        /// Note that usUsage must be zero. To exclude a particular top level collection, use EXCLUDE.
        /// </summary>
        PageOnly = 0x00000020,

        /// <summary>
        /// If set, this prevents any devices specified by UsagePage or Usage from generating legacy messages.
        /// This is only for the mouse and keyboard. See RawInputDevice Remarks.
        /// </summary>
        NoLegacy = 0x00000030,

        /// <summary>
        /// If set, this enables the caller to receive the input even when the caller is not in the foreground.
        /// Note that Target must be specified in RawInputDevice.
        /// </summary>
        InputSink = 0x00000100,

        /// <summary>
        /// If set, the mouse button click does not activate the other window.
        /// </summary>
        CaptureMouse = 0x00000200, // effective when mouse nolegacy is specified, otherwise it would be an error

        /// <summary>
        /// If set, the application-defined keyboard device hotkeys are not handled.
        /// However, the system hotkeys; for example, ALT+TAB and CTRL+ALT+DEL, are still handled.
        /// By default, all keyboard hotkeys are handled.
        /// NOHOTKEYS can be specified even if NOLEGACY is not specified and Target is NULL in RawInputDevice.
        /// </summary>
        NoHotkeys = 0x00000200, // effective for keyboard.

        /// <summary>
        /// Microsoft Windows XP Service Pack 1 (SP1): If set, the application command keys are handled. APPKEYS can be
        /// specified only if NOLEGACY is specified for a keyboard device.
        /// </summary>
        AppKeys = 0x00000400, // effective for keyboard.

        /// <summary>
        /// If set, this enables the caller to receive input in the background only if the foreground application
        /// does not process it. In other words, if the foreground application is not registered for raw input,
        /// then the background application that is registered will receive the input.<para/>
        /// Only supported on Vista later.
        /// </summary>
        ExInputSink = 0x00001000,

        /// <summary>
        /// If set, this enables the caller to receive WM_INPUT_DEVICE_CHANGE notifications for device arrival and
        /// device removal.<para/>
        /// Only supported on Vista and later.
        /// </summary>
        DevNotify = 0x00002000
    }
}
