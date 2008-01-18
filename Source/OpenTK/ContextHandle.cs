using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    internal class ContextHandle : /*System.Runtime.InteropServices.SafeHandle,*/ IComparable<ContextHandle>
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
            return c.handle;
        }

        public static implicit operator ContextHandle(IntPtr p)
        {
            return new ContextHandle(p);
        }
    }
}
