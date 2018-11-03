using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Specifies the different types of window messages.
    /// </summary>
    public enum WindowMessage : uint
    {
        /// <summary>
        /// Performs no operation. An application sends the <see cref="Null"/> message if it wants to
        /// post a message that the recipient window will ignore.
        /// </summary>
        Null = 0x0000,

        /// <summary>
        /// Sent when an application requests that a window be created by calling the
        /// <see cref="User32.Window.CreateWindowEx(ExtendedWindowStyles, string, string,
        /// WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/> or CreateWindow function.
        /// (The message is sent before the function returns.) The window procedure of the
        /// new window receives this message after the window is created, but before the window becomes visible.
        /// </summary>
        Create = 0x0001,

        /// <summary>
        /// Sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed
        /// after the window is removed from the screen.<para/>
        /// This message is sent first to the window being destroyed and then to the child windows (if any) as they
        /// are destroyed. During the processing of the message, it can be assumed that all child windows still exist.
        /// </summary>
        Destroy = 0x0002,

        /// <summary>
        /// Sent after a window has been moved.
        /// </summary>
        Move = 0x0003,

        /// <summary>
        /// Sent to a window after its size has changed.
        /// </summary>
        Size = 0x0005,

        /// <summary>
        /// Sent to both the window being activated and the window being deactivated. If the windows use the same
        /// input queue, the message is sent synchronously, first to the window procedure of the top-level window being
        /// deactivated, then to the window procedure of the top-level window being activated. If the windows use
        /// different input queues, the message is sent asynchronously, so the window is activated immediately.
        /// </summary>
        Activate = 0x0006,

        /// <summary>
        /// Sent to a window after it has gained the keyboard focus.
        /// </summary>
        SetFocus = 0x0007,

        /// <summary>
        /// Sent to a window immediately before it loses the keyboard focus.
        /// </summary>
        KillFocus = 0x0008,

        /// <summary>
        /// Sent when an application changes the enabled state of a window. It is sent to the window whose enabled
        /// state is changing. This message is sent before the EnableWindow function returns, but after the enabled
        /// state (<see cref="WindowStyles.Disabled"/> style bit) of the window has changed.
        /// </summary>
        Enable = 0x000A,

        /// <summary>
        /// An application sends the <see cref="SetRedraw"/> message to a window to allow changes in that window
        /// to be redrawn or to prevent changes in that window from being redrawn.
        /// </summary>
        SetRedraw = 0x000B,

        /// <summary>
        /// Sets the text of a window.
        /// </summary>
        SetText = 0x000C,

        /// <summary>
        /// Copies the text that corresponds to a window into a buffer provided by the caller.
        /// </summary>
        GetText = 0x000D,

        /// <summary>
        /// Determines the length, in characters, of the text associated with a window.
        /// </summary>
        GetTextLength = 0x000E,

        /// <summary>
        /// Sent when the system or another application makes a request to paint a portion of an application's window.
        /// The message is sent when the UpdateWindow or RedrawWindow function is called, or by the
        /// <see cref="User32.Message.DispatchMessage(ref Msg)"/> function when the application obtains a
        /// <see cref="WindowMessage.Paint"/> message by using the
        /// <see cref="User32.Message.GetMessage(out Msg, IntPtr, uint, uint)"/> or
        /// <see cref="User32.Message.PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function.
        /// </summary>
        Paint = 0x000F,

        /// <summary>
        /// Sent as a signal that a window or an application should terminate.
        /// </summary>
        Close = 0x0010,

        /// <summary>
        /// Sent when the user chooses to end the session or when an application calls one of the system shutdown
        /// functions. If any application returns zero, the session is not ended. The system stops sending
        /// <see cref="QueryEndSession"/> messages as soon as one application returns zero.
        /// </summary>
        QueryEndSession = 0x0011,

        /// <summary>
        /// Indicates a request to terminate an application, and is generated when the application calls the
        /// <see cref="User32.Message.PostQuitMessage(int)"/> function. This message causes the
        /// <see cref="User32.Message.GetMessage(out Msg, IntPtr, uint, uint)"/> function to return zero.
        /// </summary>
        Quit = 0x0012,

        /// <summary>
        /// Sent to an icon when the user requests that the window be restored to its previous size and position.
        /// </summary>
        QueryOpen = 0x0013,

        /// <summary>
        /// Sent when the window background must be erased (for example, when a window is resized).
        /// The message is sent to prepare an invalidated portion of a window for painting.
        /// </summary>
        EraseBackground = 0x0014,

        /// <summary>
        /// The <see cref="SystemColorChange"/> message is sent to all top-level windows when
        /// a change is made to a system color setting.
        /// </summary>
        SystemColorChange = 0x0015,

        /// <summary>
        /// Sent to an application after the system processes the results of the <see cref="QueryEndSession"/> message.
        /// The <see cref="EndSession"/> message informs the application whether the session is ending.
        /// </summary>
        EndSession = 0x0016,

        /// <summary>
        /// Sent to a window when the window is about to be hidden or shown.
        /// </summary>
        ShowWindow = 0x0018,

        /// <summary>
        /// Sent by an application to all top-level windows after making a change to the
        /// WIN.INI file. The SystemParametersInfo function sends this message
        /// after an application uses the function to change a setting in WIN.INI.
        /// </summary>
        WinIniChange = 0x001A,

        /// <summary>
        /// A message that is sent to all top-level windows when the SystemParametersInfo function changes
        /// a system-wide setting or when policy settings have changed.<para/>
        /// Applications should send <see cref="SettingChange"/> to all top-level windows when they make changes to
        /// system parameters. (This message cannot be sent directly to a window.) To send the
        /// <see cref="SettingChange"/> message to all top-level windows, use the SendMessageTimeout function with the
        /// hwnd parameter set to <see cref="User32.Message.BroadcastHandle"/>.
        /// </summary>
        SettingChange = WinIniChange,

        /// <summary>
        /// Sent to all top-level windows whenever the user changes device-mode settings.
        /// </summary>
        DeviceModeChange = 0x001B,

        /// <summary>
        /// Sent when a window belonging to a different application than the active window is about to be activated.
        /// The message is sent to the application whose window is being activated
        /// and to the application whose window is being deactivated.
        /// </summary>
        ActivateApp = 0x001C,

        /// <summary>
        /// Sent to all top-level windows in the system after changing the pool of font resources.
        /// </summary>
        FontChange = 0x001D,

        /// <summary>
        /// A message that is sent whenever there is a change in the system time.
        /// </summary>
        TimeChange = 0x001E,

        /// <summary>
        /// Sent to cancel certain modes, such as mouse capture. For example, the system sends this message to the
        /// active window when a dialog box or message box is displayed. Certain functions also send this message
        /// explicitly to the specified window regardless of whether it is the active window. For example,
        /// the EnableWindow function sends this message when disabling the specified window.
        /// </summary>
        CancelMode = 0x001F,

        /// <summary>
        /// Sent to a window if the mouse causes the cursor to move within a window and mouse input is not captured.
        /// </summary>
        SetCursor = 0x0020,

        /// <summary>
        /// Sent when the cursor is in an inactive window and the user presses a mouse button. The parent window
        /// receives this message only if the child window passes it to the
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function.
        /// </summary>
        MouseActivate = 0x0021,

        /// <summary>
        /// Sent to a child window when the user clicks the window's title bar or
        /// when the window is activated, moved, or sized.
        /// </summary>
        ChildActivate = 0x0022,

        /// <summary>
        /// Sent by a computer-based training (CBT) application to separate user-input messages
        /// from other messages sent through the WH_JOURNALPLAYBACK procedure.
        /// </summary>
        QueueSync = 0x0023,

        /// <summary>
        /// Sent to a window when the size or position of the window is about to change. An application can use
        /// this message to override the window's default maximized size and position,
        /// or its default minimum or maximum tracking size.
        /// </summary>
        GetMinMaxInfo = 0x0024,

        /// <summary>
        /// Obsolete. Used in Windows NT 3.51 and earlier.
        /// </summary>
        PaintIcon = 0x0026,

        /// <summary>
        /// Obsolete. Used in Windows NT 3.51 and earlier.
        /// </summary>
        IconEraseBackground = 0x0027,

        /// <summary>
        /// Sent to a dialog box procedure to set the keyboard focus to a different control in the dialog box.
        /// </summary>
        NextDialogCtl = 0x0028,

        /// <summary>
        /// Sent from Print Manager whenever a job is added to or removed from the Print Manager queue.
        /// </summary>
        SpoolerStatus = 0x002A,

        /// <summary>
        /// Sent to the parent window of an owner-drawn button, combo box, list box, or menu when a
        /// visual aspect of the button, combo box, list box, or menu has changed.
        /// </summary>
        DrawItem = 0x002B,

        /// <summary>
        /// Sent to the owner window of a combo box, list box, list view control, or menu item when
        /// the control or menu is created.
        /// </summary>
        MeasureItem = 0x002C,

        /// <summary>
        /// Sent to the owner of a list box or combo box when the list box or combo box is destroyed or when items
        /// are removed by the LB_DELETESTRING, LB_RESETCONTENT, CB_DELETESTRING, or CB_RESETCONTENT message.
        /// The system sends a <see cref="DeleteItem"/> message for each deleted item. The system sends the
        /// <see cref="DeleteItem"/> message for any deleted list box or combo box item with nonzero item data.
        /// </summary>
        DeleteItem = 0x002D,

        /// <summary>
        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its
        /// owner in response to a <see cref="KeyDown"/> message.
        /// </summary>
        VKeyToItem = 0x002E,

        /// <summary>
        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its
        /// owner in response to a <see cref="Char"/> message.
        /// </summary>
        CharToItem = 0x002F,

        /// <summary>
        /// Sent to specify the font that a control is to use when drawing text.
        /// </summary>
        SetFont = 0x0030,

        /// <summary>
        /// Sent to a control to retrieve the font with which the control is currently drawing its text.
        /// </summary>
        GetFont = 0x0031,

        /// <summary>
        /// Sent to a window to associate a hot key with the window.
        /// When the user presses the hot key, the system activates the window.
        /// </summary>
        SetHotkey = 0x0032,

        /// <summary>
        /// Sent to determine the hot key associated with a window.
        /// </summary>
        GetHotkey = 0x0033,

        /// <summary>
        /// Sent to a minimized (iconic) window. The window is about to be dragged by the user but does not have an
        /// icon defined for its class. An application can return a handle to an icon or cursor.
        /// The system displays this cursor or icon while the user drags the icon.
        /// </summary>
        QueryDragIcon = 0x0037,

        /// <summary>
        /// Sent to determine the relative position of a new item in the sorted list of an owner-drawn combo box or
        /// list box. Whenever the application adds a new item, the system sends this message to the owner of a
        /// combo box or list box created with the CBS_SORT or LBS_SORT style.
        /// </summary>
        CompareItem = 0x0039,

        /// <summary>
        /// Sent by Active Accessibility to obtain information about an accessible object contained in a server
        /// application. Applications never send this message directly. It is sent only by Active Accessibility
        /// in response to calls to AccessibleObjectFromPoint, AccessibleObjectFromEvent, or
        /// AccessibleObjectFromWindow. However, server applications handle this message.
        /// </summary>
        GetObject = 0x003D,

        /// <summary>
        /// Sent to all top-level windows when the system detects more than 12.5 percent of system time over a
        /// 30- to 60-second interval is being spent compacting memory. This indicates that system memory is low.
        /// </summary>
        Compacting = 0x0041,

        /// <summary>
        /// Marked as "no longer supported" and not officially documented. Use with care.
        /// </summary>
        CommNotify = 0x0044,

        /// <summary>
        /// Sent to a window whose size, position, or place in the Z order is about to change as a result of a
        /// call to the <see cref="User32.Window.SetWindowPos(IntPtr, SetWindowPosHwndEnum, int, int, int, int,
        /// SetWindowPosFlags)"/> function or another window-management function.
        /// </summary>
        WindowPosChanging = 0x0046,

        /// <summary>
        /// Sent to a window whose size, position, or place in the Z order has changed as a result of a call to the
        /// <see cref="User32.Window.SetWindowPos(IntPtr, SetWindowPosHwndEnum, int, int, int, int,
        /// SetWindowPosFlags)"/> function or another window-management function.
        /// </summary>
        WindowPosChanged = 0x0047,

        /// <summary>
        /// Notifies applications that the system, typically a battery-powered personal computer,
        /// is about to enter a suspended mode.<para/>
        /// Obsolete : use <see cref="PowerBroadcast"/> instead.
        /// </summary>
        Power = 0x0048,

        /// <summary>
        /// Sent to pass data to another application.
        /// </summary>
        CopyData = 0x004A,

        /// <summary>
        /// Posted to an application when a user cancels the application's journaling activities.
        /// The message is posted with a null/zero window handle.
        /// </summary>
        CancelJournal = 0x004B,

        /// <summary>
        /// Sent by a common control to its parent window when an event has occurred
        /// or the control requires some information.
        /// </summary>
        Notify = 0x004E,

        /// <summary>
        /// Posted to the window with the focus when the user chooses a new input language, either with the hotkey
        /// (specified in the Keyboard control panel application) or from the indicator on the system taskbar.
        /// An application can accept the change by passing the message to the
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function or reject the change (and prevent it from taking place) by returning immediately.
        /// </summary>
        InputLanguageChangeRequest = 0x0050,

        /// <summary>
        /// Sent to the topmost affected window after an application's input language has been changed. You should
        /// make any application-specific settings and pass the message to the
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function, which passes the message to all first-level child windows. These child windows can pass the
        /// message to
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// to have it pass the message to their child windows, and so on.
        /// </summary>
        InputLanguageChange = 0x0051,

        /// <summary>
        /// Sent to an application that has initiated a training card with Microsoft Windows Help. The message informs
        /// the application when the user clicks an authorable button. An application initiates a training card by
        /// specifying the HELP_TCARD command in a call to the WinHelp function.
        /// </summary>
        TCard = 0x0052,

        /// <summary>
        /// Indicates that the user pressed the F1 key. If a menu is active when F1 is pressed, <see cref="Help"/> is
        /// sent to the window associated with the menu; otherwise, <see cref="Help"/> is sent to the window that has
        /// the keyboard focus. If no window has the keyboard focus, <see cref="Help"/> is sent to the currently
        /// active window.
        /// </summary>
        Help = 0x0053,

        /// <summary>
        /// Sent to all windows after the user has logged on or off. When the user logs on or off, the system updates
        /// the user-specific settings. The system sends this message immediately after updating the settings.
        /// </summary>
        UserChanged = 0x0054,

        /// <summary>
        /// Determines if a window accepts ANSI or Unicode structures in the <see cref="Notify"/> notification message.
        /// <see cref="NotifyFormat"/> messages are sent from a common control to its parent window
        /// and from the parent window to the common control.
        /// </summary>
        NotifyFormat = 0x0055,

        /// <summary>
        /// Notifies a window that the user clicked the right mouse button (right-clicked) in the window.
        /// </summary>
        ContextMenu = 0x007B,

        /// <summary>
        /// Sent to a window when the <see cref="User32.Window.SetWindowLong(IntPtr, int, int)"/>
        /// function is about to change one or more of the window's styles.
        /// </summary>
        StyleChanging = 0x007C,

        /// <summary>
        /// Sent to a window after the <see cref="User32.Window.SetWindowLong(IntPtr, int, int)"/>
        /// function has changed one or more of the window's styles.
        /// </summary>
        StyleChanged = 0x007D,

        /// <summary>
        /// Sent to all windows when the display resolution has changed.
        /// </summary>
        DisplayChange = 0x007E,

        /// <summary>
        /// Sent to a window to retrieve a handle to the large or small icon associated with a window.
        /// The system displays the large icon in the ALT+TAB dialog, and the small icon in the window caption.
        /// </summary>
        GetIcon = 0x007F,

        /// <summary>
        /// Sent by an application to associate a new large or small icon with a window. The system displays the
        /// large icon in the ALT+TAB dialog box, and the small icon in the window caption.
        /// </summary>
        SetIcon = 0x0080,

        /// <summary>
        /// Sent prior to the <see cref="Create"/> message when a window is first created.
        /// </summary>
        NCCreate = 0x0081,

        /// <summary>
        /// Informs a window that its nonclient area is being destroyed. The
        /// <see cref="User32.Window.DestroyWindow(IntPtr)"/> function sends the <see cref="NCDestroy"/> message
        /// to the window following the <see cref="Destroy"/> message.
        /// <see cref="Destroy"/> is used to free the allocated memory object associated with the window.
        /// </summary>
        NCDestroy = 0x0082,

        /// <summary>
        /// Sent when the size and position of a window's client area must be calculated. By processing this message,
        /// an application can control the content of the window's client area when
        /// the size or position of the window changes.
        /// </summary>
        NCCalcSize = 0x0083,

        /// <summary>
        /// Sent to a window when the cursor moves, or when a mouse button is pressed or released. If the mouse is
        /// not captured, the message is sent to the window beneath the cursor.
        /// Otherwise, the message is sent to the window that has captured the mouse.
        /// </summary>
        NCHitTest = 0x0084,

        /// <summary>
        /// Sent to a window when its frame must be painted.
        /// </summary>
        NCPaint = 0x0085,

        /// <summary>
        /// Non Client Area Activated Caption (Title) of the Form.
        /// </summary>
        NCActivate = 0x0086,

        /// <summary>
        /// Sent to the window procedure associated with a control. By default, the system handles all keyboard input
        /// to the control; the system interprets certain types of keyboard input as dialog box navigation keys.
        /// To override this default behavior, the control can respond to the <see cref="GetDialogCode"/> message to
        /// indicate the types of input it wants to process itself.
        /// </summary>
        GetDialogCode = 0x0087,

        /// <summary>
        /// Used to synchronize painting while avoiding linking independent GUI threads.
        /// </summary>
        SyncPaint = 0x0088,

        /// <summary>
        /// Posted to a window when the cursor is moved within the nonclient area of the window. This message is posted
        /// to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCMouseMove = 0x00A0,

        /// <summary>
        /// Posted when the user presses the left mouse button while the cursor is within the nonclient area of a
        /// window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCLButtonDown = 0x00A1,

        /// <summary>
        /// Posted when the user releases the left mouse button while the cursor is within the nonclient area of a
        /// window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCLButtonUp = 0x00A2,

        /// <summary>
        /// Posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area
        /// of a window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCLButtonDoubleClick = 0x00A3,

        /// <summary>
        /// Posted when the user presses the right mouse button while the cursor is within the nonclient area of a
        /// window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCRButtonDown = 0x00A4,

        /// <summary>
        /// Posted when the user releases the right mouse button while the cursor is within the nonclient area of a
        /// window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCRButtonUp = 0x00A5,

        /// <summary>
        /// Posted when the user double-clicks the right mouse button while the cursor is within the nonclient area
        /// of a window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCRButtonDoubleClick = 0x00A6,

        /// <summary>
        /// Posted when the user presses the middle mouse button while the cursor is within the nonclient area of a
        /// window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCMButtonDown = 0x00A7,

        /// <summary>
        /// Posted when the user releases the middle mouse button while the cursor is within the nonclient area of a
        /// window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCMButtonUp = 0x00A8,

        /// <summary>
        /// Posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area
        /// of a window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCMButtonDoubleClick = 0x00A9,

        /// <summary>
        /// Posted when the user presses the first or second X button while the cursor is within the nonclient area
        /// of a window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCXButtonDown = 0x00AB,

        /// <summary>
        /// Posted when the user releases the first or second X button while the cursor is within the nonclient area
        /// of a window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCXButtonUp = 0x00AC,

        /// <summary>
        /// Posted when the user double-clicks the first or second X button while the cursor is within the nonclient
        /// area of a window. This message is posted to the window that contains the cursor.<para/>
        /// If a window has captured the mouse, this message is not posted.
        /// </summary>
        NCXButtonDoubleClick = 0x00AD,

        /// <summary>
        /// Sent to the window that registered to receive raw input.
        /// </summary>
        InputDeviceChange = 0x00FE,

        /// <summary>
        /// Sent to the window that is getting raw input.
        /// </summary>
        Input = 0x00FF,

        /// <summary>
        /// Posted to the window with the keyboard focus when a nonsystem key is pressed.
        /// A nonsystem key is a key that is pressed when the ALT key is not pressed.
        /// </summary>
        KeyDown = 0x0100,

        /// <summary>
        /// This message filters for keyboard messages.
        /// </summary>
        KeyFirst = 0x0100,

        /// <summary>
        /// Posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key
        /// that is pressed when the ALT key is not pressed,
        /// or a keyboard key that is pressed when a window has the keyboard focus.
        /// </summary>
        KeyUp = 0x0101,

        /// <summary>
        /// Posted to the window with the keyboard focus when a <see cref="KeyDown"/> message is translated by the
        /// TranslateMessage function. The <see cref="Char"/> message contains
        /// the character code of the key that was pressed.
        /// </summary>
        Char = 0x0102,

        /// <summary>
        /// Posted to the window with the keyboard focus when a <see cref="KeyUp"/> message is translated by the
        /// TranslateMessage function. <see cref="DeadChar"/> specifies a character code generated by a dead key.
        /// A dead key is a key that generates a character, such as the umlaut (double-dot), that is combined with
        /// another character to form a composite character. For example, the umlaut-O character (Ö) is generated
        /// by typing the dead key for the umlaut character, and then typing the O key.
        /// </summary>
        DeadChar = 0x0103,

        /// <summary>
        /// Posted to the window with the keyboard focus when the user presses the F10 key (which activates the menu
        /// bar) or holds down the ALT key and then presses another key. It also occurs when no window currently
        /// has the keyboard focus; in this case, the <see cref="SystemKeyDown"/> message is sent to the active window.
        /// The window that receives the message can distinguish between these two contexts by
        /// checking the context code in the lParam parameter.
        /// </summary>
        SystemKeyDown = 0x0104,

        /// <summary>
        /// Posted to the window with the keyboard focus when the user releases a key that was pressed while the ALT
        /// key was held down. It also occurs when no window currently has the keyboard focus; in this case, the
        /// <see cref="SystemKeyUp"/> message is sent to the active window. The window that receives the message can
        /// distinguish between these two contexts by checking the context code in the lParam parameter.
        /// </summary>
        SystemKeyUp = 0x0105,

        /// <summary>
        /// Posted to the window with the keyboard focus when a <see cref="SystemKeyDown"/> message is translated by
        /// the TranslateMessage function. It specifies the character code of a system character key — that is, a
        /// character key that is pressed while the ALT key is down.
        /// </summary>
        SystemChar = 0x0106,

        /// <summary>
        /// Sent to the window with the keyboard focus when a <see cref="SystemKeyDown"/> message is translated by the
        /// TranslateMessage function. <see cref="SystemDeadChar"/> specifies the character code of a system dead key
        /// — that is, a dead key that is pressed while holding down the ALT key.
        /// </summary>
        SystemDeadChar = 0x0107,

        /// <summary>
        /// Can be used by an application to post input to other windows. This message contains the character code
        /// of the key that was pressed. (Test whether a target app can process <see cref="UnicodeCharacter"/> messages
        /// by sending the message with wParam set to UNICODE_NOCHAR.)
        /// </summary>
        UnicodeCharacter = 0x0109,

        /// <summary>
        /// This message filters for keyboard messages.
        /// </summary>
        KeyLast = 0x0109,

        /// <summary>
        /// Sent immediately before the IME generates the composition string as a result of a keystroke.
        /// </summary>
        ImeStartComposition = 0x010D,

        /// <summary>
        /// Sent to an application when the IME ends composition.
        /// </summary>
        ImeEndComposition = 0x010E,

        /// <summary>
        /// Sent to an application when the IME changes composition status as a result of a keystroke.
        /// </summary>
        ImeComposition = 0x010F,

        /// <summary>
        /// Same as <see cref="ImeComposition"/>. Documentation incomplete.
        /// </summary>
        ImeKeylast = 0x010F,

        /// <summary>
        /// Sent to the dialog box procedure immediately before a dialog box is displayed. Dialog box procedures
        /// typically use this message to initialize controls and carry out any other
        /// initialization tasks that affect the appearance of the dialog box.
        /// </summary>
        InitDialog = 0x0110,

        /// <summary>
        /// Sent when the user selects a command item from a menu, when a control sends a notification message
        /// to its parent window, or when an accelerator keystroke is translated.
        /// </summary>
        Command = 0x0111,

        /// <summary>
        /// A window receives this message when the user chooses a command from the Window menu (formerly known
        /// as the system or control menu) or when the user chooses the maximize button, minimize button,
        /// restore button, or close button.
        /// </summary>
        SystemCommand = 0x0112,

        /// <summary>
        /// Posted to the installing thread's message queue when a timer expires.
        /// The message is posted by the <see cref="User32.Message.GetMessage(out Msg, IntPtr, uint, uint)"/> or
        /// <see cref="User32.Message.PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function.
        /// </summary>
        Timer = 0x0113,

        /// <summary>
        /// Sent to a window when a scroll event occurs in the window's standard horizontal scroll bar.
        /// This message is also sent to the owner of a horizontal scroll bar control
        /// when a scroll event occurs in the control.
        /// </summary>
        HScroll = 0x0114,

        /// <summary>
        /// Sent to a window when a scroll event occurs in the window's standard vertical scroll bar. This message
        /// is also sent to the owner of a vertical scroll bar control when a scroll event occurs in the control.
        /// </summary>
        VScroll = 0x0115,

        /// <summary>
        /// Sent when a menu is about to become active. It occurs when the user clicks an item on the menu bar or
        /// presses a menu key. This allows the application to modify the menu before it is displayed.
        /// </summary>
        InitMenu = 0x0116,

        /// <summary>
        /// Sent when a drop-down menu or submenu is about to become active. This allows an application to modify
        /// the menu before it is displayed, without changing the entire menu.
        /// </summary>
        InitMenuPopup = 0x0117,

        /// <summary>
        /// Passes information about a gesture.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        Gesture = 0x0119,

        /// <summary>
        /// Gives you a chance to set the gesture configuration.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        GestureNotify = 0x011A,

        /// <summary>
        /// Sent to a menu's owner window when the user selects a menu item.
        /// </summary>
        MenuSelect = 0x011F,

        /// <summary>
        /// Sent when a menu is active and the user presses a key that does not correspond to any mnemonic
        /// or accelerator key. This message is sent to the window that owns the menu.
        /// </summary>
        MenuChar = 0x0120,

        /// <summary>
        /// Sent to the owner window of a modal dialog box or menu that is entering an idle state.
        /// A modal dialog box or menu enters an idle state when no messages are waiting in its queue
        /// after it has processed one or more previous messages.
        /// </summary>
        EnterIdle = 0x0121,

        /// <summary>
        /// Sent when the user releases the right mouse button while the cursor is on a menu item.
        /// </summary>
        MenuRButtonUp = 0x0122,

        /// <summary>
        /// Sent to the owner of a drag-and-drop menu when the user drags a menu item.
        /// </summary>
        MenuDrag = 0x0123,

        /// <summary>
        /// Sent to the owner of a drag-and-drop menu when the mouse cursor enters a menu item or moves
        /// from the center of the item to the top or bottom of the item.
        /// </summary>
        MenuGetObject = 0x0124,

        /// <summary>
        /// Sent when a drop-down menu or submenu has been destroyed.
        /// </summary>
        UninitMenuPopup = 0x0125,

        /// <summary>
        /// Sent when the user makes a selection from a menu.
        /// </summary>
        MenuCommand = 0x0126,

        /// <summary>
        /// Sent by an application to indicate that the UI state should be changed.
        /// </summary>
        ChangeUIState = 0x0127,

        /// <summary>
        /// Sent by an application to change the UI state for the specified window and all its child windows.
        /// </summary>
        UpdateUIState = 0x0128,

        /// <summary>
        /// Sent by an application to retrieve the UI state for a window.
        /// </summary>
        QueryUIState = 0x0129,

        /// <summary>
        /// Sent to the owner window of a message box before Windows draws the message box. By responding to this
        /// message, the owner window can set the text and background colors of the message box
        /// by using the given display device context handle.
        /// </summary>
        CtlColorMsgBox = 0x0132,

        /// <summary>
        /// An edit control that is not read-only or disabled sends the <see cref="CtlColorEdit"/> message to its
        /// parent window when the control is about to be drawn. By responding to this message, the parent window
        /// can use the specified device context handle to set the text and background colors of the edit control.
        /// </summary>
        CtlColorEdit = 0x0133,

        /// <summary>
        /// Sent to the parent window of a list box before the system draws the list box. By responding to this
        /// message, the parent window can set the text and background colors of the list box
        /// by using the specified display device context handle.
        /// </summary>
        CtlColorListBox = 0x0134,

        /// <summary>
        /// Sent to the parent window of a button before drawing the button. The parent window can change
        /// the button's text and background colors. However, only owner-drawn buttons
        /// respond to the parent window processing this message.
        /// </summary>
        CtlColorButton = 0x0135,

        /// <summary>
        /// Sent to a dialog box before the system draws the dialog box. By responding to this message,
        /// the dialog box can set its text and background colors using the specified display device context handle.
        /// </summary>
        CtlColorDialog = 0x0136,

        /// <summary>
        /// Sent to the parent window of a scroll bar control when the control is about to be drawn.
        /// By responding to this message, the parent window can use the display context handle
        /// to set the background color of the scroll bar control.
        /// </summary>
        CtlColorScrollbar = 0x0137,

        /// <summary>
        /// A static control, or an edit control that is read-only or disabled, sends the <see cref="CtlColorStatic"/>
        /// message to its parent window when the control is about to be drawn.
        /// By responding to this message, the parent window can use the specified device context handle
        /// to set the text and background colors of the static control.
        /// </summary>
        CtlColorStatic = 0x0138,

        /// <summary>
        /// Retrieves the menu handle for the current window.
        /// </summary>
        GetHMenu = 0x01E1,

        /// <summary>
        /// Posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window
        /// that contains the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        MouseMove = 0x0200,

        /// <summary>
        /// Use to specify the first mouse message. Use the
        /// <see cref="User32.Message.PeekMessage(out Msg, IntPtr, uint, uint, PeekMessageActions)"/> function.
        /// </summary>
        MouseFirst = 0x0200,

        /// <summary>
        /// Posted when the user presses the left mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        LButtonDown = 0x0201,

        /// <summary>
        /// Posted when the user releases the left mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        LButtonUp = 0x0202,

        /// <summary>
        /// Posted when the user double-clicks the left mouse button while the cursor is in the client area of a
        /// window. If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        LButtonDoubleClick = 0x0203,

        /// <summary>
        /// Posted when the user presses the right mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        RButtonDown = 0x0204,

        /// <summary>
        /// Posted when the user releases the right mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        RButtonUp = 0x0205,

        /// <summary>
        /// Posted when the user double-clicks the right mouse button while the cursor is in the client area of a
        /// window. If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        RButtonDoubleClick = 0x0206,

        /// <summary>
        /// Posted when the user presses the middle mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        MButtonDown = 0x0207,

        /// <summary>
        /// Posted when the user releases the middle mouse button while the cursor is in the client area of a window.
        /// If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        MButtonUp = 0x0208,

        /// <summary>
        /// Posted when the user double-clicks the middle mouse button while the cursor is in the client area of a
        /// window. If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        MButtonDoubleClick = 0x0209,

        /// <summary>
        /// Sent to the focus window when the mouse wheel is rotated. The
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function propagates the message to the window's parent. There should be no internal forwarding of the
        /// message, since
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// propagates it up the parent chain until it finds a window that processes it.
        /// </summary>
        MouseWheel = 0x020A,

        /// <summary>
        /// Posted when the user presses the first or second X button while the cursor is in the client area of a
        /// window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise,
        /// the message is posted to the window that has captured the mouse.
        /// </summary>
        XButtonDown = 0x020B,

        /// <summary>
        /// Posted when the user releases the first or second X button while the cursor is in the client area of a
        /// window. If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        XButtonUp = 0x020C,

        /// <summary>
        /// Posted when the user double-clicks the first or second X button while the cursor is in the client area of
        /// a window. If the mouse is not captured, the message is posted to the window beneath the cursor.
        /// Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        XButtonDoubleClick = 0x020D,

        /// <summary>
        /// Sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. The
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function propagates the message to the window's parent. There should be no internal forwarding of the
        /// message, since
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// propagates it up the parent chain until it finds a window that processes it.
        /// </summary>
        MouseHWheel = 0x020E,

        /// <summary>
        /// Same as <see cref="MouseHWheel"/>. Documentation incomplete.
        /// </summary>
        MouseLast = 0x020E,

        /// <summary>
        /// Sent to the parent of a child window when the child window is created or destroyed, or when the user
        /// clicks a mouse button while the cursor is over the child window. When the child window is being created,
        /// the system sends <see cref="ParentNotify"/> just before the CreateWindow or
        /// <see cref="User32.Window.CreateWindowEx(ExtendedWindowStyles, string, string,
        /// WindowStyles, int, int, int, int, IntPtr, IntPtr, IntPtr, IntPtr)"/>
        /// function that creates the window returns. When the child window is being destroyed, the system sends the
        /// message before any processing to destroy the window takes place.
        /// </summary>
        ParentNotify = 0x0210,

        /// <summary>
        /// Informs an application's main window procedure that a menu modal loop has been entered.
        /// </summary>
        EnterMenuLoop = 0x0211,

        /// <summary>
        /// Informs an application's main window procedure that a menu modal loop has been exited.
        /// </summary>
        ExitMenuLoop = 0x0212,

        /// <summary>
        /// Sent to an application when the right or left arrow key is used
        /// to switch between the menu bar and the system menu.
        /// </summary>
        NextMenu = 0x0213,

        /// <summary>
        /// Sent to a window that the user is resizing. By processing this message, an application can monitor
        /// the size and position of the drag rectangle and, if needed, change its size or position.
        /// </summary>
        Sizing = 0x0214,

        /// <summary>
        /// Sent to the window that is losing the mouse capture.
        /// </summary>
        CaptureChanged = 0x0215,

        /// <summary>
        /// Sent to a window that the user is moving. By processing this message, an application can monitor
        /// the position of the drag rectangle and, if needed, change its position.
        /// </summary>
        Moving = 0x0216,

        /// <summary>
        /// Notifies applications that a power-management event has occurred.
        /// </summary>
        PowerBroadcast = 0x0218,

        /// <summary>
        /// Notifies an application of a change to the hardware configuration of a device or the computer.
        /// </summary>
        DeviceChange = 0x0219,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to create an MDI child window.
        /// </summary>
        MdiCreate = 0x0220,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to close an MDI child window.
        /// </summary>
        MdiDestroy = 0x0221,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to instruct the client window
        /// to activate a different MDI child window.
        /// </summary>
        MdiActivate = 0x0222,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to restore an MDI child
        /// window from maximized or minimized size.
        /// </summary>
        MdiRestore = 0x0223,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to activate the
        /// next or previous child window.
        /// </summary>
        MdiNext = 0x0224,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to maximize an MDI
        /// child window. The system resizes the child window to make its client area fill the client window. The
        /// system places the child window's window menu icon in the rightmost position of the frame window's menu bar,
        /// and places the child window's restore icon in the leftmost position. The system also appends the title bar
        /// text of the child window to that of the frame window.
        /// </summary>
        MdiMaximize = 0x0225,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to arrange all of its MDI
        /// child windows in a tile format.
        /// </summary>
        MdiTile = 0x0226,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to arrange all its MDI
        /// child windows in a cascade format.
        /// </summary>
        MdiCascade = 0x0227,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to arrange all minimized MDI
        /// child windows. It does not affect child windows that are not minimized.
        /// </summary>
        MdiIconArrange = 0x0228,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to retrieve the handle
        /// to the active MDI child window.
        /// </summary>
        MdiGetActive = 0x0229,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to replace the entire menu
        /// of an MDI frame window, to replace the window menu of the frame window, or both.
        /// </summary>
        MdiSetMenu = 0x0230,

        /// <summary>
        /// Sent one time to a window after it enters the moving or sizing modal loop. The window enters the moving or
        /// sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes
        /// the <see cref="SystemCommand"/> message to the
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value.
        /// The operation is complete when
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// returns.
        /// </summary>
        EnterSizeMove = 0x0231,

        /// <summary>
        /// Sent one time to a window, after it has exited the moving or sizing modal loop. The window enters the
        /// moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the
        /// window passes the <see cref="SystemCommand"/> message to the
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value.
        /// The operation is complete when
        /// <see cref="User32.Window.DefWindowProc(IntPtr, WindowMessage, IntPtr, IntPtr)"/>
        /// returns.
        /// </summary>
        ExitSizeMove = 0x0232,

        /// <summary>
        /// Sent when the user drops a file on the window of an application that
        /// has registered itself as a recipient of dropped files.
        /// </summary>
        DropFiles = 0x0233,

        /// <summary>
        /// Sent to a multiple-document interface (MDI) client window by an application to refresh
        /// the window menu of the MDI frame window.
        /// </summary>
        MdiRefreshMenu = 0x0234,

        /// <summary>
        /// Sent to a window when there is a change in the settings of a monitor that has a digitizer attached to it.
        /// This message contains information regarding the scaling of the display mode.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        PointerDeviceChange = 0x0238,

        /// <summary>
        /// Sent to a window when a pointer device is detected within range of an input digitizer.
        /// This message contains information regarding the device and its proximity.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        PointerDeviceInRange = 0x0239,

        /// <summary>
        /// Sent to a window when a pointer device has departed the range of an input digitizer.
        /// This message contains information regarding the device and its proximity.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        PointerDeviceOutOfRange = 0x023A,

        /// <summary>
        /// Notifies the window when one or more touch points, such as a finger or pen,
        /// touches a touch-sensitive digitizer surface.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        Touch = 0x0240,

        /// <summary>
        /// Posted to provide an update on a pointer that made contact over the non-client area of a window or when a
        /// hovering uncaptured contact moves over the non-client area of a window. While the pointer is hovering,
        /// the message targets whichever window the pointer happens to be over. While the pointer is in contact with
        /// the surface, the pointer is implicitly captured to the window over which the pointer made contact and that
        /// window continues to receive input for the pointer until it breaks contact.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        NCPointerUpdate = 0x0241,

        /// <summary>
        /// Posted when a pointer makes contact over the non-client area of a window. The message targets the window
        /// over which the pointer makes contact. The pointer is implicitly captured to the window so that the window
        /// continues to receive input for the pointer until it breaks contact.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        NCPointerDown = 0x0242,

        /// <summary>
        /// Posted when a pointer that made contact over the non-client area of a window breaks contact. The message
        /// targets the window over which the pointer makes contact and the pointer is, at that point, implicitly
        /// captured to the window so that the window continues to receive input for the pointer until it breaks
        /// contact, including the <see cref="NCPointerUp"/> notification.<para/>
        /// If a window has captured this pointer, this message is not posted. Instead, a <see cref="PointerUp"/>
        /// is posted to the window that has captured this pointer.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        NCPointerUp = 0x0243,

        /// <summary>
        /// Posted to provide an update on a pointer that made contact over the client area of a window or on a
        /// hovering uncaptured pointer over the client area of a window. While the pointer is hovering, the message
        /// targets whichever window the pointer happens to be over. While the pointer is in contact with the surface,
        /// the pointer is implicitly captured to the window over which the pointer made contact and that window
        /// continues to receive input for the pointer until it breaks contact.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerUpdate = 0x0245,

        /// <summary>
        /// Posted when a pointer makes contact over the client area of a window. This input message targets the
        /// window over which the pointer makes contact, and the pointer is implicitly captured to the window so
        /// that the window continues to receive input for the pointer until it breaks contact.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerDown = 0x0246,

        /// <summary>
        /// Posted when a pointer that made contact over the client area of a window breaks contact. This input
        /// message targets the window over which the pointer makes contact and the pointer is, at that point,
        /// implicitly captured to the window so that the window continues to receive input messages including
        /// the <see cref="PointerUp"/> notification for the pointer until it breaks contact.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerUp = 0x0247,

        /// <summary>
        /// Sent to a window when a new pointer enters detection range over the window (hover) or when an
        /// existing pointer moves within the boundaries of the window.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerEnter = 0x0249,

        /// <summary>
        /// Sent to a window when a pointer leaves detection range over the window (hover) or when a
        /// pointer moves outside the boundaries of the window.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerLeave = 0x024A,

        /// <summary>
        /// Sent to an inactive window when a primary pointer generates a <see cref="PointerDown"/> over the window.
        /// As long as the message remains unhandled, it travels up the parent window chain until it is reaches the
        /// top-level window. Applications can respond to this message to specify whether they wish to be activated.
        /// <para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerActivate = 0x024B,

        /// <summary>
        /// Sent to a window that is losing capture of an input pointer.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerCaptureChanged = 0x024C,

        /// <summary>
        /// Sent to a window on a touch down in order to determine the most probable touch target.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        TouchHitTesting = 0x024D,

        /// <summary>
        /// Posted to the window with foreground keyboard focus when a scroll wheel is rotated.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerWheel = 0x024E,

        /// <summary>
        /// Posted to the window with foreground keyboard focus when a horizontal scroll wheel is rotated.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerHWheel = 0x024F,

        /// <summary>
        /// This member is not officially documented. Use with care.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerHitTest = 0x0250,

        /// <summary>
        /// Sent when ongoing pointer input, for an existing pointer ID, transitions from one process to another
        /// across content configured for cross-process chaining (AddContentWithCrossProcessChaining).<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerRoutedTo = 0x0251,

        /// <summary>
        /// Sent when pointer input transitions from one process to another across content configured for
        /// cross-process chaining (AddContentWithCrossProcessChaining).<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerRoutedAway = 0x0252,

        /// <summary>
        /// Sent to all processes (configured for cross-process chaining through AddContentWithCrossProcessChaining
        /// and not currently handling pointer input) ever associated with a specific pointer ID,
        /// when a <see cref="PointerUp"/> message is received on the current process.<para/>
        /// Only supported on Windows 8 and higher.
        /// </summary>
        PointerRoutedReleased = 0x0253,

        /// <summary>
        /// Sent to an application when a window is activated.
        /// </summary>
        ImeSetContext = 0x0281,

        /// <summary>
        /// Sent to an application to notify it of changes to the IME window.
        /// </summary>
        ImeNotify = 0x0282,

        /// <summary>
        /// Sent by an application to direct the IME window to carry out the requested command. The application
        /// uses this message to control the IME window that it has created.
        /// </summary>
        ImeControl = 0x0283,

        /// <summary>
        /// Sent to an application when the IME window finds no space to extend the area for the composition window.
        /// </summary>
        ImeCompositionFull = 0x0284,

        /// <summary>
        /// Sent to an application when the operating system is about to change the current IME.
        /// </summary>
        ImeSelect = 0x0285,

        /// <summary>
        /// Sent to an application when the IME gets a character of the conversion result.
        /// </summary>
        ImeChar = 0x0286,

        /// <summary>
        /// Sent to an application to provide commands and request information.
        /// </summary>
        ImeRequest = 0x0288,

        /// <summary>
        /// Sent to an application by the IME to notify the application of a key press and to keep message order.
        /// </summary>
        ImeKeydown = 0x0290,

        /// <summary>
        /// Sent to an application by the IME to notify the application of a key release and to keep message order.
        /// </summary>
        ImeKeyup = 0x0291,

        /// <summary>
        /// Posted to a window when the cursor hovers over the nonclient area of the window for the period of time
        /// specified in a prior call to <see cref="User32.Mouse.TrackMouseEvent(ref TrackMouseEvent)"/>.
        /// </summary>
        NCMouseHover = 0x02A0,

        /// <summary>
        /// Posted to a window when the cursor hovers over the client area of the window for the period of time
        /// specified in a prior call to <see cref="User32.Mouse.TrackMouseEvent(ref TrackMouseEvent)"/>.
        /// </summary>
        MouseHover = 0x02A1,

        /// <summary>
        /// Posted to a window when the cursor leaves the nonclient area of the window specified
        /// in a prior call to <see cref="User32.Mouse.TrackMouseEvent(ref TrackMouseEvent)"/>.
        /// </summary>
        NCMouseLeave = 0x02A2,

        /// <summary>
        /// Posted to a window when the cursor leaves the client area of the window specified
        /// in a prior call to <see cref="User32.Mouse.TrackMouseEvent(ref TrackMouseEvent)"/>.
        /// </summary>
        MouseLeave = 0x02A3,

        /// <summary>
        /// Notifies applications of changes in session state.
        /// </summary>
        WtsSessionChange = 0x02B1,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        TabletFirst = 0x02C0,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        TabletLast = 0x02DF,

        /// <summary>
        /// Sent when the effective dots per inch (dpi) for a window has changed. The DPI is the scale factor for a
        /// window. There are multiple events that can cause the DPI to change.<para/>
        /// Only supported on Windows 7 and higher.
        /// </summary>
        DpiChanged = 0x02E0,

        /// <summary>
        /// For Per Monitor v2 top-level windows, this message is sent to all HWNDs in the child HWDN tree of the
        /// window that is undergoing a DPI change. This message occurs before the top-level window receives
        /// <see cref="DpiChanged"/>, and traverses the child tree from the bottom up.<para/>
        /// Only supported on Windows 10.
        /// </summary>
        DpiChangedBeforeParent = 0x02E2,

        /// <summary>
        /// For Per Monitor v2 top-level windows, this message is sent to all HWNDs in the child HWDN tree of the
        /// window that is undergoing a DPI change. This message occurs after the top-level window receives
        /// <see cref="DpiChanged"/>, and traverses the child tree from the top down.<para/>
        /// Only supported on Windows 10.
        /// </summary>
        DpiChangedAfterParent = 0x02E3,

        /// <summary>
        /// This message tells the operating system that the window will be sized to dimensions other than the default.
        /// <para/>
        /// Only supported on Windows 10.
        /// </summary>
        GetDpiScaledSize = 0x02E4,

        /// <summary>
        /// Sent to an edit control or combo box by an application to delete (cut) the current selection,
        /// if any, in the edit control and copy the deleted text to the clipboard in CF_TEXT format.
        /// </summary>
        Cut = 0x0300,

        /// <summary>
        /// Sent to an edit control or combo box by an application to copy the current selection
        /// to the clipboard in CF_TEXT format.
        /// </summary>
        Copy = 0x0301,

        /// <summary>
        /// Sent to an edit control or combo box by an application to copy the current content of the clipboard to the
        /// edit control at the current caret position.
        /// Data is inserted only if the clipboard contains data in CF_TEXT format.
        /// </summary>
        Paste = 0x0302,

        /// <summary>
        /// Sent to an edit control or combo box by an application to delete (clear) the current selection,
        /// if any, from the edit control.
        /// </summary>
        Clear = 0x0303,

        /// <summary>
        /// Sent to an edit control by an application to undo the last operation. When this message is sent to
        /// an edit control, the previously deleted text is restored or the previously added text is deleted.
        /// </summary>
        Undo = 0x0304,

        /// <summary>
        /// Sent to the clipboard owner if it has delayed rendering a specific clipboard format and if an application
        /// has requested data in that format. The clipboard owner must render data in the specified format
        /// and place it on the clipboard by calling the SetClipboardData function.
        /// </summary>
        RenderFormat = 0x0305,

        /// <summary>
        /// Sent to the clipboard owner before it is destroyed, if the clipboard owner has delayed rendering one or
        /// more clipboard formats. For the content of the clipboard to remain available to other applications,
        /// the clipboard owner must render data in all the formats it is capable of generating, and place the
        /// data on the clipboard by calling the SetClipboardData function.
        /// </summary>
        RenderAllFormats = 0x0306,

        /// <summary>
        /// Sent to the clipboard owner when a call to the EmptyClipboard function empties the clipboard.
        /// </summary>
        DestroyClipboard = 0x0307,

        /// <summary>
        /// Sent to the first window in the clipboard viewer chain when the content of the clipboard changes. This
        /// enables a clipboard viewer window to display the new content of the clipboard.
        /// </summary>
        DrawClipboard = 0x0308,

        /// <summary>
        /// Sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the
        /// CF_OWNERDISPLAY format and the clipboard viewer's client area needs repainting.
        /// </summary>
        PaintClipboard = 0x0309,

        /// <summary>
        /// Sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the
        /// CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's vertical scroll bar.
        /// The owner should scroll the clipboard image and update the scroll bar values.
        /// </summary>
        VScrollClipboard = 0x030A,

        /// <summary>
        /// Sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the
        /// CF_OWNERDISPLAY format and the clipboard viewer's client area has changed size.
        /// </summary>
        SizeClipboard = 0x030B,

        /// <summary>
        /// Sent to the clipboard owner by a clipboard viewer window to request the name of a
        /// CF_OWNERDISPLAY clipboard format.
        /// </summary>
        AskClipboardFormatName = 0x030C,

        /// <summary>
        /// Sent to the first window in the clipboard viewer chain when a window is being removed from the chain.
        /// </summary>
        ChangeClipboardChain = 0x030D,

        /// <summary>
        /// Sent to the clipboard owner by a clipboard viewer window. This occurs when the clipboard contains data in
        /// the CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's horizontal scroll bar. The owner
        /// should scroll the clipboard image and update the scroll bar values.
        /// </summary>
        HScrollClipboard = 0x030E,

        /// <summary>
        /// Informs a window that it is about to receive the keyboard focus, giving the window the opportunity
        /// to realize its logical palette when it receives the focus.
        /// </summary>
        QueryNewPalette = 0x030F,

        /// <summary>
        /// Informs applications that an application is going to realize its logical palette.
        /// </summary>
        PaletteIsChanging = 0x0310,

        /// <summary>
        /// Sent by the OS to all top-level and overlapped windows after the window with the keyboard focus realizes
        /// its logical palette. This message enables windows that do not have the keyboard focus to realize
        /// their logical palettes and update their client areas.
        /// </summary>
        PaletteChanged = 0x0311,

        /// <summary>
        /// Posted when the user presses a hot key registered by the RegisterHotKey function. The message is placed
        /// at the top of the message queue associated with the thread that registered the hot key.
        /// </summary>
        Hotkey = 0x0312,

        /// <summary>
        /// Sent to a window to request that it draw itself in the specified device context,
        /// most commonly in a printer device context.
        /// </summary>
        Print = 0x0317,

        /// <summary>
        /// Sent to a window to request that it draw its client area in the specified device context,
        /// most commonly in a printer device context.
        /// </summary>
        PrintClient = 0x0318,

        /// <summary>
        /// Notifies a window that the user generated an application command event, for example, by clicking an
        /// application command button using the mouse or typing an application command key on the keyboard.<para/>
        /// </summary>
        AppCommand = 0x0319,

        /// <summary>
        /// Broadcast to every window following a theme change event. Examples of theme change events are the
        /// activation of a theme, the deactivation of a theme, or a transition from one theme to another.
        /// </summary>
        ThemeChanged = 0x031A,

        /// <summary>
        /// Sent when the contents of the clipboard have changed.
        /// </summary>
        ClipboardUpdate = 0x031D,

        /// <summary>
        /// Informs all top-level windows that Desktop Window Manager (DWM) composition has been enabled or disabled.
        /// <para/>
        /// Only supported on Windows Vista or higher.
        /// </summary>
        DwmCompositionChanged = 0x031E,

        /// <summary>
        /// Sent when the non-client area rendering policy has changed.<para/>
        /// Only supported on Windows Vista or higher.
        /// </summary>
        DwmNCRenderingChanged = 0x031F,

        /// <summary>
        /// Informs all top-level windows that the colorization color has changed.<para/>
        /// Only supported on Windows Vista or higher.
        /// </summary>
        DwmColorizationColorChanged = 0x0320,

        /// <summary>
        /// Sent when a Desktop Window Manager (DWM) composed window is maximized.<para/>
        /// Only supported on Windows Vista or higher.
        /// </summary>
        DwmWindowMaximizedChange = 0x0321,

        /// <summary>
        /// Instructs a window to provide a static bitmap to use as a thumbnail representation of that window.<para/>
        /// Only supported on Windows 7 or higher.
        /// </summary>
        DwmSendIconicThumbnail = 0x0323,

        /// <summary>
        /// Instructs a window to provide a static bitmap to use as a
        /// live preview (also known as a Peek preview) of that window.<para/>
        /// Only supported on Windows 7 or higher.
        /// </summary>
        DwmSendIconicLivePreviewBitmap = 0x0326,

        /// <summary>
        /// Sent to request extended title bar information.<para/>
        /// Only supported on Windows Vista or higher.
        /// </summary>
        GetTitleBarInfoEx = 0x033F,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        HandheldFirst = 0x0358,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        HandheldLast = 0x035F,

        /// <summary>
        /// Specifies the first afx message.
        /// </summary>
        AfxFirst = 0x0360,

        /// <summary>
        /// Specifies the last afx message.
        /// </summary>
        AfxLast = 0x037F,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        PenWinFirst = 0x0380,

        /// <summary>
        /// This member is not officially documented. Use with care.
        /// </summary>
        PenWinLast = 0x038F,

        /// <summary>
        /// Used by applications to help define private messages,
        /// usually of the form <see cref="App"/> + X, where X is an integer value.
        /// </summary>
        App = 0x8000,

        /// <summary>
        /// Used by applications to help define private messages for use by private window classes,
        /// usually of the form <see cref="User"/> + X, where X is an integer value.
        /// </summary>
        User = 0x0400,
    }
}
