using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface of the context in the OpenAL 1.1 library.
    /// </summary>
    [NativeSymbols(Prefix = "alc")]
    internal interface IALC : IContext, IContextDevices, IContextErrors, IContextExtensions, IContextState
    {
    }
}
