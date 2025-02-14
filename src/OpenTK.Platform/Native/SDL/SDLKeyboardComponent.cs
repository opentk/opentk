using OpenTK.Platform;
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
        public void Initialize(ToolkitOptions options)
        {
            // Show the default IME UI.
            // FIXME: Make this user togglable so they can make their own IME window.
            SDL_SetHint(SDL_HINT_IME_SHOW_UI, "1");
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        /// <inheritdoc/>
        public bool SupportsLayouts => false;

        /// <inheritdoc/>
        public bool SupportsIme => true;

        /// <inheritdoc/>
        public string GetActiveKeyboardLayout(WindowHandle? handle)
        {
            // FIXME! Can we do something here?
            //Logger?.LogError("SDL 2 doesn't support getting keyboard layouts.");
            return "Unknown";
        }

        /// <inheritdoc/>
        public string[] GetAvailableKeyboardLayouts()
        {
            throw new NotSupportedException("SDL 2 doesn't support getting keyboard layouts.");
        }

        /// <inheritdoc/>
        public Scancode GetScancodeFromKey(Key key)
        {
            SDL_Keycode keycode = ToSDL(key, Logger);

            SDL_Scancode scancode = SDL_GetScancodeFromKey(keycode);

            return FromSDL(scancode, Logger);
        }

        /// <inheritdoc/>
        public Key GetKeyFromScancode(Scancode scancode)
        {
            SDL_Scancode scan = ToSDL(scancode, Logger);

            SDL_Keycode keycode = SDL_GetKeyFromScancode(scan);

            return FromSDL(keycode, Logger);
        }

        /// <inheritdoc/>
        public unsafe void GetKeyboardState(bool[] keyboardState)
        {
            byte* ptr = SDL_GetKeyboardState(out int numkeys);
            Span<byte> keys = new Span<byte>(ptr, numkeys);

            Array.Fill(keyboardState, false);

            for (int i = 0; i < keys.Length; i++)
            {
                // Intentionally send null logger here to avoid spamming messages
                Scancode code = FromSDL((SDL_Scancode)i, null);
                if (((int)code) < keyboardState.Length)
                {
                    keyboardState[(int)code] = keys[i] == 1;
                }
            }
        }

        /// <inheritdoc/>
        public unsafe KeyModifier GetKeyboardModifiers()
        {
            return FromSDL(SDL_GetModState());
        }

        /// <inheritdoc/>
        public void BeginIme(WindowHandle window)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDL_StartTextInput();
        }

        /// <inheritdoc/>
        public void SetImeRectangle(WindowHandle window, float x, float y, float width, float height)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDL_Rect rect;
            rect.x = (int)x;
            rect.y = (int)y;
            rect.w = (int)width;
            rect.h = (int)height;

            SDL_SetTextInputRect(rect);
        }

        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            SDLWindow sdlWindow = window.As<SDLWindow>(this);

            SDL_StopTextInput();
        }

        // FIXME: Because we have to make these static we have to pass a logger with it.
        // Maybe we could find a way to not need this?

        internal static SDL_Keycode ToSDL(Key key, ILogger? logger)
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
                case Key.KeypadDecimal: return SDL_Keycode.SDLK_KP_PERIOD;
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
                case Key.OEM3: return SDL_Keycode.SDLK_SEMICOLON;
                // FIXME: Is this correct??
                case Key.OEM4: return SDL_Keycode.SDLK_CURRENCYUNIT;
                case Key.OEM5: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM6: return SDL_Keycode.SDLK_KP_LEFTBRACE;
                case Key.OEM7: return SDL_Keycode.SDLK_QUOTE;
                case Key.OEM8: return SDL_Keycode.SDLK_UNKNOWN;
                case Key.OEM102: return SDL_Keycode.SDLK_LESS;


                case Key.PlayPause: return SDL_Keycode.SDLK_AUDIOPLAY;
                case Key.NextTrack: return SDL_Keycode.SDLK_AUDIONEXT;
                case Key.PreviousTrack: return SDL_Keycode.SDLK_AUDIOPREV;
                case Key.Stop: return SDL_Keycode.SDLK_AUDIOSTOP;
                case Key.Mute: return SDL_Keycode.SDLK_AUDIOMUTE;
                case Key.VolumeUp: return SDL_Keycode.SDLK_VOLUMEUP;
                case Key.VolumeDown: return SDL_Keycode.SDLK_VOLUMEDOWN;

                default: throw new Exception($"Unhandled key {key} when converting to SDK_Keycode.");
            }
        }

        internal static Key FromSDL(SDL_Keycode keycode, ILogger? logger)
        {
            // FIXME: On ubuntu the key codes reported from SDL are any UTF key code.
            // Do we also want to do that or do we want to do something else?
            foreach (var key in Enum.GetValues<Key>())
            {
                if (ToSDL(key, logger) == keycode)
                {
                    return key;
                }
            }

            // FIXME: Sometimes we get a SDL_Keycode without the (1 << 30) bit.
            // What does that mean??

            logger?.LogError($"Could not find Key for SDL keycode {keycode} ({keycode | (SDL_Keycode)(1 << 30)}).");

            return Key.Unknown;
        }

        internal static SDL_Scancode ToSDL(Scancode scancode, ILogger? logger)
        {
            if (scancode >= Scancode.A && scancode <= Scancode.Z)
            {
                return scancode - Scancode.A + SDL_Scancode.SDL_SCANCODE_A;
            }

            if (scancode >= Scancode.D1 && scancode <= Scancode.D0)
            {
                return scancode - Scancode.D1 + SDL_Scancode.SDL_SCANCODE_1;
            }

            if (scancode >= Scancode.F1 && scancode <= Scancode.F12)
            {
                return scancode - Scancode.F1 + SDL_Scancode.SDL_SCANCODE_F1;
            }

            if (scancode >= Scancode.F13 && scancode <= Scancode.F24)
            {
                return scancode - Scancode.F13 + SDL_Scancode.SDL_SCANCODE_F13;
            }

            if (scancode >= Scancode.Keypad1 && scancode <= Scancode.Keypad0)
            {
                return scancode - Scancode.Keypad1 + SDL_Scancode.SDL_SCANCODE_KP_1;
            }

            switch (scancode)
            {
                case Scancode.Unknown: return SDL_Scancode.SDL_SCANCODE_UNKNOWN;
                case Scancode.Return: return SDL_Scancode.SDL_SCANCODE_RETURN;
                case Scancode.Escape: return SDL_Scancode.SDL_SCANCODE_ESCAPE;
                case Scancode.Backspace: return SDL_Scancode.SDL_SCANCODE_BACKSPACE;
                case Scancode.Tab: return SDL_Scancode.SDL_SCANCODE_TAB;
                case Scancode.Spacebar: return SDL_Scancode.SDL_SCANCODE_SPACE;
                case Scancode.Dash: return SDL_Scancode.SDL_SCANCODE_MINUS;
                case Scancode.Equals: return SDL_Scancode.SDL_SCANCODE_EQUALS;
                case Scancode.LeftBrace: return SDL_Scancode.SDL_SCANCODE_LEFTBRACKET;
                case Scancode.RightBrace: return SDL_Scancode.SDL_SCANCODE_RIGHTBRACKET;
                case Scancode.Pipe: return SDL_Scancode.SDL_SCANCODE_BACKSLASH;
                case Scancode.SemiColon: return SDL_Scancode.SDL_SCANCODE_SEMICOLON;
                case Scancode.LeftApostrophe: return SDL_Scancode.SDL_SCANCODE_APOSTROPHE;
                case Scancode.GraveAccent: return SDL_Scancode.SDL_SCANCODE_GRAVE;
                case Scancode.Comma: return SDL_Scancode.SDL_SCANCODE_COMMA;
                case Scancode.Period: return SDL_Scancode.SDL_SCANCODE_PERIOD;
                case Scancode.QuestionMark: return SDL_Scancode.SDL_SCANCODE_SLASH;
                case Scancode.CapsLock: return SDL_Scancode.SDL_SCANCODE_CAPSLOCK;
                case Scancode.PrintScreen: return SDL_Scancode.SDL_SCANCODE_PRINTSCREEN;
                case Scancode.ScrollLock: return SDL_Scancode.SDL_SCANCODE_SCROLLLOCK;
                case Scancode.Pause: return SDL_Scancode.SDL_SCANCODE_PAUSE;
                case Scancode.Insert: return SDL_Scancode.SDL_SCANCODE_INSERT;
                case Scancode.Home: return SDL_Scancode.SDL_SCANCODE_HOME;
                case Scancode.PageUp: return SDL_Scancode.SDL_SCANCODE_PAGEUP;
                case Scancode.Delete: return SDL_Scancode.SDL_SCANCODE_DELETE;
                case Scancode.End: return SDL_Scancode.SDL_SCANCODE_END;
                case Scancode.PageDown: return SDL_Scancode.SDL_SCANCODE_PAGEDOWN;
                case Scancode.RightArrow: return SDL_Scancode.SDL_SCANCODE_RIGHT;
                case Scancode.LeftArrow: return SDL_Scancode.SDL_SCANCODE_LEFT;
                case Scancode.DownArrow: return SDL_Scancode.SDL_SCANCODE_DOWN;
                case Scancode.UpArrow: return SDL_Scancode.SDL_SCANCODE_UP;
                case Scancode.NumLock: return SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR;
                case Scancode.KeypadEnter: return SDL_Scancode.SDL_SCANCODE_KP_ENTER;
                case Scancode.KeypadForwardSlash: return SDL_Scancode.SDL_SCANCODE_KP_DIVIDE;
                case Scancode.KeypadPeriod: return SDL_Scancode.SDL_SCANCODE_KP_PERIOD;
                case Scancode.KeypadStar: return SDL_Scancode.SDL_SCANCODE_KP_MULTIPLY;
                case Scancode.KeypadDash: return SDL_Scancode.SDL_SCANCODE_KP_MINUS;
                case Scancode.KeypadPlus: return SDL_Scancode.SDL_SCANCODE_KP_PLUS;
                case Scancode.NonUSSlashBar: return SDL_Scancode.SDL_SCANCODE_NONUSBACKSLASH;
                case Scancode.Application: return SDL_Scancode.SDL_SCANCODE_APPLICATION;
                case Scancode.KeypadEquals: return SDL_Scancode.SDL_SCANCODE_KP_EQUALS;
                case Scancode.KeypadComma: return SDL_Scancode.SDL_SCANCODE_KP_COMMA;
                case Scancode.International1: return SDL_Scancode.SDL_SCANCODE_INTERNATIONAL1;
                case Scancode.International2: return SDL_Scancode.SDL_SCANCODE_INTERNATIONAL2;
                case Scancode.International3: return SDL_Scancode.SDL_SCANCODE_INTERNATIONAL3;
                case Scancode.International4: return SDL_Scancode.SDL_SCANCODE_INTERNATIONAL4;
                case Scancode.International5: return SDL_Scancode.SDL_SCANCODE_INTERNATIONAL5;
                case Scancode.International6: return SDL_Scancode.SDL_SCANCODE_INTERNATIONAL6;
                case Scancode.LANG1: return SDL_Scancode.SDL_SCANCODE_LANG1;
                case Scancode.LANG2: return SDL_Scancode.SDL_SCANCODE_LANG2;
                case Scancode.LANG3: return SDL_Scancode.SDL_SCANCODE_LANG3;
                case Scancode.LANG4: return SDL_Scancode.SDL_SCANCODE_LANG4;
                case Scancode.LANG5: return SDL_Scancode.SDL_SCANCODE_LANG5;
                case Scancode.LeftControl: return SDL_Scancode.SDL_SCANCODE_LCTRL;
                case Scancode.LeftShift: return SDL_Scancode.SDL_SCANCODE_LSHIFT;
                case Scancode.LeftAlt: return SDL_Scancode.SDL_SCANCODE_LALT;
                case Scancode.LeftGUI: return SDL_Scancode.SDL_SCANCODE_LGUI;
                case Scancode.RightControl: return SDL_Scancode.SDL_SCANCODE_RCTRL;
                case Scancode.RightShift: return SDL_Scancode.SDL_SCANCODE_RSHIFT;
                case Scancode.RightAlt: return SDL_Scancode.SDL_SCANCODE_RALT;
                case Scancode.RightGUI: return SDL_Scancode.SDL_SCANCODE_RGUI;
                // FIXME: Can we do something here? Is this key even interesting??
                case Scancode.SystemPowerDown: return SDL_Scancode.SDL_SCANCODE_UNKNOWN;
                case Scancode.SystemSleep: return SDL_Scancode.SDL_SCANCODE_SLEEP;
                // FIXME: Can we do something here?
                case Scancode.SystemWakeUp: return SDL_Scancode.SDL_SCANCODE_UNKNOWN;
                case Scancode.ScanNextTrack: return SDL_Scancode.SDL_SCANCODE_AUDIONEXT;
                case Scancode.ScanPreviousTrack: return SDL_Scancode.SDL_SCANCODE_AUDIOPREV;
                case Scancode.Stop: return SDL_Scancode.SDL_SCANCODE_AUDIOSTOP;
                case Scancode.PlayPause: return SDL_Scancode.SDL_SCANCODE_AUDIOPLAY;
                case Scancode.Mute: return SDL_Scancode.SDL_SCANCODE_AUDIOMUTE;
                case Scancode.VolumeIncrement: return SDL_Scancode.SDL_SCANCODE_VOLUMEUP;
                case Scancode.VolumeDecrement: return SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN;
                default:
                    logger?.LogWarning($"Could not convert Scancode {scancode} to SDL scancode.");
                    return SDL_Scancode.SDL_SCANCODE_UNKNOWN;
            }
        }

        internal static Scancode FromSDL(SDL_Scancode scancode, ILogger? logger)
        {
            foreach (var scan in Enum.GetValues<Scancode>())
            {
                if (ToSDL(scan, logger) == scancode)
                {
                    return scan;
                }
            }

            logger?.LogWarning($"Could not find Scancode for SDL scancode {scancode}.");

            return Scancode.Unknown;
        }
    
        internal static KeyModifier FromSDL(SDL_Keymod mods)
        {
            KeyModifier modifiers = KeyModifier.None;
            if (mods.HasFlag(SDL_Keymod.KMOD_LSHIFT))
                modifiers |= KeyModifier.LeftShift;
            if (mods.HasFlag(SDL_Keymod.KMOD_RSHIFT))
                modifiers |= KeyModifier.RightShift;

            if (mods.HasFlag(SDL_Keymod.KMOD_LCTRL))
                modifiers |= KeyModifier.LeftControl;
            if (mods.HasFlag(SDL_Keymod.KMOD_RCTRL))
                modifiers |= KeyModifier.RightControl;

            if (mods.HasFlag(SDL_Keymod.KMOD_LALT))
                modifiers |= KeyModifier.LeftAlt;
            if (mods.HasFlag(SDL_Keymod.KMOD_RALT))
                modifiers |= KeyModifier.RightAlt;

            if (mods.HasFlag(SDL_Keymod.KMOD_LGUI))
                modifiers |= KeyModifier.LeftGUI;
            if (mods.HasFlag(SDL_Keymod.KMOD_RGUI))
                modifiers |= KeyModifier.RightGUI;

            if (mods.HasFlag(SDL_Keymod.KMOD_NUM))
                modifiers |= KeyModifier.NumLock;
            if (mods.HasFlag(SDL_Keymod.KMOD_CAPS))
                modifiers |= KeyModifier.CapsLock;
            if (mods.HasFlag(SDL_Keymod.KMOD_SCROLL))
                modifiers |= KeyModifier.ScrollLock;

            if (modifiers.HasFlag(KeyModifier.LeftShift) || modifiers.HasFlag(KeyModifier.RightShift))
                modifiers |= KeyModifier.Shift;
            if (modifiers.HasFlag(KeyModifier.LeftControl) || modifiers.HasFlag(KeyModifier.RightControl))
                modifiers |= KeyModifier.Control;
            if (modifiers.HasFlag(KeyModifier.LeftAlt) || modifiers.HasFlag(KeyModifier.RightAlt))
                modifiers |= KeyModifier.Alt;
            if (modifiers.HasFlag(KeyModifier.LeftGUI) || modifiers.HasFlag(KeyModifier.RightGUI))
                modifiers |= KeyModifier.GUI;

            return modifiers;
        }
    }
}
