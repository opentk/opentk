/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */

using System;

namespace OpenTK.Core
{
    /// <summary>
    /// Represents a handle to an OpenGL or OpenAL context.
    /// </summary>
    public struct ContextHandle : IComparable<ContextHandle>, IEquatable<ContextHandle>
    {
        /// <summary>
        /// Gets a System.IntPtr that represents the handle of this ContextHandle.
        /// </summary>
        public IntPtr Handle { get; }

        /// <summary>
        /// A read-only field that represents a handle that has been initialized to zero.
        /// </summary>
        public static readonly ContextHandle Zero = new ContextHandle(IntPtr.Zero);

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextHandle"/> struct with the specified handle.
        /// </summary>
        /// <param name="h">A System.IntPtr containing the value for this instance.</param>
        public ContextHandle(IntPtr h)
        {
            Handle = h;
        }

        /// <summary>
        /// Converts the specified ContextHandle to the equivalent IntPtr.
        /// </summary>
        /// <param name="c">The ContextHandle to convert.</param>
        /// <returns>A System.IntPtr equivalent to the specified ContextHandle.</returns>
        public static explicit operator IntPtr(ContextHandle c)
        {
            return c != Zero ? c.Handle : IntPtr.Zero;
        }

        /// <summary>
        /// Converts the specified IntPtr to the equivalent ContextHandle.
        /// </summary>
        /// <param name="p">The System.IntPtr to convert.</param>
        /// <returns>A ContextHandle equivalent to the specified IntPtr.</returns>
        public static explicit operator ContextHandle(IntPtr p)
        {
            return new ContextHandle(p);
        }

        /// <summary>
        /// Compares two ContextHandles for equality.
        /// </summary>
        /// <param name="left">The ContextHandle to compare.</param>
        /// <param name="right">The ContextHandle to compare to.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        public static bool operator ==(ContextHandle left, ContextHandle right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two ContextHandles for inequality.
        /// </summary>
        /// <param name="left">The ContextHandle to compare.</param>
        /// <param name="right">The ContextHandle to compare to.</param>
        /// <returns>True if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(ContextHandle left, ContextHandle right)
        {
            return !left.Equals(right);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Handle.ToString();
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is ContextHandle handle)
            {
                return Equals(handle);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }

        /// <inheritdoc />
        public int CompareTo(ContextHandle other)
        {
            unsafe
            {
                return (int)((int*)other.Handle.ToPointer() - (int*)Handle.ToPointer());
            }
        }

        /// <inheritdoc />
        public bool Equals(ContextHandle other)
        {
            return Handle == other.Handle;
        }
    }
}
