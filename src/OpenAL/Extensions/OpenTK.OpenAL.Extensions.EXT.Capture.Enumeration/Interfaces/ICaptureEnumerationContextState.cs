using AdvancedDLSupport;
using OpenToolkit.OpenAL.Extensions.Enumeration;

// ReSharper disable ExplicitCallerInfoArgument
namespace OpenToolkit.OpenAL.Extensions.EXT.Capture.Enumeration
{
    /// <summary>
    /// Defines the public API of the context-related functions of the Capture extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface ICaptureEnumerationContextState
    {
        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        unsafe string GetString(Device* device, GetCaptureEnumerationContextString param);

        /// <summary>
        /// Gets a named property on the context.
        /// </summary>
        /// <param name="device">The device for the context.</param>
        /// <param name="param">The named property.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetString")]
        unsafe char* GetStringList(Device* device, GetCaptureContextStringList param);
    }
}
