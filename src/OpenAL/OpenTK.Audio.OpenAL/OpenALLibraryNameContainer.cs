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
        /// Overrides any platform detection logic and directly searches for the OpenAL library using the provided path.
        /// If this is <c>null</c> then no override will happen.
        /// </summary>
        public static string OverridePath { get; set; } = null;

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
        public string Android => "libopenal.so";

        /// <summary>
        /// Gets the library name to use on iOS.
        /// </summary>
        public string IOS => MacOS;

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
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
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
