using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.X11.LibX11;

namespace OpenTK.Platform.Native.X11
{
    public class X11MouseComponent : IMouseComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11MouseComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public void GetPosition(out int x, out int y)
        {
            byte ret = XQueryPointer(X11.Display, X11.DefaultRootWindow, out XWindow root, out XWindow child, out int root_x, out int root_y, out int win_x, out int win_y, out _);

            x = root_x;
            y = root_y;
        }

        /// <inheritdoc/>
        public void SetPosition(int x, int y)
        {
            XWarpPointer(X11.Display, XWindow.None, X11.DefaultRootWindow, 0, 0, 0, 0, x, y);
        }

        /// <inheritdoc/>
        public void GetMouseState(out MouseState state)
        {
            throw new NotImplementedException();
        }
    }
}
