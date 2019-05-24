//
// IContextState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the state-related context functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IContextState
    {
        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        unsafe string GetContextProperty(Device* device, GetContextString param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <param name="count">The size of the output buffer.</param>
        /// <param name="data">The output buffer.</param>
        [NativeSymbol("GetIntegerv")]
        unsafe void GetContextProperty(Device* device, GetContextInteger param, int count, IntPtr data);
    }
}
