using System.Runtime.InteropServices;
using System.Security;

using LRESULT = System.IntPtr;
using HWND = System.IntPtr;
using LPARAM = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenTK.NT.Native
{
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate LRESULT WindowProc(
        [In] HWND hWnd,
        [In] WM message,
        [In] WPARAM wParam, 
        [In] LPARAM lParam
    );
}
