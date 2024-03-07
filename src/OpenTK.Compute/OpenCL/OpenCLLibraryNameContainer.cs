using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.OpenCL
{
    /// <summary>
    /// Contains the library name of OpenCL.
    /// </summary>
    public class OpenCLLibraryNameContainer
    {
        /// <summary>
        /// Overrides any platform detection logic and directly searches for the OpenCL library using the provided path.
        /// If this is <c>null</c> then no override will happen.
        /// </summary>
        public static string OverridePath { get; set; } = null;

        public string Linux => "libOpenCL.so.1";

        /// <summary>
        /// Gets the library name to use on MacOS.
        /// </summary>
        public string MacOS => "/System/Library/Frameworks/OpenCL.framework/OpenCL";

        public string Android => "libOpenCL.so";

        /// <summary>
        /// Gets the library name to use on iOS.
        /// </summary>
        public string IOS => MacOS;

        /// <summary>
        /// Gets the library name to use on Windows.
        /// </summary>
        public string Windows => "OpenCL.dll";

        /// <summary>
        /// Gets the library name for the target platform.
        /// </summary>
        /// <returns>Library name.</returns>
        public string GetLibraryName()
        {
            if (OverridePath != null)
            {
                return OverridePath;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID")))
            {
                return Android;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return Linux;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Windows;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS")))
            {
                return IOS;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return MacOS;
            }
            else
            {
                throw new NotSupportedException($"The library name couldn't be resolved for the given platform ('{RuntimeInformation.OSDescription}').");
            }
        }
    }
}
