#region License
//
// MappedGamePadDriver.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2013 Stefanos Apostolopoulos
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
using System.Text;
using OpenTK.Input;

namespace OpenTK.Platform
{
    /// \internal
    /// <summary>
    /// Implements IGamePadDriver using OpenTK.Input.Joystick
    /// and a gamepad-specific axis/button mapping.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class supports OpenTK and is not meant to be accessed by user code.
    /// </para>
    /// <para>
    /// To support gamepads on platforms that do not offer a gamepad-optimized API,
    /// we need to use the generic OpenTK.Input.Joystick and implement a custom
    /// mapping scheme to provide a stable mapping to OpenTK.Input.GamePad. This
    /// class implements this mapping scheme.
    /// </para>
    /// </remarks>
    class MappedGamePadDriver : IGamePadDriver
    {
        readonly GamePadConfigurationDatabase database =
            new GamePadConfigurationDatabase();
        readonly Dictionary<Guid, GamePadConfiguration> configurations =
            new Dictionary<Guid, GamePadConfiguration>();

        public GamePadState GetState(int index)
        {
            JoystickState joy = Joystick.GetState(index);
            GamePadState pad = new GamePadState();

            if (joy.IsConnected)
            {
                pad.SetConnected(true);
                pad.SetPacketNumber(joy.PacketNumber);

                GamePadConfiguration configuration = GetConfiguration(Joystick.GetGuid(index));

                foreach (GamePadConfigurationItem map in configuration)
                {
                    switch (map.Source.Type)
                    {
                        case ConfigurationType.Axis:
                            {
                                // JoystickAxis -> Buttons/GamePadAxes mapping
                                JoystickAxis source_axis = map.Source.Axis;
                                short value = joy.GetAxisRaw(source_axis);

                                switch (map.Target.Type)
                                {
                                    case ConfigurationType.Axis:
                                        pad.SetAxis(map.Target.Axis, value);
                                        break;

                                    case ConfigurationType.Button:
                                        // Todo: if SDL2 GameController config is ever updated to
                                        // distinguish between negative/positive axes, then remove
                                        // Math.Abs below.
                                        // Button is considered press when the axis is >= 0.5 from center
                                        pad.SetButton(map.Target.Button, Math.Abs(value) >= short.MaxValue >> 1);
                                        break;
                                }
                            }
                            break;

                        case ConfigurationType.Button:
                            {
                                // JoystickButton -> Buttons/GamePadAxes mapping
                                JoystickButton source_button = map.Source.Button;
                                bool pressed = joy.GetButton(source_button) == ButtonState.Pressed;

                                switch (map.Target.Type)
                                {
                                    case ConfigurationType.Axis:
                                        // Todo: if SDL2 GameController config is ever updated to
                                        // distinguish between negative/positive axes, then update
                                        // the following line to support both.
                                        pad.SetAxis(map.Target.Axis, pressed ? short.MaxValue : (short)0);
                                        break;

                                    case ConfigurationType.Button:
                                        pad.SetButton(map.Target.Button, pressed);
                                        break;
                                }
                            }
                            break;
                    }
                }
            }

            return pad;
        }

        public GamePadCapabilities GetCapabilities(int index)
        {
            JoystickCapabilities joy = Joystick.GetCapabilities(index);
            GamePadCapabilities pad;
            if (joy.IsConnected)
            {
                GamePadConfiguration configuration = GetConfiguration(Joystick.GetGuid(index));
                GamePadAxes mapped_axes = 0;
                Buttons mapped_buttons = 0;

                foreach (GamePadConfigurationItem map in configuration)
                {
                    switch (map.Target.Type)
                    {
                        case ConfigurationType.Axis:
                            mapped_axes |= map.Target.Axis;
                            break;

                        case ConfigurationType.Button:
                            mapped_buttons |= map.Target.Button;
                            break;
                    }
                }

                pad = new GamePadCapabilities(
                    GamePadType.GamePad, // Todo: detect different types
                    mapped_axes,
                    mapped_buttons,
                    true);
            }
            else
            {
                pad = new GamePadCapabilities();
            }
            return pad;
        }

        public string GetName(int index)
        {
            JoystickCapabilities joy = Joystick.GetCapabilities(index);
            string name = String.Empty;
            if (joy.IsConnected)
            {
                GamePadConfiguration map = GetConfiguration(Joystick.GetGuid(index));
                name = map.Name;
            }
            return name;
        }

        public bool SetVibration(int index, float left, float right)
        {
            return false;
        }

        #region Private Members

        GamePadConfiguration GetConfiguration(Guid guid)
        {
            if (!configurations.ContainsKey(guid))
            {
                string config = database[guid];
                GamePadConfiguration map = new GamePadConfiguration(config);
                configurations.Add(guid, map);
            }
            return configurations[guid];
        }

        bool IsMapped(GamePadConfigurationSource item)
        {
            return item.Type != ConfigurationType.Unmapped;
        }

        #endregion
    }
}
