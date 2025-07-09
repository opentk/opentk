using System;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.X11
{
    public static class Libc
    {
        internal struct pollfd {
            public int fd;
            public short events;
            public short revents;
        }

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        internal static unsafe extern int poll(pollfd* fds, uint nfds, int timeout);

        internal enum LC : int
        {
            LC_CTYPE = 0,
            LC_NUMERIC = 1,
            LC_TIME = 2,
            LC_COLLATE = 3,
            LC_MONETARY = 4,
            LC_MESSAGES = 5,
            LC_ALL = 6,
            LC_PAPER = 7,
            LC_NAME = 8,
            LC_ADDRESS = 9,
            LC_TELEPHONE = 10,
            LC_MEASUREMENT = 11,
            LC_IDENTIFICATION = 12,
        }

        internal static unsafe string? setlocale(LC category, string? locale)
        {
            byte* localePtr = (byte*)Marshal.StringToCoTaskMemUTF8(locale);
            byte* retPtr = setlocale(category, localePtr);
            Marshal.ZeroFreeCoTaskMemUTF8((IntPtr)localePtr);
            return Marshal.PtrToStringUTF8((nint)retPtr);
            
            [DllImport("libc", EntryPoint = "setlocale")]
            static unsafe extern byte* setlocale(LC category, /* const */ byte* locale);
        }
    }
}