using AdvancedDLSupport;
using OpenToolkit.OpenAL.Extensions;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the extension-related functions of OpenAL 1.1. Furthermore, this interface is
    /// used to constrain extension implementation classes.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IExtensions : IAPIExtension
    {
    }
}
