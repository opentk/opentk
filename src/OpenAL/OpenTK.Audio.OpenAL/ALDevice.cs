//
// ALDevice.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Diagnostics.CodeAnalysis;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Opaque handle to an OpenAL device.
    /// </summary>
    public struct ALDevice : IEquatable<ALDevice>
    {
        public static readonly ALDevice Null = new ALDevice(IntPtr.Zero);

        public IntPtr Handle;

        public ALDevice(IntPtr handle)
        {
            Handle = handle;
        }

        public override readonly bool Equals(object obj)
        {
            return obj is ALDevice device && Equals(device);
        }

        public readonly bool Equals([AllowNull] ALDevice other)
        {
            return Handle.Equals(other.Handle);
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ALDevice left, ALDevice right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ALDevice left, ALDevice right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(ALDevice device) => device.Handle;
    }
}
