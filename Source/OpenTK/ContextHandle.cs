#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    public class ContextHandle : /*System.Runtime.InteropServices.SafeHandle,*/ IComparable<ContextHandle>
    {
        IntPtr handle;
        public IntPtr Handle { get { return handle; } }

        public ContextHandle() /*: base(IntPtr.Zero, true)*/ { }
        public ContextHandle(IntPtr h) { handle = h; }

        #region IComparable<ContextHandle> Members

        public int CompareTo(ContextHandle other)
        {
            unsafe { return (int)((int*)other.handle.ToPointer() - (int*)this.handle.ToPointer()); }
        }

        #endregion

        public override string ToString()
        {
            return Handle.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is ContextHandle)
                return this.Handle == ((ContextHandle)obj).Handle;
            return false;
        }

        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }

        /// <summary>A read-only field that represents a handle that has been initialized to zero.</summary>
        public static readonly ContextHandle Zero = new ContextHandle(IntPtr.Zero);

        /*
        public override bool IsInvalid
        {
            get { return handle == IntPtr.Zero; }
        }

        protected override bool ReleaseHandle()
        {
            throw new NotImplementedException();
        }
        */

        public static implicit operator IntPtr(ContextHandle c)
        {
            return c != null ? c.handle : IntPtr.Zero;
        }

        public static implicit operator ContextHandle(IntPtr p)
        {
            return new ContextHandle(p);
        }
    }
}
