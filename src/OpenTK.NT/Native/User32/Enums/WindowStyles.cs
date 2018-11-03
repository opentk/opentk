using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Every window has one or more window styles. A window style is a named constant that defines an aspect of the
    /// window's appearance and behavior that is not specified by the window's class. An application usually sets
    /// window styles when creating windows. It can also set the styles after creating a window by using the
    /// <see cref="User32.Window.SetWindowLong(IntPtr, int, int)"/> function.
    /// </summary>
    [Flags]
    public enum WindowStyles : uint
    {
        /// <summary>
        /// The window is an overlapped window. An overlapped window has a title bar and a border.
        /// Same as the <see cref="Tiled"/> style.
        /// </summary>
        Overlapped = 0x00000000,

        /// <summary>
        /// The window is an overlapped window. An overlapped window has a title bar and a border.
        /// Same as the <see cref="Overlapped"/> style.
        /// </summary>
        Tiled = Overlapped,

        /// <summary>
        /// The window is a control that can receive the keyboard focus when the user presses the TAB key. Pressing
        /// the TAB key changes the keyboard focus to the next control with the <see cref="TabStop"/> style.<para/>
        /// You can turn this style on and off to change dialog box navigation. To change this style after a window
        /// has been created, use the <see cref="User32.Window.SetWindowLong(IntPtr, GetWindowLongIndex, IntPtr)"/>
        /// function. For user-created windows and modeless dialogs to work with tab stops,
        /// alter the message loop to call the IsDialogMessage function.
        /// </summary>
        TabStop = 0x00010000,

        /// <summary>
        /// The window has a maximize button. Cannot be combined with the
        /// <see cref="ExtendedWindowStyles.ContextHelp"/> style. The <see cref="SystemMenu"/>
        /// style must also be specified.
        /// </summary>
        MaximizeBox = 0x00010000,

        /// <summary>
        /// The window is the first control of a group of controls. The group consists of this first control and all
        /// controls defined after it, up to the next control with the <see cref="Group"/> style. The first control
        /// in each group usually has the <see cref="TabStop"/> style so that the user can move from group to group.
        /// The user can subsequently change the keyboard focus from one control in the group to
        /// the next control in the group by using the direction keys.<para/>
        /// You can turn this style on and off to change dialog box navigation. To change this style after a window
        /// has been created, use the <see cref="User32.Window.SetWindowLong(IntPtr, GetWindowLongIndex, IntPtr)"/>
        /// function.
        /// </summary>
        Group = 0x00020000,

        /// <summary>
        /// The window has a minimize button. Cannot be combined with the
        /// <see cref="ExtendedWindowStyles.ContextHelp"/> style.
        /// The <see cref="SystemMenu"/> style must also be specified.
        /// </summary>
        MinimizeBox = 0x00020000,

        /// <summary>
        /// The window has a sizing border. Same as the <see cref="SizeBox"/> style.
        /// </summary>
        ThickFrame = 0x00040000,

        /// <summary>
        /// The window has a sizing border. Same as the <see cref="ThickFrame"/> style.
        /// </summary>
        SizeBox = ThickFrame,

        /// <summary>
        /// The window has a window menu on its title bar. The <see cref="Caption"/> style must also be specified.
        /// </summary>
        SystemMenu = 0x00080000,

        /// <summary>
        /// The window has a horizontal scroll bar.
        /// </summary>
        HScroll = 0x00100000,

        /// <summary>
        /// The window has a vertical scroll bar.
        /// </summary>
        VScroll = 0x00200000,

        /// <summary>
        /// The window has a border of a style typically used with dialog boxes.
        /// A window with this style cannot have a title bar.
        /// </summary>
        DialogFrame = 0x00400000,

        /// <summary>
        /// The window has a thin-line border.
        /// </summary>
        Border = 0x00800000,

        /// <summary>
        /// The window has a title bar (includes the <see cref="Border"/> style).
        /// </summary>
        Caption = Border | DialogFrame,

        /// <summary>
        /// The window is initially maximized.
        /// </summary>
        Maximize = 0x01000000,

        /// <summary>
        /// Excludes the area occupied by child windows when drawing occurs within the parent window.
        /// This style is used when creating the parent window.
        /// </summary>
        ClipChildren = 0x02000000,

        /// <summary>
        /// Clips child windows relative to each other; that is, when a particular child window receives a
        /// <see cref="WindowMessage.Paint"/> message, the <see cref="ClipSiblings"/> style clips all other overlapping
        /// child windows out of the region of the child window to be updated. If <see cref="ClipSiblings"/> is not
        /// specified and child windows overlap, it is possible, when drawing within the client area of a child window,
        /// to draw within the client area of a neighboring child window.
        /// </summary>
        ClipSiblings = 0x04000000,

        /// <summary>
        /// The window is initially disabled. A disabled window cannot receive input from the user. To change this
        /// after a window has been created, use the EnableWindow function.
        /// </summary>
        Disabled = 0x08000000,

        /// <summary>
        /// The window is initially visible.<para/>
        /// This style can be turned on and off by using the
        /// <see cref="User32.Window.ShowWindow(IntPtr, ShowWindowCommand)"/> or <see cref="User32.Window.SetWindowPos(
        /// IntPtr, SetWindowPosHwndEnum, int, int, int, int, SetWindowPosFlags)"/> function.
        /// </summary>
        Visible = 0x10000000,

        /// <summary>
        /// The window is initially minimized. Same as the <see cref="Iconic"/> style.
        /// </summary>
        Minimize = 0x20000000,

        /// <summary>
        /// The window is initially minimized. Same as the <see cref="Minimize"/> style.
        /// </summary>
        Iconic = Minimize,

        /// <summary>
        /// The window is a child window. A window with this style cannot have a menu bar.
        /// This style cannot be used with the <see cref="Popup"/> style.
        /// </summary>
        Child = 0x40000000,

        /// <summary>
        /// Same as the <see cref="Child"/> style.
        /// </summary>
        ChildWindow = Child,

        /// <summary>
        /// The windows is a pop-up window. This style cannot be used with the <see cref="Child"/> style.
        /// </summary>
        Popup = 0x80000000,

        /// <summary>
        /// The window is an overlapped window. Same as the <see cref="TiledWindow"/> style.
        /// </summary>
        OverlappedWindow = Overlapped | Caption | SystemMenu | ThickFrame | MinimizeBox | MaximizeBox,

        /// <summary>
        /// The window is an overlapped window. Same as the <see cref="OverlappedWindow"/> style.
        /// </summary>
        TiledWindow = OverlappedWindow,

        /// <summary>
        /// The window is a pop-up window. The <see cref="Caption"/> and
        /// <see cref="PopupWindow"/> styles must be combined to make the window menu visible.
        /// </summary>
        PopupWindow = Popup | Border | SystemMenu,
    }
}
