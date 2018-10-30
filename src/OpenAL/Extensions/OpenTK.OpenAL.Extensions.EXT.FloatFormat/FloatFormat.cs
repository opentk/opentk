using AdvancedDLSupport;
using OpenTK.Core.Loader;

namespace OpenTK.OpenAL.Extensions.EXT.FloatFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_float")]
    public abstract class FloatFormat : FormatExtensionBase<FloatBufferFormat>, IFloatFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected FloatFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
