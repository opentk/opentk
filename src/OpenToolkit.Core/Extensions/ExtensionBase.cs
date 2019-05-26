//
// ExtensionBase.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Core.Extensions
{
    /// <summary>
    /// Base class for extensions.
    /// </summary>
    public abstract class ExtensionBase : NativeLibraryBase, IAPIExtension
    {
        /// <inheritdoc cref="NativeLibraryBase"/>
        protected ExtensionBase(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract IPlatformLibraryNameContainer NameContainer { get; }

        /// <inheritdoc />
        public abstract bool IsExtensionPresent(string name);

        /// <inheritdoc />
        public abstract IntPtr GetProcAddress(string name);

        /// <inheritdoc />
        public abstract int GetEnumValue(string name);
    }
}
