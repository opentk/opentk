using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with device contexts.
        /// </summary>
        public static class DeviceContext
        {
            /// <summary>
            /// Retrieves a handle to a device context (DC) for the client area
            /// of a specified window or for the entire screen.
            /// </summary>
            /// <param name="window">
            /// A handle to the window whose DC is to be retrieved.
            /// If this value is <see cref="IntPtr.Zero"/>, the DC for the entire screen is retrieved.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is a handle
            /// to the DC for the specified window's client area.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.
            /// </returns>
            [DllImport(Library)]
            public static extern IntPtr GetDC([In] [Optional] IntPtr window);

            /// <summary>
            /// Releases a device context (DC), freeing it for use by other applications. The effect of this function
            /// depends on the type of DC.<para/>
            /// It frees only common and window DCs. It has no effect on class or private DCs.
            /// </summary>
            /// <param name="window">A handle to the window whose DC is to be released.</param>
            /// <param name="dc">A handle to the DC to be released.</param>
            /// <returns>
            /// The return value indicates whether the DC was released.
            /// If the DC was released, the return value is true.<para/>
            /// If the DC was not released, the return value is false.
            /// </returns>
            [DllImport(Library)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ReleaseDC([In] IntPtr window, [In] IntPtr dc);

            /// <summary>
            /// Changes the settings of the default display device to the specified graphics mode.<para/>
            /// To change the settings of a specified display device, use the
            /// <see cref="ChangeDisplaySettingsEx(string, IntPtr, IntPtr, DisplaySettingsChanges, IntPtr)"/>
            /// function.
            /// </summary>
            /// <param name="deviceMode">
            /// A <see cref="DeviceMode"/> structure that describes the new graphics mode. If
            /// <paramref name="deviceMode"/> is <see cref="IntPtr.Zero"/>, all the values currently in the registry
            /// will be used for the display setting. Passing <see cref="IntPtr.Zero"/> for the
            /// <paramref name="deviceMode"/> parameter and 0 for the <paramref name="changeFlags"/> parameter is the
            /// easiest way to return to the default mode after a dynamic mode change.
            /// </param>
            /// <param name="changeFlags">Indicates how the graphics mode should be changed.</param>
            /// <returns>
            /// A <see cref="ChangeDisplaySettingsResult"/> indicating the status of the change operation.
            /// </returns>
            [DllImport(Library)]
            public static extern ChangeDisplaySettingsResult ChangeDisplaySettings
            (
                [In] ref DeviceMode deviceMode,
                [In] DisplaySettingsChanges changeFlags
            );

            /// <summary>
            /// Changes the settings of the specified display device to the specified graphics mode.
            /// </summary>
            /// <param name="deviceName">
            /// A string that specifies the display device whose graphics mode will change.<para/>
            /// Only display device names as returned by
            /// <see cref="EnumDisplayDevices(string, uint, out DisplayDevice, uint)"/> are valid.
            /// </param>
            /// <param name="deviceMode">
            /// A <see cref="DeviceMode"/> structure that describes the new graphics mode. If
            /// <paramref name="deviceMode"/> is <see cref="IntPtr.Zero"/>, all the values currently in the registry
            /// will be used for the display setting. Passing <see cref="IntPtr.Zero"/> for the
            /// <paramref name="deviceMode"/> parameter and 0 for the <paramref name="changeFlags"/> parameter is the
            /// easiest way to return to the default mode after a dynamic mode change.
            /// </param>
            /// <param name="window">Reserved, must be null.</param>
            /// <param name="changeFlags">Indicates how the graphics mode should be changed.</param>
            /// <param name="changeParams">
            /// If <paramref name="changeFlags"/> is <see cref="DisplaySettingsChanges.VideoParameters"/>, this
            /// parameter is a pointer to a VIDEOPARAMETERS structure.<para/>
            /// Otherwise <paramref name="changeParams"/> must be NULL.
            /// </param>
            /// <returns>
            /// A <see cref="ChangeDisplaySettingsResult"/> indicating the status of the change operation.
            /// </returns>
            [DllImport(Library, CharSet = CharSet.Unicode)]
            public static extern ChangeDisplaySettingsResult ChangeDisplaySettingsEx
            (
                [In] [Optional] string deviceName,
                [In] [Optional] IntPtr deviceMode,
                [Optional] IntPtr window,
                [In] DisplaySettingsChanges changeFlags,
                [In] IntPtr changeParams
            );

            /// <summary>
            /// Retrieves information about one of the graphics modes for a display device. To retrieve information
            /// for all the graphics modes of a display device, make a series of calls to this function.
            /// </summary>
            /// <param name="deviceName">
            /// A string that specifies the display device about whose graphics mode the function
            /// will obtain information.<para/>
            /// This parameter is either null or a <see cref="DisplayDevice.DeviceName"/> returned from
            /// <see cref="EnumDisplayDevices(string, uint, out DisplayDevice, uint)"/>. A null value specifies the
            /// current display device on the computer on which the calling thread is running.
            /// </param>
            /// <param name="modeSetting">Specifies the type of information to be retrieved.</param>
            /// <param name="deviceMode">
            /// A <see cref="DeviceMode"/> structure into which the function stores information about the specified
            /// graphics mode. Before calling
            /// <see cref="EnumDisplaySettings(string, DisplayModeSetting, out DeviceMode)"/>, set the
            /// <see cref="DeviceMode.Size"/> member to <see cref="DeviceMode.SizeInBytes"/>,
            /// and set the <see cref="DeviceMode.DriverExtra"/> member to indicate the size, in bytes,
            /// of the additional space available to receive private driver data.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.
            /// If the function fails, the return value is false.
            /// </returns>
            [DllImport(Library, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplaySettings
            (
                [In] string deviceName,
                [In] DisplayModeSetting modeSetting,
                [Out] out DeviceMode deviceMode
            );

            /// <summary>
            /// Retrieves information about one of the graphics modes for a display device. To retrieve information
            /// for all the graphics modes of a display device, make a series of calls to this function.
            /// </summary>
            /// <param name="deviceName">
            /// A string that specifies the display device about whose graphics mode the function
            /// will obtain information.<para/>
            /// This parameter is either null or a <see cref="DisplayDevice.DeviceName"/> returned from
            /// <see cref="EnumDisplayDevices(string, uint, out DisplayDevice, uint)"/>. A null value specifies the
            /// current display device on the computer on which the calling thread is running.
            /// </param>
            /// <param name="modeSetting">Specifies the type of information to be retrieved.</param>
            /// <param name="deviceMode">
            /// A <see cref="DeviceMode"/> structure into which the function stores information about the specified
            /// graphics mode. Before calling
            /// <see cref="EnumDisplaySettings(string, DisplayModeSetting, out DeviceMode)"/>, set the
            /// <see cref="DeviceMode.Size"/> member to <see cref="DeviceMode.SizeInBytes"/>,
            /// and set the <see cref="DeviceMode.DriverExtra"/> member to indicate the size, in bytes,
            /// of the additional space available to receive private driver data.
            /// </param>
            /// <param name="displayModeFlags">
            /// Sets constraints on which graphics modes to return for the given display device.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.
            /// If the function fails, the return value is false.
            /// </returns>
            [DllImport(Library, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplaySettingsEx
            (
                [In] string deviceName,
                [In] DisplayModeSetting modeSetting,
                [Out] out DeviceMode deviceMode,
                [In] EnumDisplayModes displayModeFlags
            );

            /// <summary>
            /// Obtains information about the display devices in the current session.
            /// </summary>
            /// <param name="deviceName">
            /// A pointer to the device name. If NULL, function returns information for the display adapter(s)
            /// on the machine, based on <paramref name="deviceIndex"/>.
            /// </param>
            /// <param name="deviceIndex">An index value that specifies the display device of interest.</param>
            /// <param name="displayDevice">
            /// A <see cref="DisplayDevice"/> structure that receives information about the display device
            /// specified by <paramref name="deviceIndex"/>.<para/>
            /// Before calling <see cref="EnumDisplayDevices(string, uint, out DisplayDevice, uint)"/>, you must
            /// initialize the <see cref="DisplayDevice.Size"/> member of <see cref="DisplayDevice"/>
            /// to <see cref="DisplayDevice.SizeInBytes"/>.
            /// </param>
            /// <param name="flags">
            /// Set this to 1 to retrieve the device interface name for GUID_DEVINTERFACE_MONITOR, which is registered
            /// by the operating system on a per monitor basis. The value is placed in the
            /// <see cref="DisplayDevice.DeviceID"/> member in <paramref name="displayDevice"/>. The resulting device
            /// interface name can be used with SetupAPI functions and serves as a link between GDI monitor
            /// devices and SetupAPI monitor devices.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// The function fails if <paramref name="deviceIndex"/> is greater than the largest device index.
            /// </returns>
            [DllImport(Library, CharSet = CharSet.Unicode)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EnumDisplayDevices
            (
                [In] [Optional] string deviceName,
                [In] uint deviceIndex,
                [Out] out DisplayDevice displayDevice,
                [In] uint flags
            );
        }
    }
}
