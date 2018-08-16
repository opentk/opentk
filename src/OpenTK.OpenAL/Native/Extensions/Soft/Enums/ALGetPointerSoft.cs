using System;

namespace OpenTK.OpenAL.Native.Extensions.Soft
{
    /// <summary>
    /// A list of valid <see cref="IntPtr"/> <see cref="IALStateSoft.GetPointer"/> parameters.
    /// </summary>
    public enum ALGetPointerSoft
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
