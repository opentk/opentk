using OpenTK.Platform;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides static access to all OpenTK platform abstraction interfaces.
    /// This is the main way to access the OpenTK PAL2 api.
    /// </summary>
    /// <seealso cref="ToolkitOptions"/>
    public static class Toolkit
    {
        private static bool Initialized = false;
        private static bool EnableOpenGL = false;
        private static bool EnableVulkan = false;

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
        private static IGamepadComponent? _gamepadComponent;
        private static IDialogComponent? _dialogComponent;
        private static IVulkanComponent? _vulkanComponent;

        /// <summary>
        /// Interface for creating, interacting with, and deleting windows.
        /// </summary>
        public static IWindowComponent Window => _windowComponent ??
            (Initialized ? null! : ThrowNotInitialized<IWindowComponent>());

        /// <summary>
        /// Interface for creating, interacting with, and deleting surfaces.
        /// </summary>
        public static ISurfaceComponent Surface => _surfaceComponent ??
            (Initialized ? null! : ThrowNotInitialized<ISurfaceComponent>());

        /// <summary>
        /// Interface for creating, interacting with, and deleting OpenGL contexts.
        /// </summary>
        public static IOpenGLComponent OpenGL
        {
            get
            {
                if (_openGLComponent != null)
                {
                    return _openGLComponent;
                }
                else if (!Initialized)
                {
                    return ThrowNotInitialized<IOpenGLComponent>();
                }
                else if (!EnableOpenGL)
                {
                    return ThrowFeatureNotEnabled<IOpenGLComponent>("OpenGL", ToolkitFlags.EnableOpenGL);
                }
                else
                {
                    return null!;
                }
            }
        }

        /// <summary>
        /// Interface for querying information about displays attached to the system.
        /// </summary>
        public static IDisplayComponent Display => _displayComponent ??
            (Initialized ? null! : ThrowNotInitialized<IDisplayComponent>());

        /// <summary>
        /// Interface for shell functions such as battery information, preferred theme, etc.
        /// </summary>
        public static IShellComponent Shell => _shellComponent ??
            (Initialized ? null! : ThrowNotInitialized<IShellComponent>());

        /// <summary>
        /// Interface for getting and setting the mouse position, and getting mouse button information.
        /// </summary>
        public static IMouseComponent Mouse => _mouseComponent ??
            (Initialized ? null! : ThrowNotInitialized<IMouseComponent>());

        /// <summary>
        /// Interface for dealing with keyboard layouts, conversions between <see cref="Key"/> and <see cref="Scancode"/>, and IME.
        /// </summary>
        public static IKeyboardComponent Keyboard => _keyboardComponent ??
            (Initialized ? null! : ThrowNotInitialized<IKeyboardComponent>());

        /// <summary>
        /// Interface for creating, interacting with, and deleting mouse cursor images.
        /// </summary>
        public static ICursorComponent Cursor => _cursorComponent ??
            (Initialized ? null! : ThrowNotInitialized<ICursorComponent>());

        /// <summary>
        /// Interface for creating, interacting with, and deleting window icon images.
        /// </summary>
        public static IIconComponent Icon => _iconComponent ??
            (Initialized ? null! : ThrowNotInitialized<IIconComponent>());

        /// <summary>
        /// Interface for getting and setting clipboard data.
        /// </summary>
        public static IClipboardComponent Clipboard => _clipboardComponent ??
            (Initialized ? null! : ThrowNotInitialized<IClipboardComponent>());

        /// <summary>
        /// Interface for getting joystick input.
        /// </summary>
        public static IJoystickComponent Joystick => _joystickComponent ??
            (Initialized ? null! : ThrowNotInitialized<IJoystickComponent>());

        /// <summary>
        /// Interface for getting gamepad input.
        /// </summary>
        public static IGamepadComponent Gamepad => _gamepadComponent ??
            (Initialized ? null! : ThrowNotInitialized<IGamepadComponent>());

        /// <summary>
        /// Interface for opening system dialogs such as file open dialogs.
        /// </summary>
        public static IDialogComponent Dialog => _dialogComponent ??
            (Initialized ? null! : ThrowNotInitialized<IDialogComponent>());

        /// <summary>
        /// Interface for creating Vulkan surfaces.
        /// </summary>
        public static IVulkanComponent Vulkan
        {
            get
            {
                if (_vulkanComponent != null)
                {
                    return _vulkanComponent;
                }
                else if (!Initialized)
                {
                    return ThrowNotInitialized<IVulkanComponent>();
                }
                else if (!EnableVulkan)
                {
                    return ThrowFeatureNotEnabled<IVulkanComponent>("Vulkan", ToolkitFlags.EnableVulkan);
                }
                else
                {
                    return null!;
                }
            }
        }

        /// <summary>
        /// Initialize OpenTK with the given settings.
        /// This function must be called before trying to use the OpenTK API.
        /// </summary>
        /// <param name="options">The options to initialize with.</param>
        /// <seealso cref="ToolkitOptions"/>
        public static void Init(ToolkitOptions options)
        {
            EnableOpenGL = options.FeatureFlags.HasFlag(ToolkitFlags.EnableOpenGL);
            EnableVulkan = options.FeatureFlags.HasFlag(ToolkitFlags.EnableVulkan);

            // FIXME: Figure out where to actually store this setting...
            // - Noggin_bops 2025-07-09
            PlatformComponents.PreferANGLE = options.FeatureFlags.HasFlag(ToolkitFlags.PreferANGLE);

            try { _windowComponent = PlatformComponents.CreateWindowComponent(); } catch (NotSupportedException) { }
            try { _surfaceComponent = PlatformComponents.CreateSurfaceComponent(); } catch (NotSupportedException) { }
            if (EnableOpenGL)
            {
                try { _openGLComponent = PlatformComponents.CreateOpenGLComponent(); } catch (NotSupportedException) { }
            }
            try { _displayComponent = PlatformComponents.CreateDisplayComponent(); } catch (NotSupportedException) { }
            try { _shellComponent = PlatformComponents.CreateShellComponent(); } catch (NotSupportedException) { }
            try { _mouseComponent = PlatformComponents.CreateMouseComponent(); } catch (NotSupportedException) { }
            try { _keyboardComponent = PlatformComponents.CreateKeyboardComponent(); } catch (NotSupportedException) { }
            try { _cursorComponent = PlatformComponents.CreateCursorComponent(); } catch (NotSupportedException) { }
            try { _iconComponent = PlatformComponents.CreateIconComponent(); } catch (NotSupportedException) { }
            try { _clipboardComponent = PlatformComponents.CreateClipboardComponent(); } catch (NotSupportedException) { }
            try { _joystickComponent = PlatformComponents.CreateJoystickComponent(); } catch (NotSupportedException) { }
            try { _gamepadComponent = PlatformComponents.CreateGamepadComponent(); } catch (NotSupportedException) { }
            try { _dialogComponent = PlatformComponents.CreateDialogComponent(); } catch (NotSupportedException) { }
            if (EnableVulkan)
            {
                try { _vulkanComponent = PlatformComponents.CreateVulkanComponent(); } catch (NotSupportedException) { }
            }

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
            if (_gamepadComponent != null)
                _gamepadComponent.Logger = options.Logger;
            if (_dialogComponent != null)
                _dialogComponent.Logger = options.Logger;
            if (_vulkanComponent != null)
                _vulkanComponent.Logger = options.Logger;

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
            _gamepadComponent?.Initialize(options);
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
            EnableOpenGL = false;
            EnableVulkan = false;
        }

        [DoesNotReturn]
        private static T ThrowNotInitialized<T>() where T : IPalComponent
        {
            throw new InvalidOperationException("You need to call Toolkit.Init() before you can use it.");
        }

        [DoesNotReturn]
        private static T ThrowFeatureNotEnabled<T>(string featureName, ToolkitFlags flag) where T : IPalComponent
        {
            throw new InvalidOperationException($"You need to enable {featureName} by adding {nameof(ToolkitFlags)}.{flag} to {nameof(ToolkitOptions)}.{nameof(ToolkitOptions.FeatureFlags)} before you can use {featureName}.");
        }
    }
}
