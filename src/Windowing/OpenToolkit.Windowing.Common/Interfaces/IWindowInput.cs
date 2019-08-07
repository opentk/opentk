﻿//
// IWindowInput.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common.Input;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    ///     Describes mouse, keyboard and hid input and cursor related information.
    /// </summary>
    public interface IWindowInput
    {
        /// <summary>
        /// Gets or sets the <see cref="OpenToolkit.Windowing.Common.Input.MouseCursor" /> for this window.
        /// </summary>
        /// <value>The cursor.</value>
        MouseCursor Cursor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is visible.
        /// </summary>
        bool CursorVisible { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mouse cursor is confined inside the window size.
        /// </summary>
        bool CursorGrabbed { get; set; }

        /// <summary>
        /// Gets the current state of the joysticks as of the last time the window processed events.
        /// </summary>
        JoystickState[] JoystickStates { get; }

        /// <summary>
        /// Gets the previous joystick state.
        /// This value is updated with the new state every time the window processes events.
        /// </summary>
        JoystickState[] LastJoystickStates { get; }

        /// <summary>
        ///     Gets the current state of the keyboard as of the last time the window processed events.
        /// </summary>
        KeyboardState KeyboardState { get; }

        /// <summary>
        ///     Gets the previous keyboard state.
        ///     This value is updated with the new state every time the window processes events.
        /// </summary>
        KeyboardState LastKeyboardState { get; }

        /// <summary>
        ///     Gets or sets the position of the mouse relative to the content area of this window.
        /// </summary>
        Vector2 MousePosition { get; set; }

        /// <summary>
        ///     Gets the amount that the mouse moved since the last frame.
        /// </summary>
        /// <summary>
        ///     This does not necessarily correspond to pixels, for example in the case of raw input.
        /// </summary>
        Vector2 MouseDelta { get; }

        /// <summary>
        ///     Gets the current state of the mouse as of the last time the window processed events.
        /// </summary>
        MouseState MouseState { get; }

        /// <summary>
        ///     Gets the previous keyboard state.
        ///     This value is updated with the new state every time the window processes events.
        /// </summary>
        MouseState LastMouseState { get; }

        /// <summary>
        /// Gets a value indicating whether any key is down.
        /// </summary>
        /// <value><c>true</c> if any key is down; otherwise, <c>false</c>.</value>
        bool IsAnyKeyDown { get; }

        /// <summary>
        /// Gets a value indicating whether any mouse button is pressed.
        /// </summary>
        /// <value><c>true</c> if any button is pressed; otherwise, <c>false</c>.</value>
        bool IsAnyMouseButtonDown { get; }

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently down.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the down state; otherwise, <c>false</c>.</returns>
        bool IsKeyDown(Key key);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this key is currently up.
        /// </summary>
        /// <param name="key">The <see cref="Key" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="key"/> is in the up state; otherwise, <c>false</c>.</returns>
        bool IsKeyUp(Key key);

        /// <summary>
        ///     Gets whether the specified key is pressed in the current frame but released in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="key">The key to check.</param>
        /// <returns>True if the key is pressed in this frame, but not the last frame.</returns>
        bool IsKeyPressed(Key key);

        /// <summary>
        ///     Gets whether the specified key is released in the current frame but pressed in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="key">The key to check.</param>
        /// <returns>True if the key is released in this frame, but pressed the last frame.</returns>
        bool IsKeyReleased(Key key);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this button is currently down.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="button"/> is in the down state; otherwise, <c>false</c>.</returns>
        bool IsMouseButtonDown(MouseButton button);

        /// <summary>
        /// Gets a <see cref="bool" /> indicating whether this mouse button is currently up.
        /// </summary>
        /// <param name="button">The <see cref="MouseButton" /> to check.</param>
        /// <returns><c>true</c> if <paramref name="button"/> is in the up state; otherwise, <c>false</c>.</returns>
        bool IsMouseButtonUp(MouseButton button);

        /// <summary>
        ///     Gets whether the specified mouse button is pressed in the current frame but released in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="button">The button to check.</param>
        /// <returns>True if the button is pressed in this frame, but not the last frame.</returns>
        bool IsMouseButtonPressed(MouseButton button);

        /// <summary>
        ///     Gets whether the specified mouse button is released in the current frame but pressed in the previous frame.
        /// </summary>
        /// <remarks>
        ///     "Frame" refers to invocations of <see cref="INativeWindow.ProcessEvents"/> here.
        /// </remarks>
        /// <param name="button">The button to check.</param>
        /// <returns>True if the button is released in this frame, but pressed the last frame.</returns>
        bool IsMouseButtonReleased(MouseButton button);
    }
}
