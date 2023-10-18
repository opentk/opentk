using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenTK.Core;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Handles;
using OpenTK.Core.Platform.Interfaces;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLMouseComponent : IMouseComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(SDLMouseComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MiceInput)
            {
                throw new PalException(this, "SDLMouseComponent can only initialize the Mouse component.");
            }
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public void GetPosition(out int x, out int y)
        {
            SDL_GetMouseState(out x, out y);
        }

        /// <inheritdoc/>
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
