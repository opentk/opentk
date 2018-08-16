using OpenTK.OpenAL.Native.Interfaces;

namespace OpenTK.OpenAL.Native.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="double"/> <see cref="IALState.GetDouble"/> parameters. These enumeration members
    /// are defined as extensions in the OpenAL Soft library.
    /// </summary>
    public enum ALGetDoubleSoft
    {
        /// <summary>
        /// Gets the gain limit of the context.
        /// </summary>
        GainLimit = 0x200E
    }
}
