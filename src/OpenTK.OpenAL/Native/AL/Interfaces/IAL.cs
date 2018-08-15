using System.Runtime.InteropServices;
using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Interfaces
{
    /// <summary>
    /// Defines the public interface of the OpenAL 1.1 library.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IAL : IALState
    {

    }
}
