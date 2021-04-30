//
// EnumerateAll.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Exposes the API in the EnumerateAll extension.
    /// </summary>
    public class EnumerateAll : ALBase
    {
        /// <summary>
        /// The name of this AL extension.
        /// </summary>
        public const string ExtensionName = "ALC_ENUMERATE_ALL_EXT";

        static EnumerateAll()
        {
            // We need to register the resolver for OpenAL before we can DllImport functions.
            ALBase.RegisterOpenALResolver();
        }

        private EnumerateAll()
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
        [DllImport(ALC.Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern string GetString(ALDevice device, GetEnumerateAllContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [DllImport(ALC.Lib, EntryPoint = "alcGetString", ExactSpelling = true, CallingConvention = ALC.AlcCallingConv)]
        public static extern unsafe byte* GetStringList(ALDevice device, GetEnumerateAllContextStringList param);

        /// <inheritdoc cref="GetStringList(ALDevice, GetEnumerateAllContextStringList)"/>
        public static unsafe IEnumerable<string> GetStringList(GetEnumerateAllContextStringList param)
        {
            byte* result = GetStringList(ALDevice.Null, param);
            return ALC.ALStringListToList(result);
        }
    }
}
