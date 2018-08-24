using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenTK.OpenAL.Native.Extensions;

namespace OpenTK.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Exposes the API in the EnumerateAll extension.
    /// </summary>
    public abstract class EnumerateAll : ExtensionBase, IEnumerateAllContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected EnumerateAll(string path, ImplementationOptions options) : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe char* GetString(void* device, GetEnumerateAllContextString param);

        /// <inheritdoc cref="GetString(void*, GetEnumerateAllContextString)"/>
        public string GetString(IntPtr device, GetEnumerateAllContextString param)
        {
            unsafe
            {
                var result = GetString(device.ToPointer(), param);
                if (result != (char*)0)
                {
                    return Marshal.PtrToStringAnsi(new IntPtr(result));
                }
            }

            return string.Empty;
        }

        /// <inheritdoc />
        public abstract unsafe char* GetStringList(void* device, GetEnumerateAllContextStringList param);

        /// <inheritdoc cref="GetString(void*, GetEnumerateAllContextStringList)"/>
        public IEnumerable<string> GetStringList(GetEnumerateAllContextStringList param)
        {
            unsafe
            {
                var result = GetStringList(null, param);
                if (result == (char*)0)
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                var currentPos = result;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (currentString is null)
                    {
                        break;
                    }

                    strings.Add(currentString);
                    currentPos += currentString.Length + 1;
                }

                return strings;
            }
        }
    }
}
