//
// VisibilityChangedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    public class VisibilityChangedEventArgs : EventArgs
    {
        public VisibilityChangedEventArgs()
        {
            
        }

        public VisibilityChangedEventArgs(VisibilityChangedEventArgs other)
        {
            this.isVisible = other.isVisible;
        }

        public VisibilityChangedEventArgs(bool isVisible)
        {
            this.isVisible = isVisible;
        }
        
        public bool isVisible { get; internal set; }
    }
}