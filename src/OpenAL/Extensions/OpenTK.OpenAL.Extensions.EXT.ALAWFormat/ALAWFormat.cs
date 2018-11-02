using AdvancedDLSupport;
using OpenToolkit.Core.Loader;
using OpenToolkit.OpenAL.Extensions.EXT.ALAWFormat.Enums;
using OpenToolkit.OpenAL.Extensions.EXT.ALAWFormat.Interfaces;

namespace OpenToolkit.OpenAL.Extensions.EXT.ALAWFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_ALAW")]
    public abstract class ALAWFormat : FormatExtensionBase<ALAWBufferFormat>, IALAWFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected ALAWFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
