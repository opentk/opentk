//
// FocusChangedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for the window focus changing.
    /// </summary>
    public class FocusedChangedEventArgs : EventArgs
    {
        public FocusedChangedEventArgs()
        {
            
        }

        public FocusedChangedEventArgs(FocusedChangedEventArgs other)
        {
            this.isFocused = other.isFocused;
        }

        internal FocusedChangedEventArgs(bool isFocused)
        {
            this.isFocused = isFocused;
        }

        public bool isFocused { get; internal set; }
    }
}