using AdvancedDLSupport;
// ReSharper disable ExplicitCallerInfoArgument

namespace OpenToolkit.OpenAL.Extensions.Enumeration
{
    /// <summary>
    /// Defines the public API of the context-related functions of the Enumeration extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IEnumerationContextState
    {
        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        unsafe string GetString(Device* device, GetEnumerationContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        unsafe char* GetStringList(Device* device, GetEnumerationContextStringList param);
    }
}
