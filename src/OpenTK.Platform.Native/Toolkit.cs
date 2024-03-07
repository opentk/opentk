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

        public static IWindowComponent Window => _windowComponent;

        public static ISurfaceComponent Surface => _surfaceComponent;

        public static IOpenGLComponent OpenGL => _openGLComponent;

        public static IDisplayComponent Display => _displayComponent;

        public static IShellComponent Shell => _shellComponent;

        public static IMouseComponent Mouse => _mouseComponent;

        public static IKeyboardComponent Keyboard => _keyboardComponent;

        public static ICursorComponent Cursor => _cursorComponent;

        public static IIconComponent Icon => _iconComponent;

        public static IClipboardComponent Clipboard => _clipboardComponent;

        public static IJoystickComponent Joystick => _joystickComponent;

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
        }
    }
}
