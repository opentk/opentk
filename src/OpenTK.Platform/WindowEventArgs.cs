using System;
using System.Collections.Generic;
using OpenTK.Mathematics;

#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Base class for OpenTK window event arguments.
    /// </summary>
    public abstract class WindowEventArgs : EventArgs
    {
        /// <summary>
        /// Handle to the window that this event relates to.
        /// </summary>
        public WindowHandle Window { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that this event relates to.</param>
        public WindowEventArgs(WindowHandle window)
        {
            Window = window;
        }
    }

    // FIXME: Add WindowDisplayChangedEvent??

    /// <summary>
    /// This event is triggered when a window gets or loses input focus.
    /// </summary>
    public class FocusEventArgs : WindowEventArgs
    {
        // FIXME: A reference to the window that got or lost focus?

        // FIXME: The mouse position

        /// <summary>
        /// If the window got or lost focus.
        /// </summary>
        public bool GotFocus { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FocusEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that got or lost focus.</param>
        /// <param name="gotFocus">If the window got focus.</param>
        public FocusEventArgs(WindowHandle window, bool gotFocus) : base(window)
        {
            GotFocus = gotFocus;
        }
    }

    /// <summary>
    /// This event is triggered when a window has its position changed on screen.
    /// </summary>
    public class WindowMoveEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new window position in screen coordinates.
        /// </summary>
        public Vector2i WindowPosition { get; private set; }

        /// <summary>
        /// The new client area position in screen coordinates.
        /// </summary>
        public Vector2i ClientAreaPosition { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowMoveEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that moved.</param>
        /// <param name="windowPosition">The new window position.</param>
        /// <param name="clientAreaPosition">The new window client area position.</param>
        public WindowMoveEventArgs(WindowHandle window, Vector2i windowPosition, Vector2i clientAreaPosition) : base(window)
        {
            WindowPosition = windowPosition;
            ClientAreaPosition = clientAreaPosition;
        }
    }

    /// <summary>
    /// This event is triggered when a window has its size changed on screen.
    /// </summary>
    public class WindowResizeEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new size of the window.
        /// </summary>
        public Vector2i NewSize { get; private set; }

        /// <summary>
        /// The new client size of the window.
        /// </summary>
        public Vector2i NewClientSize { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowResizeEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that got resized.</param>
        /// <param name="newSize">The new window size.</param>
        /// <param name="newClientSize">The new client size of the window.</param>
        // FIXME: Window client size? framebuffer size?
        public WindowResizeEventArgs(WindowHandle window, Vector2i newSize, Vector2i newClientSize) : base(window)
        {
            NewSize = newSize;
            NewClientSize = newClientSize;
        }
    }

    /// <summary>
    /// This event is triggered when a window has its framebuffer change size.
    /// This event can occur for different reasons, not only the window changing size.
    /// </summary>
    public class WindowFramebufferResizeEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new framebuffer size of the window.
        /// </summary>
        public Vector2i NewFramebufferSize { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowFramebufferResizeEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window whoes framebuffer changed size.</param>
        /// <param name="newFramebufferSize">The new framebuffer size.</param>
        public WindowFramebufferResizeEventArgs(WindowHandle window, Vector2i newFramebufferSize) : base(window)
        {
            NewFramebufferSize = newFramebufferSize;
        }
    }

    /// <summary>
    /// This event is triggered when the window mode of a window changes.
    /// </summary>
    public class WindowModeChangeEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new window mode of the window.
        /// </summary>
        public WindowMode NewMode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowModeChangeEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that changed mode.</param>
        /// <param name="newMode">The windows new mode.</param>
        public WindowModeChangeEventArgs(WindowHandle window, WindowMode newMode) : base(window)
        {
            NewMode = newMode;
        }
    }

    /// <summary>
    /// This event is triggered when the DPI of a window changes.
    /// This can happen if the window is moved between monitors with
    /// different DPI scaling settings or if the user changes DPI settings.
    /// </summary>
    public class WindowScaleChangeEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new scale value in the x-axis.
        /// </summary>
        public float ScaleX { get; private set; }

        /// <summary>
        /// The new scale value in the y-axis.
        /// </summary>
        public float ScaleY { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowScaleChangeEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window whose dpi has changed.</param>
        /// <param name="scaleX">The new x axis scale factor.</param>
        /// <param name="scaleY">The new y axis scale factor.</param>
        public WindowScaleChangeEventArgs(WindowHandle window, float scaleX, float scaleY) : base(window)
        {
            ScaleX = scaleX;
            ScaleY = scaleY;
        }
    }

    // FIXME: Are KeyDown and KeyUp window events??

    /// <summary>
    /// This event is triggered when a keyboard key is pressed.
    /// </summary>
    /// <remarks>Do not use this event to handle typing, use <see cref="TextInputEventArgs"/> instead.</remarks>
    public class KeyDownEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The virtual key that was pressed.
        /// FIXME: Document difference between Key and Scancode.
        /// </summary>
        public Key Key { get; private set; }

        /// <summary>
        /// The scancode of the key pressed.
        /// FIXME: Document difference between Key and Scancode.
        /// </summary>
        public Scancode Scancode { get; private set; }

        /// <summary>
        /// Whether this event is caused by holding down this key or not.
        /// </summary>
        public bool IsRepeat { get; private set; }

        /// <summary>
        /// The keyboard modifiers that where down while this key was pressed.
        /// </summary>
        public KeyModifier Modifiers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyDownEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window which received this keypress.</param>
        /// <param name="key">The key that was pressed.</param>
        /// <param name="scancode">The scancode representing the key.</param>
        /// <param name="isRepeat">True if this event is triggered by holding down the key, false otherwise.</param>
        /// <param name="modifiers">The keyboard modifiers that where down while this key was pressed.</param>
        public KeyDownEventArgs(WindowHandle window, Key key, Scancode scancode, bool isRepeat, KeyModifier modifiers) : base(window)
        {
            Key = key;
            Scancode = scancode;
            IsRepeat = isRepeat;
            Modifiers = modifiers;
        }
    }

    /// <summary>
    /// This event is triggered when a keyboard key is released.
    /// </summary>
    /// <remarks>Do not use this event to handle typing, use <see cref="TextInputEventArgs"/> instead.</remarks>
    public class KeyUpEventArgs : WindowEventArgs
    {
        // FIXME: These properties are for testing with the Win32 backend.

        /// <summary>
        /// The virtual key that was pressed.
        /// FIXME: Document difference between Key and Scancode.
        /// </summary>
        public Key Key { get; private set; }

        /// <summary>
        /// The scancode of the key pressed.
        /// FIXME: Document difference between Key and Scancode.
        /// </summary>
        public Scancode Scancode { get; private set; }

        /// <summary>
        /// The keyboard modifiers that where down while this key was released.
        /// </summary>
        public KeyModifier Modifiers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyUpEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window which received this keypress.</param>
        /// <param name="key">The key that was released.</param>
        /// <param name="scancode">The scancode representing the key.</param>
        /// <param name="modifiers">The keyboard modifiers that where down while this key was released.</param>
        public KeyUpEventArgs(WindowHandle window, Key key, Scancode scancode, KeyModifier modifiers) : base(window)
        {
            Key = key;
            Scancode = scancode;
            Modifiers = modifiers;
        }
    }

    /// <summary>
    /// This event is triggered when the user has typed text.
    /// </summary>
    /// <seealso cref="TextEditingEventArgs"/>.
    public class TextInputEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The text the user entered.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window which received this text input.</param>
        /// <param name="text">The typed text.</param>
        public TextInputEventArgs(WindowHandle window, string text) : base(window)
        {
            Text = text;
        }
    }

    /// <summary>
    /// This event is triggered when the user is composing text using something like IME (e.g. Chinese, Japanese, or Korean).
    /// </summary>
    public class TextEditingEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The candidate string.
        /// </summary>
        public string Candidate { get; private set; }

        /// <summary>
        /// The caret position within the candidate string.
        /// </summary>
        public int Cursor { get; private set; }

        /// <summary>
        /// The length of the text being edited.
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEditingEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window in which the text is being edited.</param>
        /// <param name="candidate">The candidate string.</param>
        /// <param name="cursor">The caret position within the candidate string.</param>
        /// <param name="length">The length of the text being edited.</param>
        public TextEditingEventArgs(WindowHandle window, string candidate, int cursor, int length) : base(window)
        {
            Candidate = candidate;
            Cursor = cursor;
            Length = length;
        }
    }

    /// <summary>
    /// This event is triggered when the input language is changed.
    /// This can change the keyboard layout.
    /// When this event occurs the values from
    /// <see cref="IKeyboardComponent.GetKeyFromScancode(Scancode)"/> and
    /// <see cref="IKeyboardComponent.GetScancodeFromKey(Key)"/>
    /// are updated to reflect the new layout keyboard layout.
    /// </summary>
    public class InputLanguageChangedEventArgs : EventArgs
    {
        /// <summary>
        /// The new keyboard layout. This indicates how physical keys are mapped to virtual keys.
        /// E.g. The difference between QWERTY and AZERTY.
        /// </summary>
        public string KeyboardLayout { get; private set; }

        /// <summary>
        /// The keyboard layout display name. This is the user facing name of the keyboard layout.
        /// </summary>
        public string KeyboardLayoutDisplayName { get; private set; }

        /// <summary>
        /// The input language. This is separate from keyboard layout.
        /// This could be used for features such as spell checking.
        ///
        /// FIXME: In what fromat should the input language be sent in?.
        /// </summary>
        public string InputLanguage { get; private set; }

        /// <summary>
        /// Localized display name for the new input language.
        /// </summary>
        public string InputLanguageDisplayName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputLanguageChangedEventArgs"/> class.
        /// </summary>
        /// <param name="keyboardLayout">The keyboard layout name of the new layout.</param>
        /// <param name="keyboardLayoutDisplayName">The user facing keyboard layout name of the new layout.</param>
        /// <param name="inputLanguage">The input language name of the new language.</param>
        /// <param name="inputLanguageDisplayName">The user facing input language of the new language.</param>
        public InputLanguageChangedEventArgs(string keyboardLayout, string keyboardLayoutDisplayName, string inputLanguage, string inputLanguageDisplayName)
        {
            KeyboardLayout = keyboardLayout;
            KeyboardLayoutDisplayName = keyboardLayoutDisplayName;
            InputLanguage = inputLanguage;
            InputLanguageDisplayName = inputLanguageDisplayName;
        }
    }

    /// <summary>
    /// This event is triggered when the mouse cursor enters or exits a window.
    /// </summary>
    public class MouseEnterEventArgs : WindowEventArgs
    {
        /// <summary>
        /// Whether the cursor entered or exited the window.
        /// </summary>
        public bool Entered { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseEnterEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that the mouse entered or exited.</param>
        /// <param name="entered">Whether the mouse entered or exited.</param>
        // FIXME: Include the position where this happened?
        public MouseEnterEventArgs(WindowHandle window, bool entered) : base(window)
        {
            Entered = entered;
        }
    }

    /// <summary>
    /// This event is triggered when the mouse moves.
    /// </summary>
    public class MouseMoveEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new position of the mouse cursor in client coordinates.
        /// Use <see cref="IWindowComponent.ClientToScreen(WindowHandle, int, int, out int, out int)"/> and
        /// <see cref="IWindowComponent.ClientToFramebuffer(WindowHandle, int, int, out int, out int)"/> to
        /// convert to the respective coordinate spaces.
        /// When using <see cref="CursorCaptureMode.Locked"/> this property will contain a virtual mouse position
        /// and will not correspond an actual location in client coordinates.
        /// </summary>
        /// <seealso cref="IWindowComponent.ClientToScreen(WindowHandle, int, int, out int, out int)"/>
        /// <seealso cref="IWindowComponent.ClientToFramebuffer(WindowHandle, int, int, out int, out int)"/>
        /// <seealso cref="CursorCaptureMode.Locked"/>
        public Vector2 ClientPosition { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseMoveEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window in which the mouse moved.</param>
        /// <param name="clientPosition">The mouse position in client coordinates.</param>
        public MouseMoveEventArgs(WindowHandle window, Vector2 clientPosition) : base(window)
        {
            ClientPosition = clientPosition;
        }
    }

    /// <summary>
    /// This event is triggered when the mouse moves and raw mouse motion is enabled.
    /// </summary>
    public class RawMouseMoveEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The unscaled movement value of the mouse.
        /// Positive X and Y deltas indicate a right and down movement, while
        /// negative X and Y deltas indicate a left and up movement.
        /// The absolute values of this property will be different between different hardware.
        /// </summary>
        public Vector2 Delta { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawMouseMoveEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window in which the mouse moved.</param>
        /// <param name="delta">The raw mouse delta.</param>
        public RawMouseMoveEventArgs(WindowHandle window, Vector2 delta) : base(window)
        {
            Delta = delta;
        }
    }

    // FIXME: Maybe make MouseButtonDown and MouseButtonUp the same event type?
    // FIXME: Are mouse down and mouse up events window events?

    /// <summary>
    /// This event is triggered when a mouse button is pressed.
    /// </summary>
    // FIXME: Position info?
    public class MouseButtonDownEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The mouse button that was pressed.
        /// </summary>
        public MouseButton Button { get; private set; }

        /// <summary>
        /// The active keyboard modifiers when the mouse button was pressed.
        /// </summary>
        public KeyModifier Modifiers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseButtonDownEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that was clicked on.</param>
        /// <param name="button">The mouse button that was pressed.</param>
        /// <param name="modifiers">The modifiers that where active when the mouse button was pressed.</param>
        public MouseButtonDownEventArgs(WindowHandle window, MouseButton button, KeyModifier modifiers) : base(window)
        {
            Button = button;
            Modifiers = modifiers;
        }
    }

    /// <summary>
    /// This event is triggered when a mouse button is released.
    /// </summary>
    public class MouseButtonUpEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The mouse button that was released.
        /// </summary>
        public MouseButton Button { get; private set; }

        /// <summary>
        /// The active keyboard modifiers when the mouse button was released.
        /// </summary>
        public KeyModifier Modifiers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseButtonUpEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that had input focus when the mouse is released.</param>
        /// <param name="button">The button that was released.</param>
        /// <param name="modifiers">The modifiers that where active when the mouse button was released.</param>
        public MouseButtonUpEventArgs(WindowHandle window, MouseButton button, KeyModifier modifiers) : base(window)
        {
            Button = button;
            Modifiers = modifiers;
        }
    }

    /// <summary>
    /// This event is triggered when the scrollwheel on a mouse is used.
    /// </summary>
    public class ScrollEventArgs : WindowEventArgs
    {
        /// <summary>
        /// How much the mouse wheel has moved.
        /// </summary>
        public Vector2 Delta { get; private set; }

        /// <summary>
        /// The distance to move screen content.
        /// This takes into account user settings for scrolling speed.
        /// Measured in vertical lines and horizontal characters.
        /// </summary>
        // FIXME? Explain this better. Also does this exist on other platforms?
        public Vector2 Distance { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that received the scrolling.</param>
        /// <param name="delta">The number of steps that where scrolled.</param>
        /// <param name="distance">The distance that was scrolled (affected by user scroll speed settings).</param>
        public ScrollEventArgs(WindowHandle window, Vector2 delta, Vector2 distance) : base(window)
        {
            Delta = delta;
            Distance = distance;
        }
    }

    /// <summary>
    /// This event is triggered when the user presses the exit button of a window.
    /// </summary>
    public class CloseEventArgs : WindowEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloseEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window that the user wants to close.</param>
        public CloseEventArgs(WindowHandle window) : base(window)
        {
        }
    }

    /// <summary>
    /// This event is triggered when a user drags files into a window.
    /// </summary>
    public class FileDropEventArgs : WindowEventArgs
    {
        /// <summary>
        /// A list of file paths that represent the files the user dragged into the window.
        /// </summary>
        public IReadOnlyList<string> FilePaths { get; private set; }

        /// <summary>
        /// The position within the window that the user dropped the files.
        /// </summary>
        public Vector2i Position { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDropEventArgs"/> class.
        /// </summary>
        /// <param name="window">The window where files where drag-and-dropped in.</param>
        /// <param name="filePaths">A list of files to the files dropped.</param>
        /// <param name="position">The position in the window where the files where dropped.</param>
        public FileDropEventArgs(WindowHandle window, IReadOnlyList<string> filePaths, Vector2i position) : base(window)
        {
            FilePaths = filePaths;
            Position = position;
        }
    }

    // FIXME: This is not a window event

    /// <summary>
    /// This event is triggered when the contents of the clipboard is changed.
    /// </summary>
    public class ClipboardUpdateEventArgs : EventArgs
    {
        /// <summary>
        /// The format of the new clipboard contents.
        /// </summary>
        public ClipboardFormat NewFormat { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipboardUpdateEventArgs"/> class.
        /// </summary>
        /// <param name="newFormat">The new format of the clipboard.</param>
        public ClipboardUpdateEventArgs(ClipboardFormat newFormat)
        {
            NewFormat = newFormat;
        }
    }

    /// <summary>
    /// This event is triggered when a user changes the preferred theme.
    /// </summary>
    public class ThemeChangeEventArgs : EventArgs
    {
        /// <summary>
        /// A <see cref="ThemeInfo"/> struct representing the new preferred theme.
        /// </summary>
        public ThemeInfo NewTheme { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeChangeEventArgs"/> class.
        /// </summary>
        /// <param name="newTheme">The new <see cref="ThemeInfo"/>.</param>
        public ThemeChangeEventArgs(ThemeInfo newTheme)
        {
            NewTheme = newTheme;
        }
    }

    /// <summary>
    /// This event is triggered when a display is connected or disconnected from the system.
    /// </summary>
    public class DisplayConnectionChangedEventArgs : EventArgs
    {
        /// <summary>
        /// A handle to the display that was connected or got disconnected.
        /// </summary>
        public DisplayHandle Display { get; private set; }

        /// <summary>
        /// Whether the monitor was connected or disconnected.
        /// </summary>
        public bool Disconnected { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayConnectionChangedEventArgs"/> class.
        /// </summary>
        /// <param name="display">The display that was either connected or disconnected.</param>
        /// <param name="disconnected">If the display was connected or disconnected.</param>
        // FIXME: Maybe add more data about the display...?
        public DisplayConnectionChangedEventArgs(DisplayHandle display, bool disconnected)
        {
            Display = display;
            Disconnected = disconnected;
        }
    }

    /// <summary>
    /// This event is triggered when the power state of the system changes.
    /// </summary>
    public class PowerStateChangeEventArgs : EventArgs
    {
        /// <summary>
        /// If the computer is entering sleep or if it's being woken from sleep.
        /// </summary>
        public bool GoingToSleep { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerStateChangeEventArgs"/> class.
        /// </summary>
        /// <param name="goingToSleep">If we are going to sleep.</param>
        public PowerStateChangeEventArgs(bool goingToSleep)
        {
            GoingToSleep = goingToSleep;
        }
    }
}
