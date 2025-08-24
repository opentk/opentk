//
// ALContext.cs
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
    public struct ALCContext : IEquatable<ALCContext>
    {
        public static readonly ALCContext Null = new ALCContext(IntPtr.Zero);

        public IntPtr Handle;

        public ALCContext(IntPtr handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is ALCContext handle && Equals(handle);
        }

        public bool Equals([AllowNull] ALCContext other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ALCContext left, ALCContext right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ALCContext left, ALCContext right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(ALCContext context) => context.Handle;

        public static explicit operator ALCContext(IntPtr ptr) => new ALCContext(ptr);
    }
}
