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
    public class WindowPositionEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowPositionEventArgs"/> class.
        /// </summary>
        public WindowPositionEventArgs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowPositionEventArgs"/> class
        /// from a second <see cref="WindowPositionEventArgs"/> which is copied.
        /// </summary>
        /// <param name="other">The <see cref="WindowPositionEventArgs"/> to copy.</param>
        public WindowPositionEventArgs(WindowPositionEventArgs other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowPositionEventArgs"/> class with given coordinate.
        /// </summary>
        /// <param name="x">The new window x position.</param>
        /// <param name="y">The new window y position.</param>
        public WindowPositionEventArgs(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets the new window x position.
        /// </summary>
        public int X { get; internal set; }

        /// <summary>
        /// Gets the new window y position.
        /// </summary>
        public int Y { get; internal set; }
    }
}
