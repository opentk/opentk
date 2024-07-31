using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
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
        /// <inheritdoc/>
        public string Name => nameof(SDLMouseComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MiceInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public bool CanSetMousePosition => true;

        /// <inheritdoc/>
        public bool SupportsRawMouseMotion => throw new NotImplementedException();

        /// <inheritdoc/>
        public void GetPosition(out int x, out int y)
        {
            SDL_GetGlobalMouseState(out x, out y);
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

        // FIXME: This is only a 32-bit float and
        // will quite quickly not be able to represent
        // deltas if the user continously scrolls in
        // one direction. Consider switching to doubles.
        // FIXME: This is only ever updated when we get
        // scroll messages to one of our windows, this is
        // not the "global" state of the scroll wheel.
        // Should we fix that? or is this what is expected?
        internal static Vector2 ScrollPosition = (0.0f, 0.0f);
        internal static void RegisterMouseWheelDelta(Vector2 delta)
        {
            ScrollPosition += delta;
        }

        /// <inheritdoc/>
        public void GetMouseState(out MouseState state)
        {
            uint buttons = SDL_GetGlobalMouseState(out int x, out int y);

            const int SDL_BUTTON_LMASK = 1 << 0;
            const int SDL_BUTTON_MMASK = 1 << 1;
            const int SDL_BUTTON_RMASK = 1 << 2;
            const int SDL_BUTTON_X1MASK = 1 << 3;
            const int SDL_BUTTON_X2MASK = 1 << 4;

            state.Position = (x, y);

            state.Scroll = ScrollPosition;

            state.PressedButtons = default;
            if ((buttons & SDL_BUTTON_LMASK) != 0)
                state.PressedButtons |= MouseButtonFlags.Button1;
            if ((buttons & SDL_BUTTON_RMASK) != 0)
                state.PressedButtons |= MouseButtonFlags.Button2;
            if ((buttons & SDL_BUTTON_MMASK) != 0)
                state.PressedButtons |= MouseButtonFlags.Button3;
            if ((buttons & SDL_BUTTON_X1MASK) != 0)
                state.PressedButtons |= MouseButtonFlags.Button4;
            if ((buttons & SDL_BUTTON_X2MASK) != 0)
                state.PressedButtons |= MouseButtonFlags.Button5;
        }

        /// <inheritdoc/>
        public bool IsRawMouseMotionEnabled(WindowHandle window)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void EnableRawMouseMotion(WindowHandle window, bool enable)
        {
            throw new NotImplementedException();
        }
    }
}
