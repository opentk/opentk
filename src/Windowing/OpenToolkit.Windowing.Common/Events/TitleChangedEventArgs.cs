//
// TitleChangedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window title changed event.
    /// </summary>
    public readonly struct TitleChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleChangedEventArgs"/> struct.
        /// </summary>
        /// <param name="title">The new window title.</param>
        public TitleChangedEventArgs(string title)
        {
            Title = title;
        }

        /// <summary>
        /// Gets the new window title.
        /// </summary>
        public string Title { get; }
    }
}
