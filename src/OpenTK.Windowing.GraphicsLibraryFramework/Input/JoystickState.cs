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
using OpenTK.Windowing.Common.Input;

[assembly: InternalsVisibleTo("OpenTK.Windowing.Desktop")]
[assembly: InternalsVisibleTo("OpenTK.Tests")]

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    ///     Encapsulates the state of a joystick device.
    /// </summary>
    public class JoystickState
    {
        private float[] _axes;
        private float[] _axesPrevious;
        private BitArray _buttons;
        private BitArray _buttonsPrevious;
        private Hat[] _hats;

        private Hat[] _hatsPrevious;

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
            _buttons = (BitArray)source._buttons.Clone(); // Array.Copy(source._buttons, _buttons, source._buttons.Length);
            Array.Copy(source._hatsPrevious, _hatsPrevious, source._hatsPrevious.Length);
            Array.Copy(source._axesPrevious, _axesPrevious, source._axesPrevious.Length);
            _buttonsPrevious = (BitArray)source._buttonsPrevious.Clone(); // Array.Copy(source._previousButtons, _previousButtons, source._previousButtons.Length);
        }

        /// <summary>
        ///     Gets the identity of the joystick this state describes.
        /// </summary>
        public int Id { get; }

        /// <summary>
        ///     Gets the name of the joystick this state describes.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Gets a <see cref="Hat" /> describing the state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat" /> describing the hat state.</returns>
        public Hat GetHat(int index) => _hats[index];

        /// <summary>
        ///     Gets a <see cref="Hat" /> describing the previous state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat" /> describing the hat state.</returns>
        public Hat GetHatPrevious(int index) => _hatsPrevious[index];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetHat(int index, Hat value)
        {
            _hats[index] = value;
        }

        /// <summary>
        ///     Gets a <see cref="bool" /> describing the state of a button in the current frame.
        /// </summary>
        /// <param name="index">The index of the button to check.</param>
        /// <returns><c>true</c> if the button is down; <c>false</c> otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonDown(int index) => _buttons[index];

        /// <summary>
        ///     Gets a <see cref="bool" /> describing whether the button was down in the previous frame.
        /// </summary>
        /// <param name="index">The index of the button.</param>
        /// <returns>Returns true if the button was down, or false if the button was not down.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool WasButtonDown(int index) => _buttonsPrevious[index];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetButtonDown(int index, bool value)
        {
            _buttons[index] = value;
        }

        /// <summary>
        ///     Gets a <see cref="float" /> between -1 and 1 describing the position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float" /> between -1 and 1 describing the position of the axis.</returns>
        public float GetAxis(int index) => _axes[index];

        /// <summary>
        ///     Gets a <see cref="float" /> between -1 and 1 describing the previous position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float" /> between -1 and 1 describing the position of the axis.</returns>
        public float GetAxisPrevious(int index) => _axesPrevious[index];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxis(int index, float value)
        {
            _axes[index] = value < -1 ? -1 : value > 1 ? 1 : value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxes(Span<float> axes)
        {
            if (axes.Length > _axes.Length)
            {
                _axes = new float[axes.Length];
            }
            axes.CopyTo(_axes);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            // string.Join internally uses a StringBuilder
            var joinedHats = string.Join(", ", _hats);
            var joinedAxes = string.Join(", ", _axes);

            var buttonBuilder = new StringBuilder();

            for (var i = 0; i < _buttons.Length * 8; i++)
            {
                buttonBuilder.Append($", {(IsButtonDown(i) ? "down" : "up")}");
            }

            // String Interpolation uses string.Format which internally uses a StringBuilder
            return $"{{id: {Id}, name: {Name}, hats: [{joinedHats}], axes: [{joinedAxes}], buttons: [{buttonBuilder}]}}";
        }

        internal void Update()
        {
            UpdateHats();

            UpdateAxes();

            UpdateButtons();
        }

        private unsafe void UpdateButtons()
        {
            Utils.Swap(ref _buttons, ref _buttonsPrevious);

            var b = GLFW.GetJoystickButtonsRaw(Id, out var count);
            for (var j = 0; j < count; j++)
            {
                SetButtonDown(j, b[j] == JoystickInputAction.Press);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void UpdateAxes()
        {
            Utils.Swap(ref _axes, ref _axesPrevious);

            var axes = GLFW.GetJoystickAxes(Id);
            SetAxes(axes);
        }

        private unsafe void UpdateHats()
        {
            Utils.Swap(ref _hats, ref _hatsPrevious);

            var h = GLFW.GetJoystickHatsRaw(Id, out var count);
            for (var j = 0; j < count; j++)
            {
                SetHat(j, (Hat)h[j]);
            }
        }

        /// <summary>
        ///     Gets an immutable snapshot of this JoystickState.
        ///     This can be used to save the current joystick state for comparison later on.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this JoystickState.</returns>
        public JoystickState GetSnapshot() => new JoystickState(this);
    }
}
