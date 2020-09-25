//
// JoystickState.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using System.Text;
using OpenTK.Windowing.Common.Input;

[assembly: InternalsVisibleTo("OpenTK.Windowing.Desktop")]

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Encapsulates the state of a joystick device.
    /// </summary>
    public sealed class JoystickState
    {
        private Hat[] _hats;
        private float[] _axes;
        private byte[] _buttons;

        private Hat[] _previousHats;
        private float[] _previousAxes;
        private byte[] _previousButtons;

        /// <summary>
        /// Gets the identity of the joystick this state describes.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets the name of the joystick this state describes.
        /// </summary>
        public string Name { get; }

        internal JoystickState(int hatCount, int axesCount, int buttonCount, int id, string name)
        {
            _hats = new Hat[hatCount];
            _axes = new float[axesCount];
            _buttons = new byte[buttonCount];

            _previousHats = new Hat[hatCount];
            _previousAxes = new float[axesCount];
            _previousButtons = new byte[buttonCount];

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
                Array.Copy(source._buttons, _buttons, source._buttons.Length);
                Array.Copy(source._previousHats, _previousHats, source._previousHats.Length);
                Array.Copy(source._previousAxes, _previousAxes, source._previousAxes.Length);
                Array.Copy(source._previousButtons, _previousButtons, source._previousButtons.Length);
        }

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        public Hat GetHat(int index)
        {
            return _hats[index];
        }

        /// <summary>
        /// Gets a <see cref="Hat"/> describing the previous state of a hat.
        /// </summary>
        /// <param name="index">The index of the hat to check.</param>
        /// <returns>A <see cref="Hat"/> describing the hat state.</returns>
        public Hat GetHatPrevious(int index)
        {
            return _previousHats[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetHat(int index, Hat value)
        {
            _hats[index] = value;
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing the state of a button.
        /// </summary>
        /// <param name="index">The index of the button to check.</param>
        /// <returns><c>true</c> if the button is down; <c>false</c> otherwise.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonDown(int index)
        {
            byte b = _buttons[index / 8];
            int pow = (int)Math.Pow(2, index % 8);

            return (b & pow) == pow;
        }

        /// <summary>
        /// Gets a <see cref="bool"/> describing whether the button was down and is now not down.
        /// </summary>
        /// <param name="index">The index of the button.</param>
        /// <returns>Returns true if the button was down, or false if the button was not down.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool WasButtonDown(int index)
        {
            byte bCurrent = _buttons[index / 8];
            byte bPrevious = _previousButtons[index / 8];
            int pow = (int)Math.Pow(2, index % 8);

            return (bCurrent & pow) != pow && (bPrevious & pow) == pow;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetButtonDown(int index, bool value)
        {
            int byteOffSet = index / 8;
            int bitOffset = index % 8;

            if (value)
            {
                _buttons[byteOffSet] |= (byte)(1 << bitOffset);
            }
            else
            {
                _buttons[byteOffSet] &= (byte)~(1 << bitOffset);
            }
        }

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        public float GetAxis(int index)
        {
            return _axes[index];
        }

        /// <summary>
        /// Gets a <see cref="float"/> between -1 and 1 describing the previous position of an axis.
        /// </summary>
        /// <param name="index">The index of the Axis to check.</param>
        /// <returns>A <see cref="float"/> between -1 and 1 describing the position of the axis.</returns>
        public float GetAxisPrevious(int index)
        {
            return _previousAxes[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxis(int index, float value)
        {
            _axes[index] = value < -1 ? -1 : (value > 1 ? 1 : value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxes(float[] axes)
        {
            _axes = axes;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            // string.Join internally uses a StringBuilder
            var joinedHats = string.Join(", ", _hats);
            var joinedAxes = string.Join(", ", _axes);

            var buttonBuilder = new StringBuilder();

            for (int i = 0; i < _buttons.Length * 8; i++)
            {
                buttonBuilder.Append($", {(IsButtonDown(i) ? "down" : "up")}");
            }

            // String Interpolation uses string.Format which internally uses a StringBuilder
            return $"{{id: {Id}, name: {Name}, hats: [{joinedHats}], axes: [{joinedAxes}], buttons: [{buttonBuilder}]}}";
        }

        internal unsafe void Update()
        {
            UpdateHats();

            UpdateAxes();

            UpdateButtons();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private unsafe void UpdateButtons()
        {
            Swap(ref _buttons, ref _previousButtons);

            var b = GLFW.GetJoystickButtonsRaw(Id, out int count);
            for (var j = 0; j < count; j++)
            {
                SetButtonDown(j, b[j] == JoystickInputAction.Press);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void UpdateAxes()
        {
            Swap(ref _axes, ref _previousAxes);

            var axes = GLFW.GetJoystickAxes(Id);
            SetAxes(axes);
        }

        private unsafe void UpdateHats()
        {
            Swap(ref _hats, ref _previousHats);

            var h = GLFW.GetJoystickHatsRaw(Id, out int count);
            for (var j = 0; j < count; j++)
            {
                SetHat(j, (Hat)h[j]);
            }
        }

        /// <summary>
        /// Gets an immutable snapshot of this JoystickState.
        /// </summary>
        /// <returns>Returns an immutable snapshot of this JoystickState.</returns>
        public JoystickState GetSnapshot()
        {
            return new JoystickState(this);
        }
    }
}
