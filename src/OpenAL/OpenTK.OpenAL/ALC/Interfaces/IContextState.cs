using Device = System.Void;

namespace OpenTK.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the state-related context functions of OpenAL 1.1.
    /// </summary>
    internal interface IContextState
    {
        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        unsafe string GetContextProperty(Device* device, GetContextString param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <param name="size">The size of the output buffer.</param>
        /// <param name="data">The output buffer.</param>
        /// <returns>The value.</returns>
        unsafe void GetContextProperty(Device* device, GetContextInteger param, int count, void* data);
    }
}
