//
// MouseState.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections;
using System.Text;
using OpenTK.Mathematics;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Encapsulates the state of a mouse device.
    /// </summary>
    public class MouseState
    {
        /// <summary>
        ///     The maximum number of buttons a <see cref="MouseState" /> can represent.
        /// </summary>
        internal const int MaxButtons = 16;

        private readonly unsafe Window* _windowPtr;

        private readonly BitArray _buttons = new BitArray(MaxButtons);
        private BitArray _buttonsPrevious = new BitArray(MaxButtons);

        internal unsafe MouseState(Window* windowPtr) => _windowPtr = windowPtr;

        private MouseState(MouseState source)
        {
            // Vector2 is a struct, so these should be value copies
            Position = source.Position;
            PreviousPosition = source.PreviousPosition;

            _buttons = (BitArray)source._buttons.Clone();
            _buttonsPrevious = (BitArray)source._buttonsPrevious.Clone();
        }

        /// <summary>
        ///     Gets a <see cref="Vector2" /> representing the absolute position of the pointer
        ///     in the current frame, relative to the top-left corner of the contents of the window.
        /// </summary>
        public Vector2 Position { get; internal set; }

        /// <summary>
        ///     Gets a <see cref="Vector2" /> representing the absolute position of the pointer
        ///     in the previous frame, relative to the top-left corner of the contents of the window.
        /// </summary>
        public Vector2 PreviousPosition { get; internal set; }

        /// <summary>
        ///     Gets a <see cref="Vector2" /> representing the amount that the mouse moved since the last frame.
        ///     This does not necessarily correspond to pixels, for example in the case of raw input.
        /// </summary>
        public Vector2 Delta => Position - PreviousPosition;

        /// <summary>
        ///     Gets a <see cref="bool" /> indicating whether the specified
        ///     <see cref="MouseButton" /> is pressed.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if key is pressed; <c>false</c> otherwise.</returns>
        public bool this[MouseButton button]
        {
            get => _buttons[(int)button];
            internal set => _buttons[(int)button] = value;
        }

        /// <summary>
        ///     Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public float X => Position.X;

        /// <summary>
        ///     Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public float Y => Position.Y;

        /// <summary>
        ///     Gets an integer representing the absolute x position of the pointer, in window pixel coordinates.
        /// </summary>
        public float PreviousX => PreviousPosition.X;

        /// <summary>
        ///     Gets an integer representing the absolute y position of the pointer, in window pixel coordinates.
        /// </summary>
        public float PreviousY => PreviousPosition.Y;

        /// <summary>
        ///     Gets a value indicating whether any button is down.
        /// </summary>
        /// <value><c>true</c> if any button is down; otherwise, <c>false</c>.</value>
        public bool IsAnyButtonDown
        {
            get
            {
                for (var i = 0; i < MaxButtons; i++)
                {
                    if (_buttons[i])
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        /// <summary>
        ///     Gets a <see cref="bool" /> indicating whether this button is down.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if the <paramref name="button" /> is down, otherwise <c>false</c>.</returns>
        public bool IsButtonDown(MouseButton button) => _buttons[(int)button];

        /// <summary>
        ///     Returns a <see cref="string" /> that represents the current <see cref="MouseState" />.
        /// </summary>
        /// <returns>A <see cref="string" /> that represents the current <see cref="MouseState" />.</returns>
        public override string ToString()
        {
            var b = new StringBuilder();
            for (var i = 0; i < MaxButtons; i++)
            {
                b.Append(_buttons[i] ? "1" : "0");
            }

            return $"[X={X}, Y={Y}, Buttons={b}]";
        }

        internal void Update()
        {
            _buttonsPrevious.SetAll(false);
            _buttonsPrevious.Or(_buttons);
            PreviousPosition = Position;

            unsafe
            {
                GLFW.GetCursorPos(_windowPtr, out var x, out var y);
                Position = new Vector2((float)x, (float)y);
            }
        }

        /// <summary>
        ///     Gets a <see cref="bool" /> indicating whether this button was down in the previous frame.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if the <paramref name="button" /> is down, otherwise <c>false</c>.</returns>
        public bool WasButtonDown(MouseButton button) => _buttonsPrevious[(int)button];

        /// <summary>
        ///     Gets an immutable snapshot of this MouseState.
        ///     This can be used to save the current mouse state for comparison later on.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this MouseState.</returns>
        public MouseState GetSnapshot() => new MouseState(this);
    }
}
