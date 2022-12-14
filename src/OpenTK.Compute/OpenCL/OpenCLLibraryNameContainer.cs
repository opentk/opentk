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
        /// Gets the library name to use on Linux.
        /// </summary>
        public string Linux => "libOpenCL.so.1";

        /// <summary>
        /// Gets the library name to use on MacOS.
        /// </summary>
        public string MacOS => "/System/Library/Frameworks/OpenCL.framework/OpenCL";

        /// <summary>
        /// Gets the library name to use on Android.
        /// </summary>
        public string Android => Linux;

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
            if (OperatingSystem.IsLinux() || OperatingSystem.IsFreeBSD())
            {
                return Linux;
            }
            else if (OperatingSystem.IsWindows())
            {
                return Windows;
            }
            else if (OperatingSystem.IsMacOS())
            {
                return MacOS;
            }
            else if (OperatingSystem.IsAndroid())
            {
                return Android;
            }
            else if (OperatingSystem.IsIOS())
            {
                return IOS;
            }
	        else
	        {
		        throw new NotSupportedException($"The library name couldn't be resolved for the given platform ('{RuntimeInformation.OSDescription}').");
	        }
        }
    }
}
