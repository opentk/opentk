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
using System.Text;

namespace OpenTK.Input
{
    enum MapType
    {
        Axis = 0,
        Button = 1
    }

    class MapItem
    {
        MapType map_type;
        Nullable<JoystickButton> map_button;
        Nullable<JoystickAxis> map_axis;

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
    }
}
