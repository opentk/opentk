//
// VisibilityChangedEventArgs.cs
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
    /// Defines the event data for the window visibility changed event.
    /// </summary>
    public class VisibilityChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisibilityChangedEventArgs"/> class.
        /// </summary>
        public VisibilityChangedEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisibilityChangedEventArgs"/> class
        /// from a second <see cref="VisibilityChangedEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="VisibilityChangedEventArgs"/> to copy.</param>
        public VisibilityChangedEventArgs(VisibilityChangedEventArgs other)
        {
            this.IsVisible = other.IsVisible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisibilityChangedEventArgs"/> class.
        /// </summary>
        /// <param name="isVisible">A value indicating whether the window is visible.</param>
        public VisibilityChangedEventArgs(bool isVisible)
        {
            this.IsVisible = isVisible;
        }

        /// <summary>
        /// Gets a value indicating whether the window is visible.
        /// </summary>
        public bool IsVisible { get; internal set; }
    }
}
