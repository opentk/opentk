using System;
using AdvancedDLSupport;
using OpenTK.OpenAL.Native.Interfaces;

namespace OpenTK.OpenAL.Native.Extensions
{
    /// <summary>
    /// Base class for OpenAL extensions.
    /// </summary>
    public abstract class ExtensionBase : NativeLibraryBase, IALExtensions
    {
        /// <inheritdoc cref="ExtensionBase"/>
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
