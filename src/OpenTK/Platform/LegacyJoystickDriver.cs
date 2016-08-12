#region License
//
// LegacyJoystickDriver.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
using System.Collections.Generic;
using OpenTK.Input;

namespace OpenTK.Platform
{
    [Obsolete]
    internal class LegacyJoystickDriver : IJoystickDriver
    {
        static readonly string ConnectedName = "Connected Joystick";
        static readonly string DisconnectedName = "Disconnected Joystick";
        readonly List<JoystickDevice> joysticks = new List<JoystickDevice>();
        readonly IList<JoystickDevice> joysticks_readonly;

        class LegacyJoystickDevice : JoystickDevice
        {
            public LegacyJoystickDevice(int id, int axes, int buttons)
                : base(id, axes, buttons)
            { }
        }

        internal LegacyJoystickDriver()
        {
            joysticks_readonly = joysticks.AsReadOnly();
            for (int i = 0; i < 4; i++)
            {
                joysticks.Add(new LegacyJoystickDevice(i, 0, 0));
                joysticks[i].Description = DisconnectedName;
            }
        }

        public void Poll()
        {
            for (int i = 0; i < 4; i++)
            {
                JoystickCapabilities caps = Joystick.GetCapabilities(i);
                if (caps.IsConnected && joysticks[i].Description == DisconnectedName)
                {
                    // New joystick connected
                    joysticks[i] = new LegacyJoystickDevice(
                        i,
                        caps.AxisCount + 2 * caps.HatCount,
                        caps.ButtonCount);
                    //device.Description = Joystick.GetName(i);
                    joysticks[i].Description = ConnectedName;
                    
                }
                else if (!caps.IsConnected && joysticks[i].Description != DisconnectedName)
                {
                    // Joystick disconnected
                    joysticks[i] = new LegacyJoystickDevice(i, 0, 0);
                    joysticks[i].Description = DisconnectedName;
                }

                JoystickState state = Joystick.GetState(i);
                for (int axis_index = 0; axis_index < caps.AxisCount; axis_index++)
                {
                    JoystickAxis axis = JoystickAxis.Axis0 + axis_index;
                    joysticks[i].SetAxis(axis, state.GetAxis(axis));
                }
                for (int button_index = 0; button_index < caps.ButtonCount; button_index++)
                {
                    JoystickButton button = JoystickButton.Button0 + button_index;
                    joysticks[i].SetButton(button, state.GetButton(button) == ButtonState.Pressed);
                }
                for (int hat_index = 0; hat_index < caps.HatCount; hat_index++)
                {
                    // LegacyJoystickDriver report hats as pairs of axes
                    // Make sure we have enough axes left for this mapping
                    int axis_index = caps.AxisCount + 2 * hat_index;
                    if (axis_index < JoystickState.MaxAxes)
                    {
                        JoystickHat hat = JoystickHat.Hat0 + hat_index;
                        JoystickHatState hat_state = state.GetHat(hat);
                        JoystickAxis axis = JoystickAxis.Axis0 + axis_index;
                        float x = 0;
                        float y = 0;
                        if (hat_state.IsDown)
                            y--;
                        if (hat_state.IsUp)
                            y++;
                        if (hat_state.IsLeft)
                            x--;
                        if (hat_state.IsRight)
                            x++;

                        joysticks[i].SetAxis(axis, x);
                        joysticks[i].SetAxis(axis + 1, y);
                    }
                }
            }
        }

        #region IJoystickDriver Members

        public IList<JoystickDevice> Joysticks
        {
            get
            {
                Poll();
                return joysticks_readonly;
            }
        }

        #endregion
    }
}

