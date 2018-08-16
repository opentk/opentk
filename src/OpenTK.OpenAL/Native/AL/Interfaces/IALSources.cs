using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Interfaces
{
    /// <summary>
    /// Defines the public interface for the source-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IALSources
    {
        void GenSources(int count, out uint[] sources);

        void DeleteSources(int count, uint[] sources);

        bool IsSource(uint source);

        void Source(uint source, ALSourcef param, float value);

        void Source(uint source, ALSource3f param, float x, float y, float z);
    }
}
