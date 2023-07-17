using System;
using System.Collections.Generic;
using OpenTK.Mathematics;

namespace OpenTK.Core.Platform
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

        /// <summary>
        /// If the window got or lost focus.
        /// </summary>
        public bool GotFocus { get; private set; }

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

        public WindowResizeEventArgs(WindowHandle window, Vector2i newSize) : base(window)
        {
            NewSize = newSize;
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
    public class WindowDpiChangeEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new DPI value in the x-axis.
        /// </summary>
        public int DpiX { get; private set; }

        /// <summary>
        /// The new DPI value in the y-axis.
        /// </summary>
        public int DpiY { get; private set; }

        /// <summary>
        /// The new scale value in the x-axis.
        /// </summary>
        public float ScaleX { get; private set; }

        /// <summary>
        /// The new scale value in the y-axis.
        /// </summary>
        public float ScaleY { get; private set; }

        public WindowDpiChangeEventArgs(WindowHandle window, int dpiX, int dpiY, float scaleX, float scaleY) : base(window)
        {
            DpiX = dpiX;
            DpiY = dpiY;
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

        public KeyDownEventArgs(WindowHandle window, Key key, Scancode scancode, bool isRepeat) : base(window)
        {
            Key = key;
            Scancode = scancode;
            IsRepeat = isRepeat;
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

        public KeyUpEventArgs(WindowHandle window, Key key, Scancode scancode) : base(window)
        {
            Key = key;
            Scancode = scancode;
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

        // FIXME: Include the position where this happened?
        public MouseEnterEventArgs(WindowHandle window, bool entered) : base(window)
        {
            Entered = entered;
        }
    }

    // FIXME: Do we only get these events when the cursor is inside the window??

    /// <summary>
    /// This event is triggered when the mouse moves.
    /// </summary>
    public class MouseMoveEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The new position of the mouse cursor.
        /// </summary>
        public Vector2 Position { get; private set; }

        public MouseMoveEventArgs(WindowHandle window, Vector2 position) : base(window)
        {
            Position = position;
        }
    }

    // FIXME: Maybe make MouseButtonDown and MouseButtonUp the same event type?
    // FIXME: Are mouse down and mouse up events window events?

    /// <summary>
    /// This event is triggered when a mouse button is pressed.
    /// </summary>
    public class MouseButtonDownEventArgs : WindowEventArgs
    {
        /// <summary>
        /// The mouse button that was pressed.
        /// </summary>
        public MouseButton Button { get; private set; }

        public MouseButtonDownEventArgs(WindowHandle window, MouseButton button) : base(window)
        {
            Button = button;
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

        public MouseButtonUpEventArgs(WindowHandle window, MouseButton button) : base(window)
        {
            Button = button;
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

        public PowerStateChangeEventArgs(bool goingToSleep)
        {
            GoingToSleep = goingToSleep;
        }
    }
}
