using System.Runtime.InteropServices;
using System.Security;
using OpenToolkit.NT.Native.User32.Enums;
using HWND = System.IntPtr;
using LPARAM = System.IntPtr;
using LRESULT = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenToolkit.NT.Native.User32.Delegates
{
    /// <summary>
    /// An application-defined function that processes messages sent to a window. WindowProc is a placeholder for the
    /// application-defined function name.
    /// </summary>
    /// <param name="hwnd">A handle to the window.</param>
    /// <param name="msg">The message.</param>
    /// <param name="wparam">
    /// Additional message information. The contents of this parameter depend on the value of the
    /// <paramref name="msg"/> parameter.
    /// </param>
    /// <param name="lparam">
    /// Additional message information. The contents of this parameter depend on the value of the
    /// <paramref name="msg"/> parameter.
    /// </param>
    /// <returns>The return value is the result of the message processing and depends on the message sent.</returns>
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate LRESULT WindowProc
    (
        [In] HWND hwnd,
        [In] WindowMessage msg,
        [In] WPARAM wparam,
        [In] LPARAM lparam
    );
}
