//
// ALCaptureDevice.cs
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
    /// Handle to an OpenAL capture device.
    /// </summary>
    public struct ALCaptureDevice : IEquatable<ALCaptureDevice>
    {
        public static readonly ALCaptureDevice Null = new ALCaptureDevice(IntPtr.Zero);

        public IntPtr Handle;

        public ALCaptureDevice(IntPtr handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is ALCaptureDevice device && Equals(device);
        }

        public bool Equals([AllowNull] ALCaptureDevice other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ALCaptureDevice left, ALCaptureDevice right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ALCaptureDevice left, ALCaptureDevice right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(ALCaptureDevice device) => device.Handle;
    }
}
