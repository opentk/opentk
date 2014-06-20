// #region License
//
// IntPtrExtensions.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// #endregion
using System;

namespace OpenTK.Extensions
{
    /// <summary>
    /// Defines extensions to simplify usage of <see cref="System.IntPtr"/>
    /// </summary>
    public static class IntPtrExtensions
    {
        /// <summary>
        /// Compares two <see cref="System.IntPtr"/> instances.
        /// </summary>
        /// <returns>A value indicating the relative order of the two instances.</returns>
        /// <param name="left">The left <see cref="System.IntPtr"/> instance.</param>
        /// <param name="right">The right <see cref="System.IntPtr"/> instance.</param>
        public static int CompareTo(this IntPtr left, IntPtr right)
        {
            return ((long)left).CompareTo((long)right);
        }
    }
}

