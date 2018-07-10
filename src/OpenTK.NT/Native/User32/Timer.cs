using System.Runtime.InteropServices;

using HWND = System.IntPtr;
using TIMERPROC = OpenTK.NT.Native.TimerProc;
using UINT_PTR = System.UIntPtr;

namespace OpenTK.NT.Native
{
    public static partial class User32
    {
        public static class Timer
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern UINT_PTR SetTimer
            (
                [In] [Optional] HWND hWnd,
                [In] UINT_PTR nIDEvent,
                [In] uint uElapse,
                [In] [Optional] TIMERPROC lpTimerFunc
            );

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool KillTimer
            (
                [In] [Optional] HWND hWnd,
                [In] UINT_PTR uIDEvent
            );
        }
    }
}
