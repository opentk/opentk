using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="double"/> <see cref="IState.GetDouble"/> parameters. These enumeration members
    /// are defined as extensions in the OpenAL Soft library.
    /// </summary>
    public enum SoftStateDouble
    {
        /// <summary>
        /// Gets the gain limit of the context.
        /// </summary>
        GainLimit = 0x200E
    }
}
