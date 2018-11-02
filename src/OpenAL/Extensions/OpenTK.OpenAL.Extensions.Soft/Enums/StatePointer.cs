using System;

namespace OpenToolkit.OpenAL.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="IntPtr"/> <see cref="IStateSoft.GetPointer"/> parameters.
    /// </summary>
    public enum StatePointer
    {
        /// <summary>
        /// Gets a pointer to the set event callback function.
        /// </summary>
        EventCallbackFunction = 0x1220,

        /// <summary>
        /// Gets a pointer to the set event callback user parameter.
        /// </summary>
        EventCallbackUserParameter = 0x1221
    }
}
