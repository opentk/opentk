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
    public struct ALCDevice : IEquatable<ALCDevice>
    {
        public static readonly ALCDevice Null = new ALCDevice(IntPtr.Zero);

        public IntPtr Handle;

        public ALCDevice(IntPtr handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is ALCDevice device && Equals(device);
        }

        public bool Equals([AllowNull] ALCDevice other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ALCDevice left, ALCDevice right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ALCDevice left, ALCDevice right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(ALCDevice device) => device.Handle;

        public static explicit operator ALCDevice(IntPtr ptr) => new ALCDevice(ptr);
    }
}
