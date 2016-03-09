// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK.Input
{
    class GamePadConfigurationItem
    {
        GamePadConfigurationSource source;
        GamePadConfigurationTarget target;

        public GamePadConfigurationItem(GamePadConfigurationSource source, GamePadConfigurationTarget target)
        {
            Source = source;
            Target = target;
        }

        public GamePadConfigurationSource Source
        {
            get { return source; }
            private set { source = value; }
        }

        public GamePadConfigurationTarget Target
        {
            get { return target; }
            private set { target = value; }
        }
    }
}

