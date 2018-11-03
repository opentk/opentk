using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface of the OpenAL 1.1 library.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IAL : IBuffers, IErrors, IExtensions, IListener, ISources, IState
    {
    }
}
