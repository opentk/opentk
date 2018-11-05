using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines the initialization parameters passed to the window procedure of an application. These members are
    /// identical to the parameters of the
    /// <see cref="User32.Window.CreateWindowEx(ExtendedWindowStyles, IntPtr, string,
    /// WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/> function.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct CreateStruct
    {
        /// <summary>
        /// Contains additional data which may be used to create the window. If the window is being created as a
        /// result of a call to the CreateWindow or
        /// <see cref="User32.Window.CreateWindowEx(ExtendedWindowStyles, IntPtr, string,
        /// WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/>
        /// function, this member contains the value of the lpParam parameter specified in the function call.<para/>
        /// If the window being created is a MDI client window, this member contains a pointer to a CLIENTCREATESTRUCT
        /// structure. If the window being created is a MDI child window, this member contains a pointer to an
        /// MDICREATESTRUCT structure.<para/>
        /// If the window is being created from a dialog template, this member is the address of a <see cref="short"/>
        /// value that specifies the size, in bytes, of the window creation data. The value is immediately followed
        /// by the creation data.
        /// </summary>
        public IntPtr CreateParams;

        /// <summary>
        /// Handle to the module that owns the new window.
        /// </summary>
        public IntPtr Instance;

        /// <summary>
        /// Handle to the menu to be used by the new window.
        /// </summary>
        public IntPtr Menu;

        /// <summary>
        /// Handle to the parent window, if the window is a child window.
        /// If the window is owned, this member identifies the owner window.
        /// If the window is not a child or owned window, this member is null.
        /// </summary>
        public IntPtr Parent;

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
        public WindowStyles Style;

        /// <summary>
        /// Pointer to a null-terminated string that specifies the name of the new window.
        /// </summary>
        public string Name;

        /// <summary>
        /// Either a pointer to a null-terminated string or an atom that specifies the class name
        /// of the new window.
        /// </summary>
        public IntPtr ClassName;

        /// <summary>
        /// The extended window style for the new window.
        /// </summary>
        public ExtendedWindowStyles ExtendedStyle;
    }
}
