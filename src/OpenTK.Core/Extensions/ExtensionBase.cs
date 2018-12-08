using System;
using AdvancedDLSupport;

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
        public abstract bool IsExtensionPresent(string name);

        /// <inheritdoc />
        public abstract IntPtr GetProcAddress(string name);

        /// <inheritdoc />
        public abstract int GetEnumValue(string name);
    }
}
