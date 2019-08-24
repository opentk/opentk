using System.Runtime.InteropServices;
using AdvancedDLSupport.Loaders;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Graphics.GL
{
    /// <summary>
    /// Contains the library name of OpenGL.
    /// </summary>
    internal class LibraryNameContainer : PlatformLibraryNameContainerBase
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
