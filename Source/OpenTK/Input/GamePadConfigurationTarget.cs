// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK.Input
{
    struct GamePadConfigurationTarget
    {
        ConfigurationType map_type;
        Nullable<Buttons> map_button;
        Nullable<GamePadAxes> map_axis;

        public GamePadConfigurationTarget(Buttons button)
            : this()
        {
            Type = ConfigurationType.Button;
            map_button = button;
        }

        public GamePadConfigurationTarget(GamePadAxes axis)
            : this()
        {
            Type = ConfigurationType.Axis;
            map_axis = axis;
        }

        public ConfigurationType Type
        {
            get { return map_type; }
            private set { map_type = value; }
        }

        public GamePadAxes Axis
        {
            get { return map_axis.Value; }
            private set { map_axis = value; }
        }

        public Buttons Button
        {
            get { return map_button.Value; }
            private set { map_button = value; }
        }
    }
}
