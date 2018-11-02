using System;
using System.Runtime.InteropServices;
using OpenToolkit.NT.Native.User32.Delegates;
using OpenToolkit.NT.Native.User32.Enums;
using HBRUSH = System.IntPtr;
using HCURSOR = System.IntPtr;
using HICON = System.IntPtr;
using HINSTANCE = System.IntPtr;
using UINT = System.UInt32;

namespace OpenToolkit.NT.Native.User32.Structs
{
    /// <summary>
    /// Contains window class information. It is used with the
    /// <see cref="User32.WindowClass.RegisterClassEx(ref ExtendedWindowClass)"/> and
    /// <see cref="User32.WindowClass.GetClassInfoEx(HBRUSH, string, out ExtendedWindowClass)"/> functions.<para/>
    /// The <see cref="ExtendedWindowClass"/> structure is similar to the <see cref="WindowClass"/> structure.
    /// There are two differences. <see cref="ExtendedWindowClass"/> includes the <see cref="Size"/> member, which
    /// specifies the size of the structure, and the <see cref="IconSmall"/> member, which contains a handle
    /// to a small icon associated with the window class.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ExtendedWindowClass
    {
        /// <summary>
        /// The size, in bytes, of this structure. Set this member to <see cref="SizeInBytes"/>.<para/>
        /// Be sure to set this member before calling the
        /// <see cref="User32.WindowClass.GetClassInfoEx(HBRUSH, HBRUSH, out ExtendedWindowClass)"/> function.
        /// </summary>
        public UINT Size;

        /// <summary>
        /// The class style(s). This member can be any combination of <see cref="WindowClassStyles"/>.
        /// </summary>
        public WindowClassStyles Style;

        /// <summary>
        /// A pointer to the window procedure. You must use the CallWindowProc function to call the window procedure.
        /// </summary>
        public WindowProc WindowProc;

        /// <summary>
        /// The number of extra bytes to allocate following the window-class structure.
        /// The system initializes the bytes to zero.
        /// </summary>
        public int ClassExtra;

        /// <summary>
        /// The number of extra bytes to allocate following the window instance. The system initializes the bytes
        /// to zero. If an application uses <see cref="ExtendedWindowClass"/> to register a dialog box created by
        /// using the CLASS directive in the resource file, it must set this member to DLGWINDOWEXTRA.
        /// </summary>
        public int WindowExtra;

        /// <summary>
        /// A handle to the instance that contains the window procedure for the class.
        /// </summary>
        public HINSTANCE Instance;

        /// <summary>
        /// A handle to the class icon. This member must be a handle to an icon resource.
        /// If this member is <see cref="IntPtr.Zero"/>, the system provides a default icon.
        /// </summary>
        public HICON Icon;

        /// <summary>
        /// A handle to the class cursor. This member must be a handle to a cursor resource.
        /// If this member is <see cref="IntPtr.Zero"/>, an application must explicitly set the cursor shape
        /// whenever the mouse moves into the application's window.
        /// </summary>
        public HCURSOR Cursor;

        /// <summary>
        /// A handle to the class background brush. This member can be a handle to the brush to be used for
        /// painting the background, or it can be a color value.<para/>
        /// For more information on setting this to a color value, check the official documentation.
        /// </summary>
        public HBRUSH Background;

        /// <summary>
        /// Pointer to a string that specifies the resource name of the class menu, as the name appears in the
        /// resource file. If this member is null, windows belonging to this class have no default menu.
        /// </summary>
        public string MenuName;

        /// <summary>
        /// A string specifying the window class name. The class name can be any name registered with
        /// RegisterClass or <see cref="User32.WindowClass.RegisterClassEx(ref ExtendedWindowClass)"/>,
        /// or any of the predefined control-class names.
        /// </summary>
        public string ClassName;

        /// <summary>
        /// A handle to a small icon that is associated with the window class. If this member is
        /// <see cref="IntPtr.Zero"/>, the system searches the icon resource specified by the hIcon member for an icon
        /// of the appropriate size to use as the small icon.
        /// </summary>
        public HICON IconSmall;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<ExtendedWindowClass>();
    }
}
