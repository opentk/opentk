//
// TitleChangedEventArgs.cs
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
    /// Defines the event data for the window title changed event.
    /// </summary>
    public class TitleChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TitleChangedEventArgs"/> class.
        /// </summary>
        public TitleChangedEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleChangedEventArgs"/> class
        /// from a second <see cref="TitleChangedEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="TitleChangedEventArgs"/> to copy.</param>
        public TitleChangedEventArgs(TitleChangedEventArgs other)
        {
            this.Title = other.Title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleChangedEventArgs"/> class.
        /// </summary>
        /// <param name="title">The new window title.</param>
        internal TitleChangedEventArgs(string title)
        {
            this.Title = title;
        }

        /// <summary>
        /// Gets the new window title.
        /// </summary>
        public string Title { get; internal set; }
    }
}
