using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the Enumeration extension.
    /// </summary>
    [Extension("ALC_ENUMERATION_EXT")]
    public abstract class Enumeration : ContextExtensionBase, IEnumerationContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected Enumeration(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe string GetString(Device* device, GetEnumerationContextString param);

        /// <inheritdoc />
        public abstract unsafe char* GetStringList(Device* device, GetEnumerationContextStringList param);

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
