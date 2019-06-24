//
// VisibilityChangedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window visibility changed event.
    /// </summary>
    public readonly struct VisibilityChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisibilityChangedEventArgs"/> struct.
        /// </summary>
        /// <param name="isVisible">A value indicating whether the window is visible.</param>
        public VisibilityChangedEventArgs(bool isVisible)
        {
            IsVisible = isVisible;
        }

        /// <summary>
        /// Gets a value indicating whether the window is visible.
        /// </summary>
        public bool IsVisible { get; }
    }
}
