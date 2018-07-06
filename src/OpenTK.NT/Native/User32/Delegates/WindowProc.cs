using System.Runtime.InteropServices;
using System.Security;

using LRESULT = System.IntPtr;
using HWND = System.IntPtr;
using LPARAM = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// An application-defined function that processes messages sent to a window. WindowProc is a placeholder for the application-defined function name.
    /// </summary>
    /// <param name="hwnd">A handle to the window.</param>
    /// <param name="uMsg">The message.</param>
    /// <param name="wParam">Additional message information. The contents of this parameter depend on the value of the <paramref name="uMsg"/> parameter.</param>
    /// <param name="lParam">Additional message information. The contents of this parameter depend on the value of the <paramref name="uMsg"/> parameter.</param>
    /// <returns>The return value is the result of the message processing and depends on the message sent.</returns>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate LRESULT WindowProc
    (
        [In] HWND hwnd,
        [In] WindowMessage uMsg,
        [In] WPARAM wParam, 
        [In] LPARAM lParam
    );
}
