//
// FocusChangedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window focus changing.
    /// </summary>
    public class FocusedChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FocusedChangedEventArgs"/> class.
        /// </summary>
        public FocusedChangedEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FocusedChangedEventArgs"/> class
        /// from a second <see cref="FocusedChangedEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="FocusedChangedEventArgs"/> to copy.</param>
        public FocusedChangedEventArgs(FocusedChangedEventArgs other)
        {
            this.IsFocused = other.IsFocused;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FocusedChangedEventArgs"/> class.
        /// </summary>
        /// <param name="isFocused">A value indicating whether the window is focused.</param>
        internal FocusedChangedEventArgs(bool isFocused)
        {
            this.IsFocused = isFocused;
        }

        /// <summary>
        /// Gets a value indicating whether the window is focused.
        /// </summary>
        public bool IsFocused { get; internal set; }
    }
}
