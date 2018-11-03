using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="int"/> <see cref="IState.GetInteger"/> parameters.
    /// </summary>
    public enum SoftStateInteger
    {
        /// <summary>
        /// Gets the number of available resamplers.
        /// </summary>
        ResamplerCount = 0x1210,

        /// <summary>
        /// Gets the default resampler. The return value corresponds to one of the members in
        /// <see cref="Resampler"/>.
        /// </summary>
        DefaultResampler = 0x1211
    }
}
