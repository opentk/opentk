using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native
{
    public sealed class ToolkitOptions
    {
        public string ApplicationName { get; set; } = "OpenTK Application";

        public ILogger? Logger { get; set; } = null;
    }

    // FIXME: Maybe find another name for this?
    /// <summary>
    /// Provides static access to all OpenTK platform abstraction interfaces.
    /// This is the main way to access the OpenTK PAL2 api.
    /// </summary>
    public static class Toolkit
    {
        private static IClipboardComponent? _clipboardComponent;
        private static ICursorComponent? _cursorComponent;
        private static IDisplayComponent? _displayComponent;
        private static IIconComponent? _iconComponent;
        private static IKeyboardComponent? _keyboardComponent;
        private static IMouseComponent? _mouseComponent;
        private static IOpenGLComponent? _openGLComponent;
        private static ISurfaceComponent? _surfaceComponent;
        private static IWindowComponent? _windowComponent;
        private static IShellComponent? _shellComponent;
        private static IJoystickComponent? _joystickComponent;
        private static IDialogComponent? _dialogComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting windows.
        /// </summary>
        public static IWindowComponent Window => _windowComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting surfaces.
        /// </summary>
        public static ISurfaceComponent Surface => _surfaceComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting OpenGL contexts.
        /// </summary>
        public static IOpenGLComponent OpenGL => _openGLComponent;

        /// <summary>
        /// Interface for querying information about displays attached to the system.
        /// </summary>
        public static IDisplayComponent Display => _displayComponent;

        /// <summary>
        /// Interface for shell functions such as battery information, preferred theme, etc.
        /// </summary>
        public static IShellComponent Shell => _shellComponent;

        /// <summary>
        /// Interface for getting and setting the mouse position, and getting mouse button information.
        /// </summary>
        public static IMouseComponent Mouse => _mouseComponent;

        /// <summary>
        /// Interface for dealing with keyboard layouts, conversions between <see cref="Key"/> and <see cref="Scancode"/>, and IME.
        /// </summary>
        public static IKeyboardComponent Keyboard => _keyboardComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting mouse cursor images.
        /// </summary>
        public static ICursorComponent Cursor => _cursorComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting window icon images.
        /// </summary>
        public static IIconComponent Icon => _iconComponent;

        /// <summary>
        /// Interface for getting and setting clipboard data.
        /// </summary>
        public static IClipboardComponent Clipboard => _clipboardComponent;

        /// <summary>
        /// Interface for getting joystick input.
        /// </summary>
        public static IJoystickComponent Joystick => _joystickComponent;

        /// <summary>
        /// Interface for opening system dialogs such as file open dialogs.
        /// </summary>
        public static IDialogComponent Dialog => _dialogComponent;

        /// <summary>
        /// Initialize OpenTK with the given settings.
        /// This function must be called before trying to use the OpenTK api.
        /// </summary>
        /// <param name="options">The options to initialize with.</param>
        public static void Init(ToolkitOptions options)
        {
            // FIXME: Figure out options...

            try { _windowComponent = PlatformComponents.CreateWindowComponent(); } catch (NotSupportedException) { }
            try { _surfaceComponent = PlatformComponents.CreateSurfaceComponent(); } catch (NotSupportedException) { }
            try { _openGLComponent = PlatformComponents.CreateOpenGLComponent(); } catch (NotSupportedException) { }
            try { _displayComponent = PlatformComponents.CreateDisplayComponent(); } catch (NotSupportedException) { }
            try { _shellComponent = PlatformComponents.CreateShellComponent(); } catch (NotSupportedException) { }
            try { _mouseComponent = PlatformComponents.CreateMouseComponent(); } catch (NotSupportedException) { }
            try { _keyboardComponent = PlatformComponents.CreateKeyboardComponent(); } catch (NotSupportedException) { }
            try { _cursorComponent = PlatformComponents.CreateCursorComponent(); } catch (NotSupportedException) { }
            try { _iconComponent = PlatformComponents.CreateIconComponent(); } catch (NotSupportedException) { }
            try { _clipboardComponent = PlatformComponents.CreateClipboardComponent(); } catch (NotSupportedException) { }
            try { _joystickComponent = PlatformComponents.CreateJoystickComponent(); } catch (NotSupportedException) { }
            try { _dialogComponent = PlatformComponents.CreateDialogComponent(); } catch (NotSupportedException) { }

            if (_windowComponent != null)
                _windowComponent.Logger = options.Logger;
            if (_surfaceComponent != null)
                _surfaceComponent.Logger = options.Logger;
            if (_openGLComponent != null)
                _openGLComponent.Logger = options.Logger;
            if (_displayComponent != null)
                _displayComponent.Logger = options.Logger;
            if (_shellComponent != null)
                _shellComponent.Logger = options.Logger;
            if (_mouseComponent != null)
                _mouseComponent.Logger = options.Logger;
            if (_keyboardComponent != null)
                _keyboardComponent.Logger = options.Logger;
            if (_cursorComponent != null)
                _cursorComponent.Logger = options.Logger;
            if (_iconComponent != null)
                _iconComponent.Logger = options.Logger;
            if (_clipboardComponent != null)
                _clipboardComponent.Logger = options.Logger;
            if (_joystickComponent != null)
                _joystickComponent.Logger = options.Logger;
            if (_dialogComponent != null)
                _dialogComponent.Logger = options.Logger;

            // FIXME: Change initialize to take toolkit options
            // This will also allow us to potentially remove the need
            // to have static classes in the different components
            // as they could get instances to each other through
            // this object...
            _windowComponent?.Initialize(PalComponents.Window);
            _surfaceComponent?.Initialize(PalComponents.Surface);
            _openGLComponent?.Initialize(PalComponents.OpenGL);
            _displayComponent?.Initialize(PalComponents.Display);
            _shellComponent?.Initialize(PalComponents.Shell);
            _mouseComponent?.Initialize(PalComponents.MiceInput);
            _keyboardComponent?.Initialize(PalComponents.KeyboardInput);
            _cursorComponent?.Initialize(PalComponents.MouseCursor);
            _iconComponent?.Initialize(PalComponents.WindowIcon);
            _clipboardComponent?.Initialize(PalComponents.Clipboard);
            _joystickComponent?.Initialize(PalComponents.Joystick);
            _dialogComponent?.Initialize(PalComponents.Dialog);
        }
    }
}
