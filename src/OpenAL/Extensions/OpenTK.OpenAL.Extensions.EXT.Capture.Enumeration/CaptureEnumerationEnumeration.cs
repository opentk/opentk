using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the CaptureEnumerationEnumeration extension.
    /// </summary>
    [Extension("ALC_ENUMERATION_EXT")]
    public abstract class CaptureEnumerationEnumeration : ContextExtensionBase, ICaptureEnumerationContextState
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected CaptureEnumerationEnumeration(string path, ImplementationOptions options) : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe char* GetString(void* device, GetCaptureEnumerationContextString param);

        /// <inheritdoc cref="GetString(void*, GetCaptureEnumerationContextString)"/>
        public string GetString(IntPtr device, GetCaptureEnumerationContextString param)
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
        public abstract unsafe char* GetStringList(void* device, GetCaptureContextStringList param);

        /// <inheritdoc cref="GetString(void*, GetCaptureContextStringList)"/>
        public IEnumerable<string> GetStringList(GetCaptureContextStringList param)
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
