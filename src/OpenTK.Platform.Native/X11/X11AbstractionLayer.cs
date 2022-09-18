using System;
using System.Collections.Generic;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.X11
{
    public partial class X11AbstractionLayer : IPalComponent
    {
        public string Name => "X11";
        public PalComponents Provides => PalComponents.OpenGL | PalComponents.Window | PalComponents.Display;

        public XDisplayPtr Display { get; private set; }

        public int DefaultScreen { get; private set; }

        public XWindow DefaultRootWindow { get; private set; }

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }

            // Later on we can replace this with a hint.
            string? displayName = null;
            Display = LibX11.XOpenDisplay(displayName);

            if (Display.Value == IntPtr.Zero)
            {
                throw new PalException(
                    this,
                    (displayName is null) ? "Could not open default X display."
                        : $"Could not open X display {displayName}."
                );
            }

            DefaultScreen = LibX11.XDefaultScreen(Display);
            DefaultRootWindow = LibX11.XDefaultRootWindow(Display);

            if (which.HasFlag(PalComponents.OpenGL))
            {
                InitializeGL();
            }

            if (which.HasFlag(PalComponents.Display))
            {
                InitializeDisplay();
            }
        }
    }
}
