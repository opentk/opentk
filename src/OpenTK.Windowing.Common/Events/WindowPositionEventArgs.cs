//
// WindowPositionEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenTK.Mathematics;

namespace OpenTK.Windowing.Common
{
    /// <summary>
    ///     Defines the event data for the window position event.
    /// </summary>
    public readonly struct WindowPositionEventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WindowPositionEventArgs" /> struct.
        /// </summary>
        /// <param name="position">The new window position.</param>
        public WindowPositionEventArgs(Vector2i position) => Position = position;

        /// <summary>
        ///     Initializes a new instance of the <see cref="WindowPositionEventArgs" /> struct with given coordinate.
        /// </summary>
        /// <param name="x">The new window x position.</param>
        /// <param name="y">The new window y position.</param>
        public WindowPositionEventArgs(int x, int y)
            : this(new Vector2i(x, y))
        {
        }

        /// <summary>
        ///     Gets the new window position, in pixels relative to the top left corner of the current monitor.
        /// </summary>
        public Vector2i Position { get; }

        /// <summary>
        ///     Gets the new window x position.
        /// </summary>
        public int X => Position.X;

        /// <summary>
        ///     Gets the new window y position.
        /// </summary>
        public int Y => Position.Y;
    }
}
