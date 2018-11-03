using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Defines extended window style flags for usage in <see cref="User32.Window.AdjustWindowRectEx(ref Rect,
    /// WindowStyles, bool, ExtendedWindowStyles)"/> and <see cref="User32.Window.CreateWindowEx(
    /// ExtendedWindowStyles, string, string, WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/>.
    /// </summary>
    [Flags]
    public enum ExtendedWindowStyles : uint
    {
        /// <summary>
        /// The window has a double border; the window can, optionally, be created with a title bar
        /// by specifying the <see cref="WindowStyles.Caption"/> style in the dwStyle parameter.
        /// </summary>
        DialogModalFrame = 0x00000001,

        /// <summary>
        /// The child window created with this style does not send the <see cref="WindowMessage.ParentNotify"/> message
        /// to its parent window when it is created or destroyed.
        /// </summary>
        NoParentModify = 0x00000004,

        /// <summary>
        /// The window should be placed above all non-topmost windows and should stay above them,
        /// even when the window is deactivated. To add or remove this style, use the
        /// <see cref="User32.Window.SetWindowPos(IntPtr, IntPtr, int, int, int, int, SetWindowPosFlags)"/> function.
        /// </summary>
        Topmost = 0x00000008,

        /// <summary>
        /// The window accepts drag-drop files.
        /// </summary>
        AcceptFiles = 0x00000010,

        /// <summary>
        /// The window should not be painted until siblings beneath the window
        /// (that were created by the same thread) have been painted.
        /// The window appears transparent because the bits of underlying
        /// sibling windows have already been painted.<para/>
        /// To achieve transparency without these restrictions, use the SetWindowRgn function.
        /// </summary>
        Transparent = 0x00000020,

        /// <summary>
        /// The window is a MDI child window.
        /// </summary>
        MdiChild = 0x00000040,

        /// <summary>
        /// The window is intended to be used as a floating toolbar. A tool window has a title bar
        /// that is shorter than a normal title bar, and the window title is drawn using a smaller font.
        /// A tool window does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB.
        /// If a tool window has a system menu, its icon is not displayed on the title bar. However,
        /// you can display the system menu by right-clicking or by typing ALT+SPACE.
        /// </summary>
        ToolWindow = 0x00000080,

        /// <summary>
        /// The window has a border with a raised edge.
        /// </summary>
        WindowEdge = 0x00000100,

        /// <summary>
        /// The window has a border with a sunken edge.
        /// </summary>
        ClientEdge = 0x00000200,

        /// <summary>
        /// The title bar of the window includes a question mark. When the user clicks the question mark,
        /// the cursor changes to a question mark with a pointer. If the user then clicks a child window,
        /// the child receives a <see cref="WindowMessage.Help"/> message. The child window should pass the message to
        /// the parent window procedure, which should call the WinHelp function using the HELP_WM_HELP command.
        /// The Help application displays a pop-up window that typically contains help for the child window.<para/>
        /// <see cref="ContextHelp"/> cannot be used with the <see cref="WindowStyles.MaximizeBox"/>
        /// or <see cref="WindowStyles.MinimizeBox"/> styles.
        /// </summary>
        ContextHelp = 0x00000400,

        /// <summary>
        /// The window has generic "right-aligned" properties. This depends on the window class.
        /// This style has an effect only if the shell language is Hebrew, Arabic, or another language
        /// that supports reading-order alignment; otherwise, the style is ignored.<para/>
        /// Using the <see cref="Right"/> style for static or edit controls has the same effect as using the SS_RIGHT
        /// or ES_RIGHT style, respectively. Using this style with button controls has the same effect
        /// as using BS_RIGHT and BS_RIGHTBUTTON styles.
        /// </summary>
        Right = 0x00001000,

        /// <summary>
        /// The window has generic left-aligned properties. This is the default.
        /// </summary>
        Left = 0x00000000,

        /// <summary>
        /// If the shell language is Hebrew, Arabic, or another language that supports reading-order alignment,
        /// the window text is displayed using right-to-left reading-order properties. For other languages,
        /// the style is ignored.
        /// </summary>
        RtlReading = 0x00002000,

        /// <summary>
        /// The window text is displayed using left-to-right reading-order properties. This is the default.
        /// </summary>
        LtrReading = 0x00000000,

        /// <summary>
        /// If the shell language is Hebrew, Arabic, or another language that supports reading order alignment,
        /// the vertical scroll bar (if present) is to the left of the client area.
        /// For other languages, the style is ignored.
        /// </summary>
        LeftScrollbar = 0x00004000,

        /// <summary>
        /// The vertical scroll bar (if present) is to the right of the client area. This is the default.
        /// </summary>
        RightScrollbar = 0x00000000,

        /// <summary>
        /// The window itself contains child windows that should take part in dialog box navigation.<para/>
        /// If this style is specified, the dialog manager recurses into children of this window when performing
        /// navigation operations such as handling the TAB key, an arrow key, or a keyboard mnemonic.
        /// </summary>
        ControlParent = 0x00010000,

        /// <summary>
        /// The window has a three-dimensional border style intended to be used for items
        /// that do not accept user input.
        /// </summary>
        StaticEdge = 0x00020000,

        /// <summary>
        /// Forces a top-level window onto the taskbar when the window is visible.
        /// </summary>
        AppWindow = 0x00040000,

        /// <summary>
        /// The window is an overlapped window.
        /// </summary>
        OverlappedWindow = WindowEdge | ClientEdge,

        /// <summary>
        /// The window is palette window, which is a modeless dialog box that presents an array of commands.
        /// </summary>
        PaletteWindow = WindowEdge | ToolWindow | Topmost,

        /// <summary>
        /// The window is a layered window. This style cannot be used if the window has
        /// a class style of either <see cref="WindowClassStyles.OwnDeviceContext"/> or
        /// <see cref="WindowClassStyles.ClassDeviceContext"/>.<para/>
        /// </summary>
        Layered = 0x00080000,

        /// <summary>
        /// The window does not pass its window layout to its child windows.<para/>
        /// </summary>
        NoInheritLayout = 0x00100000,

        /// <summary>
        /// The window does not render to a redirection surface. This is for windows that do not have visible
        /// content or that use mechanisms other than surfaces to provide their visual.<para/>
        /// </summary>
        NoRedirectionBitmap = 0x00200000,

        /// <summary>
        /// If the shell language is Hebrew, Arabic, or another language that supports reading order alignment,
        /// the horizontal origin of the window is on the right edge.
        /// Increasing horizontal values advance to the left.<para/>
        /// </summary>
        LayoutRtl = 0x00400000,

        /// <summary>
        /// Paints all descendants of a window in bottom-to-top painting order using double-buffering.<para/>
        /// This cannot be used if the window has a class style of either <see cref="WindowClassStyles.OwnDeviceContext"/>
        /// or <see cref="WindowClassStyles.ClassDeviceContext"/>.<para/>
        /// </summary>
        Composited = 0x02000000,

        /// <summary>
        /// A top-level window created with this style does not become the foreground window when the user clicks it.
        /// The system does not bring this window to the foreground when the user minimizes or closes
        /// the foreground window.<para/>
        /// The window should not be activated through programmatic access or via keyboard navigation by accessible
        /// technology, such as Narrator.<para/>
        /// To activate the window, use the SetActiveWindow or <see cref="User32.Window.SetForegroundWindow"/>
        /// function.<para/>
        /// The window does not appear on the taskbar by default. To force the window to appear on the taskbar,
        /// use the <see cref="ExtendedWindowStyles.AppWindow"/> style.<para/>
        /// </summary>
        NoActivate = 0x08000000
    }
}
