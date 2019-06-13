//
// MinimizedEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window minimizing event.
    /// </summary>
    public readonly struct MinimizedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinimizedEventArgs"/> struct.
        /// </summary>
        /// <param name="isIconified">
        /// A value indicating whether the window is iconified (minimized).
        /// </param>
        public MinimizedEventArgs(bool isIconified)
        {
            IsIconified = isIconified;
        }

        /// <summary>
        /// Gets a value indicating whether the window is iconified (minimized).
        /// </summary>
        public bool IsIconified { get; }
    }
}
