using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.OpenCL
{
    public class OpenCLLibraryNameContainer
    {
        public string Linux => "libOpenCL.so.1";

        public string MacOS => "/System/Library/Frameworks/OpenCL.framework/OpenCL";

        public string Android => "libOpenCL.so";

        public string IOS => MacOS;

        public string Windows => "OpenCL.dll";

        public string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID")))
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
