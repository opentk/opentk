#region License
//
// GamePadMapping.cs
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
using System.Diagnostics;
using System.Text;

namespace OpenTK.Input
{
    sealed class GamePadConfiguration
    {
        static readonly char[] ConfigurationSeparator = new char[] { ',' };

        Guid guid;
        string name;
        readonly List<GamePadConfigurationItem> configuration_items =
            new List<GamePadConfigurationItem>();

        public Guid Guid
        {
            get { return guid; }
            private set { guid = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public GamePadConfiguration(string configuration)
        {
            ParseConfiguration(configuration);
        }

        public List<GamePadConfigurationItem>.Enumerator GetEnumerator()
        {
            return configuration_items.GetEnumerator();
        }

        #region Private Members

        // Parses a GamePad configuration string. The string
        // follows the rules for SDL2 GameController, outlined here:
        // http://wiki.libsdl.org/SDL_GameControllerAddMapping
        void ParseConfiguration(string configuration)
        {
            if (String.IsNullOrEmpty(configuration))
            {
                throw new ArgumentNullException();
            }

            // The mapping string has the format "GUID,name,config"
            // - GUID is a unigue identifier returned by Joystick.GetGuid()
            // - name is a human-readable name for the controller
            // - config is a comma-separated list of configurations as follows:
            //   - [gamepad axis or button name]:[joystick axis, button or hat number]
            string[] items = configuration.Split(ConfigurationSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length < 3)
            {
                throw new ArgumentException();
            }

            GamePadConfiguration map = this;
            map.Guid = new Guid(items[0]);
            map.Name = items[1];
            for (int i = 2; i < items.Length; i++)
            {
                string[] config = items[i].Split(':');
                GamePadConfigurationTarget target = ParseTarget(config[0]);
                GamePadConfigurationSource source = ParseSource(config[1]);
                configuration_items.Add(new GamePadConfigurationItem(source, target));
            }
        }

        static GamePadConfigurationTarget ParseTarget(string target)
        {
            switch (target)
            {
                // Buttons
                case "a":
                    return new GamePadConfigurationTarget(Buttons.A);
                case "b":
                    return new GamePadConfigurationTarget(Buttons.B);
                case "x":
                    return new GamePadConfigurationTarget(Buttons.X);
                case "y":
                    return new GamePadConfigurationTarget(Buttons.Y);
                case "start":
                    return new GamePadConfigurationTarget(Buttons.Start);
                case "back":
                    return new GamePadConfigurationTarget(Buttons.Back);
                case "guide":
                    return new GamePadConfigurationTarget(Buttons.BigButton);
                case "leftshoulder":
                    return new GamePadConfigurationTarget(Buttons.LeftShoulder);
                case "rightshoulder":
                    return new GamePadConfigurationTarget(Buttons.RightShoulder);
                case "leftstick":
                    return new GamePadConfigurationTarget(Buttons.LeftStick);
                case "rightstick":
                    return new GamePadConfigurationTarget(Buttons.RightStick);
                case "dpup":
                    return new GamePadConfigurationTarget(Buttons.DPadUp);
                case "dpdown":
                    return new GamePadConfigurationTarget(Buttons.DPadDown);
                case "dpleft":
                    return new GamePadConfigurationTarget(Buttons.DPadLeft);
                case "dpright":
                    return new GamePadConfigurationTarget(Buttons.DPadRight);

                // Axes
                case "leftx":
                    return new GamePadConfigurationTarget(GamePadAxes.LeftX);
                case "lefty":
                    return new GamePadConfigurationTarget(GamePadAxes.LeftY);
                case "rightx":
                    return new GamePadConfigurationTarget(GamePadAxes.RightX);
                case "righty":
                    return new GamePadConfigurationTarget(GamePadAxes.RightY);

                // Triggers
                case "lefttrigger":
                    return new GamePadConfigurationTarget(GamePadAxes.LeftTrigger);
                case "righttrigger":
                    return new GamePadConfigurationTarget(GamePadAxes.RightTrigger);


                // Unmapped
                default:
                    return new GamePadConfigurationTarget();
            }
        }

        static GamePadConfigurationSource ParseSource(string item)
        {
            if (String.IsNullOrEmpty(item))
            {
                return new GamePadConfigurationSource();
            }

            switch (item[0])
            {
                case 'a':
                    return new GamePadConfigurationSource(ParseAxis(item));

                case 'b':
                    return new GamePadConfigurationSource(ParseButton(item));

                case 'h':
                    throw new NotImplementedException();
                    //return new MapItem(ParseHat(item));

                default:
                    throw new InvalidOperationException("[Input] Invalid GamePad configuration value");
            }
        }

        static JoystickAxis ParseAxis(string item)
        {
            // item is in the format "a#" where # a zero-based integer number
            JoystickAxis axis = JoystickAxis.Axis0;
            int id = Int32.Parse(item.Substring(1));
            return axis + id;
        }

        static JoystickButton ParseButton(string item)
        {
            // item is in the format "b#" where # a zero-based integer nubmer
            JoystickButton button = JoystickButton.Button0;
            int id = Int32.Parse(item.Substring(1));
            return button + id;
        }

        #endregion
    }
}
