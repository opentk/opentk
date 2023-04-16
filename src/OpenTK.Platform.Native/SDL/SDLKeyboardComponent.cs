using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
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

        /// <inheritdoc/>
        public bool SupportsLayouts => false;

        /// <inheritdoc/>
        public bool SupportsIme => true;

        /// <inheritdoc/>
        public string GetActiveKeyboardLayout(WindowHandle? handle)
        {
            throw new NotSupportedException("SDL 2 doesn't support getting keyboard layouts.");
        }

        /// <inheritdoc/>
        public string[] GetAvailableKeyboardLayouts()
        {
            throw new NotSupportedException("SDL 2 doesn't support getting keyboard layouts.");
        }

        internal SDL_Keycode ToSDL(Key key)
        {
            if (key >= Key.A && key <= Key.Z)
            {
                return key - Key.A + SDL_Keycode.SDLK_a;
            }

            if (key >= Key.D0 && key <= Key.D9)
            {
                return key - Key.D0 + SDL_Keycode.SDLK_0;
            }

            if (key >= Key.F1 && key <= Key.F12)
            {
                return key - Key.F1 + SDL_Keycode.SDLK_F1;
            }

            if (key >= Key.F13 && key <= Key.F24)
            {
                return key - Key.F13 + SDL_Keycode.SDLK_F13;
            }

            switch (key)
            {
                case Key.Unknown: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.Backspace: return SDL_Keycode.SDLK_BACKSPACE;
                case Key.Tab: return SDL_Keycode.SDLK_TAB;
                case Key.Return: return SDL_Keycode.SDLK_RETURN;
                case Key.Escape: return SDL_Keycode.SDLK_ESCAPE;
                case Key.Space: return SDL_Keycode.SDLK_SPACE;
                case Key.LeftShift: return SDL_Keycode.SDLK_LSHIFT;
                case Key.RightShift: return SDL_Keycode.SDLK_RSHIFT;
                case Key.LeftControl: return SDL_Keycode.SDLK_LCTRL;
                case Key.RightControl: return SDL_Keycode.SDLK_RCTRL;
                case Key.LeftAlt: return SDL_Keycode.SDLK_LALT;
                case Key.RightAlt: return SDL_Keycode.SDLK_RALT;
                case Key.LeftGUI: return SDL_Keycode.SDLK_LGUI;
                case Key.RightGUI: return SDL_Keycode.SDLK_RGUI;
                case Key.CapsLock: return SDL_Keycode.SDLK_CAPSLOCK;
                case Key.NumLock: return SDL_Keycode.SDLK_NUMLOCKCLEAR;
                case Key.Keypad0: return SDL_Keycode.SDLK_KP_0;
                case Key.Keypad1: return SDL_Keycode.SDLK_KP_1;
                case Key.Keypad2: return SDL_Keycode.SDLK_KP_2;
                case Key.Keypad3: return SDL_Keycode.SDLK_KP_3;
                case Key.Keypad4: return SDL_Keycode.SDLK_KP_4;
                case Key.Keypad5: return SDL_Keycode.SDLK_KP_5;
                case Key.Keypad6: return SDL_Keycode.SDLK_KP_6;
                case Key.Keypad7: return SDL_Keycode.SDLK_KP_7;
                case Key.Keypad8: return SDL_Keycode.SDLK_KP_8;
                case Key.Keypad9: return SDL_Keycode.SDLK_KP_9;
                case Key.KeypadDecimal: return SDL_Keycode.SDLK_KP_DECIMAL;
                case Key.KeypadDivide: return SDL_Keycode.SDLK_KP_DIVIDE;
                case Key.KeypadMultiply: return SDL_Keycode.SDLK_KP_MULTIPLY;
                case Key.KeypadSubtract: return SDL_Keycode.SDLK_KP_MINUS;
                case Key.KeypadAdd: return SDL_Keycode.SDLK_KP_PLUS;
                case Key.KeypadSeparator: return SDL_Keycode.SDLK_KP_COMMA;
                case Key.KeypadEnter: return SDL_Keycode.SDLK_KP_ENTER;
                case Key.KeypadEqual: return SDL_Keycode.SDLK_KP_EQUALS;
                case Key.PrintScreen: return SDL_Keycode.SDLK_PRINTSCREEN;
                case Key.ScrollLock: return SDL_Keycode.SDLK_SCROLLLOCK;
                case Key.PauseBreak: return SDL_Keycode.SDLK_PAUSE;
                case Key.Insert: return SDL_Keycode.SDLK_INSERT;
                case Key.Delete: return SDL_Keycode.SDLK_DELETE;
                case Key.Home: return SDL_Keycode.SDLK_HOME;
                case Key.End: return SDL_Keycode.SDLK_END;
                case Key.PageUp: return SDL_Keycode.SDLK_PAGEUP;
                case Key.PageDown: return SDL_Keycode.SDLK_PAGEDOWN;
                case Key.LeftArrow: return SDL_Keycode.SDLK_LEFT;
                case Key.RightArrow: return SDL_Keycode.SDLK_RIGHT;
                case Key.UpArrow: return SDL_Keycode.SDLK_UP;
                case Key.DownArrow: return SDL_Keycode.SDLK_DOWN;
                case Key.Application: return SDL_Keycode.SDLK_APPLICATION;
                case Key.Help: return SDL_Keycode.SDLK_HELP;
                case Key.Sleep: return SDL_Keycode.SDLK_SLEEP;
                case Key.Plus: return SDL_Keycode.SDLK_PLUS;
                case Key.Comma: return SDL_Keycode.SDLK_COMMA;
                case Key.Minus: return SDL_Keycode.SDLK_MINUS;
                case Key.Period: return SDL_Keycode.SDLK_PERIOD;

                // FIXME!!!
                case Key.OEM1: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM2: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM3: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM4: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM5: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM6: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM7: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM8: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM102: return SDL_Keycode.SDLK_UNKNOWN;


                case Key.PlayPause: return SDL_Keycode.SDLK_AUDIOPLAY;
                case Key.NextTrack: return SDL_Keycode.SDLK_AUDIONEXT;
                case Key.PreviousTrack: return SDL_Keycode.SDLK_AUDIOPREV;
                case Key.Stop: return SDL_Keycode.SDLK_AUDIOSTOP;
                case Key.Mute: return SDL_Keycode.SDLK_MUTE;
                case Key.VolumeUp: return SDL_Keycode.SDLK_VOLUMEUP;
                case Key.VolumeDown: return SDL_Keycode.SDLK_VOLUMEDOWN;

                default: throw new Exception($"Unhandled key {key} when converting to SDK_Keycode.");
            }
        }

        internal Key FromSDL(SDL_Keycode keycode)
        {
            foreach (var key in Enum.GetValues<Key>())
            {
                if (ToSDL(key) == keycode)
                {
                    return key;
                }
            }

            Logger?.LogError($"Could not find Key for SDL keycode {keycode}.");

            return Key.Unknown;
        }

        internal SDL_Scancode ToSDL(Scancode key)
        {
            // FIXME: Map Key to SDL_Keycode
            return default;
        }

        internal Scancode FromSDL(SDL_Scancode keycode)
        {
            // FIXME: Map SDL_Keycode to Key
            return default;
        }

        /// <inheritdoc/>
        public Scancode GetScancodeFromKey(Key key)
        {
            SDL_Keycode keycode = ToSDL(key);

            SDL_Scancode scancode = SDL_GetScancodeFromKey(keycode);

            return FromSDL(scancode);
        }

        /// <inheritdoc/>
        public Key GetKeyFromScancode(Scancode scancode)
        {
            SDL_Scancode scan = ToSDL(scancode);

            SDL_Keycode keycode = SDL_GetKeyFromScancode(scan);

            return FromSDL(keycode);
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
