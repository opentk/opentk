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
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Keyboard : IKeyboardDriver2
    {
        static readonly Sdl2KeyMap KeyMap = new Sdl2KeyMap();
        KeyboardState state;

        public Sdl2Keyboard()
        {
            state.IsConnected = true;
        }

        #region Private Members

        // Unfortunately, SDL does not report KeyDown events
        // when a modifier (e.g. shift, alt, etc) is first pressed.
        // It reports a keydown+keyup event pair when the modifier
        // is *released* - which means that we cannot use modifiers
        // for regular input (e.g. press control to fire a weapon.)
        // For that reason, we should also poll the keyboard directly
        // as necessary.
        // Fixme: this does not appear to work as expected.
        void UpdateModifiers()
        {
            SDL.SDL_Keymod mod = SDL.SDL_GetModState();

            state.SetKeyState(Key.LAlt, (byte)SDL.SDL_Scancode.SDL_SCANCODE_LALT, (mod & SDL.SDL_Keymod.KMOD_LALT) != 0);
            state.SetKeyState(Key.RAlt, (byte)SDL.SDL_Scancode.SDL_SCANCODE_RALT, (mod & SDL.SDL_Keymod.KMOD_RALT) != 0);
            state.SetKeyState(Key.LControl, (byte)SDL.SDL_Scancode.SDL_SCANCODE_LCTRL, (mod & SDL.SDL_Keymod.KMOD_LCTRL) != 0);
            state.SetKeyState(Key.RControl, (byte)SDL.SDL_Scancode.SDL_SCANCODE_RCTRL, (mod & SDL.SDL_Keymod.KMOD_RCTRL) != 0);
            state.SetKeyState(Key.LShift, (byte)SDL.SDL_Scancode.SDL_SCANCODE_LSHIFT, (mod & SDL.SDL_Keymod.KMOD_LSHIFT) != 0);
            state.SetKeyState(Key.RShift, (byte)SDL.SDL_Scancode.SDL_SCANCODE_RSHIFT, (mod & SDL.SDL_Keymod.KMOD_RSHIFT) != 0);
            state.SetKeyState(Key.Menu, (byte)SDL.SDL_Scancode.SDL_SCANCODE_APPLICATION, (mod & SDL.SDL_Keymod.KMOD_GUI) != 0);
            state.SetKeyState(Key.CapsLock, (byte)SDL.SDL_Scancode.SDL_SCANCODE_CAPSLOCK, (mod & SDL.SDL_Keymod.KMOD_CAPS) != 0);
            state.SetKeyState(Key.NumLock, (byte)SDL.SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR, (mod & SDL.SDL_Keymod.KMOD_NUM) != 0);
            //state.SetKeyState(Key., (byte)SDL.SDL_Scancode.SDL_SCANCODE_MODE, (mod & SDL.SDL_Keymod.KMOD_MODE) != 0);
        }

        #endregion

        #region Internal Members

        internal void ProcessKeyboardEvent(SDL.SDL_KeyboardEvent e)
        {
            Key key;
            bool pressed = e.state != 0;
            if (KeyMap.TryGetValue(e.keysym.scancode, out key))
            {
                state.SetKeyState(key, (byte)e.keysym.scancode, pressed);
            }
        }

        #endregion

        #region IKeyboardDriver2 Members

        public KeyboardState GetState()
        {
            //UpdateModifiers(); // Fixme
            return state;
        }

        public KeyboardState GetState(int index)
        {
            //UpdateModifiers(); // Fixme
            if (index == 0)
                return state;
            else
                return new KeyboardState();
        }

        public string GetDeviceName(int index)
        {
            return "SDL2 Default Keyboard";
        }

        #endregion
    }
}

