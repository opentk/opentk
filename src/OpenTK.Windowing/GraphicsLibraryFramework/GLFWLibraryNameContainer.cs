using OpenToolkit.Core.Loader;
using System;

namespace OpenToolkit.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class GLFWLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => throw new NotImplementedException("Get the name of the linux shared object file");

        /// <inheritdoc />
        public override string MacOS => throw new NotImplementedException("Get the path of the glfw install");

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows => "glfw3.dll";
    }
}
