// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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

