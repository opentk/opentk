using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Defines available parameters for <see cref="IContextState.GetContextProperty(OpenToolkit.OpenAL.Device*,GetContextString)" />.
    /// </summary>
    public enum GetContextString
    {
        /// <summary>
        /// A list of available context extensions separated by spaces.
        /// </summary>
        Extensions = 0x1006,

        /// <summary>
        /// Gets the name of the provided device.
        /// </summary>
        DeviceSpecifier = 0x1005,
    }
}
