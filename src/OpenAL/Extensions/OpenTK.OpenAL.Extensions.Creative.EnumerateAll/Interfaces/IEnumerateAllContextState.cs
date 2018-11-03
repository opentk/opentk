using AdvancedDLSupport;
// ReSharper disable ExplicitCallerInfoArgument

namespace OpenToolkit.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Defines the public API of the context-related functions of the EnumerateAll extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IEnumerateAllContextState
    {
        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        unsafe string GetString(Device* device, GetEnumerateAllContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        unsafe char* GetStringList(Device* device, GetEnumerateAllContextStringList param);
    }
}
