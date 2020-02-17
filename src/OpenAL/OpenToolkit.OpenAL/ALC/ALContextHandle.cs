// ALContextHandle.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OpenToolkit.Audio.OpenAL
{
    public struct ALContextHandle : IEquatable<ALContextHandle>
    {
        public static readonly ALContextHandle Zero = new ALContextHandle(IntPtr.Zero);

        public IntPtr Handle;

        public ALContextHandle(IntPtr handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is ALContextHandle handle && Equals(handle);
        }

        public bool Equals([AllowNull] ALContextHandle other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ALContextHandle left, ALContextHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ALContextHandle left, ALContextHandle right)
        {
            return !(left == right);
        }
    }
}
