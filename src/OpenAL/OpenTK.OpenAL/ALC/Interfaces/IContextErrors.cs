using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the error-related context functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IContextErrors
    {
        /// <summary>
        /// Retrieves the error state of the current context on the given device, and clears it.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>The error.</returns>
        unsafe ContextError GetError(Device* device);
    }
}
