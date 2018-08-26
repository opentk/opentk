using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the Enumeration extension.
    /// </summary>
    [Extension("ALC_ENUMERATION_EXT")]
    public abstract class Enumeration : ContextExtensionBase, IEnumerationContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected Enumeration(string path, ImplementationOptions options) : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe char* GetString(void* device, GetEnumerationContextString param);

        /// <inheritdoc cref="GetString(void*, GetEnumerationContextString)"/>
        public string GetString(IntPtr device, GetEnumerationContextString param)
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
        public abstract unsafe char* GetStringList(void* device, GetEnumerationContextStringList param);

        /// <inheritdoc cref="GetString(void*, GetEnumerationContextStringList)"/>
        public IEnumerable<string> GetStringList(GetEnumerationContextStringList param)
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
