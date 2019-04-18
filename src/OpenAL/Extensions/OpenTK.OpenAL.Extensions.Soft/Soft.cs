using System;
using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by OpenAL Soft.
    /// </summary>
    public abstract class Soft : ExtensionBase, IStateSoft
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected Soft(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract bool GetBoolean(SoftStateBoolean param);

        /// <inheritdoc />
        public abstract double GetDouble(SoftStateDouble param);

        /// <inheritdoc />
        public abstract float GetFloat(SoftStateFloat param);

        /// <inheritdoc />
        public abstract int GetInteger(SoftStateInteger param);

        /// <inheritdoc />
        public abstract IntPtr GetPointer(StatePointer param);
    }
}
