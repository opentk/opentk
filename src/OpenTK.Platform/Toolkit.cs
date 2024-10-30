using OpenTK.Platform;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{

    // FIXME: Maybe find another name for this?
    /// <summary>
    /// Provides static access to all OpenTK platform abstraction interfaces.
    /// This is the main way to access the OpenTK PAL2 api.
    /// </summary>
    public static class Toolkit
    {
        private static bool Initialized = false;

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
        private static IVulkanComponent? _vulkanComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting windows.
        /// </summary>
        public static IWindowComponent Window => _windowComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for creating, interacting with, and deleting surfaces.
        /// </summary>
        public static ISurfaceComponent Surface => _surfaceComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for creating, interacting with, and deleting OpenGL contexts.
        /// </summary>
        public static IOpenGLComponent OpenGL => _openGLComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for querying information about displays attached to the system.
        /// </summary>
        public static IDisplayComponent Display => _displayComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for shell functions such as battery information, preferred theme, etc.
        /// </summary>
        public static IShellComponent Shell => _shellComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for getting and setting the mouse position, and getting mouse button information.
        /// </summary>
        public static IMouseComponent Mouse => _mouseComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for dealing with keyboard layouts, conversions between <see cref="Key"/> and <see cref="Scancode"/>, and IME.
        /// </summary>
        public static IKeyboardComponent Keyboard => _keyboardComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for creating, interacting with, and deleting mouse cursor images.
        /// </summary>
        public static ICursorComponent Cursor => _cursorComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for creating, interacting with, and deleting window icon images.
        /// </summary>
        public static IIconComponent Icon => _iconComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for getting and setting clipboard data.
        /// </summary>
        public static IClipboardComponent Clipboard => _clipboardComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for getting joystick input.
        /// </summary>
        public static IJoystickComponent Joystick => _joystickComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for opening system dialogs such as file open dialogs.
        /// </summary>
        public static IDialogComponent Dialog => _dialogComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Interface for opening system dialogs such as file open dialogs.
        /// </summary>
        public static IVulkanComponent Vulkan => _vulkanComponent ??
            (Initialized ? null! : throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it."));

        /// <summary>
        /// Initialize OpenTK with the given settings.
        /// This function must be called before trying to use the OpenTK API.
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
            try { _vulkanComponent = PlatformComponents.CreateVulkanComponent(); } catch (NotSupportedException) { }

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
            if (_vulkanComponent != null)
                _vulkanComponent.Logger = options.Logger;

            // FIXME: Change initialize to take toolkit options
            // This will also allow us to potentially remove the need
            // to have static classes in the different components
            // as they could get instances to each other through
            // this object...
            _windowComponent?.Initialize(options);
            _surfaceComponent?.Initialize(options);
            _openGLComponent?.Initialize(options);
            _displayComponent?.Initialize(options);
            _shellComponent?.Initialize(options);
            _mouseComponent?.Initialize(options);
            _keyboardComponent?.Initialize(options);
            _cursorComponent?.Initialize(options);
            _iconComponent?.Initialize(options);
            _clipboardComponent?.Initialize(options);
            _joystickComponent?.Initialize(options);
            _dialogComponent?.Initialize(options);
            _vulkanComponent?.Initialize(options);

            Initialized = true;
        }

        /// <summary>
        /// Uninitialize OpenTK.
        /// This frees any native resources held.
        /// All allocated windows, opengl contexts, etc should be closed before calling this function.
        /// This function does not need to be called when exiting the application.
        /// This function is only useful if the application will keep running after OpenTK has been uninitialized.
        /// </summary>
        /// <remarks>
        /// There are some irreversible settings on some platforms that cannot be undone once OpenTK has been initialized.
        /// What follows is a list of things that cannot be undone:
        /// <list type="bullet">
        /// <item>DPI awareness in windows is a per process setting that can only be set once.</item>
        /// </list>
        /// </remarks>
        public static void Uninit()
        {
            _vulkanComponent?.Uninitialize();
            _dialogComponent?.Uninitialize();
            _joystickComponent?.Uninitialize();
            _clipboardComponent?.Uninitialize();
            _iconComponent?.Uninitialize();
            _cursorComponent?.Uninitialize();
            _keyboardComponent?.Uninitialize();
            _mouseComponent?.Uninitialize();
            _shellComponent?.Uninitialize();
            _displayComponent?.Uninitialize();
            _openGLComponent?.Uninitialize();
            _surfaceComponent?.Uninitialize();
            _windowComponent?.Uninitialize();

            _vulkanComponent = null;
            _dialogComponent = null;
            _joystickComponent = null;
            _clipboardComponent = null;
            _iconComponent = null;
            _cursorComponent = null;
            _keyboardComponent = null;
            _mouseComponent = null;
            _shellComponent = null;
            _displayComponent = null;
            _openGLComponent = null;
            _surfaceComponent = null;
            _windowComponent = null;

            Initialized = false;
        }
    }
}
