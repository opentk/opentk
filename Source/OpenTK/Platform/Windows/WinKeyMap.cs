#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.Windows
{
    static class WinKeyMap
    {
        public static Key TranslateKey(VirtualKeys vk)
        {
            switch (vk)
            {
                // case VirtualKeys.LBUTTON: //Left mouse button
                // case VirtualKeys.RBUTTON: //Right mouse button
                // case VirtualKeys.CANCEL: //Control-break processing
                // case VirtualKeys.MBUTTON: //Middle mouse button (three-button mouse)
                // case VirtualKeys.XBUTTON1: //X1 mouse button
                // case VirtualKeys.XBUTTON2: //X2 mouse button
                // 0x07 Undefined
                case VirtualKeys.BACK: return Key.BackSpace; //BACKSPACE key
                case VirtualKeys.TAB: return Key.Tab; //TAB key
                // 0x0A-0B Reserved
                case VirtualKeys.CLEAR: return Key.Clear; //CLEAR key
                case VirtualKeys.RETURN: return Key.Enter; //ENTER key
                // 0x0E-0F Undefined
                case VirtualKeys.SHIFT: return Key.ShiftLeft; //SHIFT key
                case VirtualKeys.CONTROL: return Key.ControlLeft; //CTRL key
                case VirtualKeys.MENU: return Key.AltLeft; //ALT key
                case VirtualKeys.PAUSE: return Key.Pause; //PAUSE key
                case VirtualKeys.CAPITAL: return Key.CapsLock; //CAPS LOCK key
                //case VirtualKeys.KANA: //IME Kana mode
                //case VirtualKeys.HANGUEL: //IME Hanguel mode (maintained for compatibility; use VK_HANGUL)
                //case VirtualKeys.HANGUL: //IME Hangul mode
                // 0x16 Undefined
                // case VirtualKeys.JUNJA: //IME Junja mode
                // case VirtualKeys.FINAL: //IME final mode
                // case VirtualKeys.HANJA: //IME Hanja mode
                // case VirtualKeys.KANJI: //IME Kanji mode
                // 0x1A Undefined
                case VirtualKeys.ESCAPE: return Key.Escape; //ESC key
                //case VirtualKeys.CONVERT: //IME convert
                //case VirtualKeys.NONCONVERT: //IME nonconvert
                //case VirtualKeys.ACCEPT: //IME accept
                //case VirtualKeys.MODECHANGE: //IME mode change request
                case VirtualKeys.SPACE: return Key.Space; //SPACEBAR
                case VirtualKeys.PRIOR: return Key.PageUp; //PAGE UP key
                case VirtualKeys.NEXT: return Key.PageDown; //PAGE DOWN key
                case VirtualKeys.END: return Key.End; //END key
                case VirtualKeys.HOME: return Key.Home; //HOME key
                case VirtualKeys.LEFT: return Key.Left; //LEFT ARROW key
                case VirtualKeys.UP: return Key.Up; //UP ARROW key
                case VirtualKeys.RIGHT: return Key.Right; //RIGHT ARROW key
                case VirtualKeys.DOWN: return Key.Down; //DOWN ARROW key
                //case VirtualKeys.SELECT: //SELECT key
                //case VirtualKeys.PRINT: //PRINT key
                //case VirtualKeys.EXECUTE: return Key; //EXECUTE key
                case VirtualKeys.SNAPSHOT: return Key.PrintScreen; //PRINT SCREEN key
                case VirtualKeys.INSERT: return Key.Insert; //INS key
                case VirtualKeys.DELETE: return Key.Delete; //DEL key
                //case VirtualKeys.HELP: //HELP key
                case VirtualKeys.D0: return Key.Number0;
                case VirtualKeys.D1: return Key.Number1;
                case VirtualKeys.D2: return Key.Number2;
                case VirtualKeys.D3: return Key.Number3;
                case VirtualKeys.D4: return Key.Number4;
                case VirtualKeys.D5: return Key.Number5;
                case VirtualKeys.D6: return Key.Number6;
                case VirtualKeys.D7: return Key.Number7;
                case VirtualKeys.D8: return Key.Number8;
                case VirtualKeys.D9: return Key.Number9;
                // 0x3A-40 Undefined
                case VirtualKeys.A: return Key.A;
                case VirtualKeys.B: return Key.B;
                case VirtualKeys.C: return Key.C;
                case VirtualKeys.D: return Key.D;
                case VirtualKeys.E: return Key.E;
                case VirtualKeys.F: return Key.F;
                case VirtualKeys.G: return Key.G;
                case VirtualKeys.H: return Key.H;
                case VirtualKeys.I: return Key.I;
                case VirtualKeys.J: return Key.J;
                case VirtualKeys.K: return Key.K;
                case VirtualKeys.L: return Key.L;
                case VirtualKeys.M: return Key.M;
                case VirtualKeys.N: return Key.N;
                case VirtualKeys.O: return Key.O;
                case VirtualKeys.P: return Key.P;
                case VirtualKeys.Q: return Key.Q;
                case VirtualKeys.R: return Key.R;
                case VirtualKeys.S: return Key.S;
                case VirtualKeys.T: return Key.T;
                case VirtualKeys.U: return Key.U;
                case VirtualKeys.V: return Key.V;
                case VirtualKeys.W: return Key.W;
                case VirtualKeys.X: return Key.X;
                case VirtualKeys.Y: return Key.Y;
                case VirtualKeys.Z: return Key.Z;
                case VirtualKeys.LWIN: return Key.WinLeft; //Left Windows key (Natural keyboard)
                case VirtualKeys.RWIN: return Key.WinRight; //Right Windows key (Natural keyboard)
                case VirtualKeys.APPS: return Key.Menu; //Applications key (Natural keyboard)
                // 0x5E Reserved
                case VirtualKeys.SLEEP: return Key.Sleep; //Computer Sleep key
                case VirtualKeys.NUMPAD0: return Key.Keypad0; //Numeric keypad 0 key
                case VirtualKeys.NUMPAD1: return Key.Keypad1; //Numeric keypad 1 key
                case VirtualKeys.NUMPAD2: return Key.Keypad2; //Numeric keypad 2 key
                case VirtualKeys.NUMPAD3: return Key.Keypad3; //Numeric keypad 3 key
                case VirtualKeys.NUMPAD4: return Key.Keypad4; //Numeric keypad 4 key
                case VirtualKeys.NUMPAD5: return Key.Keypad5; //Numeric keypad 5 key
                case VirtualKeys.NUMPAD6: return Key.Keypad6; //Numeric keypad 6 key
                case VirtualKeys.NUMPAD7: return Key.Keypad7; //Numeric keypad 7 key
                case VirtualKeys.NUMPAD8: return Key.Keypad8; //Numeric keypad 8 key
                case VirtualKeys.NUMPAD9: return Key.Keypad9; //Numeric keypad 9 key
                case VirtualKeys.MULTIPLY: return Key.KeypadMultiply; //Multiply key
                case VirtualKeys.ADD: return Key.KeypadAdd; //Add key
                //case VirtualKeys.SEPARATOR: //Separator key
                case VirtualKeys.SUBTRACT: return Key.KeypadSubtract; //Subtract key
                case VirtualKeys.DECIMAL: return Key.KeypadDecimal; //Decimal key
                case VirtualKeys.DIVIDE: return Key.KeypadDivide; //Divide key
                case VirtualKeys.F1: return Key.F1; //F1 key
                case VirtualKeys.F2: return Key.F2; //F2 key
                case VirtualKeys.F3: return Key.F3; //F3 key
                case VirtualKeys.F4: return Key.F4; //F4 key
                case VirtualKeys.F5: return Key.F5; //F5 key
                case VirtualKeys.F6: return Key.F6; //F6 key
                case VirtualKeys.F7: return Key.F7; //F7 key
                case VirtualKeys.F8: return Key.F8; //F8 key
                case VirtualKeys.F9: return Key.F9; //F9 key
                case VirtualKeys.F10: return Key.F10; //F10 key
                case VirtualKeys.F11: return Key.F11; //F11 key
                case VirtualKeys.F12: return Key.F12; //F12 key
                case VirtualKeys.F13: return Key.F13; //F13 key
                case VirtualKeys.F14: return Key.F14; //F14 key
                case VirtualKeys.F15: return Key.F15; //F15 key
                case VirtualKeys.F16: return Key.F16; //F16 key
                case VirtualKeys.F17: return Key.F17; //F17 key
                case VirtualKeys.F18: return Key.F18; //F18 key
                case VirtualKeys.F19: return Key.F19; //F19 key
                case VirtualKeys.F20: return Key.F20; //F20 key
                case VirtualKeys.F21: return Key.F21; //F21 key
                case VirtualKeys.F22: return Key.F22; //F22 key
                case VirtualKeys.F23: return Key.F23; //F23 key
                case VirtualKeys.F24: return Key.F24; //F24 key
                // 0x88-8F Unassigned
                case VirtualKeys.NUMLOCK: return Key.NumLock; //NUM LOCK key
                case VirtualKeys.SCROLL: return Key.ScrollLock; //SCROLL LOCK key 
                // 0x92-96 OEM specific
                // 0x97-9F Unassigned
                case VirtualKeys.LSHIFT: return Key.ShiftLeft; //Left SHIFT key
                case VirtualKeys.RSHIFT: return Key.ShiftRight; //Right SHIFT key
                case VirtualKeys.LCONTROL: return Key.ControlLeft; //Left CONTROL key
                case VirtualKeys.RCONTROL: return Key.ControlRight; //Right CONTROL key
                case VirtualKeys.LMENU: return Key.AltLeft; //Left MENU key
                case VirtualKeys.RMENU: return Key.AltRight; //Right MENU key
                //case VirtualKeys.BROWSER_BACK: //Browser Back key
                //case VirtualKeys.BROWSER_FORWARD: //Browser Forward key
                //case VirtualKeys.BROWSER_REFRESH: //Browser Refresh key
                //case VirtualKeys.BROWSER_STOP: //Browser Stop key
                //case VirtualKeys.BROWSER_SEARCH: //Browser Search key
                //case VirtualKeys.BROWSER_FAVORITES: //Browser Favorites key
                //case VirtualKeys.BROWSER_HOME: //Browser Start and Home key
                //case VirtualKeys.VOLUME_MUTE: //Volume Mute key
                //case VirtualKeys.VOLUME_DOWN: //Volume Down key
                //case VirtualKeys.VOLUME_UP: //Volume Up key
                //case VirtualKeys.MEDIA_NEXT_TRACK: //Next Track key
                //case VirtualKeys.MEDIA_PREV_TRACK: //Previous Track key
                //case VirtualKeys.MEDIA_STOP: //Stop Media key
                //case VirtualKeys.MEDIA_PLAY_PAUSE: //Play/Pause Media key
                //case VirtualKeys.LAUNCH_MAIL: //Start Mail key
                //case VirtualKeys.LAUNCH_MEDIA_SELECT: //Select Media key
                //case VirtualKeys.LAUNCH_APP1: //Start Application 1 key
                //case VirtualKeys.LAUNCH_APP2: //Start Application 2 key
                // 0xB8-B9 Reserved
                case VirtualKeys.OEM_1: return Key.Oem1; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ';: ' key
                case VirtualKeys.OEM_PLUS: return Key.Plus; //For any country/region, the '+' key
                case VirtualKeys.OEM_COMMA: return Key.Comma; //For any country/region, the ',' key
                case VirtualKeys.OEM_MINUS: return Key.Minus; //For any country/region, the '// -' key
                case VirtualKeys.OEM_PERIOD: return Key.Period; //For any country/region, the '.' key
                case VirtualKeys.OEM_2: return Key.Oem2; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '/?' key
                case VirtualKeys.OEM_3: return Key.Oem3; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '`~' key
                // 0xC1-D7 Reserved
                // 0xD8-DA Unassigned
                case VirtualKeys.OEM_4: return Key.Oem4; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '[{' key
                case VirtualKeys.OEM_5: return Key.Oem5; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '\|' key
                case VirtualKeys.OEM_6: return Key.Oem6; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ']}' key
                case VirtualKeys.OEM_7: return Key.Oem7; //Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key
                case VirtualKeys.OEM_8: return Key.Oem8; //Used for miscellaneous characters; it can vary by keyboard.
                // 0xE0 Reserved
                // 0xE1 OEM specific
                case VirtualKeys.OEM_102: return Key.Oem102; //Either the angle bracket key or the backslash key on the RT 102-key keyboard
                // 0xE3-E4 OEM specific
                //case VirtualKeys.PROCESSKEY: //IME PROCESS key
                // 0xE6 OEM specific
                //case VirtualKeys.PACKET: //Used to pass Unicode characters as if they were keystrokes. The case VirtualKeys.PACKET: key is the low word of a 32-bit Virtual Key value used for non-keyboard input methods. For more information, see Remark in KEYBDINPUT, SendInput, WM_KEYDOWN, and WM_KEYUP
                // 0xE8 Unassigned
                // 0xE9-F5 OEM specific
                //case VirtualKeys.ATTN: //Attn key
                //case VirtualKeys.CRSEL: //CrSel key
                //case VirtualKeys.EXSEL: //ExSel key
                //case VirtualKeys.EREOF: //Erase EOF key
                //case VirtualKeys.PLAY: //Play key
                //case VirtualKeys.ZOOM: //Zoom key
                //case VirtualKeys.NONAME: //Reserved
                //case VirtualKeys.PA1: //PA1 key
                //case VirtualKeys.OEM_CLEAR: //Clear key
            }

            return Key.Unknown;
        }

        public static Key TranslateKey(int scancode, VirtualKeys vkey, bool extended0, bool extended1)
        {
            // Starting with Windows Vista, the high byte of the uCode value 
            // can contain either 0xe0 or 0xe1 to specify the extended scan code.
            scancode |= (int)(extended0 ? 0xE000 : 0);
            scancode |= (int)(extended1 ? 0xE100 : 0);

            // Map the scan code to a virtual key, we can't just use vkey passed 
            // in by windows message here as that isn't decoded taking the 
            // extended bit into account.
            VirtualKeys mapped_vkey = (VirtualKeys)Functions.MapVirtualKey(
                (uint)scancode, MapVirtualKeyType.ScanCodeToVirtualKeyExtended);

            // Some keys aren't handled by MapVirtualKey, so we translate them
            // here checking against the extended flags and original virtual
            // key code them up here
            if (extended0)
            {
                if(vkey == VirtualKeys.NUMLOCK)
                {
                    // NumLock has extended bit set and isn't translated at all 
                    // by MapVirtualKey (it returns zero), but the standard 
                    // vkey reports numlock correctly.
                    return Key.NumLock;
                }

                // The following have left/right keys based on extended bit 
                // being set but for some reason MapVirtualKey doesn't 
                // translate them.
                switch (mapped_vkey)
                {
                    case VirtualKeys.RETURN:
                        // Keypad enter key has extended bit set
                        return Key.KeypadEnter;
                    case VirtualKeys.MENU:
                        // RAlt has extended bit set
                        return Key.RAlt;
                }
            }
            else
            {
                switch (mapped_vkey)
                {
                    // MapVirtualKey translates numpad keys to the function keys, we map back to the numpad keys.
                    case VirtualKeys.INSERT: return Key.Keypad0;
                    case VirtualKeys.END: return Key.Keypad1;
                    case VirtualKeys.DOWN: return Key.Keypad2;
                    case VirtualKeys.NEXT: return Key.Keypad3;
                    case VirtualKeys.LEFT: return Key.Keypad4;
                    case VirtualKeys.CLEAR: return Key.Keypad5;
                    case VirtualKeys.RIGHT: return Key.Keypad6;
                    case VirtualKeys.HOME: return Key.Keypad7;
                    case VirtualKeys.UP: return Key.Keypad8;
                    case VirtualKeys.PRIOR: return Key.Keypad9;
                    case VirtualKeys.DELETE: return Key.KeypadPeriod;

                    // Pause is mapped to numlock by MapVirtualKey, map it back to pause
                    case VirtualKeys.NUMLOCK: return Key.Pause;
                }
            }

            // Translate windows virtual key into our Key type.
            return WinKeyMap.TranslateKey(mapped_vkey);
        }
    }
}
