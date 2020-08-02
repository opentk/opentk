using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.Core.Loader
{
    /// <summary>
    /// Base class for a class that holds library names used on various platforms.
    /// </summary>
    public abstract class PlatformLibraryNameContainerBase : IPlatformLibraryNameContainer
    {
        /// <inheritdoc/>
        public abstract string Linux { get; }

        /// <inheritdoc/>
        public abstract string Windows { get; }

        /// <inheritdoc/>
        public abstract string MacOS { get; }

        /// <inheritdoc/>
        public abstract string Android { get; }

        /// <inheritdoc/>
        public abstract string IOS { get; }

        /// <inheritdoc/>
        public virtual string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID")))
                {
                    return Android;
                }

                return Linux;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Windows;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS")))
                {
                    return IOS;
                }

                return MacOS;
            }

            throw new NotSupportedException("The library name couldn't be resolved for the given platform.");
        }
    }
}
