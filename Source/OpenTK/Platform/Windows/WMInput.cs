#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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
#if !MINIMAL
using System.Drawing;
#endif
using System.Threading;
using System.Text;

using OpenTK.Input;


namespace OpenTK.Platform.Windows
{
    // Input driver for legacy (pre XP) Windows platforms.
    // Supports a single mouse and keyboard through async input.
    // Supports multiple joysticks through WinMM.
    sealed class WMInput : IInputDriver2, IMouseDriver2, IKeyboardDriver2, IGamePadDriver
    {
        #region Fields

        readonly object MouseLock = new object();
        readonly object KeyboardLock = new object();
        readonly WinMMJoystick gamepad_driver = new WinMMJoystick();
        KeyboardState keyboard = new KeyboardState();
        MouseState mouse = new MouseState();

        readonly WinKeyMap KeyMap = new WinKeyMap();

        #endregion

        #region Constructor

        public WMInput()
            : base()
        {
            Debug.WriteLine("Using WMInput.");
        }

        #endregion

        #region Private Members

        void UpdateKeyboard()
        {
            for (int i = 0; i < 256; i++)
            {
                VirtualKeys key = (VirtualKeys)i;
                bool pressed = (Functions.GetAsyncKeyState(key) >> 8) != 0;
                if (KeyMap.ContainsKey(key))
                {
                        keyboard[KeyMap[key]] = pressed;
                }
            }
        }

        void UpdateMouse()
        {
            POINT p = new POINT();
            Functions.GetCursorPos(ref p);
            mouse.X = p.X;
            mouse.Y = p.Y;
            // Note: we cannot poll the mouse wheel
            mouse[MouseButton.Left] = (Functions.GetAsyncKeyState(VirtualKeys.LBUTTON) >> 8) != 0;
            mouse[MouseButton.Middle] = (Functions.GetAsyncKeyState(VirtualKeys.RBUTTON) >> 8) != 0;
            mouse[MouseButton.Right] = (Functions.GetAsyncKeyState(VirtualKeys.MBUTTON) >> 8) != 0;
            mouse[MouseButton.Button1] = (Functions.GetAsyncKeyState(VirtualKeys.XBUTTON1) >> 8) != 0;
            mouse[MouseButton.Button2] = (Functions.GetAsyncKeyState(VirtualKeys.XBUTTON2) >> 8) != 0;
        }

        #endregion

        #region IInputDriver2 Members

        public IKeyboardDriver2 KeyboardDriver
        {
            get { return this; }
        }

        public IMouseDriver2 MouseDriver
        {
            get { return this; }
        }

        public IGamePadDriver GamePadDriver
        {
            get { return this; }
        }

        #endregion

        #region IMouseDriver2 Members

        public MouseState GetState()
        {
            lock (MouseLock)
            {
                UpdateMouse();
                return mouse;
            }
        }

        public MouseState GetState(int index)
        {
            lock (MouseLock)
            {
                UpdateMouse();
                if (index == 0)
                    return mouse;
                else
                    return new MouseState();
            }
        }

        public void SetPosition(double x, double y)
        {
            Functions.SetCursorPos((int)x, (int)y);
        }

        #endregion

        #region IKeyboardDriver2 Members

        KeyboardState IKeyboardDriver2.GetState()
        {
            lock (KeyboardLock)
            {
                UpdateKeyboard();
                return keyboard;
            }
        }

        KeyboardState IKeyboardDriver2.GetState(int index)
        {
            lock (KeyboardLock)
            {
                UpdateKeyboard();
                if (index == 0)
                    return keyboard;
                else
                    return new KeyboardState();
            }
        }

        string IKeyboardDriver2.GetDeviceName(int index)
        {
            return "Default Windows Keyboard";
        }

        #endregion
    }
}
