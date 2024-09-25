using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native
{
    // FIXME: Remove or formalize
    public enum Backend
    {
        None,
        Win32,
        macOS,
        X11,
        SDL,
    }

    /// <summary>
    /// Used to create platform specific version of components.
    /// </summary>
    public static class PlatformComponents
    {
        /// <summary>
        /// Set this to true to prefer loading the SDL backend on all platforms.
        /// We will fall back to platform specifc backends if SDL cannot be loaded.
        /// </summary>
        public static bool PreferSDL2 { get; set; } = false;

        // FIXME:
        public static bool PreferANGLE { get; set; } = false;

        private delegate IPalComponent ComponentCtor();

        private static Dictionary<PalComponents, ComponentCtor> sdlComponents =
            new Dictionary<PalComponents, ComponentCtor>
            {
                [PalComponents.Window] = () => new SDL.SDLWindowComponent(),
                [PalComponents.OpenGL] = () => new SDL.SDLOpenGLComponent(),
                //[PalComponents.Vulkan] = () => new SDL.SDLVulkanComponent(),
                [PalComponents.Display] = () => new SDL.SDLDisplayComponent(),
                [PalComponents.Shell] = () => new SDL.SDLShellComponent(),
                [PalComponents.MiceInput] = () => new SDL.SDLMouseComponent(),
                [PalComponents.KeyboardInput] = () => new SDL.SDLKeyboardComponent(),
                [PalComponents.MouseCursor] = () => new SDL.SDLCursorComponent(),
                [PalComponents.WindowIcon] = () => new SDL.SDLIconComponent(),
                [PalComponents.Clipboard] = () => new SDL.SDLClipboardComponent(),
                [PalComponents.Joystick] = () => new SDL.SDLJoystickComponent(),
                //[PalComponents.Dialog] = () => new SDL.SDLDialogComponent(),
            };

        private static Dictionary<PalComponents, ComponentCtor> win32Components =
            new Dictionary<PalComponents, ComponentCtor>
            {
                [PalComponents.Window] = () => new Windows.WindowComponent(),
                [PalComponents.OpenGL] = () => new Windows.OpenGLComponent(),
                [PalComponents.Vulkan] = () => new Windows.VulkanComponent(),
                [PalComponents.Display] = () => new Windows.DisplayComponent(),
                [PalComponents.Shell] = () => new Windows.ShellComponent(),
                [PalComponents.MiceInput] = () => new Windows.MouseComponent(),
                [PalComponents.KeyboardInput] = () => new Windows.KeyboardComponent(),
                [PalComponents.MouseCursor] = () => new Windows.CursorComponent(),
                [PalComponents.WindowIcon] = () => new Windows.IconComponent(),
                [PalComponents.Clipboard] = () => new Windows.ClipboardComponent(),
                [PalComponents.Joystick] = () => new Windows.JoystickComponent(),
                [PalComponents.Dialog] = () => new Windows.DialogComponent(),
            };

        private static Dictionary<PalComponents, ComponentCtor> x11Components =
            new Dictionary<PalComponents, ComponentCtor>
            {
                [PalComponents.Window] = () => new X11.X11WindowComponent(),
                [PalComponents.OpenGL] = () => new X11.X11OpenGLComponent(),
                [PalComponents.Vulkan] = () => new X11.X11VulkanComponent(),
                [PalComponents.Display] = () => new X11.X11DisplayComponent(),
                [PalComponents.Shell] = () => new X11.X11ShellComponent(),
                [PalComponents.MiceInput] = () => new X11.X11MouseComponent(),
                [PalComponents.KeyboardInput] = () => new X11.X11KeyboardComponent(),
                [PalComponents.MouseCursor] = () => new X11.X11CursorComponent(),
                [PalComponents.WindowIcon] = () => new X11.X11IconComponent(),
                [PalComponents.Clipboard] = () => new X11.X11ClipboardComponent(),
                //[PalComponents.Joystick] = () => new X11.X11JoystickComponent(),
                [PalComponents.Dialog] = () => new X11.X11DialogComponent(),
            };

        private static Dictionary<PalComponents, ComponentCtor> macosComponents =
            new Dictionary<PalComponents, ComponentCtor>
            {
                [PalComponents.Window] = () => new macOS.MacOSWindowComponent(),
                [PalComponents.OpenGL] = () => new macOS.MacOSOpenGLComponent(),
                //[PalComponents.Vulkan] = () => new macOS.MacOSVulkanComponent(),
                [PalComponents.Display] = () => new macOS.MacOSDisplayComponent(),
                [PalComponents.Shell] = () => new macOS.MacOSShellComponent(),
                [PalComponents.MiceInput] = () => new macOS.MacOSMouseComponent(),
                [PalComponents.KeyboardInput] = () => new macOS.MacOSKeyboardComponent(),
                [PalComponents.MouseCursor] = () => new macOS.MacOSCursorComponent(),
                [PalComponents.WindowIcon] = () => new macOS.MacOSIconComponent(),
                [PalComponents.Clipboard] = () => new macOS.MacOSClipboardComponent(),
                //[PalComponents.Joystick] = () => new macOS.MacOSJoystickComponent(),
                [PalComponents.Dialog] = () => new macOS.MacOSDialogComponent(),
            };

        /// <summary>
        /// Returns the backend that will be used to create components.
        /// </summary>
        /// <returns>The backend that will be used to create components.</returns>
        // FIXME: Better documentation
        // FIXME: What do we do with things like, Win32 + ANGLE?
        public static Backend GetBackend()
        {
            // FIXME: Proper backend selection!

            var test = GetPlatformComponents();
            if (test == win32Components)
            {
                return Backend.Win32;
            }
            else if (test == x11Components)
            {
                return Backend.X11;
            }
            else if (test == macosComponents)
            {
                return Backend.macOS;
            }
            else if (test == sdlComponents)
            {
                return Backend.SDL;
            }
            else
            {
                return Backend.None;
            }
        }

        // FIXME: We probably only want to evaluate the platform decision once?
        private static Dictionary<PalComponents, ComponentCtor> GetPlatformComponents()
        {
            // FIXME: Make SDL a fallback.
            if (PreferSDL2)
            {
                // We use the DllResolver to get the same loading logic as DllImport.
                IntPtr handle = DllResolver.DllImportResolver("SDL2", Assembly.GetExecutingAssembly(), null);
                if (handle != IntPtr.Zero)
                    return sdlComponents;

                // If we didn't resolve we try to load it here for windows
                if (NativeLibrary.TryLoad("SDL2.dll", Assembly.GetExecutingAssembly(), null, out _))
                    return sdlComponents;

                // FIXME: Log that we couldn't find SDL2!
            }

            if (OperatingSystem.IsWindows())
            {
                return win32Components;
            }
            else if (OperatingSystem.IsLinux())
            {
                // FIXME: Detect x11 vs Wayland.
                return x11Components;
            }
            else if (OperatingSystem.IsMacOS())
            {
                return macosComponents;
            }
            else
            {
                throw new NotSupportedException($"OS not supported. {RuntimeInformation.OSDescription}");
            }
        }

        /// <summary>
        /// Creates a platform specific component.
        /// </summary>
        /// <returns>The platform specific component</returns>
        private static TComp GetPlatformComponent<TComp>(PalComponents comp) where TComp : IPalComponent
        {
            Dictionary<PalComponents, ComponentCtor> ctors = GetPlatformComponents();
            if (ctors.TryGetValue(comp, out ComponentCtor? ctor))
            {
                return (TComp)ctor();
            }
            else
            {
                throw new NotSupportedException($"This platform doesn't support the {typeof(TComp)} component yet.");
            }
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IWindowComponent CreateWindowComponent()
        {
            return GetPlatformComponent<IWindowComponent>(PalComponents.Window);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IOpenGLComponent CreateOpenGLComponent()
        {
            // FIXME: Should we do this here?
            // FIXME: Check so that we can actually load angle binaries too!
            if (PreferANGLE)
            {
                return new ANGLE.ANGLEOpenGLComponent();
            }
            else
            {
                return GetPlatformComponent<IOpenGLComponent>(PalComponents.OpenGL);
            }
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IDisplayComponent CreateDisplayComponent()
        {
            return GetPlatformComponent<IDisplayComponent>(PalComponents.Display);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IShellComponent CreateShellComponent()
        {
            return GetPlatformComponent<IShellComponent>(PalComponents.Shell);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IMouseComponent CreateMouseComponent()
        {
            return GetPlatformComponent<IMouseComponent>(PalComponents.MiceInput);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IKeyboardComponent CreateKeyboardComponent()
        {
            return GetPlatformComponent<IKeyboardComponent>(PalComponents.KeyboardInput);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static ICursorComponent CreateCursorComponent()
        {
            return GetPlatformComponent<ICursorComponent>(PalComponents.MouseCursor);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IIconComponent CreateIconComponent()
        {
            return GetPlatformComponent<IIconComponent>(PalComponents.WindowIcon);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IClipboardComponent CreateClipboardComponent()
        {
            return GetPlatformComponent<IClipboardComponent>(PalComponents.Clipboard);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static ISurfaceComponent CreateSurfaceComponent()
        {
            return GetPlatformComponent<ISurfaceComponent>(PalComponents.Surface);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IJoystickComponent CreateJoystickComponent()
        {
            return GetPlatformComponent<IJoystickComponent>(PalComponents.Joystick);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IDialogComponent CreateDialogComponent()
        {
            return GetPlatformComponent<IDialogComponent>(PalComponents.Dialog);
        }

        /// <inheritdoc cref="GetPlatformComponent{TComp}(PalComponents)"/>
        public static IVulkanComponent CreateVulkanComponent()
        {
            return GetPlatformComponent<IVulkanComponent>(PalComponents.Vulkan);
        }
    }
}
