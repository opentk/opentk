// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK.Input
{
    struct GamePadConfigurationSource
    {
        ConfigurationType map_type;
        JoystickButton? map_button;
        JoystickAxis? map_axis;
        JoystickHat? map_hat;
        HatPosition? map_hat_position;

        public GamePadConfigurationSource(JoystickAxis axis)
            : this()
        {
            Type = ConfigurationType.Axis;
            Axis = axis;
        }

        public GamePadConfigurationSource(JoystickButton button)
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

        public JoystickButton Button
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
