using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Input;

    class MacOSKeyMap : Dictionary<MacOSKeyCode, Key>
    {
        public MacOSKeyMap()
        {
            // comments indicate members of the Key enum that are missing

            Add(MacOSKeyCode.A, Key.A);
            // AltLeft
            // AltRight
            Add(MacOSKeyCode.B, Key.B);
            
            Add(MacOSKeyCode.Backslash, Key.BackSlash);
            Add(MacOSKeyCode.Backspace, Key.BackSpace);
            Add(MacOSKeyCode.BracketLeft, Key.BracketLeft);
            Add(MacOSKeyCode.BracketRight, Key.BracketRight);
            Add(MacOSKeyCode.C, Key.C);
            // Capslock
            // Clear
            Add(MacOSKeyCode.Comma, Key.Comma);
            // ControlLeft 
            // ControlRight
            Add(MacOSKeyCode.D, Key.D);
            Add(MacOSKeyCode.Del, Key.Delete);
            Add(MacOSKeyCode.Down, Key.Down);
            Add(MacOSKeyCode.E, Key.E);
            Add(MacOSKeyCode.End, Key.End);
            Add(MacOSKeyCode.Enter, Key.Enter);
            Add(MacOSKeyCode.Return, Key.Enter);
            Add(MacOSKeyCode.Esc, Key.Escape);
            Add(MacOSKeyCode.F, Key.F);
            Add(MacOSKeyCode.F1, Key.F1);
            Add(MacOSKeyCode.F2, Key.F2);
            Add(MacOSKeyCode.F3, Key.F3);
            Add(MacOSKeyCode.F4, Key.F4);
            Add(MacOSKeyCode.F5, Key.F5);
            Add(MacOSKeyCode.F6, Key.F6);
            Add(MacOSKeyCode.F7, Key.F7);
            Add(MacOSKeyCode.F8, Key.F8);
            Add(MacOSKeyCode.F9, Key.F9);
            Add(MacOSKeyCode.F10, Key.F10);
            Add(MacOSKeyCode.F11, Key.F11);
            Add(MacOSKeyCode.F12, Key.F12);
            Add(MacOSKeyCode.F13, Key.F13);
            Add(MacOSKeyCode.F14, Key.F14);
            Add(MacOSKeyCode.F15, Key.F15);
            // F16-F35
            Add(MacOSKeyCode.G, Key.G);
            Add(MacOSKeyCode.H, Key.H);
            Add(MacOSKeyCode.Home, Key.Home);
            Add(MacOSKeyCode.I, Key.I);
            Add(MacOSKeyCode.Insert, Key.Insert);
            Add(MacOSKeyCode.J, Key.J);
            Add(MacOSKeyCode.K, Key.K);
            Add(MacOSKeyCode.KeyPad_0, Key.Keypad0);
            Add(MacOSKeyCode.KeyPad_1, Key.Keypad1);
            Add(MacOSKeyCode.KeyPad_2, Key.Keypad2);
            Add(MacOSKeyCode.KeyPad_3, Key.Keypad3);
            Add(MacOSKeyCode.KeyPad_4, Key.Keypad4);
            Add(MacOSKeyCode.KeyPad_5, Key.Keypad5);
            Add(MacOSKeyCode.KeyPad_6, Key.Keypad6);
            Add(MacOSKeyCode.KeyPad_7, Key.Keypad7);
            Add(MacOSKeyCode.KeyPad_8, Key.Keypad8);
            Add(MacOSKeyCode.KeyPad_9, Key.Keypad9);
            Add(MacOSKeyCode.KeyPad_Add, Key.KeypadAdd);
            Add(MacOSKeyCode.KeyPad_Decimal, Key.KeypadDecimal);
            Add(MacOSKeyCode.KeyPad_Divide, Key.KeypadDivide);
            Add(MacOSKeyCode.KeyPad_Enter, Key.KeypadEnter);
            Add(MacOSKeyCode.KeyPad_Multiply, Key.KeypadMultiply);
            Add(MacOSKeyCode.KeyPad_Subtract, Key.KeypadSubtract);
            //Add(MacOSKeyCode.KeyPad_Equal);
            Add(MacOSKeyCode.L, Key.L);
            Add(MacOSKeyCode.Left, Key.Left);
            Add(MacOSKeyCode.M, Key.M);
            //Key.MaxKeys 
            Add(MacOSKeyCode.Menu, Key.Menu);
            Add(MacOSKeyCode.Minus, Key.Minus);
            Add(MacOSKeyCode.N, Key.N);
            Add(MacOSKeyCode.Key_0, Key.Number0);
            Add(MacOSKeyCode.Key_1, Key.Number1);
            Add(MacOSKeyCode.Key_2, Key.Number2);
            Add(MacOSKeyCode.Key_3, Key.Number3);
            Add(MacOSKeyCode.Key_4, Key.Number4);
            Add(MacOSKeyCode.Key_5, Key.Number4);
            Add(MacOSKeyCode.Key_6, Key.Number5);
            Add(MacOSKeyCode.Key_7, Key.Number6);
            Add(MacOSKeyCode.Key_8, Key.Number7);
            Add(MacOSKeyCode.Key_9, Key.Number9);
            // Numlock
            Add(MacOSKeyCode.O, Key.O);
            Add(MacOSKeyCode.P, Key.P);
            Add(MacOSKeyCode.Pagedown, Key.PageDown);
            Add(MacOSKeyCode.Pageup, Key.PageUp);
            // Pause
            Add(MacOSKeyCode.Period, Key.Period);
            Add(MacOSKeyCode.Equals, Key.Plus);
            // PrintScreen
            Add(MacOSKeyCode.Q, Key.Q);
            Add(MacOSKeyCode.Quote, Key.Quote);
            Add(MacOSKeyCode.R, Key.R);
            Add(MacOSKeyCode.Right, Key.Right);
            Add(MacOSKeyCode.S, Key.S);
            // ScrollLock
            Add(MacOSKeyCode.Semicolon, Key.Semicolon);
            //Key.ShiftLeft 
            //Key.ShiftRight 
            Add(MacOSKeyCode.Slash, Key.Slash);
            // Key.Sleep
            Add(MacOSKeyCode.Space, Key.Space);
            Add(MacOSKeyCode.T, Key.T);
            Add(MacOSKeyCode.Tab, Key.Tab);
            Add(MacOSKeyCode.Tilde, Key.Tilde);
            Add(MacOSKeyCode.U, Key.U);
            Add(MacOSKeyCode.Up, Key.Up);
            Add(MacOSKeyCode.V, Key.V);
            Add(MacOSKeyCode.W, Key.W);
            // WinKeyLeft
            // WinKeyRight
            Add(MacOSKeyCode.X, Key.X);
            Add(MacOSKeyCode.Y, Key.Y);
            Add(MacOSKeyCode.Z, Key.Z);

        }
    }
}
