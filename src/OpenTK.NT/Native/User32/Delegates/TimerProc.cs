using System.Runtime.InteropServices;

using HWND = System.IntPtr;
using UINT_PTR = System.IntPtr;

namespace OpenTK.NT.Native
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void TimerProc(HWND hwnd, WindowMessage uMsg, UINT_PTR idEvent, int dwTime);
}
