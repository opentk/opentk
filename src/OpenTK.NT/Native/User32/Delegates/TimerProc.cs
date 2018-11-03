using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// An application-defined callback function that processes <see cref="WindowMessage.Timer"/> messages. TimerProc
    /// is a placeholder for the application-defined function name.
    /// </summary>
    /// <param name="hwnd">A handle to the window associated with the timer. </param>
    /// <param name="msg">The <see cref="WindowMessage.Timer"/> message.</param>
    /// <param name="timerID">The timer's identifier.</param>
    /// <param name="elapsedTime">
    /// The number of milliseconds that have elapsed since the system was started. This is the
    /// value returned by the GetTickCount function.
    /// </param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void TimerProc
    (
        [In] IntPtr hwnd,
        [In] WindowMessage msg,
        [In] UIntPtr timerID,
        [In] uint elapsedTime
    );
}
