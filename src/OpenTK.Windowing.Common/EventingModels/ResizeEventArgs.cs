//
// ResizeEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    public class ResizeEventArgs : EventArgs
    {
        public ResizeEventArgs()
        {
            
        }

        public ResizeEventArgs(ResizeEventArgs other)
        {
            this.Width = other.Width;
            this.Height = other.Height;
        }

        internal ResizeEventArgs(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        
        public int Width { get; internal set; }
        public int Height { get; internal set; }
    }
}