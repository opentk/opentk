using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => "libopenal.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenAL.framework/OpenAL";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows => "openal32.dll";
    }
}
