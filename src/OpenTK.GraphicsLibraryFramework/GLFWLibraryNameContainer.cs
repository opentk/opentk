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
        public override string Linux => "libglfw.so.3.3";

        /// <inheritdoc />
        public override string MacOS => "libglfw.dylib";

        /// <inheritdoc />
        public override string Android => Linux;

        /// <inheritdoc />
        public override string IOS => MacOS;

        /// <inheritdoc />
        public override string Windows => Environment.Is64BitProcess ? "glfw3-x64.dll" : "glfw3-x86.dll";
    }
}
