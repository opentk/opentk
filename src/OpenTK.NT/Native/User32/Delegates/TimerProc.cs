using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HWND = System.IntPtr;
using UINT_PTR = System.IntPtr;

namespace OpenTK.NT.Native
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void TimerProc(
        [In] HWND hwnd,
        [In] WM uMsg,
        [In] UINT_PTR idEvent,
        [In] DWORD dwTime
    );
}
