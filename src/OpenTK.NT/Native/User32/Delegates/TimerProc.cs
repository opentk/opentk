using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HWND = System.IntPtr;
using UINT_PTR = System.UIntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// An application-defined callback function that processes <see cref="WindowMessage.Timer"/> messages. TimerProc
    /// is a placeholder for the application-defined function name. 
    /// </summary>
    /// <param name="hwnd">A handle to the window associated with the timer. </param>
    /// <param name="uMsg">The <see cref="WindowMessage.Timer"/> message.</param>
    /// <param name="idEvent">The timer's identifier.</param>
    /// <param name="dwTime">The number of milliseconds that have elapsed since the system was started. This is the
    /// value returned by the GetTickCount function.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void TimerProc
    (
        [In] HWND hwnd,
        [In] WindowMessage uMsg,
        [In] UINT_PTR idEvent,
        [In] DWORD dwTime
    );
}
