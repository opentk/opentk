using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenToolkit.NT.Native
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
    public delegate IntPtr WindowProc
    (
        [In] IntPtr hwnd,
        [In] WindowMessage msg,
        [In] IntPtr wparam,
        [In] IntPtr lparam
    );
}
