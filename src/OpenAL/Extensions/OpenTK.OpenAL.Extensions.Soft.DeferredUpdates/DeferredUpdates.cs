using System;
using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Extensions.Soft.DeferredUpdates
{
    /// <summary>
    /// Exposes the public API of the OpenAL Soft Deferred Updates extension.
    /// </summary>
    public abstract class DeferredUpdates : ExtensionBase, IDeferredUpdatesState
    {
        /// <inheritdoc cref ="ExtensionBase"/>
        protected DeferredUpdates(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract bool GetBoolean(DeferredStateBoolean param);

        /// <inheritdoc />
        public abstract void DeferUpdates();

        /// <inheritdoc />
        public abstract void ProcessUpdates();
    }
}
