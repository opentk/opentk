//
// IconifyEventArgs.cs
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
    /// Defines the event data for the window iconification(minimizing) event.
    /// </summary>
    public class IconifyEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IconifyEventArgs"/> class.
        /// </summary>
        public IconifyEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IconifyEventArgs"/> class
        /// from a second <see cref="IconifyEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="IconifyEventArgs"/> to copy.</param>
        public IconifyEventArgs(IconifyEventArgs other)
        {
            this.IsIconified = other.IsIconified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IconifyEventArgs"/> class.
        /// </summary>
        /// <param name="isIconified">
        /// A value indicating whether the window is iconified (minimized).
        /// </param>
        internal IconifyEventArgs(bool isIconified)
        {
            this.IsIconified = isIconified;
        }

        /// <summary>
        /// Gets a value indicating whether the window is iconified (minimized).
        /// </summary>
        public bool IsIconified { get; internal set; }
    }
}
