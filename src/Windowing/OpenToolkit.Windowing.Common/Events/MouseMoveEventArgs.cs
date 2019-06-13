//
// MouseMoveEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    // TODO: This really does not need double precision. Can cut the struct size in half.

    /// <summary>
    /// Defines the event data for <see cref="IWindowEvents.add_MouseMove" /> events.
    /// </summary>
    public readonly struct MouseMoveEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MouseMoveEventArgs"/> struct.
        /// </summary>
        /// <param name="x">The X position.</param>
        /// <param name="y">The Y position.</param>
        /// <param name="deltaX">The change in X position produced by this event.</param>
        /// <param name="deltaY">The change in Y position produced by this event.</param>
        public MouseMoveEventArgs(double x, double y, double deltaX, double deltaY)
        {
            X = x;
            Y = y;
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        /// <summary>
        /// Gets the new X position produced by this event.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Gets the new Y position produced by this event.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Gets the change in X position produced by this event.
        /// </summary>
        public double DeltaX { get; }

        /// <summary>
        /// Gets the change in Y position produced by this event.
        /// </summary>
        public double DeltaY { get; }
    }
}
