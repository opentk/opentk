//
// MinimizedEventArgs.cs
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
    /// Defines the event data for the window minimizing event.
    /// </summary>
    public class MinimizedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinimizedEventArgs"/> class.
        /// </summary>
        public MinimizedEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimizedEventArgs"/> class
        /// from a second <see cref="MinimizedEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="MinimizedEventArgs"/> to copy.</param>
        public MinimizedEventArgs(MinimizedEventArgs other)
        {
            this.IsIconified = other.IsIconified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimizedEventArgs"/> class.
        /// </summary>
        /// <param name="isIconified">
        /// A value indicating whether the window is iconified (minimized).
        /// </param>
        internal MinimizedEventArgs(bool isIconified)
        {
            this.IsIconified = isIconified;
        }

        /// <summary>
        /// Gets a value indicating whether the window is iconified (minimized).
        /// </summary>
        public bool IsIconified { get; internal set; }
    }
}
