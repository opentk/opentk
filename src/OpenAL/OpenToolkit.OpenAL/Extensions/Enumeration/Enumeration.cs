//
// Enumeration.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenToolkit.Audio.OpenAL.Native;

namespace OpenToolkit.Audio.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Exposes the API in the Enumeration extension.
    /// </summary>
    [Api(AL.Lib, typeof(OpenALLibraryNameContainer))]
    public abstract class Enumeration : ApiContainer<Enumeration>
    {
        /// <summary>
        /// The name of this AL extension.
        /// </summary>
        public const string ExtensionName = "ALC_ENUMERATION_EXT";

        static Enumeration()
        {
            _ = ApiContainer<Enumeration>.StaticConstructorTrigger;
        }

        private Enumeration()
        {
        }

        /// <summary>
        /// Checks whether the extension is present.
        /// </summary>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsExtensionPresent()
        {
            return ALC.IsExtensionPresent(ALDevice.Null, ExtensionName);
        }

        /// <summary>
        /// Checks whether the extension is present.
        /// </summary>
        /// <param name="device">The device to be queried.</param>
        /// <returns>Whether the extension was present or not.</returns>
        public static bool IsExtensionPresent(ALDevice device)
        {
            return ALC.IsExtensionPresent(device, ExtensionName);
        }

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [DllImport(AL.Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        public static extern string GetString(ALDevice device, GetEnumerationContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [DllImport(ALC.Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = ALC.AlcCalliningConv)]
        public static extern unsafe byte* GetStringList(ALDevice device, GetEnumerationContextStringList param);

        /// <inheritdoc cref="GetString(ALDevice, GetEnumerationContextString)"/>
        public static IEnumerable<string> GetStringList(GetEnumerationContextStringList param)
        {
            unsafe
            {
                byte* result = GetStringList(ALDevice.Null, param);
                if (result == (byte*)0)
                {
                    return new List<string>();
                }

                var strings = new List<string>();

                byte* currentPos = result;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (string.IsNullOrEmpty(currentString))
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
