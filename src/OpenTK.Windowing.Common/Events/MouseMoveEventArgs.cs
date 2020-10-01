//
// MouseMoveEventArgs.cs
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
    ///     Defines the event data for <see cref="IWindowEvents.MouseMove" /> events.
    /// </summary>
    public readonly struct MouseMoveEventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MouseMoveEventArgs" /> struct.
        /// </summary>
        /// <param name="position">The new mouse position.</param>
        /// <param name="delta">The change in position produced by this event.</param>
        public MouseMoveEventArgs(Vector2 position, Vector2 delta)
        {
            Position = position;
            Delta = delta;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MouseMoveEventArgs" /> struct.
        /// </summary>
        /// <param name="x">The new mouse X position.</param>
        /// <param name="y">The new mouse Y position.</param>
        /// <param name="deltaX">The change in X position produced by this event.</param>
        /// <param name="deltaY">The change in Y position produced by this event.</param>
        public MouseMoveEventArgs(float x, float y, float deltaX, float deltaY)
            : this(new Vector2(x, y), new Vector2(deltaX, deltaY))
        {
        }

        /// <summary>
        ///     Gets the new X position produced by this event.
        ///     This position is relative to the top-left corner of the contents of the window.
        /// </summary>
        public float X => Position.X;

        /// <summary>
        ///     Gets the new Y position produced by this event.
        ///     This position is relative to the top-left corner of the contents of the window.
        /// </summary>
        public float Y => Position.Y;

        /// <summary>
        ///     Gets the new position produced by this event.
        ///     This position is relative to the top-left corner of the contents of the window.
        /// </summary>
        public Vector2 Position { get; }

        /// <summary>
        ///     Gets the change in X position since the last event.
        /// </summary>
        public float DeltaX => Delta.X;

        /// <summary>
        ///     Gets the change in Y position since the last event.
        /// </summary>
        public float DeltaY => Delta.Y;

        /// <summary>
        ///     Gets the change in position since the last event.
        /// </summary>
        public Vector2 Delta { get; }
    }
}
