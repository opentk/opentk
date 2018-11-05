using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    public static partial class User32
    {
        /// <summary>
        /// Provides a subset of functions from the Windows API,
        /// specifically those imported from user32.dll that deal with timers.
        /// </summary>
        public static class Timer
        {
            /// <summary>
            /// Creates a timer with the specified time-out value.
            /// </summary>
            /// <param name="window">
            /// A handle to the window to be associated with the timer. This window must be owned
            /// by the calling thread. If a <see cref="IntPtr.Zero"/> value for <paramref name="window"/> is passed
            /// in along with an <paramref name="timerID"/> of an existing timer, that timer will be replaced in the
            /// same way that an existing non-zero <paramref name="window"/> timer will be.
            /// </param>
            /// <param name="timerID">
            /// A nonzero timer identifier. If the <paramref name="window"/> parameter is <see cref="IntPtr.Zero"/>,
            /// and the <paramref name="timerID"/> does not match an existing timer then it is ignored and a new
            /// timer ID is generated.<para/>
            /// If the <paramref name="window"/> parameter is not <see cref="IntPtr.Zero"/>
            /// and the window specified by <paramref name="window"/> already has a timer with the value
            /// <paramref name="timerID"/>, then the existing timer is replaced by the new timer. When
            /// <see cref="SetTimer(IntPtr, UIntPtr, uint, TimerProc)"/> replaces a timer, the timer is reset.
            /// Therefore, a message will be sent after the current time-out value elapses, but the previously set
            /// time-out value is ignored.<para/>
            /// If the call is not intended to replace an existing timer,
            /// <paramref name="timerID"/> should be 0 if the <paramref name="window"/> is <see cref="IntPtr.Zero"/>.
            /// </param>
            /// <param name="elapse">The time-out value, in milliseconds.</param>
            /// <param name="timerFunc">
            /// A pointer to the function to be notified when the time-out value elapses. For more information about
            /// the function, see <see cref="TimerProc"/>. If <paramref name="timerFunc"/> is null, the system posts
            /// a <see cref="WindowMessage.Timer"/> message to the application queue. The <see cref="Msg.HWnd"/>
            /// member of the message's <see cref="Msg"/> structure contains
            /// the value of the <paramref name="window"/> parameter.
            /// </param>
            /// <returns>
            /// If the function succeeds and the <paramref name="window"/> parameter is <see cref="IntPtr.Zero"/>,
            /// the return value is an integer identifying the new timer. An application can pass this value to the
            /// <see cref="KillTimer(IntPtr, UIntPtr)"/> function to destroy the timer.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            public static extern UIntPtr SetTimer
            (
                [In] [Optional] IntPtr window,
                [In] UIntPtr timerID,
                [In] uint elapse,
                [In] [Optional] TimerProc timerFunc
            );

            /// <summary>
            /// Destroys the specified timer.
            /// </summary>
            /// <param name="window">
            /// A handle to the window associated with the specified timer. This value must be the same as the window
            /// value passed to the <see cref="SetTimer(IntPtr, UIntPtr, uint, TimerProc)"/>
            /// function that created the timer.
            /// </param>
            /// <param name="timerID">
            /// The timer to be destroyed. If the window handle passed to
            /// <see cref="SetTimer(IntPtr, UIntPtr, uint, TimerProc)"/> is valid, this parameter must be the same as
            /// the timerID value passed to <see cref="SetTimer(IntPtr, UIntPtr, uint, TimerProc)"/>. If the application
            /// calls <see cref="SetTimer(IntPtr, UIntPtr, uint, TimerProc)"/> with window set to
            /// <see cref="IntPtr.Zero"/>, this parameter must be the timer identifier returned by
            /// <see cref="SetTimer(IntPtr, UIntPtr, uint, TimerProc)"/>.
            /// </param>
            /// <returns>
            /// If the function succeeds, the return value is true.<para/>
            /// If the function fails, the return value is false.
            /// To get extended error information, call <see cref="Marshal.GetLastWin32Error"/>.
            /// </returns>
            [DllImport(Library, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool KillTimer
            (
                [In] [Optional] IntPtr window,
                [In] UIntPtr timerID
            );
        }
    }
}
