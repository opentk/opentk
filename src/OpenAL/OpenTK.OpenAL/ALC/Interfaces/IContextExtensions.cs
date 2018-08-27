using System;
using AdvancedDLSupport;
using OpenTK.OpenAL.Extensions;

namespace OpenTK.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the extension-related context functions of OpenAL 1.1. Furthermore, this interface is
    /// used to constrain extension implementation classes.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IContextExtensions
    {
        /// <summary>
        /// Determines whether or not the named extension is available.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>true if the extension is available; otherwise, false.</returns>
        unsafe bool IsExtensionPresent(void* device, [CallerFree] string name);

        /// <summary>
        /// Gets the address of an OpenAL extension function.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <returns>The function pointer.</returns>
        unsafe void* GetProcAddress(void* device, [CallerFree] string name);

        /// <summary>
        /// Gets the value of the named OpenAL extension enumeration member.
        /// </summary>
        /// <param name="name">The name of the enumeration member.</param>
        /// <returns>The value of the member.</returns>
        unsafe int GetEnumValue(void* device, [CallerFree] string name);
    }
}
