using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Extensions.EXT.DoubleFormat
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    public abstract class DoubleFormat : FormatExtensionBase<DoubleBufferFormat>, IDoubleFormat
    {
        /// <inheritdoc cref="ExtensionBase"/>
        protected DoubleFormat(string path, ImplementationOptions options)
            : base(path, options)
        {
        }
    }
}
