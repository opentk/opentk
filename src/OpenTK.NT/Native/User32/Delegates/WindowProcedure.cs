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
    public delegate LRESULT WindowProcedure(HWND hWnd, WindowMessage message, WPARAM wParam, LPARAM lParam);
}
