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
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenTK.Core.Utility
{
    /// <summary>
    /// Checks whether the specified type parameter is a blittable value type.
    /// </summary>
    /// <typeparam name="T">The type to check.</typeparam>
    /// <remarks>
    /// A blittable value type is a struct that only references other value types recursively,
    /// which allows it to be passed to unmanaged code directly.
    /// </remarks>
    public static class BlittableValueType<T>
    {
        private static readonly Type Type;

        static BlittableValueType()
        {
            Type = typeof(T);
            if (Type.IsValueType && !Type.IsGenericType)
            {
                // Does this support generic types? On Mono 2.4.3 it does
                // On .Net it doesn't.
                // http://msdn.microsoft.com/en-us/library/5s4920fa.aspx
                Stride = Marshal.SizeOf(typeof(T));
            }
        }

        /// <summary>
        /// Gets the size of the type in bytes or 0 for non-blittable types.
        /// </summary>
        /// <remarks>
        /// This property returns 0 for non-blittable types.
        /// </remarks>
        public static int Stride { get; }

        /// <summary>
        /// Checks whether the current typename T is blittable.
        /// </summary>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check()
        {
            return Check(Type);
        }

        /// <summary>
        /// Checks whether type is a blittable value type.
        /// </summary>
        /// <param name="type">A System.Type to check.</param>
        /// <returns>True if T is blittable; false otherwise.</returns>
        public static bool Check(Type type)
        {
            if (!CheckStructLayoutAttribute(type))
            {
                Debug.Print
                (
                    $"Warning: type {type.Name} does not specify a StructLayoutAttribute with Pack=1. " +
                    "The memory layout of the struct may change between platforms."
                );
            }

            return CheckType(type);
        }

        // Checks whether the parameter is a primitive type or consists of primitive types recursively.
        // Throws a NotSupportedException if it is not.
        private static bool CheckType(Type type)
        {
            if (type.IsPrimitive)
            {
                return true;
            }

            if (!type.IsValueType)
            {
                return false;
            }

            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (fields.Any(field => !CheckType(field.FieldType)))
            {
                return false;
            }

            return Stride != 0;
        }

        // Checks whether the specified struct defines [StructLayout(LayoutKind.Sequential, Pack=1)]
        // or [StructLayout(LayoutKind.Explicit)]
        private static bool CheckStructLayoutAttribute(Type type)
        {
            if (!(type.GetCustomAttribute(typeof(StructLayoutAttribute), true) is StructLayoutAttribute attr))
            {
                return false;
            }

            if (attr.Value != LayoutKind.Explicit && attr.Pack != 1)
            {
                return false;
            }

            return true;
        }
    }
}
