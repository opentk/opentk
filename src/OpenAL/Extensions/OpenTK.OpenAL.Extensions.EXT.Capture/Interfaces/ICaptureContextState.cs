using AdvancedDLSupport;
using Device = System.Void;

namespace OpenTK.OpenAL.Extensions.EXT.Capture
{
    /// <summary>
    /// Defines the public API of state-related functions in the Capture extension.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    public interface ICaptureContextState
    {
        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <param name="size">The size of the output buffer.</param>
        /// <param name="data">The output buffer.</param>
        /// <returns>The value.</returns>
        unsafe void GetContextProperty(Device* device, GetCaptureContextInteger param, int count, void* data);
    }
}
