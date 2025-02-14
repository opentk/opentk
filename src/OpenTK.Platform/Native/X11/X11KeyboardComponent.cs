using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Platform.Native.X11.XI2;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.LibXkb;

namespace OpenTK.Platform.Native.X11
{
    public class X11KeyboardComponent : IKeyboardComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11KeyboardComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.KeyboardInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal static bool XkbDetectableRepeatEnabled = false;

        private static bool[] KeyboardState = new bool[256];

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            int major = 1;
            int minor = 0;
            if (XkbQueryExtension(X11.Display, out int opcode, out int @event, out int error, ref major, ref minor) == false)
            {
                // FIXME:
                throw new Exception("Xkb extension not available.");
            }

            if (XkbSetDetectableAutoRepeat(X11.Display, true, out bool supported) && supported)
            {
                // detectable repeat is enabled and supported!
                XkbDetectableRepeatEnabled = true;
            }

            //XkbSelectEvents(X11.Display, XkbUseCoreKbd, )

            //XkbGetMap(X11.Display, )

            UpdateKeymap();
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        internal static KeyModifier ModifiersFromState(uint state)
        {
            XStateMask mask = (XStateMask)state;

            KeyModifier modifiers = KeyModifier.None;

            // FIXME: Set the left and right
            // versions of the modifiers.
            // - Noggin_bops 2024-02-25

            // FIXME: Using xmodmap one can redefine
            // what the different mod1-mod3 makes
            // are toggled by. SDL has some logic to
            // figure out which mod is bound to 
            // what modifier.
            // Do we care about that?
            // - Noggin_bops 2024-02-25

            if (mask.HasFlag(XStateMask.ShiftMask))
                modifiers |= KeyModifier.Shift;

            if (mask.HasFlag(XStateMask.LockMask))
                modifiers |= KeyModifier.CapsLock;

            if (mask.HasFlag(XStateMask.ControlMask))
                modifiers |= KeyModifier.Control;

            if (mask.HasFlag(XStateMask.Mod1Mask))
                modifiers |= KeyModifier.Alt;

            if (mask.HasFlag(XStateMask.Mod2Mask))
                modifiers |= KeyModifier.NumLock;

            if (mask.HasFlag(XStateMask.Mod3Mask))
                modifiers |= KeyModifier.ScrollLock;

            if (mask.HasFlag(XStateMask.Mod4Mask))
                modifiers |= KeyModifier.GUI;

            return modifiers;
        }

        /// <returns>If the state of the key changed.</returns>
        internal static bool KeyStateChanged(Scancode code, bool pressed)
        {
            bool prev = KeyboardState[(int)code];
            KeyboardState[(int)code] = pressed;
            return prev != pressed;
        }

        // FIXME: Figure out what we should do with the Key enum here...
        internal static Key TranslateKeySym(Span<XKeySym> keysyms)
        {
            if (keysyms.Length > 1)
            {
                switch ((XK)keysyms[1].Id)
                {
                    case XK.XK_KP_0: return Key.Keypad0;
                    case XK.XK_KP_1: return Key.Keypad1;
                    case XK.XK_KP_2: return Key.Keypad2;
                    case XK.XK_KP_3: return Key.Keypad3;
                    case XK.XK_KP_4: return Key.Keypad4;
                    case XK.XK_KP_5: return Key.Keypad5;
                    case XK.XK_KP_6: return Key.Keypad6;
                    case XK.XK_KP_7: return Key.Keypad7;
                    case XK.XK_KP_8: return Key.Keypad8;
                    case XK.XK_KP_9: return Key.Keypad9;

                    case XK.XK_KP_Equal: return Key.KeypadEqual;
                    case XK.XK_KP_Add: return Key.KeypadAdd;
                    case XK.XK_KP_Subtract: return Key.KeypadSubtract;
                    case XK.XK_KP_Multiply: return Key.KeypadMultiply;
                    case XK.XK_KP_Divide: return Key.KeypadDivide;
                    case XK.XK_KP_Enter: return Key.KeypadEnter;
                    case XK.XK_KP_Decimal: return Key.KeypadDecimal;
                    case XK.XK_KP_Separator: return Key.KeypadSeparator;
                }
            }

            if ((XK)keysyms[0].Id >= XK.XK_A && (XK)keysyms[0].Id <= XK.XK_Z)
            {
                return Key.A + (int)(keysyms[0].Id - XK.XK_A);
            }

            if ((XK)keysyms[0].Id >= XK.XK_a && (XK)keysyms[0].Id <= XK.XK_z)
            {
                return Key.A + (int)(keysyms[0].Id - XK.XK_a);
            }

            if ((XK)keysyms[0].Id >= XK.XK_0 && (XK)keysyms[0].Id <= XK.XK_9)
            {
                return Key.D0 + (int)(keysyms[0].Id - XK.XK_0);
            }

            if ((XK)keysyms[0].Id >= XK.XK_F1 && (XK)keysyms[0].Id <= XK.XK_F24)
            {
                return Key.F1 + (int)(keysyms[0].Id - XK.XK_F1);
            }

            // If NumLock is not enabled keypad keys will be reported as their functon
            // and not their number. e.g. XK_KP_0 -> XK_KP_Insert.
            // - Noggin_bops 2024-02-23
            if ((XK)keysyms[0].Id >= XK.XK_KP_0 && (XK)keysyms[0].Id <= XK.XK_KP_9)
            {
                return Key.Keypad0 + (int)(keysyms[0].Id - XK.XK_KP_0);
            }

            // FIXME: 
            // There is a KeySym for baiscally every codepoint in Unicode...
            //
            // This is not really what we want the Keys to be.
            // Windows does this differently where scancodes are converted to virtual keys that then
            // depending on locale get translated into text depending on input language.
            // Some layouts like French azerty layouts shift the locations of virtual keys
            // while languages with non-latin/greek alphabets like arabic the virtual keys
            // are placed like in a US layout and then get converted to arabic text input when typed.
            //
            // X11 doesn't really do this the same way.
            // In linux there are scancodes that get converted into keycodes. 
            // This happens at a very low level, before X11.
            // Then X11 uses the current keyboard layout and modifiers
            // to convert the keycode into a KeySym.
            // This can be thought of as representing the symbol printed on the keyboard key.
            // 
            // We could write code that then converts KeySyms back to the same kind of
            // virtual keys that windows uses. Alternatively we could expand our selection of
            // Keys to contain the around 2000 codepoints that are present in keysymdef.h
            // This could be useful to be able to accurately show the key symbol in game.
            // 
            // This leads to a larger discussion about what the usecases for Scancode and Key are
            // that I don't think we have really figured out yet.
            // - Noggin_bops 2024-02-23

            switch ((XK)keysyms[0].Id)
            {
                case XK.XK_BackSpace: return Key.Backspace;
                case XK.XK_Return: return Key.Return;
                case XK.XK_Escape: return Key.Escape;
                case XK.XK_Tab: return Key.Tab;
                case XK.XK_Caps_Lock: return Key.CapsLock;
                case XK.XK_space: return Key.Space;
                // FIXME: is this correct?
                case XK.XK_Menu: return Key.Application;
                case XK.XK_Insert: return Key.Insert;
                case XK.XK_Delete: return Key.Delete;
                case XK.XK_Home: return Key.Home;
                case XK.XK_End: return Key.End;
                case XK.XK_Page_Up: return Key.PageUp;
                case XK.XK_Page_Down: return Key.PageDown;
                case XK.XK_Num_Lock: return Key.NumLock;
                // FIXME: Is this correct?
                case XK.XK_Sys_Req: return Key.PrintScreen;
                // FIXME: Is this correct?
                case XK.XK_3270_PrintScreen: return Key.PrintScreen;
                case XK.XK_Scroll_Lock: return Key.ScrollLock;
                case XK.XK_Pause: return Key.PauseBreak;

                case XK.XK_Shift_L: return Key.LeftShift;
                case XK.XK_Control_L: return Key.LeftControl;
                case XK.XK_Alt_L: return Key.LeftAlt;
                case XK.XK_Super_L: return Key.LeftGUI;

                case XK.XK_Shift_R: return Key.RightShift;
                case XK.XK_Control_R: return Key.RightControl;
                case XK.XK_Alt_R: return Key.RightAlt;
                case XK.XK_Super_R: return Key.RightGUI;

                case XK.XK_Left: return Key.LeftArrow;
                case XK.XK_Right: return Key.RightArrow;
                case XK.XK_Up: return Key.UpArrow;
                case XK.XK_Down: return Key.DownArrow;

                // FIXME: This part would get crazy long if
                // we had to do this for every keyboard layout...
                case XK.XK_odiaeresis: return Key.OEM3;
                case XK.XK_adiaeresis: return Key.OEM7;
                case XK.XK_aring: return Key.OEM6;
                case XK.XK_section: return Key.OEM5;

                default: return Key.Unknown;
            }
        }

        static readonly Dictionary<string, Scancode> XkbNameToScancode = new ()
        {
            { "AE01", Scancode.D1 },
            { "AE02", Scancode.D2 },
            { "AE03", Scancode.D3 },
            { "AE04", Scancode.D4 },
            { "AE05", Scancode.D5 },
            { "AE06", Scancode.D6 },
            { "AE07", Scancode.D7 },
            { "AE08", Scancode.D8 },
            { "AE09", Scancode.D9 },
            { "AE10", Scancode.D0 },
            { "AE11", Scancode.Dash },
            { "AE12", Scancode.Equals },

            { "AD01", Scancode.Q },
            { "AD02", Scancode.W },
            { "AD03", Scancode.E },
            { "AD04", Scancode.R },
            { "AD05", Scancode.T },
            { "AD06", Scancode.Y },
            { "AD07", Scancode.U },
            { "AD08", Scancode.I },
            { "AD09", Scancode.O },
            { "AD10", Scancode.P },
            { "AD11", Scancode.LeftBrace },
            { "AD12", Scancode.RightBrace },

            { "AC01", Scancode.A },
            { "AC02", Scancode.S },
            { "AC03", Scancode.D },
            { "AC04", Scancode.F },
            { "AC05", Scancode.G },
            { "AC06", Scancode.H },
            { "AC07", Scancode.J },
            { "AC08", Scancode.K },
            { "AC09", Scancode.L },
            { "AC10", Scancode.SemiColon },
            { "AC11", Scancode.LeftApostrophe },

            { "AB01", Scancode.Z },
            { "AB02", Scancode.X },
            { "AB03", Scancode.C },
            { "AB04", Scancode.V },
            { "AB05", Scancode.B },
            { "AB06", Scancode.N },
            { "AB07", Scancode.M },
            { "AB08", Scancode.Comma },
            { "AB09", Scancode.Period },
            { "AB10", Scancode.QuestionMark },

            { "BKSL", Scancode.Pipe },
            { "LSGT", Scancode.NonUSSlashBar },
            { "SPCE", Scancode.Spacebar },
            { "ESC\0", Scancode.Escape },
            { "RTRN", Scancode.Return },
            { "TAB\0", Scancode.Tab },
            { "BKSP", Scancode.Backspace },
            { "INS\0", Scancode.Insert },
            { "DELE", Scancode.Delete },
            { "RGHT", Scancode.RightArrow },
            { "LEFT", Scancode.LeftArrow },
            { "DOWN", Scancode.DownArrow },
            { "UP\0\0", Scancode.UpArrow },
            { "PGUP", Scancode.PageUp },
            { "PGDN", Scancode.PageDown },
            { "HOME", Scancode.Home },
            { "END\0", Scancode.End },
            { "CAPS", Scancode.CapsLock },
            { "SCLK", Scancode.ScrollLock },
            { "NMLK", Scancode.NumLock },
            { "PRSC", Scancode.PrintScreen },
            { "PAUS", Scancode.Pause },

            { "FK01", Scancode.F1 },
            { "FK02", Scancode.F2 },
            { "FK03", Scancode.F3 },
            { "FK04", Scancode.F4 },
            { "FK05", Scancode.F5 },
            { "FK06", Scancode.F6 },
            { "FK07", Scancode.F7 },
            { "FK08", Scancode.F8 },
            { "FK09", Scancode.F9 },
            { "FK10", Scancode.F10 },
            { "FK11", Scancode.F11 },
            { "FK12", Scancode.F12 },
            { "FK13", Scancode.F13 },
            { "FK14", Scancode.F14 },
            { "FK15", Scancode.F15 },
            { "FK16", Scancode.F16 },
            { "FK17", Scancode.F17 },
            { "FK18", Scancode.F18 },
            { "FK19", Scancode.F19 },
            { "FK20", Scancode.F20 },
            { "FK21", Scancode.F21 },
            { "FK22", Scancode.F22 },
            { "FK23", Scancode.F23 },
            { "FK24", Scancode.F24 },

            { "KP0\0", Scancode.Keypad0 },
            { "KP1\0", Scancode.Keypad1 },
            { "KP2\0", Scancode.Keypad2 },
            { "KP3\0", Scancode.Keypad3 },
            { "KP4\0", Scancode.Keypad4 },
            { "KP5\0", Scancode.Keypad5 },
            { "KP6\0", Scancode.Keypad6 },
            { "KP7\0", Scancode.Keypad7 },
            { "KP8\0", Scancode.Keypad8 },
            { "KP9\0", Scancode.Keypad9 },

            { "KPDL", Scancode.KeypadPeriod },
            { "KPDV", Scancode.KeypadForwardSlash },
            { "KPMU", Scancode.KeypadStar },
            { "KPSU", Scancode.KeypadDash },
            { "KPAD", Scancode.KeypadPlus },
            { "KPEN", Scancode.KeypadEnter },
            { "KPEQ", Scancode.KeypadEquals },

            { "LFSH", Scancode.LeftShift },
            { "LCTL", Scancode.LeftControl },
            { "LALT", Scancode.LeftAlt },
            { "LWIN", Scancode.LeftGUI },

            { "RTSH", Scancode.RightShift },
            { "RCTL", Scancode.RightControl },
            { "RALT", Scancode.RightAlt },
            // FIXME: What is lvl3?
            { "LVL3", Scancode.RightAlt },
            // FIXME: What is mdsw?
            { "MDSW", Scancode.RightAlt },
            { "RWIN", Scancode.RightGUI },

            // FIXME: What should menu be?
            { "MENU", Scancode.Application },
            { "COMP", Scancode.Application },
            { "TLDE", Scancode.GraveAccent },
        };

        // FIXME: static...
        static readonly Scancode[] KeycodeToScancode = new Scancode[256];
        static readonly int[] ScancodeToKeycode = new int[256];

        internal static Scancode ToScancode(uint keycode)
        {
            if (keycode > KeycodeToScancode.Length)
                return Scancode.Unknown;
            else
                return KeycodeToScancode[keycode];
        }

        internal unsafe void UpdateKeymap()
        {
            XkbDescRec* desc = XkbGetMap(X11.Display, 0, XkbUseCoreKbd);
            int status = XkbGetNames(X11.Display, XkbKeyNamesMask | XkbKeyAliasesMask, desc);
            if (status != Success)
            {
                Logger?.LogError($"XkbGetNames failed with status: {status}");
                XkbFreeKeyboard(desc, 0, true);
                return;
            }

            int min = desc->min_key_code;
            int max = desc->max_key_code;
            for (int scancode = min; scancode <= max; scancode++)
            {
                string? name = Marshal.PtrToStringUTF8((nint)desc->names->keys[scancode].name, 4);
                if(XkbNameToScancode.TryGetValue(name, out Scancode value) == false)
                    value = Scancode.Unknown;
                Logger?.LogDebug($"Scancode: {scancode}, Name: {name ?? "NULL"}, Otk Scancode: {value}");

                KeycodeToScancode[scancode] = value;
                ScancodeToKeycode[(int)KeycodeToScancode[scancode]] = scancode;
            }

            XkbFreeKeyboard(desc, 0, true);
        }

        /// <inheritdoc/>
        public bool SupportsLayouts => false;

        /// <inheritdoc/>
        public bool SupportsIme => false;

        /// <inheritdoc/>
        public string GetActiveKeyboardLayout(WindowHandle? handle)
        {
            // FIXME:
            return "Unknown";
            //throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public string[] GetAvailableKeyboardLayouts()
        {
            // FIXME: 
            return Array.Empty<string>();
            //throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Scancode GetScancodeFromKey(Key key)
        {
            // FIXME: 
            // Key -> KeySym...
            // How do we get a keycode from a KeySym?
            return Scancode.Unknown;
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Key GetKeyFromScancode(Scancode scancode)
        {
            int keycode = ScancodeToKeycode[(int)scancode];
            // FIXME: index?
            // XkbKeycodeToKeysym?
            XKeySym sym = XKeycodeToKeysym(X11.Display, (byte)keycode, 0);

            return TranslateKeySym(stackalloc XKeySym[1] { sym });
        }

        /// <inheritdoc/>
        public void GetKeyboardState(bool[] keyboardState)
        {
            Array.Fill(keyboardState, false);
            Array.Copy(KeyboardState, keyboardState, Math.Min(KeyboardState.Length, keyboardState.Length));
        }

        /// <inheritdoc/>
        public KeyModifier GetKeyboardModifiers()
        {
            if (XQueryPointer(X11.Display, XDefaultRootWindow(X11.Display), out _, out _, out _, out _, out _, out _, out uint state) != 0)
            {
                return ModifiersFromState(state);
            }
            else
            {
                Logger?.LogDebug($"Could not get key modifiers. XQueryPointer returned false.");
                return KeyModifier.None;
            }
        }

        /// <inheritdoc/>
        public void BeginIme(WindowHandle window)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetImeRectangle(WindowHandle window, float x, float y, float width, float height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            throw new NotImplementedException();
        }
    }
}
