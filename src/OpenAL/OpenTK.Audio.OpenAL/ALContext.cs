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
    public struct ALContext : IEquatable<ALContext>
    {
        public static readonly ALContext Null = new ALContext(IntPtr.Zero);

        public IntPtr Handle;

        public ALContext(IntPtr handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is ALContext handle && Equals(handle);
        }

        public bool Equals([AllowNull] ALContext other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ALContext left, ALContext right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ALContext left, ALContext right)
        {
            return !(left == right);
        }

        public static implicit operator IntPtr(ALContext context) => context.Handle;
    }
}
