using System;
using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Interfaces
{
    /// <summary>
    /// Defines the public interface for the extension-related functions of OpenAL 1.1. Furthermore, this interface is
    /// used to constrain extension implementation classes.
    /// </summary>
    public interface IALExtensions
    {
        /// <summary>
        /// Determines whether or not the named extension is available.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>true if the extension is available; otherwise, false.</returns>
        bool IsExtensionPresent([CallerFree] string name);

        /// <summary>
        /// Gets the address of an OpenAL extension function.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <returns>The function pointer.</returns>
        IntPtr GetProcAddress([CallerFree] string name);

        /// <summary>
        /// Gets the value of the named OpenAL extension enumeration member.
        /// </summary>
        /// <param name="name">The name of the enumeration member.</param>
        /// <returns>The value of the member.</returns>
        int GetEnumValue([CallerFree] string name);
    }
}
