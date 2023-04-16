using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLKeyboardComponent : IKeyboardComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(SDLKeyboardComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.KeyboardInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.KeyboardInput)
            {
                throw new PalException(this, "SDLKeyboardComponent can only initialize the KeyboardInput component.");
            }

            // Show the default IME UI.
            // FIXME: Make this user togglable so they can make their own IME window.
            SDL_SetHint(SDL_HINT_IME_SHOW_UI, "1");
        }

        public bool SupportsLayouts => throw new NotImplementedException();

        /// <inheritdoc/>
        public bool SupportsIme => true;

        public string GetActiveKeyboardLayout(WindowHandle handle = null)
        {
            throw new NotImplementedException();
        }

        public string[] GetAvailableKeyboardLayouts()
        {
            throw new NotImplementedException();
        }

        public Scancode GetScancodeFromKey(Key key)
        {
            throw new NotImplementedException();
        }

        public Key GetKeyFromScancode(Scancode scancode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void BeginIme(WindowHandle window)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDL_StartTextInput();
        }

        /// <inheritdoc/>
        public void SetImeRectangle(WindowHandle window, int x, int y, int width, int height)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDL_Rect rect;
            rect.x = x;
            rect.y = y;
            rect.w = width;
            rect.h = height;

            SDL_SetTextInputRect(rect);
        }

        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDL_StopTextInput();
        }
    }
}
