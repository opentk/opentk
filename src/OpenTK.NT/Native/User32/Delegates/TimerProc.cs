using System.Runtime.InteropServices;
using OpenToolkit.NT.Native.User32.Enums;
using DWORD = System.UInt32;
using HWND = System.IntPtr;
using UINT_PTR = System.UIntPtr;

namespace OpenToolkit.NT.Native.User32.Delegates
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
        [In] HWND hwnd,
        [In] WindowMessage msg,
        [In] UINT_PTR timerID,
        [In] DWORD elapsedTime
    );
}
