#region License
//
// GamePadConfigurationItem.cs
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

namespace OpenTK.Input
{
    struct GamePadConfigurationSource
    {
        ConfigurationType map_type;
        int? map_button;
        JoystickAxis? map_axis;
        JoystickHat? map_hat;
        HatPosition? map_hat_position;

        public GamePadConfigurationSource(JoystickAxis axis)
            : this()
        {
            Type = ConfigurationType.Axis;
            Axis = axis;
        }

        public GamePadConfigurationSource(int button)
            : this()
        {
            Type = ConfigurationType.Button;
            Button = button;
        }

        public GamePadConfigurationSource(JoystickHat hat, HatPosition pos)
            : this()
        {
            Type = ConfigurationType.Hat;
            Hat = hat;
            map_hat_position = pos;
        }

        public ConfigurationType Type
        {
            get { return map_type; }
            private set { map_type = value; }
        }

        public JoystickAxis Axis
        {
            get { return map_axis.Value; }
            private set { map_axis = value; }
        }

        public int Button
        {
            get { return map_button.Value; }
            private set { map_button = value; }
        }

        public JoystickHat Hat
        {
            get { return map_hat.Value; }
            private set { map_hat = value; }
        }

        public HatPosition HatPosition
        {
            get { return map_hat_position.Value; }
            private set { map_hat_position = value; }
        }
    }
}
