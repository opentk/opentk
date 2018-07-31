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
