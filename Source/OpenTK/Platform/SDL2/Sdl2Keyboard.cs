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
    class Sdl2Keyboard : IKeyboardDriver2, IKeyboardDriver
    {
        KeyboardState state;

        readonly List<KeyboardDevice> keyboards =
            new List<KeyboardDevice>();
        readonly IList<KeyboardDevice> keyboards_readonly;

        public Sdl2Keyboard()
        {
            state.IsConnected = true;

            keyboards.Add(new KeyboardDevice());
            keyboards[0].Description = "Standard keyboard";
            keyboards[0].NumberOfFunctionKeys = 12;
            keyboards[0].NumberOfKeys = 101;
            keyboards[0].NumberOfLeds = 3;
            keyboards_readonly = keyboards.AsReadOnly();
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
            Keymod mod = SDL.GetModState();

            state.SetKeyState(Key.LAlt, (byte)Scancode.LALT, (mod & Keymod.LALT) != 0);
            state.SetKeyState(Key.RAlt, (byte)Scancode.RALT, (mod & Keymod.RALT) != 0);
            state.SetKeyState(Key.LControl, (byte)Scancode.LCTRL, (mod & Keymod.LCTRL) != 0);
            state.SetKeyState(Key.RControl, (byte)Scancode.RCTRL, (mod & Keymod.CTRL) != 0);
            state.SetKeyState(Key.LShift, (byte)Scancode.LSHIFT, (mod & Keymod.LSHIFT) != 0);
            state.SetKeyState(Key.RShift, (byte)Scancode.RSHIFT, (mod & Keymod.RSHIFT) != 0);
            state.SetKeyState(Key.Menu, (byte)Scancode.APPLICATION, (mod & Keymod.GUI) != 0);
            state.SetKeyState(Key.CapsLock, (byte)Scancode.CAPSLOCK, (mod & Keymod.CAPS) != 0);
            state.SetKeyState(Key.NumLock, (byte)Scancode.NUMLOCKCLEAR, (mod & Keymod.NUM) != 0);
            //state.SetKeyState(Key., (byte)Scancode.MODE, (mod & Keymod.MODE) != 0);
        }

        #endregion

        #region Internal Members

        internal void ProcessKeyboardEvent(KeyboardEvent e)
        {
            bool pressed = e.State != 0;
            var scancode = e.Keysym.Scancode;
            Key key = Sdl2KeyMap.GetKey(scancode);
            if (key != Key.Unknown)
            {
                state.SetKeyState(key, (byte)scancode, pressed);
                keyboards[0].SetKey(key, (byte)scancode, pressed);
            }
        }

        #endregion

        #region IKeyboardDriver Members

        public IList<KeyboardDevice> Keyboard
        {
            get
            {
                return keyboards_readonly;
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

