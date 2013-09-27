using System;
using System.Collections.Generic;
using OpenTK.Input;

namespace OpenTK.Platform.SDL2
{
    class Sdl2Joystick : IJoystickDriver, IGamePadDriver
    {
        readonly List<JoystickDevice> joysticks = new List<JoystickDevice>();
        IList<JoystickDevice> joysticks_readonly;

        public Sdl2Joystick()
        {
            joysticks_readonly = joysticks.AsReadOnly();
        }

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get
            {
                return joysticks_readonly;
            }
        }

        #endregion

        #region IGamePadDriver Members

        public GamePadState GetState()
        {
            throw new NotImplementedException();
        }

        public GamePadState GetState(int index)
        {
            throw new NotImplementedException();
        }

        public string GetDeviceName(int index)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

