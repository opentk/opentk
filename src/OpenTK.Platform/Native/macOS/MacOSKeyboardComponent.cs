using System;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSKeyboardComponent : IKeyboardComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(MacOSKeyboardComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.KeyboardInput;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal static bool[] KeyboardState = new bool[256];

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
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
        }

        /// <inheritdoc/>
        public string[] GetAvailableKeyboardLayouts()
        {
            // FIXME:
            return Array.Empty<string>();
        }

        internal static bool KeyStateChanged(Scancode code, bool pressed)
        {
            bool prev = KeyboardState[(int)code];
            KeyboardState[(int)code] = pressed;
            return prev != pressed;
        }

        internal static KeyModifier ToKeyModifiers(ModifierFlags mods)
        {
            KeyModifier modifiers = KeyModifier.None;

            if (mods.HasFlag(ModifierFlags.NX_DEVICELCTLKEYMASK))
                modifiers |= KeyModifier.LeftControl;

            if (mods.HasFlag(ModifierFlags.NX_DEVICELSHIFTKEYMASK))
                modifiers |= KeyModifier.LeftShift;

            if (mods.HasFlag(ModifierFlags.NX_DEVICERSHIFTKEYMASK))
                modifiers |= KeyModifier.RightShift;

            if (mods.HasFlag(ModifierFlags.NX_DEVICELCMDKEYMASK))
                modifiers |= KeyModifier.LeftGUI;

            if (mods.HasFlag(ModifierFlags.NX_DEVICERCMDKEYMASK))
                modifiers |= KeyModifier.RightGUI;

            if (mods.HasFlag(ModifierFlags.NX_DEVICELALTKEYMASK))
                modifiers |= KeyModifier.LeftAlt;

            if (mods.HasFlag(ModifierFlags.NX_DEVICERALTKEYMASK))
                modifiers |= KeyModifier.RightAlt;

            if (mods.HasFlag(ModifierFlags.NX_DEVICERCTLKEYMASK))
                modifiers |= KeyModifier.RightControl;

            if (mods.HasFlag(ModifierFlags.CapsLock))
                modifiers |= KeyModifier.CapsLock;

            if (mods.HasFlag(ModifierFlags.Shift))
                modifiers |= KeyModifier.Shift;

            if (mods.HasFlag(ModifierFlags.Control))
                modifiers |= KeyModifier.Control;

            if (mods.HasFlag(ModifierFlags.Option))
                modifiers |= KeyModifier.Alt;

            if (mods.HasFlag(ModifierFlags.Command))
                modifiers |= KeyModifier.GUI;

            // FIXME: Do something with NumericPad, Help, and Function?

            // FIXME: ScrollLock? NumLock?

            return modifiers;
        }

        internal static Scancode ScancodeFromVK(VK vk)
        {
            switch (vk)
            {
                case VK.kVK_ANSI_A: return Scancode.A;
                case VK.kVK_ANSI_B: return Scancode.B;
                case VK.kVK_ANSI_C: return Scancode.C;
                case VK.kVK_ANSI_D: return Scancode.D;
                case VK.kVK_ANSI_E: return Scancode.E;
                case VK.kVK_ANSI_F: return Scancode.F;
                case VK.kVK_ANSI_G: return Scancode.G;
                case VK.kVK_ANSI_H: return Scancode.H;
                case VK.kVK_ANSI_I: return Scancode.I;
                case VK.kVK_ANSI_J: return Scancode.J;
                case VK.kVK_ANSI_K: return Scancode.K;
                case VK.kVK_ANSI_L: return Scancode.L;
                case VK.kVK_ANSI_M: return Scancode.M;
                case VK.kVK_ANSI_N: return Scancode.N;
                case VK.kVK_ANSI_O: return Scancode.O;
                case VK.kVK_ANSI_P: return Scancode.P;
                case VK.kVK_ANSI_Q: return Scancode.Q;
                case VK.kVK_ANSI_R: return Scancode.R;
                case VK.kVK_ANSI_S: return Scancode.S;
                case VK.kVK_ANSI_T: return Scancode.T;
                case VK.kVK_ANSI_U: return Scancode.U;
                case VK.kVK_ANSI_V: return Scancode.V;
                case VK.kVK_ANSI_W: return Scancode.W;
                case VK.kVK_ANSI_X: return Scancode.X;
                case VK.kVK_ANSI_Y: return Scancode.Y;
                case VK.kVK_ANSI_Z: return Scancode.Z;

                case VK.kVK_ANSI_0: return Scancode.D0;
                case VK.kVK_ANSI_1: return Scancode.D1;
                case VK.kVK_ANSI_2: return Scancode.D2;
                case VK.kVK_ANSI_3: return Scancode.D3;
                case VK.kVK_ANSI_4: return Scancode.D4;
                case VK.kVK_ANSI_5: return Scancode.D5;
                case VK.kVK_ANSI_6: return Scancode.D6;
                case VK.kVK_ANSI_7: return Scancode.D7;
                case VK.kVK_ANSI_8: return Scancode.D8;
                case VK.kVK_ANSI_9: return Scancode.D9;

                case VK.kVK_F1: return Scancode.F1;
                case VK.kVK_F2: return Scancode.F2;
                case VK.kVK_F3: return Scancode.F3;
                case VK.kVK_F4: return Scancode.F4;
                case VK.kVK_F5: return Scancode.F5;
                case VK.kVK_F6: return Scancode.F6;
                case VK.kVK_F7: return Scancode.F7;
                case VK.kVK_F8: return Scancode.F8;
                case VK.kVK_F9: return Scancode.F9;
                case VK.kVK_F10: return Scancode.F10;
                case VK.kVK_F11: return Scancode.F11;
                case VK.kVK_F12: return Scancode.F12;
                case VK.kVK_F13: return Scancode.F13;
                case VK.kVK_F14: return Scancode.F14;
                case VK.kVK_F15: return Scancode.F15;
                case VK.kVK_F16: return Scancode.F16;
                case VK.kVK_F17: return Scancode.F17;
                case VK.kVK_F18: return Scancode.F18;
                case VK.kVK_F19: return Scancode.F19;
                case VK.kVK_F20: return Scancode.F20;

                case VK.kVK_ANSI_Keypad0: return Scancode.Keypad0;
                case VK.kVK_ANSI_Keypad1: return Scancode.Keypad1;
                case VK.kVK_ANSI_Keypad2: return Scancode.Keypad2;
                case VK.kVK_ANSI_Keypad3: return Scancode.Keypad3;
                case VK.kVK_ANSI_Keypad4: return Scancode.Keypad4;
                case VK.kVK_ANSI_Keypad5: return Scancode.Keypad5;
                case VK.kVK_ANSI_Keypad6: return Scancode.Keypad6;
                case VK.kVK_ANSI_Keypad7: return Scancode.Keypad7;
                case VK.kVK_ANSI_Keypad8: return Scancode.Keypad8;
                case VK.kVK_ANSI_Keypad9: return Scancode.Keypad9;
                case VK.kVK_ANSI_KeypadDivide: return Scancode.KeypadForwardSlash;
                case VK.kVK_ANSI_KeypadDecimal: return Scancode.KeypadPeriod;
                case VK.kVK_ANSI_KeypadMultiply: return Scancode.KeypadStar;
                case VK.kVK_ANSI_KeypadMinus: return Scancode.KeypadDash;
                case VK.kVK_ANSI_KeypadPlus: return Scancode.KeypadPlus;
                case VK.kVK_ANSI_KeypadEquals: return Scancode.KeypadEquals;
                case VK.kVK_JIS_KeypadComma: return Scancode.KeypadComma;
                // FIXME: case VK.kVK_ANSI_KeypadClear:

                case VK.kVK_ANSI_Equal: return Scancode.Equals;
                case VK.kVK_ANSI_Minus: return Scancode.Dash;
                // FIXME: Is this correct?
                case VK.kVK_ANSI_RightBracket: return Scancode.RightBrace;
                // FIXME: Is this correct?
                case VK.kVK_ANSI_LeftBracket: return Scancode.LeftBrace;
                case VK.kVK_ANSI_Quote: return Scancode.LeftApostrophe;
                case VK.kVK_ANSI_Semicolon: return Scancode.SemiColon;
                case VK.kVK_ANSI_Backslash: return Scancode.Pipe;
                case VK.kVK_ANSI_Comma: return Scancode.Comma;
                case VK.kVK_ANSI_Slash: return Scancode.QuestionMark;
                case VK.kVK_ANSI_Period: return Scancode.Period;
                // FIXME: This key seems to move depending on layout?
                // This can both be Scancode.GraveAccent and Scancode.NonUSSlashBar...
                case VK.kVK_ANSI_Grave: return Scancode.NonUSSlashBar;

                case VK.kVK_Return: return Scancode.Return;
                case VK.kVK_Tab: return Scancode.Tab;
                case VK.kVK_Space: return Scancode.Spacebar;
                case VK.kVK_Delete: return Scancode.Backspace;
                case VK.kVK_Escape: return Scancode.Escape;
                // FIXME: kVK_Command gets sent for both Left and Right command...
                case VK.kVK_Command: return Scancode.LeftGUI;
                case VK.kVK_Shift: return Scancode.LeftShift;
                case VK.kVK_CapsLock: return Scancode.CapsLock;
                case VK.kVK_Option: return Scancode.LeftAlt;
                case VK.kVK_Control: return Scancode.LeftControl;
                case VK.kVK_RightShift: return Scancode.RightShift;
                case VK.kVK_RightOption: return Scancode.RightAlt;
                case VK.kVK_RightControl: return Scancode.RightControl;
                // FIXME: 
                // case VK.kVK_Function: return Scancode.Fn;
                case VK.kVK_VolumeUp: return Scancode.VolumeIncrement;
                case VK.kVK_VolumeDown: return Scancode.VolumeDecrement;
                case VK.kVK_Mute: return Scancode.Mute;
                // FIXME:
                // case VK.kVK_Help: return Scancode.Help;
                case VK.kVK_Home: return Scancode.Home;
                case VK.kVK_PageUp: return Scancode.PageUp;
                case VK.kVK_PageDown: return Scancode.PageDown;
                case VK.kVK_LeftArrow: return Scancode.LeftArrow;
                case VK.kVK_RightArrow: return Scancode.RightArrow;
                case VK.kVK_DownArrow: return Scancode.DownArrow;
                case VK.kVK_UpArrow: return Scancode.UpArrow;

                case VK.kVK_ISO_Section: return Scancode.GraveAccent;

                // FIXME: Map to international scancodes?
                case VK.kVK_JIS_Yen:
                case VK.kVK_JIS_Underscore:
                case VK.kVK_JIS_Eisu:
                case VK.kVK_JIS_Kana:
                default:
                    return Scancode.Unknown;
            }
        }

        /// <inheritdoc/>
        public Scancode GetScancodeFromKey(Key key)
        {
            return Scancode.Unknown;
        }

        /// <inheritdoc/>
        public Key GetKeyFromScancode(Scancode scancode)
        {
            return GetKeyFromScancodeInternal(scancode);
        }

        internal static Key GetKeyFromScancodeInternal(Scancode scancode)
        {
            // FIXME: For now we do a quick and dirty mapping to make something work
            // but this implementation is not correct.
            if (scancode == Scancode.D0)
                return Key.D0;
            if (scancode >= Scancode.D1 && scancode <= Scancode.D9)
                return scancode - Scancode.D1 + Key.D1;

            if (scancode >= Scancode.A && scancode <= Scancode.Z)
                return scancode - Scancode.A + Key.A;

            switch (scancode)
            {
                case Scancode.Return: // kVK_Return
                    return Key.Return;
                case Scancode.Backspace: // kVK_Delete
                    return Key.Backspace;
                case Scancode.Escape: // kVK_Escape
                    return Key.Escape;
                case Scancode.LeftArrow: // kVK_LeftArrow
                    return Key.LeftArrow;
                case Scancode.RightArrow: // kVK_RightArrow
                    return Key.RightArrow;
                case Scancode.DownArrow: // kVK_DownArrow
                    return Key.DownArrow;
                case Scancode.UpArrow: // kVK_UpArrow
                    return Key.UpArrow;
                case Scancode.LeftControl:
                    return Key.LeftControl;
                case Scancode.RightControl:
                    return Key.RightControl;
                case Scancode.LeftShift:
                    return Key.LeftShift;
                case Scancode.RightShift:
                    return Key.RightShift;
                case Scancode.LeftAlt:
                    return Key.LeftAlt;
                case Scancode.RightAlt:
                    return Key.RightAlt;
                case Scancode.LeftGUI:
                    return Key.LeftGUI;
                case Scancode.RightGUI:
                    return Key.RightGUI;
                case Scancode.Tab:
                    return Key.Tab;
                case Scancode.Delete:
                    return Key.Delete;
                default:
                    return Key.Unknown;
            }
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
            ModifierFlags modifierFlags = (ModifierFlags)((UIntPtr)objc_msgSend_IntPtr((IntPtr)MacOSWindowComponent.NSEventClass, MacOSWindowComponent.selModifierFlags)).ToUInt64();
            KeyModifier modifiers = ToKeyModifiers(modifierFlags);
            // [NSEvent modifierFlags] doesn't seem to include left and right device dependent flags,
            // so we have to add them by looking at which buttons are pressed.
            // - Noggin_bops 2024-02-28
            modifiers = AddLeftRight(modifiers);
            return modifiers;

            static KeyModifier AddLeftRight(KeyModifier modifiers)
            {
                if (KeyboardState[(int)Scancode.LeftShift])
                    modifiers |= KeyModifier.LeftShift;

                if (KeyboardState[(int)Scancode.RightShift])
                    modifiers |= KeyModifier.RightShift;

                if (KeyboardState[(int)Scancode.LeftControl])
                    modifiers |= KeyModifier.LeftControl;

                if (KeyboardState[(int)Scancode.RightControl])
                    modifiers |= KeyModifier.RightControl;

                if (KeyboardState[(int)Scancode.LeftAlt])
                    modifiers |= KeyModifier.LeftAlt;

                if (KeyboardState[(int)Scancode.RightAlt])
                    modifiers |= KeyModifier.RightAlt;

                if (KeyboardState[(int)Scancode.LeftGUI])
                    modifiers |= KeyModifier.LeftGUI;

                if (KeyboardState[(int)Scancode.RightGUI])
                    modifiers |= KeyModifier.RightGUI;

                return modifiers;
            }
        }

        /// <inheritdoc/>
        public void BeginIme(WindowHandle window)
        {
            // FIXME:
        }

        /// <inheritdoc/>
        public unsafe void SetImeRectangle(WindowHandle window, int x, int y, int width, int height)
        {
            NSWindowHandle nswindow = window.As<NSWindowHandle>(this);
            
            // FIXME: Convert rect into the correct coordinate system.

            // For now we just set the ivar directly.
            *(CGRect*)getIvarPointer(nswindow.View, "inputRect"u8) = new CGRect(x, y, width, height);
        }

        /// <inheritdoc/>
        public void EndIme(WindowHandle window)
        {
            // FIXME:
        }
    }
}
