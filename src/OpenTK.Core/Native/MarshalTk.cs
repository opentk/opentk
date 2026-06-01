using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Core.Native
{
    /// <summary>
    /// Contains extra marshalling utilities that aren't available in the normal Marshal class.
    /// </summary>
    public static class MarshalTk
    {
        /// <summary>
        /// Copies the contents of a managed <see cref="T:string[]"/> to a block of memory allocated from the unmanaged COM task allocator.
        /// This function allocates multiple pieces of memory and needs to be freed with <see cref="FreeStringArrayCoTaskMem(nint, int)"/>.
        /// </summary>
        /// <param name="stringArray">The string array to marshal.</param>
        /// <returns>An integer representing a pointer to the block of memory allocated for the string array.</returns>
        public static unsafe IntPtr StringArrayToCoTaskMemAnsi(ReadOnlySpan<string> stringArray)
        {
            IntPtr* ptrs = (IntPtr*)Marshal.AllocCoTaskMem(stringArray.Length * sizeof(IntPtr));
            for (int i = 0; i < stringArray.Length; i++)
            {
                ptrs[i] = Marshal.StringToCoTaskMemAnsi(stringArray[i]);
            }
            return (IntPtr)ptrs;
        }

        /// <summary>
        /// Copies the contents of a managed <see cref="T:string[]"/> to a block of memory allocated from the unmanaged COM task allocator.
        /// This function allocates multiple pieces of memory and needs to be freed with <see cref="FreeStringArrayCoTaskMem(nint, int)"/>.
        /// </summary>
        /// <param name="stringArray">The string array to marshal.</param>
        /// <returns>An integer representing a pointer to the block of memory allocated for the string array.</returns>
        public static unsafe IntPtr StringArrayToCoTaskMemAuto(ReadOnlySpan<string> stringArray)
        {
            IntPtr* ptrs = (IntPtr*)Marshal.AllocCoTaskMem(stringArray.Length * sizeof(IntPtr));
            for (int i = 0; i < stringArray.Length; i++)
            {
                ptrs[i] = Marshal.StringToCoTaskMemAuto(stringArray[i]);
            }
            return (IntPtr)ptrs;
        }

        /// <summary>
        /// Copies the contents of a managed <see cref="T:string[]"/> to a block of memory allocated from the unmanaged COM task allocator.
        /// This function allocates multiple pieces of memory and needs to be freed with <see cref="FreeStringArrayCoTaskMem(nint, int)"/>.
        /// </summary>
        /// <param name="stringArray">The string array to marshal.</param>
        /// <returns>An integer representing a pointer to the block of memory allocated for the string array.</returns>
        public static unsafe IntPtr StringArrayToCoTaskMemUni(ReadOnlySpan<string> stringArray)
        {
            IntPtr* ptrs = (IntPtr*)Marshal.AllocCoTaskMem(stringArray.Length * sizeof(IntPtr));
            for (int i = 0; i < stringArray.Length; i++)
            {
                ptrs[i] = Marshal.StringToCoTaskMemUni(stringArray[i]);
            }
            return (IntPtr)ptrs;
        }

        /// <summary>
        /// Copies the contents of a managed <see cref="T:string[]"/> to a block of memory allocated from the unmanaged COM task allocator.
        /// This function allocates multiple pieces of memory and needs to be freed with <see cref="FreeStringArrayCoTaskMem(nint, int)"/>.
        /// </summary>
        /// <param name="stringArray">The string array to marshal.</param>
        /// <returns>An integer representing a pointer to the block of memory allocated for the string array.</returns>
        public static unsafe IntPtr StringArrayToCoTaskMemUTF8(ReadOnlySpan<string> stringArray)
        {
            IntPtr* ptrs = (IntPtr*)Marshal.AllocCoTaskMem(stringArray.Length * sizeof(IntPtr));
            for (int i = 0; i < stringArray.Length; i++)
            {
                ptrs[i] = Marshal.StringToCoTaskMemUTF8(stringArray[i]);
            }
            return (IntPtr)ptrs;
        }

        /// <summary>
        /// Frees an allocated string array using the StringArrayToCoTaskMem* functions.
        /// </summary>
        /// <param name="stringArray">The address of the string array to free.</param>
        /// <param name="length">The number of strings in the array.</param>
        public static unsafe void FreeStringArrayCoTaskMem(IntPtr stringArray, int length)
        {
            IntPtr* ptrs = (IntPtr*)stringArray;
            for (int i = 0; i < length; i++)
            {
                Marshal.FreeCoTaskMem(ptrs[i]);
            }
            Marshal.FreeCoTaskMem(stringArray);
        }

        /// <summary>
        /// Marshals a <see cref="T:byte**"/> ansi string array into a <see cref="T:string[]"/>.
        /// </summary>
        /// <param name="strArrayPtr">The ansi string array pointer.</param>
        /// <param name="length">The number of strings in the array.</param>
        /// <returns>The managed string array.</returns>
        public static unsafe string[] StringArrayPtrToStringArrayAnsi(IntPtr strArrayPtr, uint length)
        {
            string[] arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Marshal.PtrToStringAnsi(((IntPtr*)strArrayPtr)[i]);
            }
            return arr;
        }

        /// <summary>
        /// Marshals a <see cref="IntPtr"/> ansi string array into a <see cref="T:string[]"/>.
        /// </summary>
        /// <param name="strArrayPtr">The string array pointer.</param>
        /// <param name="length">The number of strings in the array.</param>
        /// <returns>The managed string array.</returns>
        public static unsafe string[] StringArrayPtrToStringArrayAuto(IntPtr strArrayPtr, uint length)
        {
            string[] arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Marshal.PtrToStringAuto(((IntPtr*)strArrayPtr)[i]);
            }
            return arr;
        }

        /// <summary>
        /// Marshals a <see cref="IntPtr"/> ansi string array into a <see cref="T:string[]"/>.
        /// </summary>
        /// <param name="strArrayPtr">The string array pointer.</param>
        /// <param name="length">The number of strings in the array.</param>
        /// <returns>The managed string array.</returns>
        public static unsafe string[] StringArrayPtrToStringArrayUni(IntPtr strArrayPtr, uint length)
        {
            string[] arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Marshal.PtrToStringUni(((IntPtr*)strArrayPtr)[i]);
            }
            return arr;
        }

        /// <summary>
        /// Marshals a <see cref="IntPtr"/> ansi string array into a <see cref="T:string[]"/>.
        /// </summary>
        /// <param name="strArrayPtr">The string array pointer.</param>
        /// <param name="length">The number of strings in the array.</param>
        /// <returns>The managed string array.</returns>
        public static unsafe string[] StringArrayPtrToStringArrayUTF8(IntPtr strArrayPtr, uint length)
        {
            string[] arr = new string[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Marshal.PtrToStringUTF8(((IntPtr*)strArrayPtr)[i]);
            }
            return arr;
        }
    }
}
