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
    /// <inheritdoc />
    internal sealed class JoystickState : IJoystickState
    {
        private const int StatePositionCount = 2;

        private int _current = StatePositionCount - 1;
        private int _previous = StatePositionCount - 2;

        private Hat[][] _hats;
        private float[][] _axes;
        private byte[][] _buttons;

        /// <inheritdoc />
        public int Id { get; }

        /// <inheritdoc />
        public string Name { get; }

        internal JoystickState(int hatCount, int axesCount, int buttonCount, int id, string name)
        {
            _hats = new Hat[StatePositionCount][];
            _axes = new float[StatePositionCount][];
            _buttons = new byte[StatePositionCount][];

            for (int i = 0; i < StatePositionCount; i++)
            {
                _hats[i] = new Hat[hatCount];
                _axes[i] = new float[axesCount];
                _buttons[i] = new byte[(buttonCount + 7) / 8];
            }

            Id = id;
            Name = name;
        }

        private JoystickState(JoystickState source)
            : this(
                   source._hats[0].Length,
                   source._axes[0].Length,
                   source._buttons[0].Length,
                   source.Id,
                   source.Name)
        {
            for (int i = 0; i < StatePositionCount; i++)
            {
                Array.Copy(source._hats[i], _hats[i], source._hats[i].Length);
                Array.Copy(source._axes[i], _axes[i], source._axes[i].Length);
                Array.Copy(source._buttons[i], _buttons[i], source._buttons[i].Length);
            }

            _current = source._current;
            _previous = source._previous;
        }

        /// <inheritdoc />
        public Hat GetHat(int index)
        {
            return _hats[_current][index];
        }

        /// <inheritdoc />
        public Hat GetHatPrevious(int index)
        {
            return _hats[_previous][index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetHat(int index, Hat value)
        {
            _hats[_current][index] = value;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonDown(int index)
        {
            byte b = _buttons[_current][index / 8];
            int pow = (int)Math.Pow(2, index % 8);

            return (b & pow) == pow;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool WasButtonDown(int index)
        {
            byte bCurrent = _buttons[_current][index / 8];
            byte bPrevious = _buttons[_previous][index / 8];
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
                _buttons[_current][byteOffSet] |= (byte)(1 << bitOffset);
            }
            else
            {
                _buttons[_current][byteOffSet] &= (byte)~(1 << bitOffset);
            }
        }

        /// <inheritdoc />
        public float GetAxis(int index)
        {
            return _axes[_current][index];
        }

        /// <inheritdoc />
        public float GetAxisPrevious(int index)
        {
            return _axes[_previous][index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxis(int index, float value)
        {
            _axes[_current][index] = value < -1 ? -1 : (value > 1 ? 1 : value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxes(float[] axes)
        {
            _axes[_current] = axes;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            // string.Join internally uses a StringBuilder
            var joinedHats = string.Join(", ", _hats[_current]);
            var joinedAxes = string.Join(", ", _axes[_current]);

            var buttonBuilder = new StringBuilder();

            for (int i = 0; i < _buttons.Length * 8; i++)
            {
                buttonBuilder.Append($", {(IsButtonDown(i) ? "down" : "up")}");
            }

            // String Interpolation uses string.Format which internally uses a StringBuilder
            return $"{{hats: [{joinedHats}], axes: [{joinedAxes}], buttons: [{buttonBuilder}], id: {Id}, name: {Name}}}";
        }

        internal unsafe void Update()
        {
            _previous = _current;
            _current++;
            _current %= StatePositionCount;

            var h = GLFW.GetJoystickHatsRaw(Id, out var count);
            for (var j = 0; j < count; j++)
            {
                SetHat(j, (Hat)h[j]);
            }

            var axes = GLFW.GetJoystickAxes(Id);
            SetAxes(axes);

            var b = GLFW.GetJoystickButtonsRaw(Id, out count);
            for (var j = 0; j < count; j++)
            {
                SetButtonDown(j, b[j] == JoystickInputAction.Press);
            }
        }

        /// <inheritdoc/>
        public IJoystickState GetSnapshot()
        {
            return new JoystickState(this);
        }
    }
}
