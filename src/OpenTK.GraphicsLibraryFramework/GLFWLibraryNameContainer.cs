//
// GLFWLibraryNameContainer.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Contains the library name of GLFW.
    /// </summary>
    internal class GLFWLibraryNameContainer : PlatformLibraryNameContainerBase
    {
        /// <inheritdoc />
        public override string Linux => throw new NotImplementedException("Get the name of the linux shared object file");

        /// <inheritdoc />
        public override string MacOS => throw new NotImplementedException("Get the path of the glfw install");

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows => "glfw3.dll";
    }
}
