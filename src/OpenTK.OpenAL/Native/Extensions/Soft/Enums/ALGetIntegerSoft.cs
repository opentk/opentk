using OpenTK.OpenAL.Native.Interfaces;

namespace OpenTK.OpenAL.Native.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="int"/> <see cref="IALState.GetInteger"/> parameters.
    /// </summary>
    public enum ALGetIntegerSoft
    {
        /// <summary>
        /// Gets the number of available resamplers.
        /// </summary>
        ResamplerCount = 0x1210,

        /// <summary>
        /// Gets the default resampler. The return value corresponds to one of the members in
        /// <see cref="ALSoftResampler"/>.
        /// </summary>
        DefaultResampler = 0x1211
    }
}
