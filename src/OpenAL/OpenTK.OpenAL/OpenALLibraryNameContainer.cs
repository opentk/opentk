using OpenTK.Core.Loader;

namespace OpenTK.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    internal class OpenALLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        public override string Linux => "libopenal.so.1";
        public override string MacOS => "/System/Library/Frameworks/OpenAL.framework/OpenAL";
        public override string Android => Linux;
        public override string IOS => MacOS;
        public override string Windows => "openal32.dll";
    }
}
