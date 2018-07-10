using System.Runtime.InteropServices;

using HANDLE = System.IntPtr;
using HDEVNOTIFY = System.IntPtr;
using LPVOID = System.IntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Device
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern HDEVNOTIFY RegisterDeviceNotification
            (
                [In] HANDLE hRecipient,
                [In] LPVOID notificationFilter,
                [In] DeviceNotificationEnum flags
            );

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnregisterDeviceNotification([In] HDEVNOTIFY handle);
        }
    }
}
