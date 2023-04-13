using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLMouseComponent : IMouseComponent
    {
        public string Name => nameof(SDLMouseComponent);

        public PalComponents Provides => PalComponents.MiceInput;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MiceInput)
            {
                throw new PalException(this, "SDLMouseComponent can only initialize the Mouse component.");
            }
        }

        public bool CanSetMousePosition => true;

        public void GetPosition(out int x, out int y)
        {
            SDL_GetMouseState(out x, out y);
        }

        public void SetPosition(int x, int y)
        {
            int result = SDL_WarpMouseGlobal(x, y);
            if (result < 0)
            {
                string error = SDL_GetError();
                Logger?.LogError($"SDL2 could not set the mouse position: '{error}'");
            }
        }

        /// <summary>
        /// Calls SDL_WarpMouseInWindow.
        /// </summary>
        /// <param name="handle">The window to warp inside.</param>
        /// <param name="x">The x coordinate to warp to.</param>
        /// <param name="y">The y coordinate to warp to.</param>
        public void SetPositionInWindow(WindowHandle handle, int x, int y)
        {
            SDLWindow window = handle.As<SDLWindow>(this);

            SDL_WarpMouseInWindow(window.Window, x, y);
        }
    }
}
