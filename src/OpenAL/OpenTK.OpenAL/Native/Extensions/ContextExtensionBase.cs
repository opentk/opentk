using System;
using AdvancedDLSupport;
using OpenTK.OpenAL.Native.Interfaces;

namespace OpenTK.OpenAL.Native.Extensions
{
    /// <summary>
    /// Base class for OpenAL context extensions.
    /// </summary>
    public abstract class ContextExtensionBase : NativeLibraryBase, IContextExtensions
    {
        /// <inheritdoc cref="NativeLibraryBase"/>
        protected ContextExtensionBase(string path, ImplementationOptions options)
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
