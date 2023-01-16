using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native
{
    /// <summary>
    /// Used to create platform specific version of components.
    /// </summary>
    public static class PlatformComponents
    {
        private delegate IPalComponent ComponentCtor();

        private static Dictionary<PalComponents, ComponentCtor> win32Components =
            new Dictionary<PalComponents, ComponentCtor>
            {
                [PalComponents.Window] = () => new Windows.WindowComponent(),
                [PalComponents.OpenGL] = () => new Windows.OpenGLComponent(),
                [PalComponents.Display] = () => new Windows.DisplayComponent(),
                [PalComponents.Shell] = () => new Windows.ShellComponent(),
                [PalComponents.MiceInput] = () => new Windows.MouseComponent(),
                [PalComponents.KeyboardInput] = () => new Windows.KeyboardComponent(),
                [PalComponents.MouseCursor] = () => new Windows.CursorComponent(),
                [PalComponents.WindowIcon] = () => new Windows.IconComponent(),
                [PalComponents.Clipboard] = () => new Windows.ClipboardComponent(),
            };

        private static Dictionary<PalComponents, ComponentCtor> x11Components =
            new Dictionary<PalComponents, ComponentCtor>
            {
                [PalComponents.Window] = () => new X11.X11WindowComponent(),
                [PalComponents.OpenGL] = () => new X11.X11OpenGLComponent(),
                [PalComponents.Display] = () => new X11.X11DisplayComponent(),
                [PalComponents.Shell] = () => new X11.X11ShellComponent(),
                [PalComponents.MiceInput] = () => new X11.X11MouseComponent(),
                //[PalComponents.KeyboardInput] = () => new X11.X11KeyboardComponent(),
                [PalComponents.MouseCursor] = () => new X11.X11CursorComponent(),
                //[PalComponents.WindowIcon] = () => new X11.X11IconComponent(),
                //[PalComponents.Clipboard] = () => new X11.X11ClipboardComponent(),
            };

        private static Dictionary<PalComponents, ComponentCtor> macosComponents =
            new Dictionary<PalComponents, ComponentCtor>
            {
                //[PalComponents.Window] = () => new Macos.WindowComponent(),
                //[PalComponents.OpenGL] = () => new Macos.OpenGLComponent(),
                //[PalComponents.Display] = () => new Macos.DisplayComponent(),
                //[PalComponents.Shell] = () => new Macos.ShellComponent(),
                //[PalComponents.MiceInput] = () => new Macos.MouseComponent(),
                //[PalComponents.KeyboardInput] = () => new Macos.KeyboardComponent(),
                //[PalComponents.MouseCursor] = () => new Macos.CursorComponent(),
                //[PalComponents.WindowIcon] = () => new Macos.IconComponent(),
                //[PalComponents.Clipboard] = () => new Macos.ClipboardComponent(),
            };

        private static Dictionary<PalComponents, ComponentCtor> GetPlatformComponents()
        {
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
                throw new NotSupportedException("Os not supported.");
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
                throw new NotSupportedException("This platform doesn't support this component yet.");
            }
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IWindowComponent CreateWindowComponent()
        {
            return GetPlatformComponent<IWindowComponent>(PalComponents.Window);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IOpenGLComponent CreateOpenGLComponent()
        {
            return GetPlatformComponent<IOpenGLComponent>(PalComponents.OpenGL);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IDisplayComponent CreateDisplayComponent()
        {
            return GetPlatformComponent<IDisplayComponent>(PalComponents.Display);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IShellComponent CreateShellComponent()
        {
            return GetPlatformComponent<IShellComponent>(PalComponents.Shell);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IMouseComponent CreateMouseComponent()
        {
            return GetPlatformComponent<IMouseComponent>(PalComponents.MiceInput);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IKeyboardComponent CreateKeyboardComponent()
        {
            return GetPlatformComponent<IKeyboardComponent>(PalComponents.KeyboardInput);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static ICursorComponent CreateCursorComponent()
        {
            return GetPlatformComponent<ICursorComponent>(PalComponents.MouseCursor);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IIconComponent CreateIconComponent()
        {
            return GetPlatformComponent<IIconComponent>(PalComponents.WindowIcon);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static IClipboardComponent CreateClipboardComponent()
        {
            return GetPlatformComponent<IClipboardComponent>(PalComponents.Clipboard);
        }

        /// <inheritdoc cref="GetPlatformComponents"/>
        public static ISurfaceComponent CreateSurfaceComponent()
        {
            return GetPlatformComponent<ISurfaceComponent>(PalComponents.Surface);
        }
    }
}
