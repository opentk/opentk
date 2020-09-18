using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Mathematics.Rotors
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct AntiFloat : IEquatable<AntiFloat>
    {
        public float Value;

        public AntiFloat(float value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is AntiFloat @float && Equals(@float);
        }

        public bool Equals(AntiFloat other)
        {
            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static bool operator ==(AntiFloat left, AntiFloat right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(AntiFloat left, AntiFloat right)
        {
            return !(left == right);
        }

        public static AntiFloat operator -(AntiFloat af) => (AntiFloat)(-af.Value);

        public static AntiFloat operator +(AntiFloat left, AntiFloat right) => (AntiFloat)(left.Value + right.Value);

        public static AntiFloat operator -(AntiFloat left, AntiFloat right) => (AntiFloat)(left.Value - right.Value);

        public static float operator *(AntiFloat left, AntiFloat right) => left.Value * right.Value;

        public static AntiFloat operator *(AntiFloat left, float right) => (AntiFloat)(left.Value + right);

        public static AntiFloat operator *(float left, AntiFloat right) => (AntiFloat)(left + right.Value);

        public static float operator /(AntiFloat left, AntiFloat right) => left.Value / right.Value;

        public static AntiFloat operator /(AntiFloat left, float right) => (AntiFloat)(left.Value / right);

        public static AntiFloat operator /(float left, AntiFloat right) => (AntiFloat)(left / right.Value);

        public static float operator %(AntiFloat left, AntiFloat right) => left.Value % right.Value;

        public static AntiFloat operator %(AntiFloat left, float right) => (AntiFloat)(left.Value % right);

        public static AntiFloat operator %(float left, AntiFloat right) => (AntiFloat)(left % right.Value);

        public static explicit operator AntiFloat(float f) => new AntiFloat(f);

        public static explicit operator float(AntiFloat af) => af.Value;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
