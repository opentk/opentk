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

using System;
using System.Collections.Generic;

namespace OpenTK.Input
{
    internal sealed class GamePadConfiguration
    {
        private static readonly char[] ConfigurationSeparator = { ',' };

        private readonly List<GamePadConfigurationItem> configuration_items =
            new List<GamePadConfigurationItem>();

        public GamePadConfiguration(string configuration)
        {
            ParseConfiguration(configuration);
        }

        public Guid Guid { get; private set; }

        public string Name { get; private set; }

        public List<GamePadConfigurationItem>.Enumerator GetEnumerator()
        {
            return configuration_items.GetEnumerator();
        }

        /// <summary>
        /// Parses a GamePad configuration string.
        /// This string must follow the rules for SDL2
        /// GameController outlined here:
        /// http://wiki.libsdl.org/SDL_GameControllerAddMapping
        /// </summary>
        /// <param name="configuration"></param>
        private void ParseConfiguration(string configuration)
        {
            if (string.IsNullOrEmpty(configuration))
            {
                throw new ArgumentNullException();
            }

            // The mapping string has the format "GUID,name,config"
            // - GUID is a unigue identifier returned by Joystick.GetGuid()
            // - name is a human-readable name for the controller
            // - config is a comma-separated list of configurations as follows:
            //   - [gamepad axis or button name]:[joystick axis, button or hat number]
            var items = configuration.Split(ConfigurationSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (items.Length < 3)
            {
                throw new ArgumentException();
            }

            var map = this;
            map.Guid = new Guid(items[0]);
            map.Name = items[1];
            for (var i = 2; i < items.Length; i++)
            {
                var config = items[i].Split(':');
                var target = ParseTarget(config[0]);
                var source = ParseSource(config[1]);
                configuration_items.Add(new GamePadConfigurationItem(source, target));
            }
        }

        /// <summary>
        /// Parses a gamepad configuration target string
        /// </summary>
        /// <param name="target">The string to parse</param>
        /// <returns>The configuration target (Button index, axis index etc.)</returns>
        private static GamePadConfigurationTarget ParseTarget(string target)
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

        /// <summary>
        /// Creates a new gamepad configuration source from the given string
        /// </summary>
        /// <param name="item">The string to parse</param>
        /// <returns>The new gamepad configuration source</returns>
        private static GamePadConfigurationSource ParseSource(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                return new GamePadConfigurationSource();
            }

            switch (item[0])
            {
                case 'a':
                {
                    return new GamePadConfigurationSource(true, ParseIndex(item));
                }
                case 'b':
                {
                    return new GamePadConfigurationSource(false, ParseIndex(item));
                }
                case 'h':
                {
                    var hat = ParseHat(item, out var position);
                    return new GamePadConfigurationSource(hat, position);
                }
                default:
                {
                    throw new InvalidOperationException("[Input] Invalid GamePad configuration value");
                }
            }
        }

        /// <summary>
        /// Parses a string in the format a#" where:
        /// - # is a zero-based integer number
        /// </summary>
        /// <param name="item">The string to parse</param>
        /// <returns>The index of the axis or button</returns>
        private static int ParseIndex(string item)
        {
            // item is in the format "a#" where # a zero-based integer number
            return int.Parse(item.Substring(1));
        }

        /// <summary>
        /// Parses a string in the format "h#.#" where:
        /// - the 1st # is the zero-based hat id
        /// - the 2nd # is a bit-flag defining the hat position
        /// </summary>
        /// <param name="item">The string to parse</param>
        /// <param name="position">The hat position assigned via 'out'</param>
        /// <returns>The new joystick hat</returns>
        private static JoystickHat ParseHat(string item, out HatPosition position)
        {
            var hat = JoystickHat.Hat0;
            var id = int.Parse(item.Substring(1, 1));
            var pos = int.Parse(item.Substring(3));

            position = HatPosition.Centered;
            switch (pos)
            {
                case 1:
                    position = HatPosition.Up;
                    break;
                case 2:
                    position = HatPosition.Right;
                    break;
                case 3:
                    position = HatPosition.UpRight;
                    break;
                case 4:
                    position = HatPosition.Down;
                    break;
                case 6:
                    position = HatPosition.DownRight;
                    break;
                case 8:
                    position = HatPosition.Left;
                    break;
                case 9:
                    position = HatPosition.UpLeft;
                    break;
                case 12:
                    position = HatPosition.DownLeft;
                    break;
                default:
                    position = HatPosition.Centered;
                    break;
            }

            return hat + id;
        }
    }
}
