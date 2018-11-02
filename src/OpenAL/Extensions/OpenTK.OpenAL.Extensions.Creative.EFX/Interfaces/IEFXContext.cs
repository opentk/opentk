using System;
using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument

namespace OpenToolkit.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines the public API of the context-related functions in the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IEFXContext
    {
        /// <summary>
        /// Gets a vector of integer properties from the context.
        /// </summary>
        /// <param name="device">The audio device.</param>
        /// <param name="param">The named property.</param>
        /// <param name="size">The size of the provided buffer.</param>
        /// <param name="data">A pointer to the first element of a provided data buffer.</param>
        [NativeSymbol("GetIntegerv")]
        unsafe void GetContextProperty(IntPtr device, EFXContextInteger param, int size, int* data);
    }
}
