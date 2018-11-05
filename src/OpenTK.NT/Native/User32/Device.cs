using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with devices.
        /// </summary>
        public static class Device
        {
            /// <summary>
            /// Registers the device or type of device for which a window will receive notifications.
            /// </summary>
            /// <param name="recipient">
            /// A handle to the window or service that will receive device events for the devices specified in the
            /// <paramref name="notificationFilter"/> parameter. The same window handle can be used in multiple calls
            /// to <see cref="RegisterDeviceNotification(IntPtr, IntPtr, DeviceNotificationEnum)"/>.<para/>
            /// Services can specify either a window handle or service status handle.
            /// </param>
            /// <param name="notificationFilter">
            /// A pointer to a block of data that specifies the type of device for which notifications should be sent.
            /// This block always begins with the DEV_BROADCAST_HDR structure. The data following this header is
            /// dependent on the value of the dbch_devicetype member, which can be
            /// <see cref="DeviceBroadcastType.DeviceInterface"/> or <see cref="DeviceBroadcastType.Handle"/>.<para/>
            /// For more information, see the Remarks section in the official documentation.
            /// </param>
            /// <param name="flags">Specifies additional information for this function call.</param>
            /// <returns>
            /// If the function succeeds, the return value is a device notification handle.
            /// If the function fails, the return value is <see cref="IntPtr.Zero"/>.<para/>
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern IntPtr RegisterDeviceNotification
            (
                [In] IntPtr recipient,
                [In] IntPtr notificationFilter,
                [In] DeviceNotificationEnum flags
            );

            /// <summary>
            /// Closes the specified device notification handle.
            /// </summary>
            /// <param name="handle">
            /// Device notification handle returned by the
            /// <see cref="RegisterDeviceNotification(IntPtr, IntPtr, DeviceNotificationEnum)"/> function.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.
            /// If the function fails, the return value is false.<para/>
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnregisterDeviceNotification([In] IntPtr handle);
        }
    }
}
