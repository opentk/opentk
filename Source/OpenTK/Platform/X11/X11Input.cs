#region License
//
// X11Input.cs
//
// Author:
//       thefiddler <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using OpenTK.Input;

namespace OpenTK.Platform.X11
{
    class X11Input : IInputDriver2
    {
        readonly X11Mouse mouse = new X11Mouse();
        readonly X11Keyboard keyboard = new X11Keyboard();
        readonly Linux.LinuxJoystick joystick = new Linux.LinuxJoystick();
        readonly IGamePadDriver gamepad = new MappedGamePadDriver();

        internal X11Input()
        {
            Debug.WriteLine("Using X11 core input driver.");
            Debug.WriteLine("[Warning] Mouse functionality will be significantly reduced.");
            Debug.WriteLine("[Warning] Copy OpenTK.dll.config to use the XI2 input driver instead.");
        }

        #region IInputDriver2 Members

        public IMouseDriver2 MouseDriver
        {
            get
            {
                return mouse;
            }
        }

        public IKeyboardDriver2 KeyboardDriver
        {
            get
            {
                return keyboard;
            }
        }

        public IGamePadDriver GamePadDriver
        {
            get
            {
                return gamepad;
            }
        }

        public IJoystickDriver2 JoystickDriver
        {
            get
            {
                return joystick;
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            joystick.Dispose();
        }

        #endregion

    }
}

