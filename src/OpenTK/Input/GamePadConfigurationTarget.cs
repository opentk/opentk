#region License
//
// GamePadConfigurationTarget.cs
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
