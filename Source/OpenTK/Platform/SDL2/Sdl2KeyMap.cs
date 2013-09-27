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
    using Code = SDL.SDL_Keycode;

    class Sdl2KeyMap : Dictionary<SDL.SDL_Keycode, Key> 
    {
        public Sdl2KeyMap()
        {
            Add(Code.SDLK_ESCAPE, Key.Escape);

            // Function keys
            for (int i = 0; i < 12; i++)
            {
                Add(Code.SDLK_F1 + i, Key.F1 + i);
            }

            // Number keys (0-9)
            for (int i = 0; i <= 9; i++)
            {
                Add(Code.SDLK_0 + i, Key.Number0 + i);
            }

            // Letters (A-Z)
            for (int i = 0; i < 26; i++)
            {
                Add(Code.SDLK_a + i, Key.A + i);
            }

            Add(Code.SDLK_TAB, Key.Tab);
            Add(Code.SDLK_CAPSLOCK, Key.CapsLock);
            Add(Code.SDLK_LCTRL, Key.ControlLeft);
            Add(Code.SDLK_LSHIFT, Key.ShiftLeft);
            Add(Code.SDLK_LALT, Key.WinLeft);
            Add(Code.SDLK_MENU, Key.AltLeft);
            Add(Code.SDLK_SPACE, Key.Space);
            Add(Code.SDLK_RALT, Key.AltRight);
            //Add(Code., Key.WinRight);
            Add(Code.SDLK_APPLICATION, Key.Menu);
            Add(Code.SDLK_RCTRL, Key.ControlRight);
            Add(Code.SDLK_RSHIFT, Key.ShiftRight);
            Add(Code.SDLK_RETURN, Key.Enter);
            Add(Code.SDLK_BACKSPACE, Key.BackSpace);

            Add(Code.SDLK_SEMICOLON, Key.Semicolon);      // Varies by keyboard, ;: on Win2K/US
            Add(Code.SDLK_SLASH, Key.Slash);          // Varies by keyboard, /? on Win2K/US
            //Add(Code., Key.Tilde);          // Varies by keyboard, `~ on Win2K/US
            Add(Code.SDLK_LEFTBRACKET, Key.BracketLeft);    // Varies by keyboard, [{ on Win2K/US
            Add(Code.SDLK_BACKSLASH, Key.BackSlash);      // Varies by keyboard, \| on Win2K/US
            Add(Code.SDLK_RIGHTBRACKET, Key.BracketRight);   // Varies by keyboard, ]} on Win2K/US
            Add(Code.SDLK_QUOTE, Key.Quote);          // Varies by keyboard, '" on Win2K/US
            Add(Code.SDLK_PLUS, Key.Plus);        // Invariant: +
            Add(Code.SDLK_COMMA, Key.Comma);      // Invariant: ,
            Add(Code.SDLK_MINUS, Key.Minus);      // Invariant: -
            Add(Code.SDLK_PERIOD, Key.Period);    // Invariant: .

            Add(Code.SDLK_HOME, Key.Home);
            Add(Code.SDLK_END, Key.End);
            Add(Code.SDLK_DELETE, Key.Delete);
            Add(Code.SDLK_PAGEUP, Key.PageUp);
            Add(Code.SDLK_PAGEDOWN, Key.PageDown);
            Add(Code.SDLK_PAUSE, Key.Pause);
            Add(Code.SDLK_NUMLOCKCLEAR, Key.NumLock);

            Add(Code.SDLK_SCROLLLOCK, Key.ScrollLock);
            Add(Code.SDLK_PRINTSCREEN, Key.PrintScreen);
            Add(Code.SDLK_CLEAR, Key.Clear);
            Add(Code.SDLK_INSERT, Key.Insert);

            Add(Code.SDLK_SLEEP, Key.Sleep);

            // Keypad
            for (int i = 0; i < 9; i++)
            {
                Add(Code.SDLK_KP_1 + i, Key.Keypad1 + i);
            }
            Add(Code.SDLK_KP_0, Key.Keypad0); // Note: SDL2 goes KP_1..KP_9, then KP_0

            Add(Code.SDLK_KP_DECIMAL, Key.KeypadDecimal);
            Add(Code.SDLK_KP_PLUS, Key.KeypadAdd);
            Add(Code.SDLK_KP_MINUS, Key.KeypadSubtract);
            Add(Code.SDLK_KP_DIVIDE, Key.KeypadDivide);
            Add(Code.SDLK_KP_MULTIPLY, Key.KeypadMultiply);

            // Navigation
            Add(Code.SDLK_UP, Key.Up);
            Add(Code.SDLK_DOWN, Key.Down);
            Add(Code.SDLK_LEFT, Key.Left);
            Add(Code.SDLK_RIGHT, Key.Right);
        }
    }
}

