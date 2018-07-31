//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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

using System;

namespace OpenTK.Core.Utility
{
    /// <summary>
    /// Checks whether the specified type parameter is a blittable value type.
    /// </summary>
    /// <remarks>
    /// A blittable value type is a struct that only references other value types recursively,
    /// which allows it to be passed to unmanaged code directly.
    /// </remarks>
    public static class BlittableValueType
    {
        /// <summary>
        /// Checks whether type is a blittable value type.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <param name="type">An instance of the type to check.</param>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check<T>(T type)
        {
            return BlittableValueType<T>.Check();
        }

        /// <summary>
        /// Checks whether type is a blittable value type.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <param name="type">An instance of the type to check.</param>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check<T>(T[] type)
        {
            return BlittableValueType<T>.Check();
        }

        /// <summary>
        /// Checks whether type is a blittable value type.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <param name="type">An instance of the type to check.</param>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check<T>(T[,] type)
        {
            return BlittableValueType<T>.Check();
        }

        /// <summary>
        /// Checks whether type is a blittable value type.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <param name="type">An instance of the type to check.</param>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check<T>(T[,,] type)
        {
            return BlittableValueType<T>.Check();
        }

        /// <summary>
        /// Checks whether type is a blittable value type.
        /// </summary>
        /// <typeparam name="T">The type to check.</typeparam>
        /// <param name="type">An instance of the type to check.</param>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check<T>(T[][] type)
        {
            return BlittableValueType<T>.Check();
        }

        /// <summary>
        /// Returns the size of the specified value type in bytes or 0 if the type is not blittable.
        /// </summary>
        /// <typeparam name="T">The value type. Must be blittable.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the size of the type in bytes.</returns>
        /// <exception cref="ArgumentException">Occurs when type is not blittable.</exception>
        public static int StrideOf<T>(T type)
        {
            if (!Check(type))
            {
                throw new ArgumentException("type");
            }

            return BlittableValueType<T>.Stride;
        }

        /// <summary>
        /// Returns the size of a single array element in bytes  or 0 if the element is not blittable.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the size of the type in bytes.</returns>
        /// <exception cref="ArgumentException">Occurs when type is not blittable.</exception>
        public static int StrideOf<T>(T[] type)
        {
            if (!Check(type))
            {
                throw new ArgumentException("type");
            }

            return BlittableValueType<T>.Stride;
        }

        /// <summary>
        /// Returns the size of a single array element in bytes or 0 if the element is not blittable.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the size of the type in bytes.</returns>
        /// <exception cref="ArgumentException">Occurs when type is not blittable.</exception>
        public static int StrideOf<T>(T[,] type)
        {
            if (!Check(type))
            {
                throw new ArgumentException("type");
            }

            return BlittableValueType<T>.Stride;
        }

        /// <summary>
        /// Returns the size of a single array element in bytes or 0 if the element is not blittable.
        /// </summary>
        /// <typeparam name="T">The value type.</typeparam>
        /// <param name="type">An instance of the value type.</param>
        /// <returns>An integer, specifying the size of the type in bytes.</returns>
        /// <exception cref="ArgumentException">Occurs when type is not blittable.</exception>
        public static int StrideOf<T>(T[,,] type)
        {
            if (!Check(type))
            {
                throw new ArgumentException("type");
            }

            return BlittableValueType<T>.Stride;
        }
    }
}
