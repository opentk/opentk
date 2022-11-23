using System;
using OpenTK.Core.Platform;
using System.Diagnostics;
using OpenTK.Core.Utility;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// Abstraction layer driver for X11.
    /// </summary>
    public partial class X11AbstractionLayer : IPalComponent
    {
        public string Name => "X11";

        public PalComponents Provides => PalComponents.OpenGL | PalComponents.Window | PalComponents.Display;

        public ILogger? Logger { get; set; }

        public XDisplayPtr Display { get; private set; }

        public int DefaultScreen { get; private set; }

        public XWindow DefaultRootWindow { get; private set; }

        private XAtomDictionary? _atoms { get; set; }

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

            _atoms = new XAtomDictionary(Display);

            Debug.Write($"Known Atoms ({_atoms.Count}) ", "PAL2.0/Linux/X11");
            foreach (var(key,value) in _atoms)
            {
                Debug.WriteIf(!value.IsNone, key + " ");
            }
            Debug.WriteLine("");

            if (which.HasFlag(PalComponents.Window))
            {
                InitializeWindow();
            }

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
