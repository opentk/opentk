//
// GL.cs
//
// Copyright (C) OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;
using System.Text;
using AdvancedDLSupport;
using OpenToolkit.Core.Loader;
using OpenToolkit.Core.Native;

namespace OpenToolkit.OpenGL
{
    public partial class GL : NativeLibraryBase, IGL
    {
        /// <inheritdoc cref="NativeLibraryBase"/>
        protected GL(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <summary>
        /// Gets the library name container for this profile.
        /// </summary>
        public IPlatformLibraryNameContainer NameContainer => new OpenGLLibraryNameContainer();
    }
}
