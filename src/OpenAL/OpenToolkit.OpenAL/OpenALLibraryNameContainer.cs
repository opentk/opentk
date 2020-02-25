//
// OpenALLibrarynameContainer.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
    /// <summary>
    /// Contains the library name of OpenAL.
    /// </summary>
    public class OpenALLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => "libopenal.so.1";

        /// <inheritdoc />
        public override string MacOS => "/System/Library/Frameworks/OpenAL.framework/OpenAL";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows => "openal32.dll";
    }
}
