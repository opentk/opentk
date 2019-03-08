//
// JoystickEventArgs.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    public class JoystickEventArgs : EventArgs
    {
        public JoystickEventArgs()
        {
            
        }

        public JoystickEventArgs(int joystickId, bool isConnected)
        {
            this.joystickId = joystickId;
            this.isConnected = isConnected;
        }

        public JoystickEventArgs(JoystickEventArgs other)
        {
            this.joystickId = other.joystickId;
            this.isConnected = other.isConnected;
        }
        
        public int joystickId;
        public bool isConnected;
    }
}