//
// JoystickState.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using OpenTK.Core;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Common.Input;

[assembly: InternalsVisibleTo("OpenTK.Windowing.Desktop")]
[assembly: InternalsVisibleTo("OpenTK.Tests")]

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Encapsulates the state of a joystick device.
    /// </summary>
    public class JoystickState
    {
        private Hat[] _hats;
        private float[] _axes;
        private BitArray _buttons;

        private Hat[] _hatsPrevious;
        private float[] _axesPrevious;
        private BitArray _buttonsPrevious;

        /// <summary>
        /// Gets the identity of the joystick this state describes.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the joystick this state describes.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the number of buttons on the joystick this state describes.
        /// </summary>
        public int ButtonCount { get => _buttons.Length; }

        /// <summary>
        /// Gets the number of axes on the joystick this state describes.
        /// </summary>
        public int AxisCount { get => _axes.Length; }

        /// <summary>
        /// Gets the number of hats on the joystick this state describes.
        /// </summary>
        public int HatCount { get => _hats.Length; }

        internal JoystickState(int hatCount, int axesCount, int buttonCount, int id, string name)
        {
            _hats = new Hat[hatCount];
            _axes = new float[axesCount];
            _buttons = new BitArray(buttonCount);

            _hatsPrevious = new Hat[hatCount];
            _axesPrevious = new float[axesCount];
            _buttonsPrevious = new BitArray(buttonCount);

            Id = id;
            Name = name;
        }

        private JoystickState(JoystickState source)
            : this(
                   source._hats.Length,
                   source._axes.Length,
                   source._buttons.Length,
                   source.Id,
                   source.Name)
        {
            Array.Copy(source._hats, _hats, source._hats.Length);
            Array.Copy(source._axes, _axes, source._axes.Length);
            _buttons.Or(source._buttons);

            Array.Copy(source._hatsPrevious, _hatsPrevious, source._hatsPrevious.Length);
            Array.Copy(source._axesPrevious, _axesPrevious, source._axesPrevious.Length);
            _buttonsPrevious.Or(source._buttonsPrevious);
        }

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Hat GetHat(int index)
        {
            return _hats[index];
        }

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the previous state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Hat GetHatPrevious(int index)
        {
            return _hatsPrevious[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetHat(int index, Hat value)
        {
            _hats[index] = value;
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing the state of a button in the current frame.
        /// </summary>
        /// <param name="index">The index of the button to check.</param>
        /// <returns><c>true</c> if the button is down; <c>false</c> otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonDown(int index)
        {
            return _buttons[index];
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing whether the button was down in the previous frame.
        /// </summary>
        /// <param name="index">The index of the button.</param>
        /// <returns>Returns true if the button was down, or false if the button was not down.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool WasButtonDown(int index)
        {
            return _buttonsPrevious[index];
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing whether the specified button is down in the current frame but was up in the previous frame.
        /// </summary>
        /// <remarks>
        /// "Frame" refers to invocations of <see cref="NativeWindow.ProcessEvents(double)"/>  (<see cref="NativeWindow.ProcessInputEvents()"/> more precisely) here.
        /// </remarks>
        /// <param name="index">The index of the button.</param>
        /// <returns>True if the button is down in this frame, but not the last frame.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonPressed(int index)
        {
            return IsButtonDown(index) && !WasButtonDown(index);
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing whether the specified button is up in the current frame but was down in the previous frame.
        /// </summary>
        /// <remarks>
        /// "Frame" refers to invocations of <see cref="NativeWindow.ProcessEvents(double)"/>  (<see cref="NativeWindow.ProcessInputEvents()"/> more precisely) here.
        /// </remarks>
        /// <param name="index">The index of the button.</param>
        /// <returns>True if the button is up in this frame, but down the last frame.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonReleased(int index)
        {
            return !IsButtonDown(index) && WasButtonDown(index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetButtonDown(int index, bool value)
        {
            _buttons[index] = value;
        }

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float GetAxis(int index)
        {
            return _axes[index];
        }

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the previous position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float GetAxisPrevious(int index)
        {
            return _axesPrevious[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxes(ReadOnlySpan<float> axes)
        {
            if (axes.Length > _axes.Length)
            {
                _axes = new float[axes.Length];
            }
            axes.CopyTo(_axes);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            // string.Join internally uses a StringBuilder
            string joinedHats = string.Join(", ", _hats);
            string joinedAxes = string.Join(", ", _axes);

            StringBuilder buttonBuilder = new StringBuilder();

            for (int i = 0; i < _buttons.Length; i++)
            {
                buttonBuilder.Append($", {(IsButtonDown(i) ? "down" : "up")}");
            }

            // String Interpolation uses string.Format which internally uses a StringBuilder
            return $"{{id: {Id}, name: {Name}, hats: [{joinedHats}], axes: [{joinedAxes}], buttons: [{buttonBuilder}]}}";
        }

        internal unsafe void NewFrame()
        {
            UpdateHats();

            UpdateAxes();

            UpdateButtons();
        }

        private unsafe void UpdateButtons()
        {
            (_buttons, _buttonsPrevious) = (_buttonsPrevious, _buttons);

            ReadOnlySpan<JoystickInputAction> buttons = GLFW.GetJoystickButtons(Id);
            for (var j = 0; j < buttons.Length; j++)
            {
                SetButtonDown(j, buttons[j] == JoystickInputAction.Press);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void UpdateAxes()
        {
            (_axes, _axesPrevious) = (_axesPrevious, _axes);

            ReadOnlySpan<float> axes = GLFW.GetJoystickAxes(Id);
            SetAxes(axes);
        }

        private unsafe void UpdateHats()
        {
            (_hats, _hatsPrevious) = (_hatsPrevious, _hats);

            ReadOnlySpan<JoystickHats> hats = GLFW.GetJoystickHats(Id);
            for (var j = 0; j < hats.Length; j++)
            {
                // FIXME: If we ever want to change the Hat enum this is going to break horribly.
                SetHat(j, (Hat)hats[j]);
            }
        }

        /// <summary>
        /// Gets an immutable snapshot of this JoystickState.
        /// This can be used to save the current joystick state for comparison later on.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this JoystickState.</returns>
        public JoystickState GetSnapshot()
        {
            return new JoystickState(this);
        }
    }
}
