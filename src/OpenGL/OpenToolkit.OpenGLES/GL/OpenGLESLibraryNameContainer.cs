using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenGLES
{
    /// <summary>
    /// Contains the library name of OpenGLES.
    /// </summary>
    internal class OpenGLESLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => "libGLESv2.so";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";

        /// <inheritdoc />
        public override string Android => "libGLESv2.so";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/OpenGLES.framework/OpenGLES";

        /// <inheritdoc />
        public override string Windows => "libGLESv2.dll";
    }
}
