//
// OpenALLibrarynameContainer.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    public class OpenALLibraryNameContainer
    {
        /// <summary>
        /// Gets the library name to use on Windows.
        /// </summary>
        public string Windows => "openal32.dll";

        /// <summary>
        /// Gets the library name to use on Linux.
        /// </summary>
        public string Linux => "libopenal.so.1";

        /// <summary>
        /// Gets the library name to use on MacOS.
        /// </summary>
        public string MacOS => "/System/Library/Frameworks/OpenAL.framework/OpenAL";

        /// <summary>
        /// Gets the library name to use on Android.
        /// </summary>
        public string Android => Linux;

        /// <summary>
        /// Gets the library name to use on iOS.
        /// </summary>
        public string IOS => MacOS;

        /// <summary>
        /// Gets the library name for the target platform.
        /// </summary>
        /// <returns>Library name.</returns>
        public string GetLibraryName()
        {
            if (OperatingSystem.IsLinux() ||
                OperatingSystem.IsFreeBSD())
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
