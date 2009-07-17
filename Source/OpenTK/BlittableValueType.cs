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

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace OpenTK
{
    /// <summary>
    /// Checks whether the specified type parameter is a blittable value type.
    /// </summary>
    /// <remarks>
    /// A blittable value type is a struct that only references other value types recursively,
    /// which allows it to be passed to unmanaged code directly.
    /// </remarks>
    /// <typeparam name="T">The struct to check.</typeparam>
    /// <exception cref="System.NotSupportedException">Raised when T is not a blittable value type.</exception>
    public struct BlittableValueType<T> where T : struct
    {
        /// <summary>
        /// Gets the size of the type in bytes.
        /// </summary>
        public static readonly int Stride = Marshal.SizeOf(typeof(T));

        static BlittableValueType()
        {
            Type type = typeof(T);
            
            if (!CheckStructLayoutAttribute(type))
                Debug.Print("Warning: type {0} does not specify a StructLayoutAttribute with Pack=1. The memory layout of the struct may change between platforms.", type.Name);

            if (!CheckType(type))
                throw new NotSupportedException(String.Format("Type {0} contains non-primitive fields.", type.Name));
        }

        // Checks whether the parameter is a primitive type or consists of primitive types recursively.
        // Throws a NotSupportedException if it is not.
        static bool CheckType(Type type)
        {
            //Debug.Print("Checking type {0} (size: {1} bytes).", type.Name, Marshal.SizeOf(type));
            if (type.IsPrimitive)
                return true;

            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Debug.Indent();
            foreach (FieldInfo field in fields)
            {
                if (!CheckType(field.FieldType))
                    return false;
            }
            Debug.Unindent();

            return true;
        }

        // Checks whether the specified struct defines [StructLayout(LayoutKind.Sequential, Pack=1)]
        // or [StructLayout(LayoutKind.Explicit)]
        static bool CheckStructLayoutAttribute(Type type)
        {
            StructLayoutAttribute[] attr = (StructLayoutAttribute[])
                type.GetCustomAttributes(typeof(StructLayoutAttribute), true);

            if ((attr == null) ||
                (attr != null && attr.Length > 0 && attr[0].Value != LayoutKind.Explicit && attr[0].Pack != 1))
                return false;

            return true;
        }
    }
}
