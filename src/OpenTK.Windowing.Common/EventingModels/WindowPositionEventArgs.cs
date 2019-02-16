//
// WindowPositionEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    public class WindowPositionEventArgs : EventArgs
    {
        public WindowPositionEventArgs()
        {
            
        }

        public WindowPositionEventArgs(WindowPositionEventArgs other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        public WindowPositionEventArgs(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
        public int X { get; internal set; }
        public int Y { get; internal set; }
    }
}