#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit library.
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
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    using Code = Scancode;

    class Sdl2KeyMap : Dictionary<Scancode, Key> 
    {
        public Sdl2KeyMap()
        {
            Add(Code.ESCAPE, Key.Escape);

            // Function keys
            for (int i = 0; i < 12; i++)
            {
                Add(Code.F1 + i, Key.F1 + i);
            }

            // Number keys (0-9)
            Add(Code.Num0, Key.Number0);
            for (int i = 0; i < 9; i++)
            {
                Add(Code.Num1 + i, Key.Number1 + i);
            }

            // Letters (A-Z)
            for (int i = 0; i < 26; i++)
            {
                Add(Code.A + i, Key.A + i);
            }

            Add(Code.TAB, Key.Tab);
            Add(Code.CAPSLOCK, Key.CapsLock);
            Add(Code.LCTRL, Key.ControlLeft);
            Add(Code.LSHIFT, Key.ShiftLeft);
            Add(Code.LALT, Key.WinLeft);
            Add(Code.MENU, Key.AltLeft);
            Add(Code.SPACE, Key.Space);
            Add(Code.RALT, Key.AltRight);
            //Add(Code., Key.WinRight);
            Add(Code.APPLICATION, Key.Menu);
            Add(Code.RCTRL, Key.ControlRight);
            Add(Code.RSHIFT, Key.ShiftRight);
            Add(Code.RETURN, Key.Enter);
            Add(Code.BACKSPACE, Key.BackSpace);

            Add(Code.SEMICOLON, Key.Semicolon);      // Varies by keyboard, ;: on Win2K/US
            Add(Code.SLASH, Key.Slash);          // Varies by keyboard, /? on Win2K/US
            Add(Code.GRAVE, Key.Tilde);          // Varies by keyboard, `~ on Win2K/US
            Add(Code.LEFTBRACKET, Key.BracketLeft);    // Varies by keyboard, [{ on Win2K/US
            Add(Code.BACKSLASH, Key.BackSlash);      // Varies by keyboard, \| on Win2K/US
            Add(Code.RIGHTBRACKET, Key.BracketRight);   // Varies by keyboard, ]} on Win2K/US
            Add(Code.APOSTROPHE, Key.Quote);          // Varies by keyboard, '" on Win2K/US
            Add(Code.EQUALS, Key.Plus);
            Add(Code.COMMA, Key.Comma);      // Invariant: ,
            Add(Code.MINUS, Key.Minus);      // Invariant: -
            Add(Code.PERIOD, Key.Period);    // Invariant: .

            Add(Code.HOME, Key.Home);
            Add(Code.END, Key.End);
            Add(Code.DELETE, Key.Delete);
            Add(Code.PAGEUP, Key.PageUp);
            Add(Code.PAGEDOWN, Key.PageDown);
            Add(Code.PAUSE, Key.Pause);
            Add(Code.NUMLOCKCLEAR, Key.NumLock);

            Add(Code.SCROLLLOCK, Key.ScrollLock);
            Add(Code.PRINTSCREEN, Key.PrintScreen);
            Add(Code.CLEAR, Key.Clear);
            Add(Code.INSERT, Key.Insert);

            Add(Code.SLEEP, Key.Sleep);

            // Keypad
            for (int i = 0; i < 9; i++)
            {
                Add(Code.KP_1 + i, Key.Keypad1 + i);
            }
            Add(Code.KP_0, Key.Keypad0); // Note: SDL2 goes KP_1..KP_9, then KP_0

            Add(Code.KP_DECIMAL, Key.KeypadDecimal);
            Add(Code.KP_PLUS, Key.KeypadAdd);
            Add(Code.KP_MINUS, Key.KeypadSubtract);
            Add(Code.KP_DIVIDE, Key.KeypadDivide);
            Add(Code.KP_MULTIPLY, Key.KeypadMultiply);

            // Navigation
            Add(Code.UP, Key.Up);
            Add(Code.DOWN, Key.Down);
            Add(Code.LEFT, Key.Left);
            Add(Code.RIGHT, Key.Right);
        }
    }
}

