using AdvancedDLSupport;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions.EXT.MULAWFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_MULAW")]
    public abstract class MULAWFormat : FormatExtensionBase<MULAWBufferFormat>, IMULAWFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected MULAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
