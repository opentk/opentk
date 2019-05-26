using OpenToolkit.Core.Loader;

namespace OpenToolkit.OpenGL
{
    /// <summary>
    /// Contains the library name of OpenGL.
    /// </summary>
    internal class OpenGLLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => "libGL.so";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenGL.framework/OpenGL";

        /// <inheritdoc />
        public override string Android => "libGL.so";

        /// <inheritdoc />
        public override string IOS => "/System/Library/Frameworks/OpenGL.framework/OpenGL";

        /// <inheritdoc />
        public override string Windows => "opengl32.dll";
    }
}
