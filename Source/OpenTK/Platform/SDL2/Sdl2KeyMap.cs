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
    using Code = SDL.SDL_Scancode;

    class Sdl2KeyMap : Dictionary<SDL.SDL_Scancode, Key> 
    {
        public Sdl2KeyMap()
        {
            Add(Code.SDL_SCANCODE_ESCAPE, Key.Escape);

            // Function keys
            for (int i = 0; i < 12; i++)
            {
                Add(Code.SDL_SCANCODE_F1 + i, Key.F1 + i);
            }

            // Number keys (0-9)
            Add(Code.SDL_SCANCODE_0, Key.Number0);
            for (int i = 1; i < 9; i++)
            {
                Add(Code.SDL_SCANCODE_1 + i, Key.Number1 + i);
            }

            // Letters (A-Z)
            for (int i = 0; i < 26; i++)
            {
                Add(Code.SDL_SCANCODE_A + i, Key.A + i);
            }

            Add(Code.SDL_SCANCODE_TAB, Key.Tab);
            Add(Code.SDL_SCANCODE_CAPSLOCK, Key.CapsLock);
            Add(Code.SDL_SCANCODE_LCTRL, Key.ControlLeft);
            Add(Code.SDL_SCANCODE_LSHIFT, Key.ShiftLeft);
            Add(Code.SDL_SCANCODE_LALT, Key.WinLeft);
            Add(Code.SDL_SCANCODE_MENU, Key.AltLeft);
            Add(Code.SDL_SCANCODE_SPACE, Key.Space);
            Add(Code.SDL_SCANCODE_RALT, Key.AltRight);
            //Add(Code., Key.WinRight);
            Add(Code.SDL_SCANCODE_APPLICATION, Key.Menu);
            Add(Code.SDL_SCANCODE_RCTRL, Key.ControlRight);
            Add(Code.SDL_SCANCODE_RSHIFT, Key.ShiftRight);
            Add(Code.SDL_SCANCODE_RETURN, Key.Enter);
            Add(Code.SDL_SCANCODE_BACKSPACE, Key.BackSpace);

            Add(Code.SDL_SCANCODE_SEMICOLON, Key.Semicolon);      // Varies by keyboard, ;: on Win2K/US
            Add(Code.SDL_SCANCODE_SLASH, Key.Slash);          // Varies by keyboard, /? on Win2K/US
            //Add(Code., Key.Tilde);          // Varies by keyboard, `~ on Win2K/US
            Add(Code.SDL_SCANCODE_LEFTBRACKET, Key.BracketLeft);    // Varies by keyboard, [{ on Win2K/US
            Add(Code.SDL_SCANCODE_BACKSLASH, Key.BackSlash);      // Varies by keyboard, \| on Win2K/US
            Add(Code.SDL_SCANCODE_RIGHTBRACKET, Key.BracketRight);   // Varies by keyboard, ]} on Win2K/US
            Add(Code.SDL_SCANCODE_APOSTROPHE, Key.Quote);          // Varies by keyboard, '" on Win2K/US
            Add(Code.SDL_SCANCODE_EQUALS, Key.Plus);
            Add(Code.SDL_SCANCODE_COMMA, Key.Comma);      // Invariant: ,
            Add(Code.SDL_SCANCODE_MINUS, Key.Minus);      // Invariant: -
            Add(Code.SDL_SCANCODE_PERIOD, Key.Period);    // Invariant: .

            Add(Code.SDL_SCANCODE_HOME, Key.Home);
            Add(Code.SDL_SCANCODE_END, Key.End);
            Add(Code.SDL_SCANCODE_DELETE, Key.Delete);
            Add(Code.SDL_SCANCODE_PAGEUP, Key.PageUp);
            Add(Code.SDL_SCANCODE_PAGEDOWN, Key.PageDown);
            Add(Code.SDL_SCANCODE_PAUSE, Key.Pause);
            Add(Code.SDL_SCANCODE_NUMLOCKCLEAR, Key.NumLock);

            Add(Code.SDL_SCANCODE_SCROLLLOCK, Key.ScrollLock);
            Add(Code.SDL_SCANCODE_PRINTSCREEN, Key.PrintScreen);
            Add(Code.SDL_SCANCODE_CLEAR, Key.Clear);
            Add(Code.SDL_SCANCODE_INSERT, Key.Insert);

            Add(Code.SDL_SCANCODE_SLEEP, Key.Sleep);

            // Keypad
            for (int i = 0; i < 9; i++)
            {
                Add(Code.SDL_SCANCODE_KP_1 + i, Key.Keypad1 + i);
            }
            Add(Code.SDL_SCANCODE_KP_0, Key.Keypad0); // Note: SDL2 goes KP_1..KP_9, then KP_0

            Add(Code.SDL_SCANCODE_KP_DECIMAL, Key.KeypadDecimal);
            Add(Code.SDL_SCANCODE_KP_PLUS, Key.KeypadAdd);
            Add(Code.SDL_SCANCODE_KP_MINUS, Key.KeypadSubtract);
            Add(Code.SDL_SCANCODE_KP_DIVIDE, Key.KeypadDivide);
            Add(Code.SDL_SCANCODE_KP_MULTIPLY, Key.KeypadMultiply);

            // Navigation
            Add(Code.SDL_SCANCODE_UP, Key.Up);
            Add(Code.SDL_SCANCODE_DOWN, Key.Down);
            Add(Code.SDL_SCANCODE_LEFT, Key.Left);
            Add(Code.SDL_SCANCODE_RIGHT, Key.Right);
        }
    }
}

