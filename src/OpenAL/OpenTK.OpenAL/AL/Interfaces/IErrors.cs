using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the error-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IErrors
    {
        /// <summary>
        /// Gets the current error state, then clears it.
        /// </summary>
        /// <returns>The error.</returns>
        AudioError GetError();
    }
}
