using System.Runtime.InteropServices;

using DWORD = System.UInt32;
using HINSTANCE = System.IntPtr;
using HMENU = System.IntPtr;
using HWND = System.IntPtr;
using LPVOID = System.IntPtr;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CreateStruct
    {
        /// <summary>
        /// Contains additional data which may be used to create the window.
        /// </summary>
        /// <remarks>
        /// If the window is being created as a result of a call to the CreateWindow
        /// or CreateWindowEx function, this member contains the value of the lpParam
        /// parameter specified in the function call.
        ///  <para>
        /// If the window being created is a multiple-document interface (MDI) client window,
        /// this member contains a pointer to a CLIENTCREATESTRUCT structure. If the window
        /// being created is a MDI child window, this member contains a pointer to an
        /// MDICREATESTRUCT structure.
        ///  </para>
        ///  <para>
        /// Windows NT/2000/XP: If the window is being created from a dialog template,
        /// this member is the address of a SHORT value that specifies the size, in bytes,
        /// of the window creation data. The value is immediately followed by the creation data.
        ///  </para>
        ///  <para>
        /// Windows NT/2000/XP: You should access the data represented by the lpCreateParams member
        /// using a pointer that has been declared using the UNALIGNED type, because the pointer
        /// may not be DWORD aligned.
        ///  </para>
        /// </remarks>
        public LPVOID CreateParams;

        /// <summary>
        /// Handle to the module that owns the new window.
        /// </summary>
        public HINSTANCE Instance;

        /// <summary>
        /// Handle to the menu to be used by the new window.
        /// </summary>
        public HMENU Menu;

        /// <summary>
        /// Handle to the parent window, if the window is a child window.
        /// If the window is owned, this member identifies the owner window.
        /// If the window is not a child or owned window, this member is NULL.
        /// </summary>
        public HWND Parent;

        /// <summary>
        /// Specifies the height of the new window, in pixels.
        /// </summary>
        public int Height;

        /// <summary>
        /// Specifies the width of the new window, in pixels.
        /// </summary>
        public int Width;

        /// <summary>
        /// Specifies the y-coordinate of the upper left corner of the new window.
        /// If the new window is a child window, coordinates are relative to the parent window.
        /// Otherwise, the coordinates are relative to the screen origin.
        /// </summary>
        public int Y;

        /// <summary>
        /// Specifies the x-coordinate of the upper left corner of the new window.
        /// If the new window is a child window, coordinates are relative to the parent window.
        /// Otherwise, the coordinates are relative to the screen origin.
        /// </summary>
        public int X;

        /// <summary>
        /// Specifies the style for the new window.
        /// </summary>
        public WindowStyleFlags Style;

        /// <summary>
        /// Pointer to a null-terminated string that specifies the name of the new window.
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)]
        public string Name;

        /// <summary>
        /// Either a pointer to a null-terminated string or an atom that specifies the class name
        /// of the new window.
        ///  <remarks>
        /// Note  Because the lpszClass member can contain a pointer to a local (and thus inaccessable) atom,
        /// do not obtain the class name by using this member. Use the GetClassName function instead.
        ///  </remarks>
        /// </summary>
        [MarshalAs(UnmanagedType.LPTStr)]
        public string ClassName;

        /// <summary>
        /// Specifies the extended window style for the new window.
        /// </summary>
        public ExtendedWindowStyleFlags ExtendedStyle;
    }
}
