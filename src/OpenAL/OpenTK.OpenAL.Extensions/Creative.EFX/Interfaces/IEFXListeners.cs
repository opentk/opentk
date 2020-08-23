//
// IEfXListeners.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace OpenTK.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines the public API of the listener-related functions of the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFXListeners
    {
        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Listenerf")]
        void SetListenerProperty(uint listener, EFXListenerFloat param, float value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="listener">The listener.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetListenerf")]
        void GetListenerProperty(uint listener, EFXListenerFloat param, out float value);
    }
}
