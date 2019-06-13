//
// WindowPositionEventArgs.cs
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
    /// Defines the event data for the window position event.
    /// </summary>
    public readonly struct WindowPositionEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowPositionEventArgs"/> struct with given coordinate.
        /// </summary>
        /// <param name="x">The new window x position.</param>
        /// <param name="y">The new window y position.</param>
        public WindowPositionEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets the new window x position.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets the new window y position.
        /// </summary>
        public int Y { get; }
    }
}
