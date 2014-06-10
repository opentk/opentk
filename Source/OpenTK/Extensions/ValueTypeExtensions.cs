// #region License
//
// ValueTypeExtensions.cs
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
    /// Contains extension methods to simplify
    /// bindings with value type parameters
    /// </summary>
    public static class ValueTypeExtensions
    {
        /// <summary>
        /// Returns the total size of the specified type in bytes.
        /// </summary>
        /// <typeparam name="T">The value type. Must be blittable.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the total size of the type in bytes.</returns>
        /// <exception cref="System.ArgumentException">Occurs when type is not blittable.</exception>
        public static IntPtr Size<T>(this T type)
            where T : struct
        {
            return (IntPtr)BlittableValueType.SizeOf(type);
        }

        /// <summary>
        /// Returns the total size of the specified array in bytes.
        /// Use <see cref="ValueTypeExtensions.Size{T}(T)" /> to get the size
        /// of a single array element.
        /// </summary>
        /// <typeparam name="T">The value type. Must be blittable.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the total size of the type in bytes.</returns>
        /// <exception cref="System.ArgumentException">Occurs when type is not blittable.</exception>
        [CLSCompliant(false)]
        public static IntPtr Size<T>(this T[] type)
            where T : struct
        {
            return (IntPtr)BlittableValueType.SizeOf(type);
        }

        /// <summary>
        /// Returns the total size of the specified array in bytes.
        /// Use <see cref="ValueTypeExtensions.Size{T}(T)" /> to get the size
        /// of a single array element.
        /// </summary>
        /// <typeparam name="T">The value type. Must be blittable.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the total size of the type in bytes.</returns>
        /// <exception cref="System.ArgumentException">Occurs when type is not blittable.</exception>
        [CLSCompliant(false)]
        public static IntPtr Size<T>(this T[,] type)
            where T : struct
        {
            return (IntPtr)BlittableValueType.SizeOf(type);
        }

        /// <summary>
        /// Returns the total size of the specified array in bytes.
        /// Use <see cref="ValueTypeExtensions.Size{T}(T)" /> to get the size
        /// of a single array element.
        /// </summary>
        /// <typeparam name="T">The value type. Must be blittable.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the total size of the type in bytes.</returns>
        /// <exception cref="System.ArgumentException">Occurs when type is not blittable.</exception>
        [CLSCompliant(false)]
        public static IntPtr Size<T>(this T[,,] type)
            where T : struct
        {
            return (IntPtr)BlittableValueType.SizeOf(type);
        }
    }
}
