using OpenToolkit.Core.Loader;

namespace OpenToolkit.Compute.OpenCL
{
    public class OpenClLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => "libOpenCL.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenCL.framework/OpenCL";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows => "OpenCL.dll";
    }
}
