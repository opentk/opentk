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
        readonly Dictionary<Guid, GamePadMap> configurations =
            new Dictionary<Guid, GamePadMap>();

        public GamePadState GetState(int index)
        {
            JoystickState joy = Joystick.GetState(index);
            GamePadState pad = new GamePadState();
            if (joy.IsConnected)
            {
                GamePadMap map = GetConfiguration(Joystick.GetGuid(index));


                // Todo: implement mapping
            }
            return pad;
        }

        public GamePadCapabilities GetCapabilities(int index)
        {
            JoystickCapabilities joy = Joystick.GetCapabilities(index);
            GamePadCapabilities pad;
            if (joy.IsConnected)
            {
                GamePadMap map = GetConfiguration(Joystick.GetGuid(index));
                pad = new GamePadCapabilities(
                    GamePadType.GamePad, // Todo: detect different types
                    TranslateAxes(map),
                    TranslateButtons(map),
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
                GamePadMap map = GetConfiguration(Joystick.GetGuid(index));
                name = map.Name;
            }
            return name;
        }

        #region Private Members

        GamePadMap GetConfiguration(Guid guid)
        {
            if (!configurations.ContainsKey(guid))
            {
                GamePadMap map = GamePadMap.GetConfiguration(guid);
                configurations.Add(guid, map);
            }
            return configurations[guid];
        }

        bool IsMapped(MapItem item)
        {
            return item.Type != MapType.Unmapped;
        }

        GamePadAxes TranslateAxes(GamePadMap map)
        {
            GamePadAxes axes = 0;
            axes |= IsMapped(map.LeftAxisX) ? GamePadAxes.LeftX : 0;
            axes |= IsMapped(map.LeftAxisY) ? GamePadAxes.LeftY : 0;
            axes |= IsMapped(map.RightAxisX) ? GamePadAxes.RightX : 0;
            axes |= IsMapped(map.RightAxisY) ? GamePadAxes.RightY : 0;
            axes |= IsMapped(map.LeftTrigger) ? GamePadAxes.LeftTrigger : 0;
            axes |= IsMapped(map.RightTrigger) ? GamePadAxes.RightTrigger : 0;
            return axes;
        }

        Buttons TranslateButtons(GamePadMap map)
        {
            Buttons buttons = 0;
            buttons |= IsMapped(map.A) ? Buttons.A : 0;
            buttons |= IsMapped(map.B) ? Buttons.B : 0;
            buttons |= IsMapped(map.X) ? Buttons.X : 0;
            buttons |= IsMapped(map.Y) ? Buttons.Y : 0;
            buttons |= IsMapped(map.Start) ? Buttons.Start : 0;
            buttons |= IsMapped(map.Back) ? Buttons.Back : 0;
            buttons |= IsMapped(map.BigButton) ? Buttons.BigButton : 0;
            buttons |= IsMapped(map.LeftShoulder) ? Buttons.LeftShoulder : 0;
            buttons |= IsMapped(map.RightShoulder) ? Buttons.RightShoulder : 0;
            buttons |= IsMapped(map.LeftStick) ? Buttons.LeftStick : 0;
            buttons |= IsMapped(map.RightStick) ? Buttons.RightStick : 0;
            return buttons;
        }

//        bool TranslateDPad(GamePadMap map)
//        {
//            pad.HasDPadDownButton = IsMapped(map.DPadDown);
//            pad.HasDPadUpButton = IsMapped(map.DPadUp);
//            pad.HasDPadLeftButton = IsMapped(map.DPadLeft);
//            pad.HasDPadRightButton = IsMapped(map.DPadRight);
//        }

        #endregion
    }
}
