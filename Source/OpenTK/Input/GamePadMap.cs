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
    enum MapType
    {
        Unmapped = 0,
        Axis,
        Button
    }

    class MapItem
    {
        MapType map_type;
        Nullable<JoystickButton> map_button;
        Nullable<JoystickAxis> map_axis;

        public MapItem()
        {
        }

        public MapItem(JoystickAxis axis)
        {
            Type = MapType.Axis;
            Axis = axis;
        }

        public MapItem(JoystickButton button)
        {
            Type = MapType.Button;
            Button = button;
        }

        public MapType Type
        {
            get { return map_type; }
            private set { map_type = value; }
        }

        public Nullable<JoystickAxis> Axis
        {
            get { return map_axis; }
            private set { map_axis = value; }
        }

        public Nullable<JoystickButton> Button
        {
            get { return map_button; }
            private set { map_button = value; }
        }
    }

    class GamePadMap
    {
        static readonly GamePadMap default_map;

        Guid guid;
        string name;
        MapItem a, b, x, y;
        MapItem lshoulder, rshoulder;
        MapItem lstick, rstick;
        MapItem start, back;
        MapItem home;
        MapItem axis_lx, axis_ly;
        MapItem axis_rx, axis_ry;
        MapItem ltrigger, rtrigger;
        MapItem dpad_u, dpad_d;
        MapItem dpad_l, dpad_r;

        Guid Guid { get { return guid; } set { guid = value; } }
        string Name { get { return name; } set { name = value; } }
        public MapItem A { get { return a; } set { a = value; } }
        public MapItem B { get { return b; } set { b = value; } }
        public MapItem X { get { return x; } set { x = value; } }
        public MapItem Y { get { return y; } set { y = value; } }
        public MapItem LeftShoulder { get { return lshoulder; } set { lshoulder = value; } }
        public MapItem RightShoulder { get { return rshoulder; } set { rshoulder = value; } }
        public MapItem LeftStick { get { return lstick; } set { lstick = value; } }
        public MapItem RightStick { get { return rstick; } set { rstick = value; } }
        public MapItem Start { get { return start; } set { start = value; } }
        public MapItem Back { get { return back; } set { back = value; } }
        public MapItem BigButton { get { return home; } set { home = value; } }
        public MapItem LeftAxisX { get { return axis_lx; } set { axis_lx = value; } }
        public MapItem LeftAxisY { get { return axis_ly; } set { axis_ly = value; } }
        public MapItem RightAxisX { get { return axis_rx; } set { axis_rx = value; } }
        public MapItem RightAxisY { get { return axis_ry; } set { axis_ry = value; } }
        public MapItem LeftTrigger { get { return ltrigger; } set { ltrigger = value; } }
        public MapItem RightTrigger { get { return rtrigger; } set { rtrigger = value; } }
        public MapItem DPadUp { get { return dpad_u; } set { dpad_u = value; } }
        public MapItem DPadDown { get { return dpad_d; } set { dpad_d = value; } }
        public MapItem DPadLeft { get { return dpad_l; } set { dpad_l = value; } }
        public MapItem DPadRight { get { return dpad_r; } set { dpad_r = value; } }

        public GamePadMap()
        {
        }

        public GamePadMap(string configuration)
        {
        }

        static GamePadMap()
        {
            GamePadMap map = new GamePadMap();
            map.A = new MapItem(JoystickButton.Button0);
            map.B = new MapItem(JoystickButton.Button1);
            map.X = new MapItem(JoystickButton.Button2);
            map.Y = new MapItem(JoystickButton.Button3);
            map.LeftShoulder = new MapItem(JoystickButton.Button4);
            map.RightShoulder = new MapItem(JoystickButton.Button5);
            map.LeftStick = new MapItem(JoystickButton.Button6);
            map.RightStick = new MapItem(JoystickButton.Button7);
            map.Start = new MapItem(JoystickButton.Button8);
            map.Back = new MapItem(JoystickButton.Button9);
            map.BigButton = new MapItem(JoystickButton.Button10);
            map.DPadUp = new MapItem(JoystickButton.Button11);
            map.DPadDown = new MapItem(JoystickButton.Button12);
            map.DPadLeft = new MapItem(JoystickButton.Button13);
            map.DPadRight = new MapItem(JoystickButton.Button14);
            map.LeftAxisX = new MapItem(JoystickAxis.Axis0);
            map.LeftAxisY = new MapItem(JoystickAxis.Axis1);
            map.RightAxisX = new MapItem(JoystickAxis.Axis2);
            map.RightAxisY = new MapItem(JoystickAxis.Axis3);
            map.LeftTrigger = new MapItem(JoystickAxis.Axis4);
            map.RightTrigger = new MapItem(JoystickAxis.Axis5);
            default_map = map;
        }

        public static GamePadMap Default
        {
            get { return default_map; }
        }

        public static GamePadMap GetConfiguration(Guid guid)
        {
            GamePadMap map = GamePadMap.Default;
            if (GamePadConfigurationDatabase.Configurations.ContainsKey(guid))
            {
                map = ParseConfiguration(GamePadConfigurationDatabase.Configurations[guid]);
            }
            return map;
        }

        // Parses a GamePad configuration string. The string
        // follows the rules for SDL2 GameController, outlined here:
        // http://wiki.libsdl.org/SDL_GameControllerAddMapping
        static GamePadMap ParseConfiguration(string configuration)
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
            string[] items = configuration.Split(',');
            if (items.Length < 3)
            {
                throw new ArgumentException();
            }

            GamePadMap map = new GamePadMap();
            map.Guid = new Guid(items[0]);
            map.Name = items[1];
            for (int i = 2; i < items.Length; i++)
            {
                string[] config = items[i].Split(':');
                MapItem map_item = ParseItem(config[1]);
                switch (config[0])
                {
                    case "a":
                        map.A = map_item;
                        break;

                    case "b":
                        map.B = map_item;
                        break;

                    case "x":
                        map.X = map_item;
                        break;

                    case "y":
                        map.Y = map_item;
                        break;

                    case "start":
                        map.Start = map_item;
                        break;

                    case "back":
                        map.Back = map_item;
                        break;

                    case "guide":
                        map.BigButton = map_item;
                        break;

                    case "dpup":
                        map.DPadUp = map_item;
                        break;

                    case "dpdown":
                        map.DPadDown = map_item;
                        break;

                    case "dpleft":
                        map.DPadLeft = map_item;
                        break;

                    case "dpright":
                        map.DPadRight = map_item;
                        break;

                    case "leftshoulder":
                        map.LeftShoulder = map_item;
                        break;

                    case "rightshoulder":
                        map.RightShoulder = map_item;
                        break;

                    case "leftstick":
                        map.LeftStick = map_item;
                        break;

                    case "rightstick":
                        map.RightStick = map_item;
                        break;

                    case "leftx":
                        map.LeftAxisX = map_item;
                        break;

                    case "lefty":
                        map.LeftAxisY = map_item;
                        break;

                    case "rightx":
                        map.RightAxisX = map_item;
                        break;

                    case "righty":
                        map.RightAxisY = map_item;
                        break;

                    case "lefttrigger":
                        map.LeftTrigger = map_item;
                        break;

                    case "righttrigger":
                        map.RightTrigger = map_item;
                        break;

                    default:
                        Debug.Print("[Input] Invalid GamePad configuration name: {0}", items[i]);
                        break;
                }
            }

            return map;
        }

        static MapItem ParseItem(string item)
        {
            if (String.IsNullOrEmpty(item))
            {
                return new MapItem();
            }

            switch (item[0])
            {
                case 'a':
                    return new MapItem(ParseAxis(item));

                case 'b':
                    return new MapItem(ParseButton(item));

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
    }
}
