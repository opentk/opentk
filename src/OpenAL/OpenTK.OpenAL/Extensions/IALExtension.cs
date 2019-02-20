using System;
using AdvancedDLSupport;
using OpenToolkit.Core.Extensions;

namespace OpenToolkit.OpenAL.Extensions
{
    /// <summary>
    /// Represents an OpenAL extension.
    /// </summary>
    public interface IALExtension : IAPIExtension
    {
        /// <summary>
        /// Gets the address of an extension function.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <returns>The function pointer.</returns>
        IntPtr GetProcAddress([CallerFree] string name);

        /// <summary>
        /// Gets the value of the named extension enumeration member.
        /// </summary>
        /// <param name="name">The name of the enumeration member.</param>
        /// <returns>The value of the member.</returns>
        int GetEnumValue([CallerFree] string name);
    }
}
