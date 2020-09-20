//
// JoystickState.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using OpenTK.Windowing.Common.Input;

[assembly: InternalsVisibleTo("OpenTK.Windowing.Desktop")]

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <inheritdoc />
    public sealed class JoystickState : IJoystickState
    {
        private Hat[][] _hats;
        private float[][] _axes;
        private byte[][] _buttons;

        /// <inheritdoc />
        public int Id { get; }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public bool IsConnected { get; }

        internal JoystickState(int hatCount, int axesCount, int buttonCount, int id, string name)
        {
            _hats = new Hat[2][];
            _hats[0] = new Hat[hatCount];
            _hats[1] = new Hat[hatCount];
            _axes = new float[2][];
            _axes[0] = new float[axesCount];
            _axes[1] = new float[axesCount];
            _buttons = new byte[2][];
            _buttons[0] = new byte[(buttonCount + 7) / 8];
            _buttons[1] = new byte[(buttonCount + 7) / 8];
            Id = id;
            Name = name;
            IsConnected = true;
        }

        private JoystickState(JoystickState source)
        {
            Id = source.Id;
            Name = source.Name;
            IsConnected = source.IsConnected;

            _hats = new Hat[2][];
            _axes = new float[2][];
            _buttons = new byte[2][];
            for (int i = 0; i < 2; i++)
            {
                Array.Copy(source._hats[i], _hats[i], source._hats[i].Length);
                Array.Copy(source._axes[i], _axes[i], source._axes[i].Length);
                Array.Copy(source._buttons[i], _buttons[i], source._buttons[i].Length);
            }
        }

        /// <inheritdoc />
        public Hat GetHat(int index)
        {
            return _hats[0][index];
        }

        /// <inheritdoc />
        public Hat GetHatPrevious(int index)
        {
            return _hats[1][index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetHat(int index, Hat value)
        {
            _hats[0][index] = value;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsButtonDown(int index)
        {
            byte b = _buttons[0][index / 8];
            int pow = (int)Math.Pow(2, index % 8);

            return (b & pow) == pow;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool WasButtonDown(int index)
        {
            byte b0 = _buttons[0][index / 8];
            byte b1 = _buttons[1][index / 8];
            int pow = (int)Math.Pow(2, index % 8);

            return (b0 & pow) == pow && (b1 & pow) != pow;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetButtonDown(int index, bool value)
        {
            int byteOffSet = index / 8;
            int bitOffset = index % 8;

            if (value)
            {
                _buttons[0][byteOffSet] |= (byte)(1 << bitOffset);
            }
            else
            {
                _buttons[0][byteOffSet] &= (byte)~(1 << bitOffset);
            }
        }

        /// <inheritdoc />
        public float GetAxis(int index)
        {
            return _axes[0][index];
        }

        /// <inheritdoc />
        public float GetAxisPrevious(int index)
        {
            return _axes[1][index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxis(int index, float value)
        {
            _axes[0][index] = value < -1 ? -1 : (value > 1 ? 1 : value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetAxes(float[] axes)
        {
            _axes[0] = axes;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            int hashCode = _axes.GetHashCode();
            hashCode ^= _hats.GetHashCode();
            hashCode ^= _buttons.GetHashCode();
            hashCode ^= Id.GetHashCode();
            hashCode ^= Name.GetHashCode();

            return hashCode;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("{hats: [");
            builder.Append(_hats[0][0]);
            for (int i = 1; i < _hats.Length; i++)
            {
                builder.Append(", ");
                builder.Append(_hats[0][i]);
            }

            builder.Append("], axes: [");
            builder.Append(_axes[0][0]);
            for (int i = 1; i < _axes.Length; i++)
            {
                builder.Append(", ");
                builder.Append(_axes[0][i]);
            }

            builder.Append("], buttons: [");
            builder.Append(IsButtonDown(0) ? "down" : "up");
            for (int i = 0; i < _buttons.Length * 8; i++)
            {
                builder.Append(", ");
                builder.Append(IsButtonDown(0) ? "down" : "up");
            }

            builder.Append("], id: ");
            builder.Append(Id);
            builder.Append(", name: ");
            builder.Append(Name);
            builder.Append("}");

            return builder.ToString();
        }

        internal unsafe void Update()
        {
            Array.Copy(_hats[0], _hats[1], _hats[0].Length);
            Array.Copy(_axes[0], _axes[1], _axes[0].Length);
            Array.Copy(_buttons[0], _buttons[1], _buttons[0].Length);

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
