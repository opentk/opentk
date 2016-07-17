#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

#if EXPERIMENTAL

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Compute
{
    #region struct Handle<T>

    struct Handle<T> : IEquatable<Handle<T>>, IComparable<Handle<T>>
    {
        #region Fields

        IntPtr handle;

        /// <summary>
        /// Gets a System.IntPtr that represents the handle of this ContextHandle.
        /// </summary>
        public IntPtr Value { get { return handle; } }

        /// <summary>A read-only field that represents a handle that has been initialized to zero.</summary>
        public static readonly Handle<T> Zero = new Handle<T>(IntPtr.Zero);

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance with the specified handle.
        /// </summary>
        /// <param name="h">A System.IntPtr containing the value for this instance.</param>
        public Handle(IntPtr h) { handle = h; }

        #endregion

        #region Public Members

        #region ToString

        /// <summary>
        /// Converts this instance to its equivalent string representation.
        /// </summary>
        /// <returns>A System.String that contains the string representation of this instance.</returns>
        public override string ToString()
        {
            return Value.ToString();
        }

        #endregion

        #region Equals

        /// <summary>
        /// Compares this instance to the specified object.
        /// </summary>
        /// <param name="obj">The System.Object to compare to.</param>
        /// <returns>True if obj is a ContextHandle that is equal to this instance; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Handle<T>)
                return this.Equals((Handle<T>)obj);
            return false;
        }

        #endregion

        #region GetHashCode

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A System.Int32 with the hash code of this instance.</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        #endregion

        #region public static explicit operator IntPtr(Handle<T> c)

        /// <summary>
        /// Converts the specified ContextHandle to the equivalent IntPtr.
        /// </summary>
        /// <param name="c">The ContextHandle to convert.</param>
        /// <returns>A System.IntPtr equivalent to the specified ContextHandle.</returns>
        public static explicit operator IntPtr(Handle<T> c)
        {
            return c != Handle<T>.Zero ? c.Value : IntPtr.Zero;
        }

        #endregion

        #region public static explicit operator Handle<T>(IntPtr p)

        /// <summary>
        /// Converts the specified IntPtr to the equivalent ContextHandle.
        /// </summary>
        /// <param name="p">The System.IntPtr to convert.</param>
        /// <returns>A ContextHandle equivalent to the specified IntPtr.</returns>
        public static explicit operator Handle<T>(IntPtr p)
        {
            return new Handle<T>(p);
        }

        #endregion

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The instance to compare.</param>
        /// <param name="right">The instance to compare to.</param>
        /// <returns>True if left is equal to right; false otherwise.</returns>
        public static bool operator ==(Handle<T> left, Handle<T> right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The instance to compare.</param>
        /// <param name="right">The instance to compare to.</param>
        /// <returns>True if left is not equal to right; false otherwise.</returns>
        public static bool operator !=(Handle<T> left, Handle<T> right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region IComparable<Handle<T>> Members

        /// <summary>
        /// Compares the numerical value of this instance to other and returns a value indicating their relative order.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>Less than 0, if this instance is less than other; 0 if both are equal; Greater than 0 if other is greater than this instance.</returns>
        public int CompareTo(Handle<T> other)
        {
            unsafe
            {
                return Value.ToInt64().CompareTo(other.Value.ToInt64());
            }
        }

        #endregion

        #region IEquatable<Handle<T>> Members

        /// <summary>
        /// Compares this instance to the specified ContextHandle for equality.
        /// </summary>
        /// <param name="other">The ContextHandle to compare to.</param>
        /// <returns>True if this instance is equal to other; false otherwise.</returns>
        public bool Equals(Handle<T> other)
        {
            return Value == other.Value;
        }

        #endregion
    }

    #endregion

}

#endif