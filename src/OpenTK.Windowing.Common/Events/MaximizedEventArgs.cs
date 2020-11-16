//
// MaximizedEventArgs.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.Common
{
    /// <summary>
    /// Defines the event data for the window maximizing event.
    /// </summary>
    public readonly struct MaximizedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaximizedEventArgs"/> struct.
        /// </summary>
        /// <param name="isMaximized">
        /// A value indicating whether the window is maximized.
        /// </param>
        public MaximizedEventArgs(bool isMaximized)
        {
            IsMaximized = isMaximized;
        }

        /// <summary>
        /// Gets a value indicating whether the window is maximized.
        /// </summary>
        public bool IsMaximized { get; }
    }
}
